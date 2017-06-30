using System;
using System.Data;

namespace GNetBillingSoft.DataOperation
{
    
    
    public class clsunits
    {
        
        private const string mvartablename = "units";
        
        private long mvarunitid;
        
        private string mvarunits;
        
        private double mvarquantity;
        
        public long unitid
        {
            get
            {
                return this.mvarunitid;
            }
            set
            {
                this.mvarunitid = value;
            }
        }
        
        public string units
        {
            get
            {
                return this.mvarunits;
            }
            set
            {
                this.mvarunits = value;
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
        
        public void Add()
        {
            string strsql;
            strsql="INSERT INTO "+ mvartablename+ "([unitid],[units],[quantity]) VALUES  ('"+mvarunitid+"','"+mvarunits+"','"+mvarquantity+"')";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set units='"+mvarunits+"',quantity='"+mvarquantity+"' where   unitid = "+mvarunitid+"";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   unitid = "+mvarunitid+" ";
            dboperation.ExecuteSql(strsql);
        }
        
        public int GetNextId()
        {
            string strsql;
            strsql="select max(unitid) from " +  mvartablename +"";
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
            strsql="select unitid,units,quantity from "+mvartablename+" ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select unitid,units,quantity from " + mvartablename + " where unitid="+unitid;
            DataTable dt= dboperation.GetDataTable(strsql);
            return dt;
        }
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where unitid="+mvarunitid+" ";
            DataTable dt = dboperation.GetDataTable(strsql);
            if ((dt.Rows.Count > 0))
            {
                result = true;
                // Add Your Variable Here
            }
            return result;
        }
        public void CheckUnits(string name)
        {
            string strsql = "select * from " + mvartablename + " where units='" + name+"'";
            DataTable dt = dboperation.GetDataTable(strsql);
            if (dt.Rows.Count == 0)
            {

                unitid = GetNextId();
                units = name;
                quantity = 1;
                Add();
                
            }

        }
    }
}
