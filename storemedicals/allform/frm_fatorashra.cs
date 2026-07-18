using storemedicals.allform.sales;
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

namespace storemedicals.allform
{
    public partial class frm_fatorashra : Form
    {
        CLS.cls_purch_order pur = new CLS.cls_purch_order();
        Data.DataAccesLayer dal = new Data.DataAccesLayer();
        char dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
        DataTable dt = new DataTable();
        public frm_fatorashra()
        {
            InitializeComponent();
            btn_save.Enabled = false;
            btn_new.Focus();
            pnl_sup.Enabled = false;
            txt_pur_id.Enabled = false;
            rd_add_supler.Enabled = true;
            txt_userAdd.Text = Program.user_Name;
            addData();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                txt_pur_id.Text = pur.purch_Maxid().Rows[0][0].ToString();
                btn_save.Enabled = true;
                btn_new.Enabled = false;

                txt_sppler_id.Text = "1";
                txt_suppler_name.Text = "بدون مورد";
                txt_puch_dec.Focus();

            }
            catch { return; }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_pur_id.Text.Trim()==string.Empty|| txt_userAdd.Text.Trim() == string.Empty ||
                    txt_sppler_id.Text.Trim() == string.Empty   || dgvitem.Rows.Count<1 )
                {
                    MessageBox.Show("تاكدمن الحقول لايمكن اضافة حقول فارغة فى الفاتورة", " تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                pur.purch_Insert(Convert.ToInt32(txt_pur_id.Text), date_purch.Value.ToString("yyyy-MM-dd"),
                    txt_puch_dec.Text, Convert.ToInt32(txt_sppler_id.Text), txt_userAdd.Text);
               
                
                //===================================حفظ تفاصيل الفاتورة
                //dt.Columns.Add("رقم ايصال الشراء");
                //dt.Columns.Add("الباركود");
                //dt.Columns.Add("اسم الصنف");
                //dt.Columns.Add("سعر الشراء");
                //dt.Columns.Add("الكمية");
                //dt.Columns.Add("سعر الوحدة");
                //dt.Columns.Add("المبلغ");
                try
                {
                    for (int i = 0; i < dgvitem.Rows.Count; i++)
                    {
                        pur.insert_PURCHES_ORDER_DETAIL_(
                            Convert.ToInt32(txt_pur_id.Text),
                            dgvitem.Rows[i].Cells[0].Value.ToString(),
                            dgvitem.Rows[i].Cells[1].Value.ToString(),
                            dgvitem.Rows[i].Cells[2].Value.ToString(),
                            dgvitem.Rows[i].Cells[3].Value.ToString(),
                            Convert.ToInt32( dgvitem.Rows[i].Cells[4].Value.ToString()),
                            dgvitem.Rows[i].Cells[5].Value.ToString(),
                            dgvitem.Rows[i].Cells[6].Value.ToString(),
                           
                            labstatus.Text

                             );

                        int idin = 0;

                        idin = Convert.ToInt32(this.dgvitem.Rows[i].Cells[0].Value.ToString());

                        SqlCommand cmd11 = new SqlCommand("update ITEMS set ITEM_COUNT =ITEM_COUNT+'" + this.dgvitem.Rows[i].Cells[4].Value.ToString() + "' , ITEM_SAL = '"+ this.dgvitem.Rows[i].Cells[5].Value.ToString() + "' where ITEM_ID = '" + Convert.ToInt32(idin) + "' ", dal.con);

                        dal.open();
                        cmd11.ExecuteNonQuery();

                        dal.Close();
                        idin = 0;
                    }

                }
                catch
                { return; }

                //========================================
                MessageBox.Show("تم اضافة البيانات بنجاح", "تاكيد الحفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);


           /*     DialogResult ms= MessageBox.Show("هل ترغب بطباعة هذة الفاورة", " تنبية ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(ms==DialogResult.Yes)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;

                        reportsprint.Rep.crstal_print_onePurche myrep = new reportsprint.Rep.crstal_print_onePurche();
                        int ID = Convert.ToInt32(txt_pur_id.Text);
                        myrep.SetParameterValue("@id",ID);

                        reportsprint.Rep.frm_purch_on fm = new reportsprint.Rep.frm_purch_on();
                        fm.crystalReportViewer1.ReportSource=myrep;
                      
                        this.Cursor = Cursors.Hand;
                        fm.ShowDialog();
                    
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("خطا فى طباعة التقرير"+ex.ToString());
                    }

                }*/
                clearAlltxt();
                btn_new.Enabled=true;
                btn_save.Enabled=false;

            }
            catch
            {
                return;
            }
        }
        //==========================
        void clearAlltxt()
        {
            txt_pur_id.Clear();
            txt_puch_dec.Clear();
            txt_sppler_id.Clear();
            txt_suppler_name.Clear();
            txt_suppler_company.Clear();
            txt_suppler_phon.Clear();
            txt_total_amount.Clear();
            dgvitem.DataSource = null;
            cleartxt();
            dt.Clear();
        }
        //=================
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_item_Click(object sender, EventArgs e)
        {
             try
            {
                if (txt_fator_id.Text.Trim() == string.Empty 
                    || txt_item_nam.Text.Trim() == string.Empty || txt_purch_pric.Text.Trim() == string.Empty
                    || txt_qunty.Text.Trim() == string.Empty || txt_pric_untiy.Text.Trim() == string.Empty || txt_amount.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("عزرا لايمكن اضافة  حقل فارغ ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_fator_id.Focus();
                    return;
                }
                DataRow row = dt.NewRow();
                row[0] = txt_fator_id.Text;
                row[1] = txt_barcod.Text;
                row[2] = txt_item_nam.Text;
                row[3] = txt_purch_pric.Text;
                row[4] = txt_qunty.Text;
                row[5] = txt_pric_untiy.Text;
                row[6] = txt_amount.Text;
                dt.Rows.Add(row);
                this.dgvitem.DataSource = dt;
                totalSumdgv();
                cleartxt();
                txt_fator_id.Focus();
            }
            catch { return; }
        }

        private void dgvitem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GetData_dgv();
                totalSumdgv();
            }
            catch { return; }
            
        }

        //=========================
        void GetData_dgv()
        {
            try
            {
                txt_fator_id.Text = dgvitem.CurrentRow.Cells[0].Value.ToString();
                txt_barcod.Text = dgvitem.CurrentRow.Cells[1].Value.ToString();
                txt_item_nam.Text = dgvitem.CurrentRow.Cells[2].Value.ToString();
                txt_purch_pric.Text = dgvitem.CurrentRow.Cells[3].Value.ToString();
                txt_qunty.Text = dgvitem.CurrentRow.Cells[4].Value.ToString();
                txt_pric_untiy.Text = dgvitem.CurrentRow.Cells[5].Value.ToString();
                txt_amount.Text = dgvitem.CurrentRow.Cells[6].Value.ToString();
                dgvitem.Rows.RemoveAt(dgvitem.CurrentRow.Index);
            }
            catch { return; }
        }
        //==========================
       private void totalSumdgv()
        {
            try
            {
                if (dgvitem.Rows.Count<1)
                {
                    txt_total_amount.Text = "0";
                }
                else
                {
                    txt_total_amount.Text = (from DataGridViewRow row in dgvitem.Rows
                                             where row.Cells[6].FormattedValue.ToString() != string.Empty
                                             select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
                }

            }
            catch { return; }

        }

        //======================
        void cleartxt()
        {
            txt_fator_id.Clear();
            txt_barcod.Clear();
            txt_item_nam.Clear();
            txt_purch_pric.Clear();
            txt_qunty.Clear();
            txt_pric_untiy.Clear();
            txt_amount.Clear();
        }
        //======================
        public void Dev()
        {
            try
            {
                if (txt_purch_pric.Text.Trim() != string.Empty && txt_qunty.Text.Trim() != string.Empty)
                {
                    
                    double pric = Convert.ToDouble(txt_purch_pric.Text);
                    double qty = Convert.ToDouble(txt_qunty.Text);
                    double reslt = (pric  * qty);
                    Math.Round(reslt);
                   // txt_pric_untiy.Text =string.Format( "{0:0##}",reslt);
                    //txt_pric_untiy.Text = Math.Round(reslt, 2).ToString(); تقريب رقمين     12.45
                  //  txt_pric_untiy.Text = Math.Round(reslt).ToString();
                    txt_amount.Text = reslt.ToString();
                }
            }
            catch { return; }
        }
        //====================
        void addData()
        {
            try
            {
                dt.Columns.Add("رقم الصنف");
                dt.Columns.Add("الباركود");
                dt.Columns.Add("اسم الصنف");
                dt.Columns.Add("سعر الشراء");
                dt.Columns.Add("الكمية");
                dt.Columns.Add("سعر الوحدة");
                dt.Columns.Add("المبلغ");
               
                this.dgvitem.DataSource = dt;
            }
            catch { return; }

        }
        //====================

        private void txt_fator_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_barcod.Focus();
            }
        }

        private void txt_fator_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8.0)
            {
                e.Handled = true;
            }
        }

        private void txt_barcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_item_nam.Focus();
            }
        }

        private void txt_item_nam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_purch_pric.Focus();
            }
        }

        private void txt_purch_pric_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_qunty.Focus();
            }
        }

        private void txt_purch_pric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void txt_purch_pric_KeyUp(object sender, KeyEventArgs e)
        {
            Dev();
        }

        private void txt_qunty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btn_add_item_Click(sender, e);
            }
        }

        private void txt_qunty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void txt_qunty_KeyUp(object sender, KeyEventArgs e)
        {
            Dev();
        }

        private void rd_no_supler_CheckedChanged(object sender, EventArgs e)
        {
            pnl_sup.Enabled = false;
            txt_sppler_id.Text = "1";
            txt_suppler_name.Text = "بدون مورد";
            txt_suppler_company.Clear();
            txt_suppler_phon.Clear();
        }

        private void rd_add_supler_CheckedChanged(object sender, EventArgs e)
        {
            pnl_sup.Enabled = true;
            txt_sppler_id.Text = "";
            txt_suppler_name.Text = "";
        }

        private void btn_add_suppler_Click(object sender, EventArgs e)
        {
            frm_suppList suplist = new frm_suppList();
            try
            {
                suplist.ShowDialog();
                txt_sppler_id.Text = suplist.dgvSupler.CurrentRow.Cells[0].Value.ToString();
                txt_suppler_name.Text = suplist.dgvSupler.CurrentRow.Cells[1].Value.ToString();
                txt_suppler_phon.Text = suplist.dgvSupler.CurrentRow.Cells[2].Value.ToString();
                txt_suppler_company.Text = suplist.dgvSupler.CurrentRow.Cells[4].Value.ToString();
                txt_fator_id.Focus();
            }
            catch
            {
                return;
            }
        }

        private void frm_fatorashra_Load(object sender, EventArgs e)
        {
            pnl_sup.Enabled = false;
            txt_sppler_id.Text = "1";
            txt_suppler_name.Text = "بدون مورد";
            txt_suppler_company.Clear();
            txt_suppler_phon.Clear();
        }

        private void حذفالسطرالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                if (dgvitem.Rows.Count < 1)
                {
                    return;
                }
                dgvitem.Rows.RemoveAt(dgvitem.CurrentRow.Index);
                totalSumdgv();
            }
            catch { return; }
        }

        private void تعديلالسطرالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                GetData_dgv();
                totalSumdgv();
            }
            catch { return; }
            
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvitem.Rows.Count < 1)
                {
                    return;
                }
                dt.Clear();
                dgvitem.DataSource = null;
                txt_total_amount.Text = "0";
            }
            catch { return; }
          
        }

        private void dgvitem_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try { totalSumdgv(); }
            catch { return; }
        }

        private void txt_purch_pric_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pric_untiy_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_item_Click(object sender, EventArgs e)
        {
            frm_itemList fm = new frm_itemList();
            fm.ShowDialog();

            try
            {
                txt_fator_id.Text = fm.dgvitem.CurrentRow.Cells[0].Value.ToString();
                txt_item_nam.Text = fm.dgvitem.CurrentRow.Cells[1].Value.ToString();
                txt_pric_untiy.Text = fm.dgvitem.CurrentRow.Cells[5].Value.ToString();

                txt_purch_pric.Focus();
                txt_purch_pric.Select();
                txt_purch_pric.SelectAll();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_pric_untiy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btn_add_item_Click(sender, e);
            }
        }
    }
}
