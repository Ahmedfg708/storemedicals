using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals.allform.sales
{
    public partial class formMangaerEXP : Form
    {
        Data.DataAccesLayer dal = new Data.DataAccesLayer();
        public formMangaerEXP()
        {
            InitializeComponent();
            getexp();

        }

       public void getexp()
        {
            try
            {
                string st = "غير معالجه";
                SqlCommand cmd = new SqlCommand("SELECT id as \"معرف\" , on_nmber as \"رقم الفاتوره\" , typ_error as \"نوع المشكلة\" , how_fexet as \"معالجة المشكلة\" , useradd as \"المستخدم\" , dat as \"التاريخ\" , stat as \"الحالة\" from exception_eroor where stat = '"+ st + "'  ", dal.con);
                dal.open();

                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgv_EXP.DataSource = tbl;

                dal.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_EXP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_correction_in_saler f = new frm_correction_in_saler();

            int ID = Convert.ToInt32(this.dgv_EXP.CurrentRow.Cells[1].Value.ToString());

            f.getdata(Convert.ToString(ID));

            

            f.ShowDialog();
            getexp();
        }
    }
}
