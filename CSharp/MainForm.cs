using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

using DemosCommonCode;
using DemosCommonCode.Imaging;
using DemosCommonCode.Imaging.Codecs;
using DemosCommonCode.Imaging.ColorManagement;

using Vintasoft.Imaging;
using Vintasoft.Imaging.ColorManagement;
using Vintasoft.Imaging.Utils;
using Vintasoft.Imaging.Codecs.Decoders;
using Vintasoft.Imaging.Codecs.Encoders;

#if !REMOVE_PDF_PLUGIN
using DemosCommonCode.Pdf;

using Vintasoft.Imaging.Pdf;
using Vintasoft.Imaging.Pdf.Processing;



#endif
#if !REMOVE_OFFICE_PLUGIN
using Vintasoft.Imaging.Office.OpenXml;
using Vintasoft.Imaging.Office.OpenXml.Editor.Xlsx;
#endif

namespace ImageConverterDemo
{
    /// <summary>
    /// Main form of Image Converter Demo.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Fields

        /// <summary>
        /// The document converter that provides multi-threaded and most optimal alogirithm for document conversion.
        /// </summary>
        DocumentConverter _documentConverter;

        /// <summary>
        /// The names of source image files.
        /// </summary>
        List<string> _sourceFilenames = new List<string>();

        /// <summary>
        /// The name of the destination image file.
        /// </summary>
        string _destFilename = string.Empty;

        /// <summary>
        /// The image rendering settings for rendering of source files in vector format.
        /// </summary>
        RenderingSettings _renderingSettings;

        /// <summary>
        /// Conversion thread.
        /// </summary>
        Thread _conversionThread;

        /// <summary>
        /// A value indicating whether the conversion is failed.
        /// </summary>
        bool _conversionError = false;

        /// <summary>
        /// A value indicating whether the conversion is canceled.
        /// </summary>
        bool _isConversionCanceled = false;

        /// <summary>
        /// The color management settings.
        /// </summary>
        ColorManagementDecodeSettings _colorManagementDecodeSettings = null;

        /// <summary>
        /// The time when conversion is started.
        /// </summary>
        Stopwatch _conversionTime = new Stopwatch();

        /// <summary>
        /// Manages the layout settings of DOCX document image collections.
        /// </summary>
        ImageCollectionDocxLayoutSettingsManager _imageCollectionDocxLayoutSettingsManager;

        /// <summary>
        /// Manages the layout settings of XLSX document image collections.
        /// </summary>
        ImageCollectionXlsxLayoutSettingsManager _imageCollectionXlsxLayoutSettingsManager;

        /// <summary>
        /// The encoded image count.
        /// </summary>
        int _encodedImageCount = 0;

        /// <summary>
        /// The encoded image count.
        /// </summary>
        int _displayedEncodedImageCount = 0;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // register the evaluation license for VintaSoft Imaging .NET SDK
            Vintasoft.Imaging.ImagingGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");

            InitializeComponent();

            Jbig2AssemblyLoader.Load();
            Jpeg2000AssemblyLoader.Load();
            RawAssemblyLoader.Load();
            DicomAssemblyLoader.Load();
            PdfAssemblyLoader.Load();
            PdfAnnotationsAssemblyLoader.Load();
            DocxAssemblyLoader.Load();
            PdfOfficeAssemblyLoader.Load();

            // set CustomFontProgramsController for all opened documents
            CustomFontProgramsController.SetDefaultFontProgramsController();

            // set application's title
            Text = string.Format("VintaSoft Image Converter Demo v{0}", ImagingGlobalSettings.ProductVersion);

            // set the initial directory in open dialog
            DemosTools.SetTestFilesFolder(openFileDialog1);

            // allow to select multiple files in open file dialog
            openFileDialog1.Multiselect = true;

            // set filters in open dialog
            CodecsFileFilters.SetOpenFileDialogFilter(openFileDialog1);
            CodecsFileFilters.SetSaveFileDialogFilter(saveFileDialog1, false, false);

#if !REMOVE_OFFICE_PLUGIN && !REMOVE_PDF_PLUGIN
            // if DOCX encoder is available
            if (AvailableEncoders.IsEncoderAvailable("Docx"))
            {
                saveFileDialog1.Filter += "|" + "DOCX files|*.docx";
                saveFileDialog1.Filter += "|" + "HTML files|*.html;*.htm";
            }
#endif

            // set color management decoding settings
            _colorManagementDecodeSettings = new ColorManagementDecodeSettings();
            ColorManagementHelper.InitColorManagement(_colorManagementDecodeSettings);

            // create progress action handler
            ProgressBarActionHandler progressActionHandler = new ProgressBarActionHandler(totalProgressBar, progressLabel);
            progressActionHandler.ProgressUpdated += ProgressActionHandler_ProgressUpdated;

