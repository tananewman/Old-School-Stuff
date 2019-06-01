// File Prolog
// Name: Montana Newman
// CS 1400 Section 004
// Project: CS1400_Lab_10
// Date: 10/1/14 12:44:44 PM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;

static class Program
{
    static void Main()
    {
        //Prompt user to enter value for the first side length
        //Store in variable sideLength1
        //Prompt user to enter value for the second side length
        //Parse and store in variable sideLength2
        //Call the method CalcHypotenuse and pass sideLength1 and sideLength2 through it
        //Save the result in variable triangleHypotenuse
        //Print result

        Console.Write("Please enter the first side length: ");
        double sideLength1 = double.Parse(Console.ReadLine());
        Console.Write("Now please enter the second side length: ");
        double sideLength2 = double.Parse(Console.ReadLine());

        //Call the CalcHypotenuse Method
        double triangleHypotenuse = CalcHypotenuse(sideLength1, sideLength2);

        Console.WriteLine("The hypotenuse is {0:F}.", triangleHypotenuse);


        Console.ReadLine();
    }//End Main()

//Hypotenuse Method
//Purpose: Calculating the hypotenuse of a triangle
//Parameters: The two non-hypontenuse side lengths as doubles
//Returns: The hypotenuse (the square root of the sum of each side length squared)

    static double CalcHypotenuse(double side1, double side2)
    {
        //Define variables
        //Perform calculation which takes the square root of side1 * side1 + side2 * side2
        //Store in variable hypotenuse
        //return hypotenuse

        double hypotenuse = Math.Sqrt(side1 * side1 + side2 * side2);
        return hypotenuse;
    }

    
    
}//End class Program

//Questions

//1. You can use methods to break a program into smaller segments.  This makes it easier to write, read, and debug.
//2. We can run different parameters multiple times through the same method, saving of from having to re-write the same code multiple times.
