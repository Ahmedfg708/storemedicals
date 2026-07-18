using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using storemedicals.reportsprint.repcust;

namespace storemedicals.allform
{
    public partial class frm_cust_mang : Form
    {
        CLS.cls_custmer cust = new CLS.cls_custmer();

        public frm_cust_mang()
        {
            InitializeComponent();
            fill_dgv();
            pictureBox1.Visible = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_cust_mang_Load(object sender, EventArgs e)
        {
            fill_dgv();
        }

        private void fill_dgv()
        {
            try
            {
                this.dgvcust.DataSource = cust.GetAll_cust();
                this.dgvcust.Columns[8].Visible = false;
                this.dgvcust.Columns[0].Width = 45;
            }
            catch { return; }
        }

        private void frm_cust_mang_Activated(object sender, EventArgs e)
        {
            fill_dgv();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            frm_addcustmer cust = new frm_addcustmer();

            if (dgvcust.Rows.Count > 0)
            {
                try
                {
                    cust.btn_new.Enabled = false;
                    cust.btn_new.Visible = false;
                    cust.state = "update";
                    cust.Text = "تعديل البيانات";
                    cust.btn_add.Location = new Point(328, 16);
                    cust.btn_add.Text = "تعديل ";
                    cust.btn_add.Enabled = true;

                    //==========================
                    if (this.dgvcust.CurrentRow.Cells[8].Value != DBNull.Value)
                    {
                        cust.txt_id.Text = this.dgvcust.CurrentRow.Cells[0].Value.ToString();
                        cust.txt_name.Text = this.dgvcust.CurrentRow.Cells[1].Value.ToString();
                        cust.txt_mob.Text = this.dgvcust.CurrentRow.Cells[2].Value.ToString();
                        cust.txt_addres.Text = this.dgvcust.CurrentRow.Cells[3].Value.ToString();
                        cust.txt_nation_num.Text = this.dgvcust.CurrentRow.Cells[4].Value.ToString();
                        cust.txt_email.Text = this.dgvcust.CurrentRow.Cells[5].Value.ToString();
                        cust.txt_company.Text = this.dgvcust.CurrentRow.Cells[6].Value.ToString();
                        cust.date_add.Text = this.dgvcust.CurrentRow.Cells[7].Value.ToString();
                        //ToString("yyyy_MM_dd");
                        var da = (byte[])this.dgvcust.CurrentRow.Cells["الصورة"].Value;
                        //var ms = new MemoryStream(da);
                        //cust.pictureBox1.Image = Image.FromStream(ms);

                        cust.txt_user.Text = this.dgvcust.CurrentRow.Cells[9].Value.ToString();
                        if (dgvcust.CurrentRow.Cells[1].Value.ToString() == "بدون زبون")
                        {
                            MessageBox.Show("  هذا السطر محمى من التعديل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        cust.ShowDialog();
                        fill_dgv();
                    }
                    else
                    {
                        cust.txt_id.Text = this.dgvcust.CurrentRow.Cells[0].Value.ToString();
                        cust.txt_name.Text = this.dgvcust.CurrentRow.Cells[1].Value.ToString();
                        cust.txt_mob.Text = this.dgvcust.CurrentRow.Cells[2].Value.ToString();
                        cust.txt_addres.Text = this.dgvcust.CurrentRow.Cells[3].Value.ToString();
                        cust.txt_nation_num.Text = this.dgvcust.CurrentRow.Cells[4].Value.ToString();
                        cust.txt_email.Text = this.dgvcust.CurrentRow.Cells[5].Value.ToString();
                        cust.txt_company.Text = this.dgvcust.CurrentRow.Cells[6].Value.ToString();
                        cust.date_add.Text = this.dgvcust.CurrentRow.Cells[7].Value.ToString();

                        cust.pictureBox1.Image = null;
                        cust.txt_user.Text = this.dgvcust.CurrentRow.Cells[9].Value.ToString();
                        if (dgvcust.CurrentRow.Cells[1].Value.ToString() == "بدون زبون")
                        {
                            MessageBox.Show("  هذا السطر محمى من التعديل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        cust.ShowDialog();
                        fill_dgv();
                    }
                //====================
                  }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
         
           }

        }

        private void dgvcust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvcust.CurrentRow.Cells[8].Value != DBNull.Value)
                {
                    pictureBox1.Visible = true;
                    var data = (byte[])this.dgvcust.CurrentRow.Cells["الصورة"].Value;
                    var ms = new MemoryStream(data);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                else
                { 
                    pictureBox1.Visible = false;
                }

            }
            catch { return; }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                frm_show_imgCust fm = new frm_show_imgCust();
                if (this.dgvcust.CurrentRow.Cells[8].Value != DBNull.Value)
                {
                    
                    var data = (byte[])this.dgvcust.CurrentRow.Cells["الصورة"].Value;
                    var ms = new MemoryStream(data);
                    fm.pic_cust.Image = Image.FromStream(ms);
                    fm.ShowDialog();
                }
                else
                {
                    pictureBox1.Visible = false;
                }

            }
            catch { return; }
            */
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_addcustmer fm = new frm_addcustmer();
            fm.ShowDialog();
            fill_dgv();

        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgvcust.CurrentRow.Cells[0].Value.ToString());
           

            if (dgvcust.Rows.Count > 0)
            {
                if (dgvcust.CurrentRow.Cells[1].Value.ToString() == "بدون زبون")
                {
                    MessageBox.Show("  هذا السطر محمى من الحذف", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult ms = MessageBox.Show("هل ريد حذف البيانات", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                try
                {

                    if (ms == DialogResult.Yes)
                    {
                        cust.delete_custmer(id);
                        MessageBox.Show("  تم حذف البيانات بنجاح", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        
                        fill_dgv();
                    } else { fill_dgv(); }


                }
                catch { }
            }
            else
            {
                MessageBox.Show("لاتوجد بيانات للحذف", "تنبة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btn_print_one_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int id;
                id = Convert.ToInt32(this.dgvcust.CurrentRow.Cells[0].Value.ToString());
                rep_cust fm = new rep_cust();
                fm.print_on_custmerTableAdapter.Fill(fm.MEDICAL_STOREDataSetCustmer.print_on_custmer, id);

                //reportsprint.repcust fm = new reportsprint.repcust()
                //fm.print_on_custmerTableAdapter.Fill(fm.MEDICAL_S
                //fm.sup_print_oneTableAdapter.Fill(fm.MEDICAL_STOREDataSet.sup_print_one, id);

            //    fm.reportViewer2.Visible = false;
             //   fm.reportViewer1.RefreshReport();
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
                id = Convert.ToInt32(this.dgvcust.CurrentRow.Cells[0].Value.ToString());
                rep_cust fm = new rep_cust();
                fm.print_All_custmerTableAdapter.Fill(fm.MEDICAL_STOREDataSetCustmer.print_All_custmer);
                //fm.sup_print_AllTableAdapter.Fill(fm.MEDICAL_STOREDataSet.sup_print_All);

              //  fm.reportViewer1.Visible = false;
             //   fm.reportViewer2.RefreshReport();
                this.Cursor = Cursors.Default;
              //  fm.ShowDialog();

            }
            catch
            {
                this.Cursor = Cursors.Default;
                return;
            }

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search_custmer();
        }
    //================
        private void search_custmer()
        { 
           try
            {
                DataTable dt = new DataTable();
                dt = cust.search_All_cust(txt_search.Text);
                dgvcust.DataSource = dt;
            }
            catch { return; }
        
        }

//==========================
    }
}
