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

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tip Calculator\nProject 1 V1.0\nMontana Newman");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InMealAmount_Leave(object sender, EventArgs e)
        {
            //Declaring Constants
            const double POORSERVICE = .10;
            const double AVGSERVICE = .15;
            const double EXCSERVICE = .20;
           
            //Service Calculation
            double mealAmount = double.Parse(InMealAmountBox.Text);
            double poorServiceTip = mealAmount * POORSERVICE;
            double avgServiceTip = mealAmount * AVGSERVICE;
            double excServiceTip = mealAmount * EXCSERVICE;
            string outStrPoor = string.Format("{0:C}", poorServiceTip);
            string outStrAvg = string.Format("{0:C}", avgServiceTip);
            string outStrExc = string.Format("{0:C}", excServiceTip);
     
            //Service Display
            OutPoorServiceBox.Text = outStrPoor;
            OutAverageServiceBox.Text = outStrAvg; 
            OutExcellentServiceBox.Text = outStrExc;
           

            
        }
    }
}
