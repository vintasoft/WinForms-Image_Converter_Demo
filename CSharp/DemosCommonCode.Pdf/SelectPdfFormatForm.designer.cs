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
            this.securityButton = new System.Windows.Forms.Button();
            this.binaryFormat = new System.Windows.Forms.CheckBox();
            this.compressedCrossReferenceTable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pdfVersion = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linearizedCheckBox = new System.Windows.Forms.CheckBox();
            this.compressedObjectStreamsCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(226, 166);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(145, 166);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 27);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // securityButton
            // 
            this.securityButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.securityButton.AutoSize = true;
            this.securityButton.Location = new System.Drawing.Point(51, 30);
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
            this.tableLayoutPanel1.SetColumnSpan(this.binaryFormat, 3);
            this.binaryFormat.Location = new System.Drawing.Point(3, 82);
            this.binaryFormat.Name = "binaryFormat";
            this.binaryFormat.Size = new System.Drawing.Size(90, 17);
            this.binaryFormat.TabIndex = 17;
            this.binaryFormat.Text = "Binary Format";
            this.binaryFormat.UseVisualStyleBackColor = true;
            // 
            // compressedCrossReferenceTable
            // 
            this.compressedCrossReferenceTable.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.compressedCrossReferenceTable, 3);
            this.compressedCrossReferenceTable.Location = new System.Drawing.Point(3, 59);
            this.compressedCrossReferenceTable.Name = "compressedCrossReferenceTable";
            this.compressedCrossReferenceTable.Size = new System.Drawing.Size(249, 17);
            this.compressedCrossReferenceTable.TabIndex = 16;
            this.compressedCrossReferenceTable.Text = "Compressed Cross-Reference Tables (PDF 1.5)";
            this.compressedCrossReferenceTable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Version";
            // 
            // pdfVersion
            // 
            this.pdfVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.pdfVersion.Location = new System.Drawing.Point(51, 3);
            this.pdfVersion.Name = "pdfVersion";
            this.pdfVersion.Size = new System.Drawing.Size(107, 21);
            this.pdfVersion.TabIndex = 14;
            this.pdfVersion.SelectedIndexChanged += new System.EventHandler(this.pdfVersion_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.compressedObjectStreamsCheckBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.binaryFormat, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.securityButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.compressedCrossReferenceTable, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pdfVersion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.linearizedCheckBox, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 152);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // linearizedCheckBox
            // 
            this.linearizedCheckBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.linearizedCheckBox, 3);
            this.linearizedCheckBox.Location = new System.Drawing.Point(3, 105);
            this.linearizedCheckBox.Name = "linearizedCheckBox";
            this.linearizedCheckBox.Size = new System.Drawing.Size(109, 17);
            this.linearizedCheckBox.TabIndex = 18;
            this.linearizedCheckBox.Text = "Linearized Format";
            this.linearizedCheckBox.UseVisualStyleBackColor = true;
            // 
            // compressedObjectStreamsCheckBox
            // 
            this.compressedObjectStreamsCheckBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.compressedObjectStreamsCheckBox, 3);
            this.compressedObjectStreamsCheckBox.Location = new System.Drawing.Point(3, 128);
            this.compressedObjectStreamsCheckBox.Name = "compressedObjectStreamsCheckBox";
            this.compressedObjectStreamsCheckBox.Size = new System.Drawing.Size(207, 17);
            this.compressedObjectStreamsCheckBox.TabIndex = 19;
            this.compressedObjectStreamsCheckBox.Text = "Compressed Object Streams (PDF 1.5)";
            this.compressedObjectStreamsCheckBox.UseVisualStyleBackColor = true;
            // 
            // SelectPdfFormatForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(310, 205);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectPdfFormatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Document Format";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.CheckBox binaryFormat;
        private System.Windows.Forms.CheckBox compressedCrossReferenceTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pdfVersion;
        private System.Windows.Forms.Button securityButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox linearizedCheckBox;
        private System.Windows.Forms.CheckBox compressedObjectStreamsCheckBox;
    }
}