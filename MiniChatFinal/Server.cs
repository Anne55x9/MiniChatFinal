using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MiniChatFinal
{
    public class Server
    {

        public void StartServer()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback,7070);

            server.Start();


            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Task.Run(() =>
                {
                    TcpClient LokalSocket = client;
                    DoClient(LokalSocket);
                });

            }
        }

        public static void DoClient(TcpClient client)
        {
            using (NetworkStream ns = client.GetStream())

            using (StreamReader sr = new StreamReader(ns))

            using (StreamWriter sw = new StreamWriter(ns)) 
            {
                String inline = sr.ReadLine();
                String outline = HandleClient(inline);

                sw.WriteLine(outline);
                sw.Flush();
            }

        }

        public  static String HandleClient(String line)
        {
            Console.WriteLine("Server modtaget" + line);
            return line;
        }
        


    }
}
