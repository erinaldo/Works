namespace GNetBillingSoft
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUsrName = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPswd = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.lblAccLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsrName
            // 
            resources.ApplyResources(this.lblUsrName, "lblUsrName");
            this.lblUsrName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblUsrName.Name = "lblUsrName";
            // 
            // txtusername
            // 
            resources.ApplyResources(this.txtusername, "txtusername");
            this.txtusername.Name = "txtusername";
            this.txtusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblPswd
            // 
            resources.ApplyResources(this.lblPswd, "lblPswd");
            this.lblPswd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblPswd.Name = "lblPswd";
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.btLogin, "btLogin");
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Name = "btLogin";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btnok_Click);
            // 
            // lblAccLogin
            // 
            resources.ApplyResources(this.lblAccLogin, "lblAccLogin");
            this.lblAccLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblAccLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAccLogin.ForeColor = System.Drawing.Color.White;
            this.lblAccLogin.Name = "lblAccLogin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblAccLogin);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPswd);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblUsrName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsrName;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPswd;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lblAccLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}