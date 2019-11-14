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
    public partial class FORM_IMP_EXP : Form
    {
        BL.SOURC_CLS SOURCE = new BL.SOURC_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.HEREM_CLS HER = new BL.HEREM_CLS();
        BL.EYALET_CLS EYALET = new BL.EYALET_CLS();
        BL.TUGAY_CLS TUGAY = new BL.TUGAY_CLS();
        BL.ALAY_CLS ALAY = new BL.ALAY_CLS();
        BL.TABUR_CLS TABUR = new BL.TABUR_CLS();
        BL.SILAH_CLS SILAH = new BL.SILAH_CLS();

        DataTable DT_ADD_SILAH_TO_IMP_EXP = new DataTable();
        void CREATEDGV_imp_exp_SIALH()
        {
            DT_ADD_SILAH_TO_IMP_EXP.Columns.Add("SILAH_CODE");
            DT_ADD_SILAH_TO_IMP_EXP.Columns.Add("النوع");
            DT_ADD_SILAH_TO_IMP_EXP.Columns.Add("السلاح");
            DT_ADD_SILAH_TO_IMP_EXP.Columns.Add("الموديل");
            DT_ADD_SILAH_TO_IMP_EXP.Columns.Add("الواحدة");
            DGV_imp_exp_SILAH.DataSource = DT_ADD_SILAH_TO_IMP_EXP;
        }
        void CREATEDGV_imp_exp_SIALH_DETAILE()
        {
            DT_ADD_SILAH_TO_IMP_EXP.Columns.Add("SILAH_CODE");
            DT_ADD_SILAH_TO_IMP_EXP.Columns.Add("النوع");
            DT_ADD_SILAH_TO_IMP_EXP.Columns.Add("السلاح");
            DT_ADD_SILAH_TO_IMP_EXP.Columns.Add("الموديل");
            DT_ADD_SILAH_TO_IMP_EXP.Columns.Add("الواحدة");
            DGV_DETAILS.DataSource = DT_ADD_SILAH_TO_IMP_EXP;
        }
        private static FORM_IMP_EXP frm;
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FORM_IMP_EXP getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_IMP_EXP();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
        }
        public FORM_IMP_EXP()
        {
            InitializeComponent();
            frm = this;
            CREATEDGV_imp_exp_SIALH();
            DGV_imp_exp_SILAH.Columns[0].Visible = false;

            DataGridViewTextBoxColumn textboxColumn = new DataGridViewTextBoxColumn();
            textboxColumn.HeaderText = "الكمية";
            textboxColumn.Name = "TEXTBOX1";
            DGV_imp_exp_SILAH.Columns.Add(textboxColumn);
            DataTable dt_silah =  SILAH.GET_ALL_SILAH();
            DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
            DGV_SILAH.Columns[0].Visible = false;
            DGV_SILAH.Columns[1].Visible = false;
            DGV_SILAH.Columns[2].Visible = false;
            DGV_SILAH.Columns[9].Visible = false;

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
                this.Text = rm.GetString("الوارد و الصادر من المستودع", ar);
                tabControl1.TabPages[0].Text = rm.GetString("الصادر و الوارد", ar);
                tabControl1.TabPages[1].Text = rm.GetString("ادارة الصادر و الوارد", ar);
                add_silah.Text = rm.GetString("جديد", ar);
                label5.Text = rm.GetString("من", ar);
                label12.Text = rm.GetString("من", ar);
                label6.Text = rm.GetString("الى", ar);
                label11.Text = rm.GetString("الى", ar);
                label3.Text = rm.GetString("الجهة المرسلة", ar);
                label9.Text = rm.GetString("الجهة المرسلة", ar);
                label4.Text = rm.GetString("الجهة المستقبلة", ar);
                label1.Text = rm.GetString("الجهة المستقبلة", ar);
                label7.Text = rm.GetString("التاريخ", ar);
                label10.Text = rm.GetString("التاريخ", ar);
                label8.Text = rm.GetString("ملاحظات", ar);
                label2.Text = rm.GetString("ملاحظات", ar);
                RBTN_EXPORT.Text = rm.GetString("صادر", ar);
                rbtn_export1.Text = rm.GetString("صادر", ar);
                RBTN_IMPORT.Text = rm.GetString("وارد", ar);
                rbtn_import1.Text = rm.GetString("وارد", ar);
                RBTN_EXTERNAL.Text = rm.GetString("وارد من خارج قسد", ar);
                rbtn_external1.Text = rm.GetString("وارد من خارج قسد", ar);
                RBTN_MUSTARED.Text = rm.GetString("مسترد", ar);
                rbtn_mustered.Text = rm.GetString("مسترد", ar);
                groupBox3.Text = rm.GetString("قائمة الاسلحة", ar);
                groupBox4.Text = rm.GetString("قائمة التصدير - التوريد", ar);
                BTNNEW.Text = rm.GetString("جديد", ar);
                BTN_ADD.Text = rm.GetString("اضافة", ar);
                groupBox6.Text = rm.GetString("التفاصيل", ar);
                BTNEDIT.Text = rm.GetString("تعديل", ar);
                BTNDELETE.Text = rm.GetString("حذف", ar);
                BTN_ADD_SILAH.Text = rm.GetString("اضافة", ar);
                btn_edit_row.Text = rm.GetString("تعديل", ar);
                BTN_DELET_ROW.Text = rm.GetString("حذف", ar);
                BTN_ADD_TO_LIST.Text = "<<";
                

            }
        }

        private void DGVIQLIM_Click(object sender, EventArgs e)
        {
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < DGV_SILAH.Rows.Count; i++)
                {
                    Convert.ToInt32(DGV_SILAH.Rows[i].Cells["الكمية"].Value.ToString());
                }
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

            if (RBTN_EXPORT.Checked == false && RBTN_IMPORT.Checked == false && RBTN_EXTERNAL.Checked == false && RBTN_MUSTARED.Checked == false)
            {
                MessageBox.Show("يجب تحديد العملية صادر أم وارد أم مسترد \n Çalakiya Derketin an Hatin an Jê Girtiye Hilbijêre  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (CBOX_FROM.Text == string.Empty && RBTN_EXTERNAL.Checked == false)
            {
                MessageBox.Show("يجب اختيار الجهة \n Cihê Jê Hatiye Hilbijêre  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_FROM.Focus();
                return;
            }
            if (CBOX_TO.Text == string.Empty )
            {
                MessageBox.Show("يجب اختيار الجهة الواردة إليها \n Cihê Jêre Hatiye Hilbijêre ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_TO.Focus();
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
            if (RBTN_EXPORT.Checked == true)
            {
                for (int i = 0; i <= DGV_imp_exp_SILAH.Rows.Count-1; i++)
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
       
            string from_to=" ";
            string from_to_external = " ";
            if ((CBOX_FROM.Text == "إقليم" && CBOX_TO.Text == "إقليم") ||( RBTN_EXTERNAL.Checked==true && CBOX_TO.Text == "إقليم"))
            {
                from_to = "herem";
                from_to_external = "herem";
            }
            if ((CBOX_FROM.Text == "إقليم" && CBOX_TO.Text == "منطقة") || (RBTN_EXTERNAL.Checked == true && CBOX_TO.Text == "منطقة"))
            {
                from_to = "herm_eya";
                from_to_external = "herm_eya";
            }
            if ((CBOX_FROM.Text == "إقليم" && CBOX_TO.Text == "لواء") ||( RBTN_EXTERNAL.Checked == true && CBOX_TO.Text == "لواء"))
            {
                from_to = "herm_tug";
                from_to_external = "herm_tug";
            }
            if ((CBOX_FROM.Text == "إقليم" && CBOX_TO.Text == "فوج") ||( RBTN_EXTERNAL.Checked == true && CBOX_TO.Text == "فوج"))
            {
                from_to = "herm_ala";
                from_to_external = "herm_ala";
            }
            if ((CBOX_FROM.Text == "إقليم" && CBOX_TO.Text == "كتيبة") ||( RBTN_EXTERNAL.Checked == true && CBOX_TO.Text == "كتيبة"))
            {
                from_to = "herm_tabur";
                from_to_external = "herm_tabur";
            }

            if (CBOX_FROM.Text == "منطقة" && CBOX_TO.Text == "منطقة")
            {
                from_to = "EYALET";
              
            }
            if (CBOX_FROM.Text == "منطقة" && CBOX_TO.Text == "كتيبة")
            {
                from_to = "EYA_TABUR";
            }
            if (CBOX_FROM.Text == "منطقة" && CBOX_TO.Text == "فوج")
            {
                from_to = "EYA_ALA";
            }
            if (CBOX_FROM.Text == "منطقة" && CBOX_TO.Text == "لواء")
            {
                from_to = "EYA_TUG";
            }
            if (CBOX_FROM.Text == "لواء" && CBOX_TO.Text == "كتيبة")
            {
                from_to = "TUG_TABUR";
            }
            if (CBOX_FROM.Text == "لواء" && CBOX_TO.Text == "فوج")
            {
                from_to = "TUG_ALA";
            }
            if (CBOX_FROM.Text == "لواء" && CBOX_TO.Text == "لواء")
            {
                from_to = "TUGAY";
            }

            if (CBOX_FROM.Text == "فوج" && CBOX_TO.Text == "فوج")
            {
                from_to = "ALAY";
            }
            if (CBOX_FROM.Text == "فوج" && CBOX_TO.Text == "كتيبة")
            {
                from_to = "ALAY_TABUR";
            }

            if (CBOX_FROM.Text == "كتيبة" && CBOX_TO.Text == "كتيبة")
            {
                from_to = "TABUR";
            }
            if (RBTN_EXPORT.Checked == true)
            {
                SILAH.ADD_IMP_EXP(CBOX_SOURCE.SelectedValue.ToString(), CBOX_RECIEV.SelectedValue.ToString(), from_to, dtp_imp_exp.Value, "export", 0, txt_notes.Text);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة سلاح صادر", "إضافة", DateTime.Now);
            }
            if (RBTN_IMPORT.Checked == true)
            {
                SILAH.ADD_IMP_EXP(CBOX_SOURCE.SelectedValue.ToString(), CBOX_RECIEV.SelectedValue.ToString(), from_to, dtp_imp_exp.Value, "import", 0, txt_notes.Text);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة سلاح وارد", "إضافة", DateTime.Now);
            }
            if (RBTN_MUSTARED.Checked == true)
            {
                SILAH.ADD_IMP_EXP(CBOX_SOURCE.SelectedValue.ToString(), CBOX_RECIEV.SelectedValue.ToString(), from_to, dtp_imp_exp.Value, "mustered", 0, txt_notes.Text);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة سلاح مسترد", "إضافة", DateTime.Now);
            }
            if (RBTN_EXTERNAL.Checked == true)
            {

                SILAH.ADD_IMP_EXP(CBOX_SOURCE.Text, CBOX_RECIEV.SelectedValue.ToString(), from_to_external, dtp_imp_exp.Value, "external_imp", 0, txt_notes.Text);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة سلاح وارد من خارج قسد", "إضافة", DateTime.Now);
            }
            for (int j = 0; j <= DGV_imp_exp_SILAH.Rows.Count - 1; j++)
            {
                DataGridViewRow row = DGV_SILAH.Rows[j];
             
                if (RBTN_EXPORT.Checked == true)
                {
                    SILAH.TAKE_SILAH_FROM_WAREHOUSE(DGV_imp_exp_SILAH.Rows[j].Cells["SILAH_CODE"].Value.ToString(), DGV_imp_exp_SILAH.Rows[j].Cells["TEXTBOX1"].Value.ToString());

                }
                if (RBTN_IMPORT.Checked == true || RBTN_MUSTARED.Checked == true)
                {
                    SILAH.ADD_TO_QTY(DGV_imp_exp_SILAH.Rows[j].Cells["SILAH_CODE"].Value.ToString(), DGV_imp_exp_SILAH.Rows[j].Cells["TEXTBOX1"].Value.ToString());

                }
                if (RBTN_EXTERNAL.Checked == true)
                {
                    SILAH.ADD_TO_QTY(DGV_imp_exp_SILAH.Rows[j].Cells["SILAH_CODE"].Value.ToString(), DGV_imp_exp_SILAH.Rows[j].Cells["TEXTBOX1"].Value.ToString());

                }
                DataTable DT_MAX_IMP_EX_ID = SILAH.GET_MAX_IMP_EXP_ID();
                SILAH.ADD_TO_IMP_EXP_SILAH(DGV_imp_exp_SILAH.Rows[j].Cells["SILAH_CODE"].Value.ToString(), Convert.ToInt32(DT_MAX_IMP_EX_ID.Rows[0][0].ToString()), from_to, DGV_imp_exp_SILAH.Rows[j].Cells["TEXTBOX1"].Value.ToString(), " ",0);
            }

            MessageBox.Show(" تم الاضافة بنجاح \n zêdekirin serkeftî derbas bû  ", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
            BTN_ADD.Enabled = false;           
        }

        private void BTNEDIT_Click(object sender, EventArgs e)
        {
           
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
         
        }

        private void BTNNEW_Click(object sender, EventArgs e)
        {
            try
            {
                txt_recieve_from_external.Clear();
                CBOX_FROM.ResetText();
                CBOX_TO.ResetText();
                CBOX_RECIEV.DataSource = null; 
                CBOX_SOURCE.DataSource = null;
                if (RBTN_EXTERNAL.Checked == true)
                {
                    CBOX_SOURCE.DataSource = SOURCE.GET_ALL_SOURCE();
                    CBOX_SOURCE.DisplayMember = "اسم الجهة";
                    CBOX_SOURCE.ValueMember = "رقم الجهة";
                }
                DT_ADD_SILAH_TO_IMP_EXP.Rows.Clear();
                DT_ADD_SILAH_TO_IMP_EXP.Columns.Clear();
                txt_notes.Clear();
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
                
                BTN_ADD.Enabled = true;
                dtp_imp_exp.ResetText();
                CREATEDGV_imp_exp_SIALH();
                DataGridViewTextBoxColumn textboxColumn = new DataGridViewTextBoxColumn();
                textboxColumn.HeaderText = "الكمية";
                textboxColumn.Name = "TEXTBOX1";
                DGV_imp_exp_SILAH.Columns.Add(textboxColumn);
                DGV_imp_exp_SILAH.Columns[0].Visible = false;
                
            }
            catch { return; }
        }

    

        private void TXT_HEREM_NAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGV_HEREM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CBOX_FROM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBOX_FROM.Text  =="إقليم") 
            {
                CBOX_SOURCE.DataSource = HER.GET_ALL_HEREM();
                CBOX_SOURCE.DisplayMember = "اسم الإقليم";
                CBOX_SOURCE.ValueMember = "رقم الإقليم";
            }
            if (CBOX_FROM.Text == "منطقة")
            {
                CBOX_SOURCE.DataSource = EYALET.GET_ALL_EYALET();
                CBOX_SOURCE.DisplayMember = "المنطقة";
                CBOX_SOURCE.ValueMember = "رقم المنطقة";
            }
            if (CBOX_FROM.Text == "لواء")
            {
                CBOX_SOURCE.DataSource = TUGAY.GET_ALL_TUGAY();
                CBOX_SOURCE.DisplayMember = "اللواء";
                CBOX_SOURCE.ValueMember = "رقم اللواء";
            }
            if (CBOX_FROM.Text == "فوج")
            {
                CBOX_SOURCE.DataSource = ALAY.GET_ALL_ALAY();
                CBOX_SOURCE.DisplayMember = "الفوج";
                CBOX_SOURCE.ValueMember = "رقم الفوج";
            }
            if (CBOX_FROM.Text == "كتيبة")
            {
                CBOX_SOURCE.DataSource = TABUR.GET_ALL_TABUR();
                CBOX_SOURCE.DisplayMember = "كتيبة";
                CBOX_SOURCE.ValueMember = "رقم الكتيبة";
            }
        }

        private void CBOX_TO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBOX_TO.Text == "إقليم")
            {
                CBOX_RECIEV.DataSource = HER.GET_ALL_HEREM();
                CBOX_RECIEV.DisplayMember = "اسم الإقليم";
                CBOX_RECIEV.ValueMember = "رقم الإقليم";
            }
            if (CBOX_TO.Text == "منطقة")
            {
                CBOX_RECIEV.DataSource = EYALET.GET_ALL_EYALET();
                CBOX_RECIEV.DisplayMember = "المنطقة";
                CBOX_RECIEV.ValueMember = "رقم المنطقة";
            }
            if (CBOX_TO.Text == "لواء")
            {
                CBOX_RECIEV.DataSource = TUGAY.GET_ALL_TUGAY();
                CBOX_RECIEV.DisplayMember = "اللواء";
                CBOX_RECIEV.ValueMember = "رقم اللواء";
            }
            if (CBOX_TO.Text == "فوج")
            {
                CBOX_RECIEV.DataSource = ALAY.GET_ALL_ALAY();
                CBOX_RECIEV.DisplayMember = "الفوج";
                CBOX_RECIEV.ValueMember = "رقم الفوج";
            }
            if (CBOX_TO.Text == "كتيبة")
            {
                CBOX_RECIEV.DataSource = TABUR.GET_ALL_TABUR();
                CBOX_RECIEV.DisplayMember = "الكتيبة";
                CBOX_RECIEV.ValueMember = "رقم الكتيبة";
            }
        }

        private void RBTN_IMPORT_CheckedChanged(object sender, EventArgs e)
        {
            CBOX_RECIEV.DataSource = null;
            CBOX_SOURCE.DataSource = null;               
        }

        private void RBTN_EXTERNAL_CheckedChanged(object sender, EventArgs e)
        {
            if (RBTN_EXTERNAL.Checked == true)
            {
                CBOX_FROM.Enabled = false;
               // CBOX_TO.Enabled = false;
                //txt_recieve_from_external.Visible = true;
                CBOX_RECIEV.Visible = true;
                CBOX_SOURCE.DataSource = SOURCE.GET_ALL_SOURCE();
                CBOX_SOURCE.DisplayMember = "اسم الجهة";
                CBOX_SOURCE.ValueMember = "رقم الجهة";
            }
            if (RBTN_EXTERNAL.Checked == false)
            {
                CBOX_FROM.Enabled = true;
                CBOX_TO.Enabled = true;
                txt_recieve_from_external.Visible = false;
                CBOX_RECIEV.Visible = true;
            }
        }

        private void RBTN_EXPORT_CheckedChanged(object sender, EventArgs e)
        {
            CBOX_RECIEV.DataSource = null;
            CBOX_SOURCE.DataSource = null;
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
            DataRow DR_ADD = DT_ADD_SILAH_TO_IMP_EXP.NewRow();
            DR_ADD[0] = DGV_SILAH.CurrentRow.Cells[2].Value.ToString();
            DR_ADD[1] = DGV_SILAH.CurrentRow.Cells[3].Value.ToString();
            DR_ADD[2] = DGV_SILAH.CurrentRow.Cells[4].Value.ToString();
            DR_ADD[3] = DGV_SILAH.CurrentRow.Cells[5].Value.ToString();
            DR_ADD[4] = DGV_SILAH.CurrentRow.Cells[7].Value.ToString();
            DT_ADD_SILAH_TO_IMP_EXP.Rows.Add(DR_ADD);
            DGV_imp_exp_SILAH.DataSource = DT_ADD_SILAH_TO_IMP_EXP;        
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
           if(DGV_imp_exp_SILAH.Rows.Count>0)DGV_imp_exp_SILAH.Rows.RemoveAt(DGV_imp_exp_SILAH.CurrentRow.Index);

        }

        private void DGV_SILAH_Click(object sender, EventArgs e)
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

        private void DGV_imp_exp_SILAH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < DGV_imp_exp_SILAH.Rows.Count; i++)
            {
                if (DGV_imp_exp_SILAH.Rows[i].Index % 2 == 0)
                {
                    DGV_imp_exp_SILAH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171, 125, 47);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DGV_SILAH_IMP_EXP.DataSource = null;
            DGV_SILAH_IMP_EXP.DataSource = SILAH.GET_FROM_IMP_EXP("export");
            DGV_SILAH_IMP_EXP.Columns[0].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[1].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[2].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[3].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[5].Visible = false;
            txt_recieve1.Visible = false;
            cbox_from1.Enabled = true;
            cbox_to1.Enabled = true;
            cbox_source1.DataSource = null; 
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            DGV_SILAH_IMP_EXP.DataSource = null;
            DGV_SILAH_IMP_EXP.DataSource = SILAH.GET_FROM_IMP_EXP("import");
            DGV_SILAH_IMP_EXP.Columns[0].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[1].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[2].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[3].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[5].Visible = false;
            DGV_DETAILS.DataSource = null;
            TXT_NOTE.Clear();
            dtp_imp_exp1.ResetText();
            cbox_from1.Text = null;
            cbox_to1.Text = null;
            cbox_recieve1.DataSource = null;
            cbox_source1.DataSource = null; 
            txt_recieve1.Visible = false;
            cbox_from1.Enabled = true;
            cbox_to1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DGV_SILAH_IMP_EXP.DataSource = null;
            DGV_SILAH_IMP_EXP.DataSource = SILAH.GET_FROM_IMP_EXP("external_imp");
            DGV_SILAH_IMP_EXP.Columns[0].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[1].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[2].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[3].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[5].Visible = false;
            DGV_DETAILS.DataSource = null;
            TXT_NOTE.Clear();
            dtp_imp_exp1.ResetText();
            cbox_from1.Text = null;
            cbox_to1.Text = null;
            cbox_recieve1.DataSource = null;
            cbox_from1.Enabled = false;
            cbox_to1.Enabled = true;
            cbox_source1.DataSource = SOURCE.GET_ALL_SOURCE();
            cbox_source1.DisplayMember = "اسم الجهة";
            cbox_source1.ValueMember = "رقم الجهة"; 
            
        }

        private void BTNEDIT_Click_1(object sender, EventArgs e)
        {
            try
            {
            if (rbtn_export1.Checked == false && rbtn_external1.Checked == false && rbtn_import1.Checked == false)
            {
                MessageBox.Show("يجب تحديد العملية صادر أم وارد أم مسترد \n Çalakiya Derketin an Hatin an Jê Girtiye Hilbijêre  ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
          
            string from_to = " ";
           
            if (cbox_from1.Text == "إقليم" && cbox_to1.Text == "إقليم")
            {
                from_to = "herem";
            }
            if (cbox_from1.Text == "إقليم" && cbox_to1.Text == "منطقة")
            {
                from_to = "herm_eya";
            }
            if (cbox_from1.Text == "إقليم" && cbox_to1.Text == "لواء")
            {
                from_to = "herm_tug";
            }
            if (cbox_from1.Text == "إقليم" && cbox_to1.Text == "فوج")
            {
                from_to = "herm_ala";
            }
            if (cbox_from1.Text == "إقليم" && cbox_to1.Text == "كتيبة")
            {
                from_to = "herm_tabur";
            }
            if (cbox_from1.Text == "منطقة" && cbox_to1.Text == "منطقة")
            {
                from_to = "EYALET";
            }
            if (cbox_from1.Text == "منطقة" && cbox_to1.Text == "كتيبة")
            {
                from_to = "EYA_TABUR";
            }
            if (cbox_from1.Text == "منطقة" && cbox_to1.Text == "فوج")
            {
                from_to = "EYA_ALA";
            }
            if (cbox_from1.Text == "منطقة" && cbox_to1.Text == "لواء")
            {
                from_to = "EYA_TUG";
            }
            if (cbox_from1.Text == "لواء" && cbox_to1.Text == "كتيبة")
            {
                from_to = "TUG_TABUR";
            }
            if (cbox_from1.Text == "لواء" && cbox_to1.Text == "فوج")
            {
                from_to = "TUG_ALA";
            }
            if (cbox_from1.Text == "لواء" && cbox_to1.Text == "لواء")
            {
                from_to = "TUGAY";
            }

            if (cbox_from1.Text == "فوج" && cbox_to1.Text == "فوج")
            {
                from_to = "ALAY";
            }
            if (cbox_from1.Text == "فوج" && cbox_to1.Text == "كتيبة")
            {
                from_to = "ALAY_TABUR";
            }

            if (cbox_from1.Text == "كتيبة" && cbox_to1.Text == "كتيبة")
            {
                from_to = "TABUR";
            }
         
                if (cbox_from1.Text == string.Empty && cbox_to1.Text == string.Empty)
                {
                    from_to = DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString();
                }           
            
            
            if (cbox_from1.Text == string.Empty && cbox_to1.Text != string.Empty)
            {
                MessageBox.Show("يجب إدخال الجهة المرسلة \n Cihê Jê Hatiye Hilbijêre ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbox_from1.Focus();
                return;
            }
            if (cbox_from1.Text != string.Empty && cbox_to1.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال الجهة المستقبلة \n Cihê Jêre Hatiye Hilbijêre ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbox_to1.Focus();
                return;
            }

            if (rbtn_export1.Checked == true)
            {
                SILAH.EDIT_IMP_EXP(cbox_source1.SelectedValue.ToString(), cbox_recieve1.SelectedValue.ToString(), from_to, dtp_imp_exp1.Value, "export", 0, Convert.ToInt32(DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), TXT_NOTE.Text);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تعديل سلاح صادر", " biguhere - تعديل", DateTime.Now);
            }
            if (rbtn_import1.Checked == true)
            {
                SILAH.EDIT_IMP_EXP(cbox_source1.SelectedValue.ToString(), cbox_recieve1.SelectedValue.ToString(), from_to, dtp_imp_exp1.Value, "import", 0, Convert.ToInt32(DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), TXT_NOTE.Text);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تعديل سلاح وارد", " biguhere - تعديل", DateTime.Now);
            }
            if (rbtn_mustered.Checked == true)
            {
                SILAH.EDIT_IMP_EXP(cbox_source1.SelectedValue.ToString(), cbox_recieve1.SelectedValue.ToString(), from_to, dtp_imp_exp1.Value, "mustered", 0, Convert.ToInt32(DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), TXT_NOTE.Text);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تعديل سلاح مسترد", " biguhere - تعديل", DateTime.Now);
            }
            if (rbtn_external1.Checked == true)
            {                
                SILAH.EDIT_IMP_EXP(cbox_source1.Text, cbox_recieve1.SelectedValue.ToString(), from_to, dtp_imp_exp1.Value, "external_imp", 0, Convert.ToInt32(DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), TXT_NOTE.Text);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تعديل سلاح وارد من خارج قسد", " biguhere - تعديل", DateTime.Now);
            }
       
            MessageBox.Show(" تم التعديل بنجاح \n tomarkirin serkeftî ye ", " biguhere - تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);;
            if (rbtn_export1.Checked == true)
            {
                DGV_SILAH_IMP_EXP.DataSource = SILAH.GET_FROM_IMP_EXP("export");
                txt_recieve1.Visible = false;
                cbox_recieve1.Enabled = true;
            }
            if (rbtn_import1.Checked == true)
            {
                DGV_SILAH_IMP_EXP.DataSource = SILAH.GET_FROM_IMP_EXP("import");
                txt_recieve1.Visible = false;
                cbox_recieve1.Enabled = true;
            }
            if (rbtn_mustered.Checked == true)
            {
                DGV_SILAH_IMP_EXP.DataSource = SILAH.GET_FROM_IMP_EXP("mustered");
                txt_recieve1.Visible = false;
                cbox_recieve1.Enabled = true;
            }
            if (rbtn_external1.Checked == true)
            {
                DGV_SILAH_IMP_EXP.DataSource = SILAH.GET_FROM_IMP_EXP("external_imp");
                txt_recieve1.Visible = false;
                cbox_recieve1.Enabled = true;
            }
            DGV_DETAILS.DataSource = null;
            DGV_SILAH_IMP_EXP.Columns[0].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[1].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[2].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[3].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[5].Visible = false;
            txt_recieve1.Clear();
            cbox_from1.Text = null;
            cbox_to1.Text = null;
            cbox_recieve1.DataSource = null;
            TXT_NOTE.Clear();
            dtp_imp_exp1.ResetText();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DGV_SILAH_IMP_EXP.CurrentRow == null)
            {
                MessageBox.Show("يجب اختيار تاريخ العملية \n Divê dîroka çalakîyê bê bijartin", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DGV_SILAH_IMP_EXP.Focus();
                return;
            }
            FORM_IMP_EXP_DETAILS FRM = new FORM_IMP_EXP_DETAILS();
            FRM.ShowDialog();
        }

    

        private void DGV_SILAH_IMP_EXP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_silah_Click(object sender, EventArgs e)
        {
            FORM_SILAH_MNG frm = new FORM_SILAH_MNG();
            frm.ShowDialog();
        }
        private void cbox_from1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_from1.Text == "إقليم")
            {
                cbox_source1.DataSource = HER.GET_ALL_HEREM();
                cbox_source1.DisplayMember = "اسم الإقليم";
                cbox_source1.ValueMember = "رقم الإقليم";
            }
            if (cbox_from1.Text == "منطقة")
            {
                cbox_source1.DataSource = EYALET.GET_ALL_EYALET();
                cbox_source1.DisplayMember = "المنطقة";
                cbox_source1.ValueMember = "رقم المنطقة";
            }
            if (cbox_from1.Text == "لواء")
            {
                cbox_source1.DataSource = TUGAY.GET_ALL_TUGAY();
                cbox_source1.DisplayMember = "اللواء";
                cbox_source1.ValueMember = "رقم اللواء";
            }
            if (cbox_from1.Text == "فوج")
            {
                cbox_source1.DataSource = ALAY.GET_ALL_ALAY();
                cbox_source1.DisplayMember = "الفوج";
                cbox_source1.ValueMember = "رقم الفوج";
            }
            if (cbox_from1.Text == "كتيبة")
            {
                cbox_source1.DataSource = TABUR.GET_ALL_TABUR();
                cbox_source1.DisplayMember = "كتيبة";
                cbox_source1.ValueMember = "رقم الكتيبة";
            }
        }

        private void cbox_to1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_to1.Text == "إقليم")
            {
                cbox_recieve1.DataSource = HER.GET_ALL_HEREM();
                cbox_recieve1.DisplayMember = "اسم الإقليم";
                cbox_recieve1.ValueMember = "رقم الإقليم";
            }
            if (cbox_to1.Text == "منطقة")
            {
                cbox_recieve1.DataSource = EYALET.GET_ALL_EYALET();
                cbox_recieve1.DisplayMember = "المنطقة";
                cbox_recieve1.ValueMember = "رقم المنطقة";
            }
            if (cbox_to1.Text == "لواء")
            {
                cbox_recieve1.DataSource = TUGAY.GET_ALL_TUGAY();
                cbox_recieve1.DisplayMember = "اللواء";
                cbox_recieve1.ValueMember = "رقم اللواء";
            }
            if (cbox_to1.Text == "فوج")
            {
                cbox_recieve1.DataSource = ALAY.GET_ALL_ALAY();
                cbox_recieve1.DisplayMember = "الفوج";
                cbox_recieve1.ValueMember = "رقم الفوج";
            }
            if (cbox_to1.Text == "كتيبة")
            {
                cbox_recieve1.DataSource = TABUR.GET_ALL_TABUR();
                cbox_recieve1.DisplayMember = "الكتيبة";
                cbox_recieve1.ValueMember = "رقم الكتيبة";
            }
        }

        private void BTNDELETE_Click_1(object sender, EventArgs e)
        {
            try
            {

            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SILAH.DELETE_FROM_IMP_EXP(1, Convert.ToInt32(DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()));
                
                MessageBox.Show("تم الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (rbtn_export1.Checked == true)
                {
                    DGV_SILAH_IMP_EXP.DataSource = SILAH.GET_FROM_IMP_EXP("export");
                    MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف  صادر", "Jêbirinê - الحذف", DateTime.Now);
                }
                if (rbtn_import1.Checked == true)
                {
                    DGV_SILAH_IMP_EXP.DataSource = SILAH.GET_FROM_IMP_EXP("import");
                    MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف  وارد  ", "Jêbirinê - الحذف", DateTime.Now);
                }
                if (rbtn_mustered.Checked == true)
                {
                    DGV_SILAH_IMP_EXP.DataSource = SILAH.GET_FROM_IMP_EXP("mustered");
                    MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف مسترد", "Jêbirinê - الحذف", DateTime.Now);
                }
                if (rbtn_external1.Checked == true)
                {
                    DGV_SILAH_IMP_EXP.DataSource = SILAH.GET_FROM_IMP_EXP("external_imp");
                    MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف وارد من خارج قسد  ", "Jêbirinê - الحذف", DateTime.Now);
                }
                DGV_DETAILS.DataSource = null;
            }

            }
            catch (Exception)
            {

              //  throw;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

            int QTY1 = 0;
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SILAH.DELETE_FROM_SILAH_IMP_EXP(Convert.ToInt32(DGV_DETAILS.CurrentRow.Cells[14].Value.ToString()),1);
              
                MessageBox.Show("تم الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (rbtn_import1.Checked == true)
                {
                    cbox_source1.DataSource = null;
                    QTY1 =  (-1) * (Convert.ToInt32(DGV_DETAILS.CurrentRow.Cells[10].Value.ToString()));                   
                    SILAH.ADD_TO_QTY(FORM_IMP_EXP.getMainForm.DGV_DETAILS.CurrentRow.Cells[6].Value.ToString(),Convert.ToString(QTY1));
                    DGV_DETAILS.DataSource = SILAH.GET_IMP_EXP_DETAILS(Convert.ToInt32(DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), "import");
                    Program.type = "import";
                    MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف سلاح وارد من وارد", "Jêbirinê - الحذف", DateTime.Now);
                }
                if (rbtn_mustered.Checked == true)
                {
                    cbox_source1.DataSource = null;
                    QTY1 = (-1) * (Convert.ToInt32(DGV_DETAILS.CurrentRow.Cells[10].Value.ToString()));
                    SILAH.ADD_TO_QTY(FORM_IMP_EXP.getMainForm.DGV_DETAILS.CurrentRow.Cells[6].Value.ToString(), Convert.ToString(QTY1));
                    DGV_DETAILS.DataSource = SILAH.GET_IMP_EXP_DETAILS(Convert.ToInt32(DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), "mustered");
                    Program.type = "mustered";
                    MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف سلاح مسترد من مسترد", "Jêbirinê - الحذف", DateTime.Now);
                }
                if (rbtn_export1.Checked == true)
                {
                    cbox_source1.DataSource = null;
                    SILAH.ADD_TO_QTY(FORM_IMP_EXP.getMainForm.DGV_DETAILS.CurrentRow.Cells[6].Value.ToString(), DGV_DETAILS.CurrentRow.Cells[10].Value.ToString());
                    DGV_DETAILS.DataSource = SILAH.GET_IMP_EXP_DETAILS(Convert.ToInt32(DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), "export");
                    Program.type = "export";
                    MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف سلاح صادر من صادر", "Jêbirinê - الحذف", DateTime.Now);
                }
                if (rbtn_external1.Checked == true)
                {
                    QTY1 = (-1) * (Convert.ToInt32(DGV_DETAILS.CurrentRow.Cells[10].Value.ToString()));
                    SILAH.ADD_TO_QTY(FORM_IMP_EXP.getMainForm.DGV_DETAILS.CurrentRow.Cells[6].Value.ToString(), Convert.ToString(QTY1));
                    DGV_DETAILS.DataSource = SILAH.GET_IMP_EXP_DETAILS(Convert.ToInt32(DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), "external_imp");
                    Program.type = "external_imp";
                    MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف سلاح وارد من خارج قسد من وارد", "Jêbirinê - الحذف", DateTime.Now);
                }
            }
            DGV_SILAH.DataSource = SILAH.GET_ALL_SILAH();
            DGV_SILAH.Columns[0].Visible = false;
            DGV_SILAH.Columns[1].Visible = false;
            DGV_SILAH.Columns[2].Visible = false;
            DGV_SILAH.Columns[9].Visible = false;

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void cbox_source1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbox_recieve1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  TXT_NOTE.Text = cbox_recieve1.SelectedValue.ToString();
        }

        private void btn_edit_row_Click(object sender, EventArgs e)
        {
            try
            {

            FORM_EDIT_ROW FRM = new FORM_EDIT_ROW();
            FRM.TXT_OLD_QTY.Text = DGV_DETAILS.CurrentRow.Cells[10].Value.ToString();
            FRM.ShowDialog();

            }
            catch (Exception)
            {

              //  throw;
            }

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            CBOX_RECIEV.DataSource = null;
            CBOX_SOURCE.DataSource = null;
        }

        private void rbtn_mustered_CheckedChanged(object sender, EventArgs e)
        {
            DGV_SILAH_IMP_EXP.DataSource = null;
            DGV_SILAH_IMP_EXP.DataSource = SILAH.GET_FROM_IMP_EXP("mustered");
            DGV_SILAH_IMP_EXP.Columns[0].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[1].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[2].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[3].Visible = false;
            DGV_SILAH_IMP_EXP.Columns[5].Visible = false;
            DGV_DETAILS.DataSource = null;
            TXT_NOTE.Clear();
            dtp_imp_exp1.ResetText();
            cbox_from1.Text = null;
            cbox_to1.Text = null;
            cbox_recieve1.DataSource = null;
            cbox_source1.DataSource = null;
            txt_recieve1.Visible = false;
            cbox_from1.Enabled = true;
            cbox_to1.Enabled = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void DGV_DETAILS_SelectionChanged(object sender, EventArgs e)
        {
            if (!(DGV_DETAILS.CurrentRow==null))
            {
            BTN_DELET_ROW.Enabled = true;
            btn_edit_row.Enabled = true;
            Program.SILAH_IMP_EXP_ID = Convert.ToInt32(DGV_DETAILS.CurrentRow.Cells[14].Value.ToString());
            }

        }

        private void DGV_SILAH_IMP_EXP_SelectionChanged(object sender, EventArgs e)
        {
            if (!(DGV_SILAH_IMP_EXP.CurrentRow == null))
            {
                cbox_from1.Text = null;
                cbox_to1.Text = null;
                BTN_ADD_SILAH.Enabled = true;
                cbox_recieve1.DataSource = null;
                BTN_ADD_SILAH.Enabled = true;
                BTNDELETE.Enabled = true;
                BTNEDIT.Enabled = true;
                Program.IMP_EXP_ID = DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString();

                if (rbtn_import1.Checked == true)
                {
                    cbox_source1.DataSource = null;
                    DGV_DETAILS.DataSource = SILAH.GET_IMP_EXP_DETAILS(Convert.ToInt32(DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), "import");
                    Program.type = "import";
                }
                if (rbtn_mustered.Checked == true)
                {
                    cbox_source1.DataSource = null;
                    DGV_DETAILS.DataSource = SILAH.GET_IMP_EXP_DETAILS(Convert.ToInt32(DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), "mustered");
                    Program.type = "mustered";
                }
                if (rbtn_export1.Checked == true)
                {
                    cbox_source1.DataSource = null;
                    DGV_DETAILS.DataSource = SILAH.GET_IMP_EXP_DETAILS(Convert.ToInt32(DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), "export");
                    Program.type = "export";
                }
                if (rbtn_external1.Checked == true)
                {

                    DGV_DETAILS.DataSource = SILAH.GET_IMP_EXP_DETAILS(Convert.ToInt32(DGV_SILAH_IMP_EXP.CurrentRow.Cells[0].Value.ToString()), "external_imp");
                    Program.type = "external_imp";
                }
                dtp_imp_exp1.Text = DGV_SILAH_IMP_EXP.CurrentRow.Cells[4].Value.ToString();
                TXT_NOTE.Text = DGV_SILAH_IMP_EXP.CurrentRow.Cells[6].Value.ToString();
                if (rbtn_external1.Checked == true)
                {
                    cbox_source1.Text = DGV_SILAH_IMP_EXP.CurrentRow.Cells[1].Value.ToString();
                }


                if (DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString() == "herem")
                {
                    Program.FROM_TO = "herem";
                    if (rbtn_external1.Checked == false)
                    {
                        DataTable DT = HER.GET_HEREM_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[1].Value.ToString());
                        cbox_source1.DataSource = DT;
                        cbox_source1.DisplayMember = "HEREM_NAME";
                        cbox_source1.ValueMember = "HEREM_CODE";
                    }

                    DataTable DT1 = HER.GET_HEREM_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[2].Value.ToString());
                    cbox_recieve1.DataSource = DT1;
                    cbox_recieve1.DisplayMember = "HEREM_NAME";
                    cbox_recieve1.ValueMember = "HEREM_CODE";

                }

                if (DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString() == "herm_eya")
                {
                    Program.FROM_TO = "herm_eya";

                    DataTable DT = HER.GET_HEREM_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[1].Value.ToString());
                    cbox_source1.DataSource = DT;
                    cbox_source1.DisplayMember = "HEREM_NAME";
                    cbox_source1.ValueMember = "HEREM_CODE";

                    DataTable DT1 = EYALET.GET_EYALET_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[2].Value.ToString());
                    cbox_recieve1.DataSource = DT1;
                    cbox_recieve1.DisplayMember = "EYALET_NAME";
                    cbox_recieve1.ValueMember = "EYALET_CODE";

                }
                if (DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString() == "herm_tug")
                {
                    Program.FROM_TO = "herm_tug";

                    DataTable DT = HER.GET_HEREM_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[1].Value.ToString());
                    cbox_source1.DataSource = DT;
                    cbox_source1.DisplayMember = "HEREM_NAME";
                    cbox_source1.ValueMember = "HEREM_CODE";

                    DataTable DT1 = TUGAY.GET_TUGAY_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[2].Value.ToString());
                    cbox_recieve1.DataSource = DT1;
                    cbox_recieve1.DisplayMember = "TUGAY_NAME";
                    cbox_recieve1.ValueMember = "TUGAY_CODE";

                }

                if (DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString() == "herm_ala")
                {
                    Program.FROM_TO = "herm_ala";


                    DataTable DT = HER.GET_HEREM_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[1].Value.ToString());
                    cbox_source1.DataSource = DT;
                    cbox_source1.DisplayMember = "HEREM_NAME";
                    cbox_source1.ValueMember = "HEREM_CODE";

                    DataTable DT1 = ALAY.GET_AIAY_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[2].Value.ToString());
                    cbox_recieve1.DataSource = DT1;
                    cbox_recieve1.DisplayMember = "ALAY_NAME";
                    cbox_recieve1.ValueMember = "ALAY_CODE";
                }
                if (DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString() == "herm_tabur")
                {
                    Program.FROM_TO = "herm_tabur";


                    DataTable DT = HER.GET_HEREM_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[1].Value.ToString());
                    cbox_source1.DataSource = DT;
                    cbox_source1.DisplayMember = "HEREM_NAME";
                    cbox_source1.ValueMember = "HEREM_CODE";

                    DataTable DT1 = TABUR.GET_TABUR_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[2].Value.ToString());
                    cbox_recieve1.DataSource = DT1;
                    cbox_recieve1.DisplayMember = "TABUR_NAME";
                    cbox_recieve1.ValueMember = "TABUR_CODE";
                }

                if (DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString() == "EYALET")
                {
                    Program.FROM_TO = "EYALET";
                    DataTable DT1 = EYALET.GET_EYALET_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[1].Value.ToString());
                    cbox_source1.DataSource = DT1;
                    cbox_source1.DisplayMember = "EYALET_NAME";
                    cbox_source1.ValueMember = "EYALET_CODE";

                    DataTable DT = EYALET.GET_EYALET_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[2].Value.ToString());
                    cbox_recieve1.DataSource = DT;
                    cbox_recieve1.DisplayMember = "EYALET_NAME";
                    cbox_recieve1.ValueMember = "EYALET_CODE";

                }
                if (DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString() == "EYA_TABUR")
                {
                    Program.FROM_TO = "EYA_TABUR";
                    DataTable DT1 = EYALET.GET_EYALET_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[1].Value.ToString());
                    cbox_source1.DataSource = DT1;
                    cbox_source1.DisplayMember = "EYALET_NAME";
                    cbox_source1.ValueMember = "EYALET_CODE";

                    DataTable DT = TABUR.GET_TABUR_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[2].Value.ToString());
                    cbox_recieve1.DataSource = DT;
                    cbox_recieve1.DisplayMember = "TABUR_NAME";
                    cbox_recieve1.ValueMember = "TABUR_CODE";
                }
                if (DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString() == "EYA_ALA")
                {
                    Program.FROM_TO = "EYA_ALA";
                    DataTable DT1 = EYALET.GET_EYALET_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[1].Value.ToString());
                    cbox_source1.DataSource = DT1;
                    cbox_source1.DisplayMember = "EYALET_NAME";
                    cbox_source1.ValueMember = "EYALET_CODE";
                    DataTable DT = ALAY.GET_AIAY_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[2].Value.ToString());
                    cbox_recieve1.DataSource = DT;
                    cbox_recieve1.DisplayMember = "ALAY_NAME";
                    cbox_recieve1.ValueMember = "ALAY_CODE";

                }
                if (DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString() == "EYA_TUG")
                {
                    Program.FROM_TO = "EYA_TUG";
                    DataTable DT1 = EYALET.GET_EYALET_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[1].Value.ToString());
                    cbox_source1.DataSource = DT1;
                    cbox_source1.DisplayMember = "EYALET_NAME";
                    cbox_source1.ValueMember = "EYALET_CODE";

                    DataTable DT = TUGAY.GET_TUGAY_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[2].Value.ToString());
                    cbox_recieve1.DataSource = DT;
                    cbox_recieve1.DisplayMember = "TUGAY_NAME";
                    cbox_recieve1.ValueMember = "TUGAY_CODE";

                }
                if (DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString() == "TUG_TABUR")
                {
                    Program.FROM_TO = "TUG_TABUR";
                    DataTable DT = TUGAY.GET_TUGAY_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[1].Value.ToString());
                    cbox_source1.DataSource = DT;
                    cbox_source1.DisplayMember = "TUGAY_NAME";
                    cbox_source1.ValueMember = "TUGAY_CODE";

                    DataTable DT1 = TABUR.GET_TABUR_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[2].Value.ToString());
                    cbox_recieve1.DataSource = DT1;
                    cbox_recieve1.DisplayMember = "TABUR_NAME";
                    cbox_recieve1.ValueMember = "TABUR_CODE";
                }
                if (DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString() == "TUG_ALA")
                {
                    Program.FROM_TO = "TUG_ALA";
                    DataTable DT = TUGAY.GET_TUGAY_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[1].Value.ToString());
                    cbox_source1.DataSource = DT;
                    cbox_source1.DisplayMember = "TUGAY_NAME";
                    cbox_source1.ValueMember = "TUGAY_CODE";

                    DataTable DT1 = ALAY.GET_AIAY_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[2].Value.ToString());
                    cbox_recieve1.DataSource = DT1;
                    cbox_recieve1.DisplayMember = "ALAY_NAME";
                    cbox_recieve1.ValueMember = "ALAY_CODE";
                }
                if (DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString() == "TUGAY")
                {
                    Program.FROM_TO = "TUGAY";
                    DataTable DT = TUGAY.GET_TUGAY_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[1].Value.ToString());
                    cbox_source1.DataSource = DT;
                    cbox_source1.DisplayMember = "TUGAY_NAME";
                    cbox_source1.ValueMember = "TUGAY_CODE";

                    DataTable DT1 = TUGAY.GET_TUGAY_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[2].Value.ToString());
                    cbox_recieve1.DataSource = DT1;
                    cbox_recieve1.DisplayMember = "TUGAY_NAME";
                    cbox_recieve1.ValueMember = "TUGAY_CODE";
                }
                if (DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString() == "ALAY")
                {
                    Program.FROM_TO = "ALAY";
                    DataTable DT = ALAY.GET_AIAY_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[1].Value.ToString());
                    cbox_source1.DataSource = DT;
                    cbox_source1.DisplayMember = "ALAY_NAME";
                    cbox_source1.ValueMember = "ALAY_CODE";

                    DataTable DT1 = ALAY.GET_AIAY_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[2].Value.ToString());
                    cbox_recieve1.DataSource = DT1;
                    cbox_recieve1.DisplayMember = "ALAY_NAME";
                    cbox_recieve1.ValueMember = "ALAY_CODE";
                }
                if (DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString() == "ALAY_TABUR")
                {
                    Program.FROM_TO = "ALAY_TABUR";
                    DataTable DT = ALAY.GET_AIAY_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[1].Value.ToString());
                    cbox_source1.DataSource = DT;
                    cbox_source1.DisplayMember = "ALAY_NAME";
                    cbox_source1.ValueMember = "ALAY_CODE";

                    DataTable DT1 = TABUR.GET_TABUR_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[2].Value.ToString());
                    cbox_recieve1.DataSource = DT1;
                    cbox_recieve1.DisplayMember = "TABUR_NAME";
                    cbox_recieve1.ValueMember = "TABUR_CODE";
                }

                if (DGV_SILAH_IMP_EXP.CurrentRow.Cells[3].Value.ToString() == "TABUR")
                {
                    Program.FROM_TO = "TABUR";
                    DataTable DT = TABUR.GET_TABUR_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[1].Value.ToString());
                    cbox_source1.DataSource = DT;
                    cbox_source1.DisplayMember = "TABUR_NAME";
                    cbox_source1.ValueMember = "TABUR_CODE";

                    DataTable DT1 = TABUR.GET_TABUR_BY_CODE(DGV_SILAH_IMP_EXP.CurrentRow.Cells[2].Value.ToString());
                    cbox_recieve1.DataSource = DT1;
                    cbox_recieve1.DisplayMember = "TABUR_NAME";
                    cbox_recieve1.ValueMember = "TABUR_CODE";

                }

                DGV_DETAILS.Columns[0].Visible = false;
                DGV_DETAILS.Columns[1].Visible = false;
                DGV_DETAILS.Columns[2].Visible = false;
                DGV_DETAILS.Columns[3].Visible = false;
                DGV_DETAILS.Columns[4].Visible = false;
                DGV_DETAILS.Columns[5].Visible = false;
                DGV_DETAILS.Columns[6].Visible = false;
                DGV_DETAILS.Columns[12].Visible = false;
                DGV_DETAILS.Columns[13].Visible = false;
                DGV_DETAILS.Columns[14].Visible = false;
            }
        }

    }
}
