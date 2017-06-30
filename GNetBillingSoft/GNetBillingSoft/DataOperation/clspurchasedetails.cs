using System;
using System.Data;
namespace GNetBillingSoft.DataOperation
{
    
    
    public class clspurchasedetails
    {
        
        private const string mvartablename = "purchasedetails";
        
        private long mvarpurchaseid;
        
        private string mvarinvoiceno;
        
        private string mvaritemid;
        
        private double  mvarquantity;
        
        private string mvarunit;
        private double mvarprice;
        
        public long purchaseid
        {
            get
            {
                return this.mvarpurchaseid;
            }
            set
            {
                this.mvarpurchaseid = value;
            }
        }
        
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
        
        public string itemid
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
        
        public string unit
        {
            get
            {
                return this.mvarunit;
            }
            set
            {
                this.mvarunit = value;
            }
        }
        public double Price
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
            strsql="INSERT INTO "+ mvartablename+ "([purchaseid],[invoiceno],[itemid],[quantity],[unit],[price]) VALUES  ('"+mvarpurchaseid+"','"+mvarinvoiceno+"','"+mvaritemid+"','"+mvarquantity+"','"+mvarunit+"','"+mvarprice+"')";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set invoiceno='"+mvarinvoiceno+"',itemid='"+mvaritemid+"',quantity='"+mvarquantity+"',unit='"+mvarunit+"',price='"+mvarprice+"' where   purchaseid = "+mvarpurchaseid+"";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   purchaseid = "+mvarpurchaseid+" ";
            dboperation.ExecuteSql(strsql);
        }
        public void DeleteDetails()
        {
            string strsql;
            strsql = "Delete from " + mvartablename + " where   invoiceno = '" + mvarinvoiceno + "' ";
            dboperation.ExecuteSql(strsql);
        }
        public int GetNextId()
        {
            string strsql;
            strsql="select max(purchaseid) from " +  mvartablename +"";
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
            strsql="select purchaseid,invoiceno,itemid,quantity,unit from "+mvartablename+" ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select purchaseid,invoiceno,purchasedetails.itemid,Description,purchasedetails.price,oldprice,quantity,purchasedetails.unit,salesrate from " + mvartablename + ",itemdetails where  " + mvartablename + ".itemid=itemdetails.itemid and  invoiceno='" + mvarinvoiceno + "'";
            return dboperation.GetDataTable(strsql);
        }
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where purchaseid="+mvarpurchaseid+" ";
            DataTable dt = dboperation.GetDataTable(strsql);
            if ((dt.Rows.Count > 0))
            {
                result = true;
                // Add Your Variable Here
            }
            return result;
        }
        public double GetStock()
        {
            string strsql;
            strsql = "select sum(quantity) as Stock from " + mvartablename + " where itemid=" + mvaritemid;
            DataTable dt = dboperation.GetDataTable(strsql);
            if (dt.Rows[0]["Stock"].ToString()=="")
            {
                return 0;
            }
            else
            {
                return Convert.ToDouble(dt.Rows[0]["Stock"].ToString());
            }
        }
    }
}
