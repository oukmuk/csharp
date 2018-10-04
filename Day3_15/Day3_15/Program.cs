using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            var result = numbers.Aggregate((a, b) => a * b);
            Console.WriteLine("Aggregation = " + result);

            // 초기값 10 
            result = numbers.Aggregate(10, (a, b) => a + b);
            Console.WriteLine("Aggregation with seed = " + result);

            result = numbers.Where(num => num % 2 == 0).Aggregate((a, b) => a * b);
            Console.WriteLine("Aggregation.where = " + result);

        }
    }
}
