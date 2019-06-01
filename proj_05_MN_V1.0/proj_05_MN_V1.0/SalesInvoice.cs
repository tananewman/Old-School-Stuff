using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class SalesInvoice
    {
        //The data members of the class
        private int itemsSold;
        private double itemPrice;
        private const double STATE_TAX_RATE = .0745;
        private const double LOCAL_TAX_RATE = .025;
        private const double STATE_TAX_RATE_PURCHASE = 1.0745;
        private const double LOCAL_TAX_RATE_PURCHASE = 1.025;

        //The default constructor
        //Purpose: It sets all declared variables
        //Parameters: None
        //Returns: None
        public SalesInvoice()
        {
            itemsSold = 0;
            itemPrice = 0;
        }

        //The SetQuantity Method
        //Purpose: It sets declared variable quantity to items passed in
        //Parameters: variable passed in as int
        //Returns: None
        public void SetQuantity(int p1)
        {
            //Stores the parameter in the corresponding data member
            itemsSold = p1;
        }

        //The SetPrice Method
        //Purpose: It sets declared variable price to item passed in
        //Parameters: variable passed in as double
        //Returns: None
        public void SetPrice(double p1)
        {
            //Stores the parameter in corresponding data member
            itemPrice = p1;
        }

        //The GetNet Method
        //Purpose: To calculate and return the net price for the items purchased
        //Parameters: None
        //Returns: The net price as double
        public double GetNet()
        {
            double netPrice = itemPrice * itemsSold;
            return netPrice;
        }

        //The StateTax Method
        //Purpose: To calculate and return the state sales tax for the items purchased
        //Parameters: none
        //Returns: the state sales tax as double
        public double GetStateTax()
        {
            double stateTax = itemsSold * itemPrice * STATE_TAX_RATE;
            return stateTax;
        }

        //The GetLocalTax Method
        //Purpose: to calc and return the local sales tax for the items purchased
        //Parameters: none
        //Returns: the local tax as double
        public double GetLocalTax()
        {
            double localTax = itemPrice * itemsSold * LOCAL_TAX_RATE;
            return localTax;
        }

        //The GetFinalPrice Method
        //Purpose: To calculate the final gross price cust has to pay and return it as double
        //Parameters: none
        //Returns: the final price as double
        public double GetFinalPrice()
        {
            double finalPrice = itemsSold * itemPrice * LOCAL_TAX_RATE_PURCHASE * STATE_TAX_RATE_PURCHASE;
            return finalPrice;
        }      
    }
}
