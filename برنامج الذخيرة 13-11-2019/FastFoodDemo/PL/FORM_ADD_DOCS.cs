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
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace FastFoodDemo.PL
{
    public partial class FORM_ADD_DOCS : Form
    {
        FolderBrowserDialog dlg = new FolderBrowserDialog();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.SOURC_CLS SOURCE = new BL.SOURC_CLS();
        public FORM_ADD_DOCS()
        {
            InitializeComponent();

            DGVDOCS.DataSource = MEM.GET_FOLDER_BY_MEM_ID(Program.MEM_IDEN);
            DGVDOCS.Columns[0].Visible = false;
            DGVDOCS.Columns[2].Visible = false;
            DGVDOCS.Columns[3].Visible = false;
            DGVDOCS.Columns[4].Visible = false;
            DGVDOCS.Columns[5].Visible = false;

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        byte[] ReadFile(string path)
        {
            byte[] data = null;
            FileInfo finfo = new FileInfo(path);
            long numBytes = finfo.Length;
            FileStream fstream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            data = br.ReadBytes((int)numBytes);
            br.Close();
            fstream.Close();
            return data;

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DGVDOCS_Click(object sender, EventArgs e)
        {
            //BTNSHOW.Enabled = true;
            //BTNDELETE.Enabled = true;
        }

        private void BTNSHOW_Click(object sender, EventArgs e)
        {           
            string PATH = DGVDOCS.CurrentRow.Cells[2].Value.ToString();

            if (DGVDOCS.CurrentRow.Cells[1].Value.ToString() == "صورة السجل" || DGVDOCS.CurrentRow.Cells[1].Value.ToString() == "رخصة السلاح")
            {

                System.Diagnostics.Process.Start(@PATH);
            }


            else
            {

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = PATH,
                    FileName = "explorer.exe",
                };
                if (Directory.Exists(PATH))
                {
                    Process.Start(startInfo);
                }
                else
                {
                    MessageBox.Show("المجلد غير موجود في المسار المحفوظ \n Klasor Di Cihê Qeyid Kirinê De Tuneye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MEM.DELETE_MEM_FOLDER(Convert.ToInt32(DGVDOCS.CurrentRow.Cells[0].Value.ToString()));

                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "Jêbirinê - الحذف", "حذف المجلد : " + DGVDOCS.CurrentRow.Cells[3].Value.ToString() + " " + "للعنصر " + Program.MEM_CODENAME, DateTime.Now);
                MessageBox.Show("تمت عملية الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DGVDOCS.DataSource = MEM.GET_FOLDER_BY_MEM_ID(Program.MEM_IDEN);
                BTNDELETE.Enabled = false;
                BTNSHOW.Enabled = false;
            }
        }

        private void DGVDOCS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < DGVDOCS.Rows.Count; i++)
            {
                if (DGVDOCS.Rows[i].Index % 2 == 0)
                {
                    DGVDOCS.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171, 125, 47);
                }
            }
        }

        private void FORM_ADD_DOCS_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text= rm.GetString("اضافة وثائق", ar);
                BTNSHOW.Text = rm.GetString("فتح", ar);
                BTNDELETE.Text = rm.GetString("حذف", ar);
                button2.Text = rm.GetString("خروج", ar);

            }
        }

        private void DGVDOCS_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

            BTNSHOW.Enabled = true;
            BTNDELETE.Enabled = true;

            }
            catch (Exception)
            {

           //     throw;
            }
        }
    }
}
