using System;

namespace ConsoleApplication3

{
    class Program

    {
        static void Main(string[] args)
        {

            //가변배열, 처음방에는 1,2 두번째방에는 1,2,3 세번째방에는 1,2,3,4

            int[][] a = new int[3][];
            a[0] = new int[2] { 1, 2 };
            a[1] = new int[3] { 1, 2, 3 };
            a[2] = new int[4] { 1, 2, 3, 4 };

            //3행 2열, 이차원배열 1행은 (1,2), 2행은 (3,4), 3행은 (5,6)

            int[][] b = new int[3][];
            b[0] = new int[2] { 1, 2 };
            b[1] = new int[2] { 3, 4 };
            b[2] = new int[2] { 5, 6 };

            //가변배열 출력
            for (int i = 0; i < a.Length; i++)
            {
                System.Console.Write("element {0} => ", i);
                for (int j = 0; j < a[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", a[i][j], j == (a[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }      

            Console.WriteLine("\n---------------\n");

            //이차원 배열 출력
            for (int i = 0; i < b.Length; i++)
            {
                System.Console.Write("element {0} => ", i);
                System.Console.Write("{0}, {1}", b[i][0], b[i][1]);
                System.Console.WriteLine();
            }
        }
    }
}