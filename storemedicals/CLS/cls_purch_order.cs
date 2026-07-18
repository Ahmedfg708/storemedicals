using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace storemedicals.CLS
{
    class cls_purch_order
    {
        Data.DataAccesLayer DAL = new Data.DataAccesLayer();
        DataTable dt;

        public DataTable purch_Maxid() 
        {
            dt = new DataTable();
            dt = DAL.SelectData("purch_order_MaxId", null);
            return dt;
        }
        //=============================
        public DataTable search_purch_order(string seach)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@search", SqlDbType.NVarChar,50);
            parm[0].Value = seach;
           
            dt = DAL.SelectData("get_pruch_order_byfatora", parm);
            return dt;

        }
       
        //==============================================

        public void purch_Insert(int PUR_ID, string PUR_DATE, string PUR_DECRIP, int SUP_ID, string USER_Add)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[5];
            parm[0] = new SqlParameter("@PUR_ID", SqlDbType.Int);
            parm[0].Value = PUR_ID;

            parm[1] = new SqlParameter("@PUR_DATE", SqlDbType.NVarChar, 50);
            parm[1].Value = PUR_DATE;

            parm[2] = new SqlParameter("@PUR_DECRIP", SqlDbType.NVarChar, 50);
            parm[2].Value = PUR_DECRIP;

            parm[3] = new SqlParameter("@SUP_ID", SqlDbType.Int);
            parm[3].Value = SUP_ID;

            parm[4] = new SqlParameter("@USER_Add", SqlDbType.NVarChar, 50);
            parm[4].Value = USER_Add;



            DAL.ExecuteCommand("purch_order_Insert", parm);
            DAL.Close();
        }


        //=========================================insret table pruches_order_detail==


        public void insert_PURCHES_ORDER_DETAIL_(int PUR_ord_ID, string fator_num, string barcod, string item_name, string purech_pric,
               int quntity, string prices_unit ,string amount,string stat_id)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[9];
            parm[0] = new SqlParameter("@PUR_ord_ID", SqlDbType.Int);
            parm[0].Value = PUR_ord_ID;

            parm[1] = new SqlParameter("@fator_num", SqlDbType.NVarChar,50);
            parm[1].Value = fator_num;

            parm[2] = new SqlParameter("@barcod", SqlDbType.NVarChar, 150);
            parm[2].Value = barcod;

            parm[3] = new SqlParameter("@item_name", SqlDbType.NVarChar,50);
            parm[3].Value = item_name;

            parm[4] = new SqlParameter("@purech_pric", SqlDbType.NVarChar, 50);
            parm[4].Value = purech_pric;

            parm[5] = new SqlParameter("@quntity", SqlDbType.Int);
            parm[5].Value = quntity;

            parm[6] = new SqlParameter("@prices_unit", SqlDbType.NVarChar, 50);
            parm[6].Value = prices_unit;

            parm[7] = new SqlParameter("@amount", SqlDbType.NVarChar,50);
            parm[7].Value = amount;

            

            parm[8] = new SqlParameter("@stat_id", SqlDbType.NVarChar,50);
            parm[8].Value = stat_id;

            DAL.ExecuteCommand("inset_PURCHES_ORDER_DETAIL", parm);
            DAL.Close();
        }

        //============================================

        public DataTable Get_all_fatoraShra()
        {
           DataTable dt = new DataTable();

            dt = DAL.SelectData("get_all_purches_order", null);
            return dt;

        }
        //=========================
        public DataTable Get_all_fator_byNumber(string search)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
            parm[0].Value = search;
            //parm[1] = new SqlParameter("@dat", SqlDbType.NVarChar, 50);
            //parm[1].Value = dat;
            dt = DAL.SelectData("search_purch_by_fator_number", parm);
            return dt;

        }
        //==========================
        public DataTable print_purch_report( string d1,string d2)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@stardat1", SqlDbType.NVarChar, 50);
            parm[0].Value = d1;

            parm[1] = new SqlParameter("@enddat2", SqlDbType.NVarChar, 50);
            parm[1].Value = d2;
            dt = DAL.SelectData("print_fatorsh", parm);
            return dt;

        }
        //===========================
        public void Delet_PURCHES_ORDER(int PUR_ord_ID )
           
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", SqlDbType.Int);
            parm[0].Value = PUR_ord_ID;

            DAL.ExecuteCommand("Delet_purches_order", parm);
            DAL.Close();
        }

        //=========================
        //============================================

        public DataTable print_on(int ID)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = ID;
            dt = DAL.SelectData("print_on_purch_order_detail", parm);
            return dt;

        }
        //=========================
        public DataTable print_all()
        {
            DataTable dt = new DataTable();
            dt = DAL.SelectData("print_All_purch_order_detail", null);
            return dt;

        }
        //=====================
        public DataTable load_data()
        {
            DataTable dt = new DataTable();

            dt = DAL.SelectData("get_all_purch_detail", null);
            return dt;

        }
    //================
    }
}
