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
using Tulpep.NotificationWindow;

namespace storemedicals.allform
{
    public partial class frmlog : Form
    {
        CLS.cls_user us = new CLS.cls_user();
        Data.DataAccesLayer dal = new Data.DataAccesLayer();
        public frmlog()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("ادخل اسم المستخدم اولا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_name.Focus();
                return;
            }
            if (txt_pass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("ادخل كلمة المرور اولا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_pass.Focus();
                return;
            }
            //===================
            //if (txt_name.Text == "bakery" && txt_pass.Text == "bakery")
            //{
            //    admin_server();
            //    user_Enable_Admin();
            //}
            //==================
            try
            {
            
                DataTable dt = new DataTable();

                dt = us.cheaklog(txt_name.Text, txt_pass.Text);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][3].ToString() == "مدير")
                    {
                        MessageBox.Show("مدير");
                        Program.user_Name = dt.Rows[0]["USER_FULL_NAME"].ToString();

                        Form_W_Tim f = new Form_W_Tim();

                        SqlCommand cmd = new SqlCommand("SELECT  USER_NAME from USERES where USER_NAME = '" + txt_name.Text + "'", dal.con);
                        dal.open();

                        try
                        {
                            DataTable tbl = null;
                            tbl = new DataTable();
                            tbl.Load(cmd.ExecuteReader());

                            string u = (string)tbl.Rows[0][0];
                            storemedicals.User_name.username = u;
                       

                            dal.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("خطاء في جلب الدوام" + ex.Message);
                        }





                        user_Enable_Admin();
                        admin_server();
                        get_end_quan();
                        get_end_quan();
                        get_end_quan();
                        f.ShowDialog();
                        MessageBox.Show("الدوام " + WOTIME.WTim);

                    }
                    else if (dt.Rows[0][3].ToString() == "موظف")
                    {
                        MessageBox.Show("موظف");
                        Program.user_Name = dt.Rows[0]["USER_FULL_NAME"].ToString();

                        user_Enable_Employee();
                        get_end_quan();
                        get_end_quan();
                        get_end_quan();

                        SqlCommand cmd = new SqlCommand("SELECT w_time , USER_NAME from USERES where USER_NAME = '" + txt_name.Text + "'", dal.con);
                        dal.open();

                        try
                        {
                            DataTable tbl = null;
                            tbl = new DataTable();
                            tbl.Load(cmd.ExecuteReader());

                            string n = (string)tbl.Rows[0][0];

                            string u = (string)tbl.Rows[0][1];

                            storemedicals.WOTIME.WTim = n;
                            storemedicals.User_name.username = u;
                            MessageBox.Show("الدوام " + WOTIME.WTim + "\n" + "مرحبا " + u);

                            dal.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("خطاء في جلب الدوام" + ex.Message);
                        }

                    }



