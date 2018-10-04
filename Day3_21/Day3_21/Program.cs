using System;
using System.Threading;

namespace Day3_21
{
    public class ThreadTest3
    {
        public static Mutex mutex = new Mutex(); 
        public string lockstring = "hello";

        public void Print(string rank)
        {
            //lock (obj)
            //Monitor.Enter(obj);
            mutex.WaitOne(); 
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Thread.Sleep(100);
                        Console.Write(",");
                    }
                    Console.WriteLine("{0}{1}", rank, lockstring);

                }
            }
            //Monitor.Exit(0);
            mutex.ReleaseMutex(); 
        }

        public void FirstWork() { Print("F"); }
        public void SecondWork() { Print("S"); }

    }

    class TestMain
    {
        [MTAThread]
        public static void Main()
        {
            ThreadTest3 t = new ThreadTest3();
            Thread first = new Thread(new ThreadStart(t.FirstWork));
            Thread second = new Thread(t.SecondWork);

            first.Start();
            second.Start(); 
        }
    }

}
