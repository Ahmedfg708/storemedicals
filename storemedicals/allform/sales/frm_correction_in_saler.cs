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

namespace storemedicals.allform.sales
{
    public partial class frm_correction_in_saler : Form
    {

        Data.DataAccesLayer dal = new Data.DataAccesLayer();
        char dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
        DataTable dt = new DataTable();
        int qty=0;
        int id = 0;
        string bar = "";
        string  wti = "";
        string cach = "", bank = "", atm = "";
        public frm_correction_in_saler()
        {
            InitializeComponent();
            txt_ITEM_COUNT.Text = "0";
            txt_ITEM_PRIC.Text = "0";
            tex_atm.Text = "0";
            tex_bank.Text = "0";
            tex_cha.Text = "0";
            
        }

        public void show_dgvitem()
        {
            // 1. تكبير حجم الخط وتغيير نوعه ليكون واضحاً وقابلاً للقراءة
            dgvitem.Font = new Font("Segoe UI", 11, FontStyle.Regular);

            // 2. تكبير عناوين الأعمدة وجعلها عريضة وفي المنتصف
            dgvitem.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvitem.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 3. جعل محاذاة نصوص الخلايا في المنتصف لتنظيم المظهر
            dgvitem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 4. ضبط الارتفاع التلقائي لصفوف الجدول بناءً على محتواها (مهم جداً للنصوص الكبيرة)
            dgvitem.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // 5. ضبط العرض التلقائي للأعمدة لتملأ الشاشة وتتوزع بشكل متناسق
            dgvitem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 6. تفعيل خاصية التفاف النص (WrapText) لكي ينزل النص للسطر التالي إذا كان اسم المنتج طويلاً جداً
            dgvitem.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // 7. زيادة ارتفاع سطر العناوين الرئيسي ليظهر بشكل مريح
            dgvitem.ColumnHeadersHeight = 40;

            // 8. ميزة اختيارية: تلوين سطر وسطر (سطر أبيض وسطر رمادي فاتح) لتسهيل القراءة بالعين
            dgvitem.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);


        }


