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
    public partial class frmMDI : Form
    {
        private String appName = "STELLAR";

        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {            
            // Set up dlgOpenProject
            dlgOpenProject.Filter = "Project (*.proj)|*.proj|All Files (*.*)|*.*";
            dlgOpenProject.DefaultExt = "*.proj";
            dlgOpenProject.CheckFileExists = true;
            dlgOpenProject.CheckPathExists = true;
            dlgOpenProject.Multiselect = false;
            dlgOpenProject.SupportMultiDottedExtensions = true;
            dlgOpenProject.ReadOnlyChecked = false;
            dlgOpenProject.ShowReadOnly = false;
            dlgOpenProject.Title = "Open Project";
            dlgOpenProject.ShowHelp = false;
            dlgOpenProject.InitialDirectory = Application.StartupPath;

            // Set up dlgSaveProject
            dlgSaveProject.Filter = "Project (*.proj)|*.proj|All Files (*.*)|*.*";
            dlgSaveProject.DefaultExt = "*.proj";
            dlgSaveProject.AddExtension = true;
            dlgSaveProject.Title = "Save Project As";
            dlgSaveProject.ShowHelp = false;
            dlgSaveProject.InitialDirectory = Application.StartupPath;

            // Set up OpenFileDialog control
            dlgOpenProcess.Filter = "Process (*.proc)|*.proc|All Files (*.*)|*.*";
            dlgOpenProcess.DefaultExt = "*.proc";
            dlgOpenProcess.CheckFileExists = true;
            dlgOpenProcess.CheckPathExists = true;
            dlgOpenProcess.Multiselect = false;
            dlgOpenProcess.SupportMultiDottedExtensions = true;
            dlgOpenProcess.ReadOnlyChecked = false;
            dlgOpenProcess.ShowReadOnly = false;
            dlgOpenProcess.Title = "Choose Process";
            dlgOpenProcess.ShowHelp = false;
            dlgOpenProcess.InitialDirectory = Application.StartupPath;

            this.Text = appName;            
        }

        private void mnuFExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
        private void mnuHAbout_Click(object sender, EventArgs e)
        {
            Form f = new frmAbout();
            f.ShowDialog(this);
        }       

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Show help contents
        }

        private void mnuHWeb_Click(object sender, EventArgs e)
        {
            //goto STELLAR home page...
            string target = "http://hypermedia.research.glam.ac.uk/kos/stellar";
            
            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch
                (
                 System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }      
        

        private void mnuFOpen_Click(object sender, EventArgs e)
        {
            openProject();
        }

        private void mnuFSave_Click(object sender, EventArgs e)
        {
            saveProject();
        }

        private void mnuFSaveAs_Click(object sender, EventArgs e)
        {
            saveProject(true);
        }        

        private void mnuVStatusBar_CheckStateChanged(object sender, EventArgs e)
        {
            staStatus.Visible = mnuVStatusBar.Checked;            
        }

        private void mnuVToolBar_CheckStateChanged(object sender, EventArgs e)
        {
            toolStrip1.Visible = mnuVToolBar.Checked;            
        }   
        
        private void newProject()
        {
            //prompt to save if anything has changed
            /*if (_currentProject.hasChanged)
            {
                if (promptToSave() == DialogResult.Cancel)
                    return;
            }
            _currentProject = new STELLAR.DATA.Project();            
            dlgSaveProject.FileName = String.Empty;
            this.Text = appName;*/
        }

        private DialogResult promptToSave()
        {
            DialogResult dr = MessageBox.Show(this, "The current project has changed, would you like to save the changes?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
                saveProject();
            return dr;
        }

        private void openProject()
        {            
            //Prompt for file to open
            if (dlgOpenProject.ShowDialog(this) == DialogResult.OK && dlgOpenProject.FileName.Trim() != String.Empty)
            {
                dlgSaveProject.FileName = dlgOpenProject.FileName;
                this.Text = appName + " : " + dlgOpenProject.FileName;              
            }
        }        

        //overloaded...
        private void saveProject()
        {
            saveProject(false);
        }
        private void saveProject(Boolean saveAs)
        {
            //Do we know the file name? If not, ask for it
            if (dlgSaveProject.FileName.Trim() == String.Empty || saveAs)
            {
                if (dlgSaveProject.ShowDialog(this) != DialogResult.OK)
                    return;
            }
            //Do we now have a file name? If so, save the file
            if (dlgSaveProject.FileName.Trim() != String.Empty)
            {
               this.Text = appName + " : " + dlgSaveProject.FileName.Trim();                
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //prompt to save if anything has changed
            //if (_currentProject.hasChanged)
            {
                if (promptToSave() == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newProject();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openProject();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveProject();
        }

        private void lvwFileProcesses_DoubleClick(object sender, EventArgs e)
        {

        }       

        private void mnuFNew_Click(object sender, EventArgs e)
        {
            frmDelimited2STG f = new frmDelimited2STG();
            f.MdiParent = this;
            f.Show();            
        }

        private void mnuFile_Click(object sender, EventArgs e)
        {

        }

        private void mnuView_Click(object sender, EventArgs e)
        {

        }

        private void mnuVToolBar_Click(object sender, EventArgs e)
        {

        }

        private void mnuHContents_Click(object sender, EventArgs e)
        {

        }        
    }
}
