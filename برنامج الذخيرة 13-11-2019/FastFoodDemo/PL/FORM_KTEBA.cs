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
    public partial class FORM_KTEBA : Form
    {
        BL.TUGAY_CLS TUGAY = new BL.TUGAY_CLS();
        BL.TABUR_CLS TABUR = new BL.TABUR_CLS();
        BL.ALAY_CLS ALAY = new BL.ALAY_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.DELETED_CLS KTEBA_Deleted = new BL.DELETED_CLS();

        private static FORM_KTEBA frm;
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FORM_KTEBA getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_KTEBA();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
        }
        public FORM_KTEBA()
        {
            InitializeComponent();

            frm = this;
            CBOX_ALAY.DataSource = ALAY.GET_ALL_ALAY();
            CBOX_ALAY.DisplayMember = "الفوج";
            CBOX_ALAY.ValueMember = "رقم الفوج";

            CBOX_TUGAY.DataSource = TUGAY.GET_ALL_TUGAY();
            CBOX_TUGAY.DisplayMember = "اللواء";
            CBOX_TUGAY.ValueMember = "رقم اللواء";

            CBOX_ALAY.Enabled = false;
            DGV_TABUR.DataSource = TABUR.GET_ALL_TABUR();
            DGV_TABUR.Columns[0].Visible = false;
            DGV_TABUR.Columns[1].Visible = false;
            DGV_TABUR.Columns[7].Visible = false;
            DGV_TABUR.Columns[5].Visible = false;
            BTN_EDIT.Enabled = false;
            BTN_DELETE.Enabled = false;

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            if (TXTNUM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم الكتيبة \n Numara Tabûr Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNUM.Focus();
                return;
            }
            if (TXT_TABUR_NAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم الكتيبة \n Navê Tabûr Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_TABUR_NAME.Focus();
                return;
            }
            //DataTable DT_ALL_KTEBA = SOURCE.GET_ALL_KTEBA();
            //foreach (DataRow row in DT_ALL_KTEBA.Rows)
            //{
            //    if (row.Field<string>(0) == TXTNUM.Text.TrimEnd(' '))
            //    {
            //        MessageBox.Show(" توجد كتيبة بنفس الرقم مسبقاً \n Ji Heman Numarê Tabûrek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //    if (row.Field<string>(2) == TXT_TABUR_NAME.Text.TrimEnd(' ') && row.Field<string>(1) == CBOX_ALAY.SelectedValue.ToString())
            //    {
            //        MessageBox.Show(" توجد كتيبة بنفس الاسم مسبقاً في نفس الفوج و اللواء و المنطقة والإقليم \n Ji Heman Navî Tabûrek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //}

            //SOURCE.ADD_KTEBA(TXTNUM.Text.TrimEnd(' '), CBOX_ALAY.SelectedValue.ToString(), Program.APP_IDEN, TXT_TABUR_NAME.Text.TrimEnd(' '), TXTLOCATION.Text);

            //MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة", "إضافة الكتيبة : " + TXT_TABUR_NAME.Text, DateTime.Now);

            //MessageBox.Show("تمت عملية الإضافة بنجاح \n zêdekirin serkeftî derbas bû ", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //DGV_TABUR.DataSource = SOURCE.GET_ALL_KTEBA();
            //TXT_TABUR_NAME.Clear();
            //TXTLOCATION.Clear();
            //BTNADD.Enabled = true;
            //BTNEDIT.Enabled = false;
            //BTNDELETE.Enabled = false;
            //TXTNUM.Text = Program.APP_IDEN + SOURCE.GET_MAX_KTEBA_NUM().Rows[0][0].ToString();

        }

        private void BTNEDIT_Click(object sender, EventArgs e)
        {
            if (TXTNUM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم الكتيبة \n Numara Tabûr Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNUM.Focus();
                return;
            }
            if (TXT_TABUR_NAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم الكتيبة \n Navê Tabûr Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_TABUR_NAME.Focus();
                return;
            }
            //DataTable DT_ALL_KTEBA_FOR_EDIT = SOURCE.GET_ALL_KTEBA_FOR_EDIT(DGV_TABUR.CurrentRow.Cells[0].Value.ToString());
            //foreach (DataRow row in DT_ALL_KTEBA_FOR_EDIT.Rows)
            //{
            //    if (row.Field<string>(2) == TXTNUM.Text.TrimEnd(' '))
            //    {
            //        MessageBox.Show(" توجد كتيبة بنفس الرقم مسبقاً \n Ji Heman Numarê Tabûrek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //    if (row.Field<string>(1) == TXT_TABUR_NAME.Text.TrimEnd(' ') && row.Field<string>(0) == CBOX_ALAY.SelectedValue.ToString())
            //    {
            //        MessageBox.Show(" توجد كتيبة بنفس الاسم مسبقاً في نفس الفوج و اللواء و المنطقة والإقليم \n Ji Heman Navî Tabûrek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //}

            //SOURCE.EDIT_KTEBA(DGV_TABUR.CurrentRow.Cells[0].Value.ToString(), CBOX_ALAY.SelectedValue.ToString(),
            //    TXT_TABUR_NAME.Text.TrimEnd(' '), TXTLOCATION.Text, TXTNUM.Text.TrimEnd(' '));

            //MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, " biguhere - تعديل", "تعديل الكتيبة : " + DGV_TABUR.CurrentRow.Cells[2].Value.ToString(), DateTime.Now);

            //MessageBox.Show("تمت عملية التعديل بنجاح  \n sererastkirin bi awakî serkeftî hate tomarkirin ", " biguhere - تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //DGV_TABUR.DataSource = SOURCE.GET_ALL_KTEBA();
            //TXT_TABUR_NAME.Clear();
            //TXTLOCATION.Clear();
            //BTNADD.Enabled = true;
            //BTNEDIT.Enabled = false;
            //BTNDELETE.Enabled = false;
            //TXTNUM.Text = Program.APP_IDEN + SOURCE.GET_MAX_KTEBA_NUM().Rows[0][0].ToString();

        }

        private void DGVKTEBA_Click(object sender, EventArgs e)
        {           
            //BTN_EDIT.Enabled = true;
            //CBOX_ALAY.Enabled = true;
            //TXTNUM.Text = DGV_TABUR.CurrentRow.Cells[3].Value.ToString();
            //TXT_TABUR_NAME.Text = DGV_TABUR.CurrentRow.Cells[4].Value.ToString();
            //TXTLOCATION.Text = DGV_TABUR.CurrentRow.Cells[6].Value.ToString();
            //CBOX_ALAY.Text = DGV_TABUR.CurrentRow.Cells[2].Value.ToString();
            //DataTable DT_TYGAY = TUGAY.GET_TUGAY_BY_ALAY_CODE(DGV_TABUR.CurrentRow.Cells[7].Value.ToString());  
            //CBOX_TUGAY.Text = DT_TYGAY.Rows[0][7].ToString();
            //BTN_EDIT.Enabled = true;
            //BTN_DELETE.Enabled = true;
            //BTN_ADD.Enabled = false;
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //SOURCE.DELETE_KTEBA(DGV_TABUR.CurrentRow.Cells[0].Value.ToString());

                //MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "Jêbirinê - الحذف", "حذف الكتيبة : " + DGV_TABUR.CurrentRow.Cells[2].Value.ToString(), DateTime.Now);
                //MessageBox.Show("تمت عملية الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //DGV_TABUR.DataSource = SOURCE.GET_ALL_KTEBA();
                //TXT_TABUR_NAME.Clear();
                //TXTLOCATION.Clear();
                //BTNADD.Enabled = true;
                //BTNEDIT.Enabled = false;
                //BTNDELETE.Enabled = false;
                //TXTNUM.Text = Program.APP_IDEN + SOURCE.GET_MAX_KTEBA_NUM().Rows[0][0].ToString();

            }
        }

        private void DGVKTEBA_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < DGV_TABUR.Rows.Count; i++)
            {
                if (DGV_TABUR.Rows[i].Index % 2 == 0)
                {
                    DGV_TABUR.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171,125,47);
                }
            }
        }

        private void TXTNUM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void BTNNEW_Click(object sender, EventArgs e)
        {
          
            TXTNUM.Clear();
            TXTLOCATION.Clear();
            BTN_ADD.Enabled = true;
            BTN_DELETE.Enabled = false;
            BTN_EDIT.Enabled = false;
            TXT_TABUR_NAME.Clear();
            TXTNUM.Focus();
            TXT_SEARCH.Clear();
            CBOX_ALAY.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            TXT_TABUR_NAME.Clear();
            if (TXT_SEARCH.Text == string.Empty)
            {
                DGV_TABUR.DataSource = TABUR.GET_ALL_TABUR();
            }
            else
            {
                DGV_TABUR.DataSource = TABUR.SEARCH_TABUR(TXT_SEARCH.Text);
                DGV_TABUR.Columns[0].Visible = false;
                DGV_TABUR.Columns[1].Visible = false;
               // DGV_TABUR.Columns[2].Visible = false;
                DGV_TABUR.Columns[5].Visible = false;
            }
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            if (TXTNUM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم الكتيبة \n Numara Tabûr Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNUM.Focus();
                return;
            }
            if (TXT_TABUR_NAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم الكتيبة \n Navê Tabûr Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_TABUR_NAME.Focus();
                return;
            }

            if (CBOX_ALAY.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار اللواء والفوج \n Navê Alay û Tûgay  Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_TUGAY.Focus();
                return;
            }
            DataTable DT = TABUR.GET_ALL_TABUR();
            foreach (DataRow ROW in DT.Rows)
            {
                if (ROW.Field<string>(4).TrimEnd(' ').ToLower() == TXT_TABUR_NAME.Text.TrimEnd(' ').ToLower()
                    && ROW.Field<string>(2).TrimEnd(' ').ToLower() == CBOX_ALAY.Text.TrimEnd(' ').ToLower()
                    
                   )
                {
                    MessageBox.Show("توجد كتيبة بنفس الاسم مسبقاً في نفس الفوج و اللواء و المنطقة والإقليم \n Ji Heman Navî Tabûrek Din Heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("توجد كتيبة بنفس الرقم مسبقاً \n Ji Heman Numarê Tabûrek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            ///// عدم التقاطع مع المحذوف بشكل مؤقت
            DT=KTEBA_Deleted.GET_ALL_TABUR_DELETED();
            foreach (DataRow ROW in DT.Rows)
            {
                if (ROW.Field<string>(4).TrimEnd(' ').ToLower() == TXT_TABUR_NAME.Text.TrimEnd(' ').ToLower()
                    && ROW.Field<string>(2).TrimEnd(' ').ToLower() == CBOX_ALAY.Text.TrimEnd(' ').ToLower()

                   )
                {
                    MessageBox.Show("تمت إضافة كتيبة محذوفه بشكل مؤقت بنفس الاسم المدخل  بنفس الفوج واللواء", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("تمت إضافة كتيبة محذوفه بشكل مؤقت بنفس الرقم المدخل \n Tabûreka jêbirî bi awakî demkî bi heman jimara derbaskirî hatîye zêdekirin   ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            //////


            TABUR.ADD_NEW_TABUR(Program.APP_IDEN,TXTNUM.Text.TrimEnd(' '), CBOX_ALAY.SelectedValue.ToString(), TXT_TABUR_NAME.Text.TrimEnd(' '), 0,TXTLOCATION.Text.TrimEnd(' '));
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة كتيبة", "إضافة", DateTime.Now);
            MessageBox.Show(" تم الاضافة بنجاح \n zêdekirin serkeftî derbas bû  ", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_TABUR.DataSource = TABUR.GET_ALL_TABUR();
            BTN_ADD.Enabled = false;
            CBOX_ALAY.Enabled = false;
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
          
            if (TXTNUM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم الكتيبة \n Numara Tabûr Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNUM.Focus();
                return;
            }
            if (TXT_TABUR_NAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم الكتيبة \n Navê Tabûr Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_TABUR_NAME.Focus();
                return;
            }

            if (CBOX_ALAY.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار اللواء والفوج \n Navê Alay û Tûgay  Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_TUGAY.Focus();
                return;
            }

            DataTable DT_ALL_KTEBA_FOR_EDIT = TABUR.GET_TABUR_FOR_EDIT(DGV_TABUR.CurrentRow.Cells[3].Value.ToString());
            foreach (DataRow row in DT_ALL_KTEBA_FOR_EDIT.Rows)
            {
                if (row.Field<string>(3).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower() )
                {
                    MessageBox.Show(" توجد كتيبة بنفس الرقم مسبقاً \n Ji Heman Numarê Tabûrek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTNUM.Text = DGV_TABUR.CurrentRow.Cells[3].Value.ToString();
                    return;
                }
                if (row.Field<string>(4).TrimEnd(' ').ToLower() == TXT_TABUR_NAME.Text.TrimEnd(' ').ToLower() && row.Field<string>(2).TrimEnd(' ').ToLower() == CBOX_ALAY.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show(" توجد كتيبة بنفس الاسم مسبقاً في نفس الفوج و اللواء و المنطقة والإقليم \n Ji Heman Navî Tabûrek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXT_TABUR_NAME.Text = DGV_TABUR.CurrentRow.Cells[4].Value.ToString();
                    return;
                }
            }

            ///// عدم تقاطع المعدل مع المحذوف بشكل مؤقت
            DT_ALL_KTEBA_FOR_EDIT= KTEBA_Deleted.GET_ALL_TABUR_DELETED();
            foreach (DataRow row in DT_ALL_KTEBA_FOR_EDIT.Rows)
            {
                if (row.Field<string>(3).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show(" توجد كتيبة محذوفه بشكل مؤقت بنفس الرقم \n Tabûreka jêbirî bi awakî demkî bi heman jimarê heye  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTNUM.Text = DGV_TABUR.CurrentRow.Cells[3].Value.ToString();
                    return;
                }
                if (row.Field<string>(4).TrimEnd(' ').ToLower() == TXT_TABUR_NAME.Text.TrimEnd(' ').ToLower() && row.Field<string>(2).TrimEnd(' ').ToLower() == CBOX_ALAY.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show(" توجد كتيبة  محذوفه بشكل مؤقت بنفس الاسم في نفس الفوج و اللواء و المنطقة والإقليم \n Tabûreka jêbirî bi awakî demkî bi heman navî li heman Alay, Tûgay, Herem û Eyaletê heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXT_TABUR_NAME.Text = DGV_TABUR.CurrentRow.Cells[4].Value.ToString();
                    return;
                }
            }


            ////////



            TABUR.EDIT_TABUR(DGV_TABUR.CurrentRow.Cells[3].Value.ToString(), CBOX_ALAY.SelectedValue.ToString(), TXT_TABUR_NAME.Text.TrimEnd(' '),TXTNUM.Text.TrimEnd(' '),TXTLOCATION.Text.TrimEnd(' '));
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تعديل كتيبة", " biguhere - تعديل", DateTime.Now);
            MessageBox.Show(" تم التعديل بنجاح \n tomarkirin serkeftî ye ", "biguhere - التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_TABUR.DataSource = TABUR.GET_ALL_TABUR();
            TXT_SEARCH.Clear();
            TXT_TABUR_NAME.Clear();
            BTN_EDIT.Enabled = false;
            BTN_DELETE.Enabled = false;
            CBOX_ALAY.ResetText();
            CBOX_ALAY.Enabled = false;
            TXTNUM.Clear();
            TXTLOCATION.Clear();
            CBOX_ALAY.SelectedValue = string.Empty;

        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TABUR.DELETE_TABUR(DGV_TABUR.CurrentRow.Cells[3].Value.ToString());
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف كتيبة", "Jêbirinê - الحذف", DateTime.Now);
                MessageBox.Show("تم الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_TABUR.DataSource = TABUR.GET_ALL_TABUR();
                TXT_SEARCH.Clear();
                TXT_TABUR_NAME.Clear();
                BTN_EDIT.Enabled = false;
                BTN_DELETE.Enabled = false;
                CBOX_ALAY.ResetText();
                CBOX_ALAY.Enabled = false;
                CBOX_ALAY.SelectedValue = string.Empty;
                TXTNUM.Clear();
                TXTLOCATION.Clear();

            }
        }

        private void CBOX_ALAY_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CBOX_ALAY.DataSource = ALAY.GET_ALAY_BY_TUGAY_CODE(CBOX_TUGAY.SelectedValue.ToString());
            //CBOX_ALAY.DisplayMember = "الفوج";
            //CBOX_ALAY.ValueMember = "ALAY_CODE";
        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            BTN_ADD.Enabled = true;
            CBOX_ALAY.Enabled = false ;
            BTN_DELETE.Enabled = false;
            BTN_EDIT.Enabled = false;
            TXT_TABUR_NAME.Clear();
            TXTNUM.Focus();
            TXT_SEARCH.Clear();
            CBOX_ALAY.ResetText();
            TXTNUM.Clear();
            TXTLOCATION.Clear();
            CBOX_ALAY.SelectedValue = string.Empty;

           
        }

        private void CBOX_TUGAY_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBOX_ALAY.Enabled = true;
            CBOX_ALAY.DataSource = ALAY.GET_ALAY_BY_TUGAY_CODE(CBOX_TUGAY.SelectedValue.ToString());
            CBOX_ALAY.DisplayMember = "الفوج";
            CBOX_ALAY.ValueMember = "ALAY_CODE";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FORM_LOAA FRM = new FORM_LOAA();
            FRM.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FORM_FAOJ FRM = new FORM_FAOJ();
            FRM.ShowDialog();
            CBOX_ALAY.DataSource = null;
        }

        private void FORM_KTEBA_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("الكتائب", ar);
                label3.Text = rm.GetString("رقم الكتيبة", ar);
                label1.Text = rm.GetString("اسم الكتيبة", ar);
                label2.Text = rm.GetString("موقع الكتيبة", ar);
                label4.Text = rm.GetString("اللواء", ar);
                label24.Text = rm.GetString("الفوج", ar);
                label5.Text = rm.GetString("بحث", ar);
                button1.Text = rm.GetString("دمج الكلمتين", ar);
                button2.Text = rm.GetString("اضافة لواء", ar);
                button3.Text = rm.GetString("اضافة فوج", ar);
                BTN_NEW.Text = rm.GetString("جديد", ar);
                BTN_ADD.Text = rm.GetString("اضافة", ar);
                BTN_EDIT.Text = rm.GetString("تعديل", ar);
                BTN_DELETE.Text = rm.GetString("حذف", ar);
            }
        }

        private void DGV_TABUR_SelectionChanged(object sender, EventArgs e)
        {
            BTN_DELETE.Enabled = true;
            BTN_EDIT.Enabled = true;
            try
            {
                BTN_EDIT.Enabled = true;
                CBOX_ALAY.Enabled = true;
                TXTNUM.Text = DGV_TABUR.CurrentRow.Cells[3].Value.ToString();
                TXT_TABUR_NAME.Text = DGV_TABUR.CurrentRow.Cells[4].Value.ToString();
                TXTLOCATION.Text = DGV_TABUR.CurrentRow.Cells[6].Value.ToString();
                CBOX_ALAY.Text = DGV_TABUR.CurrentRow.Cells[2].Value.ToString();
                DataTable DT_TYGAY = TUGAY.GET_TUGAY_BY_ALAY_CODE(DGV_TABUR.CurrentRow.Cells[7].Value.ToString());
                CBOX_TUGAY.Text = DT_TYGAY.Rows[0][7].ToString();
                BTN_EDIT.Enabled = true;
                BTN_DELETE.Enabled = true;
                BTN_ADD.Enabled = false;

            }
            catch (Exception)
            {

               // throw;
            }
        }
    }
}
