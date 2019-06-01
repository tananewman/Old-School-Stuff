// File Prolog
// Name: Montana Newman
// CS 1400 Section xxx
// Project: CS1400_Proj_11
// Date: 12/9/2014 12:44:44 PM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.IO;

static class Program
{
    static void Main()
    {
        //New resistor object
        Resistors resistor = new Resistors();
 
        resistor.SetResistanceAndMax();     //Parse and splits resistance and max

        resistor.SetVoltage();      //Calcs voltage  

        resistor.CalcPwrDis();      //Calculates Power Dissipation 

        resistor.PrintTable();      //Displays table

        Console.ReadLine();
    }//End Main()
}//End class Program

class Resistors
{
    //-----The Data Members of the Class-----
    const int ARRAY_SIZE = 50;
    private string environment;
    private string fileNameInput;
    private string path;
    public string yesStr = "yes";
    public string noStr = "no";
    private int index;
    private int pwrIndex = 0;
    private double maxPower;
    private double resistance;
    private double passFail;
    private string powerAndResist;
    private string voltageStr;
    private double[] voltage = new double[ARRAY_SIZE];
    private double[] pwrDis = new double[ARRAY_SIZE];
   

    private StreamReader textFile;     //new object

    //------Methods------------

    //default contstructor
    //Purpose: It sets all declared variables, asks for path and creates new stream reader object with that path
    //Parameters: None
    //Returns: None
    public Resistors()
    {
        Console.WriteLine("Resistor Test Program");
        Console.Write("Please enter the file name: ");

        // This line of code gets the path to the My Documents Folder
        environment = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "\\";

        fileNameInput = Console.ReadLine();
        path = environment + fileNameInput;

        textFile = new StreamReader(path);
    }

    //The GetPath Method
    //Purpose: returns path as string
    //Parameters: None
    //Returns: None
    public string GetPath()
    {
        return path;
    }

    //The SetResistanceAndMaxPower Method
    //Purpose: Read the first line in the text and split it into resistance and max power
    //Parameters: None
    //Returns: None
    public void SetResistanceAndMax()
    {
        powerAndResist = textFile.ReadLine();
        string[] splitInput = powerAndResist.Split();
        resistance = double.Parse(splitInput[0]);
        maxPower = double.Parse(splitInput[1]);
    }

    //The GetResistance Method
    //Purpose: get resistance stored in double
    //Parameters: None
    //Returns: None
    public double GetResistance()
    {
        return resistance;
    }

    //The GetMaxPower Method
    //Purpose: get max power stored in double
    //Parameters: None
    //Returns: None
    public double GetMaxPower()
    {
        return maxPower;
    }

    //The SetVoltage Method
    //Purpose: read voltage from text file and store them in voltage array
    //Parameters: none
    //Returns: None
    public void SetVoltage()
    {
        do
        {
            voltageStr = textFile.ReadLine();
            if (voltageStr != null && voltageStr != powerAndResist)
            {
                voltage[index] = double.Parse(voltageStr);
                index++;
            }
        } while (voltageStr != null);
    }

    //The Display voltage method
    //Purpose: Displays voltage
    //Parameters: None
    //Returns: None
    public void PrintVoltage()
    {
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine("{0}", voltage[i]);
        }     
    }

    //The Display pwrDis method
    //Purpose: Displays power dis
    //Parameters: None
    //Returns: None
    public void PrintPwrDis()
    {
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine("{0}", pwrDis[i]);
        }
    }

    //The CalcPowerDissapation Method
    //Purpose: Use the voltage and resistance to calculate power of resistors
    //Parameters: None
    //Returns: None
    public void CalcPwrDis()
    {
        for(int i = 0; i < index; i++)
        {
            pwrDis[pwrIndex] = (voltage[pwrIndex] * voltage[pwrIndex]) / resistance;
            pwrIndex++;
        }
    }

    //The PassOrFail Method
    //Purpose: Test whether or not the resistors pass or fail
    //Parameters: None
    //Returns: string
    public string PassOrFail()
    {
        for(int i = 0; i < index; i++)
        {
            passFail = pwrDis[i];

        }

        if (passFail < maxPower)
            return noStr;
        else
            return yesStr;
    }
    
    //PrintTable method
    //Purpose: Print table
    //Purpose: Print the table--finally
    //Parameters: none
    //Returns: None
    public void PrintTable()
    {
        Console.WriteLine("Resistor #\tDissipation\tPassed");
        for(int i = 0; i < index; i++)
        {
        Console.Write("{0}\t\t{1}\t\t", i + 1, pwrDis[i]);
        if (pwrDis[i] < maxPower)
            Console.WriteLine("No");
        else
            Console.WriteLine("Yes");
        }
    }
}