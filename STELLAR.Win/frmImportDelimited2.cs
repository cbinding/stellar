using System;
using System.IO;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;

namespace STELLAR.APP
{
    public partial class frmImportDelimited : Form
    {
        private char delimiter = ',';
        
        public frmImportDelimited()
        {
            InitializeComponent();
        }        

        private void btnChooseFile_Click(object sender, EventArgs e)
        {          
            dlgOpenDataFile.ShowDialog(this);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //TODO: Save the current specification

            this.Close(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dlgOpenFile_FileOk(object sender, CancelEventArgs e)
        {
            txtFileName.Text = dlgOpenDataFile.FileName;

            if (File.Exists(dlgOpenDataFile.FileName))
            {
                RefreshData();                             
            }          

        }        

        private void RefreshData()
        {
            try
            {
                lstExamples.Columns.Clear();
                lstExamples.Items.Clear();
                
                if (!File.Exists(txtFileName.Text))
                    return;

                // Parse just first few rows of file into DataTable for viewing
                TextReader tr = new StreamReader(txtFileName.Text);
                DataTable dt = CsvParser.Parse(tr, chkHeaders.Checked, delimiter, 20);
                
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
                else if (rb.Equals(radSpaceDelimiter))
                    delimiter = ' ';
                else if (rb.Equals(radTabDelimiter))
                    delimiter = '\t';
                else if (rb.Equals(radOtherDelimiter))
                {
                    txtDelimiterChar.Enabled = true;
                    if(txtDelimiterChar.Text.Length > 0)
                        delimiter = txtDelimiterChar.Text.ToCharArray(0, 1)[0];                                       
                }
            }
            RefreshData();
        }         

        private void txtDelimiterChar_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("TextChanged");
            RefreshData();
        }

        private void frmImportDelimited_Load(object sender, EventArgs e)
        {
            txtFileName.Text = "";

            // Set up OpenFileDialog control
            dlgOpenDataFile.Filter = "Delimited Files (*.csv;*.tab;*.txt)|*.csv;*.tab;*.txt|All Files (*.*)|*.*";
            dlgOpenDataFile.DefaultExt = "*.csv;*.tab;*.txt";
            dlgOpenDataFile.Multiselect = false;
            dlgOpenDataFile.ReadOnlyChecked = true;
            dlgOpenDataFile.ShowReadOnly = false;
            dlgOpenDataFile.Title = "Open Delimited File";
            dlgOpenDataFile.ShowHelp = false;
            dlgOpenDataFile.InitialDirectory = Application.StartupPath;

            // Set up SaveFileDialog control
            dlgSaveSchema.Filter = "Schema Files (*.xsd)|*.xsd|All Files (*.*)|*.*";
            dlgSaveSchema.DefaultExt = "*.xsd";
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
            dlgSaveSchema.FileName = dlgOpenDataFile.FileName;
            if (!dlgSaveSchema.FileName.EndsWith(".xsd"))
                dlgSaveSchema.FileName += ".xsd";
            dlgSaveSchema.ShowDialog(this);
        }

        private void dlgSaveSchema_FileOk(object sender, CancelEventArgs e)
        {
            //get a zero row DataTable based on currently selected file import parameters
            TextReader tr = new StreamReader(dlgOpenDataFile.FileName);
            DataTable dt = CsvParser.Parse(tr, chkHeaders.Checked, delimiter, 0);
            dt.TableName = "STELLAR"; //needs a name or write doesnt work
            if (dt != null)
            {   //Write the schema of the DataTable to the selected file          
                dt.WriteXmlSchema(dlgSaveSchema.FileName);
            }
        }        
    }
}
