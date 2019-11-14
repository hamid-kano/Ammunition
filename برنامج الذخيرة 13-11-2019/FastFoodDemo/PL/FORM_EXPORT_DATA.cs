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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using System.Data.OleDb;
using System.Diagnostics;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using System.Globalization;
using System.Resources;

namespace FastFoodDemo.PL

{
    public partial class FORM_EXPORT_DATA : Form
    {
        BL.HEREM_CLS HER = new BL.HEREM_CLS();
        BL.EYALET_CLS EYALET = new BL.EYALET_CLS();
        BL.TUGAY_CLS TUGAY = new BL.TUGAY_CLS();
        BL.ALAY_CLS ALAY = new BL.ALAY_CLS();
        BL.TABUR_CLS TABUR = new BL.TABUR_CLS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        BL.SOURC_CLS SRC = new BL.SOURC_CLS();
        BL.EXPORT_CLS EX = new BL.EXPORT_CLS();
        BL.MEM_SILAH MEM_SILA = new BL.MEM_SILAH();
        public FORM_EXPORT_DATA()
        {
            InitializeComponent();
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }

        }
          public  void ExportToExcel(DataTable tbl, string excelFilePath = null)
        {
            try
            {

                if (tbl == null || tbl.Columns.Count == 0)
                {
                    MessageBox.Show("لا توجد بيانات لتصديرها \n Daneyên Derxistinin Tuneye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // load excel, and create a new workbook
                var excelApp = new Excel.Application();
                excelApp.Workbooks.Add();

                // single worksheet
                Excel._Worksheet workSheet = excelApp.ActiveSheet;

                // column headings
                for (var i = 0; i < tbl.Columns.Count; i++)
                {
                    workSheet.Cells[1, i + 1] = tbl.Columns[i].ColumnName;
                }

                // rows
                for (var i = 0; i < tbl.Rows.Count; i++)
                {
                    // to do: format datetime values before printing
                    for (var j = 0; j < tbl.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2, j + 1] = tbl.Rows[i][j];
                    }
                }

                // check file path
                if (!string.IsNullOrEmpty(excelFilePath))
                {
                    try
                    {
                        workSheet.SaveAs(excelFilePath);
                        excelApp.Quit();
                        //  MessageBox.Show("Excel file saved!");


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("لا توجد بيانات لتصديرها \n Daneyên Derxistinin Tuneye ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                { // no file path is given
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ExportToExcel: \n" + ex.Message);
                return;
            }}
        
        FolderBrowserDialog dlg = new FolderBrowserDialog();
       

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String PATH = "";
            this.Cursor = Cursors.WaitCursor;

            DialogResult dres = dlg.ShowDialog();


            PATH = dlg.SelectedPath;

            if (CBOXEXTYPE.Text == "الأقاليم")
            {
                this.Cursor = Cursors.WaitCursor;
                ExportToExcel(EX.EX_GET_FROM_HEREM(), PATH + "\\" + "1-الأقاليم" + ".Xlsx");
                MessageBox.Show("تم تصدير الملفات بنجاح \n radestikrina agahiyan serkeftî ye ", " Excel تصدير لملف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تصدير", "تصدير البيانات بتاريخ " + DateTime.Now.ToShortDateString(), DateTime.Now);

                this.Cursor = Cursors.Default;

            }
            if (CBOXEXTYPE.Text == "المناطق")
            {
                this.Cursor = Cursors.WaitCursor;
                ExportToExcel(EYALET.GET_ALL_EYALET(), PATH + "\\" + "2-المناطق" + ".Xlsx");
                MessageBox.Show("تم تصدير الملفات بنجاح \n radestikrina agahiyan serkeftî ye ", " Excel تصدير لملف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تصدير", "تصدير البيانات بتاريخ " + DateTime.Now.ToShortDateString(), DateTime.Now);

                this.Cursor = Cursors.Default;

            }

            if (CBOXEXTYPE.Text == "الألوية")
            {
                this.Cursor = Cursors.WaitCursor;
                ExportToExcel(TUGAY.GET_ALL_TUGAY(), PATH + "\\" + "3-الألوية" + ".Xlsx");
                MessageBox.Show("تم تصدير الملفات بنجاح \n radestikrina agahiyan serkeftî ye ", " Excel تصدير لملف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تصدير", "تصدير البيانات بتاريخ " + DateTime.Now.ToShortDateString(), DateTime.Now);

                this.Cursor = Cursors.Default;

            }
            if (CBOXEXTYPE.Text == "الأفواج")
            {
                this.Cursor = Cursors.WaitCursor;

                ExportToExcel(ALAY.GET_ALL_ALAY(), PATH + "\\" + "4-الأفواج" + ".Xlsx");
                MessageBox.Show("تم تصدير الملفات بنجاح \n radestikrina agahiyan serkeftî ye ", " Excel تصدير لملف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تصدير", "تصدير البيانات بتاريخ " + DateTime.Now.ToShortDateString(), DateTime.Now);

                this.Cursor = Cursors.Default;

            }

            if (CBOXEXTYPE.Text == "الكتائب")
            {
                this.Cursor = Cursors.WaitCursor;

                ExportToExcel(TABUR.GET_ALL_TABUR(), PATH + "\\" + "5-الكتائب" + ".Xlsx");
                MessageBox.Show("تم تصدير الملفات بنجاح \n radestikrina agahiyan serkeftî ye ", " Excel تصدير لملف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تصدير", "تصدير البيانات بتاريخ " + DateTime.Now.ToShortDateString(), DateTime.Now);

                this.Cursor = Cursors.Default;

            }

            if (CBOXEXTYPE.Text == "القوات")
            {
                this.Cursor = Cursors.WaitCursor;

                ExportToExcel(SRC.GET_ALL_FORCE(), PATH + "\\" + "6-القوات" + ".Xlsx");
                MessageBox.Show("تم تصدير الملفات بنجاح \n radestikrina agahiyan serkeftî ye ", " Excel تصدير لملف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تصدير", "تصدير البيانات بتاريخ " + DateTime.Now.ToShortDateString(), DateTime.Now);

                this.Cursor = Cursors.Default;

            }
            if (CBOXEXTYPE.Text == "المقاتلين")
            {
                this.Cursor = Cursors.WaitCursor;

                ExportToExcel(EX.EX_GET_FROM_MEM_TABLE(), PATH + "\\" + "7-المقاتلين" + ".Xlsx");
                MessageBox.Show("تم تصدير الملفات بنجاح \n radestikrina agahiyan serkeftî ye ", " Excel تصدير لملف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تصدير", "تصدير البيانات بتاريخ " + DateTime.Now.ToShortDateString(), DateTime.Now);

                this.Cursor = Cursors.Default;

            }
            if (CBOXEXTYPE.Text == "تفاصيل المقاتلين")
            {
                this.Cursor = Cursors.WaitCursor;

                ExportToExcel(EX.EX_GET_GATH(), PATH + "\\" + "8-تفاصيل المقاتلين" + ".Xlsx");
                MessageBox.Show("تم تصدير الملفات بنجاح \n radestikrina agahiyan serkeftî ye ", " Excel تصدير لملف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تصدير", "تصدير البيانات بتاريخ " + DateTime.Now.ToShortDateString(), DateTime.Now);

                this.Cursor = Cursors.Default;

            }
            if (CBOXEXTYPE.Text == "أسلحة المستودع")
            {
                this.Cursor = Cursors.WaitCursor;

                ExportToExcel(EX.EX_GET_ALL_SILAH(), PATH + "\\" + "9-أسلحة المستودع " + ".Xlsx");
                MessageBox.Show("تم تصدير الملفات بنجاح \n radestikrina agahiyan serkeftî ye ", " Excel تصدير لملف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تصدير", "تصدير البيانات بتاريخ " + DateTime.Now.ToShortDateString(), DateTime.Now);

                this.Cursor = Cursors.Default;

            }
            if (CBOXEXTYPE.Text == "أسلحة المقاتل")
            {
                this.Cursor = Cursors.Default;
                DataTable DT =EX.EX_GET_FROM_MEM_TABLE();              
                ExportToExcel(EX.EX_GET_FROM_MEM_TABLE(), PATH + "\\" + "المقاتلين" + ".Xlsx");

                for(int i=0;i<DT.Rows.Count;i++){

                    ExportToExcel(MEM_SILA.GET_ALL_MEM_SILAH(DT.Rows[i][0].ToString()), PATH + "\\" + DT.Rows[i][0].ToString() + "-" + DT.Rows[i][3].ToString() + " " + "أسلحة المقاتل" + ".Xlsx");
                }
                MessageBox.Show("تم تصدير الملفات بنجاح \n radestikrina agahiyan serkeftî ye ", " Excel تصدير لملف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تصدير", "تصدير البيانات بتاريخ " + DateTime.Now.ToShortDateString(), DateTime.Now);

                this.Cursor = Cursors.Default;

            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FORM_EXPORT_DATA_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("تصدير البيانات", ar);
                label3.Text = rm.GetString("تحديد الجدول", ar);
                button2.Text = rm.GetString("تصدير البيانات", ar);
                button3.Text = rm.GetString("خروج", ar);
                
            }
        }
    }
}
