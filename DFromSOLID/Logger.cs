using System;

namespace DFromSOLID
{
    public class Logger
    {
        public void Log(string ereignis)
        {
            Console.WriteLine($"Das Ereignis {ereignis} wurde in das Ereignislog geschrieben!");
        }
    }
}
