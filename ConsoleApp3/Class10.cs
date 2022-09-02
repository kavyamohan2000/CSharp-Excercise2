using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//11. Write a program in C# Sharp to display the cube of the number up to given an integer. 
namespace ConsoleApp3
{
    internal class Class10
    {
        public static void Main11()
        {
            Console.WriteLine("Input the term:");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= a; i++)
            {
                Console.WriteLine($"The cube of {i} is : {i * i * i}");
            }
            Console.ReadKey();
        }
    }
}
