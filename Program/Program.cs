namespace Program
{


    internal class Program
    {
        class Screen
        {

            private readonly int width = 80;
            private readonly int height = 30;

            public Screen()
            {
                Console.SetWindowSize(width, height);
            }
        }

        public class Player
        {
            int x;
            int y;

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

            public void Move(string[,] maze, int dirx, int diry)
            {
                if ((x + dirx > 0 && x + dirx < maze.GetLength(1)) &&
                    (y + diry > 0 && y + diry < maze.GetLength(0)))
                {
                    maze[x, y] = "  ";
                    maze[x + dirx, y + diry] = "◎";
                    x += dirx;
                    y += diry;
                }

            }
        }

        class Bullet
        {
            private int[] damage = new int[10];

            public int this[int index]
            {
                get { return damage[index]; }
                set { damage[index] = value; }
            }
        }

            static void Main(string[] args)
            {

            #region 좌표 이동 함수
            //Screen screen = new Screen();

            //int curx = 4;
            //int cury = 4;
            //Console.SetCursorPosition(5, 5);
            //Console.Write("a");
            //while (true)
            //{
            //    Console.SetCursorPosition(curx, cury);
            //    Console.Write("★");
            //    ConsoleKeyInfo key = Console.ReadKey(true);

            //    switch (key.Key)
            //    {
            //        case ConsoleKey.UpArrow:
            //            cury-=2;
            //            break;

            //        case ConsoleKey.DownArrow:
            //            cury+=2;
            //            break;

            //        case ConsoleKey.LeftArrow:
            //            curx-=2;
            //            break;

            //        case ConsoleKey.RightArrow:
            //            curx+=2;
            //            break;
            //    }

            //    Console.Clear();
            //    if (curx <= 0)
            //        curx = 0;
            //    if (curx >= 99)
            //        curx = 98;
            //    if (cury <= 0)
            //        cury = 0;
            //    if (cury >= 30)
            //        cury = 29;

            //}

            #endregion

            #region 이차원 배열
            // 배열의 요소로 또 다른 배열을 가지는 배열입니다.

            //int[,] array2D = new int[3, 4]{
            //    { 1,2,3,4},
            //    { 5,6,7,8},
            //    { 9,0,1,2}
            //};

            //for (int i = 0; i < array2D.GetLength(0); i++)
            //{
            //    for(int j=0;j< array2D.GetLength(1); j++)
            //    {
            //        Console.Write(array2D[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}


            // 2차원 배열은 행과 열로 구분되며,
            // 앞에 있는 배열은 열을 의미하고,
            // 뒤에 있는 배열은 행을 의미합니다.

            #endregion

            #region Maze Game
            //string[] option= new string[5] { "▣","  ", "  ", "★" ,"◎"};
            //Random random= new Random();
            //Player player = new Player();
            //string[,] maze = new string[11, 11];

            //for(int i=0;i< maze.GetLength(1); i++)
            //{
            //    maze[0, i] = option[0];
            //}//미로의 테두리

            //for(int i=1; i<maze.GetLength(0); i++)
            //{
            //    maze[i, 0] = option[0];
            //    for(int j = 1; j < maze.GetLength(1); j++)
            //    {                
            //        maze[i,j]=option[random.Next(0, 3)];
            //    }
            //    maze[i, maze.GetLength(1) - 1] = option[0];
            //}//미로 내부 구조

            //for (int i = 0; i < maze.GetLength(1); i++)
            //{
            //    maze[maze.GetLength(0)-1, i] = option[0];
            //}//미로의 테두리


            //int GX = random.Next(1, 10);
            //int GY = random.Next(1, 10);
            //maze[GX, GY] = option[3];

            //player.X = random.Next(1, 10);
            //player.Y = random.Next(1, 10);
            //maze[player.X, player.Y] = option[4];

            //while (true)
            //{
            //    for (int i = 0; i < maze.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < maze.GetLength(1); j++)
            //        {
            //            Console.Write(maze[i, j]);
            //        }
            //        Console.WriteLine();
            //    }

            //    ConsoleKeyInfo key = Console.ReadKey(true);

            //    switch (key.Key)
            //    {
            //        case ConsoleKey.UpArrow:
            //            if (maze[player.X-1, player.Y] != "▣")
            //                player.Move(maze, -1, 0);

            //            break;

            //        case ConsoleKey.DownArrow:
            //            if (maze[player.X+1, player.Y] != "▣")
            //                player.Move(maze, 1, 0);

            //            break;

            //        case ConsoleKey.LeftArrow:
            //            if (maze[player.X, player.Y-1] != "▣")
            //                player.Move(maze, 0, -1);

            //            break;

            //        case ConsoleKey.RightArrow:
            //            if (maze[player.X, player.Y+1] != "▣")
            //                player.Move(maze, 0, 1);

            //            break;
            //    }

            //    Console.Clear();

            //    if (player.X==GX&&player.Y==GY)
            //    {
            //        Console.WriteLine("Victory");
            //        break;
            //    }
            //}


            #endregion

            #region 인덱서

            // 객체의 인스턴스 변수에 대한 배열 형태의 접근 방법을 제공하는 기능입니다.
            //Bullet bullet = new Bullet();
            //for (int i = 0; i < 10; i++)
            //{
            //    bullet[i] = i + 1;
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write(bullet[i] + " ");
            //}

            #endregion

            #region 무명 형식
            //var gameObject = new { id = 100, name = "GameObject", grade = 'A' };
            //// 무명 형식의 경우 데이터를 접근하는 것은 불가능하지만,
            //// 데이터를 출력하는 형태는 가능합니다.

            //Console.WriteLine(gameObject.id);
            //Console.WriteLine(gameObject.name);
            //Console.WriteLine(gameObject.grade);
            #endregion
        }
    }
    
}
