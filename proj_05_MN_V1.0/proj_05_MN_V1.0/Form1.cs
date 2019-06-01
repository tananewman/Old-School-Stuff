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
        //a class level reference for SalesInvoice class
        private SalesInvoice invoice;

        public Form1()
        {
            InitializeComponent();
            //create a new invoice object
            invoice = new SalesInvoice();
        }

        private void NumItemsTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get the items quantity and the item price from the user via the text boxes
            int itemsBought = int.Parse(NumItemsTxtBox.Text);
            double priceOfItem = double.Parse(UnitPriceTxtBox.Text);

            //Pass itemsBought through SetQuantity method to store in invoice object
            invoice.SetQuantity(itemsBought);
            //Pass priceOfItem through SetPrice method to store in invoice object
            invoice.SetPrice(priceOfItem);
                        
            //Create a bunch of strings so that I can string them (no pun intended)...
            //...together and display via message box
            string l1 = String.Format("Sales Ticket\n");
            string l2 = String.Format("Quantity: {0} units\n", itemsBought);
            string l3 = String.Format("Unit Price: {0:c} each\n", priceOfItem);
            string l4 = String.Format("----------------------\n");
            string l5 = String.Format("Net Price: {0:c}\n", invoice.GetNet());
            string l6 = String.Format("State Sales Tax: {0:c}\n", invoice.GetStateTax());
            string l7 = String.Format("Local Sales Tax: {0:c}\n", invoice.GetLocalTax());
            string l8 = String.Format("Please pay: {0:c}", invoice.GetFinalPrice());
                        
            //Display the sales ticket via message box by combining strings together
            MessageBox.Show(l1 + l2 + l3 + l4 + l5 + l6 + l7 + l8);                                   
        }
        
        //Exit
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //About box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Montana Newman\nProject 05\nSales Invoice Calc\nCS 1400");
        }

        //Clear Button
        //Clears text boxes and moves cursor to numitems text box
        private void button2_Click(object sender, EventArgs e)
        {
            NumItemsTxtBox.Clear();
            UnitPriceTxtBox.Clear();
            NumItemsTxtBox.Select();
        }
    }
}
