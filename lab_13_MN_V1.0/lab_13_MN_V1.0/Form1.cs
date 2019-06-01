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
        // a class level reference to a token machine
        private TokenMachine tm;
        
        public Form1()
        {
            InitializeComponent();

            // create a token machine object
            tm = new TokenMachine();
            quartersTxtBox.Select();
            tm.Reset();
        }

        //Method to count quarters and tokens
        private void GetTokenBtn_Click(object sender, EventArgs e)
        {
            tm.GetToken();

            quartersTxtBox.Text = String.Format("{0:d}", tm.CountQuarters());
            tokensTxtBox.Text = String.Format("{0:d}", tm.CountTokens());
            
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Token Machine Program\nMontana Newman\nCS 1400");
        }
        
        //Method to reset the counter
        private void ResetBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void ResetBtn_Click_1(object sender, EventArgs e)
        {
            tm.Reset();
            quartersTxtBox.Text = String.Format("{0:d}", tm.CountQuarters());
            tokensTxtBox.Text = String.Format("{0:d}", tm.CountTokens());
        }
                
    }
}
