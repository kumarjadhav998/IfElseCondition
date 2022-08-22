using System;
using System.Collections.Generic;
using System.Text;

namespace IfElseCondition
{
    class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num%3==0 && num%9==0)
            {
                Console.WriteLine("the number is devisible 3 & 9");
            }
            else
            {
                Console.WriteLine("the number is not devisible 3 & 9");
            }
         }
    }
}
