using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace storemedicals.allform.sales
{
    public partial class Form_Order_Stp : Form
    {


        char dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
        DataTable dt = new DataTable();

        SqlConnection conn ;

        public Form_Order_Stp()
        {
            InitializeComponent();
            ConnData();
            txt_userAdd.Text = Program.user_Name;
            addData();
            txt_Branch.Text = "سامي المندري شرق النيل";


        }

        public void ConnData()
        {
            try
            {

                conn = new SqlConnection("Server=26.136.138.35;Database=MEDICAL_STORE;User Id=sa; Password=sagad;");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     
        public void idRan()
        {
            Random rad = new Random();
            int id = rad.Next();
            id_ordrand.Text = "3-"+Convert.ToString(id);
        }

        private void addData()
        {
            try
            {
                dt = new DataTable();
                dt.Columns.Add("رقم الصنف");
                dt.Columns.Add("اسم الصنف");
                dt.Columns.Add("الكمية");

                this.dgvitem_sal.DataSource = dt;
            }
            catch { return; }

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            idRan();

            btn_save.Enabled = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd0 = new SqlCommand("select id_order from itemorder_ORDER where id_order = '"+id_ordrand.Text+"' ", conn);
                conn.Open();

                DataTable tbl1 = new DataTable();

                tbl1.Load(cmd0.ExecuteReader());

                conn.Close();

                if(tbl1.Rows.Count > 0)
                {
                    MessageBox.Show("من فضلك اظغط علي زير جديد و اعد المحول من جديد", "خطاء ", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    return;
                }



                conn.Open();


            //     MessageBox.Show(conn.State.ToString());
              string exe = "قيد التنفيذ";

                 SqlCommand cmd = new SqlCommand("INSERT INTO itemorder_ORDER VALUES ('" + id_ordrand.Text + "','" + dateTimeP.Value.ToString("yyyy-MM-dd") + "','" + txt_userAdd.Text + "','" + txt_Branch.Text + "','" + exe + "' )",conn);

                cmd.ExecuteNonQuery();

                conn.Close();

               
                for (int i = 0; i < dgvitem_sal.Rows.Count; i++)
                {
                    
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO itemOrderDeail_Order VALUES ('" + id_ordrand.Text+"' , '"+ Convert.ToInt32( this.dgvitem_sal.Rows[i].Cells[0].Value.ToString()) + "' , '" + this.dgvitem_sal.Rows[i].Cells[1].Value.ToString() + "' , '"+Convert.ToInt32 (this.dgvitem_sal.Rows[i].Cells[2].Value.ToString()) + "' )", conn);
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("تم اضافة البيانات بنجاح", "تاكيد الحفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvitem_sal.DataSource = null;
                dt.Clear();
                btn_save.Enabled = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_item_Click(object sender, EventArgs e)
        {

            frm_itemList fm = new frm_itemList();
            fm.ShowDialog();
            try
            {

                txt_item_id.Text = fm.dgvitem.CurrentRow.Cells[0].Value.ToString();
                txt_item_nam.Text = fm.dgvitem.CurrentRow.Cells[1].Value.ToString();

                txt_qunty.Text = "0";
                //btn_add_item.Focus();

                txt_qunty.Focus();
                txt_qunty.Select();
                txt_qunty.SelectAll();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }

        private void txt_qunty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void txt_qunty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add_item_Click(sender, e);
            }
        }

        private void btn_add_item_Click(object sender, EventArgs e)
        {

            string searchValue = txt_item_nam.Text;
            int rowIndex = -1;
            foreach (DataGridViewRow roww in dgvitem_sal.Rows)
            {
                if (roww.Cells[1].Value.ToString().Equals(searchValue))
                {
                    rowIndex = roww.Index;
                    MessageBox.Show("خطاء في أسم الصنف لقد تمة اضافة في قائمة المبيعات", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_item_nam.Focus();
                    txt_item_nam.SelectAll();
                    return;
                }

            }

            if (txt_qunty.Text.Trim() == "0")
            {
                MessageBox.Show("خطاء لايمكن اضافة 0 في الكمية", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_qunty.Focus();
                txt_qunty.SelectAll();
                return;

            }
            if (txt_item_id.Text == string.Empty)
            {

                return;
            }


            DataRow row = dt.NewRow();
            row[0] = txt_item_id.Text;
            row[1] = txt_item_nam.Text;
            row[2] = txt_qunty.Text;


            dt.Rows.Add(row);
            this.dgvitem_sal.DataSource = dt;

            txt_item_id.Clear();
            txt_item_nam.Clear();
            txt_qunty.Clear();

        }

        private void حذفالسطرالمحددToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvitem_sal.Rows.Count < 1)
                {
                    return;
                }
                dgvitem_sal.Rows.RemoveAt(dgvitem_sal.CurrentRow.Index);
             
            }
            catch { return; }
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvitem_sal.Rows.Count < 1)
                {
                    return;
                }
                dt.Clear();
                dgvitem_sal.DataSource = null;
               
            }
            catch { return; }
        }

        private void dgvitem_sal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Rows.Count < 1
                if (dgvitem_sal.Rows.Count < 1)
                {
                    return;
                }
                txt_item_id.Text = this.dgvitem_sal.CurrentRow.Cells[0].Value.ToString();
                txt_item_nam.Text = this.dgvitem_sal.CurrentRow.Cells[1].Value.ToString();
                txt_qunty.Text = this.dgvitem_sal.CurrentRow.Cells[2].Value.ToString();
                dgvitem_sal.Rows.RemoveAt(dgvitem_sal.CurrentRow.Index);

            }
            catch { return; }



        }
    }
}
