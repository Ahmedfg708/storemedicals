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

namespace storemedicals.allform.sales
{
    public partial class Frm_sals_defe_controol : Form
    {
        Data.DataAccesLayer dal = new Data.DataAccesLayer();

        public int id_order = 0;

        public Frm_sals_defe_controol()
        {
            InitializeComponent();
        }

        private void DisableActionButtons()
        {
            if (!dgvitem_sho_ord.Columns.Contains("btnEdit") || !dgvitem_sho_ord.Columns.Contains("btnDelete"))
            {
                return;
            }

            foreach (DataGridViewRow row in dgvitem_sho_ord.Rows)
            {
                if (row.Cells["btnEdit"] is DataGridViewButtonCell cellEdit)
                {
                    cellEdit.FlatStyle = FlatStyle.Flat;
                    cellEdit.Style.BackColor = Color.FromArgb(240, 240, 240); // خلفية رمادية فاتحة جداً
                    cellEdit.Style.ForeColor = Color.DarkGray; // خط رمادي غامق لعدم التنشيط
                    cellEdit.Style.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                }
                if (row.Cells["btnDelete"] is DataGridViewButtonCell cellDelete)
                {
                    cellDelete.FlatStyle = FlatStyle.Flat;
                    cellDelete.Style.BackColor = Color.FromArgb(240, 240, 240);
                    cellDelete.Style.ForeColor = Color.DarkGray;
                    cellDelete.Style.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                }
            }
        }

        /*      private void DisableActionButtons()
              {
                  // التحقق من وجود الأعمدة قبل الدخول في الحلقة
                  if (!dgvitem_sho_ord.Columns.Contains("btnEdit") || !dgvitem_sho_ord.Columns.Contains("btnDelete"))
                  {
                      return;
                  }

                  foreach (DataGridViewRow row in dgvitem_sho_ord.Rows)
                  {
                      if (row.Cells["btnEdit"] is DataGridViewButtonCell cellEdit)
                      {
                          cellEdit.FlatStyle = FlatStyle.Flat;
                          cellEdit.Style.ForeColor = Color.Gray;
                      }
                      if (row.Cells["btnDelete"] is DataGridViewButtonCell cellDelete)
                      {
                          cellDelete.FlatStyle = FlatStyle.Flat;
                          cellDelete.Style.ForeColor = Color.Gray;
                      }
                  }
              }*/

        /*public void getdata(string tex)
        {
            try //,m.ty_cach as \"كاش\",m.mo_cach as \"القيمه\" ,m.ty_bank as \"بنكك\" ,m.mo_bank as \"القيمه\",m.ty_atm as \"ATM\" ,m.mo_atm as\"القيمة\" ,f.pink as\"الدوام\"
            {
                SqlCommand cmd = new SqlCommand("SELECT id as \"المعرف\" , item_id as \"رقم الصنف\" , order_id as \"الفاتورة\", ITEM_NAME_AR as \"أسم الصنف\" , ITEM_COUNT as \"الكمية\" , ITEM_PRIC as \"السعر\", Amount as \"المبلغ\" , pink as \"الدوام\"  FROM itemOrderDeail WHERE order_id = '" + tex + "'", dal.con);

               // SqlCommand cmd2 = new SqlCommand("SELECT order_id as \"رقم\", ty_cach as \"كاش\", mo_cach as \"القيمه\" , ty_bank as \"بنكك\" , mo_bank as \"القيمة\", ty_atm as \"ATM\" , mo_atm as\"القيمة\" , wtim as\"الدوام\" from typ_money WHERE order_id = '" + tex + "'", dal.con);

                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();

                tbl.Load(cmd.ExecuteReader());

                dgvitem_sho_ord.DataSource = tbl;
              
                dal.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/


        public void getdata(string tex)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT id as \"المعرف\" , item_id as \"رقم الصنف\" , order_id as \"الفاتورة\", ITEM_NAME_AR as \"أسم الصنف\" , ITEM_COUNT as \"الكمية\" , ITEM_PRIC as \"السعر\", Amount as \"المبلغ\" , pink as \"الدوام\"  FROM itemOrderDeail WHERE order_id = '" + tex + "'", dal.con);

                dal.open();
                DataTable tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem_sho_ord.DataSource = tbl;
                dal.Close();

                // --- [المهمة 1]: إضافة الأزرار برمجياً بعد تحميل البيانات ---
                if (!dgvitem_sho_ord.Columns.Contains("btnEdit"))
                {
                    DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                    btnEdit.Name = "btnEdit";
                    btnEdit.HeaderText = "تعديل";
                    btnEdit.Text = "تعديل";
                    btnEdit.UseColumnTextForButtonValue = true;
                    btnEdit.Width = 70;
                    dgvitem_sho_ord.Columns.Add(btnEdit);
                }

                if (!dgvitem_sho_ord.Columns.Contains("btnDelete"))
                {
                    DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                    btnDelete.Name = "btnDelete";
                    btnDelete.HeaderText = "حذف";
                    btnDelete.Text = "حذف";
                    btnDelete.UseColumnTextForButtonValue = true;
                    btnDelete.Width = 70;
                    dgvitem_sho_ord.Columns.Add(btnDelete);
                }

                // --- [المهمة 3]: حماية الحقول والسماح فقط بتعديل "الكمية" و "السعر" ---
                dgvitem_sho_ord.ReadOnly = false;
                foreach (DataGridViewColumn col in dgvitem_sho_ord.Columns)
                {
                    if (col.Name == "الكمية" || col.Name == "السعر" || col.Name == "btnEdit" || col.Name == "btnDelete")
                    {
                        col.ReadOnly = false;
                    }
                    else
                    {
                        col.ReadOnly = true;
                    }
                }

                /* // --- [المهمة 4]: جعل الحقول واضحة تماماً مهما كان طول البيانات ---
                 dgvitem_sho_ord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                 dgvitem_sho_ord.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                 dgvitem_sho_ord.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

                 // تشغيل وضعية الإيقاف المبدئي للأزرار
                 DisableActionButtons();*/


