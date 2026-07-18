using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals.allform.sales
{
    public partial class form_Exception : Form
    {
        Data.DataAccesLayer dal = new Data.DataAccesLayer();
        string user_add = "";
        
        public form_Exception()
        {
            InitializeComponent();
            user_add = Program.user_Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tex_on_nmber.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" اضف رقم الفاتوره", " حقل اجبارى", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex_on_nmber.Focus();
                tex_on_nmber.SelectAll();
                return;
            }
            if(comb_name_eroo.SelectedIndex == -1)
            {
                MessageBox.Show(" اضف سبب المشكلة", " حقل اجبارى", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comb_name_eroo.Focus();
                comb_name_eroo.SelectAll();
                return;
            }
            if(listBo_typ_eroo.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" اضف كيف مالجو المشكلة", " حقل اجبارى", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBo_typ_eroo.Focus();
                listBo_typ_eroo.Select();
                return;
            }

            try
            {
                string stat = "غير معالجه";
                SqlCommand cmd = new SqlCommand("INSERT INTO exception_eroor VALUES ('"+ tex_on_nmber.Text+ "' , '"+comb_name_eroo.Text+"' , '"+ listBo_typ_eroo.Text + "' , '"+ user_add + "' , '"+ dateTimeP.Value.ToString("yyyy-MM-dd") + "' , '"+ stat + "' ) ", dal.con);
                dal.open();
                cmd.ExecuteNonQuery();
               
                MessageBox.Show(" تمت اضافة الصنف بنجاح  ");

                dal.Close();

                tex_on_nmber.Clear();
                comb_name_eroo.SelectedIndex = -1;
                listBo_typ_eroo.Clear();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void tex_on_nmber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
