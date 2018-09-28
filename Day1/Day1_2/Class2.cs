using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_2
{
    enum Day1
    {
        Monday, thusday, Wendesday, Thursday, Friday, Saturday, Sunday
    }

    enum Day2 : byte
    {
        Monday = 11, Thesday, Wednesday, Friday, Saturday, Sunday = Monday + 100
    }

    public class EnumTest 
    {
        static void Main()
        {
            Day1 WhatDay = Day1.Sunday;
            Console.WriteLine("{0}", WhatDay);
            Console.WriteLine("{0}", (byte)WhatDay);

            WhatDay = (Day1)6;
            Console.WriteLine("{0}", WhatDay);

            Day2 whatDay2 = Day2.Monday;
            Console.WriteLine("{0}", whatDay2);
            Console.WriteLine("{0}", (byte)whatDay2);

            whatDay2 = (Day2)255;
            Console.WriteLine("{0}", whatDay2);
        }
    }
}
