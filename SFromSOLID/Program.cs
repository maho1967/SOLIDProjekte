using System;

namespace SFromSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Benutzer! Willkommen zu meiner Konsolenanwendung.");

            Person user = new Person();

            Console.WriteLine("Bitte gebe Deinen Vornamen an!");
            user.Vorname = Console.ReadLine();

            Console.WriteLine("Bitte gebe Deinen Nachnamen an!");
            user.Nachname = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(user.Vorname))
            {
                Console.WriteLine("Du hast keinen richtigen Vornamen angegeben!");
                Console.ReadLine();
            }                

            if (string.IsNullOrWhiteSpace(user.Nachname))
            {
                Console.WriteLine("Du hast keinen richtigen Nachnamen eingegeben!");
                Console.ReadLine();
            }

            Console.WriteLine($"Deine UserID wäre {user.Vorname.Substring(0, 1)}.{user.Nachname}@trianel.com");
            Console.ReadLine();

        }
    }
}
