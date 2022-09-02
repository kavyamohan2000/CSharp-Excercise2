using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*10. Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria: 
Marks in Maths >=65
Marks in Phy >=55
Marks in Chem>=50
Total in all three subject >=180
or
Total in Math and Subjects >=140
*/
namespace ConsoleApp3
{
    internal class Class9
    {
        public static void Main10()
        {
            Console.WriteLine("Enter mark in Maths:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mark in Physics:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mark in Chemistry:");
            int c = Convert.ToInt32(Console.ReadLine());
            int total = a + b + c;
            Console.WriteLine("Enter total in Maths and other subjects:");
            int mno = Convert.ToInt32(Console.ReadLine());
            if ((a >= 65) && (b >= 55) && (c >= 50))
            {
                if(total>=180 || mno >= 140)
                {
                    Console.WriteLine("The candidate is eligible for admission");
                }
                else
                {
                    Console.WriteLine("The candidate is not eligible for admission");
                }
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission");
            }
            Console.ReadKey();
        }
    }
}
