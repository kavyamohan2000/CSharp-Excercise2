using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*20. Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk. 

   *
  * * 
 * * *
* * * *

 */
namespace ConsoleApp3
{
    internal class Class19
    {
        public static void Main()
        {
            
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

                    Console.Write($"* ");
                    
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
