namespace GNetBillingSoft.Transactions
{
    partial class frmTender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.txtpaidamount = new System.Windows.Forms.TextBox();
            this.txtnetamount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsaveonly = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnseven = new System.Windows.Forms.Button();
            this.btneight = new System.Windows.Forms.Button();
            this.btnnine = new System.Windows.Forms.Button();
            this.btnfour = new System.Windows.Forms.Button();
            this.btnfive = new System.Windows.Forms.Button();
            this.btnsix = new System.Windows.Forms.Button();
            this.btnone = new System.Windows.Forms.Button();
            this.btntwo = new System.Windows.Forms.Button();
            this.btnthree = new System.Windows.Forms.Button();
            this.btnzero = new System.Windows.Forms.Button();
            this.btnremark = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbalance);
            this.groupBox1.Controls.Add(this.txtpaidamount);
            this.groupBox1.Controls.Add(this.txtnetamount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcustomername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtcustomerid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 218);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // txtbalance
            // 
            this.txtbalance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.Location = new System.Drawing.Point(200, 181);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(118, 23);
            this.txtbalance.TabIndex = 19;
            // 
            // txtpaidamount
            // 
            this.txtpaidamount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaidamount.Location = new System.Drawing.Point(200, 142);
            this.txtpaidamount.Name = "txtpaidamount";
            this.txtpaidamount.Size = new System.Drawing.Size(118, 23);
            this.txtpaidamount.TabIndex = 0;
            this.txtpaidamount.TextChanged += new System.EventHandler(this.txtpaidamount_TextChanged);
            // 
            // txtnetamount
            // 
            this.txtnetamount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetamount.Location = new System.Drawing.Point(200, 106);
            this.txtnetamount.Name = "txtnetamount";
            this.txtnetamount.Size = new System.Drawing.Size(118, 23);
            this.txtnetamount.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "BALANCE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "PAID AMOUNT ON ACCOUNT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "NET AMOUNT";
            // 
            // txtcustomername
            // 
            this.txtcustomername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomername.Location = new System.Drawing.Point(200, 64);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(118, 23);
            this.txtcustomername.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "CUSTOMER NAME";
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomerid.Location = new System.Drawing.Point(200, 20);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(118, 23);
            this.txtcustomerid.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "CUSTOMER CODE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsaveonly);
            this.groupBox2.Controls.Add(this.btnclose);
            this.groupBox2.Controls.Add(this.btnsave);
            this.groupBox2.Location = new System.Drawing.Point(12, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 74);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btnsaveonly
            // 
            this.btnsaveonly.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnsaveonly.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveonly.Location = new System.Drawing.Point(60, 16);
            this.btnsaveonly.Name = "btnsaveonly";
            this.btnsaveonly.Size = new System.Drawing.Size(80, 52);
            this.btnsaveonly.TabIndex = 2;
            this.btnsaveonly.Text = "Save";
            this.btnsaveonly.UseVisualStyleBackColor = true;
            this.btnsaveonly.Click += new System.EventHandler(this.btnsaveonly_Click);
            // 
            // btnclose
            // 
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(262, 16);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 52);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "Cancel";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(161, 16);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(80, 52);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save and Print";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnseven);
            this.flowLayoutPanel1.Controls.Add(this.btneight);
            this.flowLayoutPanel1.Controls.Add(this.btnnine);
            this.flowLayoutPanel1.Controls.Add(this.btnfour);
            this.flowLayoutPanel1.Controls.Add(this.btnfive);
            this.flowLayoutPanel1.Controls.Add(this.btnsix);
            this.flowLayoutPanel1.Controls.Add(this.btnone);
            this.flowLayoutPanel1.Controls.Add(this.btntwo);
            this.flowLayoutPanel1.Controls.Add(this.btnthree);
            this.flowLayoutPanel1.Controls.Add(this.btnzero);
            this.flowLayoutPanel1.Controls.Add(this.btnremark);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(361, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(248, 296);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // btnseven
            // 
            this.btnseven.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnseven.AutoSize = true;
            this.btnseven.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseven.Location = new System.Drawing.Point(3, 3);
            this.btnseven.Name = "btnseven";
            this.btnseven.Size = new System.Drawing.Size(76, 52);
            this.btnseven.TabIndex = 0;
            this.btnseven.Text = "7";
            this.btnseven.UseVisualStyleBackColor = true;
            this.btnseven.Click += new System.EventHandler(this.btnaction_Click);
            // 
            // btneight
            // 
            this.btneight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btneight.AutoSize = true;
            this.btneight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneight.Location = new System.Drawing.Point(85, 3);
            this.btneight.Name = "btneight";
            this.btneight.Size = new System.Drawing.Size(76, 52);
            this.btneight.TabIndex = 1;
            this.btneight.Text = "8";
            this.btneight.UseVisualStyleBackColor = true;
            this.btneight.Click += new System.EventHandler(this.btnaction_Click);
            // 
            // btnnine
            // 
            this.btnnine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnnine.AutoSize = true;
            this.btnnine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnine.Location = new System.Drawing.Point(167, 3);
            this.btnnine.Name = "btnnine";
            this.btnnine.Size = new System.Drawing.Size(76, 52);
            this.btnnine.TabIndex = 2;
            this.btnnine.Text = "9";
            this.btnnine.UseVisualStyleBackColor = true;
            this.btnnine.Click += new System.EventHandler(this.btnaction_Click);
            // 
            // btnfour
            // 
            this.btnfour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnfour.AutoSize = true;
            this.btnfour.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfour.Location = new System.Drawing.Point(3, 61);
            this.btnfour.Name = "btnfour";
            this.btnfour.Size = new System.Drawing.Size(76, 52);
            this.btnfour.TabIndex = 4;
            this.btnfour.Text = "4";
            this.btnfour.UseVisualStyleBackColor = true;
            this.btnfour.Click += new System.EventHandler(this.btnaction_Click);
            // 
            // btnfive
            // 
            this.btnfive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnfive.AutoSize = true;
            this.btnfive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfive.Location = new System.Drawing.Point(85, 61);
            this.btnfive.Name = "btnfive";
            this.btnfive.Size = new System.Drawing.Size(76, 52);
            this.btnfive.TabIndex = 3;
            this.btnfive.Text = "5";
            this.btnfive.UseVisualStyleBackColor = true;
            this.btnfive.Click += new System.EventHandler(this.btnaction_Click);
            // 
            // btnsix
            // 
            this.btnsix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsix.AutoSize = true;
            this.btnsix.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsix.Location = new System.Drawing.Point(167, 61);
            this.btnsix.Name = "btnsix";
            this.btnsix.Size = new System.Drawing.Size(76, 52);
            this.btnsix.TabIndex = 5;
            this.btnsix.Text = "6";
            this.btnsix.UseVisualStyleBackColor = true;
            this.btnsix.Click += new System.EventHandler(this.btnaction_Click);
            // 
            // btnone
            // 
            this.btnone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnone.AutoSize = true;
            this.btnone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnone.Location = new System.Drawing.Point(3, 119);
            this.btnone.Name = "btnone";
            this.btnone.Size = new System.Drawing.Size(76, 52);
            this.btnone.TabIndex = 6;
            this.btnone.Text = "1";
            this.btnone.UseVisualStyleBackColor = true;
            this.btnone.Click += new System.EventHandler(this.btnaction_Click);
            // 
            // btntwo
            // 
            this.btntwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btntwo.AutoSize = true;
            this.btntwo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntwo.Location = new System.Drawing.Point(85, 119);
            this.btntwo.Name = "btntwo";
            this.btntwo.Size = new System.Drawing.Size(76, 52);
            this.btntwo.TabIndex = 7;
            this.btntwo.Text = "2";
            this.btntwo.UseVisualStyleBackColor = true;
            this.btntwo.Click += new System.EventHandler(this.btnaction_Click);
            // 
            // btnthree
            // 
            this.btnthree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnthree.AutoSize = true;
            this.btnthree.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthree.Location = new System.Drawing.Point(167, 119);
            this.btnthree.Name = "btnthree";
            this.btnthree.Size = new System.Drawing.Size(76, 52);
            this.btnthree.TabIndex = 8;
            this.btnthree.Text = "3";
            this.btnthree.UseVisualStyleBackColor = true;
            this.btnthree.Click += new System.EventHandler(this.btnaction_Click);
            // 
            // btnzero
            // 
            this.btnzero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnzero.AutoSize = true;
            this.btnzero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzero.Location = new System.Drawing.Point(3, 177);
            this.btnzero.Name = "btnzero";
            this.btnzero.Size = new System.Drawing.Size(76, 52);
            this.btnzero.TabIndex = 12;
            this.btnzero.Text = "0";
            this.btnzero.UseVisualStyleBackColor = true;
            this.btnzero.Click += new System.EventHandler(this.btnaction_Click);
            // 
            // btnremark
            // 
            this.btnremark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnremark.AutoSize = true;
            this.btnremark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremark.Location = new System.Drawing.Point(85, 177);
            this.btnremark.Name = "btnremark";
            this.btnremark.Size = new System.Drawing.Size(76, 52);
            this.btnremark.TabIndex = 20;
            this.btnremark.TabStop = false;
            this.btnremark.Text = "Remarks";
            this.btnremark.UseVisualStyleBackColor = true;
            this.btnremark.Click += new System.EventHandler(this.btnremark_Click);
            // 
            // frmTender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 314);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tender";
            this.Load += new System.EventHandler(this.frmTender_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.TextBox txtpaidamount;
        private System.Windows.Forms.TextBox txtnetamount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnsaveonly;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnseven;
        private System.Windows.Forms.Button btneight;
        private System.Windows.Forms.Button btnnine;
        private System.Windows.Forms.Button btnfour;
        private System.Windows.Forms.Button btnfive;
        private System.Windows.Forms.Button btnsix;
        private System.Windows.Forms.Button btnone;
        private System.Windows.Forms.Button btntwo;
        private System.Windows.Forms.Button btnthree;
        private System.Windows.Forms.Button btnzero;
        private System.Windows.Forms.Button btnremark;
    }
}