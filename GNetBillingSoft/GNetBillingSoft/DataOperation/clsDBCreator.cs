using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace GNetBillingSoft.DataOperation
{
    class clsDBCreator
    {
        static string strsql;
        static bool boolTrans;
        static  clscompanyinfo info = new clscompanyinfo();
        static  clsperiodinfo period = new clsperiodinfo();
        static clsuserinfo user = new clsuserinfo();
        static Thread _thread;
        //static SqlTransaction trans;
        //static SqlCommand cmd;
        public clsDBCreator()
        {
            
        }

        public static bool CreateCompany()
        {
            try
            {
                if (DBCreation())
                {
                    return true;
                }
                else
                    return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public void Testing()
        {
        }
        private  static bool  DBCreation()
        {
            try
            {
                

                clsproperties.CompanyName = Path.GetFileNameWithoutExtension(clsproperties.CompanyPath);
                strsql = "CREATE DATABASE " + clsproperties.CompanyName + ""
                + " ON "
                + "( NAME = " + clsproperties.CompanyName + ","
                + "FILENAME = '" + clsproperties.CompanyPath + "',"
                + "SIZE = 10,"
                + "MAXSIZE = UNLIMITED,"
                + "FILEGROWTH = 5 )"
                + "LOG ON"
                 + "( NAME = '" + clsproperties.CompanyName + "log',"
                + "FILENAME = '" + Path.GetDirectoryName(clsproperties.CompanyPath) + "\\" + clsproperties.CompanyName + "log.ldf" + "',"
                + "SIZE = 5MB,"
                + "MAXSIZE = 25MB,"
                + "FILEGROWTH = 5MB )";
                SqlCommand cmddb = new SqlCommand();
                cmddb.CommandText = strsql;
                cmddb.Connection =dboperation.GetConn(clsproperties.CompanyName);
                    
                cmddb.ExecuteNonQuery();
                clsproperties.CompConnection = dboperation.GetConn(clsproperties.CompanyName);
                
                return true;

               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
                
            }
            
        }
        public static void TableCreator(string str)
        {
           // if(clsproperties.BoolTrans==false)
               // trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
            try
            {

                
                boolTrans = true;
                clsproperties.BoolTrans = true;
                // cmd.Connection = clsproperties.CompConnection;
                switch (str)
                {
                    case "Creating Company Info...":
                        {

                           
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                           SqlCommand cmd = clsproperties.CompConnection.CreateCommand();
                         
                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='companyinfo' and xtype='U')"
                                      +"CREATE TABLE [dbo].[companyinfo]("
	                                  +"[companyid] [bigint] NOT NULL,"
	                                  +"[companyname] [varchar](100) NULL,"
                                      +"[displayname] [varchar](100) NULL,"
	                                  +"[address] [varchar](200) NULL,"
	                                  +"[address2] [varchar](200) NULL,"
	                                  +"[city] [varchar](100) NULL,"
	                                  +"[state] [varchar](100) NULL,"
	                                  +"[zipcode] [bigint] NULL,"
	                                  +"[country] [varchar](100) NULL,"
	                                  +"[telephone] [varchar](20) NULL,"
	                                  +"[mobileno] [varchar](20) NULL,"
	                                  +"[faxno] [varchar](100) NULL,"
	                                  +"[email] [varchar](100) NULL,"
                                      +"PRIMARY KEY CLUSTERED "
                                      +"("
	                                  +"[companyid] ASC"
                                      +")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                                      +") ON [PRIMARY]";
                            cmd.CommandText = strsql;
                           
                            clsproperties.PrgMessage = "Creating Period...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating Period...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='periodinfo' and xtype='U')"
                                     + "CREATE TABLE [dbo].[periodinfo]("
	                                 +"[periodid] [bigint] NOT NULL,"
	                                 +"[periodstart] [date] NULL,"
	                                 +"[periodend] [date] NULL,"
	                                 +"[active] [int] NULL,"
                                     +"[itemmaxid][bigint] default (1000) NULL,"
                                     +"CONSTRAINT [PK_periodinfo] PRIMARY KEY CLUSTERED "
                                     +"("
	                                 +"[periodid] ASC"
                                     +")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                                     +") ON [PRIMARY]";
                            cmd.CommandText = strsql;
                            cmd.Connection = clsproperties.CompConnection;
                            clsproperties.PrgMessage = "Creating user Info...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }

                    case "Creating user Info...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='userinfo' and xtype='U')"
                                     +"CREATE TABLE [dbo].[userinfo]("
	                                 +"[userid] [bigint] NOT NULL,"
	                                 +"[username] [varchar](100) NULL,"
	                                 +"[password] [varchar](100) NULL,"
                                     +"PRIMARY KEY CLUSTERED "
                                     +"("
	                                 +"[userid] ASC"
                                     +")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                                     +") ON [PRIMARY]";
                            cmd.CommandText = strsql;
                            cmd.Connection = clsproperties.CompConnection;
                            clsproperties.PrgMessage = "Creating itemdetails...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating itemdetails...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='itemdetails' and xtype='U')"
                                + "CREATE TABLE [dbo].[itemdetails]("
                                + "[itemid] [varchar](500) NOT NULL,"
                                + "[Description] [nvarchar](500) NULL,"
                                + "[Price] [float] NULL,"
                                + "[oldprice] [float] NULL,"
                                + "[salesrate] [float] NULL,"
                                + "[unit][varchar](50)NULL,"
                                +"[actualstock][bigint]NULL,"
                                +"[image] [varbinary](max) NULL,"
	                            +"[head] [bigint] NULL,"
	                            +"[imgpath] [varchar](100) NULL,"
                                + "[arabic_description] [nvarchar](2000) NULL,"
                                + "[fontcolor] [varchar](50) NULL,"
                                + "[backgroundcolor] [varchar] (100) NULL,"
                                + "[barcode] [varchar](500) NULL,"
                                 + "CONSTRAINT [PK_itemdetails] PRIMARY KEY CLUSTERED "
                                + "("
                                + "[itemid] ASC"
                                + ")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                                + ") ON [PRIMARY]";
                            cmd.CommandText = strsql;
                            cmd.Connection = clsproperties.CompConnection;
                            clsproperties.PrgMessage = "Creating purchasedetails...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating purchasedetails...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='purchasedetails' and xtype='U')"
                                + "CREATE TABLE [dbo].[purchasedetails]("
	                            +" [purchaseid] [bigint] NOT NULL,"
	                            +"[invoiceno] [varchar](500) NULL,"
	                            +"[itemid] [varchar](500) NULL,"
	                            +"[quantity] [float] NULL,"
	                            +"[unit] [varchar](50) NULL,"
	                            +"[price] [float] NULL,"
                                +"CONSTRAINT [PK_purchasedetails] PRIMARY KEY CLUSTERED "
                                +"("
	                            +"[purchaseid] ASC"
                                +")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                                +") ON [PRIMARY]";
                            cmd.CommandText = strsql;
                            cmd.Connection = clsproperties.CompConnection;
                            clsproperties.PrgMessage = "Creating purchaseinvoice...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating purchaseinvoice...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='purchaseinvoice' and xtype='U')"
                                + "CREATE TABLE [dbo].[purchaseinvoice]("
                                + "[invoiceno] [varchar](500) NOT NULL,"
                                + "[suplierName] [varchar](100) NULL,"
                                + "[phonenumber] [varchar](50) NULL,"
                                + "[address] [varchar](100) NULL,"
                                + "[discount] [float] NULL,"
                                + "[purchasedate] [date] NULL,"
                                + "[paidcash] [float] NULL,"
                                + "[paidcheque] [float] NULL,"
                                + "[referenceno] [varchar](100) NULL,"
                                + "[openingbalance] [float] NULL,"
                                + "CONSTRAINT [PK_purchaseinvoice] PRIMARY KEY CLUSTERED "
                                + "("
                                + "[invoiceno] ASC"
                                + ")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                                + ") ON [PRIMARY]";
                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Creating purchasereturn...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating purchasereturn...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='purchasereturn' and xtype='U')"
                                      +"CREATE TABLE [dbo].[purchasereturn]("
	                                  +"[returnno] [varchar](500) NOT NULL,"
	                                  +"[oldinvoiceno] [varchar](500) NULL,"
	                                  +"[phonenumber] [varchar](20) NULL,"
	                                  +"[address] [varchar](500) NULL,"
	                                  +"[supplier] [varchar](50) NULL,"
	                                  +"[paidamount] [float] NULL,"
	                                  +"[discount] [float] NULL,"
	                                  +"[returndate] [datetime] NULL,"
                                      +"CONSTRAINT [PK_purchasereturn] PRIMARY KEY CLUSTERED "
                                      +"("
	                                  +"[returnno] ASC"
                                      +")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                                      +") ON [PRIMARY]";

                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Creating purchasereturndetails...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating purchasereturndetails...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='purchasereturndetails' and xtype='U')"
                                      +"CREATE TABLE [dbo].[purchasereturndetails]("
	                                  +"[purchasereturnid] [bigint] NOT NULL,"
	                                  +"[returnno] [varchar](500) NULL,"
	                                  +"[itemid] [varchar](500) NULL,"
	                                  +"[quantity] [float] NULL,"
	                                  +"[unit] [varchar](50) NULL,"
	                                  +"[price] [float] NULL,"
                                      +"CONSTRAINT [PK_purchasereturndetails] PRIMARY KEY CLUSTERED "
                                      +"("
	                                  +"[purchasereturnid] ASC"
                                      +")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                                      +") ON [PRIMARY]";

                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Creating salesdetails...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating salesdetails...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='salesdetails' and xtype='U')"
                                + " CREATE TABLE [dbo].[salesdetails]("
                                + "[salesid] [bigint] NOT NULL,"
                                + "[invoiceno] [varchar](200) NULL,"
                                + "[itemid] [varchar](500) NULL,"
                                + "[quantity] [float] NULL,"
                                + "[unit] [varchar](50) NULL,"
                                + "[supplier] [varchar](100) NULL,"
                                + "[salesrate] [float] NULL,"
                                +"[newcost] [float],"
                                + "CONSTRAINT [PK_salesdetails] PRIMARY KEY CLUSTERED "
                                + "("
                                + "[salesid] ASC"
                                + ")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                                + ") ON [PRIMARY]";

                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Creating salesinvoice...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating salesinvoice...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='salesinvoice' and xtype='U')"
                                + "CREATE TABLE [dbo].[salesinvoice]("
                                + "[salesinvoice] [varchar](200) NOT NULL,"
                                + "[customerid] [bigint] NULL,"
                                + "[discount] [float] NULL,"
                                + "[additionaldiscount] [float] NULL,"
                                + "[paidcash] [float] NULL,"
                                + "[paidcheque] [float] NULL,"
                                + "[salesdate] [date] NULL,"
                                +"[salestime][time](7) NULL ,"
                                +"[userid] [bigint]  NULL,"
                                +"[closesales] [int] NULL,"
                                +"[delstatus] [int] NULL,"
                                +"[tokenno] [bigint] NULL,"
                                + "CONSTRAINT [PK_salesinvoice] PRIMARY KEY CLUSTERED "
                                + "("
                                + "[salesinvoice] ASC"
                                + ")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                                + ") ON [PRIMARY]";

                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Creating generalledger...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating generalledger...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='generalledger' and xtype='U')"
                                + "CREATE TABLE [dbo].[generalledger]("
                                + "[ledcode] [bigint] NOT NULL,"
                                + "[ledgerdate] [date] NULL,"
                                + "[ledgertime] [datetime] NULL,"
                                + "[particulars] [varchar](200) NULL,"
                                + "[Debitamt] [float] NULL,"
                                + "[Creditamt] [float] NULL,"
                                + "[Balance] [float] NULL,"
                                + "[voucherno] [varchar](200) NULL,"
                                + "[vouchertype] [varchar](50) NULL,"
                                +" [RVNO] [varchar] (500) NULL,"
                                + "CONSTRAINT [PK_generalledger] PRIMARY KEY CLUSTERED "
                                + "("
                                + "[ledcode] ASC"
                                + ")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                                + ") ON [PRIMARY]";

                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Creating voucher...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating voucher...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='voucher' and xtype='U')"
                               + "CREATE TABLE [dbo].[voucher]("
                               + "[voucherno] [bigint] NOT NULL,"
                               + "[typeoftransaction] [varchar](100) NULL,"
                               + "[typeofvoucher] [varchar](100) NULL,"
                               + "[voucherdate] [date] NULL,"
                               + "PRIMARY KEY CLUSTERED"
                               + "("
                               + "[voucherno] ASC"
                               + ")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                               + ") ON [PRIMARY]";

                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Creating voucherdetails...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating voucherdetails...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='voucherdetails' and xtype='U')"
                               + "CREATE TABLE [dbo].[voucherdetails]("
                               + "[voucherdetailno] [bigint] NOT NULL,"
                               + "[voucherno] [bigint] NULL,"
                               + "[accounttype] [varchar](100) NULL,"
                               + "[name] [varchar](100) NULL,"
                               + "[referenceinv] [varchar](100) NULL,"
                               + "[amount] [float] NULL,"
                               + "[remark] [varchar](200) NULL,"
                               + "[oldbalance] [float] NULL,"
                               + "CONSTRAINT [PK_voucherdetails] PRIMARY KEY CLUSTERED "
                               + "("
                               + "[voucherdetailno] ASC"
                               + ")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                               + ") ON [PRIMARY]";

                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Creating SalesReturn...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating SalesReturn...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='salesreturn' and xtype='U')"
                               + "CREATE TABLE [dbo].[salesreturn]("
	                           +"[salesreturnid] [varchar](200) NOT NULL,"
	                           +"[customerid] [bigint] NULL,"
	                           +"[customername] [varchar](200) NULL,"
	                           +"[phonenumber] [varchar](20) NULL,"
	                           +"[address] [varchar](500) NULL,"
	                           +"[discount] [float] NULL,"
	                           +"[paidcash] [float] NULL,"
	                           +"[salesreturndate] [date] NULL,"
	                           +"[oldinvoice] [varchar](200) NULL,"
                               +"CONSTRAINT [PK_salesreturn] PRIMARY KEY CLUSTERED "
                               +"("
	                           +"[salesreturnid] ASC"
                               +")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                               +") ON [PRIMARY]";

                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Creating SalesReturnDetails...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating SalesReturnDetails...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='salesreturndetails' and xtype='U')"
                               + "CREATE TABLE [dbo].[salesreturndetails]("
	                           +"[returndetailid] [bigint] NOT NULL,"
	                           +"[invoiceno] [varchar](200) NULL,"
	                           +"[itemid] [varchar](500) NULL,"
	                           +"[quantity] [float] NULL,"
	                           +"[unit] [varchar](50) NULL,"
	                           +"[supplier] [varchar](100) NULL,"
	                           +"[salesrate] [float] NULL,"
                               +"CONSTRAINT [PK_salesreturndetails] PRIMARY KEY CLUSTERED "
                               +"("
	                           +"[returndetailid] ASC"
                               +")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                               +") ON [PRIMARY]";

                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Creating POSGroup...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating POSGroup...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='posgroup' and xtype='U')"
                               + "CREATE TABLE [dbo].[posgroup]("
	                           +"[positemid] [bigint] NOT NULL,"
	                           +"[itemname] [nvarchar](500) NOT NULL,"
	                           +"[backimage] [varbinary](max) NULL,"
	                           +"[imagepath] [varchar](100) NULL,"
                               + "[backgroundcolor] [varchar] (100) NULL,"
                               +"CONSTRAINT [PK_positemmaster] PRIMARY KEY CLUSTERED" 
                               +"("
	                           +"[positemid] ASC"
                               +")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]"
                               +") ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]";

                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Creating POSInvoice...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating POSInvoice...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='posinvoice' and xtype='U')"
                              +"CREATE TABLE [dbo].[posinvoice]("
	                          +"[posinvoice] [bigint] NOT NULL,"
	                          +"[customerid] [bigint] NULL,"
	                          +"[posdate] [date] NULL,"
	                          +"[discount] [float] NULL,"
	                          +"[paidcash] [float] NULL,"
                              +"CONSTRAINT [PK_posinvoice] PRIMARY KEY CLUSTERED "
                              +"("
	                          +"[posinvoice] ASC"
                              +")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]"  
                              +") ON [PRIMARY]";

                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Creating POSDetails...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating POSDetails...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='posdetails' and xtype='U')"
                              +"CREATE TABLE [dbo].[posdetails]("
	                          +"[posdetailsid] [bigint] NOT NULL,"
	                          +"[posinvoice] [bigint] NULL,"
	                          +"[itemid] [bigint] NULL,"
	                          +"[quantity] [float] NULL,"
	                          +"[price] [float] NULL,"
                              +"CONSTRAINT [PK_posdetails] PRIMARY KEY CLUSTERED "
                              +"("
	                          +"[posdetailsid] ASC"
                              +")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]"
                              +") ON [PRIMARY]";

                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Creating Remarks...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating Remarks...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='remarks' and xtype='U')"
                              +"CREATE TABLE [dbo].[remarks]("
	                          +"[remarkid] [bigint] NOT NULL,"
                              +"[remarks] [nvarchar](500) NULL,"
                              +"CONSTRAINT [PK_remarks] PRIMARY KEY CLUSTERED "
                              +"("
	                          +"[remarkid] ASC"
                              +")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]"
                              +") ON [PRIMARY]";

                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Creating Units...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating Units...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='units' and xtype='U')"
                              +"CREATE TABLE [dbo].[units]("
	                          +"[unitid] [bigint] NOT NULL,"
	                          +"[units] [nvarchar](100) NULL,"
	                          +"[quantity] [float] NULL,"
                              +"PRIMARY KEY CLUSTERED "
                              +"("
	                          +"[unitid] ASC"
                              +")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]"
                              +") ON [PRIMARY]";

                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Creating CustomerDetails...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating CustomerDetails...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='customerdetails' and xtype='U')"
                              +"CREATE TABLE [dbo].[customerdetails]("
	                          +"[customerid] [bigint] NOT NULL,"
	                          +"[customername] [varchar](100) NULL,"
	                          +"[address] [varchar](200) NULL,"
	                          +"[phonenumber] [varchar](20) NULL,"
	                          +"[addeddate] [date] NULL,"
                              +"[cusopening] [float] null,"
                              +"PRIMARY KEY CLUSTERED "
                              +"("
	                          +"[customerid] ASC"
                              +")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]"
                              +") ON [PRIMARY]";

                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Creating SuplierDetails...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Creating SuplierDetails...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='suplierdetails' and xtype='U')"
                              +"CREATE TABLE [dbo].[suplierdetails]("
	                          +"[suplierid] [bigint] NOT NULL,"
	                          +"[supliername] [varchar](100) NULL,"
	                          +"[address] [varchar](500) NULL,"
	                          +"[phonenumber] [varchar](20) NULL,"
	                          +"[openingbalance] [float] NULL,"
	                          +"[addeddate] [date] NULL,"
                              +"CONSTRAINT [PK_suplierdetails] PRIMARY KEY CLUSTERED "
                              +"("
	                          +"[suplierid] ASC"
                              +")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                              +") ON [PRIMARY]";

                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Create Userroles...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Create Userroles...":
                        {
                             SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='userroles' and xtype='U')"
                            +" CREATE TABLE [dbo].[userroles]( "
	                        +" [userroleid] [bigint] NOT NULL,"
	                        +" [userid] [bigint] NULL,"
	                        +" [menuname] [varchar](200) NULL,"
                            +" CONSTRAINT [PK_userroles] PRIMARY KEY CLUSTERED "
                            +" ( "
	                        +" [userroleid] ASC"
                            +" )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]"
                            +" ) ON [PRIMARY]";
                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Create TokenSetting...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Create TokenSetting...":
                        {
                            SqlTransaction trans = clsproperties.CompConnection.BeginTransaction("TableTrans");
                            SqlCommand cmd = clsproperties.CompConnection.CreateCommand();

                            cmd.Transaction = trans;
                            strsql = "if not exists (select * from sysobjects where name='tokensettings' and xtype='U')"
                            +"CREATE TABLE [dbo].[tokensettings]("
	                        +"[tokenid] [bigint] NOT NULL,"
	                        +"[tokenstarttime] [datetime] NULL,"
	                        +"[tokenendtime] [datetime] NULL,"
	                        +"[tokenstartnumber] [float] NULL,"
	                        +"[addeddate] [datetime] NULL,"
	                        +"[addedby] [bigint] NULL,"
                            +"[currenttoken] [bigint] NULL,"
                            +"CONSTRAINT [PK_tokensettings] PRIMARY KEY CLUSTERED "
                            +"("
	                        +"[tokenid] ASC"
                            +")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]"
                            +") ON [PRIMARY]";
                            cmd.CommandText = strsql;
                            clsproperties.PrgMessage = "Dumping Default Value...";
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                            return;
                        }
                    case "Dumping Default Value...":
                        {
                            try
                            {
                                info.companyid = info.GetNextId();
                                info.companyname = clsproperties.CompanyName;
                                info.DisplayName = clsproperties.DisplayName;
                                info.address = clsproperties.Addr1;
                                info.address2 = clsproperties.Addr2;
                                info.city = clsproperties.City;
                                info.state = clsproperties.State;
                                info.zipcode = (clsproperties.Zip != "") ? Convert.ToInt64(clsproperties.Zip) : 0;
                                info.country = clsproperties.Country;
                                info.telephone = clsproperties.Telephone;
                                info.mobileno = clsproperties.Mobile;
                                info.faxno = clsproperties.Fax;
                                info.email = clsproperties.Email;
                                info.Add();

                                period.periodid = period.GetNextId();

                                period.periodstart = clsproperties.DtFrom;
                                period.periodend =clsproperties.DtTo;
                                period.active = 1;
                                period.Add();

                                user.userid = user.GetNextId();
                                user.username = "admin";
                                user.password = user.Encrypt("admin","12345!@#$%");
                                user.Add();
                                clsproperties.PrgMessage = "Finishing Company Creation...";

                                return;
                            }
                            catch (Exception defaulterror)
                            {
                                MessageBox.Show(defaulterror.Message);
                                clsproperties.TableFinish = true;
                            }
                            break;
                        }
                    case "Finishing Company Creation...":
                        {
                           // trans.Commit();
                            clsproperties.TableFinish = true;
                            
                            return;
                        }
                    

                }
                
            }
            catch (Exception e)
            {
               // trans.Rollback();
                dboperation.RollBackDb();
                clsproperties.TableFinish = true;
                MessageBox.Show(e.Message);
                return;
            }

        }
        public  bool DefaultValues()
        {
            try
            {
                info.companyid = info.GetNextId();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            

        }
        public static bool DropTable(string dbname)
        {
            try
            {
                clsproperties.CompanyName =null;
                SqlConnection con= dboperation.getMastConn();
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                
                clsproperties.CompanyName = dbname;
                string strsql = "drop database " + clsproperties.CompanyName;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = strsql;
                cmd.ExecuteNonQuery();
                clsproperties.CompanyName = null;
                //dboperation.ExecuteBackup(strsql);
                return true;
            }
            catch (Exception exdrop)
            {
                MessageBox.Show(exdrop.Message);
                return false;
            }

        }

        public static void Backup(string companyname)
        {
            string path = Application.StartupPath + "\\Backup\\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            dboperation.GetConn(companyname);
            string strsql = "backup database " + companyname + " to disk= '" + Application.StartupPath + "\\Backup\\" + companyname + ".bak'";
            //dboperation.ExecuteBackup(strsql,ba);
            dboperation.ExecuteBackup(strsql);

        }
        static Form frmwait;
        public static void Restore(OpenFileDialog backup)
        {
            mainmdi main = new mainmdi();
            string path = Application.StartupPath + "\\db\\";
            string filename = System.IO.Path.GetFileNameWithoutExtension(backup.FileName);

           // dboperation.DbRestore(backup, filename);
           
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            frmwait = new Form();
            frmwait.Name = "frmwait";
            frmwait.MdiParent = main.MdiParent;
            frmwait.Height = 100;
            frmwait.Width = 250;
            frmwait.MaximizeBox = false;
            frmwait.MinimizeBox = false;
           // frmwait.ControlBox = false;
            Label waitmsg = new Label();
            waitmsg.Text = "Please Wait...";
            waitmsg.Width = 250;
            waitmsg.Font = new System.Drawing.Font("Arial", 15);
            waitmsg.Left = 0;

            frmwait.Controls.Add(waitmsg);
            frmwait.Show();
            Application.DoEvents();

            dboperation.GetConn("master");
            string strsql = "RESTORE FILELISTONLY "
                         + " FROM DISK='" + backup.FileName + "'";
            DataTable dt = dboperation.GetDataTable(strsql);
            string mdfpath = dt.Rows[0]["LogicalName"].ToString();
            string ldfpath = dt.Rows[1]["LogicalName"].ToString();
            strsql = "RESTORE DATABASE " + filename
                         + " FROM DISK = '" + backup.FileName + "'"
                         + " WITH MOVE '" + mdfpath + "' TO '" + path + "\\" + filename + ".mdf',"
                         + " MOVE '" + ldfpath + "' TO '" + path + "\\" + filename + ".ldf'";



            if (dboperation.ExecuteBackup(strsql))
            {
                waitmsg.Text = "Restoration Completed";
                frmwait.Update();
                Thread.Sleep(500);
                frmwait.Close();
            }
            else
            {
                waitmsg.Text = "Restoration Failed";
                frmwait.Update();
                Thread.Sleep(500);
                frmwait.Close();
            }
        }
        private static void  StartRestore(string query)
        {

        }
        
    }
}
