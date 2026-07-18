using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals.allform.REPORTITEM
{
    public partial class Form_REP_DATE_BETT : Form
    {
        public Form_REP_DATE_BETT()
        {
            InitializeComponent();
        }

        private void Form_REP_DATE_BETT_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
