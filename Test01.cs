using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Test01
    {
        static void Main01(string[] args)
        {
            Console.WriteLine("Test01 World");
            // Comment /* */
            /* variable
             *  1. 키워드 int, for, 3value, __value             */

            int a = 3;
            int b = 4;
            b = 5;


            string input;

            Console.Write("Insert Age : ");
            input = Console.ReadLine();
            if(int.TryParse(input, out int age)) 
            {
                Console.WriteLine(age + 1);
            }


            // while 

            while(b>=0)
            {
                Console.WriteLine(--b);
            }

            // for (초기값; 조건; 증감)
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"{a} {b}");
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            int degree = 77;

            if( degree >= 90 )
            {
                Console.WriteLine("A");
            }
            else
            {
                if( degree >= 80 )
                {
                    Console.WriteLine("B");
                }else
                {
                    Console.WriteLine("F");
                }
            }

            bool isOn = true;
            int intValue = 10;
            float floatValue = 3.14f;
            double doubleValue = 3.14;
            char charValue = 'a';

            Console.WriteLine(isOn);
            Console.WriteLine("int value = " + intValue + ", char =" + charValue);

        }
    }
}
