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

namespace storemedicals.allform.purchees
{
    public partial class frm_purchases : Form
    {
        Data.DataAccesLayer dal = new Data.DataAccesLayer();
        char dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
        string typ_money = "";

        public frm_purchases()
        {
            InitializeComponent();
        
            txt_userAdd.Text = Program.user_Name;
        }




        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tex_ne_com.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("من فضلك حدد اسم الشركة");
                    tex_ne_com.Focus();
                    tex_ne_com.SelectAll();
                }
                else if (tex_inv.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("من فضلك حدد القيمة ");
                    tex_inv.Focus();
                }
                else if (tex_amount.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("من فضلك حدد المبلغ");
                    tex_amount.Focus();
                    tex_amount.SelectAll();

                }
                else if (typ_money.ToString() == string.Empty)
                {
                    MessageBox.Show("من فضلك حدد نوع الكاش او بنكك او بشيك");
                }
                else if (tex_ponas.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("من فضلك حدد البونص");
                    tex_ponas.Focus();
                    tex_ponas.SelectAll();
                }
                else
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO purchases VALUES ('" + tex_ne_com.Text + "','" + Convert.ToInt32( tex_inv.Text) + "', '"+typ_money+"', '"+ tex_amount.Text+ "', '"+ tex_ponas.Text+ "', '"+ tex_tol.Text+ "','" + date_purch.Value.ToString("yyyy-MM-dd") + "','" + txt_userAdd.Text + "' )", dal.con);
                    dal.open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تمة الحفظ");
                    dal.Close();
                   
                  
                    typ_money = "";
                    tex_ne_com.Clear();
                    tex_inv.Clear();
                    tex_amount.Clear();
                    tex_ponas.Clear();
                    tex_tol.Clear();




                    rad_cash.Checked = false;
                    rad_bank.Checked = false;
                    rad_shak.Checked = false;

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tex_ponas_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tex_ponas.Text.Trim() == string.Empty)
                {
                    tex_ponas.Text = "0";

                }
                if (tex_amount.Text.Trim() == string.Empty)
                {
                    tex_amount.Text = "0";
                }
                int sum = Convert.ToInt32(tex_amount.Text) + Convert.ToInt32(tex_amount.Text) * Convert.ToInt32(tex_ponas.Text) / 100;

                //  string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(sum));
                //tex_tol.Text = formatted;
                tex_tol.Text = Convert.ToString(sum);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tex_inv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void tex_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void tex_ponas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void rad_cash_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_cash.Checked)
            {
                typ_money = "كاش";
            }
        }

        private void rad_bank_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_bank.Checked)
            {
                typ_money = "بنكك";
            }
        }

        private void rad_shak_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_shak.Checked)
            {
                typ_money = "شيك";
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
