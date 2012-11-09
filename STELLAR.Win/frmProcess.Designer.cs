namespace STELLAR.Win
{
    partial class frmProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcess));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImportSpecFile = new System.Windows.Forms.TextBox();
            this.btnImportSpec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOutputFile = new System.Windows.Forms.Button();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.txtTemplateSpecFile = new System.Windows.Forms.TextBox();
            this.btnTemplateSpec = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dlgSaveProcess = new System.Windows.Forms.SaveFileDialog();
            this.dlgChooseImportSpec = new System.Windows.Forms.OpenFileDialog();
            this.dlgChooseOutputFile = new System.Windows.Forms.SaveFileDialog();
            this.dlgChooseTemplateSpec = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.Location = new System.Drawing.Point(12, 29);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(453, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Import Specification";
            // 
            // txtImportSpecFile
            // 
            this.txtImportSpecFile.AcceptsTab = true;
            this.txtImportSpecFile.Location = new System.Drawing.Point(12, 68);
            this.txtImportSpecFile.Name = "txtImportSpecFile";
            this.txtImportSpecFile.ReadOnly = true;
            this.txtImportSpecFile.Size = new System.Drawing.Size(418, 20);
            this.txtImportSpecFile.TabIndex = 3;
            this.txtImportSpecFile.TextChanged += new System.EventHandler(this.txtImportSpecFile_TextChanged);
            // 
            // btnImportSpec
            // 
            this.btnImportSpec.Location = new System.Drawing.Point(436, 67);
            this.btnImportSpec.Name = "btnImportSpec";
            this.btnImportSpec.Size = new System.Drawing.Size(29, 21);
            this.btnImportSpec.TabIndex = 4;
            this.btnImportSpec.Text = "...";
            this.btnImportSpec.UseVisualStyleBackColor = true;
            this.btnImportSpec.Click += new System.EventHandler(this.btnImportSpec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output File Name";
            // 
            // btnOutputFile
            // 
            this.btnOutputFile.Location = new System.Drawing.Point(436, 145);
            this.btnOutputFile.Name = "btnOutputFile";
            this.btnOutputFile.Size = new System.Drawing.Size(29, 21);
            this.btnOutputFile.TabIndex = 7;
            this.btnOutputFile.Text = "...";
            this.btnOutputFile.UseVisualStyleBackColor = true;
            this.btnOutputFile.Click += new System.EventHandler(this.btnOutputFile_Click);
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(12, 146);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.ReadOnly = true;
            this.txtOutputFile.Size = new System.Drawing.Size(418, 20);
            this.txtOutputFile.TabIndex = 6;
            this.txtOutputFile.TextChanged += new System.EventHandler(this.txtOutputFile_TextChanged);
            // 
            // txtTemplateSpecFile
            // 
            this.txtTemplateSpecFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTemplateSpecFile.Location = new System.Drawing.Point(12, 106);
            this.txtTemplateSpecFile.Name = "txtTemplateSpecFile";
            this.txtTemplateSpecFile.ReadOnly = true;
            this.txtTemplateSpecFile.Size = new System.Drawing.Size(418, 20);
            this.txtTemplateSpecFile.TabIndex = 35;
            this.txtTemplateSpecFile.TextChanged += new System.EventHandler(this.txtTemplateSpecFile_TextChanged);
            // 
            // btnTemplateSpec
            // 
            this.btnTemplateSpec.Location = new System.Drawing.Point(436, 106);
            this.btnTemplateSpec.Name = "btnTemplateSpec";
            this.btnTemplateSpec.Size = new System.Drawing.Size(28, 21);
            this.btnTemplateSpec.TabIndex = 34;
            this.btnTemplateSpec.Text = "...";
            this.btnTemplateSpec.UseVisualStyleBackColor = true;
            this.btnTemplateSpec.Click += new System.EventHandler(this.btnTemplateSpec_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Template Specification";
            // 
            // btnOK
            // 
            this.btnOK.Image = Stellar.Win.Properties.Resources.accept;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(306, 205);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 23);
            this.btnOK.TabIndex = 45;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = Stellar.Win.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(388, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 23);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dlgChooseImportSpec
            // 
            this.dlgChooseImportSpec.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgChooseImportSpec_FileOk);
            // 
            // dlgChooseOutputFile
            // 
            this.dlgChooseOutputFile.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgChooseOutputFile_FileOk);
            // 
            // dlgChooseTemplateSpec
            // 
            this.dlgChooseTemplateSpec.FileName = "openFileDialog1";
            this.dlgChooseTemplateSpec.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgChooseTemplateSpec_FileOk);
            // 
            // frmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 243);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.txtTemplateSpecFile);
            this.Controls.Add(this.btnTemplateSpec);
            this.Controls.Add(this.btnOutputFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnImportSpec);
            this.Controls.Add(this.txtImportSpecFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Process";
            this.Load += new System.EventHandler(this.frmProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImportSpecFile;
        private System.Windows.Forms.Button btnImportSpec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOutputFile;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.TextBox txtTemplateSpecFile;
        private System.Windows.Forms.Button btnTemplateSpec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.SaveFileDialog dlgSaveProcess;
        private System.Windows.Forms.OpenFileDialog dlgChooseImportSpec;
        private System.Windows.Forms.SaveFileDialog dlgChooseOutputFile;
        private System.Windows.Forms.OpenFileDialog dlgChooseTemplateSpec;
    }
}