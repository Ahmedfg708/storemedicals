namespace storemedicals.reportsprint
{
    partial class frm_printRep
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
            this.sup_print_oneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MEDICAL_STOREDataSet = new storemedicals.reportsprint.MEDICAL_STOREDataSet();
            this.sup_print_AllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sup_print_oneTableAdapter = new storemedicals.reportsprint.MEDICAL_STOREDataSetTableAdapters.sup_print_oneTableAdapter();
            this.sup_print_AllTableAdapter = new storemedicals.reportsprint.MEDICAL_STOREDataSetTableAdapters.sup_print_AllTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sup_print_oneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEDICAL_STOREDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sup_print_AllBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sup_print_oneBindingSource
            // 
            this.sup_print_oneBindingSource.DataMember = "sup_print_one";
            this.sup_print_oneBindingSource.DataSource = this.MEDICAL_STOREDataSet;
            // 
            // MEDICAL_STOREDataSet
            // 
            this.MEDICAL_STOREDataSet.DataSetName = "MEDICAL_STOREDataSet";
            this.MEDICAL_STOREDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sup_print_AllBindingSource
            // 
            this.sup_print_AllBindingSource.DataMember = "sup_print_All";
            this.sup_print_AllBindingSource.DataSource = this.MEDICAL_STOREDataSet;
            // 
            // sup_print_oneTableAdapter
            // 
            this.sup_print_oneTableAdapter.ClearBeforeFill = true;
            // 
            // sup_print_AllTableAdapter
            // 
            this.sup_print_AllTableAdapter.ClearBeforeFill = true;
            // 
            // frm_printRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 495);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_printRep";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_printRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sup_print_oneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEDICAL_STOREDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sup_print_AllBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

    //    public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.BindingSource sup_print_oneBindingSource;
        public MEDICAL_STOREDataSet MEDICAL_STOREDataSet;
        public MEDICAL_STOREDataSetTableAdapters.sup_print_oneTableAdapter sup_print_oneTableAdapter;
     //   public Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        public System.Windows.Forms.BindingSource sup_print_AllBindingSource;
        public MEDICAL_STOREDataSetTableAdapters.sup_print_AllTableAdapter sup_print_AllTableAdapter;

    }
}