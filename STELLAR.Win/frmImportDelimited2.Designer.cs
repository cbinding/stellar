namespace STELLAR.APP
{
    partial class frmImportDelimited
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
            this.dlgOpenDataFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDelimiterChar = new System.Windows.Forms.TextBox();
            this.radOtherDelimiter = new System.Windows.Forms.RadioButton();
            this.radSpaceDelimiter = new System.Windows.Forms.RadioButton();
            this.radCommaDelimiter = new System.Windows.Forms.RadioButton();
            this.radSemicolonDelimiter = new System.Windows.Forms.RadioButton();
            this.radTabDelimiter = new System.Windows.Forms.RadioButton();
            this.lstExamples = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEnclosingChar = new System.Windows.Forms.TextBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.chkHeaders = new System.Windows.Forms.CheckBox();
            this.btnOpenDataFile = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSaveSchemaAs = new System.Windows.Forms.Button();
            this.dlgSaveSchema = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgOpenDataFile
            // 
            this.dlgOpenDataFile.Title = "Choose Delimited File";
            this.dlgOpenDataFile.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpenFile_FileOk);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDelimiterChar);
            this.groupBox1.Controls.Add(this.radOtherDelimiter);
            this.groupBox1.Controls.Add(this.radSpaceDelimiter);
            this.groupBox1.Controls.Add(this.radCommaDelimiter);
            this.groupBox1.Controls.Add(this.radSemicolonDelimiter);
            this.groupBox1.Controls.Add(this.radTabDelimiter);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text delimited by";
            // 
            // txtDelimiterChar
            // 
            this.txtDelimiterChar.Enabled = false;
            this.txtDelimiterChar.Location = new System.Drawing.Point(323, 19);
            this.txtDelimiterChar.MaxLength = 1;
            this.txtDelimiterChar.Name = "txtDelimiterChar";
            this.txtDelimiterChar.Size = new System.Drawing.Size(34, 20);
            this.txtDelimiterChar.TabIndex = 5;
            this.txtDelimiterChar.Text = "|";
            this.txtDelimiterChar.WordWrap = false;
            this.txtDelimiterChar.TextChanged += new System.EventHandler(this.txtDelimiterChar_TextChanged);
            // 
            // radOtherDelimiter
            // 
            this.radOtherDelimiter.AutoSize = true;
            this.radOtherDelimiter.Location = new System.Drawing.Point(274, 19);
            this.radOtherDelimiter.Name = "radOtherDelimiter";
            this.radOtherDelimiter.Size = new System.Drawing.Size(54, 17);
            this.radOtherDelimiter.TabIndex = 4;
            this.radOtherDelimiter.Text = "Other:";
            this.radOtherDelimiter.UseVisualStyleBackColor = true;
            this.radOtherDelimiter.CheckedChanged += new System.EventHandler(this.delimiter_CheckedChanged);
            // 
            // radSpaceDelimiter
            // 
            this.radSpaceDelimiter.AutoSize = true;
            this.radSpaceDelimiter.Location = new System.Drawing.Point(212, 19);
            this.radSpaceDelimiter.Name = "radSpaceDelimiter";
            this.radSpaceDelimiter.Size = new System.Drawing.Size(56, 17);
            this.radSpaceDelimiter.TabIndex = 3;
            this.radSpaceDelimiter.Text = "Space";
            this.radSpaceDelimiter.UseVisualStyleBackColor = true;
            this.radSpaceDelimiter.CheckedChanged += new System.EventHandler(this.delimiter_CheckedChanged);
            // 
            // radCommaDelimiter
            // 
            this.radCommaDelimiter.AutoSize = true;
            this.radCommaDelimiter.Checked = true;
            this.radCommaDelimiter.Location = new System.Drawing.Point(146, 19);
            this.radCommaDelimiter.Name = "radCommaDelimiter";
            this.radCommaDelimiter.Size = new System.Drawing.Size(60, 17);
            this.radCommaDelimiter.TabIndex = 2;
            this.radCommaDelimiter.TabStop = true;
            this.radCommaDelimiter.Text = "Comma";
            this.radCommaDelimiter.UseVisualStyleBackColor = true;
            this.radCommaDelimiter.CheckedChanged += new System.EventHandler(this.delimiter_CheckedChanged);
            // 
            // radSemicolonDelimiter
            // 
            this.radSemicolonDelimiter.AutoSize = true;
            this.radSemicolonDelimiter.Location = new System.Drawing.Point(66, 19);
            this.radSemicolonDelimiter.Name = "radSemicolonDelimiter";
            this.radSemicolonDelimiter.Size = new System.Drawing.Size(74, 17);
            this.radSemicolonDelimiter.TabIndex = 1;
            this.radSemicolonDelimiter.Text = "Semicolon";
            this.radSemicolonDelimiter.UseVisualStyleBackColor = true;
            this.radSemicolonDelimiter.CheckedChanged += new System.EventHandler(this.delimiter_CheckedChanged);
            // 
            // radTabDelimiter
            // 
            this.radTabDelimiter.AutoSize = true;
            this.radTabDelimiter.Location = new System.Drawing.Point(16, 19);
            this.radTabDelimiter.Name = "radTabDelimiter";
            this.radTabDelimiter.Size = new System.Drawing.Size(44, 17);
            this.radTabDelimiter.TabIndex = 0;
            this.radTabDelimiter.Text = "Tab";
            this.radTabDelimiter.UseVisualStyleBackColor = true;
            this.radTabDelimiter.CheckedChanged += new System.EventHandler(this.delimiter_CheckedChanged);
            // 
            // lstExamples
            // 
            this.lstExamples.FullRowSelect = true;
            this.lstExamples.Location = new System.Drawing.Point(12, 144);
            this.lstExamples.Name = "lstExamples";
            this.lstExamples.Size = new System.Drawing.Size(619, 137);
            this.lstExamples.TabIndex = 1;
            this.lstExamples.UseCompatibleStateImageBehavior = false;
            this.lstExamples.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEnclosingChar);
            this.groupBox2.Controls.Add(this.radioButton9);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Location = new System.Drawing.Point(391, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text enclosed in";
            // 
            // txtEnclosingChar
            // 
            this.txtEnclosingChar.AcceptsReturn = true;
            this.txtEnclosingChar.Location = new System.Drawing.Point(194, 19);
            this.txtEnclosingChar.Name = "txtEnclosingChar";
            this.txtEnclosingChar.Size = new System.Drawing.Size(34, 20);
            this.txtEnclosingChar.TabIndex = 7;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(143, 19);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(54, 17);
            this.radioButton9.TabIndex = 6;
            this.radioButton9.Text = "Other:";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(107, 19);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(30, 17);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.Text = "\"";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(74, 19);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(27, 17);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.Text = "\'";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(17, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(51, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "None";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // chkHeaders
            // 
            this.chkHeaders.AutoSize = true;
            this.chkHeaders.Location = new System.Drawing.Point(15, 116);
            this.chkHeaders.Name = "chkHeaders";
            this.chkHeaders.Size = new System.Drawing.Size(170, 17);
            this.chkHeaders.TabIndex = 3;
            this.chkHeaders.Text = "First row contains field names?";
            this.chkHeaders.UseVisualStyleBackColor = true;
            this.chkHeaders.CheckedChanged += new System.EventHandler(this.chkHeaders_CheckedChanged);
            // 
            // btnOpenDataFile
            // 
            this.btnOpenDataFile.Location = new System.Drawing.Point(606, 25);
            this.btnOpenDataFile.Name = "btnOpenDataFile";
            this.btnOpenDataFile.Size = new System.Drawing.Size(25, 20);
            this.btnOpenDataFile.TabIndex = 4;
            this.btnOpenDataFile.Text = "...";
            this.btnOpenDataFile.UseVisualStyleBackColor = true;
            this.btnOpenDataFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(382, 349);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(79, 26);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(467, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 26);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(552, 349);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(79, 26);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFileName.Enabled = false;
            this.txtFileName.Location = new System.Drawing.Point(13, 25);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(583, 20);
            this.txtFileName.TabIndex = 12;
            this.txtFileName.Text = "MOLA_ENV2_ABONE.csv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Save As";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(12, 310);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(587, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "MOLA_ENV2_ABONE.xml";
            // 
            // btnSaveSchemaAs
            // 
            this.btnSaveSchemaAs.Location = new System.Drawing.Point(605, 310);
            this.btnSaveSchemaAs.Name = "btnSaveSchemaAs";
            this.btnSaveSchemaAs.Size = new System.Drawing.Size(25, 20);
            this.btnSaveSchemaAs.TabIndex = 20;
            this.btnSaveSchemaAs.Text = "...";
            this.btnSaveSchemaAs.UseVisualStyleBackColor = true;
            this.btnSaveSchemaAs.Click += new System.EventHandler(this.btnSaveSchemaAs_Click);
            // 
            // dlgSaveSchema
            // 
            this.dlgSaveSchema.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgSaveSchema_FileOk);
            // 
            // frmImportDelimited
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 574);
            this.Controls.Add(this.btnSaveSchemaAs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnOpenDataFile);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkHeaders);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstExamples);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportDelimited";
            this.Text = "Import Delimited Data";
            this.Load += new System.EventHandler(this.frmImportDelimited_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpenDataFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDelimiterChar;
        private System.Windows.Forms.RadioButton radOtherDelimiter;
        private System.Windows.Forms.RadioButton radSpaceDelimiter;
        private System.Windows.Forms.RadioButton radCommaDelimiter;
        private System.Windows.Forms.RadioButton radSemicolonDelimiter;
        private System.Windows.Forms.RadioButton radTabDelimiter;
        private System.Windows.Forms.ListView lstExamples;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEnclosingChar;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.CheckBox chkHeaders;
        private System.Windows.Forms.Button btnOpenDataFile;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSaveSchemaAs;
        private System.Windows.Forms.SaveFileDialog dlgSaveSchema;
    }
}

