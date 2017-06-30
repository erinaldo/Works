namespace GNetBillingSoft
{
    partial class frmunits
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
            this.unitLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // unitLayout
            // 
            this.unitLayout.AutoSize = true;
            this.unitLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.unitLayout.ColumnCount = 2;
            this.unitLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.unitLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.unitLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitLayout.Location = new System.Drawing.Point(0, 0);
            this.unitLayout.Name = "unitLayout";
            this.unitLayout.RowCount = 2;
            this.unitLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.unitLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.unitLayout.Size = new System.Drawing.Size(202, 102);
            this.unitLayout.TabIndex = 0;
            this.unitLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.unitLayout_Paint);
            // 
            // frmunits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(202, 102);
            this.Controls.Add(this.unitLayout);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmunits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Units";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel unitLayout;
    }
}