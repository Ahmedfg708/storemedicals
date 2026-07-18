namespace storemedicals.allform.sales
{
    partial class form_Exception
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
            this.label1 = new System.Windows.Forms.Label();
            this.tex_on_nmber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comb_name_eroo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimeP = new System.Windows.Forms.DateTimePicker();
            this.listBo_typ_eroo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتوره";
            // 
            // tex_on_nmber
            // 
            this.tex_on_nmber.Location = new System.Drawing.Point(110, 140);
            this.tex_on_nmber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tex_on_nmber.Name = "tex_on_nmber";
            this.tex_on_nmber.Size = new System.Drawing.Size(121, 29);
            this.tex_on_nmber.TabIndex = 1;
            this.tex_on_nmber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_on_nmber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "اصلاح مشاكل الفواتير";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "وصف المشكلة";
            // 
            // comb_name_eroo
            // 
            this.comb_name_eroo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_name_eroo.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_name_eroo.FormattingEnabled = true;
            this.comb_name_eroo.Items.AddRange(new object[] {
            "مشكلة في نوع الدفع",
            "مشكلة في الكمية",
            "ارجاع فاتوره",
            "اخري"});
            this.comb_name_eroo.Location = new System.Drawing.Point(365, 142);
            this.comb_name_eroo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comb_name_eroo.MaxDropDownItems = 6;
            this.comb_name_eroo.Name = "comb_name_eroo";
            this.comb_name_eroo.Size = new System.Drawing.Size(266, 33);
            this.comb_name_eroo.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "كيف اصلاح الخطاء";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(287, 348);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 47);
            this.button1.TabIndex = 24;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimeP
            // 
            this.dateTimeP.CustomFormat = "yyyy-MM-dd";
            this.dateTimeP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeP.Location = new System.Drawing.Point(110, 189);
            this.dateTimeP.Name = "dateTimeP";
            this.dateTimeP.Size = new System.Drawing.Size(153, 29);
            this.dateTimeP.TabIndex = 84;
            // 
            // listBo_typ_eroo
            // 
            this.listBo_typ_eroo.Location = new System.Drawing.Point(150, 224);
            this.listBo_typ_eroo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBo_typ_eroo.Multiline = true;
            this.listBo_typ_eroo.Name = "listBo_typ_eroo";
            this.listBo_typ_eroo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listBo_typ_eroo.Size = new System.Drawing.Size(481, 118);
            this.listBo_typ_eroo.TabIndex = 85;
            // 
            // form_Exception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(644, 416);
            this.Controls.Add(this.listBo_typ_eroo);
            this.Controls.Add(this.dateTimeP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comb_name_eroo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tex_on_nmber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_Exception";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Exception";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tex_on_nmber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comb_name_eroo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimeP;
        private System.Windows.Forms.TextBox listBo_typ_eroo;
    }
}