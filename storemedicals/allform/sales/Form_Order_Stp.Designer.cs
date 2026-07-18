namespace storemedicals.allform.sales
{
    partial class Form_Order_Stp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Order_Stp));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Branch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvitem_sal = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.حذفالسطرالمحددToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.id_ordrand = new System.Windows.Forms.TextBox();
            this.btn_item = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeP = new System.Windows.Forms.DateTimePicker();
            this.txt_item_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_qunty = new System.Windows.Forms.TextBox();
            this.txt_userAdd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_add_item = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.txt_item_nam = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem_sal)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 508);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الطلب";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_item_nam);
            this.panel1.Controls.Add(this.txt_Branch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvitem_sal);
            this.panel1.Controls.Add(this.id_ordrand);
            this.panel1.Controls.Add(this.btn_item);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimeP);
            this.panel1.Controls.Add(this.txt_item_id);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_qunty);
            this.panel1.Controls.Add(this.txt_userAdd);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btn_add_item);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(33, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 369);
            this.panel1.TabIndex = 77;
            // 
            // txt_Branch
            // 
            this.txt_Branch.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Branch.Enabled = false;
            this.txt_Branch.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Branch.ForeColor = System.Drawing.Color.Navy;
            this.txt_Branch.Location = new System.Drawing.Point(467, 141);
            this.txt_Branch.Name = "txt_Branch";
            this.txt_Branch.ReadOnly = true;
            this.txt_Branch.Size = new System.Drawing.Size(255, 32);
            this.txt_Branch.TabIndex = 79;
            this.txt_Branch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(765, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 78;
            this.label2.Text = "الفرع:";
            // 
            // dgvitem_sal
            // 
            this.dgvitem_sal.AllowUserToAddRows = false;
            this.dgvitem_sal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvitem_sal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvitem_sal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvitem_sal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvitem_sal.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvitem_sal.ColumnHeadersHeight = 40;
            this.dgvitem_sal.ContextMenuStrip = this.contextMenuStrip2;
            this.dgvitem_sal.Location = new System.Drawing.Point(26, 179);
            this.dgvitem_sal.MultiSelect = false;
            this.dgvitem_sal.Name = "dgvitem_sal";
            this.dgvitem_sal.ReadOnly = true;
            this.dgvitem_sal.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvitem_sal.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvitem_sal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvitem_sal.Size = new System.Drawing.Size(787, 169);
            this.dgvitem_sal.TabIndex = 77;
            this.dgvitem_sal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitem_sal_CellDoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حذفالسطرالمحددToolStripMenuItem1,
            this.toolStripSeparator3,
            this.حذفالكلToolStripMenuItem,
            this.toolStripSeparator4});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip2.Size = new System.Drawing.Size(171, 60);
            // 
            // حذفالسطرالمحددToolStripMenuItem1
            // 
            this.حذفالسطرالمحددToolStripMenuItem1.Image = global::storemedicals.Properties.Resources.Ampeross_Qetto_2_Trash;
            this.حذفالسطرالمحددToolStripMenuItem1.Name = "حذفالسطرالمحددToolStripMenuItem1";
            this.حذفالسطرالمحددToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.حذفالسطرالمحددToolStripMenuItem1.Text = "حذف السطر المحدد";
            this.حذفالسطرالمحددToolStripMenuItem1.Click += new System.EventHandler(this.حذفالسطرالمحددToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // حذفالكلToolStripMenuItem
            // 
            this.حذفالكلToolStripMenuItem.Image = global::storemedicals.Properties.Resources.Actions_window_close_icon;
            this.حذفالكلToolStripMenuItem.Name = "حذفالكلToolStripMenuItem";
            this.حذفالكلToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.حذفالكلToolStripMenuItem.Text = "حذف الكل";
            this.حذفالكلToolStripMenuItem.Click += new System.EventHandler(this.حذفالكلToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(167, 6);
            // 
            // id_ordrand
            // 
            this.id_ordrand.Location = new System.Drawing.Point(545, 18);
            this.id_ordrand.Name = "id_ordrand";
            this.id_ordrand.ReadOnly = true;
            this.id_ordrand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.id_ordrand.Size = new System.Drawing.Size(172, 35);
            this.id_ordrand.TabIndex = 15;
            // 
            // btn_item
            // 
            this.btn_item.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_item.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_item.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_item.Location = new System.Drawing.Point(420, 36);
            this.btn_item.Name = "btn_item";
            this.btn_item.Size = new System.Drawing.Size(113, 34);
            this.btn_item.TabIndex = 72;
            this.btn_item.Text = "الاصناف";
            this.btn_item.UseVisualStyleBackColor = false;
            this.btn_item.Click += new System.EventHandler(this.btn_item_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(732, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "رقم الفاتورة:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(420, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 76;
            this.label5.Text = "الاصناف";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(730, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "تاريخ الفاتورة:";
            // 
            // dateTimeP
            // 
            this.dateTimeP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeP.Location = new System.Drawing.Point(545, 58);
            this.dateTimeP.Name = "dateTimeP";
            this.dateTimeP.Size = new System.Drawing.Size(175, 35);
            this.dateTimeP.TabIndex = 14;
            // 
            // txt_item_id
            // 
            this.txt_item_id.Enabled = false;
            this.txt_item_id.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_item_id.ForeColor = System.Drawing.Color.White;
            this.txt_item_id.Location = new System.Drawing.Point(308, 38);
            this.txt_item_id.Name = "txt_item_id";
            this.txt_item_id.ReadOnly = true;
            this.txt_item_id.Size = new System.Drawing.Size(106, 36);
            this.txt_item_id.TabIndex = 73;
            this.txt_item_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(747, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "المستخدم:";
            // 
            // txt_qunty
            // 
            this.txt_qunty.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qunty.Location = new System.Drawing.Point(241, 107);
            this.txt_qunty.MaxLength = 10;
            this.txt_qunty.Name = "txt_qunty";
            this.txt_qunty.Size = new System.Drawing.Size(116, 36);
            this.txt_qunty.TabIndex = 68;
            this.txt_qunty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_qunty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_qunty_KeyDown);
            this.txt_qunty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qunty_KeyPress);
            // 
            // txt_userAdd
            // 
            this.txt_userAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_userAdd.Enabled = false;
            this.txt_userAdd.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userAdd.ForeColor = System.Drawing.Color.Navy;
            this.txt_userAdd.Location = new System.Drawing.Point(467, 102);
            this.txt_userAdd.Name = "txt_userAdd";
            this.txt_userAdd.ReadOnly = true;
            this.txt_userAdd.Size = new System.Drawing.Size(255, 32);
            this.txt_userAdd.TabIndex = 17;
            this.txt_userAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.DimGray;
            this.label13.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(241, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 25);
            this.label13.TabIndex = 65;
            this.label13.Text = "الكمية";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 25);
            this.label9.TabIndex = 60;
            this.label9.Text = "اسم الصنف";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_add_item
            // 
            this.btn_add_item.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_item.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_item.ForeColor = System.Drawing.Color.Navy;
            this.btn_add_item.Image = global::storemedicals.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_svn_update;
            this.btn_add_item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_item.Location = new System.Drawing.Point(64, 92);
            this.btn_add_item.Name = "btn_add_item";
            this.btn_add_item.Size = new System.Drawing.Size(134, 51);
            this.btn_add_item.TabIndex = 63;
            this.btn_add_item.Text = "اضافة صنف";
            this.btn_add_item.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_item.UseVisualStyleBackColor = false;
            this.btn_add_item.Click += new System.EventHandler(this.btn_add_item_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DimGray;
            this.label11.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(308, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 25);
            this.label11.TabIndex = 62;
            this.label11.Text = "رقم االصنف";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btn_save);
            this.panel5.Controls.Add(this.btn_exit);
            this.panel5.Controls.Add(this.btn_new);
            this.panel5.Location = new System.Drawing.Point(46, 444);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(831, 56);
            this.panel5.TabIndex = 56;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.Enabled = false;
            this.btn_save.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Navy;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.ImageIndex = 1;
            this.btn_save.ImageList = this.imageList1;
            this.btn_save.Location = new System.Drawing.Point(340, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_save.Size = new System.Drawing.Size(149, 41);
            this.btn_save.TabIndex = 55;
            this.btn_save.Text = "حفظ الطلب";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exit.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Navy;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.ImageIndex = 0;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(5, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_exit.Size = new System.Drawing.Size(158, 41);
            this.btn_exit.TabIndex = 53;
            this.btn_exit.Text = "خروج";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_new.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.Navy;
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new.ImageIndex = 4;
            this.btn_new.ImageList = this.imageList1;
            this.btn_new.Location = new System.Drawing.Point(713, 6);
            this.btn_new.Name = "btn_new";
            this.btn_new.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_new.Size = new System.Drawing.Size(104, 41);
            this.btn_new.TabIndex = 51;
            this.btn_new.Text = "جديد";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // txt_item_nam
            // 
            this.txt_item_nam.Location = new System.Drawing.Point(14, 44);
            this.txt_item_nam.Name = "txt_item_nam";
            this.txt_item_nam.Size = new System.Drawing.Size(288, 35);
            this.txt_item_nam.TabIndex = 80;
            // 
            // Form_Order_Stp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(922, 532);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Order_Stp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة طلب من المخزان";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem_sal)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_item;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_item_id;
        public System.Windows.Forms.TextBox txt_qunty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_add_item;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem حذفالسطرالمحددToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem حذفالكلToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.DataGridView dgvitem_sal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.Button btn_new;
        public System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dateTimeP;
        public System.Windows.Forms.TextBox id_ordrand;
        public System.Windows.Forms.TextBox txt_userAdd;
        public System.Windows.Forms.TextBox txt_Branch;
        private System.Windows.Forms.TextBox txt_item_nam;
    }
}