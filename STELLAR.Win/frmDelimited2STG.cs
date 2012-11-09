using System;
using System.IO;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;

namespace STELLAR.Win
{
    // used for serializing form field values to/from file
    public struct Conversion
    {
        public String description;
        public String dataFileName;
        public Char delimiter;
        public Boolean hasHeaders;
        public String templateFileName;
        public String optionsFileName;
    }

    public partial class frmDelimited2STG : Form
    {
        private String appName = "STELLAR";
        private bool hasChanged = false;

        public frmDelimited2STG()
        {
            InitializeComponent();
        }

        private void frmImportDelimited_Load(object sender, EventArgs e)
        {
            String s = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            Version v = System.Reflection.Assembly.GetEntryAssembly().GetName().Version;
            appName = String.Format("{0} v{1}.{2}", s, v.Major, v.Minor);
            this.Text = appName;
            
            newProject();

            // Set up dlgOpenFile
            dlgOpenFile.Filter = "STELLAR conversion (*.stellar)|*.stellar|XML (*.xml)|*.xml|All Files (*.*)|*.*";
            dlgOpenFile.DefaultExt = "*.stellar";
            dlgOpenFile.CheckFileExists = true;
            dlgOpenFile.CheckPathExists = true;
            dlgOpenFile.Multiselect = false;
            dlgOpenFile.SupportMultiDottedExtensions = true;
            dlgOpenFile.ReadOnlyChecked = false;
            dlgOpenFile.ShowReadOnly = false;
            dlgOpenFile.Title = "Open File";
            dlgOpenFile.ShowHelp = false;
            dlgOpenFile.InitialDirectory = Application.StartupPath;

            // Set up dlgSaveFile
            dlgSaveFile.Filter = "STELLAR conversion (*.stellar)|*.stellar|XML (*.xml)|*.xml|All Files (*.*)|*.*";
            dlgSaveFile.DefaultExt = "*.stellar";
            dlgSaveFile.AddExtension = true;
            dlgSaveFile.Title = "Save File As";
            dlgSaveFile.ShowHelp = false;
            dlgSaveFile.InitialDirectory = Application.StartupPath;

            // set up dlgOpenDataFile
            dlgOpenDataFile.Filter = "Delimited Files (*.csv;*.tab;*.txt)|*.csv;*.tab;*.txt|All Files (*.*)|*.*";
            dlgOpenDataFile.DefaultExt = "*.csv;*.tab;*.txt";
            dlgOpenDataFile.Multiselect = false;
            dlgOpenDataFile.ReadOnlyChecked = true;
            dlgOpenDataFile.ShowReadOnly = false;
            dlgOpenDataFile.Title = "Open Delimited File";
            dlgOpenDataFile.ShowHelp = false;
            dlgOpenDataFile.FileName = "";
            dlgOpenDataFile.InitialDirectory = Application.StartupPath;

            // Set up dlgOpenTemplateFile 
            dlgOpenTemplateFile.Filter = "Template Files (*.stg)|*.stg|All Files (*.*)|*.*";
            dlgOpenTemplateFile.DefaultExt = "*.stg";
            dlgOpenTemplateFile.Multiselect = false;
            dlgOpenTemplateFile.ReadOnlyChecked = true;
            dlgOpenTemplateFile.ShowReadOnly = false;
            dlgOpenTemplateFile.Title = "Choose Template File";
            dlgOpenTemplateFile.ShowHelp = false;
            dlgOpenTemplateFile.FileName = "";
            dlgOpenTemplateFile.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, "Templates");

            // Set up dlgSaveOutput 
            dlgSaveOutputFile.Filter = "Text Files (*.txt)|*.txt|XML Files (*.xml)|*.xml|RDF Files (*.rdf)|*.rdf|All Files (*.*)|*.*";
            dlgSaveOutputFile.DefaultExt = "*.txt";
            dlgSaveOutputFile.AddExtension = true;
            dlgSaveOutputFile.Title = "Save Output As";
            dlgSaveOutputFile.ShowHelp = false;
            dlgSaveOutputFile.FileName = "";
            dlgSaveOutputFile.CheckFileExists = false;
            dlgSaveOutputFile.InitialDirectory = Application.StartupPath;

            // set up dlgOpenOptionsFile
            dlgOpenOptionsFile.Filter = "Delimited Files (*.csv)|*.csv|All Files (*.*)|*.*";
            dlgOpenOptionsFile.DefaultExt = "*.csv";
            dlgOpenOptionsFile.AddExtension = true;
            dlgOpenOptionsFile.Title = "Choose Options File";
            dlgOpenOptionsFile.ShowHelp = false;
            dlgOpenOptionsFile.FileName = "";
            dlgOpenOptionsFile.CheckFileExists = false;
            dlgOpenOptionsFile.InitialDirectory = Application.StartupPath;            
        }        

