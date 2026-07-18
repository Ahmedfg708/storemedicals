namespace storemedicals.allform.sales
{
    partial class frm_itemList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_itemList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvitem = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.imageList1.Images.SetKeyName(6, "print-icon.png");
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvitem);
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Controls.Add(this.btn_new);
            this.panel2.Location = new System.Drawing.Point(27, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 367);
            this.panel2.TabIndex = 9;
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
            this.dgvitem.Location = new System.Drawing.Point(20, 52);
            this.dgvitem.MultiSelect = false;
            this.dgvitem.Name = "dgvitem";
            this.dgvitem.ReadOnly = true;
            this.dgvitem.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvitem.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvitem.Size = new System.Drawing.Size(920, 297);
            this.dgvitem.TabIndex = 6;
            this.dgvitem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitem_CellContentClick);
            this.dgvitem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitem_CellDoubleClick);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(458, 16);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(390, 30);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_new.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.Image")));
            this.btn_new.Location = new System.Drawing.Point(854, 13);
            this.btn_new.Name = "btn_new";
            this.btn_new.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_new.Size = new System.Drawing.Size(86, 35);
            this.btn_new.TabIndex = 9;
            this.btn_new.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Location = new System.Drawing.Point(27, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 70);
            this.panel1.TabIndex = 8;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exit.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImageIndex = 0;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(17, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_exit.Size = new System.Drawing.Size(128, 42);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "خروج";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm_itemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1012, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_itemList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة تعرض قائمة الاصناف";
            this.Activated += new System.EventHandler(this.frm_itemList_Activated);
            this.Load += new System.EventHandler(this.frm_itemList_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_new;
        public System.Windows.Forms.DataGridView dgvitem;
    }
}