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
    public partial class FORM_MEM_DETALIES_DELETED : Form
    {
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.DELETED_CLS DEL = new BL.DELETED_CLS();
        public FORM_MEM_DETALIES_DELETED()
        {
            InitializeComponent();

            DGVMEM.DataSource = DEL.GET_MEMBER_DETALIES_DELETED();
            DGVMEM.Columns[0].Visible = false;
            DGVMEM.Columns[2].Visible = false;
            DGVMEM.Columns[17].Visible = false;
            DGVMEM.Columns[18].Visible = false;

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DGVMEM_Click(object sender, EventArgs e)
        {
            //BTNRETRIVE.Enabled = true;
            //BTNDELETEMEM.Enabled = true;
        }

        private void BTNRETRIVE_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DGVMEM.CurrentRow.Cells[18].Value.ToString()) == 1)
            {
                MessageBox.Show("السطر المحدد عائد لعنصر محذوف..قم باستعادة العنصر من قائمة العناصر وسيتم حينها استعادة كافة تفاصيله \n Xêza bijartî girêdayî hêmaneka jêbirî ye. Hêmanê ji lîsteya hêmanan vegerîne, wî çaxî dê hemû ziravîyên wê vegerin.", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("هل تريد تأكيد عملية الاستعادة \n Çalakiya Vegerînê Tu Dixwaze Pêkbîne?؟؟", "hişyarî - تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DEL.RETRIVE_FROM_GATH_BY_GATH_ID(Convert.ToInt32(DGVMEM.CurrentRow.Cells[0].Value.ToString()));
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, " biguhere - تعديل", "استعادة تفصيل لعنصر محذوف : " + DGVMEM.CurrentRow.Cells[4].Value.ToString(), DateTime.Now);

                MessageBox.Show("تمت عملية الاستعادة بنجاح \n Çalakiya Vegerandin Bi Serkeftî Bi Dawî Bû", " biguhere - تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DGVMEM.DataSource = DEL.GET_MEMBER_DETALIES_DELETED();
                BTNRETRIVE.Enabled = false;
                BTNDELETEMEM.Enabled = false;
            }
        }

        private void BTNDELETEMEM_Click(object sender, EventArgs e)
        {
            if (DGVMEM.CurrentRow.Cells[17].Value.ToString() == "حالياً")
            {
                MessageBox.Show("لا يمكن حذف السطر المحدد..يجب حذف العنصر من قائمة العناصر \n Ev xêza hatiye bijartin nayê jêbirin, divê hêman ji lîsteya hêmanan bê jêbirin ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DEL.DELETE_GATH_DELETED(Convert.ToInt32(DGVMEM.CurrentRow.Cells[0].Value.ToString()));
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "Jêbirinê - الحذف", "حذف تفصيل بشكل نهائي للعنصر : " + DGVMEM.CurrentRow.Cells[4].Value.ToString(), DateTime.Now);

                MessageBox.Show("تمت عملية الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVMEM.DataSource = DEL.GET_MEMBER_DETALIES_DELETED();
                BTNRETRIVE.Enabled = false;
                BTNDELETEMEM.Enabled = false;
            }
        }

        private void BTNDELETEALL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int COUNT = 0;
                for (int i = 0; i < DGVMEM.Rows.Count; i++)
                {
                    if (Convert.ToInt32(DGVMEM.Rows[i].Cells[18].Value.ToString()) != 1)
                    {
                        if (DGVMEM.Rows[i].Cells[17].Value.ToString() != "حالياً")
                        {
                            DEL.DELETE_GATH_DELETED(Convert.ToInt32(DGVMEM.CurrentRow.Cells[0].Value.ToString()));
                            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "Jêbirinê - الحذف", "حذف تفاصيل بشكل نهائي للمقاتل : " + DGVMEM.Rows[i].Cells[4].Value.ToString(), DateTime.Now);

                        }
                    }               
                }
                if (COUNT == 0)
                {
                    MessageBox.Show("لا يمكن حذف كل الأسطر..قم بحذف العناصر من قائمة العناصر وسيتم حذف كل التفاصيل تلقائياً \n Hemû xêz nayên jêbirin. Hin hêmanan ji lîsteya hêmanan jê bibe û paşê dê hemû ziravî bixwe jê herin", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                MessageBox.Show("تمت عملية الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVMEM.DataSource = DEL.GET_MEMBER_DETALIES_DELETED();
                BTNRETRIVE.Enabled = false;
                BTNDELETEMEM.Enabled = false;
            }
        }

        private void DGVMEM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < DGVMEM.Rows.Count; i++)
            {
                if (DGVMEM.Rows[i].Index % 2 == 0)
                {
                    DGVMEM.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171, 125, 47);
                }
            }
        }

        private void FORM_MEM_DETALIES_DELETED_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("التفاصلة", ar);
                BTNRETRIVE.Text = rm.GetString("استعادة العنصر المحدد مع كامل بياناته", ar);
                BTNDELETEALL.Text = rm.GetString("حذف الكل بشكل نهائي", ar);
                BTNDELETEMEM.Text = rm.GetString("حذف العنصر المحدد بشكل نهائي", ar);
                button2.Text = rm.GetString("خروج", ar);


            }
        }

        private void DGVMEM_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

           
            BTNRETRIVE.Enabled = true;
            BTNDELETEMEM.Enabled = true;
            }
            catch (Exception)
            {

             //   throw;
            }
        }
    }
}
