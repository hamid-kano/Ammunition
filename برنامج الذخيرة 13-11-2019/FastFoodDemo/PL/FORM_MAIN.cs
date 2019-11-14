using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Globalization;
using System.Reflection;
using System.Resources;
using FastFoodDemo.PL;
using System.Configuration;

namespace FastFoodDemo
{
    public partial class FORM_MAIN1 : Form
    {
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();


        private static FORM_MAIN1 frm;
        System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FORM_MAIN1 getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_MAIN1();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
        }


        public FORM_MAIN1()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;

            SidePanel.Height = BTN_BASIC.Height;
            SidePanel.Top = BTN_BASIC.Top;
         
            //  uC_MAIN1.BringToFront();


            //uC_ABOUT_US1.BringToFront();

            //if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            //{
            //    this.RightToLeft = RightToLeft.No;
            //}

        }
        private void playaudio() // defining the function
        {

            SoundPlayer audio = new SoundPlayer(FastFoodDemo.Properties.Resources.Mem_Ararat); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();

        }
        private void stopaudio() // defining the function
        {

            SoundPlayer audio = new SoundPlayer(FastFoodDemo.Properties.Resources.Mem_Ararat); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Stop();

        }
        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBLTIME.Text = DateTime.Now.ToString("HH:mm:ss dddd dd MMM yyyy");
           

            //  LBLSECOND.Text = DateTime.Now.ToString("ss");
            // LBLDATE.Text = DateTime.Now.ToString("MMM dd yyyy");
            // LBLDAY.Text = DateTime.Now.ToString("dddd");
            //LBLSECOND.Location = new Point(LBLTIME.Location.X + LBLTIME.Width, LBLSECOND.Location.Y); 
        }
        private void button14_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BTN_BCKP.Height;
            SidePanel.Top = BTN_BCKP.Top;
            PL.FORM_BACKUP FRM = new PL.FORM_BACKUP();
            FRM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BTN_RSTR.Height;
            SidePanel.Top = BTN_RSTR.Top;
            PL.FORM_RESTORE FRM = new PL.FORM_RESTORE();
            FRM.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BTN_MYPROFILE.Height;
            SidePanel.Top = BTN_MYPROFILE.Top;
            PL.FORM_MY_PROFILE FRM = new PL.FORM_MY_PROFILE();
            FRM.ShowDialog();
        }

        private void BTNUSERS_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BTN_USERS.Height;
            SidePanel.Top = BTN_USERS.Top;
            PL.FORM_USERS FRM = new PL.FORM_USERS();
            FRM.ShowDialog();
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //  MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تسجيل الخروج", "تسجيل الخروج :  " + Program.USER_NAME_LOGIN, DateTime.Now);
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FORM_MAIN_Load(object sender, EventArgs e)
        {
            if (Program.login != 1)
            {
                PL.FORM_LOGIN FRM = new PL.FORM_LOGIN();
                
                if (FastFoodDemo.Properties.Settings.Default.lang == "ar-AR")
                {
                    FORM_MAIN1.getMainForm.RightToLeft = RightToLeft.Yes;
                    button1.Text = "Kurdi";
                }
                else
                {
                    FORM_MAIN1.getMainForm.RightToLeft = RightToLeft.No;
                    button1.Text = "  العربية";
                }
                FORM_MAIN1.getMainForm.Visible = false;
                FRM.ShowDialog();


            }
           

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                BTNMAIN.Text = "  Serrûpela";// rm.GetString("الرئيسية", ar);
                BTN_BASIC.Text = "  Operasiyon";// rm.GetString("العمليات", ar);
                BTN_BCKP.Text = "  Kopya Yedek";// rm.GetString("النسخ الاحتياطي", ar);
                BTN_RSTR.Text = "  Kopya Yedek Vegerîne";// rm.GetString("استعادة النسخ الاحتياطي", ar);
                BTN_USERS.Text = "  Bikarhînerê Bernameyê";// rm.GetString("مستخدموا البرنامج", ar);
                BTN_MYPROFILE.Text = "  Profîl";// rm.GetString("الملف الشخصي", ar);
                BTN_ACTIONS.Text = "  Çalakiyên Bikarhêneran";// rm.GetString("نشاطات المستخدمين", ar);
                button6.Text = "  Em Kîne"; // rm.GetString("من نحن", ar);
                /////// buttons operations
                BTNIQLIM.Text = rm.GetString("الاقاليم", ar);
                BTNMNTKA.Text = rm.GetString("المناطق", ar);
                BTNLOAA.Text = rm.GetString("الالوية", ar);
                BTNFAOJ.Text = rm.GetString("الافواج", ar);
                BTNKTEBA.Text = rm.GetString("الكتائب", ar);
                BTNFORCE.Text = rm.GetString("القوات", ar);
                BTN_CATEGRY.Text = rm.GetString("الاصناف", ar);
                BTN_SILAH.Text = rm.GetString("الاسلحة", ar);
                BTN_SILAH_WAREHOUSE.Text = rm.GetString("مستودع الاسلحة", ar);
                BTN_IMP_EXP_SILAH.Text = rm.GetString("تصدير واستيراد السلاح", ar);
                BTN_REPORT.Text = rm.GetString("التقارير 1", ar);
                BTN_REPORT2.Text = rm.GetString("التقارير 2", ar);
                BTNMEMMNG.Text = rm.GetString("ادارة بيانات المقاتلين", ar);
                BTNADDMEM.Text = rm.GetString("اضافة مقاتل", ar);
                BTN_ORDERS.Text = rm.GetString("الطلبات", ar);
                BTN_MUSADRA.Text = rm.GetString("المصادرات", ar);
                BTN_SOURCES.Text = rm.GetString("الجهات", ar);
                BTN_ALGHANAEM.Text = rm.GetString("الغنائم", ar);
                BTN_EXPORT.Text = rm.GetString("تصدير البيانات", ar);
                BTN_IMPORT.Text = rm.GetString("استيراد البيانات", ar);
                BTN_DELETED.Text = rm.GetString("المحذوفات", ar);
                button2.Text = rm.GetString("الكتائب", ar);

            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/AraratOutline");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitter.com/AraratOutline");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            playaudio();
            btn1.Visible = false;
            btn2.Visible = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            stopaudio();
            btn2.Visible = false;
            btn1.Visible = true;
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            if (getMainForm.RightToLeft == RightToLeft.No)
            {
                getMainForm.RightToLeft = RightToLeft.Yes;
                button1.Text = "Kurdi";
                FastFoodDemo.Properties.Settings.Default.lang = "ar-AR";
                FastFoodDemo.Properties.Settings.Default.Save();
                FastFoodDemo.Properties.Settings.Default.Reload();
                CultureInfo ar = new CultureInfo("ar-AR");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                BTNMAIN.Text = rm.GetString("الرئيسية", ar);
                BTN_BASIC.Text = rm.GetString("العمليات", ar);
                BTN_BCKP.Text = rm.GetString("النسخ الاحتياطي", ar);
                BTN_RSTR.Text = rm.GetString("استعادة النسخ الاحتياطي", ar);
                BTN_USERS.Text = rm.GetString("مستخدموا البرنامج", ar);
                BTN_MYPROFILE.Text = rm.GetString("الملف الشخصي", ar);
                BTN_ACTIONS.Text = rm.GetString("نشاطات المستخدمين", ar);
                button6.Text = rm.GetString("من نحن", ar);
                /////// buttons operations
                BTNIQLIM.Text = rm.GetString("الاقاليم", ar);
                BTNMNTKA.Text = rm.GetString("المناطق", ar);
                BTNLOAA.Text = rm.GetString("الالوية", ar);
                BTNFAOJ.Text = rm.GetString("الافواج", ar);
                BTNKTEBA.Text = rm.GetString("الكتائب", ar);
                BTNFORCE.Text = rm.GetString("القوات", ar);
                BTN_CATEGRY.Text = rm.GetString("الاصناف", ar);
                BTN_SILAH.Text = rm.GetString("الاسلحة", ar);
                BTN_SILAH_WAREHOUSE.Text = rm.GetString("مستودع الاسلحة", ar);
                BTN_IMP_EXP_SILAH.Text = rm.GetString("تصدير واستيراد السلاح", ar);
                BTN_REPORT.Text = rm.GetString("التقارير 1", ar);
                BTN_REPORT2.Text = rm.GetString("التقارير 2", ar);
                BTNMEMMNG.Text = rm.GetString("ادارة بيانات المقاتلين", ar);
                BTNADDMEM.Text = rm.GetString("اضافة مقاتل", ar);
                BTN_ORDERS.Text = rm.GetString("الطلبات", ar);
                BTN_MUSADRA.Text = rm.GetString("المصادرات", ar);
                BTN_SOURCES.Text = rm.GetString("الجهات", ar);
                BTN_ALGHANAEM.Text = rm.GetString("الغنائم", ar);
                BTN_EXPORT.Text = rm.GetString("تصدير البيانات", ar);
                BTN_IMPORT.Text = rm.GetString("استيراد البيانات", ar);
                BTN_DELETED.Text = rm.GetString("المحذوفات", ar);
                button2.Text = rm.GetString("الكتائب", ar);


            }
            else
            {
                getMainForm.RightToLeft = RightToLeft.No;
                button1.Text = "  العربية";
                FastFoodDemo.Properties.Settings.Default.lang = "ku-KU";
                FastFoodDemo.Properties.Settings.Default.Save();
                FastFoodDemo.Properties.Settings.Default.Reload();
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                BTNMAIN.Text = "  Serrûpela";// rm.GetString("الرئيسية", ar);
                BTN_BASIC.Text = "  Operasiyon";// rm.GetString("العمليات", ar);
                BTN_BCKP.Text = "  Kopya Yedek";// rm.GetString("النسخ الاحتياطي", ar);
                BTN_RSTR.Text = "  Kopya Yedek Vegerîne";// rm.GetString("استعادة النسخ الاحتياطي", ar);
                BTN_USERS.Text = "  Bikarhînerê Bernameyê";// rm.GetString("مستخدموا البرنامج", ar);
                BTN_MYPROFILE.Text = "  Profîl";// rm.GetString("الملف الشخصي", ar);
                BTN_ACTIONS.Text = "  Çalakiyên Bikarhêneran";// rm.GetString("نشاطات المستخدمين", ar);
                button6.Text = "  Em Kîne"; // rm.GetString("من نحن", ar);
                /////// buttons operations
                BTNIQLIM.Text = rm.GetString("الاقاليم", ar);
                BTNMNTKA.Text = rm.GetString("المناطق", ar);
                BTNLOAA.Text = rm.GetString("الالوية", ar);
                BTNFAOJ.Text = rm.GetString("الافواج", ar);
                BTNKTEBA.Text = rm.GetString("الكتائب", ar);
                BTNFORCE.Text = rm.GetString("القوات", ar);
                BTN_CATEGRY.Text = rm.GetString("الاصناف", ar);
                BTN_SILAH.Text = rm.GetString("الاسلحة", ar);
                BTN_SILAH_WAREHOUSE.Text = rm.GetString("مستودع الاسلحة", ar);
                BTN_IMP_EXP_SILAH.Text = rm.GetString("تصدير واستيراد السلاح", ar);
                BTN_REPORT.Text = rm.GetString("التقارير 1", ar);
                BTN_REPORT2.Text = rm.GetString("التقارير 2", ar);
                BTNMEMMNG.Text = rm.GetString("ادارة بيانات المقاتلين", ar);
                BTNADDMEM.Text = rm.GetString("اضافة مقاتل", ar);
                BTN_ORDERS.Text = rm.GetString("الطلبات", ar);
                BTN_MUSADRA.Text = rm.GetString("المصادرات", ar);
                BTN_SOURCES.Text = rm.GetString("الجهات", ar);
                BTN_ALGHANAEM.Text = rm.GetString("الغنائم", ar);
                BTN_EXPORT.Text = rm.GetString("تصدير البيانات", ar);
                BTN_IMPORT.Text = rm.GetString("استيراد البيانات", ar);
                BTN_DELETED.Text = rm.GetString("المحذوفات", ar);
                button2.Text = rm.GetString("الكتائب", ar);

               
            }


        }

        private void UC_FORTH1_Load_1(object sender, EventArgs e)
        {

        }
        private void BTNPARTYMNG_Click(object sender, EventArgs e)
        {
            FORM_STATISTIC_MEMBERS FRM = new FORM_STATISTIC_MEMBERS();
            FRM.ShowDialog();
        }





        private void BTNMOVE_Click(object sender, EventArgs e)
        {
            FORM_KTEBA FRM = new FORM_KTEBA();
            FRM.ShowDialog();
        }

        private void BTNSTA_Click(object sender, EventArgs e)
        {
            FORM_MANTKA FRM = new FORM_MANTKA();
            FRM.ShowDialog();
        }

       

        private void button1_Click_2(object sender, EventArgs e)
        {
            PL.FORM_SILAH_MNG FRM = new FORM_SILAH_MNG();
            FRM.ShowDialog();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            PL.FORM_CATEGORY frm = new FORM_CATEGORY();
            frm.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PL.FORM_SILAH_CATIGORY frm = new FORM_SILAH_CATIGORY();
            frm.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            PL.FORM_IMP_EXP frm = new FORM_IMP_EXP();
            frm.ShowDialog();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            FORM_GHANAEM FRM = new FORM_GHANAEM();
            FRM.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            FORM_ORDERS FRM = new FORM_ORDERS();
            FRM.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            FORM_CONFSCATION FRM = new FORM_CONFSCATION();
            FRM.ShowDialog();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            FORM_STATISTIC_SILAH FRM = new FORM_STATISTIC_SILAH();
            FRM.ShowDialog();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            FORM_SOURCE FRM = new FORM_SOURCE();
            FRM.ShowDialog();
        }

     

        private void BTN_EXPORT_Click(object sender, EventArgs e)
        {
            FORM_EXPORT_DATA FRM = new FORM_EXPORT_DATA();
            FRM.ShowDialog();
        }

       

        private void BTNIQLIM_Click(object sender, EventArgs e)
        {
            FORM_IQLIM FRM = new FORM_IQLIM();
            FRM.ShowDialog();

        }

        private void BTNMNTKA_Click(object sender, EventArgs e)
        {
            FORM_MANTKA FRM = new FORM_MANTKA();
            FRM.ShowDialog();
        }

        private void BTN_IMPORT_Click(object sender, EventArgs e)
        {
            FORM_IMPORT_DATA FRM = new FORM_IMPORT_DATA();
            FRM.ShowDialog();
        }

        private void BTNLOAA_Click(object sender, EventArgs e)
        {
            FORM_LOAA FRM = new FORM_LOAA();
            FRM.ShowDialog();
        }

        private void BTNFAOJ_Click(object sender, EventArgs e)
        {
            FORM_FAOJ FRM = new FORM_FAOJ();
            FRM.ShowDialog();
        }

        private void BTNKTEBA_Click(object sender, EventArgs e)
        {
            FORM_KTEBA FRM = new FORM_KTEBA();
            FRM.ShowDialog();
        }

        private void BTNFORCE_Click(object sender, EventArgs e)
        {
            FORM_FORCE FRM = new FORM_FORCE();
            FRM.ShowDialog();
        }

        private void BTN_CATEGRY_Click(object sender, EventArgs e)
        {
            FORM_CATEGORY FRM = new FORM_CATEGORY();
            FRM.ShowDialog();
        }

        private void BTN_SILAH_Click(object sender, EventArgs e)
        {
            PL.FORM_SILAH_CATIGORY frm = new FORM_SILAH_CATIGORY();
            frm.ShowDialog();
        }

        private void BTN_SILAH_WAREHOUSE_Click(object sender, EventArgs e)
        {
            PL.FORM_SILAH_MNG FRM = new FORM_SILAH_MNG();
            FRM.ShowDialog();
        }

        private void BTN_IMP_EXP_SILAH_Click(object sender, EventArgs e)
        {
            PL.FORM_IMP_EXP frm = new FORM_IMP_EXP();
            frm.ShowDialog();
        }

        private void BTN_MUSADRA_Click(object sender, EventArgs e)
        {
            FORM_CONFSCATION FRM = new FORM_CONFSCATION();
            FRM.ShowDialog();
        }

        private void BTN_ORDERS_Click(object sender, EventArgs e)
        {
            FORM_ORDERS FRM = new FORM_ORDERS();
            FRM.ShowDialog();
        }

        private void BTNADDMEM_Click(object sender, EventArgs e)
        {
            FORM_ADD_NEW_MEMBER FRM = new FORM_ADD_NEW_MEMBER();
            FRM.ShowDialog();
        }

        private void BTNMEMMNG_Click(object sender, EventArgs e)
        {
            FORM_MEM_MNG FRM = new FORM_MEM_MNG();
            FRM.ShowDialog();
        }

        private void BTN_SOURCES_Click(object sender, EventArgs e)
        {
            FORM_SOURCE FRM = new FORM_SOURCE();
            FRM.ShowDialog();
        }

        private void BTN_ALGHANAEM_Click(object sender, EventArgs e)
        {
            FORM_GHANAEM FRM = new FORM_GHANAEM();
            FRM.ShowDialog();
        }

        private void BTN_EXPORT_Click_1(object sender, EventArgs e)
        {
            FORM_EXPORT_DATA FRM = new FORM_EXPORT_DATA();
            FRM.ShowDialog();
        }

        private void BTN_DELETED_Click(object sender, EventArgs e)
        {
            FORM_RECYCLEBIN FRM =new FORM_RECYCLEBIN();
            FRM.ShowDialog();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            FORM_TABUR_SILAH_MNG FRM = new FORM_TABUR_SILAH_MNG();
            FRM.ShowDialog();
        }

        private void BTN_REPORT_Click(object sender, EventArgs e)
        {
            FORM_STATISTIC_MEMBERS FRM = new FORM_STATISTIC_MEMBERS();
            FRM.ShowDialog();
        }

        private void BTN_REPORT2_Click(object sender, EventArgs e)
        {
            FORM_STATISTIC_SILAH FRM = new FORM_STATISTIC_SILAH();
            FRM.ShowDialog();
        }

    

        private void BTNMAIN_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BTNMAIN.Height;
            SidePanel.Top = BTNMAIN.Top;
            Panel_Operations.Visible = false;
            panel3.BackgroundImage = Properties.Resources.pro_icon10;
            panel3.BringToFront();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BTN_BASIC.Height;
            SidePanel.Top = BTN_BASIC.Top;
            Panel_Operations.Visible = true;
            // uC_MAIN1.SendToBack();
            panel3.SendToBack();


        }
        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            Panel_Operations.Visible = false;
            panel3.BackgroundImage = Properties.Resources.alikari;
            panel3.BringToFront();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BTN_ACTIONS.Height;
            SidePanel.Top = BTN_ACTIONS.Top;            
            FORM_USERS_Actions fr_user_action = new FORM_USERS_Actions();
            fr_user_action.ShowDialog();
        }
    }
}
