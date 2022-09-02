using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3. Write a C# Sharp program to check whether a given number is positive or negative. 
namespace ConsoleApp3
{
    internal class Class2
    {
        public static void Main3()
        {
            Console.WriteLine("Input the number:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>=0)
            {
                Console.WriteLine($"{a} is a positive number.");
            }
            else
            {
                Console.WriteLine($"{a} is a negative number.");
            }
            Console.ReadLine();

        }
    }
}
