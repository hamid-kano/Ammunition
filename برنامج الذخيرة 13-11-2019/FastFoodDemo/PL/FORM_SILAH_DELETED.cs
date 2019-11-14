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
    public partial class FORM_SILAH_DELETED : Form
    {
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.DELETED_CLS DEL = new BL.DELETED_CLS();
        public FORM_SILAH_DELETED()
        {
            InitializeComponent();

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            if (DGVSILAH.CurrentRow == null)
                MessageBox.Show(" يرجى اختيار العنصر المحذوف لاستعادته \n Çalakiya Vegerînê Tu Dixwaze Pêkbîne?", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (MessageBox.Show("هل تريد تأكيد عملية الاستعادة \n Çalakiya Vegerînê Tu Dixwaze Pêkbîne?؟؟", "hişyarî - تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (CBOX_TYPE.Text == "الأقاليم")
                    {
                        DEL.RETRIVE_HEREM(DGVSILAH.CurrentRow.Cells[2].Value.ToString());
                        DGVSILAH.DataSource = DEL.GET_ALL_HEREM_DELETED();
                    }
                    if (CBOX_TYPE.Text == "المناطق")
                    {
                        DEL.RETRIVE_EYALET(DGVSILAH.CurrentRow.Cells[3].Value.ToString());
                        DGVSILAH.DataSource = DEL.GET_ALL_EYALET_DELETED();

                    }
                    if (CBOX_TYPE.Text == "الألوية")
                    {
                        DEL.RETRIVE_TUGAY(DGVSILAH.CurrentRow.Cells[3].Value.ToString());
                        DGVSILAH.DataSource = DEL.GET_ALL_TUGAY_DELETED();

                    }
                    if (CBOX_TYPE.Text == "الأفواج")
                    {
                        DEL.RETRIVE_ALAY(DGVSILAH.CurrentRow.Cells[3].Value.ToString());
                        DGVSILAH.DataSource = DEL.GET_ALL_ALAY_DELETED();
                    }
                    if (CBOX_TYPE.Text == "الكتائب")
                    {
                        DEL.RETRIVE_TABUR(DGVSILAH.CurrentRow.Cells[3].Value.ToString());
                        DGVSILAH.DataSource = DEL.GET_ALL_TABUR_DELETED();
                    }
                    if (CBOX_TYPE.Text == "القوات")
                    {
                        DEL.RETRIVE_FORCE(DGVSILAH.CurrentRow.Cells[0].Value.ToString());
                        DGVSILAH.DataSource = DEL.GET_ALL_FORCE_DELETED();
                    }
                    if (CBOX_TYPE.Text == "المصادرات")
                    {
                        DEL.RETRIVE_CONFSCATION(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[0].Value.ToString()));
                        DGVSILAH.DataSource = DEL.GET_ALL_CONFSCATIONS_DELETED();
                    }
                    if (CBOX_TYPE.Text == "الغنائم")
                    {
                        DEL.RETRIVE_SPOIL(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[0].Value.ToString()));
                        DGVSILAH.DataSource = DEL.GET_ALL_SPOILS_DELETED();
                    }
                    if (CBOX_TYPE.Text == "الطلبات")
                    {
                        DEL.RETRIVE_ORDERS(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[0].Value.ToString()));
                        DGVSILAH.DataSource = DEL.GET_ALL_ORDERS_DELETED();
                    }
                    if (CBOX_TYPE.Text == "المستودع")
                    {
                        DEL.RETIVE_SILAH(DGVSILAH.CurrentRow.Cells[0].Value.ToString());
                        DGVSILAH.DataSource = DEL.GET_ALL_SILAH_DELETED();
                    }
                    if (CBOX_TYPE.Text == "الأسلحة")
                    {
                        DEL.RETRIVE_CAT_SILAH(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[1].Value.ToString()));
                        DGVSILAH.DataSource = DEL.GET_ALL_CAT_SILAH_DELETED();
                    }

                    if (CBOX_TYPE.Text == "الأصناف")
                    {
                        DEL.RETRIVE_CATEGORY(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[0].Value.ToString()));
                        DGVSILAH.DataSource = DEL.GET_ALL_CATEGORY_DELETED();
                    }
                    if (CBOX_TYPE.Text == "الأسلحة الصادرة")
                    {
                        DEL.RETRIVE_IMP_EXP(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[0].Value.ToString()));
                        DGVSILAH.DataSource = DEL.GET_FROM_IMP_EXP_DELETED("export");
                    }

                    if (CBOX_TYPE.Text == "الأسلحةالواردة")
                    {
                        DEL.RETRIVE_IMP_EXP(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[0].Value.ToString()));
                        DGVSILAH.DataSource = DEL.GET_FROM_IMP_EXP_DELETED("import");
                    }
                    if (CBOX_TYPE.Text == "الأسلحة الواردة من خارج قسد")
                    {
                        DEL.RETRIVE_IMP_EXP(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[0].Value.ToString()));
                        DGVSILAH.DataSource = DEL.GET_FROM_IMP_EXP_DELETED("external_imp");
                    }
                    if (CBOX_TYPE.Text == "الأسلحة المستردة")
                    {
                        DEL.RETRIVE_IMP_EXP(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[0].Value.ToString()));
                        DGVSILAH.DataSource = DEL.GET_FROM_IMP_EXP_DELETED("mustered");

                    }
                    MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, " biguhere - تعديل", "استعادة  محذوف  ", DateTime.Now);

                    MessageBox.Show("تمت عملية الاستعادة بنجاح \n Çalakiya Vegerandin Bi Serkeftî Bi Dawî Bû", " biguhere - تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BTNRETRIVE.Enabled = false;
                    BTNDELETEMEM.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (CBOX_TYPE.Text == "الأقاليم")
                {
                    DEL.DELETE_HEREM_PARMENTLY(DGVSILAH.CurrentRow.Cells[2].Value.ToString());
                    DGVSILAH.DataSource = DEL.GET_ALL_HEREM_DELETED();
                }
                if (CBOX_TYPE.Text == "المناطق")
                {
                    DEL.DELETE_EYALET_PARMENTLY(DGVSILAH.CurrentRow.Cells[3].Value.ToString());
                    DGVSILAH.DataSource = DEL.GET_ALL_EYALET_DELETED();

                }
                if (CBOX_TYPE.Text == "الألوية")
                {
                    DEL.DELETE_TUGAY_PARMENTLY(DGVSILAH.CurrentRow.Cells[3].Value.ToString());
                    DGVSILAH.DataSource = DEL.GET_ALL_TUGAY_DELETED();

                }
                if (CBOX_TYPE.Text == "الأفواج")
                {
                    DEL.DELETE_ALAY_PARMENTLY(DGVSILAH.CurrentRow.Cells[3].Value.ToString());
                    DGVSILAH.DataSource = DEL.GET_ALL_ALAY_DELETED();
                }
                if (CBOX_TYPE.Text == "الكتائب")
                {
                    DEL.DELETE_TABUR_PARMANTLY(DGVSILAH.CurrentRow.Cells[3].Value.ToString());
                    DGVSILAH.DataSource = DEL.GET_ALL_TABUR_DELETED();
                }
                if (CBOX_TYPE.Text == "القوات")
                {
                    DEL.DELETE_FORCE_PARMENTLY(DGVSILAH.CurrentRow.Cells[0].Value.ToString());
                    DGVSILAH.DataSource = DEL.GET_ALL_FORCE_DELETED();
                }
                if (CBOX_TYPE.Text == "المصادرات")
                {
                    DEL.DELETE_CONFSCATION_PARMENTLY(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[0].Value.ToString()));
                    DGVSILAH.DataSource = DEL.GET_ALL_CONFSCATIONS_DELETED();
                }
                if (CBOX_TYPE.Text == "الغنائم")
                {
                    DEL.DELETE_SPOILS_PARMENTLY(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[0].Value.ToString()));
                    DGVSILAH.DataSource = DEL.GET_ALL_SPOILS_DELETED();
                }
                if (CBOX_TYPE.Text == "الطلبات")
                {
                    DEL.DELETE_ORDERS_PARMENTLY(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[0].Value.ToString()));
                    DGVSILAH.DataSource = DEL.GET_ALL_ORDERS_DELETED();
                }
                if (CBOX_TYPE.Text == "المستودع")
                {
                    DEL.DELETE_SIALH_PERMANENTLY(DGVSILAH.CurrentRow.Cells[2].Value.ToString());
                    DGVSILAH.DataSource = DEL.GET_ALL_SILAH_DELETED();
                }
                if (CBOX_TYPE.Text == "الأسلحة")
                {
                    DEL.DELETE_CAT_SILAH_PARMENTALY(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[1].Value.ToString()));
                    DGVSILAH.DataSource = DEL.GET_ALL_CAT_SILAH_DELETED();
                }
                if (CBOX_TYPE.Text == "الأصناف")
                {
                    DEL.DELETE_CATRGORY_PARMENTALY(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[0].Value.ToString()));
                    DGVSILAH.DataSource = DEL.GET_ALL_CATEGORY_DELETED();
                }
                if (CBOX_TYPE.Text == "الأسلحة الصادرة")
                {
                    DEL.DELETE_IMP_EXP_PARMENTLY(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[0].Value.ToString()));
                    DGVSILAH.DataSource = DEL.GET_FROM_IMP_EXP_DELETED("export");
                }

                if (CBOX_TYPE.Text == "الأسلحةالواردة")
                {
                    DEL.DELETE_IMP_EXP_PARMENTLY(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[0].Value.ToString()));
                    DGVSILAH.DataSource = DEL.GET_FROM_IMP_EXP_DELETED("import");
                }
                if (CBOX_TYPE.Text == "الأسلحة الواردة من خارج قسد")
                {
                    DEL.DELETE_IMP_EXP_PARMENTLY(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[0].Value.ToString()));
                    DGVSILAH.DataSource = DEL.GET_FROM_IMP_EXP_DELETED("external_imp");
                }
                if (CBOX_TYPE.Text == "الأسلحة المستردة")
                {
                    DEL.DELETE_IMP_EXP_PARMENTLY(Convert.ToInt32(DGVSILAH.CurrentRow.Cells[0].Value.ToString()));
                    DGVSILAH.DataSource = DEL.GET_FROM_IMP_EXP_DELETED("mustered");

                }
              //  DEL.DELETE_FOLDER_DELETED(DGVSILAH.CurrentRow.Cells[0].Value.ToString());
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "Jêbirinê - الحذف", "حذف بشكل نهائي  ", DateTime.Now);

                MessageBox.Show("تمت عملية الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                BTNRETRIVE.Enabled = false;
                BTNDELETEMEM.Enabled = false;
            }

            }
            catch (Exception)
            {

               // throw;
            }
        }

        private void DGVMEM_Click(object sender, EventArgs e)
        {
            //BTNRETRIVE.Enabled = true;
            //BTNDELETEMEM.Enabled = true;
        }

        private void BTNDELETEALL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (CBOX_TYPE.Text == "الأقاليم")
                {
                    for (int i = 0; i < DGVSILAH.Rows.Count; i++)
                    {
                        DEL.DELETE_HEREM_PARMENTLY(DGVSILAH.Rows[i].Cells[2].Value.ToString());
                    }
                    DGVSILAH.DataSource = DEL.GET_ALL_HEREM_DELETED();
                }
                if (CBOX_TYPE.Text == "المناطق")
                {
                    for (int i = 0; i < DGVSILAH.Rows.Count; i++)
                    {
                        DEL.DELETE_EYALET_PARMENTLY(DGVSILAH.Rows[i].Cells[3].Value.ToString());
                    }
                    DGVSILAH.DataSource = DEL.GET_ALL_EYALET_DELETED();
                }
                if (CBOX_TYPE.Text == "الألوية")
                {
                    for (int i = 0; i < DGVSILAH.Rows.Count; i++)
                    {
                        DEL.DELETE_TUGAY_PARMENTLY(DGVSILAH.Rows[i].Cells[3].Value.ToString());
                    }
                    DGVSILAH.DataSource = DEL.GET_ALL_TUGAY_DELETED();

                }
                if (CBOX_TYPE.Text == "الأفواج")
                {
                    for (int i = 0; i < DGVSILAH.Rows.Count; i++)
                    {
                        DEL.DELETE_ALAY_PARMENTLY(DGVSILAH.Rows[i].Cells[3].Value.ToString());
                    }
                    DGVSILAH.DataSource = DEL.GET_ALL_ALAY_DELETED();

                }
                if (CBOX_TYPE.Text == "الكتائب")
                {
                    for (int i = 0; i < DGVSILAH.Rows.Count; i++)
                    {
                        DEL.DELETE_TABUR_PARMANTLY(DGVSILAH.Rows[i].Cells[3].Value.ToString());
                    }
                    DGVSILAH.DataSource = DEL.GET_ALL_TABUR_DELETED();
                }
                if (CBOX_TYPE.Text == "القوات")
                {
                    for (int i = 0; i < DGVSILAH.Rows.Count; i++)
                    {
                        DEL.DELETE_FORCE_PARMENTLY(DGVSILAH.Rows[i].Cells[0].Value.ToString());
                    }
                    DGVSILAH.DataSource = DEL.GET_ALL_FORCE_DELETED();
                }
                if (CBOX_TYPE.Text == "المصادرات")
                {
                    for (int i = 0; i < DGVSILAH.Rows.Count; i++)
                    {
                        DEL.DELETE_CONFSCATION_PARMENTLY(Convert.ToInt32(DGVSILAH.Rows[i].Cells[0].Value.ToString()));
                    }
                    DGVSILAH.DataSource = DEL.GET_ALL_CONFSCATIONS_DELETED();
                }
                if (CBOX_TYPE.Text == "الغنائم")
                {
                    for (int i = 0; i < DGVSILAH.Rows.Count; i++)
                    {
                        DEL.DELETE_SPOILS_PARMENTLY(Convert.ToInt32(DGVSILAH.Rows[i].Cells[0].Value.ToString()));
                    }
                    DGVSILAH.DataSource = DEL.GET_ALL_SPOILS_DELETED();
                }
                if (CBOX_TYPE.Text == "الطلبات")
                {
                    for (int i = 0; i < DGVSILAH.Rows.Count; i++)
                    {
                        DEL.DELETE_ORDERS_PARMENTLY(Convert.ToInt32(DGVSILAH.Rows[i].Cells[0].Value.ToString()));
                    }
                    DGVSILAH.DataSource = DEL.GET_ALL_ORDERS_DELETED();
                }
                if (CBOX_TYPE.Text == "المستودع")
                {
                    for (int i = 0; i < DGVSILAH.Rows.Count; i++)
                    {
                        DEL.DELETE_SIALH_PERMANENTLY(DGVSILAH.Rows[i].Cells[2].Value.ToString());
                    }
                    DGVSILAH.DataSource = DEL.GET_ALL_SILAH_DELETED();
                }
                if (CBOX_TYPE.Text == "الأسلحة")
                {
                    for (int i = 0; i < DGVSILAH.Rows.Count; i++)
                    {
                        DEL.DELETE_CAT_SILAH_PARMENTALY(Convert.ToInt32(DGVSILAH.Rows[i].Cells[1].Value.ToString()));
                    }
                    DGVSILAH.DataSource = DEL.GET_ALL_CAT_SILAH_DELETED();
                }
                if (CBOX_TYPE.Text == "الأصناف")
                {
                    for (int i = 0; i < DGVSILAH.Rows.Count; i++)
                    {
                        DEL.DELETE_CATRGORY_PARMENTALY(Convert.ToInt32(DGVSILAH.Rows[i].Cells[0].Value.ToString()));
                    }
                    DGVSILAH.DataSource = DEL.GET_ALL_CATEGORY_DELETED();
                }
                if (CBOX_TYPE.Text == "الأسلحة الصادرة")
                {
                    for (int i = 0; i < DGVSILAH.Rows.Count; i++)
                    {
                        DEL.DELETE_IMP_EXP_PARMENTLY(Convert.ToInt32(DGVSILAH.Rows[i].Cells[0].Value.ToString()));
                    }
                    DGVSILAH.DataSource = DEL.GET_FROM_IMP_EXP_DELETED("export");
                }

                if (CBOX_TYPE.Text == "الأسلحةالواردة")
                {
                    for (int i = 0; i < DGVSILAH.Rows.Count; i++)
                    {
                        DEL.DELETE_IMP_EXP_PARMENTLY(Convert.ToInt32(DGVSILAH.Rows[i].Cells[0].Value.ToString()));
                    }
                    DGVSILAH.DataSource = DEL.GET_FROM_IMP_EXP_DELETED("import");
                }
                if (CBOX_TYPE.Text == "الأسلحة الواردة من خارج قسد")
                {
                    for (int i = 0; i < DGVSILAH.Rows.Count; i++)
                    {
                        DEL.DELETE_IMP_EXP_PARMENTLY(Convert.ToInt32(DGVSILAH.Rows[i].Cells[0].Value.ToString()));
                    }
                    DGVSILAH.DataSource = DEL.GET_FROM_IMP_EXP_DELETED("external_imp");
                }
                if (CBOX_TYPE.Text == "الأسلحة المستردة")
                {
                    for (int i = 0; i < DGVSILAH.Rows.Count; i++)
                    {
                        DEL.DELETE_IMP_EXP_PARMENTLY(Convert.ToInt32(DGVSILAH.Rows[i].Cells[0].Value.ToString()));
                    }
                    DGVSILAH.DataSource = DEL.GET_FROM_IMP_EXP_DELETED("mustered");

                }
                MessageBox.Show("تمت عملية الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "Jêbirinê - الحذف", "حذف بشكل نهائي : ", DateTime.Now);

                BTNRETRIVE.Enabled = false;
                BTNDELETEMEM.Enabled = false;
              
            }
        }

        private void DGVMEM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < DGVSILAH.Rows.Count; i++)
            {
                if (DGVSILAH.Rows[i].Index % 2 == 0)
                {
                    DGVSILAH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171,125,47);
                }
            }
        }

        private void CBOX_TYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBOX_TYPE.Text == "الأقاليم")
            {
                DGVSILAH.DataSource = DEL.GET_ALL_HEREM_DELETED();
                DGVSILAH.Columns[0].Visible = false;
                DGVSILAH.Columns[1].Visible = false;
            }
            if (CBOX_TYPE.Text == "المناطق")
            {
                DGVSILAH.DataSource = DEL.GET_ALL_EYALET_DELETED();
                DGVSILAH.Columns[0].Visible = false;
                DGVSILAH.Columns[1].Visible = false;
                DGVSILAH.Columns[5].Visible = false;
            }
            if (CBOX_TYPE.Text == "الألوية")
            {
                DGVSILAH.DataSource = DEL.GET_ALL_TUGAY_DELETED();
                DGVSILAH.Columns[0].Visible = false;
                DGVSILAH.Columns[1].Visible = false;
                DGVSILAH.Columns[6].Visible = false;
                DGVSILAH.Columns[7].Visible = false;
            }
            if (CBOX_TYPE.Text == "الأفواج")
            {
                DGVSILAH.DataSource = DEL.GET_ALL_ALAY_DELETED();
                DGVSILAH.Columns[0].Visible = false;
                DGVSILAH.Columns[1].Visible = false;
                DGVSILAH.Columns[5].Visible = false;
                DGVSILAH.Columns[7].Visible = false;
            }
            if (CBOX_TYPE.Text == "الكتائب")
            {
                DGVSILAH.DataSource = DEL.GET_ALL_TABUR_DELETED();
                DGVSILAH.Columns[0].Visible = false;
                DGVSILAH.Columns[1].Visible = false;
                DGVSILAH.Columns[5].Visible = false;
                DGVSILAH.Columns[7].Visible = false;
            }
            if (CBOX_TYPE.Text == "القوات")
            {
                DGVSILAH.DataSource = DEL.GET_ALL_FORCE_DELETED();
                DGVSILAH.Columns[1].Visible = false;
                DGVSILAH.Columns[2].Visible = false;
                DGVSILAH.Columns[4].Visible = false;
            }
            if (CBOX_TYPE.Text == "المصادرات")
            {
                DGVSILAH.DataSource = DEL.GET_ALL_CONFSCATIONS_DELETED();
                DGVSILAH.Columns[0].Visible = false;
                DGVSILAH.Columns[6].Visible = false;
            }
            if (CBOX_TYPE.Text == "الغنائم")
            {
                DGVSILAH.DataSource = DEL.GET_ALL_SPOILS_DELETED();
                DGVSILAH.Columns[0].Visible = false;
                DGVSILAH.Columns[6].Visible = false;
            }
            if (CBOX_TYPE.Text == "الطلبات")
            {
                DGVSILAH.DataSource = DEL.GET_ALL_ORDERS_DELETED();
                DGVSILAH.Columns[0].Visible = false;
                DGVSILAH.Columns[6].Visible = false;
            }
            if (CBOX_TYPE.Text == "المستودع")
            {
                DGVSILAH.DataSource = DEL.GET_ALL_SILAH_DELETED();
                DGVSILAH.Columns[0].Visible = false;
                DGVSILAH.Columns[1].Visible = false;
                DGVSILAH.Columns[2].Visible = false;
                DGVSILAH.Columns[9].Visible = false;
            }
            if (CBOX_TYPE.Text == "الأسلحة")
            {
                DGVSILAH.DataSource = DEL.GET_ALL_CAT_SILAH_DELETED();
                DGVSILAH.Columns[0].Visible = false;
                DGVSILAH.Columns[1].Visible = false;
                DGVSILAH.Columns[5].Visible = false;
            }
            if (CBOX_TYPE.Text == "الأصناف")
            {
                DGVSILAH.DataSource = DEL.GET_ALL_CATEGORY_DELETED();
                DGVSILAH.Columns[0].Visible = false;
                DGVSILAH.Columns[2].Visible = false;
            }
            if (CBOX_TYPE.Text == "الأسلحة الصادرة")
            {
                DGVSILAH.DataSource = DEL.GET_FROM_IMP_EXP_DELETED("export");
                DGVSILAH.Columns[0].Visible = false;
                DGVSILAH.Columns[1].Visible = false;
                DGVSILAH.Columns[2].Visible = false;
                DGVSILAH.Columns[3].Visible = false;
                DGVSILAH.Columns[5].Visible = false;
            }
            if (CBOX_TYPE.Text == "الأسلحةالواردة")
            {
                DGVSILAH.DataSource = DEL.GET_FROM_IMP_EXP_DELETED("import");
                DGVSILAH.Columns[0].Visible = false;
                DGVSILAH.Columns[1].Visible = false;
                DGVSILAH.Columns[2].Visible = false;
                DGVSILAH.Columns[3].Visible = false;
                DGVSILAH.Columns[5].Visible = false;
            }
            if (CBOX_TYPE.Text == "الأسلحة الواردة من خارج قسد")
            {
                DGVSILAH.DataSource = DEL.GET_FROM_IMP_EXP_DELETED("external_imp");
                DGVSILAH.Columns[0].Visible = false;
                DGVSILAH.Columns[1].Visible = false;
                DGVSILAH.Columns[2].Visible = false;
                DGVSILAH.Columns[3].Visible = false;
                DGVSILAH.Columns[5].Visible = false;
            }
            if (CBOX_TYPE.Text == "الأسلحة المستردة")
            {
                DGVSILAH.DataSource = DEL.GET_FROM_IMP_EXP_DELETED("mustered");
                DGVSILAH.Columns[0].Visible = false;
                DGVSILAH.Columns[1].Visible = false;
                DGVSILAH.Columns[2].Visible = false;
                DGVSILAH.Columns[3].Visible = false;
                DGVSILAH.Columns[5].Visible = false;
            }
            if (CBOX_TYPE.Text == "المقاتلين")
            {
                DGVSILAH.DataSource = DEL.GET_ALL_MEMBER_DELETED();
                DGVSILAH.Columns[0].Visible = false;
                DGVSILAH.Columns[1].Visible = false;
                DGVSILAH.Columns[2].Visible = false;
                DGVSILAH.Columns[3].Visible = false;
                DGVSILAH.Columns[5].Visible = false;
            }
            if (DGVSILAH.Rows.Count!=0)
            {
                BTNDELETEALL.Enabled = true;
                BTNRETRIVE.Enabled = true;
                BTNDELETEMEM.Enabled = true;
            }
            else
            {
                BTNDELETEALL.Enabled = false;
                BTNRETRIVE.Enabled = false;
                BTNDELETEMEM.Enabled = false;
            }
            
        }

        private void FORM_SILAH_DELETED_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("المحذوفات", ar);
                BTNRETRIVE.Text = rm.GetString("استعادة العنصر المحدد مع كامل بياناته", ar);
                BTNDELETEALL.Text = rm.GetString("حذف الكل بشكل نهائي", ar);
                BTNDELETEMEM.Text = rm.GetString("حذف العنصر المحدد بشكل نهائي", ar);
                button2.Text = rm.GetString("خروج", ar);
                label23.Text = rm.GetString("المحذوف", ar);


            }
        }

        private void DGVSILAH_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                    BTNRETRIVE.Enabled = true;
                    BTNDELETEMEM.Enabled = true;
                   
            }
            catch (Exception)
            {
              //  throw;
            }
        }
    }
}
