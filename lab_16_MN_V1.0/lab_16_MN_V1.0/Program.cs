// File Prolog
// Name: Montana Newman
// CS 1400 Section 001
// Project: CS1400_Lab_16
// Date: 10/22/14 12:44:44 PM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

// File Prologue
// Name: Bob LazyBones
// CS 1400
// Project: Work?
// Date: September 2014
//

using System;

class Program
{
    static void Main()
    {
        // declare some constants for saturday and sunday
        const string SAT = "Saturday";
        const string SUN = "Sunday";
        int temp;

        // declare a variable to hold user's input
        string today;

        // prompt the user to enter a day and get the input
        Console.Write("Please enter a day of the week, e.g. Tuesday: ");
        today = Console.ReadLine();
      
        // see if it is a work day
        if ((today != SUN && today != SAT))
        {
            // prompt the user to enter the temperature and get the input since it is a work day       
            Console.Write("Thanks!  Now please enter the temperature: ");
            temp = int.Parse(Console.ReadLine());

            if (temp > 32)
                Console.WriteLine("You have to go to work today...");
            else
                Console.WriteLine("You have to go to work today.  Dress warmly!");
        }
        
        else
        {
            // its not a workday, display the weekend message
            Console.WriteLine("Ahh... the weekend. No work!");
        }

        Console.ReadLine();
    }//End Main()
}//End class Program

/*Questions
1)  True
2)  Not enough info without knowing the value of 'x'.
 */