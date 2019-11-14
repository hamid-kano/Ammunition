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
    public partial class FORM_MY_PROFILE : Form
    {
        BL.STATISTIC_CLS ITEM = new BL.STATISTIC_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.USERS_CLS USER = new BL.USERS_CLS();
        public FORM_MY_PROFILE()
        {
            InitializeComponent();

            TXTNAME.Text = Program.USER_FULL_NAME;
            TXTUSERNAME.Text = Program.USER_NAME_LOGIN;

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void BTNEDIT_Click(object sender, EventArgs e)
        {
            if (TXTNAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال الاسم الثلاثي \n Nav û Paşnav binivîse ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNAME.Focus();
                return;
            }
            if (TXTUSERNAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم المستخدم \n Navê bikarhêner binivîse ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTUSERNAME.Focus();
                return;
            }

            DataTable DT_USER_EDIT = USER.GET_ALL_USER_FOR_EDIT(Program.USER_ID);
            for (int i = 0; i < DT_USER_EDIT.Rows.Count; i++)
            {
                if (TXTUSERNAME.Text.TrimEnd(' ').ToLower() == DT_USER_EDIT.Rows[i][3].ToString())
                {
                    MessageBox.Show("اسم المستخدم موجود مسبقاً \n Ji Heman Navê bikarhênerek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTUSERNAME.Focus();
                    return;
                }
            }

            if (TXTPASSWORD.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال كلمة السر \n Şîfreya binivîse  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTPASSWORD.Focus();
                return;
            }
            if (TXTPASSWORD.Text.TrimEnd(' ') != Program.PASSWORD)
            {
                MessageBox.Show("كلمة السر المُدخلة خاطئة \n Şîfreya rast binivîse   ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTPASSWORD.Focus();
                return;
            }

            if (CHPASS.Checked == true)
            {
                if (TXTNEWPASSWORD.Text == string.Empty)
                {
                    MessageBox.Show("يجب إدخال كلمة السر الجديدة \n Şîfreya binivîse  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTNEWPASSWORD.Focus();
                    return;
                }

                if (TXTCONFIRMPASSWORD.Text == string.Empty)
                {
                    MessageBox.Show("يجب تأكيد كلمة السر \n Şîfreya piştrast bikin ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTCONFIRMPASSWORD.Focus();
                    return;
                }
                if (TXTCONFIRMPASSWORD.Text.TrimEnd(' ') != TXTNEWPASSWORD.Text.TrimEnd(' '))
                {
                    MessageBox.Show("تأكد من تطابق كلمة السر مع التأكيد \n Şîfreya rast binivîse  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTNEWPASSWORD.Focus();
                    return;
                }
                //if (TXTNEWPASSWORD.Text.TrimEnd(' ').Length < 6)
                //{
                //    MessageBox.Show("يجب أن يكون طول كلمة السر أكبر من 6 محارف    ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    TXTNEWPASSWORD.Focus();
                //    return;
                //}
                USER.EDIT_PROFILE(TXTNAME.Text, TXTUSERNAME.Text.TrimEnd(' ').ToLower(), TXTNEWPASSWORD.Text.TrimEnd(' '), Program.USER_ID);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, " biguhere - تعديل", " تعديل الملف الشخصي للمستخدم:  " + Program.USER_FULL_NAME, DateTime.Now);
                MessageBox.Show(" تمت عملية التعديل بنجاح ..سيتم تسجيل الخروج..قم بتسجيل الدخول مجدداً  \n sererastkirin bi awakî serkeftî hate tomarkirin ", " biguhere - تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
                return;
            }
            USER.EDIT_PROFILE(TXTNAME.Text, TXTUSERNAME.Text.TrimEnd(' ').ToLower(), Program.PASSWORD, Program.USER_ID);
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, " biguhere - تعديل", " تعديل الملف الشخصي للمستخدم:  " + Program.USER_FULL_NAME, DateTime.Now);
            MessageBox.Show("تمت عملية التعديل بنجاح ..سيتم تسجيل الخروج..قم بتسجيل الدخول مجدداً  \n sererastkirin bi awakî serkeftî hate tomarkirin ", " biguhere - تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();

        }

        private void BTNCLO_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CHPASS_CheckedChanged(object sender, EventArgs e)
        {
            if (CHPASS.Checked == true)
            {
                TXTNEWPASSWORD.Enabled = true;
                TXTCONFIRMPASSWORD.Enabled = true;
            }
            if (CHPASS.Checked == false)
            {
                TXTNEWPASSWORD.Enabled = false;
                TXTCONFIRMPASSWORD.Enabled = false;
            }
        }

        private void FORM_MY_PROFILE_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("قائمة الاسلحة", ar);
                LBLLOCATION.Text = rm.GetString("الاسم الثلاثي", ar);
                label3.Text = rm.GetString("اسم المستخدم", ar);
                label4.Text = rm.GetString("كلمة المرور الحالية", ar);
                label2.Text = rm.GetString("كلمة المرور الجديدة", ar);
                label1.Text = rm.GetString("تاكيد كلمة المرور", ar);
                BTNEDIT.Text = rm.GetString("تعديل", ar);
                BTNCLO.Text = rm.GetString("خروج", ar);
                CHPASS.Text = rm.GetString("تعديل كلمة المرور", ar);

            }
        }
    }
}
