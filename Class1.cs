using System;
using System.Collections.Generic;
using System.Text;

namespace IfElseCondition
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0) 
            {
                Console.WriteLine("the number is devisible");
            }
              else
            {
                Console.WriteLine("the number is not devisible");
            }


                
        }
    }
}
