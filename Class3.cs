using System;
using System.Collections.Generic;
using System.Text;

namespace IfElseCondition
{
    class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 3rd number");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
                Console.WriteLine("gretest number is "+num1);
            else if(num2> num3 && num2 > num1 )
            {
                Console.WriteLine("gretest number is " + num2);
            }
            else
            {
                Console.WriteLine("gretest number is " + num3);
             }




        }
    }
}
