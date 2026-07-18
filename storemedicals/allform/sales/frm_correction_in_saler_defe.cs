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
using System.Web.Caching;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace storemedicals.allform.sales
{
    public partial class frm_correction_in_saler_defe : Form
    {

        Data.DataAccesLayer dal = new Data.DataAccesLayer();
       /* char dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
        DataTable dt = new DataTable();
        int qty = 0;
        int id = 0;
        string bar = "";
        string wti = "";
        string cach = "", bank = "", atm = "";
*/
        private void frm_correction_in_saler_defe_Load(object sender, EventArgs e)
        {

        }

        public frm_correction_in_saler_defe()
        {
            InitializeComponent();
        }

        public void getdata(string tex)
        {
            try //,m.ty_cach as \"كاش\",m.mo_cach as \"القيمه\" ,m.ty_bank as \"بنكك\" ,m.mo_bank as \"القيمه\",m.ty_atm as \"ATM\" ,m.mo_atm as\"القيمة\" ,f.pink as\"الدوام\"
            {
                SqlCommand cmd = new SqlCommand("SELECT id as \"المعرف\" , item_id as \"رقم الصنف\" , order_id as \"الفاتورة\", ITEM_NAME_AR as \"أسم الصنف\" , ITEM_COUNT as \"الكمية\" , ITEM_PRIC as \"السعر\", Amount as \"المبلغ\" , pink as \"الدوام\"  FROM itemOrderDeail WHERE order_id = '" + tex + "'", dal.con);

                SqlCommand cmd2 = new SqlCommand("SELECT order_id as \"رقم\", ty_cach as \"كاش\", mo_cach as \"القيمه\" , ty_bank as \"بنكك\" , mo_bank as \"القيمة\", ty_atm as \"ATM\" , mo_atm as\"القيمة\" , wtim as\"الدوام\" from typ_money WHERE order_id = '" + tex + "'", dal.con);

                dal.open();
                DataTable tbl = null; DataTable TDLMMO = null; TDLMMO = new DataTable();
                tbl = new DataTable();

                tbl.Load(cmd.ExecuteReader());

                TDLMMO.Load(cmd2.ExecuteReader());

                dgvitem.DataSource = tbl;

                dgvitem.Columns[0].Width = 50;
                dgvitem.Columns[1].Width = 50;
                dgvitem.Columns[2].Width = 50;
                dgvitem.Columns[3].Width = 150;
                dgvitem.Columns[4].Width = 80;
                dgvitem.Columns[5].Width = 80;

                dal.Close();

                totalSumdgv();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void totalSumdgv()
        {
            try
            {
                if (dgvitem.Rows.Count < 0)
                {
                    textBox1.Text = "0";
                }
                else
                {

                    textBox1.Text = (from DataGridViewRow row in dgvitem.Rows
                                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();


                    // string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(tex_Total.Text));
                    // tex_Total.Text = formatted;

                }

            }
            catch { return; }

        }



        private void claerTex()
        {
            txt_item_id.Clear();
            txt_order_id.Clear();
            txt_ITEM_NAME_AR.Clear();
            txt_ITEM_COUNT.Clear();
            txt_ITEM_PRIC.Clear();
            txt_Amount.Clear();
            txt_ITEM_COUNT.Text = "0";
            txt_ITEM_PRIC.Text = "0";
          
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

           

        }
    }
}
