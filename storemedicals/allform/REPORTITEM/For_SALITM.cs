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
    public partial class For_SALITM : Form
    {
        public For_SALITM()
        {
            InitializeComponent();
        }

        private void For_SALITM_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
