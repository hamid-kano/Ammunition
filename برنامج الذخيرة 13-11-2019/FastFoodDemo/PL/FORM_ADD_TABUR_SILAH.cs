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
namespace FastFoodDemo.PL
{
    public partial class FORM_ADD_TABUR_SILAH : Form
    {
        FolderBrowserDialog dlg = new FolderBrowserDialog();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.SOURC_CLS SOURCE = new BL.SOURC_CLS();
        public FORM_ADD_TABUR_SILAH()
        {
            InitializeComponent();

            CBOXTYPE.Text = "مجلد للعنصر";
            DGVDOCS.DataSource = SOURCE.GET_MEM_DOCS_BY_MEM_IDEN(Program.MEM_IDEN);
            DGVDOCS.Columns[0].Visible = false;
            DGVDOCS.Columns[1].Visible = false;
            DGVDOCS.Columns[2].Visible = false;
            DGVDOCS.Columns[4].Visible = false;
            DGVDOCS.Columns[5].Visible = false;
            DGVDOCS.Columns[6].Visible = false;
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
            DialogResult dres = dlg.ShowDialog();

            if (dres != DialogResult.Cancel)
            {
                TXTPATH.Text = dlg.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TXTPATH.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار مكان الحفظ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnBrowe.Focus();
                return;
            }
            //if (TXTNAME.Text == string.Empty)
            //{
            //    MessageBox.Show("يجب إدخال اسم الملف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    TXTNAME.Focus();
            //    return;
            //}

            int COUNT = 0;
            for (int i = 0; i < DGVDOCS.Rows.Count; i++)
            {
                if (DGVDOCS.Rows[i].Cells[3].Value.ToString() == CBOXTYPE.Text &&
                    DGVDOCS.Rows[i].Cells[3].Value.ToString() == Program.MEM_CODENAME + "_" + Program.MEM_NAME + " " + Program.MEM_LNAME)
                {
                    COUNT++;
                    break;
                }
            }
            if (COUNT > 0)
            {
                MessageBox.Show("المجلد موجود مسبقاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            /// byte[] FileData = ReadFile(TXTPATH.Text);
            ///

            if ((!Directory.Exists(TXTPATH.Text + "\\" + CBOXTYPE.Text)) && ((!Directory.Exists(TXTPATH.Text + "\\" + Program.MEM_CODENAME + "_" + Program.MEM_NAME + " " + Program.MEM_LNAME))))
            {
                if (CBOXTYPE.Text == "مجلد للعنصر")
                {
                    Directory.CreateDirectory(TXTPATH.Text + "\\" + Program.MEM_CODENAME + "_" + Program.MEM_NAME + " " + Program.MEM_LNAME);
                    SOURCE.ADD_FOLDER(Program.APP_IDEN, Program.MEM_IDEN, Program.MEM_CODENAME + "_" + Program.MEM_NAME + " " + Program.MEM_LNAME,
                        TXTPATH.Text + "\\" + Program.MEM_CODENAME + "_" + Program.MEM_NAME + " " + Program.MEM_LNAME, Program.APP_IDEN, 0);
                }
                if (CBOXTYPE.Text == "صورة السجل")
                {
                    // Directory.CreateDirectory(TXTPATH.Text + "\\" + Program.MEM_CODENAME);
                    OpenFileDialog OP = new OpenFileDialog();
                    if (OP.ShowDialog() == DialogResult.OK)
                    {
                        TXTPATH.Text = OP.FileName;

                    }

                    SOURCE.ADD_FOLDER(Program.APP_IDEN, Program.MEM_IDEN, CBOXTYPE.Text,
                        TXTPATH.Text, Program.APP_IDEN, 0);
                }
                if (CBOXTYPE.Text != "صورة السجل" && CBOXTYPE.Text != "مجلد للعنصر")
                {
                    Directory.CreateDirectory(TXTPATH.Text + "\\" + CBOXTYPE.Text);
                    SOURCE.ADD_FOLDER(Program.APP_IDEN, Program.MEM_IDEN, CBOXTYPE.Text,
                                      TXTPATH.Text + "\\" + CBOXTYPE.Text, Program.APP_IDEN, 0);
                }
            }
            else
            {
                MessageBox.Show("يوجد مجلد بنفس الاسم في المسار المحدد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة", "إضافة مجلد : " + CBOXTYPE.Text + " " + "للعنصر " + Program.MEM_CODENAME, DateTime.Now);
            MessageBox.Show("تمت عملية الإضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TXTPATH.Clear();
            CBOXTYPE.Text = "مجلد للعنصر";
            BTNSHOW.Enabled = false;
            BTNDELETE.Enabled = false;
            DGVDOCS.DataSource = SOURCE.GET_MEM_DOCS_BY_MEM_IDEN(Program.MEM_IDEN);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DGVDOCS_Click(object sender, EventArgs e)
        {
            BTNSHOW.Enabled = true;
            BTNDELETE.Enabled = true;
        }

        private void BTNSHOW_Click(object sender, EventArgs e)
        {
            //DataTable dt_get_filedata = SOURCE.GET_MEM_DOCS(Convert.ToInt32(DGVDOCS.CurrentRow.Cells[0].Value.ToString()));
            //saveFileDialog1.FileName = DGVDOCS.CurrentRow.Cells[3].Value.ToString() + dt_get_filedata.Rows[0][1];
            //string filename = DGVDOCS.CurrentRow.Cells[3].Value.ToString() + " " + Program.MEM_CODENAME + dt_get_filedata.Rows[0][1];
            //byte[] filedata = (byte[])dt_get_filedata.Rows[0][0];
            //string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            //foreach (var c in invalid)
            //{
            //    filename = filename.Replace(c.ToString(), "_");
            //}
            //using (FileStream fs = new FileStream(filename, FileMode.Create))
            //{
            //    fs.Write(filedata, 0, filedata.Length);

            //    fs.Close();
            //}
            string PATH = DGVDOCS.CurrentRow.Cells[4].Value.ToString();

            if (DGVDOCS.CurrentRow.Cells[3].Value.ToString() == "صورة السجل")
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
                    MessageBox.Show("المجلد غير موجود في المسار المحفوظ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            //System.Diagnostics.Process.Start(@PATH);
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد الحذف؟؟", "الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                SOURCE.DELETE_MEM_DOCS(Convert.ToInt32(DGVDOCS.CurrentRow.Cells[0].Value.ToString()));

                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف", "حذف المجلد : " + DGVDOCS.CurrentRow.Cells[3].Value.ToString() + " " + "للعنصر " + Program.MEM_CODENAME, DateTime.Now);
                MessageBox.Show("تمت عملية الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DGVDOCS.DataSource = SOURCE.GET_MEM_DOCS_BY_MEM_IDEN(Program.MEM_IDEN);
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
    }
}
