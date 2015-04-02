/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 11/2/2014
 * Time: 8:46 πμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Grabada
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelAda = new System.Windows.Forms.Label();
			this.textBoxAda = new System.Windows.Forms.TextBox();
			this.buttonDownload = new System.Windows.Forms.Button();
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToProgramFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFolderSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.progressBarDownload = new System.Windows.Forms.ProgressBar();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.folderBrowserDialogSave = new System.Windows.Forms.FolderBrowserDialog();
			this.menuStripMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelAda
			// 
			this.labelAda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.labelAda.Location = new System.Drawing.Point(16, 40);
			this.labelAda.Name = "labelAda";
			this.labelAda.Size = new System.Drawing.Size(47, 23);
			this.labelAda.TabIndex = 0;
			this.labelAda.Text = "ΑΔΑ:";
			// 
			// textBoxAda
			// 
			this.textBoxAda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.textBoxAda.Location = new System.Drawing.Point(69, 37);
			this.textBoxAda.Name = "textBoxAda";
			this.textBoxAda.Size = new System.Drawing.Size(138, 26);
			this.textBoxAda.TabIndex = 1;
			this.textBoxAda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// buttonDownload
			// 
			this.buttonDownload.Image = ((System.Drawing.Image)(resources.GetObject("buttonDownload.Image")));
			this.buttonDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonDownload.Location = new System.Drawing.Point(16, 79);
			this.buttonDownload.Name = "buttonDownload";
			this.buttonDownload.Size = new System.Drawing.Size(191, 23);
			this.buttonDownload.TabIndex = 2;
			this.buttonDownload.Text = "Λήψη";
			this.buttonDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonDownload.UseVisualStyleBackColor = true;
			this.buttonDownload.Click += new System.EventHandler(this.ButtonDownloadClick);
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.optionsToolStripMenuItem,
									this.aboutToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(219, 24);
			this.menuStripMain.TabIndex = 3;
			this.menuStripMain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.fileToolStripMenuItem.Text = "&Αρχείο";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.exitToolStripMenuItem.Text = "Έ&ξοδος";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.saveToProgramFolderToolStripMenuItem,
									this.saveFolderSelectToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.optionsToolStripMenuItem.Text = "&Ρυθμίσεις";
			// 
			// saveToProgramFolderToolStripMenuItem
			// 
			this.saveToProgramFolderToolStripMenuItem.CheckOnClick = true;
			this.saveToProgramFolderToolStripMenuItem.Name = "saveToProgramFolderToolStripMenuItem";
			this.saveToProgramFolderToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
			this.saveToProgramFolderToolStripMenuItem.Text = "Αποθήκευση στον φάκελο του &προγράμματος";
			this.saveToProgramFolderToolStripMenuItem.Click += new System.EventHandler(this.SaveToProgramFolderToolStripMenuItemClick);
			// 
			// saveFolderSelectToolStripMenuItem
			// 
			this.saveFolderSelectToolStripMenuItem.CheckOnClick = true;
			this.saveFolderSelectToolStripMenuItem.Name = "saveFolderSelectToolStripMenuItem";
			this.saveFolderSelectToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
			this.saveFolderSelectToolStripMenuItem.Text = "Επι&λογή φακέλου αποθήκευσης";
			this.saveFolderSelectToolStripMenuItem.Click += new System.EventHandler(this.SaveFolderSelectToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "Περί...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// progressBarDownload
			// 
			this.progressBarDownload.Location = new System.Drawing.Point(69, 37);
			this.progressBarDownload.Name = "progressBarDownload";
			this.progressBarDownload.Size = new System.Drawing.Size(138, 26);
			this.progressBarDownload.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBarDownload.TabIndex = 4;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
			this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCancel.Location = new System.Drawing.Point(16, 79);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(191, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Ακύρωση";
			this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// MainForm
			// 
			this.AcceptButton = this.buttonDownload;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(219, 114);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.progressBarDownload);
			this.Controls.Add(this.buttonDownload);
			this.Controls.Add(this.textBoxAda);
			this.Controls.Add(this.labelAda);
			this.Controls.Add(this.menuStripMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStripMain;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "GrabΑΔΑ";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSave;
		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveFolderSelectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToProgramFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.ProgressBar progressBarDownload;
		private System.Windows.Forms.Button buttonDownload;
		private System.Windows.Forms.TextBox textBoxAda;
		private System.Windows.Forms.Label labelAda;
	}
}
