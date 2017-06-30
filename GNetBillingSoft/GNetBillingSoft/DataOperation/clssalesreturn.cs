using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace GNetBillingSoft.DataOperation
{   
    public class clssalesreturn
    {
        
        private const string mvartablename = "salesreturn";
        
        private string mvarsalesreturnid;
        
        private long mvarcustomerid;
        
        private string mvarcustomername;
        
        private string mvarphonenumber;
        
        private string mvaraddress;
        
        private double mvardiscount;
        
        private double mvarpaidcash;
        
        private System.DateTime mvarsalesreturndate;
        
        private string mvaroldinvoice;
        
        public string salesreturnid
        {
            get
            {
                return this.mvarsalesreturnid;
            }
            set
            {
                this.mvarsalesreturnid = value;
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
        
        public string customername
        {
            get
            {
                return this.mvarcustomername;
            }
            set
            {
                this.mvarcustomername = value;
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
        
        public System.DateTime salesreturndate
        {
            get
            {
                return this.mvarsalesreturndate;
            }
            set
            {
                this.mvarsalesreturndate = value;
            }
        }
        
        public string oldinvoice
        {
            get
            {
                return this.mvaroldinvoice;
            }
            set
            {
                this.mvaroldinvoice = value;
            }
        }
        
        public void Add()
        {
            string strsql;
            strsql="INSERT INTO "+ mvartablename+ "([salesreturnid],[customerid],[customername],[phonenumber],[address],[discount],[paidcash],[salesreturndate],[oldinvoice]) VALUES  ('"+mvarsalesreturnid+"','"+mvarcustomerid+"','"+mvarcustomername+"','"+mvarphonenumber+"','"+mvaraddress+"','"+mvardiscount+"','"+mvarpaidcash+"','"+mvarsalesreturndate.Year+"-"+mvarsalesreturndate.Month+"-"+mvarsalesreturndate.Day+"','"+mvaroldinvoice+"')";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set customerid='"+mvarcustomerid+"',customername='"+mvarcustomername+"',phonenumber='"+mvarphonenumber+"',address='"+mvaraddress+"',discount='"+mvardiscount+"',paidcash='"+mvarpaidcash+"',salesreturndate='"+mvarsalesreturndate.Year+"-"+mvarsalesreturndate.Month+"-"+mvarsalesreturndate.Day+"',oldinvoice='"+mvaroldinvoice+"' where   salesreturnid = "+mvarsalesreturnid+"";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   salesreturnid = "+mvarsalesreturnid+" ";
            dboperation.ExecuteSql(strsql);
        }

        public string GetNextId()
        {
            string strsql;
            strsql = "select max(salesreturnid) from " + mvartablename + "";
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
            strsql="select salesreturnid,customerid,customername,phonenumber,adddress,discount,paidcash,salesreturndate,oldinvoice from "+mvartablename+" ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select salesreturnid,customerid,customername,phonenumber,address,discount,paidcash,salesreturndate from " + mvartablename + " where salesreturnid='" + mvarsalesreturnid + "'";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetIds()
        {
            string strsql;
            strsql = "select salesreturnid from " + mvartablename + " order by salesreturnid desc ";
            return dboperation.GetDataTable(strsql);
        }
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where salesreturnid="+mvarsalesreturnid+" ";
            DataTable dt = dboperation.GetDataTable(strsql);
            if ((dt.Rows.Count > 0))
            {
                result = true;
                // Add Your Variable Here
            }
            return result;
        }
        public DataTable SearchCustomer()
        {
            string strsql = "";
            strsql = "select customerid,customername,phonenumber,address from " + mvartablename + " where customerid=" + mvarcustomerid;
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
                        string strprice = (Convert.ToString(dgv.Rows[i].Cells[4].Value) != "") ? Convert.ToString(dgv.Rows[i].Cells[4].Value) : "0";
                        double price = Convert.ToDouble(strprice);

                        double discount = (disc * price) / 100;

                        netamt += quantity * price;
                        dgv.Rows[i].Cells[6].Value = quantity * price - discount;
                        netamt -= discount;
                    }
                }

                return netamt.ToString("0.00");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
    }
}
