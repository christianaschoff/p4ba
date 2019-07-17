using System;
using Contract;

namespace Rules
{
    public class Auslastung
    {
        public AUSLASTUNG BerechneAuslastungsstatus(int tageProJahr) {
            if(tageProJahr >= 200)
            {
                return AUSLASTUNG.GRUEN;
            }
            else if(tageProJahr < 200 && tageProJahr >= 120)
            {
                return AUSLASTUNG.GELB;
            }
            else if(tageProJahr < 120 && tageProJahr > 60) 
            {
                return AUSLASTUNG.ROT;
            }
            else 
            {
                return AUSLASTUNG.ALARM;
            }
        }
    }
}
