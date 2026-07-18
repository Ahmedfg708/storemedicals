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

namespace storemedicals.allform.item
{
    public partial class frm_item_Expert : Form
    {
        CLS.cls_item item = new CLS.cls_item();

        Data.DataAccesLayer dal = new Data.DataAccesLayer();

        public frm_item_Expert()
        {
            InitializeComponent();
        }

       

        private void frm_item_Expert_Load(object sender, EventArgs e)
        {
            fill_dgv();
            lab_cout.Text = dgv_item.Rows.Count.ToString();
        }


        private void fill_dgv()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT ITEM_NAME_AR as \"أسم الصنف\", ITEM_COUNT as \"الكمية\", ITEM_DATE_EXPRT as \"تاريخ انتهاء الصلاحة\" FROM ITEMS WHERE ITEM_DATE_EXPRT <= '"+ date_exp.Value.ToString("yyyy-MM-dd")+ "' AND ITEM_COUNT !=0", dal.con);
                dal.open();
                DataTable tbl = null;
                tbl = new DataTable();
                tbl.Load(cmd.ExecuteReader());

                dgv_item.DataSource = tbl;

                dal.Close();

                dgv_item.Columns[1].Width = 80;
              
                dgv_item.Columns[2].Width = 150;



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
            popp.ContentText = "يوجد اصناف اقترب من انتهاء الصلاحيات";
            popp.Popup();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fill_dgv();
            lab_cout.Text = dgv_item.Rows.Count.ToString();
        }

        private void lab_cout_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
