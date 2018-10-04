using System;
using System.Threading; 

namespace Day3_18
{

    public class ThreadTest2
    {
        public bool sleep = false;

        static AutoResetEvent autoEvent = new AutoResetEvent(false);

        public void FirstWork()
        {
            for(int i=0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.Write("F{0}", i);

                if(i == 5)
                {
                    sleep = true;
                    Console.WriteLine("");
                    Console.WriteLine("first sleep");
                    //Thread.CurrentThread.Suspend();
                    autoEvent.WaitOne(); 
                }
            }
        }

        static void Main()
        {
            ThreadTest2 t = new ThreadTest2();
            Thread first = new Thread(new ThreadStart(t.FirstWork));
            first.Start();

            while (t.sleep == false) { }

            Console.WriteLine("first is awake up after 2 seconds");
            Thread.Sleep(2000);
            autoEvent.Set(); 
        }
    }
}
