using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft
{
    public partial class frmSuplierDetails : Form
    {
        clssuplierdetails suplier = new clssuplierdetails();
        clsgeneralledger generalledger = new clsgeneralledger();
        public frmSuplierDetails()
        {
            InitializeComponent();
            AddRecord();

        }
        private void AddRecord()
        {
         
            dgvsupplier.DataSource = suplier.GetRecord();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SetData())
            {
                if (suplier.GetItems())
                {
                    suplier.Edit();
                }
                else
                {
                    suplier.Add();
                }
                Clear();
            }
        }
        private bool SetData()
        {
            if (Validation())
            {
                suplier.suplierid = suplier.GetNextId();
                suplier.supliername = txtsuppliername.Text;
                suplier.address = txtaddress.Text;
                suplier.phonenumber = txtphoneno.Text;
                suplier.openingbalance  = Convert.ToDouble(txtopening.Text);

                if (txtopening.Text != "")
                {
                    generalledger.ledcode = generalledger.GetNextId();
                    generalledger.voucherno = suplier.suplierid.ToString();
                    generalledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generalledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generalledger.particulars = txtsuppliername.Text;
                    generalledger.Debitamt = 0;
                    generalledger.Creditamt = Convert.ToDouble(txtopening.Text);
                    generalledger.Balance = 0;
                    generalledger.VType = "OP";

                    generalledger.DeleteLedger();
                    generalledger.Add();
                }
                return true;
            }
            return false;
        }
        private bool Validation()
        {
            if (txtsuppliername.Text.Trim() == "")
            {
                errorCustomer.SetError(txtsuppliername, "Supplier name is required");
                return false;

            }
            return true;
        }
        private void Clear()
        {
            txtsuppliername.Text = string.Empty;
            txtphoneno.Text = string.Empty;
            txtaddress.Text = string.Empty;
            txtopening.Text = string.Empty;
        }

        private void frmSuplierDetails_Load(object sender, EventArgs e)
        {
            dgvsupplier.ClearSelection();
            dgvsupplier.SelectionChanged += new EventHandler(dgvsupplier_SelectionChanged);
        }

        void dgvsupplier_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvsupplier.SelectedRows.Count > 0)
            {
                suplier.suplierid = Convert.ToInt64(dgvsupplier.Rows[dgvsupplier.CurrentCell.RowIndex].Cells[0].Value.ToString());
                DataTable dt = suplier.ListItem();

            }
        }

        
    }
}
