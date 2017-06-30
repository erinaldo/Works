using System;
using System.Data;
using System.Collections.Generic;
namespace GNetBillingSoft.DataOperation
{
    
   
    public class clsitemdetails
    {
        clsperiodinfo period = new clsperiodinfo();
        private const string mvartablename = "itemdetails";
        
        private string mvaritemid;
        
        private string mvarDescription;
        
        private double mvarPrice;
        
        private double mvaroldprice;
        private double mvarsalesrate;
        private string mvartempid;
        private string mvarunit;
        private double mvaractualstock;
        private byte[] mvarimage=null;
        private Int64 mvarhead;
        private string mvarimgpath="";
        private string mvararabic;
        private string mvarfntcolor;
        private string mvarbackgroundcolor;
        private string mvarbarcode;
        public string itemid
        {
            get
            {
                return this.mvaritemid;
            }
            set
            {
                this.mvaritemid = value;
            }
        }
        public string ArabicDesc
        {
            get
            {
                return this.mvararabic;
            }
            set
            {
                this.mvararabic = value;
            }
        }
        public string FontColor
        {
            get
            {
                return this.mvarfntcolor;
            }
            set
            {
                this.mvarfntcolor = value;
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
        public string TempId
        {
            get
            {
                return this.mvartempid;
            }
            set
            {
                this.mvartempid = value;
            }
        }
        
        public string Description
        {
            get
            {
                return this.mvarDescription;
            }
            set
            {
                this.mvarDescription = value;
            }
        }
        
        public double Price
        {
            get
            {
                return this.mvarPrice;
            }
            set
            {
                this.mvarPrice = value;
            }
        }
        
        public double oldprice
        {
            get
            {
                return this.mvaroldprice;
            }
            set
            {
                this.mvaroldprice = value;
            }
        }
        public double salesrate
        {
            get
            {
                return this.mvarsalesrate;
            }
            set
            {
                this.mvarsalesrate = value;
            }
        }
        public string Unit
        {
            get
            {
                return this.mvarunit;
            }
            set
            {
                this.mvarunit = value;
            }
        }
        public double actualstock
        {
            get
            {
                return this.mvaractualstock;
            }
            set
            {
                this.mvaractualstock = value;
            }
        }
        public byte[] Image
        {
            get
            {
                return this.mvarimage;
            }
            set
            {
                this.mvarimage = value;

            }
        }
        public Int64 Head
        {
            get
            {
                return this.mvarhead;
            }
            set
            {
                this.mvarhead = value;
            }
        }
        public string ImgPath
        {
            get
            {
                return this.mvarimgpath;
            }
            set
            {
                this.mvarimgpath = value;
            }
        }
        public string Barcode
        {
            get
            {
                return this.mvarbarcode;
            }
            set
            {
                this.mvarbarcode = value;
            }
        }

        public void Add()
        {
            string strsql;
            strsql = "INSERT INTO " + mvartablename + "([itemid],[Description],[Price],[oldprice],[salesrate],[unit],[actualstock],[arabic_description],[fontcolor],[backgroundcolor],[barcode]) VALUES  ('" + mvaritemid + "','" + mvarDescription + "','" + mvarPrice + "','" + mvaroldprice + "','" + mvarsalesrate + "','" + mvarunit + "','" + mvaractualstock + "','" + mvararabic + "','" + mvarfntcolor + "','"+mvarbackgroundcolor+"','"+mvarbarcode+"')";
            dboperation.ExecuteSql(strsql);
        }
        
        public void Edit()
        {
            string strsql;
            strsql = "update " + mvartablename + " set Description='" + mvarDescription + "',Price='" + mvarPrice + "',oldprice='" + mvaroldprice + "',salesrate='" + mvarsalesrate + "',unit='" + mvarunit + "',actualstock='" + mvaractualstock + "',arabic_description='"+mvararabic+"',fontcolor='"+mvarfntcolor+"',backgroundcolor='"+mvarbackgroundcolor+"',barcode='"+mvarbarcode+"'  where   itemid = '" + mvaritemid + "'";
            dboperation.ExecuteSql(strsql);
        }
        public void EditPrice()
        {
            string strsql = "update " + mvartablename + " set salesrate='" + mvarsalesrate + "' where itemid='" + itemid + "'";
            dboperation.ExecuteSql(strsql);
        }
        public void ParameterizedAdd()
        {
            string strsql;
            strsql = "insert into " + mvartablename + "(itemid,Description,head,image,unit,salesrate,price,imgpath,actualstock,arabic_description,fontcolor,backgroundcolor,barcode) values(@itemid,@Description,@head,@image,@unit,@salesrate,@price,@imgpath,@actualstock,@arabic_description,@fontcolor,@backgroundcolor,@barcode)";
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("@itemid", itemid);
            data.Add("@Description", Description);
            data.Add("@head", Head);
            if (Image == null)
            {
                data.Add("@image", -1);
            }
            else
            {
                data.Add("@image", Image);
            }
            
            data.Add("@unit", Unit);
            data.Add("@salesrate", salesrate);
            data.Add("@price", Price);
            data.Add("@imgpath", ImgPath);
            data.Add("@actualstock", actualstock);
            data.Add("@arabic_description", ArabicDesc);
            data.Add("@fontcolor", FontColor);
            data.Add("@backgroundcolor", Backgroundcolor);
            data.Add("@barcode", Barcode);

            dboperation.ExecuteParameter(strsql, data);
        }
        public void ParameterizedEdit()
        {
            string strsql;
            strsql = "update " + mvartablename + " set Description=@Description,head=@head,image=@image,unit=@unit,salesrate=@salesrate,price=@price,imgpath=@imgpath,actualstock=@actualstock,arabic_description=@arabic_description,fontcolor=@fontcolor,backgroundcolor=@backgroundcolor,barcode=@barcode where itemid=@itemid";
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("@itemid", itemid);
            data.Add("@Description", Description);
            data.Add("@head", Head);
            data.Add("@salesrate", salesrate);
            data.Add("@price", Price);
            data.Add("@actualstock", actualstock);
            data.Add("@imgpath", ImgPath);
            data.Add("@arabic_description", ArabicDesc);
            data.Add("@fontcolor", FontColor);
            data.Add("@backgroundcolor", Backgroundcolor);
            data.Add("@barcode", Barcode);
            if (mvarimage == null)
            {
                data.Add("@image", -1);
            }
            else
            {
                data.Add("@image", mvarimage);
            }
            data.Add("@unit", mvarunit);
            dboperation.ExecuteParameter(strsql, data);
        }
       
        public void EditSalesRate()
        {
            string strsql;
            strsql = "update " + mvartablename + " set salesrate='" + mvarsalesrate + "'  where   itemid = '" + mvaritemid + "'";
            dboperation.ExecuteSql(strsql);
        }

        public void Delete()
        {
            string strsql;
            strsql="Delete from "+mvartablename+" where   itemid = '"+mvaritemid+"' ";
            dboperation.ExecuteSql(strsql);
        }
        
        /*public string GetNextId()
        {
            string strsql;
            strsql = "select max(itemid) from " + mvartablename + " where isnumeric(itemid)=1";
            object obj = dboperation.GetAValue(strsql);
            if ((obj == DBNull.Value))
            {
                return Convert.ToString(1000);
            }
            else
            {
                string incno = obj.ToString();



                double Num;

                bool isNum = double.TryParse(incno, out Num);

                if (isNum)
                {
                    return (Convert.ToInt64(incno) + 1).ToString();
                }


                Regex regex = new Regex(@"((?<number>\d+)(?<letter>[A-Za-z])|(?<letter>[a-zA-Z])(?<number>\d+))");
                char[] arrincno = incno.ToCharArray();
                Match m = regex.Match(incno);
                int number = int.Parse(m.Groups["number"].Value);
                string modified = m.Groups["letter"].Value;
                string maxid = "";
                for (int i = 0; i < arrincno.Length; i++)
                {
                    if (modified != arrincno[i].ToString())
                    {

                        maxid += arrincno[i];

                    }
                    else
                    {
                        break;
                    }
                }
                maxid = maxid + modified;
                number = number + 1;
                maxid += number.ToString();
                return maxid;
            }
        }*/
        public string GetNextId()
        {
            period.MaxName = "itemmaxid";
            return period.GetMaxid();
        }
        public void UpdateMaxid()
        {
            string strsql = "update periodinfo set itemmaxid=" + mvaritemid + " where active=1";

        }
        public DataTable GetRecord()
        {
            string strsql;
            strsql="select itemid,Description,Price,oldprice,unit from "+mvartablename+" ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable ListItems()
        {
            string strsql;
            strsql = "select itemid,Description,unit,head,itemname,salesrate,price,image,imgpath,actualstock,arabic_description,fontcolor,"+mvartablename+".backgroundcolor,barcode from " + mvartablename + " left join posgroup on posgroup.positemid="+mvartablename+".head "+((mvaritemid!=null)?"where itemid='"+mvaritemid+"'":"");
            return dboperation.GetDataTable(strsql);
        }
        public DataTable ListUnit()
        {
            string strsql;
            strsql = "select distinct unit from " + mvartablename + " ";
            return dboperation.GetDataTable(strsql);
        }
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql="select * from "+mvartablename+" where (itemid='"+mvaritemid+"' or Description='"+mvarDescription+"') ";
            DataTable dt = dboperation.GetDataTable(strsql);
            if ((dt.Rows.Count > 0))
            {
                result = true;
                // Add Your Variable Here
            }
            return result;
        }
       
        public DataTable SearchItems()
        {
            //strsql = "select itemdetails.itemid,Description,itemdetails.Price,itemdetails.salesrate,itemdetails.unit from " + mvartablename + " left join purchasedetails on itemdetails.itemid=purchasedetails.itemid left join salesdetails on salesdetails.itemid=itemdetails.itemid where (itemdetails.itemid = '" + mvaritemid + "' or itemdetails.description = '" + mvarDescription + "') group by itemdetails.itemid,Description,itemdetails.Price,itemdetails.salesrate,itemdetails.unit";
            //string strsql = "select itemdetails.itemid,Description,Price,itemdetails.salesrate,(sum(purchasedetails.quantity)-sum(salesdetails.quantity)) as Stock  from " + mvartablename + " left join purchasedetails on itemdetails.itemid=purchasedetails.itemid left join salesdetails on salesdetails.itemid=itemdetails.itemid where itemdetails.itemid like '%" + mvaritemid + "%' group by itemdetails.itemid,Description,Price,itemdetails.salesrate";
            string strsql = "SELECT A.itemid as Itemid,A.Description,Price as Cost,A.salesrate as Price,A.unit, [Stock] = (InvIn.TotalIn-InvReturn.TotalReturn) - (InvOut.TotalOut-InvSalesReturn.SReturn)"
                           + " FROM"
                           + " itemdetails A OUTER APPLY"
                           + "(SELECT TotalIn=ISNULL(SUM(quantity),0)"
                            + "FROM purchasedetails "
                          + " Where A.itemid =purchasedetails.itemid"
                            + ") InvIn OUTER APPLY"
                            +"(SELECT TotalReturn=ISNULL(SUM(quantity),0)"
                            +"FROM purchasereturndetails "
                            +" where A.itemid=purchasereturndetails.itemid"
                            +")InvReturn OUTER APPLY"
                            + "(SELECT TotalOut=ISNULL(SUM(quantity),0)"
                            + "FROM salesdetails"
                            + " Where A.itemid = salesdetails.itemid"
                           + " ) InvOut OUTER APPLY"
                           +"(SELECT SReturn=ISNULL(sum(quantity),0)"
                           +"FROM salesreturndetails"
                           +" where A.itemid=salesreturndetails.itemid"
                           +")InvSalesReturn "
                            +" where A.itemid like '" + mvaritemid + "%' or A.Description like '"+mvarDescription+"%'";
            DataTable dt = dboperation.GetDataTable(strsql);
            return dt;
        }
        public DataTable StockReport()
        {
            string strsql = "SELECT Row_number() OVER(ORDER BY (SELECT 1))  AS 'slno', A.itemid as code,A.Description as name,InvOut.unit as Unit,Price as cost,A.salesrate, [quantity] = (isnull(InvIn.TotalIn,0)-isnull(InvReturn.TotalReturn,0)) - isnull(InvOut.TotalOut,0),(((isnull(Invin.TotalIn,0)-isnull(InvReturn.TotalReturn,0))-isnull(InvOut.TotalOut,0))*Price) as totalcost,((isnull(Invin.TotalIn,0)-isnull(InvOut.TotalOut,0))*salesrate) as totalsales,actualstock as ActualStock"
                           + " FROM"
                           + " itemdetails A OUTER APPLY"
                           + "(SELECT TotalIn=ISNULL(SUM(quantity),0)"
                            + "FROM purchasedetails "
                          + " Where A.itemid =purchasedetails.itemid"
                            + ") InvIn OUTER APPLY"
                            +"(select TotalReturn=ISNULL(SUM(quantity),0)"
                            +"FROM purchasereturndetails "
                            +"where A.itemid=purchasereturndetails.itemid"
                            +")InvReturn OUTER APPLY"
                            + "(SELECT unit,TotalOut=ISNULL(SUM(isnull((units.quantity*salesdetails.quantity),salesdetails.quantity)),0)"
                            + "FROM salesdetails"
                            +" left join units on units.units=salesdetails.unit"
                            + " Where A.itemid = salesdetails.itemid"
                           + " group by unit ) InvOut";
            DataTable dt = dboperation.GetDataTable(strsql);
            return dt;
        }
        public DataTable SearchProduct()
        {
            string strsql = "";
            strsql = "select itemdetails.itemid,Description from " + mvartablename + " where (itemid like '"+mvaritemid+"%' or  Description like '" + mvarDescription + "%')";
          
            
            DataTable dt = dboperation.GetDataTable(strsql);
            return dt;
        }
        public DataTable GetSearchItems()
        {
            string strsql="";
            strsql = "select * from " + mvartablename + " where (itemid='" + mvaritemid + "' or description='"+mvarDescription+"')";
            
            DataTable dt = dboperation.GetDataTable(strsql);
            return dt;
        
        }
        public DataTable GetSalesItems()
        {
            string strsql;
           // strsql = "select itemdetails.itemid,Description,itemdetails.Price,itemdetails.salesrate,itemdetails.unit from " + mvartablename + " left join purchasedetails on itemdetails.itemid=purchasedetails.itemid left join salesdetails on salesdetails.itemid=itemdetails.itemid where (itemdetails.itemid = '" + mvaritemid + "' or itemdetails.description = '"+mvarDescription+"') group by itemdetails.itemid,Description,itemdetails.Price,itemdetails.salesrate,itemdetails.unit";
             strsql = "SELECT A.itemid as Itemid,A.Description,A.Price,A.salesrate,A.unit, [Stock] = (InvIn.TotalIn-InvReturn.TotalReturn) - (InvOut.TotalOut-InvSalesReturn.SReturn)"
                          + " FROM"
                          + " itemdetails A OUTER APPLY"
                          + "(SELECT TotalIn=ISNULL(SUM(quantity),0)"
                           + "FROM purchasedetails "
                         + " Where A.itemid =purchasedetails.itemid"
                           + ") InvIn OUTER APPLY"
                           + "(SELECT TotalReturn=ISNULL(SUM(quantity),0)"
                           + "FROM purchasereturndetails "
                           + " where A.itemid=purchasereturndetails.itemid"
                           + ")InvReturn OUTER APPLY"
                           + "(SELECT TotalOut=ISNULL(SUM(quantity),0)"
                           + "FROM salesdetails"
                           + " Where A.itemid = salesdetails.itemid"
                          + " ) InvOut OUTER APPLY"
                          + "(SELECT SReturn=ISNULL(sum(quantity),0)"
                          + "FROM salesreturndetails"
                          + " where A.itemid=salesreturndetails.itemid"
                          + ")InvSalesReturn "
                           + " where A.itemid like '" + mvaritemid + "%' or A.Description like '" + mvarDescription + "%'";
            DataTable dt = dboperation.GetDataTable(strsql);
            return dt;
        }
        public DataTable GetPOSRecord()
        {
            string strsql = "select * from " + mvartablename + " where itemid=" + mvaritemid;
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql = "select * from " + mvartablename + " where head=" + mvarhead;
            return dboperation.GetDataTable(strsql);
        }
        public Int64 GetItemid(string barcode)
        {
            string strsql = "select itemid from " + mvartablename + " where barcode='" + barcode+"'";
            DataTable dt = dboperation.GetDataTable(strsql);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt64(dt.Rows[0]["itemid"].ToString());
            }
            else
                return 0;
        }
       
    }
}
