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

namespace storemedicals.allform.purchees
{
    public partial class frm_purch_forManger : Form
    {
        Data.DataAccesLayer da = new Data.DataAccesLayer();
        CLS.cls_purch_order ord = new CLS.cls_purch_order();
        int id;
        public frm_purch_forManger()
        {
            InitializeComponent();
            fill_dgv(); 
        }

        private void fill_dgv()
        {
            try 
            {
                dgv_pur_ord.DataSource = ord.Get_all_fatoraShra();
            }
            catch { return; }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_fatorashra fm = new frm_fatorashra();
            fm.ShowDialog();
            fill_dgv();
            
        }
        //===============
      
        //===============
        private void frm_purch_forManger_Load(object sender, EventArgs e)
        {
            fill_dgv();
            
           
        }

        private void frm_purch_forManger_Activated(object sender, EventArgs e)
        {
            fill_dgv(); 
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {


            id = Convert.ToInt32(this.dgv_pur_ord.CurrentRow.Cells[0].Value.ToString());
            try
            {
                if ( MessageBox.Show("هل تريد حذف البيانات", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                     
                  
                    ord.Delet_PURCHES_ORDER(id);
                    MessageBox.Show("  تم حذف البيانات بنجاح", "تاكيد الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fill_dgv();

                }
                else
                {
                    btn_delete.Enabled = false;
                    fill_dgv();
                }
            }
            catch
            { return; }

   //===================================

        }

        private void dgv_pur_ord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_pur_ord.Rows.Count>0)
            {
               
                btn_delete.Enabled = true;
            }
            
        }

        private void dgv_pur_ord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_pur_ord.Rows.Count > 0)
            {
              
                btn_delete.Enabled = true;
            }

        }

        private void btn_print_all_Click(object sender, EventArgs e)
        {


            try
            {
                this.Cursor = Cursors.WaitCursor;

                reportsprint.Rep.crystal_print_allPurch myrep = new reportsprint.Rep.crystal_print_allPurch();            
                myrep.SetDataSource(ord.print_all());

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

        private void dgv_pur_ord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_pur_ord_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgv_pur_ord_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void dgv_pur_ord_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btn_delete.Enabled = true;
        }

        private void dgv_pur_ord_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_delete.Enabled = true;
        }

        private void dgv_pur_ord_DoubleClick(object sender, EventArgs e)
        {
            btn_delete.Enabled = true;
        }

        private void btn_print_one_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                reportsprint.Rep.crstal_print_onePurche myrep = new reportsprint.Rep.crstal_print_onePurche();
                int ID = Convert.ToInt32(this.dgv_pur_ord.CurrentRow.Cells[0].Value.ToString());
                myrep.SetDataSource(ord.print_on(ID));

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

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ord.Get_all_fator_byNumber(txt_search.Text);
                this.dgv_pur_ord.DataSource = dt;

            }
            catch { return; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fill_dgv();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // txt_search.Text

            try
            {
                DataTable dt = new DataTable();
                dt = ord.Get_all_fator_byNumber(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                this.dgv_pur_ord.DataSource = dt;

            }
            catch { return; }
        }

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}
    }
}