        private void btnChooseDataFile_Click(object sender, EventArgs e)
        {
            try
            {
                String dir = System.IO.Path.GetDirectoryName(txtDataFileName.Text.Trim());
                if (System.IO.Directory.Exists(dir))
                    dlgOpenDataFile.InitialDirectory = dir;
                else
                    dlgOpenDataFile.InitialDirectory = Application.StartupPath;
            }
            catch { }           
                
            dlgOpenDataFile.ShowDialog(this);
        }

        private void btnChooseTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                String dir = System.IO.Path.GetDirectoryName(txtTemplateFileName.Text.Trim());
                if (System.IO.Directory.Exists(dir))
                    dlgOpenTemplateFile.InitialDirectory = dir;
                else
                    dlgOpenTemplateFile.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, "Templates");
            }
            catch { }     
            dlgOpenTemplateFile.ShowDialog(this);
        }

        private void btnChooseOptionsFile_Click(object sender, EventArgs e)
        {
            try
            {
                String dir = System.IO.Path.GetDirectoryName(txtOptionsFileName.Text.Trim());
                if (System.IO.Directory.Exists(dir))
                    dlgOpenOptionsFile.InitialDirectory = dir;
                else
                    dlgOpenOptionsFile.InitialDirectory = Application.StartupPath;
            }
            catch { }     
            dlgOpenOptionsFile.ShowDialog(this);
        }

        private void dlgOpenDataFile_FileOk(object sender, CancelEventArgs e)
        {
            txtDataFileName.Text = dlgOpenDataFile.FileName;
            if (File.Exists(dlgOpenDataFile.FileName))
            {
                RefreshData();
            }
            fileWatcher.Path = System.IO.Path.GetDirectoryName(dlgOpenDataFile.FileName);
            fileWatcher.Filter = System.IO.Path.GetFileName(dlgOpenDataFile.FileName);
            fileWatcher.NotifyFilter = NotifyFilters.LastWrite;

            hasChanged = true;
        }        

        private void dlgOpenTemplateFile_FileOk(object sender, CancelEventArgs e)
        {
            txtTemplateFileName.Text = dlgOpenTemplateFile.FileName;
            hasChanged = true;
        }

        private void dlgOpenOptionsFile_FileOk(object sender, CancelEventArgs e)
        {
            txtOptionsFileName.Text = dlgOpenOptionsFile.FileName;
            hasChanged = true;
        }

        private void dlgSaveOutput_FileOk(object sender, CancelEventArgs e)
        {
            StreamWriter sw = System.IO.File.CreateText(dlgSaveOutputFile.FileName);
            sw.Write(txtOutput.Text);
            sw.Close();
        }   

        private void RefreshData()
        {
            try
            {
                lstExamples.Columns.Clear();
                lstExamples.Items.Clear();
                
                if (!File.Exists(txtDataFileName.Text))
                    return;

                // Parse just first few rows of file into DataTable for viewing TODO: first few rows, not all!
                DataTable dt = STELLAR.Data.API.Delimited2DT(txtDataFileName.Text, getDelimiter(), chkHeaders.Checked, 50);
                
                // Create columns corresponding to the new DataTable                
                foreach (DataColumn dc in dt.Columns)
                {
                    lstExamples.Columns.Add(dc.ColumnName);
                }

                // Create rows corresponding to the new DataTable
                lstExamples.Items.Clear();
                foreach(DataRow dr in dt.Rows)
                {
                    ListViewItem lvItem = new ListViewItem();                    
                    for (int i = 0; i < dr.ItemArray.Length; i++)
                    {
                        String dataValue = dr[i].ToString().Trim();
                        if (dataValue.StartsWith("\"") && dataValue.EndsWith("\"") && dataValue.Length > 1)
                            dataValue = dataValue.Substring(1, dataValue.Length - 2);
                        if(i == 0)
                            lvItem.Text = dataValue;
                        else
                            lvItem.SubItems.Add(dataValue);
                    }
                    lstExamples.Items.Add(lvItem);
                }                
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString()); //tmp..
            }   
        }

        private void chkHeaders_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
            hasChanged = true;
        }

        private void delimiter_CheckedChanged(object sender, EventArgs e)
        {
            txtDelimiterChar.Enabled = radOtherDelimiter.Checked;            
            RefreshData();
            hasChanged = true;
        }

        private char getDelimiter()
        {
            txtDelimiterChar.Enabled = false;
            char delimiter = '\n'; //default = newline..

            if(radCommaDelimiter.Checked)
                delimiter = ',';
            else if (radSemicolonDelimiter.Checked)
                delimiter = ';';
            else if (radSpaceDelimiter.Checked)
                delimiter = ' ';
            else if (radTabDelimiter.Checked)
                delimiter = '\t';
            else if (radOtherDelimiter.Checked)
            {
                txtDelimiterChar.Enabled = true;
                if (txtDelimiterChar.Text.Length > 0)
                    delimiter = txtDelimiterChar.Text.ToCharArray(0, 1)[0];
            }
            return delimiter;
        }

        private void txtDelimiterChar_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
            hasChanged = true;
        }           

        private void btnRun_Click(object sender, EventArgs e)
        {
            txtEquivalentCommand.Text = getEquivalentCommand();
            txtOutput.Text = "";            

            if (!System.IO.File.Exists(txtDataFileName.Text))
            {
                MessageBox.Show("Data file '" + txtDataFileName.Text + "' doesn't exist?");
                return;
            }
            if (!System.IO.File.Exists(txtTemplateFileName.Text))
            {
                MessageBox.Show("Template file '" + txtTemplateFileName.Text + "' doesn't exist?");
                return;
            }
            if (!System.IO.File.Exists(txtOptionsFileName.Text))
            {
                MessageBox.Show("Options file '" + txtOptionsFileName.Text + "' doesn't exist?");
                return;
            }

            String tmpFileName = System.IO.Path.GetRandomFileName(); 
            STELLAR.Data.API.Delimited2STG(txtDataFileName.Text, txtTemplateFileName.Text, tmpFileName, txtOptionsFileName.Text,chkHeaders.Checked, getDelimiter());
            txtOutput.Text = System.IO.File.ReadAllText(tmpFileName);
            if (File.Exists(tmpFileName))
                System.IO.File.Delete(tmpFileName);      
        }

        private void btnEditOptionsFile_Click(object sender, EventArgs e)
        {
            if (txtOptionsFileName.Text.Trim() == "")
                return;
            if (!File.Exists(txtOptionsFileName.Text))
            {
                MessageBox.Show("Options file '" + dlgOpenOptionsFile.FileName + "' doesn't exist?");
                return;
            }

            frmEditFile f = new frmEditFile();
            f.openFile(txtOptionsFileName.Text);
            f.Show(this);
        }

        private void btnEditTemplateFile_Click(object sender, EventArgs e)
        {
            if (txtTemplateFileName.Text.Trim() == "")
                return;
            if (!File.Exists(txtTemplateFileName.Text))
            {
                MessageBox.Show("Template file '" + dlgOpenTemplateFile.FileName + "' doesn't exist?");
                return;
            }

            frmEditFile f = new frmEditFile();
            f.openFile(txtTemplateFileName.Text);
            f.Show(this);
        }

        private void btnSaveOutput_Click(object sender, EventArgs e)
        {
            dlgSaveOutputFile.ShowDialog(this);
        }

        private void btnEditDataFile_Click(object sender, EventArgs e)
        {
            if (txtDataFileName.Text.Trim() == "")
                return;
            if (!File.Exists(txtDataFileName.Text))
            {
                MessageBox.Show("Data file '" + dlgOpenDataFile.FileName + "' doesn't exist?");
                return;
            }

            frmEditFile f = new frmEditFile();
            f.openFile(txtDataFileName.Text);
            f.Show(this);            
        }

        private void fileWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            RefreshData();
        }

        private void mnuFNew_Click(object sender, EventArgs e)
        {
            newProject();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newProject();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dlgOpenFile.ShowDialog(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveProject();
        }

        //overloaded...
        private void saveProject()
        {
            saveProject(false);
        }
        private void saveProject(Boolean saveAs)
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
                this.Text = appName + " : " + dlgSaveFile.FileName.Trim();
                
                //serialize form fields to XML file
                Conversion c = new Conversion();
                c.description = txtDescription.Text.Trim();
                c.dataFileName = txtDataFileName.Text.Trim();
                c.hasHeaders = chkHeaders.Checked;
                c.templateFileName = txtTemplateFileName.Text.Trim();
                c.optionsFileName = txtOptionsFileName.Text.Trim();
                c.delimiter = getDelimiter();
                try
                {
                    System.Xml.Serialization.XmlSerializer xs =
                        new System.Xml.Serialization.XmlSerializer(typeof(Conversion));
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(dlgSaveFile.FileName);
                    xs.Serialize(sw, c);
                    sw.Close();
                    hasChanged = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }            
        }
       
        private DialogResult promptToSave()
        {
            DialogResult dr = MessageBox.Show(this, "The current project has changed, would you like to save the changes?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
                saveProject();
            return dr;
        }

        private void openProject(String fileName)
        {
            //Prompt for file to open
            if (fileName.Trim() != String.Empty)
            {
                dlgSaveFile.FileName = fileName;
                this.Text = appName + " : " + fileName;

                //deserialize settings from file and populate form fields 
                Conversion c;
                try
                {
                    System.Xml.Serialization.XmlSerializer xs =
                        new System.Xml.Serialization.XmlSerializer(typeof(Conversion));
                    System.IO.StreamReader sr = new System.IO.StreamReader(fileName);
                    c = (Conversion)(xs.Deserialize(sr));
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                txtDescription.Text = c.description;
                txtDataFileName.Text = c.dataFileName;
                txtTemplateFileName.Text = c.templateFileName;
                txtOptionsFileName.Text = c.optionsFileName;
                chkHeaders.Checked = c.hasHeaders;
                switch (c.delimiter)
                {
                    case '\t':
                        radTabDelimiter.Checked = true;
                        break;
                    case ';':
                        radSemicolonDelimiter.Checked = true;
                        break;
                    case ' ':
                        radSpaceDelimiter.Checked = true;
                        break;
                    case ',':
                        radCommaDelimiter.Checked = true;
                        break;
                    default:
                        radOtherDelimiter.Checked = true;
                        txtDelimiterChar.Text = c.delimiter.ToString();
                        break;
                }
                RefreshData();
                txtEquivalentCommand.Text = "";
                txtOutput.Text = "";
                hasChanged = false;
            }    
        }

        private void mnuFSaveAs_Click(object sender, EventArgs e)
        {
            saveProject(true);
        }           

        private void newProject()
        {
            //prompt to save if anything has changed
            if (hasChanged)
            {
                if (promptToSave() == DialogResult.Cancel)
                    return;
            }
            //clear all fields here...
            txtDescription.Text = "";
            txtDataFileName.Text = "";
            txtTemplateFileName.Text = "";
            txtOptionsFileName.Text = "";
            txtDelimiterChar.Text = "";
            chkHeaders.Checked = true;
            radCommaDelimiter.Checked = true;
            lstExamples.Items.Clear();
            lstExamples.Columns.Clear();
            txtEquivalentCommand.Text = "";
            txtOutput.Text = "";

            dlgOpenFile.FileName = "";
            dlgSaveFile.FileName = "";
            this.Text = appName;
            
            btnEditDataFile.Enabled = false;
            btnEditOptionsFile.Enabled = false;
            btnEditTemplateFile.Enabled = false;
            //btnRun.Enabled = false;
            btnSaveOutput.Enabled = false;
            hasChanged = false;
        }

        private void mnuFOpen_Click(object sender, EventArgs e)
        {
            dlgOpenFile.ShowDialog(this);
        }

        private void mnuFSave_Click(object sender, EventArgs e)
        {
            saveProject();
        }    

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Show help contents
        }

        private void mnuHWeb_Click(object sender, EventArgs e)
        {
            //goto STELLAR home page...(TODO: get Uri from app.config instead)
            string target = "http://hypermedia.research.glam.ac.uk/kos/stellar";

            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch(System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void mnuFExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }   

       
        private void frmDelimited2STG_FormClosing(object sender, FormClosingEventArgs e)
        {
            //prompt to save if anything has changed
            if (hasChanged)
            {
                if (promptToSave() == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void dlgOpenFile_FileOk(object sender, CancelEventArgs e)
        {
            openProject(dlgOpenFile.FileName); 
        }

        private void dlgSaveFile_FileOk(object sender, CancelEventArgs e)
        {
            saveProject();
        }

        private void txtDataFileName_TextChanged(object sender, EventArgs e)
        {
            btnEditDataFile.Enabled = (txtDataFileName.Text.Trim().Length > 0);
            hasChanged = true;
        }

        private void txtTemplateFileName_TextChanged(object sender, EventArgs e)
        {
            btnEditTemplateFile.Enabled = (txtTemplateFileName.Text.Trim().Length > 0);
            hasChanged = true;
        }

        private void txtOptionsFileName_TextChanged(object sender, EventArgs e)
        {
            btnEditOptionsFile.Enabled = (txtOptionsFileName.Text.Trim().Length > 0);
            hasChanged = true;
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            btnSaveOutput.Enabled = (txtOutput.Text.Trim().Length > 0);
            hasChanged = true;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private String getEquivalentCommand()
        {
            // Get equivalent STELLAR.Console command using current settings
            String cmd = "";
            Char delim = getDelimiter();
            if (delim == '\t')
            {
                cmd = "TAB2STG";
                cmd += " /tab:\"" + txtDataFileName.Text.Trim() + "\"";                
            }
            else
            {
                cmd = "DELIM2STG";
                cmd += " /data:\"" + txtDataFileName.Text.Trim() + "\"";
                cmd += " /delimiter:\"" + delim.ToString() + "\"";
            }
            cmd += " /stg:\"" + txtTemplateFileName.Text.Trim() + "\"";
            cmd += " /opt:\"" + txtOptionsFileName.Text.Trim() + "\"";
            return (cmd);
        }        
    }
}
