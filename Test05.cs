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

        public Robot()
        {
            Name = "홍길동";
            Console.WriteLine("A");
        }

        public Robot(string name)
        {
            Name = name;
            Console.WriteLine("B");
        }


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

        public CleanRobot() : base()
        {
            Console.WriteLine("C");
        }
        public CleanRobot(string name) : base("TEST")
        {
            data = 3;

            Console.WriteLine("D");
        }
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
       public static void Main05(string[] args)
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
