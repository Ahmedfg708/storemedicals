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

namespace storemedicals.allform.sales
{
    public partial class Frm_end_Quantity : Form
    {

        Data.DataAccesLayer dal = new Data.DataAccesLayer();

        public Frm_end_Quantity()
        {
            InitializeComponent();
            get_end_quan();

            lab_cout.Text = dgvitem.Rows.Count.ToString();
        }

        private void get_end_quan()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT ITEM_NAME_AR as \"أسم الصنف\",ITEM_COUNT as \"الكمية\" FROM ITEMS WHERE ITEM_COUNT <=10 ORDER BY ITEM_COUNT ASC ", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgvitem.DataSource = tbl;



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
    }
}
