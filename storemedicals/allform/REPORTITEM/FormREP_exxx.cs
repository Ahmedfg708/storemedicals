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
    public partial class FormREP_exxx : Form
    {
        public FormREP_exxx()
        {
            InitializeComponent();
        }

        private void FormREP_exxx_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
