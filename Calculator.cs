using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Calculator
    {
        
        public delegate double Calculate(double firstNumber, double secondNumber);
        public double AddTwoNumbers(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public double MultiplyTwoNumbers(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public void PrintResult(double firstNumber, double secondNumber, Calculate Calculation)
        {
            double result = Calculation(firstNumber, secondNumber);
            Console.WriteLine(result);
        }
        public void PrintName(string name)
        {
            //string input = Console.ReadLine();
            //int age = int.Parse(input);
            Console.WriteLine(name);
        }
        public string GetName()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            return name;
        }

        //last line of main bits
    }
}

