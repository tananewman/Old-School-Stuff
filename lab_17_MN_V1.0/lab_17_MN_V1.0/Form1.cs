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
            groupBox1.Select();
        }       

        private void StdRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            string selectedItem = StdRadioBtn.Text;

            if (StdRadioBtn.Checked)
                MessageBox.Show("You have selected " + selectedItem + " Shipping!");
        }

        private void ExpressRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            string selectedItem = ExpressRadioBtn.Text;

            if (ExpressRadioBtn.Checked)
                MessageBox.Show("You have selected " + selectedItem + " Shipping!");
        }

        private void SameRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            string selectedItem = SameRadioBtn.Text;

            if (SameRadioBtn.Checked)
                MessageBox.Show("You have selected " + selectedItem + " Shipping!");
        }
    }
}
