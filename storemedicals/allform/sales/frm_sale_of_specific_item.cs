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

namespace storemedicals.allform.sales
{
    public partial class frm_sale_of_specific_item : Form
    {
        Data.DataAccesLayer dal = new Data.DataAccesLayer();
        string id_item = "";
        public frm_sale_of_specific_item()
        {
            InitializeComponent();
        }

        

        private void totalSumdgv()
        {
            try
            {
                if (dataGridView1.Rows.Count < 1)
                {
                    textB_Total.Text = "0";
                }
                else
                {

                    textB_Total.Text = (from DataGridViewRow row in dataGridView1.Rows
                                             where row.Cells[3].FormattedValue.ToString() != string.Empty
                                             select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();

                    string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(textB_Total.Text));
                    textB_Total.Text = formatted;

                }

            }
            catch { return; }

        }

        private void getdat()
        {
            try
            {
                //dat BETWEEN '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'

                SqlCommand cmd = new SqlCommand("select   f.ITEM_NAME_AR as \"اسم الصنف\" , f.ITEM_COUNT as \"الكميه\" , f.ITEM_PRIC as \"السعر\" , f.Amount as \"الاجمالي\" , o.ored_date as \"التاريخ\" from itemOrderDeail f join itemorder o on f.order_id = o.ored_id  where f.item_id = '" + id_item+"' and o.ored_date between '"+ dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' ORDER BY item_id   ASC ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dataGridView1.DataSource = tbl;

                dal.Close();

                totalSumdgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_item_Click(object sender, EventArgs e)
        {
            frm_itemList fm = new frm_itemList();
            fm.ShowDialog();
            try
            {

                id_item = fm.dgvitem.CurrentRow.Cells[0].Value.ToString();
                tex_Box_naem_item.Text = fm.dgvitem.CurrentRow.Cells[1].Value.ToString();

            }
            catch(Exception ex) {

                MessageBox.Show(ex.Message);
                
                return; 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(tex_Box_naem_item.Text == string.Empty)
            {
                MessageBox.Show("من فضلك حدد الصنف", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            getdat();
        }
    }
}
