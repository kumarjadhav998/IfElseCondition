using System;
using System.Collections.Generic;
using System.Text;

namespace IfElseCondition
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                Console.WriteLine("Alphabet");

            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("symbol");
             }
        }
    }
}
