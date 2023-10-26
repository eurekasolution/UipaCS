설명을 위한 파일입니다.

19. Thread vs. Process

	Thread : 경량 프로세스 : light-weight process
18.예외처리 : Exception Control
	비정상적인 오류를 제거


17. enhanced for

	int[] lotto = new int[6];

	for(int value : lotto)
	{
		System.out.println(value);
	}

16. 그룹 데이터 처리
	1. Array , Generic
	데이터 처리 : DB, CSV, TSV, JSON(JavaScript Object Notation)

	{
		"name" : "홍길동",
		"age" : 12,
		"company" : "UIPA"
	}

	{
		"name" : "홍길동",
		"age" : 12,
		"company" : {
			"name" : "울산정보산업진흥원",
			"http" : "http://uipa.or.kr",
			"tel" : "053-123-4567"
		}
	}

	{
		"person" : {
			"name" : "홍길동",
			"age" : 12
		}, 
		"company" : {
			"name" : "국민은행",
			"url" : "https://kbstar.com"
		}
	}

	{
		"employee": [ 
			{ "name" : "홍길동", "age" : 12 },
			{
				"name" : "이순신",
				"age" : 34
			},
			{
				"name" : "광개토",
				"age" : 43
			}
		],
		"employer": [
			{ "company" : "국민은행" },
			{ "company" : "울산정보산업진흥원"}
		]
	}


15. 인터페이스 : Interface
	추상의 정도가 매우 심해서 모든 메소드가 abstract로 구성된 클래스
14. 추상 클래스 : Abstract Class
	


13. 재정의 : overriding
	말 안장에 올라타기
	올라타면 밑에 깔판이 안보임

	부모가 만든 메소드가 마음에 안들때, 덮어씌우기(재정의)

12. 상속 : Inheritance
	코드를 재생산하겠다.
	Java :  class SportsCar extends Car {}
	C#   :  class SportsCar : Car {}

11. getter, setter
	변수(Field)는 일반적으로 private
	이 값을 읽고, 세팅하는 getter, setter 사용한다.

	getXXX(), setXXX()

10. 소멸자 : Destructor
	객체가 소멸될 때 호출된다.
	Garbage Collector에게 알려주는 역할 수행
	리턴타입도 없고, 파라미터도 없고
	~클래스이름()

9. 중복정의 : overloading

	C언어 : void print() {}
			void print(int a) { } : 불가능
	객체지향 언어 : Java, C#
			print()
			print(3)
	객체지향에서 중복정의의 특성
		1. 시그너쳐(Signature)가 다르면 중복정의가능
		2. 시그너쳐
			함수이름, 파라미터 갯수, 순서
			void print() {} 
			void print(int a) { }
			int print(int a) { return a;}
			void print(int a, int b) { }
			void print(double a){}

			print(3, 4)
			print(1.2);
			print(3)

8. 생성자 : Constructor

	1. 초기화 메소드 : 이 녀석도 함수
	2. 그런데, 리턴 타입이 없다. 
	3. 생성자가 없으면 시스템이 알아서 만들어준다.
	4. 그런데 하나라도 있으면 프로그래머의 의지를 반영한다.
	5. 클래스 이름과 메소드 이름이 같다.
7. 용어설명
	overloading : 중복정의
	overriding : 재정의

6. 참고 사항 : 자료구조.

	Stack : FILO, LIFO : 스프링 동전통
		push, pop
	Queue : FIFO
		enqueue, dequeue()
		문제점 1 : Round-Robin으로 해결
		문제점 2 : 

			4 3 2 1 0
			E D C 
			이상황에서 F를 넣으려면 CDE 옮겨야만 가능
			해결책 --> 원형큐(Circular Queue)
	Array : 고정길이 벡터
	Tree : 루프가 없는 그래프
	Set : 중복을 허용하지 않는 자료구조
		A = { 1, 1, 1, 2, 2, 3 } = {1, 2, 3}

		a                                b
		test  -----암호화-----> adsfkadskfasd93329dh2df

		f(a) = b
		양변 역함수
		a = f-(b)

	Hash : 역함수가 존재하지 않는 함수

5. 클래스 : 구조체(struct)인데 함수를 포함하는 구조체
	객체(Object)를 클래스로 구현
		- 상태정보(변수) + 동작정보(Method)
	자바 : class Car { } ----> 파일명 : Car.java
	C# : 자바와 원리가 같다.

	Person 클래스를 만들려면 Person.cs에 만들기

4. 형변환 , Type Casting


3. Overflow, Underflow

	데이터타입의 저장 범위를 벗어나는 경우

cf. stack overflow

	// ipconfig -all
	// test "hello"
	main(int argc, char **argv)
	{
		char buf[100] ;

		strcpy(buf, argv[1])
	}

	main()
	{
		a();
			a1();
				a11();
				a12();
			a2();

		b();
	}

	0                       100       108     112    116
	--------------------------------------------------
	                                      EPB Pointer
										          Return Address
						      Stack Canary			
			0x90 * 50 + Hacking Code
	
Test02를 만들고, Test01의 Main -> Main01로 변경
진입점을 하나로 만들어라.

2. 연산자(Operator)
	기본 사칙연산자 : +, -, *, /, %
	관계연산자 : 결과는 True, False
		>, >=, <=, <, ==, !=
	논리연산자 : &&, ||, !
		&& : 둘다 참일때만 참이다.
		|| : 둘다 거짓일때만 거짓이다.
		!  : 뒤집기


1. 반복문 : for, while
	개발경험이 많을수록 for 보다는 while문을 많이 사용한다.
	단 while문을 사용할 때는 꼭 실행 전 눈으로 컴파일하라!!!