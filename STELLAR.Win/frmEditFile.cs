using System;
using System.Windows.Forms;

namespace STELLAR.Win
{
    public partial class frmEditFile : Form
    {
        //Change this appName and the file dialog filters to reuse this form in any other apps
        private String appName = "Edit File";

        public frmEditFile()
        {
            InitializeComponent();
        }

        private void frmEditFile_Load(object sender, EventArgs e)
        {
           
            //Set up the textbox
            txtFileContents.AcceptsReturn = true;
            txtFileContents.AcceptsTab = true;
            txtFileContents.Multiline = true;
            txtFileContents.ScrollBars = ScrollBars.Both;
            txtFileContents.WordWrap = false;
            txtFileContents.Left = this.ClientRectangle.Left;
            txtFileContents.Top = this.ClientRectangle.Top + menuStrip1.Height;
            txtFileContents.Width = this.ClientRectangle.Width;
            txtFileContents.Height = this.ClientRectangle.Height - menuStrip1.Height;

            // Set up OpenFileDialog control
            dlgOpenFile.Filter = "Text (*.txt)|*.txt|All Files (*.*)|*.*";
            dlgOpenFile.DefaultExt = "*.txt";
            dlgOpenFile.CheckFileExists = true;
            dlgOpenFile.CheckPathExists = true;
            dlgOpenFile.Multiselect = false;
            dlgOpenFile.SupportMultiDottedExtensions = true;
            dlgOpenFile.ReadOnlyChecked = false;
            dlgOpenFile.ShowReadOnly = false;
            dlgOpenFile.Title = "Open File";
            dlgOpenFile.ShowHelp = false;
            dlgOpenFile.InitialDirectory = Application.StartupPath;

            // Set up SaveFileDialog control
            dlgSaveFile.Filter = "Text (*.txt)|*.txt|All Files (*.*)|*.*";
            dlgSaveFile.DefaultExt = "*.txt";
            dlgSaveFile.AddExtension = true;
            dlgSaveFile.Title = "Save File As";
            dlgSaveFile.ShowHelp = false;
            dlgSaveFile.InitialDirectory = Application.StartupPath;

            this.Text = appName;
        }
                       
