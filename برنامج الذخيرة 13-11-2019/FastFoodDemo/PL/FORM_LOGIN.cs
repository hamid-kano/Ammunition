using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Configuration;

namespace FastFoodDemo.PL
{
    public partial class FORM_LOGIN : Form
    {
        BL.USERS_CLS USER = new BL.USERS_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public FORM_LOGIN()
        {
            InitializeComponent();
            textBox1.Focus();


            txtServerName.Text = config.AppSettings.Settings["ServerName"].Value;
            TXTUSER.Text = config.AppSettings.Settings["UserName"].Value;
            TXTPASS.Text = config.AppSettings.Settings["Password"].Value;

            string root = @"C:\AraratFiless";
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            root = @"C:\AraratProgramFiles";
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            //string path = Application.StartupPath;
            //FileStream fs = new FileStream("C:\\AraratFiless" + "\\file.txt", FileMode.OpenOrCreate);
            //StreamReader sr = new StreamReader(fs);
            //txtServerName.Text = sr.ReadToEnd();
            //sr.Close();


            //FileStream fs_user = new FileStream("C:\\AraratFiless" + "\\file1.txt", FileMode.OpenOrCreate);
            //StreamReader sw_user = new StreamReader(fs_user);
            //TXTUSER.Text = sw_user.ReadToEnd();
            //sw_user.Close();

            //FileStream fs_PASS = new FileStream("C:\\AraratFiless" + "\\file2.txt", FileMode.OpenOrCreate);
            //StreamReader sw_PASS = new StreamReader(fs_PASS);
            //TXTPASS.Text = sw_PASS.ReadToEnd();
            //sw_PASS.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void TXTUserName_Enter(object sender, EventArgs e)
        {
            if (TXTUserName.Text == "UserName")
            {
                TXTUserName.Text = "";
                TXTUserName.ForeColor = Color.Black;
            }
        }

        private void TXTUserName_Leave(object sender, EventArgs e)
        {
            if (TXTUserName.Text == "")
            {
                TXTUserName.Text = "UserName";
                TXTUserName.ForeColor = Color.Gray;
            }
        }

        private void TXTPassword_Enter(object sender, EventArgs e)
        {
            TXTPassword.PasswordChar = '*';

            if (TXTPassword.Text == "Password")
            {
                TXTPassword.Text = "";
                TXTPassword.ForeColor = Color.Black;
            }
        }

        private void TXTPassword_Leave(object sender, EventArgs e)
        {
            if (TXTPassword.Text == "")
            {
                TXTPassword.PasswordChar = '\0';
                TXTPassword.Text = "Password";
                TXTPassword.ForeColor = Color.Gray;
            }
        }

        private void BTNE_Click(object sender, EventArgs e)
        {
            try
            {
            if (TXTUserName.Text == string.Empty || TXTUserName.Text.TrimEnd(' ') == "UserName")
            {
                MessageBox.Show("يجب إدخال اسم المستخدم - Navê bikarhêner binivîse - Navê bikarhêner binivîse ", "Hişyarî", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTUserName.Focus();
                return;
            }
            else if (TXTPassword.Text == string.Empty || TXTPassword.Text.TrimEnd(' ') == "Password")
            {
                MessageBox.Show("يجب إدخال كلمة السر - Şîfreya binivîse  ", "Hişyarî", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTPassword.Focus();
                return;
            }
            else if (txtServerName.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم السيرفر - Navê Server binivîse", "Hişyarî", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtServerName.Focus();
                return;
            }
            else if (TXTUSER.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال مستخدم البيانات - Navê bikarhêner-data binivîse", "Hişyarî", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTUSER.Focus();
                return;
            }
            else if (TXTPASS.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال كلمة السر - Şîfreya binivîse", "Hişyarî", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTPASS.Focus();
                return;
            }
            else
            {
                Program.SERVER_NAME = txtServerName.Text.TrimEnd(' ');
                Program.RPT_SERVER_NAME = txtServerName.Text.TrimEnd(' ');
                Program.userid = TXTUSER.Text.TrimEnd(' ');
                Program.pass = TXTPASS.Text.TrimEnd(' ');
                if (!IsServerConnected(@"Server = " + Program.SERVER_NAME + "; DataBase=SilahWarehouse; Integrated Security= false; USER ID =" + Program.userid + ";PASSWORD =" + Program.pass + ""))
                {
                    MessageBox.Show("الرجاء التأكد من اسم السيرفر واسم المستخدم وكلمة المرور الخاصة بالسيرفر , وان الخدمة تعمل بشكل صحيح \n Ji kerema xwe ra careka din ji navê sêrver, bikarhêner û pasworda taybet bi sêrverê teqez bike, û eger xizmet bi saxlemî kar dike. ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    config.AppSettings.Settings["ServerName"].Value = txtServerName.Text;
                    config.AppSettings.Settings["UserName"].Value = TXTUSER.Text;
                    config.AppSettings.Settings["Password"].Value = TXTPASS.Text;
                    config.Save(ConfigurationSaveMode.Modified, true);
                    ConfigurationManager.RefreshSection("appSettings");
                   

                    //FastFoodDemo.Properties.Settings.Default.serverName = txtServerName.Text;
                    //FastFoodDemo.Properties.Settings.Default.userName = TXTUSER.Text;
                    //FastFoodDemo.Properties.Settings.Default.passWord = TXTPASS.Text;
                    //FastFoodDemo.Properties.Settings.Default.Save();
                    DataTable DT_USERS = USER.GET_USERS_FOR_LOGIN(TXTUserName.Text.TrimEnd(' ').ToLower(), TXTPassword.Text.TrimEnd(' ').ToLower());
                    if (DT_USERS.Rows.Count == 0)
                    {
                        MessageBox.Show("يوجد خطأ في كلمة السر أو اسم المستخدم..تأكد من البيانات المُدخلة \n Çewtiya şîfreya an navê bikarhêner nehat dîtin ", "Hişyarî", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TXTUserName.Focus();
                        return;
                    }

                    //if (RBTN_ARABIC.Checked == false && RBTN_KURDI.Checked == false)
                    //{
                    //    MessageBox.Show("يجب اختيار اللغة - Ziman Derbasbike", "Hişyarî", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);               
                    //    return;
                    //}
                    if (DT_USERS.Rows.Count > 0)
                    {
                        Program.login = 1;
                        Program.USER_ID = Convert.ToInt32(DT_USERS.Rows[0][0].ToString());
                        Program.USER_IDEN = Convert.ToInt32(DT_USERS.Rows[0][0].ToString());
                        Program.USER_FULL_NAME = DT_USERS.Rows[0][2].ToString();
                        Program.USER_NAME_LOGIN = DT_USERS.Rows[0][3].ToString();
                        Program.PASSWORD = DT_USERS.Rows[0][4].ToString();

                        if (Convert.ToInt32(DT_USERS.Rows[0][5].ToString()) == 1)
                        {
                            FORM_MAIN1.getMainForm.BTN_BASIC.Enabled = true;
                        }
                        if (Convert.ToInt32(DT_USERS.Rows[0][6].ToString()) == 1)
                        {
                            FORM_MAIN1.getMainForm.BTN_BCKP.Enabled = true;
                        }
                        if (Convert.ToInt32(DT_USERS.Rows[0][7].ToString()) == 1)
                        {
                            FORM_MAIN1.getMainForm.BTN_RSTR.Enabled = true;
                        }
                        if (Convert.ToInt32(DT_USERS.Rows[0][8].ToString()) == 1)
                        {
                            FORM_MAIN1.getMainForm.BTN_USERS.Enabled = true;
                        }
                        if (Convert.ToInt32(DT_USERS.Rows[0][9].ToString()) == 1)
                        {
                            FORM_MAIN1.getMainForm.BTN_MYPROFILE.Enabled = true;
                        }
                        if (Convert.ToInt32(DT_USERS.Rows[0][10].ToString()) == 1)
                        {
                            FORM_MAIN1.getMainForm.BTN_ACTIONS.Enabled = true;
                        }
                        //if (Convert.ToInt32(DT_USERS.Rows[0][11].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTNADDMEM.Enabled = true;

                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][12].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTNMEMMNG.Enabled = true;

                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][13].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTNIQLIM.Enabled = true;
                        //}

                        //if (Convert.ToInt32(DT_USERS.Rows[0][14].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTNMNTKA.Enabled = true;
                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][15].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTNLOAA.Enabled = true;
                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][16].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTNFAOJ.Enabled = true;
                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][17].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTNKTEBA.Enabled = true;
                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][18].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTNFORCE.Enabled = true;
                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][19].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTN_EXPORT.Enabled = true;
                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][20].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTN_IMPORT.Enabled = true;
                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][21].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTN_DELETED.Enabled = true;
                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][22].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTN_REPORT.Enabled = true;
                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][23].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTN_REPORT2.Enabled = true;

                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][24].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTN_SOURCES.Enabled = true;
                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][25].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTN_ALGHANAEM.Enabled = true;
                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][26].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTN_MUSADRA.Enabled = true;
                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][27].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTN_ORDERS.Enabled = true;
                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][28].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTN_CATEGRY.Enabled = true;
                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][29].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTN_IMP_EXP_SILAH.Enabled = true;
                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][30].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTN_SILAH_WAREHOUSE.Enabled = true;
                        //}
                        //if (Convert.ToInt32(DT_USERS.Rows[0][31].ToString()) == 1)
                        //{
                        //    FORM_MAIN1.getMainForm.uC_FORTH1.BTN_SILAH.Enabled = true;
                        //}
                        DataTable DT_SETTING = MEM.GET_FROM_SETINNG();
                        if (DT_SETTING.Rows.Count == 0)
                        {
                            MessageBox.Show("قم بإدخال رمز التطبيق  - Şîfreya Pername  binivîse", "Hişyarî", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            FORM_SETTING FRM = new FORM_SETTING();
                            FRM.ShowDialog();
                            Close();
                            return;
                        }
                        // إنشاء مجلد 
                        //string root = @"C:\AraratFiless";
                        //// If directory does not exist, create it. 
                        //if (!Directory.Exists(root))
                        //{
                        //    Directory.CreateDirectory(root);
                        //}
                        //string path = Application.StartupPath;
                        //FileStream fs = new FileStream("C:\\AraratFiless" + "\\file.txt", FileMode.OpenOrCreate);
                        //StreamWriter sw = new StreamWriter(fs);
                        //sw.Write(txtServerName.Text);
                        //sw.Close();

                        //FileStream fs_user = new FileStream("C:\\AraratFiless" + "\\file1.txt", FileMode.OpenOrCreate);
                        //StreamWriter sw_user = new StreamWriter(fs_user);
                        //sw_user.Write(TXTUSER.Text);
                        //sw_user.Close();

                        //FileStream fs_PASS = new FileStream("C:\\AraratFiless" + "\\file2.txt", FileMode.OpenOrCreate);
                        //StreamWriter sw_PASS = new StreamWriter(fs_PASS);
                        //sw_PASS.Write(TXTPASS.Text);
                        //sw_PASS.Close();


                        Program.APP_IDEN = DT_SETTING.Rows[0][0].ToString();
                        MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تسجيل الدخول", "تسجيل الدخول :  " + TXTUserName.Text, DateTime.Now);
                        FORM_MAIN1.getMainForm.Visible = true;
                        this.Close();
                    }

                }
            }
            }
            catch (Exception)
            {
              MessageBox.Show("You must run program as administrator or \n install program another disk than system", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              //  throw;
            }
        }

        private void TXTUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FORM_LOGIN_Load(object sender, EventArgs e)
        {
           
        }

        private void txtServerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtServerName_Enter(object sender, EventArgs e)
        {
            if (TXTUserName.Text == "ServerName")
            {
                TXTUserName.Text = "";
                TXTUserName.ForeColor = Color.Black;
            }
        }

        private void TXTPASS_Enter(object sender, EventArgs e)
        {
            if (TXTPASS.Text == "Password")
            {
                TXTPASS.Text = "";
                TXTPASS.ForeColor = Color.Black;
            }
        }

        private void TXTUSER_Enter(object sender, EventArgs e)
        {
            if (TXTUSER.Text == "User")
            {
                TXTUSER.Text = "";
                TXTUSER.ForeColor = Color.Black;
            }
        }

        private void txtServerName_Leave(object sender, EventArgs e)
        {
            TXTPassword.PasswordChar = '*';

            if (TXTPassword.Text == "ServerName")
            {
                TXTPassword.Text = "";
                TXTPassword.ForeColor = Color.Black;
            }
        }

        private void TXTPASS_Leave(object sender, EventArgs e)
        {
            TXTPassword.PasswordChar = '*';

            if (TXTPassword.Text == "Password")
            {
                TXTPassword.Text = "";
                TXTPassword.ForeColor = Color.Black;
            }
        }

        private void TXTUSER_Leave(object sender, EventArgs e)
        {
            TXTPassword.PasswordChar = '*';

            if (TXTPassword.Text == "User")
            {
                TXTPassword.Text = "";
                TXTPassword.ForeColor = Color.Black;
            }
        }

        private static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }


    }
}

