using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Test10
    {
        public static void Main(string[] args)
        {
            Console.Write("Insert Number : ");
            int num = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(10 / num);
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
            

            Console.WriteLine("프로그램 종료");
        }
    }
}
