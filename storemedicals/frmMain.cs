using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using storemedicals.allform;
using storemedicals.allform.purchees;
using storemedicals.allform.item;
using storemedicals.allform.sales;
using storemedicals.allform.Reten;
using storemedicals.allform.Retenitem;
using storemedicals.allform.Backup;
using System.Data.SqlClient;
using storemedicals.allform.Records;

namespace storemedicals
{
    public partial class frmMain : Form
    {
        Data.DataAccesLayer DAL = new Data.DataAccesLayer();
        string biotim = "", bioend = "";
        CLS.cls_main clsmain = new CLS.cls_main();

        private static frmMain frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        //=====================
        public static frmMain getmain
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmMain();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
         
        }
        public frmMain()
        {
            InitializeComponent();
            if (frm == null) 
            {
                frm = this;
            }

            timer1.Start();
            sumTotalForSal();

        }


        public void gettim()
        {

            try
            {

                DateTime da = DateTime.Now;

                SqlCommand cmd = new SqlCommand("SELECT  big_taem , end_tem  FROM departure where dat = '" + da.ToString("yyyy-MM-dd") + "' AND name_em = '" + User_name.username + "'  ", DAL.con);
                DAL.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                biotim = tbl.Rows[0][0].ToString();
                bioend = tbl.Rows[0][1].ToString();

                DAL.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void getUpdatendTim()
        {

            try
            {

                DateTime da = DateTime.Now;


                SqlCommand cmd = new SqlCommand("update departure set end_tem = '" + da.ToString("hh:mm:ss tt") + "' where dat = '" + da.ToString("yyyy-MM-dd") + "' AND name_em = '" + User_name.username + "' ", DAL.con);
                DAL.open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("تمة تحديث الانصراف");


                DAL.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void شاشةالمجموعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCatogry"] == null)
            {

                frmCatogry fm = new frmCatogry();
                fm.ShowDialog();
              
            }
            else
            {
                Application.OpenForms["frmCatogry"].Activate();
            }
            
        }

        private void المستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAddusers"] == null)
            {

                frmAddusers fm = new frmAddusers();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frmAddusers"].Activate();
            }
        }

        private void ادارةالمستخدمينToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmUserMannger"] == null)
            {

                frmUserMannger fm = new frmUserMannger();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frmUserMannger"].Activate();
            }
        }

        private void شاشةالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void اضافةموردجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSupplier"] == null)
            {

                frmSupplier fm = new frmSupplier();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frmSupplier"].Activate();
            }
        }

