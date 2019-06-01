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
    public partial class TriangleCalc : Form
    {
        //Const for converting variable from degrees to radians
        const double DEGREES_TO_RADIANS = 180;

        public TriangleCalc()
        {
            InitializeComponent();
        }
        //The Law of Cosines Triangle Method
        //Purpose: Use 2 sides and angle to calculate the remaining side
        //Parameters:  2 sides of a triangle and the angle in between
        //Returns: Length of side opposite to angle given

        static double LawOfCosineMethod(double side1, double side2, double angle1)
        {
            //Law of Cosines: c^2 = a^2 + b^2 - 2abCos (C)
            //c == angle c, a == side 1, b == side2
        
            double side3 = Math.Sqrt(side1 * side1 + side2 * side2 - (2 * side1 * side2 * Math.Cos(angle1)));
            return side3;
        }

           private void SideAInBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get input from user
            //Store the input (2 sides and an angle) in variables
            //Call the method and pass parameters through it
            //Return value and save it
            //display it

            double sideA = double.Parse(SideAInBox.Text);
            double sideB = double.Parse(SideBInBox.Text);
            double angleC = double.Parse(AngleCInBox.Text);
            double angleCRadians = angleC * Math.PI / DEGREES_TO_RADIANS;
                                   
            //Call Law of Cosine Method
            double sideC = LawOfCosineMethod(sideA, sideB, angleCRadians);

            //Display
            string sideCStr = string.Format("{0:F}", sideC);
            SideCOutBox.Text = sideCStr;

        }

        private void AngleCInBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SideBInBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SideAInBox.Clear();
            SideBInBox.Clear();
            AngleCInBox.Clear();
            SideCOutBox.Clear();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Law of Cosine Calc\nProject 4 v1.0\nMontana Newman");
        }
    }
}
