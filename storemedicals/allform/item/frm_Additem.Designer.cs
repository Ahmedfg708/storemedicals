namespace storemedicals.allform.item
{
    partial class frm_Additem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Additem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comb_store = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comb_catogry = new System.Windows.Forms.ComboBox();
            this.date_expert = new System.Windows.Forms.DateTimePicker();
            this.date_itemAdd = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_userAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pric = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_item_arb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_barcod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.btn_list_purch = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comb_store);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comb_catogry);
            this.panel1.Controls.Add(this.date_expert);
            this.panel1.Controls.Add(this.date_itemAdd);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_userAdd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_sal);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_pric);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_item_arb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtqty);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_barcod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 232);
            this.panel1.TabIndex = 0;
            // 
            // comb_store
            // 
            this.comb_store.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_store.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_store.FormattingEnabled = true;
            this.comb_store.Items.AddRange(new object[] {
            "======اختر اسم المجموعة ========"});
            this.comb_store.Location = new System.Drawing.Point(25, 122);
            this.comb_store.MaxDropDownItems = 6;
            this.comb_store.Name = "comb_store";
            this.comb_store.Size = new System.Drawing.Size(259, 33);
            this.comb_store.TabIndex = 20;
            this.comb_store.DropDown += new System.EventHandler(this.comb_store_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "اسم المخزن";
            // 
            // comb_catogry
            // 
            this.comb_catogry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_catogry.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_catogry.FormattingEnabled = true;
            this.comb_catogry.Location = new System.Drawing.Point(25, 78);
            this.comb_catogry.Name = "comb_catogry";
            this.comb_catogry.Size = new System.Drawing.Size(259, 33);
            this.comb_catogry.TabIndex = 4;
            this.comb_catogry.DropDown += new System.EventHandler(this.comb_catogry_DropDown);
            this.comb_catogry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_catogry_KeyDown);
            // 
            // date_expert
            // 
            this.date_expert.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_expert.Location = new System.Drawing.Point(471, 170);
            this.date_expert.Name = "date_expert";
            this.date_expert.Size = new System.Drawing.Size(134, 30);
            this.date_expert.TabIndex = 8;
            this.date_expert.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date_expert_KeyDown);
            // 
            // date_itemAdd
            // 
            this.date_itemAdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_itemAdd.Location = new System.Drawing.Point(718, 170);
            this.date_itemAdd.Name = "date_itemAdd";
            this.date_itemAdd.Size = new System.Drawing.Size(126, 30);
            this.date_itemAdd.TabIndex = 7;
            this.date_itemAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date_itemAdd_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(299, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "اسم المجموعة";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(615, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "تاريخ الانتهاء";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(297, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "مستخدم البرنامج";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(877, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "التاريخ";
            // 
            // txt_userAdd
            // 
            this.txt_userAdd.Enabled = false;
            this.txt_userAdd.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userAdd.Location = new System.Drawing.Point(25, 171);
            this.txt_userAdd.Name = "txt_userAdd";
            this.txt_userAdd.Size = new System.Drawing.Size(259, 32);
            this.txt_userAdd.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(856, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "سعر الشراء";
            // 
            // txt_sal
            // 
            this.txt_sal.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sal.Location = new System.Drawing.Point(471, 78);
            this.txt_sal.Name = "txt_sal";
            this.txt_sal.Size = new System.Drawing.Size(141, 32);
            this.txt_sal.TabIndex = 3;
            this.txt_sal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sal_KeyDown);
            this.txt_sal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sal_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(618, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "سعر البيع";
            // 
            // txt_pric
            // 
            this.txt_pric.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pric.Location = new System.Drawing.Point(697, 78);
            this.txt_pric.Name = "txt_pric";
            this.txt_pric.Size = new System.Drawing.Size(147, 32);
            this.txt_pric.TabIndex = 2;
            this.txt_pric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pric.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pric_KeyDown);
            this.txt_pric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pric_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "اسم الصنف ";
            // 
            // txt_item_arb
            // 
            this.txt_item_arb.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_item_arb.Location = new System.Drawing.Point(25, 25);
            this.txt_item_arb.Name = "txt_item_arb";
            this.txt_item_arb.Size = new System.Drawing.Size(259, 32);
            this.txt_item_arb.TabIndex = 1;
            this.txt_item_arb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_item_arb_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(867, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "الباركود";
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(472, 25);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(140, 32);
            this.txtqty.TabIndex = 0;
            this.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqty_KeyDown);
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(627, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "الكمية";
            // 
            // txt_barcod
            // 
            this.txt_barcod.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcod.Location = new System.Drawing.Point(471, 119);
            this.txt_barcod.Name = "txt_barcod";
            this.txt_barcod.Size = new System.Drawing.Size(373, 32);
            this.txt_barcod.TabIndex = 5;
            this.txt_barcod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_barcod_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(856, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم الصنف:";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(697, 25);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(147, 32);
            this.txtid.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_status);
            this.panel2.Controls.Add(this.btn_list_purch);
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_new);
            this.panel2.Location = new System.Drawing.Point(12, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 68);
            this.panel2.TabIndex = 1;
            // 
            // txt_status
            // 
            this.txt_status.Enabled = false;
            this.txt_status.Location = new System.Drawing.Point(155, 19);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(84, 30);
            this.txt_status.TabIndex = 20;
            this.txt_status.Text = "مضاف";
            this.txt_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_status.Visible = false;
            // 
            // btn_list_purch
            // 
            this.btn_list_purch.BackColor = System.Drawing.Color.White;
            this.btn_list_purch.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_list_purch.ForeColor = System.Drawing.Color.Navy;
            this.btn_list_purch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_list_purch.ImageIndex = 7;
            this.btn_list_purch.ImageList = this.imageList1;
            this.btn_list_purch.Location = new System.Drawing.Point(529, 16);
            this.btn_list_purch.Name = "btn_list_purch";
            this.btn_list_purch.Size = new System.Drawing.Size(134, 38);
            this.btn_list_purch.TabIndex = 9;
            this.btn_list_purch.Text = "قائمة الشراء";
            this.btn_list_purch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_list_purch.UseVisualStyleBackColor = false;
            this.btn_list_purch.Visible = false;
            this.btn_list_purch.Click += new System.EventHandler(this.btn_list_purch_Click);
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
            this.imageList1.Images.SetKeyName(6, "download.jpg");
            this.imageList1.Images.SetKeyName(7, "addproducts.ico");
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Navy;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.ImageIndex = 6;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(25, 16);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(113, 38);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "خروج";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Enabled = false;
            this.btn_add.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Navy;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.ImageIndex = 4;
            this.btn_add.ImageList = this.imageList1;
            this.btn_add.Location = new System.Drawing.Point(309, 16);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(132, 38);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "اضافة صنف";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.White;
            this.btn_new.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.Navy;
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new.ImageIndex = 5;
            this.btn_new.ImageList = this.imageList1;
            this.btn_new.Location = new System.Drawing.Point(756, 13);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(122, 38);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "جديد";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // frm_Additem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(987, 358);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Additem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة اضافة صنف";
            this.Load += new System.EventHandler(this.frm_Additem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox comb_catogry;
        public System.Windows.Forms.DateTimePicker date_expert;
        public System.Windows.Forms.DateTimePicker date_itemAdd;
        public System.Windows.Forms.TextBox txt_userAdd;
        public System.Windows.Forms.TextBox txt_sal;
        public System.Windows.Forms.TextBox txt_pric;
        public System.Windows.Forms.TextBox txt_item_arb;
        public System.Windows.Forms.TextBox txtqty;
        public System.Windows.Forms.TextBox txt_barcod;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_new;
        public System.Windows.Forms.Button btn_list_purch;
        public System.Windows.Forms.ComboBox comb_store;
    }
}