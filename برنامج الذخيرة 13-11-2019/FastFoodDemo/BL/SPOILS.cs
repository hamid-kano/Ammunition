using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FastFoodDemo.BL
{
    class SPOILS
    {
        public void ADD_NEW_SPOIL(string TYPE, DateTime DATE, string SOURCE, string CONTENT, string NOTES, int IS_DEL)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@TYPE", SqlDbType.NVarChar);
            param[0].Value = TYPE;

            param[1] = new SqlParameter("@DATE", SqlDbType.Date);
            param[1].Value = DATE;

            param[2] = new SqlParameter("@SOURCE", SqlDbType.NVarChar);
            param[2].Value = SOURCE;

            param[3] = new SqlParameter("@CONTENT", SqlDbType.NVarChar);
            param[3].Value = CONTENT;

            param[4] = new SqlParameter("@NOTES ", SqlDbType.NVarChar);
            param[4].Value = NOTES;

            param[5] = new SqlParameter("@IS_DEL", SqlDbType.Int);
            param[5].Value = IS_DEL;

            DAL.excutecommand("ADD_NEW_SPOIL", param);
            DAL.close();

        }
        public DataTable GET_ALL_SPOILS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_SPOILS", null);
            DAL.close();
            return Dt;
        }

        public void EDIT_SPOIL(string TYPE, DateTime DATE, string SOURCE, string CONTENT, string NOTES, int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@TYPE", SqlDbType.NVarChar);
            param[0].Value = TYPE;

            param[1] = new SqlParameter("@DATE", SqlDbType.Date);
            param[1].Value = DATE;

            param[2] = new SqlParameter("@SOURCE", SqlDbType.NVarChar);
            param[2].Value = SOURCE;

            param[3] = new SqlParameter("@CONTENT", SqlDbType.NVarChar);
            param[3].Value = CONTENT;

            param[4] = new SqlParameter("@NOTES ", SqlDbType.NVarChar);
            param[4].Value = NOTES;

            param[5] = new SqlParameter("@ID", SqlDbType.Int);
            param[5].Value = ID;

            DAL.excutecommand("EDIT_SPOIL", param);
            DAL.close();

        }
        public void DELETE_SPOIL(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.excutecommand("DELETE_SPOIL", param);
            DAL.close();

        }

        public DataTable SEARCH_SPOIL(string SEARCH)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SEARCH", SqlDbType.NVarChar);
            param[0].Value = SEARCH;

            Dt = DAL.selectdata("SEARCH_SPOIL", param);
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
        public void ADD_ORDER_FOLDER(string DB_CODE, int ID,
        string FOL_NAME, string FOL_LINK, int IS_DEL)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[0].Value = DB_CODE;

            param[1] = new SqlParameter("@ID", SqlDbType.Int);
            param[1].Value = ID;

            param[2] = new SqlParameter("@FOL_NAME", SqlDbType.NVarChar);
            param[2].Value = FOL_NAME;

            param[3] = new SqlParameter("@FOL_LINK", SqlDbType.NVarChar);
            param[3].Value = FOL_LINK;

            param[4] = new SqlParameter("@IS_DEL", SqlDbType.Int);
            param[4].Value = IS_DEL;

            DAL.excutecommand("ADD_ORDER_FOLDER", param);
            DAL.close();
        }
        public DataTable GET_FOLDER_BY_ID(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            Dt = DAL.selectdata("GET_FOLDER_BY_ID", param);
            DAL.close();
            return Dt;
        }

        public void DELETE_FOLDER(int FOL_NUM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@FOL_NUM", SqlDbType.Int);
            param[0].Value = FOL_NUM;

            DAL.excutecommand("DELETE_FOLDER", param);
            DAL.close();

        }

        internal object ADD_ORDER_FOLDER(int p)
        {
            throw new NotImplementedException();
        }
    }
}
