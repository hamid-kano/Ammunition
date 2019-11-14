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
    public partial class FORM_ACTION_LOG : Form
    {
        BL.MEMBER_CLS MEM = new BL.MEMBER_CLS();
        public FORM_ACTION_LOG()
        {
            InitializeComponent();
            DGVACTION.DataSource = MEM.GET_ACTION_LOGS();
            DGVACTION.Columns[0].Visible = false;

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == string.Empty)
            {
                DGVACTION.DataSource = MEM.GET_ACTION_LOGS();
            }
            DGVACTION.DataSource = MEM.SEARCH_ACTION_LOGS(txtSEARCH.Text);
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            DGVACTION.DataSource = MEM.SEARCH_ACTION_LOGS_BETWEEN_2DATES(dtp1.Value, dtp2.Value);
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            DGVACTION.DataSource = MEM.SEARCH_ACTION_LOGS_BETWEEN_2DATES(dtp1.Value, dtp2.Value);
        }

        private void FORM_ACTION_LOG_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);               
                label1.Text = rm.GetString("بحث عام", ar);
                label2.Text = rm.GetString("حسب التاريخ", ar);

            }
        }
    }
}
