﻿namespace Class3th__Conditional_Statement_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 실수 형태의 10진수를 2진수로 변환하는 방법
            //10진수 실수 부분을 1.0이 될 때까지 계속 2로 곱한 다음
            //결과의 정수 부분을 위에서 아래로 순서대로 정렬합니다.
            //float data = 3.2555555f;
            //double value = 3.25555555555555555555;
            //Console.WriteLine("data 변수의 값 : "+data);
            //Console.WriteLine("value 변수의 값 : " + value);

            // 4 byte 크기의 실수형 자료형은 소수점 이하 6자리까지만 표기하며,
            // 8 byte 크기의 실수형 자료형은 소수점 이하 15자리까지만 정확도를 표기합니다.
            #endregion

            #region 부호없는 자료형
            //ulong unsignedLong = 4000000000000000000;
            //uint unsignedInt = 4000000000;
            //ushort unsignedShort = 65535;
            #endregion

            #region 오버플로우
            //특정한 자료형이 표현할 수 있는 최대값의 범위를 넘어서
            //연산을 수행하는 과정입니다.
            // short exp = 65999;

            //오버플로우는 부호없는 자료형에서도 똑같이 발생할 수 있습니다.
            #endregion

            #region 언더플로우
            //특정한 자료형이 표현할 수 있는 최소값의 범위를 넘어서
            //연산을 수행하는 과정입니다.
            //short level = -60000;

            #endregion

            #region 조건문
            //어떤 조건이 주어질 때 해당 조건에 따라 동작을 수행하도록
            //실행하는 명령문입니다.

            #region 관계 연산자
            //두 개의 피연산자의 값을 비교하여 그 결과를 0 또는 1이라는
            //값으로 나타내는 연산자입니다.

            //bool result1 = 10 > 5;
            //bool result2 = 10 < 5;
            //bool result3 = 10 == 5;
            //bool result4 = 10 != 5;
            //bool result5 = 10 >= 5;
            //bool result6 = 10 <= 5;
            //
            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);
            //Console.WriteLine(result4);
            //Console.WriteLine(result5);
            //Console.WriteLine(result6);

            //관계 연산자는 조건이 맞을 때 1이라는 값을 반환하며,
            //조건이 틀릴 때 0이라는 값을 반환합니다.

            #endregion

            #region if문
            //어떤 특정한 조건을 비교하여 조건이 맞다면 실행되는 명령문
            //int health = 100;
            //
            //health = 10;
            //
            //if(health <= 0)
            //{
            //    Console.WriteLine("Destroy GameObject");
            //}


            #endregion

            #region else if문
            //if문의 조건이 틀릴 때,
            //else if문의 조건이 맞다면 실행되는 명령문입니다.
            //char key = 'A';
            //if(key=='W')
            //{
            //    Console.WriteLine("↑");
            //}
            //else if (key == 'A')
            //{
            //    Console.WriteLine("←");
            //}
            //else if (key == 'S')
            //{
            //    Console.WriteLine("↓");
            //}
            //
            //else if (key == 'D')
            //{
            //    Console.WriteLine("→");
            //}
            //else if문은 if문이 존재한다면, 여러개를 생성할 수 있습니다.
            #endregion

            #region else문
            //if문과 else if문의 조건이 다 틀리면 실행되는 명령문입니다.
            //int level = 99;
            //
            //if (level == 11)
            //{
            //    Console.WriteLine("1차 전직");
            //}
            //
            //else if(level==41)
            //{
            //    Console.WriteLine("2차 전직");
            //}
            //
            //else
            //{
            //    Console.WriteLine("전직을 할 수 없습니다.");
            //}


            //if문에 연결된 모든 조건문의 조건이 맞을 때,
            //가장 위에 있는 조건문만 실행됩니다.            

            #endregion

            #region switch문
            //어떤 결과에 따라 그 결과부터 실행되는 명령문입니다.
            //int state = 13;
            //switch (state)
            //{
            //    //break문
            //    //특정한 지점에서 분기를 탈출하는 명령문입니다.
            //    case 0:
            //        Console.WriteLine("IDLE");
            //        break;
            //
            //    case 1:
            //        Console.WriteLine("MOVE");
            //        break;
            //
            //    case 2:
            //        Console.WriteLine("ATTACK");
            //        break;
            //
            //    case 3:
            //        Console.WriteLine("DIE");
            //        break;
            //
            //    default:
            //        Console.WriteLine("ERROR");
            //        break;
            //
            //
            //}

            //switch문의 경우 조건에 해당하는 값에 따라
            //조건의 위치로 이동합니다.

            #endregion


            #endregion

            #region 사분면
            //int x = -1;
            //int y = 5;
            //
            //if(x>0 && y>0)
            //{
            //    Console.WriteLine("제 1사분면");
            //}
            //
            //else if(x<0 && y>0)
            //{
            //    Console.WriteLine("제 2사분면");
            //}
            //
            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine("제 3사분면");
            //}
            //
            //else if (x > 0 && y < 0)
            //{
            //    Console.WriteLine("제 4사분면");
            //}
            //
            //else
            //{
            //    if(x==0&& y==0)
            //    { Console.WriteLine("원점"); }
            //
            //    else
            //    {
            //        if(x==0)
            //        { Console.WriteLine("y절편 (0," + y + ")"); }
            //
            //        else if(y==0)
            //        { Console.WriteLine("x절편 (" + x + ",0)"); }
            //    }
            //}
            #endregion
        }
    }
}
