using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals.allform.sales
{
    public partial class form_password : Form
    {
        string pass = "magad";
        public form_password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_pass_log.Text == "gadsa")
            {
                frm_correction_in_saler f = new frm_correction_in_saler();

                f.ShowDialog();

                this.Close();

            }


            else if (txt_pass_log.Text == pass)
            {
                formMangaerEXP fr = new formMangaerEXP();

                fr.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("تأكد من ادخال كلمة المرور صحيح");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
