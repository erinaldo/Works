using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;

namespace GNetBillingSoft.Reports
{
    public partial class frmcashtray : Form
    {
        public frmcashtray()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            this.Text = "Cash Tray Report (تقرير صندوق النقد)";

            //Label
            this.lblFrom.Text = "من";
            this.lblTo.Text = "الى";
            this.lblDate1.Text = "التاريخ";
            this.lblTime1.Text = "زمن";
            this.lblEmploy.Text = "موظف";

            this.lblCashRev.Text = "الإيرادات النقدية";
            this.lblPaidIn.Text = "مدفوع الأجر";
            this.lblPaidOut.Text = "الدفعات المدفوعة";
            this.lblLessTip.Text = "نصائح أقل";
            this.lblNetCashDue.Text = "صافي النقد المستحق";
            this.lblBCAmt.Text = "يجري النقدية المبلغ";
            this.lblGCDue.Text = "إجمالي المبالغ المستحقة الدفع";
            this.lblCCTFee.Text = "رسوم بطاقة الائتمان تلميح";
            this.lblCashBack.Text = "استرداد النقود";
            this.lblMoneyDrop.Text = "المال قطرات";
            this.lblEmpPaidOut.Text = "دفع الموظف";
            this.lblECADue.Text = "نهاية النقدية مستحقة المستحقة";
            this.lblShort.Text = "قصيرة";

            this.lblNCChecks.Text = "صافي النقدية + الشيكات";
            this.lblTCTray.Text = "إجمالي علبة النقدية";
            this.lblTotalShort.Text = "مجموع قصير";

            this.grpCashInfo.Text = "معلومات نقدية";
            this.grpNCInfo.Text = "معلومات غير نقدية";

            this.btnPrint.Text = "طباعة";
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

