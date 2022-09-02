using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//14. Write a program in C# Sharp to display the n terms of odd natural number and their sum. 
namespace ConsoleApp3
{
    internal class Class13
    {
        public static void Main14()
        {
            Console.WriteLine("Input the term n:");
            int a = Convert.ToInt32(Console.ReadLine());
            int c= 0;
            int sum = 0;
            int i = 1;
            Console.Write("The first n odd natural numbers are :");
            while (c <a)
            {
                Console.Write($"{i},");
                c++;
                sum += i;
                i += 2;

            }
            Console.WriteLine($"The sum is: {sum}");
            Console.ReadKey();
        }
    }
}
