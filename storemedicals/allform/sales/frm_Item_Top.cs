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
    public partial class frm_Item_Top : Form
    {
        Data.DataAccesLayer dal = new Data.DataAccesLayer();

        public frm_Item_Top()
        {
            InitializeComponent();
            getAllData();
        }

        public void getAllData()
        {
            try
            {
                //SELECT ITEM_NAME_AR, COUNT(*) العدد FROM itemOrderDeail GROUP BY ITEM_NAME_AR HAVING COUNT( ITEM_NAME_AR) >= 1 ORDER BY العدد DESC 
                // 
                SqlCommand cmd = new SqlCommand("SELECT ITEM_NAME_AR as \"أسم الصنف\", COUNT(*) العدد FROM itemOrderDeail GROUP BY ITEM_NAME_AR HAVING COUNT( ITEM_NAME_AR) >= 1 ORDER BY العدد DESC", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem.DataSource = tbl;

                dal.Close();
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
