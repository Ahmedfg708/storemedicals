using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals.allform.sales.report_saler
{
    public partial class Form_Reoprt_tab_deble_ALL : Form
    {
        public Form_Reoprt_tab_deble_ALL()
        {
            InitializeComponent();
        }

        private void Form_Reoprt_tab_deble_ALL_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
