using System;
using System.Drawing;
using System.Windows.Forms;
using RawInput_dll;
using GNetBillingSoft.DataOperation;
using System.IO;
using System.Diagnostics;
namespace GNetBillingSoft
{
    public partial class TestRawInput : Form
    {
        clsposgroup group = new clsposgroup();
        clsitemdetails items = new clsitemdetails();
        clsposinvoice posinvoice = new clsposinvoice();
        clsgeneralledger generalledger = new clsgeneralledger();
        clsposdetails posdetails = new clsposdetails();
        clscustomerdetails customer = new clscustomerdetails();
        clssalesinvoice sales = new clssalesinvoice();
        clssalesdetails salesdetails = new clssalesdetails();
        public string particulars;
        public string remarks = "";
        Font printFont;
        StreamReader streamToPrint;
        public Int64 selchild = 0;
        bool edit = false;
        Process myproces = null;
        Control _focused = null;
        private readonly RawInput _rawinput;
        const bool CaptureOnlyInForeground = true;
        public TestRawInput()
        {
            InitializeComponent();
            txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
            cmbcustomer.DataSource = customer.GetRecord();
            cmbcustomer.ValueMember = "customerid";
            cmbcustomer.DisplayMember = "customername";
           // POSGroup();
            
         //   cmbcustomer.SelectedIndexChanged += new EventHandler(cmbcustomer_SelectedIndexChanged);
           // AddInvoice();
            _rawinput = new RawInput(Handle, CaptureOnlyInForeground);
            _rawinput.AddMessageFilter();   // Adding a message filter will cause keypresses to be handled
            Win32.DeviceAudit();            // Writes a file DeviceAudit.txt to the current directory
            _rawinput.KeyPressed += OnKeyPressed;
            

            
            
        }

        private void OnKeyPressed(object sender, RawInputEventArg e)
        {
        }

       

        
        //private void AddInvoice()
        //{
        //    DataTable dt = sales.GetIds();
        //    txtinvoiceno.Items.Clear();
        //    if (dt.Rows.Count != 0)
        //    {
        //        txtinvoiceno.Items.Add(sales.GetNextId().ToString());
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            txtinvoiceno.Items.Add(dt.Rows[i]["salesinvoice"].ToString());
        //        }
        //        txtinvoiceno.SelectedIndex = 0;


        //    }
        //    else
        //    {
        //        txtinvoiceno.Text = sales.GetNextId().ToString();
        //    }
        //    txtinvoiceno.Focus();
        //    if (cmbcustomer.SelectedValue != null)
        //    {
        //        customer.customerid = Convert.ToInt64(cmbcustomer.SelectedValue.ToString());
        //        DataTable dtcustomer = customer.GetSelRecord();
        //        txtaddress.Text = dtcustomer.Rows[0]["address"].ToString();
        //        txtphoneno.Text = dtcustomer.Rows[0]["phonenumber"].ToString();
        //        txtopening.Text = dtcustomer.Rows[0]["Cusopening"].ToString();
        //    }
        //}
        //void cmbcustomer_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbcustomer.SelectedIndex > -1)
        //    {
        //        if (edit)
        //            return;
        //        customer.customerid = Convert.ToInt64(cmbcustomer.SelectedValue);
        //        DataTable dt = customer.GetSelRecord();
        //        if (dt.Rows.Count != 0)
        //        {
        //            txtphoneno.Text = dt.Rows[0]["phonenumber"].ToString();
        //            txtaddress.Text = dt.Rows[0]["address"].ToString();
        //            txtopening.Text = dt.Rows[0]["cusopening"].ToString();
        //            generalledger.particulars = cmbcustomer.Text;
        //            txtoldbalance.Text = generalledger.GetBalance();
        //            double bal = (txtbalance.Text != "") ? Convert.ToDouble(txtbalance.Text) : 0;
        //            double oldbal = (txtoldbalance.Text != "") ? Convert.ToDouble(txtoldbalance.Text) : 0;
                    
        //            txtnewbalance.Text = Convert.ToString(oldbal + bal);
        //        }
        //    }
        //    else
        //    {
        //        txtphoneno.Text = string.Empty;
        //        txtaddress.Text = string.Empty;
        //    }
        //}

        //private void groupBox1_Enter(object sender, EventArgs e)
        //{

        //}
        //private void POSGroup()
        //{
        //    DataTable dt = group.GetRecord();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        Button btn = new Button();
        //        btn.Width =140;
        //        btn.Height = 56;

        //        byte[] photo = (byte[])dt.Rows[i]["backimage"];
        //        if (photo.Length != 4)
        //        {
        //            MemoryStream ms = new MemoryStream(photo);
        //            Bitmap bmp = new Bitmap(ms);
        //            btn.Image = bmp;
        //        }

        //        btn.Tag = dt.Rows[i]["positemid"].ToString();
        //        btn.Text = dt.Rows[i]["itemname"].ToString();
        //        if (dt.Rows[i]["backgroundcolor"].ToString() != "")
        //        {
        //            btn.BackColor = ColorTranslator.FromHtml(dt.Rows[i]["backgroundcolor"].ToString());
        //        }
        //        btn.Click+=new EventHandler(btn_Click);
        //        btn.Margin = new Padding(0);
        //        grouplayout.Controls.Add(btn);


        //    }

        //}

        //void btn_Click(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    GetChild(Convert.ToInt64(btn.Tag));
        //}
        //private void GetChild(Int64 id)
        //{
        //    group.positemid = id;
        //    DataTable dt = group.ChildNodes();
        //    if (id == selchild)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        selchild = id;
        //    }
        //    childlayout.Controls.Clear();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //         Button btnchild = new Button();
        //        btnchild.Width =83;
        //        btnchild.Height = 70;
        //        if (dt.Rows[i]["fontcolor"].ToString() != "")
        //        {
        //            btnchild.ForeColor = ColorTranslator.FromHtml(dt.Rows[i]["fontcolor"].ToString());
        //        }
        //        if (dt.Rows[i]["backgroundcolor"].ToString() != "")
        //        {
        //            btnchild.BackColor = ColorTranslator.FromHtml(dt.Rows[i]["backgroundcolor"].ToString());
        //        }
        //        byte[] photo = (byte[])dt.Rows[i]["image"];
        //        if (photo.Length != 4)
        //        {
        //            MemoryStream ms = new MemoryStream(photo);
        //            Bitmap bmp = new Bitmap(ms);
        //            btnchild.Image = bmp;
        //        }
               
        //        btnchild.Tag = dt.Rows[i]["itemid"].ToString();
        //        btnchild.Text = dt.Rows[i]["Description"].ToString();
        //        btnchild.Click += new EventHandler(btnchild_Click);
               
