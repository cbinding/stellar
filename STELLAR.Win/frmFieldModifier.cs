using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modifiers;

namespace STELLAR.APP
{
    public partial class frmFieldModifier : Form
    {
        private IModifier<String> _modifier;

        public frmFieldModifier()
        {
            InitializeComponent();
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public IModifier<String> modifier
        {
            get
            {
                switch (cboModifierType.SelectedIndex)
                {
                    case 1:
                        //Add prefix
                        _modifier = new AddPrefix(txtPrefix.Text);
                        break;
                    case 2:
                        //Add suffix
                        _modifier = new AddSuffix(txtSuffix.Text);
                        break;
                    case 3:
                        //Extract text                        
                        _modifier = new ExtractText(Convert.ToInt32(txtStartPos.Text), Convert.ToInt32(txtExtractLength.Text));
                        break;
                    case 4:
                        //Replace text
                        _modifier = new ReplaceText(txtFindWhat.Text, txtReplaceWith.Text);
                        break;
                    case 5:
                        //Lowercase
                        _modifier = new ToLowerCase();
                        break;
                    case 6:
                        //Uppercase
                        _modifier = new ToUpperCase();
                        break;
                    case 7:
                        //UrlEncode
                        _modifier = new UrlEncode();
                        break;
                    default:
                        //default is Trim spaces
                        _modifier = new TrimSpace();
                        break;

                }
                return _modifier;
            }
            set
            {
                _modifier = value;
                //populate fields
                if (_modifier is AddPrefix)
                {
                    cboModifierType.SelectedIndex = 1;
                    txtPrefix.Text = _modifier.getProperty("prefix");
                }
                else if (_modifier is AddSuffix)
                {
                    cboModifierType.SelectedIndex = 2;
                    txtSuffix.Text = _modifier.getProperty("suffix");
                }
                else if (_modifier is ExtractText)
                {
                    cboModifierType.SelectedIndex = 3;
                    txtStartPos.Text = _modifier.getProperty("startPos");
                    txtExtractLength.Text = _modifier.getProperty("length");
                }
                else if (_modifier is ReplaceText)
                {
                    cboModifierType.SelectedIndex = 4;
                    txtFindWhat.Text = _modifier.getProperty("replaceWhat");
                    txtReplaceWith.Text = _modifier.getProperty("replaceWith");
                }
                else if (_modifier is ToLowerCase)
                {
                    cboModifierType.SelectedIndex = 5;
                }
                else if (_modifier is ToUpperCase)
                {
                    cboModifierType.SelectedIndex = 6;
                }
                else if (_modifier is UrlEncode)
                {
                    cboModifierType.SelectedIndex = 7;
                }
                else
                {
                    //Default - assume trim spaces
                    cboModifierType.SelectedIndex = 0;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboModifierType_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpParameters.Controls.Clear();
            switch (cboModifierType.SelectedIndex)
            {
                case 0:
                    //trim spaces
                    break;
                case 1:
                    //Add prefix
                    grpParameters.Controls.Add(pnlAddPrefix);
                    break;
                case 2:
                    //Add suffix
                    grpParameters.Controls.Add(pnlAddSuffix); 
                    break;
                case 3:
                    //Extract text
                    grpParameters.Controls.Add(pnlExtractText); 
                    break;
                case 4:
                    //Replace text
                    grpParameters.Controls.Add(pnlReplaceText);
                    break;

            }
            if(grpParameters.Controls.Count > 0)
                grpParameters.Controls[0].Location = new Point(15, 15);
                    
        }        
    }
}
