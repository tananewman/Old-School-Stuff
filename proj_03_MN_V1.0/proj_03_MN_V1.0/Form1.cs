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
        /*Pseudo Code
         1. Declare constants HUN_PART (100), MINS_CONVERT (60), DELAY (1.25)
         2. Get start time and save the value in variable startTime
         3. Divide startTime by const HUN_PART and save it in variable int startHours
         4. Do the modulus operation on startTime by HUN_PART and save it in variable startMins
         5. Multiply startHours by MINS_CONVERT and then add startMins
         6. Save value in variable startTimeInMins
         7. Use the same methods in steps 2-6 but with user input for variable oldEndTime
         8. Save value in oldEndTimeInMins
         9. Subtact oldEndTimeInMins from startTimeInMins
         10. Save value in variable originalDuration
         11. Multiply originalDuration by const DELAY to get new trip length
         12. Cast as int and save in value newDuration
         13. Add newDuration to variable startTimeInMins
         14. Save value in variable newEndTimeInMins
         15. Divide newEndTimeInMins by const MINS_CONVERT
         16. Save value in newEndTimeHours
         17. Module newEndTimeInMins by MINS_CONVERT
         18. Save value in newEndTimeMins
         19. Multiply newEndTimeHours by MINS_CONVERT and add newEndTimeMins
         20. Save value in variable newArrivalTime
         21. Print results
         
         */
        private void button1_Click(object sender, EventArgs e)
        {
            const int HUN_PART = 100;
            const int MINS_CONVERT = 60;
            const double DELAY = 1.25;

            int startTime = int.Parse(OldStartTimeInput.Text);
            int startHours = startTime / HUN_PART;
            int startMins = startTime % HUN_PART;
            int startTimeInMins = startHours * MINS_CONVERT + startMins;

            int oldEndTime = int.Parse(OldEndTimeInput.Text);
            int oldEndHours = oldEndTime / HUN_PART;
            int oldEndMins = oldEndTime % HUN_PART;
            int oldEndTimeInMins = oldEndHours * MINS_CONVERT + oldEndMins;

            int originalDuration = oldEndTimeInMins - startTimeInMins;
            double newDuration = originalDuration * DELAY;

            int newEndTimeInMins = (int)newDuration + startTimeInMins;
            int newEndTimeHours = newEndTimeInMins / MINS_CONVERT;
            int newEndTimeMins = newEndTimeInMins % MINS_CONVERT;
            int newArrivalTime = newEndTimeHours * HUN_PART + newEndTimeMins;

            string newArrivalTimeStr = string.Format("{0}", newArrivalTime);
            NewArrivalOutput.Text = newArrivalTimeStr;
            
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good Guys' Delivery Calc\nProj 3 v1.0\nMontana Newman");
        }
    }
}
