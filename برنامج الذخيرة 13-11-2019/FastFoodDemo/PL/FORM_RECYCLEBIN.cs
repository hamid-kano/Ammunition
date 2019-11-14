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
    public partial class FORM_RECYCLEBIN : Form
    {
        public FORM_RECYCLEBIN()
        {
            InitializeComponent();

            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            FORM_MEM_DELETED FRM = new FORM_MEM_DELETED();
            FRM.ShowDialog();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            FORM_SILAH_DELETED FRM = new FORM_SILAH_DELETED();
            FRM.ShowDialog();
        }

        private void FORM_RECYCLEBIN_Load(object sender, EventArgs e)
        {
            if (FastFoodDemo.Properties.Settings.Default.lang == "ku-KU")
            {
                CultureInfo ar = new CultureInfo("ku-KU");
                Assembly a = Assembly.Load("FastFoodDemo");
                ResourceManager rm = new ResourceManager("FastFoodDemo.Lang.Resource", a);
                this.Text = rm.GetString("سلة المحذوفات", ar);
                BTNADD.Text = rm.GetString("العناصر", ar);
                button1.Text = rm.GetString("اخرى", ar);
               
            }
        }
    }
}
