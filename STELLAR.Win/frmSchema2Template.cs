using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileHelpers;

//Using StringTemplate library
using Antlr3.ST;
using Antlr3.ST.Language;

namespace STELLAR.APP
{
    public partial class frmSchema2Template : Form
    {
        private StringTemplateGroup stg;

        public frmSchema2Template()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*StringTemplate template = new StringTemplate(txtTemplate.Text);
            template.SetAttribute(txtName.Text, txtValue.Text);
            template.SetAttribute(txtName2.Text, txtValue2.Text);
            txtOutput.Text = template.ToString();
            */
            System.IO.TextReader tr = new System.IO.StreamReader("stellar_test_group.stg");
            StringTemplateGroup stg = new StringTemplateGroup(tr,typeof(TemplateLexer)); //lexer added to use $..$ in group templates instead of <..>
            StringTemplate st = stg.GetInstanceOf("E57_URI");
            StringTemplate st2 = stg.GetInstanceOf("E19_URI");
            StringTemplate st3 = stg.GetInstanceOf("E57");
            StringTemplate st4 = stg.GetInstanceOf("E19");            

            st2.SetAttribute("site", "molas");
            st2.SetAttribute("id", "12345");

            st3.SetAttribute("site", "molas");
            st3.SetAttribute("id", "12345");

            st4.SetAttribute("uri", st2.ToString());

            String s = st3.ToString(); 
            txtOutput.Text = s;
        }        

        private void UseOfStringTemplate_Load(object sender, EventArgs e)
        {
            // Set up OpenFileDialog control
            dlgOpenTemplate.Filter = "Template File (*.stg)|*.stg|All Files (*.*)|*.*";
            dlgOpenTemplate.DefaultExt = "*.stg";
            dlgOpenTemplate.Multiselect = false;
            dlgOpenTemplate.ReadOnlyChecked = true;
            dlgOpenTemplate.ShowReadOnly = false;
            dlgOpenTemplate.Title = "Open Template File";
            dlgOpenTemplate.ShowHelp = false;
            dlgOpenTemplate.InitialDirectory = Application.StartupPath;

            // Set up OpenFileDialog control
            dlgOpenSchema.Filter = "Schema File (*.xsd)|*.xsd|All Files (*.*)|*.*";
            dlgOpenSchema.DefaultExt = "*.xsd";
            dlgOpenSchema.Multiselect = false;
            dlgOpenSchema.ReadOnlyChecked = true;
            dlgOpenSchema.ShowReadOnly = false;
            dlgOpenSchema.Title = "Open Schema File";
            dlgOpenSchema.ShowHelp = false;
            dlgOpenSchema.InitialDirectory = Application.StartupPath;
        }        
        /*
        public long importDelimitedFile(string inputFileName)
        {
            inputFileName = inputFileName.Trim();
            FileHelperAsyncEngine inputFile = new FileHelperAsyncEngine(typeof(DelimitedRow));
            long recordCount = 0;

            if (!System.IO.File.Exists(inputFileName))
            {
                throw new Exception(string.Format("Problem finding file {0}?", inputFileName));
            }
            try
            {
                inputFile.BeginReadFile(inputFileName);
            }
            catch (System.Exception ex)
            {
                throw new Exception(string.Format("Problem reading file {0}?", inputFileName), ex);
            }
            foreach (DelimitedRow r in inputFile)
            {
                recordCount++;
            }
            inputFile.Close();            
            return (recordCount);
        }
        */
        private void btnReadSchema_Click(object sender, EventArgs e)
        {
            dlgOpenSchema.ShowDialog(this);
        }

        private void dlgOpenFile_FileOk(object sender, CancelEventArgs e)
        {
            txtSchemaFileName.Text = dlgOpenSchema.FileName;
            lstSchemaFields.Items.Clear();
            DataTable dt = new DataTable();
            dt.ReadXmlSchema(dlgOpenSchema.FileName);
            //dsMappings.Tables.Add(dt);
            //dsMappings.Tables["tblSchemaFields"].Load(dt.CreateDataReader());

            //lstSchemaFields.DataSource = dt;
            //lstSchemaFields.DisplayMember = dt.Columns[0].ColumnName;
            
            foreach (DataColumn dc in dt.Columns)
            {                
                lstSchemaFields.Items.Add(dc.Caption);
                //DataRow dr = dsMappings.Tables["tblSchemaFields"].NewRow();
                //dr.SetField("fieldName", dc.Caption);
                //dsMappings.Tables["tblSchemaFields"].Rows.Add(dr);
            }
            
        }

        private void btnReadTemplate_Click(object sender, EventArgs e)
        {
            dlgOpenTemplate.ShowDialog(this);
        }

        private void dlgOpenTemplate_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.TextReader tr;
            txtTemplateFileName.Text = dlgOpenTemplate.FileName;

            using(tr = new System.IO.StreamReader(dlgOpenTemplate.FileName))
            {
                //tr = new System.IO.StreamReader(dlgOpenTemplate.FileName);
                stg = new StringTemplateGroup(tr, typeof(TemplateLexer)); //lexer added to use $..$ in group templates instead of <..>
                //StringTemplate st = stg.GetInstanceOf("E57_URI");
                lstTemplates.Items.Clear();
                ICollection < String > names = stg.GetTemplateNames();

                //foreach (StringTemplate st in stg.Templates)
                foreach (String s in names)
                {
                    lstTemplates.Items.Add (s);
                }
                tr.Close();
            }           
        }
 
        private void txtEditTemplate_Click(object sender, EventArgs e)
        {
            frmEditFile f = new frmEditFile();
            f.Show();
            if (txtTemplateFileName.Text.Trim() != String.Empty)                
                f.openFile(txtTemplateFileName.Text.Trim());
        }

        private void lstTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringTemplate st = stg.GetInstanceOf(lstTemplates.SelectedItem.ToString());

            lstTemplateFields.Items.Clear();
            for (int i = 0; i < st.FormalArguments.Count; i++)
            {
                lstTemplateFields.Items.Add(st.FormalArguments[i].name);

            }
            /*
            lstAttributes.Items.Clear();
            if (st.Attributes != null)
            {
                foreach (object o in st.Attributes)
                {
                    lstAttributes.Items.Add(o.ToString());
                    //st.LookupFormalArgument("fred").;
                    
                }
            }*/
            //st.SetAttribute("fred", "hi");
        }

        //temp - bring up delimited file import for schema creation
        private void button5_Click(object sender, EventArgs e)
        {
            frmDelimitedFileImportSpec f = new frmDelimitedFileImportSpec();
            f.Show();
        }
                

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteMapping_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMapping_Click(object sender, EventArgs e)
        {

        }

        private void btnEditMapping_Click(object sender, EventArgs e)
        {

        }

        private void lstSchemaFields_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
