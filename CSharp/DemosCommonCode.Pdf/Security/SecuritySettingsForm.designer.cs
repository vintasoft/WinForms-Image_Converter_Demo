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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.showPasswordsCheckBox = new System.Windows.Forms.CheckBox();
            this.ownerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.permissionsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.printInLowQualityCheckBox = new System.Windows.Forms.CheckBox();
            this.assembleDocumentCheckBox = new System.Windows.Forms.CheckBox();
            this.extractTextAndGraphicsForAccessibilityCheckBox = new System.Windows.Forms.CheckBox();
            this.fillInteractiveFormFieldsCheckBox = new System.Windows.Forms.CheckBox();
            this.modifyAnnotationsCheckBox = new System.Windows.Forms.CheckBox();
            this.printInHighQualityCheckBox = new System.Windows.Forms.CheckBox();
            this.extractTextAndGraphicsCheckBox = new System.Windows.Forms.CheckBox();
            this.modifyContentsCheckBox = new System.Windows.Forms.CheckBox();
            this.dontChangeRadioButton = new System.Windows.Forms.RadioButton();
            this.noSecurityRadioButton = new System.Windows.Forms.RadioButton();
            this.passwordProtectionRadioButton = new System.Windows.Forms.RadioButton();
            this.securitySettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.securityMethodLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.passwordsGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.permissionsGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.securitySettingsGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // compatibilityModeComboBox
            // 
            this.compatibilityModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.compatibilityModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compatibilityModeComboBox.FormattingEnabled = true;
            this.compatibilityModeComboBox.Location = new System.Drawing.Point(93, 3);
            this.compatibilityModeComboBox.Name = "compatibilityModeComboBox";
            this.compatibilityModeComboBox.Size = new System.Drawing.Size(280, 21);
            this.compatibilityModeComboBox.TabIndex = 0;
            this.compatibilityModeComboBox.SelectedIndexChanged += new System.EventHandler(this.compatibilityComboBox_SelectedIndexChanged);
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.okButton.Location = new System.Drawing.Point(116, 17);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 25);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Security Method";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCancel.Location = new System.Drawing.Point(197, 17);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 25);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // passwordsGroupBox
            // 
            this.passwordsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordsGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.passwordsGroupBox.Location = new System.Drawing.Point(3, 54);
            this.passwordsGroupBox.Name = "passwordsGroupBox";
            this.passwordsGroupBox.Size = new System.Drawing.Size(370, 96);
            this.passwordsGroupBox.TabIndex = 4;
            this.passwordsGroupBox.TabStop = false;
            this.passwordsGroupBox.Text = "Document Passwords";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.showPasswordsCheckBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.ownerPasswordTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.userPasswordTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(364, 77);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Owner";
            // 
            // showPasswordsCheckBox
            // 
            this.showPasswordsCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.showPasswordsCheckBox.AutoSize = true;
            this.showPasswordsCheckBox.Location = new System.Drawing.Point(47, 56);
            this.showPasswordsCheckBox.Name = "showPasswordsCheckBox";
            this.showPasswordsCheckBox.Size = new System.Drawing.Size(107, 17);
            this.showPasswordsCheckBox.TabIndex = 4;
            this.showPasswordsCheckBox.Text = "Show Passwords";
            this.showPasswordsCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordsCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordsCheckBox_CheckedChanged);
            // 
            // ownerPasswordTextBox
            // 
            this.ownerPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ownerPasswordTextBox.Location = new System.Drawing.Point(47, 3);
            this.ownerPasswordTextBox.Name = "ownerPasswordTextBox";
            this.ownerPasswordTextBox.PasswordChar = '*';
            this.ownerPasswordTextBox.Size = new System.Drawing.Size(314, 20);
            this.ownerPasswordTextBox.TabIndex = 2;
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userPasswordTextBox.Location = new System.Drawing.Point(47, 29);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.PasswordChar = '*';
            this.userPasswordTextBox.Size = new System.Drawing.Size(314, 20);
            this.userPasswordTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "User";
            // 
            // permissionsGroupBox
            // 
            this.permissionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.permissionsGroupBox.AutoSize = true;
            this.permissionsGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.permissionsGroupBox.Location = new System.Drawing.Point(3, 156);
            this.permissionsGroupBox.Name = "permissionsGroupBox";
            this.permissionsGroupBox.Size = new System.Drawing.Size(370, 203);
            this.permissionsGroupBox.TabIndex = 5;
            this.permissionsGroupBox.TabStop = false;
            this.permissionsGroupBox.Text = "User Permissions";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.printInLowQualityCheckBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.assembleDocumentCheckBox, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.extractTextAndGraphicsForAccessibilityCheckBox, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.fillInteractiveFormFieldsCheckBox, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.modifyAnnotationsCheckBox, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.printInHighQualityCheckBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.extractTextAndGraphicsCheckBox, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.modifyContentsCheckBox, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(364, 184);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // printInLowQualityCheckBox
            // 
            this.printInLowQualityCheckBox.AutoSize = true;
            this.printInLowQualityCheckBox.Checked = true;
            this.printInLowQualityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.printInLowQualityCheckBox.Location = new System.Drawing.Point(3, 3);
            this.printInLowQualityCheckBox.Name = "printInLowQualityCheckBox";
            this.printInLowQualityCheckBox.Size = new System.Drawing.Size(116, 17);
            this.printInLowQualityCheckBox.TabIndex = 0;
            this.printInLowQualityCheckBox.Text = "Print in Low Quality";
            this.printInLowQualityCheckBox.UseVisualStyleBackColor = true;
            this.printInLowQualityCheckBox.CheckedChanged += new System.EventHandler(this.printInLowQualityCheckBox_CheckedChanged);
            // 
            // assembleDocumentCheckBox
            // 
            this.assembleDocumentCheckBox.AutoSize = true;
            this.assembleDocumentCheckBox.Checked = true;
            this.assembleDocumentCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.assembleDocumentCheckBox.Location = new System.Drawing.Point(3, 164);
            this.assembleDocumentCheckBox.Name = "assembleDocumentCheckBox";
            this.assembleDocumentCheckBox.Size = new System.Drawing.Size(123, 17);
            this.assembleDocumentCheckBox.TabIndex = 6;
            this.assembleDocumentCheckBox.Text = "Assemble Document";
            this.assembleDocumentCheckBox.UseVisualStyleBackColor = true;
            // 
            // extractTextAndGraphicsForAccessibilityCheckBox
            // 
            this.extractTextAndGraphicsForAccessibilityCheckBox.AutoSize = true;
            this.extractTextAndGraphicsForAccessibilityCheckBox.Checked = true;
            this.extractTextAndGraphicsForAccessibilityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.extractTextAndGraphicsForAccessibilityCheckBox.Location = new System.Drawing.Point(3, 72);
            this.extractTextAndGraphicsForAccessibilityCheckBox.Name = "extractTextAndGraphicsForAccessibilityCheckBox";
            this.extractTextAndGraphicsForAccessibilityCheckBox.Size = new System.Drawing.Size(230, 17);
            this.extractTextAndGraphicsForAccessibilityCheckBox.TabIndex = 7;
            this.extractTextAndGraphicsForAccessibilityCheckBox.Text = "Extract Text and Graphics (for Accessibility)";
            this.extractTextAndGraphicsForAccessibilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // fillInteractiveFormFieldsCheckBox
            // 
            this.fillInteractiveFormFieldsCheckBox.AutoSize = true;
            this.fillInteractiveFormFieldsCheckBox.Checked = true;
            this.fillInteractiveFormFieldsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fillInteractiveFormFieldsCheckBox.Location = new System.Drawing.Point(3, 141);
            this.fillInteractiveFormFieldsCheckBox.Name = "fillInteractiveFormFieldsCheckBox";
            this.fillInteractiveFormFieldsCheckBox.Size = new System.Drawing.Size(147, 17);
            this.fillInteractiveFormFieldsCheckBox.TabIndex = 4;
            this.fillInteractiveFormFieldsCheckBox.Text = "Fill Interactive Form Fields";
            this.fillInteractiveFormFieldsCheckBox.UseVisualStyleBackColor = true;
            // 
            // modifyAnnotationsCheckBox
            // 
            this.modifyAnnotationsCheckBox.AutoSize = true;
            this.modifyAnnotationsCheckBox.Checked = true;
            this.modifyAnnotationsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.modifyAnnotationsCheckBox.Location = new System.Drawing.Point(3, 118);
            this.modifyAnnotationsCheckBox.Name = "modifyAnnotationsCheckBox";
            this.modifyAnnotationsCheckBox.Size = new System.Drawing.Size(116, 17);
            this.modifyAnnotationsCheckBox.TabIndex = 5;
            this.modifyAnnotationsCheckBox.Text = "Modify Annotations";
            this.modifyAnnotationsCheckBox.UseVisualStyleBackColor = true;
            // 
            // printInHighQualityCheckBox
            // 
            this.printInHighQualityCheckBox.AutoSize = true;
            this.printInHighQualityCheckBox.Checked = true;
            this.printInHighQualityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.printInHighQualityCheckBox.Location = new System.Drawing.Point(3, 26);
            this.printInHighQualityCheckBox.Name = "printInHighQualityCheckBox";
            this.printInHighQualityCheckBox.Size = new System.Drawing.Size(116, 17);
            this.printInHighQualityCheckBox.TabIndex = 1;
            this.printInHighQualityCheckBox.Text = "Print in High Quaity";
            this.printInHighQualityCheckBox.UseVisualStyleBackColor = true;
            // 
            // extractTextAndGraphicsCheckBox
            // 
            this.extractTextAndGraphicsCheckBox.AutoSize = true;
            this.extractTextAndGraphicsCheckBox.Checked = true;
            this.extractTextAndGraphicsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.extractTextAndGraphicsCheckBox.Location = new System.Drawing.Point(3, 49);
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
            this.modifyContentsCheckBox.Location = new System.Drawing.Point(3, 95);
            this.modifyContentsCheckBox.Name = "modifyContentsCheckBox";
            this.modifyContentsCheckBox.Size = new System.Drawing.Size(102, 17);
            this.modifyContentsCheckBox.TabIndex = 2;
            this.modifyContentsCheckBox.Text = "Modify Contents";
            this.modifyContentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // dontChangeRadioButton
            // 
            this.dontChangeRadioButton.AutoSize = true;
            this.dontChangeRadioButton.Checked = true;
            this.dontChangeRadioButton.Location = new System.Drawing.Point(8, 8);
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
            this.noSecurityRadioButton.Location = new System.Drawing.Point(8, 31);
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
            this.passwordProtectionRadioButton.Location = new System.Drawing.Point(8, 54);
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
            this.securitySettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.securitySettingsGroupBox.AutoSize = true;
            this.securitySettingsGroupBox.Controls.Add(this.tableLayoutPanel6);
            this.securitySettingsGroupBox.Enabled = false;
            this.securitySettingsGroupBox.Location = new System.Drawing.Point(8, 77);
            this.securitySettingsGroupBox.Name = "securitySettingsGroupBox";
            this.securitySettingsGroupBox.Size = new System.Drawing.Size(382, 381);
            this.securitySettingsGroupBox.TabIndex = 9;
            this.securitySettingsGroupBox.TabStop = false;
            this.securitySettingsGroupBox.Text = "Security Settings";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.securityMethodLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.compatibilityModeComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 51);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Compatibility";
            // 
            // securityMethodLabel
            // 
            this.securityMethodLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.securityMethodLabel.AutoSize = true;
            this.securityMethodLabel.Location = new System.Drawing.Point(93, 32);
            this.securityMethodLabel.Name = "securityMethodLabel";
            this.securityMethodLabel.Size = new System.Drawing.Size(105, 13);
            this.securityMethodLabel.TabIndex = 7;
            this.securityMethodLabel.Text = "securityMethodLabel";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.dontChangeRadioButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.securitySettingsGroupBox, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.noSecurityRadioButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.passwordProtectionRadioButton, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(398, 525);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.okButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonCancel, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(5, 461);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(388, 59);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.permissionsGroupBox, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.passwordsGroupBox, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(376, 362);
            this.tableLayoutPanel6.TabIndex = 11;
            // 
            // SecuritySettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(398, 525);
            this.Controls.Add(this.tableLayoutPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SecuritySettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Document Security Settings";
            this.passwordsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.permissionsGroupBox.ResumeLayout(false);
            this.permissionsGroupBox.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.securitySettingsGroupBox.ResumeLayout(false);
            this.securitySettingsGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}