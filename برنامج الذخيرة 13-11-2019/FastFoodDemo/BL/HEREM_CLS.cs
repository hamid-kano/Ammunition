using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FastFoodDemo.BL
{
    class HEREM_CLS
    {

        public void ADD_NEW_HEREM(string DB_CODE, string HEREM_CODE, string HEREM_NAME, int ISDELETED)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[0].Value = DB_CODE;

            param[1] = new SqlParameter("@HEREM_CODE", SqlDbType.NVarChar);
            param[1].Value = HEREM_CODE;

            param[2] = new SqlParameter("@HEREM_NAME", SqlDbType.NVarChar);
            param[2].Value = HEREM_NAME;

            param[3] = new SqlParameter("@ISDELETED", SqlDbType.Int);
            param[3].Value = ISDELETED;

            DAL.excutecommand("ADD_NEW_HEREM", param);
            DAL.close();

        }
        public DataTable GET_ALL_HEREM()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_HEREM", null);
            DAL.close();
            return Dt;
        }

        public DataTable GET_MAX_HEREM_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_MAX_HEREM_ID", null);
            DAL.close();
            return Dt;
        }
        public void EDIT_HEREM(string HEREM_CODE, string HEREM_NAME,string HEREM_NEW_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@HEREM_CODE", SqlDbType.NVarChar);
            param[0].Value = HEREM_CODE;

            param[1] = new SqlParameter("@HEREM_NAME", SqlDbType.NVarChar);
            param[1].Value = HEREM_NAME;

            param[2] = new SqlParameter("@HEREM_NEW_CODE", SqlDbType.NVarChar);
            param[2].Value = HEREM_NEW_CODE;

            DAL.excutecommand("EDIT_HEREM", param);
            DAL.close();

        }
        public void DELETE_HEREM(string HEREM_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@HEREM_CODE", SqlDbType.NVarChar);
            param[0].Value = HEREM_CODE;

            DAL.excutecommand("DELETE_HEREM", param);
            DAL.close();

        }

        public DataTable SEARCH_HEREM(string SEARCH)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SEARCH", SqlDbType.NVarChar);
            param[0].Value = SEARCH;

            Dt = DAL.selectdata("SEARCH_HEREM", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_HEREM_FOR_EDIT(string HEREM_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@HEREM_NAME", SqlDbType.NVarChar);
            param[0].Value = HEREM_NAME;

            Dt = DAL.selectdata("GET_HEREM_FOR_EDIT", param);
            DAL.close();
            return Dt;
        }

        public DataTable GET_HEREM_BY_CODE(string CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            Dt = DAL.selectdata("GET_HEREM_BY_CODE", param);
            DAL.close();
            return Dt;
        }
    }
}
