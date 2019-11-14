using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FastFoodDemo.BL
{
    class ALAY_CLS
    {
        public void ADD_NEW_ALAY(string DB_CODE, string ALAY_CODE, string TUGAY_CODE, string ALAY_NAME, int ISDELETED ,string LOCATION)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[0].Value = DB_CODE;

            param[1] = new SqlParameter("@ALAY_CODE", SqlDbType.NVarChar);
            param[1].Value = ALAY_CODE;

            param[2] = new SqlParameter("@TUGAY_CODE", SqlDbType.NVarChar);
            param[2].Value = TUGAY_CODE;

            param[3] = new SqlParameter("@ALAY_NAME", SqlDbType.NVarChar);
            param[3].Value = ALAY_NAME;

            param[4] = new SqlParameter("@ISDELETED", SqlDbType.Int);
            param[4].Value = ISDELETED;

            param[5] = new SqlParameter("@LOCATION", SqlDbType.NVarChar);
            param[5].Value = LOCATION;

            DAL.excutecommand("ADD_NEW_ALAY", param);
            DAL.close();

        }
        public DataTable GET_ALL_ALAY()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_ALAY", null);
            DAL.close();
            return Dt;
        }


        public void EDIT_ALAY(string ALAY_CODE, string TUGAY_CODE, string ALAY_NAME, string ALAY_NEW_CODE,string LOCATION)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@ALAY_CODE", SqlDbType.NVarChar);
            param[0].Value = ALAY_CODE;

            param[1] = new SqlParameter("@TUGAY_CODE", SqlDbType.NVarChar);
            param[1].Value = TUGAY_CODE;

            param[2] = new SqlParameter("@ALAY_NAME", SqlDbType.NVarChar);
            param[2].Value = ALAY_NAME;

            param[3] = new SqlParameter("@ALAY_NEW_CODE", SqlDbType.NVarChar);
            param[3].Value = ALAY_NEW_CODE;

            param[4] = new SqlParameter("@LOCATION", SqlDbType.NVarChar);
            param[4].Value = LOCATION;
            DAL.excutecommand("EDIT_ALAY", param);
            DAL.close();

        }
        public void DELETE_ALAY(string ALAY_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ALAY_CODE", SqlDbType.NVarChar);
            param[0].Value = ALAY_CODE;

            DAL.excutecommand("DELETE_ALAY", param);
            DAL.close();

        }

        public DataTable SEARCH_ALAY(string SEARCH)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SEARCH", SqlDbType.NVarChar);
            param[0].Value = SEARCH;

            Dt = DAL.selectdata("SEARCH_ALAY", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALAY_FOR_EDIT(string ALAY_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ALAY_CODE", SqlDbType.NVarChar);
            param[0].Value = ALAY_CODE;

            Dt = DAL.selectdata("GET_ALAY_FOR_EDIT", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALAY_BY_TUGAY_CODE(string TUGAY_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@TUGAY_CODE", SqlDbType.NVarChar);
            param[0].Value = TUGAY_CODE;

            Dt = DAL.selectdata("GET_ALAY_BY_TUGAY_CODE", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_AIAY_BY_CODE(string CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            Dt = DAL.selectdata("GET_AIAY_BY_CODE", param);
            DAL.close();
            return Dt;
        }
    }
}
