using Microsoft.Win32;

namespace GNetBillingSoft.DataOperation
{
    class clsUpgrade
    {
        public static bool UpgradeItemDetails()
        {
            string strsql = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS "
           +" WHERE TABLE_NAME = 'itemdetails' AND COLUMN_NAME = 'actualstock') "
           +" BEGIN "
            +" ALTER TABLE itemdetails ADD actualstock bigint "
            +"END"
            +" IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS "
           + " WHERE TABLE_NAME = 'itemdetails' AND COLUMN_NAME = 'arabic_description') "
           +" BEGIN "
            +" ALTER TABLE itemdetails ADD arabic_description nvarchar(2000) "
            +"END"
            +" IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS "
           +" WHERE TABLE_NAME = 'itemdetails' AND COLUMN_NAME = 'fontcolor') "
           +" BEGIN "
            +" ALTER TABLE itemdetails ADD fontcolor varchar(50) "
            +"END"
             +" IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS "
           +" WHERE TABLE_NAME = 'itemdetails' AND COLUMN_NAME = 'backgroundcolor') "
           +" BEGIN "
            +" ALTER TABLE itemdetails ADD backgroundcolor varchar(100) "
            +"END"
             +" IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS "
           +" WHERE TABLE_NAME = 'itemdetails' AND COLUMN_NAME = 'barcode') "
           +" BEGIN "
            +" ALTER TABLE itemdetails ADD barcode varchar(500) "
            +"END";
            return dboperation.ExecuteSql(strsql);

        }
        public static bool UpgradeQuantity()
        {
            string strsql = " alter table purchasedetails alter column quantity float"
            +" alter table salesdetails alter column quantity float"
            +" alter table purchasereturndetails alter column quantity float"
            +" alter table salesreturndetails alter column quantity float";
            return dboperation.ExecuteSql(strsql);
        }
        public static bool UpgradeSalesInvoice()
        {
            string strsql = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS "
           + " WHERE TABLE_NAME = 'salesinvoice' AND COLUMN_NAME = 'remarks') "
           + " BEGIN "
            + "ALTER TABLE salesinvoice ADD remarks nvarchar(100) "
            + "END"
            +" IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.COLUMNS"
            +" where TABLE_NAME='salesinvoice' and COLUMN_NAME='salestime')"
            +"BEGIN "
            +"ALTER TABLE salesinvoice ADD salestime time(7) "
            +" END"
            + " IF  EXISTS(SELECT * FROM INFORMATION_SCHEMA.COLUMNS"
            + " where TABLE_NAME='salesinvoice' and COLUMN_NAME='salestime')"
            + "BEGIN "
            + "ALTER TABLE salesinvoice alter column salestime time(7) "
            + " END"
            + " IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.COLUMNS"
            +" WHERE TABLE_NAME='salesinvoice' and COLUMN_NAME='userid')"
            +" BEGIN "
            +" ALTER TABLE salesinvoice ADD userid bigint "
            +" END"
            + " IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.COLUMNS"
            + " WHERE TABLE_NAME='salesinvoice' and COLUMN_NAME='closesales')"
            + " BEGIN "
            + " ALTER TABLE salesinvoice ADD closesales int null"
            + " END"
            + " IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.COLUMNS"
            + " WHERE TABLE_NAME='salesinvoice' and COLUMN_NAME='delstatus')"
            + " BEGIN "
            + " ALTER TABLE salesinvoice ADD delstatus int null"
            + " END"
            + " IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.COLUMNS"
            + " WHERE TABLE_NAME='salesinvoice' and COLUMN_NAME='tokenno')"
            + " BEGIN "
            + " ALTER TABLE salesinvoice ADD tokenno bigint null"
            + " END";
            return dboperation.ExecuteSql(strsql);
        }
        public static bool CreateUnitsTable()
        {
           string  strsql = "if not exists (select * from sysobjects where name='units' and xtype='U')"
                             + "CREATE TABLE [dbo].[units]("
                             + "[unitid] [bigint] NOT NULL,"
                             + "[units] [nvarchar](100) NULL,"
                             + "[quantity] [float] NULL,"
                             + "PRIMARY KEY CLUSTERED "
                             + "("
                             + "[unitid] ASC"
                             + ")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]"
                             + ") ON [PRIMARY]";
            return dboperation.ExecuteSql(strsql);
        }
        public static bool CreateRemarksTable()
        {
            string strsql = "if not exists (select * from sysobjects where name='remarks' and xtype='U')"
                              + "CREATE TABLE [dbo].[remarks]("
                              + "[remarkid] [bigint] NOT NULL,"
                              + "[remarks] [nvarchar](500) NULL,"
                              + "CONSTRAINT [PK_remarks] PRIMARY KEY CLUSTERED "
                              + "("
                              + "[remarkid] ASC"
                              + ")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]"
                              + ") ON [PRIMARY]";

            return dboperation.ExecuteSql(strsql);
        }
        public static bool UpgradeCustomerDetails()
        {
            string strsql = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS "
           + " WHERE TABLE_NAME = 'customerdetails' AND COLUMN_NAME = 'cusopening') "
           + " BEGIN "
            + "ALTER TABLE customerdetails ADD cusopening float null "
            + "END";
            return dboperation.ExecuteSql(strsql);
        }
        public static bool UpgradePurchaseInvoice()
        {
            string strsql = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS"
                + " WHERE TABLE_NAME='purchaseinvoice' and COLUMN_NAME='openingbalance') "
                + " BEGIN "
                + " ALTER TABLE purchaseinvoice ADD openingbalance float null "
                + " END";
            return dboperation.ExecuteSql(strsql);
        }
        public static bool CreateSuplierDetails()
        {
            string strsql = "if not exists (select * from sysobjects where name='suplierdetails' and xtype='U')"
                             + "CREATE TABLE [dbo].[suplierdetails]("
                             + "[suplierid] [bigint] NOT NULL,"
                             + "[supliername] [varchar](100) NULL,"
                             + "[address] [varchar](500) NULL,"
                             + "[phonenumber] [varchar](20) NULL,"
                             + "[openingbalance] [float] NULL,"
                             + "[addeddate] [date] NULL,"
                             + "CONSTRAINT [PK_suplierdetails] PRIMARY KEY CLUSTERED "
                             + "("
                             + "[suplierid] ASC"
                             + ")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                             + ") ON [PRIMARY]";
            return dboperation.ExecuteSql(strsql);
        }
        private static  void ChangeDateFormat()
        {
            RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            rkey.SetValue("sShortDate", "dd/MM/yyyy");
            
        }
        private static bool ChangeActualStock()
        {
            string strsql = " alter table itemdetails alter column actualstock float";
            return dboperation.ExecuteSql(strsql);
        }
        public  static bool UpdateAdminPassword()
        {
            clsuserinfo user =new clsuserinfo();

            string pwd=user.Encrypt("admin","12345!@#$%");
            string strsql = "update userinfo set password='" + pwd + "' where userid=1 and username='admin' and password='admin'";
            return dboperation.ExecuteSql(strsql);
        }
        public static bool AddUserroles()
        {
            string strsql = "if not exists (select * from sysobjects where name='userroles' and xtype='U')"
                            + " CREATE TABLE [dbo].[userroles]( "
                            + " [userroleid] [bigint] NOT NULL,"
                            + " [userid] [bigint] NULL,"
                            + " [menuname] [varchar](200) NULL,"
                            + " CONSTRAINT [PK_userroles] PRIMARY KEY CLUSTERED "
                            + " ( "
                            + " [userroleid] ASC"
                            + " )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]"
                            + " ) ON [PRIMARY]";
            return dboperation.ExecuteSql(strsql);

        }
        public static bool CreateTokenSetting()
        {
            string strsql = "if not exists (select * from sysobjects where name='tokensettings' and xtype='U')"
                            + "CREATE TABLE [dbo].[tokensettings]("
                            + "[tokenid] [bigint] NOT NULL,"
                            + "[tokenstarttime] [datetime] NULL,"
                            + "[tokenendtime] [datetime] NULL,"
                            + "[tokenstartnumber] [float] NULL,"
                            + "[addeddate] [datetime] NULL,"
                            + "[addedby] [bigint] NULL,"
                            + "CONSTRAINT [PK_tokensettings] PRIMARY KEY CLUSTERED "
                            + "("
                            + "[tokenid] ASC"
                            + ")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]"
                            + ") ON [PRIMARY]";
            return dboperation.ExecuteSql(strsql);
        }
        public static bool UpgradePOSGroup()
        {
            string strsql = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS "
           + " WHERE TABLE_NAME = 'posgroup' AND COLUMN_NAME = 'backgroundcolor') "
           + " BEGIN "
            + " ALTER TABLE posgroup ADD backgroundcolor varchar(100) NULL "
            + "END";
            return dboperation.ExecuteSql(strsql);
        }
        public static bool UpgradeTokenSetting()
        {
            string strsql = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS "
           + " WHERE TABLE_NAME = 'tokensettings' AND COLUMN_NAME = 'currenttoken') "
           + " BEGIN "
            + " ALTER TABLE tokensettings ADD currenttoken bigint NULL "
            + "END";
            return dboperation.ExecuteSql(strsql);
        }
        public static bool Upgrade()
        {
             UpgradeItemDetails();
             UpgradeQuantity();
             CreateRemarksTable();
             CreateUnitsTable();
             UpgradeSalesInvoice();
             UpgradeCustomerDetails();
             UpgradePurchaseInvoice();
             CreateSuplierDetails();
             ChangeDateFormat();
             ChangeActualStock();
             AddUserroles();
             UpgradePOSGroup();
             CreateTokenSetting();
             UpgradeTokenSetting();
             return true;
        }

    }
}
