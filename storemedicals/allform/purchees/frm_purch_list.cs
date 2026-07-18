using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals.allform.purchees
{
    public partial class frm_purch_list : Form
    {
        CLS.cls_purch_order ord = new CLS.cls_purch_order();
        public frm_purch_list()
        {
            InitializeComponent();
            fill_dgv();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_purch_list_Load(object sender, EventArgs e)
        {
            fill_dgv();
           
        }
        void fill_dgv() 
        {
            try 
            {
                this.dgv_pur_ord.DataSource = ord.load_data();
            }
            catch { return; }
        }

        private void dgv_pur_ord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                if (this.dgv_pur_ord.CurrentRow.Cells[8].Value.ToString() == "مضاف")
                {
                    MessageBox.Show("هذا الصنف تمت اضافة مسبقا  ؟", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                this.Close();
            }
            catch { return; }
        }

        private void dgv_pur_ord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgv_pur_ord.CurrentRow.Cells[8].Value.ToString() == "مضاف")
                {
                    MessageBox.Show("هذا الصنف تمت اضافة مسبقا  ؟", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     return;
                }
                this.Close();
            }
            catch { return; }  //مضاف
        }
    }
}
