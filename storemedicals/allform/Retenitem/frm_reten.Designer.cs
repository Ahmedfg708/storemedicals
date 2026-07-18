namespace storemedicals.allform.Reten
{
    partial class frm_reten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reten));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_stat_id = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.date_reten = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_userAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tot_amount = new System.Windows.Forms.TextBox();
            this.txt_pric = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_item_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txt_barcod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_item_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_reten_stat = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_not = new System.Windows.Forms.TextBox();
            this.btn_item_list = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_order_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_retn_id = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.txt_stat_id);
            this.panel2.Controls.Add(this.btn_new);
            this.panel2.Location = new System.Drawing.Point(22, 428);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 58);
            this.panel2.TabIndex = 3;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Navy;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.ImageIndex = 6;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(12, 10);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(85, 37);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "خروج";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.UseVisualStyleBackColor = true;
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
            this.imageList1.Images.SetKeyName(6, "download.jpg");
            this.imageList1.Images.SetKeyName(7, "addproducts.ico");
            // 
            // btn_add
            // 
            this.btn_add.Enabled = false;
            this.btn_add.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Navy;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.ImageIndex = 4;
            this.btn_add.ImageList = this.imageList1;
            this.btn_add.Location = new System.Drawing.Point(163, 10);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(132, 37);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "اضافة صنف";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_stat_id
            // 
            this.txt_stat_id.BackColor = System.Drawing.Color.White;
            this.txt_stat_id.Enabled = false;
            this.txt_stat_id.ForeColor = System.Drawing.Color.Black;
            this.txt_stat_id.Location = new System.Drawing.Point(103, 15);
            this.txt_stat_id.Name = "txt_stat_id";
            this.txt_stat_id.ReadOnly = true;
            this.txt_stat_id.Size = new System.Drawing.Size(52, 28);
            this.txt_stat_id.TabIndex = 24;
            this.txt_stat_id.Text = "غير مسترجع";
            this.txt_stat_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_stat_id.Visible = false;
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.Navy;
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new.ImageIndex = 5;
            this.btn_new.ImageList = this.imageList1;
            this.btn_new.Location = new System.Drawing.Point(334, 10);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(82, 37);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "جديد";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // date_reten
            // 
            this.date_reten.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_reten.Location = new System.Drawing.Point(15, 289);
            this.date_reten.Name = "date_reten";
            this.date_reten.RightToLeftLayout = true;
            this.date_reten.Size = new System.Drawing.Size(316, 28);
            this.date_reten.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(339, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "المستخدم";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(339, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "تاريخ المرتجع";
            // 
            // txt_userAdd
            // 
            this.txt_userAdd.BackColor = System.Drawing.Color.White;
            this.txt_userAdd.Enabled = false;
            this.txt_userAdd.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userAdd.ForeColor = System.Drawing.Color.Black;
            this.txt_userAdd.Location = new System.Drawing.Point(15, 324);
            this.txt_userAdd.Name = "txt_userAdd";
            this.txt_userAdd.ReadOnly = true;
            this.txt_userAdd.Size = new System.Drawing.Size(316, 32);
            this.txt_userAdd.TabIndex = 14;
            this.txt_userAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(339, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "سعر المرتجع";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(339, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "اجمالى المرتجع";
            // 
            // txt_tot_amount
            // 
            this.txt_tot_amount.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tot_amount.ForeColor = System.Drawing.Color.Black;
            this.txt_tot_amount.Location = new System.Drawing.Point(15, 253);
            this.txt_tot_amount.Name = "txt_tot_amount";
            this.txt_tot_amount.Size = new System.Drawing.Size(316, 32);
            this.txt_tot_amount.TabIndex = 3;
            this.txt_tot_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tot_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tot_reten_KeyDown);
            // 
            // txt_pric
            // 
            this.txt_pric.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pric.ForeColor = System.Drawing.Color.Black;
            this.txt_pric.Location = new System.Drawing.Point(194, 216);
            this.txt_pric.Name = "txt_pric";
            this.txt_pric.Size = new System.Drawing.Size(137, 32);
            this.txt_pric.TabIndex = 2;
            this.txt_pric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pric.TextChanged += new System.EventHandler(this.txt_pric_TextChanged);
            this.txt_pric.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pric_KeyDown);
            this.txt_pric.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_pric_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(339, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "اسم المرجع";
            // 
            // txt_item_name
            // 
            this.txt_item_name.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_item_name.ForeColor = System.Drawing.Color.Black;
            this.txt_item_name.Location = new System.Drawing.Point(15, 141);
            this.txt_item_name.Name = "txt_item_name";
            this.txt_item_name.Size = new System.Drawing.Size(316, 32);
            this.txt_item_name.TabIndex = 1;
            this.txt_item_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_item_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_item_name_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(339, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "الباركود";
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.ForeColor = System.Drawing.Color.Black;
            this.txtqty.Location = new System.Drawing.Point(15, 177);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(316, 32);
            this.txtqty.TabIndex = 0;
            this.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqty_KeyDown);
            this.txtqty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtqty_KeyUp);
            // 
            // txt_barcod
            // 
            this.txt_barcod.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcod.ForeColor = System.Drawing.Color.Black;
            this.txt_barcod.Location = new System.Drawing.Point(18, 67);
            this.txt_barcod.Name = "txt_barcod";
            this.txt_barcod.Size = new System.Drawing.Size(313, 32);
            this.txt_barcod.TabIndex = 5;
            this.txt_barcod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_barcod.TextChanged += new System.EventHandler(this.txt_barcod_TextChanged);
            this.txt_barcod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_barcod_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم الصنف:";
            // 
            // txt_item_id
            // 
            this.txt_item_id.BackColor = System.Drawing.Color.White;
            this.txt_item_id.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_item_id.ForeColor = System.Drawing.Color.Black;
            this.txt_item_id.Location = new System.Drawing.Point(15, 106);
            this.txt_item_id.Name = "txt_item_id";
            this.txt_item_id.ReadOnly = true;
            this.txt_item_id.Size = new System.Drawing.Size(118, 32);
            this.txt_item_id.TabIndex = 0;
            this.txt_item_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(339, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "كمية المرتجع";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_reten_stat);
            this.panel1.Controls.Add(this.txt_amount);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_not);
            this.panel1.Controls.Add(this.btn_item_list);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_order_id);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_retn_id);
            this.panel1.Controls.Add(this.date_reten);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_tot_amount);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtqty);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_pric);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_userAdd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_item_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_barcod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_item_id);
            this.panel1.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 410);
            this.panel1.TabIndex = 2;
            // 
            // txt_reten_stat
            // 
            this.txt_reten_stat.BackColor = System.Drawing.Color.White;
            this.txt_reten_stat.Enabled = false;
            this.txt_reten_stat.ForeColor = System.Drawing.Color.Black;
            this.txt_reten_stat.Location = new System.Drawing.Point(17, 329);
            this.txt_reten_stat.Name = "txt_reten_stat";
            this.txt_reten_stat.ReadOnly = true;
            this.txt_reten_stat.Size = new System.Drawing.Size(70, 28);
            this.txt_reten_stat.TabIndex = 25;
            this.txt_reten_stat.Text = "تم الارجاع";
            this.txt_reten_stat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_reten_stat.Visible = false;
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.ForeColor = System.Drawing.Color.Black;
            this.txt_amount.Location = new System.Drawing.Point(15, 214);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(118, 32);
            this.txt_amount.TabIndex = 25;
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_amount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_amount_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(139, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "المبلغ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(341, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "ملاحظات";
            // 
            // txt_not
            // 
            this.txt_not.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_not.ForeColor = System.Drawing.Color.Black;
            this.txt_not.Location = new System.Drawing.Point(15, 363);
            this.txt_not.Name = "txt_not";
            this.txt_not.Size = new System.Drawing.Size(319, 32);
            this.txt_not.TabIndex = 22;
            this.txt_not.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_not.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_not_KeyDown);
            // 
            // btn_item_list
            // 
            this.btn_item_list.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item_list.ForeColor = System.Drawing.Color.Navy;
            this.btn_item_list.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_item_list.ImageIndex = 7;
            this.btn_item_list.ImageList = this.imageList1;
            this.btn_item_list.Location = new System.Drawing.Point(18, 21);
            this.btn_item_list.Name = "btn_item_list";
            this.btn_item_list.Size = new System.Drawing.Size(163, 37);
            this.btn_item_list.TabIndex = 5;
            this.btn_item_list.Text = "قائمة فواتير البيع";
            this.btn_item_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_item_list.UseVisualStyleBackColor = true;
            this.btn_item_list.Click += new System.EventHandler(this.btn_item_list_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(341, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "رقم الفاتورة";
            // 
            // txt_order_id
            // 
            this.txt_order_id.BackColor = System.Drawing.Color.White;
            this.txt_order_id.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_order_id.ForeColor = System.Drawing.Color.Black;
            this.txt_order_id.Location = new System.Drawing.Point(241, 25);
            this.txt_order_id.Name = "txt_order_id";
            this.txt_order_id.ReadOnly = true;
            this.txt_order_id.Size = new System.Drawing.Size(90, 32);
            this.txt_order_id.TabIndex = 20;
            this.txt_order_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(339, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "رقم المرتجع";
            // 
            // txt_retn_id
            // 
            this.txt_retn_id.BackColor = System.Drawing.Color.White;
            this.txt_retn_id.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_retn_id.ForeColor = System.Drawing.Color.Black;
            this.txt_retn_id.Location = new System.Drawing.Point(241, 107);
            this.txt_retn_id.Name = "txt_retn_id";
            this.txt_retn_id.ReadOnly = true;
            this.txt_retn_id.Size = new System.Drawing.Size(90, 32);
            this.txt_retn_id.TabIndex = 18;
            this.txt_retn_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_reten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 494);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_reten";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة المرتجعات";
            this.Load += new System.EventHandler(this.frm_reten_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_new;
        public System.Windows.Forms.DateTimePicker date_reten;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_userAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_tot_amount;
        public System.Windows.Forms.TextBox txt_pric;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_item_name;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtqty;
        public System.Windows.Forms.TextBox txt_barcod;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_item_id;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_retn_id;
        public System.Windows.Forms.Button btn_item_list;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txt_order_id;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_not;
        public System.Windows.Forms.TextBox txt_stat_id;
        public System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txt_reten_stat;

    }
}