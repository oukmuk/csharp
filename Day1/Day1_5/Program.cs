using System;

namespace Day1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sum(1, 2));
            Console.WriteLine(sum(1, 2, 3));
        }

        static int sum(params int[] args)           // 가변길이 파라메터 
        {
            int sum = 0; 
            foreach (int i in args) sum += i;
            return sum; 
        }
    }
}
