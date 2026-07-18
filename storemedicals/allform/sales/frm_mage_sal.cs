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
    public partial class frm_mage_sal : Form
    {
        CLS.cls_sale sal = new CLS.cls_sale();
        Data.DataAccesLayer dal = new Data.DataAccesLayer();
        char dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

        string item_name="";

        public frm_mage_sal()
        {
            InitializeComponent();
            fill_dgv();
            data();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_sale fm = new frm_sale();
            fm.ShowDialog();
            fill_dgv();
        }



     private void btn_delete_Click(object sender, EventArgs e)
     {

         //===================================
            try
            {
                DataTable tbl = null;

                if (MessageBox.Show("هل تريد حذف البيانات", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(this.dgv_sal.CurrentRow.Cells[0].Value.ToString());
                  

                        SqlCommand cmd1 = new SqlCommand("SELECT order_id from itemOrderDeail where order_id = '" + Convert.ToInt16(id) + "' ", dal.con);

                        dal.open();
                        tbl = new DataTable();
                        tbl.Load(cmd1.ExecuteReader());

                        dal.Close();
                   
                    if (tbl.Rows.Count != 0)
                    {
                        MessageBox.Show("من فضلك اعد الكمية الي المخزان");
                   
                    }
                    else
                    {
                        sal.Delet_sal_orderitem(id);

                        SqlCommand cmd = new SqlCommand("DELETE itemOrderDeail WHERE order_id = '" + Convert.ToInt16(id) + "'", dal.con);
                        dal.open();
                        cmd.ExecuteNonQuery();
                        dal.Close();

                        SqlCommand cmd2 = new SqlCommand("DELETE typ_money WHERE order_id = '" + Convert.ToInt16(id) + "'", dal.con);
                        dal.open();
                        cmd2.ExecuteNonQuery();
                        dal.Close();

                        MessageBox.Show("  تم حذف البيانات بنجاح", "تاكيد الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fill_dgv();
                    }
                }
             //   else
              //  {
                   
                  //  fill_dgv();
               // }
            }
           catch(Exception ex)
            {
                MessageBox.Show("خطا فى عملية الحذف" + ex.ToString());
               return;
           }

        //===================================
     }

     private void fill_dgv()
     {
         try
         {
             dgv_sal.DataSource = sal.Get_all_salBill();
             dgv_sal.Columns[4].Visible=false;
         }
         catch { return; }
     }

     private void frm_mage_sal_Load(object sender, EventArgs e)
     {
         fill_dgv();
     }

     private void btn_print_one_Click(object sender, EventArgs e)
     {
         try
         {
           //  this.Cursor = Cursors.WaitCursor;
           //  reportsprint.rep_sal.print_one_sal_forcrystal mysal = new reportsprint.rep_sal.print_one_sal_forcrystal();
          
                int ID = Convert.ToInt32(this.dgv_sal.CurrentRow.Cells[0].Value.ToString());

                SqlCommand cmd = new SqlCommand("SELECT f.order_id  , f.ITEM_NAME_AR , f.ITEM_COUNT , f.ITEM_PRIC , f.Amount  , o.user_add FROM itemOrderDeail f JOIN dbo.itemorder o ON  f.order_id=o.ored_id  WHERE order_id = '" + Convert.ToInt32(ID) + "' ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                For_SALITM fr = new For_SALITM();

                ReportDataSource rds = new ReportDataSource("DataSetREPOZE", tbl);
                ReportParameterCollection rpc = new ReportParameterCollection();
                fr.reportViewer1.LocalReport.DataSources.Clear();
                fr.reportViewer1.LocalReport.DataSources.Add(rds);
                rpc.Add(new ReportParameter("ReportParameter_NAMRCUSTMR", dgv_sal.CurrentRow.Cells[3].Value.ToString()));
                rpc.Add(new ReportParameter("ReportParameterDeta", dgv_sal.CurrentRow.Cells[2].Value.ToString()));
                fr.reportViewer1.LocalReport.SetParameters(rpc);
                fr.reportViewer1.LocalReport.Refresh();

                fr.ShowDialog();

                //    mysal.SetDataSource(sal.Get_All_Sal_printForcrystal2(ID));


                //  reportsprint.Rep.frm_purch_on fm = new reportsprint.Rep.frm_purch_on();
                //  fm.crystalReportViewer1.ReportSource = mysal;

                // this.Cursor = Cursors.Hand;
                // fm.ShowDialog();

            }
         catch (Exception ex)
         {
             MessageBox.Show("خطا فى طباعة التقرير" + ex.ToString());
         }
     }

     private void btn_print_all_Click(object sender, EventArgs e)
     {
         try
         {
             this.Cursor = Cursors.WaitCursor;

             reportsprint.rep_sal.print_All_salBillcrystal myrep = new reportsprint.rep_sal.print_All_salBillcrystal();
             myrep.SetDataSource(sal.Get_All_Sal_printForcrystal());

             reportsprint.Rep.frm_purch_on fm = new reportsprint.Rep.frm_purch_on();
             fm.crystalReportViewer1.ReportSource = myrep;

             this.Cursor = Cursors.Hand;
             fm.ShowDialog();

         }
         catch (Exception ex)
         {
             MessageBox.Show("خطا فى طباعة التقرير" + ex.ToString());
         }
     }

     private void button1_Click(object sender, EventArgs e)
     {
         fill_dgv();
     }

     private void txt_search_TextChanged(object sender, EventArgs e)
     {
         try
         {
                if (txt_search.Text.Trim() == string.Empty)
                {
                    fill_dgv();
                }
                else
                {

                    SqlCommand cmd = new SqlCommand("SELECT it.ored_id as\"رقم الفاتورة\",it.ored_desc as \"وصف الفاتورة\" ,it.ored_date as\"التاريخ\",c.CUST_NAME as \"أسم الزبون\" FROM dbo.itemorder it JOIN  CUSTMER C  ON it.cust_id = c.CUST_ID WHERE ored_id = '" + txt_search.Text + "'", dal.con);
                    dal.open();

                    DataTable tbl = null;
                    tbl = new DataTable();
                    tbl.Load(cmd.ExecuteReader());

                    dgv_sal.DataSource = tbl;

                    dal.Close();
                }

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
     }

     private void date_search_ValueChanged(object sender, EventArgs e)
     {
         
     }

     private void button2_Click(object sender, EventArgs e)
     {
       
     }

     private void textBox1_TextChanged(object sender, EventArgs e)
     {
       
     }

     private void button2_Click_1(object sender, EventArgs e)
     {
         try
         {
                // string s = "";txt_search.Text

                // dateTimePicker1.Value.ToString("yyyy-MM-dd");
                // dateTimePicker1.ToString();


                DataTable dt = new DataTable();
             dt = sal.Get_all_fator_bycutsmer(item_name, dateTimePicker1.Value.ToString("yyyy-MM-dd") );
             this.dgv_sal.DataSource = dt;


         }
         catch { return; }

     }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            item_name = comboBox1.SelectedItem.ToString();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }
        //============================
    }
}