        private void frmcashtray_Load(object sender, EventArgs e)
        {
            try
            {
                lbldate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lbltime.Text = DateTime.Now.ToString("HH:mm");
                lblemployee.Text = clsuserinfo.GetUsername();

                DataTable dt = new DataTable();
                String Descrp = (Properties.Settings.Default.Lang == "Arabic") ? "الوصف" : " Description";
                String Amnt = (Properties.Settings.Default.Lang == "Arabic") ? "حساب" : " Amount";
                dt.Columns.Add(Descrp); 
                dt.Columns.Add(Amnt);

                DataRow dr = dt.NewRow();
                dr[Descrp] = "Guest(0)";
                dr[Amnt] = "0.00";
                dt.Rows.Add(dr);
                dr = dt.NewRow();
                dr[Descrp] = "Void(0)";
                dr[Amnt] = "0.00";
                dt.Rows.Add(dr);
                dr = dt.NewRow();
                dr[Descrp] = "Coupons(0)";
                dr[Amnt] = "0.00";
                dt.Rows.Add(dr);

                dgvdescription.DataSource = dt;
                SetData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void SetData()
        {
            try
            {
                double revenue = clssalesinvoice.Revenue(dtFrom.Value.ToString("yyyy-MM-dd"), dtTo.Value.ToString("yyyy-MM-dd"));
                txtnetcashdue.Text = revenue.ToString();
                lblcashrevenu.Text = revenue.ToString();
                lblnetcash.Text = revenue.ToString();
                if (txtnetcashdue.Text != "")
                {
                    txtgrosscash.Text = (Convert.ToDouble(txtnetcashdue.Text) + Convert.ToDouble(txtcashamount.Text)).ToString();
                    txtshort.Text = txtgrosscash.Text;
                    lbltotcashtry.Text = (Convert.ToDouble(txtnetcashdue.Text) + Convert.ToDouble(txtcashamount.Text)).ToString();
                    lbltotshort.Text = lbltotcashtry.Text;
                    txtshort.Text = txtgrosscash.Text;
                }
            }
            catch (Exception )
            {
            }
        }
        private void txtcashamount_TextChanged(object sender, EventArgs e)
        {
            if (txtcashamount.Text != "")
            {
                txtgrosscash.Text = (Convert.ToDouble(txtnetcashdue.Text) + Convert.ToDouble(txtcashamount.Text)).ToString();
                lbltotcashtry.Text = (Convert.ToDouble(txtnetcashdue.Text) + Convert.ToDouble(txtcashamount.Text)).ToString();
                lbltotshort.Text = lbltotcashtry.Text;
                txtshort.Text = txtgrosscash.Text;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void CalcNetCash(object sender,EventArgs e)
        {
            double addition = 0;
            double substract = 0;
            foreach (Control txt in grpCashInfo.Controls)
            {
                if ((txt is TextBox)&& txt.Tag !=null)
                {
                    if (txt.Tag.ToString() == "add")
                    {
                        addition += (txt.Text != "") ? Convert.ToDouble(txt.Text) : 0;
                    }
                }
            }
            foreach (Control txt in grpCashInfo.Controls)
            {
                if ((txt is TextBox) && txt.Tag!=null)
                {
                    if (txt.Tag.ToString() == "sub")
                    {
                        substract += (txt.Text != "") ? Convert.ToDouble(txt.Text) : 0;
                    }
                }
            }
            txtnetcashdue.Text = (Convert.ToDouble(lblcashrevenu.Text) + (addition - substract)).ToString();
            if (txtnetcashdue.Text != "")
            {
                txtgrosscash.Text = (Convert.ToDouble(txtnetcashdue.Text) + Convert.ToDouble(txtcashamount.Text)).ToString();
                txtshort.Text = txtgrosscash.Text;
                lbltotcashtry.Text = (Convert.ToDouble(txtnetcashdue.Text) + Convert.ToDouble(txtcashamount.Text)).ToString();
                lbltotshort.Text = lbltotcashtry.Text;
                txtshort.Text = txtgrosscash.Text;
            }
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
           // String Employ,Revenue,PaidIn,PaidOut,LessTip,
            DataTable dt = new DataTable();
            dt.Columns.Add("employee");
            
            DataColumn col1 = new DataColumn();
            col1.ColumnName = "cash_revenue";
            col1.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(col1);

            col1 = new DataColumn();
            col1.ColumnName = "paidins";
            col1.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(col1);

            col1 = new DataColumn();
            col1.ColumnName = "paidouts";
            col1.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(col1);

            col1 = new DataColumn();
            col1.ColumnName = "lesstips";
            col1.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(col1);

            col1 = new DataColumn();
            col1.ColumnName = "creditcardtipfee";
            col1.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(col1);

            col1 = new DataColumn();
            col1.ColumnName = "cashback";
            col1.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(col1);

            col1 = new DataColumn();
            col1.ColumnName = "moneydrop";
            col1.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(col1);

            col1 = new DataColumn();
            col1.ColumnName = "employeepaidout";
            col1.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(col1);

            col1 = new DataColumn();
            col1.ColumnName = "netcashdue";
            col1.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(col1);

            col1 = new DataColumn();
            col1.ColumnName = "beingcashamount";
            col1.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(col1);

            col1 = new DataColumn();
            col1.ColumnName = "grosscashdue";
            col1.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(col1);

            col1 = new DataColumn();
            col1.ColumnName = "endcashamountdue";
            col1.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(col1);

            col1 = new DataColumn();
            col1.ColumnName = "short";
            col1.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(col1);

            col1 = new DataColumn();
            col1.ColumnName = "totalcustomer";
            col1.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(col1);

            col1 = new DataColumn();
            col1.ColumnName = "totaldelete";
            col1.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(col1);

            col1 = new DataColumn();
            col1.ColumnName = "TotAvg";
            col1.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(col1);

            double revenue = clssalesinvoice.Revenue(dtFrom.Value.ToString("yyyy-MM-dd"), dtTo.Value.ToString("yyyy-MM-dd"));
            long totalcust = clssalesinvoice.TotCustomer(dtFrom.Value.ToString("yyyy-MM-dd"), dtTo.Value.ToString("yyyy-MM-dd"));
            int totdel = clssalesinvoice.totDel(dtFrom.Value.ToString("yyyy-MM-dd"), dtTo.Value.ToString("yyyy-MM-dd"));
            DataRow dr = dt.NewRow();
            dr["employee"] = clsuserinfo.GetUsername();
            dr["cash_revenue"] = revenue;
            dr["paidins"] = txtpaidins.Text;
            dr["paidouts"] = txtpaidouts.Text;
            dr["lesstips"] = txtlesstips.Text;
            dr["creditcardtipfee"] = txtcreditcash.Text;
            dr["cashback"] = txtcashback.Text;
            dr["moneydrop"] = txtmoneydrp.Text;
            dr["employeepaidout"] = txtemppaidout.Text;
            dr["netcashdue"] = txtnetcashdue.Text;
            dr["beingcashamount"] = txtcashamount.Text;
            dr["grosscashdue"] = txtgrosscash.Text;
            dr["endcashamountdue"] = txtcashamtdue.Text;
            dr["short"] = txtshort.Text;
            dr["totalcustomer"] = totalcust;
            dr["totaldelete"] = totdel.ToString();
            dr["TotAvg"] = (totalcust != 0) ? revenue / totalcust : 0;
            dt.Rows.Add(dr);
            rptCashTray frm = new rptCashTray();
            frm.dt = dt;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            SetData();
        }

        private void dtTo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtpaidins.Focus();
        }

        private void txtshort_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPrint.Focus();
        }
    }
}
