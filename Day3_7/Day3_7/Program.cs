using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatetest
{
    delegate void OnjDelegate(int a, int b);

    class MainApp
    {
        static void Plus(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        static void Minus(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        static void Multiple(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }

        static void Divison(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }

        // 델리게이트 체인 예제 
        static void Main(string[] args)
        {
            MainApp m = new MainApp();
            //OnjDelegate CallBack = (OnjDelegate)Delegate.Combine(
            //                                        new OnjDelegate(MainApp.Plus),
            //                                       new OnjDelegate(MainApp.Minus),
            //                                        new OnjDelegate(MainApp.Multiple),
            //                                        new OnjDelegate(MainApp.Divison));

            /*
            OnjDelegate CallBack = new OnjDelegate(MainApp.Plus);
            CallBack += new OnjDelegate(MainApp.Minus);
            CallBack += new OnjDelegate(MainApp.Multiple);
            CallBack += new OnjDelegate(MainApp.Divison);
            */

            OnjDelegate CallBack1 = new OnjDelegate(MainApp.Plus);
            OnjDelegate CallBack2 = new OnjDelegate(MainApp.Minus);
            OnjDelegate CallBack3 = new OnjDelegate(MainApp.Multiple);
            OnjDelegate CallBack4 = new OnjDelegate(MainApp.Divison);

            OnjDelegate CallBack = CallBack1 + CallBack2 + CallBack3 + CallBack4;
            CallBack(4, 3);
        }
    }
}
