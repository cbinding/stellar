namespace STELLAR.APP
{
    partial class frmFieldMapping
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
            this.cmbSchemaField = new System.Windows.Forms.ComboBox();
            this.cmbTemplateField = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnAddModifier = new System.Windows.Forms.Button();
            this.btnDeleteModifier = new System.Windows.Forms.Button();
            this.btnEditModifier = new System.Windows.Forms.Button();
            this.lstModifiers = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSchemaField
            // 
            this.cmbSchemaField.FormattingEnabled = true;
            this.cmbSchemaField.Location = new System.Drawing.Point(23, 25);
            this.cmbSchemaField.Name = "cmbSchemaField";
            this.cmbSchemaField.Size = new System.Drawing.Size(430, 21);
            this.cmbSchemaField.TabIndex = 0;
            this.cmbSchemaField.SelectedIndexChanged += new System.EventHandler(this.cmbSchemaField_SelectedIndexChanged);
            // 
            // cmbTemplateField
            // 
            this.cmbTemplateField.FormattingEnabled = true;
            this.cmbTemplateField.Location = new System.Drawing.Point(23, 257);
            this.cmbTemplateField.Name = "cmbTemplateField";
            this.cmbTemplateField.Size = new System.Drawing.Size(430, 21);
            this.cmbTemplateField.TabIndex = 1;
            this.cmbTemplateField.SelectedIndexChanged += new System.EventHandler(this.cmbTemplateField_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Schema Field";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Template Field";
            // 
            // cmdOK
            // 
            this.cmdOK.Image = Stellar.Win.Properties.Resources.accept;
            this.cmdOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdOK.Location = new System.Drawing.Point(289, 302);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(81, 23);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Image = Stellar.Win.Properties.Resources.cancel;
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(376, 302);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(81, 23);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMoveDown);
            this.groupBox3.Controls.Add(this.btnMoveUp);
            this.groupBox3.Controls.Add(this.btnAddModifier);
            this.groupBox3.Controls.Add(this.btnDeleteModifier);
            this.groupBox3.Controls.Add(this.btnEditModifier);
            this.groupBox3.Controls.Add(this.lstModifiers);
            this.groupBox3.Location = new System.Drawing.Point(12, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 169);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Field Modifiers";
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Image = Stellar.Win.Properties.Resources.arrow_down;
            this.btnMoveDown.Location = new System.Drawing.Point(410, 83);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(31, 27);
            this.btnMoveDown.TabIndex = 53;
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Image = Stellar.Win.Properties.Resources.arrow_up;
            this.btnMoveUp.Location = new System.Drawing.Point(410, 50);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(31, 27);
            this.btnMoveUp.TabIndex = 52;
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnAddModifier
            // 
            this.btnAddModifier.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddModifier.Image = Stellar.Win.Properties.Resources.add;
            this.btnAddModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddModifier.Location = new System.Drawing.Point(155, 133);
            this.btnAddModifier.Name = "btnAddModifier";
            this.btnAddModifier.Size = new System.Drawing.Size(79, 26);
            this.btnAddModifier.TabIndex = 51;
            this.btnAddModifier.Text = "Add...";
            this.btnAddModifier.UseVisualStyleBackColor = true;
            this.btnAddModifier.Click += new System.EventHandler(this.btnAddModifier_Click);
            // 
            // btnDeleteModifier
            // 
            this.btnDeleteModifier.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDeleteModifier.Image = Stellar.Win.Properties.Resources.delete;
            this.btnDeleteModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteModifier.Location = new System.Drawing.Point(325, 133);
            this.btnDeleteModifier.Name = "btnDeleteModifier";
            this.btnDeleteModifier.Size = new System.Drawing.Size(79, 26);
            this.btnDeleteModifier.TabIndex = 50;
            this.btnDeleteModifier.Text = "Delete";
            this.btnDeleteModifier.UseVisualStyleBackColor = true;
            this.btnDeleteModifier.Click += new System.EventHandler(this.btnDeleteModifier_Click);
            // 
            // btnEditModifier
            // 
            this.btnEditModifier.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditModifier.Image = Stellar.Win.Properties.Resources.pencil;
            this.btnEditModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditModifier.Location = new System.Drawing.Point(240, 133);
            this.btnEditModifier.Name = "btnEditModifier";
            this.btnEditModifier.Size = new System.Drawing.Size(79, 26);
            this.btnEditModifier.TabIndex = 49;
            this.btnEditModifier.Text = "Edit...";
            this.btnEditModifier.UseVisualStyleBackColor = true;
            this.btnEditModifier.Click += new System.EventHandler(this.btnEditModifier_Click);
            // 
            // lstModifiers
            // 
            this.lstModifiers.FormattingEnabled = true;
            this.lstModifiers.Items.AddRange(new object[] {
            "Trim spaces",
            "Lowercase",
            "Add prefix: \'http://xyz/\'",
            "Replace \'x\' with \'y\'"});
            this.lstModifiers.Location = new System.Drawing.Point(11, 19);
            this.lstModifiers.Name = "lstModifiers";
            this.lstModifiers.ScrollAlwaysVisible = true;
            this.lstModifiers.Size = new System.Drawing.Size(393, 108);
            this.lstModifiers.TabIndex = 47;
            this.lstModifiers.SelectedIndexChanged += new System.EventHandler(this.lstModifiers_SelectedIndexChanged);
            this.lstModifiers.DoubleClick += new System.EventHandler(this.lstModifiers_DoubleClick);
            // 
            // frmFieldMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 342);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTemplateField);
            this.Controls.Add(this.cmbSchemaField);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFieldMapping";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Field Mapping";
            this.Load += new System.EventHandler(this.frmFieldMapping_Load);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSchemaField;
        private System.Windows.Forms.ComboBox cmbTemplateField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddModifier;
        private System.Windows.Forms.Button btnDeleteModifier;
        private System.Windows.Forms.Button btnEditModifier;
        private System.Windows.Forms.ListBox lstModifiers;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
    }
}