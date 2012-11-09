namespace STELLAR.Win
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Data Import", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Data Cleansing", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Copy file1 from server",
            "21/03/2010 12:12:00",
            "00:03:03"}, 6);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "change file name",
            "21/03/2010 12:15:01",
            "00:05:21"}, 2);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Convert file 1 to XML",
            "22/03/2010 15:15:34",
            "01:05:55"}, 1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Uppercase column 1", 7);
            this.staStatus = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
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
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPRun = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPPause = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPStop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHContents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imgImages = new System.Windows.Forms.ImageList(this.components);
            this.dlgOpenProject = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveProject = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpenProcess = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.lvwProcesses = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // staStatus
            // 
            this.staStatus.Location = new System.Drawing.Point(0, 433);
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
            this.btnNew.Image = Stellar.Win.Properties.Resources.folder_add;
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
            this.btnOpen.Image = Stellar.Win.Properties.Resources.folder_star;
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
            this.btnSave.Image = Stellar.Win.Properties.Resources.disk;
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = Stellar.Win.Properties.Resources.control_start_blue;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Back";
            // 
            // btnRun
            // 
            this.btnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRun.Image = Stellar.Win.Properties.Resources.control_play_blue;
            this.btnRun.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(23, 22);
            this.btnRun.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnPause
            // 
            this.btnPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPause.Image = Stellar.Win.Properties.Resources.control_pause_blue;
            this.btnPause.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(23, 22);
            this.btnPause.Text = "Pause";
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = Stellar.Win.Properties.Resources.control_stop_blue;
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
            this.mnuFile.Image = Stellar.Win.Properties.Resources.folder;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(51, 20);
            this.mnuFile.Text = "File";
            this.mnuFile.Click += new System.EventHandler(this.mnuFile_Click);
            // 
            // mnuFNew
            // 
            this.mnuFNew.Image = Stellar.Win.Properties.Resources.folder_add;
            this.mnuFNew.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuFNew.Name = "mnuFNew";
            this.mnuFNew.Size = new System.Drawing.Size(173, 22);
            this.mnuFNew.Text = "New Project...";
            this.mnuFNew.Click += new System.EventHandler(this.mnuFNew_Click);
            // 
            // mnuFOpen
            // 
            this.mnuFOpen.Image = Stellar.Win.Properties.Resources.folder_star;
            this.mnuFOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuFOpen.Name = "mnuFOpen";
            this.mnuFOpen.Size = new System.Drawing.Size(173, 22);
            this.mnuFOpen.Text = "Open Project...";
            this.mnuFOpen.Click += new System.EventHandler(this.mnuFOpen_Click);
            // 
            // mnuFSave
            // 
            this.mnuFSave.Image = Stellar.Win.Properties.Resources.disk;
            this.mnuFSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuFSave.Name = "mnuFSave";
            this.mnuFSave.Size = new System.Drawing.Size(173, 22);
            this.mnuFSave.Text = "Save Project";
            this.mnuFSave.Click += new System.EventHandler(this.mnuFSave_Click);
            // 
            // mnuFSaveAs
            // 
            this.mnuFSaveAs.Image = Stellar.Win.Properties.Resources.disk;
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
            this.mnuFExit.Image = Stellar.Win.Properties.Resources.door_in;
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
            this.mnuView.Image = Stellar.Win.Properties.Resources.eye;
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
            this.toolStripMenuItem2,
            this.mnuPBack,
            this.mnuPRun,
            this.mnuPPause,
            this.mnuPStop});
            this.mnuProcess.Image = Stellar.Win.Properties.Resources.cog;
            this.mnuProcess.Name = "mnuProcess";
            this.mnuProcess.Size = new System.Drawing.Size(72, 20);
            this.mnuProcess.Text = "Process";
            this.mnuProcess.Click += new System.EventHandler(this.mnuProcess_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuPBack
            // 
            this.mnuPBack.Image = Stellar.Win.Properties.Resources.control_start_blue;
            this.mnuPBack.Name = "mnuPBack";
            this.mnuPBack.Size = new System.Drawing.Size(152, 22);
            this.mnuPBack.Text = "Back";
            // 
            // mnuPRun
            // 
            this.mnuPRun.Image = Stellar.Win.Properties.Resources.control_play_blue;
            this.mnuPRun.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuPRun.Name = "mnuPRun";
            this.mnuPRun.Size = new System.Drawing.Size(152, 22);
            this.mnuPRun.Text = "Run";
            this.mnuPRun.Click += new System.EventHandler(this.mnuPRun_Click);
            // 
            // mnuPPause
            // 
            this.mnuPPause.Image = Stellar.Win.Properties.Resources.control_pause_blue;
            this.mnuPPause.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuPPause.Name = "mnuPPause";
            this.mnuPPause.Size = new System.Drawing.Size(152, 22);
            this.mnuPPause.Text = "Pause";
            this.mnuPPause.Click += new System.EventHandler(this.mnuPPause_Click);
            // 
            // mnuPStop
            // 
            this.mnuPStop.Image = Stellar.Win.Properties.Resources.control_stop_blue;
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
            this.mnuHWeb.Image = Stellar.Win.Properties.Resources.world;
            this.mnuHWeb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuHWeb.Name = "mnuHWeb";
            this.mnuHWeb.Size = new System.Drawing.Size(198, 22);
            this.mnuHWeb.Text = "STELLAR on the Web...";
            this.mnuHWeb.Click += new System.EventHandler(this.mnuHWeb_Click);
            // 
            // imgImages
            // 
            this.imgImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgImages.ImageStream")));
            this.imgImages.TransparentColor = System.Drawing.Color.Transparent;
            this.imgImages.Images.SetKeyName(0, "cog.png");
            this.imgImages.Images.SetKeyName(1, "cog_error.png");
            this.imgImages.Images.SetKeyName(2, "application_osx_terminal.png");
            this.imgImages.Images.SetKeyName(3, "application_xp_terminal.png");
            this.imgImages.Images.SetKeyName(4, "page_world.png");
            this.imgImages.Images.SetKeyName(5, "database_go.png");
            this.imgImages.Images.SetKeyName(6, "server_go.png");
            this.imgImages.Images.SetKeyName(7, "text_uppercase.png");
            this.imgImages.Images.SetKeyName(8, "text_lowercase.png");
            this.imgImages.Images.SetKeyName(9, "text_replace.png");
            this.imgImages.Images.SetKeyName(10, "zoom_out.png");
            this.imgImages.Images.SetKeyName(11, "accept.png");
            this.imgImages.Images.SetKeyName(12, "add.png");
            this.imgImages.Images.SetKeyName(13, "anchor.png");
            this.imgImages.Images.SetKeyName(14, "application.png");
            this.imgImages.Images.SetKeyName(15, "application_add.png");
            this.imgImages.Images.SetKeyName(16, "application_cascade.png");
            this.imgImages.Images.SetKeyName(17, "application_delete.png");
            this.imgImages.Images.SetKeyName(18, "application_double.png");
            this.imgImages.Images.SetKeyName(19, "application_edit.png");
            this.imgImages.Images.SetKeyName(20, "application_error.png");
            this.imgImages.Images.SetKeyName(21, "application_form.png");
            this.imgImages.Images.SetKeyName(22, "application_form_add.png");
            this.imgImages.Images.SetKeyName(23, "application_form_delete.png");
            this.imgImages.Images.SetKeyName(24, "application_form_edit.png");
            this.imgImages.Images.SetKeyName(25, "application_form_magnify.png");
            this.imgImages.Images.SetKeyName(26, "application_get.png");
            this.imgImages.Images.SetKeyName(27, "application_go.png");
            this.imgImages.Images.SetKeyName(28, "application_home.png");
            this.imgImages.Images.SetKeyName(29, "application_key.png");
            this.imgImages.Images.SetKeyName(30, "application_lightning.png");
            this.imgImages.Images.SetKeyName(31, "application_link.png");
            this.imgImages.Images.SetKeyName(32, "application_osx.png");
            this.imgImages.Images.SetKeyName(33, "application_osx_terminal.png");
            this.imgImages.Images.SetKeyName(34, "application_put.png");
            this.imgImages.Images.SetKeyName(35, "application_side_boxes.png");
            this.imgImages.Images.SetKeyName(36, "application_side_contract.png");
            this.imgImages.Images.SetKeyName(37, "application_side_expand.png");
            this.imgImages.Images.SetKeyName(38, "application_side_list.png");
            this.imgImages.Images.SetKeyName(39, "application_side_tree.png");
            this.imgImages.Images.SetKeyName(40, "application_split.png");
            this.imgImages.Images.SetKeyName(41, "application_tile_horizontal.png");
            this.imgImages.Images.SetKeyName(42, "application_tile_vertical.png");
            this.imgImages.Images.SetKeyName(43, "application_view_columns.png");
            this.imgImages.Images.SetKeyName(44, "application_view_detail.png");
            this.imgImages.Images.SetKeyName(45, "application_view_gallery.png");
            this.imgImages.Images.SetKeyName(46, "application_view_icons.png");
            this.imgImages.Images.SetKeyName(47, "application_view_list.png");
            this.imgImages.Images.SetKeyName(48, "application_view_tile.png");
            this.imgImages.Images.SetKeyName(49, "application_xp.png");
            this.imgImages.Images.SetKeyName(50, "application_xp_terminal.png");
            this.imgImages.Images.SetKeyName(51, "arrow_branch.png");
            this.imgImages.Images.SetKeyName(52, "arrow_divide.png");
            this.imgImages.Images.SetKeyName(53, "arrow_down.png");
            this.imgImages.Images.SetKeyName(54, "arrow_in.png");
            this.imgImages.Images.SetKeyName(55, "arrow_inout.png");
            this.imgImages.Images.SetKeyName(56, "arrow_join.png");
            this.imgImages.Images.SetKeyName(57, "arrow_left.png");
            this.imgImages.Images.SetKeyName(58, "arrow_merge.png");
            this.imgImages.Images.SetKeyName(59, "arrow_out.png");
            this.imgImages.Images.SetKeyName(60, "arrow_redo.png");
            this.imgImages.Images.SetKeyName(61, "arrow_refresh.png");
            this.imgImages.Images.SetKeyName(62, "arrow_refresh_small.png");
            this.imgImages.Images.SetKeyName(63, "arrow_right.png");
            this.imgImages.Images.SetKeyName(64, "arrow_rotate_anticlockwise.png");
            this.imgImages.Images.SetKeyName(65, "arrow_rotate_clockwise.png");
            this.imgImages.Images.SetKeyName(66, "arrow_switch.png");
            this.imgImages.Images.SetKeyName(67, "arrow_turn_left.png");
            this.imgImages.Images.SetKeyName(68, "arrow_turn_right.png");
            this.imgImages.Images.SetKeyName(69, "arrow_undo.png");
            this.imgImages.Images.SetKeyName(70, "arrow_up.png");
            this.imgImages.Images.SetKeyName(71, "asterisk_orange.png");
            this.imgImages.Images.SetKeyName(72, "asterisk_yellow.png");
            this.imgImages.Images.SetKeyName(73, "attach.png");
            this.imgImages.Images.SetKeyName(74, "award_star_add.png");
            this.imgImages.Images.SetKeyName(75, "award_star_bronze_1.png");
            this.imgImages.Images.SetKeyName(76, "award_star_bronze_2.png");
            this.imgImages.Images.SetKeyName(77, "award_star_bronze_3.png");
            this.imgImages.Images.SetKeyName(78, "award_star_delete.png");
            this.imgImages.Images.SetKeyName(79, "award_star_gold_1.png");
            this.imgImages.Images.SetKeyName(80, "award_star_gold_2.png");
            this.imgImages.Images.SetKeyName(81, "award_star_gold_3.png");
            this.imgImages.Images.SetKeyName(82, "award_star_silver_1.png");
            this.imgImages.Images.SetKeyName(83, "award_star_silver_2.png");
            this.imgImages.Images.SetKeyName(84, "award_star_silver_3.png");
            this.imgImages.Images.SetKeyName(85, "basket.png");
            this.imgImages.Images.SetKeyName(86, "basket_add.png");
            this.imgImages.Images.SetKeyName(87, "basket_delete.png");
            this.imgImages.Images.SetKeyName(88, "basket_edit.png");
            this.imgImages.Images.SetKeyName(89, "basket_error.png");
            this.imgImages.Images.SetKeyName(90, "basket_go.png");
            this.imgImages.Images.SetKeyName(91, "basket_put.png");
            this.imgImages.Images.SetKeyName(92, "basket_remove.png");
            this.imgImages.Images.SetKeyName(93, "bell.png");
            this.imgImages.Images.SetKeyName(94, "bell_add.png");
            this.imgImages.Images.SetKeyName(95, "bell_delete.png");
            this.imgImages.Images.SetKeyName(96, "bell_error.png");
            this.imgImages.Images.SetKeyName(97, "bell_go.png");
            this.imgImages.Images.SetKeyName(98, "bell_link.png");
            this.imgImages.Images.SetKeyName(99, "bin.png");
            this.imgImages.Images.SetKeyName(100, "bin_closed.png");
            this.imgImages.Images.SetKeyName(101, "bin_empty.png");
            this.imgImages.Images.SetKeyName(102, "bomb.png");
            this.imgImages.Images.SetKeyName(103, "book.png");
            this.imgImages.Images.SetKeyName(104, "book_add.png");
            this.imgImages.Images.SetKeyName(105, "book_addresses.png");
            this.imgImages.Images.SetKeyName(106, "book_delete.png");
            this.imgImages.Images.SetKeyName(107, "book_edit.png");
            this.imgImages.Images.SetKeyName(108, "book_error.png");
            this.imgImages.Images.SetKeyName(109, "book_go.png");
            this.imgImages.Images.SetKeyName(110, "book_key.png");
            this.imgImages.Images.SetKeyName(111, "book_link.png");
            this.imgImages.Images.SetKeyName(112, "book_next.png");
            this.imgImages.Images.SetKeyName(113, "book_open.png");
            this.imgImages.Images.SetKeyName(114, "book_previous.png");
            this.imgImages.Images.SetKeyName(115, "box.png");
            this.imgImages.Images.SetKeyName(116, "brick.png");
            this.imgImages.Images.SetKeyName(117, "brick_add.png");
            this.imgImages.Images.SetKeyName(118, "brick_delete.png");
            this.imgImages.Images.SetKeyName(119, "brick_edit.png");
            this.imgImages.Images.SetKeyName(120, "brick_error.png");
            this.imgImages.Images.SetKeyName(121, "brick_go.png");
            this.imgImages.Images.SetKeyName(122, "brick_link.png");
            this.imgImages.Images.SetKeyName(123, "bricks.png");
            this.imgImages.Images.SetKeyName(124, "briefcase.png");
            this.imgImages.Images.SetKeyName(125, "bug.png");
            this.imgImages.Images.SetKeyName(126, "bug_add.png");
            this.imgImages.Images.SetKeyName(127, "bug_delete.png");
            this.imgImages.Images.SetKeyName(128, "bug_edit.png");
            this.imgImages.Images.SetKeyName(129, "bug_error.png");
            this.imgImages.Images.SetKeyName(130, "bug_go.png");
            this.imgImages.Images.SetKeyName(131, "bug_link.png");
            this.imgImages.Images.SetKeyName(132, "building.png");
            this.imgImages.Images.SetKeyName(133, "building_add.png");
            this.imgImages.Images.SetKeyName(134, "building_delete.png");
            this.imgImages.Images.SetKeyName(135, "building_edit.png");
            this.imgImages.Images.SetKeyName(136, "building_error.png");
            this.imgImages.Images.SetKeyName(137, "building_go.png");
            this.imgImages.Images.SetKeyName(138, "building_key.png");
            this.imgImages.Images.SetKeyName(139, "building_link.png");
            this.imgImages.Images.SetKeyName(140, "bullet_add.png");
            this.imgImages.Images.SetKeyName(141, "bullet_arrow_bottom.png");
            this.imgImages.Images.SetKeyName(142, "bullet_arrow_down.png");
            this.imgImages.Images.SetKeyName(143, "bullet_arrow_top.png");
            this.imgImages.Images.SetKeyName(144, "bullet_arrow_up.png");
            this.imgImages.Images.SetKeyName(145, "bullet_black.png");
            this.imgImages.Images.SetKeyName(146, "bullet_blue.png");
            this.imgImages.Images.SetKeyName(147, "bullet_delete.png");
            this.imgImages.Images.SetKeyName(148, "bullet_disk.png");
            this.imgImages.Images.SetKeyName(149, "bullet_error.png");
            this.imgImages.Images.SetKeyName(150, "bullet_feed.png");
            this.imgImages.Images.SetKeyName(151, "bullet_go.png");
            this.imgImages.Images.SetKeyName(152, "bullet_green.png");
            this.imgImages.Images.SetKeyName(153, "bullet_key.png");
            this.imgImages.Images.SetKeyName(154, "bullet_orange.png");
            this.imgImages.Images.SetKeyName(155, "bullet_picture.png");
            this.imgImages.Images.SetKeyName(156, "bullet_pink.png");
            this.imgImages.Images.SetKeyName(157, "bullet_purple.png");
            this.imgImages.Images.SetKeyName(158, "bullet_red.png");
            this.imgImages.Images.SetKeyName(159, "bullet_star.png");
            this.imgImages.Images.SetKeyName(160, "bullet_toggle_minus.png");
            this.imgImages.Images.SetKeyName(161, "bullet_toggle_plus.png");
            this.imgImages.Images.SetKeyName(162, "bullet_white.png");
            this.imgImages.Images.SetKeyName(163, "bullet_wrench.png");
            this.imgImages.Images.SetKeyName(164, "bullet_yellow.png");
            this.imgImages.Images.SetKeyName(165, "cake.png");
            this.imgImages.Images.SetKeyName(166, "calculator.png");
            this.imgImages.Images.SetKeyName(167, "calculator_add.png");
            this.imgImages.Images.SetKeyName(168, "calculator_delete.png");
            this.imgImages.Images.SetKeyName(169, "calculator_edit.png");
            this.imgImages.Images.SetKeyName(170, "calculator_error.png");
            this.imgImages.Images.SetKeyName(171, "calculator_link.png");
            this.imgImages.Images.SetKeyName(172, "calendar.png");
            this.imgImages.Images.SetKeyName(173, "calendar_add.png");
            this.imgImages.Images.SetKeyName(174, "calendar_delete.png");
            this.imgImages.Images.SetKeyName(175, "calendar_edit.png");
            this.imgImages.Images.SetKeyName(176, "calendar_link.png");
            this.imgImages.Images.SetKeyName(177, "calendar_view_day.png");
            this.imgImages.Images.SetKeyName(178, "calendar_view_month.png");
            this.imgImages.Images.SetKeyName(179, "calendar_view_week.png");
            this.imgImages.Images.SetKeyName(180, "camera.png");
            this.imgImages.Images.SetKeyName(181, "camera_add.png");
            this.imgImages.Images.SetKeyName(182, "camera_delete.png");
            this.imgImages.Images.SetKeyName(183, "camera_edit.png");
            this.imgImages.Images.SetKeyName(184, "camera_error.png");
            this.imgImages.Images.SetKeyName(185, "camera_go.png");
            this.imgImages.Images.SetKeyName(186, "camera_link.png");
            this.imgImages.Images.SetKeyName(187, "camera_small.png");
            this.imgImages.Images.SetKeyName(188, "cancel.png");
            this.imgImages.Images.SetKeyName(189, "car.png");
            this.imgImages.Images.SetKeyName(190, "car_add.png");
            this.imgImages.Images.SetKeyName(191, "car_delete.png");
            this.imgImages.Images.SetKeyName(192, "cart.png");
            this.imgImages.Images.SetKeyName(193, "cart_add.png");
            this.imgImages.Images.SetKeyName(194, "cart_delete.png");
            this.imgImages.Images.SetKeyName(195, "cart_edit.png");
            this.imgImages.Images.SetKeyName(196, "cart_error.png");
            this.imgImages.Images.SetKeyName(197, "cart_go.png");
            this.imgImages.Images.SetKeyName(198, "cart_put.png");
            this.imgImages.Images.SetKeyName(199, "cart_remove.png");
            this.imgImages.Images.SetKeyName(200, "cd.png");
            this.imgImages.Images.SetKeyName(201, "cd_add.png");
            this.imgImages.Images.SetKeyName(202, "cd_burn.png");
            this.imgImages.Images.SetKeyName(203, "cd_delete.png");
            this.imgImages.Images.SetKeyName(204, "cd_edit.png");
            this.imgImages.Images.SetKeyName(205, "cd_eject.png");
            this.imgImages.Images.SetKeyName(206, "cd_go.png");
            this.imgImages.Images.SetKeyName(207, "chart_bar.png");
            this.imgImages.Images.SetKeyName(208, "chart_bar_add.png");
            this.imgImages.Images.SetKeyName(209, "chart_bar_delete.png");
            this.imgImages.Images.SetKeyName(210, "chart_bar_edit.png");
            this.imgImages.Images.SetKeyName(211, "chart_bar_error.png");
            this.imgImages.Images.SetKeyName(212, "chart_bar_link.png");
            this.imgImages.Images.SetKeyName(213, "chart_curve.png");
            this.imgImages.Images.SetKeyName(214, "chart_curve_add.png");
            this.imgImages.Images.SetKeyName(215, "chart_curve_delete.png");
            this.imgImages.Images.SetKeyName(216, "chart_curve_edit.png");
            this.imgImages.Images.SetKeyName(217, "chart_curve_error.png");
            this.imgImages.Images.SetKeyName(218, "chart_curve_go.png");
            this.imgImages.Images.SetKeyName(219, "chart_curve_link.png");
            this.imgImages.Images.SetKeyName(220, "chart_line.png");
            this.imgImages.Images.SetKeyName(221, "chart_line_add.png");
            this.imgImages.Images.SetKeyName(222, "chart_line_delete.png");
            this.imgImages.Images.SetKeyName(223, "chart_line_edit.png");
            this.imgImages.Images.SetKeyName(224, "chart_line_error.png");
            this.imgImages.Images.SetKeyName(225, "chart_line_link.png");
            this.imgImages.Images.SetKeyName(226, "chart_organisation.png");
            this.imgImages.Images.SetKeyName(227, "chart_organisation_add.png");
            this.imgImages.Images.SetKeyName(228, "chart_organisation_delete.png");
            this.imgImages.Images.SetKeyName(229, "chart_pie.png");
            this.imgImages.Images.SetKeyName(230, "chart_pie_add.png");
            this.imgImages.Images.SetKeyName(231, "chart_pie_delete.png");
            this.imgImages.Images.SetKeyName(232, "chart_pie_edit.png");
            this.imgImages.Images.SetKeyName(233, "chart_pie_error.png");
            this.imgImages.Images.SetKeyName(234, "chart_pie_link.png");
            this.imgImages.Images.SetKeyName(235, "clock.png");
            this.imgImages.Images.SetKeyName(236, "clock_add.png");
            this.imgImages.Images.SetKeyName(237, "clock_delete.png");
            this.imgImages.Images.SetKeyName(238, "clock_edit.png");
            this.imgImages.Images.SetKeyName(239, "clock_error.png");
            this.imgImages.Images.SetKeyName(240, "clock_go.png");
            this.imgImages.Images.SetKeyName(241, "clock_link.png");
            this.imgImages.Images.SetKeyName(242, "clock_pause.png");
            this.imgImages.Images.SetKeyName(243, "clock_play.png");
            this.imgImages.Images.SetKeyName(244, "clock_red.png");
            this.imgImages.Images.SetKeyName(245, "clock_stop.png");
            this.imgImages.Images.SetKeyName(246, "cog.png");
            this.imgImages.Images.SetKeyName(247, "cog_add.png");
            this.imgImages.Images.SetKeyName(248, "cog_delete.png");
            this.imgImages.Images.SetKeyName(249, "cog_edit.png");
            this.imgImages.Images.SetKeyName(250, "cog_error.png");
            this.imgImages.Images.SetKeyName(251, "cog_go.png");
            this.imgImages.Images.SetKeyName(252, "coins.png");
            this.imgImages.Images.SetKeyName(253, "coins_add.png");
            this.imgImages.Images.SetKeyName(254, "coins_delete.png");
            this.imgImages.Images.SetKeyName(255, "color_swatch.png");
            this.imgImages.Images.SetKeyName(256, "color_wheel.png");
            this.imgImages.Images.SetKeyName(257, "comment.png");
            this.imgImages.Images.SetKeyName(258, "comment_add.png");
            this.imgImages.Images.SetKeyName(259, "comment_delete.png");
            this.imgImages.Images.SetKeyName(260, "comment_edit.png");
            this.imgImages.Images.SetKeyName(261, "comments.png");
            this.imgImages.Images.SetKeyName(262, "comments_add.png");
            this.imgImages.Images.SetKeyName(263, "comments_delete.png");
            this.imgImages.Images.SetKeyName(264, "compress.png");
            this.imgImages.Images.SetKeyName(265, "computer.png");
            this.imgImages.Images.SetKeyName(266, "computer_add.png");
            this.imgImages.Images.SetKeyName(267, "computer_delete.png");
            this.imgImages.Images.SetKeyName(268, "computer_edit.png");
            this.imgImages.Images.SetKeyName(269, "computer_error.png");
            this.imgImages.Images.SetKeyName(270, "computer_go.png");
            this.imgImages.Images.SetKeyName(271, "computer_key.png");
            this.imgImages.Images.SetKeyName(272, "computer_link.png");
            this.imgImages.Images.SetKeyName(273, "connect.png");
            this.imgImages.Images.SetKeyName(274, "contrast.png");
            this.imgImages.Images.SetKeyName(275, "contrast_decrease.png");
            this.imgImages.Images.SetKeyName(276, "contrast_high.png");
            this.imgImages.Images.SetKeyName(277, "contrast_increase.png");
            this.imgImages.Images.SetKeyName(278, "contrast_low.png");
            this.imgImages.Images.SetKeyName(279, "control_eject.png");
            this.imgImages.Images.SetKeyName(280, "control_eject_blue.png");
            this.imgImages.Images.SetKeyName(281, "control_end.png");
            this.imgImages.Images.SetKeyName(282, "control_end_blue.png");
            this.imgImages.Images.SetKeyName(283, "control_equalizer.png");
            this.imgImages.Images.SetKeyName(284, "control_equalizer_blue.png");
            this.imgImages.Images.SetKeyName(285, "control_fastforward.png");
            this.imgImages.Images.SetKeyName(286, "control_fastforward_blue.png");
            this.imgImages.Images.SetKeyName(287, "control_pause.png");
            this.imgImages.Images.SetKeyName(288, "control_pause_blue.png");
            this.imgImages.Images.SetKeyName(289, "control_play.png");
            this.imgImages.Images.SetKeyName(290, "control_play_blue.png");
            this.imgImages.Images.SetKeyName(291, "control_repeat.png");
            this.imgImages.Images.SetKeyName(292, "control_repeat_blue.png");
            this.imgImages.Images.SetKeyName(293, "control_rewind.png");
            this.imgImages.Images.SetKeyName(294, "control_rewind_blue.png");
            this.imgImages.Images.SetKeyName(295, "control_start.png");
            this.imgImages.Images.SetKeyName(296, "control_start_blue.png");
            this.imgImages.Images.SetKeyName(297, "control_stop.png");
            this.imgImages.Images.SetKeyName(298, "control_stop_blue.png");
            this.imgImages.Images.SetKeyName(299, "controller.png");
            this.imgImages.Images.SetKeyName(300, "controller_add.png");
            this.imgImages.Images.SetKeyName(301, "controller_delete.png");
            this.imgImages.Images.SetKeyName(302, "controller_error.png");
            this.imgImages.Images.SetKeyName(303, "creditcards.png");
            this.imgImages.Images.SetKeyName(304, "cross.png");
            this.imgImages.Images.SetKeyName(305, "css.png");
            this.imgImages.Images.SetKeyName(306, "css_add.png");
            this.imgImages.Images.SetKeyName(307, "css_delete.png");
            this.imgImages.Images.SetKeyName(308, "css_go.png");
            this.imgImages.Images.SetKeyName(309, "css_valid.png");
            this.imgImages.Images.SetKeyName(310, "cup.png");
            this.imgImages.Images.SetKeyName(311, "cup_add.png");
            this.imgImages.Images.SetKeyName(312, "cup_delete.png");
            this.imgImages.Images.SetKeyName(313, "cup_edit.png");
            this.imgImages.Images.SetKeyName(314, "cup_error.png");
            this.imgImages.Images.SetKeyName(315, "cup_go.png");
            this.imgImages.Images.SetKeyName(316, "cup_key.png");
            this.imgImages.Images.SetKeyName(317, "cup_link.png");
            this.imgImages.Images.SetKeyName(318, "cursor.png");
            this.imgImages.Images.SetKeyName(319, "cut.png");
            this.imgImages.Images.SetKeyName(320, "cut_red.png");
            this.imgImages.Images.SetKeyName(321, "database.png");
            this.imgImages.Images.SetKeyName(322, "database_add.png");
            this.imgImages.Images.SetKeyName(323, "database_connect.png");
            this.imgImages.Images.SetKeyName(324, "database_delete.png");
            this.imgImages.Images.SetKeyName(325, "database_edit.png");
            this.imgImages.Images.SetKeyName(326, "database_error.png");
            this.imgImages.Images.SetKeyName(327, "database_gear.png");
            this.imgImages.Images.SetKeyName(328, "database_go.png");
            this.imgImages.Images.SetKeyName(329, "database_key.png");
            this.imgImages.Images.SetKeyName(330, "database_lightning.png");
            this.imgImages.Images.SetKeyName(331, "database_link.png");
            this.imgImages.Images.SetKeyName(332, "database_refresh.png");
            this.imgImages.Images.SetKeyName(333, "database_save.png");
            this.imgImages.Images.SetKeyName(334, "database_table.png");
            this.imgImages.Images.SetKeyName(335, "date.png");
            this.imgImages.Images.SetKeyName(336, "date_add.png");
            this.imgImages.Images.SetKeyName(337, "date_delete.png");
            this.imgImages.Images.SetKeyName(338, "date_edit.png");
            this.imgImages.Images.SetKeyName(339, "date_error.png");
            this.imgImages.Images.SetKeyName(340, "date_go.png");
            this.imgImages.Images.SetKeyName(341, "date_link.png");
            this.imgImages.Images.SetKeyName(342, "date_magnify.png");
            this.imgImages.Images.SetKeyName(343, "date_next.png");
            this.imgImages.Images.SetKeyName(344, "date_previous.png");
            this.imgImages.Images.SetKeyName(345, "delete.png");
            this.imgImages.Images.SetKeyName(346, "disconnect.png");
            this.imgImages.Images.SetKeyName(347, "disk.png");
            this.imgImages.Images.SetKeyName(348, "disk_multiple.png");
            this.imgImages.Images.SetKeyName(349, "door.png");
            this.imgImages.Images.SetKeyName(350, "door_in.png");
            this.imgImages.Images.SetKeyName(351, "door_open.png");
            this.imgImages.Images.SetKeyName(352, "door_out.png");
            this.imgImages.Images.SetKeyName(353, "drink.png");
            this.imgImages.Images.SetKeyName(354, "drink_empty.png");
            this.imgImages.Images.SetKeyName(355, "drive.png");
            this.imgImages.Images.SetKeyName(356, "drive_add.png");
            this.imgImages.Images.SetKeyName(357, "drive_burn.png");
            this.imgImages.Images.SetKeyName(358, "drive_cd.png");
            this.imgImages.Images.SetKeyName(359, "drive_cd_empty.png");
            this.imgImages.Images.SetKeyName(360, "drive_delete.png");
            this.imgImages.Images.SetKeyName(361, "drive_disk.png");
            this.imgImages.Images.SetKeyName(362, "drive_edit.png");
            this.imgImages.Images.SetKeyName(363, "drive_error.png");
            this.imgImages.Images.SetKeyName(364, "drive_go.png");
            this.imgImages.Images.SetKeyName(365, "drive_key.png");
            this.imgImages.Images.SetKeyName(366, "drive_link.png");
            this.imgImages.Images.SetKeyName(367, "drive_magnify.png");
            this.imgImages.Images.SetKeyName(368, "drive_network.png");
            this.imgImages.Images.SetKeyName(369, "drive_rename.png");
            this.imgImages.Images.SetKeyName(370, "drive_user.png");
            this.imgImages.Images.SetKeyName(371, "drive_web.png");
            this.imgImages.Images.SetKeyName(372, "dvd.png");
            this.imgImages.Images.SetKeyName(373, "dvd_add.png");
            this.imgImages.Images.SetKeyName(374, "dvd_delete.png");
            this.imgImages.Images.SetKeyName(375, "dvd_edit.png");
            this.imgImages.Images.SetKeyName(376, "dvd_error.png");
            this.imgImages.Images.SetKeyName(377, "dvd_go.png");
            this.imgImages.Images.SetKeyName(378, "dvd_key.png");
            this.imgImages.Images.SetKeyName(379, "dvd_link.png");
            this.imgImages.Images.SetKeyName(380, "email.png");
            this.imgImages.Images.SetKeyName(381, "email_add.png");
            this.imgImages.Images.SetKeyName(382, "email_attach.png");
            this.imgImages.Images.SetKeyName(383, "email_delete.png");
            this.imgImages.Images.SetKeyName(384, "email_edit.png");
            this.imgImages.Images.SetKeyName(385, "email_error.png");
            this.imgImages.Images.SetKeyName(386, "email_go.png");
            this.imgImages.Images.SetKeyName(387, "email_link.png");
            this.imgImages.Images.SetKeyName(388, "email_open.png");
            this.imgImages.Images.SetKeyName(389, "email_open_image.png");
            this.imgImages.Images.SetKeyName(390, "emoticon_evilgrin.png");
            this.imgImages.Images.SetKeyName(391, "emoticon_grin.png");
            this.imgImages.Images.SetKeyName(392, "emoticon_happy.png");
            this.imgImages.Images.SetKeyName(393, "emoticon_smile.png");
            this.imgImages.Images.SetKeyName(394, "emoticon_surprised.png");
            this.imgImages.Images.SetKeyName(395, "emoticon_tongue.png");
            this.imgImages.Images.SetKeyName(396, "emoticon_unhappy.png");
            this.imgImages.Images.SetKeyName(397, "emoticon_waii.png");
            this.imgImages.Images.SetKeyName(398, "emoticon_wink.png");
            this.imgImages.Images.SetKeyName(399, "error.png");
            this.imgImages.Images.SetKeyName(400, "error_add.png");
            this.imgImages.Images.SetKeyName(401, "error_delete.png");
            this.imgImages.Images.SetKeyName(402, "error_go.png");
            this.imgImages.Images.SetKeyName(403, "exclamation.png");
            this.imgImages.Images.SetKeyName(404, "eye.png");
            this.imgImages.Images.SetKeyName(405, "feed.png");
            this.imgImages.Images.SetKeyName(406, "feed_add.png");
            this.imgImages.Images.SetKeyName(407, "feed_delete.png");
            this.imgImages.Images.SetKeyName(408, "feed_disk.png");
            this.imgImages.Images.SetKeyName(409, "feed_edit.png");
            this.imgImages.Images.SetKeyName(410, "feed_error.png");
            this.imgImages.Images.SetKeyName(411, "feed_go.png");
            this.imgImages.Images.SetKeyName(412, "feed_key.png");
            this.imgImages.Images.SetKeyName(413, "feed_link.png");
            this.imgImages.Images.SetKeyName(414, "feed_magnify.png");
            this.imgImages.Images.SetKeyName(415, "female.png");
            this.imgImages.Images.SetKeyName(416, "film.png");
            this.imgImages.Images.SetKeyName(417, "film_add.png");
            this.imgImages.Images.SetKeyName(418, "film_delete.png");
            this.imgImages.Images.SetKeyName(419, "film_edit.png");
            this.imgImages.Images.SetKeyName(420, "film_error.png");
            this.imgImages.Images.SetKeyName(421, "film_go.png");
            this.imgImages.Images.SetKeyName(422, "film_key.png");
            this.imgImages.Images.SetKeyName(423, "film_link.png");
            this.imgImages.Images.SetKeyName(424, "film_save.png");
            this.imgImages.Images.SetKeyName(425, "find.png");
            this.imgImages.Images.SetKeyName(426, "flag_blue.png");
            this.imgImages.Images.SetKeyName(427, "flag_green.png");
            this.imgImages.Images.SetKeyName(428, "flag_orange.png");
            this.imgImages.Images.SetKeyName(429, "flag_pink.png");
            this.imgImages.Images.SetKeyName(430, "flag_purple.png");
            this.imgImages.Images.SetKeyName(431, "flag_red.png");
            this.imgImages.Images.SetKeyName(432, "flag_yellow.png");
            this.imgImages.Images.SetKeyName(433, "folder.png");
            this.imgImages.Images.SetKeyName(434, "folder_add.png");
            this.imgImages.Images.SetKeyName(435, "folder_bell.png");
            this.imgImages.Images.SetKeyName(436, "folder_brick.png");
            this.imgImages.Images.SetKeyName(437, "folder_bug.png");
            this.imgImages.Images.SetKeyName(438, "folder_camera.png");
            this.imgImages.Images.SetKeyName(439, "folder_database.png");
            this.imgImages.Images.SetKeyName(440, "folder_delete.png");
            this.imgImages.Images.SetKeyName(441, "folder_edit.png");
            this.imgImages.Images.SetKeyName(442, "folder_error.png");
            this.imgImages.Images.SetKeyName(443, "folder_explore.png");
            this.imgImages.Images.SetKeyName(444, "folder_feed.png");
            this.imgImages.Images.SetKeyName(445, "folder_find.png");
            this.imgImages.Images.SetKeyName(446, "folder_go.png");
            this.imgImages.Images.SetKeyName(447, "folder_heart.png");
            this.imgImages.Images.SetKeyName(448, "folder_image.png");
            this.imgImages.Images.SetKeyName(449, "folder_key.png");
            this.imgImages.Images.SetKeyName(450, "folder_lightbulb.png");
            this.imgImages.Images.SetKeyName(451, "folder_link.png");
            this.imgImages.Images.SetKeyName(452, "folder_magnify.png");
            this.imgImages.Images.SetKeyName(453, "folder_page.png");
            this.imgImages.Images.SetKeyName(454, "folder_page_white.png");
            this.imgImages.Images.SetKeyName(455, "folder_palette.png");
            this.imgImages.Images.SetKeyName(456, "folder_picture.png");
            this.imgImages.Images.SetKeyName(457, "folder_star.png");
            this.imgImages.Images.SetKeyName(458, "folder_table.png");
            this.imgImages.Images.SetKeyName(459, "folder_user.png");
            this.imgImages.Images.SetKeyName(460, "folder_wrench.png");
            this.imgImages.Images.SetKeyName(461, "font.png");
            this.imgImages.Images.SetKeyName(462, "font_add.png");
            this.imgImages.Images.SetKeyName(463, "font_delete.png");
            this.imgImages.Images.SetKeyName(464, "font_go.png");
            this.imgImages.Images.SetKeyName(465, "group.png");
            this.imgImages.Images.SetKeyName(466, "group_add.png");
            this.imgImages.Images.SetKeyName(467, "group_delete.png");
            this.imgImages.Images.SetKeyName(468, "group_edit.png");
            this.imgImages.Images.SetKeyName(469, "group_error.png");
            this.imgImages.Images.SetKeyName(470, "group_gear.png");
            this.imgImages.Images.SetKeyName(471, "group_go.png");
            this.imgImages.Images.SetKeyName(472, "group_key.png");
            this.imgImages.Images.SetKeyName(473, "group_link.png");
            this.imgImages.Images.SetKeyName(474, "heart.png");
            this.imgImages.Images.SetKeyName(475, "heart_add.png");
            this.imgImages.Images.SetKeyName(476, "heart_delete.png");
            this.imgImages.Images.SetKeyName(477, "help.png");
            this.imgImages.Images.SetKeyName(478, "hourglass.png");
            this.imgImages.Images.SetKeyName(479, "hourglass_add.png");
            this.imgImages.Images.SetKeyName(480, "hourglass_delete.png");
            this.imgImages.Images.SetKeyName(481, "hourglass_go.png");
            this.imgImages.Images.SetKeyName(482, "hourglass_link.png");
            this.imgImages.Images.SetKeyName(483, "house.png");
            this.imgImages.Images.SetKeyName(484, "house_go.png");
            this.imgImages.Images.SetKeyName(485, "house_link.png");
            this.imgImages.Images.SetKeyName(486, "html.png");
            this.imgImages.Images.SetKeyName(487, "html_add.png");
            this.imgImages.Images.SetKeyName(488, "html_delete.png");
            this.imgImages.Images.SetKeyName(489, "html_go.png");
            this.imgImages.Images.SetKeyName(490, "html_valid.png");
            this.imgImages.Images.SetKeyName(491, "image.png");
            this.imgImages.Images.SetKeyName(492, "image_add.png");
            this.imgImages.Images.SetKeyName(493, "image_delete.png");
            this.imgImages.Images.SetKeyName(494, "image_edit.png");
            this.imgImages.Images.SetKeyName(495, "image_link.png");
            this.imgImages.Images.SetKeyName(496, "images.png");
            this.imgImages.Images.SetKeyName(497, "information.png");
            this.imgImages.Images.SetKeyName(498, "ipod.png");
            this.imgImages.Images.SetKeyName(499, "ipod_cast.png");
            this.imgImages.Images.SetKeyName(500, "ipod_cast_add.png");
            this.imgImages.Images.SetKeyName(501, "ipod_cast_delete.png");
            this.imgImages.Images.SetKeyName(502, "ipod_sound.png");
            this.imgImages.Images.SetKeyName(503, "joystick.png");
            this.imgImages.Images.SetKeyName(504, "joystick_add.png");
            this.imgImages.Images.SetKeyName(505, "joystick_delete.png");
            this.imgImages.Images.SetKeyName(506, "joystick_error.png");
            this.imgImages.Images.SetKeyName(507, "key.png");
            this.imgImages.Images.SetKeyName(508, "key_add.png");
            this.imgImages.Images.SetKeyName(509, "key_delete.png");
            this.imgImages.Images.SetKeyName(510, "key_go.png");
            this.imgImages.Images.SetKeyName(511, "keyboard.png");
            this.imgImages.Images.SetKeyName(512, "keyboard_add.png");
            this.imgImages.Images.SetKeyName(513, "keyboard_delete.png");
            this.imgImages.Images.SetKeyName(514, "keyboard_magnify.png");
            this.imgImages.Images.SetKeyName(515, "layers.png");
            this.imgImages.Images.SetKeyName(516, "layout.png");
            this.imgImages.Images.SetKeyName(517, "layout_add.png");
            this.imgImages.Images.SetKeyName(518, "layout_content.png");
            this.imgImages.Images.SetKeyName(519, "layout_delete.png");
            this.imgImages.Images.SetKeyName(520, "layout_edit.png");
            this.imgImages.Images.SetKeyName(521, "layout_error.png");
            this.imgImages.Images.SetKeyName(522, "layout_header.png");
            this.imgImages.Images.SetKeyName(523, "layout_link.png");
            this.imgImages.Images.SetKeyName(524, "layout_sidebar.png");
            this.imgImages.Images.SetKeyName(525, "lightbulb.png");
            this.imgImages.Images.SetKeyName(526, "lightbulb_add.png");
            this.imgImages.Images.SetKeyName(527, "lightbulb_delete.png");
            this.imgImages.Images.SetKeyName(528, "lightbulb_off.png");
            this.imgImages.Images.SetKeyName(529, "lightning.png");
            this.imgImages.Images.SetKeyName(530, "lightning_add.png");
            this.imgImages.Images.SetKeyName(531, "lightning_delete.png");
            this.imgImages.Images.SetKeyName(532, "lightning_go.png");
            this.imgImages.Images.SetKeyName(533, "link.png");
            this.imgImages.Images.SetKeyName(534, "link_add.png");
            this.imgImages.Images.SetKeyName(535, "link_break.png");
            this.imgImages.Images.SetKeyName(536, "link_delete.png");
            this.imgImages.Images.SetKeyName(537, "link_edit.png");
            this.imgImages.Images.SetKeyName(538, "link_error.png");
            this.imgImages.Images.SetKeyName(539, "link_go.png");
            this.imgImages.Images.SetKeyName(540, "lock.png");
            this.imgImages.Images.SetKeyName(541, "lock_add.png");
            this.imgImages.Images.SetKeyName(542, "lock_break.png");
            this.imgImages.Images.SetKeyName(543, "lock_delete.png");
            this.imgImages.Images.SetKeyName(544, "lock_edit.png");
            this.imgImages.Images.SetKeyName(545, "lock_go.png");
            this.imgImages.Images.SetKeyName(546, "lock_open.png");
            this.imgImages.Images.SetKeyName(547, "lorry.png");
            this.imgImages.Images.SetKeyName(548, "lorry_add.png");
            this.imgImages.Images.SetKeyName(549, "lorry_delete.png");
            this.imgImages.Images.SetKeyName(550, "lorry_error.png");
            this.imgImages.Images.SetKeyName(551, "lorry_flatbed.png");
            this.imgImages.Images.SetKeyName(552, "lorry_go.png");
            this.imgImages.Images.SetKeyName(553, "lorry_link.png");
            this.imgImages.Images.SetKeyName(554, "magifier_zoom_out.png");
            this.imgImages.Images.SetKeyName(555, "magnifier.png");
            this.imgImages.Images.SetKeyName(556, "magnifier_zoom_in.png");
            this.imgImages.Images.SetKeyName(557, "male.png");
            this.imgImages.Images.SetKeyName(558, "map.png");
            this.imgImages.Images.SetKeyName(559, "map_add.png");
            this.imgImages.Images.SetKeyName(560, "map_delete.png");
            this.imgImages.Images.SetKeyName(561, "map_edit.png");
            this.imgImages.Images.SetKeyName(562, "map_go.png");
            this.imgImages.Images.SetKeyName(563, "map_magnify.png");
            this.imgImages.Images.SetKeyName(564, "medal_bronze_1.png");
            this.imgImages.Images.SetKeyName(565, "medal_bronze_2.png");
            this.imgImages.Images.SetKeyName(566, "medal_bronze_3.png");
            this.imgImages.Images.SetKeyName(567, "medal_bronze_add.png");
            this.imgImages.Images.SetKeyName(568, "medal_bronze_delete.png");
            this.imgImages.Images.SetKeyName(569, "medal_gold_1.png");
            this.imgImages.Images.SetKeyName(570, "medal_gold_2.png");
            this.imgImages.Images.SetKeyName(571, "medal_gold_3.png");
            this.imgImages.Images.SetKeyName(572, "medal_gold_add.png");
            this.imgImages.Images.SetKeyName(573, "medal_gold_delete.png");
            this.imgImages.Images.SetKeyName(574, "medal_silver_1.png");
            this.imgImages.Images.SetKeyName(575, "medal_silver_2.png");
            this.imgImages.Images.SetKeyName(576, "medal_silver_3.png");
            this.imgImages.Images.SetKeyName(577, "medal_silver_add.png");
            this.imgImages.Images.SetKeyName(578, "medal_silver_delete.png");
            this.imgImages.Images.SetKeyName(579, "money.png");
            this.imgImages.Images.SetKeyName(580, "money_add.png");
            this.imgImages.Images.SetKeyName(581, "money_delete.png");
            this.imgImages.Images.SetKeyName(582, "money_dollar.png");
            this.imgImages.Images.SetKeyName(583, "money_euro.png");
            this.imgImages.Images.SetKeyName(584, "money_pound.png");
            this.imgImages.Images.SetKeyName(585, "money_yen.png");
            this.imgImages.Images.SetKeyName(586, "monitor.png");
            this.imgImages.Images.SetKeyName(587, "monitor_add.png");
            this.imgImages.Images.SetKeyName(588, "monitor_delete.png");
            this.imgImages.Images.SetKeyName(589, "monitor_edit.png");
            this.imgImages.Images.SetKeyName(590, "monitor_error.png");
            this.imgImages.Images.SetKeyName(591, "monitor_go.png");
            this.imgImages.Images.SetKeyName(592, "monitor_lightning.png");
            this.imgImages.Images.SetKeyName(593, "monitor_link.png");
            this.imgImages.Images.SetKeyName(594, "mouse.png");
            this.imgImages.Images.SetKeyName(595, "mouse_add.png");
            this.imgImages.Images.SetKeyName(596, "mouse_delete.png");
            this.imgImages.Images.SetKeyName(597, "mouse_error.png");
            this.imgImages.Images.SetKeyName(598, "music.png");
            this.imgImages.Images.SetKeyName(599, "new.png");
            this.imgImages.Images.SetKeyName(600, "newspaper.png");
            this.imgImages.Images.SetKeyName(601, "newspaper_add.png");
            this.imgImages.Images.SetKeyName(602, "newspaper_delete.png");
            this.imgImages.Images.SetKeyName(603, "newspaper_go.png");
            this.imgImages.Images.SetKeyName(604, "newspaper_link.png");
            this.imgImages.Images.SetKeyName(605, "note.png");
            this.imgImages.Images.SetKeyName(606, "note_add.png");
            this.imgImages.Images.SetKeyName(607, "note_delete.png");
            this.imgImages.Images.SetKeyName(608, "note_edit.png");
            this.imgImages.Images.SetKeyName(609, "note_error.png");
            this.imgImages.Images.SetKeyName(610, "note_go.png");
            this.imgImages.Images.SetKeyName(611, "overlays.png");
            this.imgImages.Images.SetKeyName(612, "package.png");
            this.imgImages.Images.SetKeyName(613, "package_add.png");
            this.imgImages.Images.SetKeyName(614, "package_delete.png");
            this.imgImages.Images.SetKeyName(615, "package_go.png");
            this.imgImages.Images.SetKeyName(616, "package_green.png");
            this.imgImages.Images.SetKeyName(617, "package_link.png");
            this.imgImages.Images.SetKeyName(618, "page.png");
            this.imgImages.Images.SetKeyName(619, "page_add.png");
            this.imgImages.Images.SetKeyName(620, "page_attach.png");
            this.imgImages.Images.SetKeyName(621, "page_code.png");
            this.imgImages.Images.SetKeyName(622, "page_copy.png");
            this.imgImages.Images.SetKeyName(623, "page_delete.png");
            this.imgImages.Images.SetKeyName(624, "page_edit.png");
            this.imgImages.Images.SetKeyName(625, "page_error.png");
            this.imgImages.Images.SetKeyName(626, "page_excel.png");
            this.imgImages.Images.SetKeyName(627, "page_find.png");
            this.imgImages.Images.SetKeyName(628, "page_gear.png");
            this.imgImages.Images.SetKeyName(629, "page_go.png");
            this.imgImages.Images.SetKeyName(630, "page_green.png");
            this.imgImages.Images.SetKeyName(631, "page_key.png");
            this.imgImages.Images.SetKeyName(632, "page_lightning.png");
            this.imgImages.Images.SetKeyName(633, "page_link.png");
            this.imgImages.Images.SetKeyName(634, "page_paintbrush.png");
            this.imgImages.Images.SetKeyName(635, "page_paste.png");
            this.imgImages.Images.SetKeyName(636, "page_red.png");
            this.imgImages.Images.SetKeyName(637, "page_refresh.png");
            this.imgImages.Images.SetKeyName(638, "page_save.png");
            this.imgImages.Images.SetKeyName(639, "page_white.png");
            this.imgImages.Images.SetKeyName(640, "page_white_acrobat.png");
            this.imgImages.Images.SetKeyName(641, "page_white_actionscript.png");
            this.imgImages.Images.SetKeyName(642, "page_white_add.png");
            this.imgImages.Images.SetKeyName(643, "page_white_c.png");
            this.imgImages.Images.SetKeyName(644, "page_white_camera.png");
            this.imgImages.Images.SetKeyName(645, "page_white_cd.png");
            this.imgImages.Images.SetKeyName(646, "page_white_code.png");
            this.imgImages.Images.SetKeyName(647, "page_white_code_red.png");
            this.imgImages.Images.SetKeyName(648, "page_white_coldfusion.png");
            this.imgImages.Images.SetKeyName(649, "page_white_compressed.png");
            this.imgImages.Images.SetKeyName(650, "page_white_copy.png");
            this.imgImages.Images.SetKeyName(651, "page_white_cplusplus.png");
            this.imgImages.Images.SetKeyName(652, "page_white_csharp.png");
            this.imgImages.Images.SetKeyName(653, "page_white_cup.png");
            this.imgImages.Images.SetKeyName(654, "page_white_database.png");
            this.imgImages.Images.SetKeyName(655, "page_white_delete.png");
            this.imgImages.Images.SetKeyName(656, "page_white_dvd.png");
            this.imgImages.Images.SetKeyName(657, "page_white_edit.png");
            this.imgImages.Images.SetKeyName(658, "page_white_error.png");
            this.imgImages.Images.SetKeyName(659, "page_white_excel.png");
            this.imgImages.Images.SetKeyName(660, "page_white_find.png");
            this.imgImages.Images.SetKeyName(661, "page_white_flash.png");
            this.imgImages.Images.SetKeyName(662, "page_white_freehand.png");
            this.imgImages.Images.SetKeyName(663, "page_white_gear.png");
            this.imgImages.Images.SetKeyName(664, "page_white_get.png");
            this.imgImages.Images.SetKeyName(665, "page_white_go.png");
            this.imgImages.Images.SetKeyName(666, "page_white_h.png");
            this.imgImages.Images.SetKeyName(667, "page_white_horizontal.png");
            this.imgImages.Images.SetKeyName(668, "page_white_key.png");
            this.imgImages.Images.SetKeyName(669, "page_white_lightning.png");
            this.imgImages.Images.SetKeyName(670, "page_white_link.png");
            this.imgImages.Images.SetKeyName(671, "page_white_magnify.png");
            this.imgImages.Images.SetKeyName(672, "page_white_medal.png");
            this.imgImages.Images.SetKeyName(673, "page_white_office.png");
            this.imgImages.Images.SetKeyName(674, "page_white_paint.png");
            this.imgImages.Images.SetKeyName(675, "page_white_paintbrush.png");
            this.imgImages.Images.SetKeyName(676, "page_white_paste.png");
            this.imgImages.Images.SetKeyName(677, "page_white_php.png");
            this.imgImages.Images.SetKeyName(678, "page_white_picture.png");
            this.imgImages.Images.SetKeyName(679, "page_white_powerpoint.png");
            this.imgImages.Images.SetKeyName(680, "page_white_put.png");
            this.imgImages.Images.SetKeyName(681, "page_white_ruby.png");
            this.imgImages.Images.SetKeyName(682, "page_white_stack.png");
            this.imgImages.Images.SetKeyName(683, "page_white_star.png");
            this.imgImages.Images.SetKeyName(684, "page_white_swoosh.png");
            this.imgImages.Images.SetKeyName(685, "page_white_text.png");
            this.imgImages.Images.SetKeyName(686, "page_white_text_width.png");
            this.imgImages.Images.SetKeyName(687, "page_white_tux.png");
            this.imgImages.Images.SetKeyName(688, "page_white_vector.png");
            this.imgImages.Images.SetKeyName(689, "page_white_visualstudio.png");
            this.imgImages.Images.SetKeyName(690, "page_white_width.png");
            this.imgImages.Images.SetKeyName(691, "page_white_word.png");
            this.imgImages.Images.SetKeyName(692, "page_white_world.png");
            this.imgImages.Images.SetKeyName(693, "page_white_wrench.png");
            this.imgImages.Images.SetKeyName(694, "page_white_zip.png");
            this.imgImages.Images.SetKeyName(695, "page_word.png");
            this.imgImages.Images.SetKeyName(696, "page_world.png");
            this.imgImages.Images.SetKeyName(697, "paintbrush.png");
            this.imgImages.Images.SetKeyName(698, "paintcan.png");
            this.imgImages.Images.SetKeyName(699, "palette.png");
            this.imgImages.Images.SetKeyName(700, "paste_plain.png");
            this.imgImages.Images.SetKeyName(701, "paste_word.png");
            this.imgImages.Images.SetKeyName(702, "pencil.png");
            this.imgImages.Images.SetKeyName(703, "pencil_add.png");
            this.imgImages.Images.SetKeyName(704, "pencil_delete.png");
            this.imgImages.Images.SetKeyName(705, "pencil_go.png");
            this.imgImages.Images.SetKeyName(706, "phone.png");
            this.imgImages.Images.SetKeyName(707, "phone_add.png");
            this.imgImages.Images.SetKeyName(708, "phone_delete.png");
            this.imgImages.Images.SetKeyName(709, "phone_sound.png");
            this.imgImages.Images.SetKeyName(710, "photo.png");
            this.imgImages.Images.SetKeyName(711, "photo_add.png");
            this.imgImages.Images.SetKeyName(712, "photo_delete.png");
            this.imgImages.Images.SetKeyName(713, "photo_link.png");
            this.imgImages.Images.SetKeyName(714, "photos.png");
            this.imgImages.Images.SetKeyName(715, "picture.png");
            this.imgImages.Images.SetKeyName(716, "picture_add.png");
            this.imgImages.Images.SetKeyName(717, "picture_delete.png");
            this.imgImages.Images.SetKeyName(718, "picture_edit.png");
            this.imgImages.Images.SetKeyName(719, "picture_empty.png");
            this.imgImages.Images.SetKeyName(720, "picture_error.png");
            this.imgImages.Images.SetKeyName(721, "picture_go.png");
            this.imgImages.Images.SetKeyName(722, "picture_key.png");
            this.imgImages.Images.SetKeyName(723, "picture_link.png");
            this.imgImages.Images.SetKeyName(724, "picture_save.png");
            this.imgImages.Images.SetKeyName(725, "pictures.png");
            this.imgImages.Images.SetKeyName(726, "pilcrow.png");
            this.imgImages.Images.SetKeyName(727, "pill.png");
            this.imgImages.Images.SetKeyName(728, "pill_add.png");
            this.imgImages.Images.SetKeyName(729, "pill_delete.png");
            this.imgImages.Images.SetKeyName(730, "pill_go.png");
            this.imgImages.Images.SetKeyName(731, "plugin.png");
            this.imgImages.Images.SetKeyName(732, "plugin_add.png");
            this.imgImages.Images.SetKeyName(733, "plugin_delete.png");
            this.imgImages.Images.SetKeyName(734, "plugin_disabled.png");
            this.imgImages.Images.SetKeyName(735, "plugin_edit.png");
            this.imgImages.Images.SetKeyName(736, "plugin_error.png");
            this.imgImages.Images.SetKeyName(737, "plugin_go.png");
            this.imgImages.Images.SetKeyName(738, "plugin_link.png");
            this.imgImages.Images.SetKeyName(739, "printer.png");
            this.imgImages.Images.SetKeyName(740, "printer_add.png");
            this.imgImages.Images.SetKeyName(741, "printer_delete.png");
            this.imgImages.Images.SetKeyName(742, "printer_empty.png");
            this.imgImages.Images.SetKeyName(743, "printer_error.png");
            this.imgImages.Images.SetKeyName(744, "rainbow.png");
            this.imgImages.Images.SetKeyName(745, "report.png");
            this.imgImages.Images.SetKeyName(746, "report_add.png");
            this.imgImages.Images.SetKeyName(747, "report_delete.png");
            this.imgImages.Images.SetKeyName(748, "report_disk.png");
            this.imgImages.Images.SetKeyName(749, "report_edit.png");
            this.imgImages.Images.SetKeyName(750, "report_go.png");
            this.imgImages.Images.SetKeyName(751, "report_key.png");
            this.imgImages.Images.SetKeyName(752, "report_link.png");
            this.imgImages.Images.SetKeyName(753, "report_magnify.png");
            this.imgImages.Images.SetKeyName(754, "report_picture.png");
            this.imgImages.Images.SetKeyName(755, "report_user.png");
            this.imgImages.Images.SetKeyName(756, "report_word.png");
            this.imgImages.Images.SetKeyName(757, "resultset_first.png");
            this.imgImages.Images.SetKeyName(758, "resultset_last.png");
            this.imgImages.Images.SetKeyName(759, "resultset_next.png");
            this.imgImages.Images.SetKeyName(760, "resultset_previous.png");
            this.imgImages.Images.SetKeyName(761, "rosette.png");
            this.imgImages.Images.SetKeyName(762, "rss.png");
            this.imgImages.Images.SetKeyName(763, "rss_add.png");
            this.imgImages.Images.SetKeyName(764, "rss_delete.png");
            this.imgImages.Images.SetKeyName(765, "rss_go.png");
            this.imgImages.Images.SetKeyName(766, "rss_valid.png");
            this.imgImages.Images.SetKeyName(767, "ruby.png");
            this.imgImages.Images.SetKeyName(768, "ruby_add.png");
            this.imgImages.Images.SetKeyName(769, "ruby_delete.png");
            this.imgImages.Images.SetKeyName(770, "ruby_gear.png");
            this.imgImages.Images.SetKeyName(771, "ruby_get.png");
            this.imgImages.Images.SetKeyName(772, "ruby_go.png");
            this.imgImages.Images.SetKeyName(773, "ruby_key.png");
            this.imgImages.Images.SetKeyName(774, "ruby_link.png");
            this.imgImages.Images.SetKeyName(775, "ruby_put.png");
            this.imgImages.Images.SetKeyName(776, "script.png");
            this.imgImages.Images.SetKeyName(777, "script_add.png");
            this.imgImages.Images.SetKeyName(778, "script_code.png");
            this.imgImages.Images.SetKeyName(779, "script_code_red.png");
            this.imgImages.Images.SetKeyName(780, "script_delete.png");
            this.imgImages.Images.SetKeyName(781, "script_edit.png");
            this.imgImages.Images.SetKeyName(782, "script_error.png");
            this.imgImages.Images.SetKeyName(783, "script_gear.png");
            this.imgImages.Images.SetKeyName(784, "script_go.png");
            this.imgImages.Images.SetKeyName(785, "script_key.png");
            this.imgImages.Images.SetKeyName(786, "script_lightning.png");
            this.imgImages.Images.SetKeyName(787, "script_link.png");
            this.imgImages.Images.SetKeyName(788, "script_palette.png");
            this.imgImages.Images.SetKeyName(789, "script_save.png");
            this.imgImages.Images.SetKeyName(790, "server.png");
            this.imgImages.Images.SetKeyName(791, "server_add.png");
            this.imgImages.Images.SetKeyName(792, "server_chart.png");
            this.imgImages.Images.SetKeyName(793, "server_compressed.png");
            this.imgImages.Images.SetKeyName(794, "server_connect.png");
            this.imgImages.Images.SetKeyName(795, "server_database.png");
            this.imgImages.Images.SetKeyName(796, "server_delete.png");
            this.imgImages.Images.SetKeyName(797, "server_edit.png");
            this.imgImages.Images.SetKeyName(798, "server_error.png");
            this.imgImages.Images.SetKeyName(799, "server_go.png");
            this.imgImages.Images.SetKeyName(800, "server_key.png");
            this.imgImages.Images.SetKeyName(801, "server_lightning.png");
            this.imgImages.Images.SetKeyName(802, "server_link.png");
            this.imgImages.Images.SetKeyName(803, "server_uncompressed.png");
            this.imgImages.Images.SetKeyName(804, "shading.png");
            this.imgImages.Images.SetKeyName(805, "shape_align_bottom.png");
            this.imgImages.Images.SetKeyName(806, "shape_align_center.png");
            this.imgImages.Images.SetKeyName(807, "shape_align_left.png");
            this.imgImages.Images.SetKeyName(808, "shape_align_middle.png");
            this.imgImages.Images.SetKeyName(809, "shape_align_right.png");
            this.imgImages.Images.SetKeyName(810, "shape_align_top.png");
            this.imgImages.Images.SetKeyName(811, "shape_flip_horizontal.png");
            this.imgImages.Images.SetKeyName(812, "shape_flip_vertical.png");
            this.imgImages.Images.SetKeyName(813, "shape_group.png");
            this.imgImages.Images.SetKeyName(814, "shape_handles.png");
            this.imgImages.Images.SetKeyName(815, "shape_move_back.png");
            this.imgImages.Images.SetKeyName(816, "shape_move_backwards.png");
            this.imgImages.Images.SetKeyName(817, "shape_move_forwards.png");
            this.imgImages.Images.SetKeyName(818, "shape_move_front.png");
            this.imgImages.Images.SetKeyName(819, "shape_rotate_anticlockwise.png");
            this.imgImages.Images.SetKeyName(820, "shape_rotate_clockwise.png");
            this.imgImages.Images.SetKeyName(821, "shape_square.png");
            this.imgImages.Images.SetKeyName(822, "shape_square_add.png");
            this.imgImages.Images.SetKeyName(823, "shape_square_delete.png");
            this.imgImages.Images.SetKeyName(824, "shape_square_edit.png");
            this.imgImages.Images.SetKeyName(825, "shape_square_error.png");
            this.imgImages.Images.SetKeyName(826, "shape_square_go.png");
            this.imgImages.Images.SetKeyName(827, "shape_square_key.png");
            this.imgImages.Images.SetKeyName(828, "shape_square_link.png");
            this.imgImages.Images.SetKeyName(829, "shape_ungroup.png");
            this.imgImages.Images.SetKeyName(830, "shield.png");
            this.imgImages.Images.SetKeyName(831, "shield_add.png");
            this.imgImages.Images.SetKeyName(832, "shield_delete.png");
            this.imgImages.Images.SetKeyName(833, "shield_go.png");
            this.imgImages.Images.SetKeyName(834, "sitemap.png");
            this.imgImages.Images.SetKeyName(835, "sitemap_color.png");
            this.imgImages.Images.SetKeyName(836, "sound.png");
            this.imgImages.Images.SetKeyName(837, "sound_add.png");
            this.imgImages.Images.SetKeyName(838, "sound_delete.png");
            this.imgImages.Images.SetKeyName(839, "sound_low.png");
            this.imgImages.Images.SetKeyName(840, "sound_mute.png");
            this.imgImages.Images.SetKeyName(841, "sound_none.png");
            this.imgImages.Images.SetKeyName(842, "spellcheck.png");
            this.imgImages.Images.SetKeyName(843, "sport_8ball.png");
            this.imgImages.Images.SetKeyName(844, "sport_basketball.png");
            this.imgImages.Images.SetKeyName(845, "sport_football.png");
            this.imgImages.Images.SetKeyName(846, "sport_golf.png");
            this.imgImages.Images.SetKeyName(847, "sport_raquet.png");
            this.imgImages.Images.SetKeyName(848, "sport_shuttlecock.png");
            this.imgImages.Images.SetKeyName(849, "sport_soccer.png");
            this.imgImages.Images.SetKeyName(850, "sport_tennis.png");
            this.imgImages.Images.SetKeyName(851, "star.png");
            this.imgImages.Images.SetKeyName(852, "status_away.png");
            this.imgImages.Images.SetKeyName(853, "status_busy.png");
            this.imgImages.Images.SetKeyName(854, "status_offline.png");
            this.imgImages.Images.SetKeyName(855, "status_online.png");
            this.imgImages.Images.SetKeyName(856, "stop.png");
            this.imgImages.Images.SetKeyName(857, "style.png");
            this.imgImages.Images.SetKeyName(858, "style_add.png");
            this.imgImages.Images.SetKeyName(859, "style_delete.png");
            this.imgImages.Images.SetKeyName(860, "style_edit.png");
            this.imgImages.Images.SetKeyName(861, "style_go.png");
            this.imgImages.Images.SetKeyName(862, "sum.png");
            this.imgImages.Images.SetKeyName(863, "tab.png");
            this.imgImages.Images.SetKeyName(864, "tab_add.png");
            this.imgImages.Images.SetKeyName(865, "tab_delete.png");
            this.imgImages.Images.SetKeyName(866, "tab_edit.png");
            this.imgImages.Images.SetKeyName(867, "tab_go.png");
            this.imgImages.Images.SetKeyName(868, "table.png");
            this.imgImages.Images.SetKeyName(869, "table_add.png");
            this.imgImages.Images.SetKeyName(870, "table_delete.png");
            this.imgImages.Images.SetKeyName(871, "table_edit.png");
            this.imgImages.Images.SetKeyName(872, "table_error.png");
            this.imgImages.Images.SetKeyName(873, "table_gear.png");
            this.imgImages.Images.SetKeyName(874, "table_go.png");
            this.imgImages.Images.SetKeyName(875, "table_key.png");
            this.imgImages.Images.SetKeyName(876, "table_lightning.png");
            this.imgImages.Images.SetKeyName(877, "table_link.png");
            this.imgImages.Images.SetKeyName(878, "table_multiple.png");
            this.imgImages.Images.SetKeyName(879, "table_refresh.png");
            this.imgImages.Images.SetKeyName(880, "table_relationship.png");
            this.imgImages.Images.SetKeyName(881, "table_row_delete.png");
            this.imgImages.Images.SetKeyName(882, "table_row_insert.png");
            this.imgImages.Images.SetKeyName(883, "table_save.png");
            this.imgImages.Images.SetKeyName(884, "table_sort.png");
            this.imgImages.Images.SetKeyName(885, "tag.png");
            this.imgImages.Images.SetKeyName(886, "tag_blue.png");
            this.imgImages.Images.SetKeyName(887, "tag_blue_add.png");
            this.imgImages.Images.SetKeyName(888, "tag_blue_delete.png");
            this.imgImages.Images.SetKeyName(889, "tag_blue_edit.png");
            this.imgImages.Images.SetKeyName(890, "tag_green.png");
            this.imgImages.Images.SetKeyName(891, "tag_orange.png");
            this.imgImages.Images.SetKeyName(892, "tag_pink.png");
            this.imgImages.Images.SetKeyName(893, "tag_purple.png");
            this.imgImages.Images.SetKeyName(894, "tag_red.png");
            this.imgImages.Images.SetKeyName(895, "tag_yellow.png");
            this.imgImages.Images.SetKeyName(896, "telephone.png");
            this.imgImages.Images.SetKeyName(897, "telephone_add.png");
            this.imgImages.Images.SetKeyName(898, "telephone_delete.png");
            this.imgImages.Images.SetKeyName(899, "telephone_edit.png");
            this.imgImages.Images.SetKeyName(900, "telephone_error.png");
            this.imgImages.Images.SetKeyName(901, "telephone_go.png");
            this.imgImages.Images.SetKeyName(902, "telephone_key.png");
            this.imgImages.Images.SetKeyName(903, "telephone_link.png");
            this.imgImages.Images.SetKeyName(904, "television.png");
            this.imgImages.Images.SetKeyName(905, "television_add.png");
            this.imgImages.Images.SetKeyName(906, "television_delete.png");
            this.imgImages.Images.SetKeyName(907, "text_align_center.png");
            this.imgImages.Images.SetKeyName(908, "text_align_justify.png");
            this.imgImages.Images.SetKeyName(909, "text_align_left.png");
            this.imgImages.Images.SetKeyName(910, "text_align_right.png");
            this.imgImages.Images.SetKeyName(911, "text_allcaps.png");
            this.imgImages.Images.SetKeyName(912, "text_bold.png");
            this.imgImages.Images.SetKeyName(913, "text_columns.png");
            this.imgImages.Images.SetKeyName(914, "text_dropcaps.png");
            this.imgImages.Images.SetKeyName(915, "text_heading_1.png");
            this.imgImages.Images.SetKeyName(916, "text_heading_2.png");
            this.imgImages.Images.SetKeyName(917, "text_heading_3.png");
            this.imgImages.Images.SetKeyName(918, "text_heading_4.png");
            this.imgImages.Images.SetKeyName(919, "text_heading_5.png");
            this.imgImages.Images.SetKeyName(920, "text_heading_6.png");
            this.imgImages.Images.SetKeyName(921, "text_horizontalrule.png");
            this.imgImages.Images.SetKeyName(922, "text_indent.png");
            this.imgImages.Images.SetKeyName(923, "text_indent_remove.png");
            this.imgImages.Images.SetKeyName(924, "text_italic.png");
            this.imgImages.Images.SetKeyName(925, "text_kerning.png");
            this.imgImages.Images.SetKeyName(926, "text_letter_omega.png");
            this.imgImages.Images.SetKeyName(927, "text_letterspacing.png");
            this.imgImages.Images.SetKeyName(928, "text_linespacing.png");
            this.imgImages.Images.SetKeyName(929, "text_list_bullets.png");
            this.imgImages.Images.SetKeyName(930, "text_list_numbers.png");
            this.imgImages.Images.SetKeyName(931, "text_lowercase.png");
            this.imgImages.Images.SetKeyName(932, "text_padding_bottom.png");
            this.imgImages.Images.SetKeyName(933, "text_padding_left.png");
            this.imgImages.Images.SetKeyName(934, "text_padding_right.png");
            this.imgImages.Images.SetKeyName(935, "text_padding_top.png");
            this.imgImages.Images.SetKeyName(936, "text_replace.png");
            this.imgImages.Images.SetKeyName(937, "text_signature.png");
            this.imgImages.Images.SetKeyName(938, "text_smallcaps.png");
            this.imgImages.Images.SetKeyName(939, "text_strikethrough.png");
            this.imgImages.Images.SetKeyName(940, "text_subscript.png");
            this.imgImages.Images.SetKeyName(941, "text_superscript.png");
            this.imgImages.Images.SetKeyName(942, "text_underline.png");
            this.imgImages.Images.SetKeyName(943, "text_uppercase.png");
            this.imgImages.Images.SetKeyName(944, "textfield.png");
            this.imgImages.Images.SetKeyName(945, "textfield_add.png");
            this.imgImages.Images.SetKeyName(946, "textfield_delete.png");
            this.imgImages.Images.SetKeyName(947, "textfield_key.png");
            this.imgImages.Images.SetKeyName(948, "textfield_rename.png");
            this.imgImages.Images.SetKeyName(949, "thumb_down.png");
            this.imgImages.Images.SetKeyName(950, "thumb_up.png");
            this.imgImages.Images.SetKeyName(951, "tick.png");
            this.imgImages.Images.SetKeyName(952, "time.png");
            this.imgImages.Images.SetKeyName(953, "time_add.png");
            this.imgImages.Images.SetKeyName(954, "time_delete.png");
            this.imgImages.Images.SetKeyName(955, "time_go.png");
            this.imgImages.Images.SetKeyName(956, "timeline_marker.png");
            this.imgImages.Images.SetKeyName(957, "transmit.png");
            this.imgImages.Images.SetKeyName(958, "transmit_add.png");
            this.imgImages.Images.SetKeyName(959, "transmit_blue.png");
            this.imgImages.Images.SetKeyName(960, "transmit_delete.png");
            this.imgImages.Images.SetKeyName(961, "transmit_edit.png");
            this.imgImages.Images.SetKeyName(962, "transmit_error.png");
            this.imgImages.Images.SetKeyName(963, "transmit_go.png");
            this.imgImages.Images.SetKeyName(964, "tux.png");
            this.imgImages.Images.SetKeyName(965, "user.png");
            this.imgImages.Images.SetKeyName(966, "user_add.png");
            this.imgImages.Images.SetKeyName(967, "user_comment.png");
            this.imgImages.Images.SetKeyName(968, "user_delete.png");
            this.imgImages.Images.SetKeyName(969, "user_edit.png");
            this.imgImages.Images.SetKeyName(970, "user_female.png");
            this.imgImages.Images.SetKeyName(971, "user_go.png");
            this.imgImages.Images.SetKeyName(972, "user_gray.png");
            this.imgImages.Images.SetKeyName(973, "user_green.png");
            this.imgImages.Images.SetKeyName(974, "user_orange.png");
            this.imgImages.Images.SetKeyName(975, "user_red.png");
            this.imgImages.Images.SetKeyName(976, "user_suit.png");
            this.imgImages.Images.SetKeyName(977, "vcard.png");
            this.imgImages.Images.SetKeyName(978, "vcard_add.png");
            this.imgImages.Images.SetKeyName(979, "vcard_delete.png");
            this.imgImages.Images.SetKeyName(980, "vcard_edit.png");
            this.imgImages.Images.SetKeyName(981, "vector.png");
            this.imgImages.Images.SetKeyName(982, "vector_add.png");
            this.imgImages.Images.SetKeyName(983, "vector_delete.png");
            this.imgImages.Images.SetKeyName(984, "wand.png");
            this.imgImages.Images.SetKeyName(985, "weather_clouds.png");
            this.imgImages.Images.SetKeyName(986, "weather_cloudy.png");
            this.imgImages.Images.SetKeyName(987, "weather_lightning.png");
            this.imgImages.Images.SetKeyName(988, "weather_rain.png");
            this.imgImages.Images.SetKeyName(989, "weather_snow.png");
            this.imgImages.Images.SetKeyName(990, "weather_sun.png");
            this.imgImages.Images.SetKeyName(991, "webcam.png");
            this.imgImages.Images.SetKeyName(992, "webcam_add.png");
            this.imgImages.Images.SetKeyName(993, "webcam_delete.png");
            this.imgImages.Images.SetKeyName(994, "webcam_error.png");
            this.imgImages.Images.SetKeyName(995, "world.png");
            this.imgImages.Images.SetKeyName(996, "world_add.png");
            this.imgImages.Images.SetKeyName(997, "world_delete.png");
            this.imgImages.Images.SetKeyName(998, "world_edit.png");
            this.imgImages.Images.SetKeyName(999, "world_go.png");
            this.imgImages.Images.SetKeyName(1000, "world_link.png");
            this.imgImages.Images.SetKeyName(1001, "wrench.png");
            this.imgImages.Images.SetKeyName(1002, "wrench_orange.png");
            this.imgImages.Images.SetKeyName(1003, "xhtml.png");
            this.imgImages.Images.SetKeyName(1004, "xhtml_add.png");
            this.imgImages.Images.SetKeyName(1005, "xhtml_delete.png");
            this.imgImages.Images.SetKeyName(1006, "xhtml_go.png");
            this.imgImages.Images.SetKeyName(1007, "xhtml_valid.png");
            this.imgImages.Images.SetKeyName(1008, "zoom.png");
            this.imgImages.Images.SetKeyName(1009, "zoom_in.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.propertyGrid1);
            this.groupBox1.Location = new System.Drawing.Point(589, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 377);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Properties";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(142, 352);
            this.propertyGrid1.TabIndex = 4;
            // 
            // lvwProcesses
            // 
            this.lvwProcesses.AllowDrop = true;
            this.lvwProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwProcesses.CheckBoxes = true;
            this.lvwProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6});
            this.lvwProcesses.FullRowSelect = true;
            this.lvwProcesses.GridLines = true;
            listViewGroup1.Header = "Data Import";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "Data Cleansing";
            listViewGroup2.Name = "listViewGroup2";
            this.lvwProcesses.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            this.lvwProcesses.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lvwProcesses.Location = new System.Drawing.Point(116, 49);
            this.lvwProcesses.Name = "lvwProcesses";
            this.lvwProcesses.ShowGroups = false;
            this.lvwProcesses.Size = new System.Drawing.Size(467, 380);
            this.lvwProcesses.SmallImageList = this.imgImages;
            this.lvwProcesses.TabIndex = 4;
            this.lvwProcesses.UseCompatibleStateImageBehavior = false;
            this.lvwProcesses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description";
            this.columnHeader1.Width = 185;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Run";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Duration";
            this.columnHeader6.Width = 105;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripButton11,
            this.toolStripButton5,
            this.toolStripSeparator5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton10});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(113, 384);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = Stellar.Win.Properties.Resources.application_xp_terminal;
            this.toolStripButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(110, 20);
            this.toolStripButton3.Text = "Run command";
            this.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = Stellar.Win.Properties.Resources.page_copy;
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripButton2.Size = new System.Drawing.Size(110, 20);
            this.toolStripButton2.Text = "Copy file";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = Stellar.Win.Properties.Resources.database;
            this.toolStripButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(110, 20);
            this.toolStripButton4.Text = "DB query";
            this.toolStripButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(110, 20);
            this.toolStripButton11.Text = "CSV to XML";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(110, 20);
            this.toolStripButton5.Text = "XSL transform";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(110, 6);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(110, 20);
            this.toolStripButton6.Text = "Trim spaces";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(110, 20);
            this.toolStripButton7.Text = "Add prefix";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(110, 20);
            this.toolStripButton8.Text = "Add suffix";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(110, 20);
            this.toolStripButton9.Text = "Replace text";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(110, 20);
            this.toolStripButton10.Text = "Value from lookup";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 455);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.lvwProcesses);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnRun;
        private System.Windows.Forms.ToolStripButton btnPause;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuHContents;
        private System.Windows.Forms.ToolStripMenuItem mnuHWeb;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ImageList imgImages;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuVToolBar;
        private System.Windows.Forms.ToolStripMenuItem mnuVStatusBar;
        private System.Windows.Forms.ToolStripMenuItem mnuPBack;
        private System.Windows.Forms.OpenFileDialog dlgOpenProject;
        private System.Windows.Forms.SaveFileDialog dlgSaveProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.OpenFileDialog dlgOpenProcess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwProcesses;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;

    }
}