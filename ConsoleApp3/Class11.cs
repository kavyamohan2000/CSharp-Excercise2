using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//12. Write a program in C# Sharp to display the multiplication table of a given integer. 
namespace ConsoleApp3
{
    internal class Class11
    {
        public static void Main12()
        {
            Console.WriteLine("Input the term:");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{a}*{i}={a * i}");
            }
            Console.ReadKey();
        }
    }
}
