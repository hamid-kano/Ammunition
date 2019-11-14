using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FastFoodDemo.BL
{
    class SILAH_CLS 
    {
        public void ADD_NEW_SILAH(string DB_CODE, string SILAH_CODE,string SILAH_MODEL,
            int ISDELETED, string QTY_IN_STACK, string NOTES, int CAT_ID, string UNIT, string TABUR_CODE, string TABUR_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[0].Value = DB_CODE;

            param[1] = new SqlParameter("@SILAH_CODE", SqlDbType.NVarChar);
            param[1].Value = SILAH_CODE;

            param[2] = new SqlParameter("@SILAH_MODEL", SqlDbType.NVarChar);
            param[2].Value = SILAH_MODEL;

            param[3] = new SqlParameter("@ISDELETED", SqlDbType.Int);
            param[3].Value = ISDELETED;

            param[4] = new SqlParameter("@QTY_IN_STACK", SqlDbType.NVarChar);
            param[4].Value = QTY_IN_STACK;

            param[5] = new SqlParameter("@NOTES", SqlDbType.NVarChar);
            param[5].Value = NOTES;

            param[6] = new SqlParameter("@CAT_ID", SqlDbType.Int);
            param[6].Value = CAT_ID;

            param[7] = new SqlParameter("@UNIT", SqlDbType.NVarChar);
            param[7].Value = UNIT;

            param[8] = new SqlParameter("@TABUR_CODE", SqlDbType.NVarChar);
            param[8].Value = TABUR_CODE;

            param[9] = new SqlParameter("@TABUR_NAME", SqlDbType.NVarChar);
            param[9].Value = TABUR_NAME;
            DAL.excutecommand("ADD_NEW_SILAH", param);
            DAL.close();

        }
        public DataTable GET_ALL_SILAH()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_SILAH", null);
            DAL.close();
            return Dt;
        }

        public DataTable GET_MAX_SILAH_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_MAX_SILAH_ID", null);
            DAL.close();
            return Dt;
        }
     
        public void EDIT_SILAHS(string SILAH_CODE, string SILAH_MODEL, string QTY_IN_STACK, string NOTES, int CAT_ID, string UNIT, string TABUR_CODE, string TABUR_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@SILAH_CODE", SqlDbType.NVarChar);
            param[0].Value = SILAH_CODE;

            param[1] = new SqlParameter("@SILAH_MODEL", SqlDbType.NVarChar);
            param[1].Value = SILAH_MODEL;

            param[2] = new SqlParameter("@QTY_IN_STACK", SqlDbType.NVarChar);
            param[2].Value = QTY_IN_STACK;

            param[3] = new SqlParameter("@NOTES", SqlDbType.NVarChar);
            param[3].Value = NOTES;

            param[4] = new SqlParameter("@CAT_ID", SqlDbType.Int);
            param[4].Value = CAT_ID;

            param[5] = new SqlParameter("@UNIT", SqlDbType.NVarChar);
            param[5].Value = UNIT;

            param[6] = new SqlParameter("@TABUR_CODE", SqlDbType.NVarChar);
            param[6].Value = TABUR_CODE;

            param[7] = new SqlParameter("@TABUR_NAME", SqlDbType.NVarChar);
            param[7].Value = TABUR_NAME;

            DAL.excutecommand("EDIT_SILAHS", param);
            DAL.close();

        }
        public void DELETE_SILAH(string SILAH_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SILAH_CODE", SqlDbType.NVarChar);
            param[0].Value = SILAH_CODE;

            DAL.excutecommand("DELETE_SILAH", param);
            DAL.close();

        }

        public DataTable SEARCH_SILAH(string SEARCH)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SEARCH", SqlDbType.NVarChar);
            param[0].Value = SEARCH;

            Dt = DAL.selectdata("SEARCH_SILAH", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_SILAH_FOR_EDIT(string SILAH_NAME ,string SILAH_MODEL ,string TYPE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@SILAH_NAME", SqlDbType.NVarChar);
            param[0].Value = SILAH_NAME;

            param[1] = new SqlParameter("@SILAH_MODEL", SqlDbType.NVarChar);
            param[1].Value = SILAH_MODEL;

            param[2] = new SqlParameter("@TYPE", SqlDbType.NVarChar);
            param[2].Value = TYPE;

            Dt = DAL.selectdata("GET_SILAH_FOR_EDIT", param);
            DAL.close();
            return Dt;
        }

        public void ADD_CAT_SILAH(int CAT_ID, string NAME,  string NOTE, int IS_DELETED)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@CAT_ID", SqlDbType.Int);
            param[0].Value = CAT_ID;

            param[1] = new SqlParameter("@NAME", SqlDbType.NVarChar);
            param[1].Value = NAME;

            param[2] = new SqlParameter("@NOTE", SqlDbType.NVarChar);
            param[2].Value = NOTE;

            param[3] = new SqlParameter("@IS_DELETED", SqlDbType.Int);
            param[3].Value = IS_DELETED;

            DAL.excutecommand("ADD_CAT_SILAH", param);
            DAL.close();

        }
        public DataTable GET_ALL_CAT_SILAH()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();        
            Dt = DAL.selectdata("GET_ALL_CAT_SILAH", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_MAX_cat_num()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_MAX_cat_num", null);
            DAL.close();
            return Dt;
        }

        public DataTable GET_CAT_SILAH_FOR_EDIT(string NAME, string CAT_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@NAME", SqlDbType.NVarChar);
            param[0].Value = NAME;

            param[1] = new SqlParameter("@CAT_NAME", SqlDbType.NVarChar);
            param[1].Value = CAT_NAME;

            Dt = DAL.selectdata("GET_CAT_SILAH_FOR_EDIT", param);
            DAL.close();
            return Dt;
        }
        public void EDIT_CAT(int CAT_ID, string NAME, string NOTE ,int CAT_SIL_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@CAT_ID", SqlDbType.Int);
            param[0].Value = CAT_ID;

            param[1] = new SqlParameter("@NAME", SqlDbType.NVarChar);
            param[1].Value = NAME;

            param[2] = new SqlParameter("@NOTE", SqlDbType.NVarChar);
            param[2].Value = NOTE;

            param[3] = new SqlParameter("@CAT_SIL_ID", SqlDbType.Int);
            param[3].Value = CAT_SIL_ID;
            DAL.excutecommand("EDIT_CAT", param);
            DAL.close();

        }
        public void DELETE_CAT(string CAT_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CAT_ID", SqlDbType.NVarChar);
            param[0].Value = CAT_ID;

            DAL.excutecommand("DELETE_CAT", param);
            DAL.close();

        }

        public DataTable GET_SILAH_BY_CAT_CODE(int CAT_SILAH_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CAT_SILAH_ID", SqlDbType.Int);
            param[0].Value = CAT_SILAH_ID;

            Dt = DAL.selectdata("GET_SILAH_BY_CAT_CODE", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_CATEGORY_FOR_EDIT(string NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@NAME", SqlDbType.NVarChar);
            param[0].Value = NAME;

            Dt = DAL.selectdata("GET_CATEGORY_FOR_EDIT", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_CATEGORY()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            Dt = DAL.selectdata("GET_ALL_CATEGORY", null);
            DAL.close();
            return Dt;
        }
        public void EDIT_CATEGORY(string NAME,int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@NAME", SqlDbType.NVarChar);
            param[0].Value = NAME;

            param[1] = new SqlParameter("@ID", SqlDbType.NVarChar);
            param[1].Value = ID;

            DAL.excutecommand("EDIT_CATEGORY", param);
            DAL.close();

        }
        public void DELETE_CATEGORY( int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar);
            param[0].Value = ID;

            DAL.excutecommand("DELETE_CATEGORY", param);
            DAL.close();

        }
        public void ADD_CATEGRY(string NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@NAME", SqlDbType.NVarChar);
            param[0].Value = NAME;

            DAL.excutecommand("ADD_CATEGRY", param);
            DAL.close();

        }

        public void ADD_IMP_EXP(string FROM, string TO, string FROM_TO, DateTime DATE, string TYPE, int IS_DELETED,string NOTES)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@FROM", SqlDbType.NVarChar);
            param[0].Value = FROM;
            param[1] = new SqlParameter("@TO", SqlDbType.NVarChar);
            param[1].Value = TO;
            param[2] = new SqlParameter("@FROM_TO", SqlDbType.NVarChar);
            param[2].Value = FROM_TO;
            param[3] = new SqlParameter("@DATE", SqlDbType.Date);
            param[3].Value = DATE;
            param[4] = new SqlParameter("@TYPE", SqlDbType.NVarChar);
            param[4].Value = TYPE;

            param[5] = new SqlParameter("@IS_DELETED", SqlDbType.Int);
            param[5].Value = IS_DELETED;
            param[6] = new SqlParameter("@NOTES", SqlDbType.NVarChar);
            param[6].Value = NOTES;
            DAL.excutecommand("ADD_IMP_EXP", param);
            DAL.close();

        }
        public DataTable GET_MAX_IMP_EXP_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_MAX_IMP_EXP_ID", null);
            DAL.close();
            return Dt;
        }

        public void ADD_TO_IMP_EXP_SILAH(string SILAH_CODE, int IMP_EXP_ID, string FROM_TO, string QTY, string NOTES, int IS_DELETED)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@SILAH_CODE", SqlDbType.NVarChar);
            param[0].Value = SILAH_CODE;
            param[1] = new SqlParameter("@IMP_EXP_ID", SqlDbType.Int);
            param[1].Value = IMP_EXP_ID;
            param[2] = new SqlParameter("@FROM_TO", SqlDbType.NVarChar);
            param[2].Value = FROM_TO;
            param[3] = new SqlParameter("@QTY", SqlDbType.NVarChar);
            param[3].Value = QTY;
            param[4] = new SqlParameter("@NOTES", SqlDbType.NVarChar);
            param[4].Value = NOTES;
            param[5] = new SqlParameter("@IS_DELETED", SqlDbType.Int);
            param[5].Value = IS_DELETED;
            DAL.excutecommand("ADD_TO_IMP_EXP_SILAH", param);
            DAL.close();

        }
        public void ADD_TO_QTY(string SILAH_CODE, string QTY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@SILAH_CODE", SqlDbType.NVarChar);
            param[0].Value = SILAH_CODE;
            param[1] = new SqlParameter("@QTY", SqlDbType.NVarChar);
            param[1].Value = QTY;

            DAL.excutecommand("ADD_TO_QTY", param);
            DAL.close();

        }

        public void TAKE_SILAH_FROM_WAREHOUSE(string SILAH_CODE, string QTY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@SILAH_CODE", SqlDbType.NVarChar);
            param[0].Value = SILAH_CODE;
            param[1] = new SqlParameter("@QTY", SqlDbType.NVarChar);
            param[1].Value = QTY;

            DAL.excutecommand("TAKE_SILAH_FROM_WAREHOUSE", param);
            DAL.close();

        }
        public DataTable GET_FROM_IMP_EXP_BY_IMP_EXP_ID(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar);
            param[0].Value = ID;

            Dt = DAL.selectdata("GET_FROM_IMP_EXP_BY_IMP_EXP_ID", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_FROM_IMP_EXP(string TYPE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@TYPE", SqlDbType.NVarChar);
            param[0].Value = TYPE;

            Dt = DAL.selectdata("GET_FROM_IMP_EXP", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_IMP_EXP_DETAILS(int ID, string TYPE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar);
            param[0].Value = ID;

            param[1] = new SqlParameter("@TYPE", SqlDbType.NVarChar);
            param[1].Value = TYPE;

            Dt = DAL.selectdata("GET_IMP_EXP_DETAILS", param);
            DAL.close();
            return Dt;
        }
        public void EDIT_IMP_EXP(string FROM, string TO, string FROM_TO, DateTime DATE, string TYPE, int IS_DELETED,int ID,string NOTES)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@FROM", SqlDbType.NVarChar);
            param[0].Value = FROM;
            param[1] = new SqlParameter("@TO", SqlDbType.NVarChar);
            param[1].Value = TO;
            param[2] = new SqlParameter("@FROM_TO", SqlDbType.NVarChar);
            param[2].Value = FROM_TO;
            param[3] = new SqlParameter("@DATE", SqlDbType.Date);
            param[3].Value = DATE;
            param[4] = new SqlParameter("@TYPE", SqlDbType.NVarChar);
            param[4].Value = TYPE;
            param[5] = new SqlParameter("@IS_DELETED", SqlDbType.Int);
            param[5].Value = IS_DELETED;
            param[6] = new SqlParameter("@ID", SqlDbType.Int);
            param[6].Value = ID;
            param[7] = new SqlParameter("@NOTES", SqlDbType.NVarChar);
            param[7].Value = NOTES;
            DAL.excutecommand("EDIT_IMP_EXP", param);
            DAL.close();

        }

        public void DELETE_FROM_IMP_EXP(int IS_DELETE, int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@IS_DELETE", SqlDbType.Int);
            param[0].Value = IS_DELETE;

            param[1] = new SqlParameter("@ID", SqlDbType.Int);
            param[1].Value = ID;

            DAL.excutecommand("DELETE_FROM_IMP_EXP", param);
            DAL.close();

        }
        public void DELETE_FROM_SILAH_IMP_EXP(int ID, int IS_DELETED)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
;

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@IS_DELETED", SqlDbType.Int);
            param[1].Value = IS_DELETED;

            DAL.excutecommand("DELETE_FROM_SILAH_IMP_EXP", param);
            DAL.close();

        }
        public void DELETE_FROM_IMP_EXP_SILAH_BY_IMP_EXP_ID(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.excutecommand("DELETE_FROM_IMP_EXP_SILAH_BY_IMP_EXP_ID", param);
            DAL.close();

        }

        public void EDIT_QTY_IN_ROW(int ID, string QTY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@QTY", SqlDbType.NVarChar);
            param[1].Value = QTY;
            DAL.excutecommand("EDIT_QTY_IN_ROW", param);
            DAL.close();

        }

        public DataTable GET_SILAH_BY_CAT_NAME(string CAT_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CAT_NAME", SqlDbType.NVarChar);
            param[0].Value = CAT_NAME;

            Dt = DAL.selectdata("GET_SILAH_BY_CAT_NAME", param);
            DAL.close();
            return Dt;
        }


        

            }
}