        //        childlayout.Controls.Add(btnchild);
        //    }
            
        //}

        //void btnchild_Click(object sender, EventArgs e)
        //{
        //    grdPOS.Focus();
        //    Button bt = (Button)sender;
        //    AddRecord(Convert.ToInt64(bt.Tag));
        //    CalcGridTotal();

        //}
        ////private void AddRecord(Int64 id)
        ////{
        ////    items.itemid = id.ToString();
        ////    DataTable dt = items.GetPOSRecord();
        ////    int count = grdPOS.Rows.Count;
        ////    int rowIndex = DataExists(id);
        ////    //if (rowIndex != -1)
        ////    //{
        ////    //    grdPOS.Rows[rowIndex].Cells[3].Value = Convert.ToDouble(grdPOS.Rows[rowIndex].Cells[3].Value) + 1;
        ////    //    grdPOS.Rows[rowIndex].Cells[5].Value = Convert.ToDouble(grdPOS.Rows[rowIndex].Cells[3].Value) * Convert.ToDouble(grdPOS.Rows[rowIndex].Cells[4].Value);
        ////    //}
        ////    //else
        ////    //{

        ////    if (grdPOS.CurrentCell.ColumnIndex == 1)
        ////    {
        ////        grdPOS.Rows[grdPOS.CurrentCell.RowIndex].Cells[1].Value = dt.Rows[0]["Description"];
        ////        grdPOS.Rows[grdPOS.CurrentCell.RowIndex].Cells[2].Value = dt.Rows[0]["unit"];
        ////        grdPOS.Rows[grdPOS.CurrentCell.RowIndex].Cells[3].Value = 1;
        ////        grdPOS.Rows[grdPOS.CurrentCell.RowIndex].Cells[4].Value = dt.Rows[0]["salesrate"];
        ////        grdPOS.Rows[grdPOS.CurrentCell.RowIndex].Cells[5].Value = dt.Rows[0]["salesrate"];
        ////        grdPOS.Rows[grdPOS.CurrentCell.RowIndex].Cells[6].Value = dt.Rows[0]["itemid"];
        ////    }

        ////    else
        ////    {
        ////        DataGridViewRow dr = (DataGridViewRow)this.grdPOS.Rows[0].Clone();
        ////        dr.Cells[0].Value = count;
        ////        dr.Cells[1].Value = dt.Rows[0]["Description"];
        ////        dr.Cells[2].Value = dt.Rows[0]["unit"];
        ////        dr.Cells[3].Value = 1;
        ////        dr.Cells[4].Value = dt.Rows[0]["salesrate"];
        ////        dr.Cells[5].Value = dt.Rows[0]["salesrate"];
        ////        dr.Cells[6].Value = dt.Rows[0]["itemid"];

        ////        grdPOS.Rows.Add(dr);


        ////    }
        ////    //}
        ////    int fcount = grdPOS.Rows.Count;

        ////    grdPOS.CurrentCell = grdPOS.Rows[fcount - 2].Cells[2];
        ////    CalcTotal();

        ////}
        ////-----------Restuarant AddRecord.(below)-----
        //private void AddRecord(Int64 id)
        //{
        //    items.itemid = id.ToString();
        //    DataTable dt = items.GetPOSRecord();
        //    int count = grdPOS.Rows.Count;
        //    int rowIndex = DataExists(id);
        //    if (rowIndex != -1)
        //    {
        //        grdPOS.Rows[rowIndex].Cells[3].Value = Convert.ToDouble(grdPOS.Rows[rowIndex].Cells[3].Value) + 1;
        //        grdPOS.Rows[rowIndex].Cells[5].Value = Convert.ToDouble(grdPOS.Rows[rowIndex].Cells[3].Value) * Convert.ToDouble(grdPOS.Rows[rowIndex].Cells[4].Value);
        //    }
        //    else
        //    {

        //        if (grdPOS.CurrentCell.ColumnIndex == 1)
        //        {
        //            grdPOS.Rows[grdPOS.CurrentCell.RowIndex].Cells[1].Value = dt.Rows[0]["Description"];
        //            grdPOS.Rows[grdPOS.CurrentCell.RowIndex].Cells[2].Value = dt.Rows[0]["unit"];
        //            grdPOS.Rows[grdPOS.CurrentCell.RowIndex].Cells[3].Value = 1;
        //            grdPOS.Rows[grdPOS.CurrentCell.RowIndex].Cells[4].Value = dt.Rows[0]["salesrate"];
        //            grdPOS.Rows[grdPOS.CurrentCell.RowIndex].Cells[5].Value = dt.Rows[0]["salesrate"];
        //            grdPOS.Rows[grdPOS.CurrentCell.RowIndex].Cells[6].Value = dt.Rows[0]["itemid"];
        //        }

        //        else
        //        {
        //            DataGridViewRow dr = (DataGridViewRow)this.grdPOS.Rows[0].Clone();
        //            dr.Cells[0].Value = count;
        //            dr.Cells[1].Value = dt.Rows[0]["Description"];
        //            dr.Cells[2].Value = dt.Rows[0]["unit"];
        //            dr.Cells[3].Value = 1;
        //            dr.Cells[4].Value = dt.Rows[0]["salesrate"];
        //            dr.Cells[5].Value = dt.Rows[0]["salesrate"];
        //            dr.Cells[6].Value = dt.Rows[0]["itemid"];

        //            grdPOS.Rows.Add(dr);


        //        }
        //    }
        //    int fcount = grdPOS.Rows.Count;

        //    grdPOS.CurrentCell = grdPOS.Rows[fcount - 2].Cells[2];
        //    CalcTotal();

        //}
        //private int DataExists(Int64 id)
        //{
        //    for (int i = 0; i < grdPOS.Rows.Count; i++)
        //    {
        //        if (grdPOS.Rows[i].Cells[6].Value != null)
        //        {
        //            if (Convert.ToInt64(grdPOS.Rows[i].Cells[6].Value.ToString()) == id)
        //            {
        //                return i;
        //            }
        //        }
        //    }
        //    return -1;
        //}

        //private void groupBox4_Enter(object sender, EventArgs e)
        //{

