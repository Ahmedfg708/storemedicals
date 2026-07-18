using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals.allform.item
{
    public partial class frm_company : Form
    {
        CLS.cls_company com = new CLS.cls_company();
        public frm_company()
        {
            InitializeComponent();
            txt_comp_name.Focus();
            fill_dgv_compny();
            

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_phon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txt_comp_name.Focus(); }
        }

        private void txt_comp_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txt_addres.Focus(); }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_itemid.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" لايمكن ترك رقم الصنف فارغ", "  حقل اجبارى", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //============================
                  try
                  {
                      for (int i = 0; i < this.dgv_company.Rows.Count; i++)
                      {
                          if (this.dgv_company.Rows[i].Cells["رقم الصنف"].Value.ToString() == txt_itemid.Text)
                          {
                              MessageBox.Show("رقم هذا الصنف قد اضيف لة بيانات شركة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                              txt_itemid.Text = string.Empty;
                              cleartxt();
                              return;
                          }
                      }

                  } catch { return; }            
               
            //============================
            try
            {
                com.insert_company(Convert.ToInt32(txt_itemid.Text), txt_comp_name.Text, txt_phon.Text, txt_addres.Text);
                MessageBox.Show(" تمت اضافة شركة للصنف بنجاح  ", "  تاكيد الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fill_dgv_compny();
                cleartxt();
            } catch { return; }

        }
//===============================================
        private void cleartxt()
        {
            txt_itemid.Text = txt_phon.Text = txt_comp_name.Text = txt_addres.Text = "";
        }

        private void txt_addres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btn_add_Click(sender, e); }
        }

        private void frm_company_Load(object sender, EventArgs e)
        {
           
           
           
        }

        public void fill_dgv_compny()
        {
            try
            {
                dgv_company.DataSource = com.GetAll_company();
            }
            catch { return; }
        }

        private void dgv_company_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            get_data();
        }

        public void get_data() 
        {
            try
            {
                txt_itemid.Text = dgv_company.CurrentRow.Cells[0].Value.ToString();
                txt_comp_name.Text = dgv_company.CurrentRow.Cells[1].Value.ToString();
                txt_phon.Text = dgv_company.CurrentRow.Cells[2].Value.ToString();
                txt_addres.Text = dgv_company.CurrentRow.Cells[3].Value.ToString();
            }
            catch { return; }
        }

        private void dgv_company_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            get_data();
        }

        private void dgv_company_SelectionChanged(object sender, EventArgs e)
        {
            //get_data();
        }

        private void btn_updet_Click(object sender, EventArgs e)
        {
            if (txt_itemid.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" لايمكن ترك رقم الصنف فارغ", "  حقل اجبارى", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                com.update_company(Convert.ToInt32(txt_itemid.Text), txt_comp_name.Text, txt_phon.Text, txt_addres.Text);
                MessageBox.Show(" تمت  عملية تعديل البيانات بنجاح  ", "  تاكيد الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fill_dgv_compny();
                cleartxt();

            }
            catch { return; }
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            //===============================
            if(txt_itemid.Text.Trim()==string.Empty)
            {
                  MessageBox.Show("  رقم الصنف غير موجود ؟ لااضافة شركة لة", " تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                  return;
            }
            //===========================
             
             DialogResult ms = MessageBox.Show("هل ريد حذف البيانات", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
             int id = Convert.ToInt32(txt_itemid.Text);
            //====================================
            if (dgv_company.Rows.Count > 0)
            {

                try
                {

                    if (ms == DialogResult.Yes)
                    {
                        com.delet_company(id);
                        MessageBox.Show("  تم حذف البيانات بنجاح", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        fill_dgv_compny();
                        cleartxt();
                    }
                    else
                    { fill_dgv_compny(); }
                   

                }
                catch { return;}
           }
            else
            {
                MessageBox.Show("لاتوجد بيانات للحذف", "تنبة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
    }
}
