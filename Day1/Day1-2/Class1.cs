namespace AsTest
{
    class Emp
    {
        public override string ToString()
        {
            return "Emp";
        }
    }

    class Programmer : Emp { }

    class Program
    {
        static void Main()
        {
            Programmer p = new
            Programmer();
            Emp e = p as Emp;  // 형변환 실패시 Null 리턴 
            if (e != null)
            {
                System.Console.WriteLine(e.ToString());
                System.Console.WriteLine(e);
            }
        }
    }
}
 
