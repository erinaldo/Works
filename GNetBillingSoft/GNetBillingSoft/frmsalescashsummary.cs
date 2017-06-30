using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.dsReportTableAdapters;
using GNetBillingSoft.DataOperation;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace GNetBillingSoft
{
    public partial class frmsalescashsummary : Form
    {
        clsperiodinfo period=new clsperiodinfo();
        DataTable dt;
        DataSet ds;
        public frmsalescashsummary()
        {
            InitializeComponent();
            DataTable dt=period.GetRecord();
            dtfrom.Value=Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
            dtTo.Value=Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
            AddRecord();
            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }
        public void Arabic()
        {
            this.Text = "Sales And Cash Summary  (ملخص المبيعات والنقد)";

            //Label
            this.lblFrom.Text = "من";
            this.lblTo.Text = "الى";
            this.lblPrevBal.Text = "الرصيد السابق";
            this.lblTotSale.Text = "إجمالي المبيعات";
            this.lblExpns.Text = "مصروف";
            this.lblBal.Text = "رصيد";
            this.lblExcess.Text = "فائض";
            this.lblShort.Text = "قصيرة";
            this.lblTotExpens.Text = "إجمالي النفقات";

            //GroupBox
            this.grpSummary.Text = "ملخص المبيعات والنقد";
            this.grpExpns.Text = "مصروف";
            this.grpAcc.Text = "حسابات";
            
            //DataGrid Summary
            this.itemname.HeaderText = "اسم العنصر";
            this.quantitysold.HeaderText = "الكمية المباعة";
            this.values.HeaderText = "القيمة";
            this.salesincome.HeaderText = "دخل المبيعات";
            this.stock.HeaderText = "المخزون";

            //DataGrid Expenses
            this.description.HeaderText = "الوصف";
            this.amount.HeaderText = "حساب ";

            //Button
            this.btnshow.Text = "عرض";
            this.btnprint.Text = "طباعة";
        }

        private void AddRecord()
        {
            try
            {
                SalescashsummaryTableAdapter reportAdapter = new SalescashsummaryTableAdapter();
                dsReport.salescashsummaryDataTable itemsales = new dsReport.salescashsummaryDataTable();
                string fromdate = dtfrom.Value.Year + "-" + dtfrom.Value.Month + "-" + dtfrom.Value.Day + " " + timefrom.Value.Hour + ":" + timefrom.Value.Minute;
                string todate = dtTo.Value.Year + "-" + dtTo.Value.Month + "-" + dtTo.Value.Day + " " + timeto.Value.Hour + ":" + timeto.Value.Minute;
                reportAdapter.Fill(itemsales, Convert.ToDateTime(fromdate), Convert.ToDateTime(todate));
               
                dt = (DataTable)itemsales;
                //double totqty = 0,totincome=0;
               grdsales.DataSource = dt;

               DataTable totalrow = new DataTable();
               totalrow.Columns.Add("total");
               totalrow.Columns.Add("totqty");
               totalrow.Columns.Add("totcost");
               totalrow.Columns.Add("totsales");
               totalrow.Columns.Add("totstock");
               
               

               DataRow dr = totalrow.NewRow();
               dr["total"] = "TOTAL";
               dr["totqty"] = dt.Compute("sum(quantity)", null);
               dr["totcost"] = dt.Compute("sum(totalcost)",null);
               dr["totsales"] = dt.Compute("sum(totsales)", null);
               dr["totstock"] = dt.Compute("sum(stock)", null);
               txttotalsales.Text = Convert.ToString(dt.Compute("sum(totsales)",null));
              
               totalrow.Rows.Add(dr);

               grdtotal.DataSource = totalrow;

               grdtotal.Columns[0].Width = grdsales.Columns[0].Width;
               grdtotal.Columns[1].Width = grdsales.Columns[1].Width;
               grdtotal.Columns[2].Width = grdsales.Columns[2].Width;
               grdtotal.Columns[3].Width = grdsales.Columns[3].Width;
               grdtotal.Columns[4].Width =(grdsales.Columns[4].Width)+100;
               grdtotal.Columns[5].Width = (grdsales.Columns[5].Width) ;
               

                
                
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    //DataGridViewRow row = (DataGridViewRow)grdsales.Rows[0].Clone();
                //    DataGridViewRow row = new DataGridViewRow();

                //    row.HeaderCell.Value = String.Format("{0}", (i + 1));
                //    row.Cells[0].Value = dt.Rows[i]["Description"];
                //    row.Cells[1].Value = dt.Rows[i]["quantity"];

                //    row.Cells[2].Value = dt.Rows[i]["totalcost"];
                //    row.Cells[3].Value = dt.Rows[i]["totsales"];
                //    grdsales.Rows.Add(row);
                //    totqty += Convert.ToDouble(dt.Rows[i]["quantity"]);
                //    totincome += Convert.ToDouble(dt.Rows[i]["totsales"]);


                //}
                //DataGridViewRow rowtot = (DataGridViewRow)grdsales.Rows[0].Clone();
                //rowtot.HeaderCell.Value = "";
                //rowtot.Cells[0].Value ="TOTAL";
                //rowtot.Cells[1].Value = totqty.ToString();

                //rowtot.Cells[2].Value ="";
                //rowtot.Cells[3].Value =totincome.ToString();
                //grdsales.Rows.Add(rowtot);
                


            }
            catch (Exception )
            {

            }
        }

        private void frmsalescashsummary_Load(object sender, EventArgs e)
        {
            

        }

        private void grdsales_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void grdsales_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void dtfrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void grdsales_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //DataGridViewRow row = grdsales.Rows[e.RowIndex];
            //row.HeaderCell.Value = String.Format("{0}",e.RowIndex + 1);
        }

        private void grdsales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                
            }
        }

        private void grdExpenses_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int total = 0;
                for (int i = 0; i < grdExpenses.Rows.Count; i++)
                {
                    int tot = Convert.ToInt32(grdExpenses.Rows[i].Cells[1].Value);
                    total += tot;
                }
                lblexptot.Text =total.ToString();
                txtexpenses.Text = (total*-1).ToString();
            }
        }

        private void txtprevbalance_TextChanged(object sender, EventArgs e)
        {
            CalcBalance();
        }
        private void CalcBalance()
        {
            double balance = Convert.ToDouble(((txttotalsales.Text!="")?txttotalsales.Text:"0")) + Convert.ToDouble((txtexpenses.Text!="")?txtexpenses.Text:"0") + Convert.ToDouble((txtprevbalance.Text!="")?txtprevbalance.Text:"0");
            txtbalance.Text = balance.ToString();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            AddRecord();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            dsReport.ExpenseTableDataTable dtexpense = new dsReport.ExpenseTableDataTable();
           

            for (int i = 0; i < grdExpenses.Rows.Count - 1; i++)
            {
                DataRow dr = dtexpense.NewRow();
                dr["Expense_Description"] = grdExpenses.Rows[i].Cells[0].Value;
                dr["Expense_Amount"] = grdExpenses.Rows[i].Cells[1].Value;
                dtexpense.Rows.Add(dr);
            }

            DataTable dtaccounts = new DataTable();

            dtaccounts.Columns.Add("Prev_balance");
            dtaccounts.Columns.Add("Excess");
            dtaccounts.Columns.Add("Short");

            DataRow dracct = dtaccounts.NewRow();
            dracct["Prev_balance"] = txtprevbalance.Text;
            dracct["Excess"] = txtexcess.Text;
            dracct["Short"] = txtshort.Text;

            dtaccounts.Rows.Add(dracct);

             ds = new DataSet();
             DataSet dtold = dt.DataSet;
             if (dtold != null)
             {
                 dtold.Tables.Remove(dt.TableName);
             }
            ds.Tables.Add(dt);
            ds.Tables.Add(dtexpense);
            //ds.Tables.Add(dtaccounts);

            try
            {
                //dsReport.CashTrayDataTable dtcash = (dsReport.CashTrayDataTable)dt;
                String Path;
                if (Properties.Settings.Default.Lang == "Arabic")
                    Path = Application.StartupPath + "\\CrystalReports\\Arabic\\crySalesCashAr.rpt";
                else
                    Path = Application.StartupPath + "\\CrystalReports\\crysalescash.rpt";

                if (!File.Exists(Path))
                {
                    MessageBox.Show("The Directory CrystalReports or Report File crySalesreport.rpt Not Exists");
                    return;
                }
                ReportDocument rDoc = new ReportDocument();
                rDoc.Load(Path);
                rDoc.SetDataSource(ds);
                rDoc.SetParameterValue("prevbalance", txtprevbalance.Text);
                rDoc.SetParameterValue("excess", txtexcess.Text);
                rDoc.SetParameterValue("short", txtshort.Text);

                cryReportviewer viewer = new cryReportviewer();
                viewer.rDoc = rDoc;
                viewer.MdiParent = this.MdiParent;
                viewer.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

       
    }
}
