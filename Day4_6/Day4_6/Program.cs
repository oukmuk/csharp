using System;
using System.Windows.Forms;


namespace Day4_6
{
    class OnjMessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            //Console.WriteLine(m.Msg.ToString()); 

            if(m.Msg == 0x201)
            {
                Console.WriteLine("Mouse click is filtered ");
                return true;
            }
            return false;
        }
    }

    class Program : Form
    {
        static void Main(string[] args)
        {
            Application.AddMessageFilter(new OnjMessageFilter());
            Program p = new Program();
            p.Click += new EventHandler(p.Form_Click);
            Application.Run(p);
        }

        void Form_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Mouse click event is happened");
            Application.Exit();
        }
    }
}
