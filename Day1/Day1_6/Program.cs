using System;

namespace Day1_6
{
    class Tester
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Minus(1, 2));
            Console.WriteLine(Minus(1));
            Console.WriteLine(Minus(i:8, j:9));
            Console.WriteLine(Minus());
        }

        static int Minus(int i = 0, int j = 0)
        {
            return i - j; 
        }
    }
}
