using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class TokenMachine
    {
        //The data members of the class.
        private int numQuarters;
        private int numTokens;

        //The Default Constructor
        //Purpose: It sets all declared variables
        //Parameters: None
        //Returns: None
        public TokenMachine()
        {
            numQuarters = 0;
            numTokens = 100;
        }
                
        //The GetTokens Method
        //Purpose: To change the amount of tokens and quarters
        //Parameters: None
        //Returns: none
        public void GetToken()
        {
            numTokens--;
            numQuarters++;                       
        }

        //The CountTokens method
        //Purpose: To return the number of tokens of this TokenMachine Object
        //Parameters: None
        //Returns: An integer tokens value
        public int CountTokens()
        {
            return numTokens;
        }

        //TheCountQuarters method
        //Purpose: To return the number of quarters of the TokenMachine object
        //Parameters: None
        //Returns: An integer quarters value
        public int CountQuarters()
        {
            return numQuarters;
        }
        
        //Reset Method
        //Purpose: resets to original values
        //Parameters: none
        //returns: none
        public void Reset()
        {
            numQuarters = 0;
            numTokens = 100;          
        }       
        
    }
}
