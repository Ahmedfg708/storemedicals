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
    public partial class frm_store : Form
    {
        CLS.cls_store stor = new CLS.cls_store();
        public string state = "add";
        public frm_store()
        {
            InitializeComponent();
            txt_userAdd.Text = Program.user_Name;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_mobil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_mobil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_storeName.Focus();
            }
        }

        private void txt_storeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_location.Focus();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(state=="add")
            {
                if(txtid.Text.Trim()==string.Empty)
                {
                MessageBox.Show("اضف رقم المخزن اولا", " حقل اجبارى ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtid.Focus();
                return;
                }

               if(txt_storeName.Text.Trim()==string.Empty)
                {
                MessageBox.Show("اضف اسم المخزن اولا", " حقل اجبارى ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_storeName.Focus();
                return;
                }
           //===========================
             try
            {
                stor.Insert_store(Convert.ToInt32(txtid.Text), txt_storeName.Text, txt_location.Text, txt_mobil.Text, txt_userAdd.Text);

                 MessageBox.Show("تمت اضافة البيانات بنجاح", "  حفظ البيانات ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtid.Text=txt_storeName.Text=txt_mobil.Text=txt_location.Text="";

                btn_add.Enabled=false;
                btn_new.Enabled=true;
            }
            catch { return; }

            }

            else if (state == "update")
            {
                stor.update_store(Convert.ToInt32(txtid.Text),txt_storeName.Text,txt_location.Text,txt_mobil.Text);
                MessageBox.Show("تم تعديل البيانات  بنجاح", "تاكيد التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_add.Enabled = false;
                btn_new.Enabled = true;
                txtid.Text = txt_storeName.Text = txt_location.Text = txt_mobil.Text = "";
                this.Close();
            }
        //=============================================
           
           
        //=================================
        }

        private void txt_location_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.Focus();
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try 
            {
                txtid.Text = stor.GetMaxid().Rows[0][0].ToString();
                btn_new.Enabled = false;
                btn_add.Enabled = true;
            
            }
           catch { return; }

        }

        private void frm_store_Load(object sender, EventArgs e)
        {

        }
    }
}
