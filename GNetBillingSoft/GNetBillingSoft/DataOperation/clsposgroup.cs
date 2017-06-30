using System;
using System.Data;
using System.Collections.Generic;
namespace GNetBillingSoft.DataOperation
{

    
    
    public class clsposgroup
    {
        
        private const string mvartablename = "posgroup";
        
        private long mvarpositemid;
        
        private string mvaritemname;
        
        private byte[] mvarbackimage;
        private string mvarimagepath;
        private string mvaroperator;
        private double  mvaroperand = 0;
        private bool mvaroperation=true;
        private string mvarbackgroundcolor;
        public long positemid
        {
            get
            {
                return this.mvarpositemid;
            }
            set
            {
                this.mvarpositemid = value;
            }
        }
        
        public string itemname
        {
            get
            {
                return this.mvaritemname;
            }
            set
            {
                this.mvaritemname = value;
            }
        }
        
        public byte[] backimage
        {
            get
            {
                return this.mvarbackimage;
            }
            set
            {
                this.mvarbackimage = value;
            }
        }
        public string ImagePath
        {
            get
            {
                return this.mvarimagepath;
            }
            set
            {
                this.mvarimagepath = value;
            }
        }
        public string Backgroundcolor
        {
            get
            {
                return this.mvarbackgroundcolor;
            }
            set
            {
                this.mvarbackgroundcolor = value;
            }
        }
       
        public double  Operand
        {
            get
            {
                return this.mvaroperand;
            }
            set
            {
                this.mvaroperand = value;
            }
        }
        public string Operator
        {
            get
            {
                return this.mvaroperator;
            }
            set
            {
                this.mvaroperator = value;
            }
        }
        public bool  Operation
        {
            get
            {
                return this.mvaroperation;
            }
            set
            {
                this.mvaroperation = value;
            }
        }
        public void Add()
        {
            string strsql;
            strsql = "INSERT INTO " + mvartablename + "([positemid],[itemname],[backimage],[backgroundcolor]) VALUES  ('" + mvarpositemid + "','" + mvaritemname + "','" + mvarbackimage + "','" + mvarbackgroundcolor + "')";
            dboperation.ExecuteSql(strsql);
        }
        public void ParametirizedAdd()
        {
            string strsql = "insert into " + mvartablename + "(positemid,itemname,backimage,imagepath,backgroundcolor) values(@positemid,@itemname,@backimage,@imagepath,@backgroundcolor)";
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("@positemid", positemid);
            data.Add("@itemname", itemname);
            if (backimage != null)
            {
                data.Add("@backimage", backimage);
                data.Add("@imagepath", ImagePath);
            }
            else
            {
                data.Add("@backimage", -1);
                data.Add("@imagepath", "");
            }
            data.Add("@backgroundcolor", Backgroundcolor);
            dboperation.ExecuteParameter(strsql, data);


        }
        public void ParametrizedEdit()
        {
            string strsql = "update " + mvartablename + " set itemname=@itemname,backimage=@backimage,imagepath=@imagepath,backgroundcolor=@backgroundcolor where positemid=@positemid";
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("@positemid", positemid);
            data.Add("@itemname", itemname);
            if (backimage != null)
            {
                data.Add("@backimage", backimage);
                data.Add("@imagepath", ImagePath);
            }
            else
            {
                data.Add("@backimage", -1);
                data.Add("@imagepath", "");
            }
            data.Add("@backgroundcolor", Backgroundcolor);
            dboperation.ExecuteParameter(strsql, data);
        }

        public DataTable ChildNodes()
        {
            string strsql = "select itemid,Description,image,fontcolor,backgroundcolor from itemdetails where head=" + mvarpositemid;
            DataTable dt = dboperation.GetDataTable(strsql);
            return dt;
        }
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set itemname='"+mvaritemname+"',backimage='"+mvarbackimage+"' where   positemid = "+mvarpositemid+"";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   positemid = "+mvarpositemid+" ";
            dboperation.ExecuteSql(strsql);
        }
        
        public int GetNextId()
        {
            string strsql;
            strsql="select max(positemid) from " +  mvartablename +"";
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
            strsql = "select positemid,itemname,backimage,imagepath,backgroundcolor from " + mvartablename;
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select positemid,itemname,backimage,imagepath,backgroundcolor from " + mvartablename+" where positemid="+positemid;
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetData()
        {
            string strsql;
            strsql = "select positemid,itemname,backimage,imagepath from " + mvartablename+" positemid="+positemid;
            return dboperation.GetDataTable(strsql);
        }
        
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where positemid="+mvarpositemid+" ";
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
