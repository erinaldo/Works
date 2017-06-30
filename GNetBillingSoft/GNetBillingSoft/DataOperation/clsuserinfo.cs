using System;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.IO;

namespace GNetBillingSoft.DataOperation
{


    public class clsuserinfo
    {

        private const string mvartablename = "userinfo";

        private long mvaruserid;

        private string mvarusername;

        private string mvarpassword;
        private const string initVector = "tu89geji340t89u2";

        private const int keysize = 256;
        private static long mvaruid;
        public long userid
        {
            get
            {
                return this.mvaruserid;
            }
            set
            {
                this.mvaruserid = value;
            }
        }
        public static long UID
        {
            get
            {
                return mvaruid;
            }
            set
            {
                mvaruid= value;
            }
        }
        public string username
        {
            get
            {
                return this.mvarusername;
            }
            set
            {
                this.mvarusername = value;
            }
        }

        public string password
        {
            get
            {
                return this.mvarpassword;
            }
            set
            {
                this.mvarpassword = value;
            }
        }

        public void Add()
        {
            string strsql;
            strsql = "INSERT INTO " + mvartablename + "([userid],[username],[password]) VALUES  ('" + mvaruserid + "','" + mvarusername + "','" + mvarpassword + "')";
            dboperation.ExecuteSql(strsql);
        }

        public void Edit()
        {
            string strsql;
            strsql = "update " + mvartablename + " set username='" + mvarusername + "',password='" + mvarpassword + "' where   userid = " + mvaruserid + "";
            dboperation.ExecuteSql(strsql);
        }

        public void Delete()
        {
            string strsql;
            strsql = "Delete from " + mvartablename + " where   userid = " + mvaruserid + " ";
            dboperation.ExecuteSql(strsql);
        }

        public int GetNextId()
        {
            string strsql;
            strsql = "select max(userid) from " + mvartablename + "";
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
        public bool CheckUserInfo(ref long userid)
        {
            string strsql;
            strsql = "select userid,username,password from " + mvartablename + " where username='" + mvarusername + "' and password='" + Encrypt(mvarpassword,"12345!@#$%") + "'";
            DataTable dt = dboperation.GetDataTable(strsql);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                userid = Convert.ToInt64(dt.Rows[0]["userid"].ToString());
                return true;
            }
        }

        public DataTable GetRecord()
        {
            string strsql;
            strsql = "select userid,username,password from " + mvartablename + " ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select userid,username,password from " + mvartablename + " where userid=" + mvaruserid + " ";
            return dboperation.GetDataTable(strsql);
        }

        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql = "select * from " + mvartablename + " where userid=" + mvaruserid + " ";

            DataTable dt = dboperation.GetDataTable(strsql);
            if ((dt.Rows.Count > 0))
            {
                result = true;
                // Add Your Variable Here
            }
            return result;
        }
        public void SetMenuTag(MenuStrip menu)
        {

            int count = menu.Items.Count;
            foreach (ToolStripMenuItem item in menu.Items)
            {

                foreach (ToolStripMenuItem subitem in item.DropDownItems)
                {

                }
            }
        }
        public string MD5Hash(string password)
        {
            MD5 md5 = MD5.Create();
            return GetMd5Hash(md5, password);
        }
        private string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes 
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string. 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }
        public  string Encrypt(string Text, string Key)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(Text);
            PasswordDeriveBytes password = new PasswordDeriveBytes(Key, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] Encrypted = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            return Convert.ToBase64String(Encrypted);
        }

        public  string Decrypt(string EncryptedText, string Key)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] DeEncryptedText = Convert.FromBase64String(EncryptedText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(Key, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(DeEncryptedText);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[DeEncryptedText.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }


        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
        public static string  GetUsername()
        {
            string strsql="select username from "+mvartablename+" where userid="+UID;
            DataTable dt = dboperation.GetDataTable(strsql);
            return dt.Rows[0]["username"].ToString();
        }
    }
}
