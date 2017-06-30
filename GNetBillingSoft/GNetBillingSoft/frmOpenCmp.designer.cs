namespace GNetBillingSoft
{
    partial class frmOpenCmp
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
            this.grpCmp = new System.Windows.Forms.GroupBox();
            this.lstCompany = new System.Windows.Forms.ListBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnbackup = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkdefault = new System.Windows.Forms.CheckBox();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.grpCmp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCmp
            // 
            this.grpCmp.Controls.Add(this.lstCompany);
            this.grpCmp.Location = new System.Drawing.Point(0, 0);
            this.grpCmp.Name = "grpCmp";
            this.grpCmp.Size = new System.Drawing.Size(248, 234);
            this.grpCmp.TabIndex = 0;
            this.grpCmp.TabStop = false;
            // 
            // lstCompany
            // 
            this.lstCompany.FormattingEnabled = true;
            this.lstCompany.Location = new System.Drawing.Point(6, 12);
            this.lstCompany.Name = "lstCompany";
            this.lstCompany.Size = new System.Drawing.Size(236, 212);
            this.lstCompany.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOpen.Location = new System.Drawing.Point(6, 17);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(85, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(6, 49);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRestore);
            this.groupBox1.Controls.Add(this.btnbackup);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Location = new System.Drawing.Point(254, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 235);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(6, 148);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(85, 23);
            this.btnRestore.TabIndex = 7;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnbackup
            // 
            this.btnbackup.Location = new System.Drawing.Point(6, 115);
            this.btnbackup.Name = "btnbackup";
            this.btnbackup.Size = new System.Drawing.Size(85, 23);
            this.btnbackup.TabIndex = 6;
            this.btnbackup.Text = "Backup";
            this.btnbackup.UseVisualStyleBackColor = true;
            this.btnbackup.Click += new System.EventHandler(this.btnbackup_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkdefault
            // 
            this.chkdefault.AutoSize = true;
            this.chkdefault.Location = new System.Drawing.Point(6, 240);
            this.chkdefault.Name = "chkdefault";
            this.chkdefault.Size = new System.Drawing.Size(140, 17);
            this.chkdefault.TabIndex = 5;
            this.chkdefault.Text = "Set as Default Company";
            this.chkdefault.UseVisualStyleBackColor = true;
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // frmOpenCmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 259);
            this.Controls.Add(this.chkdefault);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCmp);
            this.Name = "frmOpenCmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open Company";
            this.Load += new System.EventHandler(this.frmOpenCmp_Load);
            this.grpCmp.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCmp;
        private System.Windows.Forms.ListBox lstCompany;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkdefault;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnbackup;
        private System.Windows.Forms.Button btnRestore;
        public System.Windows.Forms.OpenFileDialog dlgOpen;
    }
}