using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals.reportsprint
{
    public partial class frm_printRep : Form
    {
        public frm_printRep()
        {
            InitializeComponent();
        }

        private void frm_printRep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MEDICAL_STOREDataSet.sup_print_All' table. You can move, or remove it, as needed.
            this.sup_print_AllTableAdapter.Fill(this.MEDICAL_STOREDataSet.sup_print_All);
            // TODO: This line of code loads data into the 'MEDICAL_STOREDataSet.sup_print_one' table. You can move, or remove it, as needed.
            //this.sup_print_oneTableAdapter.Fill(this.MEDICAL_STOREDataSet.sup_print_one);

            //this.reportViewer1.RefreshReport();
        }
    }
}
