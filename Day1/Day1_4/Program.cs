using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요");
            int mok; 

            string strnum = Console.ReadLine();
            string na = ""; 

            bool parsed = Int32.TryParse(strnum, out mok);

            if (!parsed)
            {
                Console.WriteLine("input error");
                Environment.Exit(0);
            }

            if(mok == 0)
            {
                Console.WriteLine("{0}의 이진수는 0 입니다", strnum);
            }
            else
            {
                while (mok > 0)
                {
                    na = (mok % 2) + na;
                    mok = mok / 2;
                }

                Console.WriteLine("{0}의 이진수는 {1} 입니다", strnum, na);
            }
        }
    }
}
