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
    public partial class frmUserMannger : Form
    {
        CLS.cls_user us = new CLS.cls_user();
        public frmUserMannger()
        {
            InitializeComponent();
            
            fill_dgv();
        }

        private void fill_dgv()
        {
            try
            {
                dgvuser.DataSource = us.GetAll_User();
            }
            catch{return;}
          
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserMannger_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_new_Click_1(object sender, EventArgs e)
        {
            allform.frmAddusers fm = new frmAddusers();
            fm.ShowDialog();
            fill_dgv();
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            frmAddusers fm = new frmAddusers();
            fm.Text = "تعديل بيانات المستخدم";
            fm.btn_new.Visible = false;
            fm.btn_save.Text = "تعديل";
            fm.btn_save.Enabled = true;
            fm.btn_save.Location = new Point(400,12);
            fm.txt_activ.Enabled = false;
            fm.txt_activ.Visible = false;
            fm.state = "update";
            try 
            {
                fm.txtid.Text = this.dgvuser.CurrentRow.Cells[0].Value.ToString();
                fm.txt_name.Text = this.dgvuser.CurrentRow.Cells[1].Value.ToString();
                fm.txt_pass.Text = this.dgvuser.CurrentRow.Cells[2].Value.ToString();
                fm.txt_confirmpass.Text = this.dgvuser.CurrentRow.Cells[2].Value.ToString();
                fm.comb_type.Text = this.dgvuser.CurrentRow.Cells[3].Value.ToString();
                fm.txt_mobial.Text = this.dgvuser.CurrentRow.Cells[4].Value.ToString();
                fm.txt_fullname.Text = this.dgvuser.CurrentRow.Cells[5].Value.ToString();
                fm.txt_activ.Text = this.dgvuser.CurrentRow.Cells[6].Value.ToString();
                if (this.dgvuser.CurrentRow.Cells[8].Value.ToString() == "صباح")
                {
                   fm.comBoxPink.SelectedIndex = 0;
                }
                else if(this.dgvuser.CurrentRow.Cells[8].Value.ToString() == "مساء")
                {
                    fm.comBoxPink.SelectedIndex = 1;
                }
                else
                {
                    fm.comBoxPink.SelectedIndex = 2;
                }

                //if (fm.txt_activ.Text.Contains("True")) 
                //{
                //    fm.ch_yes.Checked = true;
                //}
                //========================
                if (fm.txt_activ.Text.Contains("True"))
                {
                    fm.rdyes.Checked = true;
                }
                if (fm.txt_activ.Text.Contains("False"))
                {
                    fm.rdno.Checked = true;
                }
                //============================
                //if (fm.txt_activ.Text .Contains("False"))
                //{
                //    fm.ch_no.Checked = true;
                //}
                fm.date_user.Text = this.dgvuser.CurrentRow.Cells[7].Value.ToString();
                fm.ShowDialog();
                fill_dgv();
            }
            catch
            {
                return;
            }
        }

        private void dgvuser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_delet.Enabled = true;
            btn_update.Enabled = true;
        }

        private void dgvuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_delet.Enabled = true;
            btn_update.Enabled = true;
        }

        private void dgvuser_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_delet.Enabled = true;
            btn_update.Enabled = true;
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgvuser.CurrentRow.Cells[0].Value.ToString());
            DialogResult ms = MessageBox.Show("هل ريد حذف البيانات", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dgvuser.Rows.Count > 0)
            {

                try
                {

                    if (ms == DialogResult.Yes)
                    {
                        us.User_delet(id);
                        MessageBox.Show("  تم حذف البيانات بنجاح", "تاكيد الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_delet.Enabled = false;
                        btn_update.Enabled = false;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvuser.DataSource = us.GetAll_User();
        }
    }
}
