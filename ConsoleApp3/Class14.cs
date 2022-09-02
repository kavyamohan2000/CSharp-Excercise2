using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*15. Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk. 
 The pattern like :

*
**
***
****

 */
namespace ConsoleApp3
{
    internal class Class14
    {
        public static void Main15()
        {
            for(int i = 1; i < 8; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
