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
    public partial class frm_khzena : Form
    {

        Data.DataAccesLayer dal = new Data.DataAccesLayer();
        char dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

        string item_custmer = "";
        string typ_money = "";
      
        int id_rve = 0;


        public frm_khzena()
        {
            InitializeComponent();

            data();
            getAllData();

        }

        public void data()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT CUST_NAME FROM CUSTMER WHERE CUST_ID BETWEEN 5 AND 8", dal.con);
                dal.open();

                SqlDataReader drd = cmd.ExecuteReader();

                while (drd.Read())
                {
                    com_Box_custmeer.Items.Add(drd["CUST_NAME"].ToString());
                    comb_serach.Items.Add(drd["CUST_NAME"].ToString());
                }

                drd.Close();
                dal.Close();
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
                //SELECT ITEM_NAME_AR, COUNT(*) العدد FROM itemOrderDeail GROUP BY ITEM_NAME_AR HAVING COUNT( ITEM_NAME_AR) >= 1 ORDER BY العدد DESC 
                // 
                SqlCommand cmd = new SqlCommand("SELECT rev_id as \"الرقم\" , rev_name as \"اسم المحل\", rev_salee as \"المبلغ\" , rev_date as \"التاريخ\" , typ_money as \"النوع\" FROM revenu", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem.DataSource = tbl;

                dgvitem.Columns[0].Width = 60;
                dgvitem.Columns[3].Width = 90;
                dgvitem.Columns[4].Width = 80;


                dal.Close();
                // sumDataGrad();
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


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
              //  if(com_Box_custmeer.SelectedIndex ==0 || com_Box_custmeer.SelectedIndex == -1)
               // {
                  //  MessageBox.Show("من فضلك حدد اسم المحل");
                  //  com_Box_custmeer.Focus();
                 //   com_Box_custmeer.SelectAll();
              //  }
                //else 

                 if (item_custmer.Trim() == string.Empty)
                {
                    MessageBox.Show("من فضلك حدد اسم المحل");
                    com_Box_custmeer.Focus();
                }
                else if (tex_salr.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("من فضلك حدد المبلغ");
                    tex_salr.Focus();
                    tex_salr.SelectAll();

                }
                else if (typ_money.ToString() == string.Empty)
                {
                    MessageBox.Show("من فضلك حدد نوع الكاش او بنكك او ATM");
                }
                else
                {
                    
                    SqlCommand cmd = new SqlCommand("INSERT INTO revenu VALUES ('" + item_custmer+"','"+ tex_salr.Text + "','"+ dateTimePicker_ver.Value.ToString("yyyy-MM-dd") + "','"+typ_money+"' )", dal.con);
                    dal.open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تمة الحفظ");
                    dal.Close();
                    getAllData();
                    totalSumdgv();
                    // com_Box_custmeer.SelectedIndex = 0;
                    com_Box_custmeer.Items.Clear();
                    comb_serach.Items.Clear();
                    data();
                    item_custmer = "";
                    typ_money = "";
                    tex_salr.Clear();
                    id_rve = 0;

                    rad_cash.Checked = false;
                    rad_bank.Checked = false;
                    rad_atm.Checked = false;

                    rad_cash_sh.Checked = false;
                    rad_bank_sh.Checked = false;
                    rad_atm_sh.Checked = false;
                }



            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  item_custmer = com_Box_custmeer.SelectedItem.ToString();
        }

        private void com_Box_custmeer_SelectedIndexChanged(object sender, EventArgs e)
        {

            item_custmer = com_Box_custmeer.SelectedItem.ToString();
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("هل تريد الحذف", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("DELETE  revenu WHERE rev_id = '" + id_rve + "'", dal.con);
                    dal.open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تمة الحذف");
                    dal.Close();
                    getAllData();
                    totalSumdgv();
                   

                    com_Box_custmeer.Items.Clear();
                    comb_serach.Items.Clear();
                    data();

                    item_custmer = "";
                    typ_money = "";
                    tex_salr.Clear();
                    id_rve = 0;

                    btn_update.Enabled = false;
                    btn_delet.Enabled = false;

                    rad_cash.Checked = false;
                    rad_bank.Checked = false;
                    rad_atm.Checked = false;

                    rad_cash_sh.Checked = false;
                    rad_bank_sh.Checked = false;
                    rad_atm_sh.Checked = false;
                }

            }
            catch(Exception ex)
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

                    SqlCommand cmd = new SqlCommand("UPDATE  revenu SET rev_name='"+item_custmer+"',rev_salee='"+tex_salr.Text+ "',rev_date = '"+ dateTimePicker_ver.Value.ToString("yyyy-MM-dd") + "' , typ_money = '"+typ_money+"'  WHERE rev_id = '" + id_rve + "'", dal.con);
                    dal.open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تمة التعديل");
                    dal.Close();
                    getAllData();
                    totalSumdgv();
                    // com_Box_custmeer.SelectedIndex = 0;

                    com_Box_custmeer.Items.Clear();
                    comb_serach.Items.Clear();
                    data();

                    item_custmer = "";
                    typ_money = "";
                    tex_salr.Clear();
                    id_rve = 0;
                    btn_update.Enabled = false;
                    btn_delet.Enabled = false;

                    rad_cash.Checked = false;
                    rad_bank.Checked = false;
                    rad_atm.Checked = false;

                    rad_cash_sh.Checked = false;
                    rad_bank_sh.Checked = false;
                    rad_atm_sh.Checked = false;

                }



                }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            item_custmer = "";

            com_Box_custmeer.Items.Clear();
            comb_serach.Items.Clear();
            data();

            tex_salr.Clear();
            rad_cash.Checked = false;
            rad_atm.Checked = false;
            rad_bank.Checked = false;

            rad_cash_sh.Checked = false;
            rad_bank_sh.Checked = false;
            rad_atm_sh.Checked = false;

            getAllData();

        }

        private void dgvitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rad_cash.Checked = false;
            rad_bank.Checked = false;
            rad_atm.Checked = false;

            rad_cash_sh.Checked = false;
            rad_bank_sh.Checked = false;
            rad_atm_sh.Checked = false;

            try
            {
                id_rve  = Convert.ToInt32(dgvitem.CurrentRow.Cells[0].Value.ToString());
                com_Box_custmeer.SelectedItem = (dgvitem.CurrentRow.Cells[1].Value.ToString());
                tex_salr.Text = (dgvitem.CurrentRow.Cells[2].Value.ToString());
                dateTimePicker_ver.Value = Convert.ToDateTime(dgvitem.CurrentRow.Cells[3].Value.ToString());

                typ_money = dgvitem.CurrentRow.Cells[4].Value.ToString();
                if (typ_money == "كاش")
                {
                    rad_cash.Checked = true;
                }
               else if (typ_money == "بنكك")
                {
                    rad_bank.Checked = true;
                }
               else if(typ_money == "ATM")
                {
                    rad_atm.Checked = true;
                }
                btn_update.Enabled = true;
                btn_delet.Enabled = true;



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
              //  if(comb_serach.SelectedIndex == 0)
              //  {
                  //  MessageBox.Show("لامكن البحث بدون زبون");
                  //  comb_serach.Focus();
                 //   comb_serach.SelectAll();
                 //   return;
               // }

                SqlCommand cmd = new SqlCommand("SELECT rev_id as \"الرقم\" , rev_name as \"اسم المحل\", rev_salee as \"المبلغ\" , rev_date as \"التاريخ\" , typ_money as \"النوع\" FROM revenu WHERE rev_name LIKE'%" + comb_serach.Text+ "%' and rev_date='"+dat_search.Value.ToString("yyyy-MM-dd")+"' ", dal.con);

                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem.DataSource = tbl;

                dal.Close();
                totalSumdgv();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAllData();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            try
            {
              //  if (comb_serach.SelectedIndex == 0 )
              //  {
                  //  MessageBox.Show("لامكن البحث بدون زبون");
                  //  comb_serach.Focus();
                 //   comb_serach.SelectAll();
                 //   return;
             //   }

                SqlCommand cmd = new SqlCommand("SELECT rev_id as \"الرقم\" , rev_name as \"اسم المحل\", rev_salee as \"المبلغ\" , rev_date as \"التاريخ\" , typ_money as \"النوع\" FROM revenu WHERE rev_name LIKE'%" + comb_serach.Text + "%' AND rev_date BETWEEN '" + dat_search.Value.ToString("yyyy-MM-dd") + "' AND '"+ dateTimePicker2.Value.ToString("yyyy-MM-dd")+ "'", dal.con);

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

        private void com_Box_custmeer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_khzena_Load(object sender, EventArgs e)
        {

        }

        private void tex_salr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void rad_cash_CheckedChanged(object sender, EventArgs e)
        {
            if(rad_cash.Checked)
            {
                typ_money = "كاش";
            }
        }

        private void rad_bank_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_bank.Checked)
            {
                typ_money = "بنكك";
            }
        }

        private void rad_atm_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_atm.Checked)
            {
                typ_money = "ATM";
            }
        }

        private void rad_cash_sh_CheckedChanged(object sender, EventArgs e)
        {
            string typm = "كاش";
             try
            {
               

                SqlCommand cmd = new SqlCommand("SELECT rev_id as \"الرقم\" , rev_name as \"اسم المحل\", rev_salee as \"المبلغ\" , rev_date as \"التاريخ\" , typ_money as \"النوع\" FROM revenu WHERE rev_name LIKE'%" + comb_serach.Text + "%' AND typ_money = '"+ typm + "'  AND  rev_date BETWEEN '" + dat_search.Value.ToString("yyyy-MM-dd") + "' AND '"+ dateTimePicker2.Value.ToString("yyyy-MM-dd")+ "'", dal.con);

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

        private void rad_bank_sh_CheckedChanged(object sender, EventArgs e)
        {
           
            string typm = "بنكك";
            try
            {
              

                SqlCommand cmd = new SqlCommand("SELECT rev_id as \"الرقم\" , rev_name as \"اسم المحل\", rev_salee as \"المبلغ\" , rev_date as \"التاريخ\" , typ_money as \"النوع\" FROM revenu WHERE rev_name LIKE'%" + comb_serach.Text + "%' AND typ_money = '" + typm + "'  AND  rev_date BETWEEN '" + dat_search.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'", dal.con);

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

        private void rad_atm_sh_CheckedChanged(object sender, EventArgs e)
        {
    
            string typm = "ATM";
            try
            {
             

                SqlCommand cmd = new SqlCommand("SELECT rev_id as \"الرقم\" , rev_name as \"اسم المحل\", rev_salee as \"المبلغ\" , rev_date as \"التاريخ\" , typ_money as \"النوع\" FROM revenu WHERE rev_name LIKE'%" + comb_serach.Text + "%' AND typ_money = '" + typm + "'  AND  rev_date BETWEEN '" + dat_search.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'", dal.con);

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

        private void dgvitem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 2 && e.RowIndex != this.dgvitem.NewRowIndex)
            {
                if(dgvitem.Rows[e.RowIndex].Cells[2].Value != null)
                {
                    double val1 = double.Parse(e.Value.ToString());
                    e.Value = val1.ToString("N2");

                }
            }
        }
    }
}
