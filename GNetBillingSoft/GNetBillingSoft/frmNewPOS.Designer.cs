namespace GNetBillingSoft
{
    partial class frmNewPOS
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
            this.ehPos = new System.Windows.Forms.Integration.ElementHost();
            this.UCPos = new WpfUserControl.UCPos();
            this.SuspendLayout();
            // 
            // ehPos
            // 
            this.ehPos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ehPos.Location = new System.Drawing.Point(0, 1);
            this.ehPos.Name = "ehPos";
            this.ehPos.Size = new System.Drawing.Size(1261, 678);
            this.ehPos.TabIndex = 0;
            this.ehPos.Text = "e";
            this.ehPos.Child = this.UCPos;
            // 
            // frmNewPOS
            // 
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.ehPos);
            this.Name = "frmNewPOS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost ehPos;
        private WpfUserControl.UCPos UCPos;
    }
}