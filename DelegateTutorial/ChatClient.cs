using System;
using System.Net.Http;

namespace DelegateTutorial
{
    public class ChatClient
    {
        private string clientName;
        private ChatServer chatServer;

        private void NewMessageArrived(string message, ChatClient chatClient)
        {
            if (chatClient != null)
            {
                Console.WriteLine($"Message arrived from ({chatClient.clientName}) *** Message {message} to ChatClient {clientName}");
            }
            else
            {
                Console.WriteLine($"Message arrived from (ChatServer) *** Message {message} to ChatClient {clientName}");
            }
        }

        public ChatClient(ChatServer chatServer, string clientName)
        {
            this.chatServer = chatServer;
            this.clientName = clientName;

            this.chatServer.Connect(NewMessageArrived);
        }

        public void SendMessageToChatServer(string message)
        {
            this.chatServer.SendMessageToAllClients(message, this);
        }

        public void DisConnectFromServer()
        {
            this.chatServer.DisConnect(NewMessageArrived);
        }
    }
}