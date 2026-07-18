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
    public partial class FormREPTYM_PIN : Form
    {
        public FormREPTYM_PIN()
        {
            InitializeComponent();
        }

        private void FormREPTYM_PIN_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
