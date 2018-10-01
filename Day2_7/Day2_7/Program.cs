/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_7
{
    class SumTest<T>
    {
        public T Sum(T i, T j)
        {
            return (dynamic)i + (dynamic)j; 
        }
    }

    class SumMain
    {
        static void Main()
        {
            SumTest<int> s1 = new SumTest<int>();
            Console.WriteLine("정수의 합 : {0} + {1} = {2}", 1, 2, s1.Sum(1, 2));

            SumTest<double> s2 = new SumTest<double>();
            Console.WriteLine("실수의 합 : {0:f} + {1:f} = {2:f}", 1.0, 2.0, s2.Sum(1.0, 2.0));

        }
    }
}
*/

/*
using System;
using System.Collections.Generic;
using System.Text; 

namespace GenericMethod
{
    class MainApp
    {
        static T[] GetArray<T>(int size, T val)
        {
            T[] array = new T[size];
            for(int i=0; i < size; i++)
            {
                array[i] = val; 
            }
            return array; 
        }

        static void Main(string[] args)
        {
            string[] str_array = GetArray<string>(3, "test test test");
            foreach (string s in str_array) Console.WriteLine(s);

            int[] int_array = GetArray<int>(3, 999);
            foreach (int i in int_array) Console.WriteLine(i); 
        }
    }
}
*/

using System;

using System.Collections;

using System.Collections.Generic;

namespace ConsoleApplication6

{
    class Stack<T>
    {
        int top = 0;

        T[] ar = new T[10];

        public void Push(T obj)
        {
            ar[top] = obj;

            top++;
        }

        public T Pop()
        {
            top--;

            return ar[top];
        }
    }

   
    class StackTest

    {
        static void Main()
        {
            //Stack1 s1 = new Stack1();
            Stack<int> s1 = new Stack<int>();
            s1.Push(1);

            s1.Push(2);

            s1.Push(3);

            Console.WriteLine(s1.Pop());

            Console.WriteLine(s1.Pop());

            Console.WriteLine(s1.Pop());



            // Stack2 s2 = new Stack2();
            Stack<string> s2 = new Stack<string>();
            s2.Push("KOREA");

            s2.Push("대한민국");

            s2.Push("서울");

            Console.WriteLine(s2.Pop());

            Console.WriteLine(s2.Pop());

            Console.WriteLine(s2.Pop());

        }

    }

}