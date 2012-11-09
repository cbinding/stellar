namespace STELLAR.Win
{
    partial class frmEditFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditFile));
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileContents = new System.Windows.Forms.TextBox();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuECut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuECopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEToUppercase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEToLowercase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuESelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "File name";
            // 
            // txtFileContents
            // 
            this.txtFileContents.AcceptsTab = true;
            this.txtFileContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileContents.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileContents.Location = new System.Drawing.Point(12, 41);
            this.txtFileContents.Multiline = true;
            this.txtFileContents.Name = "txtFileContents";
            this.txtFileContents.Size = new System.Drawing.Size(453, 201);
            this.txtFileContents.TabIndex = 45;
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "dlgOpenFile";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFNew,
            this.mnuFOpen,
            this.mnuFSave,
            this.mnuFSaveAs,
            this.toolStripMenuItem3,
            this.mnuFExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "&File";
            this.mnuFile.Click += new System.EventHandler(this.mnuFile_Click);
            // 
            // mnuFNew
            // 
            this.mnuFNew.Image = global::Stellar.Win.Properties.Resources.script_add;
            this.mnuFNew.Name = "mnuFNew";
            this.mnuFNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFNew.Size = new System.Drawing.Size(163, 22);
            this.mnuFNew.Text = "&New";
            this.mnuFNew.Click += new System.EventHandler(this.mnuFNew_Click);
            // 
            // mnuFOpen
            // 
            this.mnuFOpen.Image = global::Stellar.Win.Properties.Resources.script_edit;
            this.mnuFOpen.Name = "mnuFOpen";
            this.mnuFOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFOpen.Size = new System.Drawing.Size(163, 22);
            this.mnuFOpen.Text = "&Open...";
            this.mnuFOpen.Click += new System.EventHandler(this.mnuFOpen_Click);
            // 
            // mnuFSave
            // 
            this.mnuFSave.Image = global::Stellar.Win.Properties.Resources.script_save;
            this.mnuFSave.Name = "mnuFSave";
            this.mnuFSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFSave.Size = new System.Drawing.Size(163, 22);
            this.mnuFSave.Text = "&Save";
            this.mnuFSave.Click += new System.EventHandler(this.mnuFSave_Click);
            // 
            // mnuFSaveAs
            // 
            this.mnuFSaveAs.Image = global::Stellar.Win.Properties.Resources.script_save;
            this.mnuFSaveAs.Name = "mnuFSaveAs";
            this.mnuFSaveAs.Size = new System.Drawing.Size(163, 22);
            this.mnuFSaveAs.Text = "Save &As...";
            this.mnuFSaveAs.Click += new System.EventHandler(this.mnuFSaveAs_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(160, 6);
            // 
            // mnuFExit
            // 
            this.mnuFExit.Image = global::Stellar.Win.Properties.Resources.door_in;
            this.mnuFExit.Name = "mnuFExit";
            this.mnuFExit.Size = new System.Drawing.Size(163, 22);
            this.mnuFExit.Text = "Exit";
            this.mnuFExit.Click += new System.EventHandler(this.mnuFExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEUndo,
            this.toolStripMenuItem1,
            this.mnuECut,
            this.mnuECopy,
            this.mnuEPaste,
            this.toolStripMenuItem2,
            this.mnuEFind,
            this.mnuEFindNext,
            this.mnuEReplace,
            this.toolStripMenuItem5,
            this.convertToolStripMenuItem,
            this.toolStripMenuItem4,
            this.mnuESelectAll});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(37, 20);
            this.mnuEdit.Text = "&Edit";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // mnuEUndo
            // 
            this.mnuEUndo.Image = global::Stellar.Win.Properties.Resources.arrow_rotate_anticlockwise;
            this.mnuEUndo.Name = "mnuEUndo";
            this.mnuEUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnuEUndo.Size = new System.Drawing.Size(174, 22);
            this.mnuEUndo.Text = "Undo";
            this.mnuEUndo.Click += new System.EventHandler(this.mnuEUndo_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
            // 
            // mnuECut
            // 
            this.mnuECut.Image = global::Stellar.Win.Properties.Resources.cut;
            this.mnuECut.Name = "mnuECut";
            this.mnuECut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuECut.Size = new System.Drawing.Size(174, 22);
            this.mnuECut.Text = "Cut";
            this.mnuECut.Click += new System.EventHandler(this.mnuECut_Click);
            // 
            // mnuECopy
            // 
            this.mnuECopy.Image = global::Stellar.Win.Properties.Resources.page_copy;
            this.mnuECopy.Name = "mnuECopy";
            this.mnuECopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuECopy.Size = new System.Drawing.Size(174, 22);
            this.mnuECopy.Text = "Copy";
            this.mnuECopy.Click += new System.EventHandler(this.mnuECopy_Click);
            // 
            // mnuEPaste
            // 
            this.mnuEPaste.Image = global::Stellar.Win.Properties.Resources.page_paste;
            this.mnuEPaste.Name = "mnuEPaste";
            this.mnuEPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuEPaste.Size = new System.Drawing.Size(174, 22);
            this.mnuEPaste.Text = "Paste";
            this.mnuEPaste.Click += new System.EventHandler(this.mnuEPaste_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 6);
            // 
            // mnuEFind
            // 
            this.mnuEFind.Image = global::Stellar.Win.Properties.Resources.find;
            this.mnuEFind.Name = "mnuEFind";
            this.mnuEFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuEFind.Size = new System.Drawing.Size(174, 22);
            this.mnuEFind.Text = "Find...";
            this.mnuEFind.Click += new System.EventHandler(this.mnuEFind_Click);
            // 
            // mnuEFindNext
            // 
            this.mnuEFindNext.Image = global::Stellar.Win.Properties.Resources.find;
            this.mnuEFindNext.Name = "mnuEFindNext";
            this.mnuEFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuEFindNext.Size = new System.Drawing.Size(174, 22);
            this.mnuEFindNext.Text = "Find Next...";
            this.mnuEFindNext.Click += new System.EventHandler(this.mnuEFindNext_Click);
            // 
            // mnuEReplace
            // 
            this.mnuEReplace.Image = global::Stellar.Win.Properties.Resources.text_replace;
            this.mnuEReplace.Name = "mnuEReplace";
            this.mnuEReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mnuEReplace.Size = new System.Drawing.Size(174, 22);
            this.mnuEReplace.Text = "Replace...";
            this.mnuEReplace.Click += new System.EventHandler(this.mnuEReplace_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(171, 6);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEToUppercase,
            this.mnuEToLowercase});
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.convertToolStripMenuItem.Text = "Convert";
            // 
            // mnuEToUppercase
            // 
            this.mnuEToUppercase.Image = global::Stellar.Win.Properties.Resources.text_uppercase;
            this.mnuEToUppercase.Name = "mnuEToUppercase";
            this.mnuEToUppercase.Size = new System.Drawing.Size(151, 22);
            this.mnuEToUppercase.Text = "To Uppercase";
            this.mnuEToUppercase.Click += new System.EventHandler(this.mnuEToUppercase_Click);
            // 
            // mnuEToLowercase
            // 
            this.mnuEToLowercase.Image = global::Stellar.Win.Properties.Resources.text_lowercase;
            this.mnuEToLowercase.Name = "mnuEToLowercase";
            this.mnuEToLowercase.Size = new System.Drawing.Size(151, 22);
            this.mnuEToLowercase.Text = "To Lowercase";
            this.mnuEToLowercase.Click += new System.EventHandler(this.mnuEToLowercase_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(171, 6);
            // 
            // mnuESelectAll
            // 
            this.mnuESelectAll.Name = "mnuESelectAll";
            this.mnuESelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuESelectAll.Size = new System.Drawing.Size(174, 22);
            this.mnuESelectAll.Text = "Select All";
            this.mnuESelectAll.Click += new System.EventHandler(this.mnuESelectAll_Click);
            // 
            // frmEditFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 314);
            this.Controls.Add(this.txtFileContents);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEditFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit File";
            this.Load += new System.EventHandler(this.frmEditFile_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditFile_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileContents;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuECut;
        private System.Windows.Forms.ToolStripMenuItem mnuECopy;
        private System.Windows.Forms.ToolStripMenuItem mnuEPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuESelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuFExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEFind;
        private System.Windows.Forms.ToolStripMenuItem mnuEFindNext;
        private System.Windows.Forms.ToolStripMenuItem mnuEReplace;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEToUppercase;
        private System.Windows.Forms.ToolStripMenuItem mnuEToLowercase;
    }
}