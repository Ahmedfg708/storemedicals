using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace storemedicals.CLS
{
    class cls_company
    {
        Data.DataAccesLayer DAL = new Data.DataAccesLayer();
        DataTable dt = new DataTable();

        //===============================
        public DataTable GetAll_company()
        {
            dt = new DataTable();
            dt = DAL.SelectData("company_select", null);
            return dt;

        }
        //======================================
        public DataTable GetAll_company_forSal(int id)
        {
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", SqlDbType.Int);
            parm[0].Value = id;
            dt = new DataTable();
            dt = DAL.SelectData("Get_itemcompany_forsal", parm);
            return dt;

        }
        //=======================================
        public void insert_company(int item_id, string com_name, string com_phon, string com_addres)
                             
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[4];
            parm[0] = new SqlParameter("@item_id", SqlDbType.Int);
            parm[0].Value = item_id;

            parm[1] = new SqlParameter("@com_name", SqlDbType.NVarChar,50);
            parm[1].Value = com_name;

            parm[2] = new SqlParameter("@com_phon", SqlDbType.NVarChar,20);
            parm[2].Value = com_phon;

            parm[3] = new SqlParameter("@com_addres", SqlDbType.NVarChar, 50);
            parm[3].Value = com_addres;


            DAL.ExecuteCommand("company_insert", parm);
            DAL.Close();
        }
        //=========================================
        public void update_company(int item_id, string com_name, string com_phon, string com_addres)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[4];
            parm[0] = new SqlParameter("@item_id", SqlDbType.Int);
            parm[0].Value = item_id;

            parm[1] = new SqlParameter("@com_name", SqlDbType.NVarChar, 50);
            parm[1].Value = com_name;

            parm[2] = new SqlParameter("@com_phon", SqlDbType.NVarChar, 20);
            parm[2].Value = com_phon;

            parm[3] = new SqlParameter("@com_addres", SqlDbType.NVarChar, 50);
            parm[3].Value = com_addres;


            DAL.ExecuteCommand("company_update", parm);
            DAL.Close();
        }
        //=========================================
        public void delet_company(int item_id)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@item_id", SqlDbType.Int);
            parm[0].Value = item_id;


            DAL.ExecuteCommand("company_delete", parm);
            DAL.Close();
        }

        //=======================================
    }
}
