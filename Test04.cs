using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        private string name; // field

        public string Name // method, attribute
        { 
            get { return name; }
            set { name = value; }
        } 
        
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
    }

    class Company
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public Company(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
    class Test04
    {
        public static void Main04(string[] args)
        {
            Employee kim = new Employee();

            kim.Name = "Hong Kil Dong";
            Console.WriteLine(kim.Name);

            Company kbstar = new Company("국민은행", "http://kbstar.com");
            Company uipa = new Company("울산정보진흥원", "http://uipa.org");

            Console.WriteLine($"{kbstar.Name} {kbstar.Url}");
            Console.WriteLine($"{uipa.Name} {uipa.Url}");
        }
    }
}
