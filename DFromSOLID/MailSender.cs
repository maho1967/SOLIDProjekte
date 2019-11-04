using System;

namespace DFromSOLID
{
    public class MailSender
    {
        public void Send(string langName, int stunden)
        {
            Console.WriteLine($"Ich habe die Mail an m.hoss@trianel.com gesendet! {langName} hat {stunden}h gearbeitet!");
        }
    }
}
