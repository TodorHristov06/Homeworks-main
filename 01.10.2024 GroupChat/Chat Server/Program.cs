using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class Program
{
    private static List<Socket> clients = new List<Socket>();

    static void Main(string[] args)
    {
        IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
        IPAddress ipAddress = ipHostInfo.AddressList[0];
        IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000); // IP:PORT

        Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        listener.Bind(localEndPoint);
        listener.Listen(10);

        Console.WriteLine("Waiting for a connection...");

        while (true)
        {
            Socket handler = listener.Accept();
            clients.Add(handler);
            Console.WriteLine("Client connected: " + handler.RemoteEndPoint.ToString());
            Thread clientThread = new Thread(() => HandleClient(handler));
            clientThread.Start();
        }
    }

    private static void HandleClient(Socket handler)
    {
        byte[] buffer = new byte[1024];
        string message = "";

        try
        {
            while (true)
            {
                int messageSize = handler.Receive(buffer);
                message = Encoding.ASCII.GetString(buffer, 0, messageSize);

                if (message.Contains("<EOF>"))
                {
                    message = message.Replace("<EOF>", "");
                    if (message == "exit")
                    {
                        Console.WriteLine("Client disconnected: " + handler.RemoteEndPoint.ToString());
                        break;
                    }

                    Console.WriteLine("> " + message);
                    BroadcastMessage(message, handler);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            handler.Shutdown(SocketShutdown.Both);
            handler.Close();
            clients.Remove(handler);
        }
    }

    private static void BroadcastMessage(string message, Socket sender)
    {
        byte[] msg = Encoding.ASCII.GetBytes(message + "<EOF>");
        foreach (var client in clients)
        {
            if (client != sender) 
            {
                client.Send(msg);
            }
        }
    }
}
