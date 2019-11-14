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
    public partial class FORM_SOURCE : Form
    {
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.SOURC_CLS SOURCE = new BL.SOURC_CLS();
        private static FORM_SOURCE frm;
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FORM_SOURCE getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_SOURCE();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
        }
        public FORM_SOURCE()
        {
            InitializeComponent();

            frm = this;
            DGV_SOUR.DataSource = SOURCE.GET_ALL_SOURCE();
            DGV_SOUR.Columns[0].Visible = false;
            BTN_EDIT.Enabled = false;
            BTN_DELETE.Enabled = false;

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

     
        private void DGVKTEBA_Click(object sender, EventArgs e)
        {           
            //BTN_EDIT.Enabled = true;
            //TXTNAME.Text = DGV_SOUR.CurrentRow.Cells[2].Value.ToString();
            //TXT_NUM.Text = DGV_SOUR.CurrentRow.Cells[1].Value.ToString();
            //BTN_EDIT.Enabled = true;
            //BTN_DELETE.Enabled = true;
            //BTN_ADD.Enabled = false;
        }

  


        private void DGVKTEBA_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < DGV_SOUR.Rows.Count; i++)
            {
                if (DGV_SOUR.Rows[i].Index % 2 == 0)
                {
                    DGV_SOUR.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171,125,47);
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

        private void label24_Click(object sender, EventArgs e)
        {

        }

        

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
          
            if (TXT_NUM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم الجهة \n Numara Cih Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_NUM.Focus();
                return;
            }
            if (TXTNAME.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال الجهة \n Cih Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNAME.Focus();
                return;
            }
            DataTable DT = SOURCE.GET_ALL_SOURCE();
            foreach (DataRow ROW in DT.Rows)
            {
                if (ROW.Field<string>(1).TrimEnd(' ').ToLower() == TXT_NUM.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("توجد جهة بنفس الرقم مسبقاً \n Ji Heman Numara Cihek Din Heye  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (ROW.Field<string>(2).TrimEnd(' ').ToLower() == TXTNAME.Text.TrimEnd(' ').ToLower() )
                {
                    MessageBox.Show(" توجد جهة بنفس الاسم مسبقاً \n Ji Heman Navî Cihek Din Heye  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            SOURCE.ADD_NEW_SOURCE(Program.APP_IDEN, TXT_NUM.Text.TrimEnd(' '), TXTNAME.Text.TrimEnd(' '),0);
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة جهة", "إضافة", DateTime.Now);
            MessageBox.Show(" تم الاضافة بنجاح \n zêdekirin serkeftî derbas bû  ", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_SOUR.DataSource = SOURCE.GET_ALL_SOURCE();
            BTN_ADD.Enabled = false;
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            if (TXT_NUM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم الجهة \n Numara Cih Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_NUM.Focus();
                return;
            }
            if (TXTNAME.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال الجهة \n Cih Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNAME.Focus();
                return;
            }
            DataTable DT1 = SOURCE.GET_SOURCE_FOR_EDIT(DGV_SOUR.CurrentRow.Cells[1].Value.ToString().TrimEnd(' '));

            foreach (DataRow ROW in DT1.Rows)
            {
                if (ROW.Field<string>(1).TrimEnd(' ').ToLower() == TXT_NUM.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show("توجد جهة بنفس الرقم مسبقاً \n Ji Heman Numara Cihek Din Heye  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXT_NUM.Text = DGV_SOUR.CurrentRow.Cells[1].Value.ToString();
                    return;
                }
                if (ROW.Field<string>(2).TrimEnd(' ').ToLower() == TXTNAME.Text.TrimEnd(' ').ToLower() && ROW.Field<string>(0).TrimEnd(' ').ToLower() == Program.APP_IDEN.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show(" توجد جهة بنفس الاسم مسبقاً \n Ji Heman Navî Cihek Din Heye  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXTNAME.Text = DGV_SOUR.CurrentRow.Cells[2].Value.ToString();
                    return;
                }
            }

            SOURCE.EDIT_SOURCE(DGV_SOUR.CurrentRow.Cells[1].Value.ToString(), TXTNAME.Text.TrimEnd(' '), TXT_NUM.Text.TrimEnd(' '), 0);
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تعديل جهة", " biguhere - تعديل", DateTime.Now);
            MessageBox.Show(" تم التعديل بنجاح \n tomarkirin serkeftî ye ", "biguhere - التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_SOUR.DataSource = SOURCE.GET_ALL_SOURCE();
            TXT_NUM.Clear();
            BTN_EDIT.Enabled = false;
            BTN_DELETE.Enabled = false;
            TXTNAME.Clear();


        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SOURCE.DELETE_SOURCE(DGV_SOUR.CurrentRow.Cells[1].Value.ToString(),1);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف جهة", "Jêbirinê - الحذف", DateTime.Now);
                MessageBox.Show("تم الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_SOUR.DataSource = SOURCE.GET_ALL_SOURCE();
                TXT_NUM.Clear();
                BTN_EDIT.Enabled = false;
                BTN_DELETE.Enabled = false;
                TXTNAME.Clear();
            }
        }


        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            BTN_ADD.Enabled = true;
            BTN_DELETE.Enabled = false;
            BTN_EDIT.Enabled = false;
            TXT_NUM.Clear();
            TXT_NUM.Focus();
            TXTNAME.Clear();
           
        }

       

      



        private void FORM_SOURCE_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("الجهات", ar);
                label1.Text = rm.GetString("رقم الجهة", ar);
                label3.Text = rm.GetString("اسم الجهة", ar);
                BTN_NEW.Text = rm.GetString("جديد", ar);
                BTN_ADD.Text = rm.GetString("اضافة", ar);
                BTN_EDIT.Text = rm.GetString("تعديل", ar);
                BTN_DELETE.Text = rm.GetString("حذف", ar);
   


            }
        }

        private void DGV_SOUR_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

            BTN_EDIT.Enabled = true;
            TXTNAME.Text = DGV_SOUR.CurrentRow.Cells[2].Value.ToString();
            TXT_NUM.Text = DGV_SOUR.CurrentRow.Cells[1].Value.ToString();
            BTN_EDIT.Enabled = true;
            BTN_DELETE.Enabled = true;
            BTN_ADD.Enabled = false;

            }
            catch (Exception)
            {

              //  throw;
            }
        }
    }
}
