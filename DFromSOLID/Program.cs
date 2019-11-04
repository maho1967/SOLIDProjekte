namespace DFromSOLID
{

    // Dependency Inversion Prinzip
    class Program
    {
        static void Main(string[] args)
        {
            Person Sohn = new Person() 
            { 
                Vorname = "Markus", 
                Nachname = "Hoß" 
            };

            Taetigkeit Bloedsinn = new Taetigkeit() 
            { 
                Ausfuehrender = Sohn,
                Beschreibung = "Ich habe die Datenbank gelöscht!"
            };

            Bloedsinn.Ausführen(2);

            Bloedsinn.Ausführen(1);

            Bloedsinn.Ausgefuehrt();

        }
    }
}
