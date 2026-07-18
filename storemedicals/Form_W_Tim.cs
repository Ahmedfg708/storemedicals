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
    public partial class Form_W_Tim : Form
    {
        public Form_W_Tim()
        {
            InitializeComponent();
        }

        private void Form_W_Tim_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_TYMO_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = comboBox_TYMO.Text;

            storemedicals.WOTIME.WTim = n;
            this.Close();

        }
    }
}
