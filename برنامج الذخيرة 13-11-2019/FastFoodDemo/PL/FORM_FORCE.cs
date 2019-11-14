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
    public partial class FORM_FORCE : Form
    {
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.SOURC_CLS SOURCE = new BL.SOURC_CLS();
        public FORM_FORCE()
        {
            InitializeComponent();

            DGVFORCE.DataSource = SOURCE.GET_ALL_FORCE();
           // DGVFORCE.Columns[0].Visible = false;
            DGVFORCE.Columns[1].Visible = false;
            DGVFORCE.Columns[2].Visible = false;
            DGVFORCE.Columns[4].Visible = false;

            //    TXTNUM.Text = Program.APP_IDEN + SOURCE.GET_LAST_FORCE_NUM().Rows[0][0].ToString();

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            if (TXTNUM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم القوة \n Numara Hêz Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNUM.Focus();
                return;
            }
            if (TXTNAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم القوة \n Navê Hêz Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNAME.Focus();
                return;
            }
            DataTable DT_ALL_FORCE = SOURCE.GET_ALL_FORCE();
            foreach (DataRow row in DT_ALL_FORCE.Rows)
            {
                if (row.Field<string>(0).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show(" توجد قوة مسبقاً بنفس الرقم \n Ji Heman Numarê Hêzek Din Heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (row.Field<string>(2).TrimEnd(' ').ToLower() == TXTNAME.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show(" توجد قوة مسبقاً بنفس الاسم \n Ji Heman Navî Hêzek Din Heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            try
            {
             SOURCE.ADD_FORCE(TXTNUM.Text, Program.APP_IDEN, TXTNAME.Text.TrimEnd(' '),0);
            }
            catch (Exception)
            {
                MessageBox.Show(" توجد قوة محذوفه بشكل مؤقت بياناتها تتقاطع مع البيانات المدخله \n Hêzeka jêbirî bi awakî demkî mîna agahîyên derbaskirî heye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // throw;
                return;
            }

            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة", "إضافة القوة : " + TXTNAME.Text, DateTime.Now);

            MessageBox.Show("تمت عملية الإضافة بنجاح \n zêdekirin serkeftî derbas bû ", "Zêdekirin-إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DGVFORCE.DataSource = SOURCE.GET_ALL_FORCE();
            TXTNAME.Clear();
            BTNDELETE.Enabled = false;
            BTNEDIT.Enabled = false;
            BTNADD.Enabled = true;
         //   TXTNUM.Text = Program.APP_IDEN + SOURCE.GET_LAST_FORCE_NUM().Rows[0][0].ToString();

        }

        private void DGVFORCE_Click(object sender, EventArgs e)
        {
            //TXTNAME.Text = DGVFORCE.CurrentRow.Cells[2].Value.ToString();
            //TXTNUM.Text = DGVFORCE.CurrentRow.Cells[0].Value.ToString();

            //BTNADD.Enabled = false;
            //BTNEDIT.Enabled = true;
            //BTNDELETE.Enabled = true;
        }

        private void BTNEDIT_Click(object sender, EventArgs e)
        {
            if (TXTNUM.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم القوة \n Numara Hêz Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNUM.Focus();
                return;
            }
            if (TXTNAME.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم القوة \n Navê Hêz Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXTNAME.Focus();
                return;
            }
            DataTable DT_ALL_FORCE_FOR_EDIT = SOURCE.GET_ALL_FORCE_FOR_EDIT(DGVFORCE.CurrentRow.Cells[0].Value.ToString());
            foreach (DataRow row in DT_ALL_FORCE_FOR_EDIT.Rows)
            {
                if (row.Field<string>(0).TrimEnd(' ').ToLower() == TXTNUM.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show(" توجد قوة مسبقاً بنفس الرقم \n Ji Heman Numarê Hêzek Din Heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (row.Field<string>(2).TrimEnd(' ').ToLower() == TXTNAME.Text.TrimEnd(' ').ToLower())
                {
                    MessageBox.Show(" توجد قوة مسبقاً بنفس الاسم \n Ji Heman Navî Hêzek Din Heye", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            try
            {
                SOURCE.EDIT_FORCE(DGVFORCE.CurrentRow.Cells[0].Value.ToString(), TXTNAME.Text.TrimEnd(' '),TXTNUM.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(" توجد قوة محذوفه بشكل مؤقت بياناتها تتقاطع مع البيانات المدخله \n Hêzeka jêbirî bi awakî demkî mîna agahîyên derbaskirî heye  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
               // throw;
            }

            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, " biguhere - تعديل", "تعديل القوة : " + DGVFORCE.CurrentRow.Cells[2].Value.ToString(), DateTime.Now);

            MessageBox.Show("تمت عملية التعديل بنجاح  \n sererastkirin bi awakî serkeftî hate tomarkirin ", " biguhere - تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DGVFORCE.DataSource = SOURCE.GET_ALL_FORCE();
            TXTNAME.Clear();
            TXTNUM.Clear();
            BTNDELETE.Enabled = false;
            BTNEDIT.Enabled = false;
            BTNADD.Enabled = true;
         //  TXTNUM.Text = Program.APP_IDEN + SOURCE.GET_LAST_FORCE_NUM().Rows[0][0].ToString();

        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                SOURCE.DELETE_FORCE(DGVFORCE.CurrentRow.Cells[0].Value.ToString());

                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "Jêbirinê - الحذف", "حذف القوة : " + DGVFORCE.CurrentRow.Cells[2].Value.ToString(), DateTime.Now);
                MessageBox.Show("تمت عملية الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DGVFORCE.DataSource = SOURCE.GET_ALL_FORCE();
                TXTNAME.Clear();
                TXTNUM.Clear();

                BTNDELETE.Enabled = false;
                BTNEDIT.Enabled = false;
                BTNADD.Enabled = true;
            //    TXTNUM.Text = Program.APP_IDEN + SOURCE.GET_LAST_FORCE_NUM().Rows[0][0].ToString();

            }
        }

        private void DGVFORCE_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < DGVFORCE.Rows.Count; i++)
            {
                if (DGVFORCE.Rows[i].Index % 2 == 0)
                {
                    DGVFORCE.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171,125,47);
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
            DGVFORCE.DataSource = SOURCE.GET_ALL_FORCE();
            TXTNAME.Clear();
            TXTNUM.Clear();
            TXTNUM.Focus();
            BTNDELETE.Enabled = false;
            BTNEDIT.Enabled = false;
            BTNADD.Enabled = true;
         //   TXTNUM.Text = Program.APP_IDEN + SOURCE.GET_LAST_FORCE_NUM().Rows[0][0].ToString();
        }

        private void FORM_FORCE_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("القوات", ar);
                label3.Text = "Numara Hêz"; // rm.GetString("القوة", ar);
                label24.Text = "Navê hêza";   // rm.GetString("القوة", ar);
                BTNNEW.Text = rm.GetString("جديد", ar);
                BTNADD.Text = rm.GetString("اضافة", ar);
                BTNEDIT.Text = rm.GetString("تعديل", ar);
                BTNDELETE.Text = rm.GetString("خروج", ar);

            }
        }

        private void DGVFORCE_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

           
            TXTNAME.Text = DGVFORCE.CurrentRow.Cells[2].Value.ToString();
            TXTNUM.Text = DGVFORCE.CurrentRow.Cells[0].Value.ToString();
            BTNADD.Enabled = false;
            BTNEDIT.Enabled = true;
            BTNDELETE.Enabled = true;
            }
            catch (Exception)
            {

               // throw;
            }
        }

        private void DGVFORCE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
