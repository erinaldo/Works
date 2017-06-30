namespace GNetBillingSoft.Reports
{
    partial class frmCashBook
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
            this.txtto = new System.Windows.Forms.DateTimePicker();
            this.txtfrom = new System.Windows.Forms.DateTimePicker();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtto
            // 
            this.txtto.CustomFormat = "dd/MM/yyyy";
            this.txtto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtto.Location = new System.Drawing.Point(63, 63);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(200, 20);
            this.txtto.TabIndex = 13;
            // 
            // txtfrom
            // 
            this.txtfrom.CustomFormat = "dd/MM/yyyy";
            this.txtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfrom.Location = new System.Drawing.Point(63, 20);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(200, 20);
            this.txtfrom.TabIndex = 12;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(188, 107);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 32);
            this.btnclose.TabIndex = 11;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Green;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(97, 107);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 32);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTo.Location = new System.Drawing.Point(21, 65);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(21, 15);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFrom.Location = new System.Drawing.Point(21, 24);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(36, 15);
            this.lblFrom.TabIndex = 8;
            this.lblFrom.Text = "From";
            // 
            // frmCashBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 163);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCashBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtto;
        private System.Windows.Forms.DateTimePicker txtfrom;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
    }
}