using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FastFoodDemo.BL
{
    class TUGAY_CLS
    {
        public void ADD_NEW_TUGAY(string DB_CODE, string TUGAY_CODE, string EYALET_CODE, string TUGAY_NAME, int ISDELETED, string LOCATION)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[0].Value = DB_CODE;

            param[1] = new SqlParameter("@TUGAY_CODE", SqlDbType.NVarChar);
            param[1].Value = TUGAY_CODE;

            param[2] = new SqlParameter("@EYALET_CODE", SqlDbType.NVarChar);
            param[2].Value = EYALET_CODE;

            param[3] = new SqlParameter("@TUGAY_NAME", SqlDbType.NVarChar);
            param[3].Value = TUGAY_NAME;

            param[4] = new SqlParameter("@ISDELETED", SqlDbType.Int);
            param[4].Value = ISDELETED;

            param[5] = new SqlParameter("@LOCATION", SqlDbType.NVarChar);
            param[5].Value = LOCATION;


            DAL.excutecommand("ADD_NEW_TUGAY", param);
            DAL.close();

        }
        public DataTable GET_ALL_TUGAY()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_TUGAY", null);
            DAL.close();
            return Dt;
        }

        public DataTable GET_MAX_TUGAY_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_MAX_TUGAY_ID", null);
            DAL.close();
            return Dt;
        }
        public void EDIT_TUGAY(string TUAGY_CODE, string EYALET_CODE, string TUGAY_NAME, string LOCATION, string TUAGY_NEW_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@TUAGY_CODE", SqlDbType.NVarChar);
            param[0].Value = TUAGY_CODE;

            param[1] = new SqlParameter("@EYALET_CODE", SqlDbType.NVarChar);
            param[1].Value = EYALET_CODE;

            param[2] = new SqlParameter("@TUGAY_NAME", SqlDbType.NVarChar);
            param[2].Value = TUGAY_NAME;

            param[3] = new SqlParameter("@LOCATION", SqlDbType.NVarChar);
            param[3].Value = LOCATION;

            param[4] = new SqlParameter("@TUAGY_NEW_CODE", SqlDbType.NVarChar);
            param[4].Value = TUAGY_NEW_CODE;
            DAL.excutecommand("EDIT_TUGAY", param);
            DAL.close();

        }
        public void DELETE_TUGAY(string TUGAY_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@TUGAY_CODE", SqlDbType.NVarChar, 20);
            param[0].Value = TUGAY_CODE;

            DAL.excutecommand("DELETE_TUGAY", param);
            DAL.close();

        }

        public DataTable SEARCH_YUGAY(string SEARCH)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SEARCH", SqlDbType.NVarChar, 20);
            param[0].Value = SEARCH;

            Dt = DAL.selectdata("SEARCH_YUGAY", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_TUGAT_FOR_EDIT(string TUGAY_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@TUGAY_NAME", SqlDbType.NVarChar, 30);
            param[0].Value = TUGAY_NAME;

            Dt = DAL.selectdata("GET_TUGAT_FOR_EDIT", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_TUGAY_CODE_FOR_EDIT(string TUGAY_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@TUGAY_CODE", SqlDbType.NVarChar, 20);
            param[0].Value = TUGAY_CODE;

            Dt = DAL.selectdata("GET_TUGAY_CODE_FOR_EDIT", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_EYALET_BY_TUGAY_CODE(string TUGAY_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@TUGAY_CODE", SqlDbType.NVarChar, 20);
            param[0].Value = TUGAY_CODE;

            Dt = DAL.selectdata("GET_EYALET_BY_TUGAY_CODE", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_TUGAY_BY_EYALET_CODE_AND_COR_CODE(string EYALET_CODE, string COR_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@EYALET_CODE", SqlDbType.NVarChar, 20);
            param[0].Value = EYALET_CODE;

            param[1] = new SqlParameter("@COR_CODE", SqlDbType.NVarChar, 20);
            param[1].Value = COR_CODE;

            Dt = DAL.selectdata("GET_TUGAY_BY_EYALET_CODE_AND_COR_CODE", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_TUGAY_BY_ALAY_CODE(string ALAY_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ALAY_CODE", SqlDbType.NVarChar, 20);
            param[0].Value = ALAY_CODE;

            Dt = DAL.selectdata("GET_TUGAY_BY_ALAY_CODE", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_TUGAY_BY_CODE(string CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            Dt = DAL.selectdata("GET_TUGAY_BY_CODE", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_TUGAY_BY_EYALET_CODE(string CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            Dt = DAL.selectdata("GET_TUGAY_BY_EYALET_CODE", param);
            DAL.close();
            return Dt;
        }
    }
}
