namespace ImageConverterDemo
{
    partial class HtmlConverterSettingsForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imagesEncoderComboBox = new System.Windows.Forms.ComboBox();
            this.embedResourcesCheckBox = new System.Windows.Forms.CheckBox();
            this.imagesEncodingSettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(112, 66);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(193, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // imagesEncoderComboBox
            // 
            this.imagesEncoderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagesEncoderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imagesEncoderComboBox.FormattingEnabled = true;
            this.imagesEncoderComboBox.Items.AddRange(new object[] {
            "Auto",
            "Png",
            "Gif",
            "Jpeg"});
            this.imagesEncoderComboBox.Location = new System.Drawing.Point(12, 12);
            this.imagesEncoderComboBox.Name = "imagesEncoderComboBox";
            this.imagesEncoderComboBox.Size = new System.Drawing.Size(175, 21);
            this.imagesEncoderComboBox.TabIndex = 2;
            this.imagesEncoderComboBox.SelectedIndexChanged += new System.EventHandler(this.imagesEncoderComboBox_SelectedIndexChanged);
            // 
            // embedResourcesCheckBox
            // 
            this.embedResourcesCheckBox.AutoSize = true;
            this.embedResourcesCheckBox.Location = new System.Drawing.Point(12, 39);
            this.embedResourcesCheckBox.Name = "embedResourcesCheckBox";
            this.embedResourcesCheckBox.Size = new System.Drawing.Size(113, 17);
            this.embedResourcesCheckBox.TabIndex = 3;
            this.embedResourcesCheckBox.Text = "Embed Resources";
            this.embedResourcesCheckBox.UseVisualStyleBackColor = true;
            // 
            // imagesEncodingSettingsButton
            // 
            this.imagesEncodingSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imagesEncodingSettingsButton.Location = new System.Drawing.Point(193, 12);
            this.imagesEncodingSettingsButton.Name = "imagesEncodingSettingsButton";
            this.imagesEncodingSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.imagesEncodingSettingsButton.TabIndex = 4;
            this.imagesEncodingSettingsButton.Text = "Settings";
            this.imagesEncodingSettingsButton.UseVisualStyleBackColor = true;
            this.imagesEncodingSettingsButton.Click += new System.EventHandler(this.imagesEncodingSettingsButton_Click);
            // 
            // HtmlConverterSettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 101);
            this.Controls.Add(this.imagesEncodingSettingsButton);
            this.Controls.Add(this.embedResourcesCheckBox);
            this.Controls.Add(this.imagesEncoderComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.okButton);
            this.Name = "HtmlConverterSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Html Converter Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox imagesEncoderComboBox;
        private System.Windows.Forms.CheckBox embedResourcesCheckBox;
        private System.Windows.Forms.Button imagesEncodingSettingsButton;
    }
}