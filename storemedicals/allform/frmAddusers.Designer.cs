namespace storemedicals.allform
{
    partial class frmAddusers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddusers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.txt_activ = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_mobial = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.comb_type = new System.Windows.Forms.ComboBox();
            this.date_user = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comBoxPink = new System.Windows.Forms.ComboBox();
            this.rdno = new System.Windows.Forms.RadioButton();
            this.rdyes = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_confirmpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Location = new System.Drawing.Point(22, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 73);
            this.panel1.TabIndex = 6;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.ImageIndex = 0;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(15, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_exit.Size = new System.Drawing.Size(122, 39);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "خروج";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
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
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.Enabled = false;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.ImageIndex = 1;
            this.btn_save.ImageList = this.imageList1;
            this.btn_save.Location = new System.Drawing.Point(217, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_save.Size = new System.Drawing.Size(117, 39);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "حفظ";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.White;
            this.btn_new.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new.ImageIndex = 4;
            this.btn_new.ImageList = this.imageList1;
            this.btn_new.Location = new System.Drawing.Point(400, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_new.Size = new System.Drawing.Size(106, 39);
            this.btn_new.TabIndex = 3;
            this.btn_new.Text = "جديد";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // txt_activ
            // 
            this.txt_activ.Enabled = false;
            this.txt_activ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_activ.Location = new System.Drawing.Point(14, 66);
            this.txt_activ.Name = "txt_activ";
            this.txt_activ.ReadOnly = true;
            this.txt_activ.Size = new System.Drawing.Size(46, 26);
            this.txt_activ.TabIndex = 18;
            this.txt_activ.Text = "true";
            this.txt_activ.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(14, 24);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(38, 26);
            this.txtid.TabIndex = 2;
            this.txtid.Visible = false;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(102, 37);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(299, 26);
            this.txt_name.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "الاسم الكامل:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "كلــــــمة المرور:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "مــــــــوبايل:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "اسم المستخدم:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "نوع المستخدم:";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullname.Location = new System.Drawing.Point(102, 249);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(299, 26);
            this.txt_fullname.TabIndex = 5;
            // 
            // txt_mobial
            // 
            this.txt_mobial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobial.Location = new System.Drawing.Point(102, 292);
            this.txt_mobial.Name = "txt_mobial";
            this.txt_mobial.Size = new System.Drawing.Size(299, 26);
            this.txt_mobial.TabIndex = 6;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(102, 81);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(299, 26);
            this.txt_pass.TabIndex = 1;
            // 
            // comb_type
            // 
            this.comb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_type.FormattingEnabled = true;
            this.comb_type.Items.AddRange(new object[] {
            "موظف",
            "مدير"});
            this.comb_type.Location = new System.Drawing.Point(216, 171);
            this.comb_type.Name = "comb_type";
            this.comb_type.Size = new System.Drawing.Size(185, 27);
            this.comb_type.TabIndex = 3;
            // 
            // date_user
            // 
            this.date_user.Enabled = false;
            this.date_user.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_user.Location = new System.Drawing.Point(115, 3);
            this.date_user.Name = "date_user";
            this.date_user.Size = new System.Drawing.Size(286, 26);
            this.date_user.TabIndex = 15;
            this.date_user.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.comBoxPink);
            this.panel3.Controls.Add(this.rdno);
            this.panel3.Controls.Add(this.rdyes);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_activ);
            this.panel3.Controls.Add(this.txtid);
            this.panel3.Controls.Add(this.txt_confirmpass);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.date_user);
            this.panel3.Controls.Add(this.comb_type);
            this.panel3.Controls.Add(this.txt_pass);
            this.panel3.Controls.Add(this.txt_mobial);
            this.panel3.Controls.Add(this.txt_fullname);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_name);
            this.panel3.Location = new System.Drawing.Point(29, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 337);
            this.panel3.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(435, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 72;
            this.label8.Text = "نوع الدوام:";
            // 
            // comBoxPink
            // 
            this.comBoxPink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxPink.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxPink.FormattingEnabled = true;
            this.comBoxPink.Items.AddRange(new object[] {
            "صباح",
            "مساء",
            "عام"});
            this.comBoxPink.Location = new System.Drawing.Point(216, 209);
            this.comBoxPink.Name = "comBoxPink";
            this.comBoxPink.Size = new System.Drawing.Size(180, 27);
            this.comBoxPink.TabIndex = 4;
            // 
            // rdno
            // 
            this.rdno.AutoSize = true;
            this.rdno.Location = new System.Drawing.Point(114, 190);
            this.rdno.Name = "rdno";
            this.rdno.Size = new System.Drawing.Size(35, 23);
            this.rdno.TabIndex = 23;
            this.rdno.Text = "لا";
            this.rdno.UseVisualStyleBackColor = true;
            this.rdno.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdyes
            // 
            this.rdyes.AutoSize = true;
            this.rdyes.Checked = true;
            this.rdyes.Location = new System.Drawing.Point(105, 163);
            this.rdyes.Name = "rdyes";
            this.rdyes.Size = new System.Drawing.Size(43, 23);
            this.rdyes.TabIndex = 22;
            this.rdyes.TabStop = true;
            this.rdyes.Text = "نعم";
            this.rdyes.UseVisualStyleBackColor = true;
            this.rdyes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(173, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "نشط";
            // 
            // txt_confirmpass
            // 
            this.txt_confirmpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmpass.Location = new System.Drawing.Point(102, 124);
            this.txt_confirmpass.Name = "txt_confirmpass";
            this.txt_confirmpass.Size = new System.Drawing.Size(299, 26);
            this.txt_confirmpass.TabIndex = 2;
            this.txt_confirmpass.Validated += new System.EventHandler(this.txt_confirmpass_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "تاكيد كلمة المرور";
            // 
            // frmAddusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(570, 456);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddusers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة اضافة مستخدم للنظام";
            this.Load += new System.EventHandler(this.frmAddusers_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_new;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.TextBox txt_fullname;
        public System.Windows.Forms.TextBox txt_mobial;
        public System.Windows.Forms.TextBox txt_pass;
        public System.Windows.Forms.ComboBox comb_type;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txt_confirmpass;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.TextBox txt_activ;
        public System.Windows.Forms.DateTimePicker date_user;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.RadioButton rdno;
        public System.Windows.Forms.RadioButton rdyes;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox comBoxPink;
    }
}