using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using System.Diagnostics;
using System.IO;
using AxZKFPEngXControl;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace FastFoodDemo.PL
{
    public partial class FORM_MEM_MNG : Form
    {
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.TABUR_CLS TABUR = new BL.TABUR_CLS();
       BL.SOURC_CLS SOURCE = new BL.SOURC_CLS();
      ////  private AxZKFPEngX ZkFprint = new AxZKFPEngX();
      //  private bool Check;
      //  bool result;
      //  string PERSON;
      //  BL.EXPORT_CLS EX = new BL.EXPORT_CLS();
       private static FORM_MEM_MNG frm;
       static void frm_formclosed(object sender, FormClosedEventArgs e)
       {
           frm = null;
       }
       public static FORM_MEM_MNG getMainForm
       {
           get
           {
               if (frm == null)
               {
                   frm = new FORM_MEM_MNG();
                   frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
               }
               return frm;
           }
       }

        public FORM_MEM_MNG()
        {
            InitializeComponent();
            frm = this;
            CBOXKATEBA.DataSource = TABUR.GET_ALL_TABUR();
            CBOXKATEBA.DisplayMember = "الكتيبة";
            CBOXKATEBA.ValueMember = "رقم الكتيبة";

            CBOXFORCE.DataSource = SOURCE.GET_ALL_FORCE();
            CBOXFORCE.DisplayMember = "اسم القوة";
            CBOXFORCE.ValueMember = "رقم القوة";


            DGVMEM.DataSource = MEM.GET_ALL_MEMBER();
            // DGVMEM.Columns[0].Visible = false;
            DGVMEM.Columns[1].Visible = false;
            DGVMEM.Columns[13].Visible = false;
            DGVMEM.Columns[14].Visible = false;
            DGVMEM.Columns[15].Visible = false;

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PL.FORM_ADD_NEW_MEMBER FRM = new FORM_ADD_NEW_MEMBER();
            FRM.ShowDialog();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            FORM_EDIT_MEMBERS FRM = new FORM_EDIT_MEMBERS();
            FRM.ShowDialog();
        }

        private void DGVMEM_Click(object sender, EventArgs e)
        {
           //Program.GATH_ID = Convert.ToInt32(DGVMEM.CurrentRow.Cells[14].Value.ToString());
           // Program.MEM_IDEN = DGVMEM.CurrentRow.Cells[0].Value.ToString();
           // Program.MEM_CODENAME = DGVMEM.CurrentRow.Cells[3].Value.ToString();         
           // Program.MEM_NAME = DGVMEM.CurrentRow.Cells[4].Value.ToString();
           // Program.MEM_LNAME = DGVMEM.CurrentRow.Cells[6].Value.ToString();

           // DataTable DT_IMG = MEM.GET_MEM_IMG_FOR_PRINT(DGVMEM.CurrentRow.Cells[0].Value.ToString());
           // if (DT_IMG.Rows.Count > 0)
           // {
           //     string PATH = DT_IMG.Rows[0][0].ToString();
           //     MEM_PIC.Image = Image.FromFile(PATH);
           // }
           // if (DT_IMG.Rows.Count == 0)
           // {
           //     //    MEM_PIC.Image = FastFoodDemo.Properties.Settings.Default.LOGO_OPS;
           // }

           // BTNEDIT.Enabled = true;
           // BTNDELETE.Enabled = true;
           // BTN_DOCs.Enabled = true;
           // BTNDETALIES.Enabled = true;
           //// BTN_MEM_SILAH.Enabled = true;
        }

        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == string.Empty)
            {
                foreach (DataGridViewRow row in DGVMEM.Rows)
                {
                    row.Selected = false;
                    row.Visible = true;
                }
            }
            else
            {
                for (int row = 0; row < DGVMEM.Rows.Count; row++)
                {
                    if (DGVMEM.Rows[row].Cells["رقم المقاتل"].Value.ToString().Contains(txtSEARCH.Text) ||
                        DGVMEM.Rows[row].Cells["رقم البطاقة"].Value.ToString().Contains(txtSEARCH.Text) ||
                        DGVMEM.Rows[row].Cells["اللقب"].Value.ToString().Contains(txtSEARCH.Text) ||
                        DGVMEM.Rows[row].Cells["الاسم"].Value.ToString().Contains(txtSEARCH.Text) ||
                        DGVMEM.Rows[row].Cells["الأب"].Value.ToString().Contains(txtSEARCH.Text) ||
                        DGVMEM.Rows[row].Cells["الكنية"].Value.ToString().Contains(txtSEARCH.Text) ||
                        DGVMEM.Rows[row].Cells["الأم"].Value.ToString().Contains(txtSEARCH.Text)||
                        DGVMEM.Rows[row].Cells["المكان الحالي"].Value.ToString().Contains(txtSEARCH.Text) ||
                        DGVMEM.Rows[row].Cells["محلي/كادر"].Value.ToString().Contains(txtSEARCH.Text)||
                         DGVMEM.Rows[row].Cells["القوة"].Value.ToString().Contains(txtSEARCH.Text) ||
                        DGVMEM.Rows[row].Cells["القومية"].Value.ToString().Contains(txtSEARCH.Text)
                        ||
                        DGVMEM.Rows[row].Cells["الكتيبة"].Value.ToString().Contains(txtSEARCH.Text))
                    {
                        DGVMEM.Rows[row].Selected = true;
                        DGVMEM.Rows[row].Visible = true;
                    }
                    else
                    {
                        DGVMEM.CurrentCell = null;
                        DGVMEM.Rows[row].Visible = false;
                    }
                }

            } 
            //if (txtSEARCH.Text == string.Empty)
            //{
            //    DGVMEM.DataSource = MEM.GET_ALL_MEMBER();
            //}
            //else
            //{
            //    DGVMEM.DataSource = MEM.SEARCH_MEM(txtSEARCH.Text);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DGVMEM.DataSource = MEM.GET_ALL_MEMBER();

            RBALL.Checked = true;
            RBGLOBAL.Checked = false;
            RBKTEBA.Checked = false;
            RBFORCE.Checked = false;
         //   MEM_PIC.Image = FastFoodDemo.Properties.Settings.Default.LOGO_OPS;
        }

        private void RBALL_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            if (RBALL.Checked == true)
            {
                DGVMEM.DataSource = MEM.GET_ALL_MEMBER();
                txtSEARCH.Enabled = false;
                CBOXFORCE.Enabled = false;
                CBOXKATEBA.Enabled = false;

            }
            }
            catch (Exception)
            {

             //   throw;
            }
        }

        private void RBGLOBAL_CheckedChanged(object sender, EventArgs e)
        {
            if (RBGLOBAL.Checked == true)
            {
                DGVMEM.DataSource = MEM.GET_ALL_MEMBER();
                txtSEARCH.Enabled = true;
                CBOXFORCE.Enabled = false;
                CBOXKATEBA.Enabled = false;

            }
        }

        private void RBKTEBA_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

           
            if (RBKTEBA.Checked == true)
            {
                DGVMEM.DataSource = MEM.GET_MEM_BY_KTEBA_IDEN(CBOXKATEBA.SelectedValue.ToString());
                txtSEARCH.Enabled = false;
                CBOXFORCE.Enabled = false;
                CBOXKATEBA.Enabled = true;

            }
            }
            catch (Exception)
            {

               // throw;
            }
        }

        private void RBFORCE_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

            
            if (RBFORCE.Checked == true)
            {
                DGVMEM.DataSource = MEM.GET_MEM_BY_FORCE_IDEN(CBOXFORCE.SelectedValue.ToString());
                txtSEARCH.Enabled = false;
                CBOXFORCE.Enabled = true;
                CBOXKATEBA.Enabled = false;

            }
            }
            catch (Exception)
            {

               // throw;
            }
        }

        private void CBOXFORCE_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGVMEM.DataSource = MEM.GET_MEM_BY_FORCE_IDEN(CBOXFORCE.SelectedValue.ToString());
        }

        private void CBOXKATEBA_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGVMEM.DataSource = MEM.GET_MEM_BY_KTEBA_IDEN(CBOXKATEBA.SelectedValue.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MEM.DELETE_MEM(DGVMEM.CurrentRow.Cells[0].Value.ToString());
                MEM.DELETE_FROM_GATH_BY_MEM_IDEN(DGVMEM.CurrentRow.Cells[0].Value.ToString());
                MEM.DELETE_FROM_FOLDER(DGVMEM.CurrentRow.Cells[0].Value.ToString());
                 MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "Jêbirinê - الحذف", "حذف المقاتل : " + DGVMEM.CurrentRow.Cells[3].Value.ToString(), DateTime.Now);
                MessageBox.Show("تمت عملية الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DGVMEM.DataSource = MEM.GET_ALL_MEMBER();
                txtSEARCH.Enabled = false;
                CBOXFORCE.Enabled = false;
                CBOXKATEBA.Enabled = false;

                BTNEDIT.Enabled = false;
                BTNDETALIES.Enabled = false;
            }

            }
            catch (Exception)
            {

               // throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
      

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
        }

        private void BTNDETALIES_Click(object sender, EventArgs e)
        {
            FORM_MEM_SILAHS FRM = new FORM_MEM_SILAHS();
            FRM.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void FORM_MEM_MNG_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("ادارة بيانات المقاتلين", ar);
                RBALL.Text = rm.GetString("الكل", ar);
                RBGLOBAL.Text = rm.GetString("بحث عام", ar);
                RBKTEBA.Text = rm.GetString("حسب الكتيبة", ar);
                RBFORCE.Text = rm.GetString("حسب القوة", ar);
                BTNREFRESH.Text = rm.GetString("تحديث", ar);
                BTNADD.Text = rm.GetString("اضافة", ar);
                BTNEDIT.Text = rm.GetString("تعديل", ar);
                BTN_DOCs.Text = rm.GetString("وثائق المقاتل", ar);
                BTNDETALIES.Text = rm.GetString("اسلحة المقاتل", ar);
                BTNDELETE.Text = rm.GetString("حذف", ar);
              
            }
        }


        private void RBFINGER_CheckedChanged(object sender, EventArgs e)
        {

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            FORM_ADD_DOCS FRM = new FORM_ADD_DOCS();
            FRM.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
          
        }

        private void DGVMEM_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

            Program.GATH_ID = Convert.ToInt32(DGVMEM.CurrentRow.Cells[14].Value.ToString());
            Program.MEM_IDEN = DGVMEM.CurrentRow.Cells[0].Value.ToString();
            Program.MEM_CODENAME = DGVMEM.CurrentRow.Cells[3].Value.ToString();
            Program.MEM_NAME = DGVMEM.CurrentRow.Cells[4].Value.ToString();
            Program.MEM_LNAME = DGVMEM.CurrentRow.Cells[6].Value.ToString();

            DataTable DT_IMG = MEM.GET_MEM_IMG_FOR_PRINT(DGVMEM.CurrentRow.Cells[0].Value.ToString());
            if (DT_IMG.Rows.Count > 0)
            {
                string PATH = DT_IMG.Rows[0][0].ToString();
                MEM_PIC.Image = Image.FromFile(PATH);
            }
            if (DT_IMG.Rows.Count == 0)
            {
                //    MEM_PIC.Image = FastFoodDemo.Properties.Settings.Default.LOGO_OPS;
            }

            BTNEDIT.Enabled = true;
            BTNDELETE.Enabled = true;
            BTN_DOCs.Enabled = true;
            BTNDETALIES.Enabled = true;
                // BTN_MEM_SILAH.Enabled = true;

            }
            catch (Exception)
            {

            //    throw;
            }
        }
    }
}
