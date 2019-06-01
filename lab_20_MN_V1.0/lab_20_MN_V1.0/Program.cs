// File Prolog
// Name: Montana Newman
// CS 1400 Section xxx
// Project: CS1400_Lab_20
// Date: 11/11/2014 12:44:44 PM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
using System;

class Program
{
    static void Main()
    {
        int number1 = 10;
        int number2 = 15;

        // call the Swap method and output the result
        Swap(ref number1, ref number2);
        Console.WriteLine("number1 = {0}", number1);
        Console.WriteLine("number2 = {0}", number2);

        Console.ReadLine();
    }

    // The Swap method
    // Purpose: To interchange the value of two variables
    // Parameters: two integers
    // Returns: None
    // Pre-conditions: None
    // Post-conditions: None
    // Side Effect: the values of the 2 integers are swapped

    static void Swap(ref int n1, ref int n2)
    {
        int temp = n1;
        n1 = n2;
        n2 = temp;

    }
}

//Questions
//1. There were copies of the variables made and it changed the copies, but not the original variables.  
//2. When you want to change the original variables, such as in this program, or when you need to pass an array object.