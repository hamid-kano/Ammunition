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
    public partial class FORM_MEM_SILAH_CHANGE : Form
    {
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.SOURC_CLS SOURCE = new BL.SOURC_CLS();
        BL.SILAH_CLS SILAH = new BL.SILAH_CLS();
        BL.MEM_SILAH MEM_SILAH = new BL.MEM_SILAH();
        public FORM_MEM_SILAH_CHANGE()
        {
            InitializeComponent();
            DGV_SILAH.DataSource = SILAH.GET_SILAH_BY_CAT_NAME("Sîlahê Şexsî - سلاح فردي");

            DataGridViewCheckBoxColumn dgvchek1 = new DataGridViewCheckBoxColumn();
            dgvchek1.HeaderText = "اختر";
            dgvchek1.Name = "chk1";
            DGV_SILAH.Columns.Add(dgvchek1);

            DataGridViewTextBoxColumn textboxColumn = new DataGridViewTextBoxColumn();
            textboxColumn.HeaderText = "رقم السلاح";
            textboxColumn.Name = "TEXTBOX1";
            DGV_SILAH.Columns.Add(textboxColumn);

            DGV_SILAH.Columns[0].Visible = false;
            DGV_SILAH.Columns[1].Visible = false;
            DGV_SILAH.Columns[2].Visible = false;
            DGV_SILAH.Columns[6].Visible = false;
            DGV_SILAH.Columns[8].Visible = false;
            DGV_SILAH.Columns[7].Visible = false;
            DGV_SILAH.Columns[9].Visible = false;

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= DGV_SILAH.Rows.Count - 1; i++)
            {
                DataTable DT = MEM_SILAH.GET_MAX_MEM_SILAH_ID();
                DataGridViewRow row = DGV_SILAH.Rows[i];
                if (Convert.ToBoolean(row.Cells["chk1"].Value) == true)
                {
                    MEM_SILAH.ADD_MEM_SILAH_WITHOUT_FILE(DT.Rows[0][0].ToString() + Program.APP_IDEN, Program.APP_IDEN,
                        Program.MEM_IDEN, DGV_SILAH.Rows[i].Cells[4].Value.ToString(),
                        DGV_SILAH.Rows[i].Cells[6].Value.ToString(), DGV_SILAH.Rows[i].Cells[5].Value.ToString(),
                        0, DGV_SILAH.Rows[i].Cells[3].Value.ToString(),
                        DGV_SILAH.Rows[i].Cells["TEXTBOX1"].Value.ToString(), "حالياّ");
                }
            }
            MessageBox.Show("تمت عملية التبديل بنجاح \n Çalakiya Guhertin Bi Serkeftî Bi Dawî Bû", "Bugherîne-تبديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, " biguhere - تعديل", "تبديل سلاح مقاتل " + Program.MEM_CODENAME, DateTime.Now);

        }

        private void DGVDETALIES_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
       
        }

        private void FORM_MEM_SILAH_CHANGE_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("التفاصيل", ar);
                BTNADD.Text = rm.GetString("حفظ التغييرات", ar);
                button1.Text = rm.GetString("خروج", ar);

            }
        }
    }
}
