using CrystalDecisions.CrystalReports.Engine;
using Microsoft.Reporting.WinForms;
using storemedicals.allform.REPORTITEM;
using storemedicals.allform.sales.report_saler;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace storemedicals.allform.sales
{
    public partial class sals_defe : Form
    {
        Data.DataAccesLayer dal = new Data.DataAccesLayer();

        // متغير لتخزين رقم الفاتورة المحددة، القيمة 0 تعني لم يتم اختيار فاتورة
        int selectedOrderID = 0;

        public sals_defe()
        {
            InitializeComponent();
            tex_bank.Enabled = false;
            tex_cha.Enabled = false;
            tex_cha.Text = "0";
            tex_bank.Text = "0";
            textBo_nunmbok.Text = "0";
            settle_accounts.Text = "0";


        }

        private void FormatSalesGrid()
        {
            // 1. جعل الأعمدة تمتد تلقائياً لتملأ كامل عرض الشاشة وتختفي المساحات البيضاء
            dgvitem_sal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 2. تكبير خط الخلايا والنصوص داخل الجدول (حجم 11 ولون خط واضح جداً)
            dgvitem_sal.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // 3. تكبير خط عناوين الأعمدة (العناوين الرئيسية في الأعلى لسهولة القراءة)
            dgvitem_sal.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // 4. ضبط محاذاة النصوص لتكون في المنتصف تماماً (شكل هندسي متناسق)
            dgvitem_sal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvitem_sal.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 5. تفعيل التفاف النص وزيادة الارتفاعات لاستيعاب البيانات الطويلة (أرقام الهاتف، الأسماء الكبيرة)
            dgvitem_sal.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvitem_sal.RowTemplate.Height = 38;
            dgvitem_sal.ColumnHeadersHeight = 42;

            // 6. لمسة فنية للألوان (تبديل ألوان الصفوف لتسهيل تتبع الأسطر بالعين)
            dgvitem_sal.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250); // صف رمادي خفيف جداً
            dgvitem_sal.RowsDefaultCellStyle.BackColor = Color.White; // صف أبيض

            // 7. تحسين مظهر الصف المحدد عند الضغط عليه (أزرق هادئ مع خط أبيض واضح)
            dgvitem_sal.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dgvitem_sal.DefaultCellStyle.SelectionForeColor = Color.White;

            // 8. تحديث أوتوماتيكي لأحجام الصفوف بناءً على المحتوى الجديد
            dgvitem_sal.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }

        public void refreshdata()

        {

            try
            {
                

                SqlCommand cmd = new SqlCommand("SELECT id, name_cust , id_cus  , order_id ,sele_rest , dat from tab_deble WHERE sele_rest > 0 and id_cus = '" + Convert.ToInt32(txt_cust_id.Text) + "'  ORDER BY order_id ASC ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem_sal.DataSource = tbl;

                FormatSalesGrid();

                dal.Close();

                totalSumdgv();

                getdata_sele_rest_paidl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void test(){

            int i = 65;
            char c = Convert.ToChar(i);
            textBo_pr_voi.Text = Convert.ToString(c);

            }

        private void getdata_sele_rest_paidl()
        {
            try
            {

                SqlCommand cmd2 = new SqlCommand("SELECT sele_rest_paid from tab_deble_paid WHERE p_id_cus = '"+ txt_cust_id.Text+ "' ", dal.con);

                dal.open();
                DataTable tbi = null;

                tbi = new DataTable();

                tbi.Load(cmd2.ExecuteReader());



                if (tbi.Rows.Count != 0)
                {
                    object sumOb;
                    sumOb = tbi.Compute("Sum(sele_rest_paid)", string.Empty);

                    txt_sele_rest_paid.Text = Convert.ToString(sumOb);

                }
                else
                {
                    txt_sele_rest_paid.Text = "0";
                }

                dal.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void totalSumdgv()
        {
            try
            {
                if (dgvitem_sal.Rows.Count < 1)
                {
                    txt_cust_company.Text = "0";
                }
                else
                {

                    txt_cust_company.Text = (from DataGridViewRow row in dgvitem_sal.Rows
                                      where row.Cells[5].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();

                    string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", Convert.ToInt64(txt_cust_company.Text));
                    txt_cust_company.Text = formatted;

                }

            }
            catch { return; }

        }

    

        private void getdat()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT id, name_cust , id_cus  , order_id ,sele_rest , dat from tab_deble WHERE sele_rest > 0 and id_cus = '" + Convert.ToInt32(txt_cust_id.Text) + "'  ORDER BY order_id ASC ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem_sal.DataSource = tbl;

                dal.Close();

                totalSumdgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("tab_deble   " + ex.Message);
            }
        }

        private void getdat__paid()
        {
            try
            {
                //dat BETWEEN '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'

                SqlCommand cmd = new SqlCommand("SELECT id, p_name_cust , p_id_cus  , p_order_id ,sele_rest_paid ,cash ,bank , settle_accounts ,  num_bok , p_dat from tab_deble_paid WHERE p_dat = '" + date_sal.Value.ToString("yyyy-MM-dd") + "'  and p_id_cus = '" + Convert.ToInt32(txt_cust_id.Text) + "'  ORDER BY p_order_id ASC ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dataGridView1.DataSource = tbl;

                dal.Close();

                //totalSumdgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.Message);
            }
        }


        private void sals_defe_Load(object sender, EventArgs e)
        {
            // التأكد من عدم تكرار إضافة العمود إذا تم استدعاء الدالة مجدداً
            if (!dgvitem_sal.Columns.Contains("btn_show_invoice"))
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "btn_show_invoice";
                btnColumn.HeaderText = "عرض الفاتورة";
                btnColumn.Text = "عرض الفاتورة";
                btnColumn.UseColumnTextForButtonValue = true; // لإظهار النص على الزر في كل الصفوف
                btnColumn.Width = 100;

                // إضافة العمود إلى نهاية الجدول
                dgvitem_sal.Columns.Add(btnColumn);
            }
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
              
            }
            catch { return; }
        }

        private void txt_cust_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("SELECT id, name_cust , id_cus  , order_id ,sele_rest , dat from tab_deble WHERE sele_rest > 0 and id_cus = '" +Convert.ToInt32( txt_cust_id.Text) +"'  ORDER BY order_id ASC ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem_sal.DataSource = tbl;

                FormatSalesGrid();

                dal.Close();

                totalSumdgv();

                getdata_sele_rest_paidl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     

        private void btn_save_Click(object sender, EventArgs e)
        {
            // 1. استخراج القيم من الواجهة وتحويلها إلى أرقام
            double cash = string.IsNullOrEmpty(tex_cha.Text) ? 0 : Convert.ToDouble(tex_cha.Text);
            double bank = string.IsNullOrEmpty(tex_bank.Text) ? 0 : Convert.ToDouble(tex_bank.Text);
            double settlement = string.IsNullOrEmpty(settle_accounts.Text) ? 0 : Convert.ToDouble(settle_accounts.Text);

            double totalAmount = cash + bank + settlement;

            // التحقق من صحة المبلغ المدفوع مقارنة بالمطلوب
            if (totalAmount <= 0)
            {
                MessageBox.Show("يرجى إدخال مبلغ السداد أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToDouble(textBo_pr_voi.Text) > Convert.ToDouble(txt_cust_company.Text))
            {
                MessageBox.Show("يجب أن يساوي تماماً المبلغ المحدد في خانة الإجمالي", "عدم تطابق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // التأكد أن إجمالي المدفوع يساوي القيمة المحددة في خانة الإجمالي (لمنع الخطأ البشري)
            // double requiredAmount = string.IsNullOrEmpty(textBo_pr_voi.Text) ? 0 : Convert.ToDouble(textBo_pr_voi.Text);
            // double requiredAmount = string.IsNullOrEmpty(textBo_pr_voi.Text) ? 0 : Convert.ToDouble(textBo_pr_voi.Text);


            double requiredAmount = string.IsNullOrEmpty(textBo_pr_voi.Text) ? 0 : Convert.ToDouble(textBo_pr_voi.Text);
            if (Math.Abs(totalAmount - requiredAmount) > 0.01)
            {
                MessageBox.Show("مجموع (كاش + بنك + تسوية) لا يساوي إجمالي مبلغ السداد المحدد", "خطأ في الحساب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            if (dgvitem_sal.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد فواتير مستحقة للتوزيع عليها", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        


            try
            {
                dal.open();
                // بدء المعاملة المالية لحماية البيانات من الانهيار (Crash Protection)
                SqlTransaction trans = dal.con.BeginTransaction();

                double remCash = cash;        // الرصيد المتاح من الكاش (الأولوية الأولى)
                double remBank = bank;        // الرصيد المتاح من البنك (الأولوية الثانية)
                double remSettle = settlement; // الرصيد المتاح من التسوية (الأولوية الثالثة)

                try
                {
                    foreach (DataGridViewRow row in dgvitem_sal.Rows)
                    {
                        // استخراج رقم الفاتورة الحالية في الحلقة
                        int currentOrderID = Convert.ToInt32(row.Cells["order_id"].Value);

                        // --- التعديل المطلوب: التحقق إذا كان هناك سداد محدد لفاتورة معينة ---
                        // إذا كان المستخدم قد اختار فاتورة (selectedOrderID لا يساوي 0) 
                        // وكانت هذه الفاتورة ليست هي المطلوبة، نتخطاها وننتقل للتالية
                        if (selectedOrderID != 0 && currentOrderID != selectedOrderID)
                        {
                            continue;
                        }
                        // -----------------------------------------------------------

                        // إذا انتهى المبلغ المدفوع بالكامل، نخرج من الحلقة فوراً
                        if (remCash <= 0 && remBank <= 0 && remSettle <= 0) break;

                        double currentInvoiceDebt = Convert.ToDouble(row.Cells["sele_rest"].Value);

                        if (currentInvoiceDebt <= 0) continue;

                        // تحديد كم سيتم خصمه من هذه الفاتورة (لا يتجاوز دينها ولا يتجاوز المتبقي من المحفظة)
                        double maxCanPayForThis = Math.Min(currentInvoiceDebt, (remCash + remBank + remSettle));

                        // توزيع المبلغ على المصادر حسب الأولوية
                        double pCash = Math.Min(remCash, maxCanPayForThis);
                        double pBank = Math.Min(remBank, maxCanPayForThis - pCash);
                        double pSettle = Math.Min(remSettle, maxCanPayForThis - pCash - pBank);

                        double totalPaidForThisInv = pCash + pBank + pSettle;

                        if (totalPaidForThisInv > 0)
                        {
                            // أ- تحديث جدول الديون (خصم الجزء المدفوع فقط)
                            string updateSql = "UPDATE tab_deble SET sele_rest = sele_rest - @paid WHERE order_id = @id";
                            using (SqlCommand cmdUp = new SqlCommand(updateSql, dal.con, trans))
                            {
                                cmdUp.Parameters.AddWithValue("@paid", totalPaidForThisInv);
                                cmdUp.Parameters.AddWithValue("@id", currentOrderID);
                                cmdUp.ExecuteNonQuery();
                            }

                            // ب- تسجيل تفاصيل السداد في الجدول (حل مشكلة العميل 48)
                            string insertSql = @"INSERT INTO tab_deble_paid         (p_name_cust, p_id_cus, p_order_id, sele_rest_paid, cash, bank, settle_accounts, num_bok, p_dat)         VALUES (@name, @cusID, @orderID, @totalPaid, @c, @b, @s, @note, @date)";

                            using (SqlCommand cmdIn = new SqlCommand(insertSql, dal.con, trans))
                            {
                                cmdIn.Parameters.AddWithValue("@name", textBo_name_cus.Text);
                                cmdIn.Parameters.AddWithValue("@cusID", txt_cust_id.Text);
                                cmdIn.Parameters.AddWithValue("@orderID", currentOrderID);
                                cmdIn.Parameters.AddWithValue("@totalPaid", totalPaidForThisInv);
                                cmdIn.Parameters.AddWithValue("@c", pCash);
                                cmdIn.Parameters.AddWithValue("@b", pBank);
                                cmdIn.Parameters.AddWithValue("@s", pSettle);
                                // استخدام Parameters يحل مشكلة الرموز والانهيار في الملحوظات
                                cmdIn.Parameters.AddWithValue("@note", textBo_nunmbok.Text);
                                cmdIn.Parameters.AddWithValue("@date", date_sal.Value.ToString("yyyy-MM-dd"));
                                cmdIn.ExecuteNonQuery();
                            }
                        }

                        // تحديث المحفظة المتبقية بعد الخصم من هذه الفاتورة
                        remCash -= pCash;
                        remBank -= pBank;
                        remSettle -= pSettle;
                    }

                    trans.Commit(); // اعتماد جميع العمليات فقط في حال نجاح الحلقة بالكامل

                    // إعادة تصفير المتغير ليعود النظام للوضع التلقائي بعد النجاح
                    selectedOrderID = 0;

                    MessageBox.Show($"تم توزيع مبلغ {totalAmount} بنجاح وتحديث السجلات", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    trans.Rollback(); // التراجع عن كل شيء في حال حدوث أي خطأ (حماية الديون)
                    throw ex;
                }

                // تحديث الشاشة
                getdat();
                getdat__paid();
                ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الحفظ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dal.Close();
            }



        }

        // دالة إضافية لتنظيف الخانات بعد الحفظ
        private void ClearControls()
        {
            tex_cha.Text = "0";
            tex_bank.Text = "0";
            settle_accounts.Text = "0";
            textBo_nunmbok.Text = "0";
            textBo_vio.Text = "0";
            textBo_pr_voi.Text = "0";
            tex_bank.Enabled = false;
            tex_cha.Enabled = false;
            checkBox_bank.Checked = false;
            checkBox_cah.Checked = false;
            selectedOrderID = 0;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                SqlCommand cmd = new SqlCommand("select name_cust , sum(sele_rest) as 'sum' from tab_deble group by id_cus , name_cust order by id_cus ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                Form_Reoprt_tab_deble_ALL fr = new Form_Reoprt_tab_deble_ALL();
                // FormRep_PR frm = new FormRep_PR();

                ReportDataSource rds = new ReportDataSource("DataSet1", tbl);
                fr.reportViewer1.LocalReport.DataSources.Clear();
                fr.reportViewer1.LocalReport.DataSources.Add(rds);
                fr.reportViewer1.LocalReport.Refresh();

                fr.ShowDialog();

                dal.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT  name_cust , order_id ,sele_rest , dat from tab_deble WHERE sele_rest > 0 and id_cus = '" + Convert.ToInt32(txt_cust_id.Text) + "'  ORDER BY order_id ASC ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

              //  dal.Close();

                Form_tabbb_deble fr = new Form_tabbb_deble();

                ReportDataSource rds = new ReportDataSource("DataSet1", tbl);
                fr.reportViewer1.LocalReport.DataSources.Clear();
                fr.reportViewer1.LocalReport.DataSources.Add(rds);
                fr.reportViewer1.LocalReport.Refresh();

                fr.ShowDialog();

                dal.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_cust_id.Text == string.Empty)
            {
                MessageBox.Show("خطاء يجب تحديد العميل  ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_add_cust.Focus();
                btn_add_cust.Select();
                return;
            }
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT o.ored_id , o.ored_date , o.user_add ,f.order_id , f.ITEM_NAME_AR , f.ITEM_COUNT , f.ITEM_PRIC , f.Amount ,t.name_cust , t.order_id , t.sele_rest , t.dat  from itemorder o JOIN itemOrderDeail f on o.ored_id = f.order_id JOIN tab_deble t on f.order_id = t.order_id where  t.sele_rest > 0 and t.id_cus = '" + Convert.ToInt32(txt_cust_id.Text) +"' ORDER BY o.ored_date ASC ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                //  dal.Close();

                Form_ACC fr = new Form_ACC();

                ReportDataSource rds = new ReportDataSource("DataSet1", tbl);
                ReportParameterCollection rpc = new ReportParameterCollection();

                fr.reportViewer1.LocalReport.DataSources.Clear();
                fr.reportViewer1.LocalReport.DataSources.Add(rds);
                rpc.Add(new ReportParameter("ReportParameter_pp", txt_sele_rest_paid.Text));
                rpc.Add(new ReportParameter("ReportParameter_rest", txt_cust_company.Text));
                fr.reportViewer1.LocalReport.SetParameters(rpc);
                fr.reportViewer1.LocalReport.Refresh();

                fr.ShowDialog();

                dal.Close();

             


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          


            try
            {
                // 1. إعداد وتنفيذ أمر SQL لجلب البيانات
                SqlCommand cmd2 = new SqlCommand("select p_order_id , cash , bank , settle_accounts , num_bok , " +
                "sele_rest_paid , p_dat from tab_deble_paid where p_id_cus = '" + Convert.ToInt32(txt_cust_id.Text) + "' and p_dat BETWEEN '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' ORDER BY p_order_id DESC ", dal.con);

                dal.open();
                DataTable tbl2 = new DataTable();
                tbl2.Load(cmd2.ExecuteReader());
                dal.Close();

                // 2. إنشاء كائن تقرير Crystal Report وتعيين مصدر البيانات
                ReportDocument crystalReport = new CrystalReport_test();

                // تأكد من تحديث المسار/الاسم لملف .rpt الفعلي
               // crystalReport.Load("C:\\Users\\HP\\Desktop\\storemedicals\\storemedicals\\allform\\REPORTITEM\\CrystalReport_test.rpt");

                // تعيين مصدر البيانات (الـ DataTable) للتقرير
                crystalReport.SetDataSource(tbl2);

                // 3. تعيين قيم المعلمات (Parameters)

                // المعلمة 1: اسم العميل
            //    crystalReport.SetParameterValue("ReportParameter_name_cus", txt_cust_name.Text);

                // المعلمة 2: تاريخ البدء
              //  crystalReport.SetParameterValue("ReportParameterb_DAT", dateTimePicker_s.Value.ToString("yyyy-MM-dd"));

                // المعلمة 3: تاريخ الانتهاء
                //crystalReport.SetParameterValue("ReportParameter_En_date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                // 4. عرض التقرير في نموذج العارض
                Form_CrystalReport fr = new Form_CrystalReport();

                // افترض أن اسم الـ CrystalReportViewer في FormRepPBetwen هو crystalReportViewer1
                fr.crystalReportViewer1.ReportSource = crystalReport;
                fr.ShowDialog();
            }
            catch (Exception ex)
            {
                // التعامل مع الأخطاء
                MessageBox.Show("حدث خطأ: " + ex.Message);
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txt_cust_id.Text == string.Empty)
            {
                MessageBox.Show("خطاء يجب تحديد العميل  ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_add_cust.Focus();
                btn_add_cust.Select();
                return;
            }

            try
            {

                SqlCommand cmd = new SqlCommand("SELECT o.ored_id , o.ored_date , o.cust_id ,f.ITEM_NAME_AR , f.ITEM_COUNT , f.ITEM_PRIC , f.Amount ,t.sele_rest from itemorder o JOIN itemOrderDeail f on o.ored_id = f.order_id JOIN tab_deble t  on o.ored_id = t.order_id where o.cust_id = '" + txt_cust_id.Text+ "' AND  t.sele_rest >= 0 ORDER BY o.ored_id ASC", dal.con);
                SqlCommand cmd2 = new SqlCommand("select p_order_id , cash , bank , settle_accounts , num_bok , " +
                "sele_rest_paid , p_dat from tab_deble_paid where p_id_cus = '"+ Convert.ToInt32(txt_cust_id.Text) + "' ORDER BY p_order_id ASC ", dal.con);
                dal.open();
                DataTable tbl , tbl2 = null;
                tbl = new DataTable();
                tbl2 = new DataTable();
                tbl.Load(cmd.ExecuteReader());
                 tbl2.Load(cmd2.ExecuteReader());

             

                Form1_T fr = new Form1_T();

                  ReportDataSource rds = new ReportDataSource("DataSet1", tbl);
                ReportDataSource rds2 = new ReportDataSource("DataSet2", tbl2);
                ReportParameterCollection rpc = new ReportParameterCollection();

                fr.reportViewer1.LocalReport.DataSources.Clear();
                   fr.reportViewer1.LocalReport.DataSources.Add(rds);
                fr.reportViewer1.LocalReport.DataSources.Add(rds2);

                rpc.Add(new ReportParameter("ReportParameter_name_cus", txt_cust_name.Text));
                rpc.Add(new ReportParameter("ReportParameter_total", txt_cust_company.Text));
                fr.reportViewer1.LocalReport.SetParameters(rpc);
                fr.reportViewer1.LocalReport.Refresh();

                   fr.ShowDialog();

                dal.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("iiiiiiii"+"\n"+ex.Message);
            }
        }

        private void checkBox_cah_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox_cah.Checked == true)
            {
                if (textBo_pr_voi.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("خطاء يجب تحدد قيمة الفاتوره");
                    checkBox_cah.Checked = false;
                }
                else
                {
                  
                    tex_cha.Text = textBo_pr_voi.Text;
                    tex_cha.Enabled = true;
                }
            }
        }

        private void checkBox_bank_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox_bank.Checked == true)
            {
                if (textBo_pr_voi.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("خطاء يجب تحدد قيمة الفاتوره");
                    checkBox_bank.Checked = false;
                }
                else
                {

                    tex_bank.Text = textBo_pr_voi.Text;
                    tex_bank.Enabled = true;
                }
            }
        }

        private void checkBox_cah_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cah.Checked == false)
            {
                checkBox_cah.Checked = false;
                tex_cha.Enabled = false;
                tex_cha.Text = "0";
               
            }
        }

        private void checkBox_bank_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_bank.Checked == false)
            {
                checkBox_bank.Checked = false;
                tex_bank.Enabled = false;
                tex_bank.Text = "0";
               
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (txt_cust_id.Text == string.Empty)
            {
                MessageBox.Show("خطاء يجب تحديد العميل  ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_add_cust.Focus();
                btn_add_cust.Select();
                return;
            }


            //  التعديل في الاستعلام: تحويل JOIN إلى LEFT JOIN واستخدام ISNULL لمنع اختفاء السجلات التي ليس لها سداد() 
            try
            {
                
                string sqlQuery = @"SELECT DISTINCT 
                            T1.ored_date, 
                            T1.ored_id, 
                            T2.ITEM_NAME_AR, 
                            T2.ITEM_COUNT, 
                            T2.ITEM_PRIC, 
                            T2.Amount, 
                            T.sele_rest, 
                            ISNULL(T3.sele_rest_paid, 0) AS sele_rest_paid, 
                            ISNULL(T3.cash, 0) AS cash, 
                            ISNULL(T3.bank, 0) AS bank, 
                            ISNULL(T3.settle_accounts, 0) AS settle_accounts, 
                            T3.num_bok, 
                            T3.p_dat 
                        FROM itemorder T1 
                        JOIN itemOrderDeail T2 ON T1.ored_id = T2.order_id 
                        JOIN tab_deble T ON T1.ored_id = T.order_id
                        LEFT JOIN (
                            -- تجميع السداد لمنع تكرار الأصناف
                            SELECT p_order_id, MAX(p_dat) as p_dat, SUM(cash) as cash, SUM(bank) as bank, 
                                   SUM(settle_accounts) as settle_accounts, MAX(num_bok) as num_bok, 
                                   MAX(sele_rest_paid) as sele_rest_paid, p_id_cus
                            FROM tab_deble_paid 
                            GROUP BY p_order_id, p_id_cus
                        ) T3 ON T1.ored_id = T3.p_order_id 
                        WHERE T.sele_rest >= 0 
                        AND T1.ored_date BETWEEN '" + dateTimePicker_s.Value.ToString("yyyy-MM-dd") + @"' 
                        AND '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + @"'  
                        AND T1.cust_id = '" + Convert.ToInt32(txt_cust_id.Text) + @"'  
                        ORDER BY T1.ored_id ASC";

                SqlCommand cmd2 = new SqlCommand(sqlQuery, dal.con);

                dal.open();
                DataTable tbl2 = new DataTable();
                tbl2.Load(cmd2.ExecuteReader());

                FormCustomerDetailedReport fr = new FormCustomerDetailedReport();

                ReportDataSource rds2 = new ReportDataSource("DataSet1", tbl2);
                ReportParameterCollection rpc = new ReportParameterCollection();

                fr.reportViewer1.LocalReport.DataSources.Clear();
                fr.reportViewer1.LocalReport.DataSources.Add(rds2);

                rpc.Add(new ReportParameter("ReportParameter_cu_name", txt_cust_name.Text));
                //[@ReportParameter_sal_ser]
                rpc.Add(new ReportParameter("ReportParameter_sal_ser", txt_cust_company.Text));
                rpc.Add(new ReportParameter("ReportParameterdat_from", dateTimePicker_s.Value.ToString("yyyy-MM-dd")));
                rpc.Add(new ReportParameter("ReportParameter_dat_to", dateTimePicker1.Value.ToString("yyyy-MM-dd")));

                fr.reportViewer1.LocalReport.SetParameters(rpc);
                fr.reportViewer1.LocalReport.Refresh();

                fr.ShowDialog();
                dal.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          


        }

        private void settle_accounts_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox textBox = (TextBox)sender;

            // السماح بالأرقام، والنقطة، ومفاتيح التحكم
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // السماح بنقطة واحدة فقط
            if (e.KeyChar == '.' && settle_accounts.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void tex_bank_KeyPress(object sender, KeyPressEventArgs e)
        {
         //   TextBox textBox = (TextBox)sender;

            // السماح بالأرقام، والنقطة، ومفاتيح التحكم
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // السماح بنقطة واحدة فقط
            if (e.KeyChar == '.' && tex_bank.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void tex_cha_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox textBox = (TextBox)sender;

            // السماح بالأرقام، والنقطة، ومفاتيح التحكم
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // السماح بنقطة واحدة فقط
            if (e.KeyChar == '.' && tex_cha.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void textBo_pr_voi_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  TextBox textBox = (TextBox)sender;

            // السماح بالأرقام، والنقطة، ومفاتيح التحكم
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // السماح بنقطة واحدة فقط
            if (e.KeyChar == '.' && textBo_pr_voi.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void dgvitem_sal_MouseClick(object sender, MouseEventArgs e)
        {

            if (dgvitem_sal.Rows.Count > 0)
            {
                // معرفة تفاصيل نقطة النقر عبر الإحداثيات X و Y لـ الماوس
                var hit = dgvitem_sal.HitTest(e.X, e.Y);

                // إذا كانت النقرة على خلايا الجدول (وليس العناوين)
                if (hit.RowIndex >= 0 && hit.ColumnIndex >= 0)
                {
                    // الحماية: إذا كان العمود الذي تم النقر عليه هو عمود الزر، اخرج فوراً لمنع التعارض
                    if (dgvitem_sal.Columns[hit.ColumnIndex].Name == "btn_show_invoice")
                    {
                        return;
                    }

                    // الكود الحالي الخاص بك للسداد الموجه (يتم تنفيذه فقط عند النقر على باقي الخلايا)
                    selectedOrderID = Convert.ToInt32(dgvitem_sal.Rows[hit.RowIndex].Cells["order_id"].Value);

                    // تلوين الصف المختار بالأخضر وإرجاع الباقي للأبيض
                    foreach (DataGridViewRow row in dgvitem_sal.Rows)
                        row.DefaultCellStyle.BackColor = Color.White;

                    dgvitem_sal.Rows[hit.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;

                    MessageBox.Show("تم تحديد الفاتورة رقم: " + selectedOrderID + " للسداد الموجه", "تنبيه");
                }
            }

        }

        private void dgvitem_sal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            // التأكد من أن النقر تم على صف صالح وعلى عمود الزر تحديداً
            if (e.RowIndex >= 0 && dgvitem_sal.Columns[e.ColumnIndex].Name == "btn_show_invoice")
            {
                Frm_sals_defe_controol fr = new Frm_sals_defe_controol();
                // جلب رقم الفاتورة من الصف الذي تم الضغط على زرّه
                int invoiceIDToView = Convert.ToInt32(dgvitem_sal.Rows[e.RowIndex].Cells["order_id"].Value);

                // هنا يمكنك كتابة كود فتح تقرير الفاتورة أو شاشتك الخاصة
                // كمثال للاختبار حالياً:

                fr.id_order = invoiceIDToView;

                fr.ShowDialog();

                refreshdata();


            }



        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
