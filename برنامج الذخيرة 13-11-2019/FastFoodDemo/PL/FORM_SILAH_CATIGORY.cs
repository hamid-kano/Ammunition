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
    public partial class FORM_SILAH_CATIGORY : Form
    {
        BL.SILAH_CLS SILAH = new BL.SILAH_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        public FORM_SILAH_CATIGORY()
        {
            InitializeComponent();
            DGV_SILAH.DataSource = SILAH.GET_ALL_CAT_SILAH();
            DGV_SILAH.Columns[0].Visible = false;
            DGV_SILAH.Columns[1].Visible = false;
            DGV_SILAH.Columns[5].Visible = false;
            CBOX_SILAH_TYPE.DataSource = SILAH.GET_ALL_CATEGORY();
            CBOX_SILAH_TYPE.DisplayMember = "الاسم";
            CBOX_SILAH_TYPE.ValueMember = "CAT_ID";
            BTN_DELETE.Enabled = false;
            BTN_EDIT.Enabled = false;

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
                this.Text = rm.GetString("ادارة الاصناف", ar);
                label2.Text = rm.GetString("النوع", ar);
                label1.Text = rm.GetString("الاسم", ar);
                label5.Text = rm.GetString("ملاحظات", ar);
                BTN_NEW.Text = rm.GetString("جديد", ar);
                BTN_ADD.Text = rm.GetString("اضافة", ar);
                BTN_EDIT.Text = rm.GetString("تعديل", ar);
                BTN_DELETE.Text = rm.GetString("حذف", ar);
            }
        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {

            TXT_NOTES.Clear();
            TXT_SILAH_NAME.Clear();
            CBOX_SILAH_TYPE.Focus();           
            CBOX_SILAH_TYPE.ResetText(); 
            BTN_ADD.Enabled = true;
            BTN_DELETE.Enabled = false;
            BTN_EDIT.Enabled = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //BTN_ADD.Enabled = false;
            //BTN_DELETE.Enabled = true;
            //BTN_EDIT.Enabled = true;
            //TXT_SILAH_NAME.Text = DGV_SILAH.CurrentRow.Cells[3].Value.ToString();

            //CBOX_SILAH_TYPE.Text = DGV_SILAH.CurrentRow.Cells[2].Value.ToString();

            //TXT_NOTES.Text = DGV_SILAH.CurrentRow.Cells[4].Value.ToString();
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
             if (CBOX_SILAH_TYPE.Text.TrimEnd(' ') == string.Empty)
             {
                 MessageBox.Show("يجب إدخال النوع \n Cûre Derbas Bike  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 CBOX_SILAH_TYPE.Focus();
                 return;
             }
            if (TXT_SILAH_NAME.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال الاسم \n Nav Derbas Bike  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_SILAH_NAME.Focus();
                return;
            }                                         
            DataTable DT = SILAH.GET_ALL_CAT_SILAH();
            foreach (DataRow ROW in DT.Rows)
            {
                if (ROW.Field<string>(2).TrimEnd(' ').ToLower() == CBOX_SILAH_TYPE.Text.TrimEnd(' ').ToLower()
                  &&  ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXT_SILAH_NAME.Text.TrimEnd(' ').ToLower()
                  )
                {
                    MessageBox.Show("تمت الإضافة بنفس المواصفات المدخلة مسبقاً \n Ji Heman Sîlahan Sîlahek Din Heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            try
            {
              SILAH.ADD_CAT_SILAH(Convert.ToInt32(CBOX_SILAH_TYPE.SelectedValue.ToString()),TXT_SILAH_NAME.Text,TXT_NOTES.Text,0);
            }
            catch (Exception)
            {
                MessageBox.Show("يوجد سلاح محذوف بشكل موقت بنفس المواصفات المدخلة \n Çekeka jêbirî bi awakî demkî bi heman taybetîyên derbaskirî heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
             //   throw;
            }
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة صنف سلاح", "إضافة", DateTime.Now);
            MessageBox.Show(" تم الاضافة بنجاح \n zêdekirin serkeftî derbas bû  ", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_SILAH.DataSource = SILAH.GET_ALL_CAT_SILAH();
            BTN_ADD.Enabled = false;
            FORM_SILAH_MNG.getMainForm.CBOX_CAT_NAME.DataSource = SILAH.GET_SILAH_BY_CAT_CODE(Convert.ToInt32(FORM_SILAH_MNG.getMainForm.CBOX_CAT.SelectedValue.ToString()));
            
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            if (CBOX_SILAH_TYPE.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال النوع \n Cûre Derbas Bike  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_SILAH_TYPE.Focus();
                return;
            }
            if (TXT_SILAH_NAME.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال الاسم \n Nav Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_SILAH_NAME.Focus();
                return;
            }
            DataTable DT = SILAH.GET_CAT_SILAH_FOR_EDIT(DGV_SILAH.CurrentRow.Cells[3].Value.ToString(), DGV_SILAH.CurrentRow.Cells[2].Value.ToString());
            foreach (DataRow ROW in DT.Rows)
            {
                if (ROW.Field<string>(2).TrimEnd(' ').ToLower() == CBOX_SILAH_TYPE.Text.TrimEnd(' ').ToLower()
                    && ROW.Field<string>(3).TrimEnd(' ').ToLower() == TXT_SILAH_NAME.Text.TrimEnd(' ').ToLower())                    
                {
                    MessageBox.Show("يوجد صنف بنفس المواصفات مسبقاً \n Ji Heman Sîlahan Sîlahek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            SILAH.EDIT_CAT(Convert.ToInt32(CBOX_SILAH_TYPE.SelectedValue.ToString()), TXT_SILAH_NAME.Text.TrimEnd(' '), TXT_NOTES.Text,Convert.ToInt32(DGV_SILAH.CurrentRow.Cells[1].Value.ToString()));
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تعديل صنف سلاح", " biguhere - تعديل", DateTime.Now);
            MessageBox.Show(" تم التعديل بنجاح \n tomarkirin serkeftî ye ", "biguhere - التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_SILAH.DataSource = SILAH.GET_ALL_CAT_SILAH();
            TXT_NOTES.Clear();
            TXT_SILAH_NAME.Clear();
            CBOX_SILAH_TYPE.Focus();
            CBOX_SILAH_TYPE.ResetText();
            BTN_ADD.Enabled = true;
            BTN_DELETE.Enabled = false;
            BTN_EDIT.Enabled = false;
            FORM_SILAH_MNG.getMainForm.CBOX_CAT_NAME.DataSource = SILAH.GET_SILAH_BY_CAT_CODE(Convert.ToInt32(FORM_SILAH_MNG.getMainForm.CBOX_CAT.SelectedValue.ToString()));
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SILAH.DELETE_CAT(DGV_SILAH.CurrentRow.Cells[1].Value.ToString());
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف صنف سلاح", "Jêbirinê - الحذف", DateTime.Now);
                MessageBox.Show("تم الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_SILAH.DataSource = SILAH.GET_ALL_CAT_SILAH();
                TXT_NOTES.Clear();
                TXT_SILAH_NAME.Clear();
                CBOX_SILAH_TYPE.Focus();
                CBOX_SILAH_TYPE.ResetText();
                BTN_ADD.Enabled = true;
                BTN_DELETE.Enabled = false;
                BTN_EDIT.Enabled = false;
                FORM_SILAH_MNG.getMainForm.CBOX_CAT_NAME.DataSource = SILAH.GET_SILAH_BY_CAT_CODE(Convert.ToInt32(FORM_SILAH_MNG.getMainForm.CBOX_CAT.SelectedValue.ToString()));

            }
            
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void DGV_SILAH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void DGV_SILAH_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

           
            BTN_ADD.Enabled = false;
            BTN_DELETE.Enabled = true;
            BTN_EDIT.Enabled = true;
            TXT_SILAH_NAME.Text = DGV_SILAH.CurrentRow.Cells[3].Value.ToString();

            CBOX_SILAH_TYPE.Text = DGV_SILAH.CurrentRow.Cells[2].Value.ToString();

            TXT_NOTES.Text = DGV_SILAH.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
