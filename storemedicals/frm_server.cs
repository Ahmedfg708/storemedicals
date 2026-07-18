using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
//using Microsoft.SqlServer.Management.Smo;
//using Microsoft.SqlServer.Server;
//using Microsoft.SqlServer.Management.Smo.ServerProxyAccount;
//using Microsoft.SqlServer.Management.Common;
//using Microsoft.Win32;

namespace storemedicals
{
    public partial class frm_server : Form
    {
        


        public frm_server()
        {
            InitializeComponent();

            txt_server.Text = Properties.Settings.Default.server;
            txt_db.Text = Properties.Settings.Default.Database;
            if (Properties.Settings.Default.Mode == "SQL")
            {
                rd_serv.Checked = true;
                txt_user.Text = Properties.Settings.Default.ID;
                txt_pass.Text = Properties.Settings.Default.Password;
            }
            else 
            {
                rd_win.Checked = true;
                txt_user.Clear();
                txt_pass.Clear();
                txt_pass.ReadOnly = true;
                txt_user.ReadOnly = true;
            }
           

        }

       
        

        private void frm_server_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.server = txt_server.Text;
            Properties.Settings.Default.Database = txt_db.Text;
            Properties.Settings.Default.Mode = rd_serv.Checked == true ? "SQL" : "windows";
            Properties.Settings.Default.ID = txt_user.Text;
            Properties.Settings.Default.Password = txt_pass.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تم حفظ الاعدادات نجاح ", "حفظ الاعداد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();
        }

        private void rd_serv_CheckedChanged(object sender, EventArgs e)
        {
            txt_pass.ReadOnly = false;
            txt_user.ReadOnly = false;
        }

        private void rd_win_CheckedChanged(object sender, EventArgs e)
        {
            txt_pass.ReadOnly = true;
            txt_user.ReadOnly = true;
        }
    }
}
