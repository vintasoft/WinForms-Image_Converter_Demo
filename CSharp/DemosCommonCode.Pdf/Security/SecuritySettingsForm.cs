#if REMOVE_PDF_PLUGIN
#error Remove SecuritySettingsForm from project.
#endif

using System;
using System.Windows.Forms;

using Vintasoft.Imaging.Pdf.Security;
using Vintasoft.Imaging.Pdf;

namespace DemosCommonCode.Pdf.Security
{
    /// <summary>
    /// A form that allows to edit the security properties of PDF document.
    /// </summary>
    public partial class SecuritySettingsForm : Form
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySettingsForm"/> class.
        /// </summary>
        /// <param name="currentEncryptionSettings">Current encryption settings.</param>
        public SecuritySettingsForm(EncryptionSystem currentEncryptionSettings)
        {
            InitializeComponent();

            // add Adobe Acrobat compatibility modes to the combo box
            compatibilityModeComboBox.Items.Add(AdobeAcrobatCompatibilityMode.Acrobat4);
            compatibilityModeComboBox.Items.Add(AdobeAcrobatCompatibilityMode.Acrobat5);
            compatibilityModeComboBox.Items.Add(AdobeAcrobatCompatibilityMode.Acrobat6);
            compatibilityModeComboBox.Items.Add(AdobeAcrobatCompatibilityMode.Acrobat7);
            compatibilityModeComboBox.Items.Add(AdobeAcrobatCompatibilityMode.Acrobat8);
            compatibilityModeComboBox.Items.Add(AdobeAcrobatCompatibilityMode.Acrobat9);
            compatibilityModeComboBox.Items.Add(AdobeAcrobatCompatibilityMode.AcrobatX);

            UpdateUI(currentEncryptionSettings);
            _newEncryptionSettings = currentEncryptionSettings;
        }

        #endregion



        #region Properties

        EncryptionSystem _newEncryptionSettings;
        /// <summary>
        /// The encryption settings.
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
        /// Updates the user interface.
        /// </summary>
        /// <param name="currentEncryptionSettings">Current encryption settings.</param>
        private void UpdateUI(EncryptionSystem currentEncryptionSettings)
        {
            if (currentEncryptionSettings == null)
            {
                dontChangeRadioButton.Text = "Don't Change (No Security)";
                securityMethodLabel.Text = "";
                compatibilityModeComboBox.SelectedIndex = -1;
            }
            else
            {
                dontChangeRadioButton.Text = string.Format("Don't Change ({0})", currentEncryptionSettings);
                compatibilityModeComboBox.SelectedItem = currentEncryptionSettings.CompatibilityMode;
                ShowSecurityMethodByCompatibility(currentEncryptionSettings.CompatibilityMode);
            }
            userPasswordTextBox.Clear();
            ownerPasswordTextBox.Clear();

            if (currentEncryptionSettings != null)
            {
                // get user access permissions
                UserAccessPermissions permissions = currentEncryptionSettings.UserPermissions;
                // show user access permissions
                if ((permissions & UserAccessPermissions.AssembleDocument) == 0)
                    assembleDocumentCheckBox.Checked = false;
                else
                    assembleDocumentCheckBox.Checked = true;

                if ((permissions & UserAccessPermissions.ExtractTextAndGraphics) == 0)
                    extractTextAndGraphicsCheckBox.Checked = false;
                else
                    extractTextAndGraphicsCheckBox.Checked = true;

                if ((permissions & UserAccessPermissions.ExtractTextAndGraphicsForAccessibility) == 0)
                    extractTextAndGraphicsForAccessibilityCheckBox.Checked = false;
                else
                    extractTextAndGraphicsForAccessibilityCheckBox.Checked = true;

                if ((permissions & UserAccessPermissions.FillInteractiveFormFields) == 0)
                    fillInteractiveFormFieldsCheckBox.Checked = false;
                else
                    fillInteractiveFormFieldsCheckBox.Checked = true;

                if ((permissions & UserAccessPermissions.ModifyAnnotations) == 0)
                    modifyAnnotationsCheckBox.Checked = false;
                else
                    modifyAnnotationsCheckBox.Checked = true;

                if ((permissions & UserAccessPermissions.ModifyContents) == 0)
                    modifyContentsCheckBox.Checked = false;
                else
                    modifyContentsCheckBox.Checked = true;

                if ((permissions & UserAccessPermissions.PrintDocumentInLowResolution) == 0)
                    printInLowQualityCheckBox.Checked = false;
                else
                    printInLowQualityCheckBox.Checked = true;

                if ((permissions & UserAccessPermissions.PrintDocumentInHighResolution) == 0)
                    printInHighQualityCheckBox.Checked = false;
                else
                    printInHighQualityCheckBox.Checked = true;
            }
        }

