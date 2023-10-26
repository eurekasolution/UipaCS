using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Test09
    {
        public static void Main09(string[] args)
        {
            /* Java : 배열
             *  int[] lotto = new int[6];
             */

            int[] array = new int[3];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;

            int[] array2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] array3 = { 11, 22, 33, 44, 55 };
            int[] array4 = new int[100];

            Console.WriteLine(array);
            for(int i=0; i<array4.Length; i++)
            {
                array4[i] = i * 2;
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine();
            foreach(int value in array4 )
            {
                Console.WriteLine(value + 1);
            }

            int index = Array.IndexOf(array4, 88);
            Console.WriteLine("index = " + index);

            index = Array.IndexOf(array4, 7);
            Console.WriteLine("index = " + index);

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Hello");
            list.Add("C#");
            list.Add(3.1415927);
            list.Add(true);
            list.Add(1 > 2);

            //list.Remove("Hello");
            //list.RemoveAt(2);
            //list.Clear();

            foreach(var item in list)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("------- Queue ------ ");
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3.14);
            q.Enqueue("Queue");

            Console.WriteLine("q size = " + q.Count);
            Console.WriteLine("q 3.14 contains = " + q.Contains(3.14));

            while(q.Count >0)
            {
                Console.WriteLine(q.Dequeue());
            }

            Console.WriteLine("------- Stack ------ ");
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push("stack");
            stack.Push("2");
            stack.Pop();
            stack.Push(3);
            Console.WriteLine(stack.Peek());

            Console.WriteLine("------- Hashtable ------ ");
            /* 연관배열 : Associative Array
             * array[1] = 1;
             * dict["apple"] = "사과"
             */
            Hashtable dict = new Hashtable();
            dict["apple"] = "사과";
            dict["desk"] = "책상";
            dict["banana"] = "바나나";
            dict["applogy"] = "사과";
            dict["tcp"] = "Transmission Control Protocol";
            dict["udp"] = "User Datagram Protocol";
            dict["ftp"] = "File Transfer Protocol";
            dict["http"] = "Hyper Text Transfer Protocol";

            Console.WriteLine(dict["tcp"]);
            Console.WriteLine("No data = " + dict["nodata"]);
        }
    }
}
