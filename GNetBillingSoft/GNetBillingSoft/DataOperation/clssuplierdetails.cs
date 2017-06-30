using System;
using System.Data;

namespace GNetBillingSoft.DataOperation
{
    
    
    public class clssuplierdetails
    {
        
        private const string mvartablename = "suplierdetails";
        
        private long mvarsuplierid;
        
        private string mvarsupliername;
        
        private string mvaraddress;
        
        private string mvarphonenumber;
        
        private double mvaropeningbalance;
        
        private System.DateTime mvaraddeddate;
        
        public long suplierid
        {
            get
            {
                return this.mvarsuplierid;
            }
            set
            {
                this.mvarsuplierid = value;
            }
        }
        
        public string supliername
        {
            get
            {
                return this.mvarsupliername;
            }
            set
            {
                this.mvarsupliername = value;
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
        
        public double openingbalance
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
        
        public void Add()
        {
            string strsql;
            strsql="INSERT INTO "+ mvartablename+ "([suplierid],[supliername],[address],[phonenumber],[openingbalance],[addeddate]) VALUES  ('"+mvarsuplierid+"','"+mvarsupliername+"','"+mvaraddress+"','"+mvarphonenumber+"','"+mvaropeningbalance+"','"+mvaraddeddate.Year+"-"+mvaraddeddate.Month+"-"+mvaraddeddate.Day+"')";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set supliername='"+mvarsupliername+"',address='"+mvaraddress+"',phonenumber='"+mvarphonenumber+"',openingbalance='"+mvaropeningbalance+"',addeddate='"+mvaraddeddate.Year+"-"+mvaraddeddate.Month+"-"+mvaraddeddate.Day+"' where   suplierid = "+mvarsuplierid+"";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   suplierid = "+mvarsuplierid+" ";
            dboperation.ExecuteSql(strsql);
        }
        
        public int GetNextId()
        {
            string strsql;
            strsql="select max(suplierid) from " +  mvartablename +"";
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
            strsql="select suplierid,supliername,address,phonenumber,openingbalance,addeddate from "+mvartablename+" ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select suplierid,supliername,address,phonenumber,openingbalance,addeddate from " + mvartablename + " where suplierid=" + suplierid;
            return dboperation.GetDataTable(strsql);
        }
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where suplierid="+mvarsuplierid+" ";
            DataTable dt = dboperation.GetDataTable(strsql);
            if ((dt.Rows.Count > 0))
            {
                result = true;
                // Add Your Variable Here
            }
            return result;
        }
        public DataTable ListItem()
        {
            string strsql = "";
            strsql = "select * from " + mvartablename + " where suplierid=" + mvarsuplierid;
            return  dboperation.GetDataTable(strsql);


        }
    }
}
