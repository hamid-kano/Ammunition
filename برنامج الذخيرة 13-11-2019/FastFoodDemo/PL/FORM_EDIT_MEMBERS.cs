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
using System.Reflection;
using System.Globalization;
using System.Resources;

namespace FastFoodDemo.PL
{
    public partial class FORM_EDIT_MEMBERS : Form
    {
        FolderBrowserDialog dlg = new FolderBrowserDialog();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.TUGAY_CLS TUGAY = new BL.TUGAY_CLS();
        BL.TABUR_CLS TABUR = new BL.TABUR_CLS();
        BL.ALAY_CLS ALAY = new BL.ALAY_CLS();
        BL.SOURC_CLS SOURCE = new BL.SOURC_CLS();
        BL.SILAH_CLS SILAH = new BL.SILAH_CLS();
        BL.MEM_SILAH MEM_SILAH = new BL.MEM_SILAH();
        DataTable DT_MEM = new DataTable();
        private static FORM_EDIT_MEMBERS frm;
        DataGridView DGV_MEM = new DataGridView();
        BL.DELETED_CLS MEM_Deleted = new BL.DELETED_CLS();
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FORM_EDIT_MEMBERS getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_EDIT_MEMBERS();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
        }
        public FORM_EDIT_MEMBERS()
        {
            InitializeComponent();

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }

            frm = this;
            CBOX_TUGAY.DataSource = TUGAY.GET_ALL_TUGAY();
            CBOX_TUGAY.DisplayMember = "اللواء";
            CBOX_TUGAY.ValueMember = "رقم اللواء";

            CBOX_ALAY.DataSource = ALAY.GET_ALL_ALAY();
            CBOX_ALAY.DisplayMember = "الفوج";
            CBOX_ALAY.ValueMember = "رقم الفوج";

            CBOXKATEBA.DataSource = TABUR.GET_ALL_TABUR();
            CBOXKATEBA.DisplayMember = "الكتيبة";
            CBOXKATEBA.ValueMember = "رقم الكتيبة";

            CBOXFORCE.DataSource = SOURCE.GET_ALL_FORCE();
            CBOXFORCE.DisplayMember = "اسم القوة";
            CBOXFORCE.ValueMember = "رقم القوة";

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
            DGV_SILAH.Columns[8].Visible = false;
            DGV_SILAH.Columns[7].Visible = false;
            DGV_SILAH.Columns[9].Visible = false;

            DGV_SILAH.Columns[3].ReadOnly = true;
            DGV_SILAH.Columns[4].ReadOnly = true;
            DGV_SILAH.Columns[5].ReadOnly = true;




            DT_MEM = MEM.GET_MEM_BY_GATH_ID_FOR_EDIT(Program.GATH_ID);
            TXTMEMIDEN.Text = DT_MEM.Rows[0][0].ToString();
            TXTCARDNUM.Text = DT_MEM.Rows[0][2].ToString();
            TXTCODENAME.Text = DT_MEM.Rows[0][3].ToString();
            TXTNAME.Text = DT_MEM.Rows[0][4].ToString();
            TXTFNAME.Text = DT_MEM.Rows[0][5].ToString();
            TXTLNAME.Text = DT_MEM.Rows[0][6].ToString();
            TXTMNAME.Text = DT_MEM.Rows[0][7].ToString();
            DTPBIRTH.Text = DT_MEM.Rows[0][8].ToString();
            TXTBIRTHPLACE.Text = DT_MEM.Rows[0][9].ToString();

            CBOXGENDER.Text = DT_MEM.Rows[0][10].ToString();
            TXTNATIONALISM.Text = DT_MEM.Rows[0][11].ToString();
            TXTSPECIALNOTES.Text = DT_MEM.Rows[0][12].ToString();
            TXTNOWPLACE.Text = DT_MEM.Rows[0][14].ToString();
            if (DT_MEM.Rows[0][16].ToString() == "كادر")
            {
                RBMAHLI.Checked = true;
            }
            else
            {
                RBKADER.Checked = true;
            }

            CBOXKATEBA.Text = DT_MEM.Rows[0][16].ToString();
            CBOXFORCE.Text = DT_MEM.Rows[0][17].ToString();
            CBOX_ALAY.Text = DT_MEM.Rows[0][28].ToString();
            CBOX_TUGAY.Text = DT_MEM.Rows[0][29].ToString();
            TXT_SILAH_NUM.Text = DT_MEM.Rows[0][26].ToString();

            TXT_MEXAZEN_NUM.Text = DT_MEM.Rows[0][22].ToString();
            TXT_RESAS_NUM.Text = DT_MEM.Rows[0][23].ToString();
            TXT_CUEB_NUM.Text = DT_MEM.Rows[0][24].ToString();
            TXT_BOMB_NUM.Text = DT_MEM.Rows[0][25].ToString();
            TXT_OTHERS.Text = DT_MEM.Rows[0][33].ToString();
            TXT_SILAH_DATA.Text = DT_MEM.Rows[0][27].ToString();

