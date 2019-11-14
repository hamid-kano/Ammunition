using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace FastFoodDemo.BL
{
    class EYALET_CLS
    {
        public void ADD_NEW_EYALET(string DB_CODE, string EYALET_CODE, string HEREM_CODE, string EYALET_NAME, int ISDELETED)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[0].Value = DB_CODE;

            param[1] = new SqlParameter("@EYALET_CODE", SqlDbType.NVarChar);
            param[1].Value = EYALET_CODE;

            param[2] = new SqlParameter("@HEREM_CODE", SqlDbType.NVarChar);
            param[2].Value = HEREM_CODE;

            param[3] = new SqlParameter("@EYALET_NAME", SqlDbType.NVarChar);
            param[3].Value = EYALET_NAME;

            param[4] = new SqlParameter("@ISDELETED", SqlDbType.Int);
            param[4].Value = ISDELETED;

            DAL.excutecommand("ADD_NEW_EYALET", param);
            DAL.close();

        }
        public DataTable GET_ALL_EYALET()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_EYALET", null);
            DAL.close();
            return Dt;
        }

        public DataTable GET_MAX_EYALET_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_MAX_EYALET_ID", null);
            DAL.close();
            return Dt;
        }
        public void EDIT_EYALET(string EYALET_CODE, string HEREM_CODE, string EYALET_NAME, string EYALET_NEW_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@EYALET_CODE", SqlDbType.NVarChar);
            param[0].Value = EYALET_CODE;  

            param[1] = new SqlParameter("@HEREM_CODE", SqlDbType.NVarChar);
            param[1].Value = HEREM_CODE;

            param[2] = new SqlParameter("@EYALET_NAME", SqlDbType.NVarChar);
            param[2].Value = EYALET_NAME;

            param[3] = new SqlParameter("@EYALET_NEW_CODE", SqlDbType.NVarChar);
            param[3].Value = EYALET_NEW_CODE;
            DAL.excutecommand("EDIT_EYALET", param);
            DAL.close();

        }
        public void DELETE_EYALET(string EYALET_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@EYALET_CODE", SqlDbType.NVarChar);
            param[0].Value = EYALET_CODE;

            DAL.excutecommand("DELETE_EYALET", param);
            DAL.close();

        }

        public DataTable SREACH_EYALET(string SEARCH)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SEARCH", SqlDbType.NVarChar);
            param[0].Value = SEARCH;

            Dt = DAL.selectdata("SREACH_EYALET", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_EYALET_FOR_EDIT(string EYALET_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@EYALET_CODE", SqlDbType.NVarChar);
            param[0].Value = EYALET_CODE;

            Dt = DAL.selectdata("GET_EYALET_FOR_EDIT", param);
            DAL.close();
            return Dt;
        }

        public DataTable GET_EYALET_BY_HEREM_CODE(string HEREM_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@HEREM_CODE", SqlDbType.NVarChar);
            param[0].Value = HEREM_CODE;

            Dt = DAL.selectdata("GET_EYALET_BY_HEREM_CODE", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_HEREM_BY_EYALET_CODE(string EYALET_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@EYALET_CODE", SqlDbType.NVarChar);
            param[0].Value = EYALET_CODE;

            Dt = DAL.selectdata("GET_HEREM_BY_EYALET_CODE", param);
            DAL.close();
            return Dt;
        }

        public DataTable GET_EYALET_BY_CODE(string CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            Dt = DAL.selectdata("GET_EYALET_BY_CODE", param);
            DAL.close();
            return Dt;
        }
    }
}
