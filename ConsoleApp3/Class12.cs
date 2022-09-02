using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//13. Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
namespace ConsoleApp3
{
    internal class Class12
    {
        public static void Main13()
        {
            Console.WriteLine("Input the term:");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 8; j++)
                {
                    Console.Write($"{j}*{i}={j * i}, ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
