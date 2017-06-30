using System;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using System.Threading;
using System.ComponentModel;
using System.Data.SqlClient;
namespace GNetBillingSoft.DataOperation
{
    class clsServerOperation
    {
        //MySqlConnection con;
       //string connectionstring = "Server=166.62.28.124;Database=crystal;Uid=noushad;Pwd=Nhd123456789";
        string connectionstring = "Server=127.0.0.1;Database=crystal;Uid=root;";
        public clsServerOperation()
        {
            //try
            //{
            //    con = new MySqlConnection();
            //    //con.ConnectionString = "Server=127.0.0.1;Database=crystal;Uid=root;";
            //    con.ConnectionString = "Server=166.62.28.124;Database=crystal;Uid=noushad;Pwd=Nhd123456789";
            //    con.Open();
            //}
            //catch (Exception e)
            //{

            //}
        }
        public bool ExecuteSql(string strsql)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                MySqlCommand cmd = con.CreateCommand();
                //MySqlTransaction SqlTrans;
                // SqlTrans = con.BeginTransaction();// con.BeginTransaction("dbAction");
                cmd.Connection = con;
                if (con.State == ConnectionState.Closed)
                    con.Open();
                //cmd.Transaction = SqlTrans;
                try
                {
                    cmd.CommandText = strsql;
                    cmd.ExecuteNonQuery();
                    //  SqlTrans.Commit();
                    return true;
                }
                catch (Exception )
                {
                    //SqlTrans.Rollback();
                   // MessageBox.Show(e.Message);
                    return false;

                }
            }

        }
        public DataTable GetDataTable(string qry)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {

                    MySqlDataAdapter cmd;
                    DataSet dts = new DataSet();
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd = new MySqlDataAdapter(qry, con);
                    cmd.SelectCommand.CommandTimeout = 0;
                    cmd.Fill(dts);
                    return (dts.Tables[0]);

                }
                catch (Exception )
                {
                    return null;
                }
            }
        }
        private  void SyncitemsalesData()
        {


            string strsql = "SELECT posgroup.itemname, itemdetails.Description, SUM(salesdetails.quantity) AS quantity, SUM(salesdetails.quantity) * itemdetails.Price AS totalcost, SUM(salesdetails.quantity)* salesdetails.salesrate - SUM(salesdetails.quantity) * salesdetails.salesrate * AVG(salesinvoice.discount) / 100 AS totsales,((actualstock+sum(isnull(purchasedetails.quantity,0)))-(sum(isnull(salesdetails.quantity,0)))) as stock,CONVERT(DATETIME, CONVERT(CHAR(8), salesdate, 112) + ' ' + CONVERT(CHAR(8), salestime, 108)) as salesdate,salesinvoice.salesinvoice FROM salesinvoice "
            + "INNER JOIN salesdetails ON salesdetails.invoiceno = salesinvoice.salesinvoice "
            + "INNER JOIN  itemdetails ON itemdetails.itemid = salesdetails.itemid "
            + "INNER JOIN posgroup ON posgroup.positemid = itemdetails.head "
            + "LEFT OUTER JOIN purchasedetails ON purchasedetails.itemid = itemdetails.itemid "
            + "GROUP BY posgroup.itemname, itemdetails.Description, itemdetails.Price, salesdetails.salesrate,itemdetails.actualstock,salesinvoice.salesdate,salesinvoice.salestime,salesinvoice.salesinvoice "
            +" order by cast(salesinvoice.salesinvoice as decimal), salesinvoice.salesdate";
            DataTable dt =GetLocalTable(strsql);
             strsql = "select `invoiceno` from `sales-item-wise`";
            DataTable serdt = GetDataTable(strsql);
            
            if (serdt != null)
            {
                var qry1 = dt.AsEnumerable().Select(a => new { Invoiceno = a["salesinvoice"].ToString() });
                var qry2 = serdt.AsEnumerable().Select(b => new { Invoiceno = b["invoiceno"].ToString() });

                var exceptAB = qry1.Except(qry2);
                if (exceptAB.ToList().Count > 0)
                {
                    DataTable dtres = (from a in dt.AsEnumerable()
                                       join ab in exceptAB on a["salesinvoice"].ToString() equals ab.Invoiceno
                                       select a).CopyToDataTable();


                    //        var results = dt.AsEnumerable().Where(
                    //r => !serdt.AsEnumerable().Select(x => x["invoiceno"]).ToList().Contains(r["salesinvoice"])).ToList();
                    //        if (results.Count > 0)
                    //        {
                    //            DataTable dtres = results.CopyToDataTable();
                    strsql = "select max(id) as id from `sales-item-wise`";
                    DataTable nextid = GetDataTable(strsql);

                    Int64 id =(nextid.Rows[0]["id"].ToString()!="")?Convert.ToInt64(nextid.Rows[0]["id"].ToString()) + 1:1;
                    for (int i = 0; i < dtres.Rows.Count; i++)
                    {
                        DateTime salesdate = Convert.ToDateTime(dtres.Rows[i]["salesdate"].ToString());
                        //DateTime salestime = Convert.ToDateTime(dt.Rows[i]["salestime"].ToString());
                        strsql = "INSERT INTO `crystal`.`sales-item-wise` (`id`, `itemname`, `description`, `quantity`, `totalcost`, `totsales`, `salesdate`, `stock`,`invoiceno`) values('" + (id) + "','" + dtres.Rows[i]["itemname"].ToString() + "','" + dtres.Rows[i]["Description"].ToString() + "','" + dtres.Rows[i]["quantity"].ToString() + "','" + dtres.Rows[i]["totalcost"].ToString() + "','" + dtres.Rows[i]["totsales"].ToString() + "','" + salesdate.Year + "-" + salesdate.Month + "-" + salesdate.Day + " " + salesdate.Hour + ":" + salesdate.Minute + "','" + dtres.Rows[i]["stock"].ToString() + "','" + dtres.Rows[i]["salesinvoice"].ToString() + "')";
                        id++;
                        ExecuteSql(strsql);

                    }
                }
               // }
            }


            //var matched = from table1 in dt.AsEnumerable()
            //              join table2 in serdt.AsEnumerable() on table1.Field<String>("itemname") equals table2.Field<String>("itemname")
            //              where table1.Field<String>("description") == table2.Field<String>("description") || table1.Field<int>("quantity") == table2.Field<int>("quantity") || table1.Field<float>("totalcost") == table2.Field<float>("totalcost")
            //              || table1.Field<String>("totsales") == table2.Field<String>("totsales") || table1.Field<Int64>("stock") == table2.Field<Int64>("stock") || table1.Field<DateTime>("salesdate") == table2.Field<DateTime>("salesdate")
            //              select table1;
            //var missing = from table1 in dt.AsEnumerable()
            //              where !matched.Contains(table1)
            //              select table1;

            //DataTable dtresult = missing.CopyToDataTable();


            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DateTime salesdate = Convert.ToDateTime(dt.Rows[i]["salesdate"].ToString());
            //    DateTime salestime = Convert.ToDateTime(dt.Rows[i]["salestime"].ToString());


            //    strsql = "INSERT INTO `crystal`.`sales-item-wise` (`id`, `itemname`, `description`, `quantity`, `totalcost`, `totsales`, `salesdate`, `stock`) values('"+(i+1)+"','" + dt.Rows[i]["itemname"].ToString() + "','" + dt.Rows[i]["Description"].ToString() + "','" + dt.Rows[i]["quantity"].ToString() + "','" + dt.Rows[i]["totalcost"].ToString() + "','" + dt.Rows[i]["totsales"].ToString() + "','" + salesdate.Year + "-" + salesdate.Month + "-" + salesdate.Day + " " + salestime.Hour + ":" + salestime.Minute + "','" + dt.Rows[i]["stock"].ToString() + "')";
            //    ExecuteSql(strsql);
            //}

        }
        public int SynchronizeData(BackgroundWorker bw)
        {
            while (!bw.CancellationPending)
            {

                SyncSalesReport();
                Thread.Sleep(60000);
                
            }

            return 1;


        }
        public int SynchronizeitemData(BackgroundWorker bw)
        {
            while (!bw.CancellationPending)
            {

               
                SyncitemsalesData();
                Thread.Sleep(60000);
            }

            return 1;


        }
        public void SyncSalesItem()
        {
           // Thread thread = new Thread(new ThreadStart(SyncitemsalesData));
           // thread.Start();
        }
        public void SyncSales()
        {
           // Thread thread = new Thread(new ThreadStart(SyncSalesReport));
            //thread.Start();
        }
        private void SyncSalesReport()
        {
            string strsql = "SELECT   salesinvoice.customerid, customerdetails.customername, salesinvoice.salesinvoice, salesinvoice.additionaldiscount, SUM(salesdetails.quantity)* salesdetails.salesrate - SUM(salesdetails.quantity) * salesdetails.salesrate * AVG(salesinvoice.discount) / 100 AS totalamount, salesinvoice.discount," 
                         +"0 AS Netamt, 0 AS paidcash, 0 AS paidcheque, 0 AS Balance, salesinvoice.salestime, userinfo.username, salesinvoice.delstatus, salesinvoice.tokenno, salesinvoice.salesdate "
                         + "FROM salesinvoice INNER JOIN "
                         + "customerdetails ON customerdetails.customerid = salesinvoice.customerid INNER JOIN "
                         + "salesdetails ON salesdetails.invoiceno = salesinvoice.salesinvoice  "
                         + "LEFT OUTER JOIN userinfo ON userinfo.userid = salesinvoice.userid "
                         + "GROUP BY customerdetails.customername, salesinvoice.salesinvoice, salesdetails.invoiceno, salesinvoice.customerid, salesinvoice.additionaldiscount, salesinvoice.salestime, userinfo.username, salesinvoice.discount,salesinvoice.delstatus,salesinvoice.tokenno,salesinvoice.salesdate,salesdetails.salesrate "
                         + "order by cast(salesinvoice.salesinvoice as decimal)";
            DataTable dt = GetLocalTable(strsql);

            strsql = "select * from  `sales-report`";
            DataTable serdt = GetDataTable(strsql);
            if (serdt != null)
            {
               //var results = dt.AsEnumerable().Where(
         //r => !serdt.AsEnumerable().Select(x => x["invoiceno"]).ToList().Contains(r["salesinvoice"])).ToList();
                var qry1 = dt.AsEnumerable().Select(a => new { Invoiceno = a["salesinvoice"].ToString() });
                var qry2 = serdt.AsEnumerable().Select(b => new { Invoiceno = b["invoiceno"].ToString() });

                var exceptAB = qry1.Except(qry2);
                if (exceptAB.ToList().Count > 0)
                {
                    DataTable dtresult = (from a in dt.AsEnumerable()
                                       join ab in exceptAB on a["salesinvoice"].ToString() equals ab.Invoiceno
                                       select a).CopyToDataTable();
                    //var results = from table1 in dt.AsEnumerable()

                    //              where !serdt.AsEnumerable().Any(r2 => table1["salesinvoice"] == r2["invoiceno"])
                    //              select table1;

                   // DataTable dtresult = results.CopyToDataTable();
                    strsql = "select max(id) as id from `sales-report`";
                    DataTable nextid = GetDataTable(strsql);
                    Int64 id = (nextid.Rows[0]["id"].ToString() != "") ? Convert.ToInt64(nextid.Rows[0]["id"].ToString()) + 1 : 1;
                    for (int i = 0; i < dtresult.Rows.Count; i++)
                    {
                        DateTime salesdate = Convert.ToDateTime(dtresult.Rows[i]["salesdate"].ToString());
                        DateTime salestime = Convert.ToDateTime(dtresult.Rows[i]["salestime"].ToString());

                        strsql = "INSERT INTO `crystal`.`sales-report` (`id`, `invoiceno`, `customername`, `totalamount`, `discount`, `netamt`, `paidcash`, `paidcheque`, `balance`, `additionaldiscount`,  `username`, `delstatus`, `tokenno`, `salesdate`) VALUES ('" + (id) + "', '" + dtresult.Rows[i]["salesinvoice"].ToString() + "', '" + dtresult.Rows[i]["customername"].ToString() + "','" + dtresult.Rows[i]["totalamount"].ToString() + "','" + dtresult.Rows[i]["discount"].ToString() + "','" + dtresult.Rows[i]["netamt"].ToString() + "','" + dtresult.Rows[i]["paidcash"].ToString() + "','" + dtresult.Rows[i]["paidcheque"].ToString() + "','" + dtresult.Rows[i]["balance"].ToString() + "','" + dtresult.Rows[i]["additionaldiscount"].ToString() + "','" + dtresult.Rows[i]["username"].ToString() + "','" + dtresult.Rows[i]["delstatus"].ToString() + "','" + dtresult.Rows[i]["tokenno"].ToString() + "','" + salesdate.Year + "-" + salesdate.Month + "-" + salesdate.Day + " " + salestime.Hour + ":" + salestime.Minute + "');";
                        ExecuteSql(strsql);
                        id++;
                    }
                }
            }



        }
        public  DataTable GetLocalTable(string qry)
        {

            string connectionstring = Properties.Settings.Default.Defaultcompany;
            SqlConnection newcon = new SqlConnection(connectionstring);
            if(newcon.State==ConnectionState.Closed)
                newcon.Open();
            SqlDataAdapter cmd;
            DataTable dts = new DataTable();

            cmd = new SqlDataAdapter(qry, newcon);
            cmd.SelectCommand.CommandTimeout = 0;
            cmd.Fill(dts);
            newcon.Close();
            return (dts);
        }
        public static void Delete(string invoiceno)
        {
            //clsServerOperation server = new clsServerOperation();
            //string strsql = "delete from `sales-report` where invoiceno=" + invoiceno;
            //server.ExecuteSql(strsql);
            //strsql = "delete from `sales-item-wise` where invoiceno=" + invoiceno;
            //server.ExecuteSql(strsql);
        }

    }
   
}
