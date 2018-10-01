using System;

using System.Collections.Generic;

namespace ConsoleApplication17

{
    class Program
    {
        static void Main(string[] args)
        {
            //----4행2열
            int[,] twoDim = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            for (int i=0; i < twoDim.GetLength(0) ; i++ )
            {
                System.Console.Write("{0}{1}", twoDim[i,0], twoDim[i, 1]);     
            }
            Console.WriteLine();

            foreach (int i in twoDim)
            {
               System.Console.Write(i);
            }
        }
    }
}
