using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*16. Write a program in C# Sharp to display the pattern like right angle triangle with a number.
The pattern like :

1
12
123
1234

 */
namespace ConsoleApp3
{
    internal class Class15
    {
        public static void Main16()
        {
            for (int i = 1; i < 8; i++)
            {
                for (int j = 1; j < i+1; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
