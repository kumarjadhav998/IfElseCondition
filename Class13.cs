using System;
using System.Collections.Generic;
using System.Text;

namespace IfElseCondition
{
    class Class13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("monday");
            }
            else if (num == 2)
            {
                Console.WriteLine("tuesday");
            }
            else if (num == 3)
            {
                Console.WriteLine("wednesday");
            }
            else if (num == 4)
            {
                Console.WriteLine("thursday");
            }
            else if (num == 5)
            {
                Console.WriteLine("friday");
            }
            else if (num == 6)
            {
                Console.WriteLine("saturday");
            }
            else if(num==7)
            {
                Console.WriteLine("sunday");
            }

        }
    }
}
