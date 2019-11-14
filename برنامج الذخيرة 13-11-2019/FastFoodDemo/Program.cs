using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static string IMP_EXP_ID;
        public static int SILAH_IMP_EXP_ID;
        public static string type;
        public static string FROM_TO;
        public static int USER_IDEN;
        public static string USER_FULL_NAME;
        public static string USER_NAME_LOGIN;
        public static string PASSWORD;
        public static int USER_ID;
        public static int ORD_ID;
        public static string ORD_SOURCE;
        public static string ORD_DATE;
        public static string RPT_SERVER_NAME;
        public static string APP_IDEN;
        public static string HEREM_CODE;      
        public static int GATH_ID;
        public static string MEM_IDEN;
        public static string MEM_CODENAME;
        public static int STATE = 0;
        public static string MEM_NAME;
        public static string MEM_LNAME;
        public static string SERVER_NAME;
        public static string userid;
        public static string pass;
        public static int login;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FORM_MAIN1());
        }//PL.FORM_SILAH_MNG
    }
}
