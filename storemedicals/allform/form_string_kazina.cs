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
    public partial class form_string_kazina : Form
    {

        string pass = "1963";

        public form_string_kazina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_pass_log.Text == pass)
            {
                frm_khzena fr = new frm_khzena();

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
