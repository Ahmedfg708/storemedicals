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
    public partial class FormRep_PR : Form
    {
        public FormRep_PR()
        {
            InitializeComponent();
        }

        private void FormRep_PR_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
