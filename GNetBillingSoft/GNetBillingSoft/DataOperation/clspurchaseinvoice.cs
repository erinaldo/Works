using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GNetBillingSoft.DataOperation
{
    
    
    public class clspurchaseinvoice
    {
        
        private const string mvartablename = "purchaseinvoice";
        
        private string mvarinvoiceno;
        
        private string mvarsuplierName;
        
        private string mvarphonenumber;
        
        private string mvaraddress;
        
        private double mvardiscount;
        
        private System.DateTime mvarpurchasedate;
        
        private double mvarpaidcash;
        
        private double mvarpaidcheque;
        private string mvarreferenceno;
        private double mvaropeningbalance;
        public string invoiceno
        {
            get
            {
                return this.mvarinvoiceno;
            }
            set
            {
                this.mvarinvoiceno = value;
            }
        }
        
        public string suplierName
        {
            get
            {
                return this.mvarsuplierName;
            }
            set
            {
                this.mvarsuplierName = value;
            }
        }
        
        public string phonenumber
        {
            get
            {
                return this.mvarphonenumber;
            }
            set
            {
                this.mvarphonenumber = value;
            }
        }
        
        public string address
        {
            get
            {
                return this.mvaraddress;
            }
            set
            {
                this.mvaraddress = value;
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
        
        public System.DateTime purchasedate
        {
            get
            {
                return this.mvarpurchasedate;
            }
            set
            {
                this.mvarpurchasedate = value;
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
        public string referenceno
        {
            get
            {
                return this.mvarreferenceno;
            }
            set
            {
                this.mvarreferenceno = value;
            }
        }
        public double OppBalance
        {
            get
            {
                return this.mvaropeningbalance;
            }
            set
            {
                this.mvaropeningbalance = value;
            }
        }
        
        public void Add()
        {
            string strsql;
            strsql = "INSERT INTO " + mvartablename + "([invoiceno],[suplierName],[phonenumber],[address],[discount],[purchasedate],[paidcash],[paidcheque],[referenceno],[openingbalance]) VALUES  ('" + mvarinvoiceno + "','" + mvarsuplierName + "','" + mvarphonenumber + "','" + mvaraddress + "','" + mvardiscount + "','" + mvarpurchasedate.Year + "-" + mvarpurchasedate.Month + "-" + mvarpurchasedate.Day + "','" + mvarpaidcash + "','" + mvarpaidcheque + "','" + mvarreferenceno + "',"+mvaropeningbalance+")";
          
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql = "update " + mvartablename + " set suplierName='" + mvarsuplierName + "',phonenumber='" + mvarphonenumber + "',address='" + mvaraddress + "',discount='" + mvardiscount + "',purchasedate='" + mvarpurchasedate.Year + "-" + mvarpurchasedate.Month + "-" + mvarpurchasedate.Day + "',paidcash='" + mvarpaidcash + "',paidcheque='" + mvarpaidcheque + "',referenceno='" + mvarreferenceno + "',openingbalance="+mvaropeningbalance+" where   invoiceno = '" + mvarinvoiceno + "'";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   invoiceno = '"+mvarinvoiceno+"' ";
            dboperation.ExecuteSql(strsql);
        }
        
        public string  GetNextId()
        {
            string strsql;
            strsql="select max(invoiceno) from " +  mvartablename +"";
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
                number = number+1;
                maxid += number.ToString();
                return maxid;
            }
        }
        
        public DataTable GetRecord()
        {
            string strsql;
            strsql = "select invoiceno,suplierName,phonenumber,address,discount,purchasedate,paidcash,paidcheque,referenceno,openingbalance from " + mvartablename + " ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable  GetIds()
        {
            string strsql;
            strsql = "select invoiceno from " + mvartablename + " order by invoiceno desc ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select invoiceno,suplierName,phonenumber,address,discount,purchasedate,paidcash,paidcheque,referenceno,openingbalance from " + mvartablename + " where invoiceno='" + mvarinvoiceno + "'";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable Supplier()
        {
            string strsql;
            strsql = "select distinct suplierName from " + mvartablename;
            return dboperation.GetDataTable(strsql);
        }
        public DataTable SupplierDetails()
        {
            string strsql = "select distinct suplierName,phonenumber,address,openingbalance from " + mvartablename + " where suplierName='" + mvarsuplierName + "'";
            return dboperation.GetDataTable(strsql);
        }
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where invoiceno='"+mvarinvoiceno+"' ";
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
                    double quantity=0;
                    if (dgv.Rows[i].Cells[3].Value != null && dgv.Rows[i].Cells[4].Value!=null)
                    {
                        quantity = Convert.ToDouble(Convert.ToString(dgv.Rows[i].Cells[3].Value));

                        double price = Convert.ToDouble(Convert.ToString(dgv.Rows[i].Cells[4].Value));
                        double total = quantity * price;
                      //  double discount = (disc * total) / 100;

                       // netamt += quantity * price;
                        dgv.Rows[i].Cells[6].Value = (quantity * price);// -discount;
                        netamt += Convert.ToDouble(dgv.Rows[i].Cells[6].Value.ToString());
                    }
                }
                double discount = (disc * netamt) / 100;
                netamt = netamt - discount;
                return netamt.ToString("0.00");
            }
            catch (Exception)
            {

                throw;
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
        public DataTable Suplier()
        {
            string strsql = "";
            strsql = "select distinct suplierName as name from " + mvartablename;
            return dboperation.GetDataTable(strsql);
        }

    }
}
