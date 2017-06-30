using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GNetBillingSoft.DataOperation
{
    
    
    public class clssalesinvoice
    {
        
        private const string mvartablename = "salesinvoice";
        
        private string mvarsalesinvoice;
        
        private long mvarcustomerid;
        
        
       
        
        private double mvardiscount;
        
        private double mvaradditionaldiscount;
        
        private double mvarpaidcash;
        
        private double mvarpaidcheque;
        
        private System.DateTime mvarsalesdate;
        private string mvarremarks;
        private DateTime mvarsalestime;
        private long mvarusrid;
        private int mvarclosesale;
        private int mvardelete;
        private long mvartokenno;
        public string salesinvoice
        {
            get
            {
                return this.mvarsalesinvoice;
            }
            set
            {
                this.mvarsalesinvoice = value;
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
        
        public double additionaldiscount
        {
            get
            {
                return this.mvaradditionaldiscount;
            }
            set
            {
                this.mvaradditionaldiscount = value;
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
        
        public double paidcheque
        {
            get
            {
                return this.mvarpaidcheque;
            }
            set
            {
                this.mvarpaidcheque = value;
            }
        }
        
        public System.DateTime salesdate
        {
            get
            {
                return this.mvarsalesdate;
            }
            set
            {
                this.mvarsalesdate = value;
            }
        }
        public string Remarks
        {
            get
            {
                return mvarremarks;
            }
            set
            {
                mvarremarks = value;
            }
        }
        public DateTime SalesTime
        {
            get
            {
                return mvarsalestime;
            }
            set
            {
                mvarsalestime = value;
            }
        }
        public int CloseSale
        {
            get
            {
                return mvarclosesale;
            }
            set
            {
                mvarclosesale = value;
            }
        }
        public long UserId
        {
            get
            {
                return mvarusrid;
             }
                
            set
            {
                mvarusrid = value;
            }
        }
        public int DelStatus
        {
            get
            {
                return mvardelete;
            }
            set
            {
                mvardelete = value;
            }
        }
        public long TokenNo
        {
            get
            {
                return mvartokenno;
            }
            set
            {
                mvartokenno = value;
            }
        } 
        public clssalesinvoice()
        {
            dboperation db = new dboperation();
        }
        public void Add()
        {
            string strsql;

            strsql = "INSERT INTO " + mvartablename + "([salesinvoice],[customerid],[discount],[additionaldiscount],[paidcash],[paidcheque],[salesdate],[remarks],[salestime],[userid],[tokenno]) VALUES  ('" + mvarsalesinvoice + "','" + mvarcustomerid + "','" + mvardiscount + "','" + mvaradditionaldiscount + "','" + mvarpaidcash + "','" + mvarpaidcheque + "','" + mvarsalesdate.Year + "-" + mvarsalesdate.Month + "-" + mvarsalesdate.Day + "','" + mvarremarks + "','" + mvarsalestime.Hour + ":" + mvarsalestime.Minute + "'," + mvarusrid + ","+mvartokenno+")";
            
            dboperation.ExecuteSql(strsql);
        }
      
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set customerid='"+mvarcustomerid+"',discount='"+mvardiscount+"',additionaldiscount='"+mvaradditionaldiscount+"',paidcash='"+mvarpaidcash+"',paidcheque='"+mvarpaidcheque+"',salesdate='"+mvarsalesdate.Year+"-"+mvarsalesdate.Month+"-"+mvarsalesdate.Day+"',remarks='"+mvarremarks+"',salestime='"+mvarsalestime.Hour+":"+mvarsalestime.Minute+"',userid="+mvarusrid+",tokenno="+mvartokenno+" where   salesinvoice = "+mvarsalesinvoice+"";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   salesinvoice = '"+mvarsalesinvoice+"' ";
            dboperation.ExecuteSql(strsql);
        }
        public void DeletePos()
        {
            string strsql;
            strsql = "update "+mvartablename+" set delstatus=" + mvardelete + " where salesinvoice='" + mvarsalesinvoice + "'";
            dboperation.ExecuteSql(strsql);
        }
        public bool Status()
        {
            string strsql;
            strsql = "select delstatus from " + mvartablename + " where salesinvoice='" + mvarsalesinvoice + "'";
            DataTable dt =dboperation.GetDataTable(strsql);
            if (dt.Rows.Count>0 && dt.Rows[0]["delstatus"].ToString() == "1")
            {
                return true;
            }
            else
                return false;

        }

        public string GetNextId()
        {
            string strsql;
            strsql = "select max(cast(salesinvoice as decimal)) from " + mvartablename + "";
            object obj = dboperation.GetAValue(strsql);
            if ((obj == DBNull.Value))
            {
                return Convert.ToString(1000);
            }
            else
            {
                string incno = obj.ToString();



                double Num;

                bool isNum = double.TryParse(incno, out Num);

                if (isNum)
                {
                    return (Convert.ToInt64(incno) + 1).ToString();
                }


                Regex regex = new Regex(@"((?<number>\d+)(?<letter>[A-Za-z])|(?<letter>[a-zA-Z])(?<number>\d+))");
                char[] arrincno = incno.ToCharArray();
                Match m = regex.Match(incno);
                int number = int.Parse(m.Groups["number"].Value);
                string modified = m.Groups["letter"].Value;
                string maxid = "";
                for (int i = 0; i < arrincno.Length; i++)
                {
                    if (modified != arrincno[i].ToString())
                    {

                        maxid += arrincno[i];

                    }
                    else
                    {
                        break;
                    }
                }
                maxid = maxid + modified;
                number = number + 1;
                maxid += number.ToString();
                return maxid;
            }
        }
        
        public DataTable GetRecord()
        {
            string strsql;
            strsql="select salesinvoice,customerid,discount,additionaldiscount,paidcash,paidcheque,salesdate from "+mvartablename+" ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select salesinvoice,customerid,discount,additionaldiscount,paidcash,paidcheque,salesdate,remarks,salestime,tokenno from " + mvartablename + " where salesinvoice='"+mvarsalesinvoice+"'";
            return dboperation.GetDataTable(strsql);
        }
        public DataSet GetSelRecord(string TableName)
        {
            string strsql;
            //strsql = "select salesinvoice,customerid,customername,phonenumber,address,discount,additionaldiscount,paidcash,paidcheque,salesdate from " + mvartablename + " where salesinvoice='" + mvarsalesinvoice + "'";
            strsql = "SELECT salesinvoice.salesinvoice, salesinvoice.customerid,  salesinvoice.discount, salesinvoice.salesdate,"
                         + "salesinvoice.additionaldiscount, salesdetails.quantity, itemdetails.Description, itemdetails.salesrate "
                        + "FROM salesdetails INNER JOIN "
                         + " itemdetails ON salesdetails.itemid = itemdetails.itemid INNER JOIN "
                         + " salesinvoice ON salesdetails.invoiceno = salesinvoice.salesinvoice "
                        + " WHERE (salesinvoice.salesinvoice = '"+mvarsalesinvoice+"')";
            return dboperation.GetDataTable(strsql, TableName);
        }
        public DataTable GetIds()
        {
            string strsql;
            strsql = "select salesinvoice from " + mvartablename + " order by cast(salesinvoice as decimal) desc ";
            return dboperation.GetDataTable(strsql);
        }
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where salesinvoice="+mvarsalesinvoice+" ";
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
                    if (dgv.Rows[i].Cells[3].Value != null && dgv.Rows[i].Cells[4].Value != null)
                    {
                        quantity = Convert.ToDouble(Convert.ToString(dgv.Rows[i].Cells[3].Value));
                        string strprice=(Convert.ToString(dgv.Rows[i].Cells[4].Value)!="")?Convert.ToString(dgv.Rows[i].Cells[4].Value):"0";
                        double price = Convert.ToDouble(strprice);

                        double total = quantity * price;

                        //netamt += quantity * price;
                       // double discount = (disc * total) / 100;
                        
                        dgv.Rows[i].Cells[6].Value = quantity * price;// -discount;
                        netamt += Convert.ToDouble(dgv.Rows[i].Cells[6].Value.ToString());
                    }
                }
                double discount = (disc * netamt) / 100;
                netamt = netamt - discount;
                return netamt.ToString("0.00");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "0.00";
               
            }
        }
        public string CalcTotalItem(DataGridView dgv)
        {
            try
            {


                double quantity = 0;
                for (int i = 0; i < dgv.Rows.Count - 1; i++)
                {
                    if (dgv.Rows[i].Cells[3].Value != null)
                    {
                        quantity += Convert.ToDouble(Convert.ToString(dgv.Rows[i].Cells[3].Value));
                    }

                }
                return quantity.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Decimal GetMinId()
        {
            string strsql = "select min(invoiceno) as minimum  from " + mvartablename;
            DataTable td = dboperation.GetDataTable(strsql);
            if (td.Rows[0]["minimum"].ToString() != "")
            {
                return Convert.ToDecimal(td.Rows[0]["minimum"].ToString());
            }
            return 0;

        }
        public long Customerid()
        {
            string strsql = "select max(customerid) as customerid from " + mvartablename;
            DataTable dt = dboperation.GetDataTable(strsql);
            if (dt.Rows[0]["customerid"].ToString() != "")
            {
                return Convert.ToInt64(dt.Rows[0]["customerid"].ToString())+1;
            }
            else
            {
                return 1;
            }
        }
        public DataTable SearchCustomer()
        {
            string strsql = "";
            strsql = "select customerid,customername,phonenumber,address from " + mvartablename + " where customerid=" + mvarcustomerid;
            return dboperation.GetDataTable(strsql);
        }
        public DataTable Customers()
        {
            string strsql = "";
            strsql = "select distinct customername as name,customerid from " + mvartablename;
            return dboperation.GetDataTable(strsql);


        }
        public void ClosingSale()
        {
            string strsql = "update salesinvoice set closesales=" + CloseSale + " where salesinvoice.salesinvoice=(select max(cast(salesinvoice.salesinvoice as decimal)) from salesinvoice)";
            dboperation.ExecuteSql(strsql);
        }
        public DataTable CloseSalesPrint()
        {
            string strsql="select * from salesinvoice where salesdate='"+salesdate.Year+"-"+salesdate.Month+"-"+salesdate.Day+"' and closesales=1 and salesinvoice.salesinvoice=(select max(cast(salesinvoice.salesinvoice as decimal)) from salesinvoice where closesales=1)";
            DataTable dt = dboperation.GetDataTable(strsql);
            if (dt.Rows.Count == 0)
            {
                strsql = "select * from salesinvoice where salesdate='" + salesdate.Year + "-" + salesdate.Month + "-" + salesdate.Day + "'";
                return dboperation.GetDataTable(strsql);
            }
            else
                return dt;
        }
        public static double Revenue(string from,string to)
        {
            string strsql = "select isnull(sum(quantity * salesrate),0) as paid from " + mvartablename+" join salesdetails on salesdetails.invoiceno=salesinvoice.salesinvoice where delstatus is null and salesdate between '"+from+"' and '"+to+"'";
            DataTable dt = dboperation.GetDataTable(strsql);
            return Convert.ToDouble(dt.Rows[0]["paid"].ToString());

        }
        public static int totDel(string from,string to )
        {
            string strsql = "select isnull(sum(quantity*salesrate),0) as del from " + mvartablename + " join salesdetails on salesdetails.invoiceno=salesinvoice.salesinvoice where delstatus=1 and salesdate between '"+from+"' and '"+to+"'";
            DataTable dt = dboperation.GetDataTable(strsql);
            return Convert.ToInt32(dt.Rows[0]["del"].ToString());
        }
        public static Int64 TotCustomer(string from,string to)
        {
            string strsql = "select isnull(sum(customerid),0) as totcus from " + mvartablename+" where salesdate between '"+from+"' and '"+to+"' and delstatus is null";

            DataTable dt = dboperation.GetDataTable(strsql);
            return Convert.ToInt64(dt.Rows[0]["totcus"].ToString());
        }
    }
}
