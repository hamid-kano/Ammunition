using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FastFoodDemo.BL
{
    class DELETED_CLS
    {
        public DataTable GET_ALL_MEMBER_DELETED()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_MEMBER_DELETED", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_SILAH_DELETED()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_SILAH_DELETED", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_CAT_SILAH_DELETED()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_CAT_SILAH_DELETED", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_CATEGORY_DELETED()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_CATEGORY_DELETED", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_FROM_IMP_EXP_DELETED(string TYPE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TYPE", SqlDbType.NVarChar);
            param[0].Value = TYPE;
            Dt = DAL.selectdata("GET_FROM_IMP_EXP_DELETED", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_HEREM_DELETED()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();   
            Dt = DAL.selectdata("GET_ALL_HEREM_DELETED", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_EYALET_DELETED()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_EYALET_DELETED", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_TUGAY_DELETED()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_TUGAY_DELETED", null);
            DAL.close();
            return Dt;
        }

        public DataTable GET_ALL_ALAY_DELETED()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_ALAY_DELETED", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_TABUR_DELETED()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_TABUR_DELETED", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_FORCE_DELETED()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_FORCE_DELETED", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_CONFSCATIONS_DELETED()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_CONFSCATIONS_DELETED", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_SPOILS_DELETED()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_SPOILS_DELETED", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_ORDERS_DELETED()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_ORDERS_DELETED", null);
            DAL.close();
            return Dt;
        }
        public void RETRIVE_MEM(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            DAL.excutecommand("RETRIVE_MEM", param);
            DAL.close();
        }
        public void RETRIVE_MEM_PUNI_BY_MEM_IDEN(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            DAL.excutecommand("RETRIVE_MEM_PUNI_BY_MEM_IDEN", param);
            DAL.close();
        }
        public void RETIVE_SILAH(string SILAH_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@SILAH_CODE", SqlDbType.NVarChar);
            param[0].Value = SILAH_CODE;

            DAL.excutecommand("RETIVE_SILAH", param);
            DAL.close();
        }
        public void RETRIVE_CAT_SILAH(int CAT_SIL_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CAT_SIL_ID", SqlDbType.Int);
            param[0].Value = CAT_SIL_ID;

            DAL.excutecommand("RETRIVE_CAT_SILAH", param);
            DAL.close();
        }
        public void RETRIVE_CATEGORY(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.excutecommand("RETRIVE_CATEGORY", param);
            DAL.close();
        }
        public void RETRIVE_MEM_GATH_BY_MEM_IDEN(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            DAL.excutecommand("RETRIVE_MEM_GATH_BY_MEM_IDEN", param);
            DAL.close();
        }
        public void RETRIVE_MEM_FOLDER_BY_MEM_IDEN(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            DAL.excutecommand("RETRIVE_MEM_FOLDER_BY_MEM_IDEN", param);
            DAL.close();
        }
        public void RETRIVE_IMP_EXP(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.excutecommand("RETRIVE_IMP_EXP", param);
            DAL.close();
        }
        public void RETRIVE_HEREM(string CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            DAL.excutecommand("RETRIVE_HEREM", param);
            DAL.close();
        }
        public void RETRIVE_TUGAY(string CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            DAL.excutecommand("RETRIVE_TUGAY", param);
            DAL.close();
        }
        public void RETRIVE_ALAY(string CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            DAL.excutecommand("RETRIVE_ALAY", param);
            DAL.close();
        }
        public void RETRIVE_TABUR(string CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            DAL.excutecommand("RETRIVE_TABUR", param);
            DAL.close();
        }
        public void RETRIVE_FORCE(string CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            DAL.excutecommand("RETRIVE_FORCE", param);
            DAL.close();
        }
        public void RETRIVE_CONFSCATION(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.excutecommand("RETRIVE_CONFSCATION", param);
            DAL.close();
        }
        public void RETRIVE_SPOIL(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.excutecommand("RETRIVE_SPOIL", param);
            DAL.close();
        }
        public void RETRIVE_ORDERS(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.excutecommand("RETRIVE_ORDERS", param);
            DAL.close();
        }
        public void RETRIVE_EYALET(string CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            DAL.excutecommand("RETRIVE_EYALET", param);
            DAL.close();
        }
        public void DELETE_MEM_DELETED(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            DAL.excutecommand("DELETE_MEM_DELETED", param);
            DAL.close();
        }
        public void DELETE_SIALH_PERMANENTLY(string SILAH_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@SILAH_CODE", SqlDbType.NVarChar);
            param[0].Value = SILAH_CODE;

            DAL.excutecommand("DELETE_SIALH_PERMANENTLY", param);
            DAL.close();
        }
        public void DELETE_CAT_SILAH_PARMENTALY(int CAT_SILAH_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CAT_SILAH_ID", SqlDbType.Int);
            param[0].Value = CAT_SILAH_ID;

            DAL.excutecommand("DELETE_CAT_SILAH_PARMENTALY", param);
            DAL.close();
        }
        public void DELETE_FOLDER_DELETED(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = ID;

            DAL.excutecommand("DELETE_FOLDER_DELETED", param);
            DAL.close();
        }
        public void DELETE_CATRGORY_PARMENTALY(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.excutecommand("DELETE_CATRGORY_PARMENTALY", param);
            DAL.close();
        }
        public void DELETE_IMP_EXP_PARMENTLY(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.excutecommand("DELETE_IMP_EXP_PARMENTLY", param);
            DAL.close();
        }
        public void DELETE_HEREM_PARMENTLY(string CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            DAL.excutecommand("DELETE_HEREM_PARMENTLY", param);
            DAL.close();
        }
        public void DELETE_EYALET_PARMENTLY(string CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            DAL.excutecommand("DELETE_EYALET_PARMENTLY", param);
            DAL.close();
        }
        public void DELETE_TUGAY_PARMENTLY(string CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            DAL.excutecommand("DELETE_TUGAY_PARMENTLY", param);
            DAL.close();
        }
        public void DELETE_ALAY_PARMENTLY(string CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            DAL.excutecommand("DELETE_ALAY_PARMENTLY", param);
            DAL.close();
        }
        public void DELETE_TABUR_PARMANTLY(string CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CODE", SqlDbType.NVarChar);
            param[0].Value = CODE;

            DAL.excutecommand("DELETE_TABUR_PARMANTLY", param);
            DAL.close();
        }
        public void DELETE_FORCE_PARMENTLY(string FORCE_CODE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@FORCE_CODE", SqlDbType.NVarChar);
            param[0].Value = FORCE_CODE;

            DAL.excutecommand("DELETE_FORCE_PARMENTLY", param);
            DAL.close();
        }
        public void DELETE_CONFSCATION_PARMENTLY(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            DAL.excutecommand("DELETE_CONFSCATION_PARMENTLY", param);
            DAL.close();
        }
        public void DELETE_SPOILS_PARMENTLY(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            DAL.excutecommand("DELETE_SPOILS_PARMENTLY", param);
            DAL.close();
        }
        public void DELETE_ORDERS_PARMENTLY(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            DAL.excutecommand("DELETE_ORDERS_PARMENTLY", param);
            DAL.close();
        }
        public DataTable GET_MEMBER_DETALIES_DELETED()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_MEMBER_DETALIES_DELETED", null);
            DAL.close();
            return Dt;
        }
        public void RETRIVE_FROM_GATH_BY_GATH_ID(int GATH_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@GATH_ID", SqlDbType.Int);
            param[0].Value = GATH_ID;

            DAL.excutecommand("RETRIVE_FROM_GATH_BY_GATH_ID", param);
            DAL.close();
        }
        public void DELETE_GATH_DELETED(int GATH_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@GATH_ID", SqlDbType.Int);
            param[0].Value = GATH_ID;

            DAL.excutecommand("DELETE_GATH_DELETED", param);
            DAL.close();
        }
        public DataTable GET_MEM_REWARDS_DELETED()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_MEM_REWARDS_DELETED", null);
            DAL.close();
            return Dt;
        }
        public void RETIVE_CAT_SILAH(int CAT_SILAH_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CAT_SILAH_ID", SqlDbType.Int);
            param[0].Value = CAT_SILAH_ID;

            DAL.excutecommand("RETIVE_CAT_SILAH", param);
            DAL.close();
        }
        public void DELETE_MEM_REWARDS_DELETED(int REWARD_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@REWARD_ID", SqlDbType.Int);
            param[0].Value = REWARD_ID;

            DAL.excutecommand("DELETE_MEM_REWARDS_DELETED", param);
            DAL.close();
        }
        public DataTable GET_MEM_PUNI_DELETED()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_MEM_PUNI_DELETED", null);
            DAL.close();
            return Dt;
        }
        public void RETRIVE_MEM_PUNI_DELETED(int PUNI_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@PUNI_ID", SqlDbType.Int);
            param[0].Value = PUNI_ID;

            DAL.excutecommand("RETRIVE_MEM_PUNI_DELETED", param);
            DAL.close();
        }
        public void DELETE_MEM_PUNI_DELETED(int PUNI_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@PUNI_ID", SqlDbType.Int);
            param[0].Value = PUNI_ID;

            DAL.excutecommand("DELETE_MEM_PUNI_DELETED", param);
            DAL.close();
        }
        public void RETRIVE_MEM_FINGER(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            DAL.excutecommand("RETRIVE_MEM_FINGER", param);
            DAL.close();
        }
    }
}
