using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace storemedicals.CLS
{
    class cls_custmer
    {
        Data.DataAccesLayer DAL = new Data.DataAccesLayer();
        DataTable dt = new DataTable();

        public DataTable GetMaxid()
        {
            dt = new DataTable();
            dt = DAL.SelectData("max_custmerid", null);
            return dt;

        }

    //====================
        public void insert_custmer(int CUST_ID, string CUST_NAME, string CUST_PHON, string CUST_ADDRES,
                             string CUST_NATIONAL, string CUST_EMAIL, string CUST_COMPANY, 
                             string CUST_DAE_add, byte[] CUST_img, string user_add, string img_state)

        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@CUST_ID", SqlDbType.Int);
            parm[0].Value = CUST_ID;

            parm[1] = new SqlParameter("@CUST_NAME", SqlDbType.NVarChar,50);
            parm[1].Value = CUST_NAME;

            parm[2] = new SqlParameter("@CUST_PHON", SqlDbType.NVarChar,20);
            parm[2].Value = CUST_PHON;

            parm[3] = new SqlParameter("@CUST_ADDRES", SqlDbType.NVarChar, 50);
            parm[3].Value = CUST_ADDRES;

            parm[4] = new SqlParameter("@CUST_NATIONAL", SqlDbType.NVarChar, 30);
            parm[4].Value = CUST_NATIONAL;

            parm[5] = new SqlParameter("@CUST_EMAIL", SqlDbType.NVarChar, 50);
            parm[5].Value = CUST_EMAIL;



            parm[6] = new SqlParameter("@CUST_COMPANY", SqlDbType.NVarChar, 50);
            parm[6].Value = CUST_COMPANY;

            parm[7] = new SqlParameter("@CUST_DAE_add", SqlDbType.NVarChar,50);
            parm[7].Value = CUST_DAE_add;



            parm[8] = new SqlParameter("@CUST_img", SqlDbType.Image);
            parm[8].Value = CUST_img;

            parm[9] = new SqlParameter("@user_add", SqlDbType.NVarChar, 50);
            parm[9].Value = user_add;

            parm[10] = new SqlParameter("@img_state", SqlDbType.NVarChar, 50);
            parm[10].Value = img_state;

            DAL.ExecuteCommand("insert_custmer", parm);
            DAL.Close();
        }
    //====================
        public DataTable GetAll_cust()
        {
            dt = new DataTable();
            dt = DAL.SelectData("select_custmer", null);
            return dt;

        }
    //===================================
        public void update_custmer(int CUST_ID, string CUST_NAME, string CUST_PHON, string CUST_ADDRES,
                         string CUST_NATIONAL, string CUST_EMAIL, string CUST_COMPANY,
                         string CUST_DAE_add, byte[] CUST_img, string user_add, string img_state)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@CUST_ID", SqlDbType.Int);
            parm[0].Value = CUST_ID;

            parm[1] = new SqlParameter("@CUST_NAME", SqlDbType.NVarChar, 50);
            parm[1].Value = CUST_NAME;

            parm[2] = new SqlParameter("@CUST_PHON", SqlDbType.NVarChar, 20);
            parm[2].Value = CUST_PHON;

            parm[3] = new SqlParameter("@CUST_ADDRES", SqlDbType.NVarChar, 50);
            parm[3].Value = CUST_ADDRES;

            parm[4] = new SqlParameter("@CUST_NATIONAL", SqlDbType.NVarChar, 30);
            parm[4].Value = CUST_NATIONAL;

            parm[5] = new SqlParameter("@CUST_EMAIL", SqlDbType.NVarChar, 50);
            parm[5].Value = CUST_EMAIL;



            parm[6] = new SqlParameter("@CUST_COMPANY", SqlDbType.NVarChar, 50);
            parm[6].Value = CUST_COMPANY;

            parm[7] = new SqlParameter("@CUST_DAE_add", SqlDbType.NVarChar,50);
            parm[7].Value = CUST_DAE_add;



            parm[8] = new SqlParameter("@CUST_img", SqlDbType.Image);
            parm[8].Value = CUST_img;

            parm[9] = new SqlParameter("@user_add", SqlDbType.NVarChar, 50);
            parm[9].Value = user_add;

            parm[10] = new SqlParameter("@img_state", SqlDbType.NVarChar, 50);
            parm[10].Value = img_state;

            DAL.ExecuteCommand("update_custmer", parm);
            DAL.Close();
        }
        //====================

        public void delete_custmer(int CUST_ID)
                      
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = CUST_ID;


            DAL.ExecuteCommand("delete_custmer", parm);
            DAL.Close();
        }
        //=========================================

        public DataTable search_All_cust(string id)
        {
            dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
            parm[0].Value = id;

            dt = DAL.SelectData("custmer_search", parm);
            return dt;

        }
        //=========================================

    }
}
