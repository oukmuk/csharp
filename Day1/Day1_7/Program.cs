using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_7
{
    class Emp
    {
        /*
        public void SetName(string name)
        {
            this.name = name; 
        }
        public string GetName()
        {
            return name; 
        }
        */
        public string Name
        {
            /*
            get
            {
                return name; 
            }
            set
            {
                name = value; 
            }
            */
            get;
            set; 
        }
    }
    class EmpTest
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e.Name = "홍길동";
            Console.WriteLine(e.Name);
        }
    }
}
