using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6. Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
namespace ConsoleApp3
{
    internal class Class5
    {
        public static void Main6()
        {
            Console.WriteLine("Enter the value of m:");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m > 0)
            {
                Console.WriteLine("The value of n=1.");
            }
            else if(m==0){
                Console.WriteLine("The value of n=0.");
            }
            else
            {
                Console.WriteLine("The value of n=-1");
            }
            Console.ReadKey();
        }
    }
}
