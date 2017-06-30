namespace GNetBillingSoft.Master
{
    partial class frmUnits_Remarks
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.unittb = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtunitid = new System.Windows.Forms.TextBox();
            this.btnunit = new System.Windows.Forms.Button();
            this.lblQnty = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtUnitname = new System.Windows.Forms.TextBox();
            this.grdUnits = new System.Windows.Forms.DataGridView();
            this.unitid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkstb = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtremarkid = new System.Windows.Forms.TextBox();
            this.btnremarks = new System.Windows.Forms.Button();
            this.lblRmrk = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.grdRemarks = new System.Windows.Forms.DataGridView();
            this.remarkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errUnits = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.unittb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnits)).BeginInit();
            this.remarkstb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.unittb);
            this.tabControl1.Controls.Add(this.remarkstb);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 248);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // unittb
            // 
            this.unittb.Controls.Add(this.splitContainer1);
            this.unittb.Location = new System.Drawing.Point(4, 22);
            this.unittb.Name = "unittb";
            this.unittb.Padding = new System.Windows.Forms.Padding(3);
            this.unittb.Size = new System.Drawing.Size(492, 222);
            this.unittb.TabIndex = 0;
            this.unittb.Text = "Units";
            this.unittb.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtunitid);
            this.splitContainer1.Panel1.Controls.Add(this.btnunit);
            this.splitContainer1.Panel1.Controls.Add(this.lblQnty);
            this.splitContainer1.Panel1.Controls.Add(this.lblUnit);
            this.splitContainer1.Panel1.Controls.Add(this.txtquantity);
            this.splitContainer1.Panel1.Controls.Add(this.txtUnitname);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdUnits);
            this.splitContainer1.Size = new System.Drawing.Size(486, 216);
            this.splitContainer1.SplitterDistance = 198;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtunitid
            // 
            this.txtunitid.Location = new System.Drawing.Point(63, 138);
            this.txtunitid.Name = "txtunitid";
            this.txtunitid.Size = new System.Drawing.Size(100, 20);
            this.txtunitid.TabIndex = 5;
            this.txtunitid.Visible = false;
            // 
            // btnunit
            // 
            this.btnunit.Location = new System.Drawing.Point(63, 82);
            this.btnunit.Name = "btnunit";
            this.btnunit.Size = new System.Drawing.Size(75, 23);
            this.btnunit.TabIndex = 3;
            this.btnunit.Text = "Save";
            this.btnunit.UseVisualStyleBackColor = true;
            this.btnunit.Click += new System.EventHandler(this.btnunit_Click);
            // 
            // lblQnty
            // 
            this.lblQnty.AutoSize = true;
            this.lblQnty.Location = new System.Drawing.Point(6, 44);
            this.lblQnty.Name = "lblQnty";
            this.lblQnty.Size = new System.Drawing.Size(46, 13);
            this.lblQnty.TabIndex = 3;
            this.lblQnty.Text = "Quantity";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(6, 13);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(26, 13);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "Unit";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(63, 44);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(100, 20);
            this.txtquantity.TabIndex = 2;
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtUnitname
            // 
            this.txtUnitname.Location = new System.Drawing.Point(63, 13);
            this.txtUnitname.Name = "txtUnitname";
            this.txtUnitname.Size = new System.Drawing.Size(100, 20);
            this.txtUnitname.TabIndex = 1;
            this.txtUnitname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // grdUnits
            // 
            this.grdUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitid,
            this.unitname,
            this.quantity});
            this.grdUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUnits.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdUnits.Location = new System.Drawing.Point(0, 0);
            this.grdUnits.Name = "grdUnits";
            this.grdUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUnits.Size = new System.Drawing.Size(284, 216);
            this.grdUnits.TabIndex = 0;
            // 
            // unitid
            // 
            this.unitid.DataPropertyName = "unitid";
            this.unitid.HeaderText = "unitid";
            this.unitid.Name = "unitid";
            this.unitid.Visible = false;
            // 
            // unitname
            // 
            this.unitname.DataPropertyName = "units";
            this.unitname.HeaderText = "Unit";
            this.unitname.Name = "unitname";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // remarkstb
            // 
            this.remarkstb.Controls.Add(this.splitContainer2);
            this.remarkstb.Location = new System.Drawing.Point(4, 22);
            this.remarkstb.Name = "remarkstb";
            this.remarkstb.Padding = new System.Windows.Forms.Padding(3);
            this.remarkstb.Size = new System.Drawing.Size(492, 222);
            this.remarkstb.TabIndex = 1;
            this.remarkstb.Text = "Remarks";
            this.remarkstb.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtremarkid);
            this.splitContainer2.Panel1.Controls.Add(this.btnremarks);
            this.splitContainer2.Panel1.Controls.Add(this.lblRmrk);
            this.splitContainer2.Panel1.Controls.Add(this.txtRemarks);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grdRemarks);
            this.splitContainer2.Size = new System.Drawing.Size(486, 216);
            this.splitContainer2.SplitterDistance = 206;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtremarkid
            // 
            this.txtremarkid.Location = new System.Drawing.Point(63, 93);
            this.txtremarkid.Name = "txtremarkid";
            this.txtremarkid.Size = new System.Drawing.Size(100, 20);
            this.txtremarkid.TabIndex = 3;
            this.txtremarkid.Visible = false;
            // 
            // btnremarks
            // 
            this.btnremarks.Location = new System.Drawing.Point(63, 44);
            this.btnremarks.Name = "btnremarks";
            this.btnremarks.Size = new System.Drawing.Size(75, 23);
            this.btnremarks.TabIndex = 2;
            this.btnremarks.Text = "Save";
            this.btnremarks.UseVisualStyleBackColor = true;
            this.btnremarks.Click += new System.EventHandler(this.btnremarks_Click);
            // 
            // lblRmrk
            // 
            this.lblRmrk.AutoSize = true;
            this.lblRmrk.Location = new System.Drawing.Point(8, 11);
            this.lblRmrk.Name = "lblRmrk";
            this.lblRmrk.Size = new System.Drawing.Size(49, 13);
            this.lblRmrk.TabIndex = 1;
            this.lblRmrk.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(63, 8);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(100, 20);
            this.txtRemarks.TabIndex = 0;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // grdRemarks
            // 
            this.grdRemarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRemarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.remarkid,
            this.remarks});
            this.grdRemarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRemarks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdRemarks.Location = new System.Drawing.Point(0, 0);
            this.grdRemarks.Name = "grdRemarks";
            this.grdRemarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRemarks.Size = new System.Drawing.Size(276, 216);
            this.grdRemarks.TabIndex = 0;
            this.grdRemarks.SelectionChanged += new System.EventHandler(this.grdRemarks_SelectionChanged);
            // 
            // remarkid
            // 
            this.remarkid.DataPropertyName = "remarkid";
            this.remarkid.HeaderText = "SlNo";
            this.remarkid.Name = "remarkid";
            // 
            // remarks
            // 
            this.remarks.DataPropertyName = "remarks";
            this.remarks.HeaderText = "Remarks";
            this.remarks.Name = "remarks";
            // 
            // errUnits
            // 
            this.errUnits.ContainerControl = this;
            // 
            // frmUnits_Remarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 248);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUnits_Remarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Units and Remarks";
            this.Load += new System.EventHandler(this.frmUnits_Remarkmaster_Load);
            this.tabControl1.ResumeLayout(false);
            this.unittb.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUnits)).EndInit();
            this.remarkstb.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errUnits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage unittb;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnunit;
        private System.Windows.Forms.Label lblQnty;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtUnitname;
        private System.Windows.Forms.DataGridView grdUnits;
        private System.Windows.Forms.TabPage remarkstb;
        private System.Windows.Forms.ErrorProvider errUnits;
        private System.Windows.Forms.TextBox txtunitid;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitid;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtremarkid;
        private System.Windows.Forms.Button btnremarks;
        private System.Windows.Forms.Label lblRmrk;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.DataGridView grdRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
    }
}