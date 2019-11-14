using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace FastFoodDemo
{
    public partial class FORM_USERS_Actions : Form
    {
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        public FORM_USERS_Actions()
        {
            InitializeComponent();

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }

        }

      
        private void FORM_USERS_Actions_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("نشاطات المستخدمين", ar);
                label3.Text = rm.GetString("بحث عام", ar);
                label1.Text = rm.GetString("حسب التاريخ", ar);
            }
            DGVACTIONLOGs.DataSource = MEM.GET_ACTION_LOGS();
        }

        private void Dtp2_ValueChanged(object sender, EventArgs e)
        {
            DGVACTIONLOGs.DataSource = MEM.SEARCH_ACTION_LOGS_BETWEEN_2DATES(dtp1.Value, dtp2.Value);
        }

        private void Dtp1_ValueChanged(object sender, EventArgs e)
        {
            DGVACTIONLOGs.DataSource = MEM.SEARCH_ACTION_LOGS_BETWEEN_2DATES(dtp1.Value, dtp2.Value);
        }

        private void DGVACTIONLOGs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < DGVACTIONLOGs.Rows.Count; i++)
            {
                if (DGVACTIONLOGs.Rows[i].Index % 2 == 0)
                {
                    DGVACTIONLOGs.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(171, 125, 47);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DGVACTIONLOGs.DataSource = MEM.SEARCH_ACTION_LOGS_BETWEEN_2DATES(dtp1.Value.Date, dtp2.Value.Date);
        }

        private void TxtSEARCH_TextChanged(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == string.Empty)
            {
                DGVACTIONLOGs.DataSource = MEM.GET_ACTION_LOGS();
            }
            DGVACTIONLOGs.DataSource = MEM.SEARCH_ACTION_LOGS(txtSEARCH.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DGVACTIONLOGs.DataSource = MEM.GET_ACTION_LOGS();
            txtSEARCH.Clear();
        }
    }
}