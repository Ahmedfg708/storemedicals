using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using storemedicals.allform.REPORTITEM;
using Microsoft.Reporting.WinForms;

namespace storemedicals.allform.sales
{
    public partial class frm_sale : Form
    {
        Data.DataAccesLayer dal = new Data.DataAccesLayer();
        CLS.cls_sale sal = new CLS.cls_sale();
        CLS.cls_company com = new CLS.cls_company();
        char dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
        DataTable dt,dt1 = new DataTable();
        int qty;
        string sumqty ;
      //  string compin = "";
        string wtim = "";
        string cach = "", bank = "", atm = "";

      
        // مجموعة تخزين الأسماء لخاصية الإكمال التلقائي
        AutoCompleteStringCollection itemCollection = new AutoCompleteStringCollection();


        //================

        //================


        public frm_sale()
        {
            InitializeComponent();
            btn_new.Focus();
            txt_userAdd.Text = Program.user_Name;
            //==================================
            addData();
            //=========================
            pnl_cust.Enabled = false;
            txt_cust_id.Text = "1";
            txt_cust_name.Text = "بدون زبون";
            txt_cust_phon.Clear();
            txt_cust_company.Clear();
            dgvitem_sal.Columns[0].Width = 50;
            dgvitem_sal.Columns[2].Width = 50;
            dgvitem_sal.Columns[3].Width = 50;
            dgvitem_sal.Columns[4].Width = 50;
            dgvitem_sal.Columns[5].Width = 50;
            dgvitem_sal.Columns[6].Width = 50;
            wtim = storemedicals.WOTIME.WTim;

            tex_atm.Text = "0";
            tex_bank.Text = "0";
            tex_cha.Text = "0";

            // استدعاء الدالة وحفظ النتيجة
            string type = GetUserType(txt_userAdd.Text);

            if (type == "موظف")
            {
                // الحقل يصبح للقراءة فقط ولا يمكن التعديل عليه
                txt_sal_pric.ReadOnly = true;

                // اختياري: تغيير اللون ليعرف الموظف أنه مغلق
                txt_sal_pric.BackColor = Color.LightGray;
            }
            else if (type == "مدير")
            {
                // المدير يمكنه التعديل
                txt_sal_pric.ReadOnly = false;
                txt_sal_pric.BackColor = Color.White;
            }


        }

        private async Task LoadItemsAutoComplete()
        {
            try
            {
                // 1. إظهار دائرة التحميل
              //  pic_loading.Visible = true;

                // 2. مصفوفة لتخزين الأسماء
                List<string> names = new List<string>();

                // 3. الاتصال بالقاعدة وجلب البيانات في خيط منفصل (Task)
                await Task.Run(() =>
                {
                    dal.open();
                    {
                        // استعلام لجلب الأسماء فقط لسرعة الأداء
                        string query = "SELECT ITEM_NAME_AR FROM ITEMS";
                        SqlCommand cmd = new SqlCommand(query, dal.con);
                        
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            names.Add(dr["ITEM_NAME_AR"].ToString());
                        }
                    }
                });

                // 4. تحديث الـ AutoComplete بالبيانات المجلوبة
                itemCollection.Clear();
                itemCollection.AddRange(names.ToArray());
                txt_item_nam.AutoCompleteCustomSource = itemCollection;

                dal.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل الأصناف: " + ex.Message);
            }
            finally
            {
                // 5. إخفاء دائرة التحميل بعد الانتهاء
                //pic_loading.Visible = false;
            }
        }


