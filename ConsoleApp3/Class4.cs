using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5. Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote. 
namespace ConsoleApp3
{
    internal class Class4
    {
        public static void Main5()
        {
            Console.WriteLine("Enter your age:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 18)
            {
                Console.WriteLine("Congratulations! You are eligible to cast your vote.");
            }
            else
            {
                Console.WriteLine("Sorry! You are not eligible to cast your vote.");
            }
            Console.ReadKey();
        }
    }
}
