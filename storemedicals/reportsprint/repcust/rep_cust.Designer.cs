namespace storemedicals.reportsprint.repcust
{
    partial class rep_cust
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
         //   Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
        //    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
          //  this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MEDICAL_STOREDataSetCustmer = new storemedicals.reportsprint.repcust.MEDICAL_STOREDataSetCustmer();
            this.print_on_custmerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.print_on_custmerTableAdapter = new storemedicals.reportsprint.repcust.MEDICAL_STOREDataSetCustmerTableAdapters.print_on_custmerTableAdapter();
          //  this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.print_All_custmerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.print_All_custmerTableAdapter = new storemedicals.reportsprint.repcust.MEDICAL_STOREDataSetCustmerTableAdapters.print_All_custmerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MEDICAL_STOREDataSetCustmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.print_on_custmerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.print_All_custmerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
          //  this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
        //    reportDataSource1.Name = "DataSet1";
         //   reportDataSource1.Value = this.print_on_custmerBindingSource;
         //   this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
       //     this.reportViewer1.LocalReport.ReportEmbeddedResource = "storemedicals.reportsprint.repcust.Report3.rdlc";
        //    this.reportViewer1.Location = new System.Drawing.Point(0, 0);
        //    this.reportViewer1.Name = "reportViewer1";
        //    this.reportViewer1.Size = new System.Drawing.Size(948, 414);
        //    this.reportViewer1.TabIndex = 0;
            // 
            // MEDICAL_STOREDataSetCustmer
            // 
            this.MEDICAL_STOREDataSetCustmer.DataSetName = "MEDICAL_STOREDataSetCustmer";
            this.MEDICAL_STOREDataSetCustmer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // print_on_custmerBindingSource
            // 
            this.print_on_custmerBindingSource.DataMember = "print_on_custmer";
            this.print_on_custmerBindingSource.DataSource = this.MEDICAL_STOREDataSetCustmer;
            // 
            // print_on_custmerTableAdapter
            // 
            this.print_on_custmerTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
         //   this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
        //    reportDataSource2.Name = "DataSet1";
        //    reportDataSource2.Value = this.print_All_custmerBindingSource;
        //    this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
          //  this.reportViewer2.LocalReport.ReportEmbeddedResource = "storemedicals.reportsprint.repcust.Report4.rdlc";
      //      this.reportViewer2.Location = new System.Drawing.Point(0, 0);
      //      this.reportViewer2.Name = "reportViewer2";
       //     this.reportViewer2.Size = new System.Drawing.Size(948, 414);
       //     this.reportViewer2.TabIndex = 1;
            // 
            // print_All_custmerBindingSource
            // 
            this.print_All_custmerBindingSource.DataMember = "print_All_custmer";
            this.print_All_custmerBindingSource.DataSource = this.MEDICAL_STOREDataSetCustmer;
            // 
            // print_All_custmerTableAdapter
            // 
            this.print_All_custmerTableAdapter.ClearBeforeFill = true;
            // 
            // rep_cust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 414);
          //  this.Controls.Add(this.reportViewer2);
         //   this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "rep_cust";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rep_cust";
            this.Load += new System.EventHandler(this.rep_cust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MEDICAL_STOREDataSetCustmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.print_on_custmerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.print_All_custmerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

      //  public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.BindingSource print_on_custmerBindingSource;
        public MEDICAL_STOREDataSetCustmer MEDICAL_STOREDataSetCustmer;
        public MEDICAL_STOREDataSetCustmerTableAdapters.print_on_custmerTableAdapter print_on_custmerTableAdapter;
    //    public Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        public System.Windows.Forms.BindingSource print_All_custmerBindingSource;
        public MEDICAL_STOREDataSetCustmerTableAdapters.print_All_custmerTableAdapter print_All_custmerTableAdapter;

    }
}