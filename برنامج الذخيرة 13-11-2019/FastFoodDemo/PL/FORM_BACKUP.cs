using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Resources;
using System.Reflection;
using System.IO;

namespace FastFoodDemo.PL
{
    public partial class FORM_BACKUP : Form
    {
        SqlConnection cn = new SqlConnection(@"Server = " + Program.SERVER_NAME + "; DataBase=SilahWarehouse; Integrated Security= false; USER ID =" + Program.userid + ";PASSWORD =" + Program.pass + "");
        SqlCommand cmd;
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        public FORM_BACKUP()
        {
            InitializeComponent();

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            string path = Path.GetPathRoot(Environment.SystemDirectory);
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath.Contains(path))
                {
                    MessageBox.Show("يجب اختيار موقع مغاير لقرص النظام \n Divê kopî li cihekî cudayî cihê sîstemê bê danîn", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtpath.Text = folderBrowserDialog1.SelectedPath;
            }
        }


        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (txtpath.Text != string.Empty)
            {
                this.Cursor = Cursors.WaitCursor;
                string filename = txtpath.Text + "\\SilahWarehouse" + DateTime.Now.ToShortDateString().Replace('/', '-') + "---" +
                DateTime.Now.ToLongTimeString().Replace(':', '-');
                string strQury = "Backup  DataBase SilahWarehouse to Disk ='" + filename + ".bak'";
                cmd = new SqlCommand(strQury, cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "نسخ احتياطي", "إنشاء نسخة احتياطية", DateTime.Now);

                MessageBox.Show("تم إنشاء نسخة احتياطية بنجاح \n Çalakiya Kopya Yedek Bi Serkeftî Bi Dawî Bû", "نسخة احتياطية - Kopya Yedek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("يجب اختيار مكان الحفظ \n Cihê Qeydkirinê Diyar Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void FORM_BACKUP_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("النسخ الاحتياطي", ar);
                btnBrows.Text = rm.GetString("مكان الحفظ", ar);
                btnBackup.Text = rm.GetString("استعادة النسخ الاحتياطي", ar);               
                btnClose.Text = rm.GetString("خروج", ar);
               
            }
        }
    }
}
