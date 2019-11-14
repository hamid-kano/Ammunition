using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FastFoodDemo.BL
{
    class COPORATION_CLS
    {
        public void ADD_NEW_COR(string DB_CODE, string COR_CODE, string COR_NAME, int DELETED)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar, 20);
            param[0].Value = DB_CODE;

            param[1] = new SqlParameter("@COR_CODE", SqlDbType.NVarChar, 20);
            param[1].Value = COR_CODE;

            param[2] = new SqlParameter("@COR_NAME", SqlDbType.NVarChar, 30);
            param[2].Value = COR_NAME;

            param[3] = new SqlParameter("@DELETED", SqlDbType.Int);
            param[3].Value = DELETED;

            DAL.excutecommand("ADD_NEW_COR", param);
            DAL.close();

        }
        public DataTable GET_ALL_COR()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_COR", null);
            DAL.close();
            return Dt;
        }

        public DataTable GET_MAX_COR_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_MAX_COR_ID", null);
            DAL.close();
            return Dt;
        }
        public void EDIT_COR( string COR_CODE, string COR_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
     
            param[0] = new SqlParameter("@COR_CODE", SqlDbType.NVarChar, 20);
            param[0].Value = COR_CODE;

            param[1] = new SqlParameter("@COR_NAME", SqlDbType.NVarChar, 30);
            param[1].Value = COR_NAME;

            DAL.excutecommand("EDIT_COR", param);
            DAL.close();

        }
        public void DELETE_COR(string COR_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
    
            param[0] = new SqlParameter("@COR_CODE", SqlDbType.NVarChar, 20);
            param[0].Value = COR_CODE;

            DAL.excutecommand("DELETE_COR", param);
            DAL.close();

        }

        public DataTable SEARCH_CORP(string SEARCH)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SEARCH", SqlDbType.NVarChar,20);
            param[0].Value = SEARCH;

            Dt = DAL.selectdata("SEARCH_CORP", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_COR_FOR_EDIT(string COR_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@COR_NAME", SqlDbType.NVarChar, 30);
            param[0].Value = COR_NAME;

            Dt = DAL.selectdata("GET_COR_FOR_EDIT", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_CORPO_BY_HEREM_CODE(string HEREM_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@HEREM_CODE", SqlDbType.NVarChar, 30);
            param[0].Value = HEREM_CODE;

            Dt = DAL.selectdata("GET_CORPO_BY_HEREM_CODE", param);
            DAL.close();
            return Dt;
        }
    }
}
