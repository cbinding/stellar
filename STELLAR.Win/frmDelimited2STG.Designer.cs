namespace STELLAR.Win
{
    partial class frmDelimited2STG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelimited2STG));
            this.dlgOpenDataFile = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemplateFileName = new System.Windows.Forms.TextBox();
            this.btnChooseTemplate = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.dlgSaveOutputFile = new System.Windows.Forms.SaveFileDialog();
            this.txtOptionsFileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChooseOptionsFile = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnEditTemplateFile = new System.Windows.Forms.Button();
            this.btnEditOptionsFile = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditDataFile = new System.Windows.Forms.Button();
            this.txtDataFileName = new System.Windows.Forms.TextBox();
            this.btnChooseDataFile = new System.Windows.Forms.Button();
            this.chkHeaders = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDelimiterChar = new System.Windows.Forms.TextBox();
            this.radOtherDelimiter = new System.Windows.Forms.RadioButton();
            this.radSpaceDelimiter = new System.Windows.Forms.RadioButton();
            this.radCommaDelimiter = new System.Windows.Forms.RadioButton();
            this.radSemicolonDelimiter = new System.Windows.Forms.RadioButton();
            this.radTabDelimiter = new System.Windows.Forms.RadioButton();
            this.lstExamples = new System.Windows.Forms.ListView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtEquivalentCommand = new System.Windows.Forms.TextBox();
            this.btnSaveOutput = new System.Windows.Forms.Button();
            this.fileWatcher = new System.IO.FileSystemWatcher();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHContents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenTemplateFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgOpenOptionsFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcher)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgOpenDataFile
            // 
            this.dlgOpenDataFile.Title = "Choose Delimited File";
            this.dlgOpenDataFile.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpenDataFile_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Template file";
            // 
            // txtTemplateFileName
            // 
            this.txtTemplateFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTemplateFileName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTemplateFileName.ForeColor = System.Drawing.Color.Black;
            this.txtTemplateFileName.Location = new System.Drawing.Point(11, 39);
            this.txtTemplateFileName.Name = "txtTemplateFileName";
            this.txtTemplateFileName.ReadOnly = true;
            this.txtTemplateFileName.Size = new System.Drawing.Size(233, 20);
            this.txtTemplateFileName.TabIndex = 12;
            this.txtTemplateFileName.TabStop = false;
            this.txtTemplateFileName.TextChanged += new System.EventHandler(this.txtTemplateFileName_TextChanged);
            // 
            // btnChooseTemplate
            // 
            this.btnChooseTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseTemplate.Location = new System.Drawing.Point(250, 39);
            this.btnChooseTemplate.Name = "btnChooseTemplate";
            this.btnChooseTemplate.Size = new System.Drawing.Size(66, 20);
            this.btnChooseTemplate.TabIndex = 11;
            this.btnChooseTemplate.Text = "Choose...";
            this.btnChooseTemplate.UseVisualStyleBackColor = true;
            this.btnChooseTemplate.Click += new System.EventHandler(this.btnChooseTemplate_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutput.Location = new System.Drawing.Point(6, 16);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(410, 339);
            this.txtOutput.TabIndex = 16;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // dlgSaveOutputFile
            // 
            this.dlgSaveOutputFile.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgSaveOutput_FileOk);
            // 
            // txtOptionsFileName
            // 
            this.txtOptionsFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOptionsFileName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtOptionsFileName.Location = new System.Drawing.Point(12, 92);
            this.txtOptionsFileName.Name = "txtOptionsFileName";
            this.txtOptionsFileName.ReadOnly = true;
            this.txtOptionsFileName.Size = new System.Drawing.Size(232, 20);
            this.txtOptionsFileName.TabIndex = 15;
            this.txtOptionsFileName.TabStop = false;
            this.txtOptionsFileName.TextChanged += new System.EventHandler(this.txtOptionsFileName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Options file";
            // 
            // btnChooseOptionsFile
            // 
            this.btnChooseOptionsFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseOptionsFile.Location = new System.Drawing.Point(250, 92);
            this.btnChooseOptionsFile.Name = "btnChooseOptionsFile";
            this.btnChooseOptionsFile.Size = new System.Drawing.Size(66, 20);
            this.btnChooseOptionsFile.TabIndex = 13;
            this.btnChooseOptionsFile.Text = "Choose...";
            this.btnChooseOptionsFile.UseVisualStyleBackColor = true;
            this.btnChooseOptionsFile.Click += new System.EventHandler(this.btnChooseOptionsFile_Click);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(250, 445);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(138, 24);
            this.btnRun.TabIndex = 15;
            this.btnRun.Text = "Convert Data";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnEditTemplateFile
            // 
            this.btnEditTemplateFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditTemplateFile.Enabled = false;
            this.btnEditTemplateFile.Location = new System.Drawing.Point(319, 39);
            this.btnEditTemplateFile.Name = "btnEditTemplateFile";
            this.btnEditTemplateFile.Size = new System.Drawing.Size(66, 20);
            this.btnEditTemplateFile.TabIndex = 12;
            this.btnEditTemplateFile.Text = "Edit...";
            this.btnEditTemplateFile.UseVisualStyleBackColor = true;
            this.btnEditTemplateFile.Click += new System.EventHandler(this.btnEditTemplateFile_Click);
            // 
            // btnEditOptionsFile
            // 
            this.btnEditOptionsFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditOptionsFile.Enabled = false;
            this.btnEditOptionsFile.Location = new System.Drawing.Point(319, 91);
            this.btnEditOptionsFile.Name = "btnEditOptionsFile";
            this.btnEditOptionsFile.Size = new System.Drawing.Size(66, 20);
            this.btnEditOptionsFile.TabIndex = 14;
            this.btnEditOptionsFile.Text = "Edit...";
            this.btnEditOptionsFile.UseVisualStyleBackColor = true;
            this.btnEditOptionsFile.Click += new System.EventHandler(this.btnEditOptionsFile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtOutput);
            this.groupBox3.Location = new System.Drawing.Point(3, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 361);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Converted output";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 52);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.btnRun);
            this.splitContainer1.Panel1MinSize = 400;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel2.Controls.Add(this.btnSaveOutput);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(831, 478);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 36;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txtDescription);
            this.groupBox5.Location = new System.Drawing.Point(4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(393, 69);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Conversion description";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(10, 16);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(374, 47);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtTemplateFileName);
            this.groupBox4.Controls.Add(this.btnEditOptionsFile);
            this.groupBox4.Controls.Add(this.btnEditTemplateFile);
            this.groupBox4.Controls.Add(this.btnChooseOptionsFile);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnChooseTemplate);
            this.groupBox4.Controls.Add(this.txtOptionsFileName);
            this.groupBox4.Location = new System.Drawing.Point(3, 314);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 125);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Template";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnEditDataFile);
            this.groupBox2.Controls.Add(this.txtDataFileName);
            this.groupBox2.Controls.Add(this.btnChooseDataFile);
            this.groupBox2.Controls.Add(this.chkHeaders);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lstExamples);
            this.groupBox2.Location = new System.Drawing.Point(3, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 230);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delimited data file";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Delimited data preview (up to first 50 records)";
            // 
            // btnEditDataFile
            // 
            this.btnEditDataFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDataFile.Enabled = false;
            this.btnEditDataFile.Location = new System.Drawing.Point(319, 20);
            this.btnEditDataFile.Name = "btnEditDataFile";
            this.btnEditDataFile.Size = new System.Drawing.Size(66, 20);
            this.btnEditDataFile.TabIndex = 3;
            this.btnEditDataFile.Text = "Edit...";
            this.btnEditDataFile.UseVisualStyleBackColor = true;
            this.btnEditDataFile.Click += new System.EventHandler(this.btnEditDataFile_Click);
            // 
            // txtDataFileName
            // 
            this.txtDataFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataFileName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDataFileName.Location = new System.Drawing.Point(12, 20);
            this.txtDataFileName.Name = "txtDataFileName";
            this.txtDataFileName.ReadOnly = true;
            this.txtDataFileName.Size = new System.Drawing.Size(232, 20);
            this.txtDataFileName.TabIndex = 1;
            this.txtDataFileName.TabStop = false;
            this.txtDataFileName.TextChanged += new System.EventHandler(this.txtDataFileName_TextChanged);
            // 
            // btnChooseDataFile
            // 
            this.btnChooseDataFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseDataFile.Location = new System.Drawing.Point(250, 20);
            this.btnChooseDataFile.Name = "btnChooseDataFile";
            this.btnChooseDataFile.Size = new System.Drawing.Size(66, 20);
            this.btnChooseDataFile.TabIndex = 2;
            this.btnChooseDataFile.Text = "Choose...";
            this.btnChooseDataFile.UseVisualStyleBackColor = true;
            this.btnChooseDataFile.Click += new System.EventHandler(this.btnChooseDataFile_Click);
            // 
            // chkHeaders
            // 
            this.chkHeaders.AutoSize = true;
            this.chkHeaders.Checked = true;
            this.chkHeaders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHeaders.Location = new System.Drawing.Point(27, 113);
            this.chkHeaders.Name = "chkHeaders";
            this.chkHeaders.Size = new System.Drawing.Size(170, 17);
            this.chkHeaders.TabIndex = 10;
            this.chkHeaders.Text = "First row contains field names?";
            this.chkHeaders.UseVisualStyleBackColor = true;
            this.chkHeaders.CheckedChanged += new System.EventHandler(this.chkHeaders_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtDelimiterChar);
            this.groupBox1.Controls.Add(this.radOtherDelimiter);
            this.groupBox1.Controls.Add(this.radSpaceDelimiter);
            this.groupBox1.Controls.Add(this.radCommaDelimiter);
            this.groupBox1.Controls.Add(this.radSemicolonDelimiter);
            this.groupBox1.Controls.Add(this.radTabDelimiter);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 49);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text delimited by";
            // 
            // txtDelimiterChar
            // 
            this.txtDelimiterChar.Enabled = false;
            this.txtDelimiterChar.Location = new System.Drawing.Point(324, 19);
            this.txtDelimiterChar.MaxLength = 1;
            this.txtDelimiterChar.Name = "txtDelimiterChar";
            this.txtDelimiterChar.Size = new System.Drawing.Size(34, 20);
            this.txtDelimiterChar.TabIndex = 9;
            this.txtDelimiterChar.WordWrap = false;
            this.txtDelimiterChar.TextChanged += new System.EventHandler(this.txtDelimiterChar_TextChanged);
            // 
            // radOtherDelimiter
            // 
            this.radOtherDelimiter.AutoSize = true;
            this.radOtherDelimiter.Location = new System.Drawing.Point(273, 19);
            this.radOtherDelimiter.Name = "radOtherDelimiter";
            this.radOtherDelimiter.Size = new System.Drawing.Size(54, 17);
            this.radOtherDelimiter.TabIndex = 8;
            this.radOtherDelimiter.TabStop = true;
            this.radOtherDelimiter.Text = "Other:";
            this.radOtherDelimiter.UseVisualStyleBackColor = true;
            this.radOtherDelimiter.CheckedChanged += new System.EventHandler(this.delimiter_CheckedChanged);
            // 
            // radSpaceDelimiter
            // 
            this.radSpaceDelimiter.AutoSize = true;
            this.radSpaceDelimiter.Location = new System.Drawing.Point(211, 19);
            this.radSpaceDelimiter.Name = "radSpaceDelimiter";
            this.radSpaceDelimiter.Size = new System.Drawing.Size(56, 17);
            this.radSpaceDelimiter.TabIndex = 7;
            this.radSpaceDelimiter.TabStop = true;
            this.radSpaceDelimiter.Text = "Space";
            this.radSpaceDelimiter.UseVisualStyleBackColor = true;
            this.radSpaceDelimiter.CheckedChanged += new System.EventHandler(this.delimiter_CheckedChanged);
            // 
            // radCommaDelimiter
            // 
            this.radCommaDelimiter.AutoSize = true;
            this.radCommaDelimiter.Checked = true;
            this.radCommaDelimiter.Location = new System.Drawing.Point(145, 19);
            this.radCommaDelimiter.Name = "radCommaDelimiter";
            this.radCommaDelimiter.Size = new System.Drawing.Size(60, 17);
            this.radCommaDelimiter.TabIndex = 6;
            this.radCommaDelimiter.TabStop = true;
            this.radCommaDelimiter.Text = "Comma";
            this.radCommaDelimiter.UseVisualStyleBackColor = true;
            // 
            // radSemicolonDelimiter
            // 
            this.radSemicolonDelimiter.AutoSize = true;
            this.radSemicolonDelimiter.Location = new System.Drawing.Point(65, 19);
            this.radSemicolonDelimiter.Name = "radSemicolonDelimiter";
            this.radSemicolonDelimiter.Size = new System.Drawing.Size(74, 17);
            this.radSemicolonDelimiter.TabIndex = 5;
            this.radSemicolonDelimiter.TabStop = true;
            this.radSemicolonDelimiter.Text = "Semicolon";
            this.radSemicolonDelimiter.UseVisualStyleBackColor = true;
            this.radSemicolonDelimiter.CheckedChanged += new System.EventHandler(this.delimiter_CheckedChanged);
            // 
            // radTabDelimiter
            // 
            this.radTabDelimiter.AutoSize = true;
            this.radTabDelimiter.Location = new System.Drawing.Point(15, 19);
            this.radTabDelimiter.Name = "radTabDelimiter";
            this.radTabDelimiter.Size = new System.Drawing.Size(44, 17);
            this.radTabDelimiter.TabIndex = 4;
            this.radTabDelimiter.TabStop = true;
            this.radTabDelimiter.Text = "Tab";
            this.radTabDelimiter.UseVisualStyleBackColor = true;
            this.radTabDelimiter.CheckedChanged += new System.EventHandler(this.delimiter_CheckedChanged);
            // 
            // lstExamples
            // 
            this.lstExamples.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstExamples.FullRowSelect = true;
            this.lstExamples.GridLines = true;
            this.lstExamples.HideSelection = false;
            this.lstExamples.Location = new System.Drawing.Point(13, 158);
            this.lstExamples.MinimumSize = new System.Drawing.Size(100, 60);
            this.lstExamples.Name = "lstExamples";
            this.lstExamples.Size = new System.Drawing.Size(372, 60);
            this.lstExamples.TabIndex = 0;
            this.lstExamples.TabStop = false;
            this.lstExamples.UseCompatibleStateImageBehavior = false;
            this.lstExamples.View = System.Windows.Forms.View.Details;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.txtEquivalentCommand);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(419, 69);
            this.groupBox6.TabIndex = 38;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Equivalent STELLAR.Console command";
            // 
            // txtEquivalentCommand
            // 
            this.txtEquivalentCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquivalentCommand.Location = new System.Drawing.Point(10, 16);
            this.txtEquivalentCommand.Multiline = true;
            this.txtEquivalentCommand.Name = "txtEquivalentCommand";
            this.txtEquivalentCommand.ReadOnly = true;
            this.txtEquivalentCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEquivalentCommand.Size = new System.Drawing.Size(400, 47);
            this.txtEquivalentCommand.TabIndex = 1;
            this.txtEquivalentCommand.TabStop = false;
            // 
            // btnSaveOutput
            // 
            this.btnSaveOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveOutput.Location = new System.Drawing.Point(278, 445);
            this.btnSaveOutput.Name = "btnSaveOutput";
            this.btnSaveOutput.Size = new System.Drawing.Size(138, 24);
            this.btnSaveOutput.TabIndex = 17;
            this.btnSaveOutput.Text = "Save Output As...";
            this.btnSaveOutput.UseVisualStyleBackColor = true;
            this.btnSaveOutput.Click += new System.EventHandler(this.btnSaveOutput_Click);
            // 
            // fileWatcher
            // 
            this.fileWatcher.EnableRaisingEvents = true;
            this.fileWatcher.SynchronizingObject = this;
            this.fileWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileWatcher_Changed);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator4,
            this.btnHelp,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(834, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Stellar.Win.Properties.Resources.folder_add;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(48, 22);
            this.btnNew.Text = "&New";
            this.btnNew.ToolTipText = "New Conversion";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnOpen.Image = global::Stellar.Win.Properties.Resources.folder_star;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(53, 22);
            this.btnOpen.Text = "&Open";
            this.btnOpen.ToolTipText = "Open Conversion";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Stellar.Win.Properties.Resources.disk;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 22);
            this.btnSave.Text = "&Save";
            this.btnSave.ToolTipText = "Save Conversion";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnHelp
            // 
            this.btnHelp.Enabled = false;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(48, 22);
            this.btnHelp.Text = "&Help";
            this.btnHelp.ToolTipText = "Display Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFNew,
            this.mnuFOpen,
            this.mnuFSave,
            this.mnuFSaveAs,
            this.toolStripMenuItem1,
            this.mnuFExit});
            this.mnuFile.Image = global::Stellar.Win.Properties.Resources.folder;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(51, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFNew
            // 
            this.mnuFNew.Image = global::Stellar.Win.Properties.Resources.folder_add;
            this.mnuFNew.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuFNew.Name = "mnuFNew";
            this.mnuFNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFNew.Size = new System.Drawing.Size(175, 22);
            this.mnuFNew.Text = "&New";
            this.mnuFNew.ToolTipText = "New Project";
            this.mnuFNew.Click += new System.EventHandler(this.mnuFNew_Click);
            // 
            // mnuFOpen
            // 
            this.mnuFOpen.Image = global::Stellar.Win.Properties.Resources.folder_star;
            this.mnuFOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuFOpen.Name = "mnuFOpen";
            this.mnuFOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFOpen.Size = new System.Drawing.Size(175, 22);
            this.mnuFOpen.Text = "&Open...";
            this.mnuFOpen.ToolTipText = "Open Project";
            this.mnuFOpen.Click += new System.EventHandler(this.mnuFOpen_Click);
            // 
            // mnuFSave
            // 
            this.mnuFSave.Image = global::Stellar.Win.Properties.Resources.disk;
            this.mnuFSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuFSave.Name = "mnuFSave";
            this.mnuFSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFSave.Size = new System.Drawing.Size(175, 22);
            this.mnuFSave.Text = "&Save";
            this.mnuFSave.ToolTipText = "Save Project";
            this.mnuFSave.Click += new System.EventHandler(this.mnuFSave_Click);
            // 
            // mnuFSaveAs
            // 
            this.mnuFSaveAs.Image = global::Stellar.Win.Properties.Resources.disk;
            this.mnuFSaveAs.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuFSaveAs.Name = "mnuFSaveAs";
            this.mnuFSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuFSaveAs.Size = new System.Drawing.Size(175, 22);
            this.mnuFSaveAs.Text = "Save &As...";
            this.mnuFSaveAs.ToolTipText = "Save Project As ";
            this.mnuFSaveAs.Click += new System.EventHandler(this.mnuFSaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 6);
            // 
            // mnuFExit
            // 
            this.mnuFExit.Image = global::Stellar.Win.Properties.Resources.door_in;
            this.mnuFExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFExit.Name = "mnuFExit";
            this.mnuFExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFExit.Size = new System.Drawing.Size(175, 22);
            this.mnuFExit.Text = "&Quit";
            this.mnuFExit.ToolTipText = "Exit STELLAR";
            this.mnuFExit.Click += new System.EventHandler(this.mnuFExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHContents,
            this.mnuHWeb});
            this.mnuHelp.Image = ((System.Drawing.Image)(resources.GetObject("mnuHelp.Image")));
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(56, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHContents
            // 
            this.mnuHContents.Enabled = false;
            this.mnuHContents.Image = ((System.Drawing.Image)(resources.GetObject("mnuHContents.Image")));
            this.mnuHContents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuHContents.Name = "mnuHContents";
            this.mnuHContents.Size = new System.Drawing.Size(198, 22);
            this.mnuHContents.Text = "&Contents...";
            this.mnuHContents.ToolTipText = "Show Help";
            // 
            // mnuHWeb
            // 
            this.mnuHWeb.Image = global::Stellar.Win.Properties.Resources.world;
            this.mnuHWeb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuHWeb.Name = "mnuHWeb";
            this.mnuHWeb.Size = new System.Drawing.Size(198, 22);
            this.mnuHWeb.Text = "STELLAR on the &Web...";
            this.mnuHWeb.ToolTipText = "Go to STELLAR web site";
            this.mnuHWeb.Click += new System.EventHandler(this.mnuHWeb_Click);
            // 
            // dlgOpenTemplateFile
            // 
            this.dlgOpenTemplateFile.Title = "Choose Delimited File";
            this.dlgOpenTemplateFile.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpenTemplateFile_FileOk);
            // 
            // dlgOpenOptionsFile
            // 
            this.dlgOpenOptionsFile.Title = "Choose Delimited File";
            this.dlgOpenOptionsFile.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpenOptionsFile_FileOk);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Title = "Choose Delimited File";
            this.dlgOpenFile.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpenFile_FileOk);
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgSaveFile_FileOk);
            // 
            // frmDelimited2STG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 533);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDelimited2STG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "STELLAR";
            this.Load += new System.EventHandler(this.frmImportDelimited_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDelimited2STG_FormClosing);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcher)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpenDataFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemplateFileName;
        private System.Windows.Forms.Button btnChooseTemplate;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.SaveFileDialog dlgSaveOutputFile;
        private System.Windows.Forms.TextBox txtOptionsFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChooseOptionsFile;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnEditTemplateFile;
        private System.Windows.Forms.Button btnEditOptionsFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditDataFile;
        private System.Windows.Forms.TextBox txtDataFileName;
        private System.Windows.Forms.Button btnChooseDataFile;
        private System.Windows.Forms.CheckBox chkHeaders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDelimiterChar;
        private System.Windows.Forms.RadioButton radOtherDelimiter;
        private System.Windows.Forms.RadioButton radSpaceDelimiter;
        private System.Windows.Forms.RadioButton radCommaDelimiter;
        private System.Windows.Forms.RadioButton radSemicolonDelimiter;
        private System.Windows.Forms.RadioButton radTabDelimiter;
        private System.Windows.Forms.ListView lstExamples;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSaveOutput;
        private System.IO.FileSystemWatcher fileWatcher;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHContents;
        private System.Windows.Forms.ToolStripMenuItem mnuHWeb;
        private System.Windows.Forms.OpenFileDialog dlgOpenTemplateFile;
        private System.Windows.Forms.OpenFileDialog dlgOpenOptionsFile;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtEquivalentCommand;
    }
}

