namespace storemedicals.allform.Records
{
    partial class Form_Add_Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_Records));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvcat = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstListOfScanner = new System.Windows.Forms.ListBox();
            this.grop_fator = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.btn_add_item = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Col = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcat)).BeginInit();
            this.panel2.SuspendLayout();
            this.grop_fator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Location = new System.Drawing.Point(12, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 66);
            this.panel1.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImageIndex = 0;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(179, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_exit.Size = new System.Drawing.Size(92, 49);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "خروج";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.Enabled = false;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.ImageIndex = 1;
            this.btn_save.ImageList = this.imageList1;
            this.btn_save.Location = new System.Drawing.Point(391, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_save.Size = new System.Drawing.Size(100, 49);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "حفظ";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.White;
            this.btn_new.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.ImageIndex = 4;
            this.btn_new.ImageList = this.imageList1;
            this.btn_new.Location = new System.Drawing.Point(593, 9);
            this.btn_new.Name = "btn_new";
            this.btn_new.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_new.Size = new System.Drawing.Size(100, 49);
            this.btn_new.TabIndex = 3;
            this.btn_new.Text = "جديد";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(810, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم الزبون";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "رقم الفاتوره";
            // 
            // dgvcat
            // 
            this.dgvcat.AllowUserToAddRows = false;
            this.dgvcat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvcat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvcat.ColumnHeadersHeight = 40;
            this.dgvcat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col});
            this.dgvcat.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvcat.Location = new System.Drawing.Point(306, 53);
            this.dgvcat.MultiSelect = false;
            this.dgvcat.Name = "dgvcat";
            this.dgvcat.ReadOnly = true;
            this.dgvcat.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcat.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcat.Size = new System.Drawing.Size(568, 374);
            this.dgvcat.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstListOfScanner);
            this.panel2.Controls.Add(this.grop_fator);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.btn_add_item);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnScan);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.dgvcat);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 500);
            this.panel2.TabIndex = 7;
            // 
            // lstListOfScanner
            // 
            this.lstListOfScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListOfScanner.FormattingEnabled = true;
            this.lstListOfScanner.ItemHeight = 16;
            this.lstListOfScanner.Location = new System.Drawing.Point(436, 449);
            this.lstListOfScanner.Name = "lstListOfScanner";
            this.lstListOfScanner.Size = new System.Drawing.Size(258, 36);
            this.lstListOfScanner.TabIndex = 41;
            // 
            // grop_fator
            // 
            this.grop_fator.Controls.Add(this.pictureBox2);
            this.grop_fator.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold);
            this.grop_fator.Location = new System.Drawing.Point(11, 21);
            this.grop_fator.Name = "grop_fator";
            this.grop_fator.Size = new System.Drawing.Size(274, 406);
            this.grop_fator.TabIndex = 40;
            this.grop_fator.TabStop = false;
            this.grop_fator.Text = "الصورة";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 357);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(8, 435);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(341, 20);
            this.textBox10.TabIndex = 39;
            // 
            // btn_add_item
            // 
            this.btn_add_item.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_item.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_item.ForeColor = System.Drawing.Color.Navy;
            this.btn_add_item.Image = global::storemedicals.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_svn_update;
            this.btn_add_item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_item.Location = new System.Drawing.Point(765, 452);
            this.btn_add_item.Name = "btn_add_item";
            this.btn_add_item.Size = new System.Drawing.Size(109, 41);
            this.btn_add_item.TabIndex = 38;
            this.btn_add_item.Text = "اضافة";
            this.btn_add_item.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_item.UseVisualStyleBackColor = false;
            this.btn_add_item.Click += new System.EventHandler(this.btn_add_item_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(204, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "أختار الصورة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnScan
            // 
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Location = new System.Drawing.Point(11, 461);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(187, 31);
            this.btnScan.TabIndex = 11;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 26);
            this.textBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(581, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 27);
            this.comboBox1.TabIndex = 7;
            // 
            // Col
            // 
            this.Col.HeaderText = "img";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            // 
            // Form_Add_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(920, 602);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Add_Records";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة اضافة سجل ";
            this.Load += new System.EventHandler(this.Form_Add_Records_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grop_fator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvcat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_add_item;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.GroupBox grop_fator;
        private System.Windows.Forms.ListBox lstListOfScanner;
        private System.Windows.Forms.DataGridViewImageColumn Col;
    }
}