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

namespace storemedicals.allform.item
{
    public partial class frm_manger_item : Form
    {
        Data.DataAccesLayer dal = new Data.DataAccesLayer();
        CLS.cls_item item = new CLS.cls_item();
        DataTable tblUse = new DataTable();

        string uetyp = "";

        public frm_manger_item()
        {
            InitializeComponent();
            txt_userAdd.Text = Program.user_Name;
            txt_search.Focus();
            txt_search.Select();
            txt_search.SelectAll();

            getUsrTYP();
            uetyp = (string)tblUse.Rows[0][0];


        }

        public void getUsrTYP()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT USER_TYPE  FROM USERES WHERE USER_FULL_NAME = '" + txt_userAdd.Text + "' ", dal.con);
                dal.open();


                tblUse.Load(cmd.ExecuteReader());

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
            if (uetyp == "موظف")
            {
                MessageBox.Show("هذا المستخدم ليس لديه صلاحية", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frm_Additem item = new frm_Additem();
            item.ShowDialog();
            fill_dgv();
        }

        private void fill_dgv()
        {
            try
            {

                dgv_item.DataSource = item.GetAll_item();
                dgv_item.Columns[0].Width = 40;
                dgv_item.Columns[1].Width = 140;
                dgv_item.Columns[3].Width = 50;
                dgv_item.Columns[4].Width = 79;
                dgv_item.Columns[5].Width = 79;
            }
            catch { return; }

        }

        private void frm_manger_item_Load(object sender, EventArgs e)
        {


            fill_dgv();
        }

        private void frm_manger_item_Activated(object sender, EventArgs e)
        {
            fill_dgv();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (uetyp == "موظف")
            {
                Form_updatequt frt = new Form_updatequt();

                frt.txtidt.Text = this.dgv_item.CurrentRow.Cells[0].Value.ToString();
                frt.txtqtyt.Text = this.dgv_item.CurrentRow.Cells[3].Value.ToString();
                frt.qu = Convert.ToInt32(this.dgv_item.CurrentRow.Cells[3].Value.ToString());
                frt.ShowDialog();
                fill_dgv();
            }

            else
            {

                frm_Additem fm = new frm_Additem();
                fm.Text = "تعديل";
                fm.stat = "update";
                fm.btn_new.Enabled = false;
                fm.btn_new.Visible = false;
                fm.btn_list_purch.Visible = false;
                fm.btn_add.Enabled = true;
                fm.btn_add.Text = "تعديل الصنف";
                fm.btn_add.Location = new Point(722, 16);
                fm.btn_add.ImageIndex = 5;
                //================
                //fm.load_comb_cat();
                //===============
                try
                {
                    fm.txtid.Text = this.dgv_item.CurrentRow.Cells[0].Value.ToString();
                    fm.txt_item_arb.Text = this.dgv_item.CurrentRow.Cells[1].Value.ToString();
                    fm.txt_barcod.Text = this.dgv_item.CurrentRow.Cells[2].Value.ToString();
                    fm.txtqty.Text = this.dgv_item.CurrentRow.Cells[3].Value.ToString();
                    fm.txt_pric.Text = this.dgv_item.CurrentRow.Cells[4].Value.ToString();
                    fm.txt_sal.Text = this.dgv_item.CurrentRow.Cells[5].Value.ToString();
                    fm.date_itemAdd.Text = this.dgv_item.CurrentRow.Cells[6].Value.ToString();
                    fm.date_expert.Text = this.dgv_item.CurrentRow.Cells[7].Value.ToString();
                    fm.txt_userAdd.Text = this.dgv_item.CurrentRow.Cells[8].Value.ToString();
                    fm.comb_catogry.Text = this.dgv_item.CurrentRow.Cells[9].Value.ToString();
                    fm.comb_store.Text = this.dgv_item.CurrentRow.Cells[10].Value.ToString();

                    fm.ShowDialog();
                    fill_dgv();



                }
                catch { return; }
            }
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            if (uetyp == "موظف")
            {
                MessageBox.Show("هذا المستخدم ليس لديه صلاحية", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(this.dgv_item.CurrentRow.Cells[0].Value.ToString());
            DialogResult ms = MessageBox.Show("هل ريد حذف البيانات", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dgv_item.Rows.Count > 0)
            {

                try
                {

                    if (ms == DialogResult.Yes)
                    {
                        item.delet_item(id);
                        MessageBox.Show("  تم حذف بيانات الصنف المحدد بنجاح", "تاكيد الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_privew_item_Click(object sender, EventArgs e)
        {
            frm_Additem fm = new frm_Additem();

            fm.btn_add.Visible = false;
            fm.btn_new.Visible = false;
            fm.btn_list_purch.Visible = false;


            try
            {
                fm.txtid.Text = this.dgv_item.CurrentRow.Cells[0].Value.ToString();
                fm.txt_item_arb.Text = this.dgv_item.CurrentRow.Cells[1].Value.ToString();
                fm.txt_barcod.Text = this.dgv_item.CurrentRow.Cells[2].Value.ToString();
                fm.txtqty.Text = this.dgv_item.CurrentRow.Cells[3].Value.ToString();
                fm.txt_pric.Text = this.dgv_item.CurrentRow.Cells[4].Value.ToString();
                fm.txt_sal.Text = this.dgv_item.CurrentRow.Cells[5].Value.ToString();
                fm.date_itemAdd.Text = this.dgv_item.CurrentRow.Cells[6].Value.ToString();
                fm.date_expert.Text = this.dgv_item.CurrentRow.Cells[7].Value.ToString();
                fm.txt_userAdd.Text = this.dgv_item.CurrentRow.Cells[8].Value.ToString();
                fm.comb_catogry.Text = this.dgv_item.CurrentRow.Cells[9].Value.ToString();
                fm.comb_store.Text = this.dgv_item.CurrentRow.Cells[10].Value.ToString();

                fm.ShowDialog();
                fill_dgv();
            }
            catch { return; }
        }

        private void dgv_item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_delet.Enabled = true;
            btn_update.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uetyp == "موظف")
            {
                MessageBox.Show("هذا المستخدم ليس لديه صلاحية", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frm_company fm = new frm_company();
            try
            {
                fm.txt_itemid.Text = this.dgv_item.CurrentRow.Cells[0].Value.ToString();
                //==========================
                try
                {
                    for (int i = 0; i < fm.dgv_company.Rows.Count; i++)
                    {
                        if (fm.dgv_company.Rows[i].Cells["رقم الصنف"].Value.ToString() == this.dgv_item.CurrentRow.Cells[0].Value.ToString())
                        {
                            MessageBox.Show("رقم هذا الصنف قد اضيف لة بيانات شركة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                catch { return; }
                //===========================
                fm.ShowDialog();
            }
            catch { return; }

        }

        private void btn_print_one_Click(object sender, EventArgs e)
        {
            if (uetyp == "موظف")
            {
                MessageBox.Show("هذا المستخدم ليس لديه صلاحية", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                this.Cursor = Cursors.WaitCursor;

                storemedicals.reportsprint.repitem.crys_print_on_item myrep = new reportsprint.repitem.crys_print_on_item();
                int id = Convert.ToInt32(this.dgv_item.CurrentRow.Cells[0].Value.ToString());
                myrep.SetParameterValue("@ID", id);

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

        private void btn_print_all_Click(object sender, EventArgs e)
        {
            if (uetyp == "موظف")
            {
                MessageBox.Show("هذا المستخدم ليس لديه صلاحية", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                this.Cursor = Cursors.WaitCursor;

                reportsprint.repitem.crys_print_All_item myrep = new reportsprint.repitem.crys_print_All_item();
                myrep.SetDataSource(item.print_All_item());

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
                dt = item.search_All_item(txt_search.Text);
                dgv_item.DataSource = dt;
            }
            catch { return; }
        }



        //======================

    }
}
