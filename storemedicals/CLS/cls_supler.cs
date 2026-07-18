using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace storemedicals.CLS
{
    class cls_supler
    {
        Data.DataAccesLayer DAL = new Data.DataAccesLayer();
        DataTable dt = new DataTable();

        public DataTable GetMaxid()
        {
            dt = DAL.SelectData("sup_maxid", null);
            return dt;

        }
        //=============================
        public DataTable search_supler(string seach)
        {
            dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@search", SqlDbType.NVarChar,50);
            parm[0].Value = seach;
            dt = DAL.SelectData("sup_search", parm);
            return dt;

        }
        //=============================

        public void Insert_Supler(int SUP_ID, string SUP_NAME, string SUP_PHON, string SUP_ADDRES, 
            string COMPANY_NAME, string COMMET, string SUP_NATIONAL_NUM,string USER_Add,string sup_date)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[9];
            parm[0] = new SqlParameter("@SUP_ID", SqlDbType.Int);
            parm[0].Value = SUP_ID;

            parm[1] = new SqlParameter("@SUP_NAME", SqlDbType.NVarChar, 50);
            parm[1].Value = SUP_NAME;

            parm[2] = new SqlParameter("@SUP_PHON", SqlDbType.NVarChar, 20);
            parm[2].Value = SUP_PHON;

            parm[3] = new SqlParameter("@SUP_ADDRES", SqlDbType.NVarChar, 80);
            parm[3].Value = SUP_ADDRES;

            parm[4] = new SqlParameter("@COMPANY_NAME", SqlDbType.NVarChar, 50);
            parm[4].Value = COMPANY_NAME;

            parm[5] = new SqlParameter("@COMMET", SqlDbType.NVarChar, 50);
            parm[5].Value = COMMET;

            parm[6] = new SqlParameter("@SUP_NATIONAL_NUM", SqlDbType.NVarChar,30);
            parm[6].Value = SUP_NATIONAL_NUM;

            parm[7] = new SqlParameter("@USER_Add", SqlDbType.NVarChar,50);
            parm[7].Value = USER_Add;

            parm[8] = new SqlParameter("@sup_date", SqlDbType.NVarChar,20);
            parm[8].Value = sup_date;

            DAL.ExecuteCommand("sup_Insert", parm);
            DAL.Close();
        }


        //===========================================sup_select
        public DataTable GetAll_Supler()
        {

            dt = DAL.SelectData("sup_select", null);
            return dt;

        }
        //=========================================
        public void Update_Supler(int id, string SUP_NAME, string SUP_PHON, string SUP_ADDRES, string COMPANY_NAME,
            string COMMET, string SUP_NATIONAL_NUM, string sup_date)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[8];

            parm[0] = new SqlParameter("@SUP_ID", SqlDbType.Int);
            parm[0].Value = id;

            parm[1] = new SqlParameter("@SUP_NAME", SqlDbType.NVarChar, 50);
            parm[1].Value = SUP_NAME;

            parm[2] = new SqlParameter("@SUP_PHON", SqlDbType.NVarChar,20);
            parm[2].Value = SUP_PHON;

            parm[3] = new SqlParameter("@SUP_ADDRES", SqlDbType.NVarChar, 80);
            parm[3].Value = SUP_ADDRES;

            parm[4] = new SqlParameter("@COMPANY_NAME", SqlDbType.NVarChar, 50);
            parm[4].Value = COMPANY_NAME;

            parm[5] = new SqlParameter("@COMMET", SqlDbType.NVarChar, 150);
            parm[5].Value = COMMET;

            parm[6] = new SqlParameter("@SUP_NATIONAL_NUM", SqlDbType.NVarChar,30);
            parm[6].Value = SUP_NATIONAL_NUM;

            parm[7] = new SqlParameter("@sup_date", SqlDbType.NVarChar,20);
            parm[7].Value = sup_date;



            DAL.ExecuteCommand("sup_update", parm);
            DAL.Close();
        }

        //============================================

        //=========================================
        public void delet_supler(int id)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;
            DAL.ExecuteCommand("sup_delete", parm);
            DAL.Close();
        }
        //===========================================


        public DataTable Get_all_fatoraShra()
        {
            dt = new DataTable();

            dt = DAL.SelectData("get_all_purches_order", null);
            return dt;

        }
        //=============================
    }
}
