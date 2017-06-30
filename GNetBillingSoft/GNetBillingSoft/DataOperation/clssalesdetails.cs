using System;
using System.Data;

namespace GNetBillingSoft.DataOperation
{
    
    
    public class clssalesdetails
    {
        
        private const string mvartablename = "salesdetails";
        
        private long mvarsalesid;
        
        private string mvarinvoiceno;
        
        private string mvaritemid;
        
        private double mvarquantity;
        
        private string mvarunit;
        private string mvarsupplier;
        private double mvarsalesrate;
        private double mvarnewcost;
        public long salesid
        {
            get
            {
                return this.mvarsalesid;
            }
            set
            {
                this.mvarsalesid = value;
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
        public string Supplier
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
        public double SalesRate
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
        public double NewCost
        {
            get
            {
                return this.mvarnewcost;
            }
            set
            {
                this.mvarnewcost = value;
            }
        }
        public void Add()
        {
            string strsql;
            strsql="INSERT INTO "+ mvartablename+ "([salesid],[invoiceno],[itemid],[quantity],[unit],[supplier],[salesrate],[newcost]) VALUES  ('"+mvarsalesid+"','"+mvarinvoiceno+"','"+mvaritemid+"','"+mvarquantity+"','"+mvarunit+"','"+mvarsupplier+"','"+mvarsalesrate+"','"+mvarnewcost+"')";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set invoiceno='"+mvarinvoiceno+"',itemid='"+mvaritemid+"',quantity='"+mvarquantity+"',unit='"+mvarunit+"', supplier='"+mvarsupplier+"',salesrate='"+mvarsalesrate+"',newcost='"+mvarnewcost+"' where   salesid = "+mvarsalesid+"";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   salesid = "+mvarsalesid+" ";
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
            strsql="select max(salesid) from " +  mvartablename +"";
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
            strsql="select salesid,invoiceno,itemid,quantity,unit from "+mvartablename+" ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select salesid,invoiceno,salesdetails.itemid,Description,price,oldprice,quantity,isnull(salesdetails.unit,itemdetails.unit) as unit,salesdetails.salesrate,supplier,newcost from " + mvartablename + ",itemdetails where  " + mvartablename + ".itemid=itemdetails.itemid and  invoiceno='" + mvarinvoiceno + "'";
            return dboperation.GetDataTable(strsql);
        }
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where salesid="+mvarsalesid+" ";
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
