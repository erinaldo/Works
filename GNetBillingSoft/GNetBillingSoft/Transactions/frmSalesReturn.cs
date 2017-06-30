using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;

namespace GNetBillingSoft.Transactions
{
    public partial class frmSalesReturn : Form
    {
        clssalesreturn salesreturn = new clssalesreturn();
        clssalesinvoice sales = new clssalesinvoice();
        clssalesreturndetails returndetails = new clssalesreturndetails();
        clsitemdetails items = new clsitemdetails();
        clsgeneralledger generalledger=new clsgeneralledger();
        clscustomerdetails customer = new clscustomerdetails();
        public static string itemsid;
        public static string desc;
        public frmSalesReturn()
        {
            InitializeComponent();
            txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            AddInvoice();

           
            txtphoneno.PromptChar = ' ';
            txtinvoice.Focus();
            grdsales.Rows[0].HeaderCell.Value = "1";
            
            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
            
        }

        private void Arabic()
        {
            this.Text = "مردودات المبيعات";

            //Label
            this.lblVoucherNo.Text = "رقم القسيمة";
            this.lblPhone.Text = "رقم الهاتف";
            this.lblCustName.Text = "العميل";
            this.lblAddr.Text = "عنوان";
            this.lblDate.Text = "التاريخ";
            this.lblBal.Text = "رصيد";
            this.lblTotPaid.Text = "مجموع المبالغ المدفوعة";
            this.lblPaidCash.Text = "النقدية المدفوعة";
            this.lblAdDiscount.Text = "خصم إضافي";
            this.lblNetAmnt.Text = "الصافى";
            this.lblDiscount.Text = "% خصم";
            this.lblTotItem.Text = "(اجمالى المواد(الاصناف";

            
            //DataGrid
            this.itemno.HeaderText = "رقم الصنف";
            this.description.HeaderText = "الوصف";
            this.unit.HeaderText = "وحدة";
            this.quantity.HeaderText = "الكمية";
            this.price.HeaderText = "السعر";
            this.total.HeaderText = "الاجمالى";
            this.netamount.HeaderText = "الصافى";
            this.scode_name.HeaderText = "الاسم";
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
        private void AddInvoice()
        {
            DataTable dt = salesreturn.GetIds();
            txtinvoice.Items.Clear();
            if (dt.Rows.Count != 0)
            {
                txtinvoice.Items.Add(salesreturn.GetNextId().ToString());
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtinvoice.Items.Add(dt.Rows[i]["salesreturnid"].ToString());
                }
                txtinvoice.SelectedIndex = 0;


            }
            else
            {
                txtinvoice.Text = salesreturn.GetNextId().ToString();
            }
            txtinvoice.Focus();
            
            txtcustomername.DataSource = customer.GetRecord(); ;
            txtcustomername.DisplayMember = "name";
            txtcustomername.ValueMember = "customerid";
            //txtcustomer.Text = salesreturn.Customerid().ToString();
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

        private DataGridViewTextBoxEditingControl editingControl;
        private void grdsales_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            editingControl = (DataGridViewTextBoxEditingControl)e.Control;

            // editingControl.TextChanged += new EventHandler(editingControl_TextChanged);
            // editingControl.KeyPress += new KeyPressEventHandler(editingControl_KeyPress);
            // editingControl.KeyDown += new KeyEventHandler(editingControl_KeyDown);
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
            if (n == 0 || n == 1)
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
            DataTable dt = items.GetSalesItems();
            grdsales.EndEdit();
            if (dt.Rows.Count > 0)
            {
                grdsales.CurrentRow.Cells[0].Value = dt.Rows[0]["itemid"];

                grdsales.CurrentRow.Cells[1].Value = dt.Rows[0]["Description"];
                grdsales.CurrentRow.Cells[2].Value = dt.Rows[0]["unit"];
                grdsales.CurrentRow.Cells[4].Value = dt.Rows[0]["salesrate"];
                grdsales.CurrentCell = grdsales.CurrentRow.Cells[3];
            }

           // pnlPopup.Visible = false;
        }
        private void grdsales_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
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
                //pnlPopup.Visible = false;
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
            if (dgv.Rows.Count > 1)
            {

                string quantity = (dgv.Rows[e.RowIndex].Cells[3].Value != null) ? Convert.ToString(dgv.Rows[e.RowIndex].Cells[3].Value) : "0";


                SetNetAmt(e.RowIndex, quantity);
                CalcBalance();

                if (e.ColumnIndex == 3)
                {
                    grdsales.CurrentCell = grdsales.CurrentRow.Cells[0];
                    //CalculateStock(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
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
                txtnetamt.Text = salesreturn.CalcNetAmt(grdsales, txtdiscount.Text);
                txttotalitem.Text = salesreturn.CalcTotalItem(grdsales);



                CalcBalance();


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
                double netamt = (txtnetamt.Text != "") ? Convert.ToDouble(txtnetamt.Text) : 0;
                double balance = 0;
                txtpaidcash.Text = paidcash.ToString("0.00");
                balance = ( paidcash) - netamt;
                txttotalpaid.Text = ( paidcash).ToString("0.00");

                txtbalance.Text = balance.ToString("0.00");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            salesreturn.CalcNetAmt(grdsales, txtdiscount.Text);
            CalcBalance();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SetData())
            {
                salesreturn.Add();
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
                    generalledger.Creditamt =0;
                    generalledger.Balance = 0;
                    generalledger.VType = "SR";

                    generalledger.DeleteLedger();
                    generalledger.Add();

                    generalledger.ledcode = generalledger.GetNextId();
                    generalledger.voucherno = txtinvoice.Text;
                    generalledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generalledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generalledger.particulars = "Sales Return";
                    generalledger.Debitamt =0;
                    generalledger.Creditamt =Convert.ToDouble(txtnetamt.Text);
                    generalledger.Balance = 0;
                    generalledger.VType = "SR";


                    generalledger.Add();

                    if (txtpaidcash.Text != "0.00")
                    {

                        generalledger.ledcode = generalledger.GetNextId();
                        generalledger.voucherno = txtinvoice.Text;
                        generalledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generalledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generalledger.particulars = txtcustomername.Text;
                        generalledger.Debitamt = 0;
                        generalledger.Creditamt =Convert.ToDouble(txtpaidcash.Text);
                        generalledger.Balance = 0;
                        generalledger.VType = "SRCP";
                        generalledger.DeleteLedger();
                        generalledger.Add();

                        generalledger.ledcode = generalledger.GetNextId();
                        generalledger.voucherno = txtinvoice.Text;
                        generalledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generalledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generalledger.particulars = "Cash Account";
                        generalledger.Debitamt = Convert.ToDouble(txtpaidcash.Text);
                        generalledger.Creditamt = 0 ;
                        generalledger.Balance = 0;
                        generalledger.VType = "SRCP";
                        generalledger.Add();
                    }
                    
                    //---------------------------------------------------------------------------------------

                    salesreturn.salesreturnid = txtinvoice.Text;
                    if (txtcustomername.SelectedValue != null)
                    {
                        salesreturn.customerid = Convert.ToInt64(txtcustomername.SelectedValue.ToString());// Convert.ToInt64(txtcustomer.Text);
                    }
                    else
                    {
                        salesreturn.customerid = sales.Customerid();
                    }
                    salesreturn.customername = txtcustomername.Text;
                    salesreturn.address = txtaddress.Text;
                    salesreturn.phonenumber = txtphoneno.Text;
                    

                    salesreturn.salesreturndate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    
                    salesreturn.discount = Convert.ToDouble((txtdiscount.Text!="")?txtdiscount.Text:"0");
                    salesreturn.paidcash = Convert.ToDouble((txtpaidcash.Text!="")?txtpaidcash.Text:"0");
                    salesreturn.Delete();
                    returndetails.DeleteDetails();
                    grdsales.EndEdit();
                    for (int i = 0; i < grdsales.Rows.Count-1; i++)
                    {
                       
                        returndetails.returndetailid = returndetails.GetNextId();
                        returndetails.invoiceno = txtinvoice.Text;
                        returndetails.itemid = Convert.ToString(grdsales.Rows[i].Cells[0].Value);
                        returndetails.quantity = Convert.ToDouble(grdsales.Rows[i].Cells[3].Value);
                        returndetails.unit = Convert.ToString(grdsales.Rows[i].Cells[2].Value);
                        returndetails.supplier = Convert.ToString(grdsales.Rows[i].Cells[7].Value);
                        returndetails.salesrate = Convert.ToDouble(grdsales.Rows[i].Cells[4].Value);
                        returndetails.Add();
                       /* items.itemid = salesdetails.itemid;
                        items.salesrate = Convert.ToDouble(grdsales.Rows[i].Cells[4].Value);
                        items.EditSalesRate();*/
                        this.items.itemid = Convert.ToString(this.grdsales.Rows[i].Cells[0].Value);
                        this.items.Description = Convert.ToString(this.grdsales.Rows[i].Cells[1].Value);
                        this.items.salesrate = Convert.ToDouble(Convert.ToString(this.grdsales.Rows[i].Cells[4].Value));
                       
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
        private void Clear()
        {
            
            txtcustomername.Text = string.Empty;
            txtphoneno.Text = string.Empty;
            txtaddress.Text = string.Empty;
            txttotalitem.Text = string.Empty;
            txttotalpaid.Text = string.Empty;
            txtpaidcash.Text = string.Empty;
            txtdiscount.Text = string.Empty;
            txtadddiscount.Text = string.Empty;
            txtnetamt.Text = string.Empty;
            txtnetamt.Text = "0.00";
            grdsales.Rows.Clear();
           
            AddInvoice();
        }
        private void txtpaidcash_Leave(object sender, EventArgs e)
        {
            CalcBalance();
        }
         private void AddSelRecord()
        {
            salesreturn.salesreturnid = txtinvoice.Text;
            returndetails.invoiceno = txtinvoice.Text;
            DataTable dt = salesreturn.GetSelRecord();
            grdsales.CausesValidation = false;
            grdsales.Rows.Clear();
            

            if (dt.Rows.Count != 0)
            {

                
                txtcustomername.Text = dt.Rows[0]["customername"].ToString();
                txtaddress.Text = dt.Rows[0]["address"].ToString();
                txtphoneno.Text = dt.Rows[0]["phonenumber"].ToString();
                txtdate.Text = Convert.ToDateTime(dt.Rows[0]["salesreturndate"].ToString()).ToString("dd/MM/yyyy");
                txtpaidcash.Text = dt.Rows[0]["paidcash"].ToString();
                txtdiscount.Text = dt.Rows[0]["discount"].ToString();
                DataTable dtPur = returndetails.GetSelRecord();

                for (int i = 0; i < dtPur.Rows.Count; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)grdsales.Rows[0].Clone();

                    row.Cells[0].Value = dtPur.Rows[i]["itemid"];
                    row.Cells[1].Value = dtPur.Rows[i]["Description"];
                    row.Cells[2].Value = dtPur.Rows[i]["unit"];
                    row.Cells[3].Value = dtPur.Rows[i]["quantity"];
                    row.Cells[4].Value = dtPur.Rows[i]["salesrate"];
                    double total = Convert.ToDouble(dtPur.Rows[i]["quantity"].ToString()) * Convert.ToDouble(dtPur.Rows[i]["Price"].ToString());
                    row.Cells[5].Value = total;
                    row.Cells[7].Value = dtPur.Rows[i]["supplier"];
                    // double discount =(txtdiscount.Text!="")?Convert.ToDouble(txtdiscount.Text):0;

                    //double netamt=
                    //row.Cells[7].Value = dtPur.Rows[i]["oldprice"];
                    grdsales.Rows.Add(row);
                    grdsales.Rows[i].HeaderCell.Value = Convert.ToString(i + 1);
                    

                }
                DisableControls(false);
            }
            else
            {

                
                txtcustomername.Text = "";
                txtphoneno.Text = "";
                txtaddress.Text = "";
                txtdiscount.Text = "";
                txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txtpaidcash.Text = "";
                txtadddiscount.Text = "";
                grdsales.Rows.Clear();
                grdsales.Rows[0].HeaderCell.Value = "1";
                DisableControls(true);
            }

            salesreturn.CalcNetAmt(grdsales, txtdiscount.Text);
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

         private void btnedit_Click(object sender, EventArgs e)
         {
             DisableControls(true);
         }

         private void btnDelete_Click(object sender, EventArgs e)
         {
             String Msg = (Properties.Settings.Default.Lang == "Arabic") ? "هل تريد حذف" : "Do you want delete";
             if (MessageBox.Show(Msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
             {

                 salesreturn.salesreturnid = txtinvoice.Text;
                 salesreturn.Delete();

                 returndetails.invoiceno = txtinvoice.Text;
                 returndetails.DeleteDetails();

                 Clear();
             }
         }

         private void btnmainclose_Click(object sender, EventArgs e)
         {
             this.Close();
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
                 {
                     PopClick();
                 }
                 e.Cancel = true;
             }
         }
         

         private void txtcustomername_TextChanged(object sender, EventArgs e)
         {

         }

         private void txtcustomername_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (txtcustomername.SelectedValue.ToString() != "System.Data.DataRowView")
             {

                 sales.customerid = Convert.ToInt32(txtcustomername.SelectedValue.ToString());
                 DataTable dt = sales.SearchCustomer();
                 if (dt.Rows.Count > 0)
                 {
                     txtcustomername.Text = dt.Rows[0]["customername"].ToString();
                     txtphoneno.Text = dt.Rows[0]["phonenumber"].ToString();
                     txtaddress.Text = dt.Rows[0]["address"].ToString();
                 }
                 else
                 {

                     txtcustomername.Text = "";
                     txtphoneno.Text = "";
                     txtaddress.Text = "";
                 }
             }
         }

         private void btnmainclose_Click_1(object sender, EventArgs e)
         {
             this.Close();
         }

         private void btnClear_Click(object sender, EventArgs e)
         {
             Clear();
         }

         private void btnprint_Click(object sender, EventArgs e)
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
    }
}
