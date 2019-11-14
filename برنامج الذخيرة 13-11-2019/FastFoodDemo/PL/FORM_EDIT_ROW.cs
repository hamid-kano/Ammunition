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
    public partial class FORM_EDIT_ROW : Form
    {
        BL.SILAH_CLS SILAH = new BL.SILAH_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        public FORM_EDIT_ROW()
        {
            InitializeComponent();

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
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
                this.Text = rm.GetString("تعديل الكمية في السطر المحدد", ar);
                label3.Text = rm.GetString("الكمية القديمة", ar);
                label1.Text = rm.GetString("الكمية الجديدة", ar);
                BTN_EDIT.Text = rm.GetString("تعديل", ar);
                BTN_DELETE.Text = rm.GetString("خروج", ar);               
            }

        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            int QTY = 0;
            if (TXT_NEW_QTY.Text.TrimEnd(' ') == string.Empty)
            {
                MessageBox.Show("يجب إدخال الكمية الجديدة \n Miqdarê Nû Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_NEW_QTY.Focus();
                return;
            }
            SILAH.EDIT_QTY_IN_ROW(Program.SILAH_IMP_EXP_ID, TXT_NEW_QTY.Text);

            if ( FORM_IMP_EXP.getMainForm.rbtn_import1.Checked == true)
            {
                QTY = Convert.ToInt32(TXT_NEW_QTY.Text) - Convert.ToInt32(TXT_OLD_QTY.Text);
                SILAH.ADD_TO_QTY(FORM_IMP_EXP.getMainForm.DGV_DETAILS.CurrentRow.Cells[6].Value.ToString(), Convert.ToString(QTY));
                FORM_IMP_EXP.getMainForm.DGV_DETAILS.DataSource = SILAH.GET_IMP_EXP_DETAILS(Convert.ToInt32(FORM_IMP_EXP.getMainForm.DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), "import");

            }
            if (FORM_IMP_EXP.getMainForm.rbtn_mustered.Checked == true)
            {
                QTY = Convert.ToInt32(TXT_NEW_QTY.Text) - Convert.ToInt32(TXT_OLD_QTY.Text);
                SILAH.ADD_TO_QTY(FORM_IMP_EXP.getMainForm.DGV_DETAILS.CurrentRow.Cells[6].Value.ToString(), Convert.ToString(QTY));
                FORM_IMP_EXP.getMainForm.DGV_DETAILS.DataSource = SILAH.GET_IMP_EXP_DETAILS(Convert.ToInt32(FORM_IMP_EXP.getMainForm.DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), "mustered");

            }
            if (FORM_IMP_EXP.getMainForm.rbtn_export1.Checked == true)
            {
                 QTY = Convert.ToInt32(TXT_OLD_QTY.Text) - Convert.ToInt32(TXT_NEW_QTY.Text);
                SILAH.ADD_TO_QTY(FORM_IMP_EXP.getMainForm.DGV_DETAILS.CurrentRow.Cells["SILAH_CODE"].Value.ToString(), Convert.ToString(QTY));
                FORM_IMP_EXP.getMainForm.DGV_DETAILS.DataSource = SILAH.GET_IMP_EXP_DETAILS(Convert.ToInt32(FORM_IMP_EXP.getMainForm.DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), "export");
            }
            if (FORM_IMP_EXP.getMainForm.rbtn_external1.Checked == true)
            {
                QTY = Convert.ToInt32(TXT_NEW_QTY.Text) - Convert.ToInt32(TXT_OLD_QTY.Text);
                SILAH.ADD_TO_QTY(FORM_IMP_EXP.getMainForm.DGV_DETAILS.CurrentRow.Cells["SILAH_CODE"].Value.ToString(), Convert.ToString(QTY));
                FORM_IMP_EXP.getMainForm.DGV_DETAILS.DataSource = SILAH.GET_IMP_EXP_DETAILS(Convert.ToInt32(FORM_IMP_EXP.getMainForm.DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), "external_imp");                
            }
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, " biguhere - تعديل", "تعديل كمية سلاح", DateTime.Now);
            MessageBox.Show(" تم التعديل بنجاح \n tomarkirin serkeftî ye ", "biguhere - التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
          FORM_IMP_EXP.getMainForm.DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
          FORM_IMP_EXP.getMainForm.DGV_SILAH.Columns[0].Visible = false;
          FORM_IMP_EXP.getMainForm.DGV_SILAH.Columns[1].Visible = false;
          FORM_IMP_EXP.getMainForm.DGV_SILAH.Columns[2].Visible = false;
          FORM_IMP_EXP.getMainForm.DGV_SILAH.Columns[9].Visible = false;
            TXT_NEW_QTY.Clear();
        }     
       
        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXTLOCATION_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
