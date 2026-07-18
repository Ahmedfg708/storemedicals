using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals.allform.sales
{
    public partial class frm_custList : Form
    {
        CLS.cls_custmer cust= new CLS.cls_custmer();
        public frm_custList()
        {
            InitializeComponent();
            load_data();
            txt_search.Focus();
            txt_search.Select();
            txt_search.SelectAll();
            
        }

        private void frm_custList_Load(object sender, EventArgs e)
        {
            load_data();
        }
        public void load_data()
        {
            try
            {
                this.dgv_cust.DataSource = cust.GetAll_cust();
                this.dgv_cust.Columns[8].Visible = false;
                this.dgv_cust.Columns[0].Width = 45;
                this.dgv_cust.Columns[2].Visible = false;
                this.dgv_cust.Columns[4].Visible = false;
                this.dgv_cust.Columns[5].Visible = false;
                this.dgv_cust.Columns[6].Visible = false;
            }
            catch { return; }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_addcustmer fm = new frm_addcustmer();
            load_data();
            fm.ShowDialog();
           
        }

        private void frm_custList_Activated(object sender, EventArgs e)
        {
            load_data();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search_custmer();
        }

        private void search_custmer()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = cust.search_All_cust(txt_search.Text);
                dgv_cust.DataSource = dt;
            }
            catch { return; }

        }

        private void dgv_cust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void dgv_cust_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        //==========================
        
    }
}
