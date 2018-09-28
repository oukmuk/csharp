using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_2
{
    class Emp
    {
        internal int empno; 

        internal void GoToOffice()
        {
            Console.WriteLine(empno + "사원이 출근");
        }
    }

    class EmpTest
    {
        static void Main()
        {
            int num = 1001;
            Emp e = new Emp();
            e.empno = num;
            e.GoToOffice(); 
            Console.WriteLine(e);
        }
    }
}
