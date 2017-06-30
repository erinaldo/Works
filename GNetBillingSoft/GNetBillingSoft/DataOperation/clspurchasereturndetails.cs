using System;
using System.Data;

namespace GNetBillingSoft.DataOperation
{
    
    
    public class clspurchasereturndetails
    {
        
        private const string mvartablename = "purchasereturndetails";
        
        private long mvarpurchasereturnid;
        
        private string mvarreturnno;
        
        private string mvaritemid;
        
        private double  mvarquantity;
        
        private string mvarunit;
        private double mvarprice;
        
        public long purchasereturnid
        {
            get
            {
                return this.mvarpurchasereturnid;
            }
            set
            {
                this.mvarpurchasereturnid = value;
            }
        }
        
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
        
        public double  quantity
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
            strsql="INSERT INTO "+ mvartablename+ "([purchasereturnid],[returnno],[itemid],[quantity],[unit],[price]) VALUES  ('"+mvarpurchasereturnid+"','"+mvarreturnno+"','"+mvaritemid+"','"+mvarquantity+"','"+mvarunit+"','"+mvarprice+"')";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set returnno='"+mvarreturnno+"',itemid='"+mvaritemid+"',quantity='"+mvarquantity+"',unit='"+mvarunit+"',price='"+mvarprice+"' where   purchasereturnid = "+mvarpurchasereturnid+"";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   purchasereturnid = "+mvarpurchasereturnid+" ";
            dboperation.ExecuteSql(strsql);
        }
        public void DeleteDetails()
        {
            string strsql;
            strsql = "Delete from " + mvartablename + " where   returnno = '" + mvarreturnno + "' ";
            dboperation.ExecuteSql(strsql);
        }
        
        public int GetNextId()
        {
            string strsql;
            strsql="select max(purchasereturnid) from " +  mvartablename +"";
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
            strsql="select purchasereturnid,returnno,itemid,quantity,unit from "+mvartablename+" ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select purchasereturnid,returnno,purchasereturndetails.itemid,Description,purchasereturndetails.price,quantity,purchasereturndetails.unit,salesrate from " + mvartablename + ",itemdetails where  " + mvartablename + ".itemid=itemdetails.itemid and  returnno='" + mvarreturnno + "'";
            return dboperation.GetDataTable(strsql);
        }
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where purchasereturnid="+mvarpurchasereturnid+" ";
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
