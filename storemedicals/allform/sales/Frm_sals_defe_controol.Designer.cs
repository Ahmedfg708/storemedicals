namespace storemedicals.allform.sales
{
    partial class Frm_sals_defe_controol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvitem_sho_ord = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem_sho_ord)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvitem_sho_ord
            // 
            this.dgvitem_sho_ord.AllowUserToAddRows = false;
            this.dgvitem_sho_ord.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvitem_sho_ord.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvitem_sho_ord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvitem_sho_ord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvitem_sho_ord.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvitem_sho_ord.ColumnHeadersHeight = 40;
            this.dgvitem_sho_ord.Location = new System.Drawing.Point(40, 17);
            this.dgvitem_sho_ord.MultiSelect = false;
            this.dgvitem_sho_ord.Name = "dgvitem_sho_ord";
            this.dgvitem_sho_ord.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvitem_sho_ord.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvitem_sho_ord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvitem_sho_ord.Size = new System.Drawing.Size(1063, 397);
            this.dgvitem_sho_ord.TabIndex = 51;
            this.dgvitem_sho_ord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitem_sho_ord_CellContentClick);
            this.dgvitem_sho_ord.SelectionChanged += new System.EventHandler(this.dgvitem_sho_ord_SelectionChanged);
            // 
            // Frm_sals_defe_controol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1142, 450);
            this.Controls.Add(this.dgvitem_sho_ord);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_sals_defe_controol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة تحكم فواتير المتأخرات";
            this.Load += new System.EventHandler(this.Frm_sals_defe_controol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem_sho_ord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvitem_sho_ord;
    }
}