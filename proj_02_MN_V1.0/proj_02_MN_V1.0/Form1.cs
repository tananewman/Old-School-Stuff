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
    public partial class PirateWindow : Form
    {
        public PirateWindow()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NumOfPiratesInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void SplitGoldButton_Click(object sender, EventArgs e)
        {
            //Pseudo Code
            
            //Declare constants
            //Ask user for number of pirates and store it in numOfCrew - 2
            //Ask user for amount of gold and store it in variable goldCoins
            //Subtract 3 * the numOfCrew from goldCoins
            //Calculate Captains gold by taking goldCoins and multiplying by constant rate for Captain
            //Store in goldCoins and display
            //Calc mate's gold by taking remaining gold and multiplying by constant rate for mate.  Display and store remaining in goldCoins
            //Divide goldCoins by numOfCrew and display
            //Use modulus to calculate remainder (if applicable) and display
            //Done!!


            const double CAPTAINS_CUT_RATE = .12;
            const double MATES_CUT_RATE = .08;
            const int PARTY_MONEY_FOR_CREW = 3;
            const int CAPTAIN_AND_MATE = 2;

            int goldCoins = int.Parse(NumOfGoldInput.Text);
            int numOfCrew = int.Parse(NumOfPiratesInput.Text);
            int numOfRegCrew = numOfCrew - CAPTAIN_AND_MATE;
            
            goldCoins = goldCoins - PARTY_MONEY_FOR_CREW * numOfRegCrew;

            string goldCoinsStr = string.Format("{0}", goldCoins);
            JacksShareTextBox.Text = goldCoinsStr;
                        
            double captainsCut = CAPTAINS_CUT_RATE * goldCoins;
            string captsCutStr = string.Format("{0}", (int)captainsCut);
            JacksShareTextBox.Text = captsCutStr;
            
            goldCoins = goldCoins - (int)captainsCut;
            double matesCut = MATES_CUT_RATE * goldCoins;
            string matesCutStr = string.Format("{0}", (int)matesCut);
            MatesShareTextBox.Text = matesCutStr;

            goldCoins = goldCoins - (int)matesCut;
            int regCrewCut = (int)goldCoins / numOfCrew;
            string regCrewCutStr = string.Format("{0}", (int)regCrewCut);
            CrewShareTextBox.Text = regCrewCutStr;

            int benevFundCut = goldCoins % numOfCrew;
            string benevFundCutStr = string.Format("{0}", benevFundCut);
            PiratesBenevTextBox.Text = benevFundCutStr;
            
              
         
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pirate CalculatARRRR\nProj 2 v1.0\nMontana Newman");
        }
    }
}
