using System;
using System.Data;

namespace GNetBillingSoft.DataOperation
{
    
    
    public class clsgeneralledger
    {
        
        private const string mvartablename = "generalledger";
        
        private long mvarledcode;
        
        private System.DateTime mvarledgerdate;
        
        private System.DateTime mvarledgertime;
        
        private string mvarparticulars;
        
        private double  mvarDebitamt;

        private double mvarCreditamt;
        
        private double mvarBalance;
        
        private string mvarvoucherno;
        private string mvarvouchertype;
        private string mvarrvno;
        public long ledcode
        {
            get
            {
                return this.mvarledcode;
            }
            set
            {
                this.mvarledcode = value;
            }
        }
        
        public System.DateTime ledgerdate
        {
            get
            {
                return this.mvarledgerdate;
            }
            set
            {
                this.mvarledgerdate = value;
            }
        }
        
        public System.DateTime ledgertime
        {
            get
            {
                return this.mvarledgertime;
            }
            set
            {
                this.mvarledgertime = value;
            }
        }
        
        public string particulars
        {
            get
            {
                return this.mvarparticulars;
            }
            set
            {
                this.mvarparticulars = value;
            }
        }
        
        public double Debitamt
        {
            get
            {
                return this.mvarDebitamt;
            }
            set
            {
                this.mvarDebitamt = value;
            }
        }
        
        public double Creditamt
        {
            get
            {
                return this.mvarCreditamt;
            }
            set
            {
                this.mvarCreditamt = value;
            }
        }
        
        public double Balance
        {
            get
            {
                return this.mvarBalance;
            }
            set
            {
                this.mvarBalance = value;
            }
        }
        
        public string voucherno
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
        public string VType
        {
            get
            {
                return this.mvarvouchertype;
            }
            set
            {
                this.mvarvouchertype = value;
            }
        }
        public string RVNo
        {
            get
            {
                return this.mvarrvno;
            }
            set
            {
                this.mvarrvno = value;
            }
        }
        public void Add()
        {
            string strsql;
            strsql="INSERT INTO "+ mvartablename+ "([ledcode],[ledgerdate],[ledgertime],[particulars],[Debitamt],[Creditamt],[Balance],[voucherno],[vouchertype],[RVNO]) VALUES  ('"+mvarledcode+"','"+mvarledgerdate.Year+"-"+mvarledgerdate.Month+"-"+mvarledgerdate.Day+"','"+mvarledgertime.Year+"-"+mvarledgertime.Month+"-"+mvarledgertime.Day+" "+mvarledgertime.Hour+":"+mvarledgertime.Minute+"','"+mvarparticulars+"','"+mvarDebitamt+"','"+mvarCreditamt+"','"+mvarBalance+"','"+mvarvoucherno+"','"+mvarvouchertype+"','"+mvarrvno+"')";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql="update "+ mvartablename+ " set ledgerdate='"+mvarledgerdate+"',ledgertime='"+mvarledgertime+"',particulars='"+mvarparticulars+"',Debitamt='"+mvarDebitamt+"',Creditamt='"+mvarCreditamt+"',Balance='"+mvarBalance+"',voucherno='"+mvarvoucherno+"',vouchertype='"+mvarvouchertype+"',RVNo='"+mvarrvno+"' where   ledcode = "+mvarledcode+"";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   ledcode = "+mvarledcode+" ";
            dboperation.ExecuteSql(strsql);
        }
        public void DeleteLedger()
        {
            string strsql;
            strsql = "Delete from " + mvartablename + " where   voucherno = '" + mvarvoucherno + "' and vouchertype='"+mvarvouchertype+"' ";
            dboperation.ExecuteSql(strsql);
        }
        
        public int GetNextId()
        {
            string strsql;
            strsql="select max(ledcode) from " +  mvartablename +"";
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
            strsql="select ledcode,ledgerdate,ledgertime,particulars,Debitamt,Creditamt,Balance,voucherno from "+mvartablename+" ";
            return dboperation.GetDataTable(strsql);
        }
        
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where ledcode="+mvarledcode+" ";
            DataTable dt = dboperation.GetDataTable(strsql);
            if ((dt.Rows.Count > 0))
            {
                result = true;
                // Add Your Variable Here
            }
            return result;
        }
        public string GetBalance()
        {
            string strsql = "";
            strsql = "select sum(Debitamt-Creditamt) as Balance from generalledger where particulars='" + mvarparticulars + "'   group by particulars";
           DataTable dt= dboperation.GetDataTable(strsql);
           if (dt.Rows.Count > 0)
           {
               return dt.Rows[0]["Balance"].ToString();
           }
           else
           {
               return "0";
           }
        }
        public string OldBalance()
        {
            string strsql = "";
            strsql = "select sum(Debitamt-Creditamt) as Balance from generalledger where particulars='" + mvarparticulars + "' and voucherno<'"+voucherno+"'   group by particulars";
            DataTable dt = dboperation.GetDataTable(strsql);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Balance"].ToString();
            }
            else
            {
                return "0";
            }
        }
        public string GetParticularsBalance()
        {
            string strsql = "";
            strsql = "select sum(Debitamt-Creditamt) as Balance from generalledger where particulars='" + mvarparticulars + "' and (voucherno='" + mvarvoucherno + "' or RVNO='"+mvarvoucherno+"')  group by particulars";
            DataTable dt = dboperation.GetDataTable(strsql);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Balance"].ToString();
            }
            else
            {
                return "0";
            }
        }
        public DataTable GetParticulars()
        {
            string strsql = "";
            strsql = "select distinct particulars from " + mvartablename;
           
            return dboperation.GetDataTable(strsql); ;
        }
        public DataTable GetInv()
        {
            string strsql = "";
            strsql = "select distinct voucherno from " + mvartablename + " where particulars='" + mvarparticulars + "' and (voucherno in (select salesinvoice from salesinvoice) or voucherno in (select invoiceno from purchaseinvoice))";
            return dboperation.GetDataTable(strsql);
        }
        public double  GetVoucherBalance()
        {
            string strsql = "";
            strsql = "select sum(creditamt-debitamt) as balance from generalledger where particulars='" + mvarparticulars + "' and voucherno<" + mvarvoucherno + "";
            DataTable dt= dboperation.GetDataTable(strsql);
            if (dt.Rows[0][0].ToString() != "")
            {
                return Convert.ToDouble(dt.Rows[0][0].ToString());
            }
            else
                return 0;
        }
    }
}
