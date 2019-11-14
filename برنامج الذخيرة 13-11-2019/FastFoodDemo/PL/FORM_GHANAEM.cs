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
using System.Resources;
using System.Reflection;
using System.Globalization;

namespace FastFoodDemo.PL
{
  
    public partial class FORM_GHANAEM : Form
    {
        FolderBrowserDialog dlg = new FolderBrowserDialog();
        BL.SPOILS SPO = new BL.SPOILS();
        BL.SILAH_CLS SILAH = new BL.SILAH_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        public FORM_GHANAEM()
        {
            InitializeComponent();
            DGV_GHNAEM.DataSource = SPO.GET_ALL_SPOILS();
            DGV_GHNAEM.Columns[0].Visible = false;
            DGV_GHNAEM.Columns[6].Visible = false;

            CBOX_TYPE.DataSource = SILAH.GET_ALL_CATEGORY();
            CBOX_TYPE.DisplayMember = "الاسم";
            CBOX_TYPE.ValueMember = "CAT_ID";

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CBOX_TYPE.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال نوع الغنيمة \n Cûre Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_TYPE.Focus();
                return;
            }
            if (TXT_SOURCE.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال المكان \n Cih Derbas Bike  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_SOURCE.Focus();
                return;
            }

            SPO.ADD_NEW_SPOIL(CBOX_TYPE.Text, DTP_DATE.Value, TXT_SOURCE.Text.TrimEnd(' '), TXT_CONTENT.Text, TXT_NOTES.Text, 0);
            DGV_GHNAEM.DataSource = SPO.GET_ALL_SPOILS();


            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة", "إضافة غنيمة ", DateTime.Now);
            MessageBox.Show("تمت عملية الإضافة بنجاح \n zêdekirin serkeftî derbas bû ", "Zêdekirin-إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BTNADD.Enabled = false;
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
        private void btnBrowe_Click(object sender, EventArgs e)
        {
          
        }

        private void btnNEW_Click(object sender, EventArgs e)
        {
            TXT_SOURCE.Clear();
            TXT_NOTES.Clear();
            TXT_CONTENT.Clear();
            DTP_DATE.ResetText();
            BTNADD.Enabled = true;
        }

        private void DGV_ORDERS_Click(object sender, EventArgs e)
        {
            //BTNEDIT.Enabled = true;
            //BTNDELETE.Enabled = true;
            //BTNADD_DOCS.Enabled = true;
            //CBOX_TYPE.Text = DGV_GHNAEM.CurrentRow.Cells[1].Value.ToString();
            //TXT_SOURCE.Text = DGV_GHNAEM.CurrentRow.Cells[2].Value.ToString();
            //DTP_DATE.Text = DGV_GHNAEM.CurrentRow.Cells[3].Value.ToString();
            //TXT_CONTENT.Text= DGV_GHNAEM.CurrentRow.Cells[4].Value.ToString();
            //TXT_NOTES.Text= DGV_GHNAEM.CurrentRow.Cells[5].Value.ToString();
        }

        private void BTNEDIT_Click(object sender, EventArgs e)
        {
            try
            {

            if (CBOX_TYPE.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار نوع الغنيمة \n Cûre Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_TYPE.Focus();
                return;
            }
            if (TXT_SOURCE.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال الجهة \n Cih Derbas Bike  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_SOURCE.Focus();
                return;
            }

            SPO.EDIT_SPOIL(CBOX_TYPE.Text, DTP_DATE.Value, TXT_SOURCE.Text.TrimEnd(' '), TXT_CONTENT.Text, TXT_NOTES.Text, Convert.ToInt32(DGV_GHNAEM.CurrentRow.Cells[0].Value.ToString()));

            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تعديل غنيمة", " biguhere - تعديل", DateTime.Now);
            MessageBox.Show("تمت عملية التعديل بنجاح  \n sererastkirin bi awakî serkeftî hate tomarkirin ", " biguhere - تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_GHNAEM.DataSource = SPO.GET_ALL_SPOILS();
            TXT_SOURCE.Clear();
            TXT_CONTENT.Clear();
            TXT_NOTES.Clear();
            DTP_DATE.ResetText();
            BTNEDIT.Enabled = false;
            BTNDELETE.Enabled = false;
            BTNADD_DOCS.Enabled = false;

            }
            catch (Exception)
            {

               // throw;
            }
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SPO.DELETE_SPOIL(Convert.ToInt32(DGV_GHNAEM.CurrentRow.Cells[0].Value.ToString()));
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف غنيمة", "Jêbirinê - الحذف", DateTime.Now);
                MessageBox.Show("تم الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_GHNAEM.DataSource = SPO.GET_ALL_SPOILS();
                TXT_SOURCE.Clear();
                TXT_CONTENT.Clear();
                TXT_NOTES.Clear();
                DTP_DATE.ResetText();
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;
                BTNADD_DOCS.Enabled = false;
             
                // FORM_TABUR_MNG.getMainForm.CBOX_ALAY.DataSource = ALAY.GET_ALL_ALAY();
            }
        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            if (TXT_SEARCH.Text == string.Empty)
            {
                DGV_GHNAEM.DataSource = SPO.GET_ALL_SPOILS();
            }
            else
            {
                DGV_GHNAEM.DataSource = SPO.SEARCH_SPOIL(TXT_SEARCH.Text);
                DGV_GHNAEM.Columns[0].Visible = false;

                DGV_GHNAEM.Columns[6].Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DGV_GHNAEM.DataSource = SPO.GET_ALL_SPOILS();
        }

        private void BTNSHOW_Click(object sender, EventArgs e)
        {
            BTNEDIT.Enabled = false;
            BTNDELETE.Enabled = false;
            BTNADD_DOCS.Enabled = false;
        }

        private void FORM_GHANAEM_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("الغنائم", ar);
                label23.Text = rm.GetString("نوع الغنيمة", ar);
                label1.Text = rm.GetString("التاريخ", ar);
                label2.Text = rm.GetString("المكان", ar);
                label4.Text = rm.GetString("المضمون", ar);
                label3.Text = rm.GetString("ملاحظات", ar);
                label5.Text = rm.GetString("بحث", ar);
                btnNEW.Text = rm.GetString("جديد", ar);
                BTNADD.Text = rm.GetString("اضافة", ar);
                BTNEDIT.Text = rm.GetString("تعديل", ar);
                BTNDELETE.Text = rm.GetString("حذف", ar);
                button2.Text = rm.GetString("خروج", ar);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_GHNAEM_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

            BTNEDIT.Enabled = true;
            BTNDELETE.Enabled = true;
            BTNADD_DOCS.Enabled = true;
            BTNADD.Enabled = false;
            CBOX_TYPE.Text = DGV_GHNAEM.CurrentRow.Cells[1].Value.ToString();
            TXT_SOURCE.Text = DGV_GHNAEM.CurrentRow.Cells[2].Value.ToString();
            DTP_DATE.Text = DGV_GHNAEM.CurrentRow.Cells[3].Value.ToString();
            TXT_CONTENT.Text = DGV_GHNAEM.CurrentRow.Cells[4].Value.ToString();
            TXT_NOTES.Text = DGV_GHNAEM.CurrentRow.Cells[5].Value.ToString();

            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
