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
    public partial class FORM_MANTKA : Form
    {
        BL.EYALET_CLS EYALET = new BL.EYALET_CLS();
        BL.HEREM_CLS HER = new BL.HEREM_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.DELETED_CLS MANTKA_Delete = new BL.DELETED_CLS();
        private static FORM_MANTKA frm;
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FORM_MANTKA getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_MANTKA();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
        }
        public FORM_MANTKA()
        {
            InitializeComponent();
            frm = this;
            DGV_EYALET.DataSource = EYALET.GET_ALL_EYALET();
            CBOX_HEREM.DataSource = HER.GET_ALL_HEREM();
            CBOX_HEREM.DisplayMember = "اسم الإقليم";
            CBOX_HEREM.ValueMember = "رقم الإقليم";
            DGV_EYALET.Columns[0].Visible = false;
            DGV_EYALET.Columns[1].Visible = false;
           // DGV_EYALET.Columns[2].Visible = false;
            DGV_EYALET.Columns[5].Visible = false;
            DGV_EYALET.Columns[6].Visible = false;
            BTN_EDIT.Enabled = false;
            BTN_DELETE.Enabled = false;
            DGV_EYALET.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }


        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            if (TXTNUM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم المنطقة \n Numara Eyalet Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNUM.Focus();
                return;
            }
         
            if (TXT_EYALET_NAME.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم المنطقة \n Navê Eyalet Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_EYALET_NAME.Focus();
                return;
            }
            if (CBOX_HEREM.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب اختيار الإقليم \n Navê Herem Derbas Bike  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_HEREM.Focus();
                return;
            }
           
            DataTable DT = EYALET.GET_ALL_EYALET();
            foreach (DataRow ROW in DT.Rows)
            {
                if (ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())                                     
                {
                    MessageBox.Show("توجد منطقة بنفس الرقم المدخل مسبقاً \n Ji Heman Numarê Eyaletek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (ROW.Field<string>(4).TrimEnd(' ').ToLower() == TXT_EYALET_NAME.Text.TrimEnd(' ').ToLower()
                    && ROW.Field<string>(2).TrimEnd(' ').ToLower() == CBOX_HEREM.Text)
                {
                    MessageBox.Show("يوجد منطقة بنفس الاسم في نفس الأقليم \n Ji Heman Navî Eyaletek Din Heye" , "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            //// عدم التقاطع مع المناطق المحذوف
            DT= MANTKA_Delete.GET_ALL_EYALET_DELETED();
            foreach (DataRow ROW in DT.Rows)
            {
                if (ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("توجد منطقة محذوفه مؤقتاً بنفس الرقم المدخل \n Eyaletek jêbirî bi awakî demkî bi heman jimara derbaskirî heye.  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (ROW.Field<string>(4).TrimEnd(' ').ToLower() == TXT_EYALET_NAME.Text.TrimEnd(' ').ToLower()
                    && ROW.Field<string>(2).TrimEnd(' ').ToLower() == CBOX_HEREM.Text)
                {
                    MessageBox.Show("يوجد منطقة محذوفه مؤقتاً بنفس الاسم في نفس الأقليم \n Eyaletek jêbirî bi awakî demkî bi heman navî li heman herêmê heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            /////

            EYALET.ADD_NEW_EYALET(Program.APP_IDEN, TXTNUM.Text.TrimEnd(' '), CBOX_HEREM.SelectedValue.ToString(), TXT_EYALET_NAME.Text.TrimEnd(' '), 0);
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة منطقة", "إضافة", DateTime.Now);
            MessageBox.Show(" تم الاضافة بنجاح \n zêdekirin serkeftî derbas bû  ", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_EYALET.DataSource = EYALET.GET_ALL_EYALET();
            BTN_ADD.Enabled = false;
            try
            {
            FORM_LOAA.getMainForm.CBOX_EYALET.DataSource = EYALET.GET_EYALET_BY_HEREM_CODE(Program.HEREM_CODE);
            }
            catch (Exception)
            {

               // throw;
            }

        }

        private void DGVMANTKA_Click(object sender, EventArgs e)
        {
            //TXT_EYALET_NAME.Text = DGV_EYALET.CurrentRow.Cells[4].Value.ToString();
            //TXTNUM.Text = DGV_EYALET.CurrentRow.Cells[3].Value.ToString();
            //CBOX_HEREM.Text = DGV_EYALET.CurrentRow.Cells[2].Value.ToString();
            //BTN_EDIT.Enabled = true;
            //BTN_DELETE.Enabled = true;
            //BTN_ADD.Enabled = false;
        }

        private void BTNEDIT_Click(object sender, EventArgs e)
        {
            if (TXTNUM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم المنطقة \n Numara Eyalet Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNUM.Focus();
                return;
            }

            if (TXT_EYALET_NAME.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم المنطقة \n Navê Eyalet Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_EYALET_NAME.Focus();
                return;
            }
            if (CBOX_HEREM.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب اختيار الإقليم \n Navê Herem Derbas Bike  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_HEREM.Focus();
                return;
            }

            DataTable DT1 = EYALET.GET_EYALET_FOR_EDIT(DGV_EYALET.CurrentRow.Cells[3].Value.ToString().TrimEnd(' '));
            foreach (DataRow ROW in DT1.Rows)
            {
                if (ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("توجد منطقة بنفس الرقم المدخل مسبقاً \n Ji Heman Numarê Eyaletek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTNUM.Text = DGV_EYALET.CurrentRow.Cells[3].Value.ToString();
                    return;
                }

                if (ROW.Field<string>(4).TrimEnd(' ').ToLower() == TXT_EYALET_NAME.Text.TrimEnd(' ').ToLower() && ROW.Field<string>(2).TrimEnd(' ').ToLower() == CBOX_HEREM.Text.ToLower())
                {
                    MessageBox.Show("يوجد منطقة بنفس الاسم في نفس الأقليم \n Ji Heman Navî Eyaletek Din Heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXT_EYALET_NAME.Text = DGV_EYALET.CurrentRow.Cells[4].Value.ToString();
                    CBOX_HEREM.Text = DGV_EYALET.CurrentRow.Cells[2].Value.ToString();
                    return;
                }

            }

            /////// عدم التقاطع المعدل مع المحذوف مؤقتاً
            DT1 = MANTKA_Delete.GET_ALL_EYALET_DELETED();
            foreach (DataRow ROW in DT1.Rows)
            {
                if (ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("توجد منطقة محذوفه مؤقتاً بنفس الرقم المدخل \n Eyaletek jêbirî bi awakî demkî bi heman jimara derbaskirî heye.  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTNUM.Text = DGV_EYALET.CurrentRow.Cells[3].Value.ToString();
                    return;
                }

                if (ROW.Field<string>(4).TrimEnd(' ').ToLower() == TXT_EYALET_NAME.Text.TrimEnd(' ').ToLower() && ROW.Field<string>(2).TrimEnd(' ').ToLower() == CBOX_HEREM.Text.ToLower())
                {
                    MessageBox.Show("يوجد منطقة محذوفه مؤقتاً بنفس الاسم في نفس الأقليم \n Eyaletek jêbirî bi awakî demkî bi heman navî li heman herêmê heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXT_EYALET_NAME.Text = DGV_EYALET.CurrentRow.Cells[4].Value.ToString();
                    CBOX_HEREM.Text = DGV_EYALET.CurrentRow.Cells[2].Value.ToString();
                    return;
                }

            }

            /////

            EYALET.EDIT_EYALET(DGV_EYALET.CurrentRow.Cells[3].Value.ToString(), CBOX_HEREM.SelectedValue.ToString(), TXT_EYALET_NAME.Text.TrimEnd(' '),TXTNUM.Text.TrimEnd(' '));
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تعديل منطقة", " biguhere - تعديل", DateTime.Now);
            MessageBox.Show(" تم التعديل بنجاح \n tomarkirin serkeftî ye ", "biguhere - التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_EYALET.DataSource = EYALET.GET_ALL_EYALET();
            TXT_SEARCH.Clear();
            TXT_EYALET_NAME.Clear();
            TXTNUM.Clear();
            BTN_EDIT.Enabled = false;
            BTN_DELETE.Enabled = false;
            CBOX_HEREM.ResetText();
            try
            {          
            FORM_LOAA.getMainForm.CBOX_EYALET.DataSource = EYALET.GET_EYALET_BY_HEREM_CODE(Program.HEREM_CODE);
            }
            catch (Exception)
            {

              //  throw;
            }
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {           
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EYALET.DELETE_EYALET(DGV_EYALET.CurrentRow.Cells[3].Value.ToString());
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف منطقة", "Jêbirinê - الحذف", DateTime.Now);
                MessageBox.Show("تم الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_EYALET.DataSource = EYALET.GET_ALL_EYALET();
                TXT_SEARCH.Clear();
                TXT_EYALET_NAME.Clear();
                TXTNUM.Clear();
                BTN_EDIT.Enabled = false;
                BTN_DELETE.Enabled = false;
                CBOX_HEREM.ResetText();
                try
                {
              
                FORM_LOAA.getMainForm.CBOX_EYALET.DataSource = EYALET.GET_EYALET_BY_HEREM_CODE(Program.HEREM_CODE);
                }
                catch (Exception)
                {

                   // throw;
                }
            }
        }

        private void DGVMANTKA_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < DGV_EYALET.Rows.Count; i++)
            {
                if (DGV_EYALET.Rows[i].Index % 2 == 0)
                {
                    DGV_EYALET.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171,125,47);
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
            BTN_ADD.Enabled = true;
            BTN_DELETE.Enabled = false;
            BTN_EDIT.Enabled = false;
            TXT_EYALET_NAME.Clear();
            TXTNUM.Clear();
            TXTNUM.Focus();
            TXT_SEARCH.Clear();
            CBOX_HEREM.ResetText();
        }

        private void FORM_MANTKA_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("المناطق", ar);
                label2.Text = rm.GetString("رقم المنطقة", ar);
                label1.Text = rm.GetString("اسم المنطقة", ar);
                label24.Text = rm.GetString("اسم الاقليم", ar);
                label3.Text = rm.GetString("بحث", ar);
                button1.Text = rm.GetString("اضافة اقليم", ar);
                BTN_NEW.Text = rm.GetString("جديد", ar);
                BTN_ADD.Text = rm.GetString("اضافة", ar);
                BTN_EDIT.Text = rm.GetString("تعديل", ar);
                BTN_DELETE.Text = rm.GetString("حذف", ar);
            }
        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            TXT_EYALET_NAME.Clear();
            if (TXT_SEARCH.Text == string.Empty)
            {
                DGV_EYALET.DataSource = EYALET.GET_ALL_EYALET();
            }
            else
            {
                DGV_EYALET.DataSource = EYALET.SREACH_EYALET(TXT_SEARCH.Text);
                DGV_EYALET.Columns[0].Visible = false;
                DGV_EYALET.Columns[1].Visible = false;
               // DGV_EYALET.Columns[2].Visible = false;
                DGV_EYALET.Columns[5].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORM_IQLIM frm = new FORM_IQLIM();
            frm.ShowDialog();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DGV_EYALET_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

            TXT_EYALET_NAME.Text = DGV_EYALET.CurrentRow.Cells[4].Value.ToString();
            TXTNUM.Text = DGV_EYALET.CurrentRow.Cells[3].Value.ToString();
            CBOX_HEREM.Text = DGV_EYALET.CurrentRow.Cells[2].Value.ToString();
            BTN_EDIT.Enabled = true;
            BTN_DELETE.Enabled = true;
            BTN_ADD.Enabled = false;

            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
