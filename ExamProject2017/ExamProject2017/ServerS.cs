using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamProject2017
{
    class ServerS
    {
        public static int clientNo = 0;
        public static ArrayList allClients;
        private const int SERVPORT = 1234;

        public ServerS()
        {
            runServer();
        }

        public void runServer() {
            TcpListener listener = null;
            try
            {
                allClients = new ArrayList();

                // Create a TCPListener to accept client connections

                listener = new TcpListener(IPAddress.Any, SERVPORT);
                listener.Start();
                Console.WriteLine("Waiting for clients....");
            }
            catch (SocketException se)
            {
                Console.WriteLine(se.Message);
                Environment.Exit(se.ErrorCode);
            }
            while (true)
            {
                clientNo += 1;
                try
                {
                    TcpClient client = listener.AcceptTcpClient();
                    ClientHandler handler = new ClientHandler(client, clientNo.ToString());
                    Console.WriteLine("Accepted new client, no = " + clientNo);
                    //*****************************************************

                    allClients.Add(handler);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public class ClientHandler
        {
            private const int BUFSIZE = 32;

            private TcpClient client;
            private NetworkStream ns;
            private string clientNo;

            public ClientHandler(TcpClient client, string no)
            {
                this.client = client;
                this.clientNo = no;
                Thread t = new Thread(ReadMessage);
                t.Start();
            }

            private void ReadMessage()
            {
                this.ns = this.client.GetStream();

                String result = null;
                try
                {
                    byte[] rcvBuffer = new byte[BUFSIZE]; // Receive buffer  
                    ns.Read(rcvBuffer, 0, BUFSIZE);
                    result = Encoding.ASCII.GetString(rcvBuffer);
                    Console.WriteLine("Got this message from the client: " + result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    ns.Close();
                }
            }
            /*
            private void Dostuff()
            {
                this.ns = this.client.GetStream();
                Console.WriteLine("Handling client no = " + clientNo);
                try
                {
                    while (true)
                    {
                        Console.WriteLine("is socket still connected = " + client.Connected);
                        String message = ReadMessage(ns);
                        if (message.Length > 0)
                        {
                            if (message.StartsWith("%"))
                            {
                                //// TODO: Broadcast to all clients
                                foreach (ClientHandler cH in allClients)
                                {
                                    NetworkStream ns = cH.client.GetStream();

                                    string messageM = message.Remove(0, 1);
                                    string finalMEssage = messageM;
                                    Byte[] receiveMessage = Encoding.ASCII.GetBytes(finalMEssage);
                                    ns.Write(receiveMessage, 0, receiveMessage.Length);
                                    ns.Flush();

                                    Console.WriteLine("***");
                                }
                            }
                            else if (message.StartsWith("#"))
                            {
                                // TODO: Stop the chat for this client
                                ns.Close();
                                client.Close();
                            }
                            else
                            {
                                // TODO: JOIN this client to the chat - register the nick name!!!
                            }
                        }
                    }
                    Thread.Sleep(100);    // Avoiding the (too) busy loop              
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {

                    if (ns != null)
                    {
                        ns.Close();
                    }
                    if (client != null)
                    {
                        client.Close();
                    }

                }
            }*/

        }

    }
}

