설명을 위한 파일입니다.

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