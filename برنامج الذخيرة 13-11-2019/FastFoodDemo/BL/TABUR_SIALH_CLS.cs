using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace FastFoodDemo.BL
{
    class TABUR_SIALH_CLS
    {
        public void ADD_NEW_TABUR_SILAH(string DB_CODE, string TABUR_CODE, string SIALH_CODE, int SILAH_NUMBER, string SILAH_UNIT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[0].Value = DB_CODE;

            param[1] = new SqlParameter("@TABUR_CODE", SqlDbType.NVarChar);
            param[1].Value = TABUR_CODE;

            param[2] = new SqlParameter("@SIALH_CODE", SqlDbType.NVarChar);
            param[2].Value = SIALH_CODE;

            param[3] = new SqlParameter("@SILAH_NUMBER", SqlDbType.Int);
            param[3].Value = SILAH_NUMBER;

            param[4] = new SqlParameter("@SILAH_UNIT", SqlDbType.NVarChar);
            param[4].Value = SILAH_UNIT;

            DAL.excutecommand("ADD_NEW_TABUR_SILAH", param);
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

        public DataTable GET_TABUR_SILAH_BY_TABUR_CODE(string TABUR_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TABUR_CODE", SqlDbType.NVarChar);
            param[0].Value = TABUR_CODE;
            Dt = DAL.selectdata("GET_TABUR_SILAH_BY_TABUR_CODE", param);
            DAL.close();
            return Dt;
        }
        public void EDIT_ALAY(string ALAY_CODE, string TUGAY_CODE, string ALAY_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@ALAY_CODE", SqlDbType.NVarChar);
            param[0].Value = ALAY_CODE;

            param[1] = new SqlParameter("@TUGAY_CODE", SqlDbType.NVarChar);
            param[1].Value = TUGAY_CODE;

            param[2] = new SqlParameter("@ALAY_NAME", SqlDbType.NVarChar);
            param[2].Value = ALAY_NAME;

      

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
        public DataTable GET_ALAY_FOR_EDIT(string ALAY_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ALAY_NAME", SqlDbType.NVarChar);
            param[0].Value = ALAY_NAME;

            Dt = DAL.selectdata("GET_ALAY_FOR_EDIT", param);
            DAL.close();
            return Dt;
        }
    }
}
