namespace STELLAR.APP
{
    partial class frmFieldModifier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboModifierType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpParameters = new System.Windows.Forms.GroupBox();
            this.pnlAddPrefix = new System.Windows.Forms.Panel();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAddSuffix = new System.Windows.Forms.Panel();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlExtractText = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExtractLength = new System.Windows.Forms.TextBox();
            this.txtStartPos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlReplaceText = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.txtFindWhat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlAddPrefix.SuspendLayout();
            this.pnlAddSuffix.SuspendLayout();
            this.pnlExtractText.SuspendLayout();
            this.pnlReplaceText.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboModifierType
            // 
            this.cboModifierType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModifierType.FormattingEnabled = true;
            this.cboModifierType.Items.AddRange(new object[] {
            "Trim Spaces",
            "Add Prefix",
            "Add Suffix",
            "Extract Text",
            "Replace Text",
            "Convert to Lower Case",
            "Convert to Upper Case",
            "URL Encode"});
            this.cboModifierType.Location = new System.Drawing.Point(15, 25);
            this.cboModifierType.Name = "cboModifierType";
            this.cboModifierType.Size = new System.Drawing.Size(286, 21);
            this.cboModifierType.TabIndex = 0;
            this.cboModifierType.SelectedIndexChanged += new System.EventHandler(this.cboModifierType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modifier Type";
            // 
            // btnOK
            // 
            this.btnOK.Image = global::STELLAR.APP.Properties.Resources.accept;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(135, 130);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 29);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::STELLAR.APP.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(221, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpParameters
            // 
            this.grpParameters.Location = new System.Drawing.Point(15, 55);
            this.grpParameters.Name = "grpParameters";
            this.grpParameters.Size = new System.Drawing.Size(286, 69);
            this.grpParameters.TabIndex = 5;
            this.grpParameters.TabStop = false;
            this.grpParameters.Text = "Parameters";
            // 
            // pnlAddPrefix
            // 
            this.pnlAddPrefix.Controls.Add(this.txtPrefix);
            this.pnlAddPrefix.Controls.Add(this.label2);
            this.pnlAddPrefix.Location = new System.Drawing.Point(15, 196);
            this.pnlAddPrefix.Name = "pnlAddPrefix";
            this.pnlAddPrefix.Size = new System.Drawing.Size(261, 48);
            this.pnlAddPrefix.TabIndex = 6;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(6, 16);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(244, 20);
            this.txtPrefix.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prefix";
            // 
            // pnlAddSuffix
            // 
            this.pnlAddSuffix.Controls.Add(this.txtSuffix);
            this.pnlAddSuffix.Controls.Add(this.label3);
            this.pnlAddSuffix.Location = new System.Drawing.Point(15, 250);
            this.pnlAddSuffix.Name = "pnlAddSuffix";
            this.pnlAddSuffix.Size = new System.Drawing.Size(261, 49);
            this.pnlAddSuffix.TabIndex = 7;
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(6, 16);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(244, 20);
            this.txtSuffix.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Suffix";
            // 
            // pnlExtractText
            // 
            this.pnlExtractText.Controls.Add(this.label5);
            this.pnlExtractText.Controls.Add(this.txtExtractLength);
            this.pnlExtractText.Controls.Add(this.txtStartPos);
            this.pnlExtractText.Controls.Add(this.label4);
            this.pnlExtractText.Location = new System.Drawing.Point(15, 305);
            this.pnlExtractText.Name = "pnlExtractText";
            this.pnlExtractText.Size = new System.Drawing.Size(261, 49);
            this.pnlExtractText.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Length";
            // 
            // txtExtractLength
            // 
            this.txtExtractLength.Location = new System.Drawing.Point(131, 16);
            this.txtExtractLength.Name = "txtExtractLength";
            this.txtExtractLength.Size = new System.Drawing.Size(119, 20);
            this.txtExtractLength.TabIndex = 2;
            // 
            // txtStartPos
            // 
            this.txtStartPos.Location = new System.Drawing.Point(6, 16);
            this.txtStartPos.Name = "txtStartPos";
            this.txtStartPos.Size = new System.Drawing.Size(119, 20);
            this.txtStartPos.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Start Position";
            // 
            // pnlReplaceText
            // 
            this.pnlReplaceText.Controls.Add(this.label6);
            this.pnlReplaceText.Controls.Add(this.txtReplaceWith);
            this.pnlReplaceText.Controls.Add(this.txtFindWhat);
            this.pnlReplaceText.Controls.Add(this.label7);
            this.pnlReplaceText.Location = new System.Drawing.Point(15, 360);
            this.pnlReplaceText.Name = "pnlReplaceText";
            this.pnlReplaceText.Size = new System.Drawing.Size(261, 49);
            this.pnlReplaceText.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Replace Text";
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Location = new System.Drawing.Point(134, 16);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(119, 20);
            this.txtReplaceWith.TabIndex = 2;
            // 
            // txtFindWhat
            // 
            this.txtFindWhat.AcceptsReturn = true;
            this.txtFindWhat.Location = new System.Drawing.Point(6, 16);
            this.txtFindWhat.Name = "txtFindWhat";
            this.txtFindWhat.Size = new System.Drawing.Size(119, 20);
            this.txtFindWhat.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Find Text";
            // 
            // frmFieldModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 170);
            this.Controls.Add(this.pnlReplaceText);
            this.Controls.Add(this.pnlExtractText);
            this.Controls.Add(this.pnlAddSuffix);
            this.Controls.Add(this.pnlAddPrefix);
            this.Controls.Add(this.grpParameters);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboModifierType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFieldModifier";
            this.Text = "Field Modifier";
            this.pnlAddPrefix.ResumeLayout(false);
            this.pnlAddPrefix.PerformLayout();
            this.pnlAddSuffix.ResumeLayout(false);
            this.pnlAddSuffix.PerformLayout();
            this.pnlExtractText.ResumeLayout(false);
            this.pnlExtractText.PerformLayout();
            this.pnlReplaceText.ResumeLayout(false);
            this.pnlReplaceText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboModifierType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpParameters;
        private System.Windows.Forms.Panel pnlAddPrefix;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlAddSuffix;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlExtractText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExtractLength;
        private System.Windows.Forms.TextBox txtStartPos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlReplaceText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReplaceWith;
        private System.Windows.Forms.TextBox txtFindWhat;
        private System.Windows.Forms.Label label7;
    }
}