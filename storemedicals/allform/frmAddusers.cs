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
    public partial class frmAddusers : Form
    {
        CLS.cls_user us = new CLS.cls_user();
        public  string state = "add";
        public frmAddusers()
        {
            InitializeComponent();
            btn_save.Enabled = false;
            btn_new.Focus();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try 
            {
              
                txtid.Text = us.GetMaxid().Rows[0][0].ToString();
                btn_save.Enabled = true;
                btn_new.Enabled = false;
                txt_name.Focus();

            }
            catch
            {
                return;
            }
        }

        private void txt_confirmpass_Validated(object sender, EventArgs e)
        {
            if(txt_pass.Text !=txt_confirmpass.Text)
            {
                MessageBox.Show("كلمة المرور غير متطابقة ؟", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              // txt_confirmpass.Focus();
            }
        }

        private void frmAddusers_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text != txt_confirmpass.Text)
            {
                MessageBox.Show("كلمة المرور غير متطابقة ؟", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_pass.Focus();
                return;
            }
            if(txt_name.Text==string.Empty)
            {
                MessageBox.Show("ادخل اسم المستخدم", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_name.Focus();
                return;
            }
            if(txt_pass.Text==string.Empty)
            {
                MessageBox.Show("ادخل كلمة المرور", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_name.Focus();
                return;
            }
            if (txt_confirmpass.Text == string.Empty)
            {
                MessageBox.Show("ادخل اتاكيد كلمة المرور", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_confirmpass.Focus();
                return;
            }
            if (comb_type.SelectedIndex==-1)
            {
                MessageBox.Show("اختر نوع المستخدم اولا", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comb_type.Focus();
                return;
            }
            if (txt_fullname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("ادخل الاسم الكامل للمستخدم", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_fullname.Focus();
                return;
            }
            if (comBoxPink.SelectedIndex == -1)
            {
                MessageBox.Show("اختر نوع الدوام اولا", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comb_type.Focus();
                return;
            }

            try
            {


                if(state=="add")
                {
                    DataTable user_name = new DataTable();
                    user_name = us.cheack_Userame(txt_name.Text);
                    if (user_name.Rows.Count>0)
                    {
                        MessageBox.Show("اسم المستخدم موجود مسبقا جرب اسم اخر","تنبية",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }
               //=============تشفير كلمة المرور 
                    string ps = us.hashPassword(txt_pass.Text);
               //==============txt_pass.Text
                    us.InsertUser(Convert.ToInt32(txtid.Text), txt_name.Text, txt_pass.Text,
                comb_type.Text, txt_mobial.Text, txt_fullname.Text, Convert.ToBoolean(txt_activ.Text), date_user.Value.ToString("yyyy-MM-dd"), comBoxPink.Text);
                MessageBox.Show("تم اضافة المستخدم بنجاح", "تاكيد الحفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_name.Text = txt_pass.Text = txt_confirmpass.Text = txt_fullname.Text = txt_mobial.Text = txtid.Text = "";
                comb_type.SelectedIndex = -1;
                btn_new.Enabled = true;
                btn_save.Enabled = false;
                }
                
              if(state=="update")
                {
                    string pas = us.hashPassword(txt_pass.Text);
                    int id = Convert.ToInt32(this.txtid.Text);
                    us.Update_User(txt_name.Text, txt_pass.Text,
                    comb_type.Text, txt_mobial.Text, txt_fullname.Text, Convert.ToBoolean(txt_activ.Text), date_user.Value.ToString("yyyy-MM-dd"), comBoxPink.Text, id);

                    MessageBox.Show("تم تعديل بيانات المستخدم بنجاح", "تاكيد التعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_name.Text = txt_pass.Text = txt_confirmpass.Text = txt_fullname.Text = txt_mobial.Text = txtid.Text = "";
                    comb_type.SelectedIndex = -1;
                    btn_new.Enabled = true;
                    btn_save.Enabled = false;
                    this.Close();
                }
            }

            catch
            {
                return;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txt_activ.Text = "True";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_activ.Text = "False";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_activ.Text = "True";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_activ.Text = "False";
        }
    }
}
