namespace storemedicals.allform.item
{
    partial class Form_SAL_SUM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.col_ITEM_NAME_AR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ITEM_COUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ITEM_SAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_total_fatora = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_item
            // 
            this.dgv_item.AllowUserToAddRows = false;
            this.dgv_item.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_item.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_item.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_item.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_item.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_item.ColumnHeadersHeight = 40;
            this.dgv_item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ITEM_NAME_AR,
            this.col_ITEM_COUNT,
            this.col_ITEM_SAL,
            this.col_total});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_item.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_item.Location = new System.Drawing.Point(10, 10);
            this.dgv_item.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_item.MultiSelect = false;
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.ReadOnly = true;
            this.dgv_item.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_item.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_item.Size = new System.Drawing.Size(802, 359);
            this.dgv_item.TabIndex = 8;
            // 
            // col_ITEM_NAME_AR
            // 
            this.col_ITEM_NAME_AR.HeaderText = "اسم الصنف";
            this.col_ITEM_NAME_AR.Name = "col_ITEM_NAME_AR";
            this.col_ITEM_NAME_AR.ReadOnly = true;
            // 
            // col_ITEM_COUNT
            // 
            this.col_ITEM_COUNT.HeaderText = "الكمية";
            this.col_ITEM_COUNT.Name = "col_ITEM_COUNT";
            this.col_ITEM_COUNT.ReadOnly = true;
            // 
            // col_ITEM_SAL
            // 
            this.col_ITEM_SAL.HeaderText = "السعر";
            this.col_ITEM_SAL.Name = "col_ITEM_SAL";
            this.col_ITEM_SAL.ReadOnly = true;
            // 
            // col_total
            // 
            this.col_total.HeaderText = "الاجمالي";
            this.col_total.Name = "col_total";
            this.col_total.ReadOnly = true;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(520, 401);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 31);
            this.label16.TabIndex = 56;
            this.label16.Text = "اجمالى :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_total_fatora
            // 
            this.txt_total_fatora.BackColor = System.Drawing.Color.White;
            this.txt_total_fatora.Enabled = false;
            this.txt_total_fatora.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_fatora.Location = new System.Drawing.Point(608, 400);
            this.txt_total_fatora.Name = "txt_total_fatora";
            this.txt_total_fatora.ReadOnly = true;
            this.txt_total_fatora.Size = new System.Drawing.Size(202, 32);
            this.txt_total_fatora.TabIndex = 55;
            this.txt_total_fatora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::storemedicals.Properties.Resources.icons_Print;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(20, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 57);
            this.button1.TabIndex = 57;
            this.button1.Text = "طباعة";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_SAL_SUM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_total_fatora);
            this.Controls.Add(this.dgv_item);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_SAL_SUM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة اجمالي المخزان";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_item;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txt_total_fatora;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ITEM_NAME_AR;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ITEM_COUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ITEM_SAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total;
        private System.Windows.Forms.Button button1;
    }
}