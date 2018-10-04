using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Day4_1
{
    class TcpClientTest
    {
        static void Main(string[] args)
        {
            TcpClient client = null;

            try
            {
                client = new TcpClient();
                client.Connect("192.168.0.73", 5001);
                NetworkStream stream = client.GetStream();

                Encoding encode = Encoding.GetEncoding("utf-8");
                StreamReader reader = new StreamReader(stream, encode); 

                StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

                string dataToSend = Console.ReadLine(); 

                while(true)
                {
                    writer.WriteLine(dataToSend);
                    String str = reader.ReadLine();
                    Console.WriteLine(str);

                    if (dataToSend.IndexOf("<EOF>") > -1) break;

                    dataToSend = Console.ReadLine(); 
                }
            }
            catch(Exception e )
            {
                Console.WriteLine(e.ToString());

            }
            finally
            {
                client.Close(); 
            }
        }
    }
}
