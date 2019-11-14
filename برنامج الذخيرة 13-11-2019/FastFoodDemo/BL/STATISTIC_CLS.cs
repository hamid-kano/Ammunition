using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FastFoodDemo.BL
{
    class STATISTIC_CLS
    {
        public DataTable GET_MEMBER_BY_HEREM_CODE(string HEREM_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@HEREM_CODE", SqlDbType.NVarChar);
            param[0].Value = HEREM_CODE;

            Dt = DAL.selectdata("GET_MEMBER_BY_HEREM_CODE", param);
            DAL.close();
            return Dt;
        }

        public DataTable GET_MEMBER_BY_EYALET_CODE(string EYALET_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@EYALET_CODE", SqlDbType.NVarChar);
            param[0].Value = EYALET_CODE;

            Dt = DAL.selectdata("GET_MEMBER_BY_EYALET_CODE", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_MEMBER_BY_TUGAY_CODE(string TUGAY_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@TUGAY_CODE", SqlDbType.NVarChar);
            param[0].Value = TUGAY_CODE;

            Dt = DAL.selectdata("GET_MEMBER_BY_TUGAY_CODE", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_MEMBER_BY_ALAY_CODE(string ALAY_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ALAY_CODE", SqlDbType.NVarChar);
            param[0].Value = ALAY_CODE;

            Dt = DAL.selectdata("GET_MEMBER_BY_ALAY_CODE", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_MEMBER_BY_TABUR_CODE(string TABUR_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@TABUR_CODE", SqlDbType.NVarChar);
            param[0].Value = TABUR_CODE;

            Dt = DAL.selectdata("GET_MEMBER_BY_TABUR_CODE", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_MEMBER_BY_FORCE_CODE(string FORCE_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@FORCE_CODE", SqlDbType.NVarChar);
            param[0].Value = FORCE_CODE;

            Dt = DAL.selectdata("GET_MEMBER_BY_FORCE_CODE", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_FROM_IMP_EXP_FOR_STATISTICS(string TYPE, DateTime DATE1, DateTime DATE2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@TYPE", SqlDbType.NVarChar);
            param[0].Value = TYPE;

            param[1] = new SqlParameter("@DATE1", SqlDbType.Date);
            param[1].Value = DATE1;

            param[2] = new SqlParameter("@DATE2", SqlDbType.Date);
            param[2].Value = DATE2;

            Dt = DAL.selectdata("GET_FROM_IMP_EXP_FOR_STATISTICS", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_FROM_IMP_EXP_BY_CAT_SILAH_FOR_STATISTICS(string TYPE, DateTime DATE1, DateTime DATE2,string NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@TYPE", SqlDbType.NVarChar);
            param[0].Value = TYPE;

            param[1] = new SqlParameter("@DATE1", SqlDbType.Date);
            param[1].Value = DATE1;

            param[2] = new SqlParameter("@DATE2", SqlDbType.Date);
            param[2].Value = DATE2;

            param[3] = new SqlParameter("@NAME", SqlDbType.NVarChar);
            param[3].Value = NAME;

            Dt = DAL.selectdata("GET_FROM_IMP_EXP_BY_CAT_SILAH_FOR_STATISTICS", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_FROM_IMP_EXP_BY_SILAH_NAME_FOR_STATISTICS(string TYPE, DateTime DATE1, DateTime DATE2, string NAME, string SILAH_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@TYPE", SqlDbType.NVarChar);
            param[0].Value = TYPE;

            param[1] = new SqlParameter("@DATE1", SqlDbType.Date);
            param[1].Value = DATE1;

            param[2] = new SqlParameter("@DATE2", SqlDbType.Date);
            param[2].Value = DATE2;

            param[3] = new SqlParameter("@NAME", SqlDbType.NVarChar);
            param[3].Value = NAME;

            param[4] = new SqlParameter("@SILAH_NAME", SqlDbType.NVarChar);
            param[4].Value = SILAH_NAME;
            Dt = DAL.selectdata("GET_FROM_IMP_EXP_BY_SILAH_NAME_FOR_STATISTICS", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_WAREHOUSE_SILAH_FOR_STATISTICS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_WAREHOUSE_SILAH_FOR_STATISTICS", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_WAREHOUSE_CAT_SILAH_FOR_STATISTICS(string NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@NAME", SqlDbType.NVarChar);
            param[0].Value = NAME;

            Dt = DAL.selectdata("GET_ALL_WAREHOUSE_CAT_SILAH_FOR_STATISTICS", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_WAREHOUSE_CAT_SILAH_NAME_FOR_STATISTICS(string NAME, string SILAH_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@NAME", SqlDbType.NVarChar);
            param[0].Value = NAME;

            param[1] = new SqlParameter("@SILAH_NAME", SqlDbType.NVarChar);
            param[1].Value = SILAH_NAME;

            Dt = DAL.selectdata("GET_ALL_WAREHOUSE_CAT_SILAH_NAME_FOR_STATISTICS", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_IQLIM_BY_GENDER(string IQLIM_IDEN, string GENDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@IQLIM_IDEN", SqlDbType.NVarChar);
            param[0].Value = IQLIM_IDEN;

            param[1] = new SqlParameter("@GENDER", SqlDbType.NVarChar);
            param[1].Value = GENDER;

            Dt = DAL.selectdata("STA_MEM_IN_IQLIM_BY_GENDER", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_IQLIM_BY_UNIVERSITY(string IQLIM_IDEN, string UNIVERSITY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@IQLIM_IDEN", SqlDbType.NVarChar);
            param[0].Value = IQLIM_IDEN;

            param[1] = new SqlParameter("@UNIVERSITY", SqlDbType.NVarChar);
            param[1].Value = UNIVERSITY;

            Dt = DAL.selectdata("STA_MEM_IN_IQLIM_BY_UNIVERSITY", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_IQLIM_BY_STUDY(string IQLIM_IDEN, string STUDY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@IQLIM_IDEN", SqlDbType.NVarChar);
            param[0].Value = IQLIM_IDEN;

            param[1] = new SqlParameter("@STUDY", SqlDbType.NVarChar);
            param[1].Value = STUDY;

            Dt = DAL.selectdata("STA_MEM_IN_IQLIM_BY_STUDY", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_IQLIM_BY_STATUS(string IQLIM_IDEN, string MEM_STATUS,
            DateTime DTP1, DateTime DTP2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@IQLIM_IDEN", SqlDbType.NVarChar);
            param[0].Value = IQLIM_IDEN;

            param[1] = new SqlParameter("@MEM_STATUS", SqlDbType.NVarChar);
            param[1].Value = MEM_STATUS;

            param[2] = new SqlParameter("@DTP1", SqlDbType.Date);
            param[2].Value = DTP1;

            param[3] = new SqlParameter("@DTP2", SqlDbType.Date);
            param[3].Value = DTP2;

            Dt = DAL.selectdata("STA_MEM_IN_IQLIM_BY_STATUS", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_IQLIM_BY_MEM_TYPE(string IQLIM_IDEN, string MEM_TYPE,
           DateTime DTP1, DateTime DTP2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@IQLIM_IDEN", SqlDbType.NVarChar);
            param[0].Value = IQLIM_IDEN;

            param[1] = new SqlParameter("@MEM_TYPE", SqlDbType.NVarChar);
            param[1].Value = MEM_TYPE;

            param[2] = new SqlParameter("@DTP1", SqlDbType.Date);
            param[2].Value = DTP1;

            param[3] = new SqlParameter("@DTP2", SqlDbType.Date);
            param[3].Value = DTP2;

            Dt = DAL.selectdata("STA_MEM_IN_IQLIM_BY_MEM_TYPE", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_ALL_MEM_IN_MNTKA(string MANTKA_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@MANTKA_IDEN", SqlDbType.NVarChar);
            param[0].Value = MANTKA_IDEN;

            Dt = DAL.selectdata("STA_ALL_MEM_IN_MNTKA", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_MNTKA_BY_BLOOD(string MANTKA_IDEN, string BLOOD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@MANTKA_IDEN", SqlDbType.NVarChar);
            param[0].Value = MANTKA_IDEN;

            param[1] = new SqlParameter("@BLOOD", SqlDbType.NVarChar);
            param[1].Value = BLOOD;

            Dt = DAL.selectdata("STA_MEM_IN_MNTKA_BY_BLOOD", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_MNTKA_BY_CIVILIAN(string MANTKA_IDEN, string CIVILIAN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@MANTKA_IDEN", SqlDbType.NVarChar);
            param[0].Value = MANTKA_IDEN;

            param[1] = new SqlParameter("@CIVILIAN", SqlDbType.NVarChar);
            param[1].Value = CIVILIAN;

            Dt = DAL.selectdata("STA_MEM_IN_MNTKA_BY_CIVILIAN", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_MNTKA_BY_GENDER(string MANTKA_IDEN, string GENDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@MANTKA_IDEN", SqlDbType.NVarChar);
            param[0].Value = MANTKA_IDEN;

            param[1] = new SqlParameter("@GENDER", SqlDbType.NVarChar);
            param[1].Value = GENDER;

            Dt = DAL.selectdata("STA_MEM_IN_MNTKA_BY_GENDER", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_MNTKA_BY_UNIVERSITY(string MANTKA_IDEN, string UNIVERSITY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@MANTKA_IDEN", SqlDbType.NVarChar);
            param[0].Value = MANTKA_IDEN;

            param[1] = new SqlParameter("@UNIVERSITY", SqlDbType.NVarChar);
            param[1].Value = UNIVERSITY;

            Dt = DAL.selectdata("STA_MEM_IN_MNTKA_BY_UNIVERSITY", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_MNTKA_BY_STUDY(string MANTKA_IDEN, string STUDY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@MANTKA_IDEN", SqlDbType.NVarChar);
            param[0].Value = MANTKA_IDEN;

            param[1] = new SqlParameter("@STUDY", SqlDbType.NVarChar);
            param[1].Value = STUDY;

            Dt = DAL.selectdata("STA_MEM_IN_MNTKA_BY_STUDY", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_MNTKA_BY_STATUS(string MANTKA_IDEN, string MEM_STATUS,
        DateTime DTP1, DateTime DTP2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@MANTKA_IDEN", SqlDbType.NVarChar);
            param[0].Value = MANTKA_IDEN;

            param[1] = new SqlParameter("@MEM_STATUS", SqlDbType.NVarChar);
            param[1].Value = MEM_STATUS;

            param[2] = new SqlParameter("@DTP1", SqlDbType.Date);
            param[2].Value = DTP1;

            param[3] = new SqlParameter("@DTP2", SqlDbType.Date);
            param[3].Value = DTP2;

            Dt = DAL.selectdata("STA_MEM_IN_MNTKA_BY_STATUS", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_MNTKA_BY_MEM_TYPE(string MANTKA_IDEN, string MEM_TYPE,
                                                    DateTime DTP1, DateTime DTP2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@MANTKA_IDEN", SqlDbType.NVarChar);
            param[0].Value = MANTKA_IDEN;

            param[1] = new SqlParameter("@MEM_TYPE", SqlDbType.NVarChar);
            param[1].Value = MEM_TYPE;

            param[2] = new SqlParameter("@DTP1", SqlDbType.Date);
            param[2].Value = DTP1;

            param[3] = new SqlParameter("@DTP2", SqlDbType.Date);
            param[3].Value = DTP2;

            Dt = DAL.selectdata("STA_MEM_IN_MNTKA_BY_MEM_TYPE", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_ALL_MEM_IN_LOAA(string LOAA_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@LOAA_IDEN", SqlDbType.NVarChar);
            param[0].Value = LOAA_IDEN;

            Dt = DAL.selectdata("STA_ALL_MEM_IN_LOAA", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_LOAA_BY_BLOOD(string LOAA_IDEN, string BLOOD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@LOAA_IDEN", SqlDbType.NVarChar);
            param[0].Value = LOAA_IDEN;

            param[1] = new SqlParameter("@BLOOD", SqlDbType.NVarChar);
            param[1].Value = BLOOD;

            Dt = DAL.selectdata("STA_MEM_IN_LOAA_BY_BLOOD", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_LOAA_BY_CIVILIAN(string LOAA_IDEN, string CIVILIAN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@LOAA_IDEN", SqlDbType.NVarChar);
            param[0].Value = LOAA_IDEN;

            param[1] = new SqlParameter("@CIVILIAN", SqlDbType.NVarChar);
            param[1].Value = CIVILIAN;

            Dt = DAL.selectdata("STA_MEM_IN_LOAA_BY_CIVILIAN", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_LOAA_BY_GENDER(string LOAA_IDEN, string GENDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@LOAA_IDEN", SqlDbType.NVarChar);
            param[0].Value = LOAA_IDEN;

            param[1] = new SqlParameter("@GENDER", SqlDbType.NVarChar);
            param[1].Value = GENDER;

            Dt = DAL.selectdata("STA_MEM_IN_LOAA_BY_GENDER", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_LOAA_BY_UNIVERSITY(string LOAA_IDEN, string UNIVERSITY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@LOAA_IDEN", SqlDbType.NVarChar);
            param[0].Value = LOAA_IDEN;

            param[1] = new SqlParameter("@UNIVERSITY", SqlDbType.NVarChar);
            param[1].Value = UNIVERSITY;

            Dt = DAL.selectdata("STA_MEM_IN_LOAA_BY_UNIVERSITY", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_LOAA_BY_STUDY(string LOAA_IDEN, string STUDY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@LOAA_IDEN", SqlDbType.NVarChar);
            param[0].Value = LOAA_IDEN;

            param[1] = new SqlParameter("@STUDY", SqlDbType.NVarChar);
            param[1].Value = STUDY;

            Dt = DAL.selectdata("STA_MEM_IN_LOAA_BY_STUDY", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_LOAA_BY_STATUS(string LOAA_IDEN, string MEM_STATUS,
                                                    DateTime DTP1, DateTime DTP2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@LOAA_IDEN", SqlDbType.NVarChar);
            param[0].Value = LOAA_IDEN;

            param[1] = new SqlParameter("@MEM_STATUS", SqlDbType.NVarChar);
            param[1].Value = MEM_STATUS;

            param[2] = new SqlParameter("@DTP1", SqlDbType.Date);
            param[2].Value = DTP1;

            param[3] = new SqlParameter("@DTP2", SqlDbType.Date);
            param[3].Value = DTP2;

            Dt = DAL.selectdata("STA_MEM_IN_LOAA_BY_STATUS", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_LOAA_BY_MEM_TYPE(string LOAA_IDEN, string MEM_TYPE,
                                            DateTime DTP1, DateTime DTP2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@LOAA_IDEN", SqlDbType.NVarChar);
            param[0].Value = LOAA_IDEN;

            param[1] = new SqlParameter("@MEM_TYPE", SqlDbType.NVarChar);
            param[1].Value = MEM_TYPE;

            param[2] = new SqlParameter("@DTP1", SqlDbType.Date);
            param[2].Value = DTP1;

            param[3] = new SqlParameter("@DTP2", SqlDbType.Date);
            param[3].Value = DTP2;

            Dt = DAL.selectdata("STA_MEM_IN_LOAA_BY_MEM_TYPE", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_ALL_MEM_IN_FAOJ(string FAOJ_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@FAOJ_IDEN", SqlDbType.NVarChar);
            param[0].Value = FAOJ_IDEN;

            Dt = DAL.selectdata("STA_ALL_MEM_IN_FAOJ", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_FAOJ_BY_BLOOD(string FAOJ_IDEN, string BLOOD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@FAOJ_IDEN", SqlDbType.NVarChar);
            param[0].Value = FAOJ_IDEN;

            param[1] = new SqlParameter("@BLOOD", SqlDbType.NVarChar);
            param[1].Value = BLOOD;

            Dt = DAL.selectdata("STA_MEM_IN_FAOJ_BY_BLOOD", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_FAOJ_BY_CIVILIAN(string FAOJ_IDEN, string CIVILIAN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@FAOJ_IDEN", SqlDbType.NVarChar);
            param[0].Value = FAOJ_IDEN;

            param[1] = new SqlParameter("@CIVILIAN", SqlDbType.NVarChar);
            param[1].Value = CIVILIAN;

            Dt = DAL.selectdata("STA_MEM_IN_FAOJ_BY_CIVILIAN", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_FAOJ_BY_GENDER(string FAOJ_IDEN, string GENDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@FAOJ_IDEN", SqlDbType.NVarChar);
            param[0].Value = FAOJ_IDEN;

            param[1] = new SqlParameter("@GENDER", SqlDbType.NVarChar);
            param[1].Value = GENDER;

            Dt = DAL.selectdata("STA_MEM_IN_FAOJ_BY_GENDER", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_FAOJ_BY_UNIVERSITY(string FAOJ_IDEN, string UNIVERSITY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@FAOJ_IDEN", SqlDbType.NVarChar);
            param[0].Value = FAOJ_IDEN;

            param[1] = new SqlParameter("@UNIVERSITY", SqlDbType.NVarChar);
            param[1].Value = UNIVERSITY;

            Dt = DAL.selectdata("STA_MEM_IN_FAOJ_BY_UNIVERSITY", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_FAOJ_BY_STUDY(string FAOJ_IDEN, string STUDY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@FAOJ_IDEN", SqlDbType.NVarChar);
            param[0].Value = FAOJ_IDEN;

            param[1] = new SqlParameter("@STUDY", SqlDbType.NVarChar);
            param[1].Value = STUDY;

            Dt = DAL.selectdata("STA_MEM_IN_FAOJ_BY_STUDY", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_FAOJ_BY_STATUS(string FAOJ_IDEN, string MEM_STATUS,
                                                 DateTime DTP1, DateTime DTP2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@FAOJ_IDEN", SqlDbType.NVarChar);
            param[0].Value = FAOJ_IDEN;

            param[1] = new SqlParameter("@MEM_STATUS", SqlDbType.NVarChar);
            param[1].Value = MEM_STATUS;

            param[2] = new SqlParameter("@DTP1", SqlDbType.Date);
            param[2].Value = DTP1;

            param[3] = new SqlParameter("@DTP2", SqlDbType.Date);
            param[3].Value = DTP2;

            Dt = DAL.selectdata("STA_MEM_IN_FAOJ_BY_STATUS", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_FAOJ_BY_MEM_TYPE(string FAOJ_IDEN, string MEM_TYPE,
                                             DateTime DTP1, DateTime DTP2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@FAOJ_IDEN", SqlDbType.NVarChar);
            param[0].Value = FAOJ_IDEN;

            param[1] = new SqlParameter("@MEM_TYPE", SqlDbType.NVarChar);
            param[1].Value = MEM_TYPE;

            param[2] = new SqlParameter("@DTP1", SqlDbType.Date);
            param[2].Value = DTP1;

            param[3] = new SqlParameter("@DTP2", SqlDbType.Date);
            param[3].Value = DTP2;

            Dt = DAL.selectdata("STA_MEM_IN_FAOJ_BY_MEM_TYPE", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_ALL_MEM_IN_KTEBA(string KTEBA_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@KTEBA_IDEN", SqlDbType.NVarChar);
            param[0].Value = KTEBA_IDEN;

            Dt = DAL.selectdata("STA_ALL_MEM_IN_KTEBA", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_KTEBA_BY_BLOOD(string KTEBA_IDEN, string BLOOD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@KTEBA_IDEN", SqlDbType.NVarChar);
            param[0].Value = KTEBA_IDEN;

            param[1] = new SqlParameter("@BLOOD", SqlDbType.NVarChar);
            param[1].Value = BLOOD;

            Dt = DAL.selectdata("STA_MEM_IN_KTEBA_BY_BLOOD", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_KTEBA_BY_CIVILIAN(string KTEBA_IDEN, string CIVILIAN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@KTEBA_IDEN", SqlDbType.NVarChar);
            param[0].Value = KTEBA_IDEN;

            param[1] = new SqlParameter("@CIVILIAN", SqlDbType.NVarChar);
            param[1].Value = CIVILIAN;

            Dt = DAL.selectdata("STA_MEM_IN_KTEBA_BY_CIVILIAN", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_KTEBA_BY_GENDER(string KTEBA_IDEN, string GENDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@KTEBA_IDEN", SqlDbType.NVarChar);
            param[0].Value = KTEBA_IDEN;

            param[1] = new SqlParameter("@GENDER", SqlDbType.NVarChar);
            param[1].Value = GENDER;

            Dt = DAL.selectdata("STA_MEM_IN_KTEBA_BY_GENDER", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_KTEBA_BY_UNIVERSITY(string KTEBA_IDEN, string UNIVERSITY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@KTEBA_IDEN", SqlDbType.NVarChar);
            param[0].Value = KTEBA_IDEN;

            param[1] = new SqlParameter("@UNIVERSITY", SqlDbType.NVarChar);
            param[1].Value = UNIVERSITY;

            Dt = DAL.selectdata("STA_MEM_IN_KTEBA_BY_UNIVERSITY", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_KTEBA_BY_STUDY(string KTEBA_IDEN, string STUDY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@KTEBA_IDEN", SqlDbType.NVarChar);
            param[0].Value = KTEBA_IDEN;

            param[1] = new SqlParameter("@STUDY", SqlDbType.NVarChar);
            param[1].Value = STUDY;

            Dt = DAL.selectdata("STA_MEM_IN_KTEBA_BY_STUDY", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_KTEBA_BY_STATUS(string KTEBA_IDEN, string MEM_STATUS,
                                            DateTime DTP1, DateTime DTP2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@KTEBA_IDEN", SqlDbType.NVarChar);
            param[0].Value = KTEBA_IDEN;

            param[1] = new SqlParameter("@MEM_STATUS", SqlDbType.NVarChar);
            param[1].Value = MEM_STATUS;

            param[2] = new SqlParameter("@DTP1", SqlDbType.Date);
            param[2].Value = DTP1;

            param[3] = new SqlParameter("@DTP2", SqlDbType.Date);
            param[3].Value = DTP2;

            Dt = DAL.selectdata("STA_MEM_IN_KTEBA_BY_STATUS", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_KTEBA_BY_TYPE(string KTEBA_IDEN, string MEM_TYPE,
                                          DateTime DTP1, DateTime DTP2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@KTEBA_IDEN", SqlDbType.NVarChar);
            param[0].Value = KTEBA_IDEN;

            param[1] = new SqlParameter("@MEM_TYPE", SqlDbType.NVarChar);
            param[1].Value = MEM_TYPE;

            param[2] = new SqlParameter("@DTP1", SqlDbType.Date);
            param[2].Value = DTP1;

            param[3] = new SqlParameter("@DTP2", SqlDbType.Date);
            param[3].Value = DTP2;

            Dt = DAL.selectdata("STA_MEM_IN_KTEBA_BY_TYPE", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_ALL_MEM_IN_FORCE(string FORCE_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@FORCE_IDEN", SqlDbType.NVarChar);
            param[0].Value = FORCE_IDEN;

            Dt = DAL.selectdata("STA_ALL_MEM_IN_FORCE", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_FORCE_BY_BLOOD(string FORCE_IDEN, string BLOOD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@FORCE_IDEN", SqlDbType.NVarChar);
            param[0].Value = FORCE_IDEN;

            param[1] = new SqlParameter("@BLOOD", SqlDbType.NVarChar);
            param[1].Value = BLOOD;

            Dt = DAL.selectdata("STA_MEM_IN_FORCE_BY_BLOOD", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_FORCE_BY_CIVILIAN(string FORCE_IDEN, string CIVILIAN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@FORCE_IDEN", SqlDbType.NVarChar);
            param[0].Value = FORCE_IDEN;

            param[1] = new SqlParameter("@CIVILIAN", SqlDbType.NVarChar);
            param[1].Value = CIVILIAN;

            Dt = DAL.selectdata("STA_MEM_IN_FORCE_BY_CIVILIAN", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_FORCE_BY_GENDER(string FORCE_IDEN, string GENDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@FORCE_IDEN", SqlDbType.NVarChar);
            param[0].Value = FORCE_IDEN;

            param[1] = new SqlParameter("@GENDER", SqlDbType.NVarChar);
            param[1].Value = GENDER;

            Dt = DAL.selectdata("STA_MEM_IN_FORCE_BY_GENDER", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_FORCE_BY_UNIVERSITY(string FORCE_IDEN, string UNIVERSITY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@FORCE_IDEN", SqlDbType.NVarChar);
            param[0].Value = FORCE_IDEN;

            param[1] = new SqlParameter("@UNIVERSITY", SqlDbType.NVarChar);
            param[1].Value = UNIVERSITY;

            Dt = DAL.selectdata("STA_MEM_IN_FORCE_BY_UNIVERSITY", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_FORCE_BY_STUDY(string FORCE_IDEN, string STUDY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@FORCE_IDEN", SqlDbType.NVarChar);
            param[0].Value = FORCE_IDEN;

            param[1] = new SqlParameter("@STUDY", SqlDbType.NVarChar);
            param[1].Value = STUDY;

            Dt = DAL.selectdata("STA_MEM_IN_FORCE_BY_STUDY", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_FORCE_BY_STATUS(string FORCE_IDEN, string MEM_STATUS,
                                    DateTime DTP1, DateTime DTP2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@FORCE_IDEN", SqlDbType.NVarChar);
            param[0].Value = FORCE_IDEN;

            param[1] = new SqlParameter("@MEM_STATUS", SqlDbType.NVarChar);
            param[1].Value = MEM_STATUS;

            param[2] = new SqlParameter("@DTP1", SqlDbType.Date);
            param[2].Value = DTP1;

            param[3] = new SqlParameter("@DTP2", SqlDbType.Date);
            param[3].Value = DTP2;

            Dt = DAL.selectdata("STA_MEM_IN_FORCE_BY_STATUS", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_FORCE_BY_TYPE(string FORCE_IDEN, string MEM_TYPE,
                              DateTime DTP1, DateTime DTP2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@FORCE_IDEN", SqlDbType.NVarChar);
            param[0].Value = FORCE_IDEN;

            param[1] = new SqlParameter("@MEM_TYPE", SqlDbType.NVarChar);
            param[1].Value = MEM_TYPE;

            param[2] = new SqlParameter("@DTP1", SqlDbType.Date);
            param[2].Value = DTP1;

            param[3] = new SqlParameter("@DTP2", SqlDbType.Date);
            param[3].Value = DTP2;

            Dt = DAL.selectdata("STA_MEM_IN_FORCE_BY_TYPE", param);
            DAL.close();
            return Dt;
        }
        public DataTable STA_MEM_IN_IQLIM_BY_REWARD(DateTime DTP1, DateTime DTP2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@DTP1", SqlDbType.Date);
            param[0].Value = DTP1;

            param[1] = new SqlParameter("@DTP2", SqlDbType.Date);
            param[1].Value = DTP2;

            Dt = DAL.selectdata("STA_MEM_IN_IQLIM_BY_REWARD", param);
            DAL.close();
            return Dt;
        }

        public DataTable STA_MEM_IN_IQLIM_BY_PUNI(DateTime DTP1, DateTime DTP2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@DTP1", SqlDbType.Date);
            param[0].Value = DTP1;

            param[1] = new SqlParameter("@DTP2", SqlDbType.Date);
            param[1].Value = DTP2;

            Dt = DAL.selectdata("STA_MEM_IN_IQLIM_BY_PUNI", param);
            DAL.close();
            return Dt;
        }

        internal object GET_FROM_IMP_EXP_FOR_STATISTICS(char p, DateTime dateTime1, DateTime dateTime2)
        {
            throw new NotImplementedException();
        }
    }
}
