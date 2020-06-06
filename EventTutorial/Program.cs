using System;

namespace EventTutorial
{
    public class EventArgsMessage : EventArgs
    {
        public string Message { get; set; }
    }

    public class EventTest
    {
        public event EventHandler<EventArgsMessage> PrintConsoleEvent;

        public void DoSomeWork()
        {
            EventArgsMessage eventArgsMessage = new EventArgsMessage();

            eventArgsMessage.Message = "Call an event!";

            OnPrintConsole(this, eventArgsMessage);
        }

        private void OnPrintConsole(object sender, EventArgsMessage eventArgs)
        {
            if (PrintConsoleEvent != null)
            {
                PrintConsoleEvent(sender, eventArgs);
            }
        }

        public void TestString(object sender, EventArgsMessage e)
        {
            Console.WriteLine($"Called from : {sender.GetType()} : with message : {e.Message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EventTest eventTest = new EventTest();

            eventTest.PrintConsoleEvent += eventTest.TestString;

            eventTest.DoSomeWork();
        }
    }
}
