using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. Write a C# Sharp program to accept two integers and check whether they are equal or not. 
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Input first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine($"{a} and {b} are equal.");
            }
            else
            {
                Console.WriteLine($"{a} and {b} are are not equal.");
            }
            Console.ReadKey();
        }
    }
}
