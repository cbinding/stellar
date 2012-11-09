using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STELLAR.APP
{
    public partial class frmMain : Form
    {
        private ListViewColumnSorter lvwColumnSorter;
        private STELLAR.DATA.Project _currentProject = new STELLAR.DATA.Project();
        private STELLAR.DATA.Process _currentProcess = new STELLAR.DATA.Process();
        private String appName = "STELLAR";

        public frmMain()
        {
            InitializeComponent();

            // Create an instance of a ListView column sorter and assign it 
            // to the ListView control.
            lvwColumnSorter = new ListViewColumnSorter();
            lvwProcesses.ListViewItemSorter = lvwColumnSorter;
        }

        private void mnuFile_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Set up the main listview (override any settings in visual designer)          
            resizeListview();
            
            lvwProcesses.Columns.Add("colDescription", "Description", lvwProcesses.Width - 200);
            lvwProcesses.Columns.Add("colStatus", "Status", 200);
            lvwProcesses.CheckBoxes = false;
            lvwProcesses.Scrollable = true;
            lvwProcesses.FullRowSelect = true;
            lvwProcesses.Sorting = SortOrder.Ascending;
            lvwProcesses.View = View.Details;
            lvwProcesses.GridLines = true;
            lvwProcesses.CheckBoxes = true;

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

            //Add some temp fake items for demo purposes
            /*
            ListViewItem lvwItem = new ListViewItem("MOLA FND_RF to Finds Materials"); 
            
            lvwItem.ImageIndex = 1;            
            lvwItem.Checked = true;
            lvwItem.SubItems.Add(ProcessStatusEnum.Stopped.ToString());
            lvwItem.Name = "fred1.xml";
            lvwProcesses.Items.Add(lvwItem);
            

            lvwItem = new ListViewItem("MOLA_LOV to E55Type");
            lvwItem.Checked = true;
            lvwItem.ImageIndex = 0;
            lvwItem.SubItems.Add(ProcessStatusEnum.Waiting.ToString());
            lvwItem.Name = "fred2.xml";
            lvwProcesses.Items.Add(lvwItem);
            */

        }

        private void mnuFExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFNew_Click(object sender, EventArgs e)
        {
            newProject();
        }        

        private void lvwFileProcesses_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                lvwColumnSorter.Order = (lvwColumnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending);                
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            ListView lvw = (ListView)sender;
            lvw.Sort();
        }

        private void mnuHAbout_Click(object sender, EventArgs e)
        {
            Form f = new frmAbout();
            f.ShowDialog(this);
        }

        private void mnuPRun_Click(object sender, EventArgs e)
        {
            //Run all selected processes

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //Run all selected processes
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
       
        private void mnuPRemove_Click(object sender, EventArgs e)
        {
            if (lvwProcesses.SelectedItems.Count > 0)
            {
                //Prompt whether to definitely remove (remove only, does not delete it)
                DialogResult dr = MessageBox.Show("Are you sure you want to remove the currently selected process?", "Remove Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //remove the process               
                    _currentProject.removeProcess(lvwProcesses.SelectedItems[0].Name);
                }                
            }
            refreshListView();
        }

        private void mnuPPause_Click(object sender, EventArgs e)
        {
            //Pause the process(es)
        }

        private void mnuPStop_Click(object sender, EventArgs e)
        {
            //Stop the process(es)
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
        
        private void resizeListview()
        {
            // Size up the listview according to current view settings
            int statusBarHeight = (staStatus.Visible ? staStatus.Height : 0);
            int toolBarHeight = (toolStrip1.Visible ? toolStrip1.Height : 0);
            lvwProcesses.Left = this.ClientRectangle.Left;
            lvwProcesses.Top = this.ClientRectangle.Top + toolBarHeight + menuStrip1.Height;
            lvwProcesses.Width = this.ClientRectangle.Width;
            lvwProcesses.Height = this.ClientRectangle.Height - (statusBarHeight + toolBarHeight + menuStrip1.Height);
        }

        private void mnuVStatusBar_CheckStateChanged(object sender, EventArgs e)
        {
            staStatus.Visible = mnuVStatusBar.Checked;
            resizeListview();
        }

        private void mnuVToolBar_CheckStateChanged(object sender, EventArgs e)
        {
            toolStrip1.Visible = mnuVToolBar.Checked;
            resizeListview();
        }

        private void mnuPEdit_Click(object sender, EventArgs e)
        {
            Form f = new frmProcess();
            f.ShowDialog(this);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newProject()
        {
            //prompt to save if anything has changed
            if (_currentProject.hasChanged)
            {
                if (promptToSave() == DialogResult.Cancel)
                    return;
            }
            _currentProject = new STELLAR.DATA.Project();            
            dlgSaveProject.FileName = String.Empty;
            this.Text = appName;
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
            //prompt to save if anything has changed
            if (_currentProject.hasChanged)
            {
                if (promptToSave() == DialogResult.Cancel)
                    return;
            }
            //Prompt for file to open
            if (dlgOpenProject.ShowDialog(this) == DialogResult.OK && dlgOpenProject.FileName.Trim() != String.Empty)
            {
                _currentProject = STELLAR.DATA.Project.load(dlgOpenProject.FileName);
                dlgSaveProject.FileName = dlgOpenProject.FileName;
                this.Text = appName + " : " + dlgOpenProject.FileName;

                lvwProcesses.Items.Clear();
                foreach (KeyValuePair<String, STELLAR.DATA.Process> pair in _currentProject.processes)
                {
                    ListViewItem lvwItem = new ListViewItem(pair.Value.description);
                    lvwItem.ImageIndex = 1;
                    lvwItem.Checked = true;
                    lvwItem.SubItems.Add(pair.Value.status.ToString());
                    lvwItem.Name = pair.Key;
                    lvwProcesses.Items.Add(lvwItem);
                }
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
                _currentProject.saveAs(dlgSaveProject.FileName);
                this.Text = appName + " : " + dlgSaveProject.FileName.Trim();
                //_currentProject.hasChanged = false;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //prompt to save if anything has changed
            if (_currentProject.hasChanged)
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
            Form f = new frmProcess();
            f.ShowDialog(this);
        }

        private void mnuProcess_Click(object sender, EventArgs e)
        {
            //Conditionally enable menu items
            mnuPEdit.Enabled=false;
            mnuPRemove.Enabled=false;
            if (lvwProcesses.SelectedIndices.Count > 0)
            {
                mnuPEdit.Enabled = true;
                mnuPRemove.Enabled = true;
            }
        }

        private void mnuPAddNew_Click(object sender, EventArgs e)
        {
            //Open DataProcess form to add a new Process
            frmProcess f = new frmProcess();
            f.process = new STELLAR.DATA.Process("New Process");
            f.Show(this);
            refreshListView();
        }

        private void refreshListView()
        {
            lvwProcesses.Items.Clear();
            foreach (STELLAR.DATA.Process p in _currentProject.processes.Values)
            {
                ListViewItem lvwItem = new ListViewItem(p.description);

                lvwItem.ImageIndex = 1;
                lvwItem.Checked = true;
                lvwItem.SubItems.Add(STELLAR.DATA.ProcessStatusEnum.Stopped.ToString());
                lvwItem.Name = p.fileName;
                lvwProcesses.Items.Add(lvwItem);
            }
        }

        private void mnuPAddExisting_Click(object sender, EventArgs e)
        {
            //Select an existing Process from file
            if (dlgOpenProcess.ShowDialog(this) == DialogResult.OK)
            {
                //Ensure not already added
                if (!_currentProject.processFileNames.Contains(dlgOpenProcess.FileName))
                {
                    //Ensure valid process
                    STELLAR.DATA.Process p = STELLAR.DATA.Process.load(dlgOpenProcess.FileName);
                    if (p != null)
                    {
                        _currentProject.addProcess(dlgOpenProcess.FileName);
                        ListViewItem lvwItem = new ListViewItem(p.description);
                        lvwProcesses.Items.Add(lvwItem);  
                    }
                }         
                              
            }
        }       
    }
}
