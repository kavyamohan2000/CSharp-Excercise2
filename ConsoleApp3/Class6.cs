using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//7. Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height.
namespace ConsoleApp3
{
    internal class Class6
    {
        public static void Main7()
        {
            Console.WriteLine("Enter the hieght of the person:");
            int h = Convert.ToInt32(Console.ReadLine());
            if (h <= 150)
            {
                Console.WriteLine("The person is short.");
            }
            else if(h>150 && h <= 165)
            {
                Console.WriteLine("The person is of average hieght.");
            }
            else
            {
                Console.WriteLine("The person is tall.");
            }
            Console.ReadKey();
        }
    }
}
