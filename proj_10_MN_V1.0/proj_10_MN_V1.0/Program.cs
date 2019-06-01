// File Prolog
// Name: Montana Newman 
// CS 1400 Section 004
// Project: CS1400_Proj_10
// Date: 12/2/2014 12:44:44 PM
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
        //create new BowlingTeam Object
        BowlingTeam bowling = new BowlingTeam();
        //variables
        int counter = 0;
        string highScoreName = " ";
        string lowScoreName = " ";
        const int TEAM_LIMIT = 10;

        //-------Main Loop----------
        while (counter < TEAM_LIMIT)
        {
            bowling.DisplayPrompt();
            bowling.SetUserInput(Console.ReadLine());       //Gets user input

            if (bowling.CheckUserInput() == false)      //break if nothing is entered
                break;

            bowling.AddPlayer(bowling.GetUserInput());      //AddPlayer splits input, GetUserInput gets string userInput
            counter++;
        }

        //----------Display---------
        bowling.SortScores(bowling.GetScores(), bowling.GetNames());        //Sorts scores and names

        //Display all players and scores in descending order
        bowling.PrintScores(bowling.GetNames(), bowling.GetScores());
               
        //Display average score
        Console.WriteLine("The average score is {0}.", bowling.GetAverageScore(bowling.GetScores()));

        Console.ReadLine();     //Hold console open

    }//End Main()
}//End class Program

class BowlingTeam
{
    //------The Data Members of the Class-----
    private string userInput;
    //array stuff
    const int ARRAY_SIZE = 10;
    private string[] names = new string[ARRAY_SIZE];
    private int[] scores = new int[ARRAY_SIZE];
    private string[] splitInput = new string[ARRAY_SIZE];   //for storing temporary input after it is first split
    private int index;
    private int highScore = 0;
    private int highName = 0;
    private int lowScore = 1000;
    private int lowName = 0;
    private int arraySum = 0;
    private double averageScore = 0;

    //------Methods------------

    //default contstructor
    //Purpose: It sets all declared variables
    //Parameters: None
    //Returns: None
    public BowlingTeam()
    {
        userInput = "";
        index = 0;
    }

    //DisplayPrompt Method
    //Purpose: Displays a prompt
    //Parameters: None
    //Returns: None
    public void DisplayPrompt()
    {
        Console.Write("Please enter your first name and score seperated by a space: ");
    }
    //The SetUserInput Method
    //Purpose: Sets input from user and saves in a string
    //Parameters: User input as string
    //Returns: None
    public void SetUserInput(string inputStr)
    {
        userInput = inputStr;
    }

    //The GetUserInput Method
    //Purpose: Gets input that user had enter via SetUserInput Method
    //Paramaters: None
    //Returns: User input as string
    public string GetUserInput()
    {
        return userInput;
    }

    //The CheckUserInput Method
    //Purpose: Check to see if user input is empty and if loop should terminate
    //Parameters: None
    //Returns: bool
    public bool CheckUserInput()
    {
        if (GetUserInput() == "")
            return false;
        else
            return true;
    }

    //The AddPlayer Method
    //Purpose: Split user input into names and scores and increments index
    //Parameters: String with user input
    //Returns: None
    public void AddPlayer(string input)
    {
        string[] splitInput = input.Split();
        names[index] = splitInput[0];
        scores[index] = int.Parse(splitInput[1]);
        index++;
    }

    //The PrintResults Method
    //Purpose: Display all of the players' names and scores in descending order and mark perfect game with asterisk
    //Parameters: integer and string arrays
    //Returns: None
    public void PrintScores(string[] namesArray, int[] scoreArray)
    {
        Console.WriteLine("The players scores from highest to lowest are:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(namesArray[i]);

            if (scoreArray[i] == 300)
                Console.WriteLine(" {0}*", scoreArray[i]);

            else
                Console.WriteLine(" {0}", scoreArray[i]);    
        }
    }

