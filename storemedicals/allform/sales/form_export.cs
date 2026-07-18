using Microsoft.Reporting.WinForms;
using storemedicals.allform.REPORTITEM;
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

namespace storemedicals.allform.sales
{
    public partial class form_export : Form
    {

        Data.DataAccesLayer dal = new Data.DataAccesLayer();
        char dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
        string wtim = "";
        int qu = 0, idit = 0;

        public form_export()
        {
            InitializeComponent();

            foreach (DataGridViewColumn col in dataGridView1.Columns)

            {

                col.DataPropertyName = col.Name.Replace("col_", "");

            }

            wtim = storemedicals.WOTIME.WTim;
            tex_useradd.Text = Program.user_Name;

            getaddToDay();
        }

        public void cler_Text()
        {
            tex_item.Clear();
            tex_pris.Clear();
            tex_qua.Clear();
            tex_total.Clear();
            comB_shop.SelectedIndex = -1;
            idit = 0;
            qu = 0;

        }

        public void getaddToDay()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT id , shop_name , item_name  , price , quantiy  , dat  , user_add , total  , tim , name_s  FROM export WHERE dat = '" + dateTP.Value.ToString("yyyy-MM-dd") + "'", dal.con);
                dal.open();
                DataTable TDLMMO = new DataTable();
                TDLMMO.Load(cmd.ExecuteReader());

                dataGridView1.DataSource = TDLMMO;

                dal.Close();

                totalSumdgv();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pdatItem()
        {
            try
            {
                string contt = "";

                SqlCommand cmd1 = new SqlCommand("SELECT ITEM_COUNT FROM ITEMS WHERE item_id = '" + Convert.ToInt32(idit) + "'", dal.con);
                dal.open();
                SqlDataReader drd = cmd1.ExecuteReader();

                while (drd.Read())
                {
                    contt = drd["ITEM_COUNT"].ToString();

                }

                dal.Close();

                if (contt != string.Empty && contt != "0")
                {

                    int to = Convert.ToInt32(contt) - Convert.ToInt32(tex_qua.Text);


                    SqlCommand cmd = new SqlCommand("UPDATE  ITEMS SET ITEM_COUNT='" + Convert.ToInt32(to) + "'WHERE item_id = '" + Convert.ToInt32(idit) + "'", dal.con);
                    dal.open();
                    cmd.ExecuteNonQuery();

                    dal.Close();
                }
                else
                {
                    MessageBox.Show("يوجد خطاء");
                }

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
                if (dataGridView1.Rows.Count < 1)
                {
                    textotal.Text = "0";
                }
                else
                {

                    textotal.Text = (from DataGridViewRow row in dataGridView1.Rows
                                      where row.Cells[7].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();

                    string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(textotal.Text));
                    textotal.Text = formatted;

                }

            }
            catch { return; }

        }



