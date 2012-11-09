namespace STELLAR.APP
{
    partial class frmTemplateSpec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemplateSpec));
            this.txtTemplateFileName = new System.Windows.Forms.TextBox();
            this.btnReadTemplateFile = new System.Windows.Forms.Button();
            this.lstTemplates = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dlgOpenTemplate = new System.Windows.Forms.OpenFileDialog();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteFieldMapping = new System.Windows.Forms.Button();
            this.btnAddFieldMapping = new System.Windows.Forms.Button();
            this.btnEditFieldMapping = new System.Windows.Forms.Button();
            this.lstFieldMappings = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTemplateFileName
            // 
            this.txtTemplateFileName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTemplateFileName.Location = new System.Drawing.Point(9, 19);
            this.txtTemplateFileName.Name = "txtTemplateFileName";
            this.txtTemplateFileName.Size = new System.Drawing.Size(401, 20);
            this.txtTemplateFileName.TabIndex = 0;
            // 
            // btnReadTemplateFile
            // 
            this.btnReadTemplateFile.Location = new System.Drawing.Point(416, 18);
            this.btnReadTemplateFile.Name = "btnReadTemplateFile";
            this.btnReadTemplateFile.Size = new System.Drawing.Size(29, 21);
            this.btnReadTemplateFile.TabIndex = 1;
            this.btnReadTemplateFile.Text = "...";
            this.btnReadTemplateFile.UseVisualStyleBackColor = true;
            this.btnReadTemplateFile.Click += new System.EventHandler(this.btnReadTemplateFile_Click);
            // 
            // lstTemplates
            // 
            this.lstTemplates.FormattingEnabled = true;
            this.lstTemplates.Location = new System.Drawing.Point(9, 45);
            this.lstTemplates.Name = "lstTemplates";
            this.lstTemplates.Size = new System.Drawing.Size(436, 69);
            this.lstTemplates.TabIndex = 2;
            this.lstTemplates.SelectedIndexChanged += new System.EventHandler(this.lstTemplates_SelectedIndexChanged);
            // 
            // btnOK
            // 
            //this.btnOK.Image = global::STELLAR.APP.Properties.Resources.accept;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(303, 362);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            //this.btnCancel.Image = global::STELLAR.APP.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(387, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTemplateFileName);
            this.groupBox2.Controls.Add(this.btnReadTemplateFile);
            this.groupBox2.Controls.Add(this.lstTemplates);
            this.groupBox2.Location = new System.Drawing.Point(15, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 125);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Template";
            // 
            // dlgOpenTemplate
            // 
            this.dlgOpenTemplate.FileName = "openFileDialog1";
            this.dlgOpenTemplate.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpenTemplate_FileOk);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(20, 362);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(52, 23);
            this.btnRead.TabIndex = 16;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(78, 362);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(53, 23);
            this.btnWrite.TabIndex = 17;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteFieldMapping);
            this.groupBox1.Controls.Add(this.btnAddFieldMapping);
            this.groupBox1.Controls.Add(this.btnEditFieldMapping);
            this.groupBox1.Controls.Add(this.lstFieldMappings);
            this.groupBox1.Location = new System.Drawing.Point(15, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 151);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Field Mappings";
            // 
            // btnDeleteFieldMapping
            // 
            //this.btnDeleteFieldMapping.Image = global::STELLAR.APP.Properties.Resources.delete;
            this.btnDeleteFieldMapping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteFieldMapping.Location = new System.Drawing.Point(373, 120);
            this.btnDeleteFieldMapping.Name = "btnDeleteFieldMapping";
            this.btnDeleteFieldMapping.Size = new System.Drawing.Size(72, 22);
            this.btnDeleteFieldMapping.TabIndex = 42;
            this.btnDeleteFieldMapping.Text = "Delete";
            this.btnDeleteFieldMapping.UseVisualStyleBackColor = true;
            // 
            // btnAddFieldMapping
            // 
            //this.btnAddFieldMapping.Image = global::STELLAR.APP.Properties.Resources.add;
            this.btnAddFieldMapping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFieldMapping.Location = new System.Drawing.Point(205, 120);
            this.btnAddFieldMapping.Name = "btnAddFieldMapping";
            this.btnAddFieldMapping.Size = new System.Drawing.Size(77, 22);
            this.btnAddFieldMapping.TabIndex = 41;
            this.btnAddFieldMapping.Text = "Add...";
            this.btnAddFieldMapping.UseVisualStyleBackColor = true;
            this.btnAddFieldMapping.Click += new System.EventHandler(this.btnAddFieldMapping_Click);
            // 
            // btnEditFieldMapping
            // 
            //this.btnEditFieldMapping.Image = global::STELLAR.APP.Properties.Resources.pencil;
            this.btnEditFieldMapping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditFieldMapping.Location = new System.Drawing.Point(288, 120);
            this.btnEditFieldMapping.Name = "btnEditFieldMapping";
            this.btnEditFieldMapping.Size = new System.Drawing.Size(79, 22);
            this.btnEditFieldMapping.TabIndex = 40;
            this.btnEditFieldMapping.Text = "Edit...";
            this.btnEditFieldMapping.UseVisualStyleBackColor = true;
            this.btnEditFieldMapping.Click += new System.EventHandler(this.btnEditFieldMapping_Click);
            // 
            // lstFieldMappings
            // 
            this.lstFieldMappings.FormattingEnabled = true;
            this.lstFieldMappings.Location = new System.Drawing.Point(6, 19);
            this.lstFieldMappings.Name = "lstFieldMappings";
            this.lstFieldMappings.ScrollAlwaysVisible = true;
            this.lstFieldMappings.Size = new System.Drawing.Size(439, 95);
            this.lstFieldMappings.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(25, 22);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(434, 20);
            this.txtDescription.TabIndex = 48;
            // 
            // frmTemplateSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 396);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTemplateSpec";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Template Specification";
            this.Load += new System.EventHandler(this.frmApplyTemplate_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemplateFileName;
        private System.Windows.Forms.Button btnReadTemplateFile;
        private System.Windows.Forms.ListBox lstTemplates;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog dlgOpenTemplate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteFieldMapping;
        private System.Windows.Forms.Button btnAddFieldMapping;
        private System.Windows.Forms.Button btnEditFieldMapping;
        private System.Windows.Forms.ListBox lstFieldMappings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
    }
}