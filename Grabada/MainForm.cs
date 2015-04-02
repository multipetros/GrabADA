using System ;
using System.Collections.Generic ;
using System.Drawing ;
using System.Windows.Forms ;
using System.Net ;
using System.ComponentModel ;
using System.IO ;
using System.Text.RegularExpressions ;
using Microsoft.Win32 ;

namespace Grabada{
	public partial class MainForm : Form{
		private const string ADA_URL = "http://static.diavgeia.gov.gr/doc/" ;
		private const string SAVE_LOCATION_KEY = "save_location" ;
		private string localFile ;
		private WebClient client = new WebClient() ;
		
		public MainForm(){
			InitializeComponent();
			client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
			client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
		}

		void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e){			
			progressBarDownload.Enabled = false ;
			if(e.Cancelled){
				DeleteFile(GetSaveLocation() + localFile) ;
			}
			else if(e.Error != null){
				MessageBox.Show(e.Error.Message, "Σφάλμα!", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				DeleteFile(GetSaveLocation() + localFile) ;
			}else{
				System.Media.SystemSounds.Beep.Play() ;
			}
			progressBarDownload.Value = 0 ;
			progressBarDownload.Visible = false ;
			buttonDownload.Visible = true ;
			buttonCancel.Visible = false ;
		}

		void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e){
			//progressBarDownload.Value = (int) (e.BytesReceived / e.TotalBytesToReceive * 100) ;
			progressBarDownload.Enabled = true ;
		}
		
		private void Download(string ada){
			buttonDownload.Visible = false ;
			buttonCancel.Visible = true ;
			progressBarDownload.Visible = true ;
			localFile = ada + ".pdf" ;
			client.DownloadFileAsync(new Uri(ADA_URL + ada), GetSaveLocation() + localFile) ;

		}
		
		private void DeleteFile(string file){
			if(File.Exists(file)){
				try{
					File.Delete(file) ;
				}catch(Exception) { /* on error do nothing */ }
			}
		}
		
		private void SetSaveToProgramFolder(){
			RegistryKey key = ApplicationRegKey() ;
			key.SetValue(SAVE_LOCATION_KEY, "") ;
			key.Close() ;
		}

		private void SetSaveToFolder(string path){
			if(!path.EndsWith("\\")){
				path += "\\" ;
			}
			RegistryKey key = ApplicationRegKey() ;
			key.SetValue(SAVE_LOCATION_KEY, path) ;
			key.Close() ;
		}
		
		private RegistryKey ApplicationRegKey(){
			RegistryKey key = Registry.CurrentUser.OpenSubKey("Software",true) ;
			key.CreateSubKey(Application.CompanyName) ;
			key = key.OpenSubKey(Application.CompanyName, true) ;
			key.CreateSubKey(Application.ProductName) ;
			key = key.OpenSubKey(Application.ProductName, true) ;
			return key ;
		}
		
		private string GetSaveLocation(){
			try {
				RegistryKey key = ApplicationRegKey() ;
				if(key != null){
					string val = key.GetValue(SAVE_LOCATION_KEY).ToString() ;
					key.Close() ;
					return val ;
				}else{
					return "" ;
				}				
			} catch (Exception) {
				return "" ;
			}

		}
		
		private void ShowErrorMessageSaveExecPath(string errorMsg){
			MessageBox.Show("Δεν ήταν δυνατή η πρόσβαση στο μητρώο. Τα αρχεία των λήψεων θα αποθηκευτούν στον ίδιο κατάλογο από τον οποίο εκτελείτε την εφαρμογή.\n\n" + errorMsg, "Σφάλμα!", MessageBoxButtons.OK, MessageBoxIcon.Error) ;			
		}
		
		void ButtonDownloadClick(object sender, EventArgs e){
			textBoxAda.Text = Regex.Replace(textBoxAda.Text.ToUpper(), "[^Α-Ω,0-9,-]", "") ;
			if(textBoxAda.Text == ""){
				MessageBox.Show("Πρέπει να εισάγετε έναν έγκυρο ΑΔΑ","Σφάλμα!", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
			}else{
				Download(textBoxAda.Text) ;
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e){
			client.CancelAsync() ;
		}
		
		void SaveToProgramFolderToolStripMenuItemClick(object sender, EventArgs e){
			saveFolderSelectToolStripMenuItem.Checked = false ;
			try{
				SetSaveToProgramFolder() ;
			}catch(Exception exc){
				ShowErrorMessageSaveExecPath(exc.Message) ;
			}
		}
		
		void SaveFolderSelectToolStripMenuItemClick(object sender, EventArgs e){
			saveToProgramFolderToolStripMenuItem.Checked = false ;
			DialogResult folderSelection = folderBrowserDialogSave.ShowDialog() ;
			try {
				if(folderBrowserDialogSave.SelectedPath == ""){
					saveToProgramFolderToolStripMenuItem.Checked = true ;
					saveFolderSelectToolStripMenuItem.Checked = false ;
				}else{
					SetSaveToFolder(folderBrowserDialogSave.SelectedPath)  ;
				}
			} catch (Exception exc) {
				ShowErrorMessageSaveExecPath(exc.Message) ;
			}
			
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e){
			MessageBox.Show("GrabΑΔΑ - εκδ. " + Application.ProductVersion + "\n\nΜια εφαρμογή λήψης αναρτηθέντων εγγράφων\nαπό το diavgeia.gov.gr, με βάση τον ΑΔΑ.\n\nCopyright (c) 2014, Πέτρος Κυλαδίτης\n<http://www.multipetros.gr/>\n\nΗ εφαρμογή διανέμεται υπό τους όρους της άδειας\nχρήσης GNU GPL 3. Πρέπει να έχετε λάβει ένα αντίγραφο\nτης μαζί με την εφαρμογή. Αν όχι μπορείτε να λάβετε ένα\nαπό τη διεύθυνση <http://www.gnu.org/licenses/gpl.txt>","Σχετικά με την εφαρμογή", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
		}
		
		void MainFormLoad(object sender, EventArgs e){			
			progressBarDownload.Visible = false ;
			buttonCancel.Visible = false ;
			if(GetSaveLocation() == ""){
				saveToProgramFolderToolStripMenuItem.Checked = true ;
			}else{
				saveFolderSelectToolStripMenuItem.Checked = true ;
			}
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e){
			Application.Exit() ;
		}
	}
}