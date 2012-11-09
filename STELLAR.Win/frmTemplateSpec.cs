using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Using StringTemplate library
using Antlr3.ST;
using Antlr3.ST.Language;

namespace STELLAR.APP
{
    public partial class frmTemplateSpec : Form
    {
        private StringTemplateGroup stg;
        private STELLAR.DATA.TemplateSpec _templateSpec = new STELLAR.DATA.TemplateSpec();       

        public frmTemplateSpec()
        {
            InitializeComponent();
        }
        
        private void btnReadTemplateFile_Click(object sender, EventArgs e)
        {
            dlgOpenTemplate.ShowDialog(this);
        }

        private void frmApplyTemplate_Load(object sender, EventArgs e)
        {
            // Set up OpenFileDialog control
            dlgOpenTemplate.Filter = "Template File (*.stg)|*.stg|All Files (*.*)|*.*";
            dlgOpenTemplate.DefaultExt = "*.stg";
            dlgOpenTemplate.Multiselect = false;
            dlgOpenTemplate.ReadOnlyChecked = true;
            dlgOpenTemplate.ShowReadOnly = false;
            dlgOpenTemplate.Title = "Read Template File";
            dlgOpenTemplate.ShowHelp = false;
            dlgOpenTemplate.InitialDirectory = Application.StartupPath;

            // Underlying TemplateSpec object stores the data
            _templateSpec = new STELLAR.DATA.TemplateSpec();            
        }

        private void dlgOpenTemplate_FileOk(object sender, CancelEventArgs e)
        {
            _templateSpec.templateFileName = dlgOpenTemplate.FileName.Trim();
            
            System.IO.TextReader tr;
            txtTemplateFileName.Text = _templateSpec.templateFileName;
            try
            {
                tr = new System.IO.StreamReader(_templateSpec.templateFileName);
                stg = new StringTemplateGroup(tr, typeof(TemplateLexer)); //lexer added to use $..$ in group templates instead of <..>
                //StringTemplate st = stg.GetInstanceOf("E57_URI");
                lstTemplates.Items.Clear();
                ICollection<String> names = stg.GetTemplateNames();

                //foreach (StringTemplate st in stg.Templates)
                foreach (String s in names)
                {
                    lstTemplates.Items.Add(s);
                }
                tr.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);
            }
            finally
            {

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnWrite_Click(btnWrite, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public STELLAR.DATA.TemplateSpec templateSpec 
        { 
            get 
            {
                return _templateSpec;
            } 
            set 
            {
                _templateSpec = value;
                //Populate fields
                txtDescription.Text = _templateSpec.description;
                txtTemplateFileName.Text = _templateSpec.templateFileName;
            } 
        }

        private void lstTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            _templateSpec.templateName = lstTemplates.SelectedItem.ToString().Trim();
            StringTemplate st = stg.GetInstanceOf(_templateSpec.templateName);
            
            //lvwAttributes.Items.Clear();
            //for (int i = 0; i < st.FormalArguments.Count; i++)
            //{
            //    ListViewItem lvwItem = lvwAttributes.Items.Add(st.FormalArguments[i].name);
            //    lvwItem.SubItems.Add("");
            //}
        }

        private void lvwAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lvwAttributes.SelectedItems.Count == 0)
            //    return;
            //ListViewItem lvwItem = lvwAttributes.SelectedItems[0];
            //txtAttributeName.Text = lvwItem.Text;
            //cmbSchemaField.Text = lvwItem.SubItems[1].Text;
        }
        
        //temp serialization tests
        private void btnRead_Click(object sender, EventArgs e)
        {
            //Read process details from file and populate fields
            _templateSpec = STELLAR.DATA.TemplateSpec.load("tmp.xml");
            dlgOpenTemplate.FileName = _templateSpec.templateFileName;
            txtTemplateFileName.Text = _templateSpec.templateFileName;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            _templateSpec.saveAs("tmp.xml");
        }

        private void btnAddFieldMapping_Click(object sender, EventArgs e)
        {
            frmFieldMapping f = new frmFieldMapping();
            f.Show(this);
        }

        private void btnEditFieldMapping_Click(object sender, EventArgs e)
        {
            frmFieldMapping f = new frmFieldMapping();
            f.Show(this);
        }
          
    }
}
