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
    public partial class Saler_formData2 : Form
    {

        Data.DataAccesLayer dal = new Data.DataAccesLayer();

        

        public Saler_formData2()
        {
            InitializeComponent();

            foreach (DataGridViewColumn col in dgvitem.Columns)

            {

                col.DataPropertyName = col.Name.Replace("col_", "");

            }

           // foreach (DataGridViewColumn col in dataGVINVE.Columns)

         //   {

           //     col.DataPropertyName = col.Name.Replace("col_", "");

          //  }


        }

        public void getAllDataTYPMON()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT mo_cach AS \"قيمة الكاش\", mo_bank AS \"قيمة بنكك\" , mo_atm AS \"قيمة ATM\" from typ_money WHERE dat BETWEEN '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' ORDER BY order_id ASC ", dal.con);
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

        public void getAllDataTYPMONDATA()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT mo_cach AS \"قيمة الكاش\", mo_bank AS \"قيمة بنكك\" , mo_atm AS \"قيمة ATM\" from typ_money  ORDER BY order_id ASC", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dataGridView1.DataSource = tbl;

                dal.Close();
                getdata_agel();
                totalCACH();
                totalBANKK();
                totalATM();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void getTOTALDATA()
        {
            /*
            try
            {
                SqlCommand cmd = new SqlCommand("select  ty_cach,  SUM(mo_cach) total_cach, ty_bank  ,SUM(mo_bank) total_bank ,ty_atm , SUM(mo_bank) total_atm ,dat from typ_money where dat BETWEEN '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' GROUP BY ty_cach , dat ,ty_bank ,ty_atm ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dataGVINVE.DataSource = tbl;

                dal.Close();

            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
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
                                     where row.Cells[0].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();

                    string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(textBox3.Text));
                    textBox3.Text = formatted;

                    double to = Convert.ToDouble(textBox3.Text) - Convert.ToDouble(textBox4.Text) + Convert.ToInt32(texBox_pl_cash.Text);
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
                                     where row.Cells[1].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum().ToString();

                    string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(textBox2.Text));
                    textBox2.Text = formatted;

                    double total = Convert.ToDouble(formatted);// + Convert.ToDouble(texBox_pl_bok.Text);
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
                                     where row.Cells[2].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();

                    string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(textBox1.Text));
                    textBox1.Text = formatted;

                }


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
                SqlCommand cmd = new SqlCommand("SELECT o.ored_date , f.order_id  ,f.ITEM_NAME_AR , f.ITEM_COUNT , f.ITEM_PRIC , f.Amount  ,o.user_add FROM dbo.itemOrderDeail f JOIN dbo.itemorder o ON  f.order_id=o.ored_id", dal.con);
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
                                      where row.Cells[5].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();

                    string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(tex_Total.Text));
                    tex_Total.Text = formatted;

                    double toa = Convert.ToDouble(tex_Total.Text) - Convert.ToDouble(textBox4.Text) - Convert.ToUInt32(textBoxagel.Text) + Convert.ToInt32(texBox_pl_cash.Text) + Convert.ToInt32(texBox_pl_bok.Text);
                    string formattedt = string.Format(CultureInfo.InvariantCulture, "{0:N0}", toa);
                    textBoxTOtal.Text = formattedt;

                }

            }
            catch { return; }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //OR o.ored_date BETWEEN '"+ dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' AND '"+ dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'
/*
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT o.cust_id , o.ored_date , f.order_id  ,f.ITEM_NAME_AR , f.ITEM_COUNT , f.ITEM_PRIC , f.Amount  ,o.user_add FROM dbo.itemOrderDeail f JOIN dbo.itemorder o ON  f.order_id=o.ored_id  WHERE  o.cust_id = '" + id_custmer + "' AND  o.ored_date BETWEEN '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'  ", dal.con);
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
            */
        
        
    }

        private void btn_new_Click(object sender, EventArgs e)
        {
            getAllData();
            getAllDataTYPMONDATA();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT o.ored_date , f.order_id  ,f.ITEM_NAME_AR , f.ITEM_COUNT , f.ITEM_PRIC , f.Amount  ,o.user_add FROM itemOrderDeail f JOIN dbo.itemorder o ON  f.order_id=o.ored_id  WHERE o.ored_date BETWEEN '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' ORDER BY f.order_id ASC ", dal.con);
                SqlCommand cmd2 = new SqlCommand("SELECT exp_sale from expenses WHERE exp_date  BETWEEN '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' AND '"+ dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' ", dal.con);
              

                dal.open();
                DataTable tbl = null , tbiEX;
                tbl = new DataTable();
                tbiEX = new DataTable();


                tbl.Load(cmd.ExecuteReader());
                tbiEX.Load(cmd2.ExecuteReader());

                dgvitem.DataSource = tbl;

                if (tbiEX.Rows.Count != 0)
                {
                    object sumOb;
                    sumOb = tbiEX.Compute("Sum(exp_sale)", string.Empty);

                    textBox4.Text = Convert.ToString(sumOb);



                }
                else
                {
                    textBox4.Text = "0";
                }


                dal.Close();
                // sumDataGrad();

                getdata_agel();
                getagel_tab_deble_paid_cash();
                getagel_tab_deble_paid_bank();
                totalSumdgv();
                getAllDataTYPMON();
              //  getdata_agel();



                // getTOTALDATA();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getdata_agel()
        {
            try
            {

                SqlCommand cmd2 = new SqlCommand("SELECT sele_rest from tab_deble WHERE dat  BETWEEN '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' ", dal.con);

                dal.open();
                DataTable  tbiEX = null;
              
                tbiEX = new DataTable();

                tbiEX.Load(cmd2.ExecuteReader());

              

                if (tbiEX.Rows.Count != 0)
                {
                    object sumOb;
                    sumOb = tbiEX.Compute("Sum(sele_rest)", string.Empty);

                    textBoxagel.Text = Convert.ToString(sumOb);

                }
                else
                {
                    textBoxagel.Text = "0";
                }

                dal.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getagel_tab_deble_paid_cash()
        {

            try
            {

                SqlCommand cmd = new SqlCommand("SELECT cash from tab_deble_paid WHERE p_dat BETWEEN '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                if (tbl.Rows.Count != 0)
                {
                    object sumOb;
                    sumOb = tbl.Compute("Sum(cash)", string.Empty);

                    texBox_pl_cash.Text = Convert.ToString(sumOb);

                }
                else
                {
                    texBox_pl_cash.Text = "0";
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

                SqlCommand cmd = new SqlCommand("SELECT bank from tab_deble_paid WHERE p_dat BETWEEN '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                if (tbl.Rows.Count != 0)
                {
                    object sumOb;
                    sumOb = tbl.Compute("Sum(bank)", string.Empty);

                    texBox_pl_bok.Text = Convert.ToString(sumOb);

                }
                else
                {
                    texBox_pl_bok.Text = "0";
                }

                dal.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                FormRep_PR frm = new FormRep_PR();

                ReportDataSource rds = new ReportDataSource("DataSetORDER", dgvitem.DataSource);
                frm.reportViewer1.LocalReport.DataSources.Clear();
                frm.reportViewer1.LocalReport.DataSources.Add(rds);
                frm.reportViewer1.LocalReport.Refresh();

                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("خطاء في الطباعة \n" + ex.Message);
            }
        }

        private void dateTimePicker_s_ValueChanged(object sender, EventArgs e)
        {
            button3.PerformClick();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            button3.PerformClick();
        }

        private void btn_print_one_Click(object sender, EventArgs e)
        {
            //
            if (dgvitem.Rows.Count < 1)
            {
                MessageBox.Show("لا يوجد بيانات الي الطباع", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            try
            {
                Form_REP_DATE_BETT fr = new Form_REP_DATE_BETT();
                // FormRep_PR frm = new FormRep_PR();

                ReportDataSource rds = new ReportDataSource("DataSet1", dgvitem.DataSource);
                fr.reportViewer1.LocalReport.DataSources.Clear();
                fr.reportViewer1.LocalReport.DataSources.Add(rds);
                fr.reportViewer1.LocalReport.Refresh();

                ReportParameterCollection rpc = new ReportParameterCollection();

                rpc.Add(new ReportParameter("ReportParametedata", dateTimePicker_s.Value.ToString("yyyy-MM-dd")));
                rpc.Add(new ReportParameter("ReportParametedataen", dateTimePicker1.Value.ToString("yyyy-MM-dd")));


                rpc.Add(new ReportParameter("ReportParameteex", textBox4.Text));
                rpc.Add(new ReportParameter("ReportParameterCash", textBox3.Text));
                rpc.Add(new ReportParameter("ReportParameterBANK", textBox2.Text));
                rpc.Add(new ReportParameter("ReportParameterATM", textBox1.Text));
                rpc.Add(new ReportParameter("ReportParametercash_exp", textBox5.Text));
                rpc.Add(new ReportParameter("ReportParameterTOAL", tex_Total.Text));
                rpc.Add(new ReportParameter("ReportParameterTOTALALL", textBoxTOtal.Text));
                rpc.Add(new ReportParameter("ReportParameter_RELIGION", textBoxagel.Text));
                rpc.Add(new ReportParameter("ReportParameter_PL_CASH", texBox_pl_cash.Text));
                rpc.Add(new ReportParameter("ReportParameter_PL_BANK", texBox_pl_bok.Text));

                // rpc.Add(new ReportParameter("ReportParameterCash", textBox4.Text));
                // rpc.Add(new ReportParameter("ReportParameterCash", textBox3.Text));
                //  rpc.Add(new ReportParameter("ReportParameterBANK", textBox2.Text));
                //  rpc.Add(new ReportParameter("ReportParameterATM", textBox1.Text));
                // rpc.Add(new ReportParameter("ReportParametercash_exp", textBox5.Text));
                // rpc.Add(new ReportParameter("ReportParameterTOAL", textBoxTOtal.Text));
                // rpc.Add(new ReportParameter("ReportParameterDATEBE", dateTimePicker1.Value.ToString("yyyy-MM-dd"))); //
                fr.reportViewer1.LocalReport.SetParameters(rpc);
                fr.reportViewer1.RefreshReport();

                fr.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("خطاء في الطباعة \n" + ex.Message);
            }
            //END
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
