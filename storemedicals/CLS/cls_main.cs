using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace storemedicals.CLS
{
    class cls_main
    {
        Data.DataAccesLayer DAL = new Data.DataAccesLayer();
        DataTable dt = new DataTable();
     //================================
        public DataTable sum_total_inday() 
        {
            dt = new DataTable();
            dt = DAL.SelectData("sum_total_day", null);
            return dt;
        
        }
      //=======================

        public DataTable search_between_purch(string date1, string date2)
        {
            dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@date1", SqlDbType.NVarChar,50);
            parm[0].Value = date1;

            parm[1] = new SqlParameter("@date2", SqlDbType.NVarChar,50);
            parm[1].Value = date2;

            dt = DAL.SelectData("Search_Between_purches_trafec", parm);
            return dt;

        }
        //==========================
        
        public DataTable search_between_sal(string date1,string date2)
        {
            dt = new DataTable();
            SqlParameter[] parm=new SqlParameter[2];
            parm[0] = new SqlParameter("@date1", SqlDbType.NVarChar,50);
            parm[0].Value = date1;

            parm[1] = new SqlParameter("@date2", SqlDbType.NVarChar,50);
            parm[1].Value = date2;

            dt = DAL.SelectData("Search_Between_Sale_trafec", parm);
            return dt;

        }
        //============================

    }
}
