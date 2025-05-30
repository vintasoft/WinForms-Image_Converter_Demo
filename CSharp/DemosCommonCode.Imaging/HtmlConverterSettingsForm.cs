using System;
using System.Windows.Forms;

using DemosCommonCode.Imaging.Codecs.Dialogs;

using Vintasoft.Imaging.Codecs.Encoders;
using Vintasoft.Imaging.Office.OpenXml;

namespace ImageConverterDemo
{
    /// <summary>
    /// A form that allows to view and edit the HTML converter settings.
    /// </summary>
    public partial class HtmlConverterSettingsForm : Form
    {

        #region Fields

        /// <summary>
        /// The HTML converter settings.
        /// </summary>
        HtmlConverterSettings _converterSettings;

        /// <summary>
        /// The images encoding settings.
        /// </summary>
        EncoderSettings _imagesEncodingSettings;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlConverterSettingsForm"/> class.
        /// </summary>
        /// <param name="converterSettings">The HTML converter settings.</param>
        public HtmlConverterSettingsForm(HtmlConverterSettings converterSettings)
        {
            InitializeComponent();

            _converterSettings = converterSettings;

            embedResourcesCheckBox.Checked = converterSettings.EmbedResources;

            // if image encoding settings are specified
            if (converterSettings.ImagesEncodingSettings != null)
            {
                // copy image encoding settings
                _imagesEncodingSettings = (EncoderSettings)converterSettings.ImagesEncodingSettings.Clone();

                if (converterSettings.ImagesEncodingSettings is PngEncoderSettings)
                    imagesEncoderComboBox.SelectedIndex = 1;
                else if (converterSettings.ImagesEncodingSettings is GifEncoderSettings)
                    imagesEncoderComboBox.SelectedIndex = 2;
                else if (converterSettings.ImagesEncodingSettings is JpegEncoderSettings)
                    imagesEncoderComboBox.SelectedIndex = 3;
            }
            else
            {
                imagesEncoderComboBox.SelectedIndex = 0;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Handles the Click event of okButton object.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            _converterSettings.EmbedResources = embedResourcesCheckBox.Checked;
            _converterSettings.ImagesEncodingSettings = _imagesEncodingSettings;

            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of imagesEncoderComboBox object.
        /// </summary>
        private void imagesEncoderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            imagesEncodingSettingsButton.Enabled = true;

            switch (imagesEncoderComboBox.SelectedIndex)
            {
                case 0:
                    imagesEncodingSettingsButton.Enabled = false;
                    _imagesEncodingSettings = null;
                    break;

                case 1:
                    imagesEncodingSettingsButton.Enabled = true;
                    if (_converterSettings.ImagesEncodingSettings is PngEncoderSettings)
                        _imagesEncodingSettings = (EncoderSettings)_converterSettings.ImagesEncodingSettings.Clone();
                    else
                        _imagesEncodingSettings = PngEncoderSettings.Fast;
                    break;

                case 2:
                    imagesEncodingSettingsButton.Enabled = true;
                    if (_converterSettings.ImagesEncodingSettings is GifEncoderSettings)
                        _imagesEncodingSettings = (EncoderSettings)_converterSettings.ImagesEncodingSettings.Clone();
                    else
                        _imagesEncodingSettings = new GifEncoderSettings();
                    break;

                case 3:
                    imagesEncodingSettingsButton.Enabled = true;
                    if (_converterSettings.ImagesEncodingSettings is JpegEncoderSettings)
                        _imagesEncodingSettings = (EncoderSettings)_converterSettings.ImagesEncodingSettings.Clone();
                    else
                        _imagesEncodingSettings = new JpegEncoderSettings();
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Handles the Click event of imagesEncodingSettingsButton object.
        /// </summary>
        private void imagesEncodingSettingsButton_Click(object sender, EventArgs e)
        {
            Form form = null;

            if (_imagesEncodingSettings is PngEncoderSettings)
            {
                form = new PngEncoderSettingsForm();
                ((PngEncoderSettingsForm)form).EncoderSettings = (PngEncoderSettings)_imagesEncodingSettings;
            }
            else if (_imagesEncodingSettings is GifEncoderSettings)
            {
                form = new GifEncoderSettingsForm();
                ((GifEncoderSettingsForm)form).EncoderSettings = (GifEncoderSettings)_imagesEncodingSettings;
            }
            else if (_imagesEncodingSettings is JpegEncoderSettings)
            {
                form = new JpegEncoderSettingsForm();
                ((JpegEncoderSettingsForm)form).EncoderSettings = (JpegEncoderSettings)_imagesEncodingSettings;
            }
            else
            {
                throw new NotImplementedException();
            }

            using (form)
            {
                form.ShowDialog();
            }
        }

        #endregion

    }
}