        public void updatere()
        {
            try
            {
                string st = "تمة المالجه";
                SqlCommand cmd = new SqlCommand("UPDATE exception_eroor SET stat = '"+st+ "' where on_nmber = '"+ txt_order_id.Text+ "'  ", dal.con);
                dal.open();
                cmd.ExecuteNonQuery();
               
                MessageBox.Show("تمة المالجه الخطاء في الفاتورة");
                dal.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable ch()
        {
            try
            {

                DataTable tbl;
                SqlCommand cmd = new SqlCommand("SELECT Reten_itemName from RETURNitem where order_id = '" + txt_order_id.Text + "' and Reten_itemName = '" + txt_ITEM_NAME_AR.Text + "'", dal.con);

                dal.open();
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dal.Close();

                return tbl;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
            

        }


        public void getdata(string tex)
        {
            /*
                        try //,m.ty_cach as \"كاش\",m.mo_cach as \"القيمه\" ,m.ty_bank as \"بنكك\" ,m.mo_bank as \"القيمه\",m.ty_atm as \"ATM\" ,m.mo_atm as\"القيمة\" ,f.pink as\"الدوام\"
                        {
                            SqlCommand cmd = new SqlCommand("SELECT id as \"المعرف\" , item_id as \"رقم الصنف\" , order_id as \"الفاتورة\", ITEM_NAME_AR as \"أسم الصنف\" , ITEM_COUNT as \"الكمية\" , ITEM_PRIC as \"السعر\", Amount as \"المبلغ\" , pink as \"الدوام\"  FROM itemOrderDeail WHERE order_id = '" + tex+ "'", dal.con);

                            SqlCommand cmd2 = new SqlCommand("SELECT order_id as \"رقم\", ty_cach as \"كاش\", mo_cach as \"القيمه\" , ty_bank as \"بنكك\" , mo_bank as \"القيمة\", ty_atm as \"ATM\" , mo_atm as\"القيمة\" , wtim as\"الدوام\" from typ_money WHERE order_id = '" + tex + "'", dal.con);

                            dal.open();
                            DataTable tbl = null; DataTable TDLMMO = null; TDLMMO = new DataTable();
                            tbl = new DataTable();

                            tbl.Load(cmd.ExecuteReader());

                            TDLMMO.Load(cmd2.ExecuteReader());

                            dgvitem.DataSource = tbl;

                            dataGridView1.DataSource = TDLMMO;

                            dgvitem.Columns[0].Width = 50;
                            dgvitem.Columns[1].Width = 50;
                            dgvitem.Columns[2].Width = 50;
                            dgvitem.Columns[3].Width = 150;
                            dgvitem.Columns[4].Width = 80;
                            dgvitem.Columns[5].Width = 80;

                            dal.Close();

                            totalSumdgv();

                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }*/

            // شرط أمان: إذا تم استدعاء الدالة بنص فارغ عند الفتح، نظف الجداول واخرج بسلام
            if (string.IsNullOrEmpty(tex.Trim()))
            {
                dgvitem.DataSource = null;
                dataGridView1.DataSource = null;
                textBox1.Text = "0";
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT id as \"المعرف\" , item_id as \"رقم الصنف\" , order_id as \"الفاتورة\", ITEM_NAME_AR as \"أسم الصنف\" , ITEM_COUNT as \"الكمية\" , ITEM_PRIC as \"السعر\", Amount as \"المبلغ\" , pink as \"الدوام\"  FROM itemOrderDeail WHERE order_id = @orderId", dal.con);
                SqlCommand cmd2 = new SqlCommand("SELECT order_id as \"رقم\", ty_cach as \"كاش\", mo_cach as \"القيمه\" , ty_bank as \"بنكك\" , mo_bank as \"القيمة\", ty_atm as \"ATM\" , mo_atm as\"القيمة\" , wtim as\"الدوام\" from typ_money WHERE order_id = @orderId", dal.con);

                cmd.Parameters.AddWithValue("@orderId", tex);
                cmd2.Parameters.AddWithValue("@orderId", tex);

                dal.open();
                DataTable tbl = new DataTable();
                DataTable TDLMMO = new DataTable();

                tbl.Load(cmd.ExecuteReader());
                TDLMMO.Load(cmd2.ExecuteReader());

                dgvitem.DataSource = tbl;
                dataGridView1.DataSource = TDLMMO;

                // تأكيد أمان: لا تقم بضبط أبعاد الأعمدة إلا إذا نجح جلب البيانات الفعلي منعاً لأخطاء الـ Index
                if (dgvitem.Rows.Count > 0)
                {
                  //  dgvitem.Columns[0].Width = 50;
                 //   dgvitem.Columns[1].Width = 50;
                 //   dgvitem.Columns[2].Width = 50;
                    dgvitem.Columns[3].Width = 150;
                 //   dgvitem.Columns[4].Width = 80;
                  //  dgvitem.Columns[5].Width = 80;
                }

                dal.Close();

                totalSumdgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dal.Close();
            }


        }

        private void totalSumdgv()
        {
            /* try
             {
                 if (dgvitem.Rows.Count < 0)
                 {
                     textBox1.Text = "0";
                 }
                 else
                 {

                     textBox1.Text = (from DataGridViewRow row in dgvitem.Rows
                                       where row.Cells[6].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();


                    // string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(tex_Total.Text));
                    // tex_Total.Text = formatted;

                 }

             }
             catch { return; }*/

            try
            {
                // تم تصحيح الشرط: إذا كان الجدول فارغاً تماماً أو لا توجد به أسطر حقيقية
                if (dgvitem.Rows == null || dgvitem.Rows.Count == 0)
                {
                    textBox1.Text = "0";
                    return; // اخرج فوراً لمنع حدوث الخطأ
                }

                // حساب المجموع بأمان مع التأكد التام من أن الخلية تحتوي على رقم صالح
                double sum = 0;
                foreach (DataGridViewRow row in dgvitem.Rows)
                {
                    // التأكد من أن السطر ليس سطر الإضافة الجديد وفارغ
                    if (row.IsNewRow) continue;

                    if (row.Cells[6].Value != null && row.Cells[6].Value.ToString().Trim() != string.Empty)
                    {
                        double cellValue = 0;
                        // محاولة تحويل آمنة تماماً (TryParse) تمنع توقف البرنامج نهائياً لو كان النص غير صالح
                        if (double.TryParse(row.Cells[6].Value.ToString(), out cellValue))
                        {
                            sum += cellValue;
                        }
                    }
                }

                textBox1.Text = sum.ToString();
            }
            catch
            {
                textBox1.Text = "0";
            }


        }



        private void claerTex()
        {
            txt_item_id.Clear();
            txt_order_id.Clear();
            txt_ITEM_NAME_AR.Clear();
            txt_ITEM_COUNT.Clear();
            txt_ITEM_PRIC.Clear();
            txt_Amount.Clear();
            txt_ITEM_COUNT.Text = "0";
            txt_ITEM_PRIC.Text = "0";
            checkBox_cah.Checked = false;
            checkBox_bank.Checked = false;
            checkBox_atm.Checked = false;
            comBoxPink.SelectedIndex = -1;

            tex_atm.Text = "0";
            tex_bank.Text = "0";
            tex_cha.Text = "0";
        }
        private void pdatItem()
        {
            try
            {
                string contt = "";

                SqlCommand cmd1 = new SqlCommand("SELECT ITEM_COUNT FROM ITEMS WHERE item_id = '" + txt_item_id.Text + "'", dal.con); 
                dal.open();
                SqlDataReader drd = cmd1.ExecuteReader();

                while (drd.Read())
                {
                    contt = drd["ITEM_COUNT"].ToString();

                }

                dal.Close();

                if (contt != string.Empty && contt != "0")
                {

                    int to = Convert.ToInt32(contt) - Convert.ToInt32(txt_ITEM_COUNT.Text);


                    SqlCommand cmd = new SqlCommand("UPDATE  ITEMS SET ITEM_COUNT='" + Convert.ToInt32(to) + "'WHERE item_id = '" + txt_item_id.Text + "'", dal.con);
                    dal.open();
                    cmd.ExecuteNonQuery();

                    dal.Close();
                }
                else
                {
                    MessageBox.Show("يوجد خطاء");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ITEM_COUNT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void txt_ITEM_PRIC_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            
            getdata(txt_Search.Text);
            if (dataGridView1.Rows.Count < 1)
            {
                //MessageBox.Show("لا يوجد بيانات", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cach = ""; bank = ""; atm = ""; tex_cha.Text = "0"; tex_bank.Text = "0";
                tex_atm.Text = "0"; checkBox_cah.Checked = false; checkBox_bank.Checked = false; checkBox_atm.Checked = false;
                return;
            }
            //  if (dgvitem.Rows.Count < 1)
            //  {
            //   claerTex();

            //   return;
            //  }
        }

        private void dgvitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvitem.Rows.Count < 1)
            {
                MessageBox.Show("لا يوجد بيانات", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            try
            {
                id = Convert.ToInt32(dgvitem.CurrentRow.Cells[0].Value.ToString());
                txt_item_id.Text = (dgvitem.CurrentRow.Cells[1].Value.ToString());
                txt_order_id.Text = (dgvitem.CurrentRow.Cells[2].Value.ToString());
                txt_ITEM_NAME_AR.Text = (dgvitem.CurrentRow.Cells[3].Value.ToString());
                txt_ITEM_COUNT.Text = (dgvitem.CurrentRow.Cells[4].Value.ToString());
                txt_ITEM_PRIC.Text = Convert.ToString(Convert.ToDecimal (dgvitem.CurrentRow.Cells[5].Value.ToString()));
                txt_Amount.Text = Convert.ToString(Convert.ToDecimal(dgvitem.CurrentRow.Cells[6].Value.ToString()));

               // tex_atm.Text = Convert.ToString(dgvitem.CurrentRow.Cells[7].Value.ToString());

                if (dgvitem.CurrentRow.Cells[7].Value.ToString() == "صباح")
                {
                    comBoxPink.SelectedIndex = 0;
                }
                else
                {
                    comBoxPink.SelectedIndex = 1;
                }

                //===============================================================

                if (dataGridView1.Rows.Count < 1)
                {
                    MessageBox.Show("لا يوجد بيانات", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cach = ""; bank = ""; atm = ""; tex_cha.Text = "0"; tex_bank.Text = "0";
                    tex_atm.Text = "0"; checkBox_cah.Checked = false; checkBox_bank.Checked = false; checkBox_atm.Checked = false;
                    return;
                }


                if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == "كاش")
                {
                    checkBox_cah.Checked = true;
                    tex_cha.Enabled = true;

                }
                tex_cha.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "بنكك")
                {
                    checkBox_bank.Checked = true;
                    tex_bank.Enabled = true;
                }
                tex_bank.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value.ToString());

                if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "ATM")
                {
                    checkBox_atm.Checked = true;
                    tex_atm.Enabled = true;
                }

                tex_atm.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value.ToString());

                if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "صباح")
                {
                    comBoxPink.SelectedIndex = 0;
                }
                else
                {
                    comBoxPink.SelectedIndex = 1;
                }

                dgvitem.Rows.RemoveAt(dgvitem.CurrentRow.Index);

                totalSumdgv();

                //=====================================================================================



                btn_update.Enabled = true;
                btn_delet.Enabled = true;
                btn_save.Enabled = false;
                but_UPSUBSEL.Enabled = true;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tbl = null;
            int sum = 0;
                double sum_to = 0;


            if (MessageBox.Show("هل تريد التعديل", "تعديل",  MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    try
                    {

                        SqlCommand cmd0 = new SqlCommand("SELECT Reten_itemName from RETURNitem where order_id = '" + txt_order_id.Text + "' and Reten_itemName = '" + txt_ITEM_NAME_AR.Text + "'", dal.con);

                        dal.open();
                        tbl = new DataTable();
                        tbl.Load(cmd0.ExecuteReader());

                        dal.Close();
                    }catch(Exception ex)
                    {
                        MessageBox.Show("خطاء \n "+ex.Message);
                    }
//===========================================================================================

                    sum = Convert.ToInt32(tex_cha.Text) + Convert.ToInt32(tex_bank.Text) + Convert.ToInt32(tex_atm.Text);
                    sum_to = Convert.ToInt32(textBox1.Text) + Convert.ToDouble(txt_Amount.Text);

//============================================================================================
                    if (tbl.Rows.Count <= 0)
                    {
                        MessageBox.Show("من فضلك اعد الكمية الي المخزان");
                        return;
                    }

                    if (sum < sum_to)
                    {
                        MessageBox.Show("خطاء قيمة الفاتورة اقل من أجمالي الفاتوره", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }

                    if (sum > sum_to)
                    {
                        MessageBox.Show("خطاء قيمة الفاتورة اكبر من أجمالي الفاتوره", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }

                    if(cach.Trim() == string.Empty && bank.Trim() == string.Empty && atm.Trim() == string.Empty )
                    {
                        MessageBox.Show("من فضلك حدد نوع الكاش او بنكك او ATM", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

//=================================================================================================
                    try
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE  itemOrderDeail SET ITEM_NAME_AR = '" + txt_ITEM_NAME_AR.Text + "',ITEM_COUNT='" + Convert.ToInt32 (txt_ITEM_COUNT.Text) + "',Amount = '" +Convert.ToDecimal (txt_Amount.Text) + "' , totalAmount = '" + txt_Amount.Text + "' , pink = '"+ comBoxPink.Text+ "'  WHERE item_id = '" + txt_item_id.Text + "' AND order_id = '" + txt_order_id.Text + "'", dal.con);
                     
                        SqlCommand cmd2 = new SqlCommand("UPDATE  typ_money SET ty_cach='" + cach + "',mo_cach='" + Convert.ToInt32(tex_cha.Text) + "',ty_bank = '" + bank + "' , mo_bank = '" + Convert.ToInt32(tex_bank.Text) + "' , ty_atm = '" + atm + "' , mo_atm = '" + Convert.ToInt32(tex_atm.Text) + "' , wtim ='" + comBoxPink.Text + "' WHERE order_id = '" + txt_order_id.Text + "'", dal.con);
                        dal.open();
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("تمة التعديل");
                        dal.Close();
                        updatere();
                        pdatItem();
                        getdata(txt_Search.Text);
                        claerTex();
                        btn_update.Enabled = false;
                        btn_delet.Enabled = false;
                        btn_save.Enabled = false;
                        but_UPSUBSEL.Enabled = false;

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("لم يتة التعديل \n"+ex.Message);
                    }
 //========================================================================================                   

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("\n"+ex.Message);
            }
        }  //============================================   انتهاء امر التعديل

        private void txt_ITEM_COUNT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Decimal sum = 0;

                if (txt_ITEM_COUNT.Text.Trim() != string.Empty)
                {
                    sum = Convert.ToDecimal(txt_ITEM_COUNT.Text) * Convert.ToDecimal(txt_ITEM_PRIC.Text);

                    txt_Amount.Text = Convert.ToString(sum);
                }
                else
                {
                    txt_ITEM_COUNT.Text = "0";
                    //MessageBox.Show("من فضلك حدد الكمية");
                    txt_ITEM_COUNT.Focus();
                    txt_ITEM_COUNT.Select();
                    txt_ITEM_COUNT.SelectAll();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal sum = 0;

                if (txt_ITEM_COUNT.Text.Trim() != string.Empty)
                {
                    sum = Convert.ToDecimal(txt_ITEM_COUNT.Text) * Convert.ToDecimal(txt_ITEM_PRIC.Text);

                    txt_Amount.Text = Convert.ToString(sum);
                }
                else
                {
                    MessageBox.Show("من فضلك حدد الكمية");
                    txt_ITEM_COUNT.Focus();
                    txt_ITEM_COUNT.SelectAll();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            /* try
             {
                 DataTable tbl = ch();
                 if (MessageBox.Show("هل تريد الحذف", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                 {
                     if (txt_item_id.Text.Trim() == string.Empty && txt_order_id.Text.Trim() == string.Empty)
                     {
                         MessageBox.Show("من فضلك تحقق من رقم الفاتورة");
                     }

                    else if (tbl.Rows.Count <= 0)
                     {
                         MessageBox.Show("من فضلك اعد الكمية الي المخزان");
                     }
                     else
                     {

                         SqlCommand cmd = new SqlCommand("DELETE  itemOrderDeail WHERE id = '"+Convert.ToInt64(id)+"' ", dal.con);
                         dal.open();
                         cmd.ExecuteNonQuery();
                         MessageBox.Show("تمة الحذف");
                         dal.Close();
                         updatere();

                         getdata(txt_Search.Text);
                         claerTex();
                         btn_update.Enabled = false;
                         btn_delet.Enabled = false;
                         btn_save.Enabled = true;
                     }
                 }

                 }catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/


            try
            {
                // 1. تأكيد الحذف من المستخدم
                if (MessageBox.Show("هل تريد حذف هذا الصنف من الفاتورة؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    // التحقق من أن حقول الأرقام ليست فارغة
                    if (txt_item_id.Text.Trim() == string.Empty || txt_order_id.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("من فضلك تحقق من رقم الفاتورة ورقم الصنف");
                        return;
                    }

                    long currentOrderId = Convert.ToInt64(txt_order_id.Text.Trim());
                    long recordId = Convert.ToInt64(id); // المعرف الفرعي للسطر المراد حذفه

                    // متغيرات لحفظ بيانات السطر قبل الحذف للاستفادة منها في الجداول الأخرى
                    int itemID = 0;
                    int qtyToReturn = 0;
                    double itemAmount = 0;

                    dal.open();

                    // 2. جلب بيانات الصنف (رقم الصنف، الكمية، الإجمالي) من السيرفر قبل الحذف
                    string queryGetInfo = "SELECT item_id, ITEM_COUNT, Amount FROM itemOrderDeail WHERE id = @id";
                    using (SqlCommand cmdGetInfo = new SqlCommand(queryGetInfo, dal.con))
                    {
                        cmdGetInfo.Parameters.AddWithValue("@id", recordId);
                        using (SqlDataReader dr = cmdGetInfo.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                itemID = Convert.ToInt32(dr["item_id"]);
                                qtyToReturn = Convert.ToInt32(dr["ITEM_COUNT"]);
                                itemAmount = Convert.ToDouble(dr["Amount"]);
                            }
                            else
                            {
                                MessageBox.Show("لم يتم العثور على بيانات هذا الصنف في السيرفر.");
                                dal.Close();
                                return;
                            }
                        }
                    }

                    // 3. التحقق من كم عدد الأصناف المتبقية في هذه الفاتورة داخل جدول التفاصيل
                    int itemsCountInOrder = 0;
                    string queryCheckCount = "SELECT COUNT(*) FROM itemOrderDeail WHERE order_id = @orderId";
                    using (SqlCommand cmdCheckCount = new SqlCommand(queryCheckCount, dal.con))
                    {
                        cmdCheckCount.Parameters.AddWithValue("@orderId", currentOrderId);
                        itemsCountInOrder = Convert.ToInt32(cmdCheckCount.ExecuteScalar());
                    }

                    // بدء حماية المعاملة الموحدة (SqlTransaction) لضمان أمان العمليات المتتالية
                    SqlTransaction transaction = dal.con.BeginTransaction();

                    try
                    {
                        // 4. إعادة الكمية إلى المخزن الرئيسي (جدول ITEMS) تلقائياً برمجياً دون تدخل المستخدم
                        string queryUpdateStock = "UPDATE ITEMS SET ITEM_COUNT = ITEM_COUNT + @qty WHERE ITEM_ID = @itemId";
                        using (SqlCommand cmdStock = new SqlCommand(queryUpdateStock, dal.con, transaction))
                        {
                            cmdStock.Parameters.AddWithValue("@qty", qtyToReturn);
                            cmdStock.Parameters.AddWithValue("@itemId", itemID);
                            cmdStock.ExecuteNonQuery();
                        }

                        // 5. اتخاذ القرار بناءً على عدد الأصناف المتبقية بالفاتورة
                        if (itemsCountInOrder <= 1)
                        {
                            // 🔥 السيناريو الأول: هذا هو الصنف الوحيد والأخير بالفاتورة -> احذف الفاتورة من الـ 3 جداول بالكامل 🔥

                            // أ- الحذف من جدول تفاصيل الأصناف (الجدول الثاني)
                            string queryDelDetails = "DELETE FROM itemOrderDeail WHERE order_id = @orderId";
                            using (SqlCommand cmdDelDetails = new SqlCommand(queryDelDetails, dal.con, transaction))
                            {
                                cmdDelDetails.Parameters.AddWithValue("@orderId", currentOrderId);
                                cmdDelDetails.ExecuteNonQuery();
                            }

                            // ب- الحذف من جدول الأموال typ_money (الجدول الثالث)
                            string queryDelMoney = "DELETE FROM typ_money WHERE order_id = @orderId";
                            using (SqlCommand cmdDelMoney = new SqlCommand(queryDelMoney, dal.con, transaction))
                            {
                                cmdDelMoney.Parameters.AddWithValue("@orderId", currentOrderId);
                                cmdDelMoney.ExecuteNonQuery();
                            }

                            // ج- الحذف من جدول الفاتورة الرئيسي itemorder (الجدول الأول)
                            string queryDelMaster = "DELETE FROM itemorder WHERE ored_id = @orderId";
                            using (SqlCommand cmdDelMaster = new SqlCommand(queryDelMaster, dal.con, transaction))
                            {
                                cmdDelMaster.Parameters.AddWithValue("@orderId", currentOrderId);
                                cmdDelMaster.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            dal.Close();

                            MessageBox.Show("تم حذف الصنف، وبما أنه الصنف الأخير تم حذف الفاتورة بالكامل من النظام وإعادة الكميات للمخزن بنجاح.", "نجاح الحذف الكامل");
                        }
                        else
                        {
                            // 🔥 السيناريو الثاني: توجد أصناف أخرى بالفاتورة -> احذف الصنف واخصم مبلغه من الجدول المالي فقط 🔥

                            // أ- حذف الصنف الحالي فقط من الجدول الثاني
                            string queryDelItem = "DELETE FROM itemOrderDeail WHERE id = @id";
                            using (SqlCommand cmdDelItem = new SqlCommand(queryDelItem, dal.con, transaction))
                            {
                                cmdDelItem.Parameters.AddWithValue("@id", recordId);
                                cmdDelItem.ExecuteNonQuery();
                            }

                            // ب- تحديث جدول الأموال (typ_money) بخصم القيمة المادية للصنف من الإجمالي المدفوع (paid)
                            // ويقوم الكود أدناه بخصم القيمة من الكاش (mo_cach) كمثال للبيع المباشر إذا كان كافياً
                            string queryUpdateMoney = @"UPDATE typ_money 
                                            SET paid = paid - @amount,
                                                mo_cach = CASE WHEN mo_cach >= @amount THEN mo_cach - @amount ELSE 0 END
                                            WHERE order_id = @orderId";

                            using (SqlCommand cmdUpdateMoney = new SqlCommand(queryUpdateMoney, dal.con, transaction))
                            {
                                cmdUpdateMoney.Parameters.AddWithValue("@amount", itemAmount);
                                cmdUpdateMoney.Parameters.AddWithValue("@orderId", currentOrderId);
                                cmdUpdateMoney.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            dal.Close();

                            MessageBox.Show("تم حذف الصنف من الفاتورة، وإعادة كميته للمخزن، وتحديث الحساب المالي المباشر بنجاح.", "تم الحذف");
                        }

                        // تحديث الواجهات وتنظيف التكست بوكس كما كان في كودك الأصلي
                        updatere();
                        getdata(txt_Search.Text);
                        claerTex();

                        btn_update.Enabled = false;
                        btn_delet.Enabled = false;
                        btn_save.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        // في حالة حدوث أي خطأ، يتم التراجع فورا وإلغاء أي حذف لحماية المخازن والحسابات المليية
                        transaction.Rollback();
                        MessageBox.Show("فشل إتمام التعديل، تم حماية الجداول والمخازن من التضارب: " + ex.Message, "خطأ في تنفيذ العملية");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في الاتصال بقاعدة البيانات: " + ex.Message);
            }
            finally
            {
                dal.Close();
            }




        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_item_Click(object sender, EventArgs e)
        {
            frm_itemList fm = new frm_itemList();
            fm.ShowDialog();
            try
            {

                txt_item_id.Text = fm.dgvitem.CurrentRow.Cells[0].Value.ToString();
                txt_ITEM_NAME_AR.Text = fm.dgvitem.CurrentRow.Cells[1].Value.ToString();
                // txt_barcod.Text = fm.dgvitem.CurrentRow.Cells[2].Value.ToString();
                  qty = Convert.ToInt32(fm.dgvitem.CurrentRow.Cells[3].Value.ToString());
                  txt_ITEM_PRIC.Text = fm.dgvitem.CurrentRow.Cells[5].Value.ToString();


                  txt_ITEM_COUNT.Text = "0";
                //   btn_add_item.Focus();
                //btn_add_item_Click(sender,e);
            }
            catch { return; }
        }

       

        private void btn_add_item_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_item_id.Text == string.Empty)
                {
                    return;
                }
                DataRow row = dt.NewRow();
                row[0] = txt_item_id.Text;
                row[1] = txt_order_id.Text;
                row[2] = txt_ITEM_NAME_AR.Text;
                row[3] = "0";
                row[4] = txt_ITEM_COUNT.Text;
                row[5] = txt_ITEM_PRIC.Text; ;
                row[6] = txt_Amount.Text;
                row[7] = txt_Amount.Text;
                dt.Rows.Add(row);
                this.dgvitem.DataSource = dt;

            }
            catch { return; }


        }

        private void txt_ITEM_COUNT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add_item_Click(sender, e);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //  DataTable tbl = null;

            //  try
            // {
            //
            //  SqlCommand cmd = new SqlCommand("SELECT pa_type,pink from itemOrderDeail where order_id = '" + txt_order_id.Text + "' and pa_type = '" +tymo+ "' and pink='"+comBoxPink.ToString()+"' ", dal.con);

            //  dal.open();
            //  tbl = new DataTable();
            //  tbl.Load(cmd.ExecuteReader());


            //    dal.Close();
            //  }
            //  catch (Exception ex)
            // {
            //     MessageBox.Show("خطاء \n " + ex.Message);
            //  } cach = "", bank = "", atm = ""

            double sum = 0;
            sum = Convert.ToDouble(tex_cha.Text) + Convert.ToDouble(tex_bank.Text) + Convert.ToDouble(tex_atm.Text);

            try
            {
                if (txt_item_id.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("رقم الصنف فارغ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_item_id.Focus();
                    txt_item_id.Select();
                    txt_item_id.SelectAll();
                }
                else if (txt_order_id.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("رقم الفاتورة فارغ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_order_id.Focus();
                    txt_order_id.Select();
                    txt_order_id.SelectAll();

                }
                else if (txt_ITEM_NAME_AR.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("اسم الصنف فارغ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ITEM_NAME_AR.Focus();
                    txt_ITEM_NAME_AR.Select();
                    txt_ITEM_NAME_AR.SelectAll();
                }
                else if (txt_ITEM_COUNT.Text.Trim() == string.Empty || txt_ITEM_COUNT.Text.Trim() == "0")
                {
                    MessageBox.Show("الكمية غير محدد", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ITEM_COUNT.Focus();
                    txt_ITEM_COUNT.Select();
                    txt_ITEM_COUNT.SelectAll();
                }
                else if (qty <= 0 || Convert.ToInt32(txt_ITEM_COUNT.Text) > qty)
                {
                    MessageBox.Show("كمية الصنف المطلوبة اكبر من الكمية المجودة بالمخزن", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (wti.Trim()== string.Empty)
                {
                    MessageBox.Show("نوع الدوام", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else if (sum < Convert.ToDouble(txt_Amount.Text))
                {
                    MessageBox.Show("خطاء قيمة الفاتورة اقل من أجمالي الفاتوره", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                   
                }

                else if (sum > Convert.ToDouble(txt_Amount.Text))
                {
                    MessageBox.Show("خطاء قيمة الفاتورة اكبر من أجمالي الفاتوره", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    
                }

               else  if (checkBox_cah.Checked == false && checkBox_bank.Checked == false && checkBox_atm.Checked == false)
                {
                    MessageBox.Show("من فضلك حدد نوع الكاش او بنكك او ATM");
                    
                }

              else  if (checkBox_cah.Checked == true && tex_cha.Text == Convert.ToString("0"))
                {
                    MessageBox.Show("من فضلك حدد القيه", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tex_cha.Focus();
                    tex_cha.SelectAll();

                    
                }

              else  if (checkBox_bank.Checked == true && tex_bank.Text == Convert.ToString("0"))
                {
                    MessageBox.Show("من فضلك حدد القيه", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tex_bank.Focus();
                    tex_bank.SelectAll();

                   
                }

              else  if (checkBox_atm.Checked == true && tex_atm.Text == Convert.ToString("0"))
                {
                    MessageBox.Show("من فضلك حدد القيه", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tex_atm.Focus();
                    tex_atm.SelectAll();

                    
                }


                else
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO itemOrderDeail VALUES ('" + txt_item_id.Text + "','" + txt_order_id.Text + "','" + txt_ITEM_NAME_AR.Text + "','"+bar+ "', '"+ txt_ITEM_COUNT.Text+ "','"+ txt_ITEM_PRIC.Text+ "','"+ txt_Amount.Text+ "','"+ txt_Amount.Text+ "','"+ cach + "', '"+tex_cha.Text+"', '"+bank+"' , '"+tex_bank.Text+"', '"+atm+"' , '"+tex_atm.Text+"' ,'"+wti+"' )", dal.con);
                    dal.open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تمة اضاة صنف جديد الي الفاتورة");
                    dal.Close();


                    SqlCommand cmd2 = new SqlCommand("INSERT INTO typ_money VALUES ('" + txt_order_id.Text + "','" + cach + "','" + Convert.ToInt32(tex_cha.Text) + "','" + bank + "','" + Convert.ToInt32(tex_bank.Text) + "','" + atm + "','" + Convert.ToInt32(tex_atm.Text) + "' , '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' )", dal.con);
                    dal.open();
                    cmd2.ExecuteNonQuery();

                    dal.Close();

                    pdatItem();
                    getdata(txt_order_id.Text);
                    claerTex();


                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox_cah_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cah.Checked == false)
            {
                checkBox_cah.Checked = false;
                tex_cha.Enabled = false;
                tex_cha.Text = "0";
                cach = "";
            }
        }

        private void checkBox_cah_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox_cah.Checked == true)
            {
                if (txt_Amount.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("خطاء يجب تحدد قيمة الفاتوره");
                    checkBox_cah.Checked = false;
                }
                else
                {
                    cach = "كاش";
                    tex_cha.Text = txt_Amount.Text;
                    tex_cha.Enabled = true;
                }
            }
        }

        private void checkBox_bank_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_bank.Checked == false)
            {
                checkBox_bank.Checked = false;
                tex_bank.Enabled = false;
                tex_bank.Text = "0";
                bank = "";
            }
        }

        private void checkBox_bank_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox_bank.Checked == true)
            {
                if (txt_Amount.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("خطاء يجب تحدد قيمة الفاتوره");
                    checkBox_bank.Checked = false;
                }
                else
                {

                    bank = "بنكك";
                    tex_bank.Text = txt_Amount.Text;
                    tex_bank.Enabled = true;
                }
            }
        }

        private void checkBox_atm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_atm.Checked == false)
            {
                checkBox_atm.Checked = false;
                tex_atm.Enabled = false;
                tex_atm.Text = "0";
                atm = "";

            }
        }

        private void checkBox_atm_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox_atm.Checked == true)
            {
                if (txt_Amount.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("خطاء يجب تحدد قيمة الفاتوره");
                    checkBox_atm.Checked = false;
                }
                else
                {
                    atm = "ATM";
                    tex_atm.Text = txt_Amount.Text;
                    tex_atm.Enabled = true;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == "كاش")
            {
                checkBox_cah.Checked = true;
                tex_cha.Enabled = true;

            }
            tex_cha.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "بنكك")
            {
                checkBox_bank.Checked = true;
                tex_bank.Enabled = true;
            }
            tex_bank.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value.ToString());

            if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "ATM")
            {
                checkBox_atm.Checked = true;
                tex_atm.Enabled = true;
            }

            tex_atm.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value.ToString());

            if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "صباح")
            {
                comBoxPink.SelectedIndex = 0;
            }
            else
            {
                comBoxPink.SelectedIndex = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;

            sum = Convert.ToInt32(tex_cha.Text) + Convert.ToInt32(tex_bank.Text) + Convert.ToInt32(tex_atm.Text);

            if (txt_order_id.Text.Trim() == string.Empty)
            {

                MessageBox.Show("رقم الفاتورة فارغ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_order_id.Focus();
                txt_order_id.Select();
                txt_order_id.SelectAll();
                return; 

            }

            if (comBoxPink.SelectedIndex == -1)
            {
                MessageBox.Show("حدد نوع الدوام", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (sum < Convert.ToInt32(textBox1.Text))
            {
                MessageBox.Show("خطاء قيمة الفاتورة اقل من أجمالي الفاتوره", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (sum > Convert.ToInt32(textBox1.Text))
            {
                MessageBox.Show("خطاء قيمة الفاتورة اكبر من أجمالي الفاتوره", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (cach.Trim() == string.Empty && bank.Trim() == string.Empty && atm.Trim() == string.Empty)
            {
                MessageBox.Show("من فضلك حدد نوع الكاش او بنكك او ATM", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlCommand cmd2 = new SqlCommand("UPDATE  typ_money SET ty_cach='" + cach + "',mo_cach='" + Convert.ToInt32(tex_cha.Text) + "',ty_bank = '" + bank + "' , mo_bank = '" + Convert.ToInt32(tex_bank.Text) + "' , ty_atm = '" + atm + "' , mo_atm = '" + Convert.ToInt32(tex_atm.Text) + "' , wtim ='" + comBoxPink.Text + "' WHERE order_id = '" + txt_order_id.Text + "'", dal.con);
                dal.open();   
                cmd2.ExecuteNonQuery();
                MessageBox.Show("تمة التحديث");
                dal.Close();
               
                getdata(txt_Search.Text);
                claerTex();
                totalSumdgv();
                btn_update.Enabled = false;
                btn_delet.Enabled = false;
                btn_save.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            btn_update.Enabled = false;
            btn_delet.Enabled = false;
            claerTex();
        }

        private void frm_correction_in_saler_Load(object sender, EventArgs e)
        {
            show_dgvitem();
        }

        private void comBoxPink_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxPink.SelectedIndex == 0)
            {
                wti = "صباح";
            }
            else
            {
                wti = "مساء";
            }
        }

       
       

      

        private void txt_ITEM_PRIC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Decimal sum = 0;

                if (txt_ITEM_COUNT.Text.Trim() != string.Empty)
                {
                    sum = Convert.ToDecimal(txt_ITEM_COUNT.Text) * Convert.ToDecimal(txt_ITEM_PRIC.Text);

                    txt_Amount.Text = Convert.ToString(sum);
                }
                else
                {
                    txt_ITEM_COUNT.Text = "0";
                    //MessageBox.Show("من فضلك حدد الكمية");
                    txt_ITEM_COUNT.Focus();
                    txt_ITEM_COUNT.Select();
                    txt_ITEM_COUNT.SelectAll();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
