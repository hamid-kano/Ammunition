using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace FastFoodDemo.PL
{
  
    public partial class FORM_ORDERS : Form
    {
        FolderBrowserDialog dlg = new FolderBrowserDialog();
        BL.ORDERS ORD = new BL.ORDERS();
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        public FORM_ORDERS()
        {
            InitializeComponent();
            DGV_ORDERS.DataSource = ORD.GET_ALL_ORDERS();
            DGV_ORDERS.Columns[0].Visible = false;
            DGV_ORDERS.Columns[6].Visible = false;

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CBOX_TYPE.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار نوع الطلب \n Cûre Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_TYPE.Focus();
                return;
            }
            if (TXT_SOURCE.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال الجهة المرسلة \n Cihê Jê Hatiye Hilbijêre ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_SOURCE.Focus();
                return;
            }

            ORD.ADD_NEW_ORDER(CBOX_TYPE.Text, DTP_DATE.Value, TXT_SOURCE.Text.TrimEnd(' '), TXT_CONTENT.Text, TXT_NOTES.Text,0);
            DGV_ORDERS.DataSource = ORD.GET_ALL_ORDERS();
            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "إضافة طلب", "إضافة", DateTime.Now);
            MessageBox.Show("تمت عملية الإضافة بنجاح \n zêdekirin serkeftî derbas bû ", "Zêdekirin-إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BTNADD.Enabled = false;
            Program.ORD_SOURCE = TXT_SOURCE.Text;
            Program.ORD_DATE = DTP_DATE.Text;

        
        }
        byte[] ReadFile(string path)
        {
            byte[] data = null;
            FileInfo finfo = new FileInfo(path);
            long numBytes = finfo.Length;
            FileStream fstream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            data = br.ReadBytes((int)numBytes);
            br.Close();
            fstream.Close();
            return data;

        }
        private void btnBrowe_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNEW_Click(object sender, EventArgs e)
        {
            TXT_SOURCE.Clear();
            TXT_NOTES.Clear();
            TXT_CONTENT.Clear();
            CBOX_TYPE.ResetText();
            DTP_DATE.ResetText();
            BTNADD.Enabled = true;
        }

        private void DGV_ORDERS_Click(object sender, EventArgs e)
        {
            //BTNADD_DOCS.Enabled = true;
            //BTNDELETE.Enabled = true;
            //BTNEDIT.Enabled = true;
            //CBOX_TYPE.Text= DGV_ORDERS.CurrentRow.Cells[1].Value.ToString();
            //TXT_SOURCE.Text = DGV_ORDERS.CurrentRow.Cells[2].Value.ToString();
            //DTP_DATE.Text = DGV_ORDERS.CurrentRow.Cells[3].Value.ToString();
            //TXT_CONTENT.Text= DGV_ORDERS.CurrentRow.Cells[4].Value.ToString();
            //TXT_NOTES.Text= DGV_ORDERS.CurrentRow.Cells[5].Value.ToString();
            //Program.ORD_ID = Convert.ToInt32(DGV_ORDERS.CurrentRow.Cells[0].Value.ToString());
        }

        private void BTNEDIT_Click(object sender, EventArgs e)
        {
            if (CBOX_TYPE.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار نوع الطلب \n Cûre Derbas Bike ", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBOX_TYPE.Focus();
                return;
            }
            if (TXT_SOURCE.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال الجهة المرسلة \n Cih Derbas Bike", "hişyarî - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_SOURCE.Focus();
                return;
            }

            ORD.EDIT_ORDER(CBOX_TYPE.Text, DTP_DATE.Value, TXT_SOURCE.Text.TrimEnd(' '), TXT_CONTENT.Text, TXT_NOTES.Text,Convert.ToInt32(DGV_ORDERS.CurrentRow.Cells[0].Value.ToString()));

            MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "تعديل طلب", " biguhere - تعديل", DateTime.Now);
            MessageBox.Show("تمت عملية التعديل بنجاح  \n sererastkirin bi awakî serkeftî hate tomarkirin ", " biguhere - تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_ORDERS.DataSource = ORD.GET_ALL_ORDERS();
            TXT_SOURCE.Clear();
            TXT_CONTENT.Clear();
            TXT_NOTES.Clear();
            CBOX_TYPE.ResetText();
            DTP_DATE.ResetText();
            BTNEDIT.Enabled = false;
            BTNDELETE.Enabled = false;
            BTNADD_DOCS.Enabled = false;
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟ \n Hûn Dixwazin Çalakiya Jêbirinê Pêkbînin?", "Jêbirinê - الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ORD.DELETE_ORDER(DGV_ORDERS.CurrentRow.Cells[0].Value.ToString());
                MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "حذف طلب", "Jêbirinê - الحذف", DateTime.Now);
                MessageBox.Show("تم الحذف بنجاح \n sîlkirin serkeftî ye", "Jêbirinê - الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_ORDERS.DataSource = ORD.GET_ALL_ORDERS();
                TXT_SOURCE.Clear();
                TXT_CONTENT.Clear();
                TXT_NOTES.Clear();
                CBOX_TYPE.ResetText();
                DTP_DATE.ResetText();
                BTNEDIT.Enabled = false;
                BTNDELETE.Enabled = false;
                BTNADD_DOCS.Enabled = false;
             
                // FORM_TABUR_MNG.getMainForm.CBOX_ALAY.DataSource = ALAY.GET_ALL_ALAY();
            }
        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            if (TXT_SEARCH.Text == string.Empty)
            {
                DGV_ORDERS.DataSource = ORD.GET_ALL_ORDERS();
            }
            else
            {
                DGV_ORDERS.DataSource = ORD.SEARCH_OPDER(TXT_SEARCH.Text);
                DGV_ORDERS.Columns[0].Visible = false;

                DGV_ORDERS.Columns[6].Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DGV_ORDERS.DataSource = ORD.GET_ALL_ORDERS();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNSHOW_Click(object sender, EventArgs e)
        {
        //    FORM_ADD_order_docs FRM = new FORM_ADD_order_docs();
        //    FRM.ShowDialog();
        //    BTNEDIT.Enabled = false;
        //    BTNDELETE.Enabled = false;
        //    BTNADD_DOCS.Enabled = false;
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void FORM_ORDERS_Load(object sender, EventArgs e)
        {

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("الطلبات", ar);
                label23.Text = rm.GetString("نوع الطلب", ar);
                label1.Text = rm.GetString("التاريخ", ar);
                label2.Text = rm.GetString("الجهة المرسلة", ar);
                label4.Text = rm.GetString("المضمون", ar);
                label3.Text = rm.GetString("ملاحظات", ar);
                label5.Text = rm.GetString("بحث", ar);
                btnNEW.Text = rm.GetString("جديد", ar);
                BTNADD.Text = rm.GetString("اضافة", ar);
                BTNEDIT.Text = rm.GetString("تعديل", ar);
                BTNDELETE.Text = rm.GetString("حذف", ar);
                button2.Text = rm.GetString("خروج", ar);

            }
        }

        private void DGV_ORDERS_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

            BTNADD_DOCS.Enabled = true;
            BTNDELETE.Enabled = true;
            BTNEDIT.Enabled = true;
            CBOX_TYPE.Text = DGV_ORDERS.CurrentRow.Cells[1].Value.ToString();
            TXT_SOURCE.Text = DGV_ORDERS.CurrentRow.Cells[2].Value.ToString();
            DTP_DATE.Text = DGV_ORDERS.CurrentRow.Cells[3].Value.ToString();
            TXT_CONTENT.Text = DGV_ORDERS.CurrentRow.Cells[4].Value.ToString();
            TXT_NOTES.Text = DGV_ORDERS.CurrentRow.Cells[5].Value.ToString();
            Program.ORD_ID = Convert.ToInt32(DGV_ORDERS.CurrentRow.Cells[0].Value.ToString());

            }
            catch (Exception)
            {

               // throw;
            }
        }
    }
}
