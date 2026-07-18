namespace storemedicals
{
    partial class FormRep_PR
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.itemOrderDeailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetORDER = new storemedicals.DataSetORDER();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.itemOrderDeailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetORDER)).BeginInit();
            this.SuspendLayout();
            // 
            // itemOrderDeailBindingSource
            // 
            this.itemOrderDeailBindingSource.DataMember = "itemOrderDeail";
            this.itemOrderDeailBindingSource.DataSource = this.DataSetORDER;
            // 
            // DataSetORDER
            // 
            this.DataSetORDER.DataSetName = "DataSetORDER";
            this.DataSetORDER.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetORDER";
            reportDataSource1.Value = this.itemOrderDeailBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "storemedicals.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(924, 508);
            this.reportViewer1.TabIndex = 0;
            // 
            // FormRep_PR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 508);
            this.Controls.Add(this.reportViewer1);
            this.MinimizeBox = false;
            this.Name = "FormRep_PR";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة تقرير مبيعات يومية";
            this.Load += new System.EventHandler(this.FormRep_PR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemOrderDeailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetORDER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource itemOrderDeailBindingSource;
        private DataSetORDER DataSetORDER;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}