using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Multiplication
{
    class Program
    {
        //Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.

        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            num3 = int.Parse(Console.ReadLine());

            int multiplication = num1 * num2 * num3;

            Console.WriteLine("Result of multiplication {0}, {1} and {2} is {3} ", num1, num2, num3, multiplication);
            Console.ReadLine();

        }
    }
}
