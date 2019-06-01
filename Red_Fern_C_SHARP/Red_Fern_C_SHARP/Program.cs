using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //-----Constants------
        
        //Surcharges
        const double STD_SURCHARGE = 2.50;
        const double EXPRESS_SURCHARGE = 5.00;
        const double SAME_DAY_SURCHARGE = 8.00;

        //Standard Shipping
        const double STD_PER_ITEM = 3.00;
        const double STD_PER_POUND = 1.45;
        //Express Shipping
        const double EXPRESS_PER_ITEM = 4.00;
        const double EXPRESS_PER_POUND = 2.50;
        //Same Day Shipping
        const double SAME_DAY_PER_ITEM = 5.50;
        const double SAME_DAY_PER_POUND = 3.00; 

        //Shipping options
        const string STD_SPEED = "Standard";
        const string EXPRESS_SPEED = "Express";
        const string SAME_DAY_SPEED = "Same Day";

        //Weight or Quantity 
        const string WEIGHT_STR = "Weight";
        const string QUANTITY_STR = "Quantity";

        //Yes or No strings
        const string YES = "y";
        const string NO = "n";

        static void Main(string[] args)
        {
            //---Variables-------

            //response strings
            string userResponse;
            string responseShippingSpeed;
            string responseSurcharge;
            string responseWeightOrQuantity;

            //numerical variables
            double itemWeight = 1;
            int itemQuantity = 1;
            double shippingCost = 0;
            

            //------Main Program------

            //Greeting
            Console.WriteLine("Welcome to the Red Fern Shipping Calculator!");

            //Intro to loop
            Console.Write("Would you like to ship a parcel?  Please enter a lowercase 'y' or 'n': ");
            userResponse = Console.ReadLine();
            
            //Present error loop if invalid response is entered
            while((userResponse != YES && userResponse != NO))
            {
                Console.Write("Please enter a valid response: ");
                userResponse = Console.ReadLine();
            }

            if (userResponse == YES)
            {
                //Main loop
                do
                {

                    //------Gather Info----------

                    //Prompt user to enter input for shipping speed
                    Console.Write("How fast do you need this package?  Enter either 'Standard', 'Express', or 'Same Day': ");

                    //Get response
                    responseShippingSpeed = Console.ReadLine();

                    //loop for invalid response
                    while ((responseShippingSpeed != STD_SPEED && responseShippingSpeed != EXPRESS_SPEED && responseShippingSpeed != SAME_DAY_SPEED))
                    {
                        Console.Write("Please enter a valid response: ");
                        responseShippingSpeed = Console.ReadLine();
                    }

                    //Ask if there is a surcharge
                    Console.Write("Will this item be shipped to either Alaska or Hawaii?  Please enter a 'y' or 'n': ");
                    responseSurcharge = Console.ReadLine();

                    //loop for invalid response
                    while ((responseSurcharge != YES && responseSurcharge != NO))
                    {
                        Console.Write("Please enter a valid response: ");
                        responseSurcharge = Console.ReadLine();
                    }

                    //Ask if item is being shipped by weight or quantity
                    Console.Write("Will this item be shipped by weight or quantity?  Enter either 'Weight', or 'Quantity': ");
                    responseWeightOrQuantity = Console.ReadLine();

                    //loop for invalid response
                    while ((responseWeightOrQuantity != WEIGHT_STR && responseWeightOrQuantity != QUANTITY_STR))
                    {
                        Console.Write("Please enter a valid response: ");
                        responseWeightOrQuantity = Console.ReadLine();
                    }

                    //If by weight
                    if (responseWeightOrQuantity == WEIGHT_STR)
                    {
                        Console.Write("Please enter the weight (in lbs) of the item: ");
                        itemWeight = double.Parse(Console.ReadLine());

                        //loop for invalid response
                        while (itemWeight <= 0)
                        {
                            Console.Write("Weight must be greater than 0.  Please enter a valid response: ");
                            itemWeight = double.Parse(Console.ReadLine());
                        }
                    }

                    //If by quantity
                    else if (responseWeightOrQuantity == QUANTITY_STR)
                    {
                        Console.Write("Please enter the number of items you are shipping: ");
                        itemQuantity = int.Parse(Console.ReadLine());

                        //loop for invalid response
                        while (itemQuantity <= 0)
                        {
                            Console.Write("Quantity must be greater than 0.  Please enter a valid response: ");
                            itemQuantity = int.Parse(Console.ReadLine());
                        }
                    }

                    //--------Determine/Calculate Charge------------

                    //Standard Shipping possibilities

                    //by item, no sur
                    if (responseShippingSpeed == STD_SPEED && responseWeightOrQuantity == QUANTITY_STR && responseSurcharge == NO)
                    {
                        shippingCost = STD_PER_ITEM * itemQuantity;
                    }

                    //by item, with sur
                    else if (responseShippingSpeed == STD_SPEED && responseWeightOrQuantity == QUANTITY_STR && responseSurcharge == YES)
                    {
                        shippingCost = STD_PER_ITEM * itemQuantity + STD_SURCHARGE;
                    }

                    //by weight, no sur
                    else if (responseShippingSpeed == STD_SPEED && responseWeightOrQuantity == WEIGHT_STR && responseSurcharge == NO)
                    {
                        shippingCost = STD_PER_POUND * itemWeight;
                    }

                    //by weight, with sur
                    else if (responseShippingSpeed == STD_SPEED && responseWeightOrQuantity == WEIGHT_STR && responseSurcharge == YES)
                    {
                        shippingCost = STD_PER_POUND * itemWeight + STD_SURCHARGE;
                    }

                    //Express Shipping possibilities

                    //by item, no sur
                    else if (responseShippingSpeed == EXPRESS_SPEED && responseWeightOrQuantity == QUANTITY_STR && responseSurcharge == NO)
                    {
                        shippingCost = EXPRESS_PER_ITEM * itemQuantity;
                    }

                    //by item, with sur
                    else if (responseShippingSpeed == EXPRESS_SPEED && responseWeightOrQuantity == QUANTITY_STR && responseSurcharge == YES)
                    {
                        shippingCost = EXPRESS_PER_ITEM * itemQuantity + EXPRESS_SURCHARGE;
                    }

                    //by weight, no sur
                    else if (responseShippingSpeed == EXPRESS_SPEED && responseWeightOrQuantity == WEIGHT_STR && responseSurcharge == NO)
                    {
                        shippingCost = EXPRESS_PER_POUND * itemWeight;
                    }

                    //by weight, with sur
                    else if (responseShippingSpeed == EXPRESS_SPEED && responseWeightOrQuantity == WEIGHT_STR && responseSurcharge == YES)
                    {
                        shippingCost = EXPRESS_PER_POUND * itemWeight + EXPRESS_SURCHARGE;
                    }

                    //Same Day Shipping Possibilities

                    //by item, no sur
                    else if (responseShippingSpeed == SAME_DAY_SPEED && responseWeightOrQuantity == QUANTITY_STR && responseSurcharge == NO)
                    {
                        shippingCost = SAME_DAY_PER_ITEM * itemQuantity;
                    }

                    //by item, with sur
                    else if (responseShippingSpeed == SAME_DAY_SPEED && responseWeightOrQuantity == QUANTITY_STR && responseSurcharge == YES)
                    {
                        shippingCost = SAME_DAY_PER_ITEM * itemQuantity + SAME_DAY_SURCHARGE;
                    }

                    //by weight, no sur
                    else if (responseShippingSpeed == SAME_DAY_SPEED && responseWeightOrQuantity == WEIGHT_STR && responseSurcharge == NO)
                    {
                        shippingCost = SAME_DAY_PER_POUND * itemWeight;
                    }

                    //by weight, with sur
                    else if (responseShippingSpeed == SAME_DAY_SPEED && responseWeightOrQuantity == WEIGHT_STR && responseSurcharge == YES)
                    {
                        shippingCost = SAME_DAY_PER_POUND * itemWeight + SAME_DAY_SURCHARGE;
                    }

                    //------Display----------
                    Console.WriteLine("Your shipping cost is {0:C}", shippingCost);

                    Console.Write("Would you like to ship another parcel? Please enter or a 'y' or an 'n': ");
                    userResponse = Console.ReadLine();

                } while (userResponse == YES);
            }

            //Exit prompt
            Console.WriteLine("Thank you, have a great day!");
            Console.ReadLine();     //Hold open console
        }
    }
}
