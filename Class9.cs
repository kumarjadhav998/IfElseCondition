using System;
using System.Collections.Generic;
using System.Text;

namespace IfElseCondition
{
    class Class9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num<0 || num<10)
            {
                Console.WriteLine("the number is single digit");
            }
            else if(num<9 || num<100)
            {
                Console.WriteLine("the number is double digit");
            }


        }
    }
}
