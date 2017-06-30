namespace GNetBillingSoft
{
    partial class frmCreateNewcomp
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
            this.components = new System.ComponentModel.Container();
            this.lblProgress = new System.Windows.Forms.Label();
            this.prgCreatecmp = new System.Windows.Forms.ProgressBar();
            this.tmrProgress = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(12, 61);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(35, 13);
            this.lblProgress.TabIndex = 0;
            this.lblProgress.Text = "label1";
            // 
            // prgCreatecmp
            // 
            this.prgCreatecmp.ForeColor = System.Drawing.Color.Blue;
            this.prgCreatecmp.Location = new System.Drawing.Point(15, 31);
            this.prgCreatecmp.Maximum = 1000;
            this.prgCreatecmp.Name = "prgCreatecmp";
            this.prgCreatecmp.Size = new System.Drawing.Size(297, 15);
            this.prgCreatecmp.TabIndex = 1;
            // 
            // tmrProgress
            // 
            this.tmrProgress.Interval = 500;
            this.tmrProgress.Tick += new System.EventHandler(this.tmrProgress_Tick);
            // 
            // frmCreateNewcomp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 83);
            this.ControlBox = false;
            this.Controls.Add(this.prgCreatecmp);
            this.Controls.Add(this.lblProgress);
            this.Name = "frmCreateNewcomp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Creating New Company...";
            this.Load += new System.EventHandler(this.frmCreateNewcomp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar prgCreatecmp;
        private System.Windows.Forms.Timer tmrProgress;
    }
}