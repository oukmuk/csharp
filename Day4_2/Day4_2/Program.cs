﻿using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading; 

namespace Day4_2
{
    class ClientHandler
    {
        Socket socket = null;
        NetworkStream stream = null;
        StreamReader reader = null;
        StreamWriter writer = null; 

        public ClientHandler(Socket socket)
        {
            this.socket = socket; 
        }

        public void chat()
        {
            stream = new NetworkStream(socket);
            Encoding encode = Encoding.GetEncoding("utf-8");

            reader = new StreamReader(stream, encode);
            writer = new StreamWriter(stream, encode) { AutoFlush = true };

            while(true)
            {
                string str = reader.ReadLine();
                Console.WriteLine(str);

                writer.WriteLine(str);
            }
        }
    }
    class Server
    {
        public static void Main()
        {
            TcpListener tcpListener = null;
            Socket clientsocket = null;
          
            try
            {
                IPAddress ipAd = IPAddress.Parse("127.0.0.1");

                tcpListener = new TcpListener(ipAd, 5001);
                tcpListener.Start();

                /*
                stream = new NetworkStream(clientsocket);
                Encoding encode = Encoding.GetEncoding("utf-8");

                reader = new StreamReader(stream, encode);
                writer = new StreamWriter(stream, encode) { AutoFlush = true };
                */

                while(true)
                {
                    clientsocket = tcpListener.AcceptSocket();
                    ClientHandler cHandler = new ClientHandler(clientsocket);

                    Thread t = new Thread(new ThreadStart(cHandler.chat));
                    t.Start();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                clientsocket.Close();
            }
        }
    }
}
