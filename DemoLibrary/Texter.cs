using System;
namespace DemoLibrary
{
    public class Texter : IMessageSender
    {
        public void SendMessage(IPerson person, string body)
        {
            Console.WriteLine($"I am texting { person.FirstName } to say { body }");
        }
    }
}
