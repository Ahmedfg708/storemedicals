namespace storemedicals.allform
{
    partial class frm_khzena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_khzena));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rad_atm = new System.Windows.Forms.RadioButton();
            this.rad_bank = new System.Windows.Forms.RadioButton();
            this.rad_cash = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_ver = new System.Windows.Forms.DateTimePicker();
            this.com_Box_custmeer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tex_salr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.rad_atm_sh = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.rad_bank_sh = new System.Windows.Forms.RadioButton();
            this.rad_cash_sh = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tex_Total = new System.Windows.Forms.TextBox();
            this.dgvitem = new System.Windows.Forms.DataGridView();
            this.dat_search = new System.Windows.Forms.DateTimePicker();
            this.comb_serach = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delet = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rad_atm);
            this.panel1.Controls.Add(this.rad_bank);
            this.panel1.Controls.Add(this.rad_cash);
            this.panel1.Controls.Add(this.dateTimePicker_ver);
            this.panel1.Controls.Add(this.com_Box_custmeer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tex_salr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(126, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 104);
            this.panel1.TabIndex = 0;
            // 
            // rad_atm
            // 
            this.rad_atm.AutoSize = true;
            this.rad_atm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_atm.Location = new System.Drawing.Point(271, 68);
            this.rad_atm.Name = "rad_atm";
            this.rad_atm.Size = new System.Drawing.Size(63, 23);
            this.rad_atm.TabIndex = 6;
            this.rad_atm.TabStop = true;
            this.rad_atm.Text = "ATM";
            this.rad_atm.UseVisualStyleBackColor = true;
            this.rad_atm.CheckedChanged += new System.EventHandler(this.rad_atm_CheckedChanged);
            // 
            // rad_bank
            // 
            this.rad_bank.AutoSize = true;
            this.rad_bank.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_bank.Location = new System.Drawing.Point(362, 68);
            this.rad_bank.Name = "rad_bank";
            this.rad_bank.Size = new System.Drawing.Size(50, 23);
            this.rad_bank.TabIndex = 5;
            this.rad_bank.TabStop = true;
            this.rad_bank.Text = "بنكك";
            this.rad_bank.UseVisualStyleBackColor = true;
            this.rad_bank.CheckedChanged += new System.EventHandler(this.rad_bank_CheckedChanged);
            // 
            // rad_cash
            // 
            this.rad_cash.AutoSize = true;
            this.rad_cash.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_cash.Location = new System.Drawing.Point(454, 69);
            this.rad_cash.Name = "rad_cash";
            this.rad_cash.Size = new System.Drawing.Size(51, 23);
            this.rad_cash.TabIndex = 4;
            this.rad_cash.TabStop = true;
            this.rad_cash.Text = "كاش";
            this.rad_cash.UseVisualStyleBackColor = true;
            this.rad_cash.CheckedChanged += new System.EventHandler(this.rad_cash_CheckedChanged);
            // 
            // dateTimePicker_ver
            // 
            this.dateTimePicker_ver.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_ver.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ver.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ver.Location = new System.Drawing.Point(18, 63);
            this.dateTimePicker_ver.Name = "dateTimePicker_ver";
            this.dateTimePicker_ver.Size = new System.Drawing.Size(152, 29);
            this.dateTimePicker_ver.TabIndex = 3;
            // 
            // com_Box_custmeer
            // 
            this.com_Box_custmeer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Box_custmeer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_Box_custmeer.FormattingEnabled = true;
            this.com_Box_custmeer.Location = new System.Drawing.Point(266, 18);
            this.com_Box_custmeer.Name = "com_Box_custmeer";
            this.com_Box_custmeer.Size = new System.Drawing.Size(239, 30);
            this.com_Box_custmeer.TabIndex = 1;
            this.com_Box_custmeer.SelectedIndexChanged += new System.EventHandler(this.com_Box_custmeer_SelectedIndexChanged);
            this.com_Box_custmeer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.com_Box_custmeer_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "المبلغ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "التاريخ:";
            // 
            // tex_salr
            // 
            this.tex_salr.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_salr.Location = new System.Drawing.Point(18, 19);
            this.tex_salr.Name = "tex_salr";
            this.tex_salr.Size = new System.Drawing.Size(152, 29);
            this.tex_salr.TabIndex = 2;
            this.tex_salr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_salr_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المحل:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.rad_atm_sh);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.rad_bank_sh);
            this.panel2.Controls.Add(this.rad_cash_sh);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tex_Total);
            this.panel2.Controls.Add(this.dgvitem);
            this.panel2.Controls.Add(this.dat_search);
            this.panel2.Controls.Add(this.comb_serach);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(18, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 294);
            this.panel2.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(723, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 63;
            this.label7.Text = "خيارات البحث";
            // 
            // rad_atm_sh
            // 
            this.rad_atm_sh.AutoSize = true;
            this.rad_atm_sh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_atm_sh.Location = new System.Drawing.Point(378, 5);
            this.rad_atm_sh.Name = "rad_atm_sh";
            this.rad_atm_sh.Size = new System.Drawing.Size(63, 23);
            this.rad_atm_sh.TabIndex = 9;
            this.rad_atm_sh.TabStop = true;
            this.rad_atm_sh.Text = "ATM";
            this.rad_atm_sh.UseVisualStyleBackColor = true;
            this.rad_atm_sh.CheckedChanged += new System.EventHandler(this.rad_atm_sh_CheckedChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::storemedicals.Properties.Resources._16;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(409, 255);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(108, 34);
            this.button3.TabIndex = 62;
            this.button3.Text = "بحث بين ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rad_bank_sh
            // 
            this.rad_bank_sh.AutoSize = true;
            this.rad_bank_sh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_bank_sh.Location = new System.Drawing.Point(475, 5);
            this.rad_bank_sh.Name = "rad_bank_sh";
            this.rad_bank_sh.Size = new System.Drawing.Size(50, 23);
            this.rad_bank_sh.TabIndex = 8;
            this.rad_bank_sh.TabStop = true;
            this.rad_bank_sh.Text = "بنكك";
            this.rad_bank_sh.UseVisualStyleBackColor = true;
            this.rad_bank_sh.CheckedChanged += new System.EventHandler(this.rad_bank_sh_CheckedChanged);
            // 
            // rad_cash_sh
            // 
            this.rad_cash_sh.AutoSize = true;
            this.rad_cash_sh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_cash_sh.Location = new System.Drawing.Point(559, 6);
            this.rad_cash_sh.Name = "rad_cash_sh";
            this.rad_cash_sh.Size = new System.Drawing.Size(51, 23);
            this.rad_cash_sh.TabIndex = 7;
            this.rad_cash_sh.TabStop = true;
            this.rad_cash_sh.Text = "كاش";
            this.rad_cash_sh.UseVisualStyleBackColor = true;
            this.rad_cash_sh.CheckedChanged += new System.EventHandler(this.rad_cash_sh_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(547, 258);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(152, 29);
            this.dateTimePicker2.TabIndex = 61;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::storemedicals.Properties.Resources._16;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(61, 0);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(81, 39);
            this.button2.TabIndex = 60;
            this.button2.Text = "بحث";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 4;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(265, 255);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(114, 35);
            this.button1.TabIndex = 59;
            this.button1.Text = "عرض الكل";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 58;
            this.label4.Text = "المجموع";
            // 
            // tex_Total
            // 
            this.tex_Total.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_Total.Location = new System.Drawing.Point(6, 258);
            this.tex_Total.Name = "tex_Total";
            this.tex_Total.ReadOnly = true;
            this.tex_Total.Size = new System.Drawing.Size(160, 29);
            this.tex_Total.TabIndex = 57;
            // 
            // dgvitem
            // 
            this.dgvitem.AllowUserToAddRows = false;
            this.dgvitem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvitem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvitem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvitem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvitem.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvitem.ColumnHeadersHeight = 40;
            this.dgvitem.Location = new System.Drawing.Point(4, 66);
            this.dgvitem.MultiSelect = false;
            this.dgvitem.Name = "dgvitem";
            this.dgvitem.ReadOnly = true;
            this.dgvitem.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvitem.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvitem.Size = new System.Drawing.Size(809, 179);
            this.dgvitem.TabIndex = 56;
            this.dgvitem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitem_CellClick);
            this.dgvitem.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvitem_CellFormatting);
            // 
            // dat_search
            // 
            this.dat_search.CustomFormat = "dd-MM-yyyy";
            this.dat_search.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dat_search.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dat_search.Location = new System.Drawing.Point(152, 5);
            this.dat_search.Name = "dat_search";
            this.dat_search.Size = new System.Drawing.Size(152, 29);
            this.dat_search.TabIndex = 6;
            // 
            // comb_serach
            // 
            this.comb_serach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_serach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_serach.FormattingEnabled = true;
            this.comb_serach.Location = new System.Drawing.Point(369, 32);
            this.comb_serach.Name = "comb_serach";
            this.comb_serach.Size = new System.Drawing.Size(239, 30);
            this.comb_serach.TabIndex = 5;
            this.comb_serach.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comb_serach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "التاريخ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(614, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "اسم المحل:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_exit);
            this.panel3.Controls.Add(this.btn_update);
            this.panel3.Controls.Add(this.btn_delet);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.btn_new);
            this.panel3.Location = new System.Drawing.Point(160, 416);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 66);
            this.panel3.TabIndex = 57;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImageIndex = 0;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(15, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_exit.Size = new System.Drawing.Size(92, 49);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "خروج";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Enabled = false;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.ImageIndex = 5;
            this.btn_update.ImageList = this.imageList1;
            this.btn_update.Location = new System.Drawing.Point(217, 12);
            this.btn_update.Name = "btn_update";
            this.btn_update.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_update.Size = new System.Drawing.Size(100, 49);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "تعديل";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delet
            // 
            this.btn_delet.BackColor = System.Drawing.Color.White;
            this.btn_delet.Enabled = false;
            this.btn_delet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delet.ImageIndex = 3;
            this.btn_delet.ImageList = this.imageList1;
            this.btn_delet.Location = new System.Drawing.Point(115, 12);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_delet.Size = new System.Drawing.Size(90, 49);
            this.btn_delet.TabIndex = 9;
            this.btn_delet.Text = "حذف";
            this.btn_delet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delet.UseVisualStyleBackColor = false;
            this.btn_delet.Click += new System.EventHandler(this.btn_delet_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.ImageIndex = 1;
            this.btn_save.ImageList = this.imageList1;
            this.btn_save.Location = new System.Drawing.Point(323, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_save.Size = new System.Drawing.Size(100, 49);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "حفظ";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.White;
            this.btn_new.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.ImageIndex = 4;
            this.btn_new.ImageList = this.imageList1;
            this.btn_new.Location = new System.Drawing.Point(429, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_new.Size = new System.Drawing.Size(100, 49);
            this.btn_new.TabIndex = 7;
            this.btn_new.Text = "جديد";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // frm_khzena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(857, 493);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_khzena";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة الخزنة ";
            this.Load += new System.EventHandler(this.frm_khzena_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox com_Box_custmeer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tex_salr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ver;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dat_search;
        private System.Windows.Forms.ComboBox comb_serach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dgvitem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tex_Total;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delet;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton rad_atm;
        private System.Windows.Forms.RadioButton rad_bank;
        private System.Windows.Forms.RadioButton rad_cash;
        private System.Windows.Forms.RadioButton rad_atm_sh;
        private System.Windows.Forms.RadioButton rad_bank_sh;
        private System.Windows.Forms.RadioButton rad_cash_sh;
        private System.Windows.Forms.Label label7;
    }
}