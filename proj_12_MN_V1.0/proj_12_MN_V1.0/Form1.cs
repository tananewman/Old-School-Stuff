using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //--------Data Members-------

        //Constants
        const int MAX_SIZE = 10;        //Max size of array of employee objects
        const int NUM_EMPLOYEES = 6;    //Number of employees at fluffleshuffle

        //Create array of employee objects
        Employee[] employee = new Employee[MAX_SIZE];

        //variables to pass to constructor
        private string employeeNumStr;
        private string employeeNameStr;
        private string employeeAddressStr;
        private string employeePayDataStr;

        //Global variables
        private StreamReader data;
        private Stream myStream;
        private int counter = 0;

        public Form1()
        {
            InitializeComponent();
            this.Select();      //I don't want the cursor to blink in the first text box
        }

        //Opens Text File and check for validity        
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "text files (*.txt)|*txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    data = new StreamReader(myStream);

                    //set values to null when opened
                    employeeNameStr = null;
                    employeeAddressStr = null;
                    employeeNumStr = null;
                    employeePayDataStr = null;
                }
            }
        }

        //About Strip
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Final Project\nMontana Newman\nCS1400\nV1.0");
        }

        //Exit strip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter < NUM_EMPLOYEES)
            {

                //initialize strings and pass to employee object via constructor
                employeeNumStr = data.ReadLine();
                employeeNameStr = data.ReadLine();
                employeeAddressStr = data.ReadLine();
                employeePayDataStr = data.ReadLine();

                //null exception
                if (employeeNumStr == null)
                {
                    MessageBox.Show("Null exception.  Sorry, this program will now terminate. Later!");
                    this.Close();
                }

                else
                {
                    employee[counter] = new Employee(ref employeeNumStr, ref employeeNameStr, ref employeeAddressStr, ref employeePayDataStr);    //Pass data to new employee object


                    //Display
                    textBoxName.Text = employee[counter].GetEmployeeName();
                    textBoxAddress.Text = employee[counter].GetEmployeeAddress();
                    textBoxNetPay.Text = employee[counter].GetNetPay();

                    counter++;
                }
            }
            //Disable button when number of employees at company has been reached
            else
            {
                textBoxName.Clear();
                textBoxAddress.Clear();
                textBoxNetPay.Clear();
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button1.Enabled == false)
            {
                textBoxName.Text = employee[2].GetEmployeeName();
                textBoxAddress.Text = employee[2].GetEmployeeAddress();
                textBoxNetPay.Text = employee[2].GetNetPay();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBoxName.Clear();
            textBoxAddress.Clear();
            textBoxNetPay.Clear();
            counter = 0;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            counter--;
                textBoxName.Text = employee[counter-1].GetEmployeeName();
                textBoxAddress.Text = employee[counter-1].GetEmployeeAddress();
                textBoxNetPay.Text = employee[counter-1].GetNetPay();        
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
                textBoxName.Text = employee[2].GetEmployeeName();
                textBoxAddress.Text = employee[2].GetEmployeeAddress();
                textBoxNetPay.Text = employee[2].GetNetPay();           
        }
    }
}
