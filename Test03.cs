using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dog
    {
        public string Name = null;
        public string Type = null;

        // 4. 메소드를 중복정의
        public void SetValue()
        {
            Name = "아무개";
            Type = "똥개";
        }
        public void SetValue(string value)
        {
            Name = value;
        }
        public void SetValue(string value, string value2)
        {
            Name = value;
            Type = value2;
        }

        // 1. 없을 때는 시스템이 자동으로 만들어준다.

        // 2. 생성자는 초기화 메소드, 리턴타입이 없다.
        // 3. 클래스와 이름이 같다.
        // 만약 기본 생성자는 없고, 복제생성자만 있으면
        // 프로그래머의 의지(복제 생성자만 허용)를 반영한다.
        public Dog()  // 파라미터가 없는 생성자 ==> Default Constructor
        {
            Name = "unknown";
            Type = "unknown2";
            Console.WriteLine("Dog() created");
        }
        

        public Dog(string name, string Type)  // 파라미터가 있는 생성자 ==> 복제 생성자 Copy Constructor
        {
            Name = name;
            this.Type = Type;
            Console.WriteLine("Dog(string, string) created");
        }

        // 소멸자(Destructor)
        // 리턴타입 없고, 파라미터 없다
        ~Dog()
        {
            Console.WriteLine(Name + " is destroyed");
        }
    }
    class Test03
    {
        static void Main03(string[] args)
        {
            Dog puppy = new Dog();
            Console.WriteLine($"{puppy.Name} {puppy.Type}");

            puppy.Name = "강아지";
            puppy.Type = "치와와";
            Console.WriteLine($"{puppy.Name} {puppy.Type}");

            Dog puppy2 = new Dog();
            Console.WriteLine($"{puppy2.Name} {puppy2.Type}");

            Dog puppy3 = new Dog();
            puppy3.SetValue();
            Console.WriteLine($"{puppy3.Name} {puppy3.Type}");

            Dog puppy4 = new Dog("멍멍이", "불독");
            Console.WriteLine($"{puppy4.Name} {puppy4.Type}");

        }
    }
}
