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
    public partial class frm_search_SalAnd_purch : Form
    {
        CLS.cls_main man = new CLS.cls_main();
        Data.DataAccesLayer dal = new Data.DataAccesLayer();
        public frm_search_SalAnd_purch()
        {
            InitializeComponent();
            Between_Purch();
            //Between_sal();
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //=====================
        private void Between_Purch()
        {
            try 
            {
                DataTable dt = new DataTable();
                dt = man.search_between_purch(date_from.Value.ToString(), date_to.Value.ToString());
                this.dgv_purch.DataSource = dt;

                txt_total_purch.Text = (from DataGridViewRow row in dgv_purch.Rows
                                         where row.Cells[4].FormattedValue.ToString() != string.Empty
                                         select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            }
            catch { return; }
        
        }
        //======================

        //====================='

        //================================== حساب المبلغ من الداتا قر

        private void totalSumdgv()
        {
            try
            {
                if (dgv_sal.Rows.Count < 1)
                {
                    txt_tot_sal.Text = "0";
                }
                else
                {

                    txt_tot_sal.Text = (from DataGridViewRow row in dgv_sal.Rows
                                      where row.Cells[4].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();

                    string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(txt_tot_sal.Text));
                    txt_tot_sal.Text = formatted;

                }

            }
            catch { return; }

        }

        //=================================== دالت البحث بين تاريغ المبيعات
        private void BET_SEL()
        {

            try
            {
                //"SELECT o.cust_id as \"الرقم\" , o.ored_date as \"التارخ\", f.order_id as \"رقم الفاتورة\" ,f.ITEM_NAME_AR as \"أسم الصنف\", f.ITEM_COUNT as \"الكمية\", f.ITEM_PRIC as \"السعر\", f.Amount as \"الاجمالي\" FROM dbo.itemOrderDeail f JOIN dbo.itemorder o ON  f.order_id=o.ored_id  WHERE  o.ored_date BETWEEN '" + date_from.Value.ToString("yyyy-MM-dd") + "' AND '" + date_to.Value.ToString("yyyy-MM-dd") + "'  ", dal.con);
                //SELECT name_camp, inv_number ,type_payment,amount,ponas+'%' as ponas ,date,total FROM purchases
                SqlCommand cmd = new SqlCommand("SELECT o.ored_date as \"التارخ\" , f.order_id as \"الفاتوره\"  ,f.ITEM_NAME_AR as \"الصنف\" , f.ITEM_COUNT as \"الكميه\" , f.ITEM_PRIC as \"السعر\" , f.Amount as \"الاجمالي\"  FROM itemOrderDeail f JOIN dbo.itemorder o ON  f.order_id=o.ored_id  WHERE o.ored_date  BETWEEN '" + date_from.Value.ToString("yyyy-MM-dd") + "' AND '" + date_to.Value.ToString("yyyy-MM-dd") + "'  ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgv_sal.DataSource = tbl;

                // dgvitem.DataSource = tbl;


                dal.Close();
                // sumDataGrad();

                //totalSumdgv();

                totalSumdgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //=========================== دالة المشتروات
        private void BET_PRU()
        {

            try
            {
                //"SELECT o.cust_id as \"الرقم\" , o.ored_date as \"التارخ\", f.order_id as \"رقم الفاتورة\" ,f.ITEM_NAME_AR as \"أسم الصنف\", f.ITEM_COUNT as \"الكمية\", f.ITEM_PRIC as \"السعر\", f.Amount as \"الاجمالي\" FROM dbo.itemOrderDeail f JOIN dbo.itemorder o ON  f.order_id=o.ored_id  WHERE  o.ored_date BETWEEN '" + date_from.Value.ToString("yyyy-MM-dd") + "' AND '" + date_to.Value.ToString("yyyy-MM-dd") + "'  ", dal.con);
                //SELECT name_camp, inv_number ,type_payment,amount,ponas+'%' as ponas ,date,total FROM purchases
                //  SqlCommand cmd = new SqlCommand("SELECT name_camp as \"أسم الشركة\", inv_number as \"رقم الفاتورة\",amount as \"المبلغ\",ponas+'%' as \"القية\" ,date as \"التاريخ\",total as \"الاجمالي\" FROM purchases WHERE date BETWEEN '" + date_from.Value.ToString("yyyy-MM-dd") + "' AND '" + date_to.Value.ToString("yyyy-MM-dd") + "' ", dal.con);
                SqlCommand cmd = new SqlCommand("SELECT t.PUR_ord_ID as \"الفاتوره\" ,  t.item_name as \"الصنف\", t.purech_pric as \"السعر\" ,t.quntity as \"الكميه\" ,t.amount as \"الاجمالي\" ,i.PUR_DATE as \"التاريخ\" , s.SUP_NAME as \"المورد\" from PURCHES_ORDER_DETAIL t join PURCHES_ORDER i on t.PUR_ord_ID = i.PUR_ID join SUPLER s on i.SUP_ID = s.SUP_ID WHERE i.PUR_DATE BETWEEN '" + date_from.Value.ToString("yyyy-MM-dd") + "' AND '" + date_to.Value.ToString("yyyy-MM-dd") + "' ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgv_purch.DataSource = tbl;

                dal.Close();
               
                txt_total_purch.Text = (from DataGridViewRow row in dgv_purch.Rows
                                    where row.Cells[5].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();

                string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(txt_total_purch.Text));
                txt_total_purch.Text = formatted;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Between_sal()
        {
            try
            {
                DataTable dt1 = new DataTable();
                dt1 = man.search_between_sal(date_from.Value.ToString(), date_to.Value.ToString());
                this.dgv_sal.DataSource = dt1;
                txt_tot_sal.Text = (from DataGridViewRow row in dgv_sal.Rows
                                         where row.Cells[4].FormattedValue.ToString() != string.Empty
                                         select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            }
            catch { return; }

        }

        private void date_from_ValueChanged(object sender, EventArgs e)
        {
            BET_PRU();
            Between_Purch();
            //   Between_sal();
            BET_SEL();
        }

        private void date_to_ValueChanged(object sender, EventArgs e)
        {
            BET_PRU();
            BET_SEL();

            //Between_Purch();
            // Between_sal();
            //   BET_SEL();
        }

        private void date_from_ValueChanged_1(object sender, EventArgs e)
        {
            BET_PRU();
            BET_SEL();
            //Between_Purch();
            // Between_sal();
            // BET_SEL();
        }

        private void frm_search_SalAnd_purch_Load(object sender, EventArgs e)
        {

        }
        //======================


    }
}
