using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft.Reports
{
    public partial class frmStockReport : Form
    {
        clsitemdetails items = new clsitemdetails();
        public frmStockReport()
        {
            InitializeComponent();
            AddRecord();

            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            this.Text = "Stock Report (تقرير ستوك)";

            //DataGrid
            this.slno.HeaderText = "رقم سري";
            this.code.HeaderText = "الشفرة";
            this.name.HeaderText = "الاسم";
            this.Unit.HeaderText = "الوحدة";
            this.quantity.HeaderText = "الأسهم الحالية";
            this.cost.HeaderText = "التكلفة";
            this.total.HeaderText = "الاجمالى";
            this.salesrate.HeaderText = "معدل المبيعات";
            this.stotal.HeaderText = "الاجمالى";
            this.actualstock.HeaderText = "عدد الأسهم";
            this.difference.HeaderText = "فرق";
            this.differenceamount.HeaderText = "مبلغ الفرق";
            this.totalcost.HeaderText = "التكلفة الإجمالية";


            //Button
            this.btnSave.Text = "حفظ";
            this.btnmainclose.Text = "اقفال";
        }
        private void AddRecord()
        {
            DataTable dt = items.StockReport();
            double totalquantity = 0; double totalcost = 0; double diffamount = 0; double costtotal = 0;
            grdStock.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)grdStock.Rows[0].Clone();
                row.Cells[0].Value = dt.Rows[i]["slno"];
                row.Cells[1].Value = dt.Rows[i]["code"];
                row.Cells[2].Value = dt.Rows[i]["name"];
                row.Cells[3].Value = dt.Rows[i]["Unit"];
                double quan = Convert.ToDouble(dt.Rows[i]["quantity"].ToString());
                object valop = dt.Rows[i]["ActualStock"];
                double opening=0;
                if (valop != DBNull.Value)
                {
                    opening  = Convert.ToDouble(dt.Rows[i]["ActualStock"].ToString());
                }
                
                row.Cells[4].Value = opening + quan;
                object value=dt.Rows[i]["quantity"];
                if (value != DBNull.Value)
                {
                    totalquantity += opening + quan;
                }
                
                row.Cells[5].Value = dt.Rows[i]["cost"];
                totalcost += Convert.ToDouble(dt.Rows[i]["cost"].ToString());
                row.Cells[6].Value = dt.Rows[i]["totalcost"];
                row.Cells[7].Value = dt.Rows[i]["salesrate"];
                row.Cells[8].Value = dt.Rows[i]["totalsales"];
                row.Cells[9].Value = dt.Rows[i]["ActualStock"];
                double quantity = (row.Cells[4].Value.ToString()!="") ? Convert.ToDouble(row.Cells[4].Value.ToString()) : 0;
                double actual = (row.Cells[9].Value.ToString() != "") ? Convert.ToDouble(row.Cells[9].Value.ToString()) : 0;
                row.Cells[10].Value = quantity-actual;
                row.Cells[11].Value = Convert.ToDouble(row.Cells[10].Value.ToString()) * Convert.ToDouble(row.Cells[5].Value.ToString());
                diffamount += Convert.ToDouble(row.Cells[11].Value.ToString());
                row.Cells[12].Value = actual * Convert.ToDouble(row.Cells[5].Value.ToString());
                costtotal += Convert.ToDouble(row.Cells[12].Value.ToString());
                grdStock.Rows.Add(row);


            }

            DataGridViewRow RowTot = (DataGridViewRow)grdStock.Rows[0].Clone();
            RowTot.Cells[2].Value = "Total";
            RowTot.Cells[3].Value = totalquantity;
            RowTot.Cells[5].Value = totalcost;
            RowTot.Cells[11].Value = diffamount;
            RowTot.Cells[12].Value = costtotal;
            grdStock.Rows.Add(RowTot);
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SetData())
            {
               
               // grdStock.Refresh();
               // grdStock.Parent.Refresh();
                AddRecord();
            }
        }
        private bool SetData()
        {
            try
            {
                grdStock.EndEdit();
                for (int i = 0; i < grdStock.Rows.Count - 2; i++)
                {
                    items.itemid = grdStock.Rows[i].Cells["Code"].Value.ToString();
                    items.Description = grdStock.Rows[i].Cells["name"].Value.ToString();
                    items.Unit = grdStock.Rows[i].Cells["Unit"].Value.ToString();
                    items.Price = Convert.ToInt64(grdStock.Rows[i].Cells["cost"].Value.ToString());
                    items.salesrate = Convert.ToInt64(grdStock.Rows[i].Cells["salesrate"].Value.ToString());
                    double actual = (grdStock.Rows[i].Cells["ActualStock"].Value.ToString() != "") ? Convert.ToDouble(grdStock.Rows[i].Cells["ActualStock"].Value.ToString()) : 0;
                    items.actualstock = actual;
                    if (items.GetItems())
                    {
                        items.Edit();
                    }
                    else
                    {
                        items.Add();
                    }


                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        private void btnmainclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
