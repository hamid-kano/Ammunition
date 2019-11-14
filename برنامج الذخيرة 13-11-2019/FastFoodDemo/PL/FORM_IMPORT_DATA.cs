using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;
using GemBox.Spreadsheet;
using ExcelFile;
using System.IO;
using System.Data.OleDb;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace FastFoodDemo.PL
{
    public partial class FORM_IMPORT_DATA : Form
    {
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        System.Data.DataTable dtDESTINATION;
        BL.EXPORT_CLS EX = new BL.EXPORT_CLS();
        BL.HEREM_CLS HER = new BL.HEREM_CLS();
        BL.TUGAY_CLS TUGAY = new BL.TUGAY_CLS();
        BL.TABUR_CLS TABUR = new BL.TABUR_CLS();
        BL.ALAY_CLS ALAY = new BL.ALAY_CLS();
        BL.EYALET_CLS EYALET = new BL.EYALET_CLS();
        BL.SOURC_CLS SRC = new BL.SOURC_CLS();
        OleDbConnection CON;
        OleDbDataAdapter DA;
        DataTable DT;
        double value = 0;
        private DataTable ReadSpreadSheet(string filePath)
        {
            // If using Professional version, put your serial key below.
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            var workbook = GemBox.Spreadsheet.ExcelFile.Load(filePath);

            // Select the first worksheet from the file.
            var worksheet = workbook.Worksheets[0];

            // Create DataTable from an Excel worksheet.
            var dataTable = worksheet.CreateDataTable(new CreateDataTableOptions()
            {
                ColumnHeaders = true,
                StartRow = 0,
                NumberOfColumns = 0,
                NumberOfRows = 0,
                Resolution = ColumnTypeResolution.AutoPreferStringCurrentCulture
            });
            return dataTable;
        }
        public FORM_IMPORT_DATA()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            InitializeComponent();

            CBOXEXTYPE.Text = "1-الأقاليم";
            //  DGVSCEDULE.ColumnHeadersVisible = false;

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            DGVSCEDULE.DataSource = null;
            textBoxPath.Clear();
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                this.textBoxPath.Text = openfiledialog.FileName;
                BTNSHOW.Enabled = true;
            }
        }

        private void BTNSHOW_Click(object sender, EventArgs e)
        {
            DGVSCEDULE.DataSource = null;

            value = 0;
            this.Cursor = Cursors.WaitCursor;

            CON = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = " + textBoxPath.Text + ";Extended Properties ='Excel 12.0;HDR=Yes;'");
            CON.Open();
            DataTable Sheets = CON.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            foreach (DataRow dr in Sheets.Rows)
            {
                string sht = dr[2].ToString().Replace("'", "");
                DA = new OleDbDataAdapter("select * from [" + sht + "]", CON);
            }

            DataTable DT = new DataTable();
            DA.Fill(DT);
            DGVSCEDULE.DataSource = DT;
            dtDESTINATION = DT;

            CON.Close();
            this.Cursor = Cursors.Default;

            BTNIMPORT.Enabled = true;
        }

        private void BTNIMPORT_Click(object sender, EventArgs e)
        {
            if (CBOXEXTYPE.Text == String.Empty)
            {
                MessageBox.Show("يجب تحديد الجدول المراد استيراده \n Daneyên Hatinê Hilbijêre", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (CBOXEXTYPE.Text == "1-الأقاليم")
            {
                this.Cursor = Cursors.WaitCursor;
                DataTable dtDESTINATION_EXIST_HEREM = HER.GET_ALL_HEREM();

                for (int i = 0; i < DGVSCEDULE.Rows.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < dtDESTINATION_EXIST_HEREM.Rows.Count; j++)
                    {
                        if (DGVSCEDULE.Rows[i].Cells[2].Value.ToString() == dtDESTINATION_EXIST_HEREM.Rows[j][2].ToString())
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {

                        /////في حال الإقليم غير موجود مسبقاً تتم إضافته
                        HER.ADD_NEW_HEREM(Program.APP_IDEN
                                   , DGVSCEDULE.Rows[i].Cells[2].Value.ToString()
                                   , DGVSCEDULE.Rows[i].Cells[3].Value.ToString() ,0);
                    }
                    if (count > 0)
                    {
                        HER.EDIT_HEREM(DGVSCEDULE.Rows[i].Cells[2].Value.ToString()
                                   , DGVSCEDULE.Rows[i].Cells[3].Value.ToString()
                                   , DGVSCEDULE.Rows[i].Cells[2].Value.ToString()
                                );
                    }
                }
                DGVSCEDULE.DataSource = null;
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "استيراد", "استيراد البيانات بتاريخ " + DateTime.Now.ToShortDateString(), DateTime.Now);
                this.Cursor = Cursors.Default;
                MessageBox.Show("تم استيراد الملف بنجاح \n wergirtina agahiyan serkeftî ye", "Hatina - استيراد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CBOXEXTYPE.ResetText();
            }
            if (CBOXEXTYPE.Text == "2-المناطق" )
            {
                this.Cursor = Cursors.WaitCursor;
                DataTable dtDESTINATION_EXIST = EYALET.GET_ALL_EYALET();

                for (int i = 0; i < DGVSCEDULE.Rows.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < dtDESTINATION_EXIST.Rows.Count; j++)
                    {
                        if (DGVSCEDULE.Rows[i].Cells[3].Value.ToString() == dtDESTINATION_EXIST.Rows[j][3].ToString())
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        EYALET.ADD_NEW_EYALET(Program.APP_IDEN
                                   , DGVSCEDULE.Rows[i].Cells[3].Value.ToString()
                                   , DGVSCEDULE.Rows[i].Cells[6].Value.ToString(), DGVSCEDULE.Rows[i].Cells[4].Value.ToString(), 0);
                    }
                    if (count > 0)
                    {
                        EYALET.EDIT_EYALET(DGVSCEDULE.Rows[i].Cells[3].Value.ToString()
                                   , DGVSCEDULE.Rows[i].Cells[6].Value.ToString()
                                   , DGVSCEDULE.Rows[i].Cells[4].Value.ToString(), DGVSCEDULE.Rows[i].Cells[3].Value.ToString() );
                    }
                }
                DGVSCEDULE.DataSource = null;
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "استيراد", "استيراد البيانات بتاريخ " + DateTime.Now.ToShortDateString(), DateTime.Now);
                this.Cursor = Cursors.Default;
                MessageBox.Show("تم استيراد الملف بنجاح \n wergirtina agahiyan serkeftî ye", "Hatina - استيراد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CBOXEXTYPE.ResetText();
            }
            if (CBOXEXTYPE.Text == "3-الألوية")
            {
                this.Cursor = Cursors.WaitCursor;
                DataTable dtDESTINATION_EXIST = TUGAY.GET_ALL_TUGAY();

                for (int i = 0; i < DGVSCEDULE.Rows.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < dtDESTINATION_EXIST.Rows.Count; j++)
                    {
                        if (DGVSCEDULE.Rows[i].Cells[3].Value.ToString() == dtDESTINATION_EXIST.Rows[j][3].ToString())
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        TUGAY.ADD_NEW_TUGAY(Program.APP_IDEN
                                   , DGVSCEDULE.Rows[i].Cells[3].Value.ToString()
                                   , DGVSCEDULE.Rows[i].Cells[7].Value.ToString(), DGVSCEDULE.Rows[i].Cells[4].Value.ToString(), 0, DGVSCEDULE.Rows[i].Cells[5].Value.ToString());
                    }
                    if (count > 0)
                    {
                        TUGAY.EDIT_TUGAY(DGVSCEDULE.Rows[i].Cells[3].Value.ToString()
                                   , DGVSCEDULE.Rows[i].Cells[7].Value.ToString()
                                   , DGVSCEDULE.Rows[i].Cells[4].Value.ToString(), DGVSCEDULE.Rows[i].Cells[5].Value.ToString(), DGVSCEDULE.Rows[i].Cells[3].Value.ToString());
                    }
                }
                DGVSCEDULE.DataSource = null;
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "استيراد", "استيراد البيانات بتاريخ " + DateTime.Now.ToShortDateString(), DateTime.Now);
                this.Cursor = Cursors.Default;
                MessageBox.Show("تم استيراد الملف بنجاح \n wergirtina agahiyan serkeftî ye", "Hatina - استيراد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CBOXEXTYPE.ResetText();
            }
            if (CBOXEXTYPE.Text == "4-الأفواج")
            {
                this.Cursor = Cursors.WaitCursor;
                DataTable dtDESTINATION_EXIST = ALAY.GET_ALL_ALAY();

                for (int i = 0; i < DGVSCEDULE.Rows.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < dtDESTINATION_EXIST.Rows.Count; j++)
                    {
                        if (DGVSCEDULE.Rows[i].Cells[3].Value.ToString() == dtDESTINATION_EXIST.Rows[j][3].ToString())
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        ALAY.ADD_NEW_ALAY(Program.APP_IDEN
                                   , DGVSCEDULE.Rows[i].Cells[3].Value.ToString()
                                   , DGVSCEDULE.Rows[i].Cells[7].Value.ToString(), DGVSCEDULE.Rows[i].Cells[4].Value.ToString(), 0, DGVSCEDULE.Rows[i].Cells[6].Value.ToString());
                    }
                    if (count > 0)
                    {
                        ALAY.EDIT_ALAY(DGVSCEDULE.Rows[i].Cells[3].Value.ToString()
                                   , DGVSCEDULE.Rows[i].Cells[7].Value.ToString()
                                   , DGVSCEDULE.Rows[i].Cells[4].Value.ToString(), DGVSCEDULE.Rows[i].Cells[3].Value.ToString(), DGVSCEDULE.Rows[i].Cells[6].Value.ToString());
                    }
                }
                DGVSCEDULE.DataSource = null;
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "استيراد", "استيراد البيانات بتاريخ " + DateTime.Now.ToShortDateString(), DateTime.Now);
                this.Cursor = Cursors.Default;
                MessageBox.Show("تم استيراد الملف بنجاح \n wergirtina agahiyan serkeftî ye", "Hatina - استيراد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CBOXEXTYPE.ResetText();
            }
            if (CBOXEXTYPE.Text == "5-الكتائب")
            {
                this.Cursor = Cursors.WaitCursor;
                DataTable dtDESTINATION_EXIST = TABUR.GET_ALL_TABUR();

                for (int i = 0; i < DGVSCEDULE.Rows.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < dtDESTINATION_EXIST.Rows.Count; j++)
                    {
                        if (DGVSCEDULE.Rows[i].Cells[3].Value.ToString() == dtDESTINATION_EXIST.Rows[j][3].ToString())
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        TABUR.ADD_NEW_TABUR(Program.APP_IDEN
                                   , DGVSCEDULE.Rows[i].Cells[3].Value.ToString()
                                   , DGVSCEDULE.Rows[i].Cells[7].Value.ToString(), DGVSCEDULE.Rows[i].Cells[4].Value.ToString(), 0, DGVSCEDULE.Rows[i].Cells[6].Value.ToString());
                    }
                    if (count > 0)
                    {
                       TABUR.EDIT_TABUR(DGVSCEDULE.Rows[i].Cells[3].Value.ToString()
                                   , DGVSCEDULE.Rows[i].Cells[7].Value.ToString()
                                   , DGVSCEDULE.Rows[i].Cells[4].Value.ToString(), DGVSCEDULE.Rows[i].Cells[3].Value.ToString(), DGVSCEDULE.Rows[i].Cells[6].Value.ToString());
                    }
                }
                DGVSCEDULE.DataSource = null;
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "استيراد", "استيراد البيانات بتاريخ " + DateTime.Now.ToShortDateString(), DateTime.Now);
                this.Cursor = Cursors.Default;
                MessageBox.Show("تم استيراد الملف بنجاح \n wergirtina agahiyan serkeftî ye", "Hatina - استيراد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CBOXEXTYPE.ResetText();
            }
            if (CBOXEXTYPE.Text == "6-القوات")
            {
                this.Cursor = Cursors.WaitCursor;
                DataTable dtDESTINATION_EXIST = SRC.GET_ALL_FORCE();

                for (int i = 0; i < DGVSCEDULE.Rows.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < dtDESTINATION_EXIST.Rows.Count; j++)
                    {
                        if (DGVSCEDULE.Rows[i].Cells[0].Value.ToString() == dtDESTINATION_EXIST.Rows[j][0].ToString())
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        SRC.ADD_FORCE(DGVSCEDULE.Rows[i].Cells[0].Value.ToString(), Program.APP_IDEN
                                   , DGVSCEDULE.Rows[i].Cells[3].Value.ToString(), 0);
                    }
                    if (count > 0)
                    {
                        SRC.EDIT_FORCE(DGVSCEDULE.Rows[i].Cells[0].Value.ToString()
                                    , DGVSCEDULE.Rows[i].Cells[3].Value.ToString()
                                    , DGVSCEDULE.Rows[i].Cells[3].Value.ToString());
                    }
                }
                DGVSCEDULE.DataSource = null;
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "استيراد", "استيراد البيانات بتاريخ " + DateTime.Now.ToShortDateString(), DateTime.Now);
                this.Cursor = Cursors.Default;
                MessageBox.Show("تم استيراد الملف بنجاح \n wergirtina agahiyan serkeftî ye", "Hatina - استيراد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CBOXEXTYPE.ResetText();
            }
        }
        public void INSERT_MEM_TO_DB(System.Data.DataTable dt)
        {
           
        }

        public void INSERT_PUNI_TO_DB(System.Data.DataTable dt)
        {
            ///حذف أولا كل تفاصيل العناصر ضمن النسخة التي يتم استيرادها
            for (int i = 0; i < dt.Rows.Count; i++)
            {
            }
            ////إضافة الأسطر من النسخة التي تم استيرادها
           
        }
        public void INSERT_REWARD_TO_DB(System.Data.DataTable dt)
        {
            ///حذف أولا كل تفاصيل العناصر ضمن النسخة التي يتم استيرادها
           
          
        }
        public void INSERT_GATH_TO_DB(System.Data.DataTable dt)
        {
            ///حذف أولا كل تفاصيل العناصر ضمن النسخة التي يتم استيرادها
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MEM.IMP_DELETE_FROM_GATH_BY_APP_IDEN_AND_MEM_IDEN(dt.Rows[i][4].ToString(), dt.Rows[i][1].ToString());
            }
           
        }
        public void INSERT_FINGER_TO_DB(System.Data.DataTable dt)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DGVSCEDULE_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < DGVSCEDULE.Rows.Count; i++)
            {
                if (DGVSCEDULE.Rows[i].Index % 2 == 0)
                {
                    DGVSCEDULE.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171, 125, 47);
                }
            }
        }

        private void FORM_IMPORT_DATA_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("استيراد البيانات", ar);
                BTNADD.Text = rm.GetString("اختيار ملف", ar);
                label3.Text = rm.GetString("تحديد الجدول", ar);
                BTNSHOW.Text = rm.GetString("معاينة - عرض", ar);
                BTNIMPORT.Text = rm.GetString("استيراد البيانات", ar);
                button3.Text = rm.GetString("خروج", ar);
            }
        }
    }
}
