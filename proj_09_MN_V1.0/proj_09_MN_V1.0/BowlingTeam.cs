using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS1400_Program1
{
    class BowlingTeam
    {
        //------The Data Members of the Class-----
        private string userInput;
        //array stuff
        const int ARRAY_SIZE = 75;
        private string[] names = new string[ARRAY_SIZE];
        private int[] scores = new int[ARRAY_SIZE];
        private string[] splitInput = new string[ARRAY_SIZE];   //for storing temporary input after it is first split
        private int index;

        //default contstructor
        //Purpose: It sets all declared variables
        //Parameters: None
        //Returns: None
        public BowlingTeam()
        {
            userInput = "";
            index = 0;
        }

        //The GetUserInput Method
        //Purpose: Gets input from user and saves in a string
        //Parameters: User input as string
        //Returns: user input as string
        public void GetUserInput(string inputStr)
        {
            userInput = inputStr;
        }

        //The AddPlayer Method
        //Purpose: Split user input into names and scores and increment index
        //Parameters: String with user input
        //Returns: None
        public void AddPlayer(string input)
        {
            string[] splitInput = input.Split();
            names[index] = splitInput[0];
            scores[index] = int.Parse(splitInput[1]);
            index++;
        }

        //test
    }
}
