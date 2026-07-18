namespace storemedicals.allform.purchees
{
    partial class frm_purchases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_purchases));
            this.grop_fator = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tex_tol = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tex_ponas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tex_amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rad_shak = new System.Windows.Forms.RadioButton();
            this.rad_bank = new System.Windows.Forms.RadioButton();
            this.rad_cash = new System.Windows.Forms.RadioButton();
            this.tex_ne_com = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_userAdd = new System.Windows.Forms.TextBox();
            this.date_purch = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tex_inv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.grop_fator.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grop_fator
            // 
            this.grop_fator.Controls.Add(this.panel3);
            this.grop_fator.Location = new System.Drawing.Point(18, 12);
            this.grop_fator.Name = "grop_fator";
            this.grop_fator.Size = new System.Drawing.Size(779, 231);
            this.grop_fator.TabIndex = 12;
            this.grop_fator.TabStop = false;
            this.grop_fator.Text = "بيانات الفاتورة:-";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tex_tol);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.tex_ponas);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tex_amount);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.rad_shak);
            this.panel3.Controls.Add(this.rad_bank);
            this.panel3.Controls.Add(this.rad_cash);
            this.panel3.Controls.Add(this.tex_ne_com);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_userAdd);
            this.panel3.Controls.Add(this.date_purch);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tex_inv);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(755, 171);
            this.panel3.TabIndex = 1;
            // 
            // tex_tol
            // 
            this.tex_tol.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_tol.Location = new System.Drawing.Point(473, 121);
            this.tex_tol.Name = "tex_tol";
            this.tex_tol.Size = new System.Drawing.Size(175, 29);
            this.tex_tol.TabIndex = 9;
            this.tex_tol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(668, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "الاجمالي:";
            // 
            // tex_ponas
            // 
            this.tex_ponas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_ponas.Location = new System.Drawing.Point(472, 83);
            this.tex_ponas.Name = "tex_ponas";
            this.tex_ponas.Size = new System.Drawing.Size(175, 29);
            this.tex_ponas.TabIndex = 7;
            this.tex_ponas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_ponas.TextChanged += new System.EventHandler(this.tex_ponas_TextChanged);
            this.tex_ponas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_ponas_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(670, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "البونص:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tex_amount
            // 
            this.tex_amount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_amount.Location = new System.Drawing.Point(18, 49);
            this.tex_amount.Name = "tex_amount";
            this.tex_amount.Size = new System.Drawing.Size(217, 29);
            this.tex_amount.TabIndex = 6;
            this.tex_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_amount_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(266, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "القيمة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(664, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "نوع الدفع:";
            // 
            // rad_shak
            // 
            this.rad_shak.AutoSize = true;
            this.rad_shak.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_shak.Location = new System.Drawing.Point(393, 53);
            this.rad_shak.Name = "rad_shak";
            this.rad_shak.Size = new System.Drawing.Size(55, 26);
            this.rad_shak.TabIndex = 5;
            this.rad_shak.TabStop = true;
            this.rad_shak.Text = "شيك";
            this.rad_shak.UseVisualStyleBackColor = true;
            this.rad_shak.CheckedChanged += new System.EventHandler(this.rad_shak_CheckedChanged);
            // 
            // rad_bank
            // 
            this.rad_bank.AutoSize = true;
            this.rad_bank.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_bank.Location = new System.Drawing.Point(494, 53);
            this.rad_bank.Name = "rad_bank";
            this.rad_bank.Size = new System.Drawing.Size(55, 26);
            this.rad_bank.TabIndex = 4;
            this.rad_bank.TabStop = true;
            this.rad_bank.Text = "بنكك";
            this.rad_bank.UseVisualStyleBackColor = true;
            this.rad_bank.CheckedChanged += new System.EventHandler(this.rad_bank_CheckedChanged);
            // 
            // rad_cash
            // 
            this.rad_cash.AutoSize = true;
            this.rad_cash.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_cash.Location = new System.Drawing.Point(597, 53);
            this.rad_cash.Name = "rad_cash";
            this.rad_cash.Size = new System.Drawing.Size(56, 26);
            this.rad_cash.TabIndex = 3;
            this.rad_cash.TabStop = true;
            this.rad_cash.Text = "كاش";
            this.rad_cash.UseVisualStyleBackColor = true;
            this.rad_cash.CheckedChanged += new System.EventHandler(this.rad_cash_CheckedChanged);
            // 
            // tex_ne_com
            // 
            this.tex_ne_com.BackColor = System.Drawing.Color.White;
            this.tex_ne_com.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_ne_com.Location = new System.Drawing.Point(393, 13);
            this.tex_ne_com.Name = "tex_ne_com";
            this.tex_ne_com.Size = new System.Drawing.Size(255, 29);
            this.tex_ne_com.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(654, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "أسم الشركة :";
            // 
            // txt_userAdd
            // 
            this.txt_userAdd.BackColor = System.Drawing.Color.White;
            this.txt_userAdd.Enabled = false;
            this.txt_userAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userAdd.Location = new System.Drawing.Point(18, 118);
            this.txt_userAdd.Name = "txt_userAdd";
            this.txt_userAdd.ReadOnly = true;
            this.txt_userAdd.Size = new System.Drawing.Size(217, 29);
            this.txt_userAdd.TabIndex = 10;
            this.txt_userAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date_purch
            // 
            this.date_purch.CustomFormat = "yyyy-MM-dd";
            this.date_purch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_purch.Location = new System.Drawing.Point(106, 84);
            this.date_purch.Name = "date_purch";
            this.date_purch.RightToLeftLayout = true;
            this.date_purch.Size = new System.Drawing.Size(128, 28);
            this.date_purch.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(256, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "المستخدم:";
            // 
            // tex_inv
            // 
            this.tex_inv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_inv.Location = new System.Drawing.Point(18, 16);
            this.tex_inv.Name = "tex_inv";
            this.tex_inv.Size = new System.Drawing.Size(217, 29);
            this.tex_inv.TabIndex = 2;
            this.tex_inv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_inv_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(245, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "تاريخ الفاتورة:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(249, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "رقم الفاتورة:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Actions-window-close-icon.png");
            this.imageList1.Images.SetKeyName(1, "Save-icon (1).png");
            this.imageList1.Images.SetKeyName(2, "1486498910_sign-up.png");
            this.imageList1.Images.SetKeyName(3, "Ampeross-Qetto-2-Trash.ico");
            this.imageList1.Images.SetKeyName(4, "Actions-list-add-icon.png");
            this.imageList1.Images.SetKeyName(5, "edit-validated-icon.png");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Location = new System.Drawing.Point(139, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 66);
            this.panel1.TabIndex = 58;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImageIndex = 0;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(15, 8);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_exit.Size = new System.Drawing.Size(92, 49);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "خروج";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.ImageIndex = 1;
            this.btn_save.ImageList = this.imageList1;
            this.btn_save.Location = new System.Drawing.Point(323, 8);
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_save.Size = new System.Drawing.Size(100, 49);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "حفظ";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // frm_purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 343);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grop_fator);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_purchases";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة المشتروات";
            this.grop_fator.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grop_fator;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tex_ne_com;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_userAdd;
        private System.Windows.Forms.DateTimePicker date_purch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tex_inv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tex_ponas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tex_amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rad_shak;
        private System.Windows.Forms.RadioButton rad_bank;
        private System.Windows.Forms.RadioButton rad_cash;
        private System.Windows.Forms.TextBox tex_tol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
    }
}