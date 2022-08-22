using System;
using System.Collections.Generic;
using System.Text;

namespace IfElseCondition
{
    class Class11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the numer");
            int num = int.Parse(Console.ReadLine());
            if(num>5)
            {
                Console.WriteLine("the number is greater");
            }
            else
            {
                Console.WriteLine("the number is not greater");
            }
        }
    }
}
