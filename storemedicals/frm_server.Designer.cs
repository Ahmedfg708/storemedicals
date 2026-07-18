namespace storemedicals
{
    partial class frm_server
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
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clos = new System.Windows.Forms.Button();
            this.rd_serv = new System.Windows.Forms.RadioButton();
            this.rd_win = new System.Windows.Forms.RadioButton();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_db = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(171, 367);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(107, 39);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "حفظ الاعدادات";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم السيرفر";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_clos);
            this.panel1.Controls.Add(this.rd_serv);
            this.panel1.Controls.Add(this.rd_win);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_db);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_server);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Location = new System.Drawing.Point(30, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 426);
            this.panel1.TabIndex = 3;
            // 
            // btn_clos
            // 
            this.btn_clos.BackColor = System.Drawing.Color.White;
            this.btn_clos.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clos.Location = new System.Drawing.Point(37, 366);
            this.btn_clos.Name = "btn_clos";
            this.btn_clos.Size = new System.Drawing.Size(108, 39);
            this.btn_clos.TabIndex = 12;
            this.btn_clos.Text = "الخروج";
            this.btn_clos.UseVisualStyleBackColor = false;
            this.btn_clos.Click += new System.EventHandler(this.button2_Click);
            // 
            // rd_serv
            // 
            this.rd_serv.AutoSize = true;
            this.rd_serv.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_serv.Location = new System.Drawing.Point(30, 180);
            this.rd_serv.Name = "rd_serv";
            this.rd_serv.Size = new System.Drawing.Size(233, 25);
            this.rd_serv.TabIndex = 11;
            this.rd_serv.Text = "SQL SERVER Authentication";
            this.rd_serv.UseVisualStyleBackColor = true;
            this.rd_serv.CheckedChanged += new System.EventHandler(this.rd_serv_CheckedChanged);
            // 
            // rd_win
            // 
            this.rd_win.AutoSize = true;
            this.rd_win.Checked = true;
            this.rd_win.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_win.Location = new System.Drawing.Point(64, 149);
            this.rd_win.Name = "rd_win";
            this.rd_win.Size = new System.Drawing.Size(199, 25);
            this.rd_win.TabIndex = 10;
            this.rd_win.TabStop = true;
            this.rd_win.Text = "Widowes Authentication";
            this.rd_win.UseVisualStyleBackColor = true;
            this.rd_win.CheckedChanged += new System.EventHandler(this.rd_win_CheckedChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(37, 309);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.ReadOnly = true;
            this.txt_pass.Size = new System.Drawing.Size(241, 30);
            this.txt_pass.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "كلمة المرور";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(37, 259);
            this.txt_user.Name = "txt_user";
            this.txt_user.ReadOnly = true;
            this.txt_user.Size = new System.Drawing.Size(241, 30);
            this.txt_user.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "اسم المستخدم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "طريقة الاتصال:";
            // 
            // txt_db
            // 
            this.txt_db.Location = new System.Drawing.Point(37, 88);
            this.txt_db.Name = "txt_db";
            this.txt_db.Size = new System.Drawing.Size(226, 30);
            this.txt_db.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "اسم قاعدة البيانات";
            // 
            // txt_server
            // 
            this.txt_server.Location = new System.Drawing.Point(37, 40);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(226, 30);
            this.txt_server.TabIndex = 0;
            // 
            // frm_server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(442, 464);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_server";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة اعدادا ت النظام";
            this.Load += new System.EventHandler(this.frm_server_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.RadioButton rd_serv;
        private System.Windows.Forms.RadioButton rd_win;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_db;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_clos;
    }
}