using System;
namespace DemoLibrary
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(IPerson person, string body)
        {
            Console.WriteLine($"Simulating sending an email to { person.EmailAddress }");
        }
    }
}
