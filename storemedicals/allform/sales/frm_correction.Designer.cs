namespace storemedicals.allform.sales
{
    partial class frm_correction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_correction));
            this.dgvitem = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tex_atm = new System.Windows.Forms.TextBox();
            this.checkBox_atm = new System.Windows.Forms.CheckBox();
            this.tex_bank = new System.Windows.Forms.TextBox();
            this.checkBox_bank = new System.Windows.Forms.CheckBox();
            this.tex_cha = new System.Windows.Forms.TextBox();
            this.checkBox_cah = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).BeginInit();
            this.SuspendLayout();
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
            this.dgvitem.Location = new System.Drawing.Point(12, 95);
            this.dgvitem.MultiSelect = false;
            this.dgvitem.Name = "dgvitem";
            this.dgvitem.ReadOnly = true;
            this.dgvitem.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvitem.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvitem.Size = new System.Drawing.Size(546, 260);
            this.dgvitem.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 22);
            this.label7.TabIndex = 66;
            this.label7.Text = "البحث برقم الفاتورة";
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(160, 60);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(152, 29);
            this.txt_Search.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 92;
            this.label8.Text = "نو الدفع";
            // 
            // tex_atm
            // 
            this.tex_atm.Enabled = false;
            this.tex_atm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_atm.Location = new System.Drawing.Point(477, 16);
            this.tex_atm.MaxLength = 10;
            this.tex_atm.Name = "tex_atm";
            this.tex_atm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tex_atm.Size = new System.Drawing.Size(79, 26);
            this.tex_atm.TabIndex = 98;
            this.tex_atm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox_atm
            // 
            this.checkBox_atm.AutoSize = true;
            this.checkBox_atm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_atm.Location = new System.Drawing.Point(407, 18);
            this.checkBox_atm.Name = "checkBox_atm";
            this.checkBox_atm.Size = new System.Drawing.Size(64, 23);
            this.checkBox_atm.TabIndex = 97;
            this.checkBox_atm.Text = "ATM";
            this.checkBox_atm.UseVisualStyleBackColor = true;
            // 
            // tex_bank
            // 
            this.tex_bank.Enabled = false;
            this.tex_bank.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_bank.Location = new System.Drawing.Point(319, 16);
            this.tex_bank.MaxLength = 10;
            this.tex_bank.Name = "tex_bank";
            this.tex_bank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tex_bank.Size = new System.Drawing.Size(79, 26);
            this.tex_bank.TabIndex = 96;
            this.tex_bank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox_bank
            // 
            this.checkBox_bank.AutoSize = true;
            this.checkBox_bank.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_bank.Location = new System.Drawing.Point(267, 18);
            this.checkBox_bank.Name = "checkBox_bank";
            this.checkBox_bank.Size = new System.Drawing.Size(51, 23);
            this.checkBox_bank.TabIndex = 95;
            this.checkBox_bank.Text = "بنكك";
            this.checkBox_bank.UseVisualStyleBackColor = true;
            // 
            // tex_cha
            // 
            this.tex_cha.Enabled = false;
            this.tex_cha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_cha.Location = new System.Drawing.Point(182, 16);
            this.tex_cha.MaxLength = 10;
            this.tex_cha.Name = "tex_cha";
            this.tex_cha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tex_cha.Size = new System.Drawing.Size(79, 26);
            this.tex_cha.TabIndex = 94;
            this.tex_cha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox_cah
            // 
            this.checkBox_cah.AutoSize = true;
            this.checkBox_cah.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_cah.Location = new System.Drawing.Point(124, 18);
            this.checkBox_cah.Name = "checkBox_cah";
            this.checkBox_cah.Size = new System.Drawing.Size(52, 23);
            this.checkBox_cah.TabIndex = 93;
            this.checkBox_cah.Text = "كاش";
            this.checkBox_cah.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(304, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 23);
            this.label10.TabIndex = 99;
            this.label10.Text = "الاجمالي";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(373, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 30);
            this.textBox1.TabIndex = 100;
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
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Enabled = false;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Image = global::storemedicals.Properties.Resources.icons8_Refresh_40px;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(348, 50);
            this.btn_update.Name = "btn_update";
            this.btn_update.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_update.Size = new System.Drawing.Size(100, 39);
            this.btn_update.TabIndex = 101;
            this.btn_update.Text = "تحديث";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // frm_correction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(570, 394);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tex_atm);
            this.Controls.Add(this.checkBox_atm);
            this.Controls.Add(this.tex_bank);
            this.Controls.Add(this.checkBox_bank);
            this.Controls.Add(this.tex_cha);
            this.Controls.Add(this.checkBox_cah);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dgvitem);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_correction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_correction";
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvitem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tex_atm;
        private System.Windows.Forms.CheckBox checkBox_atm;
        public System.Windows.Forms.TextBox tex_bank;
        private System.Windows.Forms.CheckBox checkBox_bank;
        public System.Windows.Forms.TextBox tex_cha;
        private System.Windows.Forms.CheckBox checkBox_cah;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_update;
    }
}