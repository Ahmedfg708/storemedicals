namespace storemedicals.allform.Retenitem
{
    partial class frm_reten_mang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reten_mang));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvReten = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_retenItem = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delet = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReten)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dgvReten);
            this.panel2.Location = new System.Drawing.Point(23, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 367);
            this.panel2.TabIndex = 5;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(446, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(355, 28);
            this.txt_search.TabIndex = 8;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::storemedicals.Properties.Resources._16;
            this.button1.Location = new System.Drawing.Point(807, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvReten
            // 
            this.dgvReten.AllowUserToAddRows = false;
            this.dgvReten.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReten.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvReten.ColumnHeadersHeight = 40;
            this.dgvReten.Location = new System.Drawing.Point(20, 53);
            this.dgvReten.MultiSelect = false;
            this.dgvReten.Name = "dgvReten";
            this.dgvReten.ReadOnly = true;
            this.dgvReten.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReten.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReten.Size = new System.Drawing.Size(910, 298);
            this.dgvReten.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_retenItem);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_delet);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Location = new System.Drawing.Point(23, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 69);
            this.panel1.TabIndex = 4;
            // 
            // btn_retenItem
            // 
            this.btn_retenItem.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retenItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_retenItem.ImageIndex = 2;
            this.btn_retenItem.ImageList = this.imageList1;
            this.btn_retenItem.Location = new System.Drawing.Point(173, 12);
            this.btn_retenItem.Name = "btn_retenItem";
            this.btn_retenItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_retenItem.Size = new System.Drawing.Size(213, 42);
            this.btn_retenItem.TabIndex = 14;
            this.btn_retenItem.Text = "الموافقة على الاسترجاع";
            this.btn_retenItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_retenItem.UseVisualStyleBackColor = true;
            this.btn_retenItem.Click += new System.EventHandler(this.btn_retenItem_Click);
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
            this.imageList1.Images.SetKeyName(6, "print-icon.png");
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImageIndex = 0;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(17, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_exit.Size = new System.Drawing.Size(100, 42);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "خروج";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.ImageIndex = 5;
            this.btn_update.ImageList = this.imageList1;
            this.btn_update.Location = new System.Drawing.Point(582, 11);
            this.btn_update.Name = "btn_update";
            this.btn_update.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_update.Size = new System.Drawing.Size(115, 42);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "تعديل";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delet
            // 
            this.btn_delet.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delet.ImageIndex = 3;
            this.btn_delet.ImageList = this.imageList1;
            this.btn_delet.Location = new System.Drawing.Point(435, 11);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_delet.Size = new System.Drawing.Size(110, 42);
            this.btn_delet.TabIndex = 12;
            this.btn_delet.Text = "حذف";
            this.btn_delet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delet.UseVisualStyleBackColor = true;
            this.btn_delet.Click += new System.EventHandler(this.btn_delet_Click);
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.ImageIndex = 4;
            this.btn_new.ImageList = this.imageList1;
            this.btn_new.Location = new System.Drawing.Point(737, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_new.Size = new System.Drawing.Size(190, 42);
            this.btn_new.TabIndex = 9;
            this.btn_new.Text = "اضافة مرتجع جديد";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // frm_reten_mang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_reten_mang";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة التحكم بالمرتجعات";
            this.Load += new System.EventHandler(this.frm_reten_mang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReten)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvReten;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delet;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_retenItem;
    }
}