            // create document converter
            _documentConverter = new DocumentConverter();
            _documentConverter.ImageConversionFinished += documentConverter_ImageConversionFinished;
            _documentConverter.ProgressController = new ActionProgressController(progressActionHandler);

            // enable file authentication for image collection
            DocumentPasswordForm.EnableAuthentication(_documentConverter.Images);

            // set default rendering settings
#if REMOVE_PDF_PLUGIN && REMOVE_OFFICE_PLUGIN
            _renderingSettings = RenderingSettings.Empty;
#elif REMOVE_OFFICE_PLUGIN
            _renderingSettings = new PdfRenderingSettings();
#elif REMOVE_PDF_PLUGIN
            _renderingSettings = new CompositeRenderingSettings(
                new DocxRenderingSettings(),
                new XlsxRenderingSettings());
#else
            _renderingSettings = new CompositeRenderingSettings(
                new PdfRenderingSettings(),
                new DocxRenderingSettings(),
                new XlsxRenderingSettings());
#endif

#if !REMOVE_OFFICE_PLUGIN
            // specify that image collection of image viewer must handle layout settings requests
            _imageCollectionDocxLayoutSettingsManager = new ImageCollectionDocxLayoutSettingsManager(_documentConverter.Images);
            _imageCollectionXlsxLayoutSettingsManager = new ImageCollectionXlsxLayoutSettingsManager(_documentConverter.Images);
#else
            layoutSettingsToolStripMenuItem.Visible = false;
#endif

        }

        /// <summary>
        /// Handles the ProgressUpdated event of the ProgressActionHandler.
        /// </summary>
        private void ProgressActionHandler_ProgressUpdated(object sender, EventArgs e)
        {
            if (_encodedImageCount != _displayedEncodedImageCount)
            {
                _displayedEncodedImageCount = _encodedImageCount;
                logTextBox.AppendText(string.Format("Conversion is in progress: {0} pages converted, elapsed {1} ms{2}",
                    _displayedEncodedImageCount, _conversionTime.ElapsedMilliseconds, Environment.NewLine));
            }
        }

        #endregion



        #region Methods

        #region UI

        #region Main form

        /// <summary>
        /// Handles the SizeChanged event of MainForm object.
        /// </summary>
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            totalProgressBar.Maximum = totalProgressBar.Width - 2;
        }

        #endregion


        #region 'File' menu

        /// <summary>
        /// Handles the Click event of exitToolStripMenuItem object.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_conversionThread == null || !_conversionThread.IsAlive)
                Application.Exit();
        }

        #endregion


        #region 'Settings' menu

        /// <summary>
        /// Handles the Click event of colorManagementDecodeSettingsToolStripMenuItem object.
        /// </summary>
        private void colorManagementDecodeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create and show dialog that allows to set color management decode settings
            using (ColorManagementSettingsForm dialog = new ColorManagementSettingsForm())
            {
                if (_colorManagementDecodeSettings != null)
                    dialog.ColorManagementSettings = _colorManagementDecodeSettings;

                if (dialog.ShowDialog() == DialogResult.OK)
                    _colorManagementDecodeSettings = dialog.ColorManagementSettings;
            }
        }

        /// <summary>
        /// Handles the Click event of renderingSettingsToolStripMenuItem object.
        /// </summary>
        private void renderingSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create and show dialog that allows to set rendering settings
            using (CompositeRenderingSettingsForm renderingSettingsDialog = new CompositeRenderingSettingsForm(_renderingSettings))
            {
                renderingSettingsDialog.ShowDialog();
            }
        }

        /// <summary>
        /// Handles the Click event of docxToolStripMenuItem object.
        /// </summary>
        private void docxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // edit DOCX document layout settings
            _imageCollectionDocxLayoutSettingsManager.EditLayoutSettingsUseDialog();
        }

        /// <summary>
        /// Handles the Click event of xlsxToolStripMenuItem object.
        /// </summary>
        private void xlsxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // edit XLSX document layout settings
            _imageCollectionXlsxLayoutSettingsManager.EditLayoutSettingsUseDialog();
        }

        /// <summary>
        /// Handles the Click event of maxThreadsToolStripMenuItem object.
        /// </summary>
        private void maxThreadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create and show a dialog that allows to change the maximum 
            // nubmer of threads, which can be used for image rendering
            using (MaxThreadsForm maxThreadsDialog = new MaxThreadsForm())
            {
                maxThreadsDialog.Text = "DocumentConverter.MaxThreads";
                maxThreadsDialog.MaxThreads = _documentConverter.MaxThreads;

                if (maxThreadsDialog.ShowDialog() == DialogResult.OK)
                    _documentConverter.MaxThreads = maxThreadsDialog.MaxThreads;
            }
        }

        #endregion


        #region 'Help' menu

        /// <summary>
        /// Handles the Click event of aboutToolStripMenuItem object.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBoxForm dlg = new AboutBoxForm())
            {
                dlg.ShowDialog();
            }
        }

        #endregion


        #region File manipulations

        /// <summary>
        /// Handles the Click event of addSourceFilesButton object.
        /// </summary>
        private void addSourceFilesButton_Click(object sender, EventArgs e)
        {
            // show open file dialog
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            string[] filenames = openFileDialog1.FileNames;
            // add selected files to the list box with source files
            _sourceFilenames.AddRange(filenames);
            sourceFilenamesListBox.Items.AddRange(filenames);
        }

        /// <summary>
        /// Handles the Click event of removeSourceFileButton object.
        /// </summary>
        private void removeSourceFileButton_Click(object sender, EventArgs e)
        {
            // if source files list box has selected source file
            if (sourceFilenamesListBox.SelectedIndex != -1)
            {
                string removingSourceFile = (string)sourceFilenamesListBox.SelectedItem;
                // remove selected source file from lists
                _sourceFilenames.Remove(removingSourceFile);
                sourceFilenamesListBox.Items.Remove(sourceFilenamesListBox.SelectedItem);
            }
        }

        /// <summary>
        /// Handles the Click event of clearSourceFilesButton object.
        /// </summary>
        private void clearSourceFilesButton_Click(object sender, EventArgs e)
        {
            // remove all source files
            sourceFilenamesListBox.Items.Clear();
            _sourceFilenames.Clear();
        }

        /// <summary>
        /// Handles the Click event of destFileButton object.
        /// </summary>
        private void destFileButton_Click(object sender, EventArgs e)
        {
            _destFilename = string.Empty;
            if (_sourceFilenames.Count > 0)
                saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(_sourceFilenames[0]);

            // get the initial filter from "Save" dialog
            string initialSaveDialogFilter = saveFileDialog1.Filter;

            // if only one source file specified
            if (_sourceFilenames.Count == 1)
            {
#if !REMOVE_OFFICE_PLUGIN
                string sourceFileExtension = Path.GetExtension(_sourceFilenames[0]).ToUpperInvariant();

                // if the source file extension is XLS
                if (sourceFileExtension == ".XLS" ||
                    sourceFileExtension == ".TSV" || sourceFileExtension == ".TAB" ||
                    sourceFileExtension == ".CSV" ||
                    sourceFileExtension == ".ODS")
                {
                    // set a new filter with an option to save to XLSX file
                    saveFileDialog1.Filter = string.Format("{0}|{1}", saveFileDialog1.Filter, "XLSX files|*.xlsx");
                }

                // if the source file extension is XLSX
                if (sourceFileExtension == ".XLSX")
                {
                    // set a new filter with an option to save to XLSX file
                    saveFileDialog1.Filter = string.Format("{0}|{1}", saveFileDialog1.Filter, "TSV files|*.tsv|CSV files|*.csv");
                }
#endif
            }

            // show save file dialog
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _destFilename = saveFileDialog1.FileName;
                destFilenameTextBox.Text = _destFilename;
            }

            // restore initial dialog filter
            saveFileDialog1.Filter = initialSaveDialogFilter;
        }

        /// <summary>
        /// Handles the TextChanged event of destFilenameTextBox object.
        /// </summary>
        private void destFilenameTextBox_TextChanged(object sender, EventArgs e)
        {
            bool isMultipage = false;

            // try to create an encoder for filename
            using (EncoderBase encoder = AvailableEncoders.CreateEncoder(destFilenameTextBox.Text))
            {
                // if encoder is created
                if (encoder != null)
                {
                    // check if encoder is multipage encoder
                    isMultipage = encoder is MultipageEncoderBase;
#if !REMOVE_OFFICE_PLUGIN
                    // if encoder is DOCX or XLSX encoder
                    if (encoder is DocxEncoder || encoder is XlsxEncoder)
                    {
                        multipageCheckBox.Checked = true;
                        multipageCheckBox.Enabled = false;
                        return;
                    }
#endif
                }
            }

            // enable or disable multipage option
            multipageCheckBox.Checked = isMultipage;
            multipageCheckBox.Enabled = isMultipage;
        }

        #endregion


        /// <summary>
        /// Handles the Click event of convertButton object.
        /// </summary>
        private void convertButton_Click(object sender, EventArgs e)
        {
            // if conversion is not running
            if (_conversionThread == null || !_conversionThread.IsAlive)
            {
                logTextBox.Clear();
                _isConversionCanceled = false;
                totalProgressBar.Value = 0;
                progressLabel.Text = "";

                // check all parameters required for conversion

                if (_sourceFilenames.Count == 0)
                {
                    DemosTools.ShowInfoMessage("Please, add at least one source image file first.");
                    return;
                }

                _destFilename = destFilenameTextBox.Text;
                if (_destFilename == string.Empty)
                {
                    DemosTools.ShowInfoMessage("Please specify the destination image file first.");
                    return;
                }

                foreach (string sourceFilename in _sourceFilenames)
                {
                    if (sourceFilename.ToLowerInvariant() == _destFilename.ToLowerInvariant())
                    {
                        DemosTools.ShowWarningMessage("Source file names can not contain destination file name.");
                        return;
                    }
                }

                string sourceFileExtension = Path.GetExtension(_sourceFilenames[0]).ToUpperInvariant();
                string destFileExtension = Path.GetExtension(_destFilename).ToUpperInvariant();

#if !REMOVE_OFFICE_PLUGIN
                // if converting DOC to DOCX or XLS to XLSX
                if (destFileExtension == ".DOCX" || destFileExtension == ".XLSX")
                {
                    _conversionThread = null;

                    if (_sourceFilenames.Count == 1)
                    {
                        // choose a conversion type
                        if (sourceFileExtension == ".DOC" && destFileExtension == ".DOCX")
                            _conversionThread = new Thread(ConvertDocToDocxThread);
                        else if (sourceFileExtension == ".RTF" && destFileExtension == ".DOCX")
                            _conversionThread = new Thread(ConvertRtfToDocxThread);
                        else if ((sourceFileExtension == ".HTM" || sourceFileExtension == ".HTML") &&
                             destFileExtension == ".DOCX")
                            _conversionThread = new Thread(ConvertHtmlToDocxThread);
                        else if (sourceFileExtension == ".ODT" && destFileExtension == ".DOCX")
                            _conversionThread = new Thread(ConvertOdtToDocxThread);
                        else if (sourceFileExtension == ".XLS" && destFileExtension == ".XLSX")
                            _conversionThread = new Thread(ConvertXlsToXlsxThread);
                        else if ((sourceFileExtension == ".TSV" || sourceFileExtension == ".TAB") &&
                             destFileExtension == ".XLSX")
                            _conversionThread = new Thread(ConvertTsvToXlsxThread);
                        else if (sourceFileExtension == ".CSV" && destFileExtension == ".XLSX")
                            _conversionThread = new Thread(ConvertCsvToXlsxThread);
                        else if (sourceFileExtension == ".ODS" && destFileExtension == ".XLSX")
                            _conversionThread = new Thread(ConvertOdsToXlsxThread);
                    }

                    if (_conversionThread != null)
                    {
                        convertButton.Text = "Cancel";
                        InvokeUpdateMainMenu(false);

                        _conversionThread.IsBackground = true;
                        // start the conversion thread
                        _conversionThread.Start();
                        return;
                    }
                    else if (destFileExtension == ".XLSX")
                        return;
                }
                // if converting XLSX to TSV
                if (sourceFileExtension == ".XLSX" &&
                    (destFileExtension == ".TSV" || destFileExtension == ".TAB"))
                {
                    if (_sourceFilenames.Count != 1)
                    {
                        DemosTools.ShowInfoMessage("For this destination file type specify exactly one source file.");
                        return;
                    }

                    _conversionThread = new Thread(ConvertXlsxToTsvThread);
                    convertButton.Text = "Cancel";
                    InvokeUpdateMainMenu(false);

                    _conversionThread.IsBackground = true;
                    // start the conversion thread
                    _conversionThread.Start();
                    return;
                }
                // if converting XLSX to CSV
                if (sourceFileExtension == ".XLSX" && destFileExtension == ".CSV")
                {
                    if (_sourceFilenames.Count != 1)
                    {
                        DemosTools.ShowInfoMessage("For this destination file type specify exactly one source file.");
                        return;
                    }

                    _conversionThread = new Thread(ConvertXlsxToCsvThread);
                    convertButton.Text = "Cancel";
                    InvokeUpdateMainMenu(false);

                    _conversionThread.IsBackground = true;
                    // start the conversion thread
                    _conversionThread.Start();
                    return;
                }
                // if converting DOCX to HTML
                if (sourceFileExtension == ".DOCX" && (destFileExtension == ".HTM" || destFileExtension == ".HTML"))
                {
                    _conversionThread = null;

                    if (_sourceFilenames.Count != 1)
                    {
                        DemosTools.ShowInfoMessage("For this destination file type specify exactly one source file.");
                        return;
                    }

                    _conversionThread = new Thread(ConvertDocxToHtmlThread);
                    convertButton.Text = "Cancel";
                    InvokeUpdateMainMenu(false);

                    _conversionThread.IsBackground = true;
                    // start the conversion thread
                    _conversionThread.Start();
                    return;
                }
#endif

#if !REMOVE_PDF_PLUGIN
                // if converting multiple files to one PDF file with multipage option selected
                if (destFileExtension == ".PDF" && _sourceFilenames.Count > 1 && multipageCheckBox.Checked)
                {
                    bool isOnlyPdfSourceFiles = true;

                    // check if all source files are PDF's
                    foreach (string sourceFilename in _sourceFilenames)
                    {
                        if (Path.GetExtension(sourceFilename).ToUpperInvariant() != ".PDF")
                        {
                            isOnlyPdfSourceFiles = false;
                            break;
                        }
                    }

                    // if all source files are PDF files
                    if (isOnlyPdfSourceFiles)
                    {
                        // create thread to merge all PDF files into one PDF file
                        _conversionThread = new Thread(MergePdfFiles);

                        convertButton.Text = "Cancel";
                        InvokeUpdateMainMenu(false);

                        _conversionThread.IsBackground = true;
                        // start the conversion thread
                        _conversionThread.Start();
                        return;
                    }
                }
#endif

                EncoderBase encoder = null;

                try
                {
                    PluginsEncoderFactory encoderFactory = new PluginsEncoderFactory();
                    encoderFactory.DialogStartPosition = FormStartPosition.CenterScreen;

                    // if encoder for specified file name is not found
                    if (!encoderFactory.GetEncoder(_destFilename, out encoder))
                    {
                        return;
                    }
                }
                catch
                {
                }

                // if encoder is not found
                if (encoder == null)
                {
                    DemosTools.ShowErrorMessage(string.Format("Cannot find encoder for extension '{0}'.", Path.GetExtension(_destFilename)));
                    return;
                }

                // if encoder supports saving of Vintasoft binary annotations
                if ((encoder.SupportedAnnotationsFormat & AnnotationsFormat.VintasoftBinary) != 0)
                {
                    // specify that encoder must save annotations in Vintasoft binary annotations
                    encoder.AnnotationsFormat = AnnotationsFormat.VintasoftBinary;
                }

                convertButton.Text = "Cancel";
                InvokeUpdateMainMenu(false);

                _conversionThread = new Thread(ConvertImageFileThread);
                _conversionThread.IsBackground = true;
                // start the conversion thread
                _conversionThread.Start(encoder);

            }
            // if conversion is running now
            else
            {
                // disable the UI
                InvokeUpdateConvertButton(false);
                InvokeUpdateMainMenu(false);
                // cancel conversion
                _documentConverter.CancelConversion();
                _isConversionCanceled = true;
                AppendLogMessage("Conversion canceling...");
            }
        }

        #endregion


        #region UI state

        /// <summary>
        /// Updates the "Convert" button safely.
        /// </summary>
        /// <param name="enableButton">Indicates whether to enable or disable the button.</param>
        private void InvokeUpdateConvertButton(bool enableButton)
        {
            if (InvokeRequired)
                Invoke(new InvokeUpdateConvertButtonDelegate(UpdateConvertButton), enableButton);
            else
                UpdateConvertButton(enableButton);
        }

        /// <summary>
        /// Updates the "Convert" button not safely.
        /// </summary>
        /// <param name="enableButton">Indicates whether to enable or disable the button.</param>
        private void UpdateConvertButton(bool enableButton)
        {
            convertButton.Enabled = enableButton;
            if (enableButton)
                convertButton.Text = "Convert";
            else
                convertButton.Text = "Cancelling...";
        }

        /// <summary>
        /// Updates the button safely.
        /// </summary>
        /// <param name="button">Button.</param>
        /// <param name="enableButton">Indicates whether to enable or disable the button.</param>
        private void InvokeUpdateButton(Button button, bool enableButton)
        {
            if (InvokeRequired)
                Invoke(new InvokeUpdateButtonDelegate(UpdateButton), button, enableButton);
            else
                UpdateButton(button, enableButton);
        }

        /// <summary>
        /// Updates the button not safely.
        /// </summary>
        /// <param name="button">Button.</param>
        /// <param name="enableButton">Indicates whether to enable or disable the button.</param>
        private void UpdateButton(Button button, bool enableButton)
        {
            button.Enabled = enableButton;
        }

        /// <summary>
        /// Updates the main menu safely.
        /// </summary>
        /// <param name="enableMenu">Indicates whether to enable or disable the main menu.</param>
        private void InvokeUpdateMainMenu(bool enableMenu)
        {
            if (InvokeRequired)
                Invoke(new InvokeUpdateMainMenuDelegate(UpdateMainMenu), enableMenu);
            else
                UpdateMainMenu(enableMenu);
        }

        /// <summary>
        /// Updates the main menu not safely.
        /// </summary>
        /// <param name="enableMenu">Indicates whether to enable or disable the main menu.</param>
        private void UpdateMainMenu(bool enableMenu)
        {
            fileToolStripMenuItem.Enabled = enableMenu;
            settingsToolStripMenuItem.Enabled = enableMenu;
        }

        /// <summary>
        /// Appends a log message safely.
        /// </summary>
        /// <param name="text">Message text.</param>
        private void InvokeLogMessage(string text)
        {
            if (InvokeRequired)
                BeginInvoke(new InvokeLogMessageDelegate(InvokeLogMessage), text);
            else
                AppendLogMessage(text);
        }

        /// <summary>
        /// Appends a log message not safely.
        /// </summary>
        /// <param name="text">Message text.</param>
        private void AppendLogMessage(string text)
        {
            logTextBox.AppendText(text + Environment.NewLine);
            logTextBox.ScrollToCaret();
        }

        #endregion


        #region Conversion

        /// <summary>
        /// A thread method that converts an image file.
        /// </summary>
        /// <param name="obj">The object with conversion parameters.</param>
        private void ConvertImageFileThread(object obj)
        {
            try
            {
                // get encoder from parameters
                EncoderBase encoder = (EncoderBase)obj;

                InvokeLogMessage("Parsing source files...");

                OnConversionStarting();

                ImageCollection images = _documentConverter.Images;

                // add images from the source image files to the image collection
                foreach (string sourceFilename in _sourceFilenames)
                {
                    images.Add(sourceFilename);
                }

                // if conversion was canceled while adding images
                if (_isConversionCanceled)
                    return;

                if (images.Count == 0)
                {
                    DemosTools.ShowErrorMessage("Images has no pages.");
                    return;
                }

                InvokeLogMessage(string.Format("Parsed {0} pages, {1} ms.", images.Count, _conversionTime.ElapsedMilliseconds));

                // if current decoder is a vector decoder
                if (HasVectorImages(images))
                {
                    // set rendering settings to image collection
                    _documentConverter.Images.SetRenderingSettings(_renderingSettings);
                }
                // if color managent decode settings are specified
                if (_colorManagementDecodeSettings != null)
                {
                    // set these settings to every image in collection
                    foreach (VintasoftImage image in _documentConverter.Images)
                    {
                        if (image.DecodingSettings == null)
                            image.DecodingSettings = new DecodingSettings();

                        image.DecodingSettings.ColorManagement = _colorManagementDecodeSettings;
                    }
                }

                // indicates whether to save image collection as multipage
                // file or save every image of collection to singlepage file
                bool isMultipageDestFile = multipageCheckBox.Checked;

                string destFilename = _destFilename;

                // if output file is not multipage and source has many images
                if (!isMultipageDestFile && images.Count > 1)
                {
                    // add page number to file name format string
                    destFilename = Path.Combine(Path.GetDirectoryName(destFilename), Path.GetFileNameWithoutExtension(destFilename) + "-{ImageNumber}" + Path.GetExtension(destFilename));
                    InvokeLogMessage("Destination filename changed to:");
                    InvokeLogMessage(destFilename);
                }

                _encodedImageCount = 0;
                _displayedEncodedImageCount = 0;

                InvokeLogMessage("Conversion....");

                // start the conversion
                _documentConverter.Convert(destFilename, encoder, isMultipageDestFile);
            }
            catch (Exception e)
            {
                InvokeLogMessage(string.Format("Error {0}: {1}", e.GetType(), e.Message));
                DemosTools.ShowErrorMessage(e);
                _conversionError = true;
            }
            finally
            {
                _documentConverter.Images.ClearAndDisposeItems();

                OnConversionFinish();
            }
        }

