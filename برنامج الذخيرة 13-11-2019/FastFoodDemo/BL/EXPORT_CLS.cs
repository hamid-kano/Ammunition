using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FastFoodDemo.BL
{
    class EXPORT_CLS
    {
        public DataTable EX_GET_FROM_HEREM()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("EX_GET_FROM_HEREM", null);
            DAL.close();
            return Dt;
        }
        public DataTable EX_GET_PUNISHMENT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("EX_GET_PUNISHMENT", null);
            DAL.close();
            return Dt;
        }
        public DataTable EX_GET_REWARDS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("EX_GET_REWARDS", null);
            DAL.close();
            return Dt;
        }
        public DataTable EX_GET_DOCS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("EX_GET_DOCS", null);
            DAL.close();
            return Dt;
        }
        public DataTable EX_GET_IQLIM()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("EX_GET_IQLIM", null);
            DAL.close();
            return Dt;
        }
        public DataTable EX_GET_MNTKA()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("EX_GET_MNTKA", null);
            DAL.close();
            return Dt;
        }
        public DataTable EX_GET_LOAA()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("EX_GET_LOAA", null);
            DAL.close();
            return Dt;
        }
        public DataTable EX_GET_FAOJ()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("EX_GET_FAOJ", null);
            DAL.close();
            return Dt;
        }
        public DataTable EX_GET_KTEBA()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("EX_GET_KTEBA", null);
            DAL.close();
            return Dt;
        }
        public DataTable EX_GET_FORCE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("EX_GET_FORCE", null);
            DAL.close();
            return Dt;
        }
        public DataTable EX_GET_GATH()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("EX_GET_GATH", null);
            DAL.close();
            return Dt;
        }
        public DataTable EX_GET_ALL_SILAH()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("EX_GET_ALL_SILAH", null);
            DAL.close();
            return Dt;
        }
        public DataTable EX_GET_FROM_MEM_TABLE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("EX_GET_FROM_MEM_TABLE", null);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ALL_FINGER_FOR_ADD()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_FINGER_FOR_ADD", null);
            DAL.close();
            return Dt;
        }
        public void ADD_FINGER(string MEM_IDEN, string APP_IDEN, string FINGER,
            string IMPORT_IDEN, int IS_DEL, string FIN_DESC)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            param[1] = new SqlParameter("@APP_IDEN", SqlDbType.NVarChar);
            param[1].Value = APP_IDEN;

            param[2] = new SqlParameter("@FINGER", SqlDbType.NVarChar);
            param[2].Value = FINGER;

            param[3] = new SqlParameter("@IMPORT_IDEN", SqlDbType.NVarChar);
            param[3].Value = IMPORT_IDEN;

            param[4] = new SqlParameter("@IS_DEL", SqlDbType.NVarChar);
            param[4].Value = IS_DEL;

            param[5] = new SqlParameter("@FIN_DESC", SqlDbType.NVarChar);
            param[5].Value = FIN_DESC;

            DAL.excutecommand("ADD_FINGER", param);
            DAL.close();
        }
        public DataTable GET_MEM_FINGER(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            Dt = DAL.selectdata("GET_MEM_FINGER", param);
            DAL.close();
            return Dt;
        }
        public void DELETE_MEM_FINGER(int FIN_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@FIN_ID", SqlDbType.Int);
            param[0].Value = FIN_ID;

            DAL.excutecommand("DELETE_MEM_FINGER", param);
            DAL.close();
        }
        public DataTable GET_MEMBER_BY_FINGER(string MEM_IDEN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@MEM_IDEN", SqlDbType.NVarChar);
            param[0].Value = MEM_IDEN;

            Dt = DAL.selectdata("GET_MEMBER_BY_FINGER", param);
            DAL.close();
            return Dt;
        }
        public DataTable EX_GET_MEM_FINGER()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("EX_GET_MEM_FINGER", null);
            DAL.close();
            return Dt;
        }
        public DataTable IMP_GET_ALL_MEM()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("IMP_GET_ALL_MEM", null);
            DAL.close();
            return Dt;
        }
    }
}
