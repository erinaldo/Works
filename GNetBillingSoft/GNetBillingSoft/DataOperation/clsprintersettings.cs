using System;
using System.Windows.Forms;
using System.Data;

namespace GNetBillingSoft.DataOperation
{
    class clsprintersettings
    {
        System.IO.StreamWriter rdr;

		private string Bold_On = "_G";
		private string Bold_Off = "_H";
		private string Width_On = "_W1"; //Chr(27) + Chr(87) + Chr(49) 'W1
		private string Width_Off = "_W0";

		//Public Const Compress_On = "¤"       'Chr(15)    '¤"
		//Public Const Compress_Off = "_" 'Chr(18)   '_
		private string ELITE_PITCH = "_M";
		//private string Compress_On = "_ð ;      //Chr(15)    '¤"
		private string Compress_Off = "_";

		private int ColWidth=60;
		public string BillType;
		public string BillNo;
		public string BillDt;
		public string Clerk;
		public string ClientName="";
		public decimal Discount;
		public decimal TotalAmt;
		public decimal NetAmount;
		public decimal MRPTotal=0,SavedTotal=0;
		public System.Data.DataTable dt;

        public clsprintersettings()
		{			
			rdr=new System.IO.StreamWriter(Application.StartupPath+"\\test.txt");
			//rdr.AutoFlush();
		}
		public void Close()
		{			
			rdr.Close();			
		}
		public void PrintHeader()
		{
			//PrintLine();
            rdr.WriteLine("                          NEW NATIONAL TRADING EST.");
            rdr.WriteLine("                          AIA SFA DISCTRICT-JEDDAH");
			
		}
		public void PrintDetails(string invoiceno,DataTable details,double oldbalance)
		{
            rdr.WriteLine("Name :  " + details.Rows[0]["customername"].ToString());
		    rdr.WriteLine("Inv# : "+invoiceno+"                             Date : "+Convert.ToDateTime(details.Rows[0]["salesdate"]).ToShortDateString());
            
            
			rdr.WriteLine("|S/R#|Description                 |Quantity|Price   |Total      |");
            rdr.WriteLine("---------------------------------------------------------------------");
            double grandtotal=0;
            double totalquantity = 0;
            for (int i = 0; i < details.Rows.Count; i++)
            {
                rdr.Write("{0,5}","|"+GetFormatedText(Convert.ToString(i+1),5) + "|");
                rdr.Write("{0,5}",GetFormatedText(details.Rows[i]["Description"].ToString(), 29) + "|");
                //rdr.Write("{0,5}", GetFormatedText(details.Rows[i]["Description"].ToString(),28) + "|");
                rdr.Write("{0,5}",GetFormatedText(details.Rows[i]["quantity"].ToString(),9,1) + "|");
                rdr.Write("{0,5}",GetFormatedText(details.Rows[i]["salesrate"].ToString(),9,1) + "|");
                double total = Convert.ToDouble(details.Rows[i]["quantity"].ToString()) * Convert.ToDouble(details.Rows[i]["salesrate"].ToString());
                rdr.Write("{0,-20}",GetFormatedText(total.ToString(),12,1) + "|");
                rdr.WriteLine("");
                grandtotal+=total;
                totalquantity += Convert.ToDouble(details.Rows[i]["quantity"].ToString());
            }
            rdr.WriteLine("---------------------------------------------------------------------");
            rdr.Write("{0,10}","       Total                              " + totalquantity);
            rdr.WriteLine("{0,10}", "                   " + grandtotal.ToString());
            rdr.WriteLine("{0,10}","       Old Balance        " + oldbalance);
            //rdr.WriteLine("                      Total      " + grandtotal.ToString());
            rdr.Write("{0,10}","       Received           " + details.Rows[0]["paidcash"].ToString());
            rdr.WriteLine("{0,10}","                      Discount   " + details.Rows[0]["discount"].ToString());
            double netamt = grandtotal - Convert.ToDouble(details.Rows[0]["discount"].ToString());
            double newbalance = 0;
            if (oldbalance < 0)
            {
                newbalance = (Convert.ToDouble(details.Rows[0]["paidcash"].ToString()) - grandtotal) + oldbalance;
            }
            else
            {
                newbalance = (Convert.ToDouble(details.Rows[0]["paidcash"].ToString()) - grandtotal) - oldbalance;
            }
            rdr.Write("{0,10}","       New Balance        " + newbalance);
            rdr.WriteLine("{0,10}","                     Net Amount " + netamt.ToString());
					
		}
        private string GetFormatedText(string Cont, int Length,int right=0)
        {
            int rLoc = Length - Cont.Length;
            if (rLoc < 0)
            {
                Cont = Cont.Substring(0, Length);
            }
            else
            {
                int nos;
                if (right == 1)
                {
                    string space = "";
                    for (nos = 1; nos < rLoc; nos++)
                    {
                        space += " ";
                    }
                    Cont = space + Cont;
                }
                else
                {
                    for (nos = 1; nos < rLoc; nos++)
                    {
                        Cont += " ";
                    }
                }

            }
            return (Cont);
        }
//        private string GetRightFormatedText(string Cont,int Length)
//        {
//            int rLoc=Length-Cont.Length;
//            if(rLoc<0)
//            {
//                Cont =Cont.Substring(0,Length);
//            }
//            else
//            {
//                int nos;
//                string space="";
//                //for(nos=0;nos					space += " "; 
//                Cont = space + Cont;
//            }
//            return(Cont);
//        }
//        private string GetCenterdFormatedText(string Cont,int Length)
//        {
//            int rLoc=Length-Cont.Length;
//            if(rLoc<0)
//            {
//                Cont =Cont.Substring(0,Length);
//            }
//            else
//            {
//                int nos;
//                string space="";
//                for(nos=0;nos					space += " "; 
//                Cont = space + Cont;
//            }
//            return(Cont);
//        }
//        public void PrintFooter()
//        {
//            PrintLine();
//            rdr.WriteLine("                                      Total      : " + Math.Round(TotalAmt,2).ToString() );
//            rdr.WriteLine("                                      Discount   : " + Math.Round(Discount,2).ToString() );
//            rdr.WriteLine("                                      Net Amount : " + Math.Round(NetAmount,2).ToString() );
//            Miscellaneous.NumToString objMisc=new Miscellaneous.NumToString();
//                        SavedTotal=MRPTotal-TotalAmt;
//            rdr.WriteLine(Compress_On + "You Have Saved Rs. " + Math.Round(SavedTotal,2).ToString() + Compress_Off);
//            PrintLine();
//            rdr.WriteLine("Clerk   : " + Clerk);
//            rdr.WriteLine("Counter : " + clsSystem.MyCounter.ToString());
//            rdr.WriteLine();
//            rdr.WriteLine("Please check your items before leavining the counter");
//            rdr.WriteLine("Goods once sold will not be taken back");
////			PrintLine();
//        }
//        public void PrintLine()
//        {
//            int i;
//            string Lstr="";
//            for(i=1;i			{
//                Lstr=Lstr +"-";
//            }
//            rdr.WriteLine(Lstr);

//        }
//        public void SkipLine(int LineNos)
//        {
//            int i;			
//            for(i=1;i			{
//                rdr.WriteLine("");
//            }
//        }

//        public void ReverseSkip(int LineNos)
//        {
//            int i;			
//            for(i=1;i			{
//                rdr.WriteLine(Convert.ToChar(27) + "j" + Convert.ToChar(36 * LineNos));
//            }
//        }

		public void PrintBuffer()
		{
			System.Diagnostics.Process.Start("bill.bat");
		}
    }
}
