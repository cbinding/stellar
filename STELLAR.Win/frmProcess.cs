using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STELLAR.Win
{
    
    public partial class frmProcess : Form
    {
        private STELLAR.Data.Process _process;

        public frmProcess()
        {
            InitializeComponent();
            this.process = new STELLAR.Data.Process("New Process");            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            saveProcess();
            this.Close();
        }

        private void frmProcess_Load(object sender, EventArgs e)
        {
            // Set up dlgSaveProcess
            dlgSaveProcess.Filter = "Process (*.proc)|*.proc|All Files (*.*)|*.*";
            dlgSaveProcess.DefaultExt = "*.proc";
            dlgSaveProcess.AddExtension = true;
            dlgSaveProcess.Title = "Save Process As";
            dlgSaveProcess.ShowHelp = false;
            dlgSaveProcess.InitialDirectory = Application.StartupPath;

            // Set up dlgChooseImportSpec
            dlgChooseImportSpec.Filter = "Import Specification (*.ispec)|*.ispec|All Files (*.*)|*.*";
            dlgChooseImportSpec.DefaultExt = "*.ispec";
            dlgChooseImportSpec.CheckFileExists = true;
            dlgChooseImportSpec.CheckPathExists = true;
            dlgChooseImportSpec.Multiselect = false;
            dlgChooseImportSpec.SupportMultiDottedExtensions = true;
            dlgChooseImportSpec.ReadOnlyChecked = false;
            dlgChooseImportSpec.ShowReadOnly = false;
            dlgChooseImportSpec.Title = "Choose Existing Import Specification";
            dlgChooseImportSpec.ShowHelp = false;
            dlgChooseImportSpec.InitialDirectory = Application.StartupPath;

            // Set up dlgChooseTemplateSpec
            dlgChooseImportSpec.Filter = "Template Specification (*.tspec)|*.tspec|All Files (*.*)|*.*";
            dlgChooseImportSpec.DefaultExt = "*.tspec";
            dlgChooseImportSpec.CheckFileExists = true;
            dlgChooseImportSpec.CheckPathExists = true;
            dlgChooseImportSpec.Multiselect = false;
            dlgChooseImportSpec.SupportMultiDottedExtensions = true;
            dlgChooseImportSpec.ReadOnlyChecked = false;
            dlgChooseImportSpec.ShowReadOnly = false;
            dlgChooseImportSpec.Title = "Choose Existing Template Specification";
            dlgChooseImportSpec.ShowHelp = false;
            dlgChooseImportSpec.InitialDirectory = Application.StartupPath;
        }

        public STELLAR.Data.Process process 
        { 
            get 
            { 
                return _process;
            } 
            set 
            { 
                _process = value;
                //now populate fields...
                txtDescription.Text = _process.description;
                txtImportSpecFile.Text = _process.importSpecFileName;
                txtTemplateSpecFile.Text = _process.templateSpecFileName;
                txtOutputFile.Text = _process.outputFileName;
                this.Text = "Process : " + this.process.fileName;   
            } 
        }

        private void txtImportSpecFile_TextChanged(object sender, EventArgs e)
        {
            _process.importSpecFileName = txtImportSpecFile.Text.Trim();
        }

        private void txtTemplateSpecFile_TextChanged(object sender, EventArgs e)
        {
            _process.templateSpecFileName = txtTemplateSpecFile.Text.Trim();          
        }

        private void txtOutputFile_TextChanged(object sender, EventArgs e)
        {
            _process.outputFileName = txtOutputFile.Text.Trim();
        }
        
        private void saveProcess()
        {
            //Do we know the file name? If not, ask for it
            if (this.process.fileName == String.Empty)
            {
                if (dlgSaveProcess.ShowDialog(this) != DialogResult.OK)
                    return;
                else
                    this.process.fileName = dlgSaveProcess.FileName;
            }
            //Do we now have a file name? If so, save the file
            if (this.process.fileName != String.Empty)
            {
                this.Text = "Process : " + this.process.fileName;
                //Save any changes
                this.process.description = txtDescription.Text.Trim();
                this.process.importSpecFileName = txtImportSpecFile.Text.Trim();
                this.process.templateSpecFileName = txtTemplateSpecFile.Text.Trim();
                this.process.outputFileName = txtOutputFile.Text.Trim();            
                this.process.save();                               
            }
        }

        private void btnImportSpec_Click(object sender, EventArgs e)
        {            
            dlgChooseImportSpec.ShowDialog(this);
        }

        private void btnTemplateSpec_Click(object sender, EventArgs e)
        {
            dlgChooseTemplateSpec.ShowDialog(this);
        }

        private void btnOutputFile_Click(object sender, EventArgs e)
        {
            dlgChooseOutputFile.ShowDialog(this);
        }

        private void dlgChooseImportSpec_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog dialog = (OpenFileDialog)sender;
            txtImportSpecFile.Text = dialog.FileName;
        }

        private void dlgChooseTemplateSpec_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog dialog = (OpenFileDialog)sender;
            txtTemplateSpecFile.Text = dialog.FileName;
        }

        private void dlgChooseOutputFile_FileOk(object sender, CancelEventArgs e)
        {
            SaveFileDialog dialog = (SaveFileDialog)sender;
            txtOutputFile.Text = dialog.FileName;
        }
    }
}
