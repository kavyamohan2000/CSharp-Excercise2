using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//9.Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies. 
namespace ConsoleApp3
{
    internal class Class8
    {
        public static void Main8()
        {
            Console.WriteLine("Input the x coordinate:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the y coordinate:");
            int y = Convert.ToInt32(Console.ReadLine());
            if(x==0 && y == 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) is the origin.");
            }
            else if(x==0 && y>0){
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the positive y axis.");
            }
            else if (x == 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the negative y axis.");
            }
            else if (x>0 && y == 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the positive x axis.");
            }
            else if (x <0 && y == 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the negative x axis.");
            }
            else if(x>0 && y >=0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the first coordinate.");

            }
            else if(x<0 && y >= 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the second coordinate.");
            }
            else if(x<0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the third coordinate.");
            }
            else
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the fourth coordinate.");
            }
            Console.ReadKey();
        }
    }
}
