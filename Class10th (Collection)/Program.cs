using System.Collections;
namespace Class10th__Collection_
{
    public class Vector<T>
    {
        private T[] array;

        public Vector()
        {
            array = new T[5];
        }

        public T Array
        {
            get { return array[0]; }
            set { array[0] = value; }
        }
    }

    internal class Program
    {
        public static void Debug<T>(T data)
        {
            Console.WriteLine("data 변수의 값 : " + data);
        }
        static void Main(string[] args)
        {

            #region 일반화 프로그래밍
            // 특정 데이터 타입에 의존하지 않고,
            // 모든 타입을 멤버 변수의 타입으로 설정할 수 있는 프로그래밍 기법

            //Debug<int>(10);
            //Debug(20.2f);
            //Debug('a');
            //Debug("Hello");

            //Vector<int> vector=new Vector<int>();

            //vector.Array = 20;

            //Console.WriteLine("vector의  [0] index 값 : " + vector.Array);



            //C++ 템플릿은 사용하지 않으면 컴파일을 하지 않습니다. -> 컴파일이 1번 일어납니다.
            //C# 제네릭은 사용하지 않더라도 그에 관련된 정보를 저장하기 위해 .meta이 생성됩니다.->컴파일이 2번 일어납니다.

            #endregion

            #region 컬렉션
            // 많은 데이터 요소를 효율적으로 관리하기 위한 자료 구조입니다.
            // Array List, Linked List, Stack, Queue, HashTable, Dictionary
            // *이동 생성자

            #region List

            //List<int> list = new List<int>();

            //list.Capacity = 5;
            //list.Add(10); //[10] [ ]  [ ]  [ ] [ ]
            //list.Add(20); //[10] [20] [ ]  [ ] [ ]
            //list.Add(30); //[10] [20] [30] [ ] [ ]
            //list.Remove(30); //[10] [20] [ ]  [ ] [ ]
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine("list[" + i + "] : " + list[i]);
            //}



            //Console.WriteLine("list의 Count 값 : " + list.Count);
            //Console.WriteLine("list의 Capacity 값 : " + list.Capacity);

            #endregion

            #region Linked List
            // Node = data+Node를 가리키는 참조변수(Node next)
            // O(n)의 시간 복잡도를 가짐
            // 캐시->임시 저장소

            //LinkedList<int> linkedList= new LinkedList<int>();

            //linkedList.AddFirst(10); //[10]
            //linkedList.AddFirst(20); //[20] -> [10]
            //linkedList.AddLast(30);  //[20] -> [10] -> [30]

            //linkedList.Remove(10);

            //foreach(int element in linkedList)
            //{
            //    Console.WriteLine(element);
            //}

            //Console.WriteLine("linked List의 Count값 : "+linkedList.Count);

            #endregion

            #region Stack(LIFO)
            // 컨테이너 어댑터

            //Stack<int> stack = new Stack<int>();
            //stack.Push(10); // [10] 
            //stack.Push(20); // [20] [10]
            //stack.Push(30); // [30] [20] [10] 
            //stack.Push(40); // [40] [30] [20] [10] 
            //stack.Push(50); // [50] [40] [30] [20] [10]

            ////stack.Pop();
            //Console.WriteLine("Stack의 Top 값 : " + stack.Peek());

            //for(; stack.Count!=0;)
            //{
            //    Console.WriteLine(stack.Peek());
            //    stack.Pop();
            //}

            #endregion

            #region Queue(FIFO)

            //Queue<int> queue= new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //queue.Dequeue();
            //Console.WriteLine("queue의 Count : "+queue.Count);
            //foreach(int element in queue)
            //{
            //    Console.WriteLine("element의 값 : "+element);
            //}


            #endregion

            #region Dictionary
            // Data를 Key와 Value로 저장
            //Dictionary<string,int> dictionary= new Dictionary<string,int>();
            //dictionary.Add("Sword", 10000);
            //dictionary.Add("Gloves", 7500);
            //dictionary.Add("Shose", 2500);         
            //dictionary.Add("Armor", 7500);
            ////dictionary.Add("Shose", 2500);//Dictionary는 키 값의 중복을 허용하지 않습니다.

            //if (dictionary.ContainsKey("Swobrd"))
            //    Console.WriteLine("키 값이 존재합니다.");
            //else
            //    Console.WriteLine("키 값이 존재하지 않습니다.");


            //foreach (KeyValuePair<string,int> item in dictionary) {
            //    Console.WriteLine("item의 Key 값 : " + item.Key);
            //    Console.WriteLine("item의 Value 값 : " + item.Value+"\n");
            //}
            #endregion



            #endregion
        }
    }
}
