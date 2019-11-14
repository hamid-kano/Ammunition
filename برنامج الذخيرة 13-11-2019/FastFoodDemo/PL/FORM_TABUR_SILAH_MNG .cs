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
    public partial class FORM_TABUR_SILAH_MNG  : Form
    {
        BL.SILAH_CLS SILAH = new BL.SILAH_CLS();
        BL.HEREM_CLS HER = new BL.HEREM_CLS();
        BL.TUGAY_CLS TUGAY = new BL.TUGAY_CLS();
        BL.EYALET_CLS EYALET = new BL.EYALET_CLS();
        BL.TABUR_CLS TABUR = new BL.TABUR_CLS();
        BL.ALAY_CLS ALAY = new BL.ALAY_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.SOURC_CLS SOURCE = new BL.SOURC_CLS();
        private static FORM_TABUR_SILAH_MNG  frm;
        FolderBrowserDialog dlg = new FolderBrowserDialog();
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FORM_TABUR_SILAH_MNG  getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_TABUR_SILAH_MNG();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
        }
        public FORM_TABUR_SILAH_MNG()
        {
            InitializeComponent();
            frm = this;
         
            CBOX_HER.DataSource = HER.GET_ALL_HEREM();
            CBOX_HER.DisplayMember = "اسم الإقليم";
            CBOX_HER.ValueMember = "رقم الإقليم";
            CBOXKATEBA.DataSource = TABUR.GET_ALL_TABUR();
            CBOXKATEBA.DisplayMember = "الكتيبة";
            CBOXKATEBA.ValueMember = "رقم الكتيبة";

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
        private void FORM_SILAH_MNG_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("قوائمة الكتائب", ar);
                RBTN_SILAH.Text = rm.GetString("قائمة الاسلحة", ar);
                RBTN_MEMBERS.Text = rm.GetString("قائمة المقاتلين", ar);
                label24.Text = rm.GetString("الاقليم", ar);
                label2.Text = rm.GetString("المنطقة", ar);
                label7.Text = rm.GetString("اللواء", ar);
                label9.Text = rm.GetString("الفوج", ar);
                label41.Text = rm.GetString("الكتيبة", ar);
                BTN_ADD.Text = rm.GetString("اضافة", ar);
                BTNSHOW.Text = rm.GetString("فتح", ar);
                BTNDELETE.Text = rm.GetString("حذف", ar);
               
            }
        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
   
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            if (OP.ShowDialog() == DialogResult.OK)
            {
                TXTPATH.Text = OP.FileName;

            }
                if (TXTPATH.Text == string.Empty)
                {
                    MessageBox.Show("يجب اختيار مكان الحفظ \n Cihê Qeydkirinê Diyar Bike", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnBrowe.Focus();
                    return;
                }
                if (RBTN_SILAH.Checked == true)
                {
                    SOURCE.ADD_TABUR_SILAH_FOLDER(Program.APP_IDEN, CBOXKATEBA.SelectedValue.ToString(), "أسلحة الكتيبة" + " " + CBOXKATEBA.Text + " " + DTP.Value.ToShortDateString(), TXTPATH.Text, 0);

                }
                if (RBTN_MEMBERS.Checked == true)
                {
                    SOURCE.ADD_TABUR_SILAH_FOLDER(Program.APP_IDEN, CBOXKATEBA.SelectedValue.ToString(), "مقاتلين الكتيبة" + " " + CBOXKATEBA.Text + " " + DTP.Value.ToShortDateString(), TXTPATH.Text, 0);

                }
              MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة", "إضافة قائمة  : " + CBOXKATEBA.Text + " " + "للكتيبة " + CBOXKATEBA.Text, DateTime.Now);
            MessageBox.Show("تمت عملية الإضافة بنجاح \n zêdekirin serkeftî derbas bû ", "Zêdekirin-إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TXTPATH.Clear();
            BTNSHOW.Enabled = false;
            BTNDELETE.Enabled = false;
            DGVDOCS.DataSource = MEM.GET_TABUR_SILAH_FOLDER_BY_ID(CBOXKATEBA.SelectedValue.ToString());  
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            if (DGVDOCS.Rows.Count==0)
            {
                MessageBox.Show("ليس هناك قوائم لعرض ملفاتها \n  Ti lîste nîn in ku dosyayên wan bên pêşandan", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            try
            {
            string PATH = DGVDOCS.CurrentRow.Cells[2].Value.ToString();

                System.Diagnostics.Process.Start(@PATH);
            }
            catch (Exception)
            {
                MessageBox.Show("لم يتم تحديد القائمة لعرض ملفاتها \n Lîste ne hatiye bijartin ku dosyayên wê bên pêşandan ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                //  throw;
            }
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            try
            {

            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MEM.DELETE_TABUR_SILAH_FOLDER(Convert.ToInt32(DGVDOCS.CurrentRow.Cells[0].Value.ToString()));

                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "Jêbirinê - الحذف", "حذف المجلد : " + DGVDOCS.CurrentRow.Cells[3].Value.ToString() + " " + "للكتيبة " + CBOXKATEBA.SelectedValue.ToString(), DateTime.Now);
                MessageBox.Show("تمت عملية الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DGVDOCS.DataSource = MEM.GET_TABUR_SILAH_FOLDER_BY_ID(CBOXKATEBA.SelectedValue.ToString());
                BTNDELETE.Enabled = false;
                BTNSHOW.Enabled = false;
            }

            }
            catch (Exception)
            {

               // throw;
            }

        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TXT_SILAH_NAME_TextChanged(object sender, EventArgs e)
        {
        }

        private void DGV_SILAH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //for (int i = 0; i < DGV_SILAH.Rows.Count; i++)
            //{
            //    if (DGV_SILAH.Rows[i].Index % 2 == 0)
            //    {
            //        DGV_SILAH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171, 125, 47);
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.FORM_SILAH_CATIGORY FRM = new FORM_SILAH_CATIGORY();
            FRM.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CBOX_CAT_NAME_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBOX_CAT_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGV_SILAH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CBOX_HER_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            CBOX_EYALET.Enabled = true;
            CBOX_EYALET.DataSource = EYALET.GET_EYALET_BY_HEREM_CODE(CBOX_HER.SelectedValue.ToString());
            Program.HEREM_CODE = CBOX_HER.SelectedValue.ToString();
            CBOX_EYALET.DisplayMember = "المنطقة";
            CBOX_EYALET.ValueMember = "رقم المنطقة";

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void CBOX_TUGAY_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBOX_ALAY.Enabled = true;
            CBOX_ALAY.DataSource = ALAY.GET_ALAY_BY_TUGAY_CODE(CBOX_TUGAY.SelectedValue.ToString());
            CBOX_ALAY.DisplayMember = "الفوج";
            CBOX_ALAY.ValueMember = "ALAY_CODE";
        }

        private void CBOX_EYALET_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBOX_TUGAY.Enabled = true;
            CBOX_TUGAY.DataSource = TUGAY.GET_TUGAY_BY_EYALET_CODE(CBOX_EYALET.SelectedValue.ToString());
            CBOX_TUGAY.DisplayMember = "TUGAY_NAME";
            CBOX_TUGAY.ValueMember = "TUGAY_CODE";
        }

        private void CBOX_ALAY_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CBOXKATEBA.Enabled = true;
                CBOXKATEBA.DataSource = TABUR.GET_TABUR_BY_ALAY_CODE(CBOX_ALAY.SelectedValue.ToString());
                CBOXKATEBA.DisplayMember = "TABUR_NAME";
                CBOXKATEBA.ValueMember = "TABUR_CODE";
            }
            catch { return; }
        }

        private void CBOXKATEBA_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGVDOCS.DataSource = MEM.GET_TABUR_SILAH_FOLDER_BY_ID(CBOXKATEBA.SelectedValue.ToString());
            DGVDOCS.Columns[0].Visible = false;
            DGVDOCS.Columns[2].Visible = false;
            DGVDOCS.Columns[3].Visible = false;
            DGVDOCS.Columns[4].Visible = false;
            DGVDOCS.Columns[5].Visible = false;
        }

        private void btnBrowe_Click(object sender, EventArgs e)
        {
            DialogResult dres = dlg.ShowDialog();

            if (dres != DialogResult.Cancel)
            {
                TXTPATH.Text = dlg.SelectedPath;
            }
        }

        private void DGVDOCS_Click(object sender, EventArgs e)
        {
            //BTNSHOW.Enabled = true;
            //BTNDELETE.Enabled = true;
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

             //   throw;
            }
        }
    }
}
