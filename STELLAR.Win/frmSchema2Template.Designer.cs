namespace STELLAR.APP
{
    partial class frmSchema2Template
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
            System.Windows.Forms.GroupBox groupBox3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchema2Template));
            this.btnDeleteMapping = new System.Windows.Forms.Button();
            this.btnEditMapping = new System.Windows.Forms.Button();
            this.btnAddMapping = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colTemplateField = new System.Windows.Forms.ColumnHeader();
            this.colSchemaField = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lstSchemaFields = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dlgOpenSchema = new System.Windows.Forms.OpenFileDialog();
            this.btnReadSchema = new System.Windows.Forms.Button();
            this.txtSchemaFileName = new System.Windows.Forms.TextBox();
            this.dlgOpenTemplate = new System.Windows.Forms.OpenFileDialog();
            this.dsMappings = new System.Data.DataSet();
            this.tblSchemaFields = new System.Data.DataTable();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataTable1 = new System.Data.DataTable();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEditTemplate = new System.Windows.Forms.Button();
            this.lstTemplates = new System.Windows.Forms.ListBox();
            this.lstTemplateFields = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTemplateFileName = new System.Windows.Forms.TextBox();
            this.btnReadTemplate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditSchema = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMappings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSchemaFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(this.btnDeleteMapping);
            groupBox3.Controls.Add(this.btnEditMapping);
            groupBox3.Controls.Add(this.btnAddMapping);
            groupBox3.Controls.Add(this.listView1);
            groupBox3.Controls.Add(this.label2);
            groupBox3.Controls.Add(this.txtOutput);
            groupBox3.Location = new System.Drawing.Point(12, 226);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(677, 307);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            groupBox3.Text = "Schema to Template Mappings";
            // 
            // btnDeleteMapping
            // 
            this.btnDeleteMapping.Image = global::STELLAR.APP.Properties.Resources.delete;
            this.btnDeleteMapping.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteMapping.Location = new System.Drawing.Point(589, 188);
            this.btnDeleteMapping.Name = "btnDeleteMapping";
            this.btnDeleteMapping.Size = new System.Drawing.Size(74, 25);
            this.btnDeleteMapping.TabIndex = 31;
            this.btnDeleteMapping.Text = "Delete";
            this.btnDeleteMapping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMapping.UseVisualStyleBackColor = true;
            this.btnDeleteMapping.Click += new System.EventHandler(this.btnDeleteMapping_Click);
            // 
            // btnEditMapping
            // 
            this.btnEditMapping.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnEditMapping.Image = global::STELLAR.APP.Properties.Resources.pencil;
            this.btnEditMapping.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditMapping.Location = new System.Drawing.Point(511, 189);
            this.btnEditMapping.Name = "btnEditMapping";
            this.btnEditMapping.Size = new System.Drawing.Size(72, 24);
            this.btnEditMapping.TabIndex = 30;
            this.btnEditMapping.Text = "Edit";
            this.btnEditMapping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditMapping.UseVisualStyleBackColor = true;
            this.btnEditMapping.Click += new System.EventHandler(this.btnEditMapping_Click);
            // 
            // btnAddMapping
            // 
            this.btnAddMapping.Image = global::STELLAR.APP.Properties.Resources.add;
            this.btnAddMapping.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMapping.Location = new System.Drawing.Point(438, 189);
            this.btnAddMapping.Name = "btnAddMapping";
            this.btnAddMapping.Size = new System.Drawing.Size(67, 24);
            this.btnAddMapping.TabIndex = 29;
            this.btnAddMapping.Text = "Add";
            this.btnAddMapping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMapping.UseVisualStyleBackColor = true;
            this.btnAddMapping.Click += new System.EventHandler(this.btnAddMapping_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTemplateField,
            this.colSchemaField});
            this.listView1.Location = new System.Drawing.Point(10, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(653, 154);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colTemplateField
            // 
            this.colTemplateField.DisplayIndex = 1;
            this.colTemplateField.Text = "Template Field";
            this.colTemplateField.Width = 385;
            // 
            // colSchemaField
            // 
            this.colSchemaField.DisplayIndex = 0;
            this.colSchemaField.Text = "Schema Field";
            this.colSchemaField.Width = 295;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preview";
            // 
            // txtOutput
            // 
            this.txtOutput.AcceptsTab = true;
            this.txtOutput.Location = new System.Drawing.Point(10, 227);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(657, 65);
            this.txtOutput.TabIndex = 3;
            // 
            // lstSchemaFields
            // 
            this.lstSchemaFields.FormattingEnabled = true;
            this.lstSchemaFields.Location = new System.Drawing.Point(6, 63);
            this.lstSchemaFields.Name = "lstSchemaFields";
            this.lstSchemaFields.Size = new System.Drawing.Size(308, 121);
            this.lstSchemaFields.TabIndex = 12;
            this.lstSchemaFields.SelectedIndexChanged += new System.EventHandler(this.lstSchemaFields_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Schema fields";
            // 
            // dlgOpenSchema
            // 
            this.dlgOpenSchema.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpenFile_FileOk);
            // 
            // btnReadSchema
            // 
            this.btnReadSchema.Location = new System.Drawing.Point(252, 19);
            this.btnReadSchema.Name = "btnReadSchema";
            this.btnReadSchema.Size = new System.Drawing.Size(28, 21);
            this.btnReadSchema.TabIndex = 16;
            this.btnReadSchema.Text = "...";
            this.btnReadSchema.UseVisualStyleBackColor = true;
            this.btnReadSchema.Click += new System.EventHandler(this.btnReadSchema_Click);
            // 
            // txtSchemaFileName
            // 
            this.txtSchemaFileName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSchemaFileName.Location = new System.Drawing.Point(6, 21);
            this.txtSchemaFileName.Name = "txtSchemaFileName";
            this.txtSchemaFileName.ReadOnly = true;
            this.txtSchemaFileName.Size = new System.Drawing.Size(240, 20);
            this.txtSchemaFileName.TabIndex = 17;
            // 
            // dlgOpenTemplate
            // 
            this.dlgOpenTemplate.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpenTemplate_FileOk);
            // 
            // dsMappings
            // 
            this.dsMappings.DataSetName = "dsMappings";
            this.dsMappings.Tables.AddRange(new System.Data.DataTable[] {
            this.tblSchemaFields,
            this.dataTable1,
            this.dataTable2});
            // 
            // tblSchemaFields
            // 
            this.tblSchemaFields.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn3});
            this.tblSchemaFields.TableName = "tblSchemaFields";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "fieldName";
            // 
            // dataTable1
            // 
            this.dataTable1.TableName = "tblTemplateFields";
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.dataTable2.TableName = "tblMappings";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "colSchemaField";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "colTemplateField";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEditTemplate);
            this.groupBox1.Controls.Add(this.lstTemplates);
            this.groupBox1.Controls.Add(this.lstTemplateFields);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTemplateFileName);
            this.groupBox1.Controls.Add(this.btnReadTemplate);
            this.groupBox1.Location = new System.Drawing.Point(342, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 199);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Template File";
            // 
            // txtEditTemplate
            // 
            this.txtEditTemplate.Image = global::STELLAR.APP.Properties.Resources.pencil;
            this.txtEditTemplate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEditTemplate.Location = new System.Drawing.Point(307, 21);
            this.txtEditTemplate.Name = "txtEditTemplate";
            this.txtEditTemplate.Size = new System.Drawing.Size(30, 21);
            this.txtEditTemplate.TabIndex = 33;
            this.txtEditTemplate.UseVisualStyleBackColor = true;
            this.txtEditTemplate.Click += new System.EventHandler(this.txtEditTemplate_Click);
            // 
            // lstTemplates
            // 
            this.lstTemplates.FormattingEnabled = true;
            this.lstTemplates.Location = new System.Drawing.Point(6, 47);
            this.lstTemplates.Name = "lstTemplates";
            this.lstTemplates.Size = new System.Drawing.Size(331, 43);
            this.lstTemplates.TabIndex = 32;
            this.lstTemplates.SelectedIndexChanged += new System.EventHandler(this.lstTemplates_SelectedIndexChanged);
            // 
            // lstTemplateFields
            // 
            this.lstTemplateFields.FormattingEnabled = true;
            this.lstTemplateFields.Location = new System.Drawing.Point(6, 109);
            this.lstTemplateFields.Name = "lstTemplateFields";
            this.lstTemplateFields.Size = new System.Drawing.Size(331, 82);
            this.lstTemplateFields.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Template Fields";
            // 
            // txtTemplateFileName
            // 
            this.txtTemplateFileName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTemplateFileName.Location = new System.Drawing.Point(6, 21);
            this.txtTemplateFileName.Name = "txtTemplateFileName";
            this.txtTemplateFileName.ReadOnly = true;
            this.txtTemplateFileName.Size = new System.Drawing.Size(264, 20);
            this.txtTemplateFileName.TabIndex = 29;
            // 
            // btnReadTemplate
            // 
            this.btnReadTemplate.Location = new System.Drawing.Point(273, 20);
            this.btnReadTemplate.Name = "btnReadTemplate";
            this.btnReadTemplate.Size = new System.Drawing.Size(28, 21);
            this.btnReadTemplate.TabIndex = 28;
            this.btnReadTemplate.Text = "...";
            this.btnReadTemplate.UseVisualStyleBackColor = true;
            this.btnReadTemplate.Click += new System.EventHandler(this.btnReadTemplate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditSchema);
            this.groupBox2.Controls.Add(this.txtSchemaFileName);
            this.groupBox2.Controls.Add(this.lstSchemaFields);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnReadSchema);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 199);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schema File";
            // 
            // btnEditSchema
            // 
            this.btnEditSchema.Image = global::STELLAR.APP.Properties.Resources.pencil;
            this.btnEditSchema.Location = new System.Drawing.Point(283, 19);
            this.btnEditSchema.Name = "btnEditSchema";
            this.btnEditSchema.Size = new System.Drawing.Size(31, 21);
            this.btnEditSchema.TabIndex = 37;
            this.btnEditSchema.UseVisualStyleBackColor = true;
            this.btnEditSchema.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = global::STELLAR.APP.Properties.Resources.accept;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.Location = new System.Drawing.Point(442, 549);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 34;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::STELLAR.APP.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(523, 547);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 26);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Image = global::STELLAR.APP.Properties.Resources.disk;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApply.Location = new System.Drawing.Point(601, 547);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(81, 25);
            this.btnApply.TabIndex = 36;
            this.btnApply.Text = "Apply";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // frmSchema2Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 583);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSchema2Template";
            this.Text = "Schema to Template Mapping";
            this.Load += new System.EventHandler(this.UseOfStringTemplate_Load);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMappings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSchemaFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSchemaFields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog dlgOpenSchema;
        private System.Windows.Forms.Button btnReadSchema;
        private System.Windows.Forms.TextBox txtSchemaFileName;
        private System.Windows.Forms.OpenFileDialog dlgOpenTemplate;
        private System.Data.DataSet dsMappings;
        private System.Data.DataTable tblSchemaFields;
        private System.Data.DataTable dataTable1;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colTemplateField;
        private System.Windows.Forms.ColumnHeader colSchemaField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txtEditTemplate;
        private System.Windows.Forms.ListBox lstTemplates;
        private System.Windows.Forms.ListBox lstTemplateFields;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTemplateFileName;
        private System.Windows.Forms.Button btnReadTemplate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteMapping;
        private System.Windows.Forms.Button btnEditMapping;
        private System.Windows.Forms.Button btnAddMapping;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnEditSchema;
    }
}