// File Prolog
// Name: Montana Newman 
// CS 1400 Section 004
// Project: CS1400_Lab_22
// Date: 11/13/2014 12:44:44 PM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;

static class Program
{
    //declare global data members
    const int ARRAY_SIZE = 10;
    static int sum = 0;
    static int counter = 0;

    static void Main()
    {
        //declare data members
        int[] myArray = new int[ARRAY_SIZE];
        int timesRemainingCounter = 10;
        int arraySum = 0;

        do
        {
            Console.Write("Please enter a number to store in the array ({0} times remaining): ", timesRemainingCounter);
            myArray[counter] = int.Parse(Console.ReadLine());
            counter++;
            timesRemainingCounter--;
        } while (counter < ARRAY_SIZE);

        arraySum = AddArray(myArray);
        Console.WriteLine("The sum of the array is {0}.", arraySum);
        
        Console.ReadLine();
    }//End Main()

    //The ArraySum Method
    //Purpose: To add the numbers of the array together
    //Parameters: The numbers in the array object
    //Returns: The sum of the numbers in the array
    static int AddArray(int [] someArray)
    {
        foreach(int value in someArray)
        {
            sum += someArray[value];
        }
        return sum;
    }
}//End class Program

//Question
//1. It can only be used in arrays.  You can't use it for changing elements in an array, only reading.