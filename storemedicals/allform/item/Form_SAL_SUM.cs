using Microsoft.Reporting.WinForms;
using storemedicals.allform.REPORTITEM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals.allform.item
{
    public partial class Form_SAL_SUM : Form
    {

        Data.DataAccesLayer dal = new Data.DataAccesLayer();

        public Form_SAL_SUM()
        {
            InitializeComponent();

            foreach (DataGridViewColumn col in dgv_item.Columns)

            {

                col.DataPropertyName = col.Name.Replace("col_", "");

            }

            datad();
        }

        public void datad()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select ITEM_NAME_AR , ITEM_COUNT , ITEM_SAL , SUM (ITEM_SAL *ITEM_COUNT) AS 'total' from ITEMS GROUP BY ITEM_ID , ITEM_NAME_AR , ITEM_COUNT , ITEM_SAL ,ITEM_ID ORDER BY  ITEM_ID ASC ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgv_item.DataSource = tbl;


                dal.Close();
                // sumDataGrad();
                // totalSumdgv();
                totalSumdgvsum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void totalSumdgv()
        {
            double sum = 0.00; double vi = 0.00;
            for (int i = 0; i < dgv_item.Rows.Count; ++i)
            {
                 vi = Convert.ToDouble(dgv_item.Rows[i].Cells[3].Value) * Convert.ToDouble(dgv_item.Rows[i].Cells[1].Value);
                sum += vi;
            }
            txt_total_fatora.Text = sum.ToString();
            string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(txt_total_fatora.Text));
            txt_total_fatora.Text = formatted;
        }


        private void totalSumdgvsum()
        {
            try
            {
                if (dgv_item.Rows.Count < 1)
                {
                    txt_total_fatora.Text = "0";
                }
                else
                {

                    txt_total_fatora.Text = (from DataGridViewRow row in dgv_item.Rows
                                      where row.Cells[3].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();

                    string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(txt_total_fatora.Text));
                    txt_total_fatora.Text = formatted;

                   

                }

            }
            catch { return; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_item.Rows.Count < 1)
            {
                MessageBox.Show("لا يوجد بيانات الي الطباع", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }


            try
            {

                Form_REP_DATE_BETT fr = new Form_REP_DATE_BETT();
                // FormRep_PR frm = new FormRep_PR();

                ReportDataSource rds = new ReportDataSource("DataSet_GRD", dgv_item.DataSource);
                fr.reportViewer1.LocalReport.DataSources.Clear();
                fr.reportViewer1.LocalReport.DataSources.Add(rds);
                fr.reportViewer1.LocalReport.Refresh();

                fr.ShowDialog();






            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
