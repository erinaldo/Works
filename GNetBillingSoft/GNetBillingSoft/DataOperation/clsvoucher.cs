using System;
using System.Data;

namespace GNetBillingSoft.DataOperation
{
    
    
    public class clsvoucher
    {
        
        private const string mvartablename = "voucher";
        
        private long mvarvoucherno;
        
        private string mvartypeoftransaction;
        
        private string mvartypeofvoucher;
        
        private System.DateTime mvarvoucherdate;
        
        public long voucherno
        {
            get
            {
                return this.mvarvoucherno;
            }
            set
            {
                this.mvarvoucherno = value;
            }
        }
        
        public string typeoftransaction
        {
            get
            {
                return this.mvartypeoftransaction;
            }
            set
            {
                this.mvartypeoftransaction = value;
            }
        }
        
        public string typeofvoucher
        {
            get
            {
                return this.mvartypeofvoucher;
            }
            set
            {
                this.mvartypeofvoucher = value;
            }
        }
        
        public System.DateTime voucherdate
        {
            get
            {
                return this.mvarvoucherdate;
            }
            set
            {
                this.mvarvoucherdate = value;
            }
        }
        
        public void Add()
        {
            string strsql;
            strsql="INSERT INTO "+ mvartablename+ "([voucherno],[typeoftransaction],[typeofvoucher],[voucherdate]) VALUES  ('"+mvarvoucherno+"','"+mvartypeoftransaction+"','"+mvartypeofvoucher+"','"+mvarvoucherdate.Year+"-"+mvarvoucherdate.Month+"-"+mvarvoucherdate.Day+"')";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set typeoftransaction='"+mvartypeoftransaction+"',typeofvoucher='"+mvartypeofvoucher+"',voucherdate='"+mvarvoucherdate.Year+"-"+mvarvoucherdate.Month+"-"+mvarvoucherdate.Day+"' where   voucherno = "+mvarvoucherno+"";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   voucherno = "+mvarvoucherno+" ";
            dboperation.ExecuteSql(strsql);
        }
        
        public int GetNextId()
        {
            string strsql;
            strsql="select max(voucherno) from " +  mvartablename +"";
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
            strsql="select voucherno,typeoftransaction,typeofvoucher,voucherdate from "+mvartablename+" ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select voucherno,typeoftransaction,typeofvoucher,voucherdate from " + mvartablename + " where voucherno='"+mvarvoucherno+"' ";
            return dboperation.GetDataTable(strsql);
        }
        
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where voucherno="+mvarvoucherno+" ";
            DataTable dt = dboperation.GetDataTable(strsql);
            if ((dt.Rows.Count > 0))
            {
                result = true;
                // Add Your Variable Here
            }
            return result;
        }
        public DataTable GetIds()
        {
            string strsql;
            strsql = "select voucherno from " + mvartablename + " order by voucherno desc ";
            return dboperation.GetDataTable(strsql);
        }
    }
}
