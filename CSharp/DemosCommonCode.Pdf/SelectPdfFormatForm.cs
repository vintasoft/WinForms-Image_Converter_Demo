#if REMOVE_PDF_PLUGIN
#error Remove SelectPdfFormatForm from project.
#endif

using System;
using System.Windows.Forms;

using Vintasoft.Imaging.Pdf;
using Vintasoft.Imaging.Pdf.Security;

using DemosCommonCode.Pdf.Security;

namespace DemosCommonCode.Pdf
{
    /// <summary>
    /// A form that allows to select format of PDF document.
    /// </summary>
    public partial class SelectPdfFormatForm : Form
    {

        #region Constructor

        public SelectPdfFormatForm(PdfFormat initialFormat, EncryptionSystem initialEncryptionSettings)
        {
            InitializeComponent();
            _format = initialFormat;
            pdfVersion.SelectedItem = _format.Version;
            if (pdfVersion.SelectedIndex > 4)
                compressedCrossReferenceTable.Checked = _format.CompressedCrossReferenceTable;
            else
                compressedCrossReferenceTable.Checked = false;

            if (initialFormat.VersionNumber >= 12)
                linearizedCheckBox.Checked = _format.LinearizedFormat;

            binaryFormat.Checked = _format.BinaryFormat;
            _newEncryptionSettings = initialEncryptionSettings;
        }

        #endregion



        #region Properties

        PdfFormat _format;
        /// <summary>
        /// Gets the PDF document format.
        /// </summary>
        public PdfFormat Format
        {
            get
            {
                return _format;
            }
        }

        EncryptionSystem _newEncryptionSettings;
        /// <summary>
        /// Gets the new encryption settings of PDF document.
        /// </summary>
        public EncryptionSystem NewEncryptionSettings
        {
            get
            {
                return _newEncryptionSettings;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Handles the Click event of okButton object.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            _format = new PdfFormat(pdfVersion.SelectedItem.ToString(), compressedCrossReferenceTable.Checked, binaryFormat.Checked, linearizedCheckBox.Checked);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Handles the Click event of cancelButton object.
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of pdfVersion object.
        /// </summary>
        private void pdfVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            securityButton.Enabled = pdfVersion.SelectedIndex >= 1;
            if (pdfVersion.SelectedIndex > 4)
            {
                compressedCrossReferenceTable.Checked = _format.CompressedCrossReferenceTable;
                compressedCrossReferenceTable.Enabled = true;
            }
            else
            {
                compressedCrossReferenceTable.Checked = false;
                compressedCrossReferenceTable.Enabled = false;
            }
            if (pdfVersion.SelectedIndex >= 2)
            {
                linearizedCheckBox.Checked = _format.LinearizedFormat;
                linearizedCheckBox.Enabled = true;
            }
            else
            {
                linearizedCheckBox.Checked = false;
                linearizedCheckBox.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the Click event of securityButton object.
        /// </summary>
        private void securityButton_Click(object sender, EventArgs e)
        {
            using (SecuritySettingsForm securitySettings = new SecuritySettingsForm(_newEncryptionSettings))
            {
                if (securitySettings.ShowDialog() == DialogResult.OK)
                    _newEncryptionSettings = securitySettings.NewEncryptionSettings;
            }
        }

        #endregion

    }
}
