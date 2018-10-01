using System;
using System.Collections;

namespace Day2_8
{
    class SamplesArrayList 
    {
        static void Main()
        {
            ArrayList onj = new ArrayList();
           // List<string> onj = new List<string>(); 

            onj.Add("onj");
            onj.Add("OracleJava");
            onj.Add("Community");

            Console.WriteLine("onj list");
            Console.WriteLine("Count :     {0}", onj.Count);
            Console.WriteLine("Capacity :  {0}", onj.Capacity);

            Console.WriteLine("onj values");
            PrintValue(onj);

            ArrayList onj2 = (ArrayList)onj.Clone();
            Console.Write("onj2 values");
            PrintValue(onj2);
        }

        public static void PrintValue(IEnumerable myList)
        {
            foreach (Object obj in myList) Console.Write("          { 0}", obj);
            Console.WriteLine(); 
        }
    }
}
