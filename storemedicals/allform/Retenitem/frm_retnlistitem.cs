using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals.allform.Retenitem
{
    public partial class frm_retnlistitem : Form
    {
        CLS.cls_reten clasreten = new CLS.cls_reten();
        public frm_retnlistitem()
        {
            InitializeComponent();
            load_data();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_retnlistitem_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void load_data()
        {
            try
            {
                this.dgv_sal_ord.DataSource = clasreten.selectAll_itemorder();
            }
            catch { return; }
        }

        private void dgv_sal_ord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search_itemfor_reten();
        }
    //===========================
        private void search_itemfor_reten()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = clasreten.search_all_retenItem(txt_search.Text);
                dgv_sal_ord.DataSource = dt;
            }
            catch { return; }
        }
   //==================================

    }
}
