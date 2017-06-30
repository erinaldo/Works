namespace GNetBillingSoft.Settings
{
    partial class frmPeriod
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPeriodTo = new System.Windows.Forms.DateTimePicker();
            this.txtPeriodFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtPeriodTo);
            this.groupBox1.Controls.Add(this.txtPeriodFrom);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.lblFrom);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Period Setting";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(183, 115);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(116, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPeriodTo
            // 
            this.txtPeriodTo.CustomFormat = "dd/MM/yyyy";
            this.txtPeriodTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtPeriodTo.Location = new System.Drawing.Point(88, 73);
            this.txtPeriodTo.Name = "txtPeriodTo";
            this.txtPeriodTo.Size = new System.Drawing.Size(156, 20);
            this.txtPeriodTo.TabIndex = 3;
            // 
            // txtPeriodFrom
            // 
            this.txtPeriodFrom.CustomFormat = "dd/MM/yyyy";
            this.txtPeriodFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtPeriodFrom.Location = new System.Drawing.Point(88, 34);
            this.txtPeriodFrom.Name = "txtPeriodFrom";
            this.txtPeriodFrom.Size = new System.Drawing.Size(156, 20);
            this.txtPeriodFrom.TabIndex = 2;
            this.txtPeriodFrom.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(24, 77);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(53, 13);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "Period To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(14, 38);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(63, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Period From";
            // 
            // frmPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(294, 171);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmPeriod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Period Setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtPeriodTo;
        private System.Windows.Forms.DateTimePicker txtPeriodFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}