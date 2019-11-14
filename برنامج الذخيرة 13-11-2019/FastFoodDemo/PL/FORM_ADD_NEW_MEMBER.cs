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
    public partial class FORM_ADD_NEW_MEMBER : Form
    {
        FolderBrowserDialog dlg = new FolderBrowserDialog();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.TUGAY_CLS TUGAY = new BL.TUGAY_CLS();
        BL.TABUR_CLS TABUR = new BL.TABUR_CLS();
        BL.ALAY_CLS ALAY = new BL.ALAY_CLS();
        BL.SOURC_CLS SOURCE = new BL.SOURC_CLS();
        BL.SILAH_CLS SILAH = new BL.SILAH_CLS();
        BL.MEM_SILAH MEM_SILAH = new BL.MEM_SILAH();
        BL.DELETED_CLS MEM_Deleted = new BL.DELETED_CLS();
        public FORM_ADD_NEW_MEMBER()
        {
            InitializeComponent();

           // TXTMEMIDEN.Text = Program.APP_IDEN + MEM.GET_LAST_MEM_NUM().Rows[0][0].ToString();
            CBOXGENDER.Text = "ذكر";
            CBOX_ALAY.DataSource = ALAY.GET_ALL_ALAY();
            CBOX_ALAY.DisplayMember = "الفوج";
            CBOX_ALAY.ValueMember = "رقم الفوج";

            CBOX_TUGAY.DataSource = TUGAY.GET_ALL_TUGAY();
            CBOX_TUGAY.DisplayMember = "اللواء";
            CBOX_TUGAY.ValueMember = "رقم اللواء";

            CBOXFORCE.DataSource = SOURCE.GET_ALL_FORCE();
            CBOXFORCE.DisplayMember = "اسم القوة";
            CBOXFORCE.ValueMember = "رقم القوة";

            CBOX_OWN_SILAH.Text = "لا";


            DGV_SILAH.DataSource = SILAH.GET_SILAH_BY_CAT_NAME("Sîlahê Şexsî - سلاح فردي");

            DataGridViewCheckBoxColumn dgvchek1 = new DataGridViewCheckBoxColumn();
            dgvchek1.HeaderText = "اختر";
            dgvchek1.Name = "chk1";
            DGV_SILAH.Columns.Add(dgvchek1);

            DataGridViewTextBoxColumn textboxColumn = new DataGridViewTextBoxColumn();
            textboxColumn.HeaderText = "رقم السلاح";
            textboxColumn.Name = "TEXTBOX1";
            DGV_SILAH.Columns.Add(textboxColumn);

            DGV_SILAH.Columns[0].Visible = false;
            DGV_SILAH.Columns[1].Visible = false;
            DGV_SILAH.Columns[2].Visible = false;
            DGV_SILAH.Columns[6].Visible = false;
            DGV_SILAH.Columns[7].Visible = false;
            DGV_SILAH.Columns[8].Visible = false;           
            DGV_SILAH.Columns[9].Visible = false;

            DGV_SILAH.Columns[3].ReadOnly = true;
            DGV_SILAH.Columns[4].ReadOnly = true;
            DGV_SILAH.Columns[5].ReadOnly = true;
           

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnADD_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNEW_Click_1(object sender, EventArgs e)
        {
         
        }

        private void btnADD_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnCLOSE_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBOX_TUGAY_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBOX_ALAY.Enabled = true;
            CBOX_ALAY.DataSource = ALAY.GET_ALAY_BY_TUGAY_CODE(CBOX_TUGAY.SelectedValue.ToString());
            CBOX_ALAY.DisplayMember = "الفوج";
            CBOX_ALAY.ValueMember = "ALAY_CODE";
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

        private void BTN_ADD_TO_LIST_Click(object sender, EventArgs e)
        {

        }

        private void BTNNEW_Click(object sender, EventArgs e)
        {

        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {

        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {

        }

        private void CBOX_OWN_SILAH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBOX_OWN_SILAH.Text == "نعم")
            {
                TXT_SILAH_NUM.Enabled = true;
                TXT_SILAH_DATA.Enabled = true;
            }

            if (CBOX_OWN_SILAH.Text == "لا")
            {
                TXT_SILAH_NUM.Enabled = false;
                TXT_SILAH_DATA.Enabled = false;
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
        private void BTN_ADD_Click_1(object sender, EventArgs e)
        {

             
        }

        private void BTN_FILE_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowe_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_ADD_Click_2(object sender, EventArgs e)
        {

        }

        private void btnCLOSE_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNEW_Click_2(object sender, EventArgs e)
        {
            DGV_SILAH.DataSource = SILAH.GET_SILAH_BY_CAT_NAME("Sîlahê Şexsî - سلاح فردي");
            CBOXGENDER.Text = "ذكر";
            TXTCARDNUM.Clear();
            TXTCODENAME.Clear();
            TXTNAME.Clear();
            TXTFNAME.Clear();
            TXTLNAME.Clear();
            TXTMNAME.Clear();
            DTPBIRTH.ResetText();
            TXTBIRTHPLACE.Clear();
            TXTNATIONALISM.Clear();
            TXTSPECIALNOTES.Clear();
            TXTNOWPLACE.Clear();
            CBOXFORCE.ResetText();
            CBOX_TUGAY.ResetText();
            TXTMEMIDEN.Clear();
            TXT_BOMB_NUM.Clear();
            TXT_CUEB_NUM.Clear();
            TXT_MEXAZEN_NUM.Clear();
            TXT_RESAS_NUM.Clear();
            TXT_OTHERS.Clear();
            TXT_SILAH_DATA.Clear();
            TXT_SILAH_NUM.Clear();
            CBOX_OWN_SILAH.Text = "لا";
        }

        private void btnADD_Click_2(object sender, EventArgs e)
        {
            if (TXTMEMIDEN.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم المقاتل \n Numara Şervan Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTMEMIDEN.Focus();
                return;
            }
            if (TXTCODENAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال لقب المقاتل \n Kodê Şervan Derbas Bike  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTCODENAME.Focus();
                return;
            }
            if (TXTNAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم المقاتل \n Navê Şervan Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNAME.Focus();
                return;
            }
            if (TXTFNAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم الأب \n Navê Bav Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTFNAME.Focus();
                return;
            }
            if (TXTLNAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال الكنية \n Paşnavê Rast Derbas Bike  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTLNAME.Focus();
                return;
            }
            if (TXTMNAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم الأم  \n Navê Dayik Derbas Bike  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTMNAME.Focus();
                return;
            }
            if (TXTBIRTHPLACE.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال مكان الولادة \n Cihê Dayikbûnê Derbas Bike   ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTBIRTHPLACE.Focus();
                return;
            }
            if (TXTNATIONALISM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال القومية \n Netew Derbas Bike   ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNATIONALISM.Focus();
                return;
            }
            if (TXTNOWPLACE.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال المكان الحالي \n Cihê Niha Derbas Bike   ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNOWPLACE.Focus();
                return;
            }
            if (CBOX_ALAY.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال الفوج \n Cihê Foc Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_ALAY.Focus();
                return;
            }
            if (CBOXKATEBA.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال الكتيبة \n Cihê Tabur Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOXKATEBA.Focus();
                return;
            }
            if (CBOXFORCE.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال القوة \n Cihê Hêzeka Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOXFORCE.Focus();
                return;
            }
            DataTable DT_ALL_MEM_FOR_ADD = MEM.GET_ALL_MEMBER_FOR_ADD();
            foreach (DataRow row in DT_ALL_MEM_FOR_ADD.Rows)
            {
                if (row.Field<string>(0) == TXTMEMIDEN.Text.TrimEnd(' '))
                {
                    MessageBox.Show("يوجد مقاتل مسبقا بنفس الرقم \n Ji Heman Numarê Şervanek Din Heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTMEMIDEN.Focus();
                    return;
                }
                if (row.Field<string>(1) == TXTCARDNUM.Text.TrimEnd(' '))
                {
                    MessageBox.Show("يوجد مقاتل مسبقا بنفس رقم البطاقة \n  Ji Heman Numara Nasname Şervanek Din Heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTCARDNUM.Focus();
                    return;
                }
            }

            DT_ALL_MEM_FOR_ADD = MEM_Deleted.GET_ALL_MEMBER_DELETED();
            foreach (DataRow row in DT_ALL_MEM_FOR_ADD.Rows)
            {
                if (row.Field<string>(0) == TXTMEMIDEN.Text.TrimEnd(' '))
                {
                    MessageBox.Show("يوجد مقاتل محذوف بشكل مؤقت بنفس الرقم \n Şervanek heye hatiye sîlkirin bi awakî demkî bi vê hejmarê", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTMEMIDEN.Focus();
                    return;
                }
                if (row.Field<string>(2) == TXTCARDNUM.Text.TrimEnd(' '))
                {
                    MessageBox.Show("يوجد مقاتل محذوف بشكل مؤقت بنفس رقم البطاقة \n Şervanek heye hatiye sîlkirin bi awakî demkî bi vê hejmarê  nasnamê", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTCARDNUM.Focus();
                    return;
                }
            }

            if (TXTNOWPLACE.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال المكان الحالي \n Cihê Niha Derbas Bike  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNOWPLACE.Focus();
                return;
            }
            string TYPE = "";
            if (RBKADER.Checked == true)
            {
                TYPE = "كادر";
            }
            if (RBMAHLI.Checked == true)
            {
                TYPE = "محلي";
            }
      

            if (TXT_CUEB_NUM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال عدد الجعب \n Hejmara Rext Derbas Bike    ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_CUEB_NUM.Focus();
                return;
            }
            if (TXT_MEXAZEN_NUM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال عدد المخازن \n Hejmara Şarjûr Derbas Bike    ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_MEXAZEN_NUM.Focus();
                return;
            }
            if (TXT_BOMB_NUM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال عدد القنابل \n Hejmara Bombe Derbas Bike    ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_BOMB_NUM.Focus();
                return;
            }
            if (TXT_RESAS_NUM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال عدد الطلقات \n Hejmara Guleyan Derbas Bike    ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_RESAS_NUM.Focus();
                return;
            }

            if (CBOX_OWN_SILAH.Text == "نعم")
            {
                if (TXT_SILAH_NUM.Text == string.Empty)
                {
                    MessageBox.Show("يجب إدخال رقم السلاح الشخصي \n Numara Sîlah Ya Şexsî Derbas Bike", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXT_SILAH_NUM.Focus();
                    return;
                }
            }

            int count = 0;
            for (int i = 0; i <= DGV_SILAH.Rows.Count - 1; i++)
            {
                DataGridViewRow row = DGV_SILAH.Rows[i];
                if (Convert.ToBoolean(row.Cells["chk1"].Value) == true)
                {
                    count++;
                }
                if (Convert.ToBoolean(row.Cells["chk1"].Value) == true)
                {
                    if (Convert.ToString(row.Cells["TEXTBOX1"].Value) == string.Empty)
                    {
                        MessageBox.Show("يجب إدخال رقم السلاح \n Numara Sîlah Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            if (count <= 0)
            {
                MessageBox.Show("يجب تحديد سلاح المقاتل \n Sîlaha Şervan Hilbijêre   ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MEM.ADD_MEM_WITHOUT_FINGER(TXTMEMIDEN.Text, Program.APP_IDEN, TXTCARDNUM.Text.TrimEnd(' '),
                             TXTCODENAME.Text, TXTNAME.Text, TXTFNAME.Text, TXTLNAME.Text,
                             TXTMNAME.Text, DTPBIRTH.Value, TXTBIRTHPLACE.Text,
                          CBOXGENDER.Text, TXTNATIONALISM.Text, TXTSPECIALNOTES.Text,
                          Program.APP_IDEN, 0, TXT_MEXAZEN_NUM.Text, TXT_CUEB_NUM.Text, TXT_RESAS_NUM.Text,
                          TXT_BOMB_NUM.Text, TXT_OTHERS.Text, TXT_SILAH_NUM.Text, TXT_SILAH_DATA.Text);


            MEM.ADD_IN_GATH(TXTMEMIDEN.Text, CBOXFORCE.SelectedValue.ToString(), CBOXKATEBA.SelectedValue.ToString(),
                Program.APP_IDEN, TXTNOWPLACE.Text,
                 TYPE, DTPBIRTH.Value, "حالياً", Program.APP_IDEN, 0);
            for (int i = 0; i <= DGV_SILAH.Rows.Count - 1; i++)
            {
                DataTable DT = MEM_SILAH.GET_MAX_MEM_SILAH_ID();
                DataGridViewRow row = DGV_SILAH.Rows[i];
                if (Convert.ToBoolean(row.Cells["chk1"].Value) == true)
                {
                    MEM_SILAH.ADD_MEM_SILAH_WITHOUT_FILE(DT.Rows[0][0].ToString() + Program.APP_IDEN, Program.APP_IDEN, TXTMEMIDEN.Text, DGV_SILAH.Rows[i].Cells[4].Value.ToString(), DGV_SILAH.Rows[i].Cells[6].Value.ToString(), DGV_SILAH.Rows[i].Cells[5].Value.ToString(), 0, DGV_SILAH.Rows[i].Cells[3].Value.ToString(), DGV_SILAH.Rows[i].Cells["TEXTBOX1"].Value.ToString(),"حالياّ");
                }
            }

  
               MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة", "إضافة مقاتل : " + TXTCODENAME.Text, DateTime.Now);

            MessageBox.Show("تمت عملية الإضافة بنجاح \n zêdekirin serkeftî derbas bû ", "Zêdekirin-إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FORM_MEM_MNG.getMainForm.DGVMEM.DataSource = MEM.GET_ALL_MEMBER();

            if (CBOX_OWN_SILAH.Text == "نعم")
            {
                MessageBox.Show("أدخل رخصة السلاح الشخصي \n  Ruxseta Sîlah ya Şexsî Derbas Bike", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageBox.Show("أدخل صورة المقاتل في حال توافرها \n Ger Wêneyê Şervan Hebe Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.MEM_NAME = TXTFNAME.Text;
            Program.MEM_LNAME = TXTLNAME.Text;
            Program.MEM_CODENAME = TXTCODENAME.Text;
            Program.MEM_IDEN = MEM.GET_LAST_MEM_IDEN().Rows[0][0].ToString();
            DGV_SILAH.DataSource = SILAH.GET_SILAH_BY_CAT_NAME("Sîlahê Şexsî - سلاح فردي");
            CBOXGENDER.Text = "ذكر";
            TXTCARDNUM.Clear();
            TXTCODENAME.Clear();
            TXTNAME.Clear();
            TXTFNAME.Clear();
            TXTLNAME.Clear();
            TXTMNAME.Clear();
            DTPBIRTH.ResetText();
            TXTBIRTHPLACE.Clear();
            TXTNATIONALISM.Clear();
            TXTSPECIALNOTES.Clear();
            TXTNOWPLACE.Clear();
            CBOXFORCE.ResetText();
            CBOX_TUGAY.ResetText();
            TXTMEMIDEN.Clear();
            TXT_BOMB_NUM.Clear();
            TXT_CUEB_NUM.Clear();
            TXT_MEXAZEN_NUM.Clear();
            TXT_RESAS_NUM.Clear();
            TXT_OTHERS.Clear();
            TXT_SILAH_DATA.Clear();
            TXT_SILAH_NUM.Clear();
            BTN_FILE.Enabled = true;
           
        }

        private void BTN_FILE_Click_1(object sender, EventArgs e)
        {
            DataTable DT_IMG = MEM.GET_MEM_IMG_FOR_PRINT(Program.MEM_IDEN);
            if (DT_IMG.Rows.Count > 0)
            {
           
                MessageBox.Show("تمت إضافة صورة المقاتل من قبل  \n Berê Wêneyê Şervan Derbas Bûye", "Zêdekirin-إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TXTPATH.Clear();
                BTN_FILE.Enabled = false;
            }
            if (DT_IMG.Rows.Count == 0)
            {
                if (MessageBox.Show("المقاتل ليس له صورة هل تريد إضافة صورة له  \n  Wêneyê Şervan Tuneye Tu Dixwaze Derbas Bike", "صورة المقاتل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    OpenFileDialog OP = new OpenFileDialog();
                    if (OP.ShowDialog() == DialogResult.OK)
                    {
                        TXTPATH.Text = OP.FileName;

                    }

                    SOURCE.ADD_FOLDER(Program.APP_IDEN, Program.MEM_IDEN, "صورة السجل", TXTPATH.Text, 0);
                    MessageBox.Show("تمت عملية الإضافة بنجاح \n zêdekirin serkeftî derbas bû ", "Zêdekirin-إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXTPATH.Clear();
                    BTN_FILE.Enabled = false; 
                }
            }                          
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة", "إضافة صورة  : " + CBOXTYPE.Text + " " + "للمقاتل " + Program.MEM_CODENAME, DateTime.Now);

        }

        private void btnBrowe_Click_1(object sender, EventArgs e)
        {
            DialogResult dres = dlg.ShowDialog();

            if (dres != DialogResult.Cancel)
            {
                TXTPATH.Text = dlg.SelectedPath;
            }
        }

        private void CBOXFORCE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBOX_TUGAY_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CBOX_ALAY.Enabled = true;
            CBOX_ALAY.DataSource = ALAY.GET_ALAY_BY_TUGAY_CODE(CBOX_TUGAY.SelectedValue.ToString());
            CBOX_ALAY.DisplayMember = "الفوج";
            CBOX_ALAY.ValueMember = "ALAY_CODE";
    
        }

        private void CBOX_OWN_SILAH_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CBOX_OWN_SILAH.Text == "نعم")
            {
                TXT_SILAH_NUM.Enabled = true;
                TXT_SILAH_DATA.Enabled = true;
                btn_rokhsa.Enabled = true;
            }

            if (CBOX_OWN_SILAH.Text == "لا")
            {
                TXT_SILAH_NUM.Enabled = false;
                TXT_SILAH_DATA.Enabled = false;
                btn_rokhsa.Enabled = false; 
            }
        }

        private void CBOX_ALAY_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void btn_rokhsa_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            if (OP.ShowDialog() == DialogResult.OK)
            {
                TXTPATH.Text = OP.FileName;

            }

            SOURCE.ADD_FOLDER(Program.APP_IDEN, Program.MEM_IDEN, "رخصة السلاح",
                TXTPATH.Text, 0);
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة", "إضافة رخصة السلاح  : " + CBOXTYPE.Text + " " + "للمقاتل " + Program.MEM_CODENAME, DateTime.Now);

            MessageBox.Show("تمت عملية الإضافة بنجاح \n zêdekirin serkeftî derbas bû ", "Zêdekirin-إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TXTPATH.Clear();
            BTN_FILE.Enabled = false;
        }

        private void CBOXKATEBA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RBKADER_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FORM_ADD_NEW_MEMBER_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {               
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("اضافة مقاتل", ar);
                label24.Text = rm.GetString("رقم المقاتل", ar);
                label23.Text = rm.GetString("رقم البطاقة", ar);
                label1.Text = rm.GetString("اللقب و الكنية", ar);
                label2.Text = rm.GetString("الاسم", ar);
                label4.Text = rm.GetString("اسم الاب", ar);
                label3.Text = rm.GetString("الكنية", ar);
                label6.Text = rm.GetString("اسم الام", ar);
                label5.Text = rm.GetString("تاريخ الولادة", ar);
                label8.Text = rm.GetString("مكان الولادة", ar);
                label12.Text = rm.GetString("الجنس", ar);
                label36.Text = rm.GetString("القومية", ar);
                label44.Text = rm.GetString("المكان الحالي", ar);
                label25.Text = rm.GetString("ملاحظات", ar);
                label40.Text = rm.GetString("القوات", ar);
                label29.Text = rm.GetString("الالوية", ar);
                label28.Text = rm.GetString("الافواج", ar);
                label41.Text = rm.GetString("الكتائب", ar);
                label53.Text = rm.GetString("عدد الجعب", ar);
                label52.Text = rm.GetString("عدد المخازن", ar);
                label49.Text = rm.GetString("عدد القنابل", ar);
                label50.Text = rm.GetString("عدد الطلقات", ar);
                label56.Text = rm.GetString("اخرى", ar);
                label51.Text = rm.GetString("هل يملك سلاح شخصي", ar);
                label54.Text = rm.GetString("رقم السلاح الشخصي", ar);
                label55.Text = rm.GetString("بيانات السلاح الشخصي", ar);
                RBKADER.Text= rm.GetString("كادر", ar);
                RBMAHLI .Text = rm.GetString("محلي", ar);
                btnNEW.Text= rm.GetString("جديد", ar);
                btnADD.Text = rm.GetString("اضافة", ar);
                BTN_FILE.Text = rm.GetString("اضافة صورة مقاتل", ar);
                btn_rokhsa.Text = rm.GetString("اضافة رخصة السلاح", ar);
                btnCLOSE.Text = rm.GetString("خروج", ar);
                groupBox4.Text = rm.GetString("قائمة الاسلحة", ar);
               

            }
        }

   
    }
}
