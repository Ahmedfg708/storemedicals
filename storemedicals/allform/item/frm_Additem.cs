using storemedicals.allform.purchees;
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

namespace storemedicals.allform.item
{
    public partial class frm_Additem : Form
    {
        char dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
        CLS.cls_catogry cat = new CLS.cls_catogry();
        CLS.cls_item it = new CLS.cls_item();
        CLS.cls_store str = new CLS.cls_store();
        Data.DataAccesLayer dal = new Data.DataAccesLayer();

        public string stat = "add";
        int purchid;

        public frm_Additem()
        {
            InitializeComponent();

            txt_userAdd.Text = Program.user_Name;
            load_comb_cat();
            fill_comb_stor();

        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_item_arb.Focus();
            }
        }

        private void txt_item_arb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pric.Focus();
            }
        }

        private void txt_pric_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_sal.Focus();
            }
        }

        private void txt_sal_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_item_eng_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_barcod.Focus();
            }
        }

        private void txt_barcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comb_catogry.Focus();
            }
        }

        private void comb_catogry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                date_itemAdd.Focus();
            }
        }

        private void date_itemAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                date_expert.Focus();
            }
        }

        private void date_expert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add_Click(sender, e);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            //=======================================insert
            if (stat == "add")
            {
                if (txt_item_arb.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" اضف اسم الصنف اولا", " حقل اجبارى", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_item_arb.Focus();
                    return;
                }
                else if (txtqty.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" اضف كمية الصنف اولا", " حقل اجبارى", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtqty.Focus();
                    return;
                }
                else if (txt_pric.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" اضف سعر الشراء للصنف اولا", " حقل اجبارى", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_pric.Focus();
                    return;
                }
                else if (txt_sal.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" اضف سعر البيع للصنف اولا", " حقل اجبارى", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_sal.Focus();
                    return;
                }

                //====================================
                try
                {

                    //   it.insert_item(Convert.ToInt32(txtid.Text), txt_item_arb.Text, txt_barcod.Text, Convert.ToInt32(txtqty.Text), Convert.ToDecimal(txt_pric.Text),
                    //   Convert.ToDecimal(txt_sal.Text), date_itemAdd.Value.ToString("yyyy-MM-dd"), date_expert.Value.ToString("yyyy-MM-dd")
                    //, txt_userAdd.Text, Convert.ToInt32(comb_catogry.SelectedIndex + 1), Convert.ToInt32(comb_store.SelectedIndex + 1));

                    SqlCommand cmd = new SqlCommand("INSERT INTO ITEMS VALUES ('"+ Convert.ToInt32(txtid.Text) + "' , '"+ txt_item_arb.Text + "' , '"+ txt_barcod.Text + "' , '"+ Convert.ToInt32(txtqty.Text) + "' , '"+ Convert.ToDecimal(txt_pric.Text) + "' , '"+ Convert.ToDecimal(txt_sal.Text) + "' , '"+ date_itemAdd.Value.ToString("yyyy-MM-dd") + "' , '"+ date_expert.Value.ToString("yyyy-MM-dd") + "' , '"+ txt_userAdd.Text + "' , '"+ Convert.ToInt32(comb_catogry.SelectedIndex + 1) + "' , '"+ Convert.ToInt32(comb_store.SelectedIndex + 1) + "')", dal.con);

                    dal.open();
                    cmd.ExecuteNonQuery();
                    dal.Close();

                    //=====================================
                  //  try
                  //  {
                       // it.status_Update(txt_status.Text, txt_item_arb.Text, purchid);
                  //  }
                  //  catch (Exception ex1)
                   // {
                     //   MessageBox.Show("ex1 \n" + ex1.Message);
                   // }

                    //================================

                    MessageBox.Show(" تمت اضافة الصنف بنجاح  ");

                    btn_add.Enabled = false;
                    btn_new.Enabled = true;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //====================================
                cleartxt();
            }

            //======================================== update
            else if (stat == "update")
            {
                //  it.update_item(Convert.ToInt32(txtid.Text), txt_item_arb.Text, txt_barcod.Text, Convert.ToInt32(txtqty.Text), Convert.ToDecimal(txt_pric.Text),
                //  Convert.ToDecimal(txt_sal.Text), date_itemAdd.Value.ToString("yyyy-MM-dd"), date_expert.Value.ToString("yyyy-MM-dd")
                //  , Convert.ToInt32(comb_catogry.SelectedValue), Convert.ToInt32(comb_store.SelectedValue));

                SqlCommand cmd1 = new SqlCommand("UPDATE  ITEMS SET ITEM_NAME_AR = '"+ txt_item_arb.Text + "' , ITEM_BARCOD = '"+ txt_barcod.Text + "' , ITEM_COUNT = '"+ Convert.ToInt32(txtqty.Text) + "' , ITEM_PRIC = '"+ Convert.ToDecimal(txt_pric.Text) + "' , ITEM_SAL = '"+ Convert.ToDecimal(txt_sal.Text) + "' , ITEM_DATE = '"+ date_itemAdd.Value.ToString("yyyy-MM-dd") + "' , ITEM_DATE_EXPRT = '"+ date_expert.Value.ToString("yyyy-MM-dd") + "' , CAT_ID = '"+ Convert.ToInt32(comb_catogry.SelectedValue) + "' , STOR_ID = '"+ Convert.ToInt32(comb_store.SelectedValue) + "' where ITEM_ID = '"+ Convert.ToInt32(txtid.Text) + "' ", dal.con);

                dal.open();
                cmd1.ExecuteNonQuery();
                MessageBox.Show(" تمت تعديل الصنف بنجاح  ", "  تاكيد التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dal.Close();
                cleartxt();
                btn_add.Enabled = false;


            }
            //========================================



        }

        private void cleartxt()
        {
            txtid.Clear();
            txtqty.Clear();
            txt_sal.Clear();
            txt_pric.Clear();
            txt_item_arb.Clear();
            txt_barcod.Clear();
            date_expert.ResetText();
            comb_catogry.SelectedItem = null;
            comb_store.SelectedItem = null;

        }
        private void txt_pric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void txt_sal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_list_purch_Click(object sender, EventArgs e)
        {

            try
            {
                frm_purch_list fm = new frm_purch_list();
                fm.ShowDialog();
                purchid = Convert.ToInt32(fm.dgv_pur_ord.CurrentRow.Cells[0].Value);
                txt_barcod.Text = fm.dgv_pur_ord.CurrentRow.Cells[2].Value.ToString();
                txt_item_arb.Text = fm.dgv_pur_ord.CurrentRow.Cells[3].Value.ToString();
                txt_pric.Text = fm.dgv_pur_ord.CurrentRow.Cells[4].Value.ToString();
                txtqty.Text = fm.dgv_pur_ord.CurrentRow.Cells[5].Value.ToString();

            }
            catch { return; }
        }

        private void frm_Additem_Load(object sender, EventArgs e)
        {



        }

        //===============================
        public void fill_comb_stor()
        {
            try
            {
                this.comb_store.DataSource = str.GetAllstor();

                this.comb_store.DisplayMember = "اسم المخزن";
                this.comb_store.ValueMember = "رقم المخزن";
                // this.comb_catogry.SelectedText = "======اختر اسم المجموعة ========";

            }
            catch { return; }
        }
        //========================================
        public void load_comb_cat()
        {
            try
            {
                this.comb_catogry.DataSource = cat.GetAllcatogry();

                this.comb_catogry.DisplayMember = "اسم المجموعة";
                this.comb_catogry.ValueMember = "رقم المجموعة";


            }
            catch { return; }

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                txtid.Text = it.GetMaxid().Rows[0][0].ToString();
                btn_add.Enabled = true;
                btn_new.Enabled = false;

            }
            catch { return; }
        }

        private void comb_catogry_DropDown(object sender, EventArgs e)
        {
            load_comb_cat();

        }

        private void comb_store_DropDown(object sender, EventArgs e)
        {

            fill_comb_stor();
        }
    }
}
