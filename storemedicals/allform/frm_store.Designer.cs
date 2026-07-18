namespace storemedicals.allform
{
    partial class frm_store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_store));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txt_userAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_storeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mobil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.imageList1.Images.SetKeyName(6, "download.jpg");
            this.imageList1.Images.SetKeyName(7, "addproducts.ico");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(434, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "المستخدم";
            // 
            // txt_userAdd
            // 
            this.txt_userAdd.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userAdd.Location = new System.Drawing.Point(23, 149);
            this.txt_userAdd.Name = "txt_userAdd";
            this.txt_userAdd.ReadOnly = true;
            this.txt_userAdd.Size = new System.Drawing.Size(394, 32);
            this.txt_userAdd.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "اسم المخزن";
            // 
            // txt_storeName
            // 
            this.txt_storeName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_storeName.Location = new System.Drawing.Point(23, 62);
            this.txt_storeName.Name = "txt_storeName";
            this.txt_storeName.Size = new System.Drawing.Size(394, 32);
            this.txt_storeName.TabIndex = 1;
            this.txt_storeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_storeName_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "الموقع";
            // 
            // txt_mobil
            // 
            this.txt_mobil.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobil.Location = new System.Drawing.Point(23, 23);
            this.txt_mobil.Name = "txt_mobil";
            this.txt_mobil.Size = new System.Drawing.Size(227, 32);
            this.txt_mobil.TabIndex = 0;
            this.txt_mobil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mobil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mobil_KeyDown);
            this.txt_mobil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mobil_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "موبايل";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_location
            // 
            this.txt_location.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_location.Location = new System.Drawing.Point(23, 105);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(394, 32);
            this.txt_location.TabIndex = 5;
            this.txt_location.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_location_KeyDown);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(320, 22);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(97, 32);
            this.txtid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_userAdd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_storeName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_mobil);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_location);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.ForeColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(19, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 212);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم المخزن";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_new);
            this.panel2.Location = new System.Drawing.Point(19, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 68);
            this.panel2.TabIndex = 3;
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
            this.btn_exit.Size = new System.Drawing.Size(107, 37);
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
            this.btn_add.Location = new System.Drawing.Point(194, 16);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(130, 37);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "حفظ";
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
            this.btn_new.Location = new System.Drawing.Point(380, 16);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(106, 37);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "جديد";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // frm_store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(547, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_store";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة المخــــــــــــــزن";
            this.Load += new System.EventHandler(this.frm_store_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_new;
        public System.Windows.Forms.TextBox txt_userAdd;
        public System.Windows.Forms.TextBox txt_storeName;
        public System.Windows.Forms.TextBox txt_mobil;
        public System.Windows.Forms.TextBox txt_location;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.Panel panel1;
    }
}