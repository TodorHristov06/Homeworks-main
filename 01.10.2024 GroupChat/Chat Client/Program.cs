using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class ChatClient
{
    static void Main(string[] args)
    {
        byte[] buffer = new byte[1024];

        IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
        IPAddress ipAddress = ipHostInfo.AddressList[0];
        IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

        Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

        try
        {
            sender.Connect(remoteEP);
            Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());

            // Start a thread to receive messages
            Thread receiveThread = new Thread(() =>
            {
                while (true)
                {
                    int bytesReceived = sender.Receive(buffer);
                    string receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesReceived);
                    Console.WriteLine("Received: " + receivedMessage);
                }
            });
            receiveThread.Start();

            while (true)
            {
                Console.Write("> ");
                string message = Console.ReadLine();
                byte[] msg = Encoding.ASCII.GetBytes(message + "<EOF>");
                sender.Send(msg);

                if (message == "exit")
                    break;
            }

            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
