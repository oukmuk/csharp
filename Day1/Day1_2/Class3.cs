using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_2
{
    struct strEmp
    {
        public int id;
        public string name; 
    }

    class strEmpTest
    {
        public static void Main()
        {
            strEmp e;
            e.id = 1;
            e.name = "홍길동";
            Console.WriteLine("사번: {0}", e.id);
            Console.WriteLine("이름: {0}", e.name);

            strEmp e1 = new strEmp();
            e1.id = 2;
            e1.name = "홍길동2";
            Console.WriteLine("사번: {0}", e1.id);
            Console.WriteLine("이름: {0}", e1.name);
        }
    }
}
