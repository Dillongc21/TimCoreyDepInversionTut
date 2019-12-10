using System;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();

            owner.FirstName = "Dillon";
            owner.LastName = "Christensen";
            owner.EmailAddress = "dchris@example.com";
            owner.PhoneNumber = "123-456-7890";

            IChore chore = Factory.CreateChore();

            chore.ChoreName = "Take out the Trash";
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
