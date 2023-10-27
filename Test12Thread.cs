using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Test12Thread
    {
        static int count1 = 0;
        static int count3 = 0;
        static int count7 = 0;

        public static void Main12(string[] args)
        {
            Thread t1 = new Thread(() => RingTheBell(1));
            t1.Start();

            Thread t3 = new Thread(() => RingTheBell(3));
            t3.Start();

            Thread t7 = new Thread(() => RingTheBell(7));
            t7.Start();

        }

        static void RingTheBell(int second)
        {
            while(true)
            {
                Thread.Sleep(second * 1000);

                if(second == 1)
                {
                    count1++;
                    Console.WriteLine($"{second} : {count1}");
                }
                if (second == 3)
                {
                    count3++;
                    Console.WriteLine($"{second} : {count3}");
                }
                if (second == 7)
                {
                    count7++;
                    Console.WriteLine($"{second} : {count7}");
                }
            }
        }
    }
}
