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
    public partial class FORM_USERS : Form
    {
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.USERS_CLS USER = new BL.USERS_CLS();

        int BASIC = 0;
        int BCKUP = 0;
        int RSTR = 0;
        int USRS = 0;
        int MYPROFILE = 0;
        int ACTIONS = 0;
        int ADD_MEM = 0;
        int MEM_MNG = 0;
        int IQLIM = 0;
        int MNTKA = 0;
        int LOAA = 0;
        int FAOJ = 0;
        int KTEBA = 0;
        int FORCE = 0;
        int EX = 0;
        int IMP = 0;
        int SOURCES = 0;
        int SILAH_WARE = 0;
        int IMP_EXP_SILAH = 0;
        int REPORT2 = 0;
        int DELETED = 0;
        int REPORT = 0;
        int ALGHANAEM  = 0;        
          int  MUSADRA = 0;
          int CATEGRY = 0;
       int ORDERS = 0;
       int SILAH = 0;
        public FORM_USERS()
        {
            InitializeComponent();

            DGVUSERS.DataSource = USER.GET_ALL_USERS();
            DGVUSERS.Columns[0].Visible = false;
            DGVUSERS.Columns[1].Visible = false;

            for (int i = 4; i < DGVUSERS.Columns.Count; i++)
            {
                DGVUSERS.Columns[i].Visible = false;
            }

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void FORM_USERS_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("المستخدمين", ar);
                LBL11.Text = rm.GetString("الاسم الثلاثي", ar);
                label1.Text = rm.GetString("اسم المستخدم", ar);
                label2.Text = rm.GetString("كلمة المرور", ar);
                label3.Text = rm.GetString("تاكيد كلمة المرور", ar);

                CH_ALL.Text = rm.GetString("الكل", ar);
                CH_BASIC.Text = rm.GetString("العمليات", ar);
                CH_BACKUP.Text = rm.GetString("النسخ الاحتياطي", ar);
                CH_RSTR.Text = rm.GetString("استعادة النسخ الاحتياطي", ar);
                CH_USRS.Text = rm.GetString("مستخدموا البرنامج", ar);
                CH_MYPROFILE.Text = rm.GetString("الملف الشخصي", ar);
                CH_ACTIONS.Text = rm.GetString("نشاطات المستخدمين", ar);               
                CH_IQLIM.Text = rm.GetString("الاقاليم", ar);
                CH_MNTKA.Text = rm.GetString("المناطق", ar);
                CH_LOAA.Text = rm.GetString("الالوية", ar);
                CH_FAOJ.Text = rm.GetString("الافواج", ar);
                CH_KTEBA.Text = rm.GetString("الكتائب", ar);
                CH_FORCE.Text = rm.GetString("القوات", ar);
                CH_CATEGRY.Text = rm.GetString("الاصناف", ar);
                CH_SILAH.Text = rm.GetString("الاسلحة", ar);
                CH_SILAH_WAREHOUSE.Text = rm.GetString("مستودع الاسلحة", ar);
                CH_IMP_EXP_SILAH.Text = rm.GetString("تصدير واستيراد السلاح", ar);
                CH_REPORT.Text = rm.GetString("التقارير 1", ar);
                CH_REPORT2.Text = rm.GetString("التقارير 2", ar);
                CH_MNGMEM.Text = rm.GetString("ادارة بيانات المقاتلين", ar);
                CH_ADDMEM.Text = rm.GetString("اضافة مقاتل", ar);
                CH_ORDERS.Text = rm.GetString("الطلبات", ar);
                CH_MUSADRA.Text = rm.GetString("المصادرات", ar);
                CH_SOURCES.Text = rm.GetString("الجهات", ar);
                CH_ALGHANAEM.Text = rm.GetString("الغنائم", ar);
                CH_EX.Text = rm.GetString("تصدير البيانات", ar);
                CH_IMP.Text = rm.GetString("استيراد البيانات", ar);
                CH_DELETED.Text = rm.GetString("المحذوفات", ar);
               

                BTNNEW.Text = rm.GetString("جديد", ar);
                BTNADD.Text = rm.GetString("اضافة", ar);
                BTNEDIT.Text = rm.GetString("تعديل", ar);
                BTNDELETE.Text = rm.GetString("حذف", ar);
                BTNCLO.Text = rm.GetString("خروج", ar);

            }
        }

        private void BTNCLO_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNNEW_Click(object sender, EventArgs e)
        {
            CH_ALL.Checked = false;
            CH_BASIC.Checked = false;
            CH_BACKUP.Checked = false;
            CH_RSTR.Checked = false;
            CH_USRS.Checked = false;
            CH_MYPROFILE.Checked = false;
            CH_ACTIONS.Checked = false;

            CH_ADDMEM.Checked = false;
            CH_MNGMEM.Checked = false;
            CH_IQLIM.Checked = false;
            CH_MNTKA.Checked = false;
            CH_LOAA.Checked = false;
            CH_FAOJ.Checked = false;
            CH_KTEBA.Checked = false;
            CH_REPORT.Checked = false;
             CH_REPORT2.Checked = false;
            CH_SOURCES.Checked = false;
            CH_EX.Checked = false;
            CH_IMP.Checked = false;
            CH_FORCE.Checked = false;
            CH_ORDERS.Checked = false;
            CH_DELETED.Checked = false;
            CH_ALGHANAEM.Checked = false;
            CH_IMP_EXP_SILAH.Checked = false;
            CH_MUSADRA.Checked = false;
            CH_SILAH_WAREHOUSE.Checked = false;
            CH_CATEGRY.Checked = false;
            CH_SILAH.Checked = false;

            TXTUSERNAME.ReadOnly = false;


            TXTFULLNAME.Clear();
            TXTUSERNAME.Clear();
            TXTPASSWORD.Clear();
            TXTCONFIRMPASSWORD.Clear();

            BTNADD.Enabled = true;
            BTNDELETE.Enabled = false;
            BTNEDIT.Enabled = false;
        }

        private void CHALL_CheckedChanged(object sender, EventArgs e)
        {
            if (CH_ALL.Checked == true)
            {
                CH_BASIC.Checked = true;
                CH_BACKUP.Checked = true;
                CH_RSTR.Checked = true;
                CH_USRS.Checked = true;
                CH_MYPROFILE.Checked = true;
                CH_ACTIONS.Checked = true;

                CH_ADDMEM.Checked = true;
                CH_MNGMEM.Checked = true;
                CH_IQLIM.Checked = true;
                CH_MNTKA.Checked = true;
                CH_LOAA.Checked = true;
                CH_FAOJ.Checked = true;
                CH_KTEBA.Checked = true;
                CH_REPORT.Checked = true;
                CH_SOURCES.Checked = true;
                CH_EX.Checked = true;
                CH_IMP.Checked = true;
                CH_FORCE.Checked = true;
                CH_ORDERS.Checked = true;
                CH_DELETED.Checked = true;
                CH_ALGHANAEM.Checked = true;
                CH_IMP_EXP_SILAH.Checked = true;
                CH_MUSADRA.Checked = true;
                CH_REPORT2.Checked = true;
                CH_SILAH_WAREHOUSE.Checked = true;
                CH_CATEGRY.Checked = true;
                CH_SILAH.Checked = true;
            }
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {

            MUSADRA = 0;
            CATEGRY = 0;
            BASIC = 0;
            BCKUP = 0;
            RSTR = 0;
            USRS = 0;
            MYPROFILE = 0;
            ACTIONS = 0;
            ADD_MEM = 0;
            MEM_MNG = 0;
            IQLIM = 0;
            MNTKA = 0;
            LOAA = 0;
            FAOJ = 0;
            KTEBA = 0;
            FORCE = 0;
            SOURCES = 0;
            EX = 0;
            IMP = 0;
            SILAH_WARE = 0;
            IMP_EXP_SILAH = 0;
            ORDERS = 0;
            DELETED = 0;
            REPORT = 0;
            REPORT2 = 0;
            ALGHANAEM = 0;
             SILAH = 0;
            if (TXTFULLNAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال الاسم الثلاثي \n Nav û Paşnav binivîse ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTFULLNAME.Focus();
                return;
            }
            if (TXTUSERNAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم المستخدم - Navê bikarhêner binivîse ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTUSERNAME.Focus();
                return;
            }

            DataTable DT = USER.GET_ALL_USERS();
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                if (TXTUSERNAME.Text.TrimEnd(' ').ToLower() == DT.Rows[i][4].ToString().ToLower())
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
            if (TXTCONFIRMPASSWORD.Text == string.Empty)
            {
                MessageBox.Show("يجب تأكيد كلمة السر \n Şîfreya piştrast bikin  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTCONFIRMPASSWORD.Focus();
                return;
            }
            if (TXTCONFIRMPASSWORD.Text.TrimEnd(' ') != TXTPASSWORD.Text.TrimEnd(' '))
            {
                MessageBox.Show("تأكد من تطابق كلمة السر مع التأكيد \n Şîfreya rast binivîse  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTPASSWORD.Focus();
                return;
            }
 
            if (CH_BASIC.Checked == true)
            {
                BASIC = 1;
            }
            if (CH_BACKUP.Checked == true)
            {
                BCKUP = 1;
            }
            if (CH_RSTR.Checked == true)
            {
                RSTR = 1;
            }
            if (CH_USRS.Checked == true)
            {
                USRS = 1;
            }
            if (CH_MYPROFILE.Checked == true)
            {
                MYPROFILE = 1;
            }
            if (CH_ACTIONS.Checked == true)
            {
                ACTIONS = 1;
            }
            if (CH_ADDMEM.Checked == true)
            {
                ADD_MEM = 1;
            }
            if (CH_MNGMEM.Checked == true)
            {
                MEM_MNG = 1;
            }
            if (CH_IQLIM.Checked == true)
            {
                IQLIM = 1;
            }
            if (CH_MNTKA.Checked == true)
            {
                MNTKA = 1;
            }
            if (CH_LOAA.Checked == true)
            {
                LOAA = 1;
            }
            if (CH_FAOJ.Checked == true)
            {
                FAOJ = 1;
            }
            if (CH_KTEBA.Checked == true)
            {
                KTEBA = 1;
            }
            if (CH_REPORT.Checked == true)
            {
                REPORT = 1;
            }
            if (CH_SOURCES.Checked == true)
            {
                SOURCES = 1;
            }
            if (CH_EX.Checked == true)
            {
                EX = 1;
            }
            if (CH_IMP.Checked == true)
            {
                IMP = 1;
            }

            if (CH_FORCE.Checked == true)
            {
                FORCE = 1;
            }
            if (CH_ORDERS.Checked == true)
            {
                ORDERS = 1;
            }
            if (CH_DELETED.Checked == true)
            {
                DELETED = 1;
            }
            if (CH_IMP_EXP_SILAH.Checked == true)
            {
                IMP_EXP_SILAH = 1;
            }
            if (CH_ALGHANAEM.Checked == true)
            {
                ALGHANAEM = 1;
            }
            if (CH_REPORT2.Checked == true)
            {
                REPORT2 = 1;
            }           
            if (CH_SILAH_WAREHOUSE.Checked == true)
            {
                SILAH_WARE = 1;
            }
            if (CH_MUSADRA.Checked == true)
            {
                MUSADRA = 1;
            }
            if (CH_CATEGRY.Checked == true)
            {
                CATEGRY = 1;
            }
            if (CH_SILAH.Checked == true)
            {
                SILAH = 1;
            }

            USER.ADD_USER(Program.APP_IDEN, TXTFULLNAME.Text, TXTUSERNAME.Text.TrimEnd(' ').ToLower(),
                 TXTPASSWORD.Text.TrimEnd(' ')
                , BASIC, BCKUP, RSTR, USRS, MYPROFILE
                , ACTIONS, ADD_MEM, MEM_MNG, IQLIM, MNTKA, LOAA,
                FAOJ, KTEBA, FORCE, EX, IMP,DELETED,REPORT,REPORT2,SOURCES,ALGHANAEM,MUSADRA,ORDERS,CATEGRY,IMP_EXP_SILAH,SILAH_WARE,0,SILAH);


            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة", " إضافة مستخدم:  " + TXTFULLNAME.Text, DateTime.Now);

            MessageBox.Show("تمت عملية الإضافة بنجاح \n zêdekirin serkeftî derbas bû ", "Zêdekirin-إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DGVUSERS.DataSource = USER.GET_ALL_USERS();

            TXTFULLNAME.Clear();
            TXTPASSWORD.Clear();
            TXTUSERNAME.Clear();
            TXTCONFIRMPASSWORD.Clear();
            BTNEDIT.Enabled = false;
            BTNDELETE.Enabled = false;

            CH_ALL.Checked = false;
            CH_BASIC.Checked = false;
            CH_BACKUP.Checked = false;
            CH_RSTR.Checked = false;
            CH_USRS.Checked = false;
            CH_MYPROFILE.Checked = false;
            CH_ACTIONS.Checked = false;

            CH_ADDMEM.Checked = false;
            CH_MNGMEM.Checked = false;
            CH_IQLIM.Checked = false;
            CH_MNTKA.Checked = false;
            CH_LOAA.Checked = false;
            CH_FAOJ.Checked = false;
            CH_KTEBA.Checked = false;
            CH_REPORT.Checked = false;
            CH_REPORT2.Checked = false;
            CH_SOURCES.Checked = false;
            CH_EX.Checked = false;
            CH_IMP.Checked = false;
            CH_FORCE.Checked = false;
            CH_ORDERS.Checked = false;
            CH_DELETED.Checked = false;
            CH_ALGHANAEM.Checked = false;
            CH_IMP_EXP_SILAH.Checked = false;
            CH_MUSADRA.Checked = false;
            CH_SILAH_WAREHOUSE.Checked = false;
            CH_CATEGRY.Checked = false;
            CH_SILAH.Checked = false;

        }

        private void DGVUSERS_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    CH_ALL.Checked = false;
            //    BTNEDIT.Enabled = false;
            //    BTNDELETE.Enabled = false;

            //    CH_ALL.Checked = false;
            //    CH_BASIC.Checked = false;
            //    CH_BACKUP.Checked = false;
            //    CH_RSTR.Checked = false;
            //    CH_USRS.Checked = false;
            //    CH_MYPROFILE.Checked = false;
            //    CH_ACTIONS.Checked = false;

            //    CH_ADDMEM.Checked = false;
            //    CH_MNGMEM.Checked = false;
            //    CH_IQLIM.Checked = false;
            //    CH_MNTKA.Checked = false;
            //    CH_LOAA.Checked = false;
            //    CH_FAOJ.Checked = false;
            //    CH_KTEBA.Checked = false;
            //    CH_REPORT.Checked = false;
            //    CH_REPORT2.Checked = false;
            //    CH_SOURCES.Checked = false;
            //    CH_EX.Checked = false;
            //    CH_IMP.Checked = false;
            //    CH_FORCE.Checked = false;
            //    CH_ORDERS.Checked = false;
            //    CH_DELETED.Checked = false;
            //    CH_ALGHANAEM.Checked = false;
            //    CH_IMP_EXP_SILAH.Checked = false;
            //    CH_MUSADRA.Checked = false;
            //    CH_SILAH_WAREHOUSE.Checked = false;
            //    CH_CATEGRY.Checked = false;
            //    CH_SILAH.Checked = false;

            //    BTNEDIT.Enabled = true;
            //    BTNDELETE.Enabled = true;
            //    BTNADD.Enabled = false;

            //    TXTUSERNAME.Text = DGVUSERS.CurrentRow.Cells[3].Value.ToString();
            //    TXTFULLNAME.Text = DGVUSERS.CurrentRow.Cells[2].Value.ToString();

            //    TXTUSERNAME.ReadOnly = true;

            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[5].Value.ToString()) == 1)
            //    {
            //        CH_BASIC.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[6].Value.ToString()) == 1)
            //    {
            //        CH_BACKUP.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[7].Value.ToString()) == 1)
            //    {
            //        CH_RSTR.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[8].Value.ToString()) == 1)
            //    {
            //        CH_USRS.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[9].Value.ToString()) == 1)
            //    {
            //        CH_MYPROFILE.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[10].Value.ToString()) == 1)
            //    {
            //        CH_ACTIONS.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[11].Value.ToString()) == 1)
            //    {
            //        CH_ADDMEM.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[12].Value.ToString()) == 1)
            //    {
            //        CH_MNGMEM.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[13].Value.ToString()) == 1)
            //    {
            //        CH_IQLIM.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[14].Value.ToString()) == 1)
            //    {
            //        CH_MNTKA.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[15].Value.ToString()) == 1)
            //    {
            //        CH_LOAA.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[16].Value.ToString()) == 1)
            //    {
            //        CH_FAOJ.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[17].Value.ToString()) == 1)
            //    {
            //        CH_KTEBA.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[18].Value.ToString()) == 1)
            //    {
            //        CH_FORCE.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[19].Value.ToString()) == 1)
            //    {
            //        CH_EX.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[20].Value.ToString()) == 1)
            //    {
            //        CH_IMP.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[21].Value.ToString()) == 1)
            //    {
            //        CH_DELETED.Checked = true;
            //    }

            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[22].Value.ToString()) == 1)
            //    {
            //        CH_REPORT.Checked = true;
                    
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[23].Value.ToString()) == 1)
            //    {
            //        CH_REPORT2.Checked = true;
                    
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[24].Value.ToString()) == 1)
            //    {
            //        CH_SOURCES.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[25].Value.ToString()) == 1)
            //    {
            //        CH_ALGHANAEM.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[26].Value.ToString()) == 1)
            //    {
            //        CH_MUSADRA.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[27].Value.ToString()) == 1)
            //    {
            //        CH_ORDERS.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[28].Value.ToString()) == 1)
            //    {
            //        CH_CATEGRY.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[29].Value.ToString()) == 1)
            //    {
            //        CH_IMP_EXP_SILAH.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[30].Value.ToString()) == 1)
            //    {
            //        CH_SILAH_WAREHOUSE.Checked = true;
            //    }
            //    if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[32].Value.ToString()) == 1)
            //    {
            //        CH_SILAH.Checked = true;
            //    }
            //}
            //catch
            //{
            //    return;
            //}
        }

        private void BTNEDIT_Click(object sender, EventArgs e)
        {
            MUSADRA = 0;
            CATEGRY = 0;
            BASIC = 0;
            BCKUP = 0;
            RSTR = 0;
            USRS = 0;
            MYPROFILE = 0;
            ACTIONS = 0;
            ADD_MEM = 0;
            MEM_MNG = 0;
            IQLIM = 0;
            MNTKA = 0;
            LOAA = 0;
            FAOJ = 0;
            KTEBA = 0;
            FORCE = 0;
            SOURCES = 0;
            EX = 0;
            IMP = 0;
            SILAH_WARE = 0;
            IMP_EXP_SILAH = 0;
            ORDERS = 0;
            DELETED = 0;
            REPORT = 0;
            REPORT2 = 0;
            ALGHANAEM = 0;

            if (TXTFULLNAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال الاسم الثلاثي \n Nav û Paşnav binivîse ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTFULLNAME.Focus();
                return;
            }
            if (TXTUSERNAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم المستخدم - Navê bikarhêner binivîse ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTUSERNAME.Focus();
                return;
            }

            DataTable DT = USER.GET_ALL_USER_FOR_EDIT(Convert.ToInt32(DGVUSERS.CurrentRow.Cells[0].Value.ToString()));
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                if (TXTUSERNAME.Text.TrimEnd(' ').ToLower() == DT.Rows[i][3].ToString().ToLower())
                {
                    MessageBox.Show("اسم المستخدم موجود مسبقاً \n Ji Heman Navê bikarhênerek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTUSERNAME.Focus();
                    return;
                }
            }


            if (CH_BASIC.Checked == true)
            {
                BASIC = 1;
            }
            if (CH_BACKUP.Checked == true)
            {
                BCKUP = 1;
            }
            if (CH_RSTR.Checked == true)
            {
                RSTR = 1;
            }
            if (CH_USRS.Checked == true)
            {
                USRS = 1;
            }
            if (CH_MYPROFILE.Checked == true)
            {
                MYPROFILE = 1;
            }
            if (CH_ACTIONS.Checked == true)
            {
                ACTIONS = 1;
            }
            if (CH_ADDMEM.Checked == true)
            {
                ADD_MEM = 1;
            }
            if (CH_MNGMEM.Checked == true)
            {
                MEM_MNG = 1;
            }
            if (CH_IQLIM.Checked == true)
            {
                IQLIM = 1;
            }
            if (CH_MNTKA.Checked == true)
            {
                MNTKA = 1;
            }
            if (CH_LOAA.Checked == true)
            {
                LOAA = 1;
            }
            if (CH_FAOJ.Checked == true)
            {
                FAOJ = 1;
            }
            if (CH_KTEBA.Checked == true)
            {
                KTEBA = 1;
            }
            if (CH_REPORT.Checked == true)
            {
                REPORT = 1;
            }
            if (CH_SOURCES.Checked == true)
            {
                SOURCES = 1;
            }
            if (CH_EX.Checked == true)
            {
                EX = 1;
            }
            if (CH_IMP.Checked == true)
            {
                IMP = 1;
            }

            if (CH_FORCE.Checked == true)
            {
                FORCE = 1;
            }
            if (CH_ORDERS.Checked == true)
            {
                ORDERS = 1;
            }
            if (CH_DELETED.Checked == true)
            {
                DELETED = 1;
            }
            if (CH_IMP_EXP_SILAH.Checked == true)
            {
                IMP_EXP_SILAH = 1;
            }
            if (CH_ALGHANAEM.Checked == true)
            {
                ALGHANAEM = 1;
            }
            if (CH_REPORT2.Checked == true)
            {
                REPORT2 = 1;
            }
            if (CH_SILAH_WAREHOUSE.Checked == true)
            {
                SILAH_WARE = 1;
            }
            if (CH_MUSADRA.Checked == true)
            {
                MUSADRA = 1;
            }
            if (CH_CATEGRY.Checked == true)
            {
                CATEGRY = 1;
            }
            if (CH_SILAH.Checked == true)
            {
                SILAH = 1;
            }
            USER.EDIIT_USER(BASIC, BCKUP, RSTR, USRS, MYPROFILE
                , ACTIONS, ADD_MEM, MEM_MNG, IQLIM, MNTKA, LOAA,
                FAOJ, KTEBA, FORCE, EX, IMP, DELETED, REPORT, REPORT2, SOURCES, ALGHANAEM, MUSADRA, ORDERS, CATEGRY, IMP_EXP_SILAH, SILAH_WARE,Convert.ToInt32(DGVUSERS.CurrentRow.Cells[0].Value.ToString()),SILAH);
           MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, " biguhere - تعديل", " تعديل مستخدم:  " + DGVUSERS.CurrentRow.Cells[2].Value.ToString(), DateTime.Now);

            if (DGVUSERS.CurrentRow.Cells[3].Value.ToString() == Program.USER_NAME_LOGIN)
            {
                MessageBox.Show(".. تمت عملية التعديل بنجاح قم بتسجيل الدخول مجدداً \n sererastkirin bi awakî serkeftî hate tomarkirin ", " biguhere - تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
                return;
            }
            if (DGVUSERS.CurrentRow.Cells[3].Value.ToString() != Program.USER_NAME_LOGIN)
            {
                MessageBox.Show("تمت عملية التعديل بنجاح  \n sererastkirin bi awakî serkeftî hate tomarkirin ", " biguhere - تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DGVUSERS.DataSource = USER.GET_ALL_USERS();

            TXTFULLNAME.Clear();
            TXTPASSWORD.Clear();
            TXTUSERNAME.Clear();
            TXTCONFIRMPASSWORD.Clear();
            BTNEDIT.Enabled = false;
            BTNDELETE.Enabled = false;

            CH_ALL.Checked = false;
            CH_BASIC.Checked = false;
            CH_BACKUP.Checked = false;
            CH_RSTR.Checked = false;
            CH_USRS.Checked = false;
            CH_MYPROFILE.Checked = false;
            CH_ACTIONS.Checked = false;

            CH_ADDMEM.Checked = false;
            CH_MNGMEM.Checked = false;
            CH_IQLIM.Checked = false;
            CH_MNTKA.Checked = false;
            CH_LOAA.Checked = false;
            CH_FAOJ.Checked = false;
            CH_KTEBA.Checked = false;
            CH_REPORT.Checked = false;
            CH_REPORT2.Checked = false;
            CH_SOURCES.Checked = false;
            CH_EX.Checked = false;
            CH_IMP.Checked = false;
            CH_FORCE.Checked = false;
            CH_ORDERS.Checked = false;
            CH_DELETED.Checked = false;
            CH_ALGHANAEM.Checked = false;
            CH_IMP_EXP_SILAH.Checked = false;
            CH_MUSADRA.Checked = false;
            CH_SILAH_WAREHOUSE.Checked = false;
            CH_CATEGRY.Checked = false;
            CH_SILAH.Checked = false;

        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                USER.DELETE_USER(Convert.ToInt32(DGVUSERS.CurrentRow.Cells[0].Value.ToString()));
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "Jêbirinê - الحذف", " حذف مستخدم:  " + DGVUSERS.CurrentRow.Cells[2].Value.ToString(), DateTime.Now);
                MessageBox.Show(" تم الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DGVUSERS.DataSource = USER.GET_ALL_USERS();
                TXTFULLNAME.Clear();
                TXTPASSWORD.Clear();
                TXTUSERNAME.Clear();
                TXTCONFIRMPASSWORD.Clear();
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;
                CH_ALL.Checked = false;
                CH_BASIC.Checked = false;
                CH_BACKUP.Checked = false;
                CH_RSTR.Checked = false;
                CH_USRS.Checked = false;
                CH_MYPROFILE.Checked = false;
                CH_ACTIONS.Checked = false;
                CH_ADDMEM.Checked = false;
                CH_MNGMEM.Checked = false;
                CH_IQLIM.Checked = false;
                CH_MNTKA.Checked = false;
                CH_LOAA.Checked = false;
                CH_FAOJ.Checked = false;
                CH_KTEBA.Checked = false;
                CH_REPORT.Checked = false;
                CH_REPORT2.Checked = false;
                CH_SOURCES.Checked = false;
                CH_EX.Checked = false;
                CH_IMP.Checked = false;
                CH_FORCE.Checked = false;
                CH_ORDERS.Checked = false;
                CH_DELETED.Checked = false;
                CH_ALGHANAEM.Checked = false;
                CH_IMP_EXP_SILAH.Checked = false;
                CH_MUSADRA.Checked = false;
                CH_SILAH_WAREHOUSE.Checked = false;
                CH_CATEGRY.Checked = false;
                CH_SILAH.Checked = false;
            }
        }

        private void DGVUSERS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < DGVUSERS.Rows.Count; i++)
            {
                if (DGVUSERS.Rows[i].Index % 2 == 0)
                {
                    DGVUSERS.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171, 125, 47);
                }
            }
        }

        private void DGVUSERS_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                CH_ALL.Checked = false;
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;

                CH_ALL.Checked = false;
                CH_BASIC.Checked = false;
                CH_BACKUP.Checked = false;
                CH_RSTR.Checked = false;
                CH_USRS.Checked = false;
                CH_MYPROFILE.Checked = false;
                CH_ACTIONS.Checked = false;

                CH_ADDMEM.Checked = false;
                CH_MNGMEM.Checked = false;
                CH_IQLIM.Checked = false;
                CH_MNTKA.Checked = false;
                CH_LOAA.Checked = false;
                CH_FAOJ.Checked = false;
                CH_KTEBA.Checked = false;
                CH_REPORT.Checked = false;
                CH_REPORT2.Checked = false;
                CH_SOURCES.Checked = false;
                CH_EX.Checked = false;
                CH_IMP.Checked = false;
                CH_FORCE.Checked = false;
                CH_ORDERS.Checked = false;
                CH_DELETED.Checked = false;
                CH_ALGHANAEM.Checked = false;
                CH_IMP_EXP_SILAH.Checked = false;
                CH_MUSADRA.Checked = false;
                CH_SILAH_WAREHOUSE.Checked = false;
                CH_CATEGRY.Checked = false;
                CH_SILAH.Checked = false;

                BTNEDIT.Enabled = true;
                BTNDELETE.Enabled = true;
                BTNADD.Enabled = false;

                TXTUSERNAME.Text = DGVUSERS.CurrentRow.Cells[3].Value.ToString();
                TXTFULLNAME.Text = DGVUSERS.CurrentRow.Cells[2].Value.ToString();

                TXTUSERNAME.ReadOnly = true;

                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[5].Value.ToString()) == 1)
                {
                    CH_BASIC.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[6].Value.ToString()) == 1)
                {
                    CH_BACKUP.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[7].Value.ToString()) == 1)
                {
                    CH_RSTR.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[8].Value.ToString()) == 1)
                {
                    CH_USRS.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[9].Value.ToString()) == 1)
                {
                    CH_MYPROFILE.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[10].Value.ToString()) == 1)
                {
                    CH_ACTIONS.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[11].Value.ToString()) == 1)
                {
                    CH_ADDMEM.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[12].Value.ToString()) == 1)
                {
                    CH_MNGMEM.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[13].Value.ToString()) == 1)
                {
                    CH_IQLIM.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[14].Value.ToString()) == 1)
                {
                    CH_MNTKA.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[15].Value.ToString()) == 1)
                {
                    CH_LOAA.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[16].Value.ToString()) == 1)
                {
                    CH_FAOJ.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[17].Value.ToString()) == 1)
                {
                    CH_KTEBA.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[18].Value.ToString()) == 1)
                {
                    CH_FORCE.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[19].Value.ToString()) == 1)
                {
                    CH_EX.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[20].Value.ToString()) == 1)
                {
                    CH_IMP.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[21].Value.ToString()) == 1)
                {
                    CH_DELETED.Checked = true;
                }

                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[22].Value.ToString()) == 1)
                {
                    CH_REPORT.Checked = true;

                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[23].Value.ToString()) == 1)
                {
                    CH_REPORT2.Checked = true;

                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[24].Value.ToString()) == 1)
                {
                    CH_SOURCES.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[25].Value.ToString()) == 1)
                {
                    CH_ALGHANAEM.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[26].Value.ToString()) == 1)
                {
                    CH_MUSADRA.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[27].Value.ToString()) == 1)
                {
                    CH_ORDERS.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[28].Value.ToString()) == 1)
                {
                    CH_CATEGRY.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[29].Value.ToString()) == 1)
                {
                    CH_IMP_EXP_SILAH.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[30].Value.ToString()) == 1)
                {
                    CH_SILAH_WAREHOUSE.Checked = true;
                }
                if (Convert.ToInt32(DGVUSERS.CurrentRow.Cells[32].Value.ToString()) == 1)
                {
                    CH_SILAH.Checked = true;
                }
            }
            catch
            {
              //  return;
            }
        }
    }
}
