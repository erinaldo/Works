// Type: GNetBillingSoft.frmreceipts
// Assembly: GNetBillingSoft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF94799A-7D18-4F06-8215-9E1CC70A2A54
// Assembly location: F:\jdownloads\GNetBillingSoft\GNetBillingSoft.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GNetBillingSoft
{
  partial  class frmreceipts
  {
    private IContainer components = (IContainer) null;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn cash;
    private DataGridViewTextBoxColumn bank;
    private DataGridViewTextBoxColumn date;
    private DataGridViewTextBoxColumn documentno;
    private DataGridViewTextBoxColumn accountno;
    private DataGridViewTextBoxColumn accountname;
    private DataGridViewTextBoxColumn amount;
    private DataGridViewTextBoxColumn ref_invoice;
    private DataGridViewTextBoxColumn description;

   

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ref_invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cash,
            this.bank,
            this.date,
            this.documentno,
            this.accountno,
            this.accountname,
            this.amount,
            this.ref_invoice,
            this.description});
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(827, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // cash
            // 
            this.cash.HeaderText = "Cash";
            this.cash.Name = "cash";
            // 
            // bank
            // 
            this.bank.HeaderText = "Bank";
            this.bank.Name = "bank";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // documentno
            // 
            this.documentno.HeaderText = "Document No";
            this.documentno.Name = "documentno";
            // 
            // accountno
            // 
            this.accountno.HeaderText = "Account No";
            this.accountno.Name = "accountno";
            // 
            // accountname
            // 
            this.accountname.HeaderText = "Account Name";
            this.accountname.Name = "accountname";
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            // 
            // ref_invoice
            // 
            this.ref_invoice.HeaderText = "Reference Invoice No";
            this.ref_invoice.Name = "ref_invoice";
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            // 
            // frmreceipts
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 276);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmreceipts";
            this.Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

    }
  }
}
