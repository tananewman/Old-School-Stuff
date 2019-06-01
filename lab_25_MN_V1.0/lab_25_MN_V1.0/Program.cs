// File Prolog
// Name: Montana Newman 
// CS 1400 Section 002
// Project: CS1400_Lab_25
// Date: 12/4/2014 12:44:44 PM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        //declare global variables
        static int index = 0;
        static int arraySum = 0;
        static int arrayAverage;
        const int ARRAY_SIZE = 50;

        static void Main(string[] args)
        {
            //declare some constants and variables
            int[] scores = new int[ARRAY_SIZE];
            string inputString;     //for checking if the input is null, and breaking the loop if so

            //creat stream reader object with grades file as argument
            StreamReader textFile = new StreamReader("grades.txt");

            //Main Loop to read data from the file, display it, then store it in array scores
            do
            {
                inputString = textFile.ReadLine();
                if (inputString != null)
                {
                    Console.WriteLine(inputString);
                    scores[index] = int.Parse(inputString);
                    index++;
                }
            } while (inputString != null);

            //display average
            Console.WriteLine("The average score is {0}", GetAverageScore(scores));
            Console.ReadLine();

        }
        //The GetAverageScore Method
        //Purpose: Calculate average score of numbers in array
        //Parameters: array object
        //Returns: int for average score
        static int GetAverageScore(int[] pArray)
        {
            for (int i = 0; i < index; i++)
            {
                arraySum = arraySum + pArray[i];
                arrayAverage = arraySum / index;
            }
            return arrayAverage;
        }
    }
}

/*Questions

1) In the default bin/debug folder that your .exe file is located
2) When your input string does't have anything put in to it (inputString == null)
 
 */