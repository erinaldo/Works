using System;
using System.Data;
namespace GNetBillingSoft.DataOperation
{
    
    
    public class clscustomerdetails
    {
        
        private const string mvartablename = "customerdetails";
        
        private long mvarcustomerid;
        
        private string mvarcustomername;
        
        private string mvaraddress;
        
        private string mvarphonenumber;
        
        private System.DateTime mvaraddeddate;
        private double mvarcusopening;
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
        
        public System.DateTime addeddate
        {
            get
            {
                return this.mvaraddeddate;
            }
            set
            {
                this.mvaraddeddate = value;
            }
        }
        public double CusOpening
        {
            get
            {
                return mvarcusopening;
            }
            set
            {
                mvarcusopening = value;
            }
        }
        public void Add()
        {
            string strsql;
            strsql="INSERT INTO "+ mvartablename+ "([customerid],[customername],[address],[phonenumber],[addeddate],[cusopening]) VALUES  ('"+mvarcustomerid+"','"+mvarcustomername+"','"+mvaraddress+"','"+mvarphonenumber+"','"+mvaraddeddate.Year+"-"+mvaraddeddate.Month+"-"+mvaraddeddate.Day+"',"+mvarcusopening+")";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set customername='"+mvarcustomername+"',address='"+mvaraddress+"',phonenumber='"+mvarphonenumber+"',addeddate='"+mvaraddeddate.Year+"-"+mvaraddeddate.Month+"-"+mvaraddeddate.Day+"',cusopening="+mvarcusopening+" where   customerid = "+mvarcustomerid+"";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   customerid = "+mvarcustomerid+" ";
            dboperation.ExecuteSql(strsql);
        }
        
        public int GetNextId()
        {
            string strsql;
            strsql="select max(customerid) from " +  mvartablename +"";
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
            strsql="select customerid,customername,address,phonenumber,addeddate,cusopening from "+mvartablename+" ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select customerid,customername,address,phonenumber,addeddate,cusopening from " + mvartablename + " where customerid="+customerid;
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetCusRecord()
        {
            string strsql;
            strsql = "select customerid,customername as name,address,phonenumber,addeddate,cusopening from " + mvartablename;
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetCusOpening()
        {
            string strsql;
            strsql = "select customerid,cusopening from " + mvartablename+" where customerid="+mvarcustomerid;
            return dboperation.GetDataTable(strsql);
        }
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where customerid="+mvarcustomerid+" ";
            DataTable dt = dboperation.GetDataTable(strsql);
            if ((dt.Rows.Count > 0))
            {
                result = true;
                // Add Your Variable Here
            }
            return result;
        }
        public static int GetTotalCust()
        {
            string strsql;
            strsql="select count(*)as cuscount from "+mvartablename;
            DataTable dt=dboperation.GetDataTable(strsql);
            return Convert.ToInt32(dt.Rows[0]["cuscount"].ToString());
        }
    }
}
