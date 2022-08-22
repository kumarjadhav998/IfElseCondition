using System;
using System.Collections.Generic;
using System.Text;

namespace IfElseCondition
{
    class Class10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 3rd number");
            int num3 = int.Parse(Console.ReadLine());
            if (num1==num2 && num1==num3)
            {
                Console.WriteLine("the number are same");
            }
            else if (num2==num1 && num2==num3)
            {
                Console.WriteLine("the number are same");
            }
            else
            {
                Console.WriteLine("the number are not same");
            }

        }
    }
}
