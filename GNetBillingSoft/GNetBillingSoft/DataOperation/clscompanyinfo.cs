// Type: GNetBillingSoft.DataOperation.clscompanyinfo
// Assembly: GNetBillingSoft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF94799A-7D18-4F06-8215-9E1CC70A2A54
// Assembly location: F:\jdownloads\GNetBillingSoft\GNetBillingSoft.exe

using System;
using System.Data;

namespace GNetBillingSoft.DataOperation
{
  public class clscompanyinfo
  {
    private const string mvartablename = "companyinfo";
    private long mvarcompanyid;
    private string mvarcompanyname;
    private string mvaraddress;
    private string mvaraddress2;
    private string mvarcity;
    private string mvarstate;
    private long mvarzipcode;
    private string mvarcountry;
    private string mvartelephone;
    private string mvarmobileno;
    private string mvarfaxno;
    private string mvaremail;
    private string mvardisplay;

    public string DisplayName
    {
      get
      {
        return this.mvardisplay;
      }
      set
      {
        this.mvardisplay = value;
      }
    }

    public long companyid
    {
      get
      {
        return this.mvarcompanyid;
      }
      set
      {
        this.mvarcompanyid = value;
      }
    }

    public string companyname
    {
      get
      {
        return this.mvarcompanyname;
      }
      set
      {
        this.mvarcompanyname = value;
      }
    }

    public string address
    {
      get
      {
        return this.mvaraddress;
      }
      set
      {
        this.mvaraddress = value;
      }
    }

    public string address2
    {
      get
      {
        return this.mvaraddress2;
      }
      set
      {
        this.mvaraddress2 = value;
      }
    }

    public string city
    {
      get
      {
        return this.mvarcity;
      }
      set
      {
        this.mvarcity = value;
      }
    }

    public string state
    {
      get
      {
        return this.mvarstate;
      }
      set
      {
        this.mvarstate = value;
      }
    }

    public long zipcode
    {
      get
      {
        return this.mvarzipcode;
      }
      set
      {
        this.mvarzipcode = value;
      }
    }

    public string country
    {
      get
      {
        return this.mvarcountry;
      }
      set
      {
        this.mvarcountry = value;
      }
    }

    public string telephone
    {
      get
      {
        return this.mvartelephone;
      }
      set
      {
        this.mvartelephone = value;
      }
    }

    public string mobileno
    {
      get
      {
        return this.mvarmobileno;
      }
      set
      {
        this.mvarmobileno = value;
      }
    }

    public string faxno
    {
      get
      {
        return this.mvarfaxno;
      }
      set
      {
        this.mvarfaxno = value;
      }
    }

    public string email
    {
      get
      {
        return this.mvaremail;
      }
      set
      {
        this.mvaremail = value;
      }
    }

    public void Add()
    {
        try
        {
            dboperation.ExecuteSql("INSERT INTO companyinfo([companyid],[companyname],[displayname],[address],[address2],[city],[state],[zipcode],[country],[telephone],[mobileno],[faxno],[email]) VALUES  ('" + (object)this.mvarcompanyid + "','" + this.mvarcompanyname + "','"+this.DisplayName+"','" + this.mvaraddress + "','" + this.mvaraddress2 + "','" + this.mvarcity + "','" + this.mvarstate + "','" + this.mvarzipcode + "','" + this.mvarcountry + "','" + this.mvartelephone + "','" + this.mvarmobileno + "','" + this.mvarfaxno + "','" + this.mvaremail + "')");
        }
        catch (Exception )
        {
            
        }
    }

    public void Edit()
    {
      dboperation.ExecuteSql("update companyinfo set companyname='" + (object) this.mvarcompanyname + "',address='" + this.mvaraddress + "',address2='" + this.mvaraddress2 + "',city='" + this.mvarcity + "',state='" + this.mvarstate + "',zipcode='" + (string) (object) this.mvarzipcode + "',country='" + this.mvarcountry + "',telephone='" + this.mvartelephone + "',mobileno='" + this.mvarmobileno + "',faxno='" + this.mvarfaxno + "',email='" + this.mvaremail + "' where   companyid = " + (string) (object) this.mvarcompanyid);
    }

    public void Delete()
    {
      dboperation.ExecuteSql("Delete from companyinfo where   companyid = " + (object) this.mvarcompanyid + " ");
    }

    public int GetNextId()
    {
      object avalue = dboperation.GetAValue("select max(companyid) from companyinfo");
      if (avalue == DBNull.Value)
        return 1;
      else
        return Convert.ToInt32(avalue) + 1;
    }

    public DataTable GetRecord()
    {
      return dboperation.GetDataTable("select companyid,companyname,displayname,address,address2,city,state,zipcode,country,telephone,mobileno,faxno,email from companyinfo ");
    }

    public bool GetItems()
    {
      bool flag = false;
      if (dboperation.GetDataTable("select * from companyinfo where companyid=" + (object) this.mvarcompanyid + " ").Rows.Count > 0)
        flag = true;
      return flag;
    }
  }
}
