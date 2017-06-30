using System;
using System.Data;
using System.Windows.Forms;
namespace GNetBillingSoft.DataOperation
{
    
    
    public class clsposinvoice
    {
        
        private const string mvartablename = "posinvoice";
        
        private long mvarposinvoice;
        
        private long mvarcustomerid;
        
        private System.DateTime mvarposdate;
        
        private double mvardiscount;
        
        private double mvarpaidcash;
        
        public long posinvoice
        {
            get
            {
                return this.mvarposinvoice;
            }
            set
            {
                this.mvarposinvoice = value;
            }
        }
        
        public long customerid
        {
            get
            {
                return this.mvarcustomerid;
            }
            set
            {
                this.mvarcustomerid = value;
            }
        }
        
        public System.DateTime posdate
        {
            get
            {
                return this.mvarposdate;
            }
            set
            {
                this.mvarposdate = value;
            }
        }
        
        public double discount
        {
            get
            {
                return this.mvardiscount;
            }
            set
            {
                this.mvardiscount = value;
            }
        }
        
        public double paidcash
        {
            get
            {
                return this.mvarpaidcash;
            }
            set
            {
                this.mvarpaidcash = value;
            }
        }
        
        public void Add()
        {
            string strsql;
            strsql="INSERT INTO "+ mvartablename+ "([posinvoice],[customerid],[posdate],[discount],[paidcash]) VALUES  ('"+mvarposinvoice+"','"+mvarcustomerid+"','"+mvarposdate.Year+"-"+mvarposdate.Month+"-"+mvarposdate.Day+"','"+mvardiscount+"','"+mvarpaidcash+"')";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set customerid='"+mvarcustomerid+"',posdate='"+mvarposdate.Year+"-"+mvarposdate.Month+"-"+mvarposdate.Day+"',discount='"+mvardiscount+"',paidcash='"+mvarpaidcash+"' where   posinvoice = "+mvarposinvoice+"";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   posinvoice = "+mvarposinvoice+" ";
            dboperation.ExecuteSql(strsql);
        }
        
        public int GetNextId()
        {
            string strsql;
            strsql="select max(posinvoice) from " +  mvartablename +"";
            object obj = dboperation.GetAValue(strsql);
            if ((obj == DBNull.Value))
            {
                return 1;
            }
            else
            {
                return (Convert.ToInt32(obj) + 1);
            }
        }
        
        public DataTable GetRecord()
        {
            string strsql;
            strsql="select posinvoice,customerid,posdate,discount,paidcash from "+mvartablename+" ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select posinvoice,customerid,posdate,discount,paidcash from " + mvartablename + " where posinvoice=" + posinvoice;
            return dboperation.GetDataTable(strsql);
        }
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where posinvoice="+mvarposinvoice+" ";
            DataTable dt = dboperation.GetDataTable(strsql);
            if ((dt.Rows.Count > 0))
            {
                result = true;
                // Add Your Variable Here
            }
            return result;
        }
        public string CalcNetAmt(DataGridView dgv, string txtdiscount)
        {
            try
            {


                double netamt = 0;
                double disc = 0;
                if (txtdiscount != "")
                {
                    disc = Convert.ToDouble(txtdiscount);

                }
                for (int i = 0; i < dgv.Rows.Count - 1; i++)
                {
                    double quantity = 0;
                    if (dgv.Rows[i].Cells[2].Value != null && dgv.Rows[i].Cells[3].Value != null)
                    {
                        quantity = Convert.ToDouble(Convert.ToString(dgv.Rows[i].Cells[3].Value));
                        string strprice = (Convert.ToString(dgv.Rows[i].Cells[4].Value) != "") ? Convert.ToString(dgv.Rows[i].Cells[4].Value) : "0";
                        double price = Convert.ToDouble(strprice);

                        double total = quantity * price;

                        //netamt += quantity * price;
                        // double discount = (disc * total) / 100;

                        dgv.Rows[i].Cells[5].Value = quantity * price;// -discount;
                        netamt += Convert.ToDouble(dgv.Rows[i].Cells[5].Value.ToString());
                    }
                }
                double discount = disc;
                double disamount = (netamt * discount) / 100;
                netamt = netamt - disamount;
                return netamt.ToString("0.00");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "0.00";

            }
        }
    }
}
