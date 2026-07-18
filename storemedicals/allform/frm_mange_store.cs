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
    public partial class frm_mange_store : Form
    {
        CLS.cls_store str = new CLS.cls_store();
        public frm_mange_store()
        {
            InitializeComponent();
            load_data();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_store stor = new frm_store();
            stor.ShowDialog();
            load_data();
        }

        private void load_data()
        {
            try
            {
                dgv_stor.DataSource = str.Get_store();

            }
            catch { return; }
        }

        private void frm_mange_store_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void frm_mange_store_Activated(object sender, EventArgs e)
        {
            load_data();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            frm_store fm = new frm_store();
            if (dgv_stor.Rows.Count > 0) 
            {
                try
                {
                    fm.Text = "تعديل بيانات المخزن";
                    fm.btn_new.Visible = false;
                    fm.btn_add.Text = "تعديل";
                    fm.btn_add.ImageIndex = 5;
                    fm.btn_add.Enabled = true;
                    fm.btn_add.Location = new Point(380,16);
                    fm.state = "update";

                    fm.txtid.Text = dgv_stor.CurrentRow.Cells[0].Value.ToString();
                    fm.txt_storeName.Text = dgv_stor.CurrentRow.Cells[1].Value.ToString();
                    fm.txt_location.Text = dgv_stor.CurrentRow.Cells[2].Value.ToString();
                    fm.txt_mobil.Text = dgv_stor.CurrentRow.Cells[3].Value.ToString();
                    fm.ShowDialog();
                    load_data();
                }
                catch { return; }
            }

            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_stor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_delet.Enabled = true;
        }

        private void dgv_stor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_update.Enabled = true;
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgv_stor.CurrentRow.Cells[0].Value.ToString());
            DialogResult ms = MessageBox.Show("هل ريد حذف البيانات", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dgv_stor.Rows.Count > 0)
            {

                try
                {

                    if (ms == DialogResult.Yes)
                    {
                        str.delet_store(id);
                        MessageBox.Show("  تم حذف البيانات بنجاح", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        btn_delet.Enabled = false;
                        btn_update.Enabled = false;
                        load_data();
                    }
                    else { load_data(); }


                }
                catch { return; }

            }

        }

        private void dgv_stor_MouseClick(object sender, MouseEventArgs e)
        {
            btn_update.Enabled = true;
            btn_delet.Enabled = true;
        }

        private void dgv_stor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btn_update.Enabled = true;
            btn_delet.Enabled = true;
        }
    }
}
