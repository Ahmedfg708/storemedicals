using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals.allform
{
    public partial class frmSuplerManger : Form
    {
        CLS.cls_supler sup = new CLS.cls_supler();
        public frmSuplerManger()
        {
            InitializeComponent();
           
            fill_dgv();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       public void fill_dgv()
        { 
        try
        {
            dgvSupler.DataSource = sup.GetAll_Supler();
        }catch{return;}
        
        }

        private void frmSuplerManger_Load(object sender, EventArgs e)
        {
            dgvSupler.Columns[0].Width = 30;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            allform.frmSupplier fm = new allform.frmSupplier();

            fm.ShowDialog();
            fill_dgv();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(dgvSupler.Rows.Count<1)
            {
                MessageBox.Show("لاتوجد بيانات  للتعديل ؟ ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            else if (dgvSupler.CurrentRow.Cells[1].Value.ToString() == "بدون عميل")
            {
                MessageBox.Show(" بيانات هذا المورد محمية من للتعديل ؟ ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmSupplier sup = new frmSupplier();
            try 
            {
                sup.lblAddres.Text = "تعديل بيانات الموردين";
                sup.btn_new.Visible = false;
                sup.btn_save.Enabled = true;
                sup.btn_save.Text = "تعديل";
                sup.btn_save.Location = new Point(500,20);
                sup.btn_save.ImageIndex = 5;
                sup.state = "update";

                sup.txtid.Text = dgvSupler.CurrentRow.Cells[0].Value.ToString();
                sup.txt_name.Text = dgvSupler.CurrentRow.Cells[1].Value.ToString();
                sup.txt_mobil.Text = dgvSupler.CurrentRow.Cells[2].Value.ToString();
                sup.txt_addres.Text = dgvSupler.CurrentRow.Cells[3].Value.ToString();
                sup.txt_company.Text = dgvSupler.CurrentRow.Cells[4].Value.ToString();
                sup.txt_not.Text = dgvSupler.CurrentRow.Cells[5].Value.ToString();
                sup.txt_national.Text = dgvSupler.CurrentRow.Cells[6].Value.ToString();
                sup.dateTimePicker1.Text = dgvSupler.CurrentRow.Cells[8].Value.ToString();
                sup.ShowDialog();
                fill_dgv();

            }
            catch
            {
                return;
            }
        }

        private void dgvSupler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_delet.Enabled = true;
            btn_update.Enabled = true;
        }

        private void dgvSupler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_delet.Enabled = true;
            btn_update.Enabled = true;
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            
           

            if (dgvSupler.Rows.Count > 0)
            {
                DialogResult ms = MessageBox.Show("هل تريد حذف البيانات", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                try
                {
                    
                          if (dgvSupler.CurrentRow.Cells[1].Value.ToString() == "بدون عميل")
                           {
                               MessageBox.Show(" بيانات هذا المورد محمية من للتعديل ؟ ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                          }

                    if (ms == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(this.dgvSupler.CurrentRow.Cells[0].Value);
                        sup.delet_supler(id);
                        MessageBox.Show("  تم حذف البيانات بنجاح", "تاكيد الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_delet.Enabled = true;
                        btn_update.Enabled = true;
                        fill_dgv();
                    }
                    else { fill_dgv(); }


                }
                catch { }
            }
            else
            {
                MessageBox.Show("لاتوجد بيانات للحذف", "تنبة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

           

        }

        private void frmSuplerManger_Activated(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                DataTable dt = new DataTable();
                dt = sup.search_supler(txt_search.Text);
                this.dgvSupler.DataSource = dt;
                
            }
            catch { return; }
        }

        private void btn_print_one_Click(object sender, EventArgs e)
        {
            
            try 
            {
                this.Cursor = Cursors.WaitCursor;
                int id;
                id= Convert.ToInt32(this.dgvSupler.CurrentRow.Cells[0].Value.ToString());
                reportsprint.frm_printRep fm = new reportsprint.frm_printRep();

                fm.sup_print_oneTableAdapter.Fill(fm.MEDICAL_STOREDataSet.sup_print_one,id);

            //    fm.reportViewer2.Visible = false;
            //    fm.reportViewer1.RefreshReport();
                this.Cursor = Cursors.Default;
                fm.ShowDialog();

            }
            catch 
            {
                this.Cursor = Cursors.Default;
                return;
            }
        }

        private void btn_print_all_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int id;
                id = Convert.ToInt32(this.dgvSupler.CurrentRow.Cells[0].Value.ToString());
                reportsprint.frm_printRep fm = new reportsprint.frm_printRep();

                fm.sup_print_AllTableAdapter.Fill(fm.MEDICAL_STOREDataSet.sup_print_All);

              //  fm.reportViewer1.Visible = false;
              //  fm.reportViewer2.RefreshReport();
                this.Cursor = Cursors.Default;
                fm.ShowDialog();

            }
            catch
            {
                this.Cursor = Cursors.Default;
                return;
            }
        }

        private void dgvSupler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
