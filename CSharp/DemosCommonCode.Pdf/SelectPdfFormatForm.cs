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
            {
                compressedCrossReferenceTable.Checked = _format.CompressedCrossReferenceTable;
            }
            else
            {
                compressedCrossReferenceTable.Checked = false;
            }
            binaryFormat.Checked = _format.BinaryFormat;
            _newEncryptionSettings = initialEncryptionSettings;
        }

        #endregion



        #region Properties

        PdfFormat _format;
        public PdfFormat Format
        {
            get
            {
                return _format;
            }
        }

        EncryptionSystem _newEncryptionSettings;
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
        /// Handles the Click event of OkButton object.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            _format = new PdfFormat(pdfVersion.SelectedItem.ToString(), compressedCrossReferenceTable.Checked, binaryFormat.Checked);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Handles the Click event of CancelButton object.
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of PdfVersion object.
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
        }

        /// <summary>
        /// Handles the Click event of SecurityButton object.
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
