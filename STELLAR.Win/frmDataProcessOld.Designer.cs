namespace STELLAR.APP
{
    partial class frmDataProcessOld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataProcessOld));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Data Schema Fields", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("User Defined Fields", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Data Template Fields", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "SITE_ID",
            "[site]",
            "lowercase, trim"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "RECORD_ID",
            "[record_id]"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "COL2",
            "[column2]",
            "replace(x,y)"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "COMMENT",
            "[comment]"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "COL5",
            "[col5]"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "BASE_URI",
            "http://tmp#"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "MATERIAL_URI",
            "$BASE_URI$$SITE_ID$.$RECORD_ID$"}, -1, System.Drawing.Color.Green, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "MATERIAL_LABEL",
            "$COL5"}, -1, System.Drawing.Color.Green, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "MATERIAL_NAME",
            "$COL5"}, -1, System.Drawing.Color.Green, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "MATERIAL_NAME_URI",
            "$BASE_URI$$COL5$"}, -1, System.Drawing.Color.Red, System.Drawing.Color.Empty, null);
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetTemplateFile = new System.Windows.Forms.Button();
            this.txtTemplateFileName = new System.Windows.Forms.TextBox();
            this.btnGetSchemaFile = new System.Windows.Forms.Button();
            this.txtSchemaFileName = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(18, 35);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(419, 20);
            this.txtDescription.TabIndex = 33;
            this.txtDescription.Text = " MOLA FND_RF to Finds Materials";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Template";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Schema";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button13);
            this.groupBox5.Controls.Add(this.button15);
            this.groupBox5.Controls.Add(this.button14);
            this.groupBox5.Controls.Add(this.listView4);
            this.groupBox5.Location = new System.Drawing.Point(14, 168);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(449, 348);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Named Fields";
            // 
            // button13
            // 
            this.button13.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button13.Enabled = false;
            this.button13.Image = global::STELLAR.APP.Properties.Resources.pencil;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(271, 313);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(79, 26);
            this.button13.TabIndex = 55;
            this.button13.Text = "Edit...";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button15.Enabled = false;
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.Location = new System.Drawing.Point(186, 313);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(79, 26);
            this.button15.TabIndex = 53;
            this.button15.Text = "Add...";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button14.Enabled = false;
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(356, 313);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(79, 26);
            this.button14.TabIndex = 54;
            this.button14.Text = "Delete";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            this.listView4.BackColor = System.Drawing.SystemColors.Window;
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView4.FullRowSelect = true;
            this.listView4.GridLines = true;
            listViewGroup1.Header = "Data Schema Fields";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "User Defined Fields";
            listViewGroup2.Name = "listViewGroup3";
            listViewGroup3.Header = "Data Template Fields";
            listViewGroup3.Name = "listViewGroup2";
            this.listView4.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            listViewItem4.Group = listViewGroup1;
            listViewItem5.Group = listViewGroup1;
            listViewItem6.Group = listViewGroup2;
            listViewItem7.Group = listViewGroup3;
            listViewItem8.Group = listViewGroup3;
            listViewItem9.Group = listViewGroup3;
            listViewItem10.Group = listViewGroup3;
            this.listView4.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.listView4.Location = new System.Drawing.Point(14, 19);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(421, 288);
            this.listView4.TabIndex = 52;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Name";
            this.columnHeader8.Width = 141;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Value";
            this.columnHeader9.Width = 155;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Modifiers";
            this.columnHeader10.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(469, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 504);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output preview";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 476);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Description";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(722, 522);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(79, 26);
            this.btnOK.TabIndex = 57;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Enabled = false;
            this.btnApply.Image = global::STELLAR.APP.Properties.Resources.disk;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(891, 522);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(79, 26);
            this.btnApply.TabIndex = 59;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(807, 522);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 26);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetTemplateFile);
            this.groupBox1.Controls.Add(this.txtTemplateFileName);
            this.groupBox1.Controls.Add(this.btnGetSchemaFile);
            this.groupBox1.Controls.Add(this.txtSchemaFileName);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 150);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process";
            // 
            // btnGetTemplateFile
            // 
            this.btnGetTemplateFile.Location = new System.Drawing.Point(411, 113);
            this.btnGetTemplateFile.Name = "btnGetTemplateFile";
            this.btnGetTemplateFile.Size = new System.Drawing.Size(26, 20);
            this.btnGetTemplateFile.TabIndex = 66;
            this.btnGetTemplateFile.Text = "...";
            this.btnGetTemplateFile.UseVisualStyleBackColor = true;
            this.btnGetTemplateFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTemplateFileName
            // 
            this.txtTemplateFileName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTemplateFileName.Location = new System.Drawing.Point(18, 113);
            this.txtTemplateFileName.Name = "txtTemplateFileName";
            this.txtTemplateFileName.Size = new System.Drawing.Size(387, 20);
            this.txtTemplateFileName.TabIndex = 65;
            this.txtTemplateFileName.Text = "c:\\tmp\\MOLA_FND_RF_TO_FINDS_MATERIALS.stg";
            // 
            // btnGetSchemaFile
            // 
            this.btnGetSchemaFile.Location = new System.Drawing.Point(411, 74);
            this.btnGetSchemaFile.Name = "btnGetSchemaFile";
            this.btnGetSchemaFile.Size = new System.Drawing.Size(26, 20);
            this.btnGetSchemaFile.TabIndex = 64;
            this.btnGetSchemaFile.Text = "...";
            this.btnGetSchemaFile.UseVisualStyleBackColor = true;
            // 
            // txtSchemaFileName
            // 
            this.txtSchemaFileName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSchemaFileName.Location = new System.Drawing.Point(18, 74);
            this.txtSchemaFileName.Name = "txtSchemaFileName";
            this.txtSchemaFileName.Size = new System.Drawing.Size(387, 20);
            this.txtSchemaFileName.TabIndex = 63;
            this.txtSchemaFileName.Text = "c:\\tmp\\MOLA_FND_RF.xsd";
            // 
            // frmDataProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDataProcess";
            this.Text = "Data Process";
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetTemplateFile;
        private System.Windows.Forms.TextBox txtTemplateFileName;
        private System.Windows.Forms.Button btnGetSchemaFile;
        private System.Windows.Forms.TextBox txtSchemaFileName;
    }
}