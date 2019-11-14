using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FastFoodDemo.BL
{
    class USERS_CLS
    {
        public void ADD_USER(string APP_IDEN, string USER_FULL_NAME, string USER_NAME,
            string PASSWORD, int BASIC
           , int BCKP, int RESTR, int USRS, int MYPROFILE
           , int ACTIONS, int ADDMEM, int MEMMNG, int IQLIM
           , int MNTKA, int LOAA, int FAOJ, int KTEBA
           , int FORCE, int EX,
            int IMP, int DELETED, int REPORT, int REPORT2,
            int SOURCES, int ALGHANAEM, int MUSADRA, int ORDERS, int CATEGRY, 
            int IMP_EXP_SILAH, int SILAH_WARE,  int ISDELETED ,int SILAH)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[32];
            param[0] = new SqlParameter("@APP_IDEN", SqlDbType.NVarChar);
            param[0].Value = APP_IDEN;

            param[1] = new SqlParameter("@USER_FULL_NAME", SqlDbType.NVarChar);
            param[1].Value = USER_FULL_NAME;

            param[2] = new SqlParameter("@USER_NAME", SqlDbType.NVarChar);
            param[2].Value = USER_NAME;

            param[3] = new SqlParameter("@BASIC", SqlDbType.Int);
            param[3].Value = BASIC;

            param[4] = new SqlParameter("@BCKP", SqlDbType.Int);
            param[4].Value = BCKP;

            param[5] = new SqlParameter("@RESTR", SqlDbType.Int);
            param[5].Value = RESTR;

            param[6] = new SqlParameter("@USRS", SqlDbType.Int);
            param[6].Value = USRS;

            param[7] = new SqlParameter("@MYPROFILE", SqlDbType.Int);
            param[7].Value = MYPROFILE;

            param[8] = new SqlParameter("@ACTIONS", SqlDbType.Int);
            param[8].Value = ACTIONS;

            param[9] = new SqlParameter("@ADDMEM", SqlDbType.Int);
            param[9].Value = ADDMEM;

            param[10] = new SqlParameter("@MEMMNG", SqlDbType.Int);
            param[10].Value = MEMMNG;

            param[11] = new SqlParameter("@IQLIM", SqlDbType.Int);
            param[11].Value = IQLIM;

            param[12] = new SqlParameter("@MNTKA", SqlDbType.Int);
            param[12].Value = MNTKA;

            param[13] = new SqlParameter("@LOAA", SqlDbType.Int);
            param[13].Value = LOAA;

            param[14] = new SqlParameter("@FAOJ", SqlDbType.Int);
            param[14].Value = FAOJ;

            param[15] = new SqlParameter("@KTEBA", SqlDbType.Int);
            param[15].Value = KTEBA;

            param[16] = new SqlParameter("@FORCE", SqlDbType.Int);
            param[16].Value = FORCE;

            param[17] = new SqlParameter("@EX", SqlDbType.Int);
            param[17].Value = EX;

            param[18] = new SqlParameter("@IMP", SqlDbType.Int);
            param[18].Value = IMP;

            param[19] = new SqlParameter("@DELETED", SqlDbType.Int);
            param[19].Value = DELETED;

            param[20] = new SqlParameter("@REPORT", SqlDbType.Int);
            param[20].Value = REPORT;

            param[21] = new SqlParameter("@REPORT2", SqlDbType.Int);
            param[21].Value = REPORT2;

            param[22] = new SqlParameter("@SOURCES", SqlDbType.Int);
            param[22].Value = SOURCES;

            param[23] = new SqlParameter("@ALGHANAEM", SqlDbType.Int);
            param[23].Value = ALGHANAEM;

            param[24] = new SqlParameter("@MUSADRA", SqlDbType.Int);
            param[24].Value = MUSADRA;

            param[25] = new SqlParameter("@ORDERS", SqlDbType.Int);
            param[25].Value = ORDERS;

            param[26] = new SqlParameter("@CATEGRY", SqlDbType.Int);
            param[26].Value = CATEGRY;

            param[27] = new SqlParameter("@IMP_EXP_SILAH", SqlDbType.Int);
            param[27].Value = IMP_EXP_SILAH;

            param[28] = new SqlParameter("@SILAH_WARE", SqlDbType.Int);
            param[28].Value = SILAH_WARE;

            param[29] = new SqlParameter("@ISDELETED", SqlDbType.Int);
            param[29].Value = ISDELETED;
            param[30] = new SqlParameter("@PASSWORD", SqlDbType.NVarChar);
            param[30].Value = PASSWORD;
            param[31] = new SqlParameter("@SILAH", SqlDbType.Int);
            param[31].Value = SILAH;
            DAL.excutecommand("ADD_USER", param);
            DAL.close();
        }

        public DataTable GET_ALL_USERS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_USERS", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_USER_FOR_EDIT(int USER_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@USER_ID", SqlDbType.Int);
            param[0].Value = USER_ID;

            Dt = DAL.selectdata("GET_ALL_USER_FOR_EDIT", param);
            DAL.close();
            return Dt;
        }

        public void EDIIT_USER( int BASIC
           , int BCKP, int RESTR, int USRS, int MYPROFILE
           , int ACTIONS, int ADDMEM, int MEMMNG, int IQLIM
           , int MNTKA, int LOAA, int FAOJ, int KTEBA
           , int FORCE, int EX,
            int IMP, int DELETED, int REPORT, int REPORT2,
            int SOURCES, int ALGHANAEM, int MUSADRA, int ORDERS, int CATEGRY, int IMP_EXP_SILAH, int SILAH_WARE, int ID, int SILAH)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[28];
            param[0] = new SqlParameter("@BASIC", SqlDbType.Int);
            param[0].Value = BASIC;

            param[1] = new SqlParameter("@BCKP", SqlDbType.Int);
            param[1].Value = BCKP;

            param[2] = new SqlParameter("@RESTR", SqlDbType.Int);
            param[2].Value = RESTR;

            param[3] = new SqlParameter("@USRS", SqlDbType.Int);
            param[3].Value = USRS;

            param[4] = new SqlParameter("@MYPROFILE", SqlDbType.Int);
            param[4].Value = MYPROFILE;

            param[5] = new SqlParameter("@ACTIONS", SqlDbType.Int);
            param[5].Value = ACTIONS;

            param[6] = new SqlParameter("@ADDMEM", SqlDbType.Int);
            param[6].Value = ADDMEM;

            param[7] = new SqlParameter("@MEMMNG", SqlDbType.Int);
            param[7].Value = MEMMNG;

            param[8] = new SqlParameter("@IQLIM", SqlDbType.Int);
            param[8].Value = IQLIM;

            param[9] = new SqlParameter("@MNTKA", SqlDbType.Int);
            param[9].Value = MNTKA;

            param[10] = new SqlParameter("@LOAA", SqlDbType.Int);
            param[10].Value = LOAA;

            param[11] = new SqlParameter("@FAOJ", SqlDbType.Int);
            param[11].Value = FAOJ;

            param[12] = new SqlParameter("@KTEBA", SqlDbType.Int);
            param[12].Value = KTEBA;

            param[13] = new SqlParameter("@FORCE", SqlDbType.Int);
            param[13].Value = FORCE;

            param[14] = new SqlParameter("@EX", SqlDbType.Int);
            param[14].Value = EX;

            param[15] = new SqlParameter("@IMP", SqlDbType.Int);
            param[15].Value = IMP;

            param[16] = new SqlParameter("@DELETED", SqlDbType.Int);
            param[16].Value = DELETED;

            param[17] = new SqlParameter("@REPORT", SqlDbType.Int);
            param[17].Value = REPORT;

            param[18] = new SqlParameter("@REPORT2", SqlDbType.Int);
            param[18].Value = REPORT2;

            param[19] = new SqlParameter("@SOURCES", SqlDbType.Int);
            param[19].Value = SOURCES;

            param[20] = new SqlParameter("@ALGHANAEM", SqlDbType.Int);
            param[20].Value = ALGHANAEM;

            param[21] = new SqlParameter("@MUSADRA", SqlDbType.Int);
            param[21].Value = MUSADRA;

            param[22] = new SqlParameter("@ORDERS", SqlDbType.Int);
            param[22].Value = ORDERS;

            param[23] = new SqlParameter("@CATEGRY", SqlDbType.Int);
            param[23].Value = CATEGRY;

            param[24] = new SqlParameter("@IMP_EXP_SILAH", SqlDbType.Int);
            param[24].Value = IMP_EXP_SILAH;

            param[25] = new SqlParameter("@SILAH_WARE", SqlDbType.Int);
            param[25].Value = SILAH_WARE;

            param[26] = new SqlParameter("@ID", SqlDbType.Int);
            param[26].Value = ID;

            param[27] = new SqlParameter("@SILAH", SqlDbType.Int);
            param[27].Value = SILAH;
            DAL.excutecommand("EDIIT_USER", param);
            DAL.close();
        }

        public void DELETE_USER(int USER_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@USER_ID", SqlDbType.Int);
            param[0].Value = USER_ID;

            DAL.excutecommand("DELETE_USER", param);
            DAL.close();
        }

        public void EDIT_PROFILE(string USER_FULL_NAME, string USER_NAME, string PASSWORD, int USER_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@USER_FULL_NAME", SqlDbType.NVarChar);
            param[0].Value = USER_FULL_NAME;

            param[1] = new SqlParameter("@USER_NAME", SqlDbType.NVarChar);
            param[1].Value = USER_NAME;

            param[2] = new SqlParameter("@PASSWORD", SqlDbType.NVarChar);
            param[2].Value = PASSWORD;

            param[3] = new SqlParameter("@USER_ID", SqlDbType.Int);
            param[3].Value = USER_ID;

            DAL.excutecommand("EDIT_PROFILE", param);
            DAL.close();
        }

        public DataTable GET_USERS_FOR_LOGIN(string USER_NAME, string PASSWORD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@USER_NAME", SqlDbType.NVarChar);
            param[0].Value = USER_NAME;

            param[1] = new SqlParameter("@PASSWORD", SqlDbType.NVarChar);
            param[1].Value = PASSWORD;

            Dt = DAL.selectdata("GET_USERS_FOR_LOGIN", param);
            DAL.close();
            return Dt;
        }
    }
}
