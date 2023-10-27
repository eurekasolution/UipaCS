using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Test15Json
    {
        public static void Main15(string[] args)
        {
            // JSON을 파일을 읽어서 문자열로 저장
            string jsonText = File.ReadAllText("data1.json");
            Console.WriteLine(jsonText);

            JObject jsonObject = JObject.Parse(jsonText);
            // LINQ를 이용해 데이터 쿼리
            string name = jsonObject["name"].ToString();
            int age = jsonObject["age"].Value<int>();

            // 결과를 출력
            Console.WriteLine($"이름 : {name} 나이 : {age}");

        }
    }
}
