using System;

namespace DFromSOLID
{
    public class Taetigkeit
    {
        public Person Ausfuehrender { get; set; }

        public int Dauer { get; private set; } = 0;

        public string Beschreibung { get; set; }

        public bool IstFertig { get; private set; } = false;

        public void Ausführen(int anzahl)
        {
            Console.WriteLine(Beschreibung);
            Dauer += anzahl;
        }

        public void Ausgefuehrt()
        {
            IstFertig = true;
            Logger logger = new Logger();
            logger.Log("'"+Beschreibung+"'");

            MailSender sender = new MailSender();
            sender.Send(Ausfuehrender.Langname(), Dauer);

        }
    }
}
