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
    public partial class FORM_MEM_DELETED : Form
    {
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.DELETED_CLS DEL = new BL.DELETED_CLS();
        public FORM_MEM_DELETED()
        {
            InitializeComponent();
            DGVMEM.DataSource = DEL.GET_ALL_MEMBER_DELETED();
            DGVMEM.Columns[1].Visible = false;
            DGVMEM.Columns[13].Visible = false;
            DGVMEM.Columns[14].Visible = false;
            DGVMEM.Columns[15].Visible = false;

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }

        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عملية الاستعادة \n Çalakiya Vegerînê Tu Dixwaze Pêkbîne?؟؟", "hişyarî - تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DEL.RETRIVE_MEM(DGVMEM.CurrentRow.Cells[0].Value.ToString());
                DEL.RETRIVE_MEM_FOLDER_BY_MEM_IDEN(DGVMEM.CurrentRow.Cells[0].Value.ToString());
                DEL.RETRIVE_MEM_GATH_BY_MEM_IDEN(DGVMEM.CurrentRow.Cells[0].Value.ToString());

                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, " biguhere - تعديل", "استعادة مقاتل محذوف : " + DGVMEM.CurrentRow.Cells[3].Value.ToString(), DateTime.Now);

                MessageBox.Show("تمت عملية الاستعادة بنجاح \n Çalakiya Vegerandin Bi Serkeftî Bi Dawî Bû", " biguhere - تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVMEM.DataSource = DEL.GET_ALL_MEMBER_DELETED();
                BTNRETRIVE.Enabled = false;
                BTNDELETEMEM.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DEL.DELETE_MEM_DELETED(DGVMEM.CurrentRow.Cells[0].Value.ToString());
                DEL.DELETE_FOLDER_DELETED(DGVMEM.CurrentRow.Cells[0].Value.ToString());
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "Jêbirinê - الحذف", "حذف بشكل نهائي : " + DGVMEM.CurrentRow.Cells[3].Value.ToString(), DateTime.Now);

                MessageBox.Show("تمت عملية الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVMEM.DataSource = DEL.GET_ALL_MEMBER_DELETED();
                BTNRETRIVE.Enabled = false;
                BTNDELETEMEM.Enabled = false;
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
                for (int i = 0; i < DGVMEM.Rows.Count; i++)
                {
                    DEL.DELETE_MEM_DELETED(DGVMEM.Rows[i].Cells[0].Value.ToString());
                    DEL.DELETE_FOLDER_DELETED(DGVMEM.Rows[i].Cells[0].Value.ToString());

                   MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "Jêbirinê - الحذف", "حذف بشكل نهائي : " + DGVMEM.Rows[i].Cells[3].Value.ToString(), DateTime.Now);
                }

                MessageBox.Show("تمت عملية الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVMEM.DataSource = DEL.GET_ALL_MEMBER_DELETED();
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
                    DGVMEM.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171,125,47);
                }
            }
        }

        private void FORM_MEM_DELETED_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("العناصر المحذوفة", ar);
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

                //throw;
            }
        }
    }
}
