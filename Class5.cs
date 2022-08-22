using System;
using System.Collections.Generic;
using System.Text;

namespace ifelse
{
    public class Demo
    {
        static void main(string[] args)
        {
            Console.WriteLine("enter the 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("the same number");
            }
            else if (num2 == num1)
            {
                Console.WriteLine("not a same number");
            }
        }

    }
}