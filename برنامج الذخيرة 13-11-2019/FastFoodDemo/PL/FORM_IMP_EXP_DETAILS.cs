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
    public partial class FORM_IMP_EXP_DETAILS : Form
    {

        BL.SILAH_CLS SILAH = new BL.SILAH_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        public FORM_IMP_EXP_DETAILS()
        {
            InitializeComponent();
            DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
            DGV_SILAH.Columns[0].Visible = false;
            DGV_SILAH.Columns[1].Visible = false;
            DGV_SILAH.Columns[2].Visible = false;
            DGV_SILAH.Columns[9].Visible = false;
            CREATEDGV_imp_exp_SIALH();
            DataGridViewTextBoxColumn textboxColumn = new DataGridViewTextBoxColumn();
            textboxColumn.HeaderText = "الكمية";
            textboxColumn.Name = "TEXTBOX1";
            DGV_imp_exp_SILAH.Columns.Add(textboxColumn);

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }
        DataTable dt = new DataTable();
        DataTable DT_ADD_SILAH_TO_IMP_EXP = new DataTable();
        void CREATEDGV_imp_exp_SIALH()
        {
            DT_ADD_SILAH_TO_IMP_EXP.Columns.Add("SILAH_CODE");
            DT_ADD_SILAH_TO_IMP_EXP.Columns.Add("النوع");
            DT_ADD_SILAH_TO_IMP_EXP.Columns.Add("السلاح");
            DT_ADD_SILAH_TO_IMP_EXP.Columns.Add("الموديل");
            DT_ADD_SILAH_TO_IMP_EXP.Columns.Add("الواحدة");            
            DGV_imp_exp_SILAH.DataSource = DT_ADD_SILAH_TO_IMP_EXP;
            DGV_imp_exp_SILAH.Columns["SILAH_CODE"].Visible = false;
        }
        private void BTN_ADD_TO_LIST_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DGV_imp_exp_SILAH.Rows.Count; i++)
            {
                if (DGV_SILAH.CurrentRow.Cells["SILAH_CODE"].Value.ToString() == DGV_imp_exp_SILAH.Rows[i].Cells["SILAH_CODE"].Value.ToString())
                {
                    MessageBox.Show("تم اختيار السلاح مسبقا  \n  Berê Ev Sîlah Hatiye Hilbijartinً ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
             // CREATEDGV_imp_exp_SIALH();
            DataRow DR_ADD = DT_ADD_SILAH_TO_IMP_EXP.NewRow();
            DR_ADD[0] = DGV_SILAH.CurrentRow.Cells[2].Value.ToString();
            DR_ADD[1] = DGV_SILAH.CurrentRow.Cells[3].Value.ToString();
            DR_ADD[2] = DGV_SILAH.CurrentRow.Cells[4].Value.ToString();
            DR_ADD[3] = DGV_SILAH.CurrentRow.Cells[5].Value.ToString();
            DR_ADD[4] = DGV_SILAH.CurrentRow.Cells[7].Value.ToString();
            DT_ADD_SILAH_TO_IMP_EXP.Rows.Add(DR_ADD);
            DGV_imp_exp_SILAH.DataSource = DT_ADD_SILAH_TO_IMP_EXP;
            DGV_imp_exp_SILAH.Columns["SILAH_CODE"].Visible = false;

        }

        private void FORM_IMP_EXP_DETAILS_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("ادارة التفاصيل", ar);
                groupBox3.Text = rm.GetString("قائمة الاسلحة", ar);
                groupBox4.Text = rm.GetString("قائمة التصدير - التوريد", ar);
                BTN_ADD.Text = rm.GetString("اضافة", ar);
                BTNNEW.Text = rm.GetString("خروج", ar);
               
            }
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            try
            {
              if(DGV_imp_exp_SILAH.Rows.Count>0) DGV_imp_exp_SILAH.Rows.RemoveAt(DGV_imp_exp_SILAH.CurrentRow.Index);
            }
            catch (Exception)
            {

              //  throw;
            }
        }
        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < DGV_SILAH.Rows.Count; i++)
                {
                    Convert.ToInt32(DGV_SILAH.Rows[i].Cells["الكمية"].Value.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("يجب ان تكون الكمية عدد طبيعي \n Divê tişta heyî di pîvana asayî de be", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // throw;
                return;
            }
            try
            {
                for (int i = 0; i < DGV_imp_exp_SILAH.Rows.Count; i++)
                {
                    Convert.ToInt32(DGV_imp_exp_SILAH.Rows[i].Cells["TEXTBOX1"].Value);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("يجب ان تكون الكمية عدد طبيعي \n Divê tişta heyî di pîvana asayî de be", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // throw;
                return;
            }


            if (DGV_imp_exp_SILAH.RowCount == 0)
            {
                MessageBox.Show("قم باختيار قائمة الأسلحة \n Lîsteya Sîlahan Hilbijêre  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            for (int j = 0; j <= DGV_imp_exp_SILAH.Rows.Count - 1; j++)
            {

                DataGridViewRow row = DGV_imp_exp_SILAH.Rows[j];
                if (Convert.ToString(DGV_imp_exp_SILAH.Rows[j].Cells["TEXTBOX1"].Value) == string.Empty)
                {
                    MessageBox.Show("هناك بعض الأسلحة في القائمة لم تقم بإدخال كمياتها \n Hin Sîlah Di Lîsteyê De Hene Miqdarê Wê Nehatiye Nivîsandin! ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            if (FORM_IMP_EXP.getMainForm.rbtn_export1.Checked == true)
            {
                for (int i = 0; i <= DGV_imp_exp_SILAH.Rows.Count - 1; i++)
                {
                    for (int j = 0; j <= DGV_SILAH.Rows.Count - 1; j++)
                    {
                        if (DGV_SILAH.Rows[j].Cells["SILAH_CODE"].Value.ToString() == DGV_imp_exp_SILAH.Rows[i].Cells["SILAH_CODE"].Value.ToString())
                        {
                            if (Convert.ToInt32(DGV_imp_exp_SILAH.Rows[i].Cells["TEXTBOX1"].Value) > Convert.ToInt32(DGV_SILAH.Rows[j].Cells["الكمية"].Value.ToString()))
                            {
                                MessageBox.Show("الكمية المدخلة غير متوفرة في المستودع \n Miqdarê hatiye Derbas Kirin Di Depo De nîne ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                i++;
                                return;
                            }

                            if (Convert.ToInt32(DGV_imp_exp_SILAH.Rows[i].Cells["TEXTBOX1"].Value) == Convert.ToInt32(DGV_SILAH.Rows[j].Cells["الكمية"].Value.ToString()))
                            {
                                if (MessageBox.Show("الكمية المدخلة لبعض الأسلحة ستنفذ من المستودع في حال تصديرها هل تريد المتابعة على أية حال؟ \n Miqdarê Hin Sîlahên Hatine Nivîsandin Ger Bên Derxistin Wê Di Depoyê De Xilas Bibe! Tu Dixwaze Berdewam Bike?", "التصدير", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
            }

            if (FORM_IMP_EXP.getMainForm.rbtn_export1.Checked == true)
            {
                SILAH.ADD_IMP_EXP(FORM_IMP_EXP.getMainForm.DGV_SILAH_IMP_EXP.CurrentRow.Cells[1].Value.ToString(), FORM_IMP_EXP.getMainForm.DGV_SILAH_IMP_EXP.CurrentRow.Cells[2].Value.ToString(), FORM_IMP_EXP.getMainForm.DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString(),Convert.ToDateTime(FORM_IMP_EXP.getMainForm.DGV_SILAH_IMP_EXP.CurrentRow.Cells[4].Value.ToString()), "export", 0,FORM_IMP_EXP.getMainForm.TXT_NOTE.Text);

            }
        
            for (int j = 0; j <= DGV_imp_exp_SILAH.Rows.Count - 1; j++)
            {
                DataGridViewRow row = DGV_SILAH.Rows[j];

                if (FORM_IMP_EXP.getMainForm.rbtn_export1.Checked == true)
                {
                    SILAH.TAKE_SILAH_FROM_WAREHOUSE(DGV_imp_exp_SILAH.Rows[j].Cells["SILAH_CODE"].Value.ToString(), DGV_imp_exp_SILAH.Rows[j].Cells["TEXTBOX1"].Value.ToString());

                }
                if (FORM_IMP_EXP.getMainForm.rbtn_import1.Checked == true)
                {
                    SILAH.ADD_TO_QTY(DGV_imp_exp_SILAH.Rows[j].Cells["SILAH_CODE"].Value.ToString(), DGV_imp_exp_SILAH.Rows[j].Cells["TEXTBOX1"].Value.ToString());

                }
                if (FORM_IMP_EXP.getMainForm.rbtn_mustered.Checked == true)
                {
                    SILAH.ADD_TO_QTY(DGV_imp_exp_SILAH.Rows[j].Cells["SILAH_CODE"].Value.ToString(), DGV_imp_exp_SILAH.Rows[j].Cells["TEXTBOX1"].Value.ToString());

                }
                if (FORM_IMP_EXP.getMainForm.rbtn_external1.Checked == true)
                {
                    SILAH.ADD_TO_QTY(DGV_imp_exp_SILAH.Rows[j].Cells["SILAH_CODE"].Value.ToString(), DGV_imp_exp_SILAH.Rows[j].Cells["TEXTBOX1"].Value.ToString());

                }
                SILAH.ADD_TO_IMP_EXP_SILAH(DGV_imp_exp_SILAH.Rows[j].Cells["SILAH_CODE"].Value.ToString(), Convert.ToInt32(FORM_IMP_EXP.getMainForm.DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), FORM_IMP_EXP.getMainForm.DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString(), DGV_imp_exp_SILAH.Rows[j].Cells["TEXTBOX1"].Value.ToString(), " ", 0);
            }
            MessageBox.Show(" تم الاضافة بنجاح \n zêdekirin serkeftî derbas bû  ", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
            FORM_IMP_EXP.getMainForm.DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
            if (FORM_IMP_EXP.getMainForm.rbtn_import1.Checked == true)
            {
                FORM_IMP_EXP.getMainForm.DGV_DETAILS.DataSource = SILAH.GET_IMP_EXP_DETAILS(Convert.ToInt32(FORM_IMP_EXP.getMainForm.DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), "import");
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة سلاح وارد  ", "الإضافة", DateTime.Now);
            }
            if (FORM_IMP_EXP.getMainForm.rbtn_import1.Checked == true)
            {
                FORM_IMP_EXP.getMainForm.DGV_DETAILS.DataSource = SILAH.GET_IMP_EXP_DETAILS(Convert.ToInt32(FORM_IMP_EXP.getMainForm.DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), "mustered");
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة سلاح مسترد  ", "الإضافة", DateTime.Now);
            }
            if (FORM_IMP_EXP.getMainForm.rbtn_export1.Checked == true)
            {
                FORM_IMP_EXP.getMainForm.DGV_DETAILS.DataSource = SILAH.GET_IMP_EXP_DETAILS(Convert.ToInt32(FORM_IMP_EXP.getMainForm.DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), "export");
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة سلاح صادر  ", "الإضافة", DateTime.Now);
            }
            if (FORM_IMP_EXP.getMainForm.rbtn_external1.Checked == true)
            {
                FORM_IMP_EXP.getMainForm.DGV_DETAILS.DataSource = SILAH.GET_IMP_EXP_DETAILS(Convert.ToInt32(FORM_IMP_EXP.getMainForm.DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), "external_imp");
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة سلاح وارد من خارج قسد  ", "الإضافة", DateTime.Now);
            }

            BTN_ADD.Enabled = false; 
            DGV_imp_exp_SILAH.DataSource = null;
            for (int i = 0; i <= DGV_imp_exp_SILAH.Rows.Count - 1; i++)
            {
                DGV_imp_exp_SILAH.Rows.RemoveAt(i);
            }
            for (int j = 0; j <= DGV_imp_exp_SILAH.Columns.Count - 1; j++)
            {
                DGV_imp_exp_SILAH.Columns.RemoveAt(j);
            }
            for (int i = 0; i <= DGV_imp_exp_SILAH.Rows.Count - 1; i++)
            {
                DGV_imp_exp_SILAH.Rows.RemoveAt(i);
            }
            for (int j = 0; j <= DGV_imp_exp_SILAH.Columns.Count - 1; j++)
            {
                DGV_imp_exp_SILAH.Columns.RemoveAt(j);
            }
         
            }

        private void BTNNEW_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }

       
    }

