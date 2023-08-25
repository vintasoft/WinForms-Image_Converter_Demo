namespace DemosCommonCode.Pdf
{
    partial class SelectPdfFormatForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.securityButton = new System.Windows.Forms.Button();
            this.binaryFormat = new System.Windows.Forms.CheckBox();
            this.compressedCrossReferenceTable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pdfVersion = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(141, 132);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(60, 132);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 27);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.securityButton);
            this.panel1.Controls.Add(this.binaryFormat);
            this.panel1.Controls.Add(this.compressedCrossReferenceTable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pdfVersion);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 114);
            this.panel1.TabIndex = 4;
            // 
            // securityButton
            // 
            this.securityButton.Location = new System.Drawing.Point(47, 31);
            this.securityButton.Name = "securityButton";
            this.securityButton.Size = new System.Drawing.Size(107, 23);
            this.securityButton.TabIndex = 17;
            this.securityButton.Text = "Security Settings...";
            this.securityButton.UseVisualStyleBackColor = true;
            this.securityButton.Click += new System.EventHandler(this.securityButton_Click);
            // 
            // binaryFormat
            // 
            this.binaryFormat.AutoSize = true;
            this.binaryFormat.Checked = true;
            this.binaryFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.binaryFormat.Location = new System.Drawing.Point(3, 85);
            this.binaryFormat.Name = "binaryFormat";
            this.binaryFormat.Size = new System.Drawing.Size(90, 17);
            this.binaryFormat.TabIndex = 17;
            this.binaryFormat.Text = "Binary Format";
            this.binaryFormat.UseVisualStyleBackColor = true;
            // 
            // compressedCrossReferenceTable
            // 
            this.compressedCrossReferenceTable.AutoSize = true;
            this.compressedCrossReferenceTable.Location = new System.Drawing.Point(3, 62);
            this.compressedCrossReferenceTable.Name = "compressedCrossReferenceTable";
            this.compressedCrossReferenceTable.Size = new System.Drawing.Size(249, 17);
            this.compressedCrossReferenceTable.TabIndex = 16;
            this.compressedCrossReferenceTable.Text = "Compressed Cross-Reference Tables (PDF 1.5)";
            this.compressedCrossReferenceTable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Version";
            // 
            // pdfVersion
            // 
            this.pdfVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pdfVersion.FormattingEnabled = true;
            this.pdfVersion.Items.AddRange(new object[] {
            "1.0",
            "1.1",
            "1.2",
            "1.3",
            "1.4",
            "1.5",
            "1.6",
            "1.7",
            "2.0"});
            this.pdfVersion.Location = new System.Drawing.Point(48, 4);
            this.pdfVersion.Name = "pdfVersion";
            this.pdfVersion.Size = new System.Drawing.Size(105, 21);
            this.pdfVersion.TabIndex = 14;
            this.pdfVersion.SelectedIndexChanged += new System.EventHandler(this.pdfVersion_SelectedIndexChanged);
            // 
            // SelectPdfFormatForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(278, 163);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectPdfFormatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Document Format";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox binaryFormat;
        private System.Windows.Forms.CheckBox compressedCrossReferenceTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pdfVersion;
        private System.Windows.Forms.Button securityButton;
    }
}