using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//8. Write a C# Sharp program to find the largest of three numbers.
namespace ConsoleApp3
{
    internal class Class7
    {
        public static void Main8()
        {
            Console.WriteLine("Input first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input third number:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {

                Console.WriteLine($"The first number i.e {a} is the greatest among the three");
            }

            else if(b>a && b>c){
                Console.WriteLine($"The second number i.e {b} is the greatest among the three");
            }
            else
            {
                Console.WriteLine($"The third number i.e {c} is the greatest among the three");
            }

            Console.ReadKey();
        }
    }
}
