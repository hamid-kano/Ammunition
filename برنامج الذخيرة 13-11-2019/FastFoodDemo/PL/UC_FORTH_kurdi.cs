using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.PL
{
    public partial class UC_FORTH_kurdi : UserControl
    {
        public UC_FORTH_kurdi()
        {
            InitializeComponent();
        }

        private void BTNPARTYMNG_Click(object sender, EventArgs e)
        {
            FORM_STATISTIC_MEMBERS FRM = new FORM_STATISTIC_MEMBERS();
            FRM.ShowDialog();
        }



        private void BTNMEMBR_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORM_FORCE FRM = new FORM_FORCE();
            FRM.ShowDialog();
        }
 
        private void BTNMOVE_Click(object sender, EventArgs e)
        {
            FORM_KTEBA FRM = new FORM_KTEBA();
            FRM.ShowDialog();
        }

        private void BTNSTA_Click(object sender, EventArgs e)
        {
            FORM_MANTKA FRM = new FORM_MANTKA();
            FRM.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //PL.FORM_ADD_MEMBERS FRM = new FORM_ADD_MEMBERS();
            //FRM.ShowDialog();
            FORM_ADD_NEW_MEMBER FRM = new FORM_ADD_NEW_MEMBER();
            FRM.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FORM_MEM_MNG FRM = new FORM_MEM_MNG();
            FRM.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FORM_LOAA FRM = new FORM_LOAA();
            FRM.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FORM_IQLIM FRM = new FORM_IQLIM();
            FRM.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FORM_FAOJ FRM = new FORM_FAOJ();
            FRM.ShowDialog();
        }

  



        private void UC_FORTH_Load(object sender, EventArgs e)
        {

        }

        private void BTNMOVING_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            PL.FORM_SILAH_MNG FRM = new FORM_SILAH_MNG();
            FRM.ShowDialog();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            PL.FORM_CATEGORY frm = new FORM_CATEGORY();
            frm.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PL.FORM_SILAH_CATIGORY frm = new FORM_SILAH_CATIGORY();
            frm.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            PL.FORM_IMP_EXP frm = new FORM_IMP_EXP();
            frm.ShowDialog();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            FORM_GHANAEM FRM = new FORM_GHANAEM();
            FRM.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            FORM_ORDERS FRM = new FORM_ORDERS();
            FRM.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            FORM_CONFSCATION FRM = new FORM_CONFSCATION();
            FRM.ShowDialog();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            FORM_STATISTIC_SILAH FRM = new FORM_STATISTIC_SILAH();
            FRM.ShowDialog();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            FORM_SOURCE FRM = new FORM_SOURCE();
            FRM.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FORM_RECYCLEBIN FRM = new FORM_RECYCLEBIN();
            FRM.ShowDialog();
        }

        private void BTN_IMPORT_Click(object sender, EventArgs e)
        {

        }

        private void BTN_EXPORT_Click(object sender, EventArgs e)
        {
            FORM_EXPORT_DATA FRM = new FORM_EXPORT_DATA();
            FRM.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FORM_TABUR_SILAH_MNG FRM = new FORM_TABUR_SILAH_MNG();
            FRM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FORM_IMPORT_DATA FRM = new FORM_IMPORT_DATA();
            FRM.ShowDialog();
        }
    }
}
