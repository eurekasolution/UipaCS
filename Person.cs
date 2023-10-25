using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        // 상태 정보
        public string Name = null;
        public string Birthday = null;
        public string Gender = null;

        // 동작정보(Method)
        public void Eat()
        {
            Console.WriteLine("Eat()");
        }
        public void Walk()
        {
            Console.WriteLine("Walk()");
        }

        public void Run()
        {
            Console.WriteLine(Name + " runs ");
        }

    }

    class TestPerson
    {
        static void MainPerson(string[] args)
        {
            Console.WriteLine("Test Person Class");
            Person kim = new Person();

            kim.Name = "I am Kim";
            kim.Birthday = "2000-01-01";
            kim.Gender = "Male";
            kim.Run();
        }
    }
}
