using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals.allform
{
    public partial class frm_Expenses : Form
    {
        Data.DataAccesLayer dal = new Data.DataAccesLayer();
        DataTable tblUse = new DataTable();

        char dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
        int id_exp = 0;
        string uetyp = "", wtim = "";

        public frm_Expenses()
        {
            InitializeComponent();
            txt_userAdd.Text = Program.user_Name;
            // getAllData();
            wtim = storemedicals.WOTIME.WTim;
            getAllDataDAY();
            getUsrTYP();
            uetyp = (string)tblUse.Rows[0][0];
        }

       public void getUsrTYP()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT USER_TYPE  FROM USERES WHERE USER_FULL_NAME = '"+ txt_userAdd.Text+ "' ", dal.con);
                dal.open();
              
               
                tblUse.Load(cmd.ExecuteReader());

                dal.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void getAllDataDAY()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT exp_id as \"الرقم\" , exp_name as \"اسم المنصرف\", exp_sale as \"المبلغ\" , exp_date as \"التاريخ\" , useradd as \"المستخدم\" , wtim as \"الدوام\" FROM expenses WHERE  exp_date = '" + dateTimePicker_expe.Value.ToString("yyyy-MM-dd") + "'", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem.DataSource = tbl;


                dal.Close();

                totalSumdgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getAllData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT exp_id as \"الرقم\" , exp_name as \"اسم المنصرف\", exp_sale as \"المبلغ\" , exp_date as \"التاريخ\" , useradd as \"المستخدم\" FROM expenses ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem.DataSource = tbl;


                dal.Close();

                totalSumdgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void totalSumdgv()
        {
            try
            {
                if (dgvitem.Rows.Count < 1)
                {
                    tex_Total.Text = "0";
                }
                else
                {

                    tex_Total.Text = (from DataGridViewRow row in dgvitem.Rows
                                      where row.Cells[2].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();

                    string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(tex_Total.Text));
                    tex_Total.Text = formatted;

                }

            }
            catch { return; }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tex_expe.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("من فضلك حدد اسم المنصرف");
                    tex_expe.Focus();
                    tex_expe.SelectAll();
                }
                else if (tex_salr_exp.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("من فضلك حدد المبلغ");
                    tex_salr_exp.Focus();
                    tex_salr_exp.SelectAll();

                }
                else
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO expenses VALUES ('" + tex_expe.Text + "','" + tex_salr_exp.Text + "','" + dateTimePicker_expe.Value.ToString("yyyy-MM-dd") + "','"+ txt_userAdd.Text+ "' , '"+ wtim + "' )", dal.con);
                    dal.open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تمة الحفظ");
                    dal.Close();
                    //   getAllData();
                    getAllDataDAY();
                    totalSumdgv();
                    tex_expe.Clear();
                    // item_custmer = "";
                    tex_salr_exp.Clear();
                    // id_rve = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("هل تريد الحذف", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (uetyp == "موظف")
                    {
                        MessageBox.Show("هذا المستخدم ليس لديه صلاحية الحذف", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("DELETE  expenses WHERE exp_id = '" + id_exp + "'", dal.con);
                        dal.open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("تمة الحذف");
                        dal.Close();
                        getAllData();
                        totalSumdgv();
                        tex_expe.Clear();
                        // item_custmer = "";
                        tex_salr_exp.Clear();
                        id_exp = 0;

                        btn_update.Enabled = false;
                        btn_delet.Enabled = false;
                        btn_save.Enabled = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_exp = Convert.ToInt32(dgvitem.CurrentRow.Cells[0].Value.ToString());
                tex_expe.Text = (dgvitem.CurrentRow.Cells[1].Value.ToString());
                tex_salr_exp.Text = (dgvitem.CurrentRow.Cells[2].Value.ToString());
                dateTimePicker_expe.Value = Convert.ToDateTime(dgvitem.CurrentRow.Cells[3].Value.ToString());

                btn_update.Enabled = true;
                btn_delet.Enabled = true;
                btn_save.Enabled = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد التعديل", "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (uetyp == "موظف")
                    {
                        MessageBox.Show("هذا المستخدم ليس لديه صلاحية التعديل", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    else
                    {

                        SqlCommand cmd = new SqlCommand("UPDATE  expenses SET exp_name='" + tex_expe.Text + "',exp_sale='" + tex_salr_exp.Text + "',exp_date = '" + dateTimePicker_expe.Value.ToString("yyyy-MM-dd") + "'  WHERE exp_id = '" + id_exp + "'", dal.con);
                        dal.open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("تمة التعديل");
                        dal.Close();
                        getAllData();
                        totalSumdgv();
                        tex_expe.Clear();
                        tex_salr_exp.Clear();
                        id_exp = 0;

                        btn_update.Enabled = false;
                        btn_delet.Enabled = false;
                        btn_save.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT exp_id as \"الرقم\" , exp_name as \"اسم المنصرف\", exp_sale as \"المبلغ\" , exp_date as \"التاريخ\" , useradd as \"اسم المستخدم\" , wtim as \"الدوام\" FROM expenses WHERE exp_name LIKE'%" + tex_sarch_expe.Text + "%' and exp_date='" + dat_search.Value.ToString("yyyy-MM-dd") + "' ", dal.con);

                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem.DataSource = tbl;

                dal.Close();
                totalSumdgv();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT exp_id as \"الرقم\" , exp_name as \"اسم المنصرف\", exp_sale as \"المبلغ\" , exp_date as \"التاريخ\" , useradd as \"اسم المستخدم\" , wtim as \"الدوام\" FROM expenses WHERE exp_name LIKE'%" + tex_sarch_expe.Text + "%' AND  exp_date BETWEEN '" + dat_search.Value.ToString("yyyy-MM-dd") + "' AND '"+ dateTimePicker2.Value.ToString("yyyy-MM-dd")+ "'", dal.con);

                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem.DataSource = tbl;

                dal.Close();
                totalSumdgv();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAllData();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tex_salr_exp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void tex_sarch_expe_TextChanged(object sender, EventArgs e)
        {
          
           
                button2_Click(sender, e);
          
            
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            btn_delet.Enabled = false;
            btn_update.Enabled = false;
        }
    }
}
