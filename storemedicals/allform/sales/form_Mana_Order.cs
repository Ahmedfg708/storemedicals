using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace storemedicals.allform.sales
{
    public partial class form_Mana_Order : Form
    {

        SqlConnection conn;

        public form_Mana_Order()
        {
            InitializeComponent();
            ConnData();
            Show_AlData();
        }


        public void ConnData()
        {
            try
            {

                conn = new SqlConnection("Server=26.136.138.35;Database=MEDICAL_STORE;User Id=sa; Password=sagad;");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Show_AlData()
        {
            try
            {
                string exe = "قيد التنفيذ", bra = "أبن الهيثم";
                SqlCommand cmd0 = new SqlCommand("select id_order as \"رقم الطلب\" , dat_order as \"التارياخ\", user_add_order as \"أسم المستخدم\" , branch_order as \"أسم المحل\" , exp_order as \"حالة الطلب\" from itemorder_ORDER where exp_order = '" + exe + "' AND branch_order = '" + bra + "' ", conn);
                conn.Open();

                DataTable tbl1 = new DataTable();

                tbl1.Load(cmd0.ExecuteReader());

                dgvitem_sal.DataSource = tbl1;

                conn.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_sho_Click(object sender, EventArgs e)
        {
           

        }
    }
}
