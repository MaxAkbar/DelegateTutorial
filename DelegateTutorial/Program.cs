using System;

namespace DelegateTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start delegate ChatServer");

            ChatServer chatServer = new ChatServer();

            // clients connect to chat server
            ChatClient cc1 = new ChatClient(chatServer, "Max");
            ChatClient cc2 = new ChatClient(chatServer, "Liz");
            ChatClient cc3 = new ChatClient(chatServer, "Anonymous");

            chatServer.SendMessageToAllClients("Hi to all Clients from the Server!", null);
            cc1.SendMessageToChatServer("Hello Everyone!");

            // disconnect from the server
            cc1.DisConnectFromServer();

            // message should only send to 2 clients
            cc2.SendMessageToChatServer("Hi all :).");

            Console.WriteLine("Stop delegate ChatServer");
        }
    }
}
