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
    class cls_reten
    {
        Data.DataAccesLayer DAL = new Data.DataAccesLayer();
        DataTable dt = new DataTable();

        public DataTable GetMaxid()
        {
            dt = new DataTable();
            dt = DAL.SelectData("Max_retenId", null);
            return dt;

        }

        //======================================
        public DataTable Get_barcod_retenitem(string id)
        {
            dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.NVarChar,50);
            parm[0].Value = id;

            dt = DAL.SelectData("get_all_retenitem", parm);
            return dt;

        }
        //=============================
        public DataTable selectAll_itemorder()
        {
            dt = new DataTable();
            dt = DAL.SelectData("get_all_retenItem_forsal", null);
            return dt;

        }
        //========================
        public DataTable search_all_retenItem(string id)
        {
            dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            parm[0].Value = id;

            dt = DAL.SelectData("search_all_retenItem_forsal", parm);
            return dt;

        }
        //=============================
       
        //======================================
        public void insert_item(int Reten_id, int order_id, string Barcod, string Reten_itemName, string Reten_pric,int RETN_QUNTY,string Reten_total,
                                string Reten_date, string USER_Retn, string stat_id, string reten_not,int item_id)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[12];
            parm[0] = new SqlParameter("@Reten_id", SqlDbType.Int);
            parm[0].Value = Reten_id;

            parm[1] = new SqlParameter("@order_id", SqlDbType.Int);
            parm[1].Value = order_id;

            parm[2] = new SqlParameter("@Barcod", SqlDbType.NVarChar,50);
            parm[2].Value = Barcod;

            parm[3] = new SqlParameter("@Reten_itemName", SqlDbType.NVarChar, 50);
            parm[3].Value = Reten_itemName;

            parm[4] = new SqlParameter("@Reten_pric", SqlDbType.NVarChar, 50);
            parm[4].Value = Reten_pric;

            parm[5] = new SqlParameter("@RETN_QUNTY", SqlDbType.Int);
            parm[5].Value = RETN_QUNTY;



            parm[6] = new SqlParameter("@Reten_total", SqlDbType.NVarChar, 50);
            parm[6].Value = Reten_total;

            parm[7] = new SqlParameter("@Reten_date", SqlDbType.NVarChar, 50);
            parm[7].Value = Reten_date;



            parm[8] = new SqlParameter("@USER_Retn", SqlDbType.NVarChar, 50);
            parm[8].Value = USER_Retn;

            parm[9] = new SqlParameter("@stat_id", SqlDbType.NVarChar, 50);
            parm[9].Value = stat_id;

            parm[10] = new SqlParameter("@reten_not", SqlDbType.NVarChar, 100);
            parm[10].Value = reten_not;

            parm[11] = new SqlParameter("@item_id", SqlDbType.Int);
            parm[11].Value = item_id;

            DAL.ExecuteCommand("insert_itemReten", parm);
            DAL.Close();
        }
        //=======================================
        //=============================
        public DataTable selectAll_reten()
        {
            dt = new DataTable();
            dt = DAL.SelectData("select_Retenitem", null);
            return dt;

        }
        //======================================
        public void update_item(int Reten_id, int order_id, string Barcod, string Reten_itemName, string Reten_pric, int RETN_QUNTY, string Reten_total,
                                string Reten_date, string USER_Retn, string stat_id, string reten_not, int item_id)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[12];
            parm[0] = new SqlParameter("@Reten_id", SqlDbType.Int);
            parm[0].Value = Reten_id;

            parm[1] = new SqlParameter("@order_id", SqlDbType.Int);
            parm[1].Value = order_id;

            parm[2] = new SqlParameter("@Barcod", SqlDbType.NVarChar, 50);
            parm[2].Value = Barcod;

            parm[3] = new SqlParameter("@Reten_itemName", SqlDbType.NVarChar, 50);
            parm[3].Value = Reten_itemName;

            parm[4] = new SqlParameter("@Reten_pric", SqlDbType.NVarChar, 50);
            parm[4].Value = Reten_pric;

            parm[5] = new SqlParameter("@RETN_QUNTY", SqlDbType.Int);
            parm[5].Value = RETN_QUNTY;



            parm[6] = new SqlParameter("@Reten_total", SqlDbType.NVarChar, 50);
            parm[6].Value = Reten_total;

            parm[7] = new SqlParameter("@Reten_date", SqlDbType.NVarChar, 50);
            parm[7].Value = Reten_date;



            parm[8] = new SqlParameter("@USER_Retn", SqlDbType.NVarChar, 50);
            parm[8].Value = USER_Retn;

            parm[9] = new SqlParameter("@stat_id", SqlDbType.NVarChar, 50);
            parm[9].Value = stat_id;

            parm[10] = new SqlParameter("@reten_not", SqlDbType.NVarChar, 100);
            parm[10].Value = reten_not;

            parm[11] = new SqlParameter("@item_id", SqlDbType.Int);
            parm[11].Value = item_id;

            DAL.ExecuteCommand("update_retenitem", parm);
            DAL.Close();
        }
        //=======================================
        public void Delete_RetenItem(int Reten_id)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = Reten_id;

            DAL.ExecuteCommand("delet_RetenItem", parm);
            DAL.Close();
        
        }
        //=======================================
        //=========================================

        public DataTable search_RetnitemBydgv(string id)
        {
            dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            parm[0].Value = id;

            dt = DAL.SelectData("Search_RetenItem", parm);
            return dt;

        }
        //=======================
        public void updat_qty_RetenItem(int item_id,int qty)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ITEM_ID", SqlDbType.Int);
            parm[0].Value = item_id;

            parm[1] = new SqlParameter("@qunty", SqlDbType.Int);
            parm[1].Value = qty;

            DAL.ExecuteCommand("update_Reten_Qunty", parm);
            DAL.Close();

        }
        //=======================================
        public void updat_State_RetenItem(string statid, int retenid)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@id", SqlDbType.NVarChar,50);
            parm[0].Value = statid;

            parm[1] = new SqlParameter("@reten_id", SqlDbType.Int);
            parm[1].Value = retenid;

            DAL.ExecuteCommand("update_reten_State", parm);
            DAL.Close();

        }
    }
}