        private void GetItemDetails(string itemName)
        {
            try
            {
                dal.open();
                // استعلام لجلب كل تفاصيل الصنف بناءً على الاسم المختار
                string query = "SELECT ITEM_ID, ITEM_BARCOD, ITEM_SAL, ITEM_COUNT FROM ITEMS WHERE ITEM_NAME_AR = @name";
                SqlCommand cmd = new SqlCommand(query, dal.con);
                cmd.Parameters.AddWithValue("@name", itemName);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // توزيع البيانات على التكست بوكس (تأكد من الأسماء البرمجية عندك)
                    txt_item_id.Text = dr["ITEM_ID"].ToString();
                    txt_barcod.Text = dr["ITEM_BARCOD"].ToString();
                    txt_sal_pric.Text = dr["ITEM_SAL"].ToString();
                    txt_q.Text = dr["ITEM_COUNT"].ToString(); // كمية الصنف بالمخزن

                    txt_qunty.Text = "0";
                    // نقل المؤشر فوراً لخانة الكمية المطلوب بيعها
                    txt_qunty.Focus();
                    txt_qunty.SelectAll(); // تحديد النص ليسهل المسح والكتابة
                }
                dr.Close();
                dal.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء جلب تفاصيل الصنف: " + ex.Message);
            }
        }

        /*
                // هنعدل الدالة لتقبل نص البحث
                private async Task LoadItemsWithLike(string searchText)
                {
                    try
                    {
                        // pic_loading.Visible = true;
                        List<string> names = new List<string>();

                        await Task.Run(() =>
                        {
                            dal.open();
                            // البحث عن أي اسم يحتوي على النص المكتوب في أي مكان
                            string query = "SELECT ITEM_NAME_AR FROM ITEMS WHERE ITEM_NAME_AR LIKE @search";
                            SqlCommand cmd = new SqlCommand(query, dal.con);
                            cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                names.Add(dr["ITEM_NAME_AR"].ToString());
                            }
                            dr.Close(); // مهم جداً تقفل الـ Reader
                            dal.Close();
                        });

                        itemCollection.Clear();
                        itemCollection.AddRange(names.ToArray());
                        txt_item_nam.AutoCompleteCustomSource = itemCollection;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطأ في تحميل الأصناف: " + ex.Message);
                    }
                    finally
                    {
                        // pic_loading.Visible = false;
                    }
                }
        */
        /*
                private async Task LoadItemsWithLike(string searchText)
                {
                    try
                    {
                        // 1. إظهار دائرة التحميل (تأكد من وجود pictureBox بهذا الاسم)
                        //if (pic_loading != null) pic_loading.Visible = true;

                        List<string> names = new List<string>();

                        await Task.Run(() =>
                        {
                            dal.open();
                            string query = "SELECT ITEM_NAME_AR FROM ITEMS WHERE ITEM_NAME_AR LIKE @search";
                            SqlCommand cmd = new SqlCommand(query, dal.con);
                            cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                            using (SqlDataReader dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    names.Add(dr["ITEM_NAME_AR"].ToString());
                                }
                            }
                            dal.Close();
                        });

                        // تحديث الواجهة بشكل آمن
                        this.Invoke(new Action(() => {
                            itemCollection.Clear();
                            itemCollection.AddRange(names.ToArray());

                            // ضبط المصدر وتنشيط القائمة
                            txt_item_nam.AutoCompleteCustomSource = itemCollection;
                        }));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("خطأ في البحث: " + ex.Message);
                    }
                    finally
                    {
                      //  if (pic_loading != null) pic_loading.Visible = false;
                    }
                }*/

        public string GetUserType(string userName)
        {
            string userType = "";
            try
            {
                dal.open();
                SqlCommand cmd = new SqlCommand("SELECT USER_TYPE FROM USERES WHERE USER_NAME = @name", dal.con);
                cmd.Parameters.AddWithValue("@name", userName);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    userType = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في جلب صلاحية المستخدم: " + ex.Message);
            }
            finally
            {
                dal.Close();
            }
            return userType;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try { 
                txt_ord_id.Text = sal.sal_Maxid().Rows[0][0].ToString();
                btn_new.Enabled = false;
                btn_save.Enabled = true;
                txt_sal_dec.Text = "تصرف للسيد  " + txt_cust_name.Text;
                txt_barcod.Focus();
            }
            catch { return; }

        }

        private void rd_no_custmer_CheckedChanged(object sender, EventArgs e)
        {
            rd_add_custmer.Enabled = true;
            pnl_cust.Enabled = false;
            txt_cust_id.Text = "1";
            txt_cust_name.Text = "بدون زبون";
            txt_sal_dec.Text = "تصرف للسيد  " + txt_cust_name.Text;
            txt_cust_phon.Clear();
            txt_cust_company.Clear();
        }

        private void rd_add_custmer_CheckedChanged(object sender, EventArgs e)
        {
            rd_no_custmer.Enabled = true;
            rd_add_custmer.Enabled = true;
            pnl_cust.Enabled = true;
            txt_cust_id.Clear();
            txt_cust_name.Clear();
            txt_cust_phon.Clear();
            txt_cust_company.Clear();
        }

        private void btn_add_cust_Click(object sender, EventArgs e)
        {
            frm_custList fm = new frm_custList();
            try
            {
                fm.ShowDialog();
                txt_cust_id.Text = fm.dgv_cust.CurrentRow.Cells[0].Value.ToString();
                txt_cust_name.Text = fm.dgv_cust.CurrentRow.Cells[1].Value.ToString();
                txt_cust_phon.Text = fm.dgv_cust.CurrentRow.Cells[2].Value.ToString();
                txt_cust_company.Text = fm.dgv_cust.CurrentRow.Cells[6].Value.ToString();
                txt_sal_dec.Text = "تصرف للسيد  " + txt_cust_name.Text;
               
            }
            catch { return; }
        }

        private async void frm_sale_Load(object sender, EventArgs e)
        {
            addData();
            txt_sal_dec.Text = "تصرف للسيد  " + txt_cust_name.Text;

            txt_item_nam.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_item_nam.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // استدعاء دالة التحميل
              await LoadItemsAutoComplete();

            //await LoadItemsWithLike(txt_item_nam.Text);




        }

       
        private void btn_item_Click(object sender, EventArgs e)
        {
            frm_itemList fm = new frm_itemList();
            fm.ShowDialog();
            try
            {
                
                txt_item_id.Text = fm.dgvitem.CurrentRow.Cells[0].Value.ToString();
                txt_item_nam.Text = fm.dgvitem.CurrentRow.Cells[1].Value.ToString();
                txt_barcod.Text = fm.dgvitem.CurrentRow.Cells[2].Value.ToString();
                qty = Convert.ToInt32(fm.dgvitem.CurrentRow.Cells[3].Value.ToString());
                txt_sal_pric.Text = fm.dgvitem.CurrentRow.Cells[5].Value.ToString();
               

                txt_qunty.Text = "0";
                //btn_add_item.Focus();

                txt_qunty.Focus();
                txt_qunty.Select();
                txt_qunty.SelectAll();

                //btn_add_item_Click(sender,e);
            }
            catch { return; }
        }
    //=================
        private void calclaAmount()
        {
            try
            {

                if (txt_sal_pric.Text.Trim() != string.Empty && txt_qunty.Text.Trim() != string.Empty)
                {
                    double pric = Convert.ToDouble(txt_sal_pric.Text);
                    double qunty = Convert.ToDouble(txt_qunty.Text);
                    double reslet = pric * qunty;
                    txt_amount.Text = reslet.ToString();
                    txt_totalAmount.Text = reslet.ToString();

                }
            
            }
            catch { return; }
        
        }

        private void txt_sal_pric_TextChanged(object sender, EventArgs e)
        {
            calclaAmount();
        }

        private void txt_qunty_TextChanged(object sender, EventArgs e)
        {
            calclaAmount();
        }

        private void txt_qunty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
            //=================
            SqlCommand cmd = new SqlCommand("select ITEM_COUNT from ITEMS where ITEM_ID=@id", dal.con);
            cmd.Parameters.Add(new SqlParameter("@id", txt_item_id.Text));
            dal.open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_q.Text =dr.GetInt32(0).ToString();
            }
            dr.Close();
            dal.Close();
            //=================
        }

        private void txt_sal_pric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void txt_totalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void txt_totalAmount_TextChanged(object sender, EventArgs e)
        {
            totalAmount();
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
            calclaAmount();
            //txt_totalAmount.Text = txt_amount.Text;
        }

        private void txt_amount_KeyUp(object sender, KeyEventArgs e)
        {
            calclaAmount();
        }

        private void txt_totalAmount_KeyUp(object sender, KeyEventArgs e)
        {
            txt_totalAmount.Text = txt_amount.Text;
        }
    //================

        //================= دالة اجمالى  المبلغ
        private void totalAmount()
        {
            if (txt_amount.Text.Trim() != string.Empty && txt_qunty.Text.Trim() != string.Empty)
            {
                double pric = Convert.ToDouble(txt_sal_pric.Text);
                double qunty = Convert.ToDouble(txt_qunty.Text);
                double reslet = pric * qunty;
                txt_totalAmount.Text = reslet.ToString();

            }

        }

        private void حذفالسطرالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void الشركةالتابعةللصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_compny_sal fm = new frm_compny_sal();
            try 
            {
                if (txt_item_id.Text != string.Empty)
                {
                    int id = Convert.ToInt32(txt_item_id.Text);
                     dt = new DataTable();
                    dt = com.GetAll_company_forSal(id);
                    if (dt.Rows.Count > 0)
                    {
                        fm.txt_itemid.Text = dt.Rows[0][0].ToString();
                        fm.txt_comp_name.Text = dt.Rows[0][1].ToString();
                        fm.txt_phon.Text = dt.Rows[0][2].ToString();
                        fm.txt_addres.Text = dt.Rows[0][3].ToString();
                        fm.ShowDialog();
                    }
                    else
                    { 
                        MessageBox.Show("هذا الصنف لم يتم اضافة شركة لة","تنبية",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return;
                    }
                    
                }
            }
            catch { return; }
        }
       
        private void txt_barcod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                

                if (txt_barcod.Text.Trim() != string.Empty)
                {                  

                   
                    dt1 = sal.Get_barcod(txt_barcod.Text);
                    if (dt1.Rows.Count > 0)
                    {
                        txt_item_id.Text = dt1.Rows[0][0].ToString();
                        txt_item_nam.Text = dt1.Rows[0][1].ToString();
                        txt_barcod.Text = dt1.Rows[0][2].ToString();
                        txt_sal_pric.Text = dt1.Rows[0][5].ToString();
                        txt_qunty.Text = "0";

                        txt_qunty.Focus();
                        txt_qunty.Select();
                        txt_qunty.SelectAll();

                    }
                  
                }
           //====================================
            }catch(Exception ex){
                MessageBox.Show("خطا فى عملية جلب الباركود" + ex.ToString());
                return;
            }
           //========================        

        }

        private void btn_add_item_Click(object sender, EventArgs e)
        {
            string searchValue = txt_item_nam.Text;
            int rowIndex = -1;
            foreach (DataGridViewRow row in dgvitem_sal.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(searchValue))
                {
                    rowIndex = row.Index;
                    MessageBox.Show("خطاء في أسم الصنف لقد تمة اضافة في قائمة المبيعات", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_item_nam.Focus();
                    txt_item_nam.SelectAll();
                    return;
                }
               
            }
            if (txt_qunty.Text.Trim() == "0")
            {
                MessageBox.Show("خطاء لايمكن اضافة 0 في الكمية", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_qunty.Focus();
                txt_qunty.SelectAll();
                return;

            }

            if(txt_sal_pric.Text == string.Empty)
            {
                MessageBox.Show("خطاء يجب تحديد السعر  ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txt_sal_pric.Focus();
                txt_sal_pric.SelectAll();
                return;

            }

            if (txt_item_id.Text == string.Empty)
            {
               // MessageBox.Show("خطاء لايمكن اضافة اصنافا فارغ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

           

            //==================================
            try
            {
                //======*************
                if (Convert.ToInt32(txt_qunty.Text) > Convert.ToInt32(txt_q.Text))
                {
                    MessageBox.Show("كمية الصنف المطلوبة اكبر من الكمية المجودة بالمخزن " + Environment.NewLine + "كمية الصنف الموجدة هى : " + txt_q.Text.ToString(), "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_qunty.Focus();
                    txt_qunty.SelectAll();
                    return;
                }
                //==========*************
                // if (dgvitem_sal.Rows.Count > 0)
                // {
                // if (Convert.ToInt32(txt_qunty.Text) + Convert.ToInt32(sumqty.ToString()) > Convert.ToInt32(txt_q.Text))
                //    {
                //    MessageBox.Show("كمية الصنف المطلوبة اكبر من الكمية المجودة بالمخزن " + Environment.NewLine + "كمية الصنف الموجدة هى : " + txt_q.Text.ToString(), "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    txt_qunty.Focus();
                //   return;
                // }
                //  }
                //======************

                ////=========================sum_qty_item() ===== التاكد من الكمية qty
                //if (Convert.ToInt32(txt_qunty.Text) > qty)
                //{
                //    MessageBox.Show("كمية الصنف المطلوبة اكبر من الكمية المجودة بالمخزن " + Environment.NewLine + "كمية الصنف الموجدة هى : " + qty.ToString(), "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    txt_qunty.Focus();
                //    return;
                //}
                ////===========================
                ////============================== التاكد من الكمية 
                //if (dgvitem_sal.Rows.Count > 0)
                //{
                //    if (Convert.ToInt32(txt_qunty.Text) + Convert.ToInt32(sumqty.ToString()) > qty)
                //    {
                //        MessageBox.Show("كمية الصنف المطلوبة اكبر من الكمية المجودة بالمخزن " + Environment.NewLine + "كمية الصنف الموجدة هى : " + qty.ToString(), "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //        txt_qunty.Focus();
                //        return;
                //    }
                //}

                //===========================
                DataRow row = dt.NewRow();
                row[0] = txt_item_id.Text;
                row[1] = txt_item_nam.Text;
                row[2] = txt_barcod.Text;
                row[3] = txt_qunty.Text;
                row[4] = txt_sal_pric.Text;
                row[5] = txt_amount.Text; ;
                row[6] = txt_totalAmount.Text;
                dt.Rows.Add(row);
                this.dgvitem_sal.DataSource = dt;
                totalSumdgv();
                //Sum_qty();
                Sum_qty_item();
                cleartxt();
                txt_barcod.Focus();
                //============================

            }
            catch { return; }

        
        //================================
        }

        private void txt_qunty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                btn_add_item_Click(sender, e);
            }
        }

        //====================
       private void addData()
        {
            try
            {
                dt = new DataTable();
                dt.Columns.Add("رقم الصنف");
                dt.Columns.Add("اسم الصنف");
                dt.Columns.Add("الباركود");
                dt.Columns.Add("الكمية");
                dt.Columns.Add("سعر البيع");
                dt.Columns.Add("المبلغ");
                dt.Columns.Add("الاجمالى");
                this.dgvitem_sal.DataSource = dt;
            }
            catch { return; }

        }
        
        //======================
       private void cleartxt()
        {
            txt_item_id.Clear();
            txt_qunty.Clear();
            txt_item_nam.Clear();
            txt_sal_pric.Clear();
            txt_amount.Clear();
            txt_barcod.Clear();
            txt_q.Clear();
            txt_totalAmount.Clear();
        }
        //======================
        
       private void clearAlltxt()
        {
            cleartxt();
            txt_ord_id.Clear();
            txt_cust_id.Clear();
            txt_cust_name.Clear();
            txt_cust_phon.Clear();
            txt_cust_company.Clear();
            txt_total_fatora.Clear();
            txt_q.Clear();

            dgvitem_sal.DataSource = null;
            dt.Clear();

            rd_no_custmer.Checked = true;
            txt_cust_id.Text = "1";
            txt_cust_name.Text = "بدون زبون";
            checkBox_cah.Checked = false;
            checkBox_bank.Checked = false;
            checkBox_atm.Checked = false;
            tex_cha.Text = "0";
            tex_bank.Text = "0";
            tex_atm.Text = "0";
            tex_cha.Enabled = false;
            tex_bank.Enabled = false;
            tex_atm.Enabled = false;
            cach = ""; bank = ""; atm = "";


        }
        //=================
       //==========================
       private void totalSumdgv()
       {
           try
           {
               if (dgvitem_sal.Rows.Count < 1)
               {
                   txt_total_fatora.Text = "0";
               }
               else
               {
                   txt_total_fatora.Text = (from DataGridViewRow row in dgvitem_sal.Rows
                                            where row.Cells[6].FormattedValue.ToString() != string.Empty
                                            select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
               }

           }
           catch { return; }

       }
    //============================
       public void Sum_qty()
       {
           try
           {
               if (dgvitem_sal.Rows.Count < 1)
               {
                   sumqty = "0";
               }
               else
               {
                   for (int i = 0; i < dgvitem_sal.Rows.Count; i++)
                   {
                       sumqty = (from DataGridViewRow row in dgvitem_sal.Rows
                                 where row.Cells[3].FormattedValue.ToString() != string.Empty && dgvitem_sal.Rows[i].Cells[0].Value.ToString() == row.Cells[0].FormattedValue.ToString()
                                 select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
                   }
               }

           }
           catch { return; }

       }
    //============================
       private void txt_barcod_KeyUp(object sender, KeyEventArgs e)
       {
           
       }

       private void txt_barcod_KeyDown(object sender, KeyEventArgs e)
       {
           if (txt_barcod.Text == string.Empty)
           {
               if (e.KeyCode == Keys.Enter)
               {
                  
                 btn_item_Click(sender, e);
               }
           }

         
       }

       private void dgvitem_sal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
       {
           try
           {
               if (dgvitem_sal.Rows.Count < 1)
               {
                   return;
               }
               get_data_dgv();
               totalSumdgv();
               Sum_qty();
           }
           catch { return; }
           

       }
       
       private void get_data_dgv()
       {
           try 
           {
               txt_item_id.Text = this.dgvitem_sal.CurrentRow.Cells[0].Value.ToString();
               txt_item_nam.Text = this.dgvitem_sal.CurrentRow.Cells[1].Value.ToString();
               txt_barcod.Text = this.dgvitem_sal.CurrentRow.Cells[2].Value.ToString();
               txt_qunty.Text = this.dgvitem_sal.CurrentRow.Cells[3].Value.ToString();
               txt_sal_pric.Text = this.dgvitem_sal.CurrentRow.Cells[4].Value.ToString();
               txt_amount.Text = this.dgvitem_sal.CurrentRow.Cells[5].Value.ToString();
               txt_totalAmount.Text = this.dgvitem_sal.CurrentRow.Cells[6].Value.ToString();
               dgvitem_sal.Rows.RemoveAt(dgvitem_sal.CurrentRow.Index);
              
           }
           catch { return; }
       
       }

       private void حذفالسطرالمحددToolStripMenuItem_Click_1(object sender, EventArgs e)
       {
          
       }

       private void حذفالسطرالمحددToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           try
           {
               if (dgvitem_sal.Rows.Count < 1)
               { 
                   return;
               }
               dgvitem_sal.Rows.RemoveAt(dgvitem_sal.CurrentRow.Index);
               Sum_qty();
               totalSumdgv();
           }
           catch { return; }
       }

       private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
       {
           try
           {
               if (dgvitem_sal.Rows.Count < 1)
               {
                   return;
               }
               dt.Clear();
               dgvitem_sal.DataSource = null;
               txt_total_fatora.Text = "0";
           }
           catch { return; }
       }

       private void btn_save_Click(object sender, EventArgs e)
       {
         int sum = 0;
             sum = Convert.ToInt32(tex_cha.Text) + Convert.ToInt32(tex_bank.Text) + Convert.ToInt32(tex_atm.Text);

             // ====================== التحقق من صحة البيانات ======================
             if (checkBox_atm.Checked && txt_cust_id.Text == "1")
             {
                 MessageBox.Show("لا يمكن حفظ الفاتوره اجل بدون اسم", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }

            if (string.IsNullOrEmpty(txt_cust_id.Text) ||
                string.IsNullOrEmpty(txt_cust_name.Text) || dgvitem_sal.Rows.Count < 1)
            {
                MessageBox.Show("لايمكن ترك الحقول الخاصة بالفاتورة فارغة", "حقل اجبارى", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
             if (sum < Convert.ToInt32(txt_total_fatora.Text))
             {
                 MessageBox.Show("خطاء قيمة الفاتورة اقل من أجمالي الفاتوره", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }

             if (sum > Convert.ToInt32(txt_total_fatora.Text))
             {
                 MessageBox.Show("خطاء قيمة الفاتورة اكبر من أجمالي الفاتوره", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }

             if (!checkBox_cah.Checked && !checkBox_bank.Checked && !checkBox_atm.Checked)
             {
                 MessageBox.Show("من فضلك حدد نوع الكاش او بنكك او ATM", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                 return;
             }

             if (checkBox_cah.Checked && tex_cha.Text == "0")
             {
                 MessageBox.Show("من فضلك حدد القيه", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 tex_cha.Focus();
                 tex_cha.SelectAll();
                 return;
             }

             if (checkBox_bank.Checked && tex_bank.Text == "0")
             {
                 MessageBox.Show("من فضلك حدد القيه", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 tex_bank.Focus();
                 tex_bank.SelectAll();
                 return;
             }

             if (checkBox_atm.Checked && tex_atm.Text == "0")
             {
                 MessageBox.Show("من فضلك حدد القيه", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 tex_atm.Focus();
                 tex_atm.SelectAll();
                 return;
             }

             if (wtim == "عام")
             {
                 MessageBox.Show("لا يمكن أنشاء فاتورة بأسم هذا المستخدم", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }

             // ====================== تنفيذ عملية الحفظ ======================
             SqlTransaction transaction = null;

            try
            {
                dal.open();
                transaction = dal.con.BeginTransaction();

                // 1. توليد رقم الفاتورة (لضمان عدم التكرار في الشبكة)
                SqlCommand cmdId = new SqlCommand("SELECT ISNULL(MAX(ored_id), 0) + 1 FROM itemorder WITH (UPDLOCK, HOLDLOCK)", dal.con, transaction);
                int newOrderId = Convert.ToInt32(cmdId.ExecuteScalar());

                txt_ord_id.Text = Convert.ToString(newOrderId);

                // ====================== [تعديل هنا] حفظ الفاتورة الرئيسية يدوياً لضمان الارتباط بالترانزاكشن ======================
                SqlCommand cmdMain = new SqlCommand(@"INSERT INTO itemorder (ored_id, ored_desc, ored_date, cust_id, user_add) 
                                                 VALUES (@id, @dec, @date, @cust, @user)", dal.con, transaction);
                cmdMain.Parameters.AddWithValue("@id", Convert.ToInt32(txt_ord_id.Text));
                cmdMain.Parameters.AddWithValue("@dec", txt_sal_dec.Text);
                cmdMain.Parameters.AddWithValue("@date", date_sal.Value.ToString("yyyy-MM-dd"));
                cmdMain.Parameters.AddWithValue("@cust", Convert.ToInt32(txt_cust_id.Text));
                cmdMain.Parameters.AddWithValue("@user", txt_userAdd.Text);
                cmdMain.ExecuteNonQuery();
                // ==========================================================================================================

                // حفظ تفاصيل الفاتورة وتحديث الكمية بدقة
                for (int i = 0; i < dgvitem_sal.Rows.Count; i++)
                {
                    SqlCommand cmdDetail = new SqlCommand(@"        INSERT INTO itemOrderDeail        (item_id, order_id, ITEM_NAME_AR, ITEM_BARCOD, ITEM_COUNT, ITEM_PRIC, Amount, totalAmount, pink)        VALUES (@item_id, @order_id, @ITEM_NAME_AR, @ITEM_BARCOD, @ITEM_COUNT, @ITEM_PRIC, @Amount, @totalAmount, @pink)",
                        dal.con, transaction);

                    cmdDetail.Parameters.AddWithValue("@item_id", Convert.ToInt32(dgvitem_sal.Rows[i].Cells[0].Value));
                    cmdDetail.Parameters.AddWithValue("@order_id", Convert.ToInt32(txt_ord_id.Text));
                    cmdDetail.Parameters.AddWithValue("@ITEM_NAME_AR", dgvitem_sal.Rows[i].Cells[1].Value.ToString());
                    cmdDetail.Parameters.AddWithValue("@ITEM_BARCOD", dgvitem_sal.Rows[i].Cells[2].Value.ToString());
                    cmdDetail.Parameters.AddWithValue("@ITEM_COUNT", Convert.ToInt32(dgvitem_sal.Rows[i].Cells[3].Value));
                    cmdDetail.Parameters.AddWithValue("@ITEM_PRIC", dgvitem_sal.Rows[i].Cells[4].Value.ToString());
                    cmdDetail.Parameters.AddWithValue("@Amount", Convert.ToDecimal(dgvitem_sal.Rows[i].Cells[5].Value));
                    cmdDetail.Parameters.AddWithValue("@totalAmount", dgvitem_sal.Rows[i].Cells[6].Value.ToString());
                    cmdDetail.Parameters.AddWithValue("@pink", wtim);
                    cmdDetail.ExecuteNonQuery();

                    // تحديث الكمية في جدول ITEMS بدقة
                    SqlCommand cmdUpdate = new SqlCommand(@"        UPDATE ITEMS        SET ITEM_COUNT = ITEM_COUNT - @QTY        WHERE ITEM_ID = @ITEM_ID", dal.con, transaction);

                    cmdUpdate.Parameters.AddWithValue("@QTY", Convert.ToInt32(dgvitem_sal.Rows[i].Cells[3].Value));
                    cmdUpdate.Parameters.AddWithValue("@ITEM_ID", Convert.ToInt32(dgvitem_sal.Rows[i].Cells[0].Value));
                    cmdUpdate.ExecuteNonQuery();
                }

                // ===================== معالجة المدفوعات ======================
                if (checkBox_atm.Checked)
                {
                    if (checkBox_cah.Checked || checkBox_bank.Checked)
                    {
                        // إدخال الدين
                        SqlCommand cmdtd = new SqlCommand(@"            INSERT INTO tab_deble (name_cust, id_cus, order_id, sele_rest, dat)            VALUES (@name_cust, @id_cus, @order_id, @sele_rest, @dat)",
                            dal.con, transaction);

                        cmdtd.Parameters.AddWithValue("@name_cust", txt_cust_name.Text);
                        cmdtd.Parameters.AddWithValue("@id_cus", Convert.ToInt32(txt_cust_id.Text));
                        cmdtd.Parameters.AddWithValue("@order_id", Convert.ToInt32(txt_ord_id.Text));
                        cmdtd.Parameters.AddWithValue("@sele_rest", Convert.ToInt32(tex_atm.Text));
                        cmdtd.Parameters.AddWithValue("@dat", date_sal.Value.ToString("yyyy-MM-dd"));
                        cmdtd.ExecuteNonQuery();

                        int totalpp = Convert.ToInt32(tex_cha.Text) + Convert.ToInt32(tex_bank.Text);

                        // إدخال سداد جزئي
                        SqlCommand cmdtbp = new SqlCommand(@"            INSERT INTO tab_deble_paid             (p_name_cust, p_id_cus, p_order_id, sele_rest_paid, cash, bank, settle_accounts, num_bok, p_dat)            VALUES (@p_name_cust, @p_id_cus, @p_order_id, @sele_rest_paid, @cash, @bank, 0, '', @p_dat)",
                            dal.con, transaction);

                        cmdtbp.Parameters.AddWithValue("@p_name_cust", txt_cust_name.Text);
                        cmdtbp.Parameters.AddWithValue("@p_id_cus", Convert.ToInt32(txt_cust_id.Text));
                        cmdtbp.Parameters.AddWithValue("@p_order_id", Convert.ToInt32(txt_ord_id.Text));
                        cmdtbp.Parameters.AddWithValue("@sele_rest_paid", totalpp);
                        cmdtbp.Parameters.AddWithValue("@cash", Convert.ToInt32(tex_cha.Text));
                        cmdtbp.Parameters.AddWithValue("@bank", Convert.ToInt32(tex_bank.Text));
                        cmdtbp.Parameters.AddWithValue("@p_dat", date_sal.Value.ToString("yyyy-MM-dd"));
                        cmdtbp.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(@"            INSERT INTO tab_deble (name_cust, id_cus, order_id, sele_rest, dat)            VALUES (@name_cust, @id_cus, @order_id, @sele_rest, @dat)",
                            dal.con, transaction);

                        cmd.Parameters.AddWithValue("@name_cust", txt_cust_name.Text);
                        cmd.Parameters.AddWithValue("@id_cus", Convert.ToInt32(txt_cust_id.Text));
                        cmd.Parameters.AddWithValue("@order_id", Convert.ToInt32(txt_ord_id.Text));
                        cmd.Parameters.AddWithValue("@sele_rest", Convert.ToInt32(tex_atm.Text));
                        cmd.Parameters.AddWithValue("@dat", date_sal.Value.ToString("yyyy-MM-dd"));
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO typ_money(order_id, ty_cach, mo_cach, ty_bank, mo_bank, ty_atm, mo_atm, dat, wtim, paid)VALUES (@order_id, @ty_cach, @mo_cach, @ty_bank, @mo_bank, @ty_atm, @mo_atm, @dat, @wtim, 0)",
            dal.con, transaction);

                    cmd.Parameters.AddWithValue("@order_id", Convert.ToInt32(txt_ord_id.Text));
                    cmd.Parameters.AddWithValue("@ty_cach", cach);
                    cmd.Parameters.AddWithValue("@mo_cach", Convert.ToInt32(tex_cha.Text));
                    cmd.Parameters.AddWithValue("@ty_bank", bank);
                    cmd.Parameters.AddWithValue("@mo_bank", Convert.ToInt32(tex_bank.Text));
                    cmd.Parameters.AddWithValue("@ty_atm", atm);
                    cmd.Parameters.AddWithValue("@mo_atm", Convert.ToInt32(tex_atm.Text));
                    cmd.Parameters.AddWithValue("@dat", date_sal.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@wtim", wtim);

                    cmd.ExecuteNonQuery();

                }

                // ===================== تنفيذ التغييرات ======================
                transaction.Commit();
                MessageBox.Show("تم حفظ الفاتورة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // تحديث المبيعات اليومية
                try { frmMain.getmain.sumTotalForSal(); } catch { }

                // طباعة الفاتورة
                DialogResult ms = MessageBox.Show("هل ترغب بطباعة هذه الفاتورة؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (ms == DialogResult.Yes)
                {
                    SqlCommand cmdPrint = new SqlCommand(@"        SELECT f.order_id, f.ITEM_NAME_AR, f.ITEM_COUNT, f.ITEM_PRIC, f.Amount, o.user_add         FROM itemOrderDeail f         JOIN itemorder o ON f.order_id = o.ored_id         WHERE f.order_id = @order_id", dal.con);

                    cmdPrint.Parameters.AddWithValue("@order_id", Convert.ToInt32(txt_ord_id.Text));
                    DataTable tbl = new DataTable();
                    tbl.Load(cmdPrint.ExecuteReader());

                    For_SALITM fr = new For_SALITM();
                    ReportParameterCollection rpc = new ReportParameterCollection();
                    ReportDataSource rds = new ReportDataSource("DataSetREPOZE", tbl);

                    fr.reportViewer1.LocalReport.DataSources.Clear();
                    fr.reportViewer1.LocalReport.DataSources.Add(rds);
                    rpc.Add(new ReportParameter("ReportParameter_NAMRCUSTMR", txt_cust_name.Text));
                    rpc.Add(new ReportParameter("ReportParameterDeta", date_sal.Value.ToString("yyyy-MM-dd")));
                    fr.reportViewer1.LocalReport.SetParameters(rpc);
                    fr.reportViewer1.LocalReport.Refresh();
                    fr.ShowDialog();
                }

                clearAlltxt();
                btn_new.Enabled = true;
               // btn_save.Enabled = false;
              //  btn_new.Focus();
                dal.Close();
            }
            catch (Exception ex)
            {
                try { transaction?.Rollback(); } catch { }
                MessageBox.Show("خطا فى الفاتورة: " + ex.Message);
                dal.Close();
                return;
            }


            /* // ====================== تحويل القيم والتحقق ======================
             int valCha = 0; int.TryParse(tex_cha.Text, out valCha);
             int valBank = 0; int.TryParse(tex_bank.Text, out valBank);
             int valAtm = 0; int.TryParse(tex_atm.Text, out valAtm);
             int totalFatora = 0; int.TryParse(txt_total_fatora.Text, out totalFatora);

             int sum = valCha + valBank + valAtm;

             if (sum != totalFatora)
             {
                 MessageBox.Show("خطأ: مجموع القيم المدفوعة لا يساوي إجمالي الفاتورة", "تنبيه");
                 return;
             }

             // ====================== بدء عملية الحفظ الاحترافية ======================
             SqlTransaction transaction = null;

             try
             {
                 dal.open();
                 transaction = dal.con.BeginTransaction();

                 // 1. توليد رقم الفاتورة (لضمان عدم التكرار في الشبكة)
                 SqlCommand cmdId = new SqlCommand("SELECT ISNULL(MAX(ored_id), 0) + 1 FROM itemorder WITH (UPDLOCK, HOLDLOCK)", dal.con, transaction);
                 int newOrderId = Convert.ToInt32(cmdId.ExecuteScalar());

                 // 2. حفظ رأس الفاتورة (مباشرة لضمان نجاح الترانزاكشن)
                 SqlCommand cmdMain = new SqlCommand(@"INSERT INTO itemorder (ored_id, ored_desc, ored_date, cust_id, user_add) 
                                          VALUES (@id, @dec, @date, @cust, @user)", dal.con, transaction);
                 cmdMain.Parameters.AddWithValue("@id", newOrderId);
                 cmdMain.Parameters.AddWithValue("@dec", txt_sal_dec.Text);
                 cmdMain.Parameters.AddWithValue("@date", date_sal.Value.ToString("yyyy-MM-dd"));
                 cmdMain.Parameters.AddWithValue("@cust", Convert.ToInt32(txt_cust_id.Text));
                 cmdMain.Parameters.AddWithValue("@user", txt_userAdd.Text);
                 cmdMain.ExecuteNonQuery();

                 // 3. حفظ التفاصيل وتحديث المخزن
                 for (int i = 0; i < dgvitem_sal.Rows.Count; i++)
                 {
                     if (dgvitem_sal.Rows[i].Cells[0].Value == null) continue;

                     // إدخال تفاصيل الصنف
                     SqlCommand cmdDetail = new SqlCommand(@"INSERT INTO itemOrderDeail 
             (item_id, order_id, ITEM_NAME_AR, ITEM_BARCOD, ITEM_COUNT, ITEM_PRIC, Amount, totalAmount, pink) 
             VALUES (@item_id, @order_id, @name, @barcode, @qty, @price, @amount, @total, @pink)", dal.con, transaction);

                     cmdDetail.Parameters.AddWithValue("@item_id", dgvitem_sal.Rows[i].Cells[0].Value);
                     cmdDetail.Parameters.AddWithValue("@order_id", newOrderId); // استخدام الرقم المولد
                     cmdDetail.Parameters.AddWithValue("@name", dgvitem_sal.Rows[i].Cells[1].Value.ToString());
                     cmdDetail.Parameters.AddWithValue("@barcode", dgvitem_sal.Rows[i].Cells[2].Value.ToString());
                     cmdDetail.Parameters.AddWithValue("@qty", dgvitem_sal.Rows[i].Cells[3].Value);
                     cmdDetail.Parameters.AddWithValue("@price", dgvitem_sal.Rows[i].Cells[4].Value);
                     cmdDetail.Parameters.AddWithValue("@amount", dgvitem_sal.Rows[i].Cells[5].Value);
                     cmdDetail.Parameters.AddWithValue("@total", dgvitem_sal.Rows[i].Cells[6].Value);
                     cmdDetail.Parameters.AddWithValue("@pink", wtim);
                     cmdDetail.ExecuteNonQuery();

                     // تحديث الكمية في المخزن
                     SqlCommand cmdUpdate = new SqlCommand(@"UPDATE ITEMS SET ITEM_COUNT = ITEM_COUNT - @QTY WHERE ITEM_ID = @ITEM_ID", dal.con, transaction);
                     cmdUpdate.Parameters.AddWithValue("@QTY", dgvitem_sal.Rows[i].Cells[3].Value);
                     cmdUpdate.Parameters.AddWithValue("@ITEM_ID", dgvitem_sal.Rows[i].Cells[0].Value);
                     cmdUpdate.ExecuteNonQuery();
                 }

                 // 4. معالجة حسابات المبالغ
                 if (checkBox_atm.Checked)
                 {
                     SqlCommand cmdtd = new SqlCommand(@"INSERT INTO tab_deble (name_cust, id_cus, order_id, sele_rest, dat) 
                                            VALUES (@name_cust, @id_cus, @order_id, @sele_rest, @dat)", dal.con, transaction);
                     cmdtd.Parameters.AddWithValue("@name_cust", txt_cust_name.Text);
                     cmdtd.Parameters.AddWithValue("@id_cus", txt_cust_id.Text);
                     cmdtd.Parameters.AddWithValue("@order_id", newOrderId);
                     cmdtd.Parameters.AddWithValue("@sele_rest", valAtm);
                     cmdtd.Parameters.AddWithValue("@dat", date_sal.Value.ToString("yyyy-MM-dd"));
                     cmdtd.ExecuteNonQuery();

                     if (valCha > 0 || valBank > 0)
                     {
                         SqlCommand cmdtbp = new SqlCommand(@"INSERT INTO tab_deble_paid (p_name_cust, p_id_cus, p_order_id, sele_rest_paid, cash, bank, settle_accounts, num_bok, p_dat) 
                                                VALUES (@p_name, @p_id, @p_order, @p_paid, @p_cash, @p_bank, 0, '', @p_dat)", dal.con, transaction);
                         cmdtbp.Parameters.AddWithValue("@p_name", txt_cust_name.Text);
                         cmdtbp.Parameters.AddWithValue("@p_id", txt_cust_id.Text);
                         cmdtbp.Parameters.AddWithValue("@p_order", newOrderId);
                         cmdtbp.Parameters.AddWithValue("@p_paid", (valCha + valBank));
                         cmdtbp.Parameters.AddWithValue("@p_cash", valCha);
                         cmdtbp.Parameters.AddWithValue("@p_bank", valBank);
                         cmdtbp.Parameters.AddWithValue("@p_dat", date_sal.Value.ToString("yyyy-MM-dd"));
                         cmdtbp.ExecuteNonQuery();
                     }
                 }
                 else
                 {
                     SqlCommand cmdTyp = new SqlCommand(@"INSERT INTO typ_money (order_id, ty_cach, mo_cach, ty_bank, mo_bank, ty_atm, mo_atm, dat, wtim, paid) 
                                            VALUES (@order_id, @ty_c, @mo_c, @ty_b, @mo_b, @ty_a, @mo_a, @dat, @wtim, 0)", dal.con, transaction);
                     cmdTyp.Parameters.AddWithValue("@order_id", newOrderId);
                     cmdTyp.Parameters.AddWithValue("@ty_c", cach); cmdTyp.Parameters.AddWithValue("@mo_c", valCha);
                     cmdTyp.Parameters.AddWithValue("@ty_b", bank); cmdTyp.Parameters.AddWithValue("@mo_b", valBank);
                     cmdTyp.Parameters.AddWithValue("@ty_a", atm); cmdTyp.Parameters.AddWithValue("@mo_a", valAtm);
                     cmdTyp.Parameters.AddWithValue("@dat", date_sal.Value.ToString("yyyy-MM-dd"));
                     cmdTyp.Parameters.AddWithValue("@wtim", wtim);
                     cmdTyp.ExecuteNonQuery();
                 }

                 // ====================== إنهاء العملية بنجاح ======================
                 transaction.Commit();
                 MessageBox.Show("تم حفظ الفاتورة بنجاح برقم: " + newOrderId, "نجاح");

                 // طباعة الفاتورة
                 DialogResult ms = MessageBox.Show("هل ترغب بطباعة هذه الفاتورة؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                 if (ms == DialogResult.Yes)
                 {
                     SqlCommand cmdPrint = new SqlCommand(@"
              SELECT f.order_id, f.ITEM_NAME_AR, f.ITEM_COUNT, f.ITEM_PRIC, f.Amount, o.user_add 
              FROM itemOrderDeail f 
              JOIN itemorder o ON f.order_id = o.ored_id 
              WHERE f.order_id = @order_id", dal.con);

                     cmdPrint.Parameters.AddWithValue("@order_id", cmdId);
                     DataTable tbl = new DataTable();
                     tbl.Load(cmdPrint.ExecuteReader());

                     For_SALITM fr = new For_SALITM();
                     ReportParameterCollection rpc = new ReportParameterCollection();
                     ReportDataSource rds = new ReportDataSource("DataSetREPOZE", tbl);

                     fr.reportViewer1.LocalReport.DataSources.Clear();
                     fr.reportViewer1.LocalReport.DataSources.Add(rds);
                     rpc.Add(new ReportParameter("ReportParameter_NAMRCUSTMR", txt_cust_name.Text));
                     rpc.Add(new ReportParameter("ReportParameterDeta", date_sal.Value.ToString("yyyy-MM-dd")));
                     fr.reportViewer1.LocalReport.SetParameters(rpc);
                     fr.reportViewer1.LocalReport.Refresh();
                     fr.ShowDialog();
                 }


                 clearAlltxt();
                 dal.Close();
             }
             catch (Exception ex)
             {
                 if (transaction != null) transaction.Rollback();
                 MessageBox.Show("حدث خطأ حرج: " + ex.Message);
             }
             finally
             {
                 if (dal.con.State == ConnectionState.Open) dal.Close();
             }
 */


        }

        private void frm_sale_Activated(object sender, EventArgs e)
       {
           
       }

        private void rad_cash_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox_cah_MouseClick(object sender, MouseEventArgs e)
        {
            //cach = "", bank = "", atm = "";
            if (checkBox_cah.Checked == true) 
            {
                if (txt_total_fatora.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("خطاء يجب تحدد قيمة الفاتوره");
                    checkBox_cah.Checked =false;
                }
                else
                {
                    cach = "كاش";
                    tex_cha.Text = txt_total_fatora.Text;
                    tex_cha.Enabled = true;
                }
                }
        }

        private void checkBox_bank_MouseClick(object sender, MouseEventArgs e)
        {
            if(checkBox_bank.Checked == true)
            {
                if (txt_total_fatora.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("خطاء يجب تحدد قيمة الفاتوره");
                    checkBox_bank.Checked = false;
                }
                else
                {

                    bank = "بنكك";
                    tex_bank.Text = txt_total_fatora.Text;
                    tex_bank.Enabled = true;
                }
            }
        }

        private void checkBox_atm_MouseClick(object sender, MouseEventArgs e)
        {
            if(checkBox_atm.Checked == true)
            {
                if (txt_total_fatora.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("خطاء يجب تحدد قيمة الفاتوره");
                    checkBox_atm.Checked = false;
                }
                else
                {
                    atm = "ATM";
                    tex_atm.Text = txt_total_fatora.Text;
                    tex_atm.Enabled = true;
                }
            }
        }

        private void tex_cha_TextChanged(object sender, EventArgs e)
        {
            if(tex_cha.Text.Trim() == string.Empty)
            {
                tex_cha.Text = "0";
            }
        }

        private void tex_bank_TextChanged(object sender, EventArgs e)
        {
            if(tex_bank.Text.Trim() == string.Empty)
            {
                tex_bank.Text = "0";
            }
        }

        private void tex_atm_TextChanged(object sender, EventArgs e)
        {
            if(tex_atm.Text.Trim() == string.Empty)
            {
                tex_atm.Text = "0";
            }
        }

        private void rad_bank_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox_cah_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_cah.Checked == false)
            {
                checkBox_cah.Checked = false;
                tex_cha.Enabled = false;
                tex_cha.Text = "0";
                cach = "";
            }
        }

        private void checkBox_bank_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_bank.Checked == false)
            {
                checkBox_bank.Checked = false;
                tex_bank.Enabled = false;
                tex_bank.Text = "0";
                bank = "";
            }
        }

        private void checkBox_atm_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_atm.Checked == false)
            {
                checkBox_atm.Checked = false;
                tex_atm.Enabled = false;
                tex_atm.Text = "0";
                atm = "";

            }
        }

        private void date_sal_ValueChanged(object sender, EventArgs e)
        {
            DateTime dtnow = DateTime.Now;
            DateTime dtn ;

            date_sal.Value.ToString("yyyy-MM-dd");
            dtnow.ToString("yyyy-MM-dd");
            dtn = date_sal.Value;
            TimeSpan t = dtnow.Subtract(dtn);

            //< اقل
            if (t.Days >= 3 || t.Days <= 0)
            {
               // MessageBox.Show("قيه اليوم "+t.Days);
               date_sal.Value = dtnow;
                return;
            }
           // else 
            if (dtn.Month < dtnow.Month || dtn.Month > dtnow.Month || dtn.Year < dtnow.Year || dtn.Year > dtnow.Year)
            {
              //  MessageBox.Show("قيه ذياده ");
                date_sal.Value = dtnow;
                return;
            }
        }

        private async void txt_item_nam_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void txt_item_nam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // منع صوت التنبيه المزعج عند ضغط Enter
                e.SuppressKeyPress = true;

                if (!string.IsNullOrEmpty(txt_item_nam.Text))
                {
                    GetItemDetails(txt_item_nam.Text.Trim());
                }
            }
        }

        private void rad_atm_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        //==============================chaek from item

        public string ch_item(String searchValue)
        {

             
            int rowIndex = -1;
            foreach (DataGridViewRow row in dgvitem_sal.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(searchValue))
                {
                    rowIndex = row.Index;
                    MessageBox.Show("خطا في الصنف");
                }
                return null;
            }

            return null;

        }

        //======================
        public void Sum_qty_item()
       {
           try
           {
               if (dgvitem_sal.Rows.Count < 1)
               {
                   sumqty = "0";
               }
               else
               {
                   for (int i = 0; i < dgvitem_sal.Rows.Count; i++)
                   {
                       sumqty = (from DataGridViewRow row in dgvitem_sal.Rows
                                 where row.Cells[3].FormattedValue.ToString() != string.Empty && dgvitem_sal.Rows[i].Cells[0].Value.ToString() == row.Cells[0].FormattedValue.ToString()
                                 select Convert.ToInt32(row.Cells[3].FormattedValue)).Sum().ToString();
                   }
               }

           }
           catch { return; }
           //=======================================
       }

    }
}
