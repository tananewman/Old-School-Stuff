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
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DiamOfWheelInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiamOfWheelInputBox_Leave(object sender, EventArgs e)
        {
            //This program will ask the user for the diameter of a wheel and then use this to calculate how many times that wheel must rotate to travel a mile
            //Declare variables as well as constants for PI and INCHESINMILE
            //Ask user for diameter of wheel (via the text box) and store this value in variable float diamOfWheel
            //Multiple diamOfWheel by constant PI to obtain the circumference of the wheel and store it in float variable cirOfWheel
            //Divide constant INCHESINMILE by cirOfWheel and store value in variable rotationsPerMile
            //Display rotationsPerMile in text box TurnsPerMileOutputBox

            const double PI = 3.14;
            const double INCHESINMILE = 63360;
            
            double diamOfWheel = double.Parse(DiamOfWheelInputBox.Text);
            double cirOfWheel = diamOfWheel * PI;
            double rotationsPerMile = INCHESINMILE / cirOfWheel;
            string strRotationsPerMile = string.Format("{0:F2}", rotationsPerMile);

            TurnsPerMileOutputBox.Text = strRotationsPerMile;
                       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This button will clear all data from both input boxes when clicked and move the cursor to the input box.
            TurnsPerMileOutputBox.Clear();
            DiamOfWheelInputBox.Clear();
            DiamOfWheelInputBox.Select();
                                          
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rotations in Mile Calc\nLab 6 v1.0\nMontana Newman");
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
