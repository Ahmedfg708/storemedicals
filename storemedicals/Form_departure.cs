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

namespace storemedicals
{
    public partial class Form_departure : Form
    {
        Data.DataAccesLayer dal = new Data.DataAccesLayer();
        string user_name = "";


        public Form_departure()
        {
            InitializeComponent();
            getusaer();
            tim();
        }

        public void getusaer()
        {

            try
            {

                SqlCommand cmd = new SqlCommand("SELECT USER_NAME from USERES ", dal.con);
                dal.open();

                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    comboBox1.Items.Add(drd["USER_NAME"].ToString());
                }

                drd.Close();

                dal.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




        public void tim()
        {
            try
            {

                DateTime da = DateTime.Now;


                SqlCommand cmd = new SqlCommand("SELECT id as \"معرف\", name_em as \"الموظف\" , big_taem as \"الحضور\", end_tem as \"الانصراف\", totalhoer as \"عددالساعات\", dat as \"التاريخ\" FROM departure where dat = '" + da.ToString("yyyy-MM-dd") + "' ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem_dep.DataSource = tbl;

                dal.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void totalSumdgv()
        {

            try
            {
                if (dgvitem_dep.Rows.Count < 0)
                {
                    txt_total_fatora.Text = "0";
                }
                else
                {

                    txt_total_fatora.Text = (from DataGridViewRow row in dgvitem_dep.Rows
                                             where row.Cells[4].FormattedValue.ToString() != string.Empty
                                             select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();

                    string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(txt_total_fatora.Text));
                    txt_total_fatora.Text = formatted;



                }

            }
            catch { return; }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                user_name = "";
            }
            else
            {
                user_name = comboBox1.SelectedItem.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user_name == string.Empty)
            {
                MessageBox.Show("من فضلك حدد اسم الموظف");
                return;
            }

            //    getchakeadduser();

            //    if (chek_add_username_to_day != string.Empty)
            //  {
            //   MessageBox.Show("هذا الموظف تمة الحضور اليوم");
            //  return;
            //        }

            DateTime now = DateTime.Now;

            string en = "";



            try
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO departure VALUES ('" + user_name + "' , '" + now.ToString("hh:mm:ss tt") + "' , '" + en + "' , '" + Convert.ToString("0") + "', '" + now.ToString("yyyy-MM-dd") + "') ", dal.con);
                dal.open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("تسجيل الحضور " + now.ToString("hh:mm:ss tt"));

                dal.Close();

                tim();

                comboBox1.SelectedIndex = -1;
                user_name = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (user_name == string.Empty)
            {
                MessageBox.Show("من فضلك حدد اسم الموظف");
                return;
            }

            try
            {

                DateTime da = DateTime.Now;


                SqlCommand cmd = new SqlCommand("SELECT id as \"معرف\", name_em as \"الموظف\" , big_taem as \"الحضور\", end_tem as \"الانصراف\", totalhoer as \"عددالساعات\", dat as \"التاريخ\" FROM departure where dat between  '" + date_to.Value.ToString("yyyy-MM-dd") + "' AND '" + date_end.Value.ToString("yyyy-MM-dd") + "' AND name_em = '" + user_name + "' ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem_dep.DataSource = tbl;

                dal.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            totalSumdgv();
        }
    }
}