        /// <summary>
        /// Print in low quality check box check state is changed.
        /// </summary>
        private void printInLowQualityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            printInHighQualityCheckBox.Enabled = printInLowQualityCheckBox.Checked;
            if (!printInHighQualityCheckBox.Enabled)
                printInHighQualityCheckBox.Checked = false;
        }

        /// <summary>
        /// "OK" button is clicked.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (noSecurityRadioButton.Checked)
                {
                    _newEncryptionSettings = null;
                }
                else if (passwordProtectionRadioButton.Checked)
                {
                    // if both password boxes are empty
                    if (ownerPasswordTextBox.Text == "" && userPasswordTextBox.Text == "")
                    {
                        DemosTools.ShowErrorMessage("Please, enter the owner and/or user password!");
                        ownerPasswordTextBox.Focus();
                        return;
                    }

                    // set the user access permissions
                    UserAccessPermissions accessPermissions = UserAccessPermissions.None;
                    if (printInLowQualityCheckBox.Checked)
                        accessPermissions |= UserAccessPermissions.PrintDocumentInLowResolution;
                    if (printInHighQualityCheckBox.Checked)
                        accessPermissions |= UserAccessPermissions.PrintDocumentInHighResolution;
                    if (extractTextAndGraphicsCheckBox.Checked)
                        accessPermissions |= UserAccessPermissions.ExtractTextAndGraphics;
                    if (extractTextAndGraphicsForAccessibilityCheckBox.Checked)
                        accessPermissions |= UserAccessPermissions.ExtractTextAndGraphicsForAccessibility;
                    if (modifyContentsCheckBox.Checked)
                        accessPermissions |= UserAccessPermissions.ModifyContents;
                    if (modifyAnnotationsCheckBox.Checked)
                        accessPermissions |= UserAccessPermissions.ModifyAnnotations;
                    if (fillInteractiveFormFieldsCheckBox.Checked)
                        accessPermissions |= UserAccessPermissions.FillInteractiveFormFields;
                    if (assembleDocumentCheckBox.Checked)
                        accessPermissions |= UserAccessPermissions.AssembleDocument;

                    // get the Adobe Acrobat compatibility mode
                    AdobeAcrobatCompatibilityMode compatibilityMode = (AdobeAcrobatCompatibilityMode)compatibilityModeComboBox.SelectedItem;

                    // create new encryption system
                    _newEncryptionSettings = new EncryptionSystem(
                        compatibilityMode,
                        userPasswordTextBox.Text,
                        ownerPasswordTextBox.Text,
                        accessPermissions);
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// "Cancel" button is clicked.
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Show password check box check state is changed.
        /// </summary>
        private void showPasswordsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordsCheckBox.Checked)
            {
                userPasswordTextBox.PasswordChar = '\0';
                ownerPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                userPasswordTextBox.PasswordChar = '*';
                ownerPasswordTextBox.PasswordChar = '*';
            }
        }

        /// <summary>
        /// Shows encryption algorithm according to the selected Adobe Acrobat compatibility mode.
        /// </summary>
        private void compatibilityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdobeAcrobatCompatibilityMode compatibilityMode;

            if (compatibilityModeComboBox.SelectedItem == null)
                compatibilityMode = AdobeAcrobatCompatibilityMode.Unspecified;
            else
                compatibilityMode = (AdobeAcrobatCompatibilityMode)compatibilityModeComboBox.SelectedItem;

            ShowSecurityMethodByCompatibility(compatibilityMode);
        }

        /// <summary>
        /// Shows the security method.
        /// </summary>
        /// <param name="compatibility">Adobe Acrobat compatibility mode.</param>
        private void ShowSecurityMethodByCompatibility(AdobeAcrobatCompatibilityMode compatibility)
        {
            switch (compatibility)
            {
                case AdobeAcrobatCompatibilityMode.Acrobat4:
                    securityMethodLabel.Text = "40-bit RC4 (PDF 1.1)";
                    break;
                case AdobeAcrobatCompatibilityMode.Acrobat5:
                case AdobeAcrobatCompatibilityMode.Acrobat6:
                    securityMethodLabel.Text = "128-bit RC4 (PDF 1.4)";
                    break;
                case AdobeAcrobatCompatibilityMode.Acrobat7:
                case AdobeAcrobatCompatibilityMode.Acrobat8:
                    securityMethodLabel.Text = "128-bit AES (PDF 1.6)";
                    break;
                case AdobeAcrobatCompatibilityMode.Acrobat9:
                    securityMethodLabel.Text = "256-bit AES (PDF 1.7)";
                    break;
                case AdobeAcrobatCompatibilityMode.AcrobatX:
                    securityMethodLabel.Text = "256-bit AES (PDF 2.0)";
                    break;
                default:
                    securityMethodLabel.Text = "";
                    break;
            }
        }

        /// <summary>
        /// "Don't changed" radio button checked is changed.
        /// </summary>
        private void dontChangeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dontChangeRadioButton.Checked)
            {
                securitySettingsGroupBox.Enabled = false;
            }
            UpdateUI(NewEncryptionSettings);
        }

        /// <summary>
        /// "No Security" radio button checked is changed.
        /// </summary>
        private void noSecurityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (noSecurityRadioButton.Checked)
            {
                securitySettingsGroupBox.Enabled = false;
            }
            UpdateUI(NewEncryptionSettings);
        }

        /// <summary>
        /// "Password protection" radio button checked is changed.
        /// </summary>
        private void passwordProtectionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordProtectionRadioButton.Checked)
            {
                securitySettingsGroupBox.Enabled = true;

                if (compatibilityModeComboBox.SelectedIndex == -1)
                    compatibilityModeComboBox.SelectedIndex = 0;
            }
        }

        #endregion

    }
}
