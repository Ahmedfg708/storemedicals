using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace storemedicals.CLS
{
    class cls_sale
    {
        Data.DataAccesLayer DAL = new Data.DataAccesLayer();
        DataTable dt;

        public DataTable sal_Maxid()
        {
            dt = new DataTable();
            dt = DAL.SelectData("max_itemorder", null);
            return dt;
        }
        //===============================
       

        public DataTable Get_barcod(string id)
        {
            dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@barcod", SqlDbType.NVarChar);
            parm[0].Value = id;

            dt = DAL.SelectData("Get_Barcod", parm);
            return dt;

        }
        //==========================Get_Barcod_item =======Get_Barcod=======

        public void insert_itemorder(int ored_id, string ored_desc, string ored_date, int cust_id, string user_add)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[5];
            parm[0] = new SqlParameter("@ored_id", SqlDbType.Int);
            parm[0].Value = ored_id;

            parm[1] = new SqlParameter("@ored_desc", SqlDbType.NVarChar,90);
            parm[1].Value = ored_desc;

            parm[2] = new SqlParameter("@ored_date", SqlDbType.NVarChar,50);
            parm[2].Value = ored_date;

            parm[3] = new SqlParameter("@cust_id", SqlDbType.Int);
            parm[3].Value = cust_id;

            parm[4] = new SqlParameter("@user_add", SqlDbType.NVarChar,50);
            parm[4].Value = user_add;

            DAL.ExecuteCommand("insert_item_order", parm);
            DAL.Close();
        }
    //================================================
      
        public void insert_itemorder_Detail(int item_id, int order_id, string ITEM_NAME_AR, string ITEM_BARCOD,
            int ITEM_COUNT, string ITEM_PRIC, string Amount, string totalAmount , string pink)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[9];
            parm[0] = new SqlParameter("@item_id", SqlDbType.Int);
            parm[0].Value = item_id;

            parm[1] = new SqlParameter("@order_id", SqlDbType.Int);
            parm[1].Value = order_id;

            parm[2] = new SqlParameter("@ITEM_NAME_AR", SqlDbType.NVarChar);
            parm[2].Value = ITEM_NAME_AR;

            parm[3] = new SqlParameter("@ITEM_BARCOD", SqlDbType.NVarChar);
            parm[3].Value = ITEM_BARCOD;


            parm[4] = new SqlParameter("@ITEM_COUNT", SqlDbType.Int);
            parm[4].Value = ITEM_COUNT;

            parm[5] = new SqlParameter("@ITEM_PRIC", SqlDbType.NVarChar,50);
            parm[5].Value = ITEM_PRIC;

            parm[6] = new SqlParameter("@Amount", SqlDbType.NVarChar,50);
            parm[6].Value = Amount;

            parm[7] = new SqlParameter("@totalAmount", SqlDbType.NVarChar,50);
            parm[7].Value = totalAmount;

           

            parm[8] = new SqlParameter("@pink", SqlDbType.NVarChar, 50);
            parm[8].Value = pink;


            DAL.ExecuteCommand("insert_item_order_Detail", parm);
            DAL.Close();
        }

        //===========================
        public void Delet_sal_orderitem(int ord_ID)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = ord_ID;

            DAL.ExecuteCommand("delet_Sal_orderitem", parm);
            DAL.Close();
        }

        //=========================
        public DataTable Get_all_search(string search)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@search",SqlDbType.NVarChar, 50);
            parm[0].Value = search;
            //parm[1] = new SqlParameter("@dat", SqlDbType.NVarChar, 50);
            //parm[1].Value = search;
            dt = DAL.SelectData("get_print_sal_by_Search", parm);
            return dt;

        }
        //=============================
        public DataTable Get_all_fator_bycutsmer(string search ,string dat)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[2];

            parm[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
            parm[0].Value = search;
            parm[1] = new SqlParameter("@dat", SqlDbType.NVarChar, 50);
            parm[1].Value = dat;
            dt = DAL.SelectData("serach_by_cutmer_fatora", parm);
            return dt;

        }
        //==============================
        public DataTable search_by_custmerAnd_dat(string name ,string dat)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[2];

            parm[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
            parm[0].Value = name;
            parm[1] = new SqlParameter("@dat", SqlDbType.NVarChar, 50);
            parm[1].Value = dat;
            dt = DAL.SelectData("get_print_sal_by_Search", parm);
            return dt;

        }
        //============================================

        public DataTable Get_all_salBill()
        {
            DataTable dt = new DataTable();

            dt = DAL.SelectData("Get_All_Sal_orderitem", null);
            return dt;

        }
        //===========================print all

        public DataTable Get_All_Sal_printForcrystal()
        {
            DataTable dt = new DataTable();

            dt = DAL.SelectData("Get_All_Sal_printForcrystal", null);
            return dt;

        
        }
        //==============================

        //========================= print Sale 

        public DataTable Get_All_Sal_printForcrystal2(int ID)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = ID;
            dt = DAL.SelectData("Get_one_sal_print", parm);
            return dt;


        }

        public DataTable get_quntyBybarcod(int itemid)
        {
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = itemid;
            dt = DAL.SelectData("get_quntyBybarcod", parm);
            return dt;


        }
        //============================

        //=======================حساب كمية الصنف فى المخزن========  

        public DataTable sum_qty_item(int sum_qty)
        {
            
            dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@qty", SqlDbType.Int);
            parm[0].Value = sum_qty;
            dt = DAL.SelectData("Get_qunty_item", parm);
            return dt;

        }
        //=====================
        public DataTable get_item_Bybarcod_For(string id)
        {
            dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            parm[0].Value = id;

            dt = DAL.SelectData("get_item_Bybarcod", parm);
            return dt;

        }
        //=====================
    }
}
