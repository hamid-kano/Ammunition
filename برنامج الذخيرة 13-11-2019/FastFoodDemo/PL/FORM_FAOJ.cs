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
    public partial class FORM_FAOJ : Form
    {
        BL.TUGAY_CLS TUGAY = new BL.TUGAY_CLS();
        BL.ALAY_CLS ALAY = new BL.ALAY_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.DELETED_CLS FAOJ_Deleted =new BL.DELETED_CLS();
        private static FORM_FAOJ frm;
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FORM_FAOJ getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_FAOJ();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
        }
        public FORM_FAOJ()
        {
            InitializeComponent();
            frm = this;
            CBOX_TUGAY.DataSource = TUGAY.GET_ALL_TUGAY();
            CBOX_TUGAY.DisplayMember = "اللواء";
            CBOX_TUGAY.ValueMember = "رقم اللواء";
            DGV_ALAY.DataSource = ALAY.GET_ALL_ALAY();
            DGV_ALAY.Columns[0].Visible = false;
            DGV_ALAY.Columns[1].Visible = false;
            DGV_ALAY.Columns[5].Visible = false;
            DGV_ALAY.Columns[7].Visible = false;
            BTN_EDIT.Enabled = false;
            BTN_DELETE.Enabled = false;

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }
     
     
        private void DGV_ALAY_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < DGV_ALAY.Rows.Count; i++)
            {
                if (DGV_ALAY.Rows[i].Index % 2 == 0)
                {
                    DGV_ALAY.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171, 125, 47);
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

        private void FORM_FAOJ_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("الافواج", ar);
                label3.Text = rm.GetString("رقم الفوج", ar);
                label1.Text = rm.GetString("اسم الفوج", ar);
                label2.Text = rm.GetString("موقع الفوج", ar);
                label24.Text = rm.GetString("اللواء", ar);
                label5.Text = rm.GetString("بحث", ar);
                button1.Text = rm.GetString("اضافة لواء", ar);
                BTN_NEW.Text = rm.GetString("جديد", ar);
                BTN_ADD .Text = rm.GetString("اضافة", ar);
                BTN_EDIT.Text = rm.GetString("تعديل", ar);
                BTN_DELETE.Text = rm.GetString("حذف", ar);

            }
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            if (TXTNUM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم الفوج \n Numara Alay Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNUM.Focus();
                return;
            }
            if (TXT_ALAY_NAME.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم الفوج \n Navê Alay Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_ALAY_NAME.Focus();
                return;
            }

        
            DataTable DT = ALAY.GET_ALL_ALAY();
            foreach (DataRow ROW in DT.Rows)
            {
                if (ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                    {
                        MessageBox.Show("يوجد فوج بنفس الرقم مسبقاً \n Ji Numara Alay Heye  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                if (ROW.Field<string>(4).TrimEnd(' ').ToLower() == TXT_ALAY_NAME.Text.TrimEnd(' ').ToLower() && ROW.Field<string>(7).TrimEnd(' ').ToLower() == CBOX_TUGAY.SelectedValue.ToString().TrimEnd(' ').ToLower())
                    {
                        MessageBox.Show(" يوجد فوج بنفس الاسم مسبقاً في نفس اللواء \n Ji Heman Navî Alayek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }                
            }
            /// عدم المقاطعة الجديد مع المحذوف بشكل مؤقت
            DT = FAOJ_Deleted.GET_ALL_ALAY_DELETED();

            foreach (DataRow ROW in DT.Rows)
            {
                if (ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("يوجد فوج محذوف بشكل مؤقت بنفس الرقم \n Alayek jêbirî bi awakî demkî bi heman jimarê heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (ROW.Field<string>(4).TrimEnd(' ').ToLower() == TXT_ALAY_NAME.Text.TrimEnd(' ').ToLower() && ROW.Field<string>(7).TrimEnd(' ').ToLower() == CBOX_TUGAY.SelectedValue.ToString().TrimEnd(' ').ToLower())
                {
                    MessageBox.Show(" يوجد فوج محذوف بشكل مؤقت بنفس الاسم  في نفس اللواء \n Alayek jêbirî bi awakî demkî bi heman navî li heman Tûgayê heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            ////
            ALAY.ADD_NEW_ALAY(Program.APP_IDEN, TXTNUM.Text.TrimEnd(' '), CBOX_TUGAY.SelectedValue.ToString(), TXT_ALAY_NAME.Text.TrimEnd(' '), 0,TXTLOCATION.Text);
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة فوج", "إضافة", DateTime.Now);
            MessageBox.Show(" تم الاضافة بنجاح \n zêdekirin serkeftî derbas bû  ", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_ALAY.DataSource = ALAY.GET_ALL_ALAY();
            BTN_ADD.Enabled = false;
           FORM_KTEBA.getMainForm.CBOX_ALAY.DataSource = ALAY.GET_ALAY_BY_TUGAY_CODE(CBOX_TUGAY.SelectedValue.ToString());

        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            if (TXTNUM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم الفوج \n Numara Alay Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNUM.Text = DGV_ALAY.CurrentRow.Cells[3].Value.ToString();
                TXTNUM.Focus();
                return;
            }
            if (TXT_ALAY_NAME.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم الفوج \n Navê Alay Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_ALAY_NAME.Text = DGV_ALAY.CurrentRow.Cells[4].Value.ToString();
                TXT_ALAY_NAME.Focus();
                return;
            }

            DataTable DT1 = ALAY.GET_ALAY_FOR_EDIT(DGV_ALAY.CurrentRow.Cells[3].Value.ToString().TrimEnd(' '));
            foreach (DataRow ROW in DT1.Rows)
            {

                if (ROW.Field<string>(4).TrimEnd(' ').ToLower() == TXT_ALAY_NAME.Text.TrimEnd(' ').ToLower() && ROW.Field<string>(2).TrimEnd(' ').ToLower() == CBOX_TUGAY.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("يوجد فوج بنفس الاسم المدخل مسبقا في نفس اللواء \n Ji Heman Navî Alayek Din Heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXT_ALAY_NAME.Text = DGV_ALAY.CurrentRow.Cells[4].Value.ToString();
                    return;
                }
                if (ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("يوجد فوج بنفس الرقم مسبقاً \n  Ji Heman Numarê Alayek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTNUM.Text = DGV_ALAY.CurrentRow.Cells[3].Value.ToString();
                    return;
                }
            }
            if (TXT_ALAY_NAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم الفوج \n Navê Alay Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_ALAY_NAME.Focus();
                TXT_ALAY_NAME.Text = DGV_ALAY.CurrentRow.Cells[4].Value.ToString();
                return;
            }

            //// عدم تقاطع المعدل مع المحذوف بشكل مؤقت
            DT1 = FAOJ_Deleted.GET_ALL_ALAY_DELETED();

            foreach (DataRow ROW in DT1.Rows)
            {

                if (ROW.Field<string>(4).TrimEnd(' ').ToLower() == TXT_ALAY_NAME.Text.TrimEnd(' ').ToLower() && ROW.Field<string>(2).TrimEnd(' ').ToLower() == CBOX_TUGAY.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("يوجد فوج محذوف بشكل مؤقت بنفس الاسم المدخل  في نفس اللواء \n Alayek jêbirî bi awakî demkî bi heman navê li heman Tugayê heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXT_ALAY_NAME.Text = DGV_ALAY.CurrentRow.Cells[4].Value.ToString();
                    return;
                }
                if (ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("يوجد فوج محذوف بشكل مؤقت بنفس الرقم \n Alayek jêbirî bi awakî demkî bi heman jimarê heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTNUM.Text = DGV_ALAY.CurrentRow.Cells[3].Value.ToString();
                    return;
                }
            }

            /////

            ALAY.EDIT_ALAY(DGV_ALAY.CurrentRow.Cells[3].Value.ToString(), CBOX_TUGAY.SelectedValue.ToString(), TXT_ALAY_NAME.Text.TrimEnd(' '),TXTNUM.Text.TrimEnd(' '),TXTLOCATION.Text.TrimEnd(' '));
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تعديل فوج", " biguhere - تعديل", DateTime.Now);
            MessageBox.Show(" تم التعديل بنجاح \n tomarkirin serkeftî ye ", "biguhere - التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_ALAY.DataSource = ALAY.GET_ALL_ALAY();
            TXT_SEARCH.Clear();
            TXT_ALAY_NAME.Clear();
            BTN_EDIT.Enabled = false;
            BTN_DELETE.Enabled = false;
            CBOX_TUGAY.ResetText();
            TXTLOCATION.Clear();
            TXTNUM.Clear();
            FORM_KTEBA.getMainForm.CBOX_ALAY.DataSource = ALAY.GET_ALAY_BY_TUGAY_CODE(CBOX_TUGAY.SelectedValue.ToString());

        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            BTN_ADD.Enabled = true;
            BTN_DELETE.Enabled = false;
            BTN_EDIT.Enabled = false;
            TXT_ALAY_NAME.Clear();
            TXTNUM.Focus();
            TXTNUM.Clear();
            TXT_SEARCH.Clear();
            TXTLOCATION.Clear();
            CBOX_TUGAY.ResetText();
        }

        private void DGV_ALAY_Click(object sender, EventArgs e)
        {
            //TXT_ALAY_NAME.Text = DGV_ALAY.CurrentRow.Cells[4].Value.ToString();
            //TXTNUM.Text = DGV_ALAY.CurrentRow.Cells[3].Value.ToString();
            //CBOX_TUGAY.Text = DGV_ALAY.CurrentRow.Cells[2].Value.ToString();
            //TXTLOCATION.Text = DGV_ALAY.CurrentRow.Cells[6].Value.ToString();
            //BTN_EDIT.Enabled = true;
            //BTN_DELETE.Enabled = true;
            //BTN_ADD.Enabled = false;
        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            TXT_ALAY_NAME.Clear();
            if (TXT_SEARCH.Text == string.Empty)
            {
                DGV_ALAY.DataSource = ALAY.GET_ALL_ALAY();
            }
            else
            {
                DGV_ALAY.DataSource = ALAY.SEARCH_ALAY(TXT_SEARCH.Text);
                DGV_ALAY.Columns[0].Visible = false;
                DGV_ALAY.Columns[1].Visible = false;
                //DGV_ALAY.Columns[2].Visible = false;
                DGV_ALAY.Columns[7].Visible = false;
            }
        }

        private void DGV_ALAY_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                for (int i = 0; i < DGV_ALAY.Rows.Count; i++)
                {
                    if (DGV_ALAY.Rows[i].Index % 2 == 0)
                    {
                        DGV_ALAY.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171, 125, 47);
                    }
                }
            }
            catch { return; }
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            try
            {
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ALAY.DELETE_ALAY(DGV_ALAY.CurrentRow.Cells[3].Value.ToString());
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف فوج", "Jêbirinê - الحذف", DateTime.Now);
                MessageBox.Show("تم الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_ALAY.DataSource = ALAY.GET_ALL_ALAY();
                TXT_SEARCH.Clear();
                TXT_ALAY_NAME.Clear();
                TXTNUM.Clear();
                TXTLOCATION.Clear();
                BTN_EDIT.Enabled = false;
                BTN_DELETE.Enabled = false;
                CBOX_TUGAY.ResetText();
                FORM_KTEBA.getMainForm.CBOX_ALAY.DataSource = ALAY.GET_ALAY_BY_TUGAY_CODE(CBOX_TUGAY.SelectedValue.ToString());
            }
            }
            catch (Exception)
            {
               // throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORM_LOAA frm = new FORM_LOAA();
            frm.ShowDialog();
        }

        private void DGV_ALAY_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

            
            TXT_ALAY_NAME.Text = DGV_ALAY.CurrentRow.Cells[4].Value.ToString();
            TXTNUM.Text = DGV_ALAY.CurrentRow.Cells[3].Value.ToString();
            CBOX_TUGAY.Text = DGV_ALAY.CurrentRow.Cells[2].Value.ToString();
            TXTLOCATION.Text = DGV_ALAY.CurrentRow.Cells[6].Value.ToString();
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
