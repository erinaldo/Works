using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft.Transactions
{
    public partial class frmPurchaseReturn : Form
    {
        clspurchasereturn purreturn = new clspurchasereturn();
        clsitemdetails items = new clsitemdetails();
        clspurchasereturndetails returnitems = new clspurchasereturndetails();
        clsgeneralledger generaledger = new clsgeneralledger();
        //private Point Start;
        public frmPurchaseReturn()
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
            //Label
            lbldate.Text = "التاريخ";
            lblVoucherNo.Text = "رقم القسيمة";
            lblsuppliename.Text = "اسم المورد";
            lblphonenumber.Text = "رقم الهاتف";
            lbladdress.Text = "عنوان";
            lblBal.Text = "رصيد";
            lblTotPaid.Text = "مجموع المبالغ المدفوعة";
            lblPaidCheq.Text = "شيك مدفوع";
            lblPaidCash.Text = "النقدية المدفوعة";
            lblNetTotal.Text = "الصافى";
            lblDiscount.Text = "% خصم";
            lblAdDiscount.Text = "خصم إضافي";
            lblTotItem.Text = "(اجمالى المواد(الاصناف";
            lblOldInv.Text = "الفاتورة القديمة";

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
            oldcost.HeaderText = "التكلفة القديمة";

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
            DataTable strsql = this.purreturn.GetIds();
            this.txtinvoice.Items.Clear();
            if (strsql.Rows.Count != 0)
            {
                this.txtinvoice.Items.Add(this.purreturn.GetNextId().ToString());
                for (int i = 0; i < strsql.Rows.Count; i++)
                {
                    this.txtinvoice.Items.Add(strsql.Rows[i]["returnno"].ToString());
                }
                this.txtinvoice.SelectedIndex = 0;
            }
            else
            {
                this.txtinvoice.Text = this.purreturn.GetNextId().ToString();
            }

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
        }
        private void PopClick()
        {

            DataTable strsql = this.items.GetSearchItems();

            this.grdItems.EndEdit();
            if (strsql.Rows.Count > 0)
            {
                this.grdItems.CurrentRow.Cells[0].Value = strsql.Rows[0]["itemid"];
                this.grdItems.CurrentRow.Cells[1].Value = strsql.Rows[0]["Description"];
                this.grdItems.CurrentRow.Cells[2].Value = strsql.Rows[0]["unit"];
                this.grdItems.CurrentRow.Cells[4].Value = strsql.Rows[0]["price"];
                this.grdItems.CurrentRow.Cells[7].Value = strsql.Rows[0]["oldprice"];
              //  this.pnlPopup.Visible = false;
                grdItems.CurrentCell = grdItems.CurrentRow.Cells[3];

            }
        }
        private void AddSelRecord()
        {
            this.purreturn.returnno = this.txtinvoice.Text;
           returnitems.returnno = this.txtinvoice.Text;
           DataTable selRecord = this.purreturn.GetSelRecord();
            this.grdItems.CausesValidation = false;
            this.grdItems.Rows.Clear();
            if (selRecord.Rows.Count != 0)
            {
                this.txtsupplier.Text = selRecord.Rows[0]["supplier"].ToString();
                this.txtphonenumber.Text = selRecord.Rows[0]["phonenumber"].ToString();
                this.txtaddress.Text = selRecord.Rows[0]["address"].ToString();
                this.txtdate.Text = Convert.ToDateTime(selRecord.Rows[0]["returndate"].ToString()).ToString("dd/MM/yyyy");
                this.txtpaidcash.Text = selRecord.Rows[0]["paidamount"].ToString();
                
                this.txtdiscount.Text = selRecord.Rows[0]["discount"].ToString();
                this.txtoldinvoice.Text = selRecord.Rows[0]["oldinvoiceno"].ToString();
                DataTable table2 = this.returnitems.GetSelRecord();
                for (int i = 0; i < table2.Rows.Count; i++)
                {

                    DataGridViewRow dataGridViewRow = (DataGridViewRow)this.grdItems.Rows[0].Clone();

                    dataGridViewRow.Cells[0].Value = table2.Rows[i]["itemid"];
                    dataGridViewRow.Cells[1].Value = table2.Rows[i]["Description"];
                    dataGridViewRow.Cells[2].Value = table2.Rows[i]["unit"];
                    dataGridViewRow.Cells[3].Value = table2.Rows[i]["quantity"];
                    dataGridViewRow.Cells[4].Value = table2.Rows[i]["Price"];
                    double num2 = Convert.ToDouble(table2.Rows[i]["quantity"].ToString()) * Convert.ToDouble(table2.Rows[i]["Price"].ToString());
                    dataGridViewRow.Cells[5].Value = num2;
                    
                    dataGridViewRow.Cells[8].Value = table2.Rows[i]["purchasereturnid"];
                    this.grdItems.Rows.Add(dataGridViewRow);
                    grdItems.Rows[i].HeaderCell.Value = Convert.ToString(i + 1);
                }

                this.DisableControls(false);
            }
            else
            {
                this.txtsupplier.Text = "";
                this.txtphonenumber.Text = "";
                this.txtaddress.Text = "";
                this.txtdiscount.Text = "";
                this.txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                this.txtpaidcash.Text = "";
                this.txtpaidcheque.Text = "";
                this.txtoldinvoice.Text = "";
                this.grdItems.Rows.Clear();
                this.DisableControls(true);
                grdItems.Rows[0].HeaderCell.Value = "1";
            }
            this.purreturn.CalcNetAmt(this.grdItems, this.txtdiscount.Text);
            this.CalcBalance();
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
                        if ((result == this.btnedit) || (result == this.btnDelete) || (result == this.btnPrint))
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
            this.txtoldinvoice.Text = string.Empty;
            this.txtBalance.Text = string.Empty;
            this.grdItems.Rows.Clear();
            this.txtinvoice.Text = this.purreturn.GetNextId();
            this.AddInvoice();
        }
        private DataGridViewTextBoxEditingControl editingControl;
        private void grdItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            this.editingControl = (DataGridViewTextBoxEditingControl)e.Control;
            this.editingControl.TextChanged += new EventHandler(this.editingControl_TextChanged);
            this.editingControl.KeyPress += new KeyPressEventHandler(this.editingControl_KeyPress);
            editingControl.KeyDown += new KeyEventHandler(editingControl_KeyDown);
        }
        private void editingControl_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridViewTextBoxEditingControl txt = (DataGridViewTextBoxEditingControl)sender;
            if (e.KeyCode == Keys.F2)
            {

                //pnlPopup.Focus();
               // grdpopup.Focus();
            }
        }
        private void editingControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl txt = (DataGridViewTextBoxEditingControl)sender;
            int columnIndex = txt.EditingControlDataGridView.CurrentCell.ColumnIndex;
            if (columnIndex == 3)
            {
                if ((e.KeyChar != '\b') && !char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
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

                   // this.ShowPopup(control.Text, "");

                    break;

                case 1:
                  //  ShowPopup("", control.Text);

                    if (Convert.ToString(editingControlDataGridView.Rows[editingControlDataGridView.CurrentCell.RowIndex].Cells[1].Value) == "")
                    {

                        editingControlDataGridView.Rows[editingControlDataGridView.CurrentCell.RowIndex].Cells[1].Value = this.items.GetNextId();
                    }
                    break;


                default:
                    //this.pnlPopup.Visible = false;
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
              //  this.pnlPopup.Visible = false;
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
                            long tmpid = Convert.ToInt64(items.TempId) + 1;
                            this.grdItems.Rows[e.RowIndex].Cells[0].Value = tmpid.ToString();
                            items.TempId = tmpid.ToString();
                        }
                    }
                    else
                    {
                        //this.PopClick(e.RowIndex);
                    }
                }
               // pnlPopup.Visible = false;
            }
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
        private void SetNetAmt(int rowindex, string quantity)
        {
            try
            {
                string strsql = Convert.ToString(this.grdItems.Rows[rowindex].Cells[4].Value);
                quantity = (quantity == "") ? "0" : quantity;
                strsql = (strsql == "") ? "0" : strsql;
                this.grdItems.Rows[rowindex].Cells[5].Value = Convert.ToDouble(quantity) * Convert.ToDouble(strsql);
                this.txtnetamount.Text = this.purreturn.CalcNetAmt(this.grdItems, this.txtdiscount.Text);
                this.txttotitem.Text = this.purreturn.CalcTotalItem(this.grdItems);
                this.CalcBalance();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void grdItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.txtnetamount.Text = this.purreturn.CalcNetAmt(this.grdItems, this.txtdiscount.Text);
            this.txttotitem.Text = this.purreturn.CalcTotalItem(this.grdItems);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            String Msg = (Properties.Settings.Default.Lang == "Arabic") ? "هل تريد حذف" : "Do you want delete";
            if (MessageBox.Show(Msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.purreturn.returnno = this.txtinvoice.Text;
                this.purreturn.Delete();
                this.returnitems.returnno = this.txtinvoice.Text;
                this.returnitems.DeleteDetails();
                this.generaledger.voucherno = txtinvoice.Text;
                this.generaledger.DeleteLedger();

                this.Clear();
                this.DisableControls(true);
            }
        }
        private bool SetData()
        {
            try
            {
                if (this.validation())
                {
                    this.purreturn.returnno = this.txtinvoice.Text;
                    this.purreturn.supplier = this.txtsupplier.Text;
                    this.purreturn.phonenumber = this.txtphonenumber.Text;
                    this.purreturn.address = this.txtaddress.Text;
                    this.purreturn.paidamount = Convert.ToDouble(this.txtpaidcash.Text);
                    this.purreturn.oldinvoiceno = this.txtoldinvoice.Text;
                    this.purreturn.ReturnDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    this.purreturn.discount = Convert.ToDouble((this.txtdiscount.Text != "") ? this.txtdiscount.Text : "0");

                    //-------------------------generaLedger----------------------------

                    generaledger.ledcode = generaledger.GetNextId();
                    generaledger.voucherno = txtinvoice.Text;
                    generaledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generaledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generaledger.particulars = txtsupplier.Text;
                    generaledger.Debitamt = 0;
                    generaledger.Creditamt = Convert.ToDouble(txtnetamount.Text);
                    generaledger.Balance = 0;
                    generaledger.VType = "PR";

                    generaledger.DeleteLedger();
                    generaledger.Add();

                    generaledger.ledcode = generaledger.GetNextId();
                    generaledger.voucherno = txtinvoice.Text;
                    generaledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generaledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generaledger.particulars = "Purchase Return";
                    generaledger.Debitamt = Convert.ToDouble(txtnetamount.Text);
                    generaledger.Creditamt = 0;
                    generaledger.Balance = 0;
                    generaledger.VType = "PR";


                    generaledger.Add();

                    if (txtpaidcash.Text != "0.00")
                    {
                        generaledger.ledcode = generaledger.GetNextId();
                        generaledger.voucherno = txtinvoice.Text;
                        generaledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.particulars = txtsupplier.Text;
                        generaledger.Debitamt = Convert.ToDouble(txtpaidcash.Text);
                        generaledger.Creditamt = 0;
                        generaledger.Balance = 0;
                        generaledger.VType = "PRCR";
                        generaledger.DeleteLedger();

                        generaledger.Add();

                        generaledger.ledcode = generaledger.GetNextId();
                        generaledger.voucherno = txtinvoice.Text;
                        generaledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.particulars = "Cash account";
                        generaledger.Debitamt = 0;
                        generaledger.Creditamt = Convert.ToDouble(txtpaidcash.Text);
                        generaledger.Balance = 0;
                        generaledger.VType = "PRCR";
                        generaledger.Add();
                    }
                    /*if (txtpaidcheque.Text != "0.00")
                    {
                        generaledger.ledcode = generaledger.GetNextId();
                        generaledger.voucherno = txtinvoice.Text;
                        generaledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.particulars = txtsupplier.Text;
                        generaledger.Debitamt = 0;
                        generaledger.Creditamt = Convert.ToDouble(txtpaidcheque.Text);
                        generaledger.Balance = 0;
                        generaledger.VType = "BP";
                        generaledger.DeleteLedger();
                        generaledger.Add();

                        generaledger.ledcode = generaledger.GetNextId();
                        generaledger.voucherno = txtinvoice.Text;
                        generaledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        generaledger.particulars = "Bank account";
                        generaledger.Debitamt = Convert.ToDouble(txtpaidcheque.Text);
                        generaledger.Creditamt = 0;
                        generaledger.Balance = 0;
                        generaledger.VType = "BP";
                        generaledger.Add();
                    }*/
                    //-----------------------------------------------------------------//
                    this.purreturn.Delete();
                    this.returnitems.DeleteDetails();
                    for (int strsql = 0; strsql < (this.grdItems.Rows.Count - 1); strsql++)
                    {
                        this.items.itemid = Convert.ToString(this.grdItems.Rows[strsql].Cells[0].Value);
                        this.items.Description = Convert.ToString(this.grdItems.Rows[strsql].Cells[1].Value);
                        this.items.Price = Convert.ToDouble(Convert.ToString(this.grdItems.Rows[strsql].Cells[4].Value));
                        this.items.oldprice = (this.grdItems.Rows[strsql].Cells[7].Value != null) ? Convert.ToDouble(Convert.ToString(this.grdItems.Rows[strsql].Cells[7].Value)) : 0.0;
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
                            this.returnitems.purchasereturnid = Convert.ToInt64(this.grdItems.Rows[strsql].Cells[8].Value.ToString());
                        }
                        else
                        {
                            this.returnitems.purchasereturnid = this.returnitems.GetNextId();
                        }
                        this.returnitems.returnno = this.txtinvoice.Text;
                        this.returnitems.itemid = this.items.itemid;
                        this.returnitems.quantity = Convert.ToDouble(this.grdItems.Rows[strsql].Cells[3].Value);
                        this.returnitems.Price = Convert.ToDouble(Convert.ToString(this.grdItems.Rows[strsql].Cells[4].Value));
                        this.returnitems.unit = Convert.ToString(this.grdItems.Rows[strsql].Cells[2].Value);
                        if (this.returnitems.GetItems())
                        {
                            this.returnitems.Edit();
                        }
                        else
                        {
                            this.returnitems.Add();
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
        private bool validation()
        {
            if (this.txtsupplier.Text.Trim() == "")
            {
                this.errorProvider.SetError(this.txtsupplier, "Supplier Name is required");
                return false;
            }
           
            if (this.txtaddress.Text.Trim() == "")
            {
                this.errorProvider.SetError(this.txtaddress, "Address is required");
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.SetData())
            {
                if (this.purreturn.GetItems())
                {
                    this.purreturn.Edit();
                }
                else
                {
                    this.purreturn.Add();
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
        private void btnedit_Click(object sender, EventArgs e)
        {
            this.DisableControls(true);
        }
        private void txtinvoice_TextChanged(object sender, EventArgs e)
        {
            this.AddSelRecord();
            this.errorProvider.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtoldinvoice_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    }
}
