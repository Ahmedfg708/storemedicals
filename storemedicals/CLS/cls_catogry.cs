using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace storemedicals.CLS
{
    class cls_catogry
    {
        Data.DataAccesLayer DAL = new Data.DataAccesLayer();
        DataTable dt = new DataTable();

        public DataTable GetMaxid()
        {
            dt = DAL.SelectData("catogryMax_id", null);
            return dt;
        
        }
        //================================================add cat
        public void InsertCatogry(int id, string name) 
        { 
 
            DAL.open();
            SqlParameter [] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@CAT_ID",SqlDbType.Int);
            parm[0].Value = id;

            parm[1] = new SqlParameter("@CAT_NAME", SqlDbType.NVarChar,50);
            parm[1].Value = name;
            DAL.ExecuteCommand("catogry_Add", parm);
            DAL.Close();
        }

        //================================================= show data
        public DataTable GetAllcatogry() 
        {
            dt = new DataTable();
            dt = DAL.SelectData("catogry_select", null);
            return dt;
        }
        //================================================= update
        public void CategoryUpdate( string name,int id) 
        {
            
            DAL.open();
            SqlParameter[] parm = new SqlParameter[2];

            parm[0] = new SqlParameter("@CAT_NAME", SqlDbType.NVarChar, 50);
            parm[0].Value = name;

            parm[1] = new SqlParameter("@ID", SqlDbType.Int);
            parm[1].Value = id;
            DAL.ExecuteCommand("catogry_update", parm);
            DAL.Close();
        }
        //=====================================================
        public void CategoryDelete(int id)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];


            parm[0] = new SqlParameter("@Id", SqlDbType.Int);
            parm[0].Value = id;
            DAL.ExecuteCommand("catogry_delete", parm);
            DAL.Close();
        }
        //=====================================================
        public DataTable search_catogry(string seach)
        {
            dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
            parm[0].Value = seach;
            dt = DAL.SelectData("Catogery_search", parm);
            return dt;

        }
        //=========================================
    }
}
