// File Prolog
// Name: Montana Newman
// CS 1400 Section 002
// Project: CS1400_Lab_27
// Date: 12/16/2014 12:44:44 PM
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
    //Declare const
    const int MAX = 10;

    static void Main()
    {
        //Declare some variables
        int count = 0;
        string inputLine = "";

        //Create array of box object
        Box[] boxes = new Box[MAX];

        //Create enviroment for My Documents folder
        string environment = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + 
        "\\" + "boxes.txt";

        //Create new StreamReader object from MyDocuments folder
        StreamReader boxesInfo = new StreamReader(environment);

        //Main loop
        do
        {
            inputLine = boxesInfo.ReadLine();

            if (inputLine != null && count < MAX)
            {
                string[] data = inputLine.Split();

                int dataH = int.Parse(data[0]);
                int dataW = int.Parse(data[1]);
                int dataD = int.Parse(data[2]);

                //Store parsed box specifications inside newly created box object, then increment
                //so that it creates and stores in different box object next time.  10 is max, but we'll do 3.
                boxes[count++] = new Box(dataH, dataW, dataD);
            }
        } while (inputLine != null && count < MAX);

        //display volumes of box objects
        for(int i = 0; i < count; i++)
        {
            Console.WriteLine("The volume of box {0} is {1} cubic inches.", i + 1, boxes[i].GetVolume());
        }

        Console.ReadLine();
    }//End Main()
}//End class Program

class Box
{
    private int height;
    private int width;
    private int depth;

    //paramaterized constructor
    public Box(int p1, int p2, int p3)
    {
        height = p1;
        width = p2;
        depth = p3;
    }

    //the GetVolume Method
    //Purpose: Calc volume of box
    //Parameters: None
    //Return: int containing volume of box
    public int GetVolume()
    {
        return (height * width * depth);
    }
}

