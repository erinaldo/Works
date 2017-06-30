using GNetBillingSoft.DataOperation;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace GNetBillingSoft.Transactions
{
    public partial class frmVoucher : Form
    {
        private clspurchaseinvoice purchase = new clspurchaseinvoice();
        private clssalesinvoice sales = new clssalesinvoice();
        private clscustomerdetails customer = new clscustomerdetails();
        private clsgeneralledger ledger = new clsgeneralledger();
        private clsvoucher voucher = new clsvoucher();
        private clsvoucherdetails vsdetails = new clsvoucherdetails();
        public frmVoucher()
        {
            this.InitializeComponent();
            this.AddInvoice();

            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }
        private void Arabic()
        { 
            //Label
            this.lblVoucherNo.Text = "رقم القسيمة";
            this.lblVoucherType.Text = "نوع القسيمة";
            this.lblTransType.Text = "نوع المعاملة";
            this.lblTotAmnt.Text = "المبلغ الإجمالي";

            //Button
            btnprint.Text = "طباعة";
            btnClose.Text = "اقفال";
            btnDelete.Text = "الغاء";
            btnedit.Text = "تحرير";
            btnSave.Text = "حفظ";
            btnclear.Text = "واضح";

            //DataGrid
            this.slno.HeaderText = "رقم سري";
            this.accounttype.HeaderText = "نوع الحساب";
            this.name.HeaderText = "الاسم";
            this.referenceinvo.HeaderText = "مرجع";
            this.amount.HeaderText = "حساب";
            this.remark.HeaderText = "ملاحظات";
            this.oldbalance.HeaderText = "مبلغ الرصيد";
            this.newbalance.HeaderText = "رصيد جديد";

            this.chkPrint.Text = "اطبع أثناء الحفظ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void grdVoucher_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                this.editingcombo = (DataGridViewComboBoxEditingControl)e.Control;
                this.editingcombo.DropDownStyle = ComboBoxStyle.DropDown;
                this.editingcombo.SelectedIndexChanged += new EventHandler(this.editingcombo_SelectedIndexChanged);
                this.editingcombo.TextChanged += new EventHandler(this.editingcombo_TextChanged);
            }
            else
            {
                this.editingcontrol = (DataGridViewTextBoxEditingControl)e.Control;
                this.editingcontrol.TextChanged += new EventHandler(this.editingcontrol_TextChanged);
            }
        }

        private void editingcombo_TextChanged(object sender, EventArgs e)
        {
            this.grdVoucher.NotifyCurrentCellDirty(true);
        }

        private void editingcontrol_TextChanged(object sender, EventArgs e)
        {
            if (((DataGridViewTextBoxEditingControl)sender).EditingControlDataGridView.CurrentCell.ColumnIndex != 3)
            {
            }
        }

        private void editingcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewComboBoxEditingControl boxEditingControl = (DataGridViewComboBoxEditingControl)sender;
                DataGridView controlDataGridView = boxEditingControl.EditingControlDataGridView;
                DataRowView dataRowView = boxEditingControl.SelectedItem as DataRowView;
                if (controlDataGridView.CurrentCell.ColumnIndex == 2 && boxEditingControl.Text != "")
                {
                    this.ledger.particulars = boxEditingControl.Text;
                    DataGridViewComboBoxCell viewComboBoxCell = (DataGridViewComboBoxCell)controlDataGridView["referenceinvo", controlDataGridView.CurrentCell.RowIndex];
                    viewComboBoxCell.DataSource = (object)this.ledger.GetInv();
                    viewComboBoxCell.DisplayMember = "voucherno";
                }
                else
                {
                    if (controlDataGridView.CurrentCell.ColumnIndex != 3 || dataRowView == null)
                        return;
                    this.ledger.voucherno = dataRowView.Row["voucherno"].ToString();
                    double num = Convert.ToDouble(this.ledger.GetParticularsBalance());
                    this.grdVoucher.Rows[controlDataGridView.CurrentCell.RowIndex].Cells["oldbalance"].Value = (object)Math.Abs(num).ToString();
                }
            }
            catch (Exception )
            {
            }
        }

        private DataTable GetAccountsHead(string accountype)
        {
            switch (accountype)
            {
                case "CUSTOMER":
                    return this.customer.GetCusRecord();
                case "SUPPLIER":
                    return this.purchase.Suplier();
                default:
                    return new DataTable();
            }
        }

        private void cmbtypevoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            DataTable dataTable = new DataTable();
            if (comboBox.SelectedItem == null)
                return;
            if (comboBox.SelectedItem.ToString() == "RECEIPT")
                dataTable = this.GetAccountsHead("CUSTOMER");
            else if (comboBox.SelectedItem.ToString() == "PAYMENT")
                dataTable = this.GetAccountsHead("SUPPLIER");
            DataGridViewComboBoxColumn viewComboBoxColumn = (DataGridViewComboBoxColumn)this.grdVoucher.Columns["name"];
            viewComboBoxColumn.DataSource = (object)dataTable;
            viewComboBoxColumn.DisplayMember = "name";
        }

        private void cmbtypevoucher_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void grdVoucher_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.cmbtypevoucher.SelectedItem != null)
            {
                if (this.cmbtypevoucher.SelectedItem.ToString() == "RECEIPT")
                    this.grdVoucher.Rows[e.RowIndex].Cells["accounttype"].Value = (object)"CUSTOMER";
                else if (this.cmbtypevoucher.SelectedItem.ToString() == "PAYMENT")
                    this.grdVoucher.Rows[e.RowIndex].Cells["accounttype"].Value = (object)"SUPPLIER";
            }
            this.grdVoucher.Rows[e.RowIndex].Cells["slno"].Value = (object)(e.RowIndex + 1);
        }

        private void cmbtypetransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbtypetransaction.SelectedItem == null)
                return;
            this.ledger.particulars = this.cmbtypetransaction.SelectedItem.ToString();
            double num = Convert.ToDouble(this.ledger.GetBalance());
            string str = "Cr";
            if (num < 0.0)
                str = "Dr";
            if (num == 0.0)
                str = "";
            this.lblbalance.Text = "Balance : " + string.Format("{0:0.00}", (object)Math.Abs(num)) + " " + str;
        }

        private void grdVoucher_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 3:
                    if (this.grdVoucher.CurrentCell.Value == null)
                        break;
                    this.ledger.voucherno = this.grdVoucher.CurrentCell.Value.ToString();
                    double num1 = Convert.ToDouble(this.ledger.GetParticularsBalance());
                    this.grdVoucher.Rows[e.RowIndex].Cells["oldbalance"].Value = (object)Math.Abs(num1).ToString();
                    break;
                case 4:
                    double num2 = Convert.ToDouble("0.00");
                    if (this.grdVoucher.CurrentCell.Value != null)
                        num2 = Convert.ToDouble(this.grdVoucher.CurrentCell.Value.ToString());
                    if (this.grdVoucher.Rows[e.RowIndex].Cells["oldbalance"].Value == null)
                        break;
                    double num3 = Convert.ToDouble(Convert.ToDouble(this.grdVoucher.Rows[e.RowIndex].Cells["oldbalance"].Value.ToString()) - num2);
                    this.grdVoucher.Rows[e.RowIndex].Cells["newbalance"].Value = (object)Math.Abs(num3);
                    this.CalcTotal();
                    break;
            }
        }

        private void CalcTotal()
        {
            double num = 0.0;
            foreach (DataGridViewRow dataGridViewRow in (IEnumerable)this.grdVoucher.Rows)
            {
                if (!dataGridViewRow.IsNewRow)
                {
                    foreach (DataGridViewCell dataGridViewCell in (BaseCollection)dataGridViewRow.Cells)
                    {
                        if (dataGridViewCell.ColumnIndex == 4)
                            num += Convert.ToDouble(dataGridViewCell.Value.ToString());
                    }
                }
                else
                    break;
            }
            this.txttotal.Text = num.ToString("0.00");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.SetData())
                return;
            this.voucher.Add();
            if (this.chkPrint.Checked)
            {
                rptVoucher rptvoucher = new rptVoucher();
                rptvoucher.voucherno = this.txtvoucher.Text;
                rptvoucher.MdiParent = this.MdiParent;
                ((Control)rptvoucher).Show();
            }
            this.Clear();
        }

        private bool SetData()
        {
            if (!this.Validation())
                return false;
            try
            {
                this.voucher.voucherno = Convert.ToInt64(this.txtvoucher.Text);
                this.vsdetails.voucherno = Convert.ToInt64(this.txtvoucher.Text);
                this.voucher.typeoftransaction = this.cmbtypetransaction.Text;
                this.voucher.typeofvoucher = this.cmbtypevoucher.Text;
                this.voucher.voucherdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                this.voucher.Delete();
                this.vsdetails.DeletDetails();
                for (int index = 0; index < this.grdVoucher.Rows.Count - 1; ++index)
                {
                    this.ledger.ledcode = (long)this.ledger.GetNextId();
                    this.ledger.voucherno = this.txtvoucher.Text;
                    this.ledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    this.ledger.ledgertime = DateTime.Now;
                    this.ledger.particulars = this.grdVoucher.Rows[index].Cells["name"].Value.ToString();
                    if (this.cmbtypevoucher.Text == "PAYMENT")
                    {
                        this.ledger.Debitamt =Convert.ToDouble(this.grdVoucher.Rows[index].Cells["amount"].Value.ToString());
                        this.ledger.Creditamt = 0.0;
                    }
                    else
                    {
                        this.ledger.Debitamt = 0.0;
                        this.ledger.Creditamt = Convert.ToDouble(this.grdVoucher.Rows[index].Cells["amount"].Value.ToString());
                    }
                    this.ledger.Balance = 0.0;
                    this.ledger.RVNo = Convert.ToString(this.grdVoucher.Rows[index].Cells["referenceinvo"].Value);
                    if (this.cmbtypetransaction.Text == "Cash Account")
                    {
                        if (this.cmbtypevoucher.Text == "RECEIPT")
                            this.ledger.VType = "CR";
                        else if (this.cmbtypevoucher.Text == "PAYMENT")
                            this.ledger.VType = "CP";
                    }
                    else if (this.cmbtypetransaction.Text == "Bank Account")
                    {
                        if (this.cmbtypevoucher.Text == "RECEIPT")
                            this.ledger.VType = "BR";
                        else if (this.cmbtypevoucher.Text == "PAYMENT")
                            this.ledger.VType = "BP";
                    }
                    this.ledger.DeleteLedger();
                    this.ledger.Add();
                    //this.ledger.ledcode = (long)this.ledger.GetNextId();
                    //this.ledger.particulars = this.cmbtypetransaction.Text;
                    //if (this.cmbtypevoucher.Text == "PAYMENT")
                    //{
                    //    this.ledger.Debitamt = Convert.ToDouble(this.grdVoucher.Rows[index].Cells["amount"].Value.ToString());
                    //    this.ledger.Creditamt = 0.0;
                    //}
                     //else
                    //{
                    //    this.ledger.Debitamt = 0.0;
                    //    this.ledger.Creditamt = Convert.ToDouble(this.grdVoucher.Rows[index].Cells["amount"].Value.ToString());
                    //}
                    //this.ledger.Balance = 0.0;
                    //this.ledger.Add();
                    this.vsdetails.voucherdetailno = (long)this.vsdetails.GetNextId();
                    this.vsdetails.voucherno = Convert.ToInt64(this.txtvoucher.Text);
                    this.vsdetails.accounttype = this.grdVoucher.Rows[index].Cells["accounttype"].Value.ToString();
                    this.vsdetails.name = this.grdVoucher.Rows[index].Cells["name"].Value.ToString();
                    this.vsdetails.referenceinv = this.grdVoucher.Rows[index].Cells["referenceinvo"].Value.ToString();
                    this.vsdetails.amount = Convert.ToDouble(this.grdVoucher.Rows[index].Cells["amount"].Value.ToString());
                    this.vsdetails.remark = Convert.ToString(this.grdVoucher.Rows[index].Cells["remark"].Value);
                    this.vsdetails.OldBalance = Convert.ToDouble(this.grdVoucher.Rows[index].Cells["oldbalance"].Value);
                    this.vsdetails.Add();
                }
                return true;
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool Validation()
        {
            if (this.txtvoucher.Text == "")
            {
                this.errovoucher.SetError((Control)this.txtvoucher, "Voucher No is Required");
                return false;
            }
            else if (this.cmbtypetransaction.Text == "")
            {
                this.errovoucher.SetError((Control)this.cmbtypetransaction, "Type of Transaction Required");
                return false;
            }
            else if (this.cmbtypevoucher.Text == "")
            {
                this.errovoucher.SetError((Control)this.cmbtypevoucher, "Type of Voucher is Required");
                return false;
            }
            else
            {
                this.grdVoucher.EndEdit();
                foreach (DataGridViewRow dataGridViewRow in (IEnumerable)this.grdVoucher.Rows)
                {
                    foreach (DataGridViewCell dataGridViewCell in (BaseCollection)dataGridViewRow.Cells)
                    {
                        if (dataGridViewRow.IsNewRow)
                            return true;
                        if (dataGridViewCell.Value == null && dataGridViewCell.ColumnIndex != 5)
                        {
                            dataGridViewCell.Style.BackColor = Color.Red;
                            if (dataGridViewCell is DataGridViewComboBoxCell)
                                ((DataGridViewCell)dataGridViewCell.Clone()).Style.BackColor = Color.Red;
                            this.grdVoucher.BeginEdit(true);
                            return false;
                        }
                        else
                            dataGridViewCell.Style.BackColor = dataGridViewRow.DefaultCellStyle.BackColor;
                    }
                }
                return false;
            }
        }

        private void Clear()
        {
            this.cmbtypetransaction.SelectedIndex = -1;
            this.cmbtypevoucher.SelectedIndex = -1;
            this.grdVoucher.Rows.Clear();
            this.lblbalance.Text = "";
            this.txttotal.Text = "0.00";
            this.DisableControls(true);
            this.AddInvoice();
            this.txtvoucher.Focus();
        }

        private void AddInvoice()
        {
            DataTable ids = this.voucher.GetIds();
            this.txtvoucher.Items.Clear();
            if (ids.Rows.Count != 0)
            {
                DomainUpDown.DomainUpDownItemCollection items = this.txtvoucher.Items;
                int nextId = this.voucher.GetNextId();
                string str1 = nextId.ToString();
                items.Add((object)str1);
                for (int index = 0; index < ids.Rows.Count; ++index)
                    this.txtvoucher.Items.Add((object)ids.Rows[index]["voucherno"].ToString());
                this.txtvoucher.SelectedIndex = 0;
                DomainUpDown domainUpDown = this.txtvoucher;
                nextId = this.voucher.GetNextId();
                string str2 = nextId.ToString();
                domainUpDown.Text = str2;
            }
            else
                this.txtvoucher.Text = this.voucher.GetNextId().ToString();
        }

        private void AddSelRecord()
        {
            if (this.txtvoucher.Text == "")
                return;
            this.voucher.voucherno = Convert.ToInt64(this.txtvoucher.Text);
            this.vsdetails.voucherno = Convert.ToInt64(this.txtvoucher.Text);
            DataTable selRecord1 = this.voucher.GetSelRecord();
            this.grdVoucher.CausesValidation = false;
            this.grdVoucher.Rows.Clear();
            if (selRecord1.Rows.Count != 0)
            {
                this.cmbtypetransaction.SelectedItem = (object)selRecord1.Rows[0]["typeoftransaction"].ToString();
                this.cmbtypevoucher.SelectedItem = (object)selRecord1.Rows[0]["typeofvoucher"].ToString();
                DataTable selRecord2 = this.vsdetails.GetSelRecord();
                for (int index = 0; index < selRecord2.Rows.Count; ++index)
                {
                    DataGridViewRow dataGridViewRow = (DataGridViewRow)this.grdVoucher.Rows[index].Clone();
                    dataGridViewRow.Cells[1].Value = selRecord2.Rows[index]["accounttype"];
                    dataGridViewRow.Cells[2].Value = selRecord2.Rows[index]["name"];
                    this.ledger.particulars = selRecord2.Rows[index]["name"].ToString();
                    DataGridViewComboBoxCell viewComboBoxCell = (DataGridViewComboBoxCell)dataGridViewRow.Cells[3];
                    viewComboBoxCell.DataSource = (object)this.ledger.GetInv();
                    viewComboBoxCell.DisplayMember = "voucherno";
                    dataGridViewRow.Cells[3].Value = selRecord2.Rows[index]["referenceinv"];
                    dataGridViewRow.Cells[4].Value = selRecord2.Rows[index]["amount"];
                    dataGridViewRow.Cells[5].Value = selRecord2.Rows[index]["remark"];
                    dataGridViewRow.Cells[6].Value = selRecord2.Rows[index]["oldbalance"];
                    dataGridViewRow.Cells[7].Value = (object)(Convert.ToDouble(selRecord2.Rows[index]["oldbalance"]) - Convert.ToDouble(selRecord2.Rows[index]["amount"]));
                    this.grdVoucher.Rows.Add(dataGridViewRow);
                }
                this.DisableControls(false);
                this.CalcTotal();
            }
            else
            {
                this.Clear();
                this.DisableControls(true);
            }
        }

        private void DisableControls(bool enabled)
        {
            try
            {
                foreach (Control control1 in (ArrangedElementCollection)this.Controls)
                {
                    if (control1 is GroupBox)
                    {
                        foreach (Control control2 in (ArrangedElementCollection)control1.Controls)
                        {
                            if (control2 != this.txtvoucher && control2 != this.btnclear && !(control2 is Label))
                            {
                                control2.Enabled = enabled;
                                if (!(control2 is Button))
                                    control2.BackColor = SystemColors.ControlLightLight;
                            }
                            if (control2 == this.btnedit || control2 == this.btnDelete || control2 == this.btnprint)
                                control2.Enabled = !enabled;
                        }
                    }
                    else if (!(control1 is Label))
                    {
                        control1.Enabled = enabled;
                        control1.BackColor = SystemColors.ControlLightLight;
                    }
                }
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message);
            }
        }

        private void txtvoucher_SelectedItemChanged(object sender, EventArgs e)
        {
        }

        private void txtvoucher_TextChanged(object sender, EventArgs e)
        {
            this.AddSelRecord();
            this.errovoucher.Clear();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            this.DisableControls(true);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            rptVoucher rptvoucher = new rptVoucher();
            rptvoucher.voucherno = this.txtvoucher.Text;
            rptvoucher.MdiParent = this.MdiParent;
            ((Control)rptvoucher).Show();
        }

        private void grdVoucher_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void grdVoucher_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String Msg = (Properties.Settings.Default.Lang == "Arabic") ? "هل تريد حذف" : "Do you want delete";
            if (MessageBox.Show(Msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                return;
            this.voucher.voucherno = Convert.ToInt64(this.txtvoucher.Text);
            this.vsdetails.voucherno = Convert.ToInt64(this.txtvoucher.Text);
            this.ledger.voucherno = this.txtvoucher.Text;
            this.voucher.Delete();
            this.vsdetails.DeletDetails();
            this.ledger.DeleteLedger();
            this.Clear();
        }

        private void grdVoucher_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void grdVoucher_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                this.grdVoucher.EndEdit();
                this.ledger.particulars = Convert.ToString(this.grdVoucher.Rows[e.RowIndex].Cells["name"].Value);
                DataGridViewComboBoxCell viewComboBoxCell = (DataGridViewComboBoxCell)this.grdVoucher.Rows[e.RowIndex].Cells[3];
                viewComboBoxCell.DataSource = (object)this.ledger.GetInv();
                viewComboBoxCell.DisplayMember = "voucherno";
            }
            else
            {
                if (e.ColumnIndex != 4)
                    return;
                this.ledger.voucherno = Convert.ToString(this.grdVoucher.Rows[e.RowIndex].Cells[3].Value);
                double num = Convert.ToDouble(this.ledger.GetParticularsBalance());
                this.grdVoucher.Rows[e.RowIndex].Cells["oldbalance"].Value = (object)Math.Abs(num).ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}