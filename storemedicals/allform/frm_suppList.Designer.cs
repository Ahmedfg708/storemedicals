namespace storemedicals.allform
{
    partial class frm_suppList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_suppList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_add_supler = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvSupler = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_add_supler);
            this.panel2.Controls.Add(this.dgvSupler);
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(23, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 455);
            this.panel2.TabIndex = 5;
            // 
            // btn_add_supler
            // 
            this.btn_add_supler.BackColor = System.Drawing.Color.White;
            this.btn_add_supler.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_supler.ForeColor = System.Drawing.Color.Navy;
            this.btn_add_supler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_supler.ImageIndex = 4;
            this.btn_add_supler.ImageList = this.imageList1;
            this.btn_add_supler.Location = new System.Drawing.Point(20, 8);
            this.btn_add_supler.Name = "btn_add_supler";
            this.btn_add_supler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_add_supler.Size = new System.Drawing.Size(168, 42);
            this.btn_add_supler.TabIndex = 14;
            this.btn_add_supler.Text = "اضافة مورد جديد";
            this.btn_add_supler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_supler.UseVisualStyleBackColor = false;
            this.btn_add_supler.Click += new System.EventHandler(this.btn_add_supler_Click);
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
            // dgvSupler
            // 
            this.dgvSupler.AllowUserToAddRows = false;
            this.dgvSupler.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSupler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSupler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupler.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSupler.ColumnHeadersHeight = 40;
            this.dgvSupler.Location = new System.Drawing.Point(20, 56);
            this.dgvSupler.MultiSelect = false;
            this.dgvSupler.Name = "dgvSupler";
            this.dgvSupler.ReadOnly = true;
            this.dgvSupler.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSupler.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupler.Size = new System.Drawing.Size(910, 378);
            this.dgvSupler.TabIndex = 6;
            this.dgvSupler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupler_CellContentClick);
            this.dgvSupler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupler_CellDoubleClick);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(212, 15);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(589, 30);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(812, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "بحث عن بيانات مورد";
            // 
            // frm_suppList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(991, 481);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_suppList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة مورد";
            this.Activated += new System.EventHandler(this.frm_suppList_Activated);
            this.Load += new System.EventHandler(this.frm_suppList_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_add_supler;
        public System.Windows.Forms.DataGridView dgvSupler;
    }
}