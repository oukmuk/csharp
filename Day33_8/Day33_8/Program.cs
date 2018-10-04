using System;

namespace Day33_8
{
    class Program
    {
        //delegate void Calc(int i, int j);

        static void Main(string[] args)
        {
            Action<int, int> c = new Action<int, int>(MySum);
            Console.WriteLine("1 + 2=");
            c(1, 2);

            // 델리게이트 익명 메소드 (델리게이트 선언이 필요없다)
            Action<int, int> c1 = delegate (int i, int j)
            {
                Console.WriteLine(i+j);
            };
            Console.WriteLine("3 + 4 = ");
            c1(3, 4);

            //람다식 (델리게이트 선언이 필요없다) 
            Action<int, int> c2 = (int i, int j) =>
            {
                Console.WriteLine("3 + 4=" + i + j);
            };
            Console.WriteLine("3+4 = ");
            c2(3, 4);
        }

        static void MySum(int i, int j)
        {
            Console.WriteLine(i + j); 
        }
    }
}
