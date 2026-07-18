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

namespace storemedicals.allform.item
{
    public partial class Form_updatequt : Form
    {
        Data.DataAccesLayer dal = new Data.DataAccesLayer();

        public int qu = 0;

        public Form_updatequt()
        {
            InitializeComponent();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                int quch = Convert.ToInt32(txtqtyt.Text);

                if (quch < qu)
                {
                    MessageBox.Show("لايمكن انقاص الكمة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand cmd1 = new SqlCommand("UPDATE  ITEMS SET  ITEM_COUNT = '" + Convert.ToInt32(txtqtyt.Text) + "'  where ITEM_ID = '" + Convert.ToInt32(txtidt.Text) + "' ", dal.con);

                dal.open();
                cmd1.ExecuteNonQuery();
                MessageBox.Show(" تمت تعديل الصنف بنجاح  ", "  تاكيد التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dal.Close();

                txtqtyt.Clear();
                txtidt.Clear();
                btn_add.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
