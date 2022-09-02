using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4. Write a C# Sharp program to find whether a given year is a leap year or not. 
namespace ConsoleApp3
{
    internal class Class3
    {
        public static void Main4()
        {
            Console.WriteLine("Input the year to be checked:");
            int a = Convert.ToInt32(Console.ReadLine());
            if((a%4==0) && (a%100!=0) || (a % 400 == 0))
            {
                Console.WriteLine($"{a} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{a} is not a leap year.");
            }
            Console.ReadKey();
        }
    }
}
