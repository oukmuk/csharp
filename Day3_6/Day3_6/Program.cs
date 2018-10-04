using System;

namespace Day3_6
{
    class Program
    {
        //public delegate int MyDelegate(int i, int j);

        public static void TakesADelegate(Func<int, int, int> SomeFunction)
        {
            Console.WriteLine(SomeFunction(1,2));
        }

        static void Main()
        {
            TakesADelegate(new Func<int, int, int>(Add));
            TakesADelegate(new Func<int, int, int>(Minus));
            TakesADelegate(new Func<int, int, int>(Gop));
            TakesADelegate(new Func<int, int, int>(Nanugi));
        }

        public static int Add(int i, int j)
        {
            return i + j; 
        }
        public static int Minus(int i, int j)
        {
            return i - j; 
        }
        public static int Gop(int i, int j)
        {
            return i * j; 
        }
        public static int Nanugi(int i, int j)
        {
            return i / j; 
        }
    }
}
