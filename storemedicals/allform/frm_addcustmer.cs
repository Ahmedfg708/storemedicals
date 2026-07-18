using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals.allform
{
    public partial class frm_addcustmer : Form
    {
        CLS.cls_custmer cust = new CLS.cls_custmer();
        public string state = "add";

        public frm_addcustmer()
        {
            InitializeComponent();
            btn_add.Enabled = false;
            txt_name.Focus();

            try { txt_user.Text = Program.user_Name; }
            catch{ return; }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_id.Text.Trim() == string.Empty || txt_name.Text.Trim() == string.Empty || txt_mob.Text == string.Empty)
                {
                    MessageBox.Show("توجد حقول فارغة املا الحقول قبل الاضافة", "   تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            //==========================
                if (state == "add")
                {
                    if (pictureBox1.Image == null)
                    {
                        byte[] img;
                        img = new byte[0];
                        pictureBox1.Image = null;
                        cust.insert_custmer(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_mob.Text, txt_addres.Text,
                        txt_nation_num.Text, txt_email.Text, txt_company.Text, date_add.Value.ToString("yyyy-MM-dd"), img, txt_user.Text, "without_image");
                        MessageBox.Show("تم حفظ البيانات بنجاح", "  حفظ البيانات ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_add.Enabled = false;
                        btn_new.Enabled = true;
                        txt_addres.Text = txt_id.Text = txt_name.Text = txt_mob.Text = txt_nation_num.Text = txt_company.Text = txt_email.Text = "";

                    }
                    else
                    {
                        byte[] byteimg;
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        byteimg = ms.ToArray();
                        cust.insert_custmer(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_mob.Text, txt_addres.Text,
                        txt_nation_num.Text, txt_email.Text, txt_company.Text, date_add.Value.ToString("yyyy-MM-dd"), byteimg, txt_user.Text, "with_image");
                        MessageBox.Show("تم حفظ البيانات بنجاح", "  حفظ البيانات ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_add.Enabled = false;
                        btn_new.Enabled = true;
                        txt_addres.Text = txt_id.Text = txt_name.Text = txt_mob.Text = txt_nation_num.Text = txt_company.Text = txt_email.Text = "";
                    }
                
                }
            //=========================
                if (state == "update")
                {
                    if (pictureBox1.Image == null)
                    {
                        byte[] img;
                        img = new byte[0];
                        pictureBox1.Image = null;
                        cust.update_custmer(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_mob.Text, txt_addres.Text,
                        txt_nation_num.Text, txt_email.Text, txt_company.Text, date_add.Value.ToString("yyyy-MM-dd"), img, txt_user.Text, "without_image");
                        MessageBox.Show("تم عملية تعديل البيانات بنجاح", "  تعديل البيانات ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_add.Enabled = false;
                        btn_new.Enabled = true;
                        txt_addres.Text = txt_id.Text = txt_name.Text = txt_mob.Text = txt_nation_num.Text = txt_company.Text = txt_email.Text = "";
                        
                        this.Close();

                    }
                    else
                    {
                        byte[] byteimg;
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        byteimg = ms.ToArray();
                        cust.update_custmer(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_mob.Text, txt_addres.Text,
                        txt_nation_num.Text, txt_email.Text, txt_company.Text, date_add.Value.ToString("yyyy-MM-dd"), byteimg, txt_user.Text, "with_image");
                        MessageBox.Show("تم عملية تعديل البيانات بنجاح", "  تعديل البيانات ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_add.Enabled = false;
                        btn_new.Enabled = true;
                        txt_addres.Text = txt_id.Text = txt_name.Text = txt_mob.Text = txt_nation_num.Text = txt_company.Text = txt_email.Text = "";
                        this.Close();
                    }

                }

             }catch { return; }
            

        }
        private void frm_addcustmer_Load(object sender, EventArgs e)
        {

        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txt_nation_num.Focus(); }
        }

        private void txt_nation_num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txt_mob.Focus(); }
        }

        private void txt_mob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txt_addres.Focus(); }
        }

        private void txt_addres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txt_email.Focus(); }
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txt_company.Focus(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "chooes image  اختر صورة";
            op.FileName = "";
            op.Filter = " image |*.png;*.jpg;*.pmp;*.GIF;*.jepg;";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
            }

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try 
            {
                txt_id.Text = cust.GetMaxid().Rows[0][0].ToString();
                txt_name.Focus();
                btn_add.Enabled = true;
                btn_new.Enabled = false;

            }
            catch { return; }
        }

        private void txt_company_KeyDown(object sender, KeyEventArgs e)
        {
            //btn_add_Click(sender,e);
        }



    }
}
