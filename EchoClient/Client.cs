using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EchoClient
{
    class Client
    {
        public void Start()
        {
            string sendstr = "Daniel Pilanat Østergaard";

            using (TcpClient client = new TcpClient("localhost", 7))
            using (NetworkStream ns = client.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                sw.WriteLine(sendstr);
                sw.Flush();

                string Incomingstr = sr.ReadLine();
                Console.WriteLine("Jeg har modtaget: " + Incomingstr);
                Incomingstr = sr.ReadLine();
                Console.WriteLine("Jeg har modtaget: " + Incomingstr);
            }
        }
    }
}
