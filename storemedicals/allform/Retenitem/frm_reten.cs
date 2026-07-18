using storemedicals.allform.Retenitem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals.allform.Reten
{
    public partial class frm_reten : Form
    {
        CLS.cls_reten class_retn = new CLS.cls_reten();
        DataTable dt1 = new DataTable();
       // CLS.cls_reten sal = new CLS.cls_sale();
        public string state = "add";

        public frm_reten()
        {
            InitializeComponent();
            btn_add.Enabled = false;
            btn_new.Focus();
            txt_userAdd.Text = Program.user_Name;
        }

        private void txt_pric_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                txt_retn_id.Text = class_retn.GetMaxid().Rows[0][0].ToString();
                btn_add.Enabled = true;
                btn_new.Enabled = false;
                txt_barcod.Focus();

            }
            catch { return; }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_reten_Load(object sender, EventArgs e)
        {

        }

        private void txt_barcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txt_item_name.Focus(); }
        }

        private void txt_item_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txt_pric.Focus(); }
        }

        private void txt_pric_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txtqty.Focus(); }
        }

        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txt_tot_amount.Focus(); }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_order_id.Text == string.Empty || txt_item_id.Text == string.Empty ||
                txt_item_name.Text == string.Empty || txt_pric.Text == string.Empty || txt_retn_id.Text == string.Empty || txt_tot_amount.Text == string.Empty
                                   || txt_amount.Text == string.Empty)
            {
                MessageBox.Show("توجد حقول فارغة قم بتعبئة جميع الحقول","حقل اجبارى",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
        //========================
            try
            {
                if (state == "add")
                {
                     class_retn.insert_item(Convert.ToInt32(txt_retn_id.Text), Convert.ToInt32(txt_order_id.Text), txt_barcod.Text, txt_item_name.Text,
                     txt_pric.Text, Convert.ToInt32(txtqty.Text), txt_tot_amount.Text, date_reten.Value.ToString("yyyy-MM-dd"), txt_userAdd.Text,
                     txt_stat_id.Text, txt_not.Text,Convert.ToInt32(txt_item_id.Text) );
                    MessageBox.Show("تم عملية حفظ البيانات بنجاح", "حفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clrtxt();
                    btn_new.Enabled = true;
                    btn_add.Enabled = false;
                }
               //======================
                if (state == "update")
                {
                    class_retn.update_item(Convert.ToInt32(txt_retn_id.Text), Convert.ToInt32(txt_order_id.Text), txt_barcod.Text, txt_item_name.Text,
                    txt_pric.Text, Convert.ToInt32(txtqty.Text), txt_tot_amount.Text, date_reten.Value.ToString("yyyy-MM-dd"),
                    txt_userAdd.Text, txt_stat_id.Text, txt_not.Text, Convert.ToInt32(txt_item_id.Text));
                    MessageBox.Show("تم عملية تعديل البيانات بنجاح", " تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clrtxt();
                    btn_item_list.Enabled = false;
                    btn_add.Enabled = false;
                }
            //============================
                if (state == "prov")
                {
                    try 
                    {
                        class_retn.updat_qty_RetenItem(Convert.ToInt32(txt_item_id.Text), Convert.ToInt32(txtqty.Text));
                      
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        return;
                    }
                 //=============================
                    try
                    {
                        class_retn.updat_State_RetenItem(txt_reten_stat.Text, Convert.ToInt32(txt_retn_id.Text));
                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        return;
                    }
                    MessageBox.Show("تم عملية ارجاع كميةالصنف  بنجاح", "مرتجع ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clrtxt();
                    btn_new.Enabled = true;
                    btn_add.Enabled = false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("خطا فى الادخال"+Environment.NewLine+ex.ToString());
                return; 
            }

        //=========================
        }

        private void clrtxt()
        {
                txt_item_id.Text = "";
                txtqty.Text = "";
                txt_amount.Text = "";
                txt_barcod.Text = "";
                txt_item_name.Text = "";
                txt_not.Text = txt_order_id.Text = txt_pric.Text = txt_retn_id.Text = txt_tot_amount.Text = "";

        }

        private void txt_tot_reten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_not.Focus();
            }
        }

        private void txt_barcod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_barcod.Text.Trim() != string.Empty)
                {
                  
                    dt1 = class_retn.Get_barcod_retenitem(txt_barcod.Text);
                    if (dt1.Rows.Count > 0)
                    {
                        txt_item_id.Text = dt1.Rows[0][0].ToString();
                        txt_order_id.Text = dt1.Rows[0][1].ToString();
                        txt_item_name.Text = dt1.Rows[0][2].ToString();
                        txt_barcod.Text = dt1.Rows[0][3].ToString();
                        txtqty.Text = dt1.Rows[0][4].ToString();
                        txt_pric.Text = dt1.Rows[0][5].ToString();
                        txt_amount.Text = dt1.Rows[0][6].ToString();
                        txt_tot_amount.Text = dt1.Rows[0][7].ToString();
                        txt_not.Focus();
                       
                    }

                }

            } catch { return; }
  //==============================
        }

        private void txt_not_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btn_add_Click(sender, e); }
        }

        private void btn_item_list_Click(object sender, EventArgs e)
        {
            frm_retnlistitem fm = new frm_retnlistitem();
            fm.ShowDialog();
            try
            {
                txt_item_id.Text = fm.dgv_sal_ord.CurrentRow.Cells[0].Value.ToString();
                txt_order_id.Text = fm.dgv_sal_ord.CurrentRow.Cells[1].Value.ToString();
                txt_item_name.Text = fm.dgv_sal_ord.CurrentRow.Cells[2].Value.ToString();
                txt_barcod.Text = fm.dgv_sal_ord.CurrentRow.Cells[3].Value.ToString();
                txtqty.Text = fm.dgv_sal_ord.CurrentRow.Cells[4].Value.ToString();
                txt_pric.Text = fm.dgv_sal_ord.CurrentRow.Cells[5].Value.ToString();
                txt_amount.Text = fm.dgv_sal_ord.CurrentRow.Cells[6].Value.ToString();
                txt_tot_amount.Text = fm.dgv_sal_ord.CurrentRow.Cells[7].Value.ToString();
                txt_not.Focus();
            }
            catch { return; }

        }

        //=================
        public void calclaAmount()
        {
            try
            {

                if (txt_pric.Text.Trim() != string.Empty && txtqty.Text.Trim() != string.Empty)
                {
                    double pric = Convert.ToDouble(txt_pric.Text);
                    double qunty = Convert.ToDouble(txtqty.Text);
                    double reslet = pric * qunty;
                    txt_amount.Text = reslet.ToString();
                    txt_tot_amount.Text = reslet.ToString();

                }

            }
            catch { return; }

        }

        private void txtqty_KeyUp(object sender, KeyEventArgs e)
        {
            calclaAmount();
        }

        private void txt_amount_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txt_pric_KeyUp(object sender, KeyEventArgs e)
        {
            calclaAmount();
        }
  //============================

    }
}