        private void frmEditFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            //prompt to save if anything has changed
            if (txtFileContents.Modified)
            {
                if(promptToSave() == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            saveFile(true);
        }

        private void mnuFNew_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void mnuFOpen_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void mnuFSave_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void mnuFSaveAs_Click(object sender, EventArgs e)
        {
            saveFile(true);
        }

        private void mnuFExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuEUndo_Click(object sender, EventArgs e)
        {
            txtFileContents.Undo();
        }

        private void mnuECut_Click(object sender, EventArgs e)
        {
            txtFileContents.Cut();
        }

        private void mnuECopy_Click(object sender, EventArgs e)
        {
            txtFileContents.Copy();
        }

        private void mnuEPaste_Click(object sender, EventArgs e)
        {
            txtFileContents.Paste();
        }       

        private void mnuESelectAll_Click(object sender, EventArgs e)
        {
            txtFileContents.SelectAll();
        }

        private void newFile()
        {
            //prompt to save if anything has changed
            if (txtFileContents.Modified)
            {
                if(promptToSave()== DialogResult.Cancel)
                    return;
            }
            txtFileContents.Clear();
            txtFileContents.ClearUndo();
            txtFileContents.Modified = false;
            dlgSaveFile.FileName = String.Empty;
            this.Text = appName;
        }

        private DialogResult promptToSave()
        {            
            DialogResult dr = MessageBox.Show(this, "The current text has changed, would you like to save the changes?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
                saveFile();
            return dr;
        }

        private void openFile()
        {
            //prompt to save if anything has changed
            if (txtFileContents.Modified)
            {
                if(promptToSave() == DialogResult.Cancel)
                    return;
            }
            //Prompt for file to open
            if (dlgOpenFile.ShowDialog(this) == DialogResult.OK && dlgOpenFile.FileName.Trim() != String.Empty)
            {
                txtFileContents.Text = System.IO.File.ReadAllText(dlgOpenFile.FileName);
                dlgSaveFile.FileName = dlgOpenFile.FileName;
                this.Text = appName + " : " + dlgOpenFile.FileName;
                txtFileContents.Modified = false;
                txtFileContents.SelectionStart = 0;
                txtFileContents.SelectionLength = 0;
            }
        }

        //Used for externally directly opening a template for editing
        public void openFile(String fileName)
        {
            txtFileContents.Text = System.IO.File.ReadAllText(fileName);
            dlgSaveFile.FileName = fileName;
            this.Text = appName + " : " + fileName;
            txtFileContents.Modified = false;
            txtFileContents.SelectionStart = 0;
            txtFileContents.SelectionLength = 0;
        }

        //overloaded...
        private void saveFile()
        {
            saveFile(false);
        }
        private void saveFile(Boolean saveAs)
        {
            //Do we know the file name? If not, ask for it
            if (dlgSaveFile.FileName.Trim() == String.Empty || saveAs)
            {
                if (dlgSaveFile.ShowDialog(this) != DialogResult.OK)
                    return;               
            }
            //Do we now have a file name? If so, save the file
            if (dlgSaveFile.FileName.Trim() != String.Empty)
            {
                System.IO.File.WriteAllText(dlgSaveFile.FileName.Trim(), txtFileContents.Text, System.Text.Encoding.UTF8);
                this.Text = appName + " : " + dlgSaveFile.FileName.Trim();
                txtFileContents.Modified = false;
            }
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            //Conditionally disable/enable menu items
            mnuEUndo.Enabled = false;
            mnuECut.Enabled = false;
            mnuECopy.Enabled = false;
            mnuEPaste.Enabled = true; 
            mnuESelectAll.Enabled = false;

            mnuEFind.Enabled = false;
            mnuEFindNext.Enabled = false;
            mnuEReplace.Enabled = false;

            mnuEToUppercase.Enabled = false;
            mnuEToLowercase.Enabled = false;

            //If there is something to undo, then Undo is possible
            if (txtFileContents.CanUndo)
                mnuEUndo.Enabled = true;

            //If there is some text, Find/Replace and SelectAll is possible
            if (txtFileContents.Text.Length > 0)
            {
                mnuEFind.Enabled = true;
                mnuEFindNext.Enabled = true;
                mnuEReplace.Enabled = true;
                mnuESelectAll.Enabled = true;
            }

            //If there is selected text, Cut, Copy, ToUppercase, ToLowercase are possible
            if (txtFileContents.SelectedText.Length > 0)
            {
                mnuECut.Enabled = true;
                mnuECopy.Enabled = true;
                mnuEToUppercase.Enabled = true;
                mnuEToLowercase.Enabled = true;
            }

            //If there is something to paste, then paste is possible
            if(Clipboard.ContainsText())
                mnuEPaste.Enabled = true;
        }

        private void mnuEFind_Click(object sender, EventArgs e)
        {
            Form frm = new frmFindReplace();
            frm.Show(this);
            //todo..
        }

        private void mnuEFindNext_Click(object sender, EventArgs e)
        {
            Form frm = new frmFindReplace();
            frm.Show(this);
            //todo..
        }

        private void mnuEReplace_Click(object sender, EventArgs e)
        {
            Form frm = new frmFindReplace();
            frm.Show(this);
            //todo..
        }

        private void mnuFile_Click(object sender, EventArgs e)
        {
            //Conditionally enable/disable menu items
            //If we don't know the file name then SaveAs is posssible but Save is not
            if(dlgSaveFile.FileName.Trim() == String.Empty)
                mnuFSave.Enabled = false;
            else
                mnuFSave.Enabled = true;
        }

        private void mnuEToUppercase_Click(object sender, EventArgs e)
        {
            txtFileContents.SelectedText = txtFileContents.SelectedText.ToUpper();
        }

        private void mnuEToLowercase_Click(object sender, EventArgs e)
        {
            txtFileContents.SelectedText = txtFileContents.SelectedText.ToLower();
        }

       
        
    }
}
