using System;
using System.Collections.Generic;
using System.Text;

namespace IfElseCondition
{
    class Class8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the age");
            int num = int.Parse(Console.ReadLine());
            if (num>0 && num<18)
            {
                Console.WriteLine("the person is teenager");
            }
            else
            {
                Console.WriteLine("the person is adult");
            }


        }
    }
}
