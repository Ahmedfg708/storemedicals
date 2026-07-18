using Microsoft.Reporting.WinForms;
using storemedicals.allform.REPORTITEM;
using storemedicals.allform.sales.report_saler;
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
    public partial class Saler_formData : Form
    {

        Data.DataAccesLayer dal = new Data.DataAccesLayer();

        string item_custmer = "", typ_money ="";
        int id_custmer = 0;

       

        public Saler_formData()
        {
            InitializeComponent();
            textBox5.Text = "0";


            foreach (DataGridViewColumn col in dgvitem.Columns)

            {

                col.DataPropertyName = col.Name.Replace("col_", "");

            }

            foreach (DataGridViewColumn col in dataGridView1.Columns)

            {

                col.DataPropertyName = col.Name.Replace("col_", "");

            }
            getEXP();
            data();
            getagel();
            getagel_tab_deble_paid_cash();
            getagel_tab_deble_paid_bank();
            getAllDataTODAY();
            getAllDataTYPMON();

           
           
        }

        public void gdtabnul() {

            try
            {
                string un = "";
                SqlCommand cmd = new SqlCommand("SELECT o.ored_date , f.order_id  ,f.ITEM_NAME_AR , f.ITEM_COUNT , f.ITEM_PRIC , f.Amount , o.user_add ,f.pink  FROM itemOrderDeail f JOIN dbo.itemorder o ON  f.order_id=o.ored_id  WHERE o.ored_date = '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' and ITEM_NAME_AR = '" + un+"' ", dal.con);
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
        public void data()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT CUST_NAME FROM dbo.CUSTMER", dal.con);
                dal.open();

                SqlDataReader drd = cmd.ExecuteReader();

                while (drd.Read())
                {
                    comboBox1.Items.Add(drd["CUST_NAME"].ToString());
                }

                drd.Close();
                dal.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void idCst()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT CUST_ID FROM dbo.CUSTMER WHERE CUST_NAME ='"+item_custmer+"'", dal.con);
                dal.open();

                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                id_custmer = (int)tbl.Rows[0][0];
              
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
                SqlCommand cmd = new SqlCommand("SELECT o.ored_date , f.order_id ,f.ITEM_NAME_AR , f.ITEM_COUNT , f.ITEM_PRIC , f.Amount , o.user_add ,f.pink FROM itemOrderDeail f JOIN itemorder o ON  f.order_id=o.ored_id WHERE o.ored_date = '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' ORDER BY f.order_id ASC ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem.DataSource = tbl;


                dal.Close();

              

                totalSumdgv();

                totalSumdgv();
                totalCACH();
                totalBANKK();
                totalATM();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void getAllDataTYPMON()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT order_id as\"رقم الفاتوره\" , mo_cach as \"قيمة الكاش\" , mo_bank as \"قيمة بنكك\", mo_atm as \"قيمة ATM\" from typ_money WHERE dat = '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' ORDER BY order_id ASC", dal.con);  //ORDER BY f.order_id ASC
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dataGridView1.DataSource = tbl;

                dal.Close();

               

                totalCACH();
                totalBANKK();
                totalATM();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void gdtabnulWTIM()
        {

            try
            {
                string w = "";
                SqlCommand cmd = new SqlCommand("SELECT order_id as\"رقم الفاتوره\" , mo_cach as \"قيمة الكاش\" , mo_bank as \"قيمة بنكك\", mo_atm as \"قيمة ATM\" from typ_money WHERE wtim = '" + w + "' ORDER BY order_id ASC", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dataGridView1.DataSource = tbl;

                dal.Close();

               

                totalCACH();
                totalBANKK();
                totalATM();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void getAllDataTYPMONWTIM()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT order_id as\"رقم الفاتوره\" , mo_cach as \"قيمة الكاش\" , mo_bank as \"قيمة بنكك\", mo_atm as \"قيمة ATM\" from typ_money WHERE dat = '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' AND wtim = '"+comBoxPink.Text+ "' ORDER BY order_id ASC ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dataGridView1.DataSource = tbl;

                dal.Close();

             

                totalCACH();
                totalBANKK();
                totalATM();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getAllDataTODAY()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT o.ored_date , f.order_id ,f.ITEM_NAME_AR , f.ITEM_COUNT , f.ITEM_PRIC , f.Amount  , o.user_add ,f.pink FROM itemOrderDeail f JOIN itemorder o ON  f.order_id=o.ored_id WHERE o.ored_date = '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' ORDER BY f.order_id ASC", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem.DataSource = tbl;


                dal.Close();
              
                // sumDataGrad();
                totalSumdgv();
                totalCACH();
                totalBANKK();
                totalATM();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void getagel()
        {

            try
            {

                SqlCommand cmd = new SqlCommand("SELECT sele_rest from tab_deble WHERE dat='" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "'", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                if (tbl.Rows.Count != 0)
                {
                    object sumOb;
                    sumOb = tbl.Compute("Sum(sele_rest)", string.Empty);

                    textBoxagel.Text = Convert.ToString(sumOb);

                }
                else
                {
                    textBoxagel.Text = "0";
                }

                dal.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void getagel_tab_deble_paid_cash()
        {

            try
            {

                SqlCommand cmd = new SqlCommand("SELECT cash from tab_deble_paid WHERE p_dat='" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "'", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                if (tbl.Rows.Count != 0)
                {
                    object sumOb;
                    sumOb = tbl.Compute("Sum(cash)", string.Empty);

                    textBox7.Text = Convert.ToString(sumOb);

                }
                else
                {
                    textBox7.Text = "0";
                }

                dal.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void getagel_tab_deble_paid_bank()
        {

            try
            {

                SqlCommand cmd = new SqlCommand("SELECT bank from tab_deble_paid WHERE p_dat='" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "'", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                if (tbl.Rows.Count != 0)
                {
                    object sumOb;
                    sumOb = tbl.Compute("Sum(bank)", string.Empty);

                    txt_bok.Text = Convert.ToString(sumOb);

                }
                else
                {
                    txt_bok.Text = "0";
                }

                dal.Close();

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
                if (dgvitem.Rows.Count < 0)
                {
                    tex_Total.Text = "0";
                }
                else
                {
                    
                    tex_Total.Text = (from DataGridViewRow row in dgvitem.Rows
                     where row.Cells[5].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();

                    string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(tex_Total.Text));
                    tex_Total.Text = formatted;

                    double to = Convert.ToDouble(tex_Total.Text) - Convert.ToDouble(textBox4.Text) - Convert.ToInt32(textBoxagel.Text) + Convert.ToInt32(textBox7.Text) + Convert.ToInt32(txt_bok.Text);
                    string formattedto = string.Format(CultureInfo.InvariantCulture, "{0:N0}", to);
                    textBoxTOtal.Text = formattedto;

                }

            }
            catch { return; }

        }

        private void totalCACH()
        {

            try
            {

                if (dataGridView1.Rows.Count < 0)
                {
                    textBox3.Text = "0";
                }
                else
                {

                    textBox3.Text = (from DataGridViewRow row in dataGridView1.Rows
                                      where row.Cells[1].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum().ToString();

                   

                    string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(textBox3.Text));
                    textBox3.Text = formatted;



                    double to = Convert.ToDouble(textBox3.Text) - Convert.ToDouble(textBox4.Text) + Convert.ToInt32(textBox7.Text);
                    string formattedto = string.Format(CultureInfo.InvariantCulture, "{0:N0}", to);
                    textBox5.Text = formattedto;



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void totalBANKK()
        {

            try
            {

                if (dataGridView1.Rows.Count < 0)
                {
                    textBox3.Text = "0";
                }
                else
                {

                    textBox2.Text = (from DataGridViewRow row in dataGridView1.Rows
                                     where row.Cells[2].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();

                    string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(textBox2.Text));
                    textBox2.Text = formatted;

                    double total = Convert.ToDouble(textBox2.Text) ;// + Convert.ToInt32(txt_bok.Text);
                    textBox2.Text = Convert.ToString(total);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void totalATM()
        {

            try
            {


                if (dataGridView1.Rows.Count < 0)
                {
                    textBox1.Text = "0";
                }
                else
                {

                    textBox1.Text = (from DataGridViewRow row in dataGridView1.Rows
                                     where row.Cells[3].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();

                    string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(textBox1.Text));
                    textBox1.Text = formatted;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void getEXP()
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT exp_sale from expenses WHERE exp_date='"+ dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "'", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                if (tbl.Rows.Count != 0)
                {
                    object sumOb;
                    sumOb = tbl.Compute("Sum(exp_sale)", string.Empty);

                    textBox4.Text = Convert.ToString(sumOb);

                   

                }
                else
                {
                    textBox4.Text = "0";
                }


                dal.Close();
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void getEXP_wtim()
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT exp_sale from expenses WHERE exp_date='" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' AND wtim = '"+ comBoxPink.Text+ "' ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                if (tbl.Rows.Count != 0)
                {
                    object sumOb;
                    sumOb = tbl.Compute("Sum(exp_sale)", string.Empty);

                    textBox4.Text = Convert.ToString(sumOb);



                }
                else
                {
                    textBox4.Text = "0";
                }


                dal.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            item_custmer = comboBox1.SelectedItem.ToString();
            idCst();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            getAllData();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT o.cust_id , o.ored_date , f.order_id  ,f.ITEM_NAME_AR , f.ITEM_COUNT , f.ITEM_PRIC , f.Amount  , f.pa_type ,o.user_add ,f.pink FROM dbo.itemOrderDeail f JOIN dbo.itemorder o ON  f.order_id=o.ored_id  WHERE  o.cust_id = '" + id_custmer + "' AND  o.ored_date = '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem.DataSource = tbl;


                dal.Close();
                // sumDataGrad();
                totalSumdgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT o.ored_date , f.order_id  ,f.ITEM_NAME_AR , f.ITEM_COUNT , f.ITEM_PRIC , f.Amount , o.user_add ,f.pink  FROM itemOrderDeail f JOIN itemorder o ON  f.order_id=o.ored_id  WHERE o.ored_date = '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' ORDER BY f.order_id ASC ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem.DataSource = tbl;
               


                dal.Close();
                // sumDataGrad();
                getagel();
                getagel_tab_deble_paid_cash();
                getagel_tab_deble_paid_bank();
                totalSumdgv();

                totalSumdgv();
               
                totalCACH();
                totalBANKK();
                totalATM();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        private void btn_print_one_Click(object sender, EventArgs e)
        {
            if (dgvitem.Rows.Count < 1)
            {
                MessageBox.Show("لا يوجد بيانات الي الطباع", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            
            try
            {
                Form_REPORTSALERS fr = new Form_REPORTSALERS();
               // FormRep_PR frm = new FormRep_PR();

                ReportDataSource rds = new ReportDataSource("DataSetDataSetREPOZE", dgvitem.DataSource);
                fr.reportViewer1.LocalReport.DataSources.Clear();
                fr.reportViewer1.LocalReport.DataSources.Add(rds);
                fr.reportViewer1.LocalReport.Refresh();

                ReportParameterCollection rpc = new ReportParameterCollection();

                rpc.Add(new ReportParameter("ReportParametedata", dateTimePicker_s.Value.ToString("yyyy-MM-dd")));


                rpc.Add(new ReportParameter("ReportParameteex", textBox4.Text));
                rpc.Add(new ReportParameter("ReportParameterCash", textBox3.Text));
                rpc.Add(new ReportParameter("ReportParameterBANK", textBox2.Text));
                rpc.Add(new ReportParameter("ReportParameterATM", textBox1.Text));
                rpc.Add(new ReportParameter("ReportParametercash_exp", textBox5.Text));
                rpc.Add(new ReportParameter("ReportParameterTOAL", tex_Total.Text));
                rpc.Add(new ReportParameter("ReportParameterTOTALALL", textBoxTOtal.Text));
                rpc.Add(new ReportParameter("ReportParameterRELIGION", textBoxagel.Text)); 
                rpc.Add(new ReportParameter("ReportParameter_PL_CASH", textBox7.Text));
                rpc.Add(new ReportParameter("ReportParameter_PL_BANK", txt_bok.Text));

                fr.reportViewer1.LocalReport.SetParameters(rpc);
                 fr.reportViewer1.RefreshReport();

                fr.ShowDialog();

            }catch(Exception ex)
            {
                MessageBox.Show("خطاء في الطباعة \n"+ex.Message);
            }
        }

        private void rad_cash_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_cash.Checked)
            {
                typ_money = "كاش";
                button3.PerformClick();
            }

        }

        private void rad_bank_CheckedChanged(object sender, EventArgs e)
        {

            if (rad_bank.Checked)
            {
                typ_money = "بنكك";
                button3.PerformClick();
            }

        }

        private void rad_atm_CheckedChanged(object sender, EventArgs e)
        {

            if (rad_atm.Checked)
            {
                typ_money = "ATM";
                button3.PerformClick();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT o.cust_id  , o.ored_date , f.order_id  ,f.ITEM_NAME_AR , f.ITEM_COUNT , f.ITEM_PRIC , f.Amount , f.ty_cach,f.mo_cach ,f.ty_bank ,f.mo_bank,f.ty_atm ,f.mo_atm , o.user_add ,f.pink  FROM itemOrderDeail f JOIN dbo.itemorder o ON  f.order_id=o.ored_id  WHERE o.ored_date = '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' AND f.pa_type = '"+typ_money+"' ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem.DataSource = tbl;


                dal.Close();
                // sumDataGrad();
                totalSumdgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT o.ored_date , f.order_id  ,f.ITEM_NAME_AR , f.ITEM_COUNT , f.ITEM_PRIC , f.Amount , o.user_add ,f.pink  FROM itemOrderDeail f JOIN dbo.itemorder o ON  f.order_id=o.ored_id  WHERE f.pink = '" + comBoxPink.Text + "' AND  o.ored_date = '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' ORDER BY f.order_id ASC ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem.DataSource = tbl;


                dal.Close();

                // sumDataGrad();
                // totalSumdgv();

                if (tbl.Rows.Count != 0)
                {
                   
                    getAllDataTYPMONWTIM();
                    totalSumdgv();
                    getEXP_wtim();
                    totalCACH();
                    totalBANKK();
                    totalATM();
                   
                }
                else
                {
                    textBox5.Text = "0";
                    textBox3.Text = "0.00";
                    textBox2.Text = "0.00";
                    textBox1.Text = "0.00";
                    tex_Total.Text = "0";
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if(rad_cash.Checked == false && rad_bank.Checked == false && rad_atm.Checked== false)
            {
                MessageBox.Show("اختر نوع الدفع اولا", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                return;
            }

            if (dgvitem.Rows.Count < 1)
            {
                MessageBox.Show("لا يوجد بيانات الي الطباع", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            try
            {
                FormREPTYM_PIN fr = new FormREPTYM_PIN();
                ReportDataSource rds = new ReportDataSource("DataSetREPO", dgvitem.DataSource);
                fr.reportViewer1.LocalReport.DataSources.Clear();
                fr.reportViewer1.LocalReport.DataSources.Add(rds);
                fr.reportViewer1.LocalReport.Refresh();

                fr.ShowDialog();

                rad_atm.Checked = false;
                rad_bank.Checked = false;
                rad_cash.Checked = false;

               
                gdtabnul();

            }
            catch(Exception ex)
            {
                MessageBox.Show("خطاء في الطباعة \n" + ex.Message);
                rad_atm.Checked = false;
                rad_bank.Checked = false;
                rad_cash.Checked = false;
            }
        }

        private void rad_cash_MouseClick(object sender, MouseEventArgs e)
        {
            if (rad_cash.Checked)
            {
                typ_money = "كاش";
                button3.PerformClick();
            }
        }

        private void rad_bank_MouseClick(object sender, MouseEventArgs e)
        {
            if (rad_bank.Checked)
            {
                typ_money = "بنكك";
                button3.PerformClick();
            }
        }

        private void rad_atm_MouseClick(object sender, MouseEventArgs e)
        {
            if (rad_atm.Checked)
            {
                typ_money = "ATM";
                button3.PerformClick();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comBoxPink.SelectedIndex ==-1)
            {
                MessageBox.Show("اختر نوع الدوام اولا", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (dgvitem.Rows.Count < 1)
            {
                MessageBox.Show("لا يوجد بيانات الي الطباع", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            try
            {
                FormSALERWTIM fr = new FormSALERWTIM();
                ReportDataSource rds = new ReportDataSource("DataSetREPO", dgvitem.DataSource);
                fr.reportViewer1.LocalReport.DataSources.Clear();
                fr.reportViewer1.LocalReport.DataSources.Add(rds);
                fr.reportViewer1.LocalReport.Refresh();

                ReportParameterCollection rpc = new ReportParameterCollection();

                rpc.Add(new ReportParameter("ReportParametedata", dateTimePicker_s.Value.ToString("yyyy-MM-dd")));
                rpc.Add(new ReportParameter("ReportParameterTIM", comBoxPink.Text));

                rpc.Add(new ReportParameter("ReportParameteex", textBox4.Text));
                rpc.Add(new ReportParameter("ReportParameterCash", textBox3.Text));
                rpc.Add(new ReportParameter("ReportParameterBANK", textBox2.Text));
                rpc.Add(new ReportParameter("ReportParameterATM", textBox1.Text));
                rpc.Add(new ReportParameter("ReportParametercash_exp", textBox5.Text));
                rpc.Add(new ReportParameter("ReportParameterTOAL", tex_Total.Text));
                rpc.Add(new ReportParameter("ReportParameterTOTALALL", textBoxTOtal.Text));

                //  rpc.Add(new ReportParameter("ReportParameter1", textBox4.Text));
                //  rpc.Add(new ReportParameter("ReportParameterCash", textBox3.Text));
                //  rpc.Add(new ReportParameter("ReportParameterBANK", textBox2.Text));
                //  rpc.Add(new ReportParameter("ReportParameterATM", textBox1.Text));
                //  rpc.Add(new ReportParameter("ReportParametercash_exp", textBox5.Text));
                //  rpc.Add(new ReportParameter("ReportParameterTOAL", textBoxTOtal.Text));
                //  rpc.Add(new ReportParameter("ReportParameterdate", dateTimePicker_s.Value.ToString("yyyy-MM-dd")));//ReportParameterdate
                fr.reportViewer1.LocalReport.SetParameters(rpc);
                fr.reportViewer1.RefreshReport();

                fr.ShowDialog();

                comBoxPink.SelectedIndex = -1;
                gdtabnulWTIM();

            }
            catch (Exception ex)
            {
                MessageBox.Show("خطاء في الطباعة \n" + ex.Message);
                comBoxPink.SelectedIndex = -1;
            }
        }

        private void dateTimePicker_s_ValueChanged(object sender, EventArgs e)
        {
            textBox5.Text = "0";
            comBoxPink.SelectedIndex = -1;
            getEXP();
            button1.PerformClick();
            
            getAllDataTYPMON();
            // totalCACH();
            // //totalBANKK();
            //  totalATM();
            
            

        }

        private void comBoxPink_SelectedIndexChanged(object sender, EventArgs e)
        {
            getEXP_wtim();
            button5.PerformClick();
            //   getEXP_wtim();
            getAllDataTYPMONWTIM();
            if (comBoxPink.SelectedIndex == 2)
            {
                getEXP();
                getAllData();
                getAllDataTYPMON();
            }


        }

        private void dgvitem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != this.dgvitem.NewRowIndex)
            {
                if (dgvitem.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    double val1 = double.Parse(e.Value.ToString());
                    e.Value = val1.ToString("N2");
                }
            }

            if (e.ColumnIndex == 5 && e.RowIndex != this.dgvitem.NewRowIndex)
            {
                if (dgvitem.Rows[e.RowIndex].Cells[5].Value != null)
                {
                    double val1 = double.Parse(e.Value.ToString());
                    e.Value = val1.ToString("N2");
                }
            }


        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == 1 && e.RowIndex != this.dataGridView1.NewRowIndex)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
                    {
                        double val1 = double.Parse(e.Value.ToString());
                        e.Value = val1.ToString("N2");
                    }
                }

                if (e.ColumnIndex == 2 && e.RowIndex != this.dataGridView1.NewRowIndex)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[2].Value != null)
                    {
                        double val1 = double.Parse(e.Value.ToString());
                        e.Value = val1.ToString("N2");
                    }
                }

                if (e.ColumnIndex == 3 && e.RowIndex != this.dataGridView1.NewRowIndex)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[3].Value != null)
                    {
                        double val1 = double.Parse(e.Value.ToString());
                        e.Value = val1.ToString("N2");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