#if !REMOVE_OFFICE_PLUGIN
        /// <summary>
        /// A thread method that converts a XLSX file to a CSV/TSV file.
        /// </summary>
        /// <param name="inputFileName">The filename of input XLSX document.</param>
        /// <param name="outputFilename">The filename of output CSV/TSV file.</param>
        private void ConvertXlsxToTsvCsv(string inputFileName, string outputFilename)
        {
            int worksheetCount = 0;
            using (XlsxDocumentEditor editor = new XlsxDocumentEditor(inputFileName))
                worksheetCount = editor.Sheets.Length;

            bool isCsv = false;
            if (string.Equals(Path.GetExtension(outputFilename), ".CSV", StringComparison.InvariantCultureIgnoreCase))
                isCsv = true;

            string destFilename = outputFilename;

            for (int worksheetIndex = 0; worksheetIndex < worksheetCount; worksheetIndex++)
            {
                if (worksheetCount > 1)
                {
                    // add page number to file name format string
                    destFilename = Path.Combine(Path.GetDirectoryName(outputFilename), Path.GetFileNameWithoutExtension(outputFilename) + "-" + worksheetIndex.ToString() + Path.GetExtension(outputFilename));
                    InvokeLogMessage("Destination filename changed to:");
                    InvokeLogMessage(destFilename);
                }

                InvokeLogMessage("Conversion....");

                if (isCsv)
                    OpenXmlDocumentConverter.ConvertXlsxToCsv(inputFileName, worksheetIndex, destFilename, System.Text.Encoding.UTF8);
                else
                    OpenXmlDocumentConverter.ConvertXlsxToTsv(inputFileName, worksheetIndex, destFilename);
            }
        }

        /// <summary>
        /// A thread method that converts a DOC file to a DOCX file.
        /// </summary>
        private void ConvertDocToDocxThread()
        {
            try
            {
                OnConversionStarting();
                OpenXmlDocumentConverter.ConvertDocToDocx(_sourceFilenames[0], _destFilename);
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
            finally
            {
                OnConversionFinish();
            }
        }

        /// <summary>
        /// A thread method that converts a RTF file to a DOCX file.
        /// </summary>
        private void ConvertRtfToDocxThread()
        {
            try
            {
                OnConversionStarting();
                OpenXmlDocumentConverter.ConvertRtfToDocx(_sourceFilenames[0], _destFilename);
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
            finally
            {
                OnConversionFinish();
            }
        }

        /// <summary>
        /// A thread method that converts a HTML file to a DOCX file.
        /// </summary>
        private void ConvertHtmlToDocxThread()
        {
            try
            {
                OnConversionStarting();
                OpenXmlDocumentConverter.ConvertHtmlToDocx(_sourceFilenames[0], _destFilename);
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
            finally
            {
                OnConversionFinish();
            }
        }

        /// <summary>
        /// A thread method that converts a DOCX file to a HTML file.
        /// </summary>
        private void ConvertDocxToHtmlThread()
        {
            try
            {
                OnConversionStarting();
                HtmlConverterSettings settings = new HtmlConverterSettings();
                settings.EmbedResources = true;
                OpenXmlDocumentConverter.ConvertDocxToHtml(_sourceFilenames[0], _destFilename, settings);
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
            finally
            {
                OnConversionFinish();
            }
        }

        /// <summary>
        /// A thread method that converts a ODT file to a DOCX file.
        /// </summary>
        private void ConvertOdtToDocxThread()
        {
            try
            {
                OnConversionStarting();
                OpenXmlDocumentConverter.ConvertOdtToDocx(_sourceFilenames[0], _destFilename);
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
            finally
            {
                OnConversionFinish();
            }
        }

        /// <summary>
        /// A thread method that converts an XLS file to an XLSX file.
        /// </summary>
        private void ConvertXlsToXlsxThread()
        {
            try
            {
                OnConversionStarting();
                OpenXmlDocumentConverter.ConvertXlsToXlsx(_sourceFilenames[0], _destFilename);
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
            finally
            {
                OnConversionFinish();
            }
        }

        /// <summary>
        /// A thread method that converts an XLSX file to a TSV file.
        /// </summary>
        private void ConvertXlsxToTsvThread()
        {
            try
            {
                OnConversionStarting();
                ConvertXlsxToTsvCsv(_sourceFilenames[0], _destFilename);
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
            finally
            {
                OnConversionFinish();
            }
        }

        /// <summary>
        /// A thread method that converts an XLSX file to a CSV file.
        /// </summary>
        private void ConvertXlsxToCsvThread()
        {
            try
            {
                OnConversionStarting();
                ConvertXlsxToTsvCsv(_sourceFilenames[0], _destFilename);
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
            finally
            {
                OnConversionFinish();
            }
        }

        /// <summary>
        /// A thread method that converts a TSV file to an XLSX file.
        /// </summary>
        private void ConvertTsvToXlsxThread()
        {
            try
            {
                OnConversionStarting();
                OpenXmlDocumentConverter.ConvertTsvToXlsx(_sourceFilenames[0], _destFilename);
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
            finally
            {
                OnConversionFinish();
            }
        }

        /// <summary>
        /// A thread method that converts a CSV file to an XLSX file.
        /// </summary>
        private void ConvertCsvToXlsxThread()
        {
            try
            {
                OnConversionStarting();
                OpenXmlDocumentConverter.ConvertCsvToXlsx(_sourceFilenames[0], _destFilename);
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
            finally
            {
                OnConversionFinish();
            }
        }

        /// <summary>
        /// A thread method that converts an ODS file to an XLSX file.
        /// </summary>
        private void ConvertOdsToXlsxThread()
        {
            try
            {
                OnConversionStarting();
                OpenXmlDocumentConverter.ConvertOdsToXlsx(_sourceFilenames[0], _destFilename);
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
            finally
            {
                OnConversionFinish();
            }
        }
#endif

#if !REMOVE_PDF_PLUGIN
        /// <summary>
        /// Merges multiple PDF files into one PDF file.
        /// </summary>
        private void MergePdfFiles()
        {
            try
            {
                InvokeLogMessage("Merging PDF files...");

                OnConversionStarting();

                // show a form that allows tp select PDF format
                using (SelectPdfFormatForm formatSelectionForm = new SelectPdfFormatForm(PdfFormat.Pdf_17, null))
                {
                    if (formatSelectionForm.ShowDialog() != DialogResult.OK)
                    {
                        _isConversionCanceled = true;
                        return;
                    }

                    // create destination document
                    using (PdfDocument destDocument =
                        new PdfDocument(_destFilename, FileMode.Create, FileAccess.ReadWrite, formatSelectionForm.Format, formatSelectionForm.NewEncryptionSettings))
                    {
                        // create PDF document copy command
                        PdfDocumentCopyCommand pdfCopyCommand = new PdfDocumentCopyCommand(destDocument);

                        // show a form that allows to set the command properties
                        using (PropertyGridForm commandPropertiesForm = new PropertyGridForm(pdfCopyCommand, "PDF Document Copy Command Properties", true))
                        {
                            commandPropertiesForm.StartPosition = FormStartPosition.CenterScreen;
                            if (commandPropertiesForm.ShowDialog() != DialogResult.OK)
                            {
                                _isConversionCanceled = true;
                                return;
                            }
                        }

                        // create action progress handler and controller
                        ProgressBarActionHandler progressActionHandler = new ProgressBarActionHandler(totalProgressBar, progressLabel);
                        ActionProgressController progressController = new ActionProgressController(progressActionHandler);
                        progressController.Start(_sourceFilenames.Count, this);

                        // for all source files
                        for (int i = 0; i < _sourceFilenames.Count; i++)
                        {
                            // if conversion was canceled from the main thread
                            if (_isConversionCanceled)
                                return;

                            InvokeLogMessage("Processing " + Path.GetFileName(_sourceFilenames[i]));

                            // create PDF document
                            using (PdfDocument sourceDocument = new PdfDocument(_sourceFilenames[i]))
                            {
                                // execute copy command
                                pdfCopyCommand.Execute(sourceDocument);
                                // save document
                                destDocument.Save(_destFilename);
                                progressController.Next(true);
                            }
                        }
                        progressController.Finish();
                    }
                }
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
            finally
            {
                OnConversionFinish();
            }
        }
#endif

        /// <summary>
        /// Returns a value indicating whether image collection has vector images.
        /// </summary>
        /// <param name="images">The images.</param>
        /// <returns>
        /// <b>True</c> if image collection has vector images; otherwise, <b>false</b>.
        /// </returns>
        private bool HasVectorImages(ImageCollection images)
        {
            foreach (VintasoftImage image in images)
            {
                if (image.IsVectorImage)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// The conversion process is starting.
        /// </summary>
        private void OnConversionStarting()
        {
            // disable file selection
            InvokeUpdateButton(addSourceFilesButton, false);
            InvokeUpdateButton(removeSourceFileButton, false);
            InvokeUpdateButton(clearSourceFilesButton, false);
            InvokeUpdateButton(destFileButton, false);

            _conversionTime.Reset();
            _conversionTime.Start();
        }

        /// <summary>
        /// The conversion process is finished.
        /// </summary>
        private void OnConversionFinish()
        {
            _conversionTime.Stop();
            TimeSpan conversionTime = _conversionTime.Elapsed;

            // update UI
            InvokeUpdateConvertButton(true);
            InvokeUpdateMainMenu(true);
            InvokeUpdateButton(addSourceFilesButton, true);
            InvokeUpdateButton(removeSourceFileButton, true);
            InvokeUpdateButton(clearSourceFilesButton, true);
            InvokeUpdateButton(destFileButton, true);

            if (_conversionError)
            {
                _conversionError = false;
            }
            else if (_isConversionCanceled)
            {
                InvokeLogMessage("Conversion is canceled by user.");
            }
            else
            {
                InvokeLogMessage(string.Format("Conversion is finished successfully: {0} ms.", Math.Round(conversionTime.TotalMilliseconds)));
            }
        }

        #endregion


        #region Document Converter

        /// <summary>
        /// Handler of the DocumentConverter.ImageConversionFinished event.
        /// </summary>
        private void documentConverter_ImageConversionFinished(object sender, ImageEventArgs e)
        {
            Interlocked.Increment(ref _encodedImageCount);
        }

        #endregion

        #endregion



        #region Delegates

        delegate void InvokeUpdateProgressBarDelegate(Int32 progress);

        delegate void InvokeUpdateMainMenuDelegate(bool menuEnabled);

        delegate void InvokeLogMessageDelegate(string text);

        delegate void InvokeUpdateConvertButtonDelegate(bool buttonEnabled);

        delegate void InvokeUpdateButtonDelegate(Button button, bool buttonEnabled);

        #endregion

    }
}
