// Type: GNetBillingSoft.frmvoucher
// Assembly: GNetBillingSoft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF94799A-7D18-4F06-8215-9E1CC70A2A54
// Assembly location: F:\jdownloads\GNetBillingSoft\GNetBillingSoft.exe

using GNetBillingSoft.DataOperation;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace GNetBillingSoft.Transactions
{
    partial class frmVoucher : Form
    {
        private System.ComponentModel.IContainer components = null;
        
        private Label lblVoucherNo;
        private Label lblVoucherType;
        private Label lblTransType;
        private DomainUpDown txtvoucher;
        private ComboBox cmbtypetransaction;
        private ComboBox cmbtypevoucher;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView grdVoucher;
        private GroupBox groupBox5;
        private CheckBox chkPrint;
        private Button btnprint;
        private Button btnclear;
        private Button btnDelete;
        private Button btnedit;
        private Button btnSave;
        private Label lblbalance;
        private ErrorProvider errovoucher;
        private Button btnClose;
        private TextBox txttotal;
        private Label lblTotAmnt;
        private DataGridViewComboBoxEditingControl editingcombo;
        private DataGridViewTextBoxEditingControl editingcontrol;

       

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.lblVoucherType = new System.Windows.Forms.Label();
            this.lblTransType = new System.Windows.Forms.Label();
            this.txtvoucher = new System.Windows.Forms.DomainUpDown();
            this.cmbtypetransaction = new System.Windows.Forms.ComboBox();
            this.cmbtypevoucher = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdVoucher = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblbalance = new System.Windows.Forms.Label();
            this.errovoucher = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTotAmnt = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.slno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accounttype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.referenceinvo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldbalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newbalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVoucher)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errovoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblVoucherNo.Location = new System.Drawing.Point(15, 34);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(81, 15);
            this.lblVoucherNo.TabIndex = 0;
            this.lblVoucherNo.Text = "Voucher No";
            this.lblVoucherNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblVoucherType.Location = new System.Drawing.Point(263, 36);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Size = new System.Drawing.Size(109, 15);
            this.lblVoucherType.TabIndex = 2;
            this.lblVoucherType.Text = "Type of Voucher";
            // 
            // lblTransType
            // 
            this.lblTransType.AutoSize = true;
            this.lblTransType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTransType.Location = new System.Drawing.Point(545, 36);
            this.lblTransType.Name = "lblTransType";
            this.lblTransType.Size = new System.Drawing.Size(132, 15);
            this.lblTransType.TabIndex = 3;
            this.lblTransType.Text = "Type of Transaction";
            // 
            // txtvoucher
            // 
            this.txtvoucher.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvoucher.Location = new System.Drawing.Point(103, 32);
            this.txtvoucher.Name = "txtvoucher";
            this.txtvoucher.Size = new System.Drawing.Size(130, 23);
            this.txtvoucher.TabIndex = 7;
            this.txtvoucher.SelectedItemChanged += new System.EventHandler(this.txtvoucher_SelectedItemChanged);
            this.txtvoucher.TextChanged += new System.EventHandler(this.txtvoucher_TextChanged);
            // 
            // cmbtypetransaction
            // 
            this.cmbtypetransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtypetransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtypetransaction.FormattingEnabled = true;
            this.cmbtypetransaction.Items.AddRange(new object[] {
            "Cash Account",
            "Bank Account"});
            this.cmbtypetransaction.Location = new System.Drawing.Point(677, 32);
            this.cmbtypetransaction.Name = "cmbtypetransaction";
            this.cmbtypetransaction.Size = new System.Drawing.Size(133, 23);
            this.cmbtypetransaction.TabIndex = 8;
            this.cmbtypetransaction.SelectedIndexChanged += new System.EventHandler(this.cmbtypetransaction_SelectedIndexChanged);
            // 
            // cmbtypevoucher
            // 
            this.cmbtypevoucher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtypevoucher.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtypevoucher.FormattingEnabled = true;
            this.cmbtypevoucher.Items.AddRange(new object[] {
            "RECEIPT",
            "PAYMENT"});
            this.cmbtypevoucher.Location = new System.Drawing.Point(378, 31);
            this.cmbtypevoucher.Name = "cmbtypevoucher";
            this.cmbtypevoucher.Size = new System.Drawing.Size(153, 23);
            this.cmbtypevoucher.TabIndex = 9;
            this.cmbtypevoucher.SelectedIndexChanged += new System.EventHandler(this.cmbtypevoucher_SelectedIndexChanged);
            this.cmbtypevoucher.SelectedValueChanged += new System.EventHandler(this.cmbtypevoucher_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblVoucherNo);
            this.groupBox1.Controls.Add(this.cmbtypevoucher);
            this.groupBox1.Controls.Add(this.lblVoucherType);
            this.groupBox1.Controls.Add(this.cmbtypetransaction);
            this.groupBox1.Controls.Add(this.lblTransType);
            this.groupBox1.Controls.Add(this.txtvoucher);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 78);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.grdVoucher);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 192);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // grdVoucher
            // 
            this.grdVoucher.BackgroundColor = System.Drawing.Color.White;
            this.grdVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slno,
            this.accounttype,
            this.name,
            this.referenceinvo,
            this.amount,
            this.remark,
            this.oldbalance,
            this.newbalance});
            this.grdVoucher.Location = new System.Drawing.Point(6, 19);
            this.grdVoucher.Name = "grdVoucher";
            this.grdVoucher.Size = new System.Drawing.Size(804, 159);
            this.grdVoucher.TabIndex = 0;
            this.grdVoucher.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.grdVoucher_CellBeginEdit);
            this.grdVoucher.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVoucher_CellEndEdit);
            this.grdVoucher.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVoucher_CellLeave);
            this.grdVoucher.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdVoucher_DataError);
            this.grdVoucher.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdVoucher_EditingControlShowing);
            this.grdVoucher.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVoucher_RowEnter);
            this.grdVoucher.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdVoucher_UserAddedRow);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btnClose);
            this.groupBox5.Controls.Add(this.chkPrint);
            this.groupBox5.Controls.Add(this.btnprint);
            this.groupBox5.Controls.Add(this.btnclear);
            this.groupBox5.Controls.Add(this.btnDelete);
            this.groupBox5.Controls.Add(this.btnedit);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Location = new System.Drawing.Point(300, 326);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(528, 98);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::GNetBillingSoft.Properties.Resources.red_cross_icon_215331;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(446, 40);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 52);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // chkPrint
            // 
            this.chkPrint.AutoSize = true;
            this.chkPrint.Location = new System.Drawing.Point(11, 17);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(108, 17);
            this.chkPrint.TabIndex = 25;
            this.chkPrint.Text = "Print while saving";
            this.chkPrint.UseVisualStyleBackColor = true;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.White;
            this.btnprint.BackgroundImage = global::GNetBillingSoft.Properties.Resources.printer;
            this.btnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnprint.FlatAppearance.BorderSize = 0;
            this.btnprint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(272, 40);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 52);
            this.btnprint.TabIndex = 14;
            this.btnprint.Text = "Print";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.White;
            this.btnclear.BackgroundImage = global::GNetBillingSoft.Properties.Resources.eraser_icon;
            this.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(359, 40);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 52);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "Clear";
            this.btnclear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImage = global::GNetBillingSoft.Properties.Resources.delete_xxl;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(185, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 52);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.White;
            this.btnedit.BackgroundImage = global::GNetBillingSoft.Properties.Resources.edit_notes_icons_21;
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(98, 40);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 52);
            this.btnedit.TabIndex = 11;
            this.btnedit.Text = "Edit";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = global::GNetBillingSoft.Properties.Resources.Save_icon;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(11, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 52);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblbalance
            // 
            this.lblbalance.AutoSize = true;
            this.lblbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalance.Location = new System.Drawing.Point(14, 326);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(0, 20);
            this.lblbalance.TabIndex = 26;
            // 
            // errovoucher
            // 
            this.errovoucher.ContainerControl = this;
            // 
            // lblTotAmnt
            // 
            this.lblTotAmnt.AutoSize = true;
            this.lblTotAmnt.BackColor = System.Drawing.Color.Transparent;
            this.lblTotAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotAmnt.Location = new System.Drawing.Point(591, 303);
            this.lblTotAmnt.Name = "lblTotAmnt";
            this.lblTotAmnt.Size = new System.Drawing.Size(99, 15);
            this.lblTotAmnt.TabIndex = 27;
            this.lblTotAmnt.Text = "Total Amount :";
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.SystemColors.Window;
            this.txttotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(697, 300);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(125, 23);
            this.txttotal.TabIndex = 28;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // slno
            // 
            this.slno.HeaderText = "SlNo";
            this.slno.Name = "slno";
            this.slno.ReadOnly = true;
            this.slno.Width = 50;
            // 
            // accounttype
            // 
            this.accounttype.HeaderText = "Account Type";
            this.accounttype.Name = "accounttype";
            this.accounttype.ReadOnly = true;
            this.accounttype.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // name
            // 
            this.name.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // referenceinvo
            // 
            this.referenceinvo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.referenceinvo.HeaderText = "Reference";
            this.referenceinvo.Name = "referenceinvo";
            this.referenceinvo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.referenceinvo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            // 
            // remark
            // 
            this.remark.HeaderText = "Remark";
            this.remark.Name = "remark";
            // 
            // oldbalance
            // 
            this.oldbalance.HeaderText = "Old Balance";
            this.oldbalance.Name = "oldbalance";
            this.oldbalance.ReadOnly = true;
            // 
            // newbalance
            // 
            this.newbalance.HeaderText = "New Balance";
            this.newbalance.Name = "newbalance";
            this.newbalance.ReadOnly = true;
            this.newbalance.Width = 120;
            // 
            // frmvoucher
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GNetBillingSoft.Properties.Resources.web_designer_pune_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 431);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lblTotAmnt);
            this.Controls.Add(this.lblbalance);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "frmvoucher";
            this.Text = "Voucher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVoucher)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errovoucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridViewTextBoxColumn slno;
        private DataGridViewTextBoxColumn accounttype;
        private DataGridViewComboBoxColumn name;
        private DataGridViewComboBoxColumn referenceinvo;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn remark;
        private DataGridViewTextBoxColumn oldbalance;
        private DataGridViewTextBoxColumn newbalance;

       
    }
}
