using Vintasoft.Imaging.Codecs;
namespace ImageConverterDemo
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorManagementDecodeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderingSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xlsxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxThreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSourceFilesButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.sourceFileLabel = new System.Windows.Forms.Label();
            this.destFileLabel = new System.Windows.Forms.Label();
            this.destFilenameTextBox = new System.Windows.Forms.TextBox();
            this.destFileButton = new System.Windows.Forms.Button();
            this.totalProgressBar = new System.Windows.Forms.ProgressBar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.multipageCheckBox = new System.Windows.Forms.CheckBox();
            this.sourceFilenamesListBox = new System.Windows.Forms.ListBox();
            this.removeSourceFileButton = new System.Windows.Forms.Button();
            this.clearSourceFilesButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorManagementDecodeSettingsToolStripMenuItem,
            this.renderingSettingsToolStripMenuItem,
            this.layoutSettingsToolStripMenuItem,
            this.maxThreadsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // colorManagementDecodeSettingsToolStripMenuItem
            // 
            this.colorManagementDecodeSettingsToolStripMenuItem.Name = "colorManagementDecodeSettingsToolStripMenuItem";
            this.colorManagementDecodeSettingsToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.colorManagementDecodeSettingsToolStripMenuItem.Text = "Color Management Decode Settings...";
            this.colorManagementDecodeSettingsToolStripMenuItem.Click += new System.EventHandler(this.colorManagementDecodeSettingsToolStripMenuItem_Click);
            // 
            // renderingSettingsToolStripMenuItem
            // 
            this.renderingSettingsToolStripMenuItem.Name = "renderingSettingsToolStripMenuItem";
            this.renderingSettingsToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.renderingSettingsToolStripMenuItem.Text = "Rendering Settings...";
            this.renderingSettingsToolStripMenuItem.Click += new System.EventHandler(this.renderingSettingsToolStripMenuItem_Click);
            // 
            // layoutSettingsToolStripMenuItem
            // 
            this.layoutSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docxToolStripMenuItem,
            this.xlsxToolStripMenuItem});
            this.layoutSettingsToolStripMenuItem.Name = "layoutSettingsToolStripMenuItem";
            this.layoutSettingsToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.layoutSettingsToolStripMenuItem.Text = "Layout Settings...";
            // 
            // docxToolStripMenuItem
            // 
            this.docxToolStripMenuItem.Name = "docxToolStripMenuItem";
            this.docxToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.docxToolStripMenuItem.Text = "DOCX...";
            this.docxToolStripMenuItem.Click += new System.EventHandler(this.docxToolStripMenuItem_Click);
            // 
            // xlsxToolStripMenuItem
            // 
            this.xlsxToolStripMenuItem.Name = "xlsxToolStripMenuItem";
            this.xlsxToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.xlsxToolStripMenuItem.Text = "XLSX...";
            this.xlsxToolStripMenuItem.Click += new System.EventHandler(this.xlsxToolStripMenuItem_Click);
            // 
            // maxThreadsToolStripMenuItem
            // 
            this.maxThreadsToolStripMenuItem.Name = "maxThreadsToolStripMenuItem";
            this.maxThreadsToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.maxThreadsToolStripMenuItem.Text = "Max Threads...";
            this.maxThreadsToolStripMenuItem.Click += new System.EventHandler(this.maxThreadsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // addSourceFilesButton
            // 
            this.addSourceFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addSourceFilesButton.Location = new System.Drawing.Point(516, 49);
            this.addSourceFilesButton.Name = "addSourceFilesButton";
            this.addSourceFilesButton.Size = new System.Drawing.Size(60, 20);
            this.addSourceFilesButton.TabIndex = 2;
            this.addSourceFilesButton.Text = "Add";
            this.addSourceFilesButton.UseVisualStyleBackColor = true;
            this.addSourceFilesButton.Click += new System.EventHandler(this.addSourceFilesButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.convertButton.Location = new System.Drawing.Point(5, 275);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(506, 33);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FilterIndex = 4;
            this.saveFileDialog1.OverwritePrompt = false;
            // 
            // sourceFileLabel
            // 
            this.sourceFileLabel.AutoSize = true;
            this.sourceFileLabel.Location = new System.Drawing.Point(3, 31);
            this.sourceFileLabel.Name = "sourceFileLabel";
            this.sourceFileLabel.Size = new System.Drawing.Size(96, 13);
            this.sourceFileLabel.TabIndex = 4;
            this.sourceFileLabel.Text = "Source image files:";
            // 
            // destFileLabel
            // 
            this.destFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.destFileLabel.AutoSize = true;
            this.destFileLabel.Location = new System.Drawing.Point(3, 221);
            this.destFileLabel.Name = "destFileLabel";
            this.destFileLabel.Size = new System.Drawing.Size(110, 13);
            this.destFileLabel.TabIndex = 5;
            this.destFileLabel.Text = "Destination image file:";
            // 
            // destFilenameTextBox
            // 
            this.destFilenameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destFilenameTextBox.Location = new System.Drawing.Point(6, 240);
            this.destFilenameTextBox.Name = "destFilenameTextBox";
            this.destFilenameTextBox.Size = new System.Drawing.Size(427, 20);
            this.destFilenameTextBox.TabIndex = 8;
            this.destFilenameTextBox.TextChanged += new System.EventHandler(this.destFilenameTextBox_TextChanged);
            // 
            // destFileButton
            // 
            this.destFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.destFileButton.Location = new System.Drawing.Point(516, 240);
            this.destFileButton.Name = "destFileButton";
            this.destFileButton.Size = new System.Drawing.Size(60, 20);
            this.destFileButton.TabIndex = 7;
            this.destFileButton.Text = "...";
            this.destFileButton.UseVisualStyleBackColor = true;
            this.destFileButton.Click += new System.EventHandler(this.destFileButton_Click);
            // 
            // totalProgressBar
            // 
            this.totalProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalProgressBar.Enabled = false;
            this.totalProgressBar.Location = new System.Drawing.Point(6, 313);
            this.totalProgressBar.Maximum = 500;
            this.totalProgressBar.Name = "totalProgressBar";
            this.totalProgressBar.Size = new System.Drawing.Size(505, 32);
            this.totalProgressBar.TabIndex = 9;
            // 
            // progressLabel
            // 
            this.progressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(520, 323);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(36, 13);
            this.progressLabel.TabIndex = 10;
            this.progressLabel.Text = "0.00%";
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.Location = new System.Drawing.Point(6, 351);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(505, 170);
            this.logTextBox.TabIndex = 11;
            // 
            // multipageCheckBox
            // 
            this.multipageCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.multipageCheckBox.AutoSize = true;
            this.multipageCheckBox.Enabled = false;
            this.multipageCheckBox.Location = new System.Drawing.Point(444, 242);
            this.multipageCheckBox.Name = "multipageCheckBox";
            this.multipageCheckBox.Size = new System.Drawing.Size(72, 17);
            this.multipageCheckBox.TabIndex = 12;
            this.multipageCheckBox.Text = "Multipage";
            this.multipageCheckBox.UseVisualStyleBackColor = true;
            // 
            // sourceFilenamesListBox
            // 
            this.sourceFilenamesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceFilenamesListBox.FormattingEnabled = true;
            this.sourceFilenamesListBox.HorizontalScrollbar = true;
            this.sourceFilenamesListBox.IntegralHeight = false;
            this.sourceFilenamesListBox.Location = new System.Drawing.Point(5, 49);
            this.sourceFilenamesListBox.Name = "sourceFilenamesListBox";
            this.sourceFilenamesListBox.Size = new System.Drawing.Size(508, 160);
            this.sourceFilenamesListBox.TabIndex = 13;
            // 
            // removeSourceFileButton
            // 
            this.removeSourceFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeSourceFileButton.Location = new System.Drawing.Point(516, 75);
            this.removeSourceFileButton.Name = "removeSourceFileButton";
            this.removeSourceFileButton.Size = new System.Drawing.Size(60, 20);
            this.removeSourceFileButton.TabIndex = 14;
            this.removeSourceFileButton.Text = "Remove";
            this.removeSourceFileButton.UseVisualStyleBackColor = true;
            this.removeSourceFileButton.Click += new System.EventHandler(this.removeSourceFileButton_Click);
            // 
            // clearSourceFilesButton
            // 
            this.clearSourceFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearSourceFilesButton.Location = new System.Drawing.Point(516, 101);
            this.clearSourceFilesButton.Name = "clearSourceFilesButton";
            this.clearSourceFilesButton.Size = new System.Drawing.Size(60, 20);
            this.clearSourceFilesButton.TabIndex = 15;
            this.clearSourceFilesButton.Text = "Clear";
            this.clearSourceFilesButton.UseVisualStyleBackColor = true;
            this.clearSourceFilesButton.Click += new System.EventHandler(this.clearSourceFilesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 527);
            this.Controls.Add(this.clearSourceFilesButton);
            this.Controls.Add(this.removeSourceFileButton);
            this.Controls.Add(this.sourceFilenamesListBox);
            this.Controls.Add(this.multipageCheckBox);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.totalProgressBar);
            this.Controls.Add(this.destFilenameTextBox);
            this.Controls.Add(this.destFileButton);
            this.Controls.Add(this.destFileLabel);
            this.Controls.Add(this.sourceFileLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.addSourceFilesButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 477);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VintaSoft Image Converter Demo";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Button addSourceFilesButton;
		private System.Windows.Forms.Button convertButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Label sourceFileLabel;
		private System.Windows.Forms.Label destFileLabel;
		private System.Windows.Forms.TextBox destFilenameTextBox;
		private System.Windows.Forms.Button destFileButton;
		private System.Windows.Forms.ProgressBar totalProgressBar;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorManagementDecodeSettingsToolStripMenuItem;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.ToolStripMenuItem renderingSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layoutSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xlsxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxThreadsToolStripMenuItem;
        private System.Windows.Forms.CheckBox multipageCheckBox;
        private System.Windows.Forms.ListBox sourceFilenamesListBox;
        private System.Windows.Forms.Button removeSourceFileButton;
        private System.Windows.Forms.Button clearSourceFilesButton;
    }
}
