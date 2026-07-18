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
    public partial class frm_sting_serverLog : Form
    {
        public frm_sting_serverLog()
        {
            InitializeComponent();
        }
        string name = "bakery";

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_pass_log.Text==name)
            {
                frm_server fm = new frm_server();
                fm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("كلمة المرور خطا","تنبية",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
