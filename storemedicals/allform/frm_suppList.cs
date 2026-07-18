using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals.allform
{
    public partial class frm_suppList : Form
    {
        CLS.cls_supler sup = new CLS.cls_supler();
        public frm_suppList()
        {
            InitializeComponent();
            fill_dgv();
        }

        private void frm_suppList_Load(object sender, EventArgs e)
        {
          
            dgvSupler.Columns[0].Width = 30;
            fill_dgv();
        }

        private void txt_search_TextChanged(object sender, System.EventArgs e)
        {

            try
            {
                DataTable dt = new DataTable();
                dt = sup.search_supler(txt_search.Text);
                this.dgvSupler.DataSource = dt;

            }
            catch { return; }
        }

        private void btn_exit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        //==============================
        public void fill_dgv()
        {
            try
            {
                dgvSupler.DataSource = sup.GetAll_Supler();
            }
            catch { return; }

        }
        private void btn_add_supler_Click(object sender, System.EventArgs e)
        {
            

                frmSupplier fm = new frmSupplier();
                fm.ShowDialog();
                fill_dgv();
           
          
        }

        private void dgvSupler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void dgvSupler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void frm_suppList_Activated(object sender, System.EventArgs e)
        {
            fill_dgv();
        }
    }
}
