using System;
using System.Collections.Generic;
using Contract;

namespace Model
{
    public class Projekt : IProjekt
    {
        public List<IMitarbeiter> Mitarbeiter { get; }

        public List<IFreiberufler> Freiberufler { get; }

        public string Name { get; set; }

        public Projekt(string name)
        {
            this.Mitarbeiter = new List<IMitarbeiter>();
            this.Freiberufler = new List<IFreiberufler>();
            this.Name = name;
        }
    }
}
