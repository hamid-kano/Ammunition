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
    public partial class FORM_STATISTIC_SILAH : Form
    {
        BL.SOURC_CLS SOURCE = new BL.SOURC_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.STATISTIC_CLS STA = new BL.STATISTIC_CLS();
        BL.HEREM_CLS HER = new BL.HEREM_CLS();
        BL.EYALET_CLS EYALET = new BL.EYALET_CLS();
        BL.TUGAY_CLS TUGAY = new BL.TUGAY_CLS();
        BL.ALAY_CLS ALAY = new BL.ALAY_CLS();
        BL.TABUR_CLS TABUR = new BL.TABUR_CLS();
        BL.SILAH_CLS SILAH = new BL.SILAH_CLS();
        string name = " ";
        public FORM_STATISTIC_SILAH()
        {
            InitializeComponent();
            CBOX_CAT.DataSource = SILAH.GET_ALL_CATEGORY();
            CBOX_CAT.DisplayMember = "الاسم";
            CBOX_CAT.ValueMember = "CAT_ID";

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
            if (RBTN_EXPORT.Checked == true)
            {
                if (CBOXSTA.Text == "الكل")
                {
                    DGVLIST.DataSource = STA.GET_FROM_IMP_EXP_FOR_STATISTICS("export", DTP1.Value, DTP2.Value);
                }
                if (CBOXSTA.Text == "نوع السلاح")
                {
                   DGVLIST.DataSource = STA.GET_FROM_IMP_EXP_BY_CAT_SILAH_FOR_STATISTICS("export", DTP1.Value, DTP2.Value,CBOX_CAT.Text); 
                }
                if (CBOXSTA.Text == "اسم السلاح")
                {
                    DGVLIST.DataSource = STA.GET_FROM_IMP_EXP_BY_SILAH_NAME_FOR_STATISTICS("export", DTP1.Value, DTP2.Value, CBOX_CAT.Text,CBOX_CAT_NAME.Text);                   
                }
                DGVLIST.Columns[3].Visible = false;
                DGVLIST.Columns[4].Visible = false;
                DGVLIST.Columns[5].Visible = false;
                DGVLIST.Columns[14].Visible = false;
                DGVLIST.Columns[13].Visible = false; 
            }
            if (RBTN_IMPORT.Checked == true)
            {
                if (CBOXSTA.Text == "الكل")
                {
                    DGVLIST.DataSource = STA.GET_FROM_IMP_EXP_FOR_STATISTICS("import", DTP1.Value, DTP2.Value);
                }
                if (CBOXSTA.Text == "نوع السلاح")
                {
                    DGVLIST.DataSource = STA.GET_FROM_IMP_EXP_BY_CAT_SILAH_FOR_STATISTICS("import", DTP1.Value, DTP2.Value, CBOX_CAT.Text);
                }
                if (CBOXSTA.Text == "اسم السلاح")
                {
                    DGVLIST.DataSource = STA.GET_FROM_IMP_EXP_BY_SILAH_NAME_FOR_STATISTICS("import", DTP1.Value, DTP2.Value, CBOX_CAT.Text, CBOX_CAT_NAME.Text);                   
                }

                DGVLIST.Columns[3].Visible = false;
                DGVLIST.Columns[4].Visible = false;
                DGVLIST.Columns[5].Visible = false;
                DGVLIST.Columns[14].Visible = false;
                DGVLIST.Columns[13].Visible = false; 
            }
            if (RBTN_MUSTERED.Checked == true)
            {
                if (CBOXSTA.Text == "الكل")
                {
                    DGVLIST.DataSource = STA.GET_FROM_IMP_EXP_FOR_STATISTICS("mustered", DTP1.Value, DTP2.Value);
                }
                if (CBOXSTA.Text == "نوع السلاح")
                {
                    DGVLIST.DataSource = STA.GET_FROM_IMP_EXP_BY_CAT_SILAH_FOR_STATISTICS("mustered", DTP1.Value, DTP2.Value, CBOX_CAT.Text);
                }
                if (CBOXSTA.Text == "اسم السلاح")
                {
                    DGVLIST.DataSource = STA.GET_FROM_IMP_EXP_BY_SILAH_NAME_FOR_STATISTICS("mustered", DTP1.Value, DTP2.Value, CBOX_CAT.Text, CBOX_CAT_NAME.Text);
                }

                DGVLIST.Columns[3].Visible = false;
                DGVLIST.Columns[4].Visible = false;
                DGVLIST.Columns[5].Visible = false;
                DGVLIST.Columns[14].Visible = false;
                DGVLIST.Columns[13].Visible = false;
            }
            if (RBTN_ALL.Checked == true)
            {
                if (CBOXSTA.Text == "الكل")
                {
                    DGVLIST.DataSource = STA.GET_ALL_WAREHOUSE_SILAH_FOR_STATISTICS();
                }
                if (CBOXSTA.Text == "نوع السلاح")
                {
                    DGVLIST.DataSource = STA.GET_ALL_WAREHOUSE_CAT_SILAH_FOR_STATISTICS(CBOX_CAT.Text);
                }
                if (CBOXSTA.Text == "اسم السلاح")
                {
                    DGVLIST.DataSource = STA.GET_ALL_WAREHOUSE_CAT_SILAH_NAME_FOR_STATISTICS(CBOX_CAT.Text, CBOX_CAT_NAME.Text);
                }
                DGVLIST.Columns[9].Visible = false;
                DGVLIST.Columns[10].Visible = false;   
            }

            DGVLIST.Columns[0].Visible = false;
            DGVLIST.Columns[1].Visible = false;
            DGVLIST.Columns[2].Visible = false;

            }
            catch (Exception)
            {

              //  throw;
            }

        }

        private void CBOXIQLIM_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        private object GET_MEMBER_BY_HEREM_CODE(string p)
        {
            throw new NotImplementedException();
        }

        private void RBTN_HEREM_CheckedChanged(object sender, EventArgs e)
        {
            DGVLIST.DataSource = null;
            name = "الأسلحة الواردة";
            CBOX_CAT.Enabled = true;
            CBOX_CAT_NAME.Enabled = true;
            DTP1.Enabled = true;
            DTP2.Enabled = true;
            CBOXSTA.Enabled = true;
        }

        private void RBTN_EYALET_CheckedChanged(object sender, EventArgs e)
        {
            DGVLIST.DataSource = null;
            name = "الأسلحة الموجودة في المستودع";
            CBOX_CAT.Enabled = true;
            CBOX_CAT_NAME.Enabled = true;
            DTP1.Enabled = false;
            DTP2.Enabled = false;
            CBOXSTA.Enabled = true;
        }

        private void BTNIQLIMPRINT_Click_1(object sender, EventArgs e)
        {
            if (RBTN_EXPORT.Checked == true || RBTN_IMPORT.Checked == true)
            {
                if (CBOXSTA.Text == "الكل")
                {
                    DataSet DS = new DataSet();
                    DataTable DT_REPORT = new DataTable();
                    DT_REPORT.Columns.Add("التاريخ", typeof(string));
                    DT_REPORT.Columns.Add("النوع", typeof(string));
                    DT_REPORT.Columns.Add("السلاح", typeof(string));
                    DT_REPORT.Columns.Add("الموديل", typeof(string));
                    DT_REPORT.Columns.Add("الكمية", typeof(string));
                    DT_REPORT.Columns.Add("الواحدة", typeof(string));
                    DT_REPORT.Columns.Add("ملاحظات", typeof(string));
                    DT_REPORT.Columns.Add("1التاريخ", typeof(string));
                    DT_REPORT.Columns.Add("التاريخ2", typeof(string));
                    DT_REPORT.Columns.Add("الصادرة", typeof(string));
                    foreach (DataGridViewRow dgv in DGVLIST.Rows)
                    {
                        DT_REPORT.Rows.Add(Convert.ToDateTime(dgv.Cells[6].Value).ToShortDateString(),
                                           dgv.Cells[7].Value,
                                           dgv.Cells[8].Value,
                                           dgv.Cells[9].Value, dgv.Cells[10].Value, dgv.Cells[11].Value,
                                           dgv.Cells[12].Value,
                                           Convert.ToDateTime(DTP1.Value).ToShortDateString(),
                                           Convert.ToDateTime(DTP2.Value).ToShortDateString(), name);
                    }
                    DS.Tables.Add(DT_REPORT);
                    DS.WriteXmlSchema("C:\\AraratProgramFiles\\Sample_SILAH.xml");

                    RPT.FRM_RPT frm = new RPT.FRM_RPT();
                    RPT.RPT_ALL_SILAH report = new FastFoodDemo.RPT.RPT_ALL_SILAH();
                    report.Refresh();
                    report.SetDataSource(DS);
                    frm.crystalReportViewer1.ReportSource = report;
                    frm.ShowDialog();
                }
                if (CBOXSTA.Text == "نوع السلاح")
                {
                    DataSet DS = new DataSet();
                    DataTable DT_REPORT = new DataTable();
                    DT_REPORT.Columns.Add("التاريخ", typeof(string));
                    DT_REPORT.Columns.Add("النوع", typeof(string));
                    DT_REPORT.Columns.Add("السلاح", typeof(string));
                    DT_REPORT.Columns.Add("الموديل", typeof(string));
                    DT_REPORT.Columns.Add("الكمية", typeof(string));
                    DT_REPORT.Columns.Add("الواحدة", typeof(string));
                    DT_REPORT.Columns.Add("ملاحظات", typeof(string));
                    DT_REPORT.Columns.Add("1التاريخ", typeof(string));
                    DT_REPORT.Columns.Add("التاريخ2", typeof(string));
                    DT_REPORT.Columns.Add("الصادرة", typeof(string));
                    foreach (DataGridViewRow dgv in DGVLIST.Rows)
                    {
                        DT_REPORT.Rows.Add(Convert.ToDateTime(dgv.Cells[6].Value).ToShortDateString(),
                                           dgv.Cells[7].Value,
                                           dgv.Cells[8].Value,
                                           dgv.Cells[9].Value, dgv.Cells[10].Value, dgv.Cells[11].Value,
                                           dgv.Cells[12].Value,
                                           Convert.ToDateTime(DTP1.Value).ToShortDateString(),
                                           Convert.ToDateTime(DTP2.Value).ToShortDateString(), name);
                    }
                    DS.Tables.Add(DT_REPORT);
                    DS.WriteXmlSchema("C:\\AraratProgramFiles\\Sample_CAT_SILAH.xml");

                    RPT.FRM_RPT frm = new RPT.FRM_RPT();
                    RPT.RPT_CAT_SILAH report = new RPT.RPT_CAT_SILAH();

                    report.Refresh();
                    report.SetDataSource(DS);
                    frm.crystalReportViewer1.ReportSource = report;
                    frm.ShowDialog();
                }
                if (CBOXSTA.Text == "اسم السلاح")
                {
                    DataSet DS = new DataSet();
                    DataTable DT_REPORT = new DataTable();
                    DT_REPORT.Columns.Add("التاريخ", typeof(string));
                    DT_REPORT.Columns.Add("النوع", typeof(string));
                    DT_REPORT.Columns.Add("السلاح", typeof(string));
                    DT_REPORT.Columns.Add("الموديل", typeof(string));
                    DT_REPORT.Columns.Add("الكمية", typeof(string));
                    DT_REPORT.Columns.Add("الواحدة", typeof(string));
                    DT_REPORT.Columns.Add("ملاحظات", typeof(string));
                    DT_REPORT.Columns.Add("1التاريخ", typeof(string));
                    DT_REPORT.Columns.Add("التاريخ2", typeof(string));
                    DT_REPORT.Columns.Add("الصادرة", typeof(string));
                    foreach (DataGridViewRow dgv in DGVLIST.Rows)
                    {
                        DT_REPORT.Rows.Add(Convert.ToDateTime(dgv.Cells[6].Value).ToShortDateString(),
                                           dgv.Cells[7].Value,
                                           dgv.Cells[8].Value,
                                           dgv.Cells[9].Value, dgv.Cells[10].Value, dgv.Cells[11].Value,
                                           dgv.Cells[12].Value,
                                           Convert.ToDateTime(DTP1.Value).ToShortDateString(),
                                           Convert.ToDateTime(DTP2.Value).ToShortDateString(), name);
                    }
                    DS.Tables.Add(DT_REPORT);
                    DS.WriteXmlSchema("C:\\AraratProgramFiles\\Sample_CAT_SILAH.xml");

                    RPT.FRM_RPT frm = new RPT.FRM_RPT();
                    RPT.RPT_CAT_SILAH_NAME report = new RPT.RPT_CAT_SILAH_NAME();
                    report.Refresh();
                    report.SetDataSource(DS);
                    frm.crystalReportViewer1.ReportSource = report;
                    frm.ShowDialog();
                }
            }
            if (RBTN_ALL.Checked == true)
            {
                if (CBOXSTA.Text == "الكل")
                {
                    DataSet DS = new DataSet();
                    DataTable DT_REPORT = new DataTable();
                    DT_REPORT.Columns.Add("النوع", typeof(string));
                    DT_REPORT.Columns.Add("السلاح", typeof(string));
                    DT_REPORT.Columns.Add("الموديل", typeof(string));
                    DT_REPORT.Columns.Add("الكمية", typeof(string));
                    DT_REPORT.Columns.Add("الواحدة", typeof(string));
                    DT_REPORT.Columns.Add("ملاحظات", typeof(string));
                    DT_REPORT.Columns.Add("نوع التقرير", typeof(string));
                    foreach (DataGridViewRow dgv in DGVLIST.Rows)
                    {
                        DT_REPORT.Rows.Add(
                                           dgv.Cells[3].Value,
                                           dgv.Cells[4].Value,
                                           dgv.Cells[5].Value, dgv.Cells[6].Value, dgv.Cells[7].Value,
                                           dgv.Cells[8].Value, name);
                    }
                    DS.Tables.Add(DT_REPORT);
                    DS.WriteXmlSchema("C:\\AraratProgramFiles\\Sample_ALL_SILAH.xml");

                    RPT.FRM_RPT frm = new RPT.FRM_RPT();
                    RPT.RPT_EXISTING_SILAH report = new FastFoodDemo.RPT.RPT_EXISTING_SILAH();
                    report.Refresh();
                    report.SetDataSource(DS);
                    frm.crystalReportViewer1.ReportSource = report;
                    frm.ShowDialog();
                }
                if (CBOXSTA.Text == "نوع السلاح")
                {
                    DataSet DS = new DataSet();
                    DataTable DT_REPORT = new DataTable();
                    DT_REPORT.Columns.Add("النوع", typeof(string));
                    DT_REPORT.Columns.Add("السلاح", typeof(string));
                    DT_REPORT.Columns.Add("الموديل", typeof(string));
                    DT_REPORT.Columns.Add("الكمية", typeof(string));
                    DT_REPORT.Columns.Add("الواحدة", typeof(string));
                    DT_REPORT.Columns.Add("ملاحظات", typeof(string));
                    DT_REPORT.Columns.Add("نوع التقرير", typeof(string));
                    foreach (DataGridViewRow dgv in DGVLIST.Rows)
                    {
                        DT_REPORT.Rows.Add(
                                           dgv.Cells[3].Value,
                                           dgv.Cells[4].Value,
                                           dgv.Cells[5].Value, dgv.Cells[6].Value, dgv.Cells[7].Value,
                                           dgv.Cells[8].Value, name);
                    }
                    DS.Tables.Add(DT_REPORT);
                    DS.WriteXmlSchema("C:\\AraratProgramFiles\\Sample_ALL_SILAH.xml");

                    RPT.FRM_RPT frm = new RPT.FRM_RPT();
                    RPT.RPT_WAREHOUSE_SILAH report = new RPT.RPT_WAREHOUSE_SILAH();

                    report.Refresh();
                    report.SetDataSource(DS);
                    frm.crystalReportViewer1.ReportSource = report;
                    frm.ShowDialog();
                }
                if (CBOXSTA.Text == "اسم السلاح")
                {
                    DataSet DS = new DataSet();
                    DataTable DT_REPORT = new DataTable();
                    DT_REPORT.Columns.Add("النوع", typeof(string));
                    DT_REPORT.Columns.Add("السلاح", typeof(string));
                    DT_REPORT.Columns.Add("الموديل", typeof(string));
                    DT_REPORT.Columns.Add("الكمية", typeof(string));
                    DT_REPORT.Columns.Add("الواحدة", typeof(string));
                    DT_REPORT.Columns.Add("ملاحظات", typeof(string));
                    DT_REPORT.Columns.Add("نوع التقرير", typeof(string));
                    foreach (DataGridViewRow dgv in DGVLIST.Rows)
                    {
                        DT_REPORT.Rows.Add(
                                           dgv.Cells[3].Value,
                                           dgv.Cells[4].Value,
                                           dgv.Cells[5].Value, dgv.Cells[6].Value, dgv.Cells[7].Value,
                                           dgv.Cells[8].Value, name);
                    }
                    DS.Tables.Add(DT_REPORT);
                    DS.WriteXmlSchema("C:\\AraratProgramFiles\\Sample_ALL_SILAH.xml");

                    RPT.FRM_RPT frm = new RPT.FRM_RPT();
                    RPT.RPT_EXISTING_NAME_SILAH report = new RPT.RPT_EXISTING_NAME_SILAH();
                    report.Refresh();
                    report.SetDataSource(DS);
                    frm.crystalReportViewer1.ReportSource = report;
                    frm.ShowDialog();
                }
            }
        }

        private void BTNCLO_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }       


        private void RBTN_EXPORT_CheckedChanged(object sender, EventArgs e)
        {
            DGVLIST.DataSource = null;
            name = "الأسلحة الصادرة";
            CBOX_CAT.Enabled = true;
            CBOX_CAT_NAME.Enabled = true;
            DTP1.Enabled = true;
            DTP2.Enabled = true;
            CBOXSTA.Enabled = true;
        }

        private void CBOXSTA1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CBOXSTA.Text == "الكل")
            {
                CBOX_CAT.Enabled = false;
                CBOX_CAT_NAME.Enabled = false;
            }
            if (CBOXSTA.Text == "نوع السلاح")
            {
                CBOX_CAT.Enabled = true;
                CBOX_CAT_NAME.Enabled = false;
            }
            if (CBOXSTA.Text == "اسم السلاح")
            {
                CBOX_CAT.Enabled = true;
                CBOX_CAT_NAME.Enabled = true;
            }
        }

        private void CBOX_CAT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CBOX_CAT_NAME.DataSource = SILAH.GET_SILAH_BY_CAT_CODE(Convert.ToInt32(CBOX_CAT.SelectedValue.ToString()));
                CBOX_CAT_NAME.DisplayMember = "الاسم";
                CBOX_CAT_NAME.ValueMember = "CAT_SILAH_ID";
            }
            catch { return; }
        }

        private void RBTN_MUSTERED_CheckedChanged(object sender, EventArgs e)
        {
            DGVLIST.DataSource = null;
            name = "الأسلحة المستردة";
            CBOX_CAT.Enabled = true;
            CBOX_CAT_NAME.Enabled = true;
            DTP1.Enabled = true;
            DTP2.Enabled = true;
            CBOXSTA.Enabled = true;
        }

        private void FORM_STATISTIC_SILAH_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("التقارير", ar);
                RBTN_EXPORT.Text = rm.GetString("صادر", ar);
                RBTN_IMPORT.Text = rm.GetString("وارد", ar);
                RBTN_ALL.Text = rm.GetString("الموجود في المستودع", ar);
                RBTN_MUSTERED.Text = rm.GetString("مسترد", ar);
                label1.Text = rm.GetString("نوع الاحصائية", ar);
                label8.Text = rm.GetString("النوع", ar);
                label6.Text = rm.GetString("السلاح", ar);
                label3.Text = rm.GetString("من تاريخ", ar);
                label2.Text = rm.GetString("الى تاريخ", ar);
                BTNIQLIMSHOW.Text = rm.GetString("معاينة", ar);
                BTNPRINT.Text = rm.GetString("طباعة", ar);
                BTNCLO.Text = rm.GetString("خروج", ar);
            }
        }
    }
}
