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
using System.Data;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.IO;

namespace FastFoodDemo.PL
{
    public partial class FORM_RESTORE : Form
    {
        SqlConnection cn = new SqlConnection(@"Server = " + Program.SERVER_NAME + "; DataBase=SilahWarehouse; Integrated Security= false; USER ID =" + Program.userid + ";PASSWORD =" + Program.pass + "");
        SqlCommand cmd;
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        public FORM_RESTORE()
        {
            InitializeComponent();

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            string path = Path.GetPathRoot(Environment.SystemDirectory);
            openFileDialog1.Filter = "backup|*.bak";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string directoryPath = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);              
               
                if (directoryPath.Contains(path))
                {
                    MessageBox.Show("يجب وضع النسخة في موقع مغاير لقرص النظام \n Divê kopî li cihekî cudayî cihê sîstemê bê danîn", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtpath.Text = openFileDialog1.FileName;
            }
        }



        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpath.Text != string.Empty)
                {
                    this.Cursor = Cursors.WaitCursor;
                    string strQury = " Alter DataBase SilahWarehouse set offline with Rollback Immediate; Restore DataBase SilahWarehouse From Disk = '" + txtpath.Text + "'WITH REPLACE";
                    cmd = new SqlCommand(strQury, cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand(" Alter DataBase SilahWarehouse set online with Rollback Immediate", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "استعادة نسخة احتياطية", "استعادة نسخة احتياطية", DateTime.Now);


                    MessageBox.Show("تم استعادة نسخة احتياطية بنجاح \n Çalakiya Kopya Yedek Vegerîne Bi Serkeftî Bi Dawî Bû", "نسخة احتياطية - Kopya Yedek Vegerîne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("يجب اختيار ملف الاستعادة \n Divê pelê hilbijêrin ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch
            {
                cn.Close();
                cn.Open();
                cmd = new SqlCommand(" Alter DataBase SilahWarehouse set online with Rollback Immediate", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("يجب اختيار ملف صحيح \n Divê pelê hilbijêrin ", "hişyarî - تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FORM_RESTORE_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("استعادة النسخ الاحتياطي", ar);
                btnBrows.Text = rm.GetString("اختيار النسخة", ar);
                btnBackup.Text = rm.GetString("استعادة", ar);
                btnClose.Text = rm.GetString("خروج", ar);
            }
        }
    }
}
