using System;
using System.Data;

namespace GNetBillingSoft.DataOperation
{
    
    
    public class clsposdetails
    {
        
        private const string mvartablename = "posdetails";
        
        private long mvarposdetailsid;
        
        private long mvarposinvoice;
        
        private long mvaritemid;
        
        private double mvarquantity;
        
        private double mvarprice;
        
        public long posdetailsid
        {
            get
            {
                return this.mvarposdetailsid;
            }
            set
            {
                this.mvarposdetailsid = value;
            }
        }
        
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
        
        public long itemid
        {
            get
            {
                return this.mvaritemid;
            }
            set
            {
                this.mvaritemid = value;
            }
        }
        
        public double quantity
        {
            get
            {
                return this.mvarquantity;
            }
            set
            {
                this.mvarquantity = value;
            }
        }
        
        public double price
        {
            get
            {
                return this.mvarprice;
            }
            set
            {
                this.mvarprice = value;
            }
        }
        
        public void Add()
        {
            string strsql;
            strsql="INSERT INTO "+ mvartablename+ "([posdetailsid],[posinvoice],[itemid],[quantity],[price]) VALUES  ('"+mvarposdetailsid+"','"+mvarposinvoice+"','"+mvaritemid+"','"+mvarquantity+"','"+mvarprice+"')";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set posinvoice='"+mvarposinvoice+"',itemid='"+mvaritemid+"',quantity='"+mvarquantity+"',price='"+mvarprice+"' where   posdetailsid = "+mvarposdetailsid+"";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   posdetailsid = "+mvarposdetailsid+" ";
            dboperation.ExecuteSql(strsql);
        }
        public void DeleteDetails()
        {
            string strsql;
            strsql = "Delete from " + mvartablename + " where   posinvoice = " + posinvoice + " ";
            dboperation.ExecuteSql(strsql);
        }
        
        public int GetNextId()
        {
            string strsql;
            strsql="select max(posdetailsid) from " +  mvartablename +"";
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
            strsql="select posdetailsid,posinvoice,itemid,quantity,price from "+mvartablename+" ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select posdetailsid,posinvoice," + mvartablename + ".itemid,Description,quantity," + mvartablename + ".price from " + mvartablename + " join itemdetails on itemdetails.itemid= " + mvartablename + ".itemid where posinvoice=" + posinvoice;
            return dboperation.GetDataTable(strsql);
        }
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where posdetailsid="+mvarposdetailsid+" ";
            DataTable dt = dboperation.GetDataTable(strsql);
            if ((dt.Rows.Count > 0))
            {
                result = true;
                // Add Your Variable Here
            }
            return result;
        }
    }
}
