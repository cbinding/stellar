namespace STELLAR.APP
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.staStatus = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnRun = new System.Windows.Forms.ToolStripButton();
            this.btnPause = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVToolBar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPAddExisting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPRun = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPPause = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPStop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHContents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwProcesses = new System.Windows.Forms.ListView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imgImages = new System.Windows.Forms.ImageList(this.components);
            this.dlgOpenProject = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveProject = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpenProcess = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // staStatus
            // 
            this.staStatus.Location = new System.Drawing.Point(0, 487);
            this.staStatus.Name = "staStatus";
            this.staStatus.Size = new System.Drawing.Size(755, 22);
            this.staStatus.TabIndex = 0;
            this.staStatus.Text = "staStatus";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator4,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.btnRun,
            this.btnPause,
            this.btnStop,
            this.toolStripSeparator2,
            this.btnHelp,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(755, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = global::STELLAR.APP.Properties.Resources.folder_add;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 22);
            this.btnNew.Text = "New";
            this.btnNew.ToolTipText = "New Project";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = global::STELLAR.APP.Properties.Resources.folder_star;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 22);
            this.btnOpen.Text = "Open";
            this.btnOpen.ToolTipText = "Open Project";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::STELLAR.APP.Properties.Resources.disk;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Save";
            this.btnSave.ToolTipText = "Save Project";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::STELLAR.APP.Properties.Resources.cog_add;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Add";
            this.toolStripButton2.ToolTipText = "Add Process";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::STELLAR.APP.Properties.Resources.cog_edit;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Edit";
            this.toolStripButton3.ToolTipText = "Edit Process";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::STELLAR.APP.Properties.Resources.cog_delete;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Remove";
            this.toolStripButton4.ToolTipText = "Remove Process";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::STELLAR.APP.Properties.Resources.control_start_blue;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Back";
            // 
            // btnRun
            // 
            this.btnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRun.Image = global::STELLAR.APP.Properties.Resources.control_play_blue;
            this.btnRun.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(23, 22);
            this.btnRun.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnPause
            // 
            this.btnPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPause.Image = global::STELLAR.APP.Properties.Resources.control_pause_blue;
            this.btnPause.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(23, 22);
            this.btnPause.Text = "Pause";
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = global::STELLAR.APP.Properties.Resources.control_stop_blue;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(23, 22);
            this.btnStop.Text = "Stop";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 22);
            this.btnHelp.Text = "Help";
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
            this.mnuView,
            this.mnuProcess,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.mnuFile.Image = global::STELLAR.APP.Properties.Resources.folder;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(51, 20);
            this.mnuFile.Text = "File";
            this.mnuFile.Click += new System.EventHandler(this.mnuFile_Click);
            // 
            // mnuFNew
            // 
            this.mnuFNew.Image = global::STELLAR.APP.Properties.Resources.folder_add;
            this.mnuFNew.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuFNew.Name = "mnuFNew";
            this.mnuFNew.Size = new System.Drawing.Size(173, 22);
            this.mnuFNew.Text = "New Project...";
            this.mnuFNew.Click += new System.EventHandler(this.mnuFNew_Click);
            // 
            // mnuFOpen
            // 
            this.mnuFOpen.Image = global::STELLAR.APP.Properties.Resources.folder_star;
            this.mnuFOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuFOpen.Name = "mnuFOpen";
            this.mnuFOpen.Size = new System.Drawing.Size(173, 22);
            this.mnuFOpen.Text = "Open Project...";
            this.mnuFOpen.Click += new System.EventHandler(this.mnuFOpen_Click);
            // 
            // mnuFSave
            // 
            this.mnuFSave.Image = global::STELLAR.APP.Properties.Resources.disk;
            this.mnuFSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuFSave.Name = "mnuFSave";
            this.mnuFSave.Size = new System.Drawing.Size(173, 22);
            this.mnuFSave.Text = "Save Project";
            this.mnuFSave.Click += new System.EventHandler(this.mnuFSave_Click);
            // 
            // mnuFSaveAs
            // 
            this.mnuFSaveAs.Image = global::STELLAR.APP.Properties.Resources.disk;
            this.mnuFSaveAs.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuFSaveAs.Name = "mnuFSaveAs";
            this.mnuFSaveAs.Size = new System.Drawing.Size(173, 22);
            this.mnuFSaveAs.Text = "Save Project As...";
            this.mnuFSaveAs.Click += new System.EventHandler(this.mnuFSaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
            // 
            // mnuFExit
            // 
            this.mnuFExit.Image = global::STELLAR.APP.Properties.Resources.door_in;
            this.mnuFExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFExit.Name = "mnuFExit";
            this.mnuFExit.Size = new System.Drawing.Size(173, 22);
            this.mnuFExit.Text = "Exit";
            this.mnuFExit.Click += new System.EventHandler(this.mnuFExit_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVToolBar,
            this.mnuVStatusBar});
            this.mnuView.Image = global::STELLAR.APP.Properties.Resources.eye;
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(57, 20);
            this.mnuView.Text = "View";
            // 
            // mnuVToolBar
            // 
            this.mnuVToolBar.Checked = true;
            this.mnuVToolBar.CheckOnClick = true;
            this.mnuVToolBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuVToolBar.Name = "mnuVToolBar";
            this.mnuVToolBar.Size = new System.Drawing.Size(152, 22);
            this.mnuVToolBar.Text = "Toolbar";
            this.mnuVToolBar.CheckStateChanged += new System.EventHandler(this.mnuVToolBar_CheckStateChanged);
            // 
            // mnuVStatusBar
            // 
            this.mnuVStatusBar.Checked = true;
            this.mnuVStatusBar.CheckOnClick = true;
            this.mnuVStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuVStatusBar.Name = "mnuVStatusBar";
            this.mnuVStatusBar.Size = new System.Drawing.Size(152, 22);
            this.mnuVStatusBar.Text = "Status Bar";
            this.mnuVStatusBar.CheckStateChanged += new System.EventHandler(this.mnuVStatusBar_CheckStateChanged);
            // 
            // mnuProcess
            // 
            this.mnuProcess.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPAdd,
            this.mnuPEdit,
            this.mnuPRemove,
            this.toolStripMenuItem2,
            this.mnuPBack,
            this.mnuPRun,
            this.mnuPPause,
            this.mnuPStop});
            this.mnuProcess.Image = global::STELLAR.APP.Properties.Resources.cog;
            this.mnuProcess.Name = "mnuProcess";
            this.mnuProcess.Size = new System.Drawing.Size(72, 20);
            this.mnuProcess.Text = "Process";
            this.mnuProcess.Click += new System.EventHandler(this.mnuProcess_Click);
            // 
            // mnuPAdd
            // 
            this.mnuPAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPAddNew,
            this.mnuPAddExisting});
            this.mnuPAdd.Image = global::STELLAR.APP.Properties.Resources.cog_add;
            this.mnuPAdd.Name = "mnuPAdd";
            this.mnuPAdd.Size = new System.Drawing.Size(152, 22);
            this.mnuPAdd.Text = "Add";
            // 
            // mnuPAddNew
            // 
            this.mnuPAddNew.Image = global::STELLAR.APP.Properties.Resources.cog_add;
            this.mnuPAddNew.Name = "mnuPAddNew";
            this.mnuPAddNew.Size = new System.Drawing.Size(174, 22);
            this.mnuPAddNew.Text = "New Process...";
            this.mnuPAddNew.Click += new System.EventHandler(this.mnuPAddNew_Click);
            // 
            // mnuPAddExisting
            // 
            this.mnuPAddExisting.Image = global::STELLAR.APP.Properties.Resources.cog_add;
            this.mnuPAddExisting.Name = "mnuPAddExisting";
            this.mnuPAddExisting.Size = new System.Drawing.Size(174, 22);
            this.mnuPAddExisting.Text = "Existing Process...";
            this.mnuPAddExisting.Click += new System.EventHandler(this.mnuPAddExisting_Click);
            // 
            // mnuPEdit
            // 
            this.mnuPEdit.Image = global::STELLAR.APP.Properties.Resources.cog_edit;
            this.mnuPEdit.Name = "mnuPEdit";
            this.mnuPEdit.Size = new System.Drawing.Size(152, 22);
            this.mnuPEdit.Text = "Edit...";
            this.mnuPEdit.Click += new System.EventHandler(this.mnuPEdit_Click);
            // 
            // mnuPRemove
            // 
            this.mnuPRemove.Image = global::STELLAR.APP.Properties.Resources.cog_delete;
            this.mnuPRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuPRemove.Name = "mnuPRemove";
            this.mnuPRemove.Size = new System.Drawing.Size(152, 22);
            this.mnuPRemove.Text = "Remove";
            this.mnuPRemove.Click += new System.EventHandler(this.mnuPRemove_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuPBack
            // 
            this.mnuPBack.Image = global::STELLAR.APP.Properties.Resources.control_start_blue;
            this.mnuPBack.Name = "mnuPBack";
            this.mnuPBack.Size = new System.Drawing.Size(152, 22);
            this.mnuPBack.Text = "Back";
            // 
            // mnuPRun
            // 
            this.mnuPRun.Image = global::STELLAR.APP.Properties.Resources.control_play_blue;
            this.mnuPRun.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuPRun.Name = "mnuPRun";
            this.mnuPRun.Size = new System.Drawing.Size(152, 22);
            this.mnuPRun.Text = "Run";
            this.mnuPRun.Click += new System.EventHandler(this.mnuPRun_Click);
            // 
            // mnuPPause
            // 
            this.mnuPPause.Image = global::STELLAR.APP.Properties.Resources.control_pause_blue;
            this.mnuPPause.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuPPause.Name = "mnuPPause";
            this.mnuPPause.Size = new System.Drawing.Size(152, 22);
            this.mnuPPause.Text = "Pause";
            this.mnuPPause.Click += new System.EventHandler(this.mnuPPause_Click);
            // 
            // mnuPStop
            // 
            this.mnuPStop.Image = global::STELLAR.APP.Properties.Resources.control_stop_blue;
            this.mnuPStop.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuPStop.Name = "mnuPStop";
            this.mnuPStop.Size = new System.Drawing.Size(152, 22);
            this.mnuPStop.Text = "Stop";
            this.mnuPStop.Click += new System.EventHandler(this.mnuPStop_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHContents,
            this.mnuHAbout,
            this.mnuHWeb});
            this.mnuHelp.Image = ((System.Drawing.Image)(resources.GetObject("mnuHelp.Image")));
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(56, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuHContents
            // 
            this.mnuHContents.Image = ((System.Drawing.Image)(resources.GetObject("mnuHContents.Image")));
            this.mnuHContents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuHContents.Name = "mnuHContents";
            this.mnuHContents.Size = new System.Drawing.Size(198, 22);
            this.mnuHContents.Text = "Contents...";
            // 
            // mnuHAbout
            // 
            this.mnuHAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuHAbout.Name = "mnuHAbout";
            this.mnuHAbout.Size = new System.Drawing.Size(198, 22);
            this.mnuHAbout.Text = "About STELLAR...";
            this.mnuHAbout.Click += new System.EventHandler(this.mnuHAbout_Click);
            // 
            // mnuHWeb
            // 
            this.mnuHWeb.Image = global::STELLAR.APP.Properties.Resources.world;
            this.mnuHWeb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuHWeb.Name = "mnuHWeb";
            this.mnuHWeb.Size = new System.Drawing.Size(198, 22);
            this.mnuHWeb.Text = "STELLAR on the Web...";
            this.mnuHWeb.Click += new System.EventHandler(this.mnuHWeb_Click);
            // 
            // lvwProcesses
            // 
            this.lvwProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwProcesses.CheckBoxes = true;
            this.lvwProcesses.Location = new System.Drawing.Point(0, 52);
            this.lvwProcesses.Name = "lvwProcesses";
            this.lvwProcesses.Size = new System.Drawing.Size(743, 386);
            this.lvwProcesses.TabIndex = 3;
            this.lvwProcesses.UseCompatibleStateImageBehavior = false;
            this.lvwProcesses.View = System.Windows.Forms.View.Details;
            this.lvwProcesses.DoubleClick += new System.EventHandler(this.lvwFileProcesses_DoubleClick);
            this.lvwProcesses.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwFileProcesses_ColumnClick);
            // 
            // imgImages
            // 
            this.imgImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgImages.ImageStream")));
            this.imgImages.TransparentColor = System.Drawing.Color.Transparent;
            this.imgImages.Images.SetKeyName(0, "cog.png");
            this.imgImages.Images.SetKeyName(1, "cog_error.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 509);
            this.Controls.Add(this.lvwProcesses);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.staStatus);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "STELLAR";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip staStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFExit;
        private System.Windows.Forms.ToolStripMenuItem mnuProcess;
        private System.Windows.Forms.ToolStripMenuItem mnuPRun;
        private System.Windows.Forms.ToolStripMenuItem mnuPPause;
        private System.Windows.Forms.ToolStripMenuItem mnuPStop;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHAbout;
        private System.Windows.Forms.ListView lvwProcesses;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRun;
        private System.Windows.Forms.ToolStripButton btnPause;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuHContents;
        private System.Windows.Forms.ToolStripMenuItem mnuHWeb;
        private System.Windows.Forms.ToolStripMenuItem mnuPRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ImageList imgImages;
        private System.Windows.Forms.ToolStripMenuItem mnuPEdit;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuVToolBar;
        private System.Windows.Forms.ToolStripMenuItem mnuVStatusBar;
        private System.Windows.Forms.ToolStripMenuItem mnuPBack;
        private System.Windows.Forms.OpenFileDialog dlgOpenProject;
        private System.Windows.Forms.SaveFileDialog dlgSaveProject;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuPAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuPAddNew;
        private System.Windows.Forms.ToolStripMenuItem mnuPAddExisting;
        private System.Windows.Forms.OpenFileDialog dlgOpenProcess;

    }
}