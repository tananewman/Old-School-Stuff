using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ShippingCalc
    {
        //the data members of the class
        double itemVariable;        
        const double STD_RATE_ITEM = 3.00;
        const double STD_RATE_WEIGHT = 1.45;
        const double STD_SUR_RATE = 2.50;
        const double EX_RATE_WEIGHT = 2.50;
        const double EX_SUR_RATE = 5.00;
        const double EX_RATE_ITEM = 4.00;
        const double SAME_RATE_ITEM = 5.50;
        const double SAME_RATE_WEIGHT = 3.00;
        const double SAME_SUR_RATE = 8.00;
        
        //the default constructor
        //Purpose: It sets all declared variables
        //Parameters: None
        //Returns: None
        public ShippingCalc()
        {
            itemVariable = 0;
            
        }

        //The SetItemVariable Method
        //Purpose: It sets declared variable quantity to items passed in
        //Parameters: variable passed in as int
        //Returns: None
        public void SetItemVariable(double p1)
        {
            //Stores the parameter in the corresponding data member
            itemVariable = p1;
        }

        //The GetStdQuantityShip Method
        //Purpose: To calculate and return the shipping cost of item if it is quantity and no surcharge
        //Parameters: None
        //Returns: Shipping cost as double
        public double GetStdQuantityShip()
        {
            double shippingCost = itemVariable * STD_RATE_ITEM;
            return shippingCost;
        }

        //The GetStdQuantityShipSur Method
        //Purpose: To calculate and return the shipping cost of item if it is quantity and with surcharge
        //Parameters: None
        //Returns: Shipping cost as double
        public double GetStdQuantityShipSur()
        {
            double shippingCost = itemVariable * STD_RATE_ITEM + STD_SUR_RATE;
            return shippingCost;
        }

        //The GetStdWeightShip Method
        //Purpose: To calculate and return the shipping cost of item if it is by weight and no surcharge
        //Parameters: None
        //Returns: Shipping cost as double
        public double GetStdWeightShip()
        {
            double shippingCost = itemVariable * STD_RATE_WEIGHT;
            return shippingCost;
        }

        //The GetStdWeightShipSur Method
        //Purpose: To calculate and return the shipping cost of item if it is by weight and no surcharge
        //Parameters: None
        //Returns: Shipping cost as double
        public double GetStdWeightShipSur()
        {
            double shippingCost = itemVariable * STD_RATE_WEIGHT + STD_SUR_RATE;
            return shippingCost;
        }

        //the GetExpressWeight Method
        //Purpose: To calculate and return the express shipping cost of item if it is by weight and no surcharge
        //Parameters: None
        //Returns: Shipping cost as double
        public double GetExpressWeight()
        {
            double shippingCost = itemVariable * EX_RATE_WEIGHT;
            return shippingCost;
        }

        //the GetExpressWeightSur Method
        //Purpose: To calculate and return the express shipping cost of item if it is by weight and surcharge
        //Parameters: None
        //Returns: Shipping cost as double
        public double GetExpressWeightSur()
        {
            double shippingCost = itemVariable * EX_RATE_WEIGHT + EX_SUR_RATE;
            return shippingCost;
        }

        //The GetExpressItem Method
        //Purpose: To calculate and return the express shipping cost of item if it is by item
        //Parameters: None
        //Returns: Shipping cost as double
        public double GetExpressItem()
        {
            double shippingCost = itemVariable * EX_RATE_ITEM;
            return shippingCost;
        }

        //The GetExpressItemSur Method
        //Purpose: To calculate and return the express shipping cost of item if it is by item with sur
        //Parameters: None
        //Returns: Shipping cost as double
        public double GetExpressItemSur()
        {
            double shippingCost = itemVariable * EX_RATE_ITEM + EX_SUR_RATE;
            return shippingCost;
        }

        //The GetSameItem Method
        //Purpose: To calculate and return the same-day shipping cost of item if it is by item
        //Parameters: None
        //Returns: Shipping cost as double
        public double GetSameItem()
        {
            double shippingCost = itemVariable * SAME_RATE_ITEM;
            return shippingCost;
        }

        //The GetSameItemSur Method
        //Purpose: To calculate and return the same-day shipping cost of item if it is by item
        //Parameters: None
        //Returns: Shipping cost as double
        public double GetSameItemSur()
        {
            double shippingCost = itemVariable * SAME_RATE_ITEM + SAME_SUR_RATE;
            return shippingCost;
        }

        //The GetSameWeight Method
        //Purpose: To calculate and return the same-day shipping cost of item if it is by weight with sur
        //Parameters: None
        //Returns: Shipping cost as double
        public double GetSameWeight()
        {
            double shippingCost = itemVariable * SAME_RATE_WEIGHT;
            return shippingCost;
        }

        //The GetSameWeightSur Method
        //Purpose: To calculate and return the same-day shipping cost of item if it is by weight with sur
        //Parameters: None
        //Returns: Shipping cost as double
        public double GetSameWeightSur()
        {
            double shippingCost = itemVariable * SAME_RATE_WEIGHT + SAME_SUR_RATE;
            return shippingCost;
        }
    }
}
