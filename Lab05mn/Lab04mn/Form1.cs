// Project: CS1400_Lab_04
// Date: 9/9/2014
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04mn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        // This method is used to exit the window and close the application
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This method is used to display my personal informatin when someone clicks "About"
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Montana Newman\nCS1400\nLab #4");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InTextBox_Leave(object sender, EventArgs e)
        {
            const int DOUBLE = 2;
            int inputNum = int.Parse(InTextBox.Text);
            int halvedNum = inputNum * DOUBLE;
            string outStr = string.Format("{0:D}", halvedNum);
            OutTextBox.Text = outStr;
        }
    }
}


//Question #1:  "{0:C}" would work better to display, because of the C for currency.  You would also need to change the int variable to double.
//  So it would look like this: "double inputNum = double.Parse(InTextBox.Text);" for the first line, etc. where you replace the int variables as "double"
//  You wouldn't need to change the output line (besides the {0:C}) because it is output it as string, regardless of whether it's int or double.
//Question #2:  const int HALF = 2;
//              int inputNum = int.Parse(InTextBox.Text);
//              int halvedNum = inputNum / HALF;
//              string outStr = string.Format("{0:D}", halvedNum);
//              OutTextBox.Text = outStr;