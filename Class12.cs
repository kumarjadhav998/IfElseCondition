using System;
using System.Collections.Generic;
using System.Text;

namespace IfElseCondition
{
    class Class12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if(num%5==0)
            {
                Console.WriteLine("this number is multiple of 5");
            }
            else
            {
                Console.WriteLine("this number is not multiple of 5");
            }

                
            
        }
    }
}
