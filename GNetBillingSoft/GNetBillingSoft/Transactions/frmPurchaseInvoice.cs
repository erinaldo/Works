using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft.Transactions
{

    public partial class frmPurchaseInvoice : Form
    {
        clspurchaseinvoice purchase = new clspurchaseinvoice();
        clspurchasedetails purchasedetails = new clspurchasedetails();
        clssalesdetails salesdetails = new clssalesdetails();
        clsitemdetails items = new clsitemdetails();
        clsgeneralledger generaledger = new clsgeneralledger();
        clsunits units = new clsunits();
        clssuplierdetails suplier = new clssuplierdetails();
        //private Point Start;

        public frmPurchaseInvoice()
        {
            InitializeComponent();
            txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            AddInvoice();
            grdItems.Rows[0].HeaderCell.Value = "1";

            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }
        private void Arabic()
        {
            //frmpurchaseinvoice fpi = new frmpurchaseinvoice();
            //fpi.Text = "";

            //Label
            lbldate.Text = "التاريخ";
            lblVoucherNo.Text = "رقم القسيمة";
            lblsuppliename.Text = "اسم المورد";
            lblphonenumber.Text = "رقم الهاتف";
            lbladdress.Text = "عنوان";
            lblOppBal.Text = "الرصيد الافتتاحى";
            lblTotPaid.Text = "مجموع المبالغ المدفوعة";
            lblPaidCheq.Text = "شيك مدفوع";
            lblPaidCash.Text = "النقدية المدفوعة";
            lblAdDiscount.Text = "خصم إضافي";
            lblNetTotal.Text = "الصافى";
            lblBal.Text = "رصيد";
            lblDiscount.Text = "% خصم";
            lblTotItem.Text = "(اجمالى المواد(الاصناف";
            lblRef.Text = "مرجع";

            //Button
            btnPrint.Text = "طباعة";
            btnClose.Text = "اقفال";
            btnDelete.Text = "الغاء";
            btnedit.Text = "تحرير";
            btnSave.Text = "حفظ";
            btnclear.Text = "واضح";

            //DataGrid
            itemno.HeaderText = "رقم الصنف";
            description.HeaderText = "الوصف";
            unit.HeaderText = "وحدة";
            quantity.HeaderText = "الكمية";
            price.HeaderText = "السعر";
            total.HeaderText = "الاجمالى";
            netamount.HeaderText = "الصافى";
            sellingprice.HeaderText = "سعر البيع";

            chkPrint.Text = "اطبع أثناء الحفظ";
        }
        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (e.KeyChar == '\r')
                    if (this.ActiveControl != null)
                        this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void AddInvoice()
        {
            DataTable strsql = this.purchase.GetIds();
            this.txtinvoice.Items.Clear();
            if (strsql.Rows.Count != 0)
            {
                this.txtinvoice.Items.Add(this.purchase.GetNextId().ToString());
                for (int i = 0; i < strsql.Rows.Count; i++)
                {
                    this.txtinvoice.Items.Add(strsql.Rows[i]["invoiceno"].ToString());
                }
                this.txtinvoice.SelectedIndex = 0;
            }
            else
            {
                this.txtinvoice.Text = this.purchase.GetNextId().ToString();
            }
            txtsupplier.DataSource = suplier.GetRecord();
            txtsupplier.DisplayMember = "supliername";
            txtsupplier.ValueMember = "suplierid";
        }
        private void AddSelRecord()
        {
            this.purchase.invoiceno = this.txtinvoice.Text;
            this.purchasedetails.invoiceno = this.txtinvoice.Text;
            DataTable selRecord = this.purchase.GetSelRecord();
            this.grdItems.CausesValidation = false;
            this.grdItems.Rows.Clear();
            if (selRecord.Rows.Count != 0)
            {
                DataTable table2 = this.purchasedetails.GetSelRecord();
                
                for (int i = 0; i < table2.Rows.Count; i++)
                {
                    
                    DataGridViewRow dataGridViewRow = (DataGridViewRow)this.grdItems.Rows[0].Clone();
                    
                    dataGridViewRow.Cells[0].Value = table2.Rows[i]["itemid"];
                    dataGridViewRow.Cells[1].Value = table2.Rows[i]["Description"];
                    //dataGridViewRow.Cells[2].Value = table2.Rows[i]["unit"];
                    DataGridViewComboBoxCell column = (DataGridViewComboBoxCell)dataGridViewRow.Cells[2];
                    column.DataSource = units.GetRecord();
                    column.DisplayMember = "units";
                    column.ValueMember = "units";
                    column.Value = table2.Rows[i]["unit"].ToString();

                    dataGridViewRow.Cells[3].Value = table2.Rows[i]["quantity"];
                    dataGridViewRow.Cells[4].Value = table2.Rows[i]["Price"];
                    double num2 = Convert.ToDouble(table2.Rows[i]["quantity"].ToString()) * Convert.ToDouble(table2.Rows[i]["Price"].ToString());
                    dataGridViewRow.Cells[5].Value = num2;
                    dataGridViewRow.Cells[7].Value = table2.Rows[i]["salesrate"];
                    dataGridViewRow.Cells[8].Value = table2.Rows[i]["purchaseid"];
                    this.grdItems.Rows.Add(dataGridViewRow);
                    grdItems.Rows[i].HeaderCell.Value = Convert.ToString(i + 1);
                }
                this.txtsupplier.SelectedValue = selRecord.Rows[0]["suplierName"].ToString();
                this.txtphonenumber.Text = selRecord.Rows[0]["phonenumber"].ToString();
                txtopening.Text = selRecord.Rows[0]["openingbalance"].ToString();
                this.txtaddress.Text = selRecord.Rows[0]["address"].ToString();
                this.txtdate.Text = Convert.ToDateTime(selRecord.Rows[0]["purchasedate"].ToString()).ToString("dd/MM/yyyy");
                
                this.txtdiscount.Text = selRecord.Rows[0]["discount"].ToString();
                this.txtreferenno.Text = selRecord.Rows[0]["referenceno"].ToString();

                this.txtpaidcash.Text = selRecord.Rows[0]["paidcash"].ToString();
                this.txtpaidcheque.Text = selRecord.Rows[0]["paidcheque"].ToString();
                this.DisableControls(false);
            }
            else
            {
                this.txtsupplier.Text = "";
                this.txtphonenumber.Text = "";
                txtopening.Text = "";
                this.txtaddress.Text = "";
                this.txtdiscount.Text = "";
                this.txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                this.txtpaidcash.Text = "";
                this.txtpaidcheque.Text = "";
                this.txtreferenno.Text = "";
                this.grdItems.Rows.Clear();
                this.DisableControls(true);
                grdItems.Rows[0].HeaderCell.Value = "1";
            }
            this.purchase.CalcNetAmt(this.grdItems, this.txtdiscount.Text);
            this.CalcBalance();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            String Msg = (Properties.Settings.Default.Lang == "Arabic") ? "هل تريد حذف" : "Do you want delete";
            if (MessageBox.Show(Msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.purchase.invoiceno = this.txtinvoice.Text;
                this.purchase.Delete();
                this.purchasedetails.invoiceno = this.txtinvoice.Text;
                this.purchasedetails.DeleteDetails();
                this.generaledger.voucherno = txtinvoice.Text;
                this.generaledger.DeleteLedger();
                
                this.Clear();
                this.DisableControls(true);
            }
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            this.DisableControls(true);
        }
        private void btnpnlclose_Click(object sender, EventArgs e)
        {
            //this.pnlPopup.Visible = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.SetData())
            {
                if (this.purchase.GetItems())
                {
                    this.purchase.Edit();
                }
                else
                {
                    this.purchase.Add();
                }
                if (chkPrint.Checked)
                {
                    rptPurchaseInv rptpur = new rptPurchaseInv();
                    rptpur.invioceno = txtinvoice.Text;
                    rptpur.MdiParent = this.MdiParent;
                    rptpur.Show();
                }
                this.Clear();
                this.errorProvider.Clear();
                items.TempId = null;
            }
        }
        private void CalcBalance()
        {
            try
            {
                double paidcash = (this.txtpaidcash.Text != "") ? Convert.ToDouble(this.txtpaidcash.Text) : 0.0;
                double num = (this.txtpaidcheque.Text != "") ? Convert.ToDouble(this.txtpaidcheque.Text) : 0.0;
                double num2 = (this.txtnetamount.Text != "") ? Convert.ToDouble(this.txtnetamount.Text) : 0.0;
                double num3 = 0.0;
                this.txtpaidcash.Text = paidcash.ToString("0.00");
                this.txtpaidcheque.Text = num.ToString("0.00");
                num3 = (num + paidcash) - num2;
                this.txtpaid.Text = (num + paidcash).ToString("0.00");
                this.txtBalance.Text = num3.ToString("0.00");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
        private void Clear()
        {
            this.txtsupplier.Text = string.Empty;
            this.txtphonenumber.Text = string.Empty;
            this.txtaddress.Text = string.Empty;
            this.txtdiscount.Text = string.Empty;
            this.txtnetamount.Text = string.Empty;
            this.txttotitem.Text = string.Empty;
            this.txtpaid.Text = string.Empty;
            this.txtpaidcheque.Text = string.Empty;
            this.txtpaidcash.Text = string.Empty;
            this.txtreferenno.Text = string.Empty;
            this.txtBalance.Text = string.Empty;
            this.grdItems.Rows.Clear();
            this.txtinvoice.Text = this.purchase.GetNextId();
            this.AddInvoice();
        }
        private void DisableControls(bool enabled)
        {
            foreach (Control strsql in base.Controls)
            {
                if (strsql is GroupBox)
                {
                    foreach (Control result in strsql.Controls)
                    {
                        if (((result != this.txtinvoice) && (result != this.btnClose)) && !(result is Label))
                        {
                            result.Enabled = enabled;
                            if (!(result is Button))
                            {
                                result.BackColor = SystemColors.ControlLightLight;
                            }
                        }
                        if ((result == this.btnedit) || (result == this.btnDelete) || (result==this.btnPrint))
                        {
                            result.Enabled = !enabled;
                        }
                    }
                }
                else if (!(strsql is Label))
                {
                    strsql.Enabled = enabled;
                    strsql.BackColor = SystemColors.ControlLightLight;
                }
            }
        }
        private void editingControl_KeyDown(object sender, KeyEventArgs e)
        {
            //DataGridViewTextBoxEditingControl txt = (DataGridViewTextBoxEditingControl)sender;
            //if (e.KeyCode == Keys.F2)
            //{

            //    pnlPopup.Focus();
            //    grdpopup.Focus();
            //}
        }
        private void editingControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl txt = (DataGridViewTextBoxEditingControl)sender;
            int columnIndex = txt.EditingControlDataGridView.CurrentCell.ColumnIndex;
            if (columnIndex == 3)
            {
                //if ((e.KeyChar != '\b') && !char.IsNumber(e.KeyChar))
                //{
                //    e.Handled = true;
                //}
            }
            else if (((columnIndex == 4) && ((e.KeyChar != '\b') && (e.KeyChar != '.'))) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            
            
        }
        private void editingControl_TextChanged(object sender, EventArgs e)
        {
            DataGridViewTextBoxEditingControl control = (DataGridViewTextBoxEditingControl)sender;
            DataGridView editingControlDataGridView = control.EditingControlDataGridView;
            switch (editingControlDataGridView.CurrentCell.ColumnIndex)
            {
                case 0:
                    
                    this.ShowPopup(control.Text,"");
                    
                    break;

                case 1:
                    ShowPopup("", control.Text);
                   
                    if (Convert.ToString(editingControlDataGridView.Rows[editingControlDataGridView.CurrentCell.RowIndex].Cells[1].Value) == "")
                    {
                       
                        editingControlDataGridView.Rows[editingControlDataGridView.CurrentCell.RowIndex].Cells[1].Value = this.items.GetNextId();
                    }
                    break;


                default:
                   // this.pnlPopup.Visible = false;
                    break;
            }
        }
        private void grdItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string strsql = Convert.ToString(this.grdItems.Rows[e.RowIndex].Cells[0].Value);
                this.items.itemid = strsql;
                if (this.items.GetItems())
                {
                    //this.PopClick(e.RowIndex);
                }
                //this.pnlPopup.Visible = false;
            }
            else if (e.ColumnIndex == 1)
            {
                string itemid = Convert.ToString(this.grdItems.Rows[e.RowIndex].Cells[0].Value);
                if (itemid == "")
                {
                    items.Description = Convert.ToString(grdItems.Rows[e.RowIndex].Cells[1].Value);
                    DataTable dt = items.SearchProduct();
                    if (dt.Rows.Count == 0)
                    {
                        if (items.TempId == null)
                        {

                            this.grdItems.Rows[e.RowIndex].Cells[0].Value = items.GetNextId();
                            items.TempId = items.GetNextId();
                        }
                        else
                        {
                            long tmpid =Convert.ToInt64(items.TempId) + 1;
                            this.grdItems.Rows[e.RowIndex].Cells[0].Value = tmpid.ToString();
                            items.TempId = tmpid.ToString();
                        }
                    }
                    else
                    {
                        //this.PopClick(e.RowIndex);
                    }
                }
                //pnlPopup.Visible = false;
            }
        }
        private void grdItems_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void grdItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView strsql = (DataGridView)sender;
            if (strsql.Rows.Count > 1)
            {
                string obj = (strsql.Rows[e.RowIndex].Cells[3].Value != null) ? Convert.ToString(strsql.Rows[e.RowIndex].Cells[3].Value) : "0";
                this.SetNetAmt(e.RowIndex, obj);
                this.CalcBalance();

                if (e.ColumnIndex == 3)
                    grdItems.CurrentCell = grdItems.CurrentRow.Cells[0];
            }
        }
        private DataGridViewTextBoxEditingControl editingControl;
        private void grdItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (grdItems.CurrentCell.ColumnIndex == 2) return;
            this.editingControl = (DataGridViewTextBoxEditingControl)e.Control;
            this.editingControl.TextChanged += new EventHandler(this.editingControl_TextChanged);
            this.editingControl.KeyPress += new KeyPressEventHandler(this.editingControl_KeyPress);
            editingControl.KeyDown+=new KeyEventHandler(editingControl_KeyDown);
        }
        private void grdItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.txtnetamount.Text = this.purchase.CalcNetAmt(this.grdItems, this.txtdiscount.Text);
            txtpaidcash.Text = txtnetamount.Text;
            this.txttotitem.Text = this.purchase.CalcTotalItem(this.grdItems);
        }
        private void grdpopup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string itemid = Convert.ToString(this.grdpopup.Rows[e.RowIndex].Cells[0].Value);
            //items.itemid = itemid;
            //this.PopClick(e.RowIndex);
        }
        private void grdpopup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                //int strsql = this.grdpopup.CurrentCell.RowIndex;
                //string itemid = Convert.ToString(this.grdpopup.Rows[strsql].Cells[0].Value);
                //items.itemid = itemid;
              //  this.PopClick(strsql);
            }
            
        }
        private void pnlPopup_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    this.Start = e.Location;
            //    this.pnlPopup.MouseMove += new MouseEventHandler(this.pnlPopup_MouseMove);
            //    this.pnlPopup.MouseUp += new MouseEventHandler(this.pnlPopup_MouseUp);
            //}
        }
        private void pnlPopup_MouseMove(object sender, MouseEventArgs e)
        {
            //this.pnlPopup.Location = new Point(this.pnlPopup.Location.X - (this.Start.X - e.X), this.pnlPopup.Location.Y - (this.Start.Y - e.Y));
        }
        private void pnlPopup_MouseUp(object sender, MouseEventArgs e)
        {
            //this.pnlPopup.MouseMove -= new MouseEventHandler(this.pnlPopup_MouseMove);
            //this.pnlPopup.MouseUp -= new MouseEventHandler(this.pnlPopup_MouseUp);
        }
        private void PopClick()
        {
            
            DataTable strsql = this.items.GetSearchItems();
            this.grdItems.EndEdit();
            if (strsql.Rows.Count > 0)
            {
                this.grdItems.CurrentRow.Cells[0].Value = strsql.Rows[0]["itemid"];
                this.grdItems.CurrentRow.Cells[1].Value = strsql.Rows[0]["Description"];
               // this.grdItems.CurrentRow.Cells[2].Value = strsql.Rows[0]["unit"];

                DataGridViewComboBoxCell column = (DataGridViewComboBoxCell)grdItems.Rows[grdItems.CurrentCell.RowIndex].Cells[2];
                column.DataSource = units.GetRecord();
                column.DisplayMember = "units";
                column.ValueMember = "units";
                column.Value = strsql.Rows[0]["unit"].ToString();
                

                this.grdItems.CurrentRow.Cells[4].Value = strsql.Rows[0]["price"];
                this.grdItems.CurrentRow.Cells[7].Value = strsql.Rows[0]["salesrate"];
               // this.pnlPopup.Visible = false;
                grdItems.CurrentCell = grdItems.CurrentRow.Cells[3] ;
              
            }
        }
        private bool SetData()
        {
            try
            {
                if (this.validation())
                {
                    if (txtsupplier.SelectedValue != null)
                    {
                        suplier.suplierid = Convert.ToInt64(txtsupplier.SelectedValue.ToString());// Convert.ToInt64(txtcustomer.Text);
                    }
                    else
                    {
                        suplier.suplierid = suplier.GetNextId();
                    }
                    suplier.supliername = txtsupplier.Text;
                    suplier.address = txtaddress.Text;
                    suplier.phonenumber = txtphonenumber.Text;
                    suplier.addeddate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    suplier.openingbalance = Convert.ToDouble(txtopening.Text);

                    if (suplier.GetItems())
                    {
                        suplier.Edit();
                    }
                    else
                    {
                        suplier.Add();
                    }
                    if (suplier.openingbalance!= 0)
                    {
                        generaledger.ledcode = generaledger.GetNextId();
                        generaledger.voucherno = suplier.suplierid.ToString();
                        generaledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.particulars = txtsupplier.Text;
                        if (Convert.ToDouble(txtopening.Text) < 0)
                        {
                            generaledger.Debitamt = 0;
                            generaledger.Creditamt = Convert.ToDouble(txtopening.Text);
                        }
                        else
                        {
                            generaledger.Debitamt = Convert.ToDouble(txtopening.Text);
                            generaledger.Creditamt = 0;
                        }


                        generaledger.Balance = 0;
                        generaledger.VType = "OP";

                        generaledger.DeleteLedger();
                        generaledger.Add();
                    }

                    this.purchase.invoiceno = this.txtinvoice.Text;
                    this.purchase.suplierName = suplier.suplierid.ToString();
                    this.purchase.OppBalance = ((txtopening.Text!="")?Convert.ToDouble(txtopening.Text):0);
                    this.purchase.phonenumber = this.txtphonenumber.Text;
                    this.purchase.address = this.txtaddress.Text;
                    this.purchase.paidcash = Convert.ToDouble(this.txtpaidcash.Text);
                    this.purchase.paidcheque = Convert.ToDouble(this.txtpaidcheque.Text);
                    this.purchase.referenceno = this.txtreferenno.Text;
                    this.purchase.purchasedate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    this.purchase.discount = Convert.ToDouble((this.txtdiscount.Text != "") ? this.txtdiscount.Text : "0");

                    //-------------------------generaLedger----------------------------
                    
                    generaledger.ledcode = generaledger.GetNextId();
                    generaledger.voucherno = txtinvoice.Text;
                    generaledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generaledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generaledger.particulars =txtsupplier.Text;
                    generaledger.Debitamt = Convert.ToDouble(txtnetamount.Text);
                    generaledger.Creditamt = 0;
                    generaledger.Balance =0;
                    generaledger.VType = "PI";

                    generaledger.DeleteLedger();
                    generaledger.Add();

                    generaledger.ledcode = generaledger.GetNextId();
                    generaledger.voucherno = txtinvoice.Text;
                    generaledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generaledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generaledger.particulars ="Purchase Account";
                    generaledger.Debitamt = 0;
                    generaledger.Creditamt = Convert.ToDouble(txtnetamount.Text);
                    generaledger.Balance =0;
                    generaledger.VType = "PI";

                   
                    generaledger.Add();

                    if (txtpaidcash.Text != "0.00")
                    {
                        generaledger.ledcode = generaledger.GetNextId();
                        generaledger.voucherno = txtinvoice.Text;
                        generaledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.particulars =txtsupplier.Text;
                        generaledger.Debitamt = 0;
                        generaledger.Creditamt = Convert.ToDouble(txtpaidcash.Text);
                        generaledger.Balance =0 ;
                        generaledger.VType = "CP";
                        generaledger.DeleteLedger();
                        
                        generaledger.Add();

                        generaledger.ledcode = generaledger.GetNextId();
                        generaledger.voucherno = txtinvoice.Text;
                        generaledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.particulars = "Cash account";
                        generaledger.Debitamt = Convert.ToDouble(txtpaidcash.Text);
                        generaledger.Creditamt =0;
                        generaledger.Balance =0;
                        generaledger.VType = "CP";
                        generaledger.Add();
                    }
                    if (txtpaidcheque.Text != "0.00")
                    {
                        generaledger.ledcode = generaledger.GetNextId();
                        generaledger.voucherno = txtinvoice.Text;
                        generaledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.particulars = txtsupplier.Text;
                        generaledger.Debitamt =0;
                        generaledger.Creditamt = Convert.ToDouble(txtpaidcheque.Text);
                        generaledger.Balance = 0 ;
                        generaledger.VType = "BP";
                        generaledger.DeleteLedger();
                        generaledger.Add();

                        generaledger.ledcode = generaledger.GetNextId();
                        generaledger.voucherno = txtinvoice.Text;
                        generaledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.particulars = "Bank account";
                        generaledger.Debitamt = Convert.ToDouble(txtpaidcheque.Text);
                        generaledger.Creditamt =0;
                        generaledger.Balance =0;
                        generaledger.VType = "BP";
                        generaledger.Add();
                    }
                    //-----------------------------------------------------------------//
                    this.purchase.Delete();
                    this.purchasedetails.DeleteDetails();
                    grdItems.EndEdit();
                    for (int strsql = 0; strsql < (this.grdItems.Rows.Count - 1); strsql++)
                    {
                        this.items.itemid = Convert.ToString(this.grdItems.Rows[strsql].Cells[0].Value);
                        this.items.Description = Convert.ToString(this.grdItems.Rows[strsql].Cells[1].Value);
                        this.items.Price = Convert.ToDouble(Convert.ToString(this.grdItems.Rows[strsql].Cells[4].Value));
                        this.items.salesrate = (this.grdItems.Rows[strsql].Cells[7].Value != null) ? Convert.ToDouble(Convert.ToString(this.grdItems.Rows[strsql].Cells[7].Value)) : 0.0;
                        this.items.Unit = Convert.ToString(grdItems.Rows[strsql].Cells[2].Value);
                        if (this.items.GetItems())
                        {
                            this.items.Edit();
                        }
                        else
                        {
                            this.items.Add();
                        }
                        if (this.grdItems.Rows[strsql].Cells[8].Value != null)
                        {
                            this.purchasedetails.purchaseid = Convert.ToInt64(this.grdItems.Rows[strsql].Cells[8].Value.ToString());
                        }
                        else
                        {
                            this.purchasedetails.purchaseid = this.purchasedetails.GetNextId();
                        }
                        this.purchasedetails.invoiceno = this.txtinvoice.Text;
                        this.purchasedetails.itemid = this.items.itemid;
                        this.purchasedetails.quantity = Convert.ToDouble(this.grdItems.Rows[strsql].Cells[3].Value);
                        this.purchasedetails.Price = Convert.ToDouble(Convert.ToString(this.grdItems.Rows[strsql].Cells[4].Value));
                        this.purchasedetails.unit = Convert.ToString(this.grdItems.Rows[strsql].Cells[2].Value);
                        if (this.purchasedetails.GetItems())
                        {
                            this.purchasedetails.Edit();
                        }
                        else
                        {
                            this.purchasedetails.Add();
                        }
                    }
                    return true;
                }
                return false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }
        private void SetNetAmt(int rowindex, string quantity)
        {
            try
            {
                string strsql = Convert.ToString(this.grdItems.Rows[rowindex].Cells[4].Value);
                quantity = (quantity == "") ? "0" : quantity;
                strsql = (strsql == "") ? "0" : strsql;
                this.grdItems.Rows[rowindex].Cells[5].Value = Convert.ToDouble(quantity) * Convert.ToDouble(strsql);
                this.txtnetamount.Text = this.purchase.CalcNetAmt(this.grdItems, this.txtdiscount.Text);
               // if (txtpaidcash.Text == "0.00")
              //  {
                    txtpaidcash.Text = txtnetamount.Text;
                    txtpaidcheque.Text = "0.00";
              //  }
                
                this.txttotitem.Text = this.purchase.CalcTotalItem(this.grdItems);
                this.CalcBalance();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void ShowPopup(string itemid,string descr)
        {
            if (itemid != "")
            {
                this.items.itemid = itemid;
            }
            else if (descr != "")
            {
                items.Description = descr;
            }
            DataTable quantity = this.items.SearchProduct();
           // this.grdpopup.DataSource = quantity;
            Point p = new Point();
            p = grdItems.Location;
            int rowcount = grdItems.Rows.Count+1;
            int height = grdItems.Rows[0].Height*rowcount;
            p.X = 150;
            if (height > grdItems.Height)
            {
                height = grdItems.Height;
            }
            p.Y = p.Y+ height;
           // pnlPopup.Location = p;
            if (quantity.Rows.Count > 0)
            {
              
               // this.pnlPopup.Visible = true;
              
               
            }
        }
        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
           txtnetamount.Text= this.purchase.CalcNetAmt(this.grdItems, this.txtdiscount.Text);
           txtpaidcash.Text = txtnetamount.Text;
            this.CalcBalance();
        }
        private void txtinvoice_Leave(object sender, EventArgs e)
        {
            this.AddSelRecord();
        }
        private void txtinvoice_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           // MessageBox.Show("entter");
        }
        private void txtinvoice_TextChanged(object sender, EventArgs e)
        {
            this.AddSelRecord();
            this.errorProvider.Clear();
        }
        private void txtitem_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            this.ShowPopup(box.Text,"");
        }
        private void txtpaidcash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == '\r')
                if (this.ActiveControl != null)
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
            e.Handled = true;
        }
        private void txtpaidcash_Leave(object sender, EventArgs e)
        {
            this.CalcBalance();
        }
        private void txtpaidcheque_Leave(object sender, EventArgs e)
        {
            this.CalcBalance();
        }
        private bool validation()
        {
            if (this.txtsupplier.Text.Trim() == "")
            {
                this.errorProvider.SetError(this.txtsupplier, "Supplier Name is required");
                return false;
            }
           
            
            if (this.txtpaidcash.Text.Trim() == "")
            {
                this.errorProvider.SetError(this.txtpaidcash, "Paid Cash required");
                this.errorProvider.RightToLeft = true;
                return false;
            }
            if (this.grdItems.Rows.Count == 1)
            {
                this.grdItems.Rows[0].Cells[0].Style.BackColor = Color.Red;
                this.grdItems.BeginEdit(true);
                return false;
            }
            foreach (DataGridViewRow row in grdItems.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (row.IsNewRow)
                    {
                        return true;
                    }
                    if (((cell.Value == null) && (cell.ColumnIndex != 7)) && (cell.ColumnIndex != 8))
                    {
                        cell.Style.BackColor = Color.Red;
                        this.grdItems.BeginEdit(true);
                        return false;
                    }
                    cell.Style.BackColor = row.DefaultCellStyle.BackColor;
                }
            }
            return false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptPurchaseInv rpt = new rptPurchaseInv();
            rpt.MdiParent = this.MdiParent;
            rpt.invioceno = txtinvoice.Text;
            rpt.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void frmpurchaseinvoice_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void grdItems_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void grdItems_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.HeaderCell.Value = Convert.ToString(e.Row.Index + 1);
        }
        
        private void grdItems_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                frmPopUp frmpop = new frmPopUp(true);
                frmpop.purchase = true;
                frmpop.ShowDialog();
                items.itemid = frmpop.itemid;
                items.Description = frmpop.desc;
               
                //grdsales.Rows[grdsales.CurrentCell.RowIndex].Cells[grdsales.CurrentCell.ColumnIndex].ReadOnly = true;
                if (items.itemid != null || items.Description != null)
                {
                    PopClick();
                }
                e.Cancel = true;
            }
            else if (e.ColumnIndex == 2)
            {
                DataGridViewComboBoxCell column = (DataGridViewComboBoxCell)grdItems.Rows[e.RowIndex].Cells[2];

                column.DataSource = units.GetRecord();
                column.DisplayMember = "units";
                column.ValueMember = "units";
            }
        }

        private void txtsupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtsupplier.Text != "System.Data.DataRowView")
            {
                suplier.suplierid = Convert.ToInt32(txtsupplier.SelectedValue.ToString());
                DataTable dt = suplier.GetSelRecord();
                if (dt.Rows.Count > 0)
                {
                    //txtcustomername.Text = dt.Rows[0]["customername"].ToString();
                    txtphonenumber.Text = dt.Rows[0]["phonenumber"].ToString();
                    txtaddress.Text = dt.Rows[0]["address"].ToString();
                    txtopening.Text = dt.Rows[0]["openingbalance"].ToString();
                }
                else
                {
                    txtsupplier.Text = "";
                    txtphonenumber.Text = "";
                    txtaddress.Text = "";
                    txtopening.Text = "0.0";
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private bool nonNumberEntered = false;
        private void txtinvoice_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad. 
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace. 
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed. 
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void txtinvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void txtsupplier_Leave(object sender, EventArgs e)
        {
            if (txtsupplier.SelectedValue == null)
            {
                txtphonenumber.Text = "";
                txtaddress.Text = "";
                txtopening.Text = "0.0";
            }
        }

        private void txtsupplier_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
