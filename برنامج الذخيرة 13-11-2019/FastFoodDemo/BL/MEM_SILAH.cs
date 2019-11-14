using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace FastFoodDemo.BL
{
    class MEM_SILAH
    {


        public DataTable GET_MAX_MEM_SILAH_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_MAX_MEM_SILAH_ID", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_MEM_SILAH(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            Dt = DAL.selectdata("GET_ALL_MEM_SILAH", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_MEM_SILAH(string MEM_IDEN, string SATAUS)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            param[1] = new SqlParameter("@SATAUS", SqlDbType.NVarChar);
            param[1].Value = SATAUS;
            Dt = DAL.selectdata("GET_MEM_SILAH", param);
            DAL.close();
            return Dt;
        }
        public void ADD_MEM_SILAH(string CODE, string DB_CODE, string MEM_ID,
                                     string SILAH_CODE, string CAT_SILAH_NAME, string SILAH_MODEL, byte[] FILE,
                                     string EX, int ISDEL ,string CAT_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            param[1] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[1].Value = DB_CODE;

            param[2] = new SqlParameter("@MEM_ID", SqlDbType.NVarChar);
            param[2].Value = MEM_ID;

            param[3] = new SqlParameter("@SILAH_CODE", SqlDbType.NVarChar);
            param[3].Value = SILAH_CODE;

            param[4] = new SqlParameter("@CAT_SILAH_NAME", SqlDbType.NVarChar);
            param[4].Value = CAT_SILAH_NAME;

            param[5] = new SqlParameter("@SILAH_MODEL", SqlDbType.NVarChar);
            param[5].Value = SILAH_MODEL;

            param[6] = new SqlParameter("@FILE", SqlDbType.VarBinary);
            param[6].Value = FILE;

            param[7] = new SqlParameter("@EX", SqlDbType.NChar);
            param[7].Value = EX;

            param[8] = new SqlParameter("@ISDEL", SqlDbType.Int);
            param[8].Value = ISDEL;

            param[9] = new SqlParameter("@CAT_NAME", SqlDbType.NVarChar);
            param[9].Value = CAT_NAME;

            DAL.excutecommand("ADD_MEM_SILAH", param);
            DAL.close();

        }

        public void ADD_MEM_SILAH_WITHOUT_FILE(string CODE, string DB_CODE, string MEM_ID, string SILAH_CODE,
            string CAT_SILAH_NAME, string SILAH_MODEL, int ISDEL, string CAT_NAME, string SILAH_NUM, string STATUS)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            param[1] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[1].Value = DB_CODE;

            param[2] = new SqlParameter("@MEM_ID", SqlDbType.NVarChar);
            param[2].Value = MEM_ID;

            param[3] = new SqlParameter("@SILAH_CODE", SqlDbType.NVarChar);
            param[3].Value = SILAH_CODE;

            param[4] = new SqlParameter("@CAT_SILAH_NAME", SqlDbType.NVarChar);
            param[4].Value = CAT_SILAH_NAME;

            param[5] = new SqlParameter("@SILAH_MODEL", SqlDbType.NVarChar);
            param[5].Value = SILAH_MODEL;

            param[6] = new SqlParameter("@ISDEL", SqlDbType.Int);
            param[6].Value = ISDEL;

            param[7] = new SqlParameter("@CAT_NAME", SqlDbType.NVarChar);
            param[7].Value = CAT_NAME;

            param[8] = new SqlParameter("@SILAH_NUM", SqlDbType.NVarChar);
            param[8].Value = SILAH_NUM;

            param[9] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
            param[9].Value = STATUS;

            DAL.excutecommand("ADD_MEM_SILAH_WITHOUT_FILE", param);
            DAL.close();

        }

        public void CHANGE_MEM_SILAH(string MEM_ID, string STATUS)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
 
            param[0] = new SqlParameter("@MEM_ID", SqlDbType.NVarChar);
            param[0].Value = MEM_ID;

             param[1] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
             param[1].Value = STATUS;
       
            DAL.excutecommand("CHANGE_MEM_SILAH", param);
            DAL.close();

        }
        public void DELETE_MEM_SILAH(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            DAL.excutecommand("DELETE_MEM_SILAH", param);
            DAL.close();

        }
        public void EDIT_MEM_SILAH(string CODE, string DB_CODE, string MEM_ID, string SILAH_CODE,
           string CAT_SILAH_NAME, string SILAH_MODEL, int ISDEL, string CAT_NAME, string SILAH_NUM, string MEM_NEW_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            param[1] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar);
            param[1].Value = DB_CODE;

            param[2] = new SqlParameter("@MEM_ID", SqlDbType.NVarChar);
            param[2].Value = MEM_ID;

            param[3] = new SqlParameter("@SILAH_CODE", SqlDbType.NVarChar);
            param[3].Value = SILAH_CODE;

            param[4] = new SqlParameter("@CAT_SILAH_NAME", SqlDbType.NVarChar);
            param[4].Value = CAT_SILAH_NAME;

            param[5] = new SqlParameter("@SILAH_MODEL", SqlDbType.NVarChar);
            param[5].Value = SILAH_MODEL;

            param[6] = new SqlParameter("@CAT_NAME", SqlDbType.NVarChar);
            param[6].Value = CAT_NAME;

            param[7] = new SqlParameter("@SILAH_NUM", SqlDbType.NVarChar);
            param[7].Value = SILAH_NUM;

            param[8] = new SqlParameter("@MEM_NEW_ID", SqlDbType.NVarChar);
            param[8].Value = MEM_NEW_ID;

            DAL.excutecommand("EDIT_MEM_SILAH", param);
            DAL.close();

        }
        public DataTable GET_FIGHETR_TO_CHECHED_FOR_ADD()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_FIGHETR_TO_CHECHED_FOR_ADD", null);
            DAL.close();
            return Dt;
        }

        public DataTable GET_FIGHTER_MAX_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_FIGHTER_MAX_ID", null);
            DAL.close();
            return Dt;
        }
        public void ADD_TO_FIGHTER_SILAH(string DB_CODE, string TABUR_CODE, string SILAH_CODE, string FIGHTER_CODE,
                                           int CERCOR_NUM, int BULLETS, int QUIVER_NUM, int BOMB_NUM, string ANOTHER_THINGS)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@DB_CODE", SqlDbType.NVarChar, 20);
            param[0].Value = DB_CODE;

            param[1] = new SqlParameter("@TABUR_CODE", SqlDbType.NVarChar, 20);
            param[1].Value = TABUR_CODE;

            param[2] = new SqlParameter("@SILAH_CODE", SqlDbType.NVarChar, 20);
            param[2].Value = SILAH_CODE;

            param[3] = new SqlParameter("@FIGHTER_CODE", SqlDbType.NVarChar, 20);
            param[3].Value = FIGHTER_CODE;

            param[4] = new SqlParameter("@CERCOR_NUM", SqlDbType.Int);
            param[4].Value = CERCOR_NUM;

            param[5] = new SqlParameter("@BULLETS", SqlDbType.Int);
            param[5].Value = BULLETS;

            param[6] = new SqlParameter("@QUIVER_NUM", SqlDbType.Int);
            param[6].Value = QUIVER_NUM;

            param[7] = new SqlParameter("@BOMB_NUM", SqlDbType.Int);
            param[7].Value = BOMB_NUM;

            param[8] = new SqlParameter("@ANOTHER_THINGS", SqlDbType.NVarChar, 250);
            param[8].Value = ANOTHER_THINGS;

            DAL.excutecommand("ADD_TO_FIGHTER_SILAH", param);
            DAL.close();

        }

        public void EDIT_FIGHTER_INFO( string FIGHTER_CODE, string NICK_NAME,
                                    string FIRST_NAME, string FATHER_NAME, string MOTHER_NAME, DateTime BIRTHDATE,
                                    string BIRTHLOCATED, string CURRENT_ADDRESS, string TASKE, DateTime DATE_OF_ENROLLMENT,
                                    string GENDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[11];       

            param[0] = new SqlParameter("@FIGHTER_CODE", SqlDbType.NVarChar, 20);
            param[0].Value = FIGHTER_CODE;

            param[1] = new SqlParameter("@NICK_NAME", SqlDbType.NVarChar, 20);
            param[1].Value = NICK_NAME;

            param[2] = new SqlParameter("@FIRST_NAME", SqlDbType.NVarChar, 30);
            param[2].Value = FIRST_NAME;

            param[3] = new SqlParameter("@FATHER_NAME", SqlDbType.NVarChar, 30);
            param[3].Value = FATHER_NAME;

            param[4] = new SqlParameter("@MOTHER_NAME", SqlDbType.NVarChar, 30);
            param[4].Value = MOTHER_NAME;

            param[5] = new SqlParameter("@BIRTHDATE", SqlDbType.Date);
            param[5].Value = BIRTHDATE;

            param[6] = new SqlParameter("@BIRTHLOCATED", SqlDbType.NVarChar, 30);
            param[6].Value = BIRTHLOCATED;

            param[7] = new SqlParameter("@CURRENT_ADDRESS", SqlDbType.NVarChar, 50);
            param[7].Value = CURRENT_ADDRESS;

            param[8] = new SqlParameter("@TASKE", SqlDbType.NVarChar, 250);
            param[8].Value = TASKE;

            param[9] = new SqlParameter("@DATE_OF_ENROLLMENT", SqlDbType.Date);
            param[9].Value = DATE_OF_ENROLLMENT;

            param[10] = new SqlParameter("@GENDER", SqlDbType.NVarChar, 10);
            param[10].Value = GENDER;

            DAL.excutecommand("EDIT_FIGHTER_INFO", param);
            DAL.close();

        }

        public void EDIT_FIGHTER_INFO_IN_FIGHTER_SILAH(string TABUR_CODE, string SILAH_CODE, string FIGHTER_CODE,
                                           int CERCOR_NUM, int BULLETS, int QUIVER_NUM, int BOMB_NUM, string ANOTHER_THINGS)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[8];
           
            param[0] = new SqlParameter("@TABUR_CODE", SqlDbType.NVarChar, 20);
            param[0].Value = TABUR_CODE;

            param[1] = new SqlParameter("@SILAH_CODE", SqlDbType.NVarChar, 20);
            param[1].Value = SILAH_CODE;

            param[2] = new SqlParameter("@FIGHTER_CODE", SqlDbType.NVarChar, 20);
            param[2].Value = FIGHTER_CODE;

            param[3] = new SqlParameter("@CERCOR_NUM", SqlDbType.Int);
            param[3].Value = CERCOR_NUM;

            param[4] = new SqlParameter("@BULLETS", SqlDbType.Int);
            param[4].Value = BULLETS;

            param[5] = new SqlParameter("@QUIVER_NUM", SqlDbType.Int);
            param[5].Value = QUIVER_NUM;

            param[6] = new SqlParameter("@BOMB_NUM", SqlDbType.Int);
            param[6].Value = BOMB_NUM;

            param[7] = new SqlParameter("@ANOTHER_THINGS", SqlDbType.NVarChar, 250);
            param[7].Value = ANOTHER_THINGS;

            DAL.excutecommand("EDIT_FIGHTER_INFO_IN_FIGHTER_SILAH", param);
            DAL.close();

        }
        public void DELETE_FIGHTER(string FHGHTER_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@FHGHTER_CODE", SqlDbType.NVarChar, 20);
            param[0].Value = FHGHTER_CODE;

            DAL.excutecommand("DELETE_FIGHTER", param);
            DAL.close();

        }

        public DataTable SEARCH_TABUR(string SEARCH)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SEARCH", SqlDbType.NVarChar, 20);
            param[0].Value = SEARCH;

            Dt = DAL.selectdata("SEARCH_TABUR", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_TABUR_FIGHTER_BY_TABUR_CODE(string TABUR_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@TABUR_CODE", SqlDbType.NVarChar, 20);
            param[0].Value = TABUR_CODE;

            Dt = DAL.selectdata("GET_TABUR_FIGHTER_BY_TABUR_CODE", param);
            DAL.close();
            return Dt;
        }

        public DataTable GET_ALL_FIGHTERS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_FIGHTERS", null);
            DAL.close();
            return Dt;
        }
    }
}
