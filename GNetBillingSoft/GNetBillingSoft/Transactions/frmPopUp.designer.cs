namespace GNetBillingSoft.Transactions
{
    partial class frmPopUp
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
            this.grdpopup = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.lblmsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdpopup)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdpopup
            // 
            this.grdpopup.AllowUserToAddRows = false;
            this.grdpopup.AllowUserToDeleteRows = false;
            this.grdpopup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdpopup.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdpopup.Location = new System.Drawing.Point(12, 12);
            this.grdpopup.Name = "grdpopup";
            this.grdpopup.ReadOnly = true;
            this.grdpopup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdpopup.Size = new System.Drawing.Size(545, 235);
            this.grdpopup.TabIndex = 2;
            this.grdpopup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdpopup_CellContentClick);
            this.grdpopup.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdpopup_CellLeave);
            this.grdpopup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdpopup_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtitem);
            this.groupBox1.Location = new System.Drawing.Point(14, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Id / Description";
            // 
            // txtitem
            // 
            this.txtitem.Location = new System.Drawing.Point(120, 17);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(227, 20);
            this.txtitem.TabIndex = 1;
            this.txtitem.TextChanged += new System.EventHandler(this.txtitem_TextChanged);
            this.txtitem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtitem_KeyDown);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(373, 262);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 13);
            this.lblmsg.TabIndex = 3;
            // 
            // frmpopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 310);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdpopup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmpopup";
            this.Text = "Sales Items";
            this.Load += new System.EventHandler(this.frmpopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdpopup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtitem;
        public System.Windows.Forms.DataGridView grdpopup;
        private System.Windows.Forms.Label lblmsg;
    }
}