    //The GetNames Method
    //Purpose: Get the values stored in the string array holding names
    //Parameters: None
    //Return: String array Object
    public string[] GetNames()
    {
        return names;
    }

    //The GetScores Method
    //Purpose: Get values in int array
    //Parameters: None
    //Return: Int array object

    public int[] GetScores()
    {
        return scores;
    }

    //The GetHighScore Method
    //Purpose: Caculate and display the name and score of the player with the highest score
    //Parameters: None
    //Returns: int
    public int GetHighScore()
    {
        for (int i = 0; i < index; i++)
        {
            int temp = scores[i];

            if (temp > highScore)
            {
                highScore = temp;
                highName = i;
            }
        }
        return highScore;
    }

    //The GetHighScorePlayer Method
    //Purpose: Caculate and display the name and score of the player with the highest score
    //Parameters: None
    //Returns: int
    public int GetHighScorePlayer()
    {
        for (int i = 0; i < index; i++)
        {
            int temp = scores[i];

            if (temp > highScore)
            {
                highScore = temp;
                highName = i;
            }
        }
        return highName;
    }

    //Display HighPlayer
    //Purpose: Generate string to show player with highest score
    //Parameters: string
    //Returns: None
    public void DisplayHighPlayer(ref string str1)
    {
        str1 = names[GetHighScorePlayer()];
    }

    //The GetLowScore Method
    //Purpose: Caculate and display the name and score of the player with the lowest score
    //Parameters: None
    //Returns: int
    public int GetLowScore()
    {
        for (int i = 0; i < index; i++)
        {
            int temp = scores[i];

            if (temp < lowScore)
            {
                lowScore = temp;
                lowName = i;
            }
        }
        return lowScore;
    }

    //The GetLowScorePlayer Method
    //Purpose: Caculate and display the name and score of the player with the lowest score
    //Parameters: None
    //Returns: int
    public int GetLowScorePlayer()
    {
        for (int i = 0; i < index; i++)
        {
            int temp = scores[i];

            if (temp < lowScore)
            {
                lowScore = temp;
                lowName = i;
            }
        }
        return lowName;
    }

    //Display lowPlayer
    //Purpose: Generate string to show player with lowest score
    //Parameters: string
    //Returns: none
    public void DisplayLowPlayer(ref string str1)
    {
        str1 = names[GetLowScorePlayer()];
    }

    //The GetAverageScore Method
    //Purpose: Calculate average score achieved by all bowlers
    //Parameters: array object
    //Returns: double
    public double GetAverageScore(int[] pArray)
    {
        for (int i = 0; i < index; i++)
        {
            arraySum = arraySum + pArray[i];
            averageScore = arraySum / index;
        }
        return averageScore;
    }

    //The SortScores Method
    //Purpose: Sort the scores entered into the scores array from highest to lowest
    //Parameters: int array object for names, and string array object for scores
    //Returns: None
    public void SortScores(int[] sArray, string[] nArray)
    {
        for (int j = 0; j < index - 1; j++)  // index for outer loop is j
        {
            for (int i = 0; i < index - 1; i++)  // index for inner loop is i
            {
                if (sArray[i] < sArray[i + 1])
                {
                    SwapScores(ref sArray[i], ref sArray[i + 1]);

                    SwapNames(ref nArray[i], ref nArray[i + 1]);    //Swaps names to mirror whatever is swapped with the scores
                }
            }
        }
    }

    // The SwapNamesMethod
    //Purpose: The two integer values are swapped
    //Parameters: two integers, passed by reference
    //Returns: none
    static void SwapScores(ref int a, ref int b)
    {
        Console.WriteLine("Swapping {0} and {1}", a, b);
        int temp = a;
        a = b;
        b = temp;
    }

    // The SwapNamesMethod
    //Purpose: The two strings are swapped
    //Parameters: two strings, passed by reference
    //Returns: none
    static void SwapNames(ref string a, ref string b)
    {
        Console.WriteLine("Swapping {0} and {1}", a, b);
        string temp = a;
        a = b;
        b = temp;
    }
}