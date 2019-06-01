// File Prolog
// Name: Montana Newman 
// CS 1400 Section 004
// Project: CS1400_Lab_23
// Date: 11/18/2014 12:44:44 PM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;

static class Program
{
    //------Global Data Members----------
    const int ARRAY_SIZE = 100;
    static int product = 1;
    static int counter = 0;
    static int arrayChecker = 1;    //prevents 0 being stored in the array

    static void Main()
    {
        //-------Local Data Members--------
        int[] myArray = new int[ARRAY_SIZE];
        int arrayProduct = 0;

        //--------Main Loop------------
        while (arrayChecker != 0)
        {
            Console.Write("Please enter an integer greater than 0 to store in the array.\nEnter 0 to terminate: ");
            arrayChecker = int.Parse(Console.ReadLine());

            if (arrayChecker != 0)
            {
                myArray[counter] = arrayChecker;
                counter++;
            }
            else
            {
                break;
            }
        }

        //If else statement to prevent program from display the product as "1" if the "0" is the first number entered.
        if (counter > 0)
        {
            arrayProduct = MultiplyArray(myArray);
            Console.WriteLine("The product of the array is {0}.", arrayProduct);
        }

        else
        {
            Console.WriteLine("Please enter a number greater than 0 next time.");
        }

        Console.ReadLine();
    }//End Main()

    //The MultiplyArray Method
    //Purpose: To multiply the numbers of the array together
    //Parameters: Array object
    //Returns: The product of the numbers in the array
    static int MultiplyArray(int[] someArray)
    {
        for (int i = 0; i < counter; i++)
        {
            product = product * someArray[i];
        }
        return product;
    }
}//End class Program
