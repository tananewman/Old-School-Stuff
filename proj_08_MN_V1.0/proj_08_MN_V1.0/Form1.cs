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
        //a class level reference for Dice class
        private Dice theDice;

        public Form1()
        {
            InitializeComponent();
            //create a new dice object
            theDice = new Dice();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //-------Rolling the Dice----------

            //Clear Text boxes to prepare for roll
            textBox1.Clear();
            textBox2.Clear();
            //delcare and initialize the strings that will be displayed in text box
            string die1str = " ";
            string die2str = " ";
            //rolls the dice!
            theDice.RollDice();     
            //Call GetRoll method (which calls the GenerateString Method)
            theDice.GetRoll(ref die1str, ref die2str);
            //display
            textBox1.Text = die1str;        
            textBox2.Text = die2str;
            
            //--------Boxcars and Snake Eyes-------

            //declare and initialize strings for box cars and snake eyes
            string boxCarStr = " ";
            string snakeEyesStr = " ";
            //Call methods
            theDice.BoxCarTrue(ref boxCarStr);
            theDice.SnakeEyesTrue(ref snakeEyesStr);
            //display
            labelBoxCars.Text = boxCarStr;
            labelSnakeEyes.Text = snakeEyesStr;

        }
        //menu strip exit
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //menu strip about
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Montana Newman\nProject 8\nDice Game\nCS 1400");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
