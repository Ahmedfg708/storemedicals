namespace storemedicals.allform
{
    partial class frm_show_imgCust
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
            this.pic_cust = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cust)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_cust
            // 
            this.pic_cust.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic_cust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_cust.Location = new System.Drawing.Point(35, 12);
            this.pic_cust.Name = "pic_cust";
            this.pic_cust.Size = new System.Drawing.Size(240, 234);
            this.pic_cust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_cust.TabIndex = 0;
            this.pic_cust.TabStop = false;
            // 
            // frm_show_imgCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(300, 271);
            this.Controls.Add(this.pic_cust);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_show_imgCust";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض الصورة";
            ((System.ComponentModel.ISupportInitialize)(this.pic_cust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pic_cust;
    }
}