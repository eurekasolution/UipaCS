using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp1
{
    class Robot
    {
        public int data;
        public string Name { get; set; }
        public void Move()
        {
            Console.WriteLine($"{Name} moves");
        }

        public void Print()
        {
            Console.WriteLine("마음에 안드는 Print()");
        }
    }

    class CleanRobot : Robot
    {
        public double data;
        public void Clean()
        {
            Console.WriteLine("clean()");
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("새로 만든  Print()");
        }
    }

    class Test05
    {
       public static void Main(string[] args)
        {
            Robot robot = new Robot();
            robot.Name = "tgv";
            robot.Move();

            CleanRobot cleanRobot = new CleanRobot();
            cleanRobot.data = 3.14;
            cleanRobot.Name = "Clean Robot";
            cleanRobot.Print();
            cleanRobot.Move();
            Console.WriteLine(cleanRobot.data);
        }
    }
}
