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

namespace storemedicals.allform
{
    public partial class Form_test : Form
    {

        Data.DataAccesLayer dal = new Data.DataAccesLayer();

        public Form_test()
        {
            InitializeComponent();
        }

        public void test()
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT ", dal.con);

                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem.DataSource = tbl;

                dgvitem.Columns[0].Width = 80;
                dgvitem.Columns[1].Width = 80;
                dgvitem.Columns[3].Width = 100;
                dgvitem.Columns[4].Width = 100;
                dgvitem.Columns[5].Width = 100;

                dal.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
