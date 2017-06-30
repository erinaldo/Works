using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GNetBillingSoft.DataOperation
{
    
    
    public class clspurchasereturn
    {
        
        private const string mvartablename = "purchasereturn";
        
        private string mvarreturnno;
        
        private string mvaroldinvoiceno;
        
        private string mvarphonenumber;
        
        private string mvaraddress;
        
        private string mvarsupplier;
        
        private double mvarpaidamount;
        
        private double mvardiscount;
        private DateTime mvarreturndate;
        public string returnno
        {
            get
            {
                return this.mvarreturnno;
            }
            set
            {
                this.mvarreturnno = value;
            }
        }
        
        public string oldinvoiceno
        {
            get
            {
                return this.mvaroldinvoiceno;
            }
            set
            {
                this.mvaroldinvoiceno = value;
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
        
        public string supplier
        {
            get
            {
                return this.mvarsupplier;
            }
            set
            {
                this.mvarsupplier = value;
            }
        }
        
        public double paidamount
        {
            get
            {
                return this.mvarpaidamount;
            }
            set
            {
                this.mvarpaidamount = value;
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
        public DateTime ReturnDate
        {
            get
            {
                return this.mvarreturndate;
            }
            set
            {
                this.mvarreturndate = value;
            }
        }
        
        public void Add()
        {
            string strsql;
            strsql="INSERT INTO "+ mvartablename+ "([returnno],[oldinvoiceno],[phonenumber],[address],[supplier],[paidamount],[discount],[returndate]) VALUES  ('"+mvarreturnno+"','"+mvaroldinvoiceno+"','"+mvarphonenumber+"','"+mvaraddress+"','"+mvarsupplier+"','"+mvarpaidamount+"','"+mvardiscount+"','"+mvarreturndate.Year+"-"+mvarreturndate.Month+"-"+mvarreturndate.Day+"')";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set oldinvoiceno='"+mvaroldinvoiceno+"',phonenumber='"+mvarphonenumber+"',address='"+mvaraddress+"',supplier='"+mvarsupplier+"',paidamount='"+mvarpaidamount+"',discount='"+mvardiscount+"','"+mvarreturndate.Year+"-"+mvarreturndate.Month+"-"+mvarreturndate.Day+"' where   returnno = "+mvarreturnno+"";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   returnno = "+mvarreturnno+" ";
            dboperation.ExecuteSql(strsql);
        }

        public string GetNextId()
        {
            string strsql;
            strsql = "select max(returnno) from " + mvartablename + "";
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
            strsql="select returnno,oldinvoiceno,phonenumber,address,supplier,paidamount,discount from "+mvartablename+" ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select returnno,supplier,oldinvoiceno,phonenumber,address,discount,returndate,paidamount,oldinvoiceno from " + mvartablename + " where returnno='" + mvarreturnno + "'";
            return dboperation.GetDataTable(strsql);
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

                        double price = Convert.ToDouble(Convert.ToString(dgv.Rows[i].Cells[4].Value));

                        double discount = (disc * price) / 100;

                        netamt += quantity * price;
                        dgv.Rows[i].Cells[6].Value = quantity * price - discount;
                        netamt -= discount;
                    }
                }

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
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where returnno="+mvarreturnno+" ";
            DataTable dt = dboperation.GetDataTable(strsql);
            if ((dt.Rows.Count > 0))
            {
                result = true;
                // Add Your Variable Here
            }
            return result;
        }
        public DataTable GetIds()
        {
            string strsql;
            strsql = "select returnno from " + mvartablename + " order by returnno desc ";
            return dboperation.GetDataTable(strsql);
        }
    }
}
