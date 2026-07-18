using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals
{
    public partial class frmCatogry : Form
    {
        CLS.cls_catogry cat = new CLS.cls_catogry();
        public frmCatogry()
        {
            InitializeComponent();
            btn_save.Enabled = false;
            btn_update.Enabled = false;
            btn_delet.Enabled = false;
            Fill_dgv();
        }

        private void frmCatogry_Load(object sender, EventArgs e)
        {
            dgvcat.Focus();
            Fill_dgv();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            try 
            {
             txtid.Text = cat.GetMaxid().Rows[0][0].ToString();
             btn_new.Enabled = false;
             btn_save.Enabled = true;
             txtcatName.Focus();
            }
            catch
            {
                return;
            }
           


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txtcatName.Text.Trim()==string.Empty)
            {
              MessageBox.Show("يجب اضافة اسم المجموعة اولا","تنبية",MessageBoxButtons.OK,MessageBoxIcon.Information);
              return;
            }
            try
            {
                
                cat.InsertCatogry(Convert.ToInt32(txtid.Text),txtcatName.Text);
                MessageBox.Show("تم اضافة المجموعة بنجاح","تاكيد الحفظ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btn_save.Enabled = false;
                btn_new.Enabled = true;
                txtcatName.Clear();
                txtid.Clear();
                Fill_dgv();
            }
            catch {
            }
        }

        private void Fill_dgv()
        {
            dgvcat.DataSource = cat.GetAllcatogry();
        }

        private void dgvcat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                txtid.Text = dgvcat.CurrentRow.Cells[0].Value.ToString();
                txtcatName.Text = dgvcat.CurrentRow.Cells[1].Value.ToString();
            }
            catch 
            {
                return;
            }

        }

        private void txtcatName_TextChanged(object sender, EventArgs e)
        {
            if (txtcatName.Text.Trim() != string.Empty)
            {
                btn_delet.Enabled = true;
                btn_update.Enabled = true;
            }
          
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txtcatName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("ادخل اسم المجموعة اولا", "تنبة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcatName.SelectAll();
                txtcatName.Focus();
                return;
            }
            try 
            {
                int id = Convert.ToInt32(dgvcat.CurrentRow.Cells[0].Value.ToString());
                cat.CategoryUpdate(txtcatName.Text, id);
                MessageBox.Show(" تم تعديل اسم المجموعة بنجاح", "تنبة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_delet.Enabled = false;
                btn_update.Enabled = false;
                Fill_dgv();
                txtcatName.Clear();
                txtid.Clear();

            }
            catch 
            {
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcatName.Enabled = true;
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            if (txtcatName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("اختر اسم المجموعة اولا", "تنبة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcatName.SelectAll();
                txtcatName.Focus();
                return;
            }

            DialogResult ms = MessageBox.Show("هل ريد حذف البيانات", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            try 
            {
                int id = Convert.ToInt32(dgvcat.CurrentRow.Cells[0].Value.ToString());
                if (ms == DialogResult.Yes)
                {
                    cat.CategoryDelete(id);
                    MessageBox.Show("  تم حذف البيانات بنجاح", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    btn_delet.Enabled = false;
                    btn_update.Enabled = false;
                    txtcatName.Clear();
                    txtid.Clear();
                    Fill_dgv();
                }
                else { 
                    txtid.Clear();
                    txtcatName.Clear();
                    Fill_dgv();
                }
            
            }catch { }


        }

        private void dgvcat_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dgvcat_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtid.Text = dgvcat.CurrentRow.Cells[0].Value.ToString();
                txtcatName.Text = dgvcat.CurrentRow.Cells[1].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void dgvcat_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txtid.Text = dgvcat.CurrentRow.Cells[0].Value.ToString();
                txtcatName.Text = dgvcat.CurrentRow.Cells[1].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                DataTable dt = new DataTable();
                dt = cat.search_catogry(txt_search.Text);
                this.dgvcat.DataSource = dt;
                
            }
            catch { return; }
        }
    }
}
