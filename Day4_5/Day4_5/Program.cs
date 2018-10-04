using System;
using System.Windows.Forms; 

namespace Day4_5
{
/*
    class Program : Form
    {
        static void Main(string[] args)
        {
            Program form = new Program();
            form.Click += new EventHandler(form.Form_Click);
            Console.WriteLine("Window is started ");
            Application.Run(form);
            Console.WriteLine("Window is closed");
        }

        void Form_Click(object sender, EventArgs e)
        {
            Console.WriteLine("form click event is happened");
            Application.Exit(); 
        }
    }
*/
    class Program : Form
    {
        static void Main(string[] args)
        {
            Program form = new Program();
            form.Click += new EventHandler((sender, eventArgs) =>
            {
                Console.WriteLine("Form Click event is happened");
                Application.Exit();
            });
            Console.WriteLine("window is started");
            Application.Run(form);
            Console.WriteLine("window is closed");
        }
    }
}