                // --- [المهمة 4]: تنسيق الحجم وعرض الشاشة وتكبير الخط ---

                // 1. جعل الأعمدة تمتد لتملأ كامل عرض الجدول تلقائياً بدون فراغ أبيض
                dgvitem_sho_ord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // 2. تكبير خط الخلايا والنصوص داخل الجدول (حجم 11 ولون خط واضح)
                dgvitem_sho_ord.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

                // 3. تكبير خط عناوين الأعمدة (العناوين الرئيسية في الأعلى)
                dgvitem_sho_ord.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

                // 4. ضبط التفاف النص وتوسيط المحتوى ليكون متناسقاً
                dgvitem_sho_ord.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvitem_sho_ord.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvitem_sho_ord.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // 5. زيادة ارتفاع الصفوف والعناوين ليتناسب مع الحجم الجديد للخط
                dgvitem_sho_ord.RowTemplate.Height = 35;
                dgvitem_sho_ord.ColumnHeadersHeight = 40;
                dgvitem_sho_ord.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

                // تشغيل وضعية الإيقاف المبدئي للأزرار
                DisableActionButtons();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dal.con.State == ConnectionState.Open) dal.Close();
            }
        }

     


        private void Frm_sals_defe_controol_Load(object sender, EventArgs e)
        {

            string convid = Convert.ToString(id_order);

            getdata(convid);
        }

        private void dgvitem_sho_ord_SelectionChanged(object sender, EventArgs e)
        {

            /*      // شرط حماية: إذا لم يتم إنشاء أعمدة الأزرار بعد، اخرج فوراً لمنع الخطأ الظاهر في الصورة
                  if (!dgvitem_sho_ord.Columns.Contains("btnEdit") || !dgvitem_sho_ord.Columns.Contains("btnDelete"))
                  {
                      return;
                  }

                  // إذا كانت الأعمدة موجودة، نطبق المنطق بأمان
                  DisableActionButtons();

                  if (dgvitem_sho_ord.CurrentRow != null && dgvitem_sho_ord.CurrentRow.Index >= 0)
                  {
                      DataGridViewRow currentRow = dgvitem_sho_ord.CurrentRow;

                      if (currentRow.Cells["btnEdit"] is DataGridViewButtonCell cellEdit)
                      {
                          cellEdit.FlatStyle = FlatStyle.Standard;
                          cellEdit.Style.ForeColor = Color.Black;
                          cellEdit.Style.Font = new Font("Segoe UI", 11, FontStyle.Bold); // تكبير خط زر التعديل
                      }
                      if (currentRow.Cells["btnDelete"] is DataGridViewButtonCell cellDelete)
                      {
                          cellDelete.FlatStyle = FlatStyle.Standard;
                          cellDelete.Style.ForeColor = Color.Red;
                          cellDelete.Style.Font = new Font("Segoe UI", 11, FontStyle.Bold); // تكبير خط زر الحذف
                      }
                  }*/


            if (!dgvitem_sho_ord.Columns.Contains("btnEdit") || !dgvitem_sho_ord.Columns.Contains("btnDelete"))
            {
                return;
            }

            // إعادة وضع الإيقاف لكل الصفوف أولاً
            DisableActionButtons();

            // تنشيط صف المستخدم الحالي بألوان زاهية وواضحة
            if (dgvitem_sho_ord.CurrentRow != null && dgvitem_sho_ord.CurrentRow.Index >= 0)
            {
                DataGridViewRow currentRow = dgvitem_sho_ord.CurrentRow;

                // تنشيط زر التعديل (أزرق ملكي مريح للعين)
                if (currentRow.Cells["btnEdit"] is DataGridViewButtonCell cellEdit)
                {
                    cellEdit.FlatStyle = FlatStyle.Popup;
                    cellEdit.Style.BackColor = Color.FromArgb(0, 122, 204); // لون أزرق احترافي
                    cellEdit.Style.ForeColor = Color.White; // خط أبيض واضح جداً
                    cellEdit.Style.SelectionBackColor = Color.FromArgb(0, 122, 204);
                    cellEdit.Style.SelectionForeColor = Color.White;
                    cellEdit.Style.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                }

                // تنشيط زر الحذف (أحمر قرمزي للتنبيه)
                if (currentRow.Cells["btnDelete"] is DataGridViewButtonCell cellDelete)
                {
                    cellDelete.FlatStyle = FlatStyle.Popup;
                    cellDelete.Style.BackColor = Color.FromArgb(217, 83, 79); // لون أحمر غني وواضح للعين
                    cellDelete.Style.ForeColor = Color.White; // خط أبيض
                    cellDelete.Style.SelectionBackColor = Color.FromArgb(217, 83, 79);
                    cellDelete.Style.SelectionForeColor = Color.White;
                    cellDelete.Style.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                }
            }

        }

        private void dgvitem_sho_ord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex < 0) return;

            DataGridViewRow clickedRow = dgvitem_sho_ord.Rows[e.RowIndex];

            // ==========================================
            // 1. منطق زر الحذف المطور (مع التنظيف التلقائي للفاتورة الفارغة)
            // ==========================================
            if (dgvitem_sho_ord.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                if (dgvitem_sho_ord.CurrentRow.Index != e.RowIndex) return;

                int recordID = Convert.ToInt32(clickedRow.Cells["المعرف"].Value);
                int itemID = Convert.ToInt32(clickedRow.Cells["رقم الصنف"].Value);
                int itemQty = Convert.ToInt32(clickedRow.Cells["الكمية"].Value);
                double itemAmount = Convert.ToDouble(clickedRow.Cells["المبلغ"].Value);
                string itemName = clickedRow.Cells["أسم الصنف"].Value.ToString();

                DialogResult result = MessageBox.Show($"هل أنت متأكد من حذف صنف ({itemName}) نهائياً؟ سيتم إرجاع الكمية للمخزن وتعديل الحسابات.", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    dal.open();
                    SqlTransaction transaction = dal.con.BeginTransaction(); // حماية البيانات عبر العملية الموحدة

                    try
                    {
                        // أ- إرجاع الكمية إلى جدول المخزن ITEMS
                        SqlCommand cmdStock = new SqlCommand("UPDATE ITEMS SET ITEM_COUNT = ITEM_COUNT + @qty WHERE ITEM_ID = @itemId", dal.con, transaction);
                        cmdStock.Parameters.AddWithValue("@qty", itemQty);
                        cmdStock.Parameters.AddWithValue("@itemId", itemID);
                        cmdStock.ExecuteNonQuery();

                        // ب- خصم القيمة المالية من جدول الديون tab_deble
                        SqlCommand cmdDebt = new SqlCommand("UPDATE tab_deble SET sele_rest = sele_rest - @amount WHERE order_id = @orderId", dal.con, transaction);
                        cmdDebt.Parameters.AddWithValue("@amount", itemAmount);
                        cmdDebt.Parameters.AddWithValue("@orderId", id_order);
                        cmdDebt.ExecuteNonQuery();

                        // j- حذف السجل نهائياً من تفاصيل الفاتورة
                        SqlCommand cmdDel = new SqlCommand("DELETE FROM itemOrderDeail WHERE id = @id", dal.con, transaction);
                        cmdDel.Parameters.AddWithValue("@id", recordID);
                        cmdDel.ExecuteNonQuery();

                        // د- الفحص الذكي: هل بقيت أي أصناف أخرى في هذه الفاتورة؟
                        SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM itemOrderDeail WHERE order_id = @orderId", dal.con, transaction);
                        cmdCheck.Parameters.AddWithValue("@orderId", id_order);
                        int remainingItems = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        bool invoiceDeletedFully = false;

                        // هـ- إذا أصبحت الفاتورة فارغة تماماً (0 صنف)، احذف قيودها نهائياً من بقية الجداول
                        if (remainingItems == 0)
                        {
                            // 1. حذف القيد من جدول الديون التابع للعميل
                            SqlCommand cmdDelDebt = new SqlCommand("DELETE FROM tab_deble WHERE order_id = @orderId", dal.con, transaction);
                            cmdDelDebt.Parameters.AddWithValue("@orderId", id_order);
                            cmdDelDebt.ExecuteNonQuery();

                            // 2. حذف الفاتورة من الجدول الرئيسي للفواتير (تم تعديل الحقل إلى ored_id هنا)
                            SqlCommand cmdDelMainOrder = new SqlCommand("DELETE FROM itemorder WHERE ored_id = @orderId", dal.con, transaction);
                            cmdDelMainOrder.Parameters.AddWithValue("@orderId", id_order);
                            cmdDelMainOrder.ExecuteNonQuery();

                            invoiceDeletedFully = true;
                        }

                        // اعتماد العملية بالكامل بنجاح
                        transaction.Commit();
                        dal.Close();

                        if (invoiceDeletedFully)
                        {
                            MessageBox.Show("تم حذف آخر صنف في الفاتورة بنجاح، ونظراً لأن الفاتورة أصبحت فارغة، تم مسحها بالكامل من النظام ومن جدول الديون.", "تنظيف الفاتورة بالكامل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // غلق شاشة المعاينة تلقائياً لأن الفاتورة لم يعد لها وجود
                        }
                        else
                        {
                            MessageBox.Show("تم حذف الصنف، وإعادة المخزون، وتحديث متبقي الدين بنجاح", "نجاح");
                            getdata(id_order.ToString()); // إعادة تحديث الجدول لوجود أصناف أخرى
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // تراجع كامل في حال حدوث أي خطأ حمايةً للنظام
                        MessageBox.Show("فشلت العملية، تم التراجع لمنع الأخطاء: " + ex.Message);
                    }
                    finally { dal.Close(); }
                }
            }

            // ==========================================
            // 2. منطق زر التعديل (معالجة فروقات المخزن والدين)
            // ==========================================
            if (dgvitem_sho_ord.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                if (dgvitem_sho_ord.CurrentRow.Index != e.RowIndex) return;

                int recordID = Convert.ToInt32(clickedRow.Cells["المعرف"].Value);
                int itemID = Convert.ToInt32(clickedRow.Cells["رقم الصنف"].Value);

                // القيم الجديدة المكتوبة في الجدول حالياً
                int newQty = Convert.ToInt32(clickedRow.Cells["الكمية"].Value);
                double newPrice = Convert.ToDouble(clickedRow.Cells["السعر"].Value);
                double newAmount = newQty * newPrice;

                // المتغيرات لجلب القيم القديمة والكمية الحالية في المخزن
                int oldQty = 0;
                double oldAmount = 0;
                int currentStockQty = 0; // متغير جديد لحفظ كمية المخزن الحالية

                try
                {
                    dal.open();

                    // أ- جلب البيانات الحالية للفاتورة من السيرفر
                    SqlCommand cmdGetOld = new SqlCommand("SELECT ITEM_COUNT, Amount FROM itemOrderDeail WHERE id = @id", dal.con);
                    cmdGetOld.Parameters.AddWithValue("@id", recordID);
                    using (SqlDataReader dr = cmdGetOld.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            oldQty = Convert.ToInt32(dr["ITEM_COUNT"]);
                            oldAmount = Convert.ToDouble(dr["Amount"]);
                        }
                    }

                    // ب- جلب كمية الصنف المتوفرة في المخزن حالياً
                    SqlCommand cmdGetStock = new SqlCommand("SELECT ITEM_COUNT FROM ITEMS WHERE ITEM_ID = @itemId", dal.con);
                    cmdGetStock.Parameters.AddWithValue("@itemId", itemID);
                    object stockObj = cmdGetStock.ExecuteScalar();
                    if (stockObj != null)
                    {
                        currentStockQty = Convert.ToInt32(stockObj);
                    }

                    // حساب الفروقات الرياضية
                    int qtyDifference = oldQty - newQty; // موجب = يعود للمخزن، سالب = يخصم من المخزن
                    double amountDifference = newAmount - oldAmount;

                    // 🌟 شرط التحقق الحاسم لحماية المخزن من السحب بالسالب 🌟
                    if (qtyDifference < 0) // تعني أن المستخدم قام بزيادة الكمية
                    {
                        int requiredQty = Math.Abs(qtyDifference); // الكمية الإضافية المطلوبة

                        if (currentStockQty < requiredQty)
                        {
                            MessageBox.Show($"عذراً، الكمية المطلوبة غير متوفرة في المخزن!\nالكمية المتوفرة حالياً في المخزن هي: {currentStockQty} قطعة فقط.\nأنت تحاول زيادة الفاتورة بـ {requiredQty} قطعة إضافية.", "رصيد غير كافٍ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dal.Close();
                            return; // إيقاف العملية فوراً
                        }
                    }

                    // بدء حماية المعاملة الموحدة (Transaction) بعد التأكد من سلامة الشروط
                    SqlTransaction transaction = dal.con.BeginTransaction();

                    try
                    {
                        // ج- تحديث جدول تفاصيل الأصناف بالقيم الجديدة
                        SqlCommand cmdUp = new SqlCommand("UPDATE itemOrderDeail SET ITEM_COUNT = @c, ITEM_PRIC = @p, Amount = @a WHERE id = @id", dal.con, transaction);
                        cmdUp.Parameters.AddWithValue("@c", newQty);
                        cmdUp.Parameters.AddWithValue("@p", newPrice);
                        cmdUp.Parameters.AddWithValue("@a", newAmount);
                        cmdUp.Parameters.AddWithValue("@id", recordID);
                        cmdUp.ExecuteNonQuery();

                        // د- تحديث المخزن ITEMS بالفارق الرياضي (مضمون الآن ولن يصبح سالباً)
                        SqlCommand cmdStock = new SqlCommand("UPDATE ITEMS SET ITEM_COUNT = ITEM_COUNT + @qtyDiff WHERE ITEM_ID = @itemId", dal.con, transaction);
                        cmdStock.Parameters.AddWithValue("@qtyDiff", qtyDifference);
                        cmdStock.Parameters.AddWithValue("@itemId", itemID);
                        cmdStock.ExecuteNonQuery();

                        // هـ- تحديث جدول الديون tab_deble بالفارق المالي
                        SqlCommand cmdDebt = new SqlCommand("UPDATE tab_deble SET sele_rest = sele_rest + @amountDiff WHERE order_id = @orderId", dal.con, transaction);
                        cmdDebt.Parameters.AddWithValue("@amountDiff", amountDifference);
                        cmdDebt.Parameters.AddWithValue("@orderId", id_order);
                        cmdDebt.ExecuteNonQuery();

                        // اعتماد التعديلات بالكامل
                        transaction.Commit();
                        dal.Close();

                        MessageBox.Show("تم تعديل الصنف، وتحديث كميات المخزن، وضبط حسابات الدين بنجاح", "نجاح");
                        getdata(id_order.ToString());
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // تراجع شامل في حال الفشل
                        MessageBox.Show("فشل التعديل، تم حماية البيانات من التضارب: " + ex.Message);
                    }
                }
                catch (Exception ex) { MessageBox.Show("خطأ في الاتصال: " + ex.Message); }
                finally { dal.Close(); }
            }

        }
    }
}
