using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*17. Write a program in C# Sharp to make such a pattern like right angle triangle with a number which will repeat a number in a row. 
The pattern like :

1
22
333
4444

 */
namespace ConsoleApp3
{
    internal class Class16
    {
        public static void Main17()
        {
            for (int i = 1; i < 8; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
