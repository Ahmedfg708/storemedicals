using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace storemedicals.allform
{
    public partial class UserControlPurch : UserControl
    {
        CLS.cls_purch_order pur = new CLS.cls_purch_order();
        char dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
        DataTable dt = new DataTable();

        public UserControlPurch()
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
                pur.purch_Insert(Convert.ToInt32(txt_pur_id.Text), date_purch.Value.ToShortDateString(),
                    txt_puch_dec.Text, Convert.ToInt32(txt_sppler_id.Text), txt_userAdd.Text);
                      MessageBox.Show("تم اضافة البيانات بنجاح", "تاكيد الحفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      txt_pur_id.Text = txt_puch_dec.Text=txt_sup_id.Text ="";
                      date_purch.ResetText();

            }
            catch
            {
                return;
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txt_puch_dec_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txt_fator_id.Focus();
            }
        }

        private void rd_not_supler_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void rd_add_supler_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //System.Environment.Exit(0);
            
                
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pnl_sup.Enabled = false;
            txt_sppler_id.Text = "1";
            txt_suppler_name.Text = "بدون مورد";
            txt_suppler_company.Clear();
            txt_suppler_phon.Clear();
        }

        private void rd_yes_supler_CheckedChanged(object sender, EventArgs e)
        {
            pnl_sup.Enabled = true;
            txt_sppler_id.Text = "";
            txt_suppler_name.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void txt_fator_id_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txt_barcod.Focus();
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

        private void btn_add_item_Click(object sender, EventArgs e)
        {

            try 
            {
                if(txt_fator_id.Text.Trim()==string.Empty || txt_barcod.Text.Trim()==string.Empty 
                    ||txt_item_nam.Text.Trim()==string.Empty  ||txt_purch_pric.Text.Trim()==string.Empty
                    || txt_qunty.Text.Trim() == string.Empty || txt_pric_untiy.Text.Trim() == string.Empty || txt_amount.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("عزرا لايمكن اضافة  حقل فارغ ","تنبية",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
        void totalSumdgv()
        {
            try
            {
                if (txt_total_amount.Text == string.Empty)
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
                    double reslt = pric / qty;
                    txt_pric_untiy.Text = reslt.ToString();
                    txt_amount.Text = pric.ToString();
                }
            }
            catch { return; }
        }
        //====================
        private void txt_qunty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btn_add_item_Click(sender, e);
            }
        }
      //==========================
    

        private void txt_purch_pric_KeyUp(object sender, KeyEventArgs e)
        {
            Dev();
        }

        private void txt_qunty_KeyUp(object sender, KeyEventArgs e)
        {
            Dev();
        }

        private void txt_purch_pric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar !=dec)
            {
                e.Handled = true;
            }
           
        }

        private void txt_qunty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
           
        }

        private void txt_fator_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
            {
                e.Handled = true;
            }
            
        }

        private void txt_suppler_phon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar !=8 )
            {
                e.Handled = true;
            }
            
        }
     //==========================
      
        void addData()
        {
            try
            {
                dt.Columns.Add("رقم ايصال الشراء");
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

        private void dgvitem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetData_dgv();
        }

        private void dgvitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetData_dgv();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void حذفالسطرالحالىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { dgvitem.Rows.RemoveAt(dgvitem.CurrentRow.Index); }
            catch { return; }
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dgvitem.DataSource = null;
        }

        private void تعديلالسطرالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetData_dgv();
        }
     //=========================
    }
}
