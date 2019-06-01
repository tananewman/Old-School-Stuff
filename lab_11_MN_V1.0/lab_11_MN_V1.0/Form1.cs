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
        //Hypotenuse Method
        //Purpose: Calculating the hypotenuse of a triangle
        //Parameters: The two non-hypontenuse side lengths as doubles
        //Returns: The hypotenuse (the square root of the sum of each side length squared)

        static double CalcHypotenuse(double side1, double side2)
        {
            //Define variables
            //Perform calculation which takes the square root of side1 * side1 + side2 * side2
            //Store in variable hypotenuse
            //return hypotenuse

            double hypotenuse = Math.Sqrt(side1 * side1 + side2 * side2);
            return hypotenuse;
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HypotenuseButton_Click(object sender, EventArgs e)
        {
            
           //Get the values in the two TextBoxes.
           //Convert the values to doubles.
           //Call the method I wrote to calculate the hypotenuse of the triangle.
           //Display the result in the third TextBox. 
            
            double sideA = double.Parse(SideAInputBox.Text);
            double sideB = double.Parse(SideBInputBox.Text);

            //Call the CalcHypotenuse method

            double triangleHypotenuse = CalcHypotenuse(sideA, sideB);

            //Convert double to string

            string triangleHypotenuseStr = string.Format("{0:F}", triangleHypotenuse);

            //Print
            HypotenuseOutputBox.Text = triangleHypotenuseStr;
              
        }

        private void exitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hypotenuse Calc\nLab 11 v1.0\nMontana Newman");
        }
    }
}
