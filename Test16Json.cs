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
    internal class Test16Json
    {
        public static void Main16(string[] args)
        {
            // JSON을 파일을 읽어서 문자열로 저장
            string jsonText = File.ReadAllText("data2.json");
            Console.WriteLine(jsonText);

            JObject data = JObject.Parse(jsonText);
            // LINQ를 이용해 데이터 쿼리
            string name = data["name"].ToString();
            int age = (int) data["age"];
            string companyName = data["company"]["name"].ToString();
            string companyHttp = data["company"]["http"].ToString();
            string address = data["address"].ToString();

            // 결과를 출력
            Console.WriteLine($"이름 : {name} 나이 : {age}");
            Console.WriteLine($"회사명 : {companyName} ");
            Console.WriteLine($"홈페이지 : {companyHttp} ");
            Console.WriteLine($"주소 : {address} ");
        }
    }
}
