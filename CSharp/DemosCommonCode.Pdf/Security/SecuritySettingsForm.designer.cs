namespace DemosCommonCode.Pdf.Security
{
    partial class SecuritySettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.compatibilityModeComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.passwordsGroupBox = new System.Windows.Forms.GroupBox();
            this.showPasswordsCheckBox = new System.Windows.Forms.CheckBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ownerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.permissionsGroupBox = new System.Windows.Forms.GroupBox();
            this.extractTextAndGraphicsForAccessibilityCheckBox = new System.Windows.Forms.CheckBox();
            this.assembleDocumentCheckBox = new System.Windows.Forms.CheckBox();
            this.modifyAnnotationsCheckBox = new System.Windows.Forms.CheckBox();
            this.fillInteractiveFormFieldsCheckBox = new System.Windows.Forms.CheckBox();
            this.extractTextAndGraphicsCheckBox = new System.Windows.Forms.CheckBox();
            this.modifyContentsCheckBox = new System.Windows.Forms.CheckBox();
            this.printInHighQualityCheckBox = new System.Windows.Forms.CheckBox();
            this.printInLowQualityCheckBox = new System.Windows.Forms.CheckBox();
            this.dontChangeRadioButton = new System.Windows.Forms.RadioButton();
            this.noSecurityRadioButton = new System.Windows.Forms.RadioButton();
            this.passwordProtectionRadioButton = new System.Windows.Forms.RadioButton();
            this.securitySettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.securityMethodLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordsGroupBox.SuspendLayout();
            this.permissionsGroupBox.SuspendLayout();
            this.securitySettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // compatibilityModeComboBox
            // 
            this.compatibilityModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compatibilityModeComboBox.FormattingEnabled = true;
            this.compatibilityModeComboBox.Location = new System.Drawing.Point(102, 16);
            this.compatibilityModeComboBox.Name = "compatibilityModeComboBox";
            this.compatibilityModeComboBox.Size = new System.Drawing.Size(174, 21);
            this.compatibilityModeComboBox.TabIndex = 0;
            this.compatibilityModeComboBox.SelectedIndexChanged += new System.EventHandler(this.compatibilityComboBox_SelectedIndexChanged);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.Location = new System.Drawing.Point(79, 472);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 25);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Security Method";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.Location = new System.Drawing.Point(160, 472);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 25);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // passwordsGroupBox
            // 
            this.passwordsGroupBox.Controls.Add(this.showPasswordsCheckBox);
            this.passwordsGroupBox.Controls.Add(this.userPasswordTextBox);
            this.passwordsGroupBox.Controls.Add(this.ownerPasswordTextBox);
            this.passwordsGroupBox.Controls.Add(this.label3);
            this.passwordsGroupBox.Controls.Add(this.label2);
            this.passwordsGroupBox.Location = new System.Drawing.Point(8, 70);
            this.passwordsGroupBox.Name = "passwordsGroupBox";
            this.passwordsGroupBox.Size = new System.Drawing.Size(274, 96);
            this.passwordsGroupBox.TabIndex = 4;
            this.passwordsGroupBox.TabStop = false;
            this.passwordsGroupBox.Text = "Document Passwords";
            // 
            // showPasswordsCheckBox
            // 
            this.showPasswordsCheckBox.AutoSize = true;
            this.showPasswordsCheckBox.Location = new System.Drawing.Point(94, 69);
            this.showPasswordsCheckBox.Name = "showPasswordsCheckBox";
            this.showPasswordsCheckBox.Size = new System.Drawing.Size(107, 17);
            this.showPasswordsCheckBox.TabIndex = 4;
            this.showPasswordsCheckBox.Text = "Show Passwords";
            this.showPasswordsCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordsCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordsCheckBox_CheckedChanged);
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Location = new System.Drawing.Point(94, 43);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.PasswordChar = '*';
            this.userPasswordTextBox.Size = new System.Drawing.Size(174, 20);
            this.userPasswordTextBox.TabIndex = 3;
            // 
            // ownerPasswordTextBox
            // 
            this.ownerPasswordTextBox.Location = new System.Drawing.Point(94, 17);
            this.ownerPasswordTextBox.Name = "ownerPasswordTextBox";
            this.ownerPasswordTextBox.PasswordChar = '*';
            this.ownerPasswordTextBox.Size = new System.Drawing.Size(174, 20);
            this.ownerPasswordTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Owner";
            // 
            // permissionsGroupBox
            // 
            this.permissionsGroupBox.Controls.Add(this.extractTextAndGraphicsForAccessibilityCheckBox);
            this.permissionsGroupBox.Controls.Add(this.assembleDocumentCheckBox);
            this.permissionsGroupBox.Controls.Add(this.modifyAnnotationsCheckBox);
            this.permissionsGroupBox.Controls.Add(this.fillInteractiveFormFieldsCheckBox);
            this.permissionsGroupBox.Controls.Add(this.extractTextAndGraphicsCheckBox);
            this.permissionsGroupBox.Controls.Add(this.modifyContentsCheckBox);
            this.permissionsGroupBox.Controls.Add(this.printInHighQualityCheckBox);
            this.permissionsGroupBox.Controls.Add(this.printInLowQualityCheckBox);
            this.permissionsGroupBox.Location = new System.Drawing.Point(8, 172);
            this.permissionsGroupBox.Name = "permissionsGroupBox";
            this.permissionsGroupBox.Size = new System.Drawing.Size(274, 204);
            this.permissionsGroupBox.TabIndex = 5;
            this.permissionsGroupBox.TabStop = false;
            this.permissionsGroupBox.Text = "User Permissions";
            // 
            // extractTextAndGraphicsForAccessibilityCheckBox
            // 
            this.extractTextAndGraphicsForAccessibilityCheckBox.AutoSize = true;
            this.extractTextAndGraphicsForAccessibilityCheckBox.Checked = true;
            this.extractTextAndGraphicsForAccessibilityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.extractTextAndGraphicsForAccessibilityCheckBox.Location = new System.Drawing.Point(14, 88);
            this.extractTextAndGraphicsForAccessibilityCheckBox.Name = "extractTextAndGraphicsForAccessibilityCheckBox";
            this.extractTextAndGraphicsForAccessibilityCheckBox.Size = new System.Drawing.Size(230, 17);
            this.extractTextAndGraphicsForAccessibilityCheckBox.TabIndex = 7;
            this.extractTextAndGraphicsForAccessibilityCheckBox.Text = "Extract Text and Graphics (for Accessibility)";
            this.extractTextAndGraphicsForAccessibilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // assembleDocumentCheckBox
            // 
            this.assembleDocumentCheckBox.AutoSize = true;
            this.assembleDocumentCheckBox.Checked = true;
            this.assembleDocumentCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.assembleDocumentCheckBox.Location = new System.Drawing.Point(14, 182);
            this.assembleDocumentCheckBox.Name = "assembleDocumentCheckBox";
            this.assembleDocumentCheckBox.Size = new System.Drawing.Size(123, 17);
            this.assembleDocumentCheckBox.TabIndex = 6;
            this.assembleDocumentCheckBox.Text = "Assemble Document";
            this.assembleDocumentCheckBox.UseVisualStyleBackColor = true;
            // 
            // modifyAnnotationsCheckBox
            // 
            this.modifyAnnotationsCheckBox.AutoSize = true;
            this.modifyAnnotationsCheckBox.Checked = true;
            this.modifyAnnotationsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.modifyAnnotationsCheckBox.Location = new System.Drawing.Point(14, 136);
            this.modifyAnnotationsCheckBox.Name = "modifyAnnotationsCheckBox";
            this.modifyAnnotationsCheckBox.Size = new System.Drawing.Size(116, 17);
            this.modifyAnnotationsCheckBox.TabIndex = 5;
            this.modifyAnnotationsCheckBox.Text = "Modify Annotations";
            this.modifyAnnotationsCheckBox.UseVisualStyleBackColor = true;
            // 
            // fillInteractiveFormFieldsCheckBox
            // 
            this.fillInteractiveFormFieldsCheckBox.AutoSize = true;
            this.fillInteractiveFormFieldsCheckBox.Checked = true;
            this.fillInteractiveFormFieldsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fillInteractiveFormFieldsCheckBox.Location = new System.Drawing.Point(14, 159);
            this.fillInteractiveFormFieldsCheckBox.Name = "fillInteractiveFormFieldsCheckBox";
            this.fillInteractiveFormFieldsCheckBox.Size = new System.Drawing.Size(147, 17);
            this.fillInteractiveFormFieldsCheckBox.TabIndex = 4;
            this.fillInteractiveFormFieldsCheckBox.Text = "Fill Interactive Form Fields";
            this.fillInteractiveFormFieldsCheckBox.UseVisualStyleBackColor = true;
            // 
            // extractTextAndGraphicsCheckBox
            // 
            this.extractTextAndGraphicsCheckBox.AutoSize = true;
            this.extractTextAndGraphicsCheckBox.Checked = true;
            this.extractTextAndGraphicsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.extractTextAndGraphicsCheckBox.Location = new System.Drawing.Point(14, 65);
            this.extractTextAndGraphicsCheckBox.Name = "extractTextAndGraphicsCheckBox";
            this.extractTextAndGraphicsCheckBox.Size = new System.Drawing.Size(149, 17);
            this.extractTextAndGraphicsCheckBox.TabIndex = 3;
            this.extractTextAndGraphicsCheckBox.Text = "Extract Text and Graphics";
            this.extractTextAndGraphicsCheckBox.UseVisualStyleBackColor = true;
            // 
            // modifyContentsCheckBox
            // 
            this.modifyContentsCheckBox.AutoSize = true;
            this.modifyContentsCheckBox.Checked = true;
            this.modifyContentsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.modifyContentsCheckBox.Location = new System.Drawing.Point(14, 113);
            this.modifyContentsCheckBox.Name = "modifyContentsCheckBox";
            this.modifyContentsCheckBox.Size = new System.Drawing.Size(102, 17);
            this.modifyContentsCheckBox.TabIndex = 2;
            this.modifyContentsCheckBox.Text = "Modify Contents";
            this.modifyContentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // printInHighQualityCheckBox
            // 
            this.printInHighQualityCheckBox.AutoSize = true;
            this.printInHighQualityCheckBox.Checked = true;
            this.printInHighQualityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.printInHighQualityCheckBox.Location = new System.Drawing.Point(14, 42);
            this.printInHighQualityCheckBox.Name = "printInHighQualityCheckBox";
            this.printInHighQualityCheckBox.Size = new System.Drawing.Size(116, 17);
            this.printInHighQualityCheckBox.TabIndex = 1;
            this.printInHighQualityCheckBox.Text = "Print in High Quaity";
            this.printInHighQualityCheckBox.UseVisualStyleBackColor = true;
            // 
            // printInLowQualityCheckBox
            // 
            this.printInLowQualityCheckBox.AutoSize = true;
            this.printInLowQualityCheckBox.Checked = true;
            this.printInLowQualityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.printInLowQualityCheckBox.Location = new System.Drawing.Point(14, 19);
            this.printInLowQualityCheckBox.Name = "printInLowQualityCheckBox";
            this.printInLowQualityCheckBox.Size = new System.Drawing.Size(116, 17);
            this.printInLowQualityCheckBox.TabIndex = 0;
            this.printInLowQualityCheckBox.Text = "Print in Low Quality";
            this.printInLowQualityCheckBox.UseVisualStyleBackColor = true;
            this.printInLowQualityCheckBox.CheckedChanged += new System.EventHandler(this.printInLowQualityCheckBox_CheckedChanged);
            // 
            // dontChangeRadioButton
            // 
            this.dontChangeRadioButton.AutoSize = true;
            this.dontChangeRadioButton.Checked = true;
            this.dontChangeRadioButton.Location = new System.Drawing.Point(13, 13);
            this.dontChangeRadioButton.Name = "dontChangeRadioButton";
            this.dontChangeRadioButton.Size = new System.Drawing.Size(90, 17);
            this.dontChangeRadioButton.TabIndex = 6;
            this.dontChangeRadioButton.TabStop = true;
            this.dontChangeRadioButton.Text = "Don\'t Change";
            this.dontChangeRadioButton.UseVisualStyleBackColor = true;
            this.dontChangeRadioButton.CheckedChanged += new System.EventHandler(this.dontChangeRadioButton_CheckedChanged);
            // 
            // noSecurityRadioButton
            // 
            this.noSecurityRadioButton.AutoSize = true;
            this.noSecurityRadioButton.Location = new System.Drawing.Point(13, 37);
            this.noSecurityRadioButton.Name = "noSecurityRadioButton";
            this.noSecurityRadioButton.Size = new System.Drawing.Size(80, 17);
            this.noSecurityRadioButton.TabIndex = 7;
            this.noSecurityRadioButton.TabStop = true;
            this.noSecurityRadioButton.Text = "No Security";
            this.noSecurityRadioButton.UseVisualStyleBackColor = true;
            this.noSecurityRadioButton.CheckedChanged += new System.EventHandler(this.noSecurityRadioButton_CheckedChanged);
            // 
            // passwordProtectionRadioButton
            // 
            this.passwordProtectionRadioButton.AutoSize = true;
            this.passwordProtectionRadioButton.Location = new System.Drawing.Point(13, 61);
            this.passwordProtectionRadioButton.Name = "passwordProtectionRadioButton";
            this.passwordProtectionRadioButton.Size = new System.Drawing.Size(122, 17);
            this.passwordProtectionRadioButton.TabIndex = 8;
            this.passwordProtectionRadioButton.TabStop = true;
            this.passwordProtectionRadioButton.Text = "Password Protection";
            this.passwordProtectionRadioButton.UseVisualStyleBackColor = true;
            this.passwordProtectionRadioButton.CheckedChanged += new System.EventHandler(this.passwordProtectionRadioButton_CheckedChanged);
            // 
            // securitySettingsGroupBox
            // 
            this.securitySettingsGroupBox.Controls.Add(this.securityMethodLabel);
            this.securitySettingsGroupBox.Controls.Add(this.label4);
            this.securitySettingsGroupBox.Controls.Add(this.compatibilityModeComboBox);
            this.securitySettingsGroupBox.Controls.Add(this.label1);
            this.securitySettingsGroupBox.Controls.Add(this.passwordsGroupBox);
            this.securitySettingsGroupBox.Controls.Add(this.permissionsGroupBox);
            this.securitySettingsGroupBox.Enabled = false;
            this.securitySettingsGroupBox.Location = new System.Drawing.Point(12, 84);
            this.securitySettingsGroupBox.Name = "securitySettingsGroupBox";
            this.securitySettingsGroupBox.Size = new System.Drawing.Size(290, 382);
            this.securitySettingsGroupBox.TabIndex = 9;
            this.securitySettingsGroupBox.TabStop = false;
            this.securitySettingsGroupBox.Text = "Security Settings";
            // 
            // securityMethodLabel
            // 
            this.securityMethodLabel.AutoSize = true;
            this.securityMethodLabel.Location = new System.Drawing.Point(100, 49);
            this.securityMethodLabel.Name = "securityMethodLabel";
            this.securityMethodLabel.Size = new System.Drawing.Size(105, 13);
            this.securityMethodLabel.TabIndex = 7;
            this.securityMethodLabel.Text = "securityMethodLabel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Compatibility";
            // 
            // SecuritySettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 508);
            this.Controls.Add(this.securitySettingsGroupBox);
            this.Controls.Add(this.passwordProtectionRadioButton);
            this.Controls.Add(this.noSecurityRadioButton);
            this.Controls.Add(this.dontChangeRadioButton);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SecuritySettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Document Security Settings";
            this.passwordsGroupBox.ResumeLayout(false);
            this.passwordsGroupBox.PerformLayout();
            this.permissionsGroupBox.ResumeLayout(false);
            this.permissionsGroupBox.PerformLayout();
            this.securitySettingsGroupBox.ResumeLayout(false);
            this.securitySettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox compatibilityModeComboBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox passwordsGroupBox;
        private System.Windows.Forms.CheckBox showPasswordsCheckBox;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.TextBox ownerPasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox permissionsGroupBox;
        private System.Windows.Forms.CheckBox assembleDocumentCheckBox;
        private System.Windows.Forms.CheckBox modifyAnnotationsCheckBox;
        private System.Windows.Forms.CheckBox fillInteractiveFormFieldsCheckBox;
        private System.Windows.Forms.CheckBox extractTextAndGraphicsCheckBox;
        private System.Windows.Forms.CheckBox modifyContentsCheckBox;
        private System.Windows.Forms.CheckBox printInHighQualityCheckBox;
        private System.Windows.Forms.CheckBox printInLowQualityCheckBox;
        private System.Windows.Forms.RadioButton dontChangeRadioButton;
        private System.Windows.Forms.RadioButton noSecurityRadioButton;
        private System.Windows.Forms.RadioButton passwordProtectionRadioButton;
        private System.Windows.Forms.GroupBox securitySettingsGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label securityMethodLabel;
        private System.Windows.Forms.CheckBox extractTextAndGraphicsForAccessibilityCheckBox;
    }
}