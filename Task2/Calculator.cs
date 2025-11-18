using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Calculator
    {
        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to the Calculator");
        }

         public int add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Multiply(int num1, int num2 = 1 )
        {
            return num1 * num2;
        }
    }
}
