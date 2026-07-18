using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace storemedicals.CLS
{
    class cls_item
    {
        Data.DataAccesLayer DAL = new Data.DataAccesLayer();
        DataTable dt = new DataTable();

        public DataTable GetMaxid()
        {
            dt = new DataTable();
            dt = DAL.SelectData("Max_item_id", null);
            return dt;

        }
       
       //======================================
        public void insert_item(int ITEM_ID, string ITEM_NAME_AR, string ITEM_BARCOD,  int ITEM_COUNT,
                                decimal ITEM_PRIC, decimal ITEM_SAL, string ITEM_DATE, string ITEM_DATE_EXPRT, string USER_ID, int CAT_ID,int stor_id)
          
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@ITEM_ID", SqlDbType.Int);
            parm[0].Value = ITEM_ID;

            parm[1] = new SqlParameter("@ITEM_NAME_AR", SqlDbType.NVarChar);
            parm[1].Value = ITEM_NAME_AR;

            parm[2] = new SqlParameter("@ITEM_BARCOD", SqlDbType.NVarChar);
            parm[2].Value = ITEM_BARCOD;

            parm[3] = new SqlParameter("@ITEM_COUNT", SqlDbType.Int);
            parm[3].Value = ITEM_COUNT;

            parm[4] = new SqlParameter("@ITEM_PRIC", SqlDbType.Decimal);
            parm[4].Value = ITEM_PRIC;

            parm[5] = new SqlParameter("@ITEM_SAL", SqlDbType.Decimal);
            parm[5].Value = ITEM_SAL;

           

            parm[6] = new SqlParameter("@ITEM_DATE", SqlDbType.NVarChar, 20);
            parm[6].Value = ITEM_DATE;

            parm[7] = new SqlParameter("@ITEM_DATE_EXPRT", SqlDbType.NVarChar, 20);
            parm[7].Value = ITEM_DATE_EXPRT;



            parm[8] = new SqlParameter("@USER_ID", SqlDbType.NVarChar, 50);
            parm[8].Value = USER_ID;

            parm[9] = new SqlParameter("@CAT_ID", SqlDbType.Int);
            parm[9].Value = CAT_ID;

            parm[10] = new SqlParameter("@STOR_ID", SqlDbType.Int);
            parm[10].Value = stor_id;

            DAL.ExecuteCommand("insert_item", parm);
            DAL.Close();
        }
      //=======================================
        public void status_Update(string stat_id,string item, int id)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@stat_id", SqlDbType.NVarChar, 50);
            parm[0].Value = stat_id;

            parm[1] = new SqlParameter("@item_name", SqlDbType.NVarChar, 50);
            parm[1].Value = item;

            parm[2] = new SqlParameter("@ID", SqlDbType.Int);
            parm[2].Value = id;

            DAL.ExecuteCommand("state_update", parm);
            DAL.Close();
        }

        //===============================
        public DataTable GetAll_item()
        {
            dt = new DataTable();
            dt = DAL.SelectData("Get_all_item", null);
            return dt;

        }
        //=========================================
        public void update_item(int ITEM_ID, string ITEM_NAME_AR, string ITEM_BARCOD, int ITEM_COUNT,
                              decimal ITEM_PRIC, decimal ITEM_SAL, string ITEM_DATE, string ITEM_DATE_EXPRT,  int CAT_ID, int stor_id)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[10];
            parm[0] = new SqlParameter("@ITEM_ID", SqlDbType.Int);
            parm[0].Value = ITEM_ID;

            parm[1] = new SqlParameter("@ITEM_NAME_AR", SqlDbType.NVarChar);
            parm[1].Value = ITEM_NAME_AR;

            parm[2] = new SqlParameter("@ITEM_BARCOD", SqlDbType.NVarChar);
            parm[2].Value = ITEM_BARCOD;

            parm[3] = new SqlParameter("@ITEM_COUNT", SqlDbType.Int);
            parm[3].Value = ITEM_COUNT;

            parm[4] = new SqlParameter("@ITEM_PRIC", SqlDbType.Decimal);
            parm[4].Value = ITEM_PRIC;

            parm[5] = new SqlParameter("@ITEM_SAL", SqlDbType.Decimal);
            parm[5].Value = ITEM_SAL;



            parm[6] = new SqlParameter("@ITEM_DATE", SqlDbType.NVarChar, 20);
            parm[6].Value = ITEM_DATE;

            parm[7] = new SqlParameter("@ITEM_DATE_EXPRT", SqlDbType.NVarChar, 20);
            parm[7].Value = ITEM_DATE_EXPRT;

            parm[8] = new SqlParameter("@CAT_ID", SqlDbType.Int);
            parm[8].Value = CAT_ID;

            parm[9] = new SqlParameter("@STOR_ID", SqlDbType.Int);
            parm[9].Value = stor_id;

            DAL.ExecuteCommand("update_item", parm);
            DAL.Close();
        }
        //=========================================
        public void delet_item(int id)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];


            parm[0] = new SqlParameter("@ITEM_ID", SqlDbType.Int);
            parm[0].Value = id;
            DAL.ExecuteCommand("delet_item", parm);
            DAL.Close();
        }
        //===========================================
        public DataTable print_All_item()
        {
            dt = new DataTable();
            dt = DAL.SelectData("print_All_item", null);
            return dt;

        }
        //=========================================
       
        public DataTable search_All_item(string id)
        {
             dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID",SqlDbType.NVarChar, 50);
            parm[0].Value = id;

            dt = DAL.SelectData("Search_all_item", parm);
            return dt;

        }
        //======================= Search_all_item ==================[Get_Barcod_item]

        public DataTable get_item_Expert(string date)
        {
            dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@dat", SqlDbType.NVarChar,50);
            parm[0].Value = date;

            dt = DAL.SelectData("get_item_Expert", parm);
            return dt;

        }
    }
}
