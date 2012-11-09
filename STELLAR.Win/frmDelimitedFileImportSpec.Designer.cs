namespace STELLAR.Win
{
    partial class frmDelimitedFileImportSpec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelimitedFileImportSpec));
            this.dlgOpenDataFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDelimiterChar = new System.Windows.Forms.TextBox();
            this.radOtherDelimiter = new System.Windows.Forms.RadioButton();
            this.radPipeDelimiter = new System.Windows.Forms.RadioButton();
            this.radCommaDelimiter = new System.Windows.Forms.RadioButton();
            this.radSemicolonDelimiter = new System.Windows.Forms.RadioButton();
            this.radTabDelimiter = new System.Windows.Forms.RadioButton();
            this.lstExamples = new System.Windows.Forms.ListView();
            this.chkHeaders = new System.Windows.Forms.CheckBox();
            this.btnOpenDataFile = new System.Windows.Forms.Button();
            this.txtDataFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSchemaFileName = new System.Windows.Forms.TextBox();
            this.btnSaveSchemaAs = new System.Windows.Forms.Button();
            this.dlgSaveSchema = new System.Windows.Forms.SaveFileDialog();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lstFieldModifiers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.radPipeDelimiter);
            this.groupBox1.Controls.Add(this.radCommaDelimiter);
            this.groupBox1.Controls.Add(this.radSemicolonDelimiter);
            this.groupBox1.Controls.Add(this.radTabDelimiter);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text delimited by";
            // 
            // txtDelimiterChar
            // 
            this.txtDelimiterChar.Enabled = false;
            this.txtDelimiterChar.Location = new System.Drawing.Point(432, 18);
            this.txtDelimiterChar.MaxLength = 1;
            this.txtDelimiterChar.Name = "txtDelimiterChar";
            this.txtDelimiterChar.Size = new System.Drawing.Size(25, 20);
            this.txtDelimiterChar.TabIndex = 5;
            this.txtDelimiterChar.WordWrap = false;
            this.txtDelimiterChar.TextChanged += new System.EventHandler(this.txtDelimiterChar_TextChanged);
            // 
            // radOtherDelimiter
            // 
            this.radOtherDelimiter.AutoSize = true;
            this.radOtherDelimiter.Location = new System.Drawing.Point(372, 19);
            this.radOtherDelimiter.Name = "radOtherDelimiter";
            this.radOtherDelimiter.Size = new System.Drawing.Size(54, 17);
            this.radOtherDelimiter.TabIndex = 4;
            this.radOtherDelimiter.Text = "Other:";
            this.radOtherDelimiter.UseVisualStyleBackColor = true;
            this.radOtherDelimiter.CheckedChanged += new System.EventHandler(this.delimiter_CheckedChanged);
            // 
            // radPipeDelimiter
            // 
            this.radPipeDelimiter.AutoSize = true;
            this.radPipeDelimiter.Location = new System.Drawing.Point(285, 19);
            this.radPipeDelimiter.Name = "radPipeDelimiter";
            this.radPipeDelimiter.Size = new System.Drawing.Size(46, 17);
            this.radPipeDelimiter.TabIndex = 3;
            this.radPipeDelimiter.Text = "Pipe";
            this.radPipeDelimiter.UseVisualStyleBackColor = true;
            this.radPipeDelimiter.CheckedChanged += new System.EventHandler(this.delimiter_CheckedChanged);
            // 
            // radCommaDelimiter
            // 
            this.radCommaDelimiter.AutoSize = true;
            this.radCommaDelimiter.Checked = true;
            this.radCommaDelimiter.Location = new System.Drawing.Point(193, 19);
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
            this.radSemicolonDelimiter.Location = new System.Drawing.Point(89, 19);
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
            this.radTabDelimiter.Location = new System.Drawing.Point(7, 19);
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
            this.lstExamples.Location = new System.Drawing.Point(12, 348);
            this.lstExamples.Name = "lstExamples";
            this.lstExamples.Size = new System.Drawing.Size(467, 127);
            this.lstExamples.TabIndex = 1;
            this.lstExamples.UseCompatibleStateImageBehavior = false;
            this.lstExamples.View = System.Windows.Forms.View.Details;
            this.lstExamples.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstExamples_MouseMove);
            // 
            // chkHeaders
            // 
            this.chkHeaders.AutoSize = true;
            this.chkHeaders.Location = new System.Drawing.Point(19, 125);
            this.chkHeaders.Name = "chkHeaders";
            this.chkHeaders.Size = new System.Drawing.Size(170, 17);
            this.chkHeaders.TabIndex = 3;
            this.chkHeaders.Text = "First row contains field names?";
            this.chkHeaders.UseVisualStyleBackColor = true;
            this.chkHeaders.CheckedChanged += new System.EventHandler(this.chkHeaders_CheckedChanged);
            // 
            // btnOpenDataFile
            // 
            this.btnOpenDataFile.Location = new System.Drawing.Point(454, 25);
            this.btnOpenDataFile.Name = "btnOpenDataFile";
            this.btnOpenDataFile.Size = new System.Drawing.Size(25, 20);
            this.btnOpenDataFile.TabIndex = 4;
            this.btnOpenDataFile.Text = "...";
            this.btnOpenDataFile.UseVisualStyleBackColor = true;
            this.btnOpenDataFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // txtDataFileName
            // 
            this.txtDataFileName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDataFileName.Enabled = false;
            this.txtDataFileName.Location = new System.Drawing.Point(13, 25);
            this.txtDataFileName.Name = "txtDataFileName";
            this.txtDataFileName.ReadOnly = true;
            this.txtDataFileName.Size = new System.Drawing.Size(435, 20);
            this.txtDataFileName.TabIndex = 12;
            this.txtDataFileName.Text = "MOLA_ENV2_ABONE.csv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Delimited Text File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Save Schema As";
            // 
            // txtSchemaFileName
            // 
            this.txtSchemaFileName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSchemaFileName.Enabled = false;
            this.txtSchemaFileName.Location = new System.Drawing.Point(13, 494);
            this.txtSchemaFileName.Name = "txtSchemaFileName";
            this.txtSchemaFileName.ReadOnly = true;
            this.txtSchemaFileName.Size = new System.Drawing.Size(436, 20);
            this.txtSchemaFileName.TabIndex = 18;
            this.txtSchemaFileName.Text = "MOLA_ENV2_ABONE.xml";
            // 
            // btnSaveSchemaAs
            // 
            this.btnSaveSchemaAs.Location = new System.Drawing.Point(454, 493);
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
            // btnOK
            // 
            //this.btnOK.Image = Stellar.Win.Properties.Resources.accept;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(321, 521);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 24);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            //this.btnCancel.Image = Stellar.Win.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(403, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 25);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.lstFieldModifiers);
            this.groupBox2.Location = new System.Drawing.Point(13, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 151);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Field Modifiers";
            // 
            // button5
            // 
            //this.button5.Image = Stellar.Win.Properties.Resources.delete;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(382, 120);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 22);
            this.button5.TabIndex = 42;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            //this.button4.Image = Stellar.Win.Properties.Resources.add;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(222, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 22);
            this.button4.TabIndex = 41;
            this.button4.Text = "Add...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            //this.button3.Image = Stellar.Win.Properties.Resources.pencil;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(302, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 22);
            this.button3.TabIndex = 40;
            this.button3.Text = "Edit...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lstFieldModifiers
            // 
            this.lstFieldModifiers.FormattingEnabled = true;
            this.lstFieldModifiers.Location = new System.Drawing.Point(6, 19);
            this.lstFieldModifiers.Name = "lstFieldModifiers";
            this.lstFieldModifiers.ScrollAlwaysVisible = true;
            this.lstFieldModifiers.Size = new System.Drawing.Size(450, 95);
            this.lstFieldModifiers.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Preview";
            // 
            // frmDelimitedFileImportSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 557);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSaveSchemaAs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSchemaFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataFileName);
            this.Controls.Add(this.btnOpenDataFile);
            this.Controls.Add(this.chkHeaders);
            this.Controls.Add(this.lstExamples);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDelimitedFileImportSpec";
            this.Text = "Delimited File Import";
            this.Load += new System.EventHandler(this.frmImportDelimited_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpenDataFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDelimiterChar;
        private System.Windows.Forms.RadioButton radOtherDelimiter;
        private System.Windows.Forms.RadioButton radPipeDelimiter;
        private System.Windows.Forms.RadioButton radCommaDelimiter;
        private System.Windows.Forms.RadioButton radSemicolonDelimiter;
        private System.Windows.Forms.RadioButton radTabDelimiter;
        private System.Windows.Forms.ListView lstExamples;
        private System.Windows.Forms.CheckBox chkHeaders;
        private System.Windows.Forms.Button btnOpenDataFile;
        private System.Windows.Forms.TextBox txtDataFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSchemaFileName;
        private System.Windows.Forms.Button btnSaveSchemaAs;
        private System.Windows.Forms.SaveFileDialog dlgSaveSchema;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstFieldModifiers;
        private System.Windows.Forms.Label label3;
    }
}

