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
    public partial class FORM_IQLIM : Form
    {
        BL.SOURC_CLS SOURCE = new BL.SOURC_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.HEREM_CLS HER = new BL.HEREM_CLS();
        BL.EYALET_CLS EYALET = new BL.EYALET_CLS();
        BL.DELETED_CLS HER_Delete = new BL.DELETED_CLS();
        public FORM_IQLIM()
        {
            InitializeComponent();  
            DGV_HEREM.DataSource = HER.GET_ALL_HEREM();
            DGV_HEREM.Columns[0].Visible = false;
            DGV_HEREM.Columns[1].Visible = false;

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void FORM_IQLIM_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("الاقاليم", ar);
                label2.Text = rm.GetString("بحث", ar);
                label1.Text = rm.GetString("رقم الاقليم", ar);
                label24.Text = rm.GetString("اسم الاقليم", ar);
                BTNNEW.Text = rm.GetString("جديد", ar);
                BTN_ADD.Text = rm.GetString("اضافة", ar);
                BTNEDIT.Text = rm.GetString("تعديل", ar);
                BTNDELETE.Text = rm.GetString("حذف", ar);
            }
        }

        private void DGVIQLIM_Click(object sender, EventArgs e)
        {
            //BTN_ADD.Enabled = false;
            //BTNEDIT.Enabled = true;
            //BTNDELETE.Enabled = true;
            //TXT_HEREM_NAME.Text = DGV_HEREM.CurrentRow.Cells[3].Value.ToString();
            //TXTNUM.Text = DGV_HEREM.CurrentRow.Cells[2].Value.ToString();
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            if (TXTNUM.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم الإقليم \n Numara Herem Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNUM.Focus();
                return;
            }
            if (TXT_HEREM_NAME.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم الإقليم \n Navê Herem Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_HEREM_NAME.Focus();
                return;
            }
          
            DataTable DT = HER.GET_ALL_HEREM();
            foreach (DataRow ROW in DT.Rows)
            {
                if (ROW.Field<string>(3).ToLower() == TXT_HEREM_NAME.Text.TrimEnd(' ').ToLower() )
                {
                    MessageBox.Show("يوجد إقليم بنفس الاسم \n Ji Heman Navî Heremek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (ROW.Field<string>(2).ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower() )
                {
                    MessageBox.Show("يوجد إقليم مسبقاً بنفس الرقم \n Ji Heman Numarê Heremek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (ROW.Field<string>(2).ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower() && ROW.Field<string>(3).ToLower() == TXT_HEREM_NAME.Text.TrimEnd(' ').ToLower() )
                {
                    MessageBox.Show("تمت إضافة إقليم بنفس الرقم والاسم المدخل مسبقاً \n Ji Heman Numarê ,Navî Heremek Din Heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            //للنظر اذا كان بين السجلات المحذوفة اخذ السجل الجديد رقمه او اسمه .
            DT = HER_Delete.GET_ALL_HEREM_DELETED();

            foreach (DataRow ROW in DT.Rows)
            {
                if (ROW.Field<string>(3).ToLower() == TXT_HEREM_NAME.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("يوجد إقليم مسبقاً محذوف بشكل مؤقت بنفس الاسم \n Heremeka berê jêbirî bi awakî demkî bi heman Navî heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (ROW.Field<string>(2).ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("يوجد إقليم مسبقاً محذوف بشكل مؤقت بنفس الرقم \n Heremeka berê jêbirî bi awakî demkî bi heman hejmarê heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (ROW.Field<string>(2).ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower() && ROW.Field<string>(3).ToLower() == TXT_HEREM_NAME.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show(" يوجد إقليم مسبقاً محذوف بشكل مؤقت بنفس الاسم والرقم \n Heremeka berê jêbirî bi awakî demkî bi heman Navî,Numarê heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            ///////////////////////////////////////////

            HER.ADD_NEW_HEREM(Program.APP_IDEN,TXTNUM.Text.TrimEnd(' '), TXT_HEREM_NAME.Text.TrimEnd(' '), 0);
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة إقليم", "إضافة", DateTime.Now);
            MessageBox.Show(" تم الاضافة بنجاح \n zêdekirin serkeftî derbas bû  ", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_HEREM.DataSource = HER.GET_ALL_HEREM();
            BTN_ADD.Enabled = false;
            FORM_MANTKA.getMainForm.CBOX_HEREM.DataSource = HER.GET_ALL_HEREM();
            FORM_LOAA.getMainForm.CBOX_HER.DataSource = HER.GET_ALL_HEREM();
        }

        private void BTNEDIT_Click(object sender, EventArgs e)
        {
            if (TXTNUM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم الإقليم \n Numara Herem Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNUM.Focus();
                return;
            }
            if (TXT_HEREM_NAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم الإقليم \n Navê Herem Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_HEREM_NAME.Focus();
                return;
            }
         
            DataTable DT1 = HER.GET_HEREM_FOR_EDIT(DGV_HEREM.CurrentRow.Cells[3].Value.ToString().TrimEnd(' '));
            foreach (DataRow ROW in DT1.Rows)
            {

                if (ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXT_HEREM_NAME.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("يوجد إقليم بنفس الاسم \n Ji Heman Navî Heremek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXT_HEREM_NAME.Text = DGV_HEREM.CurrentRow.Cells[3].Value.ToString();
                    return;
                }
                if (ROW.Field<string>(2).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                 {
                     MessageBox.Show("يوجد إقليم مسبقاً بنفس الرقم \n Ji Heman Numarê Heremek Din Heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     TXTNUM.Text = DGV_HEREM.CurrentRow.Cells[2].Value.ToString();
                    return;
                 }
                if (ROW.Field<string>(2).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower() && ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXT_HEREM_NAME.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("يوجد إقليم مسبقاً بنفس الاسم والرقم \n Ji Heman Numarê ,Navî Heremek Din Heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTNUM.Text = DGV_HEREM.CurrentRow.Cells[2].Value.ToString();
                    TXT_HEREM_NAME.Text = DGV_HEREM.CurrentRow.Cells[3].Value.ToString();
                    return;
                }
            }

            ////// للنظر اذا كان بين السجلات المحذوفة اخذ السجل المعدل رقمه او اسمه

            DT1 = HER_Delete.GET_ALL_HEREM_DELETED();
            foreach (DataRow ROW in DT1.Rows)
            {

                if (ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXT_HEREM_NAME.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("يوجد إقليم مسبقاً محذوف بشكل مؤقت بنفس الاسم \n Heremeka berê jêbirî bi awakî demkî bi heman Navî heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXT_HEREM_NAME.Text = DGV_HEREM.CurrentRow.Cells[3].Value.ToString();
                    return;
                }
                if (ROW.Field<string>(2).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("يوجد إقليم مسبقاً محذوف بشكل مؤقت بنفس الرقم \n Heremeka berê jêbirî bi awakî demkî bi heman hejmarê heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTNUM.Text = DGV_HEREM.CurrentRow.Cells[2].Value.ToString();
                    return;
                }
                if (ROW.Field<string>(2).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower() && ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXT_HEREM_NAME.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("يوجد إقليم مسبقاً محذوف بشكل مؤقت بنفس الاسم والرقم \n Heremeka berê jêbirî bi awakî demkî bi heman Navî,Numarê heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTNUM.Text = DGV_HEREM.CurrentRow.Cells[2].Value.ToString();
                    TXT_HEREM_NAME.Text = DGV_HEREM.CurrentRow.Cells[3].Value.ToString();
                    return;
                }
            }

            /////////////////////////////////////////////////////////

            HER.EDIT_HEREM(DGV_HEREM.CurrentRow.Cells[2].Value.ToString(), TXT_HEREM_NAME.Text.TrimEnd(' '),TXTNUM.Text.TrimEnd(' '));
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تعديل إقليم", " biguhere - تعديل", DateTime.Now);
            MessageBox.Show(" تم التعديل بنجاح \n tomarkirin serkeftî ye ", "biguhere - التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_HEREM.DataSource = HER.GET_ALL_HEREM();
            TXT_SEARCH.Clear();
            TXT_HEREM_NAME.Clear();
            TXTNUM.Clear();
            BTNEDIT.Enabled = false;
            BTNDELETE.Enabled = false;
            FORM_MANTKA.getMainForm.CBOX_HEREM.DataSource = HER.GET_ALL_HEREM();
            FORM_LOAA.getMainForm.CBOX_HER.DataSource = HER.GET_ALL_HEREM();
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
         
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HER.DELETE_HEREM(DGV_HEREM.CurrentRow.Cells[2].Value.ToString());
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف إقليم", "Jêbirinê - الحذف", DateTime.Now);
                MessageBox.Show("تم الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_HEREM.DataSource = HER.GET_ALL_HEREM();
                TXT_SEARCH.Clear();
                TXT_HEREM_NAME.Clear();
                TXTNUM.Clear();
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;
                FORM_MANTKA.getMainForm.CBOX_HEREM.DataSource = HER.GET_ALL_HEREM();
                FORM_LOAA.getMainForm.CBOX_HER.DataSource = HER.GET_ALL_HEREM();
            }
        }

        private void DGVIQLIM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < DGV_HEREM.Rows.Count; i++)
            {
                if (DGV_HEREM.Rows[i].Index % 2 == 0)
                {
                    DGV_HEREM.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171,125,47);
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

        private void TXTNUM_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BTNNEW_Click(object sender, EventArgs e)
        {                      
            
            BTN_ADD.Enabled = true;
            BTNDELETE.Enabled = false;
            BTNEDIT.Enabled = false;
            TXT_HEREM_NAME.Clear();
            TXTNUM.Clear();
            TXTNUM.Focus();
            TXT_SEARCH.Clear();
        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            TXT_HEREM_NAME.Clear();
            if (TXT_SEARCH.Text == string.Empty)
            {
                DGV_HEREM.DataSource = HER.GET_ALL_HEREM();
            }
            else
            {
                DGV_HEREM.DataSource = HER.SEARCH_HEREM(TXT_SEARCH.Text);
                DGV_HEREM.Columns[0].Visible = false;
                DGV_HEREM.Columns[1].Visible = false;
                DGV_HEREM.Columns[4].Visible = false;
            }
        }

        private void TXT_HEREM_NAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGV_HEREM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_HEREM_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
            
            BTN_ADD.Enabled = false;
            BTNEDIT.Enabled = true;
            BTNDELETE.Enabled = true;
            TXT_HEREM_NAME.Text = DGV_HEREM.CurrentRow.Cells[3].Value.ToString();
            TXTNUM.Text = DGV_HEREM.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {

              //  throw;
            }
        }
    }
}
