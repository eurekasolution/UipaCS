using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private string Name = null;

        public string GetName()
        { 
            return Name; 
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }

    internal class Test06
    {
        public static void Main06(string[] args)
        {
            Student kim = new Student();
            kim.SetName("Kim Mo Mo");
            string name = kim.GetName();
            Console.WriteLine(name);
        }
    }
}