        //}
        //private void CalcTotal()
        //{
        //    double total = 0;
        //    for (int i = 0; i < grdPOS.Rows.Count; i++)
        //    {
        //        total += Convert.ToDouble(grdPOS.Rows[i].Cells[5].Value);
        //    }
        //    txttotal.Text = total.ToString();
        //}

       

        

       
        //private void btnoperator_Click(object sender, EventArgs e)
        //{
        //    DataGridViewCell cell = grdPOS.CurrentCell;
        //    Button optor = (Button)sender;
        //    group.Operator = optor.Text;
        //    group.Operand = Convert.ToInt64(cell.Value);
        //    group.Operation = true;
        //}
        int curSelStart = 0;
        TextBox curTB = null;
        //private const int WS_EX_NOACTIVATE = 0x08000000;

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams p = base.CreateParams;
        //        p.ExStyle |= WS_EX_NOACTIVATE;
        //        return p;
        //    }
        //}
//        DataGridViewCell tmpcell = null;
//        private void btnaction_click(object sender, EventArgs e)
//        {
            
            
//            //if (group.Operation)
//            //{
//            //    cell.Value = "";
//            //    group.Operation = false;
//            //}
//            Button btn = (Button)sender;
           
//            //string operand = cell.Value + btn.Text;
//            //cell.Value = operand;
//            //CalcGridTotal();
//            //CalcTotal();
//            //text.Focus();
//            if (_focused is TextBox)
//            {
//                TextBox txt = (TextBox)_focused;
//                txt.Focus();
//                SendKeys.Send(btn.Text);
//            }
//            else if (_focused is DataGridView)
//            {
//                DataGridViewCell cell = grdPOS.CurrentCell;
//                string input = btn.Text;
//                if (cell == null) { Console.Beep(); return; }
//                else
//                {
//                    if (curTB == null) curSelStart = -1;
//                    else curSelStart = curTB.SelectionStart;

                   
//                        string cs = cell.Value == null ? "" : cell.Value.ToString();

//                        if (curSelStart >= 0 && curSelStart < cs.Length)
//                            cell.Value = cs.Insert(curSelStart, input);
//                        else cell.Value = cs + input;
                    
//                }

//            }

//            //if(txt.Text.Length>0)
//            //{
//            //txt.SelectionStart = txt.Text.Length - 1;
//            //}

//            //txt.SelectionLength = 0;
//            //Button btn = (Button)sender;
//            //txt.AppendText(btn.Text);
//          //  txtpaid.Focus();
           
            
//        }
//        private void btnequal_Click(object sender, EventArgs e)
//        {
//            DataGridViewCell cell = grdPOS.CurrentCell;
            
//            double result = 0;
//            switch (group.Operator)
//            {
//                case "+":
//                        {
//                         result=group.Operand +Convert.ToDouble(cell.Value);
//                         break;
//                        }
//                case "-":
//                        {
//                            result = group.Operand - Convert.ToDouble(cell.Value);
//                            break;
//                        }
//                case "*":
//                        {
//                            result = group.Operand * Convert.ToDouble(cell.Value);
//                            break;
//                        }
//                case "/":
//                        {
//                            if (Convert.ToDouble(cell.Value) != 0)
//                            {
//                                result = group.Operand / Convert.ToDouble(cell.Value);
//                            }
                           
//                            break;
//                        }
//                default:
//                    break;
//            }
//            group.Operation = false;
//            cell.Value = result;
//            CalcGridTotal();
//          //  CalcTotal();
//        }

//        private void groupBox3_Enter(object sender, EventArgs e)
//        {

//        }

//        private void btnclear_Click(object sender, EventArgs e)
//        {
//            DataGridViewCell cell = grdPOS.CurrentCell;
//            cell.Value = "";
//            group.Operator = null;
//            group.Operand = 0;
//        }
//        private void CalcGridTotal()
//        {
//            try
//            {
//                double grandtotal = 0;
//                for (int i = 0; i < grdPOS.Rows.Count; i++)
//                {
//                    double quantity = 0;
//                    double price = 0;
//                    double total = 0;
//                    if (grdPOS.Rows[i].Cells[3].Value != null && grdPOS.Rows[i].Cells[3].Value.ToString() != "")
//                    {
//                        quantity = Convert.ToDouble(grdPOS.Rows[i].Cells[3].Value);
//                    }
//                    if (grdPOS.Rows[i].Cells[4].Value != null)
//                    {
//                        price = Convert.ToDouble(grdPOS.Rows[i].Cells[4].Value);
//                    }
//                    total = quantity * price;
//                    grdPOS.Rows[i].Cells[5].Value = total;
//                    grandtotal += total;


//                }
//                double disc = 0;
//                if (txtdisc.Text != "")
//                {
//                    disc = Convert.ToDouble(txtdisc.Text);
//                }
//                txtnet.Text = Convert.ToString(grandtotal - disc);
//                txtpaid.Text = txtnet.Text;

//                double balance = Convert.ToDouble(txtnet.Text) - Convert.ToDouble(txtpaid.Text);
//                txtbalance.Text = balance.ToString();
//                if (edit)
//                    return;
//                double oldbal = (txtoldbalance.Text != "") ? Convert.ToDouble(txtoldbalance.Text) : 0;
//            }
//            catch (Exception e)
//            {

//            }
            
//        }

//        private void grdPOS_CellLeave(object sender, DataGridViewCellEventArgs e)
//        {
//            group.Operation = true;
            
//        }

//        private void txtdisc_TextChanged(object sender, EventArgs e)
//        {
//            try
//            {
//            double discount = (txtdisc.Text != "") ? Convert.ToDouble(txtdisc.Text) : 0;
//            double total = (txttotal.Text != "") ? Convert.ToDouble(txttotal.Text) : 0;
            
//            double disc =  (total* discount) / 100;
//            txtnet.Text=Convert.ToString(total-disc);
//            txtpaid.Text = txtnet.Text;
//            CalcDiscAmount();
//            txtdisc.Select(txtdisc.Text.Length, 0);
                
//            }
//            catch(Exception ex)
//            {
//            }
            
//        }
//        private void CalcDiscAmount()
//        {
//            double totalamount =0;
//            double discount = (txtdisc.Text == "") ? 0 : Convert.ToDouble(txtdisc.Text);
//            for (int i = 0; i < grdPOS.Rows.Count - 1; i++)
//            {
//                totalamount += Convert.ToDouble(grdPOS.Rows[i].Cells[5].Value.ToString());

//            }
//            if (totalamount == 0) return;
//            if (discount == 0 || discount.ToString() == "")
//                txtdiscamount.Text = "";
//            else
//                txtdiscamount.Text = Math.Round((((totalamount * discount) / 100)),2).ToString();
//            txtdiscamount.Select(txtdiscamount.Text.Length, 0);

//        }

//        private void txtpaid_TextChanged(object sender, EventArgs e)
//        {
           
//            double paid =(txtpaid.Text!="")? Convert.ToDouble(txtpaid.Text):0;
//            double net =(txtnet.Text!="")? Convert.ToDouble(txtnet.Text):0;
//            txtbalance.Text = Convert.ToString(paid - net);
//            double oldbalance =(txtoldbalance.Text!="")? Convert.ToDouble(txtoldbalance.Text):0;
//            txtnewbalance.Text = "";
//            if (oldbalance < 0)
//            {
//                txtnewbalance.Text = Convert.ToString((paid - net) + oldbalance);
//            }
//            else
//            {
//                txtnewbalance.Text = Convert.ToString((paid -net)-oldbalance);
//            }
//        }

//        private void txtpaid_Leave(object sender, EventArgs e)
//        {
            
//        }

//        private void txtnet_TextChanged(object sender, EventArgs e)
//        {
//            //txtpaid.Text = txtnet.Text;
//        }

//        private void grdPOS_CellEndEdit(object sender, DataGridViewCellEventArgs e)
//        {

//        }

//        private void btnreceipt_Click(object sender, EventArgs e)
//        {
//            if (MessageBox.Show("Do you really want to close the sale ?  ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
//            {
//                sales.salesdate =Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
//                DataTable dt = sales.CloseSalesPrint();
//                frmviewsalesreport frm = new frmviewsalesreport();
//                frm.datefrom = Convert.ToDateTime(dt.Rows[0]["salesdate"].ToString());
//                frm.dateto = Convert.ToDateTime(dt.Rows[0]["salesdate"].ToString());
//                frm.timefrom = Convert.ToDateTime(dt.Rows[0]["salestime"].ToString());
//                frm.timeto = DateTime.Now;
//                frm.Show();
//                sales.CloseSale = 1;
//                sales.ClosingSale();
//            }
//        }
//        private bool SetData()
//        {
//            try
//            {
//                if (Validation())
//                {
//                    //------------------------general Ledger -------------------------------------
//                    generalledger.ledcode = generalledger.GetNextId();
//                    generalledger.voucherno = txtinvoiceno.Text;
//                    generalledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
//                    generalledger.ledgertime = DateTime.Now;
//                    generalledger.particulars = cmbcustomer.Text;
//                    generalledger.Debitamt = Convert.ToDouble(txtnet.Text);
//                    generalledger.Creditamt = 0;
//                    generalledger.Balance = 0;
//                    generalledger.VType = "SI";

//                    generalledger.DeleteLedger();
//                    generalledger.Add();

//                    //generalledger.ledcode = generalledger.GetNextId();
//                    //generalledger.voucherno = txtinvoiceno.Text;
//                    //generalledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
//                    //generalledger.ledgertime = DateTime.Now;
//                    //generalledger.particulars = "Sales Account";
//                    //generalledger.Debitamt = Convert.ToDouble(txtnet.Text);
//                    //generalledger.Creditamt = 0;
//                    //generalledger.Balance = 0;
//                    //generalledger.VType = "SI";


//                    //generalledger.Add();
//                    if (txtpaid.Text != "0.00")
//                    {

//                        generalledger.ledcode = generalledger.GetNextId();
//                        generalledger.voucherno = txtinvoiceno.Text;
//                        generalledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
//                        generalledger.ledgertime = DateTime.Now;
//                        generalledger.particulars = cmbcustomer.Text;
//                        generalledger.Debitamt = 0;
//                        generalledger.Creditamt = Convert.ToDouble(txtpaid.Text);
//                        generalledger.Balance = 0;
//                        generalledger.VType = "CR";
//                        generalledger.DeleteLedger();
//                        generalledger.Add();

//                        //generalledger.ledcode = generalledger.GetNextId();
//                        //generalledger.voucherno = txtinvoiceno.Text;
//                        //generalledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
//                        //generalledger.ledgertime = DateTime.Now;
//                        //generalledger.particulars = "Cash Account";
//                        //generalledger.Debitamt = 0;
//                        //generalledger.Creditamt = Convert.ToDouble(txtpaid.Text); ;
//                        //generalledger.Balance = 0;
//                        //generalledger.VType = "CR";
//                        //generalledger.Add();
//                    }




//                    //posinvoice.posinvoice = Convert.ToInt64(txtinvoiceno.Text);
//                    //posinvoice.customerid = customer.customerid;
//                    //posinvoice.paidcash =Convert.ToDouble(txtpaid.Text);
//                    //posinvoice.discount =(txtdisc.Text!="")? Convert.ToDouble(txtdisc.Text):0;
//                    //posinvoice.posdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

//                    //posinvoice.Delete();
//                    //posdetails.posinvoice = posinvoice.posinvoice;
//                    //posdetails.DeleteDetails();
//                    //grdPOS.EndEdit();
                    
//                    sales.salesinvoice = txtinvoiceno.Text;
//                    sales.salesdate = Convert.ToDateTime(txtdate.Text);
//                    sales.SalesTime = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
//                    sales.UserId = clsuserinfo.UID;
//                    sales.TokenNo =(txttokenno.Text=="")?clstokensettings.GetNextToken():Convert.ToInt64(txttokenno.Text);
//                    sales.customerid = customer.customerid;
//                    sales.discount = Convert.ToDouble((txtdisc.Text != "") ? txtdisc.Text : "0");
//                   // sales.additionaldiscount = Convert.ToDouble((txtadddiscount.Text != "") ? txtadddiscount.Text : "0");
//                    sales.paidcash = Convert.ToDouble((txtpaid.Text != "") ? txtpaid.Text : "0");
//                    sales.Remarks = remarks;
//                   // sales.paidcheque = Convert.ToDouble((txtpaidcheque.Text != "") ? txtpaidcheque.Text : "0");
//                    sales.Delete();
//                    salesdetails.DeleteDetails();
//                    grdPOS.EndEdit();
//                    for (int i = 0; i < grdPOS.Rows.Count - 1; i++)
//                    {
//                        //posdetails.posdetailsid = posdetails.GetNextId();
//                        //posdetails.posinvoice = posinvoice.posinvoice;
//                        //posdetails.itemid = Convert.ToInt64(grdPOS.Rows[i].Cells[5].Value);
//                        //posdetails.quantity = Convert.ToDouble(grdPOS.Rows[i].Cells[2].Value);
//                        //posdetails.price = Convert.ToDouble(grdPOS.Rows[i].Cells[3].Value);

//                        salesdetails.salesid = salesdetails.GetNextId();
//                        salesdetails.invoiceno = txtinvoiceno.Text;
//                        salesdetails.itemid = Convert.ToString(grdPOS.Rows[i].Cells[6].Value);
//                        salesdetails.quantity = Convert.ToDouble(grdPOS.Rows[i].Cells[3].Value);
//                        if (grdPOS.Rows[i].Cells[2].Value != null)
//                        {
//                            salesdetails.unit = Convert.ToString(grdPOS.Rows[i].Cells[2].Value);
//                            //items.Unit = Convert.ToString(grdPOS.Rows[i].Cells[2].Value);
//                        }
//                       // salesdetails.Supplier = Convert.ToString(grdsales.Rows[i].Cells[7].Value);
//                        salesdetails.SalesRate = Convert.ToDouble(grdPOS.Rows[i].Cells[4].Value);
//                       // salesdetails.NewCost = Convert.ToDouble(grdsales.Rows[i].Cells[8].Value);
//                        salesdetails.Add();

//                        items.itemid = salesdetails.itemid.ToString();
//                        items.salesrate = salesdetails.SalesRate;
//                        if(items.GetItems())
//                        {
//                            items.EditPrice();
//                        }
                       

//                    }
//                    return true;
//                }
//                return false;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//                return false;
//            }
//        }
//        private bool Validation()
//        {
//            if(cmbcustomer.Text=="")
//            {
//                errorPOS.SetError(cmbcustomer, "Customer name is required");
//                return false;

//            }
//           //if(txtphoneno.Text=="")
//           //{
//           //    errorPOS.SetError(txtphoneno , "Phone Number is required");
//           //    return false;

//           //}
//            foreach (DataGridViewRow row in grdPOS.Rows)
//            {

//                foreach (DataGridViewCell cell in row.Cells)
//                {
//                    // Validating cell value
//                    if(grdPOS.Rows.Count>1)
//                    {

//                    if (row.IsNewRow) { return true; }
//                    }
//                    if (cell.Value == null)
//                    {
//                        cell.Style.BackColor = Color.Red;

//                        grdPOS.BeginEdit(true);
//                        return false;
//                    }
//                    else
//                    {
//                        cell.Style.BackColor = row.DefaultCellStyle.BackColor;
//                    }
//                }
//            }
//            return false;
//        }
//        private void Clear()
//        {
//            cmbcustomer.Text = "";
//            cmbcustomer.DataSource = customer.GetRecord();
//            cmbcustomer.ValueMember = "customerid";
//            cmbcustomer.DisplayMember = "customername";
            
//            txtaddress.Text = string.Empty;
//            txtphoneno.Text = string.Empty;
//            txttokenno.Text = string.Empty;
//            txtinvoiceno.Text = sales.GetNextId().ToString();
//          //  AddInvoice();
//            txtnet.Text = string.Empty;
//            txtbalance.Text = string.Empty;
//            txtoldbalance.Text = string.Empty;
//            txtnewbalance.Text = string.Empty;
//            txtpaid.Text = string.Empty;
//            txtdate.Text = txtdate.Text;
//            txtdate.Text  = DateTime.Now.ToString("dd/MM/yyyy");
//            txttotal.Text = "0";
//            txtdisc.Text = string.Empty;
//            txtdiscamount.Text = string.Empty;
//            txtnewbalance.Text = "0";
//            grdPOS.Rows.Clear();
//            grdPOS.Focus();
//            remarks = "";
//            _focused = null;
//            errorPOS.Clear();
            
//        }

//        private void btnEdit_Click(object sender, EventArgs e)
//        {
//            DisableControls(true);
//        }

//        private void btnenter_Click(object sender, EventArgs e)
//        {
//            SaveTender();
//        }
//        private void SaveTender()
//        {
//            if (!Validation())
//            {
//                return;
//            }
//            frmTender frm = new frmTender();
//            //frm.MdiParent = this.MdiParent;

//            customer.customername = cmbcustomer.Text;
//            customer.address = txtaddress.Text;
//            customer.CusOpening = (txtopening.Text != "") ? Convert.ToDouble(txtopening.Text) : 0;
//            customer.phonenumber = txtphoneno.Text;
//            customer.addeddate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
//            if (cmbcustomer.SelectedIndex != -1)
//            {
//                frm.customerid = Convert.ToInt64(cmbcustomer.SelectedValue);
//                customer.customerid = Convert.ToInt64(cmbcustomer.SelectedValue);
//                if (customer.GetItems())
//                {
//                    customer.Edit();
//                }

//            }
//            else
//            {
//                customer.customerid = customer.GetNextId();
//                customer.Add();
//                frm.customerid = customer.customerid;
//            }
//            frm.total = Convert.ToDouble(txtnet.Text);
//            frm.paidamount = Convert.ToDouble(txtpaid.Text);
//           // KeyPadStart();
//            DialogResult result = frm.ShowDialog();
//            if (result == DialogResult.OK)
//            {
//                txtpaid.Text = frm.paidamount.ToString();
//                if (SetData())
//                {
//                    if (sales.GetItems())
//                    {
//                        sales.Edit();
//                    }
//                    else
//                    {
//                        sales.Add();
//                    }
//                    //frmposreport frmpos = new frmposreport();
//                    //frmpos.posinvoice = Convert.ToInt64(sales.salesinvoice);
//                    //frmpos.particulars = cmbcustomer.Text;
//                    //frmpos.MdiParent = this.MdiParent;
//                    //frmpos.Show();
//                    PrintReceipt();
//                    Clear();

//                }
//            }
//            else if (result == DialogResult.Yes)
//            {
//                txtpaid.Text = frm.paidamount.ToString();
//                if (SetData())
//                {
//                    if (sales.GetItems())
//                    {
//                        sales.Edit();
//                    }
//                    else
//                    {
//                        sales.Add();
//                    }

//                    Clear();

//                }

//            }
//        }
//        private void SaveandPrint()
//        {
//            if (!Validation())
//            {
//                return;
//            }
//            frmTender frm = new frmTender();
//            //frm.MdiParent = this.MdiParent;

//            customer.customername = cmbcustomer.Text;
//            customer.address = txtaddress.Text;
//            customer.CusOpening = (txtopening.Text != "") ? Convert.ToDouble(txtopening.Text) : 0;
//            customer.phonenumber = txtphoneno.Text;
//            customer.addeddate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
//            if (cmbcustomer.SelectedIndex != -1)
//            {
//                frm.customerid = Convert.ToInt64(cmbcustomer.SelectedValue);
//                customer.customerid = Convert.ToInt64(cmbcustomer.SelectedValue);
//                if (customer.GetItems())
//                {
//                    customer.Edit();
//                }

//            }
//            else
//            {
//                customer.customerid = customer.GetNextId();
//                customer.Add();
//                frm.customerid = customer.customerid;
//            }
//            frm.total = Convert.ToDouble(txtnet.Text);
//            frm.paidamount = Convert.ToDouble(txtpaid.Text);
//            // KeyPadStart();
//            //DialogResult result = frm.ShowDialog();
//                txtpaid.Text = frm.paidamount.ToString();
//                if (SetData())
//                {
//                    if (sales.GetItems())
//                    {
//                        sales.Edit();
//                    }
//                    else
//                    {
//                        sales.Add();
//                    }
//                    PrintReceipt();
//                    Clear();

//                }

            

//        }
//        private void txtinvoiceno_TextChanged(object sender, EventArgs e)
//        {
//           AddSelRecord();
//           errorPOS.Clear();
//        }
//        private void AddSelRecord()
//        {
//            if (txtinvoiceno.Text == "")
//                return;
          
//            //posinvoice.posinvoice = Convert.ToInt64(txtinvoiceno.Text);
//            //posdetails.posinvoice = Convert.ToInt64(txtinvoiceno.Text);
//            sales.salesinvoice = txtinvoiceno.Text;
           
//            salesdetails.invoiceno=txtinvoiceno.Text;
//            DataTable dt = sales.GetSelRecord();
            
//            if (dt.Rows.Count > 0)
//            {
//                edit = true;
//                cmbcustomer.SelectedValue  = dt.Rows[0]["customerid"];
//                customer.customerid = Convert.ToInt64(dt.Rows[0]["customerid"]);
//                DataTable dtcustomer = customer.GetSelRecord();
//                txtdate.Text = Convert.ToDateTime(dt.Rows[0]["salesdate"]).ToString("dd/MM/yyyy");
//                clsproperties.Remarks = dt.Rows[0]["remarks"].ToString();
//                txtaddress.Text = dtcustomer.Rows[0]["address"].ToString();
//                txtphoneno.Text = dtcustomer.Rows[0]["phonenumber"].ToString();
//                txtopening.Text = dtcustomer.Rows[0]["Cusopening"].ToString();
//                txttokenno.Text = dt.Rows[0]["tokenno"].ToString();
//                DataTable dtDet = salesdetails.GetSelRecord();
//                int count = 1;
//                grdPOS.Rows.Clear();
//                for (int i = 0; i < dtDet.Rows.Count; i++)
//                {
//                    DataGridViewRow dr = (DataGridViewRow)this.grdPOS.Rows[0].Clone();
//                    dr.Cells[0].Value = count;
//                    dr.Cells[1].Value = dtDet.Rows[i]["Description"];
//                    dr.Cells[2].Value= dtDet.Rows[i]["unit"];
//                    dr.Cells[3].Value = dtDet.Rows[i]["quantity"];
//                    dr.Cells[4].Value = dtDet.Rows[i]["salesrate"];
//                    dr.Cells[5].Value = Convert.ToDouble(dtDet.Rows[i]["quantity"]) * Convert.ToDouble(dtDet.Rows[i]["salesrate"]);
//                    dr.Cells[6].Value = dtDet.Rows[i]["itemid"];
                    
//                    grdPOS.Rows.Add(dr);
//                    count++;
//                }
               
                
                
                
//                txtdisc.Text =Convert.ToString(dt.Rows[0]["discount"]);
//                txtnet.Text = posinvoice.CalcNetAmt(grdPOS,txtdisc.Text);
//                txtoldbalance.Text = generalledger.OldBalance().ToString();
//                txtpaid.Text = dt.Rows[0]["paidcash"].ToString();
//                double paid = Convert.ToDouble(txtpaid.Text);
//                double net = Convert.ToDouble(txtnet.Text);
//                txtbalance.Text = Convert.ToString(paid-net);
//                generalledger.particulars = cmbcustomer.Text;
//                generalledger.voucherno = txtinvoiceno.Text;
//              //  CalcTotal();
                
//                DisableControls(false);
//                if (sales.Status())
//                {
//                    this.ForeColor = Color.Red;
//                    btnEdit.Enabled = false;
//                    btndelete.Enabled = false;
//                    btnprint.Enabled = false;

//                }
//                else
//                {
//                    this.ForeColor = SystemColors.ControlText;
//                }
                
//            }
//            else
//            {

//                txtaddress.Text = string.Empty;
//                txtphoneno.Text = string.Empty;
                
                
//                txtnet.Text = string.Empty;
//                txtbalance.Text = string.Empty;
//                txtoldbalance.Text = string.Empty;
//                txtnewbalance.Text = string.Empty;
//                txtpaid.Text = string.Empty;
//                txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
//                txttotal.Text = "0";
//                txtdisc.Text = string.Empty;
//                txtnewbalance.Text = "0";
//                grdPOS.Rows.Clear();
//                grdPOS.Focus();
//                remarks = "";
//                errorPOS.Clear();
//                DisableControls(true);
//                txtinvoiceno.Focus();
//                edit = false;
//                this.ForeColor = SystemColors.ControlText;
//            }

           
//        }

//        private void txtinvoiceno_Leave(object sender, EventArgs e)
//        {

            
//        }
//        private void DisableControls(bool enabled)
//        {

//            foreach (Control c in this.Controls)
//            {
//                if (c is GroupBox )
//                {

//                    foreach (Control grpcnt in c.Controls)
//                    {
//                        if (grpcnt != txtinvoiceno  && grpcnt != btnclose && !(grpcnt is Label) && grpcnt!=flowLayoutPanel2 && grpcnt!=btnprint)
//                        {
//                            grpcnt.Enabled = enabled;
//                            if (!(grpcnt is Button) && !(grpcnt is FlowLayoutPanel))
//                                {
//                                    grpcnt.BackColor = SystemColors.ControlLightLight;
//                                }
                            
//                        }
//                        else if (grpcnt == flowLayoutPanel2)
//                        {
//                            foreach (Control flwcnt in flowLayoutPanel2.Controls)
//                                {
//                                    if (flwcnt == btnclose || flwcnt==btnprint || flwcnt==btndelete )
//                                    {
//                                        flwcnt.Enabled = true;
//                                    }
   
//                                    else
//                                    {
//                                        flwcnt.Enabled =enabled;
//                                    }
//                                }
                            
//                        }
//                        if (grpcnt == btnEdit ||  grpcnt == btnprint || grpcnt==btndelete)
//                        {
//                            grpcnt.Enabled = !enabled;
//                        }
                       
//                    }
//                }
                
//                else
//                {
//                    if (!(c is Label))
//                    {
//                        c.Enabled = enabled;
//                        c.BackColor = SystemColors.ControlLightLight;
//                    }
//                }
//            }

//        }

//        private void grouplayout_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void cmbcustomer_Leave(object sender, EventArgs e)
//        {
//            if (cmbcustomer.SelectedIndex == -1)
//            {
//                txtaddress.Text = string.Empty;
//                txtphoneno.Text = string.Empty;
//                txtoldbalance.Text = string.Empty;
//                txtnewbalance.Text = string.Empty;
//            }
//        }

//        private void btnclose_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void btnprint_Click(object sender, EventArgs e)
//        {
//           // frmposreport frm = new frmposreport();
//           // frm.posinvoice = Convert.ToInt64(txtinvoiceno.Text);
//           // frm.particulars = cmbcustomer.Text;
//           // frm.MdiParent = this.MdiParent;
//           // frm.Show();
//           // PrintReceipt();
//            SaveandPrint();
            
            
           
//        }
//        private void PrintReceipt()
//        {
//            try
//            {
//                //string path = Application.StartupPath + "\\CrystalReports\\cryPosreport.rpt";
//                int i = 0;
//                string[] strkeys =System.Configuration.ConfigurationManager.AppSettings.AllKeys;
//                foreach (string key in strkeys)
//                {
//                    string[] rptname = System.Configuration.ConfigurationManager.AppSettings.GetValues(key);

//                    //while (i != 2)
//                    //{
//                    string path = "";
//                    path = Application.StartupPath + "\\CrystalReports\\"+key;
//                    //path = Application.StartupPath + "\\CrystalReports\\cryDeliveryNote.rpt";

//                    if (!File.Exists(path))
//                    {
//                        MessageBox.Show("The Directory CrystalReports or Report File cryPosreport.rpt Not Exists");
//                        return;
//                    }
//                    posTableAdapter pos = new posTableAdapter();
//                    dsReport.PosInvoiceDataTable dt = pos.GetData(Convert.ToInt64(txtinvoiceno.Text));
//                    salesinvoiceTableAdapter saladapter = new salesinvoiceTableAdapter();
//                    dsReport.salesinvoiceDataTable satd = saladapter.GetData(Convert.ToString(txtinvoiceno.Text));

//                    generalledger.particulars = cmbcustomer.Text;
//                    generalledger.voucherno = Convert.ToString(posinvoice);
//                    double oldbalance = Convert.ToDouble(generalledger.OldBalance());

//                    ReportDocument rDoc = new ReportDocument();
//                    //if (i == 0)
//                    //{
//                    //    rDoc.Load(Application.StartupPath + "\\CrystalReports\\cryPosreport.rpt");
//                    //}
//                    //else if (i == 1)
//                    //{
//                    //    rDoc.Load(Application.StartupPath + "\\CrystalReports\\cryDeliveryNote.rpt");
//                    //}

//                    rDoc.Load(path);
//                    rDoc.SetDataSource((DataTable)satd);
//                    rDoc.SetParameterValue("oldbalance", oldbalance);
//                    rDoc.PrintOptions.PrinterName=rptname[0];
//                    PageSettings setings = new PageSettings();
                    
//                    rDoc.PrintToPrinter(1, true, 1, 1);
//                    rDoc.Dispose();
//                    rDoc.Close();
//                }
                    
//                //    i++;
//                //}
//            }
//            catch (Exception e)
//            {

//                MessageBox.Show(e.Message);
//            }
            
//        }
//        private void DelPrint()
//        {
//            try
//            {
//                string path = "";
//                    path = Application.StartupPath + "\\CrystalReports\\cryDelete.rpt";
//                    //path = Application.StartupPath + "\\CrystalReports\\cryDeliveryNote.rpt";

//                    if (!File.Exists(path))
//                    {
//                        MessageBox.Show("The Directory CrystalReports or Report File cryDelete.rpt Not Exists");
//                        return;
//                    }
//                    posTableAdapter pos = new posTableAdapter();
//                    dsReport.PosInvoiceDataTable dt = pos.GetData(Convert.ToInt64(txtinvoiceno.Text));
//                    salesinvoiceTableAdapter saladapter = new salesinvoiceTableAdapter();
//                    dsReport.salesinvoiceDataTable satd = saladapter.GetData(Convert.ToString(txtinvoiceno.Text));

//                    generalledger.particulars = cmbcustomer.Text;
//                    generalledger.voucherno = Convert.ToString(posinvoice);
//                    double oldbalance = Convert.ToDouble(generalledger.OldBalance());

//                    ReportDocument rDoc = new ReportDocument();
//                    //if (i == 0)
//                    //{
//                    //    rDoc.Load(Application.StartupPath + "\\CrystalReports\\cryPosreport.rpt");
//                    //}
//                    //else if (i == 1)
//                    //{
//                    //    rDoc.Load(Application.StartupPath + "\\CrystalReports\\cryDeliveryNote.rpt");
//                    //}

//                    rDoc.Load(path);
//                    rDoc.SetDataSource((DataTable)satd);
//                    rDoc.SetParameterValue("oldbalance", oldbalance);
//                    //rDoc.PrintOptions.PrinterName=rptname[0];
//                    PageSettings setings = new PageSettings();
                    
//                    rDoc.PrintToPrinter(1, true, 1, 1);
//                    rDoc.Dispose();
//                    rDoc.Close();
//            }
//            catch (Exception ex)
//            {

//                MessageBox.Show(ex.Message);
//            }
//        }
//        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
//        {
//            float linesPerPage = 0;
//            float yPos = 0;
//            int count = 0;
//            float leftMargin = ev.MarginBounds.Left;
//            float topMargin = ev.MarginBounds.Top;
//            string line = null;

//            // Calculate the number of lines per page.
//            linesPerPage = ev.MarginBounds.Height /
//               printFont.GetHeight(ev.Graphics);

//            // Print each line of the file. 
//            while (count < linesPerPage &&
//               ((line = streamToPrint.ReadLine()) != null))
//            {
//                yPos = topMargin + (count *
//                   printFont.GetHeight(ev.Graphics));
//                ev.Graphics.DrawString(line, printFont, Brushes.Black,
//                   leftMargin, yPos, new StringFormat());
//                count++;
//            }

//            // If more lines exist, print another page. 
//            if (line != null)
//                ev.HasMorePages = true;
//            else
//                ev.HasMorePages = false;
//        }
//        [DllImport("user32.dll", SetLastError = true)]
//        private static extern bool MoveWindow(IntPtr hWnd, int x, int y, int width, int height, bool repaint);
//       [DllImport("user32.dll")]
//private extern static bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);


//        private void frmPOS_Load(object sender, EventArgs e)
//        {
//            //keypad = new frmKeypad();
//            //keypad.Show();
//           // KeyPadStart();
//            txtpaid.GotFocus += new EventHandler(txtpaid_GotFocus);
//            txtdisc.GotFocus += new EventHandler(txtpaid_GotFocus);
//            txtdiscamount.GotFocus += new EventHandler(txtpaid_GotFocus);
//            txtpaid.Leave+=new EventHandler(txtpaid_Leave);
//            txtdisc.Leave+=new EventHandler(txtpaid_Leave);
//            txtdiscamount.Leave+=new EventHandler(txtpaid_Leave);
//        }
//        private void KeyPadStart()
//        {
//            if (!IsProcessOpen("Keypad"))
//            {
//                try
//                {
//                    myproces = Process.Start(Application.StartupPath + "\\KeyPad.exe");
//                    myproces.WaitForInputIdle();
//                    SetWindowPos(myproces.MainWindowHandle, this.Handle, 100, 800, 348, 276, 0);
                    
                   
//                }
//                catch (Exception e)
//                {
//                }

                
//            }
//        }
//        //[DllImport("user32.dll", SetLastError = true)]
//        //private static extern bool MoveWindow(IntPtr hWnd, int x, int y, int width, int height, bool repaint);
//        void txtpaid_GotFocus(object sender, EventArgs e)
//        {
//            _focused =(Control) sender;
//            //KeyPadStart();
//        }
//        public bool IsProcessOpen(string name)
//        {
//            //here we're going to get a list of all running processes on
//            //the computer
//            foreach (Process clsProcess in Process.GetProcesses())
//            {
//                //now we're going to see if any of the running processes
//                //match the currently running processes. Be sure to not
//                //add the .exe to the name you provide, i.e: NOTEPAD,
//                //not NOTEPAD.EXE or false is always returned even if
//                //notepad is running.
//                //Remember, if you have the process running more than once, 
//                //say IE open 4 times the loop thr way it is now will close all 4,
//                //if you want it to just close the first one it finds
//                //then add a return; after the Kill
//                if (clsProcess.ProcessName.Contains(name))
//                {
//                    //if the process is found to be running then we
//                    //return a true
//                    return true;
//                }
//            }
//            //otherwise we return a false
//            return false;
//        }
//        private void grdPOS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
//        {
//            DataGridView dgv = (DataGridView)sender;
//            if (dgv.Rows.Count > 1)
//            {

//                string quantity = (dgv.Rows[e.RowIndex].Cells[4].Value != null) ? Convert.ToString(dgv.Rows[e.RowIndex].Cells[4].Value) : "0";


                

//                if (e.ColumnIndex == 3 || e.ColumnIndex==4)
//                {
//                    CalcGridTotal();
//                 //   CalcTotal();
//                }
                


//            }
//        }

//        private void grdPOS_KeyDown(object sender, KeyEventArgs e)
//        {
//            if (e.KeyValue == 46)
//            {
//                DataGridViewRow row = grdPOS.Rows[grdPOS.CurrentCell.RowIndex];
//                if (row.IsNewRow) return;
               
//                grdPOS.Rows.RemoveAt(grdPOS.CurrentCell.RowIndex);
//                for (int i =0; i < grdPOS.Rows.Count-1; i++)
//                {
//                    grdPOS.Rows[i].Cells[0].Value = (i + 1);
//                }
//                CalcGridTotal();
//               // CalcTotal();
                
//            }
//        }

//        private void btngridclear_Click(object sender, EventArgs e)
//        {
//            Clear();
//        }

//        private void btnunits_Click(object sender, EventArgs e)
//        {
//            frmunits frm = new frmunits();

//            if (frm.ShowDialog() == DialogResult.OK)
//            {
//                DataGridViewRow row = grdPOS.Rows[grdPOS.CurrentCell.RowIndex];
//                row.Cells[2].Value = clsproperties.Units;
//                grdPOS.CurrentCell = grdPOS.Rows[grdPOS.CurrentCell.RowIndex].Cells[4];
//            }
//        }

//        private void btnremark_Click(object sender, EventArgs e)
//        {
//            frmRemarks frm = new frmRemarks();
//            if (frm.ShowDialog() == DialogResult.OK)
//            {
//                remarks = clsproperties.Remarks;
//            }
//        }

//        private void groupBox6_Enter(object sender, EventArgs e)
//        {

//        }

//        private void txtdiscamount_TextChanged(object sender, EventArgs e)
//        {
//            if (txtdiscamount.Text == "") return;
//            double totalamount = 0;

//            for (int i = 0; i < grdPOS.Rows.Count - 1; i++)
//            {
//                totalamount += Convert.ToDouble(grdPOS.Rows[i].Cells[5].Value.ToString());
//            }
//            if (totalamount == 0) return;
//            double discamount = (txtdiscamount.Text != "") ? Convert.ToDouble(txtdiscamount.Text) : 0;
            
//            if (discamount == 0 || discamount.ToString() == "")
//                txtdisc.Text = "";
//            else
//                txtdisc.Text = ((discamount * 100) / totalamount).ToString();
//        }

//        private void txtdiscamount_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            char ch = e.KeyChar;
//            if (!char.IsDigit(e.KeyChar) && ch != 46)
//            {
//                e.Handled = e.KeyChar != (char)Keys.Back;
//            }
//        }

//        private void txtpaid_Enter(object sender, EventArgs e)
//        {
//            _focused =(Control) sender;
//        }

//        private void frmPOS_FormClosing(object sender, FormClosingEventArgs e)
//        {
//            try
//            {
//            myproces.CloseMainWindow();
//            myproces.Close();
//                }
//            catch(Exception ex)
//            {
//            }

//        }

//        private void grdPOS_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
           
//        }

//        private void txtinvoiceno_SelectedItemChanged(object sender, EventArgs e)
//        {

//        }
//        int y = 500;
//        private void btnreport_Click(object sender, EventArgs e)
//        {
//            myproces.WaitForInputIdle();
//            SetWindowPos(myproces.MainWindowHandle, this.Handle, 100, y, 348, 217, 0);
//            y=y+100;
//        }

//        private void btnone_MouseClick(object sender, MouseEventArgs e)
//        {


//        }

//        private void btndelete_Click(object sender, EventArgs e)
//        {
//            if (MessageBox.Show("Do you really want to delete it ?", "Delete POS", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
//            {
//                sales.salesinvoice = txtinvoiceno.Text;
//                sales.DelStatus = 1;
//                sales.DeletePos();
//                DelPrint();
//                Clear();
//            }

//        }

//        private void txtbarcode_TextChanged(object sender, EventArgs e)
//        {
//            //if (txtbarcode.Text != "")
//            //{
//            //    Int64 itemid = items.GetItemid(txtbarcode.Text);
//            //    if (itemid > 0)
//            //    {
//            //        AddRecord(itemid);
//            //        //txtbarcode.Text = string.Empty;
//            //    }
//            //}
//        }

//        //private void txtbarcode_KeyUp(object sender, KeyEventArgs e)
//        //{
//        //    if (txtbarcode.Text != "")
//        //    {
//        //        Int64 itemid = items.GetItemid(txtbarcode.Text);
//        //        if (itemid > 0)
//        //        {
//        //            AddRecord(itemid);
//        //            txtbarcode.Text = string.Empty;
//        //            int index=grdPOS.CurrentRow.Index;
//        //            grdPOS.CurrentCell = grdPOS.Rows[index].Cells[3];
//        //            grdPOS.BeginEdit(true);
//        //            //grdPOS.Rows[index].Cells[3].Selected = true;
//        //        }
//        //    }
//        //}
     
   }
}
