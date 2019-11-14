using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.PL
{
    public partial class FORM_SILAH_MNG : Form
    {
        BL.SILAH_CLS SILAH = new BL.SILAH_CLS();
        BL.HEREM_CLS HER = new BL.HEREM_CLS();
        BL.TUGAY_CLS TUGAY = new BL.TUGAY_CLS();
        BL.EYALET_CLS EYALET = new BL.EYALET_CLS();
        BL.TABUR_CLS TABUR = new BL.TABUR_CLS();
        BL.ALAY_CLS ALAY = new BL.ALAY_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        private static FORM_SILAH_MNG frm;
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FORM_SILAH_MNG getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_SILAH_MNG();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
        }
        public FORM_SILAH_MNG()
        {
            InitializeComponent();
            frm = this;
            DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
            DGV_SILAH.Columns[0].Visible = false;
            DGV_SILAH.Columns[1].Visible = false;
            DGV_SILAH.Columns[2].Visible = false;
            DGV_SILAH.Columns[9].Visible = false;

            CBOX_CAT.DataSource = SILAH.GET_ALL_CATEGORY();
            CBOX_CAT.DisplayMember = "الاسم";
            CBOX_CAT.ValueMember = "CAT_ID";
            BTN_DELETE.Enabled = false;
            BTN_EDIT.Enabled = false;
            CBOX_HER.DataSource = HER.GET_ALL_HEREM();
            CBOX_HER.DisplayMember = "اسم الإقليم";
            CBOX_HER.ValueMember = "رقم الإقليم";

            //CBOX_TUGAY.DataSource = TUGAY.GET_ALL_TUGAY();
            //CBOX_TUGAY.DisplayMember = "اللواء";
            //CBOX_TUGAY.ValueMember = "رقم اللواء";

            //CBOX_ALAY.DataSource = ALAY.GET_ALL_ALAY();
            //CBOX_ALAY.DisplayMember = "الفوج";
            //CBOX_ALAY.ValueMember = "رقم الفوج";

            CBOXKATEBA.DataSource = TABUR.GET_ALL_TABUR();
            CBOXKATEBA.DisplayMember = "الكتيبة";
            CBOXKATEBA.ValueMember = "رقم الكتيبة";

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }

        }

        private void FORM_SILAH_MNG_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("ادارة الاسلحة", ar);
                label24.Text = rm.GetString("الاقليم", ar);
                label2.Text = rm.GetString("المنطقة", ar);
                label7.Text = rm.GetString("اللواء", ar);
                label9.Text = rm.GetString("الفوج", ar);
                label41.Text = rm.GetString("الكتيبة", ar);
                label8.Text = rm.GetString("النوع", ar);
                label1.Text = rm.GetString("السلاح", ar);
                label3.Text = rm.GetString("الموديل", ar);
                label4.Text = rm.GetString("بحث", ar);
                BTN_NEW.Text = rm.GetString("جديد", ar);
                BTN_ADD.Text = rm.GetString("اضافة", ar);
                BTN_EDIT.Text = rm.GetString("تعديل", ar);
                BTN_DELETE.Text = rm.GetString("حذف", ar);
                label6.Text = rm.GetString("الكمية", ar);
                lblUnite.Text = rm.GetString("الواحدة", ar);
                label5.Text = rm.GetString("ملاحظات", ar);
                button1.Text = rm.GetString("جديد", ar);


            }
        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            TXT_QTY.Clear();
            TXT_NOTES.Clear();
            TXT_SEARCH.Clear();
            TXT_SILAH_MODEL.Clear();        
            CBOX_CAT_NAME.ResetText();
            CBOX_CAT.ResetText();
            TXT_SEARCH.Clear();
            BTN_ADD.Enabled = true;
            BTN_DELETE.Enabled = false;
            BTN_EDIT.Enabled = false;
            cbox_unit.Text = null;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //BTN_ADD.Enabled = false;
            //BTN_DELETE.Enabled = true;
            //BTN_EDIT.Enabled = true;
            //TXT_SILAH_MODEL.Text = DGV_SILAH.CurrentRow.Cells[5].Value.ToString();
            //CBOX_CAT_NAME.Text = DGV_SILAH.CurrentRow.Cells[4].Value.ToString();
            //CBOX_CAT.Text = DGV_SILAH.CurrentRow.Cells[3].Value.ToString();
            //TXT_QTY.Text = DGV_SILAH.CurrentRow.Cells[6].Value.ToString();
            //TXT_NOTES.Text = DGV_SILAH.CurrentRow.Cells[8].Value.ToString();
            //cbox_unit.Text = DGV_SILAH.CurrentRow.Cells[7].Value.ToString();
            //CBOXKATEBA.Text = DGV_SILAH.CurrentRow.Cells[10].Value.ToString();
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
                DataTable DT_IDS = SILAH.GET_MAX_SILAH_ID();
                if (CBOX_CAT.Text.TrimEnd(' ') == string.Empty)
                {
                    MessageBox.Show("يجب إدخال النوع \n Cûre Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CBOX_CAT.Focus();
                    return;
                }
                if (CBOX_CAT_NAME.Text.TrimEnd(' ') == string.Empty)
                {
                    MessageBox.Show("يجب اختيار السلاح \n Sîlah Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CBOX_CAT_NAME.Focus();
                    return;
                }
                if (TXT_SILAH_MODEL.Text.TrimEnd(' ') == string.Empty)
                {
                    MessageBox.Show("يجب إدخال موديل السلاح \n Modele Sîlah Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXT_SILAH_MODEL.Focus();
                    return;
                }

                if (TXT_QTY.Text.TrimEnd(' ') == string.Empty)
                {
                    MessageBox.Show("يجب إدخال كمية السلاح \n Miqdarê Sîlah Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXT_QTY.Focus();
                    return;
                }
                if (cbox_unit.Text.TrimEnd(' ') == string.Empty)
                {
                    MessageBox.Show("يجب إدخال الواحدة \n Yekîneya Pîvanê Derbas Bike  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbox_unit.Focus();
                    return;
                }
                if (CBOXKATEBA.Text.TrimEnd(' ') == string.Empty)
                {
                    MessageBox.Show("يجب إدخال الكتيبة \n Cihê Tabur Derbas Bike   ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CBOXKATEBA.Focus();
                    return;
                }
                DataTable DT = SILAH.GET_ALL_SILAH();
                foreach (DataRow ROW in DT.Rows)
                {
                    if (CBOX_CAT.Text.TrimEnd(' ').ToLower() == ROW.Field<string>(3).TrimEnd(' ').ToLower()
                        && ROW.Field<string>(5).TrimEnd(' ').ToLower() == TXT_SILAH_MODEL.Text.TrimEnd(' ').ToLower()
                        && ROW.Field<string>(4).TrimEnd(' ').ToLower() == CBOX_CAT_NAME.Text.TrimEnd(' ').ToLower())
                    {
                        MessageBox.Show("تمت إضافة سلاح بنفس المواصفات المدخلة مسبقاً \n Ji Heman Sîlahan Sîlahek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            try
            {
                SILAH.ADD_NEW_SILAH(Program.APP_IDEN, Program.APP_IDEN + DT_IDS.Rows[0][0].ToString(), TXT_SILAH_MODEL.Text, 0, TXT_QTY.Text, TXT_NOTES.Text,Convert.ToInt32(CBOX_CAT_NAME.SelectedValue.ToString()),cbox_unit.Text,CBOXKATEBA.SelectedValue.ToString(),CBOXKATEBA.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("تمت إضافة سلاح بنفس المواصفات المدخلة لسلاح محذوف بشكل مؤقت \n Çekek bi heman taybetîyên derbaskirî ji çekeka jêbirî bi awakî demkî heye  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
               // throw;
            }
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة سلاح إلى المستودع", "إضافة", DateTime.Now);

            MessageBox.Show(" تم الاضافة بنجاح \n zêdekirin serkeftî derbas bû  ", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
                BTN_ADD.Enabled = false;
                FORM_IMP_EXP.getMainForm.DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
     
       //     FORM_TABUR_SILAH_MNG.getMainForm.DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
       //     FORM_FIGHTER_MNG.getMainForm.DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
         
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            if (CBOX_CAT.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال النوع \n Cûre Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_CAT.Focus();
                return;
            }
            if (CBOX_CAT_NAME.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب اختيار السلاح \n Sîlah Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_CAT_NAME.Focus();
                return;
            }
            if (TXT_SILAH_MODEL.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال موديل السلاح \n Modele Sîlah Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_SILAH_MODEL.Focus();
                return;
            }

            if (TXT_QTY.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال كمية السلاح \n Miqdarê Sîlah Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_QTY.Focus();
                return;
            }
            if (cbox_unit.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال الواحدة \n Yekîneya Pîvanê Derbas Bike  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbox_unit.Focus();
                return;
            }
            if (CBOXKATEBA.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال الكتيبة \n Cihê Tabur Derbas Bike   ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOXKATEBA.Focus();
                return;
            }
            DataTable DT = SILAH.GET_SILAH_FOR_EDIT( DGV_SILAH.CurrentRow.Cells[4].Value.ToString(),DGV_SILAH.CurrentRow.Cells[5].Value.ToString(), DGV_SILAH.CurrentRow.Cells[3].Value.ToString());
            foreach (DataRow ROW in DT.Rows)
            {
                if (ROW.Field<string>(3).TrimEnd(' ').ToLower() == CBOX_CAT_NAME.Text.TrimEnd(' ').ToLower()
                    && ROW.Field<string>(4) == CBOX_CAT.Text.TrimEnd(' ').ToLower()
                    && ROW.Field<string>(5).TrimEnd(' ').ToLower() == TXT_SILAH_MODEL.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("يوجد سلاح بنفس المواصفات المدخلة \n Ji Heman Sîlahan Sîlahek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CBOX_CAT.Text = DGV_SILAH.CurrentRow.Cells[3].Value.ToString();
                    CBOX_CAT_NAME.Text = DGV_SILAH.CurrentRow.Cells[4].Value.ToString();
                    TXT_SILAH_MODEL.Text = DGV_SILAH.CurrentRow.Cells[5].Value.ToString();
                    return;
                }
            }

            try
            {
          
            SILAH.EDIT_SILAHS(DGV_SILAH.CurrentRow.Cells[2].Value.ToString(), TXT_SILAH_MODEL.Text,
                              TXT_QTY.Text, TXT_NOTES.Text, Convert.ToInt32(CBOX_CAT_NAME.SelectedValue.ToString()),
                              cbox_unit.Text, CBOXKATEBA.SelectedValue.ToString(), CBOXKATEBA.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(" يوجد سلاح محذوف بشكل موقت بنفس المواصفات المدخلة \n Çekeka jêbirî bi awakî demkî bi heman taybetîyên derbaskirî heye  \n Çekek jêbirî bi awakî demkî bi heman taybetîyên derbaskirî heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
               // throw;
            }
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تعديل سلاح في المستودع", " biguhere - تعديل", DateTime.Now);
            MessageBox.Show(" تم التعديل بنجاح \n tomarkirin serkeftî ye ", "biguhere - التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
            TXT_QTY.Clear();
            TXT_NOTES.Clear();
            TXT_SEARCH.Clear();
            TXT_SILAH_MODEL.Clear();
            CBOX_CAT_NAME.ResetText();
            CBOX_CAT.ResetText();
            TXT_SEARCH.Clear();
            BTN_ADD.Enabled = true;
            BTN_DELETE.Enabled = false;
            BTN_EDIT.Enabled = false;
            cbox_unit.Text = null;
            FORM_IMP_EXP.getMainForm.DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
          //  FORM_TABUR_SILAH_MNG.getMainForm.DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SILAH.DELETE_SILAH(DGV_SILAH.CurrentRow.Cells[2].Value.ToString());
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف سلاح من المستودع", "Jêbirinê - الحذف", DateTime.Now);
                MessageBox.Show("تم الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
                TXT_QTY.Clear();
                TXT_NOTES.Clear();
                TXT_SEARCH.Clear();
                TXT_SILAH_MODEL.Clear();
                CBOX_CAT_NAME.ResetText();
                CBOX_CAT.ResetText();
                TXT_SEARCH.Clear();
                BTN_ADD.Enabled = true;
                BTN_DELETE.Enabled = false;
                BTN_EDIT.Enabled = false;
                cbox_unit.Text = null;
                FORM_IMP_EXP.getMainForm.DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
              //  FORM_TABUR_SILAH_MNG.getMainForm.DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
            }
            
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            if (TXT_SEARCH.Text == string.Empty)
            {
               DGV_SILAH.DataSource= SILAH.GET_ALL_SILAH();
            }
            DGV_SILAH.DataSource = SILAH.SEARCH_SILAH(TXT_SEARCH.Text);
            DGV_SILAH.Columns[0].Visible = false;
            DGV_SILAH.Columns[1].Visible = false;
            DGV_SILAH.Columns[2].Visible = false;
            DGV_SILAH.Columns[9].Visible = false;
            CBOX_CAT_NAME.ResetText();
            TXT_NOTES.Clear();
        }

        private void TXT_SILAH_NAME_TextChanged(object sender, EventArgs e)
        {
        }

        private void DGV_SILAH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < DGV_SILAH.Rows.Count; i++)
            {
                if (DGV_SILAH.Rows[i].Index % 2 == 0)
                {
                    DGV_SILAH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171, 125, 47);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.FORM_SILAH_CATIGORY FRM = new FORM_SILAH_CATIGORY();
            FRM.ShowDialog();
            CBOX_CAT_NAME.DataSource = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                CBOX_CAT_NAME.DataSource = SILAH.GET_SILAH_BY_CAT_CODE(Convert.ToInt32(CBOX_CAT.SelectedValue.ToString()));
                CBOX_CAT_NAME.DisplayMember = "الاسم";
                CBOX_CAT_NAME.ValueMember = "CAT_SILAH_ID";
            }
            catch { return; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
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

              //  throw;
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

        }

        private void TXT_QTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void DGV_SILAH_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

           
            BTN_ADD.Enabled = false;
            BTN_DELETE.Enabled = true;
            BTN_EDIT.Enabled = true;
            TXT_SILAH_MODEL.Text = DGV_SILAH.CurrentRow.Cells[5].Value.ToString();
            CBOX_CAT_NAME.Text = DGV_SILAH.CurrentRow.Cells[4].Value.ToString();
            CBOX_CAT.Text = DGV_SILAH.CurrentRow.Cells[3].Value.ToString();
            TXT_QTY.Text = DGV_SILAH.CurrentRow.Cells[6].Value.ToString();
            TXT_NOTES.Text = DGV_SILAH.CurrentRow.Cells[8].Value.ToString();
            cbox_unit.Text = DGV_SILAH.CurrentRow.Cells[7].Value.ToString();
            CBOXKATEBA.Text = DGV_SILAH.CurrentRow.Cells[10].Value.ToString();
            }
            catch (Exception)
            {

             //   throw;
            }

        }
    }
}
