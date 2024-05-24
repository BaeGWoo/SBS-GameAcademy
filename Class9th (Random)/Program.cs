namespace Class9th__Random_
{
    internal class Program
    {
        public delegate void Calculator(int x, int y);
        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void Substract(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        static void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        static void Divide(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        public class Computer : IMouse, IKeyboard
        {
            private int value;

            public int Value
            {
                get { return value; }
                set { this.value = value; }
            }

            public void Input()
            {
                Console.WriteLine("Input Keyboard");
            }

            public void Select()
            {
                Console.WriteLine("Select Mouse");
            }
        }

        abstract public class Vehicle
        {
            private string name;
            private float speed;

            abstract public void Move();

        }

        public class Bicycle : Vehicle
        {
            public override void Move()
            {
                Console.WriteLine("Bicycle Move");
            }
        }

        public class Motorcycle : Vehicle
        {
            public override void Move()
            {
                Console.WriteLine("Motorcycle Move");
            }
        }

        public interface IMouse
        {
            void Select();
        }

        public interface IKeyboard
        {
            public void Input();
        }

        static void HP(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("♥ ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            #region 랜덤 함수
            //Random random = new Random();

            //while(true)
            //{
            //    int result = random.Next(0, 2);

            //    Console.WriteLine("result 변수의 값 : " + result);

            //    Console.ReadLine();

            //    Console.Clear();
            //}

            //while(true)
            //{
            //    int count=Convert.ToInt32(Console.ReadLine());

            //    Console.Clear();

            //    HP(count);


            //}

            #endregion

            #region ASCII 코드
            // 미국 국가표준 협회에서 표준화한
            // 정보 교환용 7 bit 부호체계입니다.

            // 문자 인코딩
            // 복잡한 신호를 0과 1의 디지털 신호로 변환하는 것입니다.

            //char alphabet = 'A';

            //for(int i = (int)'A'; i < (int)'Z'+1; i++)
            //{
            //    Console.Write((char)i+" ");
            //    //Console.Write((char)('A'+i));
            //}

            //Console.WriteLine("\nalphabet 변수의 값 : " + (int)alphabet);
            #endregion

            #region UP-DOWN 게임
            //Random random = new Random();
            //Computer computer = new Computer();
            //computer.Value = random.Next(1, 31);
            ////int value = random.Next(1, 31);

            //int answer = -1;
            //int life = 5;
            //while (answer!= computer.Value)
            //{
            //    Console.WriteLine(" ---------LIFE---------");
            //    Console.Write("|    ");
            //    for (int i = 0; i < life; i++)
            //    {
            //        Console.Write("■ ");
            //    }
            //    Console.WriteLine("\n ----------------------\n");



            //    if (answer != -1)
            //    {
            //        if (answer > computer.Value)
            //        {
            //            Console.WriteLine("\n당신의 예측("+answer+")보다 숫자가 작습니다.\n");
            //        }

            //        else
            //        {
            //            Console.WriteLine("\n당신의 예측("+answer+")보다 숫자가 큽니다.\n");
            //        }
            //    }

            //    Console.WriteLine("\n숫자를 예측해 주세요 : ");

            //    answer=Convert.ToInt32(Console.ReadLine());

            //    if(answer!= computer.Value)
            //    {
            //        life--;
            //        Console.Clear();    
            //    }

            //    else
            //    {
            //        Console.WriteLine("축하합니다!!!");
            //    }

            //    if (life <= 0)
            //    {
            //        Console.WriteLine("당신의 life가 모두 소진되었습니다.");
            //        break;
            //    }
            //}
            #endregion

            #region 추상 클래스
            // 추상 함수를 선언한 다음 상속을 통해 하위 클래스에서 
            // 함수를 완성하도록 유도하는 클래스입니다.

            // Vehicle vehicle = new Vehicle();
            // 추상 클래스는 인스턴스를 할 수 없습니다.

            //Bicycle bicycle=new Bicycle();
            //bicycle.Move();

            //Motorcycle motorcycle=new Motorcycle();
            //motorcycle.Move();

            #endregion

            #region 인터페이스
            //Computer computer=new Computer();

            //computer.Select();
            //computer.Input();

            #endregion

            #region 대리자
            // 함수의 주소 값을 저장한 다음 함수를 대신 호출하는 기능입니다.

            //Calculator calculator;

            //calculator = Add;
            //calculator(10, 20);
            //calculator = Substract;
            //calculator(10, 20);
            //calculator = Multiply;
            //calculator(10, 20);
            //calculator = Divide;
            //calculator(20, 10);

            //대리자는 함수의 반환형과 매개 변수의 타입이 일치해야 합니다.
            //접근지정자/delegate/반환형/델리게이트의 이름


            #endregion

            #region 델리게이트 체인
            // 하나의 호출자에 여러 개의 함수를 등록해서 사용하는 기법입니다.

            //Calculator calculator;

            //calculator = Add;
            //calculator += Substract;
            //calculator += Multiply; 
            //calculator += Divide;
            //calculator(20, 10);

            //Console.WriteLine("-----------------------------------");
            //calculator -= Substract;
            //calculator(20, 10);
            #endregion


        }
    }
}
