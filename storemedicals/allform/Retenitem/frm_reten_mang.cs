using storemedicals.allform.Reten;
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
    public partial class frm_reten_mang : Form
    {
        CLS.cls_reten clas_reten = new CLS.cls_reten();
        public frm_reten_mang()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_reten_mang_Load(object sender, EventArgs e)
        {
            fill_dgv();
        }

        private void fill_dgv()
        {
            try 
            {
               
                 this.dgvReten.DataSource = clas_reten.selectAll_reten();
                 dgvReten.Columns[2].Visible=false;
                 dgvReten.Columns[7].Visible = false;
                 dgvReten.Columns[8].Visible=false;
                 dgvReten.Columns[10].Visible=false;
            
            }
            catch { return; }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_reten fm = new frm_reten();
            fm.ShowDialog();
            fill_dgv();
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            frm_reten fm = new frm_reten();
            ;
            try
            {
                if (dgvReten.Rows.Count > 0)
                { 
                   fm.state = "update";
                   fm.Text = "تعديل";
                   fm.btn_new.Visible = false;
                   fm.btn_add.Enabled = true;
                   fm.btn_add.Text = "تعديل";
                   fm.btn_add.Location = new Point(300, 10);
                   fm.btn_add.ImageIndex = 5;
                   fm.btn_item_list.Enabled = true;

                   fm.txt_retn_id.Text = this.dgvReten.CurrentRow.Cells[0].Value.ToString();
                   fm.txt_order_id.Text = this.dgvReten.CurrentRow.Cells[1].Value.ToString();
                   fm.txt_barcod.Text = this.dgvReten.CurrentRow.Cells[2].Value.ToString();
                   fm.txt_item_name.Text = this.dgvReten.CurrentRow.Cells[3].Value.ToString();
                   fm.txt_pric.Text = this.dgvReten.CurrentRow.Cells[4].Value.ToString();
                   fm.txtqty.Text = this.dgvReten.CurrentRow.Cells[5].Value.ToString();
                   fm.txt_tot_amount.Text = this.dgvReten.CurrentRow.Cells[6].Value.ToString();
                   fm.date_reten.Text = this.dgvReten.CurrentRow.Cells[7].Value.ToString();
                    fm.txt_userAdd.Text = this.dgvReten.CurrentRow.Cells[8].Value.ToString();
                   fm.txt_stat_id.Text = this.dgvReten.CurrentRow.Cells[9].Value.ToString();
                   fm.txt_not.Text = this.dgvReten.CurrentRow.Cells[10].Value.ToString();
                   fm.txt_item_id.Text = this.dgvReten.CurrentRow.Cells[11].Value.ToString();
                   fm.calclaAmount();
                   fm.ShowDialog();
                   fill_dgv();
                }
                

            }
            catch { return; }
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
           
            if (dgvReten.Rows.Count > 0)
            {

                try
                {

                    if (MessageBox.Show("هل تريد حذف البيانات", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(this.dgvReten.CurrentRow.Cells[0].Value.ToString());
                        clas_reten.Delete_RetenItem(id);
                        MessageBox.Show("  تم حذف البيانات بنجاح", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        fill_dgv();

                    } else { fill_dgv(); }


                } catch { }
            }
            else
            {
                MessageBox.Show("لاتوجد بيانات للحذف", "تنبة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search_reten();
        }

        private void search_reten()
        {
            try 
            {
                DataTable dt = new DataTable();
                dt=clas_reten.search_RetnitemBydgv(txt_search.Text);
                dgvReten.DataSource = dt;
            }
            catch { return; }
        }

        private void btn_retenItem_Click(object sender, EventArgs e)
        {
           
            frm_reten fm = new frm_reten();
            
            try
            {
                if (dgvReten.Rows.Count > 0)
                {
                   

                    fm.state = "prov";
                    fm.Text = "معاينة لارجاع الصنف";
                    fm.btn_new.Visible = false;
                    fm.btn_add.Enabled = true;
                    fm.btn_add.Text = "ارجاع الصنف";
                    fm.btn_add.Location = new Point(300, 10);
                    fm.btn_add.ImageIndex = 5;
                    fm.btn_item_list.Visible = false;

                    fm.txt_retn_id.Text = this.dgvReten.CurrentRow.Cells[0].Value.ToString();
                    fm.txt_order_id.Text = this.dgvReten.CurrentRow.Cells[1].Value.ToString();
                    fm.txt_barcod.Text = this.dgvReten.CurrentRow.Cells[2].Value.ToString();
                    fm.txt_item_name.Text = this.dgvReten.CurrentRow.Cells[3].Value.ToString();
                    fm.txt_pric.Text = this.dgvReten.CurrentRow.Cells[4].Value.ToString();
                    fm.txtqty.Text = this.dgvReten.CurrentRow.Cells[5].Value.ToString();
                    fm.txt_tot_amount.Text = this.dgvReten.CurrentRow.Cells[6].Value.ToString();
                    fm.date_reten.Text = this.dgvReten.CurrentRow.Cells[7].Value.ToString();
                    fm.txt_userAdd.Text = this.dgvReten.CurrentRow.Cells[8].Value.ToString();
                    fm.txt_stat_id.Text = this.dgvReten.CurrentRow.Cells[9].Value.ToString();
                    fm.txt_not.Text = this.dgvReten.CurrentRow.Cells[10].Value.ToString();
                    fm.txt_item_id.Text = this.dgvReten.CurrentRow.Cells[11].Value.ToString();
                    fm.calclaAmount();

                    if (this.dgvReten.CurrentRow.Cells[9].Value.ToString() == "تم الارجاع")
                    {
                        MessageBox.Show(" هذا الصنف تم ارجاعة من قبل  ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    fm.ShowDialog();
                    fill_dgv();
                }


            }
            catch { return; }

        }
    }
}
