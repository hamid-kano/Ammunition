using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FastFoodDemo.BL
{
    class SOURC_CLS
    {
        public void ADD_NEW_SOURCE(string DB_CODE, string S_CODE, string S_NAME, int IS_DELETE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[0].Value = DB_CODE;

            param[1] = new SqlParameter("@S_CODE", SqlDbType.NVarChar);
            param[1].Value = S_CODE;

            param[2] = new SqlParameter("@S_NAME", SqlDbType.NVarChar);
            param[2].Value = S_NAME;

            param[3] = new SqlParameter("@IS_DELETE", SqlDbType.Int);
            param[3].Value = IS_DELETE;
            DAL.excutecommand("ADD_NEW_SOURCE", param);
            DAL.close();
        }

        public DataTable GET_ALL_SOURCE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_SOURCE", null);
            DAL.close();
            return Dt;
        }

        public DataTable GET_SOURCE_FOR_EDIT(string S_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@S_CODE", SqlDbType.NVarChar);
            param[0].Value = S_CODE;
            Dt = DAL.selectdata("GET_SOURCE_FOR_EDIT", param);
            DAL.close();
            return Dt;
        }

        public void EDIT_SOURCE(string S_CODE, string S_NAME, string S_NEW_CODE, int IS_DELETE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@S_CODE", SqlDbType.NVarChar);
            param[0].Value = S_CODE;

            param[1] = new SqlParameter("@S_NAME", SqlDbType.NVarChar);
            param[1].Value = S_NAME;

            param[2] = new SqlParameter("@S_NEW_CODE", SqlDbType.NVarChar);
            param[2].Value = S_NEW_CODE;

            param[3] = new SqlParameter("@IS_DELETE", SqlDbType.Int);
            param[3].Value = IS_DELETE;
            DAL.excutecommand("EDIT_SOURCE", param);
            DAL.close();
        }


        public void DELETE_SOURCE(string S_CODE ,int IS_DELETED )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@S_CODE", SqlDbType.NVarChar);
            param[0].Value = S_CODE;

            param[1] = new SqlParameter("@IS_DELETED", SqlDbType.Int);
            param[1].Value = IS_DELETED;
            DAL.excutecommand("DELETE_SOURCE", param);
            DAL.close();
        }

        public DataTable GET_SOURCE_BY_CODE(string CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            Dt = DAL.selectdata("GET_SOURCE_BY_CODE", param);
            DAL.close();
            return Dt;
        }


        public void ADD_DOCS(string MEM_IDEN, string APP_IDEN, string DOC_NAME,
            string DOC_LINK, string DOC_TYPE, string IMPORT_IDEN, int IS_DEL)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            param[1] = new SqlParameter("@APP_IDEN", SqlDbType.NVarChar);
            param[1].Value = APP_IDEN;

            param[2] = new SqlParameter("@DOC_NAME", SqlDbType.NVarChar);
            param[2].Value = DOC_NAME;

            param[3] = new SqlParameter("@DOC_LINK", SqlDbType.NVarChar);
            param[3].Value = DOC_LINK;

            param[4] = new SqlParameter("@DOC_TYPE", SqlDbType.NVarChar);
            param[4].Value = DOC_TYPE;

            param[5] = new SqlParameter("@IMPORT_IDEN", SqlDbType.NVarChar);
            param[5].Value = IMPORT_IDEN;

            param[6] = new SqlParameter("@IS_DEL", SqlDbType.Int);
            param[6].Value = IS_DEL;

            DAL.excutecommand("ADD_DOCS", param);
            DAL.close();
        }
        public DataTable GET_MEM_DOCS(int FOL_NUM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@FOL_NUM", SqlDbType.Int);
            param[0].Value = FOL_NUM;

            Dt = DAL.selectdata("GET_MEM_DOCS", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_MEM_DOCS_BY_MEM_IDEN(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            Dt = DAL.selectdata("GET_MEM_DOCS_BY_MEM_IDEN", param);
            DAL.close();
            return Dt;
        }
        public void DELETE_MEM_DOCS(int FOL_NUM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@FOL_NUM", SqlDbType.Int);
            param[0].Value = FOL_NUM;

            DAL.excutecommand("DELETE_MEM_DOCS", param);
            DAL.close();
        }

        public void EDIT_IN_GATH_TO_OLD(int GATH_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@GATH_ID", SqlDbType.Int);
            param[0].Value = GATH_ID;

            DAL.excutecommand("EDIT_IN_GATH_TO_OLD", param);
            DAL.close();
        }
        public DataTable GET_ALL_FORCE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_FORCE", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_LAST_FORCE_NUM()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_LAST_FORCE_NUM", null);
            DAL.close();
            return Dt;
        }
        public void ADD_FORCE(string FORCE_CODE, string DB_CODE, string FORCE_NAME, int DELEDTED)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@FORCE_CODE", SqlDbType.NVarChar);
            param[0].Value = FORCE_CODE;

            param[1] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[1].Value = DB_CODE;

            param[2] = new SqlParameter("@FORCE_NAME", SqlDbType.NVarChar);
            param[2].Value = FORCE_NAME;

            param[3] = new SqlParameter("@DELEDTED", SqlDbType.Int);
            param[3].Value = DELEDTED;
            DAL.excutecommand("ADD_FORCE", param);
            DAL.close();
        }
        public void EDIT_FORCE(string FORCE_CODE, string FORCE_NAME, string FORCE_CODE_NEW)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@FORCE_CODE", SqlDbType.NVarChar);
            param[0].Value = FORCE_CODE;

            param[1] = new SqlParameter("@FORCE_NAME", SqlDbType.NVarChar);
            param[1].Value = FORCE_NAME;

            param[2] = new SqlParameter("@FORCE_CODE_NEW", SqlDbType.NVarChar);
            param[2].Value = FORCE_CODE_NEW;

            DAL.excutecommand("EDIT_FORCE", param);
            DAL.close();
        }
        public DataTable GET_ALL_FORCE_FOR_EDIT(string FORCE_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@FORCE_CODE", SqlDbType.NVarChar);
            param[0].Value = FORCE_CODE;

            Dt = DAL.selectdata("GET_ALL_FORCE_FOR_EDIT", param);
            DAL.close();
            return Dt;
        }
        public void DELETE_FORCE(string FORCE_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@FORCE_CODE", SqlDbType.NVarChar);
            param[0].Value = FORCE_CODE;

            DAL.excutecommand("DELETE_FORCE", param);
            DAL.close();
        }
        public void ADD_FOLDER(string DB_CODE, string ID,
         string FOL_NAME, string FOL_LINK, int IS_DEL)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[0].Value = DB_CODE;

            param[1] = new SqlParameter("@ID", SqlDbType.NVarChar);
            param[1].Value = ID;

            param[2] = new SqlParameter("@FOL_NAME", SqlDbType.NVarChar);
            param[2].Value = FOL_NAME;

            param[3] = new SqlParameter("@FOL_LINK", SqlDbType.NVarChar);
            param[3].Value = FOL_LINK;

            param[4] = new SqlParameter("@IS_DEL", SqlDbType.Int);
            param[4].Value = IS_DEL;

            DAL.excutecommand("ADD_FOLDER", param);
            DAL.close();
        }
        public void UPDATE_FOLDER(string DB_CODE, string ID,
       string FOL_NAME, string FOL_LINK, int IS_DEL)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[0].Value = DB_CODE;

            param[1] = new SqlParameter("@ID", SqlDbType.NVarChar);
            param[1].Value = ID;

            param[2] = new SqlParameter("@FOL_NAME", SqlDbType.NVarChar);
            param[2].Value = FOL_NAME;

            param[3] = new SqlParameter("@FOL_LINK", SqlDbType.NVarChar);
            param[3].Value = FOL_LINK;

            param[4] = new SqlParameter("@IS_DEL", SqlDbType.Int);
            param[4].Value = IS_DEL;

            DAL.excutecommand("UPDATE_FOLDER", param);
            DAL.close();
        }
        public void ADD_TABUR_SILAH_FOLDER(string DB_CODE, string ID,
           string FOL_NAME, string FOL_LINK, int IS_DEL)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[0].Value = DB_CODE;

            param[1] = new SqlParameter("@ID", SqlDbType.NVarChar);
            param[1].Value = ID;

            param[2] = new SqlParameter("@FOL_NAME", SqlDbType.NVarChar);
            param[2].Value = FOL_NAME;

            param[3] = new SqlParameter("@FOL_LINK", SqlDbType.NVarChar);
            param[3].Value = FOL_LINK;

            param[4] = new SqlParameter("@IS_DEL", SqlDbType.Int);
            param[4].Value = IS_DEL;

            DAL.excutecommand("ADD_TABUR_SILAH_FOLDER", param);
            DAL.close();
        }
        
        

       
    }
}
