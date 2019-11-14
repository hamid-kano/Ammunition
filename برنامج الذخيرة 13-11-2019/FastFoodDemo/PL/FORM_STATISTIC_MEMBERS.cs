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
    public partial class FORM_STATISTIC_MEMBERS : Form
    {
        BL.SOURC_CLS SOURCE = new BL.SOURC_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.STATISTIC_CLS STA = new BL.STATISTIC_CLS();
        BL.HEREM_CLS HER = new BL.HEREM_CLS();
        BL.EYALET_CLS EYALET = new BL.EYALET_CLS();
        BL.TUGAY_CLS TUGAY = new BL.TUGAY_CLS();
        BL.ALAY_CLS ALAY = new BL.ALAY_CLS();
        BL.TABUR_CLS TABUR = new BL.TABUR_CLS();
        string name = " ";
        public FORM_STATISTIC_MEMBERS()
        {
            InitializeComponent();


            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }

        }

        private void DTP11_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CBOXSTA1_SelectedIndexChanged(object sender, EventArgs e)
        {              
        }

        private void CBOXIQLIM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void BTNCLO_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNIQLIMPRINT_Click(object sender, EventArgs e)
        {
                      
        }

        private void CBOXMQTA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBOXSTA2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTNSHOWMQTA_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNPRINTMNTKA_Click(object sender, EventArgs e)
        {


        }

        private void CBOXOAA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBOXSTA3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
       
          
        }

        private void BTNSHOWLVL1_Click(object sender, EventArgs e)
        {
       
        }

        private void DTP12_ValueChanged(object sender, EventArgs e)
        {
            DGVLIST.DataSource = null;

        }

        private void DTP21_ValueChanged(object sender, EventArgs e)
        {
        }

        private void DTP22_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DTP31_ValueChanged(object sender, EventArgs e)
        {
        }

        private void DTP32_ValueChanged(object sender, EventArgs e)
        {
        }

        private void BTNPRINTLOAA_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CBOXFAOJ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBOXSTA4_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           
        }

        private void DTP41_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DTP42_ValueChanged(object sender, EventArgs e)
        {
        }

        private void BTNSHOW4_Click(object sender, EventArgs e)
        {
            
        }

        private void BTNPRINTFAOJ_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CBOXKTEBA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBOXSTA5_SelectedIndexChanged(object sender, EventArgs e)
        {
         
         
        }

        private void DTP51_ValueChanged(object sender, EventArgs e)
        {
        }

        private void DTP52_ValueChanged(object sender, EventArgs e)
        {
        }

        private void BTNSHOW5_Click(object sender, EventArgs e)
        {
           
        }

        private void BTNPRINTKTEBA_Click(object sender, EventArgs e)
        {
 
        }

        private void CBOXFORCE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBOXSTA6_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void DTP61_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DTP62_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BTNSHOW6_Click(object sender, EventArgs e)
        {
         
       
          
           
           
        }

        private void BTNPRINTFORCE_Click(object sender, EventArgs e)
        {
 
        }

        private void CBOXFORCE_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DGVREWARDS_Click(object sender, EventArgs e)
        {

        }

        private void BTNSHOW7_Click(object sender, EventArgs e)
        {
        }

        private void DTP71_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DTP72_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CBOXSTA7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

  

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DGVIQLIM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void DGVMNTKA_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void DGVLOAA_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void DGVFAOJ_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void DGVKTEBA_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void DGVFORCE_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          
        }

        private void DGV7_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNIQLIMSHOW_Click_1(object sender, EventArgs e)
        {
            try
            {

            BTNPRINT.Enabled = true;
            if (RBTN_HEREM.Checked == true)
            {
                DGVLIST.DataSource = STA.GET_MEMBER_BY_HEREM_CODE(CBOX_HEREM.SelectedValue.ToString());
            }
            if (RBTN_EYALET.Checked == true)
            {
                DGVLIST.DataSource = STA.GET_MEMBER_BY_EYALET_CODE(CBOX_EYALET.SelectedValue.ToString());
            }
            if (RBTN_TUGAY.Checked == true)
            {
                DGVLIST.DataSource = STA.GET_MEMBER_BY_TUGAY_CODE(CBOX_TUGAY.SelectedValue.ToString());
            }
            if (RBTN_ALAY.Checked == true)
            {
                DGVLIST.DataSource = STA.GET_MEMBER_BY_ALAY_CODE(CBOX_ALAY.SelectedValue.ToString());
            }
            if (RBTN_TABUR.Checked == true)
            {
                DGVLIST.DataSource = STA.GET_MEMBER_BY_TABUR_CODE(CBOXKATEBA.SelectedValue.ToString());
            }
            if (RBTN_FORCE.Checked == true)
            {
                DGVLIST.DataSource = STA.GET_MEMBER_BY_FORCE_CODE(CBOX_FORCE.SelectedValue.ToString());
            }
            DGVLIST.Columns[1].Visible = false;
            DGVLIST.Columns[11].Visible = false;
            DGVLIST.Columns[12].Visible = false; 
            DGVLIST.Columns[16].Visible = false;
            DGVLIST.Columns[17].Visible = false;
            DGVLIST.Columns[18].Visible = false;
            DGVLIST.Columns[19].Visible = false;

            }
            catch (Exception)
            {

               // throw;
            }
        }

        private void CBOXIQLIM_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void CBOX_HEREM_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = "إقليم "+CBOX_HEREM.Text;
        }

        private object GET_MEMBER_BY_HEREM_CODE(string p)
        {
            throw new NotImplementedException();
        }

        private void RBTN_HEREM_CheckedChanged(object sender, EventArgs e)
        {
            CBOX_HEREM.DataSource = HER.GET_ALL_HEREM();
            CBOX_HEREM.DisplayMember = "اسم الإقليم";
            CBOX_HEREM.ValueMember = "رقم الإقليم";
            CBOX_EYALET.Enabled = false;
            CBOX_TUGAY.Enabled = false;
            CBOX_ALAY.Enabled = false;
            CBOXKATEBA.Enabled = false;
            CBOX_FORCE.Enabled = false;
        }

        private void RBTN_EYALET_CheckedChanged(object sender, EventArgs e)
        {
            CBOX_EYALET.DataSource = EYALET.GET_ALL_EYALET();
            CBOX_EYALET.DisplayMember = "المنطقة";
            CBOX_EYALET.ValueMember = "رقم المنطقة";
            CBOX_EYALET.Enabled = true;
        }

        private void BTNIQLIMPRINT_Click_1(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            DataTable DT_REPORT = new DataTable();
            DT_REPORT.Columns.Add("رقم المقاتل", typeof(string));
            DT_REPORT.Columns.Add("اللقب", typeof(string));
            DT_REPORT.Columns.Add("الاسم", typeof(string));
            DT_REPORT.Columns.Add("الأب", typeof(string));
            DT_REPORT.Columns.Add("الكنية", typeof(string));
            DT_REPORT.Columns.Add("الأم", typeof(string));
            DT_REPORT.Columns.Add("تاريخ الولادة", typeof(string));
            DT_REPORT.Columns.Add(" مكان الولادة", typeof(string));
            DT_REPORT.Columns.Add("المكان الحالي", typeof(string));
            DT_REPORT.Columns.Add("الكتيبة", typeof(string));
            DT_REPORT.Columns.Add("القوة", typeof(string));
            DT_REPORT.Columns.Add("السلاح", typeof(string));
            DT_REPORT.Columns.Add("الموديل", typeof(string));
            DT_REPORT.Columns.Add("الرقم", typeof(string));
            DT_REPORT.Columns.Add("في", typeof(string));
            foreach (DataGridViewRow dgv in DGVLIST.Rows)
            {
                DT_REPORT.Rows.Add(dgv.Cells[0].Value, dgv.Cells[3].Value, dgv.Cells[4].Value,
                                   dgv.Cells[5].Value, dgv.Cells[6].Value, dgv.Cells[7].Value,
                                   Convert.ToDateTime(dgv.Cells[8].Value).ToShortDateString(),
                                   dgv.Cells[9].Value, dgv.Cells[10].Value,
                                   dgv.Cells[12].Value, dgv.Cells[16].Value,
                                   dgv.Cells[20].Value,
                                   dgv.Cells[21].Value, dgv.Cells[22].Value,name);
            }
            DS.Tables.Add(DT_REPORT);
            DS.WriteXmlSchema("C:\\AraratProgramFiles\\SampleALL_MEM_IN_IQLIM.xml");

            RPT.FRM_RPT frm = new RPT.FRM_RPT();
            RPT.RPT_ALL_MEM_IN_IQLIM report = new RPT.RPT_ALL_MEM_IN_IQLIM();

            report.Refresh();
            report.SetDataSource(DS);

            frm.crystalReportViewer1.ReportSource = report;


            frm.ShowDialog();
        }

        private void BTNCLO_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RBTN_TUGAY_CheckedChanged(object sender, EventArgs e)
        {
            CBOX_TUGAY.Enabled = true;
            CBOX_TUGAY.DataSource =TUGAY.GET_ALL_TUGAY();
            CBOX_TUGAY.DisplayMember = "اللواء";
            CBOX_TUGAY.ValueMember = "رقم اللواء";
        }

        private void RBTN_ALAY_CheckedChanged(object sender, EventArgs e)
        {
            CBOX_ALAY.Enabled = true;
            CBOX_ALAY.DataSource = ALAY.GET_ALL_ALAY();
            CBOX_ALAY.DisplayMember = "الفوج";
            CBOX_ALAY.ValueMember = "رقم الفوج";
        }

        private void RBTN_TABUR_CheckedChanged(object sender, EventArgs e)
        {
            CBOXKATEBA.Enabled = true;
            CBOXKATEBA.DataSource = TABUR.GET_ALL_TABUR();
            CBOXKATEBA.DisplayMember = "الكتيبة";
            CBOXKATEBA.ValueMember = "رقم الكتيبة";
        }

        private void RBTN_FORCE_CheckedChanged(object sender, EventArgs e)
        {
            CBOX_FORCE.Enabled = true;
            CBOX_FORCE.DataSource = SOURCE.GET_ALL_FORCE();
            CBOX_FORCE.DisplayMember = "اسم القوة";
            CBOX_FORCE.ValueMember = "رقم القوة";
        }

        private void CBOX_EYALET_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = "منطقة " + CBOX_EYALET.Text;
        }

        private void CBOX_TUGAY_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = " لواء " + CBOX_TUGAY.Text;
        }

        private void CBOX_ALAY_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = " فوج " + CBOX_ALAY.Text;
        }

        private void CBOXKATEBA_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = " كتيبة  " + CBOXKATEBA.Text;
        }

        private void CBOX_FORCE_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = "قوات  " + CBOX_FORCE.Text;
        }

        private void CBOXSTA1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void FORM_STATISTIC_MEMBERS_Load(object sender, EventArgs e)
        {

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("التقارير", ar);
                RBTN_HEREM.Text = rm.GetString("حسب الاقليم", ar);
                RBTN_EYALET.Text = rm.GetString("حسب المنطقة", ar);
                RBTN_TUGAY.Text = rm.GetString("حسب اللواء", ar);
                RBTN_ALAY.Text = rm.GetString("حسب الفوج", ar);
                RBTN_TABUR.Text = rm.GetString("حسب الكتيبة", ar);
                RBTN_FORCE.Text = rm.GetString("حسب القوة", ar);
                label2.Text = rm.GetString("الاقليم", ar);
                label3.Text = rm.GetString("المنطقة", ar);
                label4.Text = rm.GetString("اللواء", ar);
                label24.Text = rm.GetString("الفوج", ar);
                label41.Text = rm.GetString("الكتيبة", ar);
                label5.Text = rm.GetString("القوة", ar);
                BTNIQLIMSHOW.Text = rm.GetString("معاينة", ar);
                BTNPRINT.Text = rm.GetString("طباعة", ar);
                BTNCLO.Text = rm.GetString("خروج", ar);
            }
        }
    }
}
