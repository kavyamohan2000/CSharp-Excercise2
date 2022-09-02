using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*19. Write a program in C# Sharp to make such a pattern like a pyramid with numbers increased by 1. 

   1 
  2 3 
 4 5 6 
7 8 9 10

 */
namespace ConsoleApp3
{
    internal class Class18
    {
        public static void Main19()
        {
            int c = 1;
            int a = 4;
            for (int i = 1; i < 5; i++)
            {
                for (int k = 0; k < a; k++)
                {
                    Console.Write(" ");
                }
                a--;
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
