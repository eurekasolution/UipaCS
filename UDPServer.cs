using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp1
{
    internal class UDPServer
    {
        public static void Main(string[] args)
        {
            // port# : 1만번 이상의 번호
            int port = 12345;
            UdpClient updServer = new UdpClient(port);

            Console.WriteLine($"Start Udp Server ... :{port}");
            while(true)
            {
                IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, port);
                byte[] receivedBytes = updServer.Receive(ref clientEndPoint);

                string receivedMessage = Encoding.UTF8.GetString(receivedBytes);
                Console.WriteLine($" << {receivedMessage} ");
                // echo
                updServer.Send(receivedBytes, receivedBytes.Length, clientEndPoint);


            }
        }
        

    }
}
