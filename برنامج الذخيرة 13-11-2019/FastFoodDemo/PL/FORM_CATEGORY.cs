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
    public partial class FORM_CATEGORY : Form
    {
        BL.SILAH_CLS SILAH = new BL.SILAH_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        public FORM_CATEGORY()
        {
            InitializeComponent();
            DGV_CAT.DataSource = SILAH.GET_ALL_CATEGORY();
            DGV_CAT.Columns[0].Visible = false;
            DGV_CAT.Columns[2].Visible = false;
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
                label1.Text = rm.GetString("الاسم", ar);
                BTN_NEW.Text = rm.GetString("جديد", ar);
                BTN_ADD.Text = rm.GetString("اضافة", ar);
                BTN_EDIT.Text = rm.GetString("تعديل", ar);
                BTN_DELETE.Text = rm.GetString("حذف", ar);

            }
        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {

            TXT_NAME.Clear();
            TXT_NAME.Focus();
            BTN_ADD.Enabled = true;
            BTN_DELETE.Enabled = false;
            BTN_EDIT.Enabled = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //BTN_ADD.Enabled = false;
            //BTN_DELETE.Enabled = true;
            //BTN_EDIT.Enabled = true;
            //TXT_NAME.Text = DGV_CAT.CurrentRow.Cells[1].Value.ToString();
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {            
          
            if (TXT_NAME.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال الاسم \n Nav Derbas Bike  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_NAME.Focus();
                return;
            }                                         
            DataTable DT = SILAH.GET_ALL_CATEGORY();
            foreach (DataRow ROW in DT.Rows)
            {
                if (ROW.Field<string>(1).TrimEnd(' ').ToLower() == TXT_NAME.Text.TrimEnd(' ').ToLower()
                  )
                {
                    MessageBox.Show("تمت إضافة صنف بنفس الاسم  مسبقاً \n Ji Heman Cûreyên Cûreyek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            try
            {

            SILAH.ADD_CATEGRY(TXT_NAME.Text.TrimEnd(' '));

            }
            catch (Exception)
            {
                MessageBox.Show("تمت إضافة صنف بياناته تتقاطع مع صنف محذوف بشكل مؤقت \n Cureyek agahîyan bi cureyeka jêbirî bi awakî demkî derbasdar e hate zêdekirin.   ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // throw;
                return;
            }
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة صنف سلاح", "إضافة صنف", DateTime.Now);

            MessageBox.Show(" تم الاضافة بنجاح \n zêdekirin serkeftî derbas bû  ", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_CAT.DataSource = SILAH.GET_ALL_CATEGORY();
            BTN_ADD.Enabled = false;
           // FORM_SILAH_MNG.getMainForm.CBOX_CAT.DataSource = SILAH.GET_ALL_CAT_SILAH();
            
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            if (TXT_NAME.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال الاسم \n Nav Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_NAME.Text = DGV_CAT.CurrentRow.Cells[1].Value.ToString();
                TXT_NAME.Focus();
                return;
            }
            DataTable DT = SILAH.GET_CATEGORY_FOR_EDIT(DGV_CAT.CurrentRow.Cells[1].Value.ToString());
            foreach (DataRow ROW in DT.Rows)
            {
                if (ROW.Field<string>(1).TrimEnd(' ').ToLower() == TXT_NAME.Text.TrimEnd(' ').ToLower())                    
                {
                    MessageBox.Show("يوجد صنف بنفس الاسم مسبقاً \n Ji Heman Cûreyên Cûreyek Din Heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   TXT_NAME.Text = DGV_CAT.CurrentRow.Cells[1].Value.ToString();
                    return;
                }
            }
            if (TXT_NAME.Text.TrimEnd(' ') == "Sîlahê Şexsî - سلاح فردي")
            {
                MessageBox.Show("لا يمكن تعديل هذا النوع \n Jêbirin Na be", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_NAME.Text = DGV_CAT.CurrentRow.Cells[1].Value.ToString();
                return;
            }
            SILAH.EDIT_CATEGORY(TXT_NAME.Text.TrimEnd(' '),Convert.ToInt32(DGV_CAT.CurrentRow.Cells[0].Value.ToString()));
            MessageBox.Show(" تم التعديل بنجاح \n tomarkirin serkeftî ye ", "biguhere - التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_CAT.DataSource = SILAH.GET_ALL_CATEGORY();

            TXT_NAME.Clear();
            BTN_ADD.Enabled = true;
            BTN_DELETE.Enabled = false;
            BTN_EDIT.Enabled = false;
        //    FORM_SILAH_MNG.getMainForm.CBOX_CAT.DataSource = SILAH.GET_ALL_CAT_SILAH();
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (TXT_NAME.Text.TrimEnd(' ') == "Sîlahê Şexsî - سلاح فردي")
                {
                    MessageBox.Show("لا يمكن حذف هذا النوع \n Jêbirin Na be", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXT_NAME.Text = DGV_CAT.CurrentRow.Cells[1].Value.ToString();
                    return;
                }
                SILAH.DELETE_CATEGORY(Convert.ToInt32(DGV_CAT.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تم الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_CAT.DataSource = SILAH.GET_ALL_CATEGORY();
                TXT_NAME.Clear();
                TXT_NAME.Focus();
                BTN_ADD.Enabled = true;
                BTN_DELETE.Enabled = false;
                BTN_EDIT.Enabled = false;
        
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
            for (int i = 0; i < DGV_CAT.Rows.Count; i++)
            {
                if (DGV_CAT.Rows[i].Index % 2 == 0)
                {
                    DGV_CAT.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171, 125, 47);
                }
            }
        }

        private void DGV_SILAH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_CAT_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

            BTN_ADD.Enabled = false;
            BTN_DELETE.Enabled = true;
            BTN_EDIT.Enabled = true;
            TXT_NAME.Text = DGV_CAT.CurrentRow.Cells[1].Value.ToString();

            }
            catch (Exception)
            {

               // throw;
            }
        }
    }
}
