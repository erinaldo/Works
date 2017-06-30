using System;
using System.Data;
namespace GNetBillingSoft.DataOperation
{
    
    
    public class clssalesreturndetails
    {
        
        private const string mvartablename = "salesreturndetails";
        
        private long mvarreturndetailid;
        
        private string mvarinvoiceno;
        
        private string mvaritemid;
        
        private double mvarquantity;
        
        private string mvarunit;
        
        private string mvarsupplier;
        
        private double mvarsalesrate;
        
        public long returndetailid
        {
            get
            {
                return this.mvarreturndetailid;
            }
            set
            {
                this.mvarreturndetailid = value;
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
        
        public double salesrate
        {
            get
            {
                return this.mvarsalesrate;
            }
            set
            {
                this.mvarsalesrate = value;
            }
        }
        
        public void Add()
        {
            string strsql;
            strsql="INSERT INTO "+ mvartablename+ "([returndetailid],[invoiceno],[itemid],[quantity],[unit],[supplier],[salesrate]) VALUES  ('"+mvarreturndetailid+"','"+mvarinvoiceno+"','"+mvaritemid+"','"+mvarquantity+"','"+mvarunit+"','"+mvarsupplier+"','"+mvarsalesrate+"')";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set invoiceno='"+mvarinvoiceno+"',itemid='"+mvaritemid+"',quantity='"+mvarquantity+"',unit='"+mvarunit+"',supplier='"+mvarsupplier+"',salesrate='"+mvarsalesrate+"' where   returndetailid = "+mvarreturndetailid+"";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   returndetailid = "+mvarreturndetailid+" ";
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
            strsql="select max(returndetailid) from " +  mvartablename +"";
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
            strsql="select returndetailid,invoiceno,itemid,quantity,unit,supplier,salesrate from "+mvartablename+" ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select returndetailid,invoiceno,salesreturndetails.itemid,Description,price,oldprice,quantity,itemdetails.unit,salesreturndetails.salesrate,supplier from " + mvartablename + ",itemdetails where  " + mvartablename + ".itemid=itemdetails.itemid and  invoiceno='" + mvarinvoiceno + "'";
            return dboperation.GetDataTable(strsql);
        }
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where returndetailid="+mvarreturndetailid+" ";
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
