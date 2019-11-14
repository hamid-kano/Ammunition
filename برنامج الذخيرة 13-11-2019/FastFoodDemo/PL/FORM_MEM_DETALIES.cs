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
    public partial class FORM_MEM_DETALIES : Form
    {
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();        
        public FORM_MEM_DETALIES()
        {
            InitializeComponent();

            DGVDETALIES.DataSource = MEM.GET_MEMBER_DETALIES(Program.MEM_IDEN);
          //  DGVDETALIES.Columns[0].Visible = false;
            DGVDETALIES.Columns[1].Visible = false;

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
            DataSet DS = new DataSet();
            DataTable DT_REPORT = new DataTable();

            DT_REPORT.Columns.Add("اللقب", typeof(string));
            DT_REPORT.Columns.Add("الاسم", typeof(string));
            DT_REPORT.Columns.Add("الأب", typeof(string));
            DT_REPORT.Columns.Add("الكنية", typeof(string));
            DT_REPORT.Columns.Add("الأم", typeof(string));

            DT_REPORT.Columns.Add("الاختصاص", typeof(string));
            DT_REPORT.Columns.Add("المكان الحالي", typeof(string));
            DT_REPORT.Columns.Add("المهمة الحالية", typeof(string));
            DT_REPORT.Columns.Add("الوضع", typeof(string));
            DT_REPORT.Columns.Add("محلي/كادر", typeof(string));

            DT_REPORT.Columns.Add("الكتيبة", typeof(string));
            DT_REPORT.Columns.Add("القوة", typeof(string));
            DT_REPORT.Columns.Add("التاريخ", typeof(string));
            DT_REPORT.Columns.Add("الحالة", typeof(string));

            foreach (DataGridViewRow dgv in DGVDETALIES.Rows)
            {
                DT_REPORT.Rows.Add(dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value,
                                   dgv.Cells[6].Value, dgv.Cells[7].Value, dgv.Cells[8].Value,
                                   dgv.Cells[9].Value, dgv.Cells[10].Value, dgv.Cells[11].Value,
                                   dgv.Cells[12].Value, dgv.Cells[13].Value, dgv.Cells[14].Value,
                                   Convert.ToDateTime(dgv.Cells[15].Value).ToShortDateString(), dgv.Cells[16].Value);
            }
            DS.Tables.Add(DT_REPORT);
            DS.WriteXmlSchema("C:\\AraratProgramFiles\\SampleMEMDETALIES.xml");

            RPT.FRM_RPT frm = new RPT.FRM_RPT();
            RPT.RPT_MEM_DETALIES_FROM_GATH report = new RPT.RPT_MEM_DETALIES_FROM_GATH();

            report.Refresh();
            report.SetDataSource(DS);

            frm.crystalReportViewer1.ReportSource = report;


            frm.ShowDialog();
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "طباعة", "طباعة قائمة بتفاصيل المقاتل  " + Program.MEM_CODENAME, DateTime.Now);

        }

        private void DGVDETALIES_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < DGVDETALIES.Rows.Count; i++)
            {
                if (DGVDETALIES.Rows[i].Index % 2 == 0)
                {
                    DGVDETALIES.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171, 125, 47);
                }
            }
        }

        private void FORM_MEM_DETALIES_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("التفاصيل", ar);
                BTNADD.Text = rm.GetString("طباعة", ar);
                button1.Text = rm.GetString("خروج", ar);
            }
        }
    }
}
