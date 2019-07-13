using System;
using Model;
using Contract;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriter consoleWriter = new ConsoleWriter();

            IMitarbeiter mitarbeiter = new Mitarbeiter("Christian", "Aschoff", 41, 1250, "München", 7, ABTEILUNG.DEVELOPMENT, LEVEL.SENIOR);
            consoleWriter.Write(mitarbeiter);

            IFreiberufler freiberufler = new Freiberufler("Sven", "Wendt", 41, 1350.50, "Hamburg", 980, PARTNERNETZ.SELBSTSTAENDIG);
            consoleWriter.Write(freiberufler);
        }
    }
}
