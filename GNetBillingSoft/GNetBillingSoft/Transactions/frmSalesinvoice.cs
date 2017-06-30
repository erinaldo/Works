using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft.Transactions
{
    public partial class frmSalesinvoice : Form
    {
        clssalesinvoice sales = new clssalesinvoice();
        clspurchasedetails purchasedetails = new clspurchasedetails();
        clssalesdetails salesdetails=new clssalesdetails();
        clsitemdetails items = new clsitemdetails();
        clsgeneralledger generalledger = new clsgeneralledger();
        clscustomerdetails customer = new clscustomerdetails();
        clsunits units = new clsunits();
        //private Point Start;
        public static string itemsid;
        public static string desc;
        
        public frmSalesinvoice()
        {
            InitializeComponent();
            txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
            AddInvoice();
           
            txtphoneno.PromptChar=' ';
            txtinvoice.Focus();
            grdsales.Rows[0].HeaderCell.Value = "1";

            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
         
        }

        private void Arabic()
        {
            //Label
            this.lblVoucherNo.Text = "رقم القسيمة";
            this.lblAddr.Text = "عنوان";
            this.lblCustName.Text = "العميل";
            this.lblPhone.Text = "رقم الهاتف";
            this.lblDate.Text = "التاريخ";

            this.lblNetAmt.Text = "الصافى";
            this.lblBal.Text = "رصيد";
            this.lblTotPaid.Text = "مجموع المبالغ المدفوعة";
            this.lblPaidCheq.Text = "شيك مدفوع";
            this.lblPaidCash.Text = "النقدية المدفوعة";
            this.lblAdDiscount.Text = "خصم إضافي";
            this.lblDiscount.Text = "خصم";
            this.lblTotItem.Text = "(اجمالى المواد(الاصناف";
            this.lblCOpening.Text = "افتتاح العملاء";
            this.lblNetAmt.Text = "الصافى";
     
            
            //DataGrid
            this.itemno.HeaderText = "رقم الصنف";
            this.description.HeaderText = "الوصف";
            this.unit.HeaderText = "وحدة";
            this.quantity.HeaderText = "الكمية";
            this.price.HeaderText = "السعر";
            this.total.HeaderText = "الاجمالى";
            this.netamount.HeaderText = "الصافى";
            this.stock.HeaderText = "المخزون";
            this.newcost.HeaderText = "التكلفة الجديدة";


            //Button
            this.btnmainclose.Text = "اقفال";
            this.btnDelete.Text = "الغاء";
            this.btnedit.Text = "تحرير";
            this.btnSave.Text = "حفظ";
            this.btnprint.Text = "طباعة";
            this.btnClear.Text = "واضح";

            this.chkPrint.Text = "اطبع أثناء الحفظ";
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
            DataTable dt = sales.GetIds();
            txtinvoice.Items.Clear();
            if (dt.Rows.Count != 0)
            {
                txtinvoice.Items.Add(sales.GetNextId().ToString());
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtinvoice.Items.Add(dt.Rows[i]["salesinvoice"].ToString());
                }
                txtinvoice.SelectedIndex = 0;
            }
            else
            {
                txtinvoice.Text = sales.GetNextId().ToString();
            }
            txtinvoice.Focus();
            DataTable dtcus = customer.GetRecord();
            txtcustomername.DataSource = dtcus;
            txtcustomername.DisplayMember = "customername";
            txtcustomername.ValueMember = "customerid";
            //txtcustomername.SelectedIndex = -1;
            txtcustomername.SelectedIndexChanged += new EventHandler(txtcustomername_SelectedIndexChanged);
            //txtcustomername.LostFocus += new EventHandler(txtcustomername_LostFocus);
            
        }

        void txtcustomername_LostFocus(object sender, EventArgs e)
        {
            if (txtcustomername.SelectedValue != null)
            {

                customer.customerid = Convert.ToInt32(txtcustomername.SelectedValue.ToString());
                DataTable dt = customer.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    txtcustomername.Text = dt.Rows[0]["customername"].ToString();
                    txtphoneno.Text = dt.Rows[0]["phonenumber"].ToString();
                    txtaddress.Text = dt.Rows[0]["address"].ToString();
                    txtopening.Text = dt.Rows[0]["cusopening"].ToString();
                }
                else
                {

                    txtcustomername.Text = "";
                    txtphoneno.Text = "";
                    txtaddress.Text = "";
                    txtopening.Text = "0.0";
                }
            }
        }
         
        void txtcustomername_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtcustomername.SelectedValue != null)
            {

                customer.customerid = Convert.ToInt32(txtcustomername.SelectedValue.ToString());
                DataTable dt = customer.GetSelRecord();
                if (dt.Rows.Count > 0)
                {
                    //txtcustomername.Text = dt.Rows[0]["customername"].ToString();
                    txtphoneno.Text = dt.Rows[0]["phonenumber"].ToString();
                    txtaddress.Text = dt.Rows[0]["address"].ToString();
                    txtopening.Text = dt.Rows[0]["cusopening"].ToString();
                }
                else
                {

                    txtcustomername.Text = "";
                    txtphoneno.Text = "";
                    txtaddress.Text = "";
                    txtopening.Text = "0.0";
                }
            }
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            CalcBalance();
        }


      //  private DataGridViewComboBoxEditingControl editingcombo;
        private DataGridViewTextBoxEditingControl editingControl;
        private void grdsales_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //if (e.Control is ComboBox)
            //{
            //    DataGridViewComboBoxEditingControl editingcombo = (DataGridViewComboBoxEditingControl)e.Control;
            //    editingcombo.DropDownStyle = ComboBoxStyle.DropDown;

            //    //editingcombo.TextChanged += new EventHandler(editingcombo_TextChanged);
            //}
            //else
            //{
            //    editingControl = (DataGridViewTextBoxEditingControl)e.Control;
            //}
           // editingControl.TextChanged += new EventHandler(editingControl_TextChanged);
           // editingControl.KeyPress += new KeyPressEventHandler(editingControl_KeyPress);
          // editingControl.KeyDown += new KeyEventHandler(editingControl_KeyDown);
        }

        void editingcombo_TextChanged(object sender, EventArgs e)
        {
            grdsales.NotifyCurrentCellDirty(true);
        }

        void editingControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (grdsales.CurrentCell.ColumnIndex == 0)
                {
                    /*frmpopup frmpop = new frmpopup();
                    frmpop.ShowDialog();
                    items.itemid = itemsid;
                    items.Description = desc;
                    grdsales.EndEdit();
                    PopClick();*/
                   
                }
                
            }
        }

        void editingControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl txt = (DataGridViewTextBoxEditingControl)sender;
            DataGridView grd = txt.EditingControlDataGridView;
            int n = grd.CurrentCell.ColumnIndex;
            if (n == 3)
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    if (!char.IsNumber(e.KeyChar))
                    {

                        e.Handled = true;

                    }
                }
            }
            else if (n == 4)
            {
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)'.')
                {
                    if (!char.IsNumber(e.KeyChar))
                    {

                        e.Handled = true;

                    }
                }
            }
        }
        void editingControl_TextChanged(object sender, EventArgs e)
        {
            DataGridViewTextBoxEditingControl txt = (DataGridViewTextBoxEditingControl)sender;
            DataGridView grd = txt.EditingControlDataGridView;
            int n = grd.CurrentCell.ColumnIndex;
            if (n == 0 ||n==1)
            {
                //ShowPopup(txt.Text);
            }
           
             else if (n == 3)
            {
                //SetNetAmt(grd.CurrentCell.RowIndex,txt.Text);
            }
            else
            {
                //pnlPopup.Visible = false;
            }
        }
        
        private void PopClick()
        {
            DataTable dt = items.SearchItems();
            grdsales.EndEdit();
            if (dt.Rows.Count > 0)
            {
                grdsales.CurrentRow.Cells[0].Value = dt.Rows[0]["Itemid"];

                grdsales.CurrentRow.Cells[1].Value = dt.Rows[0]["Description"];
               // grdsales.CurrentRow.Cells[2].Value = dt.Rows[0]["unit"];

                DataGridViewComboBoxCell column = (DataGridViewComboBoxCell)grdsales.Rows[grdsales.CurrentCell.RowIndex].Cells[2];
                column.DataSource = units.GetRecord();
                column.DisplayMember = "units";
                column.ValueMember = "units";
                column.Value = dt.Rows[0]["unit"].ToString();
           
                grdsales.CurrentRow.Cells[4].Value = dt.Rows[0]["Price"];
                grdsales.CurrentRow.Cells[7].Value = dt.Rows[0]["Stock"];
                grdsales.CurrentRow.Cells[8].Value = dt.Rows[0]["Cost"];
                //grdsales.CurrentRow.Cells[3].Value = "1";
                grdsales.CurrentCell = grdsales.CurrentRow.Cells[3];
            }
           
           
        }
        private double CalculateStock(string itemid)
        {
            purchasedetails.itemid = itemid;
            double quantity = 0; double stock = purchasedetails.GetStock();
            if (grdsales.Rows.Count > 1)
            {
                //stock = Convert.ToDouble((grdsales.CurrentRow.Cells[7].Value != null && Convert.ToString(grdsales.CurrentRow.Cells[7].Value)!="") ?Convert.ToString(grdsales.CurrentRow.Cells[7].Value) : "0");
                for (int i = 0; i < grdsales.Rows.Count; i++)
                {
                    if (Convert.ToString(grdsales.Rows[i].Cells[0].Value) == itemid)
                    {
                        quantity +=Convert.ToDouble(Convert.ToString((grdsales.Rows[i].Cells[3].Value!=null)?grdsales.Rows[i].Cells[3].Value:"0"));
                    }
                }
                grdsales.CurrentRow.Cells[7].Value = stock - quantity;
            }


            return stock;
        }
            
        private void grdsales_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 )
            {
                string itemid = Convert.ToString(grdsales.Rows[e.RowIndex].Cells[0].Value);
                string descri = Convert.ToString(grdsales.Rows[e.RowIndex].Cells[1].Value);
                items.itemid = itemid;
                items.Description = descri;
                //if (items.GetItems())
               // {
                if (itemid != "")
                {
                   // PopClick(e.RowIndex, itemid);
                }
                else if (descri != "")
                {
                    //PopClick(e.RowIndex, descri);
                }
              //  }
            }
            else if (e.ColumnIndex == 1)
            {
                string itemid = Convert.ToString(this.grdsales.Rows[e.RowIndex].Cells[0].Value);
                string descri = Convert.ToString(grdsales.Rows[e.RowIndex].Cells[1].Value);
                if (itemid == "")
                {
                    items.Description = Convert.ToString(grdsales.Rows[e.RowIndex].Cells[1].Value);
                    DataTable dt = items.SearchProduct();
                    if (dt.Rows.Count == 0)
                    {
                        if (items.TempId == null)
                        {

                            this.grdsales.Rows[e.RowIndex].Cells[0].Value = items.GetNextId();
                            items.TempId = items.GetNextId();
                        }
                        else
                        {
                            long tmpid = Convert.ToInt64(items.TempId) + 1;
                            this.grdsales.Rows[e.RowIndex].Cells[0].Value = tmpid.ToString();
                            items.TempId = tmpid.ToString();
                        }
                    }
                    else
                    {
                        if (itemid != "")
                        {
                            //PopClick(e.RowIndex, itemid);
                        }
                        else if (descri != "")
                        {
                           // PopClick(e.RowIndex, descri);
                        }
                    }
                }
               
            }
           
        }
        private bool validation()
        {
            
            
            if (txtcustomername.Text.Trim() == "")
            {
                errorSalesinvoice.SetError(txtcustomername, "Customer name is required");
                return false;

            }
            
            foreach (DataGridViewRow row in grdsales.Rows)
            {

                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Validating cell value
                    
                    if (row.IsNewRow) { return true; }
                    if (cell.Value == null && cell.ColumnIndex != 8 && cell.ColumnIndex != 7)
                    {
                        cell.Style.BackColor = Color.Red;

                        grdsales.BeginEdit(true);
                        return false;
                    }
                    else
                    {
                        cell.Style.BackColor = row.DefaultCellStyle.BackColor;
                    }
                }
            }
            return false;
        }

        private void grdsales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Rows.Count > 1 )
            {
                string quantity = (dgv.Rows[e.RowIndex].Cells[3].Value != null) ? Convert.ToString(dgv.Rows[e.RowIndex].Cells[3].Value) : "0";

                SetNetAmt(e.RowIndex, quantity);
                CalcBalance();

                if (e.ColumnIndex == 3)
                {
                    //grdsales.CurrentCell = grdsales.CurrentRow.Cells[4];
                }
            }
        }
        private void SetNetAmt(int rowindex, string quantity)
        {
            try
            {
                //string quantity = Convert.ToString(grdItems.Rows[rowindex].Cells[3].Value);
                string price = (Convert.ToString(grdsales.Rows[rowindex].Cells[4].Value));
                quantity = (quantity == "") ? "0" : quantity;
                price = (price == "") ? "0" : price;
                grdsales.Rows[rowindex].Cells[5].Value = Convert.ToDouble(quantity) * Convert.ToDouble(price);
                double discount =(txtdiscount.Text!="")? Convert.ToDouble(txtdiscount.Text): 0;
                double addiscount =(txtadddiscount.Text!="")? Convert.ToDouble(txtadddiscount.Text):0;
                // discount =discount +addiscount;
                txtnetamt.Text = sales.CalcNetAmt(grdsales,discount.ToString());
                 txtpaidcash.Text = txtnetamt.Text;
               
                txttotalitem.Text = sales.CalcTotalItem(grdsales);



                CalcBalance();
                CalcDiscAmount();
                
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void CalcBalance()
        {
            try
            {
                double paidcash = (txtpaidcash.Text != "") ? Convert.ToDouble(txtpaidcash.Text) : 0;
                double paidcheque = (txtpaidcheque.Text != "") ? Convert.ToDouble(txtpaidcheque.Text) : 0;
                double netamt = (txtnetamt.Text != "") ? Convert.ToDouble(txtnetamt.Text) : 0;
                double balance = 0;
                txtpaidcash.Text = paidcash.ToString("0.00");
                txtpaidcheque.Text = paidcheque.ToString("0.00");
                balance = (paidcheque + paidcash) - netamt;
                txttotalpaid.Text = (paidcheque + paidcash).ToString("0.00");

                txtbalance.Text = balance.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            double discount = (txtdiscount.Text != "") ? Convert.ToDouble(txtdiscount.Text) : 0;
            double adddiscount=(txtadddiscount.Text!="")?Convert.ToDouble(txtadddiscount.Text):0;
            
           txtnetamt.Text=sales.CalcNetAmt(grdsales,discount.ToString());
           txtpaidcash.Text = txtnetamt.Text;

            CalcBalance();
            CalcDiscAmount();
        }
        private void CalcDiscAmount()
        {
            double totalamount = 0;
            double discount = (txtdiscount.Text == "") ? 0 : Convert.ToDouble(txtdiscount.Text);
            for (int i = 0; i < grdsales.Rows.Count - 1; i++)
            {
                totalamount += Convert.ToDouble(grdsales.Rows[i].Cells[5].Value.ToString());

            }
            if (totalamount == 0) return;
            if (discount == 0 || discount.ToString() == "")
                txtdiscamount.Text = "";
            else
                txtdiscamount.Text = ((totalamount * discount) / 100).ToString();

        }
      
        private void txtpaidcash_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtpaidcash_Leave(object sender, EventArgs e)
        {
            CalcBalance();
        }
        private void AddSelRecord()
        {
            sales.salesinvoice = txtinvoice.Text;
            salesdetails.invoiceno = txtinvoice.Text;
            DataTable dt = sales.GetSelRecord();
           
            grdsales.CausesValidation = false;
            grdsales.Rows.Clear();
            

            if (dt.Rows.Count != 0)
            {

                customer.customerid = Convert.ToInt64(dt.Rows[0]["customerid"]);
                DataTable dtcus = customer.GetSelRecord();
                DataTable dtPur = salesdetails.GetSelRecord();

                for (int i = 0; i < dtPur.Rows.Count; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)grdsales.Rows[0].Clone();

                    row.Cells[0].Value = dtPur.Rows[i]["itemid"];
                    row.Cells[1].Value = dtPur.Rows[i]["Description"];
                    //row.Cells[2].Value = dtPur.Rows[i]["unit"];

                    DataGridViewComboBoxCell column = (DataGridViewComboBoxCell)row.Cells[2];
                    column.DataSource = units.GetRecord();
                    column.DisplayMember = "units";
                    column.ValueMember = "units";
                    column.Value = dtPur.Rows[i]["unit"].ToString();
                    

                    row.Cells[3].Value = dtPur.Rows[i]["quantity"];
                    row.Cells[4].Value = dtPur.Rows[i]["salesrate"];
                    double total = Convert.ToDouble(dtPur.Rows[i]["quantity"].ToString()) * Convert.ToDouble(dtPur.Rows[i]["Price"].ToString());
                    row.Cells[5].Value = total;
                    row.Cells[7].Value = dtPur.Rows[i]["supplier"];
                    // double discount =(txtdiscount.Text!="")?Convert.ToDouble(txtdiscount.Text):0;

                    //double netamt=
                    //row.Cells[7].Value = dtPur.Rows[i]["oldprice"];
                    row.Cells[8].Value = dtPur.Rows[i]["newcost"];
                    grdsales.Rows.Add(row);
                    grdsales.Rows[i].HeaderCell.Value = Convert.ToString(i + 1);
                    

                }
                txtcustomername.Text = dtcus.Rows[0]["customername"].ToString();
                txtaddress.Text = dtcus.Rows[0]["address"].ToString();
                txtphoneno.Text = dtcus.Rows[0]["phonenumber"].ToString();
                txtopening.Text = dtcus.Rows[0]["cusopening"].ToString();
                txtdate.Text = Convert.ToDateTime(dt.Rows[0]["salesdate"].ToString()).ToString("dd/MM/yyyy");
                
                txtdiscount.Text = dt.Rows[0]["discount"].ToString();
                txtadddiscount.Text = dt.Rows[0]["additionaldiscount"].ToString();
                txtpaidcash.Text = dt.Rows[0]["paidcash"].ToString();
                txtpaidcheque.Text = dt.Rows[0]["paidcheque"].ToString();
                DisableControls(false);
            }
            else
            {

                txtcustomername.Text = "";
                txtphoneno.Text = "";
                txtaddress.Text = "";
                txtopening.Text = "0.0";
                txtdiscount.Text = "";
                txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txtpaidcash.Text = "";
                txtpaidcheque.Text = "";
                txtadddiscount.Text = "";
                grdsales.Rows.Clear();
                grdsales.Rows[0].HeaderCell.Value = "1";
                DisableControls(true);
            }
            double discount = (txtdiscount.Text != "") ? Convert.ToDouble(txtdiscount.Text) : 0;
            double addiscount=(txtadddiscount.Text!="")?Convert.ToDouble(txtadddiscount.Text):0;
            //discount = discount + addiscount;
            //txtnetamt.Text=sales.CalcNetAmt(grdsales,discount.ToString());
            CalcBalance();
        }
        private void DisableControls(bool enabled)
        {

            foreach (Control c in this.Controls)
            {
                if (c is GroupBox)
                {

                    foreach (Control grpcnt in c.Controls)
                    {
                        if (grpcnt != txtinvoice && grpcnt != btnmainclose && !(grpcnt is Label))
                        {
                            grpcnt.Enabled = enabled;
                            if (!(grpcnt is Button))
                            {
                                grpcnt.BackColor = SystemColors.ControlLightLight;
                            }
                        }
                        if (grpcnt == btnedit || grpcnt == btnDelete || grpcnt == btnprint)
                        {
                            grpcnt.Enabled = !enabled;
                        }
                    }
                }
                else
                {
                    if (!(c is Label))
                    {
                        c.Enabled = enabled;
                        c.BackColor = SystemColors.ControlLightLight;
                    }
                }
            }

        }

        private void txtinvoice_TextChanged(object sender, EventArgs e)
        {
            AddSelRecord();
            errorSalesinvoice.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SetData())
            {
                sales.Add();
                if (chkPrint.Checked)
                {
                    rptSalesInvoice rptsales = new rptSalesInvoice();
                    rptsales.invoice = txtinvoice.Text;
                    rptsales.MdiParent = this.MdiParent;
                    rptsales.Show();
                }
                Clear();
            }
        }
        private bool SetData()
        {
            try
            {
                if (validation())
                {

                    //------------------------general Ledger -------------------------------------
                    generalledger.ledcode = generalledger.GetNextId();
                    generalledger.voucherno = txtinvoice.Text;
                    generalledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generalledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generalledger.particulars = txtcustomername.Text;
                    generalledger.Debitamt = Convert.ToDouble(txtnetamt.Text);
                    generalledger.Creditamt = 0;
                    generalledger.Balance = 0;
                    generalledger.VType = "SI";

                    generalledger.DeleteLedger();
                    generalledger.Add();

                    //generalledger.ledcode = generalledger.GetNextId();
                    //generalledger.voucherno = txtinvoice.Text;
                    //generalledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    //generalledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    //generalledger.particulars = "Sales Account";
                    //generalledger.Debitamt =Convert.ToDouble(txtnetamt.Text);
                    //generalledger.Creditamt =0 ;
                    //generalledger.Balance = 0;
                    //generalledger.VType = "SI";


                    //generalledger.Add();

                    if (txtpaidcash.Text != "0.00")
                    {

                        generalledger.ledcode = generalledger.GetNextId();
                        generalledger.voucherno = txtinvoice.Text;
                        generalledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generalledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generalledger.particulars = txtcustomername.Text;
                        generalledger.Debitamt = 0;
                        generalledger.Creditamt = Convert.ToDouble(txtpaidcash.Text);
                        generalledger.Balance = 0;
                        generalledger.VType = "CR";
                        generalledger.DeleteLedger();
                        generalledger.Add();

                        //generalledger.ledcode = generalledger.GetNextId();
                        //generalledger.voucherno = txtinvoice.Text;
                        //generalledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        //generalledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        //generalledger.particulars = "Cash Account";
                        //generalledger.Debitamt = 0;
                        //generalledger.Creditamt = Convert.ToDouble(txtpaidcash.Text); ;
                        //generalledger.Balance = 0;
                        //generalledger.VType = "CR";
                        //generalledger.Add();
                    }
                    if (txtpaidcheque.Text != "0.00")
                    {
                        generalledger.ledcode = generalledger.GetNextId();
                        generalledger.voucherno = txtinvoice.Text;
                        generalledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generalledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generalledger.particulars = txtcustomername.Text;
                        generalledger.Debitamt = 0;
                        generalledger.Creditamt = Convert.ToDouble(txtpaidcheque.Text);
                        generalledger.Balance = 0;
                        generalledger.VType = "BR";
                        generalledger.DeleteLedger();
                        generalledger.Add();

                        //generalledger.ledcode = generalledger.GetNextId();
                        //generalledger.voucherno = txtinvoice.Text;
                        //generalledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        //generalledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        //generalledger.particulars = "Bank Account";
                        //generalledger.Debitamt = 0;
                        //generalledger.Creditamt = Convert.ToDouble(txtpaidcheque.Text); ;
                        //generalledger.Balance = 0;
                        //generalledger.VType = "BR";
                        //generalledger.Add();
                    }
                    //---------------------------------------------------------------------------------------
                    clstokensettings.GetNextToken();
                    sales.salesinvoice = txtinvoice.Text;
                    if (txtcustomername.SelectedValue != null)
                    {
                        customer.customerid = Convert.ToInt64(txtcustomername.SelectedValue.ToString());// Convert.ToInt64(txtcustomer.Text);
                    }
                    else
                    {
                        customer.customerid = customer.GetNextId();
                    }
                    customer.customername = txtcustomername.Text;
                    customer.address = txtaddress.Text;
                    customer.phonenumber = txtphoneno.Text;
                    customer.addeddate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    customer.CusOpening = Convert.ToDouble(txtopening.Text);

                    if (customer.GetItems())
                    {
                        customer.Edit();
                    }
                    else
                    {
                        customer.Add();
                    }
                    if (customer.CusOpening != 0)
                    {
                        generalledger.ledcode = generalledger.GetNextId();
                        generalledger.voucherno = customer.customerid.ToString();
                        generalledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generalledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generalledger.particulars = txtcustomername.Text;
                        if (Convert.ToInt64(txtopening.Text) < 0)
                        {
                            generalledger.Debitamt = 0;
                            generalledger.Creditamt = Convert.ToDouble(txtopening.Text);
                        }
                        else
                        {
                            generalledger.Debitamt = Convert.ToDouble(txtopening.Text);
                            generalledger.Creditamt = 0;
                        }


                        generalledger.Balance = 0;
                        generalledger.VType = "OP";

                        generalledger.DeleteLedger();
                        generalledger.Add();
                    }
                    sales.salesdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    sales.customerid = customer.customerid;
                    sales.discount = Convert.ToDouble((txtdiscount.Text != "") ? txtdiscount.Text : "0");
                    sales.additionaldiscount = Convert.ToDouble((txtadddiscount.Text != "") ? txtadddiscount.Text : "0");
                    sales.paidcash = Convert.ToDouble((txtpaidcash.Text != "") ? txtpaidcash.Text : "0");
                    sales.paidcheque = Convert.ToDouble((txtpaidcheque.Text != "") ? txtpaidcheque.Text : "0");
                    sales.UserId = clsuserinfo.UID;
                    sales.Delete();
                    salesdetails.DeleteDetails();
                    grdsales.EndEdit();
                    for (int i = 0; i < grdsales.Rows.Count - 1; i++)
                    {

                        salesdetails.salesid = salesdetails.GetNextId();
                        salesdetails.invoiceno = txtinvoice.Text;
                        salesdetails.itemid = Convert.ToString(grdsales.Rows[i].Cells[0].Value);
                        salesdetails.quantity = Convert.ToDouble(grdsales.Rows[i].Cells[3].Value);
                        salesdetails.unit = Convert.ToString(grdsales.Rows[i].Cells[2].Value);
                        salesdetails.Supplier = Convert.ToString(grdsales.Rows[i].Cells[7].Value);
                        salesdetails.SalesRate = Convert.ToDouble(grdsales.Rows[i].Cells[4].Value);
                        salesdetails.NewCost = Convert.ToDouble(grdsales.Rows[i].Cells[8].Value);
                        salesdetails.Add();
                        /* items.itemid = salesdetails.itemid;
                         items.salesrate = Convert.ToDouble(grdsales.Rows[i].Cells[4].Value);
                         items.EditSalesRate();*/
                        this.items.itemid = Convert.ToString(this.grdsales.Rows[i].Cells[0].Value);
                        this.items.Description = Convert.ToString(this.grdsales.Rows[i].Cells[1].Value);
                        this.items.salesrate = Convert.ToDouble(Convert.ToString(this.grdsales.Rows[i].Cells[4].Value));
                        this.items.Price = Convert.ToDouble(Convert.ToString(this.grdsales.Rows[i].Cells[8].Value));
                        this.items.Unit = Convert.ToString(grdsales.Rows[i].Cells[2].Value);
                        if (this.items.GetItems())
                        {
                            this.items.Edit();
                        }
                        else
                        {
                            this.items.Add();
                        }
                    }


                    return true;
                }
                return false;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return false;
            }

        }
        
        private void btnedit_Click(object sender, EventArgs e)
        {
            DisableControls(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String Msg = (Properties.Settings.Default.Lang == "Arabic") ? "هل تريد حذف" : "Do you want delete";
            if (MessageBox.Show(Msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                sales.salesinvoice = txtinvoice.Text;
                sales.Delete();

                salesdetails.invoiceno = txtinvoice.Text;
                salesdetails.DeleteDetails();

                Clear();
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            rptSalesInvoice frm = new rptSalesInvoice();
            mainmdi main = new mainmdi();
            frm.invoice = txtinvoice.Text;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtcustomername.Text = string.Empty;
            txtphoneno.Text = string.Empty;
            txtaddress.Text = string.Empty;
            txttotalitem.Text = string.Empty;
            txttotalpaid.Text = string.Empty;
            txtpaidcash.Text = string.Empty;
            txtpaidcheque.Text = string.Empty;
            txtdiscount.Text = string.Empty;
            txtadddiscount.Text = string.Empty;
            txtnetamt.Text = string.Empty;
            txtnetamt.Text = "0.00";
            grdsales.Rows.Clear();
            txtdiscamount.Text = string.Empty;
            txtinvoice.Text = sales.GetNextId().ToString();
            txtopening.Text = "0.0";
            AddInvoice();
            DisableControls(true);
        }

        private void btnmainclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtinvoice_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void grdsales_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            
            e.Row.HeaderCell.Value = Convert.ToString(e.Row.Index+1);
           
        }

        private void grdsales_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void grdsales_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            /*DataGridView gridView = sender as DataGridView;

            if (null != gridView)
            {
                gridView.Rows[e.RowIndex].HeaderCell.Value = "2009";
            }*/
        }
        
        private void grdsales_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                frmPopUp frmpop = new frmPopUp();
                frmpop.ShowDialog();
                items.itemid = frmpop.itemid;
                items.Description = frmpop.desc;
                //grdsales.Rows[grdsales.CurrentCell.RowIndex].Cells[grdsales.CurrentCell.ColumnIndex].ReadOnly = true;
                if (items.itemid != null || items.Description != null)
                    PopClick();
                e.Cancel = true;
            }
            else if (e.ColumnIndex == 2)
            {
                DataGridViewComboBoxCell column = (DataGridViewComboBoxCell)grdsales.Rows[e.RowIndex].Cells[2];

                column.DataSource = units.GetRecord();
                column.DisplayMember = "units";
                column.ValueMember = "units";
               
            }
        }

        private void grdsales_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void frmSalesinvoice_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void grdsales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Clear();
            }
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtadddiscount_TextChanged(object sender, EventArgs e)
        {

            //double discount = (txtdiscount.Text!="") ? Convert.ToDouble(txtdiscount.Text) : 0;
            //double addiscount=(txtdiscount.Text!="")?Convert.ToDouble(txtadddiscount.Text):0;
            //discount = discount + addiscount;
            //sales.CalcNetAmt(grdsales,discount.ToString());
            //CalcBalance();
        }

        private void txtcustomername_Leave(object sender, EventArgs e)
        {
            if (txtcustomername.SelectedValue == null)
            {
                txtphoneno.Text = "";
                txtaddress.Text = "";
                txtopening.Text = "0.0";
            }
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

        private void txtdiscount_KeyDown(object sender, KeyEventArgs e)
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

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Return)
            {
                if (e.KeyChar == '\r')
                    if (this.ActiveControl != null)
                        this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void txtdiscamount_TextChanged(object sender, EventArgs e)
        {
            double totalamount = 0;
            
            for (int i = 0; i < grdsales.Rows.Count-1; i++)
            {
                totalamount += Convert.ToDouble(grdsales.Rows[i].Cells[5].Value.ToString());
            }
            if (totalamount == 0) return;
            double discamount = (txtdiscamount.Text != "") ? Convert.ToDouble(txtdiscamount.Text) : 0;
            if (discamount == 0 || discamount.ToString()=="") 
                txtdiscount.Text = "";
            else
                txtdiscount.Text = ((discamount * 100) / totalamount).ToString();
            
        }

        private void txtdiscamount_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtdiscamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && ch!=46)
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
            if (e.KeyChar == (char)Keys.Return)
            {
                if (e.KeyChar == '\r')
                    if (this.ActiveControl != null)
                        this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }
        
        private void grdsales_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                int iColumn = grdsales.CurrentCell.ColumnIndex;
                int iRow = grdsales.CurrentCell.RowIndex;
                if (iColumn == 3)
                {
                    grdsales.CurrentCell = grdsales[iColumn + 1, iRow];
                }
                //if (iColumn == grdsales.ColumnCount - 1)
                //{
                //    if (grdsales.RowCount > (iRow + 1))
                //    {
                //        grdsales.CurrentCell = grdsales[1, iRow + 1];
                //    }
                //    else
                //    {
                //        //focus next control
                //    }
                //}
                //else
                //    grdsales.CurrentCell = grdsales[iColumn + 1, iRow];
            }
        }

        private void grdsales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iColumn = grdsales.CurrentCell.ColumnIndex;
            int iRow = grdsales.CurrentCell.RowIndex;
            if (iColumn == 3)
            {
                grdsales.CurrentCell = grdsales[iColumn + 1, iRow];
            }
        }
       
    }
}
