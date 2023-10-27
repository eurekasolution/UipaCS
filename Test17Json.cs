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
    internal class Test17Json
    {
        public static void Main17(string[] args)
        {
            // JSON을 파일을 읽어서 문자열로 저장
            string jsonText = File.ReadAllText("data3.json");
            Console.WriteLine(jsonText);

            JObject data = JObject.Parse(jsonText);

            // nodes 의 배열추출
            JArray nodes = (JArray)data["nodes"];
            JArray links = (JArray)data["links"];

            var query = from node in nodes
                        where (int)node["age"] >= 20
                        orderby (string)node["name"]
                        select (string)node["name"];

            foreach(string name in query)
            {
                Console.WriteLine(name);
            }
        }
    }
}