        private void but_save_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (tex_item.Text.Trim() == string.Empty )
                {
                    MessageBox.Show("لايمكن ترك الحقول الخاصة أسم الصنف فارغة ", "حقل اجبارى", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }

                if(comB_shop.SelectedIndex == -1)
                {
                    MessageBox.Show("لايمكن ترك الحقول الخاصة أسم اسم المحل فارغة ", "حقل اجبارى", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if(tex_qua.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("لايمكن ترك الحقول الخاصة الكمية فارغة ", "حقل اجبارى", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tex_qua.Focus();
                    return;
                }

                if(textB_name.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("لايمكن ترك الحقول الخاصة أسم المستلم فارغة ", "حقل اجبارى", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textB_name.Focus();

                    return;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO export VALUES ('" + comB_shop.Text + "','" + tex_item.Text + "','" +tex_pris.Text + "','" +Convert.ToInt32( tex_qua.Text) + "', '"+ dateTP.Value.ToString("yyyy-MM-dd") + "', '" + tex_useradd.Text + "','" + tex_total.Text + "' ,'"+ wtim + "', '"+ textB_name.Text + "' )", dal.con);
                dal.open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("تمة اضاة صنف صادرة الي "+comB_shop.Text);
                dal.Close();

                pdatItem();

                cler_Text();

                getaddToDay();

                totalSumdgv();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"\n"+"لم يمة حفظ الصنف الصادر");
            }
        }

        private void tex_qua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void tex_qua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double total = 0.00;

                if (tex_qua.Text.Trim() != string.Empty)
                {

                    total = Convert.ToDouble(tex_pris.Text) * Convert.ToDouble(tex_qua.Text);

                    tex_total.Text = Convert.ToString(total);
                }
                else
                {
                    tex_total.Text = "0.00";
                }
            }
            catch { return; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboB_Serch.SelectedIndex != -1)
                {

                    SqlCommand cmd = new SqlCommand("SELECT id , shop_name  , item_name  , price , quantiy  , dat  , user_add , total  , tim , name_s  FROM export WHERE dat = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND shop_name = '" + comboB_Serch.Text + "' ", dal.con);
                    dal.open();
                    DataTable TDLMMO = new DataTable();
                    TDLMMO.Load(cmd.ExecuteReader());

                    dataGridView1.DataSource = TDLMMO;

                    dal.Close();
                    totalSumdgv();

                    comboB_Serch.SelectedIndex = -1;

                    //MessageBox.Show("لايمكن ترك الحقول الخاصة أسم اسم المحل فارغة ", "حقل اجبارى", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  return;
                }

                else
                {

                    SqlCommand cmd = new SqlCommand("SELECT id , shop_name  , item_name  , price , quantiy  , dat  , user_add , total  , tim , name_s  FROM export WHERE dat = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' ", dal.con);
                    dal.open();
                    DataTable TDLMMO = new DataTable();
                    TDLMMO.Load(cmd.ExecuteReader());

                    dataGridView1.DataSource = TDLMMO;

                    dal.Close();
                    totalSumdgv();

                }

              

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboB_Serch.SelectedIndex == -1)
                {
                    MessageBox.Show("لايمكن ترك الحقول الخاصة أسم اسم المحل فارغة ", "حقل اجبارى", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SqlCommand cmd = new SqlCommand("SELECT id , shop_name , item_name  , price , quantiy  , dat  , user_add , total  , tim  FROM export WHERE shop_name = '" + comboB_Serch.Text + "' AND  dat BETWEEN  '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' ", dal.con);
                dal.open();
                DataTable TDLMMO = new DataTable();
                TDLMMO.Load(cmd.ExecuteReader());

                dataGridView1.DataSource = TDLMMO;

                dal.Close();
                totalSumdgv();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("لا يوجد بيانات الي الطباع", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            try
            {
                string nam_s = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
                FormREP_exxx fr = new FormREP_exxx();
                // FormRep_PR frm = new FormRep_PR();

                ReportDataSource rds = new ReportDataSource("DataSet_export", dataGridView1.DataSource);

                ReportParameterCollection rpc = new ReportParameterCollection();
                

                fr.reportViewer1.LocalReport.DataSources.Clear();
                fr.reportViewer1.LocalReport.DataSources.Add(rds);

                rpc.Add(new ReportParameter("ReportParameter_name", nam_s));
                fr.reportViewer1.LocalReport.SetParameters(rpc);
                fr.reportViewer1.LocalReport.Refresh();

                fr.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("خطاء في الطباعة \n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_itemList fm = new frm_itemList();
            fm.ShowDialog();
            try
            {

                idit =Convert.ToInt32 (fm.dgvitem.CurrentRow.Cells[0].Value.ToString());
                tex_item.Text = fm.dgvitem.CurrentRow.Cells[1].Value.ToString();
                qu = Convert.ToInt32(fm.dgvitem.CurrentRow.Cells[3].Value.ToString());
                tex_pris.Text = fm.dgvitem.CurrentRow.Cells[5].Value.ToString();
            
                tex_qua.Text = "0";
                //btn_add_item.Focus();

                //btn_add_item_Click(sender,e);
            }
            catch { return; }
        }
    }
}
