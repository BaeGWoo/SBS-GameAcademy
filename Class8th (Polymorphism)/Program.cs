﻿using InputSystem;
namespace Class8th__Polymorphism_
{
    internal class Program
    {
        static void Process(int x)
        {
            Console.WriteLine(x + " x(int)의 값이 처리되었습니다.");
        }

        static void Process(float x)
        {
            Console.WriteLine(x + " x(float)의 값이 처리되었습니다.");
        }

        static void Process(char x)
        {
            Console.WriteLine(x + " x(char)의 값이 처리되었습니다.");
        }

        static void Process(string x)
        {
            Console.WriteLine(x + " x(string)의 값이 처리되었습니다.");
        }

        static void Process(int x, int y)
        {
            Console.WriteLine("(" + x + "," + y + ") x(int)와 y(int)의 값이 처리되었습니다.");
        }

        public enum State
        {
            IDLE,
            MOVE = 3,
            ATTACK,
            DIE

            // 열거형에서 값을 특정한 위치에 새로 할당하게 되면 그다음의
            // 열거형의 값은 새로 할당한 값의+1이 됩니다.
        }

        public enum Beruk
        {
            MARINE,
            FIREBET,
            GHOST
        }

        static void Main(string[] args)
        {

            #region 상속
            // 상위 클래스의 속성을 하위 클래스가 사용할 수 있도록
            // 설정해주는 기능입니다.

            //Unit unit = new Unit();

            //Marine marine=new Marine();
            //marine.Show();

            // 클래스의 상속 관계에서
            // 상위 클래스는 하위 클래스의 속성을 사용할 수 없으며,
            // 하위 클래스는 상위 클래스의 메모리를 포함한 상태로 메모리의 크기가 결정됩니다.

            #endregion

            #region 이름 공간
            // 속성을 구분할 수 있도록 유효 범위를 설정하는 영역입니다.
            //Keyboard keyboard = new Keyboard();
            //keyboard.Connect();
            #endregion

            #region 다형성
            // 여러 개의 서로 다른 객체가 동일한 기능을 서로 다른 
            // 방법으로 처리할 수 있는 작업입니다.


            #region 함수의 오버로딩
            // 같은 이름의 함수를 매개 변수의 자료형과 매배 변수의 수로
            // 구분하여 여러 개를 선언할 수 있는 기능입니다.
            //Process(10);
            //Process(3.5f);
            //Process('A');
            //Process("StarCraft");
            //Process(10,20);

            // 함수의 오버로딩의 경우 함수의 매개 변수에 전달하는 인수의
            // 형태를 보고 호출하므로, 반환형으로 함수의 오버로딩은 생성할 수 없습니다.
            #endregion

            #region 함수의 오버라이딩
            // 상위 클래스에 있는 함수를 하위 클래스에서 재정의하여
            // 사용하는 기능입니다.

            //Marine marine=new Marine();
            //marine.Skill();

            //Unit unit = new Ghost();//업캐스팅->상위 클래스의 포인터가 하위 클래스의 객체를 가리킴
            //unit.Skill();

            // 함수의 오버라이드는 상속 관계에서만 이루어지며, 하위 클래스에서
            // 함수를 재정의할 때 상위 클래스의 함수 형태와 일치해야 합니다.

            #endregion

            #region 가상 함수
            // 상속하는 클래스 내에서 같은 형태의 함수로 재정의 될 수 있는 함수입니다.

            //Unit unit = new Marine();
            //unit.Show();          

            //unit = new Firebet();
            //unit.Show();

            //unit = new Ghost();
            //unit.Show();

            // 가상 함수 실행 시간에 상위 클래스에 대한 참조로
            // 하위 클래스에 재정의된 함수를 호출할 수 있으며, 
            // 접근 지정자는 공개로 설정해야 합니다.

            #endregion



            // 다형성은 컴파일 시점에 함수의 속성이 결정되는 정적 바인딩을 하지 않고,
            // 실행 시간에 함수와 속성이 결정될 수 있는 동적 바인딩을 가능하게 합니다.
            //정적바인딩 -> 컴파일 시점에 데이터가 결정되는것 ex)int a=10;
            //동적바인딩 -> 사용자가 원하는 시점에 데이터가 결정되는 것
            #endregion

            #region 열거형
            //여러 개의 상수를 하나의 컨테이너에서 관리하기 위해 사용되는 자료형입니다.
            //State state = (State)3;
            //switch (state)
            //{
            //    case State.IDLE:
            //        Console.WriteLine("대기 상태");
            //        break;

            //    case State.MOVE:
            //        Console.WriteLine("이동 상태");
            //        break;

            //    case State.ATTACK:
            //        Console.WriteLine("공격 상태");
            //        break;

            //    case State.DIE:
            //        Console.WriteLine("죽음 상태");
            //        break;
            //}

            #endregion

            #region 콘솔 입력
            //출력 <=> 버퍼 <=> 입력
            //버퍼->하드웨어와 소프트웨어간의 처리시간을 메꿔주기 위한 임시 저장소
            //동기는 순차적 진행
            //비동기는 독립적으로 진행
            //string name =Console.ReadLine();
            //Console.WriteLine("name 변수의 값 : " + name);

            //'A'
            //int count = Console.Read();//아스키 코드 값으로 입력을 받게 된다.

            //int level = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("count 변수의 값 : " + level);
            #endregion

            #region 배럭생성
            //int count = 0;
            //Console.Write(" ______________________________________________\n");
            //Console.Write("|              |                |              |\n");
            //Console.Write("| 0 : Marine   |  1 : Firebet   |  2 : Ghost   |\n");
            //Console.Write("|______________|________________|______________|\n\n");
            //while (count < 5)
            //{
            //    Console.Write("[유닛을 선택해주세요] => ");
            //    int num=Convert.ToInt32(Console.ReadLine());
            //    Beruk beruk = (Beruk)num;
            //    switch (beruk)
            //    {
            //        case Beruk.MARINE:
            //            Unit unit1 = new Marine();
            //            unit1.Show();
            //            count++;
            //            break;

            //        case Beruk.FIREBET:
            //            Unit unit2 = new Firebet();
            //            unit2.Show();
            //            count++;
            //            break;

            //        case Beruk.GHOST:
            //            Unit unit3 = new Ghost();
            //            unit3.Show();
            //            count++;
            //            break;
            //        default:
            //            Console.WriteLine("0,1,2 중에서 입력해주세요\n");
            //            break;
            //    }
            //    Console.WriteLine("현재 count : " + (count));
            //    Console.Write("____________________________________________\n\n");

            //}
            //Console.WriteLine("유닛 생성이 완료되었습니다.");

            //Barracks barracks = new Barracks();
            //barracks.Create();
            #endregion


        }
    }
}
