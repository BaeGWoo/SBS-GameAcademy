namespace Class2th_Bit_
{
    internal class Program
    {
        //Main 함수는 프로그램의 진입점 역활을 수행하는 함수입니다.
        static void Main(string[] args)
        {
            #region 변수의 이름 규칙
            // 1. 변수의 경우 중복된 변수의 이름을 허용하지 않습니다.
            // ex) int x = 10;
            // ex) int x = 20;


            // 2. 변수의 이름은 대소문자를 구분하여 사용할 수 있습니다.
            // ex) int y = 10;
            // ex) int Y = 20;

            // 3. 변수의 이름으로 예약어를 사용할 수 없습니다.
            // ex) int float= 20;

            // 4.변수의 이름은 숫자로 시작할 수 없습니다.
            // ex) int directX9 = 10;
            // ex) int 5direct = 20;

            // 5. 변수의 이름으로 공백을 포함할 수 없습니다.
            // ex) int Count Down = 10;

            // 6. 변수의 이름으로 특수 문자는 _만 사용할 수 있습니다.
            // ex) int count_Down = 10;
            #endregion

            #region 상수
            // 프로그램이 실행되는 동안 더 이상 변경할 수 없는 
            // 메모리 공간입니다.

            //const int data = 10;
            //data = 2;
            //Console.WriteLine("상수 data의 값 : "+data);

            // 상수는 메모리 공간을 생성하는 동시에 초기화해야 하며,
            // 한 번 저장된 값은 더 이상 변경할 수 없습니다.

            //리터럴 상수 : 메모리 공간을 가지고 있지 않은 상수
            // 값 그자체를 의미 ex)const int data=10에서 10을 의미;


            //심볼릭 상수 : 메모리 공간을 가지고 있는 상수
            //ex) const int data=10;에서 data를 의미



            #endregion

            #region 산술연산자
            //int result1= 변수 + 변수
            //int result2= 변수 - 리터럴 상수
            //int result3= 리터럴 상수 * 심볼릭 상수
            //int result4= 변수 / 심볼릭 상수
            //int result5= 리터럴 상수 % 리터럴 상수
            //int n1 = 10;
            //const int n2 = 5;
            //int result1 = n1 + n1;
            //int result2 = n1 - 5;
            //int result3 = 5 * n2;
            //int result4 = n1 / n2;
            //int result5 = 5 % 5;
            //Console.WriteLine("result1 : "+result1);
            //Console.WriteLine("result2 : " + result2);
            //Console.WriteLine("result3 : " + result3);
            //Console.WriteLine("result4 : " + result4);
            //Console.WriteLine("result5 : " + result5);
            #endregion

            #region 비트
            // 데이터를 나타내는 최소 단위이며, 0 또는 1의 조합으로
            // 논리 계산을 수행하는 단위입니다.

            // 메모리는 비트 단위로 데이터를 저장할 수 있으며,
            // 1개의 비트에는 0 또는 1의 값만 저장할 수 있습니다.

            #region 10진수를 2진수로 변환하는 과정
            //10진수를 1이 될 때까지 계속 2로 나누어 준 다음
            //나눈 위치의 나머지 값을 아래에서 위로 순서대로 정렬합니다.
            //23=0 0 0 1 0 1 1 1
            #endregion

            #region 2진수를 10진수로 변환하는 과정
            // 1byte에 2진수로 저장된 값을 2의 제곱으로 나타내며,
            // 각각의 비트에 1이 있다면 1과 2의 제곱의 위치를 계산한 다음
            // 각각의 비트를 모두 더하여 10진수로 나타냅니다.

            #endregion


            #endregion

            #region 비트 연산자
            //비트 단위로 논리 연산을 수행하기 위해 사용하는 연산자입니다.
            // int a = 15;//0000 1111
            // int b = 10;//0000 1010

            // 1. AND 연산자 =>비교하는 두 비트가 모두 1일 때 1을 반환
            //Console.WriteLine("a변수와 b변수를 AND연산 : "+(a & b));

            // 2. OR 연산자 =>비교하는 두 비트 중 하나라도 1이면 1을 반환
            //Console.WriteLine("a변수와 b변수를 OR연산 : " + (a | b));

            // 3. XOR 연산자 =>비교하는 두 비트가 같으면 0을 다르면 1을 반환
            //Console.WriteLine("a변수와 b변수를 XOR연산 : " + (a ^ b));

            // 4. NOT 연산자 =>0인 비트는 1로 1인 비트는 0으로 반전
            //0000 1111 => 1111 0000 ==>-128+64+32+16=-16
            //첫 번째 비트는 부호를 나타내며, 첫 번째 비트에 1이 있다면
            //값은 음수가 됩니다.
            //Console.WriteLine("a변수를 NOT연산 : " + (~a));

            #endregion

            #region 시프트 연산자
            // 0과 1로 이루어진 2진수를 왼쪽 또는 오른쪽으로
            // 원하는 자리만큼 이동하는 연산자입니다.

            // int money = 10;//0000 1010
            // Console.WriteLine("money 변수를 왼쪽으로 2번 shift 연산한 결과"+(money << 2));//0010 1000
            // Console.WriteLine("money 변수를 오른쪽으로 2번 shift 연산한 결과" + (money >> 2));//0000 0010

            #endregion

        }
    }
}
