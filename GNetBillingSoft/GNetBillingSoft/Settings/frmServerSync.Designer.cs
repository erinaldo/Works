namespace GNetBillingSoft.Settings
{
    partial class frmServerSync
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
            this.btnSync = new System.Windows.Forms.Button();
            this.btnsalesreport = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSync
            // 
            this.btnSync.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSync.Location = new System.Drawing.Point(37, 90);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(150, 41);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "Sales Item Report";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnsalesreport
            // 
            this.btnsalesreport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalesreport.Location = new System.Drawing.Point(37, 30);
            this.btnsalesreport.Name = "btnsalesreport";
            this.btnsalesreport.Size = new System.Drawing.Size(150, 38);
            this.btnsalesreport.TabIndex = 1;
            this.btnsalesreport.Text = "Sales Report";
            this.btnsalesreport.UseVisualStyleBackColor = true;
            this.btnsalesreport.Click += new System.EventHandler(this.btnsalesreport_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.ForeColor = System.Drawing.Color.Green;
            this.lblmsg.Location = new System.Drawing.Point(31, 118);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 13);
            this.lblmsg.TabIndex = 2;
            // 
            // frmServerSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(230, 157);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnsalesreport);
            this.Controls.Add(this.btnSync);
            this.Name = "frmServerSync";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Sync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnsalesreport;
        private System.Windows.Forms.Label lblmsg;
    }
}