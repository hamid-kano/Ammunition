using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FastFoodDemo.BL
{
    class MEMBER_CLS
    {
        public DataTable GET_ALL_MEMBER_FOR_ADD()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_MEMBER_FOR_ADD", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_LAST_MEM_NUM()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_LAST_MEM_NUM", null);
            DAL.close();
            return Dt;
        }

        public void ADD_MEM_WITHOUT_FINGER(string MEM_IDEN,string  DB_CODE,string MEM_CARD_NUM,
            string CODE_NAME,string MEM_NAME,string MEM_FNAME,string MEM_LNAME,string MEM_MNAME
           ,DateTime MEM_BDATE,string MEM_BPLACE, string GENDER ,string NATIONALISM
           ,string SPECIAL_NOTES, string IMPORT_IDEN, int IS_DEL, string CERCUR_NUM
            , string CUBE_NUM, string RESAS_NUM, string BOMB_NUM, string ANOTHER_THINGS, string OWN_SILAH_NUM,string OWN_SILAH_DATA)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[22];
            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            param[1] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[1].Value = DB_CODE;

            param[2] = new SqlParameter("@MEM_CARD_NUM", SqlDbType.NVarChar);
            param[2].Value = MEM_CARD_NUM;

            param[3] = new SqlParameter("@CODE_NAME", SqlDbType.NVarChar);
            param[3].Value = CODE_NAME;

            param[4] = new SqlParameter("@MEM_NAME", SqlDbType.NVarChar);
            param[4].Value = MEM_NAME;

            param[5] = new SqlParameter("@MEM_FNAME", SqlDbType.NVarChar);
            param[5].Value = MEM_FNAME;

            param[6] = new SqlParameter("@MEM_LNAME", SqlDbType.NVarChar);
            param[6].Value = MEM_LNAME;

            param[7] = new SqlParameter("@MEM_MNAME", SqlDbType.NVarChar);
            param[7].Value = MEM_MNAME;

            param[8] = new SqlParameter("@MEM_BDATE", SqlDbType.Date);
            param[8].Value = MEM_BDATE;

            param[9] = new SqlParameter("@MEM_BPLACE", SqlDbType.NVarChar);
            param[9].Value = MEM_BPLACE; 

            param[10] = new SqlParameter("@GENDER", SqlDbType.NVarChar);
            param[10].Value = GENDER;
 
            param[11] = new SqlParameter("@NATIONALISM", SqlDbType.NVarChar);
            param[11].Value = NATIONALISM;
            param[12] = new SqlParameter("@SPECIAL_NOTES", SqlDbType.NVarChar);
            param[12].Value = SPECIAL_NOTES;

            param[13] = new SqlParameter("@IMPORT_IDEN", SqlDbType.NVarChar);
            param[13].Value = IMPORT_IDEN;

            param[14] = new SqlParameter("@IS_DEL", SqlDbType.TinyInt);
            param[14].Value = IS_DEL;

            param[15] = new SqlParameter("@CERCUR_NUM", SqlDbType.NVarChar);
            param[15].Value = CERCUR_NUM;

            param[16] = new SqlParameter("@CUBE_NUM", SqlDbType.NVarChar);
            param[16].Value = CUBE_NUM;

            param[17] = new SqlParameter("@RESAS_NUM ", SqlDbType.NVarChar);
            param[17].Value = RESAS_NUM;

            param[18] = new SqlParameter("@BOMB_NUM", SqlDbType.NVarChar);
            param[18].Value = BOMB_NUM;

            param[19] = new SqlParameter("@ANOTHER_THINGS", SqlDbType.NVarChar);
            param[19].Value = ANOTHER_THINGS;

            param[20] = new SqlParameter("@OWN_SILAH_NUM", SqlDbType.NVarChar);
            param[20].Value = OWN_SILAH_NUM;

            param[21] = new SqlParameter("@OWN_SILAH_DATA", SqlDbType.NVarChar);
            param[21].Value = OWN_SILAH_DATA;

            DAL.excutecommand("ADD_MEM_WITHOUT_FINGER", param);
            DAL.close();
        }


        public void ADD_IN_GATH(string MEM_IDEN, string FORCE_CODE, string  TABUR_CODE,
        string DB_CODE, string PLACE_NOW, string MEM_TYPE, DateTime ROW_DATE,
            string ROW_STATUS, string IMPORT_IDEN,int IS_DEL)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            param[1] = new SqlParameter("@FORCE_CODE", SqlDbType.NVarChar);
            param[1].Value = FORCE_CODE;

            param[2] = new SqlParameter("@TABUR_CODE", SqlDbType.NVarChar);
            param[2].Value = TABUR_CODE;

            param[3] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[3].Value = DB_CODE;

            param[4] = new SqlParameter("@PLACE_NOW", SqlDbType.NVarChar);
            param[4].Value = PLACE_NOW;

            param[5] = new SqlParameter("@MEM_TYPE", SqlDbType.NVarChar);
            param[5].Value = MEM_TYPE;

            param[6] = new SqlParameter("@ROW_DATE", SqlDbType.Date);
            param[6].Value = ROW_DATE;

            param[7] = new SqlParameter("@ROW_STATUS", SqlDbType.NVarChar);
            param[7].Value = ROW_STATUS;

            param[8] = new SqlParameter("@IMPORT_IDEN", SqlDbType.NVarChar);
            param[8].Value = IMPORT_IDEN;

            param[9] = new SqlParameter("@IS_DEL", SqlDbType.TinyInt);
            param[9].Value = IS_DEL;

            DAL.excutecommand("ADD_IN_GATH", param);
            DAL.close();
        }
        public DataTable GET_LAST_MEM_IDEN()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_LAST_MEM_IDEN", null);
            DAL.close();
            return Dt;
        }
        public void ADD_MEM_POSSESIONS(string MEM_ID, string CERCOR, string BULLETS,
                                  string QUIVER, string BOMB, string ANOTHER_THINGS, string OWN_SILAH_NUM, string OWN_SILAH_DATA)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@MEM_ID", SqlDbType.NVarChar);
            param[0].Value = MEM_ID;

            param[1] = new SqlParameter("@CERCOR", SqlDbType.NVarChar);
            param[1].Value = CERCOR;

            param[2] = new SqlParameter("@BULLETS", SqlDbType.NVarChar);
            param[2].Value = BULLETS;

            param[3] = new SqlParameter("@QUIVER", SqlDbType.NVarChar);
            param[3].Value = QUIVER;

            param[4] = new SqlParameter("@BOMB", SqlDbType.NVarChar);
            param[4].Value = BOMB;

            param[5] = new SqlParameter("@ANOTHER_THINGS", SqlDbType.NVarChar);
            param[5].Value = ANOTHER_THINGS;

            param[6] = new SqlParameter("@OWN_SILAH_NUM", SqlDbType.NVarChar);
            param[6].Value = OWN_SILAH_NUM;

            param[7] = new SqlParameter("@OWN_SILAH_DATA", SqlDbType.NVarChar);
            param[7].Value = OWN_SILAH_DATA;

            DAL.excutecommand("ADD_MEM_POSSESIONS", param);
            DAL.close();

        }
        public void DELETE_FROM_FOLDER(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            DAL.excutecommand("DELETE_FROM_FOLDER", param);
            DAL.close();

        }
        public void DELETE_MEM_FOLDER(int FOL_NUM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@FOL_NUM", SqlDbType.Int);
            param[0].Value = FOL_NUM;

            DAL.excutecommand("DELETE_MEM_FOLDER", param);
            DAL.close();

        }
        public void DELETE_TABUR_SILAH_FOLDER(int FOL_NUM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@FOL_NUM", SqlDbType.Int);
            param[0].Value = FOL_NUM;

            DAL.excutecommand("DELETE_TABUR_SILAH_FOLDER", param);
            DAL.close();

        }
        public DataTable GET_MEM_FOLDER(int FOL_NUM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@FOL_NUM", SqlDbType.Int);
            param[0].Value = FOL_NUM;

            Dt = DAL.selectdata("GET_MEM_FOLDER", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_KATEBA_FOR_ADD_MEM()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_KATEBA_FOR_ADD_MEM", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_FORC_FOR_ADD_MEM()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_FORC_FOR_ADD_MEM", null);
            DAL.close();
            return Dt;
        }

        public void ADD_LOG(string DB_CODE, int USER_IDEN, string TYPE_LOG, string DESC_LOG, DateTime DATE_LOG)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[0].Value = DB_CODE;

            param[1] = new SqlParameter("@USER_IDEN", SqlDbType.Int);
            param[1].Value = USER_IDEN;

            param[2] = new SqlParameter("@TYPE_LOG", SqlDbType.NVarChar);
            param[2].Value = TYPE_LOG;

            param[3] = new SqlParameter("@DESC_LOG", SqlDbType.NVarChar);
            param[3].Value = DESC_LOG;

            param[4] = new SqlParameter("@DATE_LOG", SqlDbType.DateTime);
            param[4].Value = DATE_LOG;

            DAL.excutecommand("ADD_LOG", param);
            DAL.close();
        }

        public DataTable GET_ALL_MEMBER()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_MEMBER", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_MEM_BY_GATH_ID_FOR_EDIT(int GATH_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@GATH_ID", SqlDbType.Int);
            param[0].Value = GATH_ID;

            Dt = DAL.selectdata("GET_MEM_BY_GATH_ID_FOR_EDIT", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_FOLDER_BY_MEM_ID(string MEM_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@MEM_ID", SqlDbType.NVarChar);
            param[0].Value = MEM_ID;

            Dt = DAL.selectdata("GET_FOLDER_BY_MEM_ID", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_TABUR_SILAH_FOLDER_BY_ID(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar);
            param[0].Value = ID;

            Dt = DAL.selectdata("GET_TABUR_SILAH_FOLDER_BY_ID", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_MEM_FOR_EDIT(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            Dt = DAL.selectdata("GET_ALL_MEM_FOR_EDIT", param);
            DAL.close();
            return Dt;
        }

        public void EDIT_MEM(string MEM_IDEN,string  DB_CODE,string MEM_CARD_NUM,
            string CODE_NAME,string MEM_NAME,string MEM_FNAME,string MEM_LNAME,string MEM_MNAME
           ,DateTime MEM_BDATE,string MEM_BPLACE, string GENDER ,string NATIONALISM
           ,string SPECIAL_NOTES, string IMPORT_IDEN, int IS_DEL, string CERCUR_NUM
            , string CUBE_NUM, string RESAS_NUM, string BOMB_NUM, string ANOTHER_THINGS, string OWN_SILAH_NUM,string OWN_SILAH_DATA, string MEM_IDEN_NEW)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[23];
            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            param[1] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[1].Value = DB_CODE;

            param[2] = new SqlParameter("@MEM_CARD_NUM", SqlDbType.NVarChar);
            param[2].Value = MEM_CARD_NUM;

            param[3] = new SqlParameter("@CODE_NAME", SqlDbType.NVarChar);
            param[3].Value = CODE_NAME;

            param[4] = new SqlParameter("@MEM_NAME", SqlDbType.NVarChar);
            param[4].Value = MEM_NAME;

            param[5] = new SqlParameter("@MEM_FNAME", SqlDbType.NVarChar);
            param[5].Value = MEM_FNAME;

            param[6] = new SqlParameter("@MEM_LNAME", SqlDbType.NVarChar);
            param[6].Value = MEM_LNAME;

            param[7] = new SqlParameter("@MEM_MNAME", SqlDbType.NVarChar);
            param[7].Value = MEM_MNAME;

            param[8] = new SqlParameter("@MEM_BDATE", SqlDbType.Date);
            param[8].Value = MEM_BDATE;

            param[9] = new SqlParameter("@MEM_BPLACE", SqlDbType.NVarChar);
            param[9].Value = MEM_BPLACE;

            param[10] = new SqlParameter("@GENDER", SqlDbType.NVarChar);
            param[10].Value = GENDER;

            param[11] = new SqlParameter("@NATIONALISM", SqlDbType.NVarChar);
            param[11].Value = NATIONALISM;
            param[12] = new SqlParameter("@SPECIAL_NOTES", SqlDbType.NVarChar);
            param[12].Value = SPECIAL_NOTES;

            param[13] = new SqlParameter("@IMPORT_IDEN", SqlDbType.NVarChar);
            param[13].Value = IMPORT_IDEN;

            param[14] = new SqlParameter("@IS_DEL", SqlDbType.TinyInt);
            param[14].Value = IS_DEL;

            param[15] = new SqlParameter("@CERCUR_NUM", SqlDbType.NVarChar);
            param[15].Value = CERCUR_NUM;

            param[16] = new SqlParameter("@CUBE_NUM", SqlDbType.NVarChar);
            param[16].Value = CUBE_NUM;

            param[17] = new SqlParameter("@RESAS_NUM ", SqlDbType.NVarChar);
            param[17].Value = RESAS_NUM;

            param[18] = new SqlParameter("@BOMB_NUM", SqlDbType.NVarChar);
            param[18].Value = BOMB_NUM;

            param[19] = new SqlParameter("@ANOTHER_THINGS", SqlDbType.NVarChar);
            param[19].Value = ANOTHER_THINGS;

            param[20] = new SqlParameter("@OWN_SILAH_NUM", SqlDbType.NVarChar);
            param[20].Value = OWN_SILAH_NUM;

            param[21] = new SqlParameter("@OWN_SILAH_DATA", SqlDbType.NVarChar);
            param[21].Value = OWN_SILAH_DATA;

            param[22] = new SqlParameter("@MEM_IDEN_NEW", SqlDbType.NVarChar);
            param[22].Value = MEM_IDEN_NEW;

            DAL.excutecommand("EDIT_MEM", param);
            DAL.close();
        }

        public DataTable SEARCH_MEM(string SEARCH)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SEARCH", SqlDbType.NVarChar);
            param[0].Value = SEARCH;

            Dt = DAL.selectdata("SEARCH_MEM", param);
            DAL.close();
            return Dt;
        }

        public DataTable GET_MEM_BY_FORCE_IDEN(string FORCE_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@FORCE_IDEN", SqlDbType.NVarChar);
            param[0].Value = FORCE_IDEN;

            Dt = DAL.selectdata("GET_MEM_BY_FORCE_IDEN", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_MEM_BY_KTEBA_IDEN(string KTEBA_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@KTEBA_IDEN", SqlDbType.NVarChar);
            param[0].Value = KTEBA_IDEN;

            Dt = DAL.selectdata("GET_MEM_BY_KTEBA_IDEN", param);
            DAL.close();
            return Dt;
        }
        public void DELETE_MEM(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            DAL.excutecommand("DELETE_MEM", param);
            DAL.close();
        }

       

        public DataTable GET_ACTION_LOGS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ACTION_LOGS", null);
            DAL.close();
            return Dt;
        }

        public DataTable SEARCH_ACTION_LOGS(string SEARCH)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SEARCH", SqlDbType.NVarChar);
            param[0].Value = SEARCH;

            Dt = DAL.selectdata("SEARCH_ACTION_LOGS", param);
            DAL.close();
            return Dt;
        }
        public DataTable SEARCH_ACTION_LOGS_BETWEEN_2DATES(DateTime DTP1, DateTime DTP2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@DTP1", SqlDbType.Date);
            param[0].Value = DTP1;

            param[1] = new SqlParameter("@DTP2", SqlDbType.Date);
            param[1].Value = DTP2;

            Dt = DAL.selectdata("SEARCH_ACTION_LOGS_BETWEEN_2DATES", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_MEM_ROKHSA(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            Dt = DAL.selectdata("GET_MEM_ROKHSA", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_MEMBER_DETALIES(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            Dt = DAL.selectdata("GET_MEMBER_DETALIES", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_FROM_SETINNG()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_FROM_SETINNG", null);
            DAL.close();
            return Dt;
        }
        public void DELETE_FROM_GATH_BY_MEM_IDEN(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            DAL.excutecommand("DELETE_FROM_GATH_BY_MEM_IDEN", param);
            DAL.close();
        }
        public void DELETE_FROM_DOC_BY_MEM_IDEN(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            DAL.excutecommand("DELETE_FROM_DOC_BY_MEM_IDEN", param);
            DAL.close();
        }
 
 
        public DataTable GET_MEM_IMG_FOR_PRINT(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            Dt = DAL.selectdata("GET_MEM_IMG_FOR_PRINT", param);
            DAL.close();
            return Dt;
        }

        public DataTable GET_MEM_DETALIES_FOR_PRINT(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            Dt = DAL.selectdata("GET_MEM_DETALIES_FOR_PRINT", param);
            DAL.close();
            return Dt;
        }
        public void IMP_DELETE_FROM_GATH_BY_APP_IDEN_AND_MEM_IDEN(string IMPORT_IDEN, string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@IMPORT_IDEN", SqlDbType.NVarChar);
            param[0].Value = IMPORT_IDEN;

            param[1] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[1].Value = MEM_IDEN;

            DAL.excutecommand("IMP_DELETE_FROM_GATH_BY_APP_IDEN_AND_MEM_IDEN", param);
            DAL.close();
        }
      


        public DataTable SEARCH_GLOBAL(string MEM_IDEN,string MEM_CARD_NUM,
            string CODE_NAME, string MEM_NAME, string MEM_FNAME, string MEM_LNAME, string MEM_MNAME
           , DateTime MEM_BDATE, string MEM_BPLACE, DateTime REVOLUTION_DATE
           , string REVOLUTION_PLACE_JOIN, string RANK_MISSION, string TRAINING
           , string WAR_JURNY_DATE_PLACE, string HEALTH, string CIVILIAN, string GENDER
           , string STUDY, string UNIVERSITY, string LANGUAGES, string JOBS
           , DateTime ARMY_DATE, string ARMY_PLACE, string BLOOD
           , string ANOTHER_SOURCE, string ARREST, string PRO_SIS
           , string NATIONALISM, string CLAN, string FAMILY_REVOLUTION
           , string REVOLUTION_PLACE_OLD, string FAMILY_MARTYR, string ALHAMLAT
           , string FAMILY_STATUS, string ECO_STATUS, string NATIONAL_STATUS
           , string FAMILY_ADDRESS_NOW, string FAMILY_PHONE, string SPECIAL_NOTES,
            string SIGNS, string FORCE_IDEN, string KTEBA_IDEN,
            string PLACE_NOW, string MISSION_NOW, string EKHTSAS,
            string MEM_STATUS, string MEM_TYPE, DateTime ROW_DATE, string SELAH_NUM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[49];

            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            param[1] = new SqlParameter("@MEM_CARD_NUM", SqlDbType.NVarChar);
            param[1].Value = MEM_CARD_NUM;

            param[2] = new SqlParameter("@CODE_NAME", SqlDbType.NVarChar);
            param[2].Value = CODE_NAME;

            param[3] = new SqlParameter("@MEM_NAME", SqlDbType.NVarChar);
            param[3].Value = MEM_NAME;

            param[4] = new SqlParameter("@MEM_FNAME", SqlDbType.NVarChar);
            param[4].Value = MEM_FNAME;

            param[5] = new SqlParameter("@MEM_LNAME", SqlDbType.NVarChar);
            param[5].Value = MEM_LNAME;

            param[6] = new SqlParameter("@MEM_MNAME", SqlDbType.NVarChar);
            param[6].Value = MEM_MNAME;

            param[7] = new SqlParameter("@MEM_BDATE", SqlDbType.Date);
            param[7].Value = MEM_BDATE;

            param[8] = new SqlParameter("@MEM_BPLACE", SqlDbType.NVarChar);
            param[8].Value = MEM_BPLACE;

            param[9] = new SqlParameter("@REVOLUTION_DATE", SqlDbType.Date);
            param[9].Value = REVOLUTION_DATE;

            param[10] = new SqlParameter("@REVOLUTION_PLACE_JOIN", SqlDbType.NVarChar);
            param[10].Value = REVOLUTION_PLACE_JOIN;

            param[11] = new SqlParameter("@RANK_MISSION", SqlDbType.NVarChar);
            param[11].Value = RANK_MISSION;

            param[12] = new SqlParameter("@TRAINING", SqlDbType.NVarChar);
            param[12].Value = TRAINING;

            param[13] = new SqlParameter("@WAR_JURNY_DATE_PLACE", SqlDbType.NVarChar);
            param[13].Value = WAR_JURNY_DATE_PLACE;

            param[14] = new SqlParameter("@HEALTH", SqlDbType.NVarChar);
            param[14].Value = HEALTH;

            param[15] = new SqlParameter("@CIVILIAN", SqlDbType.NVarChar);
            param[15].Value = CIVILIAN;

            param[16] = new SqlParameter("@GENDER", SqlDbType.NVarChar);
            param[16].Value = GENDER;

            param[17] = new SqlParameter("@STUDY", SqlDbType.NVarChar);
            param[17].Value = STUDY;

            param[18] = new SqlParameter("@UNIVERSITY", SqlDbType.NVarChar);
            param[18].Value = UNIVERSITY;

            param[19] = new SqlParameter("@LANGUAGES", SqlDbType.NVarChar);
            param[19].Value = LANGUAGES;

            param[20] = new SqlParameter("@JOBS", SqlDbType.NVarChar);
            param[20].Value = JOBS;

            param[21] = new SqlParameter("@ARMY_DATE", SqlDbType.Date);
            param[21].Value = ARMY_DATE;

            param[22] = new SqlParameter("@ARMY_PLACE", SqlDbType.NVarChar);
            param[22].Value = ARMY_PLACE;

            param[23] = new SqlParameter("@BLOOD", SqlDbType.NVarChar);
            param[23].Value = BLOOD;

            param[24] = new SqlParameter("@ANOTHER_SOURCE", SqlDbType.NVarChar);
            param[24].Value = ANOTHER_SOURCE;

            param[25] = new SqlParameter("@ARREST", SqlDbType.NVarChar);
            param[25].Value = ARREST;

            param[26] = new SqlParameter("@PRO_SIS", SqlDbType.NVarChar);
            param[26].Value = PRO_SIS;

            param[27] = new SqlParameter("@NATIONALISM", SqlDbType.NVarChar);
            param[27].Value = NATIONALISM;

            param[28] = new SqlParameter("@CLAN", SqlDbType.NVarChar);
            param[28].Value = CLAN;

            param[29] = new SqlParameter("@FAMILY_REVOLUTION", SqlDbType.NVarChar);
            param[29].Value = FAMILY_REVOLUTION;

            param[30] = new SqlParameter("@REVOLUTION_PLACE_OLD", SqlDbType.NVarChar);
            param[30].Value = REVOLUTION_PLACE_OLD;

            param[31] = new SqlParameter("@FAMILY_MARTYR", SqlDbType.NVarChar);
            param[31].Value = FAMILY_MARTYR;

            param[32] = new SqlParameter("@ALHAMLAT", SqlDbType.NVarChar);
            param[32].Value = ALHAMLAT;

            param[33] = new SqlParameter("@FAMILY_STATUS", SqlDbType.NVarChar);
            param[33].Value = FAMILY_STATUS;

            param[34] = new SqlParameter("@ECO_STATUS", SqlDbType.NVarChar);
            param[34].Value = ECO_STATUS;

            param[35] = new SqlParameter("@NATIONAL_STATUS", SqlDbType.NVarChar);
            param[35].Value = NATIONAL_STATUS;

            param[36] = new SqlParameter("@FAMILY_ADDRESS_NOW", SqlDbType.NVarChar);
            param[36].Value = FAMILY_ADDRESS_NOW;

            param[37] = new SqlParameter("@FAMILY_PHONE", SqlDbType.NVarChar);
            param[37].Value = FAMILY_PHONE;

            param[38] = new SqlParameter("@SPECIAL_NOTES", SqlDbType.NVarChar);
            param[38].Value = SPECIAL_NOTES;

            param[39] = new SqlParameter("@SIGNS", SqlDbType.NVarChar);
            param[39].Value = SIGNS;

            param[40] = new SqlParameter("@FORCE_IDEN", SqlDbType.NVarChar);
            param[40].Value = FORCE_IDEN;

            param[41] = new SqlParameter("@KTEBA_IDEN", SqlDbType.NVarChar);
            param[41].Value = KTEBA_IDEN;

            param[42] = new SqlParameter("@PLACE_NOW", SqlDbType.NVarChar);
            param[42].Value = PLACE_NOW;

            param[43] = new SqlParameter("@MISSION_NOW", SqlDbType.NVarChar);
            param[43].Value = MISSION_NOW;

            param[44] = new SqlParameter("@EKHTSAS", SqlDbType.NVarChar);
            param[44].Value = EKHTSAS;

            param[45] = new SqlParameter("@MEM_STATUS", SqlDbType.NVarChar);
            param[45].Value = MEM_STATUS;

            param[46] = new SqlParameter("@MEM_TYPE", SqlDbType.NVarChar);
            param[46].Value = MEM_TYPE;

            param[47] = new SqlParameter("@ROW_DATE", SqlDbType.Date);
            param[47].Value = ROW_DATE;

            param[48] = new SqlParameter("@SELAH_NUM", SqlDbType.NVarChar);
            param[48].Value = SELAH_NUM;

            Dt = DAL.selectdata("SEARCH_GLOBAL", param);
            DAL.close();
            return Dt;
        }

        public DataTable SEARCH_GLOBAL_BY_NAMES(string MEM_NAME,
                                       string MEM_FNAME, string MEM_LNAME, string MEM_MNAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@MEM_NAME", SqlDbType.NVarChar);
            param[0].Value = MEM_NAME;

            param[1] = new SqlParameter("@MEM_FNAME", SqlDbType.NVarChar);
            param[1].Value = MEM_FNAME;

            param[2] = new SqlParameter("@MEM_LNAME", SqlDbType.NVarChar);
            param[2].Value = MEM_LNAME;

            param[3] = new SqlParameter("@MEM_MNAME", SqlDbType.NVarChar);
            param[3].Value = MEM_MNAME;

            Dt = DAL.selectdata("SEARCH_GLOBAL_BY_NAMES", param);
            DAL.close();
            return Dt;
        }

        public DataTable SEARCH_GLOBAL_BY_MEM_IDEN(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            Dt = DAL.selectdata("SEARCH_GLOBAL_BY_MEM_IDEN", param);
            DAL.close();
            return Dt;
        }
     

        public DataTable GET_ALL_MEMBER_FOR_ADVANCE_SEARCH()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_MEMBER_FOR_ADVANCE_SEARCH", null);
            DAL.close();
            return Dt;
        }
        public DataTable SEARCH_GLOBAL_ADVANCE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("SEARCH_GLOBAL_ADVANCE", null);
            DAL.close();
            return Dt;
        }
        public DataTable SEARCH_RATE(string MEM_NAME,
                                       string MEM_FNAME, string MEM_LNAME, string MEM_MNAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@MEM_NAME", SqlDbType.NVarChar);
            param[0].Value = MEM_NAME;

            param[1] = new SqlParameter("@MEM_FNAME", SqlDbType.NVarChar);
            param[1].Value = MEM_FNAME;

            param[2] = new SqlParameter("@MEM_LNAME", SqlDbType.NVarChar);
            param[2].Value = MEM_LNAME;

            param[3] = new SqlParameter("@MEM_MNAME", SqlDbType.NVarChar);
            param[3].Value = MEM_MNAME;

            Dt = DAL.selectdata("SEARCH_RATE", param);
            DAL.close();
            return Dt;
        }

        public void ADD_SETTING(string APP_IDEN, string SERVER_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@APP_IDEN", SqlDbType.NVarChar);
            param[0].Value = APP_IDEN;

            param[1] = new SqlParameter("@SERVER_NAME", SqlDbType.NVarChar);
            param[1].Value = SERVER_NAME;

            DAL.excutecommand("ADD_SETTING", param);
            DAL.close();
        }
        public void EDIT_SETTING(string APP_IDEN, string SERVER_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@APP_IDEN", SqlDbType.NVarChar);
            param[0].Value = APP_IDEN;

            param[1] = new SqlParameter("@SERVER_NAME", SqlDbType.NVarChar);
            param[1].Value = SERVER_NAME;

            DAL.excutecommand("EDIT_SETTING", param);
            DAL.close();
        }
        public DataTable GET_SETTING()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_SETTING", null);
            DAL.close();
            return Dt;
        }

      
    }
}
