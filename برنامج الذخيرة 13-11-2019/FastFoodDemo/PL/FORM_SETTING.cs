using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.PL
{
    public partial class FORM_SETTING : Form
    {
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();

        public FORM_SETTING()
        {
            InitializeComponent();

            DataTable DT_COUNT = MEM.GET_SETTING();
            if (DT_COUNT.Rows.Count > 0)
            {
                TXTNUM.Text = DT_COUNT.Rows[0][0].ToString();
            }

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void BTNNEW_Click(object sender, EventArgs e)
        {
            DataTable DT_COUNT = MEM.GET_SETTING();
            if (DT_COUNT.Rows.Count > 0)
            {
                MEM.EDIT_SETTING(TXTNUM.Text.TrimEnd(' '), " ");
                MessageBox.Show("لقد قمت بتحديد الرمز مسبقاً \n Şîfreya program Qeyidkiriya ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (DT_COUNT.Rows.Count == 0)
            {
                MEM.ADD_SETTING(TXTNUM.Text.TrimEnd(' '), " ");
            }
            Program.APP_IDEN = TXTNUM.Text.TrimEnd(' ');
           MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إعدادات", "إعدادات", DateTime.Now);

            MessageBox.Show("تمت عملية تثبيت الإعدادات بنجاح \n Şîfreya program Qeyidkirin bu ", "Zêdekirin-إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TXTNUM.Clear();
            FORM_MAIN1.getMainForm.Visible = true;
            this.Close();
        }

        private void FORM_SETTING_Load(object sender, EventArgs e)
        {
          try
          {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("الاعدادات", ar);
                label3.Text = rm.GetString("رمز التطبيق", ar);
                BTNNEW.Text = rm.GetString("تاكيد", ar);
            }
          }
          catch (Exception)
          {
               // throw;
          }
        }
    }
}