        private void لوحةالتحكمالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSuplerManger"] == null)
            {

                frmSuplerManger fm = new frmSuplerManger();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frmSuplerManger"].Activate();
            }
        }

        private void فاتورةشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frm_fatorashra"] == null)
                {

                frm_fatorashra frm = new frm_fatorashra();
                frm.ShowDialog();
                // frm_fatorashra fm = new frm_fatorashra();
                //  fm.ShowDialog();

            }
                else
                {
                    Application.OpenForms["frm_fatorashra"].Activate();
                }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void شاشةادارةفواتيرالشراToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_purch_forManger"] == null)
            {

                frm_purch_forManger fm = new frm_purch_forManger();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_fatorashra"].Activate();
            }
        }

        private void اضافةصنفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Additem"] == null)
            {

                frm_Additem fm = new frm_Additem();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_Additem"].Activate();
            }
        }

        private void اضافةمخزنجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_store"] == null)
            {

                frm_store fm = new frm_store();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_store"].Activate();
            }
        }

        private void اضافةمخزنجديدToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_store"] == null)
            {

                frm_store fm = new frm_store();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_store"].Activate();
            }
        }

        private void ادارةالمخزنوالتحكمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_mange_store"] == null)
            {

                frm_mange_store fm = new frm_mange_store();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_mange_store"].Activate();
            }
        }

        private void ادارةالتحكمبالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_manger_item"] == null)
            {

                frm_manger_item fm = new frm_manger_item();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_manger_item"].Activate();
            }
        }

        private void حذفبياناتالشركةللصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_company fm = new frm_company();
            fm.btn_add.Enabled = false;
            fm.btn_updet.Enabled = false;
            
            if (Application.OpenForms["frm_company"] == null)
            {

                

                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_company"].Activate();
            }
        }

        private void شاشةاضافةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_company"] == null)
            {
               frm_addcustmer fm = new frm_addcustmer();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_addcustmer"].Activate();
            }
        }

        private void لوحةالتحكمبالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_cust_mang"] == null)
            {
                frm_cust_mang fm = new frm_cust_mang();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_cust_mang"].Activate();
            }
        }

        private void فاتورةبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_sale"] == null)
            {
                frm_sale fm = new frm_sale();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_sale"].Activate();
            }
        }

        private void شاشةادارةفواتيرالبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_mage_sal"] == null)
            {
                frm_mage_sal fm = new frm_mage_sal();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_mage_sal"].Activate();
            }
        }

        private void مرتجعاتالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frm_reten"] == null)
            {
                frm_reten fm = new frm_reten();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_reten"].Activate();
            }
        }

        private void شاشةتسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmlog"] == null)
            {

                frmlog fm = new frmlog();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frmlog"].Activate();
            }
        }

        private void ادارةالتحكمبالمرتجعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_reten_mang"] == null)
            {

                frm_reten_mang fm = new frm_reten_mang();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_reten_mang"].Activate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lab_sal.Location = new Point(lab_sal.Location.X-5,lab_sal.Location.Y);
            if(lab_sal.Location.X <=-80)
            {
                lab_sal.Location = new Point(941, lab_sal.Location.Y);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

          // DAL.open();
          

        }
      //=================
        public void sumTotalForSal()
        {
            try
            {
                lab_sal.Text = "مبيعات اليوم : " + clsmain.sum_total_inday().Rows[0][0].ToString()+" "+"ج س";
            }
            catch { return; }
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            sumTotalForSal();
        }

        private void حركةالبيعوالشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frm_search_SalAnd_purch"] == null)
            {

                frm_search_SalAnd_purch fm = new frm_search_SalAnd_purch();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_search_SalAnd_purch"].Activate();
            }
        }

        private void اخذنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frm_backup"] == null)
            {

                frm_backup fm = new frm_backup();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_backup"].Activate();
            }
        }

        private void استعادةالنسخةالاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_RestorBackup"] == null)
            {

                frm_RestorBackup fm = new frm_RestorBackup();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_RestorBackup"].Activate();
            }
        }

        private void شاشةتسجيلالدخولToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmlog"] == null)
            {

                frmlog fm = new frmlog();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frmlog"].Activate();
            }
        }

        private void الخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* string subtotime = "";
            try
            {

                getUpdatendTim();
                gettim();


                TimeSpan span = Convert.ToDateTime(bioend) - Convert.ToDateTime(biotim);

                string totime = span.ToString();

                subtotime = totime.Substring(0, 2);

                MessageBox.Show("عدد ساعات العمل " + subtotime);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "من فضلك سجل الحضور او تسجل دخول الي النظام");
                return;
            }

            try
            {

                DateTime da = DateTime.Now;


                SqlCommand cmd = new SqlCommand("update departure set totalhoer = '" + subtotime + "' where dat = '" + da.ToString("yyyy-MM-dd") + "' AND name_em = '" + User_name.username + "' ", DAL.con);
                DAL.open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("تمة تحديث عدد ساعة العمل");


                DAL.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/


            Application.Exit();
        }

        //private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        //{

        //}
    //=====================
        //private void AttachDB()
        //{
        //    try
        //    {
        //        string path = Application.StartupPath + "\\" + "MEDICAL_STORE.mdf";
        //       // SqlConnection con = new SqlConnection(@"Server = .\SQLExpress; AttachDbFilename =" + path + "; Database = MEDICAL_STORE; Integrated Security = True;");
        //       SqlConnection con = new SqlConnection(@"Server = .\SQLExpress; AttachDbFilename =C:\Users\bakery\Desktop\بدون الاتصال بالسيرقر\storemedicals\storemedicals\bin\Debug\MEDICAL_STORE.mdf;  Database = MEDICAL_STORE; Integrated Security = True;");
        //        if (con.State != ConnectionState.Open)
        //        {
        //            con.Open();
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString()); 
                
        //    }

        //}
   //====================
        private void عنالبرنامجوالمساعدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_about"] == null)
            {

                frm_about fm = new frm_about();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_about"].Activate();
            }
        }

        private void اعداداتالسيرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sting_serverLog fm = new frm_sting_serverLog();
            fm.ShowDialog();
          
        }

        private void الاصنافمنتهيةالصلاحيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_item_Expert"] == null)
            {

                frm_item_Expert fm = new frm_item_Expert();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_item_Expert"].Activate();
            }
        }

        private void اعدادالنظامToolStripMenuItem_Click(object sender, EventArgs e)
        {


            frm_sting_serverLog fm = new frm_sting_serverLog();
            fm.ShowDialog();
        }

        private void اعداداتالنظامToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void تقريرفواتيرالشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void حركةالبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Saler_formData"] == null)
            {

               Saler_formData fm = new Saler_formData();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["Saler_formData"].Activate();
            }
        }

        private void حركةبيعمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Saler_formData2"] == null)
            {

                Saler_formData2 fm = new Saler_formData2();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["Saler_formData2"].Activate();
            }
        }

        private void اضافةسجلجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_khzena"] == null)
            {

                // frm_khzena fm = new frm_khzena();
                form_string_kazina fm = new form_string_kazina();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_khzena"].Activate();
            }
        }

        private void لوحةالتحكمفيالسجلاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_Expenses
            if (Application.OpenForms["frm_Expenses"] == null)
            {

                frm_Expenses fm = new frm_Expenses();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_Expenses"].Activate();
            }
        }

        private void الاصنافالاعليمبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_Item_Top
            if (Application.OpenForms["frm_Item_Top"] == null)
            {

                frm_Item_Top fm = new frm_Item_Top();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_Item_Top"].Activate();
            }
        }

        private void نفاذالكميةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Frm_end_Quantity"] == null)
            {

                Frm_end_Quantity fm = new Frm_end_Quantity();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["Frm_end_Quantity"].Activate();
            }
        }

        private void الاصنافاقتربةمنانتهاءالصلاحيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_item_Expert_Appro
            if (Application.OpenForms["frm_item_Expert_Appro"] == null)
            {

                frm_item_Expert_Appro fm = new frm_item_Expert_Appro();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_item_Expert_Appro"].Activate();
            }
        }

        private void تصحيحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //form_password

            if (Application.OpenForms["form_password"] == null)
            {

                form_password fm = new form_password();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["form_password"].Activate();
            }
        }

        private void الاجماليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_correction_in_saler
            if (Application.OpenForms["Form_SAL_SUM"] == null)
            {

                Form_SAL_SUM fm = new Form_SAL_SUM();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["Form_SAL_SUM"].Activate();
            }
        }

        private void معالجةالاخطاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //form_Exception
            if (Application.OpenForms["form_Exception"] == null)
            {

                form_Exception fm = new form_Exception();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["form_Exception"].Activate();
            }
        }

        private void لوحةالتحكممالجةالاخطاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //form_password
            if (Application.OpenForms["form_password"] == null)
            {

                form_password fm = new form_password();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["form_password"].Activate();
            }

        }

        private void مبيعاتصادرةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //form_export
            if (Application.OpenForms["form_export"] == null)
            {

                form_export fm = new form_export();
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["form_export"].Activate();
            }
        }

        private void طلبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form_Order_Stp

            if (Application.OpenForms["Form_Order_Stp"] == null)
            {

                Form_Order_Stp fm = new Form_Order_Stp();
              
               
                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["Form_Order_Stp"].Activate();
            }

        }

        private void أدارةالطلبمنالمخزانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //form_Mana_Order

            if (Application.OpenForms["form_Mana_Order"] == null)
            {

                form_Mana_Order fm = new form_Mana_Order();


                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["form_Mana_Order"].Activate();
            }
        }

        private void مبيعاتاجلةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sals_defe

            if (Application.OpenForms["sals_defe"] == null)
            {

                sals_defe fm = new sals_defe();


                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["sals_defe"].Activate();
            }
        }

        private void مبيعاتصنفمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_sale_of_specific_item
            if (Application.OpenForms["frm_sale_of_specific_item"] == null)
            {

                frm_sale_of_specific_item fm = new frm_sale_of_specific_item();


                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["frm_sale_of_specific_item"].Activate();
            }
        }

        private void الحضوروالانصرافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form_departure

            if (Application.OpenForms["Form_departure"] == null)
            {

                Form_departure fm = new Form_departure();


                fm.ShowDialog();

            }
            else
            {
                Application.OpenForms["Form_departure"].Activate();
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}







    }
}
