using System;

namespace Day3_5
{
    public class Delegate1
    {
        private delegate int OnjSum(int i, int j);

        static void Main(string[] args)
        {
            OnjSum myMethod = new OnjSum(Delegate1.Sum);
            //OnjSum myMethod = new OnjSum(Sum);
            //OnjSum myMethod = Sum; 
            Console.WriteLine("두수의 합 : {0}", myMethod(10, 30));
        }

        static int Sum(int i, int j)
        {
            return i + j; 
        }
    }
}
