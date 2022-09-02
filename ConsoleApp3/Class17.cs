using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*18. Write a program in C# Sharp to make such a pattern like right angle triangle with number increased by 1.
The pattern like :

1
2 3
4 5 6
7 8 9 10 
*/
namespace ConsoleApp3
{
    internal class Class17
    {
        public static void Main18()
        {
            int c = 1;
            for (int i = 1; i < 8; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write($"{c} ");
                    c += 1;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
