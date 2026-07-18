namespace storemedicals.allform.sales
{
    partial class frm_correction_in_saler_defe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker_s = new System.Windows.Forms.DateTimePicker();
            this.comBoxPink = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_item_id = new System.Windows.Forms.TextBox();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_order_id = new System.Windows.Forms.TextBox();
            this.txt_ITEM_PRIC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ITEM_COUNT = new System.Windows.Forms.TextBox();
            this.txt_ITEM_NAME_AR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tex_cha = new System.Windows.Forms.TextBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dgvitem = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delet = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker_s);
            this.panel1.Controls.Add(this.comBoxPink);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_item_id);
            this.panel1.Controls.Add(this.txt_Amount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_order_id);
            this.panel1.Controls.Add(this.txt_ITEM_PRIC);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_ITEM_COUNT);
            this.panel1.Controls.Add(this.txt_ITEM_NAME_AR);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(133, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 181);
            this.panel1.TabIndex = 78;
            // 
            // dateTimePicker_s
            // 
            this.dateTimePicker_s.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_s.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_s.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_s.Location = new System.Drawing.Point(392, 136);
            this.dateTimePicker_s.Name = "dateTimePicker_s";
            this.dateTimePicker_s.Size = new System.Drawing.Size(153, 29);
            this.dateTimePicker_s.TabIndex = 83;
            // 
            // comBoxPink
            // 
            this.comBoxPink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxPink.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxPink.FormattingEnabled = true;
            this.comBoxPink.Items.AddRange(new object[] {
            "صباح",
            "مساء"});
            this.comBoxPink.Location = new System.Drawing.Point(20, 140);
            this.comBoxPink.Name = "comBoxPink";
            this.comBoxPink.Size = new System.Drawing.Size(137, 27);
            this.comBoxPink.TabIndex = 82;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(161, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 30);
            this.label9.TabIndex = 81;
            this.label9.Text = "الدوام";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_item_id
            // 
            this.txt_item_id.Enabled = false;
            this.txt_item_id.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_item_id.Location = new System.Drawing.Point(445, 16);
            this.txt_item_id.Name = "txt_item_id";
            this.txt_item_id.Size = new System.Drawing.Size(100, 30);
            this.txt_item_id.TabIndex = 66;
            // 
            // txt_Amount
            // 
            this.txt_Amount.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Amount.Location = new System.Drawing.Point(20, 97);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.ReadOnly = true;
            this.txt_Amount.Size = new System.Drawing.Size(137, 30);
            this.txt_Amount.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 65;
            this.label1.Text = "رقم الصنف";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 75;
            this.label6.Text = "الاجمالي";
            // 
            // txt_order_id
            // 
            this.txt_order_id.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_order_id.Location = new System.Drawing.Point(444, 56);
            this.txt_order_id.Name = "txt_order_id";
            this.txt_order_id.Size = new System.Drawing.Size(100, 30);
            this.txt_order_id.TabIndex = 68;
            // 
            // txt_ITEM_PRIC
            // 
            this.txt_ITEM_PRIC.Enabled = false;
            this.txt_ITEM_PRIC.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ITEM_PRIC.Location = new System.Drawing.Point(20, 56);
            this.txt_ITEM_PRIC.Name = "txt_ITEM_PRIC";
            this.txt_ITEM_PRIC.Size = new System.Drawing.Size(137, 30);
            this.txt_ITEM_PRIC.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 73;
            this.label5.Text = "السعر البيع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "رقم الفاتورة";
            // 
            // txt_ITEM_COUNT
            // 
            this.txt_ITEM_COUNT.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ITEM_COUNT.Location = new System.Drawing.Point(20, 16);
            this.txt_ITEM_COUNT.Name = "txt_ITEM_COUNT";
            this.txt_ITEM_COUNT.Size = new System.Drawing.Size(137, 30);
            this.txt_ITEM_COUNT.TabIndex = 72;
            // 
            // txt_ITEM_NAME_AR
            // 
            this.txt_ITEM_NAME_AR.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ITEM_NAME_AR.Location = new System.Drawing.Point(242, 96);
            this.txt_ITEM_NAME_AR.Name = "txt_ITEM_NAME_AR";
            this.txt_ITEM_NAME_AR.Size = new System.Drawing.Size(303, 30);
            this.txt_ITEM_NAME_AR.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 71;
            this.label4.Text = "الكمية";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 69;
            this.label3.Text = "أسم الصنف";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(240, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 23);
            this.label8.TabIndex = 88;
            this.label8.Text = "اجيل";
            // 
            // tex_cha
            // 
            this.tex_cha.Enabled = false;
            this.tex_cha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_cha.Location = new System.Drawing.Point(132, 213);
            this.tex_cha.MaxLength = 10;
            this.tex_cha.Name = "tex_cha";
            this.tex_cha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tex_cha.Size = new System.Drawing.Size(79, 26);
            this.tex_cha.TabIndex = 89;
            this.tex_cha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(479, 215);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(223, 29);
            this.txt_Search.TabIndex = 87;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
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
            this.dgvitem.Location = new System.Drawing.Point(12, 252);
            this.dgvitem.MultiSelect = false;
            this.dgvitem.Name = "dgvitem";
            this.dgvitem.ReadOnly = true;
            this.dgvitem.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvitem.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvitem.Size = new System.Drawing.Size(891, 245);
            this.dgvitem.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(703, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 22);
            this.label7.TabIndex = 90;
            this.label7.Text = "البحث برقم الفاتورة";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(227, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 23);
            this.label10.TabIndex = 92;
            this.label10.Text = "الاجمالي";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 523);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 30);
            this.textBox1.TabIndex = 93;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.btn_exit);
            this.panel3.Controls.Add(this.btn_update);
            this.panel3.Controls.Add(this.btn_delet);
            this.panel3.Controls.Add(this.btn_new);
            this.panel3.Location = new System.Drawing.Point(343, 513);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 66);
            this.panel3.TabIndex = 91;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.Enabled = false;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.ImageIndex = 1;
            this.btn_save.Location = new System.Drawing.Point(325, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_save.Size = new System.Drawing.Size(100, 49);
            this.btn_save.TabIndex = 77;
            this.btn_save.Text = "حفظ";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImageIndex = 0;
            this.btn_exit.Location = new System.Drawing.Point(15, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_exit.Size = new System.Drawing.Size(92, 49);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "خروج";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Enabled = false;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.ImageIndex = 5;
            this.btn_update.Location = new System.Drawing.Point(218, 9);
            this.btn_update.Name = "btn_update";
            this.btn_update.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_update.Size = new System.Drawing.Size(100, 49);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "تعديل";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_delet
            // 
            this.btn_delet.BackColor = System.Drawing.Color.White;
            this.btn_delet.Enabled = false;
            this.btn_delet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delet.ImageIndex = 3;
            this.btn_delet.Location = new System.Drawing.Point(118, 9);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_delet.Size = new System.Drawing.Size(90, 49);
            this.btn_delet.TabIndex = 9;
            this.btn_delet.Text = "حذف";
            this.btn_delet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delet.UseVisualStyleBackColor = false;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.White;
            this.btn_new.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.ImageIndex = 4;
            this.btn_new.Location = new System.Drawing.Point(429, 9);
            this.btn_new.Name = "btn_new";
            this.btn_new.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_new.Size = new System.Drawing.Size(100, 49);
            this.btn_new.TabIndex = 7;
            this.btn_new.Text = "جديد";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new.UseVisualStyleBackColor = false;
            // 
            // frm_correction_in_saler_defe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 601);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tex_cha);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dgvitem);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_correction_in_saler_defe";
            this.Text = "frm_correction_in_saler_defe";
            this.Load += new System.EventHandler(this.frm_correction_in_saler_defe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_s;
        public System.Windows.Forms.ComboBox comBoxPink;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_item_id;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_order_id;
        private System.Windows.Forms.TextBox txt_ITEM_PRIC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ITEM_COUNT;
        private System.Windows.Forms.TextBox txt_ITEM_NAME_AR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tex_cha;
        private System.Windows.Forms.TextBox txt_Search;
        public System.Windows.Forms.DataGridView dgvitem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delet;
        private System.Windows.Forms.Button btn_new;
    }
}