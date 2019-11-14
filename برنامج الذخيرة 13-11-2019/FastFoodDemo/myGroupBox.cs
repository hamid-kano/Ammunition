using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
namespace FastFoodDemo
{
    public partial class GroupBoxTest : Form

    {

        public GroupBoxTest()

        {

            InitializeComponent();

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }


        private void GroupBoxTest_Load(object sender, EventArgs e)

        {

            myGroupBox myGroupBox = new myGroupBox();

            myGroupBox.Text = "GroupBox1";

            myGroupBox.BorderColor = Color.Red;

            this.Controls.Add(myGroupBox);

        }

    }

 

    public class myGroupBox : GroupBox

    {

        private Color borderColor;

 

        public Color BorderColor

        {

            get { return this.borderColor; }

            set { this.borderColor = value; }

        }

 

        public myGroupBox()

        {

            this.borderColor = Color.Black;

        }

 

        protected override void OnPaint(PaintEventArgs e)

        {

            Size tSize = TextRenderer.MeasureText(this.Text, this.Font);

 

            Rectangle borderRect = e.ClipRectangle;

            borderRect.Y += tSize.Height / 2;

            borderRect.Height -= tSize.Height / 2;

            ControlPaint.DrawBorder(e.Graphics, borderRect, this.borderColor, ButtonBorderStyle.Solid);

 

            Rectangle textRect = e.ClipRectangle;

            textRect.X += 6;

            textRect.Width  = tSize.Width;

            textRect.Height = tSize.Height;

            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);

            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRect);

        }

    }
}
