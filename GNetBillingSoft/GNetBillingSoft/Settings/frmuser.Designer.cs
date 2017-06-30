namespace GNetBillingSoft.Settings
{
    partial class frmuser
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndel = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblPswd = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblUsr = new System.Windows.Forms.Label();
            this.btncreate = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.grpMenus = new System.Windows.Forms.GroupBox();
            this.trwMenu = new System.Windows.Forms.TreeView();
            this.errorUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpUsrList = new System.Windows.Forms.GroupBox();
            this.lstuserlist = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.grpMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorUser)).BeginInit();
            this.grpUsrList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.lblPswd);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.lblUsr);
            this.groupBox1.Controls.Add(this.btncreate);
            this.groupBox1.Controls.Add(this.txtuser);
            this.groupBox1.Location = new System.Drawing.Point(3, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(463, 12);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(51, 23);
            this.btndel.TabIndex = 5;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(519, 12);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(51, 23);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblPswd
            // 
            this.lblPswd.AutoSize = true;
            this.lblPswd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPswd.Location = new System.Drawing.Point(201, 17);
            this.lblPswd.Name = "lblPswd";
            this.lblPswd.Size = new System.Drawing.Size(57, 15);
            this.lblPswd.TabIndex = 4;
            this.lblPswd.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(264, 14);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(119, 23);
            this.txtpassword.TabIndex = 1;
            // 
            // lblUsr
            // 
            this.lblUsr.AutoSize = true;
            this.lblUsr.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsr.Location = new System.Drawing.Point(6, 19);
            this.lblUsr.Name = "lblUsr";
            this.lblUsr.Size = new System.Drawing.Size(30, 15);
            this.lblUsr.TabIndex = 2;
            this.lblUsr.Text = "User";
            // 
            // btncreate
            // 
            this.btncreate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Location = new System.Drawing.Point(406, 12);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(51, 23);
            this.btncreate.TabIndex = 2;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(66, 14);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(115, 23);
            this.txtuser.TabIndex = 0;
            this.txtuser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grpMenus
            // 
            this.grpMenus.Controls.Add(this.trwMenu);
            this.grpMenus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenus.Location = new System.Drawing.Point(3, 65);
            this.grpMenus.Name = "grpMenus";
            this.grpMenus.Size = new System.Drawing.Size(584, 249);
            this.grpMenus.TabIndex = 0;
            this.grpMenus.TabStop = false;
            this.grpMenus.Text = "Menu Previlege";
            // 
            // trwMenu
            // 
            this.trwMenu.CheckBoxes = true;
            this.trwMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trwMenu.Location = new System.Drawing.Point(3, 19);
            this.trwMenu.Name = "trwMenu";
            this.trwMenu.Size = new System.Drawing.Size(578, 227);
            this.trwMenu.TabIndex = 0;
            this.trwMenu.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trw_AfterCheck);
            // 
            // errorUser
            // 
            this.errorUser.ContainerControl = this;
            // 
            // grpUsrList
            // 
            this.grpUsrList.Controls.Add(this.lstuserlist);
            this.grpUsrList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUsrList.Location = new System.Drawing.Point(593, 12);
            this.grpUsrList.Name = "grpUsrList";
            this.grpUsrList.Size = new System.Drawing.Size(166, 314);
            this.grpUsrList.TabIndex = 1;
            this.grpUsrList.TabStop = false;
            this.grpUsrList.Text = "Users";
            // 
            // lstuserlist
            // 
            this.lstuserlist.FormattingEnabled = true;
            this.lstuserlist.ItemHeight = 15;
            this.lstuserlist.Location = new System.Drawing.Point(6, 28);
            this.lstuserlist.Name = "lstuserlist";
            this.lstuserlist.Size = new System.Drawing.Size(157, 274);
            this.lstuserlist.TabIndex = 0;
            // 
            // frmuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 350);
            this.Controls.Add(this.grpUsrList);
            this.Controls.Add(this.grpMenus);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "frmuser";
            this.Text = "New User";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpMenus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorUser)).EndInit();
            this.grpUsrList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpMenus;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lblUsr;
        private System.Windows.Forms.Label lblPswd;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.ErrorProvider errorUser;
        private System.Windows.Forms.TreeView trwMenu;
        private System.Windows.Forms.GroupBox grpUsrList;
        private System.Windows.Forms.ListBox lstuserlist;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndel;
    }
}