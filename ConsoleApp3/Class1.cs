using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2. Write a C# Sharp program to check whether a given number is even or odd.
namespace ConsoleApp3
{
    internal class Class1
    {
        public static void Main2()
        {
            Console.WriteLine("Input the number:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is an even integer");
            }
            else
            {
                Console.WriteLine($"{a} is an odd integer");
            }
            Console.ReadLine();
        }
    }
}
