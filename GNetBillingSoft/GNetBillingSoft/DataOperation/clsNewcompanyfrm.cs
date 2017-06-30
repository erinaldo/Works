// Type: GNetBillingSoft.DataOperation.clsNewcompanyfrm
// Assembly: GNetBillingSoft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF94799A-7D18-4F06-8215-9E1CC70A2A54
// Assembly location: F:\jdownloads\GNetBillingSoft\GNetBillingSoft.exe

using System.Drawing;
using System.Windows.Forms;

namespace GNetBillingSoft.DataOperation
{
  internal class clsNewcompanyfrm
  {
    public static int NavLimit = 2;

    static clsNewcompanyfrm()
    {
    }

    public GroupBox CompanyInfo()
    {
      GroupBox groupBox = new GroupBox();
      groupBox.Width = 391;
      groupBox.Height = 302;
      groupBox.Name = "grpCompanyInfo";
      groupBox.Location = new Point(185, -1);
      TextBox textBox1 = new TextBox();
      textBox1.Location = new Point(95, 242);
      textBox1.Name = "txtFax";
      textBox1.Size = new Size(237, 20);
      textBox1.TabIndex = 23;
      groupBox.Controls.Add((Control) textBox1);
      Label label1 = new Label();
      label1.AutoSize = true;
      label1.Location = new Point(7, 245);
      label1.Name = "lblFax";
      label1.Size = new Size(41, 13);
      label1.TabIndex = 22;
      label1.Text = "Fax No";
      groupBox.Controls.Add((Control) label1);
      TextBox textBox2 = new TextBox();
      textBox2.Location = new Point(232, 114);
      textBox2.Name = "txtzip";
      textBox2.Size = new Size(100, 20);
      textBox2.TabIndex = 21;
      groupBox.Controls.Add((Control) textBox2);
      Label label2 = new Label();
      label2.AutoSize = true;
      label2.Location = new Point(189, 117);
      label2.Name = "lblzip";
      label2.Size = new Size(22, 13);
      label2.TabIndex = 20;
      label2.Text = "Zip";
      groupBox.Controls.Add((Control) label2);
      TextBox textBox3 = new TextBox();
      textBox3.Location = new Point(95, 274);
      textBox3.Name = "txtEmail";
      textBox3.Size = new Size(237, 20);
      textBox3.TabIndex = 18;
      groupBox.Controls.Add((Control) textBox3);
      Label label3 = new Label();
      label3.AutoSize = true;
      label3.Location = new Point(6, 277);
      label3.Name = "lblEmail";
      label3.Size = new Size(32, 13);
      label3.TabIndex = 17;
      label3.Text = "Email";
      groupBox.Controls.Add((Control) label3);
      TextBox textBox4 = new TextBox();
      textBox4.Location = new Point(95, 210);
      textBox4.Name = "txtMobile";
      textBox4.Size = new Size(237, 20);
      textBox4.TabIndex = 16;
      groupBox.Controls.Add((Control) textBox4);
      Label label4 = new Label();
      label4.AutoSize = true;
      label4.Location = new Point(7, 213);
      label4.Name = "lblMobile";
      label4.Size = new Size(38, 13);
      label4.TabIndex = 15;
      label4.Text = "Mobile";
      groupBox.Controls.Add((Control) label4);
      TextBox textBox5 = new TextBox();
      textBox5.Location = new Point(95, 178);
      textBox5.Name = "txtTelephone";
      textBox5.Size = new Size(237, 20);
      textBox5.TabIndex = 14;
      groupBox.Controls.Add((Control) textBox5);
      Label label5 = new Label();
      label5.AutoSize = true;
      label5.Location = new Point(7, 181);
      label5.Name = "lblTelephone";
      label5.Size = new Size(58, 13);
      label5.TabIndex = 13;
      label5.Text = "Telephone";
      groupBox.Controls.Add((Control) label5);
      TextBox textBox6 = new TextBox();
      textBox6.Location = new Point(232, 146);
      textBox6.Name = "txtCountry";
      textBox6.Size = new Size(100, 20);
      textBox6.TabIndex = 12;
      groupBox.Controls.Add((Control) textBox6);
      Label label6 = new Label();
      label6.AutoSize = true;
      label6.Location = new Point(189, 148);
      label6.Name = "lblCountry";
      label6.Size = new Size(43, 13);
      label6.TabIndex = 11;
      label6.Text = "Country";
      groupBox.Controls.Add((Control) label6);
      TextBox textBox7 = new TextBox();
      textBox7.Location = new Point(95, 146);
      textBox7.Name = "txtState";
      textBox7.Size = new Size(90, 20);
      textBox7.TabIndex = 10;
      groupBox.Controls.Add((Control) textBox7);
      Label label7 = new Label();
      label7.AutoSize = true;
      label7.Location = new Point(7, 149);
      label7.Name = "lblState";
      label7.Size = new Size(32, 13);
      label7.TabIndex = 9;
      label7.Text = "State";
      groupBox.Controls.Add((Control) label7);
      TextBox textBox8 = new TextBox();
      textBox8.Location = new Point(95, 114);
      textBox8.Name = "txtCity";
      textBox8.Size = new Size(90, 20);
      textBox8.TabIndex = 8;
      groupBox.Controls.Add((Control) textBox8);
      Label label8 = new Label();
      label8.AutoSize = true;
      label8.Location = new Point(7, 117);
      label8.Name = "lblCity";
      label8.Size = new Size(24, 13);
      label8.TabIndex = 7;
      label8.Text = "City";
      groupBox.Controls.Add((Control) label8);
      TextBox textBox9 = new TextBox();
      textBox9.Location = new Point(95, 82);
      textBox9.Name = "txtAddr2";
      textBox9.Size = new Size(237, 20);
      textBox9.TabIndex = 6;
      groupBox.Controls.Add((Control) textBox9);
      TextBox textBox10 = new TextBox();
      textBox10.Location = new Point(95, 50);
      textBox10.Name = "txtAddr1";
      textBox10.Size = new Size(237, 20);
      textBox10.TabIndex = 5;
      groupBox.Controls.Add((Control) textBox10);
      Label label9 = new Label();
      label9.AutoSize = true;
      label9.Location = new Point(7, 85);
      label9.Name = "lblAddr2";
      label9.Size = new Size(74, 13);
      label9.TabIndex = 4;
      label9.Text = "Address Line2";
      groupBox.Controls.Add((Control) label9);
      Label label10 = new Label();
      label10.AutoSize = true;
      label10.Location = new Point(7, 53);
      label10.Name = "lblAddr1";
      label10.Size = new Size(77, 13);
      label10.TabIndex = 3;
      label10.Text = "Address Line 1";
      groupBox.Controls.Add((Control) label10);
      TextBox textBox11 = new TextBox();
      textBox11.Location = new Point(95, 16);
      textBox11.Name = "txtCompany";
      textBox11.Size = new Size(237, 20);
      textBox11.TabIndex = 2;
      groupBox.Controls.Add((Control) textBox11);
      Label label11 = new Label();
      label11.AutoSize = true;
      label11.Location = new Point(7, 20);
      label11.Name = "lblName";
      label11.Size = new Size(82, 13);
      label11.TabIndex = 1;
      label11.Text = "Company Name";
      groupBox.Controls.Add((Control) label11);
      return groupBox;
    }

    public GroupBox SuccessMsg()
    {
      GroupBox groupBox = new GroupBox();
      groupBox.Width = 391;
      groupBox.Height = 302;
      groupBox.Name = "grpSuccessMsg";
      groupBox.Location = new Point(185, -1);
      Label label1 = new Label();
      label1.AutoSize = true;
      label1.Location = new Point(6, 47);
      label1.Name = "lblmsg2";
      label1.Size = new Size(35, 13);
      label1.TabIndex = 1;
      label1.Text = "You have Completed required information for setting new company";
      groupBox.Controls.Add((Control) label1);
      Label label2 = new Label();
      label2.AutoSize = true;
      label2.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      label2.Location = new Point(6, 23);
      label2.Name = "lblMessage";
      label2.Size = new Size(46, 17);
      label2.TabIndex = 0;
      label2.Text = "Congratulation";
      groupBox.Controls.Add((Control) label2);
      return groupBox;
    }

    public GroupBox NavFunction(int i)
    {
      GroupBox groupBox = new GroupBox();
      switch (i)
      {
        case 1:
          return this.CompanyInfo();
        case 2:
          return this.SuccessMsg();
        default:
          return groupBox;
      }
    }
  }
}
