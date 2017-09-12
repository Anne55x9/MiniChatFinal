using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MiniChatClientFinal
{
    public class Client
    {
       
        public void StartClient()
        {
            

            using (TcpClient client = new TcpClient("localhost", 7070))

            using (NetworkStream ns = client.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                while (true)
                {
                    String SendStr = Console.ReadLine();
                    sw.WriteLine(SendStr);
                    sw.Flush();

                    String incomingStr = sr.ReadLine();
                    Console.WriteLine("Chat funktion aktiv: " + incomingStr);
                }

                Console.ReadLine();
            }




        }


    }
}
