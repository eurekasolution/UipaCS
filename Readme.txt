������ ���� �����Դϴ�.

19. Thread vs. Process

	Thread : �淮 ���μ��� : light-weight process
18.����ó�� : Exception Control
	���������� ������ ����


17. enhanced for

	int[] lotto = new int[6];

	for(int value : lotto)
	{
		System.out.println(value);
	}

16. �׷� ������ ó��
	1. Array , Generic
	������ ó�� : DB, CSV, TSV, JSON(JavaScript Object Notation)

	{
		"name" : "ȫ�浿",
		"age" : 12,
		"company" : "UIPA"
	}

	{
		"name" : "ȫ�浿",
		"age" : 12,
		"company" : {
			"name" : "���������������",
			"http" : "http://uipa.or.kr",
			"tel" : "053-123-4567"
		}
	}

	{
		"person" : {
			"name" : "ȫ�浿",
			"age" : 12
		}, 
		"company" : {
			"name" : "��������",
			"url" : "https://kbstar.com"
		}
	}

	{
		"employee": [ 
			{ "name" : "ȫ�浿", "age" : 12 },
			{
				"name" : "�̼���",
				"age" : 34
			},
			{
				"name" : "������",
				"age" : 43
			}
		],
		"employer": [
			{ "company" : "��������" },
			{ "company" : "���������������"}
		]
	}


15. �������̽� : Interface
	�߻��� ������ �ſ� ���ؼ� ��� �޼ҵ尡 abstract�� ������ Ŭ����
14. �߻� Ŭ���� : Abstract Class
	


13. ������ : overriding
	�� ���忡 �ö�Ÿ��
	�ö�Ÿ�� �ؿ� ������ �Ⱥ���

	�θ� ���� �޼ҵ尡 ������ �ȵ鶧, ������(������)

12. ��� : Inheritance
	�ڵ带 ������ϰڴ�.
	Java :  class SportsCar extends Car {}
	C#   :  class SportsCar : Car {}

11. getter, setter
	����(Field)�� �Ϲ������� private
	�� ���� �а�, �����ϴ� getter, setter ����Ѵ�.

	getXXX(), setXXX()

10. �Ҹ��� : Destructor
	��ü�� �Ҹ�� �� ȣ��ȴ�.
	Garbage Collector���� �˷��ִ� ���� ����
	����Ÿ�Ե� ����, �Ķ���͵� ����
	~Ŭ�����̸�()

9. �ߺ����� : overloading

	C��� : void print() {}
			void print(int a) { } : �Ұ���
	��ü���� ��� : Java, C#
			print()
			print(3)
	��ü���⿡�� �ߺ������� Ư��
		1. �ñ׳���(Signature)�� �ٸ��� �ߺ����ǰ���
		2. �ñ׳���
			�Լ��̸�, �Ķ���� ����, ����
			void print() {} 
			void print(int a) { }
			int print(int a) { return a;}
			void print(int a, int b) { }
			void print(double a){}

			print(3, 4)
			print(1.2);
			print(3)

8. ������ : Constructor

	1. �ʱ�ȭ �޼ҵ� : �� �༮�� �Լ�
	2. �׷���, ���� Ÿ���� ����. 
	3. �����ڰ� ������ �ý����� �˾Ƽ� ������ش�.
	4. �׷��� �ϳ��� ������ ���α׷����� ������ �ݿ��Ѵ�.
	5. Ŭ���� �̸��� �޼ҵ� �̸��� ����.
7. ����
	overloading : �ߺ�����
	overriding : ������

6. ���� ���� : �ڷᱸ��.

	Stack : FILO, LIFO : ������ ������
		push, pop
	Queue : FIFO
		enqueue, dequeue()
		������ 1 : Round-Robin���� �ذ�
		������ 2 : 

			4 3 2 1 0
			E D C 
			�̻�Ȳ���� F�� �������� CDE �Űܾ߸� ����
			�ذ�å --> ����ť(Circular Queue)
	Array : �������� ����
	Tree : ������ ���� �׷���
	Set : �ߺ��� ������� �ʴ� �ڷᱸ��
		A = { 1, 1, 1, 2, 2, 3 } = {1, 2, 3}

		a                                b
		test  -----��ȣȭ-----> adsfkadskfasd93329dh2df

		f(a) = b
		�纯 ���Լ�
		a = f-(b)

	Hash : ���Լ��� �������� �ʴ� �Լ�

5. Ŭ���� : ����ü(struct)�ε� �Լ��� �����ϴ� ����ü
	��ü(Object)�� Ŭ������ ����
		- ��������(����) + ��������(Method)
	�ڹ� : class Car { } ----> ���ϸ� : Car.java
	C# : �ڹٿ� ������ ����.

	Person Ŭ������ ������� Person.cs�� �����

4. ����ȯ , Type Casting


3. Overflow, Underflow

	������Ÿ���� ���� ������ ����� ���

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
	
Test02�� �����, Test01�� Main -> Main01�� ����
�������� �ϳ��� ������.

2. ������(Operator)
	�⺻ ��Ģ������ : +, -, *, /, %
	���迬���� : ����� True, False
		>, >=, <=, <, ==, !=
	�������� : &&, ||, !
		&& : �Ѵ� ���϶��� ���̴�.
		|| : �Ѵ� �����϶��� �����̴�.
		!  : ������


1. �ݺ��� : for, while
	���߰����� �������� for ���ٴ� while���� ���� ����Ѵ�.
	�� while���� ����� ���� �� ���� �� ������ �������϶�!!!