// File Prolog
// Name: Montana Newman
// CS 1400 Section 001
// Project: CS1400_Lab_19
// Date: 10/30/14 12:44:44 PM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
using System;

static class Program
{
    //Declare constants    
    const int DIE_MAX = 7;

    static void Main()
    {
        //declard some variables
        int die1;
        int die2;
        char response;

        //Create random num generator object
        Random randomNums = new Random(); 

        Console.Write("Would you like to roll the dice? Please enter a Y or N: ");
        response = char.Parse(Console.ReadLine());
        response = char.ToLower(response);

        while (response != 'n')
        {
            while (response != 'y' && response != 'n')
            {
                Console.Write("Invalid response, please enter y or n: ");
                response = char.Parse(Console.ReadLine());
                response = char.ToLower(response);
            }
            while (response == 'y')
            {
                //Roll dice and store values
                die1 = randomNums.Next(1, DIE_MAX);
                die2 = randomNums.Next(1, DIE_MAX);

                if (die1 == 1 || die1 == 6)
                {
                    if (die1 == 6 && die2 == 6)
                    {
                        Console.WriteLine("You rolled box cars!  Congrats!");
                    }
                    else if (die1 == 1 && die2 == 1)
                    {
                        Console.WriteLine("Oh no!  You rolled snake eyes!");
                    }
                    else
                    {
                        Console.WriteLine("You rolled a {0} and a {1}!", die1, die2);
                    }
                }
                else
                {
                    Console.WriteLine("You rolled a {0} and a {1}!", die1, die2);
                }

                Console.Write("Would you like to roll the dice? Please enter a Y or N: ");
                response = char.Parse(Console.ReadLine());
                response = char.ToLower(response);
            }
        }
            Console.WriteLine("You're no fun!  Bye.");

            Console.ReadLine();
        
    }
}//End class Program




