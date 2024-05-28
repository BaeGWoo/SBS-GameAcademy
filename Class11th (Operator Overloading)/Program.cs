namespace Class11th__Operator_Overloading_
{
    internal class Program
    {
        public class Player
        {
            private int x;
            private int y;

            public int X
            {
                get { return x; }
                set { x = value; }
            }

            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            public float distance(int x, int y)
            {
                double result = 0;

                result = Math.Sqrt(Math.Pow(x - this.x, 2) + Math.Pow(y - this.y, 2));

                return (float)result;
            }
        }
        public class Position
        {
            public void Update()
            {
                Console.WriteLine("60 FPS");
            }
        }//Position

        public class Vector2 : Position
        {
            private int x;
            private int y;

            public Vector2()
            {
                base.Update();//base->부모의 this->자신의
                //Update();
            }

            public int X
            {
                get { return x; }
                set { x = value; }
            }

            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            static public Vector2 operator +(Vector2 left, Vector2 right)
            {
                Vector2 result = new Vector2();
                result.X = left.X + right.X;
                result.Y = left.Y + right.Y;

                return result;
            }



        }//Vector2

        static void View(int health)
        {
            for (int i = 0; i < health; i++)
            {
                Console.Write("♥ ");
            }
        }



        static void Main(string[] args)
        {


            #region 리듬게임
            //Stack<char> conatiner=new Stack<char>();
            ////List -> push_back && pop이라 더욱 편리하게 구현 가능
            //char[] Arrow = new char[4]{ '↑', '↓', '→', '←' };
            ////char[] Container=new char[4];
            //int hp = 3;
            //int level = 10;
            //Random random = new Random();
            //ConsoleKeyInfo key = Console.ReadKey(true);
            //for (int i=0;i< level;i++)
            //{
            //    conatiner.Push(Arrow[random.Next(0, 4)]);
            //}

            //while (true)
            //{
            //    //Console.WriteLine("[ hp : " + hp + " ]\n\n");
            //    View(hp);
            //    Console.WriteLine("\n\n");
            //   foreach(char c in conatiner.Reverse())
            //    {
            //        Console.Write("["+c+"] ");
            //    }
            //   Console.WriteLine("\n\n");
            //    char cur=' ';

            //    switch (key.Key)
            //    {
            //        case ConsoleKey.UpArrow:
            //            cur = '↑';
            //            break;

            //        case ConsoleKey.LeftArrow:
            //            cur = '←';
            //            break;

            //        case ConsoleKey.RightArrow:
            //            cur = '→';
            //            break;

            //        case ConsoleKey.DownArrow:
            //            cur = '↓';
            //            break;
            //    }

            //    if (cur == conatiner.First())
            //    {
            //        conatiner.Pop();
            //    }
            //    else
            //        hp--;

            //    if (hp == 0)
            //    {
            //        Console.WriteLine("실패");
            //        break;
            //    }

            //    if(conatiner.Count == 0)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("성공");
            //        break;
            //    }
            //    Console.Clear();



            //}
            #endregion

            #region 두 점 사이의 거리
            //int x = 0;
            //int y = 0;
            //int Ex = 5;
            //int Ey = 3;

            //Player player = new Player();
            //Player enemy = new Player();
            //player.X = x;
            //player.Y = y;  

            //enemy.X = Ex;
            //enemy.Y = Ey;

            //float dis=player.distance(enemy.X, enemy.Y);
            //if (dis <= 2.5f)
            //{
            //    Console.WriteLine("공격 범위에 들어왔습니다.");
            //}
            //else
            //    Console.WriteLine("공격 범위에서 벗어났습니다.");

            //Console.WriteLine(dis);

            #endregion

            #region 연산자 오버로딩
            //Vector2 vector1 = new Vector2();
            //Vector2 vector2 = new Vector2();

            //vector1.X = 5;
            //vector1.Y = 10;

            //vector2.X = 10;
            //vector2.Y = 20;

            //Vector2 vector3 = vector1 + vector2;
            //Console.Write("vector1 (" + vector1.X + " , " + vector1.Y + ") + ");
            //Console.WriteLine("vector2 (" + vector2.X + " , " + vector2.Y + ")");
            //Console.WriteLine("= vector3 (" + vector3.X + " , " + vector3.Y + ")");

            #endregion


        }
    }
}
