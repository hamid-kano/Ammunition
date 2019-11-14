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
    public partial class FORM_MEM_SILAHS : Form
    {
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();

        BL.SOURC_CLS SOURCE = new BL.SOURC_CLS();
        BL.SILAH_CLS SILAH = new BL.SILAH_CLS();
        BL.MEM_SILAH MEM_SILAH = new BL.MEM_SILAH();
        public FORM_MEM_SILAHS()
        {
            InitializeComponent();
            DGV_SILAH.DataSource = MEM_SILAH.GET_ALL_MEM_SILAH(Program.MEM_IDEN);
            DGV_SILAH.Columns[0].Visible = false;
            DGV_SILAH.Columns[1].Visible = false;
            DGV_SILAH.Columns[2].Visible = false;
            DGV_SILAH.Columns[3].Visible = false;
            DGV_SILAH.Columns[4].Visible = false;
            DGV_SILAH.Columns[8].Visible = false;
            // DGV_SILAH.Columns[9].Visible = false;

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

     

        private void DGVDETALIES_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void FORM_MEM_SILAHS_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("قائمة الاسلحة", ar);               
                button1.Text = rm.GetString("خروج", ar);

            }
        }
    }
}
