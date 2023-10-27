using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Test14Linq
    {
        public static void Main14(string[] args)
        {
            string[] langs = { "c", "c++", "java", "python", "r", "javascript", "vue.js", "php",  "c#", "jsp", "asp", "ASP.NET" };
            foreach(string lang in langs)
            {
                Console.WriteLine(lang);
            }

            Console.WriteLine("------------ Linq ");
            // mysql과 같은 DB query의 문법과 유사하게 처리
            var selectedLang = from lang in langs
                               where lang.Length >= 3
                               select lang;
            foreach(var lang in selectedLang)
            {
                Console.WriteLine(lang);
            }

            Console.WriteLine("------------ Linq : sorting");

            selectedLang = from lang in langs
                           where lang.Length >= 3
                           orderby lang //descending
                           select lang;
            foreach (var lang in selectedLang)
            {
                Console.WriteLine(lang);
            }

            Console.WriteLine("------------ Linq : WHERE");

            selectedLang = from lang in langs
                           where lang.Length >= 3 && lang.Length<=4
                           // &&, ||, ==, !=, <, >, <=, >=
                           
                           orderby lang //descending
                           select lang;
            foreach (var lang in selectedLang)
            {
                Console.WriteLine(lang);
            }
        }


    }
}
