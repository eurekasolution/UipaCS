using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Test02
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 3;

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);

            Console.WriteLine(++num1);
            Console.WriteLine(num1++);

            Console.WriteLine(num1 > num2);

            Console.WriteLine(2>1 && 2>3);
            Console.WriteLine(2 > 1 || 2 > 3);
            Console.WriteLine(!(2 > 1));

            // over flow
            sbyte num3 = 127;
            //sbyte num4 = num3 + 1;
            Console.WriteLine(num3);


            // type casting
            // 다음의 c가 형변환되는 이유는 명시적인 형변환 발생
            // 큰 쪽으로 자동 형 변환
            sbyte b1 = 100;
            sbyte b2 = 100;
            int c = (int)b1 + b2;
            int d = (int)b1 + (int)b2;
            int e = (int)(b1 + b2);
            Console.WriteLine($"{c} {d} {e}");

        }
    }
}
