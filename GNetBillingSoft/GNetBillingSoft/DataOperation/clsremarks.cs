using System;
using System.Data;

namespace GNetBillingSoft.DataOperation
{
    
    
    public class clsremarks
    {
        
        private const string mvartablename = "remarks";
        
        private long mvarremarkid;
        
        private string mvarremarks;
        
        public long remarkid
        {
            get
            {
                return this.mvarremarkid;
            }
            set
            {
                this.mvarremarkid = value;
            }
        }
        
        public string remarks
        {
            get
            {
                return this.mvarremarks;
            }
            set
            {
                this.mvarremarks = value;
            }
        }
        
        public void Add()
        {
            string strsql;
            strsql="INSERT INTO "+ mvartablename+ "([remarkid],[remarks]) VALUES  ('"+mvarremarkid+"','"+mvarremarks+"')";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set remarks='"+mvarremarks+"' where   remarkid = "+mvarremarkid+"";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   remarkid = "+mvarremarkid+" ";
            dboperation.ExecuteSql(strsql);
        }
        
        public int GetNextId()
        {
            string strsql;
            strsql="select max(remarkid) from " +  mvartablename +"";
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
            strsql="select remarkid,remarks from "+mvartablename+" ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select remarkid,remarks from " + mvartablename + " where remarkid="+remarkid;
            return dboperation.GetDataTable(strsql);
        }
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where remarkid="+mvarremarkid+" ";
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
