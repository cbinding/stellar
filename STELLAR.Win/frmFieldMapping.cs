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
    public partial class frmFieldMapping : Form
    {
        private STELLAR.DATA.FieldMapping _fieldMapping;

        public frmFieldMapping()
        {
            InitializeComponent();
            _fieldMapping = new STELLAR.Data.FieldMapping();
            lstModifiers.Items.Clear();

            // get list of all schema fields

            // get list of all template fields

        }

        private void lstModifiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnMoveUp.Enabled = false;
            btnMoveDown.Enabled = false;

            if (lstModifiers.Items.Count > 1 && lstModifiers.SelectedIndex >= 0)
            {
                if(lstModifiers.SelectedIndex == 0)
                {
                    btnMoveDown.Enabled = true;
                }
                else if (lstModifiers.SelectedIndex == lstModifiers.Items.Count - 1)
                {
                    btnMoveUp.Enabled = true;
                }
                else
                {
                    btnMoveUp.Enabled = true;
                    btnMoveDown.Enabled = true;
                }
            }            
        }

        private void btnEditModifier_Click(object sender, EventArgs e)
        {
            if (lstModifiers.SelectedIndex >= 0)
            {
                frmFieldModifier f = new frmFieldModifier();
                f.modifier = (Modifiers.IModifier<String>)lstModifiers.SelectedItem;
                f.ShowDialog(this);
                lstModifiers.SelectedItem = f.modifier;
            }
        }

        private void btnAddModifier_Click(object sender, EventArgs e)
        {
            frmFieldModifier f = new frmFieldModifier();
            f.ShowDialog(this);
            lstModifiers.Items.Add(f.modifier);
        }

        private void frmFieldMapping_Load(object sender, EventArgs e)
        {

        }

        public STELLAR.DATA.FieldMapping fieldMapping 
        { 
            get 
            {
                return _fieldMapping;
            } 
            set 
            {
                _fieldMapping = value;
                //populate fields
                cmbSchemaField.Text = _fieldMapping.schemaFieldName; // tmp...
                cmbTemplateField.Text = fieldMapping.templateFieldName; //tmp...
                lstModifiers.Items.Clear();
                foreach (Modifiers.IModifier<String> m in _fieldMapping.fieldModifiers)
                {
                    lstModifiers.Items.Add(m);
                }
            } 
        }

        private void cmbSchemaField_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            this.fieldMapping.schemaFieldName = cmb.Text;
        }

        private void cmbTemplateField_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            this.fieldMapping.templateFieldName = cmb.Text;
        }

        private void lstModifiers_DoubleClick(object sender, EventArgs e)
        {
            ListBox lst = (ListBox)sender;
            if (lst.SelectedIndex >= 0)
            {
                //edit currently selected modifier
            }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            //todo - save changes
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if(lstModifiers.SelectedIndex > 0)
            {     
                int i = lstModifiers.SelectedIndex;
                object obj = lstModifiers.SelectedItem;
                lstModifiers.Items.RemoveAt(i);
                lstModifiers.Items.Insert(i - 1, obj);
                lstModifiers.SelectedItem = obj;
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (lstModifiers.SelectedIndex >= 0 && lstModifiers.SelectedIndex < lstModifiers.Items.Count - 1)
            {
                int i = lstModifiers.SelectedIndex;
                object obj = lstModifiers.SelectedItem;
                lstModifiers.Items.RemoveAt(i);
                lstModifiers.Items.Insert(i + 1, obj);
                lstModifiers.SelectedItem = obj;
            }
        }

        private void btnDeleteModifier_Click(object sender, EventArgs e)
        {
            if(lstModifiers.SelectedItem != null)
                lstModifiers.Items.Remove(lstModifiers.SelectedItem);
        }
    }
}
