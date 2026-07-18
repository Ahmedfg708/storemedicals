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
    public partial class frm_itemList : Form
    {
        CLS.cls_item item = new CLS.cls_item();

        public frm_itemList()
        {
            InitializeComponent();
            load_data();
            txt_search.Focus();
            txt_search.Select();
            txt_search.SelectAll();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //===============
        public void load_data()
        {
            try 
            {
                DataTable dt = new DataTable();
                dt = item.GetAll_item();
                dgvitem.DataSource = dt;
                dgvitem.Columns[4].Visible = false;
                dgvitem.Columns[2].Visible = false;

                dgvitem.Columns[10].Visible = false;
                dgvitem.Columns[9].Visible = false;
                dgvitem.Columns[6].Visible = false;
                dgvitem.Columns[7].Visible = false;
                dgvitem.Columns[8].Visible = false;
                dgvitem.Columns[0].Width = 80;

            }
            catch { return; }
            //==============
        
        }
        //===============
        private void search_item()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = item.search_All_item(txt_search.Text);
                dgvitem.DataSource = dt;
               
            }
            catch { return; }
            //==============

        }

        private void dgvitem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
            this.Close();
        }

        private void dgvitem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            this.Close();
        }

        private void frm_itemList_Activated(object sender, EventArgs e)
        {
           // load_data();
        }

        private void frm_itemList_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search_item();
        }
        
    }
}
