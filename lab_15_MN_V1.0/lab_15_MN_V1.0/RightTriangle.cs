using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class RightTriangle
    {
        //The data members of the class
        private double sideA = 0;
        private double sideB = 0;
        private const int TRIANGLE_AREA = 2;
        
        //The default constructor
        //Purpose: It sets all declared variables
        //Parameters: None
        //Returns: None
        public RightTriangle()
        {
            sideA = 0;
            sideB = 0;            
        }

        //The SetAngles
        //Purpose: it sets all declared variables to the values passed in
        //Parameters: doubles for the triangle (sides)
        //Returns: none
        public void SetAngles(double p1, double p2)
        {
            //stores the parameter in the corresponding data member
            sideA = p1;
            sideB = p2;
        }       
        
        //The Get Hypotenuse Method
        //Purpose: Calc and return double sideC (the hypotenuse)
        //Parameters: none
        //Returns: sideC as double
        public double GetHypotenuse()
        {
            double sideC = Math.Sqrt(sideA * sideA + sideB * sideB);
            return sideC;
        }

        //The GetArea Method
        //Purpose: Calc and return the area of the triangle
        //Parameters: None
        //Returns: Area as double
        public double GetArea()
        {
            double area = (sideA * sideB) / TRIANGLE_AREA;
            return area;
        }
    }
}