            if (TXT_SILAH_NUM.Text != string.Empty)
            {
                CBOX_OWN_SILAH.Text = "نعم";
            }
            if (TXT_SILAH_NUM.Text == string.Empty)
            {
                CBOX_OWN_SILAH.Text = "لا";
            }
            DGV_MEM.DataSource = MEM.GET_MEM_BY_GATH_ID_FOR_EDIT(Program.GATH_ID);

            DataTable DT_IMG = MEM.GET_MEM_IMG_FOR_PRINT(Program.MEM_IDEN);
            if (DT_IMG.Rows.Count > 0)
            {
                string PATH = DT_IMG.Rows[0][0].ToString();
           //  pictureBox1.Image = Image.FromFile(PATH);
            }
            TXT_OTHERS.Text = Program.MEM_IDEN;
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
          //  TXTMEMIDEN.Text = Program.APP_IDEN + MEM.GET_LAST_MEM_NUM().Rows[0][0].ToString();
         
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
            DataTable DT_ALL_MEM_FOR_EDIT = MEM.GET_ALL_MEM_FOR_EDIT(DT_MEM.Rows[0][0].ToString());
            foreach (DataRow row in DT_ALL_MEM_FOR_EDIT.Rows)
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
                    MessageBox.Show("يجب إدخال رقم السلاح الشخصي \n Numara Sîlah Ya Şexsî Derbas Bike    ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show("يجب إدخال رقم السلاح \n Numara Sîlah Derbas Bike   ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            if (count <= 0)
            {
                MessageBox.Show("يجب تحديد سلاح المقاتل \n Sîlaha Şervan Hilbijêre   ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DT_ALL_MEM_FOR_EDIT = MEM_Deleted.GET_ALL_MEMBER_DELETED();
            foreach (DataRow row in DT_ALL_MEM_FOR_EDIT.Rows)
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

            MEM.EDIT_MEM(TXTMEMIDEN.Text, Program.APP_IDEN, TXTCARDNUM.Text.TrimEnd(' '),
                             TXTCODENAME.Text, TXTNAME.Text, TXTFNAME.Text, TXTLNAME.Text,
                             TXTMNAME.Text, DTPBIRTH.Value, TXTBIRTHPLACE.Text,
                          CBOXGENDER.Text, TXTNATIONALISM.Text, TXTSPECIALNOTES.Text,
                          Program.APP_IDEN, 0, TXT_MEXAZEN_NUM.Text, TXT_CUEB_NUM.Text, TXT_RESAS_NUM.Text,
                          TXT_BOMB_NUM.Text, TXT_OTHERS.Text, TXT_SILAH_NUM.Text, TXT_SILAH_DATA.Text, TXTMEMIDEN.Text);


            MEM_SILAH.DELETE_MEM_SILAH(Program.MEM_IDEN);

            for (int i = 0; i <= DGV_SILAH.Rows.Count - 1; i++)
            {
                DataTable DT = MEM_SILAH.GET_MAX_MEM_SILAH_ID();
                DataGridViewRow row = DGV_SILAH.Rows[i];
                if (Convert.ToBoolean(row.Cells["chk1"].Value) == true)
                {
                    MEM_SILAH.ADD_MEM_SILAH_WITHOUT_FILE(DT.Rows[0][0].ToString() + Program.APP_IDEN, Program.APP_IDEN,
                        Program.MEM_IDEN, DGV_SILAH.Rows[i].Cells[4].Value.ToString(), 
                        DGV_SILAH.Rows[i].Cells[6].Value.ToString(), DGV_SILAH.Rows[i].Cells[5].Value.ToString(),
                        0, DGV_SILAH.Rows[i].Cells[3].Value.ToString(),
                        DGV_SILAH.Rows[i].Cells["TEXTBOX1"].Value.ToString(),"حالياّ");
                }
            }
             
             MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, " biguhere - تعديل", "تعديل بيانات المقاتل : " + DT_MEM.Rows[0][3].ToString(), DateTime.Now);

            MessageBox.Show("تم تعديل بيانات المقاتل بنجاح \n tomarkirin serkeftî ye ", "Rastkirin-التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FORM_MEM_MNG.getMainForm.DGVMEM.DataSource= MEM.GET_ALL_MEMBER();

            Program.MEM_NAME = TXTFNAME.Text;
            Program.MEM_LNAME = TXTLNAME.Text;
            Program.MEM_CODENAME = TXTCODENAME.Text;
            Program.MEM_IDEN = TXTMEMIDEN.Text.TrimEnd(' ');
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
                        OpenFileDialog OP = new OpenFileDialog();
                        if (OP.ShowDialog() == DialogResult.OK)
                        {
                            TXTPATH.Text = OP.FileName;

                        

                        SOURCE.UPDATE_FOLDER(Program.APP_IDEN, Program.MEM_IDEN, "صورة السجل",
                            TXTPATH.Text, 0);
                        MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, " biguhere - تعديل", "تعديل صورة : " + CBOXTYPE.Text + " " + "للمقاتل " + Program.MEM_CODENAME, DateTime.Now);

                        MessageBox.Show("تمت عملية التعديل بنجاح  \n sererastkirin bi awakî serkeftî hate tomarkirin ", " biguhere - تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TXTPATH.Clear();
                        BTN_FILE.Enabled = false;
                        }
                    }
                    if (DT_IMG.Rows.Count == 0)
                    {
                        if (MessageBox.Show("المقاتل ليس له صورة هل تريد إضافة صورة له  \n  Wêneyê Şervan Tuneye Tu Dixwaze Derbas Bike", "صورة المقاتل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            OpenFileDialog OP = new OpenFileDialog();
                            if (OP.ShowDialog() == DialogResult.OK)
                            {
                                TXTPATH.Text = OP.FileName;
                                SOURCE.ADD_FOLDER(Program.APP_IDEN, Program.MEM_IDEN, "صورة السجل",TXTPATH.Text, 0);
                                MessageBox.Show("تمت عملية الإضافة بنجاح \n zêdekirin serkeftî derbas bû ", "Zêdekirin-إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TXTPATH.Clear();
                                BTN_FILE.Enabled = false;
                               MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة", "إضافة صورة : " + CBOXTYPE.Text + " " + "للمقاتل " + Program.MEM_CODENAME, DateTime.Now);

                            }
                        }
                    }
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
            CBOX_ALAY.Enabled = true;
            CBOX_ALAY.DataSource = ALAY.GET_ALAY_BY_TUGAY_CODE(CBOX_TUGAY.SelectedValue.ToString());
            CBOX_ALAY.DisplayMember = "الفوج";
            CBOX_ALAY.ValueMember = "ALAY_CODE";
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

        private void FORM_EDIT_MEMBERS_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("تعديل البيانات", ar);
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
                RBKADER.Text = rm.GetString("كادر", ar);
                RBMAHLI.Text = rm.GetString("محلي", ar);
                btnNEW.Text = rm.GetString("جديد", ar);
                btnADD.Text = rm.GetString("تعديل", ar);
                BTN_FILE.Text = rm.GetString("تعديل صورة مقاتل", ar);
                btn_rokhsa.Text = rm.GetString("تعديل رخصة السلاح", ar);
                BTN_MEM_SILAH.Text = rm.GetString("تبديل اسلحة المقاتل", ar);
                btnCLOSE.Text = rm.GetString("خروج", ar);
                groupBox4.Text = rm.GetString("قائمة الاسلحة", ar);
                button1.Text = rm.GetString("خروج", ar);



            }





            DataTable DT_MEM_SILAH = MEM_SILAH.GET_MEM_SILAH(Program.MEM_IDEN ,"حالياّ");
            for (int i = 0; i <= DT_MEM_SILAH.Rows.Count - 1; i++)
            {

                for (int j = 0; j <= DGV_SILAH.Rows.Count - 1; j++)
                {
                    DataGridViewRow row = DGV_SILAH.Rows[j];

                    if (DT_MEM_SILAH.Rows[i]["SILAH_CODE"].ToString() == DGV_SILAH.Rows[j].Cells["SILAH_CODE"].Value.ToString())
                    {
                        row.Cells["chk1"].Value = true;
                        row.Cells["TEXTBOX1"].Value = DT_MEM_SILAH.Rows[i]["SILAH_NUM"].ToString();
                    }

                }
            }
        }

        private void btn_rokhsa_Click(object sender, EventArgs e)
        {
            DataTable DT = MEM.GET_MEM_ROKHSA(Program.MEM_IDEN);
            if (DT.Rows.Count > 0)
            {
                OpenFileDialog OP = new OpenFileDialog();
                if (OP.ShowDialog() == DialogResult.OK)
                {
                    TXTPATH.Text = OP.FileName;
                    SOURCE.UPDATE_FOLDER(Program.APP_IDEN, Program.MEM_IDEN, "رخصة السلاح",
                    TXTPATH.Text, 0);
                    MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, " biguhere - تعديل", "تعديل رخصة سلاح : " + CBOXTYPE.Text + " " + "للمقاتل " + Program.MEM_CODENAME, DateTime.Now);

                    MessageBox.Show("تمت عملية التعديل بنجاح  \n sererastkirin bi awakî serkeftî hate tomarkirin ", " biguhere - تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXTPATH.Clear();
                    BTN_FILE.Enabled = false;
                }
            }
            if (DT.Rows.Count == 0)
            {
                if (MessageBox.Show("المقاتل ليس له رخصة  لسلاحه الشخصي هل تريد إضافة رخصة؟؟ \n Ruxseta Sîlah ya Şervan Tuneye Tu Dixwaze Derbas Bike??", "Ruxseta Sîlah - رخصة السلاح", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    OpenFileDialog OP = new OpenFileDialog();
                    if (OP.ShowDialog() == DialogResult.OK)
                    {
                        TXTPATH.Text = OP.FileName;
                        SOURCE.ADD_FOLDER(Program.APP_IDEN, Program.MEM_IDEN, "رخصة السلاح",
                        TXTPATH.Text, 0);
                        MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة", "إضافة رخصة : " + CBOXTYPE.Text + " " + "للمقاتل " + Program.MEM_CODENAME, DateTime.Now);
                        MessageBox.Show("تمت عملية الإضافة بنجاح \n zêdekirin serkeftî derbas bû ", "Zêdekirin-إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TXTPATH.Clear();
                        BTN_FILE.Enabled = false;
                    }
                }
            }
        }


        private void BTN_MEM_SILAH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد تبديل السلاح؟؟ \n Hûn Dixwazin Çalakiya Sîlahê Şervan Bugherîne Pêkbînin?", "Sîlahê Şervan Bugherîne - تبديل السلاح", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                for (int i = 0; i <= DGV_SILAH.Rows.Count - 1; i++)
                {
                    
                    DataGridViewRow row = DGV_SILAH.Rows[i];
                    if (Convert.ToBoolean(row.Cells["chk1"].Value) == true)
                    {
                        MEM_SILAH.CHANGE_MEM_SILAH(Program.MEM_IDEN, "سابقاّ");
                    }
                }
                FORM_MEM_SILAH_CHANGE FRM = new FORM_MEM_SILAH_CHANGE();
                FRM.ShowDialog();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            DataTable DT_REPORT = new DataTable();
            DT_REPORT.Columns.Add("رقم المقاتل", typeof(string));
            DT_REPORT.Columns.Add("اللقب", typeof(string));
            DT_REPORT.Columns.Add("الاسم", typeof(string));
            DT_REPORT.Columns.Add("الأب", typeof(string));
            DT_REPORT.Columns.Add("الكنية", typeof(string));
            DT_REPORT.Columns.Add("الأم", typeof(string));
            DT_REPORT.Columns.Add("تاريخ الولادة", typeof(string));
            DT_REPORT.Columns.Add(" مكان الولادة", typeof(string));
            DT_REPORT.Columns.Add("الجنس", typeof(string));
            DT_REPORT.Columns.Add("المكان الحالي", typeof(string));
            DT_REPORT.Columns.Add("كادر - محلي", typeof(string));
            DT_REPORT.Columns.Add("الكتيبة", typeof(string));
            DT_REPORT.Columns.Add("القوة", typeof(string));
            DT_REPORT.Columns.Add("الجعب", typeof(string));
            DT_REPORT.Columns.Add("المخازن", typeof(string));
            DT_REPORT.Columns.Add("القنابل", typeof(string));
            DT_REPORT.Columns.Add("الطلقات", typeof(string));

            foreach (DataGridViewRow ROW in DGV_MEM.Rows)
            {
                DT_REPORT.Rows.Add(ROW.Cells[0].ToString(), ROW.Cells[3].ToString(), ROW.Cells[4].ToString(),
                                 ROW.Cells[5].ToString(), ROW.Cells[6].ToString(), ROW.Cells[7].ToString(),
                                   Convert.ToDateTime(ROW.Cells[8].ToString()).ToShortDateString(),
                                 ROW.Cells[9].ToString(), ROW.Cells[10].ToString(), ROW.Cells[14].ToString(),
                                   ROW.Cells[15].ToString(), ROW.Cells[16].ToString(),
                                 ROW.Cells[17].ToString(),
                                   ROW.Cells[24].ToString(), ROW.Cells[22].ToString()
                                   , ROW.Cells[25].ToString(), ROW.Cells[23].ToString());
            }
            DS.Tables.Add(DT_REPORT);
            DS.WriteXmlSchema("C:\\AraratProgramFiles\\sampleMEM.xml");

            RPT.FRM_RPT frm = new RPT.FRM_RPT();
            RPT.RPT_MEM_DETALIES report = new RPT.RPT_MEM_DETALIES();
            report.Refresh();
            report.SetDataSource(DS);
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
        }
    }
}
