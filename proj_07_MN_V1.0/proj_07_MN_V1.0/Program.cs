// File Prolog
// Name: Montana Newman
// CS 1400 Section 004
// Project: CS1400_project_07
// Date: 11/7/14 12:44:44 PM
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
        //Data Members 
        //---------------
        //total
        int total;
        //adult rabit variables
        int adultPrevious = 1;
        int adultNext = 1;
        int adultCurrent = 0;
        //baby rabbit variables
        int babyPrevious = 0;
        int babyNext = 1;
        int babyCurrent = 0;
        //constants
        const int MAX_CAGES = 500;
        const int MONTH_LIMIT = 24;

        //Display intro
        Console.WriteLine("Population of rabbits");
        Console.WriteLine("Month\tAdults\tBabies\tTotal");

        //Main loop to calculate rabbits
        for (int i = 1; i < MONTH_LIMIT; i++)
        {
            //adults
            adultCurrent = adultPrevious;
            adultPrevious = adultNext;
            adultNext = adultCurrent + adultNext;

            //babies           
            babyCurrent = babyPrevious;
            babyPrevious = babyNext;
            babyNext = babyCurrent + babyNext;

            //total
            total = adultCurrent + babyCurrent;
            
            //Display table
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", i, adultCurrent, babyCurrent, total);

            //Display max cages and end loop
            if (total > MAX_CAGES)
            {
                Console.Write("You will run out of cages after {0} months.", i);
                break;
            }
        }

        Console.ReadLine();
    }//End Main()
}//End class Program