                    this.Close();
                }
                else
                {
                    MessageBox.Show("عزر اسم المستخدم اوكلمة غير صحيحة ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            //============================

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void get_end_quan()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT ITEM_COUNT FROM ITEMS WHERE ITEM_COUNT <=10", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dal.Close();

                if (tbl.Rows.Count > 0)
                {
                    Notification();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Notification()
        {
            Font f = new Font("Times New Roman", 14, FontStyle.Bold);
            PopupNotifier popp = new PopupNotifier();
            popp.Image = Properties.Resources.Info;
            popp.ContentFont = f;
            popp.TitleFont = f;

            popp.TitleText = "تبية";
            popp.ContentText = "يوجد اصناف اقترب من الانتهاء او اقل من او تساوي 10";
            popp.Popup();

        }


        public void user_Enable_Admin()
        {
            frmMain.getmain.ادارةالمجموعاتToolStripMenuItem.Enabled = true;
            frmMain.getmain.مرتجعاتالاصنافToolStripMenuItem.Enabled = true;
            frmMain.getmain.لوحةالتحكمبالعملاءToolStripMenuItem.Enabled = true;
            frmMain.getmain.لوحةالتحكمالموردينToolStripMenuItem.Enabled = true;
            frmMain.getmain.فاتورةشراءToolStripMenuItem.Enabled = true;
            frmMain.getmain.فاتورةبيعToolStripMenuItem.Enabled = true;
            frmMain.getmain.شاشةالمجموعاتToolStripMenuItem.Enabled = true;
            frmMain.getmain.شاشةاضافةعميلToolStripMenuItem.Enabled = true;
            frmMain.getmain.شاشةادارةفواتيرالشراToolStripMenuItem.Enabled = true;
            frmMain.getmain.شاشةادارةفواتيرالبيعToolStripMenuItem.Enabled = true;
            frmMain.getmain.حركةالبيعوالشراءToolStripMenuItem.Enabled = true;
            frmMain.getmain.حذفبياناتالشركةللصنفToolStripMenuItem.Enabled = true;
            frmMain.getmain.المستخدمينToolStripMenuItem.Enabled = true;
            frmMain.getmain.العملاءToolStripMenuItem.Enabled = true;
            frmMain.getmain.البيعToolStripMenuItem.Enabled = true;
            
            frmMain.getmain.اعداداتالنظامToolStripMenuItem.Enabled = true;
            frmMain.getmain.اضافةموردجديدToolStripMenuItem.Enabled = true;
            frmMain.getmain.اضافةمخزنجديدToolStripMenuItem.Enabled = true;
            frmMain.getmain.اضافةصنفجديدToolStripMenuItem.Enabled = true;
            frmMain.getmain.استعادةالنسخةالاحتياطيةToolStripMenuItem.Enabled = true;
            frmMain.getmain.ادارةالموردينToolStripMenuItem.Enabled = true;
            frmMain.getmain.ادارةالمستخدمينToolStripMenuItem1.Enabled = true;
            frmMain.getmain.ادارةالمستخدمينToolStripMenuItem.Enabled = true;
            frmMain.getmain.ادارةالمخزنوالتحكمToolStripMenuItem.Enabled = true;
            frmMain.getmain.ادارةالمخزنToolStripMenuItem.Enabled = true;
            frmMain.getmain.ادارةالمجموعاتToolStripMenuItem.Enabled = true;
            frmMain.getmain.ادارةالفاتورةToolStripMenuItem.Enabled = true;
            frmMain.getmain.ادارةالتحكمبالمرتجعاتToolStripMenuItem.Enabled = true;
            frmMain.getmain.ادارةالتحكمبالاصنافToolStripMenuItem.Enabled = true;
            frmMain.getmain.اخذنسخةاحتياطيةToolStripMenuItem.Enabled = true;
            frmMain.getmain.اعداداتالسيرفرToolStripMenuItem.Enabled = true;
            frmMain.getmain.حركةالبيعToolStripMenuItem.Enabled = true;
            frmMain.getmain.حركةبيعمحددToolStripMenuItem.Enabled = true;

            frmMain.getmain.السجلاتToolStripMenuItem.Enabled = true;
            frmMain.getmain.اضافةسجلجديدToolStripMenuItem.Enabled = true;
            frmMain.getmain.لوحةالتحكمفيالسجلاتToolStripMenuItem.Enabled = true;

            frmMain.getmain.الاصنافالاعليمبيعToolStripMenuItem.Enabled = true;

            frmMain.getmain.تصحيحToolStripMenuItem.Enabled = true;
            frmMain.getmain.الاجماليToolStripMenuItem.Enabled = true;

            frmMain.getmain.لوحةالتحكممالجةالاخطاءToolStripMenuItem.Enabled = true;



        }

        //==============================
        public void user_Enable_Employee()
        {
            frmMain.getmain.ادارةالمجموعاتToolStripMenuItem.Enabled = true;
            frmMain.getmain.مرتجعاتالاصنافToolStripMenuItem.Enabled = true;
            frmMain.getmain.لوحةالتحكمبالعملاءToolStripMenuItem.Enabled = true;
            frmMain.getmain.لوحةالتحكمالموردينToolStripMenuItem.Enabled = true;

            frmMain.getmain.فاتورةشراءToolStripMenuItem.Enabled = true;
            frmMain.getmain.فاتورةبيعToolStripMenuItem.Enabled = true;

            frmMain.getmain.شاشةالمجموعاتToolStripMenuItem.Enabled = true;
            frmMain.getmain.شاشةاضافةعميلToolStripMenuItem.Enabled = true;

            frmMain.getmain.شاشةادارةفواتيرالشراToolStripMenuItem.Enabled = false;
            frmMain.getmain.شاشةادارةفواتيرالبيعToolStripMenuItem.Enabled = false;
            frmMain.getmain.حركةالبيعوالشراءToolStripMenuItem.Enabled = false;
            frmMain.getmain.حذفبياناتالشركةللصنفToolStripMenuItem.Enabled = true;

            frmMain.getmain.المستخدمينToolStripMenuItem.Enabled = false;
            frmMain.getmain.العملاءToolStripMenuItem.Enabled = true;
            frmMain.getmain.البيعToolStripMenuItem.Enabled = true;
           
            frmMain.getmain.اعداداتالنظامToolStripMenuItem.Enabled = false;

            frmMain.getmain.اضافةموردجديدToolStripMenuItem.Enabled = true;
            frmMain.getmain.اضافةمخزنجديدToolStripMenuItem.Enabled = true;
            frmMain.getmain.اضافةصنفجديدToolStripMenuItem.Enabled = true;

            frmMain.getmain.استعادةالنسخةالاحتياطيةToolStripMenuItem.Enabled = false;
            frmMain.getmain.ادارةالموردينToolStripMenuItem.Enabled = true;
            frmMain.getmain.ادارةالمستخدمينToolStripMenuItem1.Enabled = false;
            frmMain.getmain.ادارةالمستخدمينToolStripMenuItem.Enabled = false;
            frmMain.getmain.ادارةالمخزنوالتحكمToolStripMenuItem.Enabled = true;
            frmMain.getmain.ادارةالمخزنToolStripMenuItem.Enabled = true;
            frmMain.getmain.ادارةالمجموعاتToolStripMenuItem.Enabled = true;

            frmMain.getmain.ادارةالفاتورةToolStripMenuItem.Enabled = false;
            frmMain.getmain.ادارةالتحكمبالمرتجعاتToolStripMenuItem.Enabled = false;
            frmMain.getmain.ادارةالتحكمبالاصنافToolStripMenuItem.Enabled = true;
            frmMain.getmain.اخذنسخةاحتياطيةToolStripMenuItem.Enabled = true;

            frmMain.getmain.حركةالبيعToolStripMenuItem.Enabled = true;
            frmMain.getmain.حركةبيعمحددToolStripMenuItem.Enabled = false;

            frmMain.getmain.السجلاتToolStripMenuItem.Enabled = true;
            frmMain.getmain.اضافةسجلجديدToolStripMenuItem.Enabled = false;
            frmMain.getmain.لوحةالتحكمفيالسجلاتToolStripMenuItem.Enabled = true;

            frmMain.getmain.الاصنافالاعليمبيعToolStripMenuItem.Enabled = false;

            frmMain.getmain.تصحيحToolStripMenuItem.Enabled = false;
            frmMain.getmain.الاجماليToolStripMenuItem.Enabled = false;

        }
        //=============================
        public void admin_server() 
        {
            frmMain.getmain.اعداداتالسيرفرToolStripMenuItem.Enabled = true;
        
        }

        private void frmlog_Load(object sender, EventArgs e)
        {
            dal.open();
        }
      
    }
}
