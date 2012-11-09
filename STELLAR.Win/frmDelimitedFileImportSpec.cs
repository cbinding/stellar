using System;
using System.IO;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;
using FileHelpers;

namespace STELLAR.Win
{
    public partial class frmDelimitedFileImportSpec : Form
    {
        private char delimiter = ',';
        private STELLAR.Data.DelimitedFileImportSpec _importSpec;
        
        public frmDelimitedFileImportSpec()
        {
            InitializeComponent();

            _importSpec = new STELLAR.Data.DelimitedFileImportSpec();
            _importSpec.delimiter = ",";
            _importSpec.hasHeaders = chkHeaders.Checked;            
        }        

        private void btnChooseFile_Click(object sender, EventArgs e)
        {          
            dlgOpenDataFile.ShowDialog(this);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveSchema();
            this.Close(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dlgOpenFile_FileOk(object sender, CancelEventArgs e)
        {
            if (File.Exists(dlgOpenDataFile.FileName))
            {
                _importSpec.dataFileName = dlgOpenDataFile.FileName;
                txtDataFileName.Text = _importSpec.dataFileName;
                dlgSaveSchema.FileName = _importSpec.dataFileName + ".xsd";
                txtSchemaFileName.Text = dlgSaveSchema.FileName;
                RefreshData();                             
            }    
        }
        
        private void RefreshData()
        {
            try
            {
                lstExamples.Columns.Clear();
                lstExamples.Items.Clear();
                
                if (!File.Exists(txtDataFileName.Text))
                    return;

                // Parse just first few rows of file into DataTable for viewing
                TextReader tr = new StreamReader(txtDataFileName.Text);
                
                //DataTable dt = CsvParser.Parse(tr, chkHeaders.Checked, delimiter, 20);
                //DataTable dt = CsvParser.ParseUsingFileHelpers(txtDataFileName.Text, chkHeaders.Checked, delimiter.ToString(), 20);
                DataTable dt = _importSpec.getData(20);
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
                        if(i == 0)
                            lvItem.Text = dr[i].ToString();
                        else
                            lvItem.SubItems.Add(dr[i].ToString());
                    }
                    lstExamples.Items.Add(lvItem);
                }

                //temp..
                //dt.TableName = "fred";
                //dt.WriteXmlSchema("c:\\fred.xml");  

                //cleanup
                tr.Close();
                tr = null;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString()); //tmp..
            }   
        }

        private void chkHeaders_CheckedChanged(object sender, EventArgs e)
        {
            _importSpec.hasHeaders = chkHeaders.Checked;
            RefreshData();
        }

        private void delimiter_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                txtDelimiterChar.Enabled = false;
                delimiter = '\n'; //default newline..
                RadioButton rb = sender as RadioButton;
                if (rb.Equals(radCommaDelimiter))
                    delimiter = ',';
                else if (rb.Equals(radSemicolonDelimiter))
                    delimiter = ';';
                else if (rb.Equals(radPipeDelimiter))
                    delimiter = '|';
                else if (rb.Equals(radTabDelimiter))
                    delimiter = '\t';
                else if (rb.Equals(radOtherDelimiter))
                {
                    txtDelimiterChar.Enabled = true;
                    if(txtDelimiterChar.Text.Length > 0)
                        delimiter = txtDelimiterChar.Text.ToCharArray(0, 1)[0];                                       
                }
            }
            _importSpec.delimiter = delimiter.ToString();
            RefreshData();
        }         

        private void txtDelimiterChar_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("TextChanged");
            RefreshData();
        }

        private void frmImportDelimited_Load(object sender, EventArgs e)
        {
            txtDataFileName.Text = "";

            // Set up OpenFileDialog control
            dlgOpenDataFile.Filter = "Delimited Files (*.csv;*.tab;*.txt)|*.csv;*.tab;*.txt|All Files (*.*)|*.*";
            dlgOpenDataFile.DefaultExt = "*.csv;*.tab;*.txt";
            dlgOpenDataFile.Multiselect = false;
            dlgOpenDataFile.ReadOnlyChecked = true;
            dlgSaveSchema.SupportMultiDottedExtensions = true;
            dlgOpenDataFile.ShowReadOnly = false;
            dlgOpenDataFile.Title = "Open Delimited File";
            dlgOpenDataFile.ShowHelp = false;
            dlgOpenDataFile.InitialDirectory = Application.StartupPath;

            // Set up SaveFileDialog control
            dlgSaveSchema.Filter = "Schema Files (*.xsd)|*.xsd|All Files (*.*)|*.*";
            dlgSaveSchema.DefaultExt = "*.xsd";
            dlgSaveSchema.SupportMultiDottedExtensions = true;
            dlgSaveSchema.OverwritePrompt = true;
            dlgSaveSchema.AddExtension = true;
            dlgSaveSchema.Title = "Save Schema As";
            dlgSaveSchema.ShowHelp = false;
            dlgSaveSchema.InitialDirectory = Application.StartupPath;           
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //TODO: Save the current specification
        }

        private void btnSaveSchemaAs_Click(object sender, EventArgs e)
        {
            if (!dlgSaveSchema.FileName.EndsWith(".xsd"))
                dlgSaveSchema.FileName += ".xsd";
            dlgSaveSchema.ShowDialog(this);
        }

        private void dlgSaveSchema_FileOk(object sender, CancelEventArgs e)
        {
            SaveSchema();
        }

        private void SaveSchema()
        {
            if (dlgSaveSchema.FileName.Trim() == String.Empty)
                return;
            if (!dlgSaveSchema.FileName.EndsWith(".xsd"))
                dlgSaveSchema.FileName += ".xsd";

            //get a zero row DataTable based on currently selected file import parameters
            //TextReader tr = new StreamReader(dlgOpenDataFile.FileName);
            //DataTable dt = CsvParser.ParseUsingFileHelpers(dlgOpenDataFile.FileName, chkHeaders.Checked, delimiter.ToString(), 1);
            DataTable dt = _importSpec.getData(1);
            if (dt != null)
            {
                dt.TableName = "STELLAR"; //needs a name or write doesnt work - why not just use file name (minus extension?)
                //Write the schema of the DataTable to the selected file          
                dt.WriteXmlSchema(dlgSaveSchema.FileName);
            }
            txtSchemaFileName.Text = dlgSaveSchema.FileName;
        }

        private void lstExamples_MouseMove(object sender, MouseEventArgs e)
        {
            int x = 0;

            foreach (ColumnHeader column in lstExamples.Columns)
            {
                x += column.Width;
                if (e.X < x)
                {
                    //this is the current column...want to highlight it... 

                }
                   
            }            

            /*ListViewHitTestInfo ht = lstExamples.HitTest(e.X,e.Y);
            if (ht.Item != null)
            {
                System.Diagnostics.Debug.WriteLine(ht.Item.Name);
            }
            
            if(ht.SubItem != null)
            {
                System.Diagnostics.Debug.WriteLine(ht.SubItem.Name);
            }  */ 

        }

       
    }
}
