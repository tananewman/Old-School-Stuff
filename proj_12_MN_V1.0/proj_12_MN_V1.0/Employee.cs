using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class Employee
    {
        //----------Data Members----------------

        //Consts
        const int ARRAY_SIZE = 2;
        const double OVERTIME = 1.5;
        const double FED_AND_STATE_TAXES_RATE = .725;

        //strings to hold initial info
        private string employeeNumber;
        private string employeeName;
        private string employeeAddress;
        private string employeePayData;

        //variables
        private double employeeHrlyWage;
        private int employeeHrsWrkd;
        private string[] payData = new string[ARRAY_SIZE];
        private double grossPay;
        private double netPay;
        private string netPayStr;

        //the paramaterized constructor 
        //Purpose: It sets the employee number, name, address, hourly pay, and hours worked
        //Parameters: strings for employee number,name, address, and paydata
        //Returns: None
        public Employee(ref string empnumData, ref string nameData, ref string addressData, ref string payData)
        {
            employeeNumber = empnumData;
            employeeName = nameData;
            employeeAddress = addressData;
            employeePayData = payData;
        }

        //Methodized fill stream test
        public string FillStuff(StreamReader dataFile, ref string name)
        {
            name = dataFile.ReadLine();
            return name;
        }

        //The CalcSalary Method
        //Purpose: Calculate and return pay
        //Parameters: None
        //Returns: None
        public double CalcSalary()
        {
            //Split and parse
            payData = employeePayData.Split();
            employeeHrlyWage = double.Parse(payData[0]);
            employeeHrsWrkd = int.Parse(payData[1]);

            //Calc gross pay
            grossPay = employeeHrlyWage * employeeHrsWrkd;
            
            if (employeeHrsWrkd > 40)
                grossPay = grossPay * OVERTIME;

            //Calc and return net pay
            netPay = grossPay * FED_AND_STATE_TAXES_RATE;
            return netPay;
        }

        //-------Getters------
        
        //GetEmployeeName Method
        //Purpose: return employeeName
        //Parameters: None
        //Returns: String
        public string GetEmployeeName()
        {
            return employeeName;
        }

        //GetEmployeeAddress Method
        //Purpose: return employeeAddress
        //Parameters: None
        //Returns: String
        public string GetEmployeeAddress()
        {
            return employeeAddress;
        }

        //GetNetPay Method
        //Purpose: converts net to string for text box
        //Parameters: none
        //Returns: string
        public string GetNetPay()
        {
            netPayStr = String.Format("{0:C}", CalcSalary());
            return netPayStr;
        }
    }
}
