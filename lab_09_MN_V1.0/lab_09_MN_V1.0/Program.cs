// File Prolog
// Name: Montana Newman
// CS 1400 Section 004
// Project: CS1400_Lab_09
// Date: 9/25/14 12:44:44 PM
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
        //Pseudo Code

        
        //1. Declare some variables and constants for later use
        double circleRadius, circleArea, squareWidth, squareLength, squareArea, shadedRegionArea;
                
        //2. Prompt the user to enter the radius of one of the circles (they are all the same)
        Console.Write("Please enter the radius of one of the circles: ");
        
        //3. Store the value in variable named circleRadius
        circleRadius = double.Parse(Console.ReadLine());
        
        //4. Calculate the area of the circle by squaring the radius and multiplying by Pi
        //5. Store this value in variable named circleArea
        circleArea = circleRadius * circleRadius * Math.PI;
        
        //6. Calculate the area of square ABCD
        // a) Add circleRadius to circleRadius 
        // b) Store this value in variable squareWidth
        squareWidth = circleRadius + circleRadius;
        // c) Store this value in variable squareLength
        squareLength = squareWidth;
        // d) Multiply squareWidth by squareLength to find the area of the square.
        // e) Store this value in variable squareArea
        squareArea = squareWidth * squareLength;

        //8. Subract circleArea (since a quarter of circles A, B, C, and D are inside square ABCD, the sum of these areas is the equivelant to the full circle) from squareArea
        //9. Save value in variable shadedRegionArea
        shadedRegionArea = squareArea - circleArea;
        
        //10. Print out shadedRegionArea
        Console.WriteLine("The area of the shaded region is {0:F2}.", shadedRegionArea);
        
        Console.ReadLine();
    }//End Main()
}//End class Program
