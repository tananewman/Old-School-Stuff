// File Prolog
// Name: Montana Newman
// CS 1400 Section 001
// Project: CS1400_Lab_03
// Date: 9/5/2014
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
//Just declaring some variables for later use in the program
        string name;
        int age;
        int ageOnNextBirthdayNumber = 1;
        double money;

        Console.Write("Hello, my name is Hal.  ");
        Console.Write("Please enter your name here: ");
        name = Console.ReadLine();
       
        Console.Write("Hello {0}, how old are you? ", name);

        //It took me a while to remember we had to Parse it even though we reviewed it in class!
        age = int.Parse(Console.ReadLine() );
        age = age + ageOnNextBirthdayNumber;

        Console.Write("How much money do you have, {0}? ", name);
        money = double.Parse(Console.ReadLine() );

        Console.Write("Thanks {0}.  You will be {1} years old on your next birthday, and you have {2:c} saved up!", name, age, money);

       
        //Keeping console screen open             
        Console.ReadLine();
    }//End Main()
}//End class Program

//Answer to the questions
//Question #1:  I chose the int data type for the age variable.  No one answers and says "I am 23.75" when they turn 24 in three months.  Age is almost always represented by an integer.
//Question #2:  The {2:c} has a "c", which stands for currency.  When output, it displays a dollar sign, which is obviously more descriptive.
