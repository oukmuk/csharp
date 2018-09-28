using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_2
{
    class Rtype
    {
        public object Value; 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rtype a = new Rtype();
            Rtype b = new Rtype();

            a.Value = 1;
            b = a; 
            Console.WriteLine(a.Value);
            Console.WriteLine(b.Value);


            b.Value = 2;
            Console.WriteLine(a.Value);
            Console.WriteLine(b.Value);
        }
    }
}

