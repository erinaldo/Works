using System;
using System.Data;

namespace GNetBillingSoft.DataOperation
{
    
    
    public class clstokensettings
    {
        
        private const string mvartablename = "tokensettings";
        
        private long mvartokenid;
        
        private System.DateTime mvartokenstarttime;
        
        private System.DateTime mvartokenendtime;
        
        private double mvartokenstartnumber;
        
        private System.DateTime mvaraddeddate;
        
        private long mvaraddedby;
        private long mvarcurrenttoken;
        
        public long tokenid
        {
            get
            {
                return this.mvartokenid;
            }
            set
            {
                this.mvartokenid = value;
            }
        }
        
        public System.DateTime tokenstarttime
        {
            get
            {
                return this.mvartokenstarttime;
            }
            set
            {
                this.mvartokenstarttime = value;
            }
        }
        
        public System.DateTime tokenendtime
        {
            get
            {
                return this.mvartokenendtime;
            }
            set
            {
                this.mvartokenendtime = value;
            }
        }
        
        public double tokenstartnumber
        {
            get
            {
                return this.mvartokenstartnumber;
            }
            set
            {
                this.mvartokenstartnumber = value;
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
        
        public long addedby
        {
            get
            {
                return this.mvaraddedby;
            }
            set
            {
                this.mvaraddedby = value;
            }
        }
        public long CurrentToken
        {
            get
            {
                return this.mvarcurrenttoken;
            }
            set
            {
                this.mvarcurrenttoken = value;
            }
        }
        
        public void Add()
        {
            string strsql;
            strsql="INSERT INTO "+ mvartablename+ "([tokenid],[tokenstarttime],[tokenendtime],[tokenstartnumber],[addeddate],[addedby],[currenttoken]) VALUES  ('"+mvartokenid+"','"+mvartokenstarttime.Hour+":"+mvartokenstarttime.Minute+"','"+mvartokenendtime.Hour+":"+mvartokenendtime.Minute+"','"+mvartokenstartnumber+"','"+mvaraddeddate.Year+"-"+mvaraddeddate.Month+"-"+mvaraddeddate.Day+"','"+mvaraddedby+"',"+mvarcurrenttoken+")";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set tokenstarttime='"+mvartokenstarttime.Hour+":"+mvartokenstarttime.Minute+"',tokenendtime='"+mvartokenendtime.Hour+":"+mvartokenendtime.Minute+"',tokenstartnumber='"+mvartokenstartnumber+"',addeddate='"+mvaraddeddate.Year+"-"+mvaraddeddate.Month+"-"+mvaraddeddate.Day+"',addedby='"+mvaraddedby+"',currenttoken="+mvarcurrenttoken+" where   tokenid = "+mvartokenid+"";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   tokenid = "+mvartokenid+" ";
            dboperation.ExecuteSql(strsql);
        }
        public void DeleteAll()
        {
            string strsql;
            strsql = "Delete from " + mvartablename;
            dboperation.ExecuteSql(strsql);
        }
        
        public int GetNextId()
        {
            string strsql;
            strsql="select max(tokenid) from " +  mvartablename +"";
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
            strsql="select tokenid,tokenstarttime,tokenendtime,tokenstartnumber,addeddate,addedby,currenttoken from "+mvartablename+" ";
            return dboperation.GetDataTable(strsql);
        }
        
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where tokenid="+mvartokenid+" ";
            DataTable dt = dboperation.GetDataTable(strsql);
            if ((dt.Rows.Count > 0))
            {
                result = true;
                // Add Your Variable Here
            }
            return result;
        }
        public static long GetNextToken()
        {
            string strsql = "select * from " + mvartablename;
            DataTable dt = dboperation.GetDataTable(strsql);
            if(dt.Rows.Count>0)
            {
                DateTime starttime = Convert.ToDateTime(dt.Rows[0]["tokenstarttime"].ToString());
                DateTime endtime = Convert.ToDateTime(dt.Rows[0]["tokenendtime"].ToString());
                if (starttime > endtime)
                {
                    DateTime newstart = Convert.ToDateTime(DateTime.Now.ToShortDateString() + " " + starttime.Hour + ":" + starttime.Minute);
                    DateTime newend = Convert.ToDateTime(DateTime.Now.AddDays(1).ToShortDateString() + " " + endtime.Hour + ":" + endtime.Minute);
                    if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour <= 12)
                    {
                        newstart = Convert.ToDateTime(DateTime.Now.AddDays(-1).ToShortDateString() + " " + starttime.Hour + ":" + starttime.Minute);
                        newend = Convert.ToDateTime(DateTime.Now.ToShortDateString() + " " + endtime.Hour + ":" + endtime.Minute);
                    }
                  
                    
                    
                    strsql = "select ISNULL(max(tokenno),0) as tokenno from salesinvoice where (cast(salesdate as date) + cast(salestime as datetime)) between '" + newstart.Year + "-" + newstart.Month + "-" + newstart.Day + " " + newstart.Hour + ":" + newstart.Minute + "' and '" + newend.Year + "-" + newend.Month + "-" + newend.Day + " " + newend.Hour + ":" + newend.Minute + "'";
                    DataTable dtmax = dboperation.GetDataTable(strsql);
                    if (Convert.ToInt64(dtmax.Rows[0]["tokenno"].ToString()) == 0)
                    {
                        return Convert.ToInt64(dt.Rows[0]["currenttoken"].ToString());
                    }
                    else
                    {
                        long currenttoken=Convert.ToInt64(dt.Rows[0]["currenttoken"].ToString()) + 1;
                        strsql="update "+mvartablename+" set currenttoken="+currenttoken;
                        dboperation.ExecuteSql(strsql);
                        return currenttoken;
                    }
                }
                else
                {
                    DateTime newstart = Convert.ToDateTime(DateTime.Now.ToShortDateString() + " " + starttime.Hour + ":" + starttime.Minute);
                    DateTime newend = Convert.ToDateTime(DateTime.Now.ToShortDateString() + " " + endtime.Hour + ":" + endtime.Minute);
                    //if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour <= 12)
                    //{
                    //    newstart = Convert.ToDateTime(DateTime.Now.AddDays(-1).ToShortDateString() + " " + starttime.Hour + ":" + starttime.Minute);
                    //    newend = Convert.ToDateTime(DateTime.Now.ToShortDateString() + " " + endtime.Hour + ":" + endtime.Minute);
                    //}
                    strsql = "select ISNULL(max(tokenno),0) as tokenno from salesinvoice where (cast(salesdate as date) + cast(salestime as datetime)) between '" + newstart.Year + "-" + newstart.Month + "-" + newstart.Day + " " + newstart.Hour + ":" + newstart.Minute + "' and '" + newend.Year + "-" + newend.Month + "-" + newend.Day + " " + newend.Hour + ":" + newend.Minute + "'";
                    DataTable dtmax = dboperation.GetDataTable(strsql);
                    if (Convert.ToInt64(dtmax.Rows[0]["tokenno"].ToString()) == 0)
                    {
                        return Convert.ToInt64(dt.Rows[0]["currenttoken"].ToString());
                    }
                    else
                    {
                        long currenttoken = Convert.ToInt64(dt.Rows[0]["currenttoken"].ToString()) + 1;
                        strsql = "update " + mvartablename + " set currenttoken=" + currenttoken;
                        dboperation.ExecuteSql(strsql);
                        return currenttoken;
                    }

                }


            }
            return 0;
        }

    }
}
