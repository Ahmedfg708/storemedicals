using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace storemedicals.CLS
{
    class cls_user
    {

        Data.DataAccesLayer DAL = new Data.DataAccesLayer();
        DataTable dt = new DataTable();
        //==============================
        public DataTable GetMaxid()
        {
            dt = DAL.SelectData("user_max_id", null);
            return dt;

        }
        //=========================
        public DataTable cheack_Userame(string name )
        {
            dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@username", SqlDbType.NVarChar, 50);
            parm[0].Value = name;


            dt = DAL.SelectData("check_userNameEixt", parm);
            return dt;

        }
        //========================
        public string hashPassword(string input)
        { 
          string ps=string.Empty;
          MD5 hash = MD5.Create();
          byte[] data = hash.ComputeHash(Encoding.Default.GetBytes(input));
          StringBuilder bulder = new StringBuilder();
          for (int i = 0; i < data.Length; i++)
          {
              bulder.Append(data[i].ToString("x2"));
          }
          ps = bulder.ToString();
          return ps;

        }
        //========================================
        public DataTable cheaklog(string name,string pass )
        {
            dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@user_name", SqlDbType.NVarChar,50);
            parm[0].Value = name;

            parm[1] = new SqlParameter("@user_pass", SqlDbType.NVarChar, 50);
            parm[1].Value = pass;
            dt = DAL.SelectData("cheklogin", parm);
            return dt;

        }
        //================================================
        public DataTable GetAll_User()
        {
            dt = DAL.SelectData("user_Select", null);
            return dt;

        }
        //===========================================
        public void InsertUser(int id, string name,string pass,string type,string phon,string fullname ,bool active ,string userdate ,string w_tim)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[9];
            parm[0] = new SqlParameter("@USER_ID", SqlDbType.Int);
            parm[0].Value = id;

            parm[1] = new SqlParameter("@USER_NAME", SqlDbType.NVarChar,50);
            parm[1].Value = name;

            parm[2] = new SqlParameter("@USER_PASS", SqlDbType.NVarChar, 50);
            parm[2].Value = pass;

            parm[3] = new SqlParameter("@USER_TYPE", SqlDbType.NVarChar, 50);
            parm[3].Value = type;

            parm[4] = new SqlParameter("@USER_PHON", SqlDbType.NVarChar, 20);
            parm[4].Value = phon;

            parm[5] = new SqlParameter("@USER_FULL_NAME", SqlDbType.NVarChar, 150);
            parm[5].Value = fullname;

            parm[6] = new SqlParameter("@USER_ACTIV", SqlDbType.Bit);
            parm[6].Value = active;

            parm[7] = new SqlParameter("@USER_DATE", SqlDbType.NVarChar,50);
            parm[7].Value = userdate;

            parm[8] = new SqlParameter("@w_time", SqlDbType.NVarChar, 50);
            parm[8].Value = w_tim;

            DAL.ExecuteCommand("user_add", parm);
            DAL.Close();
        }

        //===========================================
        public void Update_User(string name, string pass, string type, string phon, string fullname, bool active, string userdate,string w_time, int id)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[9];
           

            parm[0] = new SqlParameter("@USER_NAME", SqlDbType.NVarChar, 50);
            parm[0].Value = name;

            parm[1] = new SqlParameter("@USER_PASS", SqlDbType.NVarChar, 50);
            parm[1].Value = pass;

            parm[2] = new SqlParameter("@USER_TYPE", SqlDbType.NVarChar, 50);
            parm[2].Value = type;

            parm[3] = new SqlParameter("@USER_PHON", SqlDbType.NVarChar, 20);
            parm[3].Value = phon;

            parm[4] = new SqlParameter("@USER_FULL_NAME", SqlDbType.NVarChar, 150);
            parm[4].Value = fullname;

            parm[5] = new SqlParameter("@USER_ACTIV", SqlDbType.Bit);
            parm[5].Value = active;

            parm[6] = new SqlParameter("@USER_DATE", SqlDbType.NVarChar,50);
            parm[6].Value = userdate;

            parm[7] = new SqlParameter("@w_time", SqlDbType.NVarChar, 50);
            parm[7].Value = w_time;

            parm[8] = new SqlParameter("@ID", SqlDbType.Int);
            parm[8].Value = id;

            DAL.ExecuteCommand("user_update", parm);
            DAL.Close();
        }

        //=========================================
        public void User_delet(int id)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];


            parm[0] = new SqlParameter("@id",SqlDbType.Int);
            parm[0].Value = id;
            DAL.ExecuteCommand("user_delet",parm);
            DAL.Close();
        }
        //===========================================
    }
}
