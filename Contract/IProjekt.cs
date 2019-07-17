using System;
using System.Collections.Generic;

namespace Contract
{
    public interface IProjekt
    {
        List<IMitarbeiter> Mitarbeiter { get; }
        List<IFreiberufler> Freiberufler { get; }
        string Name { get; } 
    }
}
