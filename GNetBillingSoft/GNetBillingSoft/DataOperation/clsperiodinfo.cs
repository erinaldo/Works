using System;
using System.Data;

namespace GNetBillingSoft.DataOperation
{
    
    
    public class clsperiodinfo
    {
        
        private const string mvartablename = "periodinfo";
        
        private long mvarperiodid;
        
        private System.DateTime mvarperiodstart;
        
        private System.DateTime mvarperiodend;
        
        private int mvaractive;
        private string mvarmaxname;
        private long mvarmaxid;
        public long periodid
        {
            get
            {
                return this.mvarperiodid;
            }
            set
            {
                this.mvarperiodid = value;
            }
        }
        
        public System.DateTime periodstart
        {
            get
            {
                return this.mvarperiodstart;
            }
            set
            {
                this.mvarperiodstart = value;
            }
        }
        
        public System.DateTime periodend
        {
            get
            {
                return this.mvarperiodend;
            }
            set
            {
                this.mvarperiodend = value;
            }
        }
        
        public int active
        {
            get
            {
                return this.mvaractive;
            }
            set
            {
                this.mvaractive = value;
            }
        }
        public string MaxName
        {
            get
            {
                return this.mvarmaxname;
            }
            set
            {
                this.mvarmaxname = value;
            }
        }
        public long Maxid
        {
            get
            {
                return this.mvarmaxid;
            }
            set
            {
                this.mvarmaxid = value;
            }
        }
        public clsperiodinfo()
        {
            //DataTable dt = this.GetRecord();
            //this.mvarperiodstart =Convert.ToDateTime( dt.Rows[0]["periodstart"].ToString());
            //this.mvarperiodend = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());
        }
        public void Add()
        {
            string strsql;

            strsql="INSERT INTO "+ mvartablename+ "([periodid],[periodstart],[periodend],[active]) VALUES  ('"+mvarperiodid+"','"+mvarperiodstart.Year+"-"+mvarperiodstart.Month+"-"+mvarperiodstart.Day+"','"+mvarperiodend.Year+"-"+mvarperiodend.Month+"-"+mvarperiodend.Day+"',"+mvaractive+")";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set periodstart='"+mvarperiodstart.Year+"-"+mvarperiodstart.Month+"-"+mvarperiodstart.Day+"',periodend='"+mvarperiodend.Year+"-"+mvarperiodend.Month+"-"+mvarperiodend.Day+"',active="+mvaractive+" where   periodid = "+mvarperiodid+"";
            dboperation.ExecuteSql(strsql);
        }
        public void EditPeriod()
        {
            string strsql;
            strsql = "update " + mvartablename + " set  periodstart='" + mvarperiodstart.Year+"-"+mvarperiodstart.Month+"-"+mvarperiodstart.Day + "',periodend='" + mvarperiodend.Year+"-"+mvarperiodend.Month+"-"+mvarperiodend.Day + "' where   active=1";
            dboperation.ExecuteSql(strsql);
        }
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   periodid = "+mvarperiodid+" ";
            dboperation.ExecuteSql(strsql);
        }
        
        public int GetNextId()
        {
            string strsql;
            strsql="select max(periodid) from " +  mvartablename +"";
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
        public string GetMaxid()
        {
            string strsql;
            strsql = "select "+mvarmaxname+" from " + mvartablename + " where active=1";
            DataTable dt = dboperation.GetDataTable(strsql);
            return dt.Rows[0][mvarmaxname].ToString();

        }
        public void UpdateMaxid()
        {
            string strsql = "update " + mvartablename + " set " + mvarmaxname + "=" + mvarmaxid + " where active=1";
            dboperation.ExecuteSql(strsql);
        }

        public DataTable GetRecord()
        {
            string strsql;
            strsql="select periodid,periodstart,periodend,active from "+mvartablename+" where active=1 ";
            return dboperation.GetDataTable(strsql);
        }
        
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where periodid="+mvarperiodid+" ";
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
