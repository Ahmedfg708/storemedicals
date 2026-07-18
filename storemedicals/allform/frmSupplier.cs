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
    public partial class frmSupplier : Form
    {
        CLS.cls_supler sup = new CLS.cls_supler();
        public string state = "add";
        public frmSupplier()
        {
            InitializeComponent();

           
            btn_save.Enabled = false;
         
            txt_userAdd.Text = Program.user_Name;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try 
            {
                txtid.Text = sup.GetMaxid().Rows[0][0].ToString();
                btn_save.Enabled = true;
                btn_new.Enabled = false;

            }
            catch
            {
                return;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

          if(state=="add")
          {
               if(txtid.Text.Trim()==string.Empty || txt_name.Text.Trim()==string.Empty || txt_mobil.Text.Trim()==string.Empty
                || txt_company.Text.Trim()==string.Empty
                )
            {
                MessageBox.Show("لاتترك الحقول الاساسية فارغة ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
        //==================
            try
            {
                sup.Insert_Supler(Convert.ToInt32(txtid.Text), txt_name.Text, txt_mobil.Text,
                    txt_addres.Text, txt_company.Text, txt_not.Text, txt_national.Text, txt_userAdd.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                MessageBox.Show("تم اضافة بيانات المورد بنجاح", "تاكيد الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_save.Enabled = false;
                btn_new.Enabled = true;
                clear_txt();

            }
            catch
            {
                return;
            }

      }
      else if(state=="update")
      {
                sup.Update_Supler(Convert.ToInt32(txtid.Text), txt_name.Text, txt_mobil.Text,
                     txt_addres.Text, txt_company.Text, txt_not.Text, txt_national.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                MessageBox.Show("تم تعديل البيانات  بنجاح", "تاكيد التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_save.Enabled = false;
                btn_new.Enabled = true;
                clear_txt();
                this.Close();
               
            }
            
           
        }

        private void clear_txt()
        {
            txtid.Text = "";
            txt_name.Text = "";
            txt_mobil.Text = "";
            txt_addres.Text = "";
            txt_company.Text = "";
            txt_not.Text = "";
            txt_national.Text = "";
            dateTimePicker1.ResetText();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmSupplier_Activated(object sender, EventArgs e)
        {
            frmSuplerManger mg = new frmSuplerManger();
             mg.fill_dgv();
        }

        private void frmSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSuplerManger mg = new frmSuplerManger();
            mg.fill_dgv();
        }

        private void frmSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmSuplerManger mg = new frmSuplerManger();
            mg.fill_dgv();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {

        }
    }
}
