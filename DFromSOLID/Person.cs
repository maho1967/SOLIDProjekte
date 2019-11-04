using System;
using System.Collections.Generic;
using System.Text;

namespace DFromSOLID
{
    public class Person
    {
        public string Vorname { get; set; }

        public string Nachname { get; set; }

        public string Langname()
        {
            return Vorname + " " + Nachname;
        }
    }
}
