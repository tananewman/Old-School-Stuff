using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // a class level reference for right triangle class
        private RightTriangle triangle;
        
        public Form1()
        {
            InitializeComponent();
            // create a new triangle object
            triangle = new RightTriangle();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the two angles from the text boxes
            double side1 = double.Parse(SideATxtBox.Text);
            double side2 = double.Parse(SideBTxtBox.Text);

            //Pass side1 and 2 through SetAngles method in triangle class
            triangle.SetAngles(side1, side2);
            
            //Get hyptonuse and store it
            double hypotenuse = triangle.GetHypotenuse();

            //Get area and store it
            double triArea = triangle.GetArea();
            
            //display
            HypotenuseTxtBox.Text = String.Format("{0:F2}", hypotenuse);
            AreaTxtBox.Text = String.Format("{0:F2}", triArea);
        }
    }
}
