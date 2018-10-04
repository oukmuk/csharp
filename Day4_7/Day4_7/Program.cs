﻿using System;
using System.Windows.Forms;

namespace Day4_7
{
    class Program : Form
    {
        public void MouseHandler(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Sender : " + ((Form)sender).Text);
            Console.WriteLine("Sender : " + ((Form)sender).Name);
            Console.WriteLine("X:{0}, Y:{1}", e.X, e.Y);
            Console.WriteLine("Button:{0}, Clicks:{1}", e.Button, e.Clicks);
        }

        public Program(String title)
        {
            this.Text = title;
            this.Name = "Winform";
            this.MouseDown += new MouseEventHandler(MouseHandler); 
        }

        static void Main(string[] args)
        {
            Application.Run(new Program("Mouse event example"));
        }
    }
}
