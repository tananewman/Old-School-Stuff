using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Dice
    {
        //the data members of the class
        private int die1;
        private int die2;
        private Random randomRoll;
        static string nL = System.Environment.NewLine;  //make short cut for newline as "nL"
        const int BOX = 6;
        private string[] DIE_FACE = {nL + nL + "  l",       //one
                                        "l" + nL + nL + nL + nL +"    l",       //two
                                        "l" + nL + nL + "  l" + nL + nL + "    l",      //three
                                        " l" + "   l" + nL + nL + nL + nL + " l" + "   l",     //four
                                        " l" + "   l" + nL + nL + "   l" + nL + nL + " l" + "   l",    //five
                                        " l" + "   l" + nL + nL +" l" + "   l" + nL + nL + " l" + "   l" };    //six                                            

        //the default constructor
        //Purpose: It sets all declared variables
        //Parameters: None
        //Returns: None
        public Dice()
        {
            die1 = 0;
            die2 = 0;
            randomRoll = new Random();
        }
        //the RollDice Method
        //Purpose: It generates pseudo-random number between 1 and 6 and assigns to dice variables
        //Parameters: None
        //Returns: None
        public void RollDice()
        {
            die1 = randomRoll.Next(1, BOX + 1);
            die2 = randomRoll.Next(1, BOX + 1);
        }
        //The GetRoll Method
        //Purpose: Assigning strings that were generating from the GenerateString method into others strings that can be used in the from class
        //Parameters: two strings, by reference
        //Returns: None
        public void GetRoll(ref string str1, ref string str2)
        {
            str1 = GenerateString(die1);
            str2 = GenerateString(die2);
        }
        //The GenerateString Method
        //Purpose: Uses the int values assigned to die to choose appropriate option from the string array DIE_FACE
        //Paramters: int
        //Returns: String for what is rolled
        public string GenerateString(int roll)
        {
            return DIE_FACE[roll - 1];
        }
        //the RollBoxCars Method
        //Purpose: Determine if box cars have been rolled
        //Parameters: None
        //Return: Bool
        public bool RollBoxCars()
        {
            if (die1 == BOX && die2 == BOX)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //The BoxCarTrue Method
        //Purpose: Display message if box cars are rolled
        //Parameters: ref string
        //Return: String displaying boxcars or blank
        public void BoxCarTrue(ref string boxStr)
        { 
            bool display = RollBoxCars();
            if(display == true)
            {
                boxStr = "Boxcars!";
            }
            else
            {
                boxStr = " ";
            }
         }
        //The RollSnakeEyes Method
        //Purpose: Determine if snake eyes have been rolleld
        //Parameters: None
        //Return: Bool
        public bool RollSnakeEyes()
        {
            if(die1 == 1 && die2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //The SnakeEyesTrue Method
        //Purpose: Display message if snake eyes are rolled
        //Parameters: ref string
        //Return: String displaying snake eyes or blank
        public string SnakeEyesTrue(ref string snakeStr)
        {
            bool display = RollSnakeEyes();
            if (display == true)
            {
                snakeStr = "Snake Eyes!";
            }
            else
            {
                snakeStr = " ";
            }
            return snakeStr;
        }
    }
}
