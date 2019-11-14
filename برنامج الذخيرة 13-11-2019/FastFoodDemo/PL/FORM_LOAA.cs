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
    public partial class FORM_LOAA : Form
    {
        BL.COPORATION_CLS COR = new BL.COPORATION_CLS();
        BL.TUGAY_CLS TUGAY = new BL.TUGAY_CLS();
        BL.EYALET_CLS EYALET = new BL.EYALET_CLS();
        BL.HEREM_CLS HER = new BL.HEREM_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.DELETED_CLS LOAA_Deleted = new BL.DELETED_CLS();

        private static FORM_LOAA frm;
       
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FORM_LOAA getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_LOAA();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
        }
        public FORM_LOAA()
        {
            InitializeComponent();
            frm = this;

            CBOX_HER.DataSource = HER.GET_ALL_HEREM();
            CBOX_HER.DisplayMember = "اسم الإقليم";
            CBOX_HER.ValueMember = "رقم الإقليم";
            DGV_TUGAY.DataSource = TUGAY.GET_ALL_TUGAY();
            DGV_TUGAY.Columns[0].Visible = false;
            DGV_TUGAY.Columns[1].Visible = false;
            DGV_TUGAY.Columns[7].Visible = false;
            DGV_TUGAY.Columns[8].Visible = false;
            BTN_EDIT.Enabled = false;
            BTN_DELETE.Enabled = false;
            CBOX_EYALET.Enabled = false;
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            if (TXTNUM.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم اللواء \n Numara Tûgay Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNUM.Focus();
                return;
            }
            if (TXT_TUGAY_NAME.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم اللواء \n Navê Tûgay Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_TUGAY_NAME.Focus();
                return;
            }
                     
            if (CBOX_HER.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب اختيار الإقليم \n Navê Herem Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_HER.Focus();
                return;
            }
            if (CBOX_EYALET.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب اختيار المنطقة \n Navê Eyalet Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_EYALET.Focus();
                return;
            }
          
            DataTable DT = TUGAY.GET_ALL_TUGAY();
            foreach (DataRow ROW in DT.Rows)
            {
                if (ROW.Field<string>(2).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show(" يوجد لواء بنفس الرقم مسبقاً \n Ji Heman Numarê Tûgayek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXT_TUGAY_NAME.Text.TrimEnd(' ').ToLower())
                {
                    if (ROW.Field<string>(6).TrimEnd(' ').ToLower() == CBOX_EYALET.Text.TrimEnd(' ').ToLower())
                    {
                    DataTable DT_herem = EYALET.GET_HEREM_BY_EYALET_CODE(CBOX_EYALET.SelectedValue.ToString().TrimEnd(' '));
                    if (DT_herem.Rows[0][2].ToString().TrimEnd(' ').ToLower() == CBOX_HER.SelectedValue.ToString().TrimEnd(' ').ToLower())
                    {
                        MessageBox.Show(" يوجد لواء بنفس الاسم مسبقاً في نفس المنطقة والإقليم \n Ji Heman Navî Tûgayek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    }
                }
            }
            /// عدم التقاطع مع محذوف سجل محذوف مؤقتاً
            DT = LOAA_Deleted.GET_ALL_TUGAY_DELETED();

            foreach (DataRow ROW in DT.Rows)
            {
                if (ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show(" يوجد لواء محذوف بشكل مؤقت بنفس الرقم \n Tûgayek jêbirî bi awakî demkî bi heman jimarê heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (ROW.Field<string>(4).TrimEnd(' ').ToLower() == TXT_TUGAY_NAME.Text.TrimEnd(' ').ToLower())
                {
                    if (ROW.Field<string>(2).TrimEnd(' ').ToLower() == CBOX_EYALET.Text.TrimEnd(' ').ToLower())
                    {
                        DataTable DT_herem = EYALET.GET_HEREM_BY_EYALET_CODE(CBOX_EYALET.SelectedValue.ToString().TrimEnd(' '));
                        if (DT_herem.Rows[0][2].ToString().TrimEnd(' ').ToLower() == CBOX_HER.SelectedValue.ToString().TrimEnd(' ').ToLower())
                        {
                            MessageBox.Show(" يوجد لواء بنفس الاسم محذوف بشكل مؤقت  في نفس المنطقة والإقليم \n Tûgayek jêbirî bi awakî demkî bi heman navî li heman eyaletê û heremê heye  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }
            }
            //////

            TUGAY.ADD_NEW_TUGAY(Program.APP_IDEN,TXTNUM.Text.TrimEnd(' '), CBOX_EYALET.SelectedValue.ToString(), TXT_TUGAY_NAME.Text.TrimEnd(' '), 0, TXTLOCATION.Text.TrimEnd(' '));
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة لواء", "إضافة", DateTime.Now);
            MessageBox.Show(" تم الاضافة بنجاح \n zêdekirin serkeftî derbas bû  ", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_TUGAY.DataSource = TUGAY.GET_ALL_TUGAY();
            BTN_ADD.Enabled = false;

            FORM_FAOJ.getMainForm.CBOX_TUGAY.DataSource = TUGAY.GET_ALL_TUGAY();
            FORM_KTEBA.getMainForm.CBOX_TUGAY.DataSource = TUGAY.GET_ALL_TUGAY();
      

        }

        private void BTNEDIT_Click(object sender, EventArgs e)
        {


            if (TXTNUM.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم اللواء \n Numara Tûgay Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNUM.Text = DGV_TUGAY.CurrentRow.Cells[0].Value.ToString();
                TXTNUM.Focus();
                return;
            }
            if (TXT_TUGAY_NAME.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم اللواء \n Navê Tûgay Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_TUGAY_NAME.Focus();
                TXT_TUGAY_NAME.Text = DGV_TUGAY.CurrentRow.Cells[1].Value.ToString();
                return;
            }

            if (CBOX_HER.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب اختيار الإقليم \n Navê Herem Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_HER.Focus();
                return;
            }
            if (CBOX_EYALET.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب اختيار المنطقة \n Navê Eyalet Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_EYALET.Focus();
                return;
            }
            DataTable DT_TUGAY_CODE = TUGAY.GET_TUGAY_CODE_FOR_EDIT(DGV_TUGAY.CurrentRow.Cells[0].Value.ToString().TrimEnd(' '));
            foreach (DataRow ROW in DT_TUGAY_CODE.Rows)
            {
                if (!(TXTNUM.Text.TrimEnd(' ').ToLower() == DGV_TUGAY.CurrentRow.Cells[0].Value.ToString()))
                {               
                    if (ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                    {
                        MessageBox.Show(" يوجد لواء بنفس الرقم مسبقاً \n Ji Heman Numarê Tûgayek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TXTNUM.Text = DGV_TUGAY.CurrentRow.Cells[3].Value.ToString();
                        return;
                    }
                }

            }

            DataTable DT1 = TUGAY.GET_TUGAT_FOR_EDIT(DGV_TUGAY.CurrentRow.Cells[3].Value.ToString().TrimEnd(' '));
            foreach (DataRow ROW in DT1.Rows)
            {

                if (ROW.Field<string>(4).TrimEnd(' ').ToLower() == TXT_TUGAY_NAME.Text.TrimEnd(' ').ToLower() )
                {
                    if (ROW.Field<string>(2).TrimEnd(' ').ToLower() == CBOX_EYALET.Text.TrimEnd(' ').ToLower())
                    {
                        DataTable DT_herem = EYALET.GET_HEREM_BY_EYALET_CODE(CBOX_EYALET.SelectedValue.ToString().TrimEnd(' '));
                        if (DT_herem.Rows[0][2].ToString().TrimEnd(' ').ToLower() == CBOX_HER.SelectedValue.ToString().TrimEnd(' ').ToLower())
                        {
                            MessageBox.Show(" يوجد لواء بنفس الاسم مسبقاً في نفس المنطقة والإقليم \n Ji Heman Navî Tûgayek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            TXT_TUGAY_NAME.Text = DGV_TUGAY.CurrentRow.Cells[4].Value.ToString();

                            return;
                        }

                    }
                }

            }


            /////// تقاطع المعدل مع المحذوف
            DT_TUGAY_CODE = LOAA_Deleted.GET_ALL_TUGAY_DELETED();
            foreach (DataRow ROW in DT_TUGAY_CODE.Rows)
            {
                if (!(TXTNUM.Text.TrimEnd(' ').ToLower() == DGV_TUGAY.CurrentRow.Cells[0].Value.ToString()))
                {
                    if (ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                    {
                        MessageBox.Show(" يوجد لواء محذوف بشكل مؤقت بنفس الرقم \n Tûgayek jêbirî bi awakî demkî bi heman jimarê heye  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TXTNUM.Text = DGV_TUGAY.CurrentRow.Cells[3].Value.ToString();
                        return;
                    }
                }

            }

            DT1 = LOAA_Deleted.GET_ALL_TUGAY_DELETED();

            foreach (DataRow ROW in DT1.Rows)
            {

                if (ROW.Field<string>(4).TrimEnd(' ').ToLower() == TXT_TUGAY_NAME.Text.TrimEnd(' ').ToLower())
                {
                    if (ROW.Field<string>(2).TrimEnd(' ').ToLower() == CBOX_EYALET.Text.TrimEnd(' ').ToLower())
                    {
                        DataTable DT_herem = EYALET.GET_HEREM_BY_EYALET_CODE(CBOX_EYALET.SelectedValue.ToString().TrimEnd(' '));
                        if (DT_herem.Rows[0][2].ToString().TrimEnd(' ').ToLower() == CBOX_HER.SelectedValue.ToString().TrimEnd(' ').ToLower())
                        {
                            MessageBox.Show(" يوجد لواء محذوف بشكل مؤقت بنفس الاسم في نفس المنطقة والإقليم \n Tûgayek jêbirî bi awakî demkî bi heman navî li heman eyaletê û heremê heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            TXT_TUGAY_NAME.Text = DGV_TUGAY.CurrentRow.Cells[4].Value.ToString();

                            return;
                        }
                    }
                }
            }
            ////

            TUGAY.EDIT_TUGAY(DGV_TUGAY.CurrentRow.Cells[0].Value.ToString(), CBOX_EYALET.SelectedValue.ToString(), TXT_TUGAY_NAME.Text.TrimEnd(' '),TXTLOCATION.Text.TrimEnd(' '),TXTNUM.Text.TrimEnd(' '));
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تعديل لواء", " biguhere - تعديل", DateTime.Now);
            MessageBox.Show(" تم التعديل بنجاح \n tomarkirin serkeftî ye ", "biguhere - التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_TUGAY.DataSource = TUGAY.GET_ALL_TUGAY();
            TXT_SEARCH.Clear();
            TXT_TUGAY_NAME.Clear();
            BTN_EDIT.Enabled = false;
            BTN_DELETE.Enabled = false;
            CBOX_EYALET.ResetText();
            TXTNUM.Clear();
            FORM_FAOJ.getMainForm.CBOX_TUGAY.DataSource = TUGAY.GET_ALL_TUGAY(); ;
            FORM_KTEBA.getMainForm.CBOX_TUGAY.DataSource = TUGAY.GET_ALL_TUGAY();


            BTN_ADD.Enabled = true;
            BTN_DELETE.Enabled = false;
            BTN_EDIT.Enabled = false;
            TXT_TUGAY_NAME.Clear();
            TXTNUM.Focus();
            TXTNUM.Clear();
            TXTLOCATION.Clear();
            TXT_SEARCH.Clear();
            CBOX_EYALET.ResetText();
            CBOX_EYALET.Enabled = false;


        }

        private void DGVLOAA_Click(object sender, EventArgs e)
        {
            //CBOX_EYALET.Enabled = true;
            //TXT_TUGAY_NAME.Text = DGV_TUGAY.CurrentRow.Cells[4].Value.ToString();
            //DataTable DT = EYALET.GET_HEREM_BY_EYALET_CODE(DGV_TUGAY.CurrentRow.Cells[7].Value.ToString());
            //CBOX_HER.Text = DT.Rows[0][3].ToString();
            //CBOX_EYALET.Text = DGV_TUGAY.CurrentRow.Cells[2].Value.ToString();
            //TXTNUM.Text = DGV_TUGAY.CurrentRow.Cells[3].Value.ToString();
            //TXTLOCATION.Text = DGV_TUGAY.CurrentRow.Cells[5].Value.ToString();
            //BTN_EDIT.Enabled = true;
            //BTN_DELETE.Enabled = true;
            //BTN_ADD.Enabled = false;
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TUGAY.DELETE_TUGAY(DGV_TUGAY.CurrentRow.Cells[3].Value.ToString());
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف لواء", "Jêbirinê - الحذف", DateTime.Now);
                MessageBox.Show("تم الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_TUGAY.DataSource = TUGAY.GET_ALL_TUGAY();
                TXT_SEARCH.Clear();
                TXT_TUGAY_NAME.Clear();
                TXTNUM.Clear();
                BTN_EDIT.Enabled = false;
                BTN_DELETE.Enabled = false;
                CBOX_EYALET.ResetText();
                FORM_FAOJ.getMainForm.CBOX_TUGAY.DataSource = TUGAY.GET_ALL_TUGAY(); ;
                FORM_KTEBA.getMainForm.CBOX_TUGAY.DataSource = TUGAY.GET_ALL_TUGAY();
            }
        }

        private void DGVLOAA_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < DGV_TUGAY.Rows.Count; i++)
            {
                if (DGV_TUGAY.Rows[i].Index % 2 == 0)
                {
                    DGV_TUGAY.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171, 125, 47);
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
            TXT_TUGAY_NAME.Clear();
            TXTNUM.Focus();
            TXTNUM.Clear();
            TXTLOCATION.Clear();
            TXT_SEARCH.Clear();
            CBOX_EYALET.ResetText();
            CBOX_EYALET.Enabled = false;
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

               // throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.FORM_IQLIM FRM = new FORM_IQLIM();
            FRM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.FORM_MANTKA FRM = new FORM_MANTKA();
            FRM.ShowDialog();
        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            TXT_TUGAY_NAME.Clear();
            if (TXT_SEARCH.Text == string.Empty)
            {
                DGV_TUGAY.DataSource = TUGAY.GET_ALL_TUGAY();
            }
            else
            {
                DGV_TUGAY.DataSource = TUGAY.SEARCH_YUGAY(TXT_SEARCH.Text);
                DGV_TUGAY.Columns[0].Visible = false;
                DGV_TUGAY.Columns[1].Visible = false;
               // DGV_TUGAY.Columns[2].Visible = false;
              //  DGV_TUGAY.Columns[5].Visible = false;
            }
        }

        private void CBOX_EYALET_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FORM_LOAA_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("الالوية", ar);
                label3.Text = rm.GetString("رقم اللواء", ar);
                label1.Text = rm.GetString("اسم اللواء", ar);
                label2.Text = rm.GetString("موقع اللواء", ar);
                label4.Text = rm.GetString("المنطقة", ar);
                label24.Text = rm.GetString("الاقليم", ar);
                label5.Text = rm.GetString("بحث", ar);
                button1.Text = rm.GetString("اضافة اقليم", ar);
                button2.Text = rm.GetString("اضافة منطقة", ar);              
                BTN_NEW.Text = rm.GetString("جديد", ar);
                BTN_ADD.Text = rm.GetString("اضافة", ar);
                BTN_EDIT.Text = rm.GetString("تعديل", ar);
                BTN_DELETE.Text = rm.GetString("حذف", ar);
            }
        }

        private void DGV_TUGAY_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                TXTNUM.Text = DGV_TUGAY.CurrentRow.Cells[2].Value.ToString();
                TXT_TUGAY_NAME.Text = DGV_TUGAY.CurrentRow.Cells[3].Value.ToString();
                TXTLOCATION.Text = DGV_TUGAY.CurrentRow.Cells[4].Value.ToString();
                CBOX_HER.Text = DGV_TUGAY.CurrentRow.Cells[5].Value.ToString(); ;// DT.Rows[0][3].ToString();
                CBOX_EYALET.Enabled = true;            
                DataTable DT = EYALET.GET_HEREM_BY_EYALET_CODE(DGV_TUGAY.CurrentRow.Cells[7].Value.ToString());           
                CBOX_EYALET.Text = DGV_TUGAY.CurrentRow.Cells[6].Value.ToString();              
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
