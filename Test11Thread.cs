using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Test11Thread
    {
        static int count1 = 0;
        static int count3 = 0;
        static int count7 = 0;

        public static void Main11(string[] args)
        {
            // 1초다 종치는 쓰레드 생성
            Thread thread1 = new Thread(RingTheBellOne);
            thread1.Start();

            // 3초다 종치는 쓰레드 생성
            Thread thread3 = new Thread(RingTheBellThree);
            thread3.Start();

            // 3초다 종치는 쓰레드 생성
            Thread thread7 = new Thread(RingTheBellSeven);
            thread7.Start();
        }

        static void RingTheBellOne()
        {
            while(true)
            {
                Thread.Sleep(1000); // unit : ms
                count1++;
                Console.WriteLine($"1 Sec : {count1}");
                
            }
        }

        static void RingTheBellThree()
        {
            while (true)
            {
                Thread.Sleep(3000); // unit : ms
                count3++;
                Console.WriteLine($"3 Sec : {count3}");           
            }
        }
        static void RingTheBellSeven()
        {
            while (true)
            {
                Thread.Sleep(7000); // unit : ms
                count7++;
                Console.WriteLine($"7 Sec : {count7}");
            }
        }


    }
}
