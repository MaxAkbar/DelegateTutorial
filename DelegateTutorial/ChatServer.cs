using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTutorial
{
    public class ChatServer
    {
        // declare a multicast delegate
        public delegate void OnNewMessage(string message, ChatClient chatClient);

        // declare a reference to multicast delegate
        private static OnNewMessage MessageArrived;

        public void Connect(OnNewMessage messageArrived)
        {
            // combine delegates
            MessageArrived = (OnNewMessage)Delegate.Combine(MessageArrived, messageArrived);
        }

        public void DisConnect(OnNewMessage messageArrived)
        {
            // remove delegate
            MessageArrived = (OnNewMessage)Delegate.Remove(MessageArrived, messageArrived);
        }

        public void SendMessageToAllClients(string message, ChatClient chatClient)
        {
            MessageArrived(message, chatClient);
        }
    }
}
