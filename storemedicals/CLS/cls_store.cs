using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace storemedicals.CLS
{
    class cls_store
    {

        Data.DataAccesLayer DAL = new Data.DataAccesLayer();
        DataTable dt = new DataTable();

        public DataTable GetMaxid()
        {
            dt = new DataTable();
            dt = DAL.SelectData("Max_storeid", null);
            return dt;

        }
// @STOR_ID int,
//@STOR_NAME nvarchar(50),
//@STOR_LOCATION nvarchar(90),
//@STOR_PHON nvarchar(20),
        //@USER_ID nvarchar(50)    [insert_store]

      //====================
        public void Insert_store(int STOR_ID, string STOR_NAME, string STOR_LOCATION, string STOR_PHON, string USER_ID)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[5];
            parm[0] = new SqlParameter("@STOR_ID", SqlDbType.Int);
            parm[0].Value = STOR_ID;

            parm[1] = new SqlParameter("@STOR_NAME", SqlDbType.NVarChar, 50);
            parm[1].Value = STOR_NAME;

            parm[2] = new SqlParameter("@STOR_LOCATION", SqlDbType.NVarChar, 90);
            parm[2].Value = STOR_LOCATION;

            parm[3] = new SqlParameter("@STOR_PHON", SqlDbType.NVarChar, 20);
            parm[3].Value = STOR_PHON;

            parm[4] = new SqlParameter("@USER_ID", SqlDbType.NVarChar, 50);
            parm[4].Value = USER_ID;

            DAL.ExecuteCommand("insert_store", parm);  
            DAL.Close();
        }
     //======================
        public void update_store(int STOR_ID, string STOR_NAME, string STOR_LOCATION, string STOR_PHON )
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[4];
            parm[0] = new SqlParameter("@STOR_ID", SqlDbType.Int);
            parm[0].Value = STOR_ID;

            parm[1] = new SqlParameter("@STOR_NAME", SqlDbType.NVarChar, 50);
            parm[1].Value = STOR_NAME;

            parm[2] = new SqlParameter("@STOR_LOCATION", SqlDbType.NVarChar, 90);
            parm[2].Value = STOR_LOCATION;

            parm[3] = new SqlParameter("@STOR_PHON", SqlDbType.NVarChar, 20);
            parm[3].Value = STOR_PHON;



            DAL.ExecuteCommand("update_store", parm);
            DAL.Close();
        }
    //========================
        public DataTable Get_store()
        {
            dt = new DataTable();

            dt = DAL.SelectData("select_store", null);
            return dt;

        }
        //=============================
        public void delet_store(int id)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", SqlDbType.Int);
            parm[0].Value = id;




            DAL.ExecuteCommand("delee_store", parm);
            DAL.Close();
        }
        //========================
        public DataTable GetAllstor()
        {
            dt = new DataTable();
            dt = DAL.SelectData("get_All_store", null);
            return dt;
        }
      //=============================

    }
}
