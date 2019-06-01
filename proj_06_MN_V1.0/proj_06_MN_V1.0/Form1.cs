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
        //a class level reference for ShippingCalc class
        private ShippingCalc shipping;
        double shippingTotal;
        
        public Form1()
        {
            InitializeComponent();
            //Stop it from annoyingly auto-selecting quantity
            groupBox1.Select();
            //create a new shipping object
            shipping = new ShippingCalc();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {                      
            //Get item quantity/weight from text box
            double itemModifier = double.Parse(InputBxQuantity.Text);
            // Store in shipping object
            shipping.SetItemVariable(itemModifier);

            //Case where standard shipping and quantity are selected           
            if(RadioBtnStd.Checked && RadioBtnQuantity.Checked)
            {
                if(RadioBtnNo.Checked)
                    shippingTotal = shipping.GetStdQuantityShip();
                else if (RadioBtnYes.Checked)
                    shippingTotal = shipping.GetStdQuantityShipSur();

                //Format to string
                string shippingStr = string.Format("{0:C}", shippingTotal);

                //Display
                MessageBox.Show("Your shipping cost is " + shippingStr + ".");
            }
            
            //Case where standard shipping and weight are selected
            else if (RadioBtnStd.Checked && RadioBtnWeight.Checked)
            {
                if (RadioBtnNo.Checked)
                    shippingTotal = shipping.GetStdWeightShip();
                else if (RadioBtnYes.Checked)
                    shippingTotal = shipping.GetStdWeightShipSur();

                //Format to string
                string shippingStr = string.Format("{0:C}", shippingTotal);

                //Display
                MessageBox.Show("Your shipping cost is " + shippingStr + ".");
            }

            //Case where express shipping and item are selected
            else if (RadioBtnExpress.Checked && RadioBtnQuantity.Checked)
            {
                if (RadioBtnNo.Checked)
                    shippingTotal = shipping.GetExpressItem();
                else if (RadioBtnYes.Checked)
                    shippingTotal = shipping.GetExpressItemSur();

                //Format to string
                string shippingStr = string.Format("{0:C}", shippingTotal);

                //Display
                MessageBox.Show("Your shipping cost is " + shippingStr + ".");
            }

            //Case where express shipping and weight are selected
            else if (RadioBtnExpress.Checked && RadioBtnWeight.Checked)
            {
                if (RadioBtnNo.Checked)
                    shippingTotal = shipping.GetExpressWeight();
                else if (RadioBtnYes.Checked)
                    shippingTotal = shipping.GetExpressWeightSur();

                //Format to string
                string shippingStr = string.Format("{0:C}", shippingTotal);

                //Display
                MessageBox.Show("Your shipping cost is " + shippingStr + ".");
            }

            //Case where same-day shipping and quantity are selected
            else if (RadioBtnSame.Checked && RadioBtnQuantity.Checked)
            {
                if (RadioBtnNo.Checked)
                    shippingTotal = shipping.GetSameItem();
                else if (RadioBtnYes.Checked)
                    shippingTotal = shipping.GetSameItemSur();

                //Format to string
                string shippingStr = string.Format("{0:C}", shippingTotal);

                //Display
                MessageBox.Show("Your shipping cost is " + shippingStr + ".");
            }

            //Case where same-day shipping and weight are selected
            else if (RadioBtnSame.Checked && RadioBtnWeight.Checked)
            {
                if (RadioBtnNo.Checked)
                    shippingTotal = shipping.GetSameWeight();
                else if (RadioBtnYes.Checked)
                    shippingTotal = shipping.GetSameWeightSur();

                //Format to string
                string shippingStr = string.Format("{0:C}", shippingTotal);

                //Display
                MessageBox.Show("Your shipping cost is " + shippingStr + ".");
            }

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CS 1400 Project 6\nMontana Newman\nFern Shipping Calculator");
        }
    }
}
