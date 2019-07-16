using System;
using Contract;

namespace Rules
{
    public class Forecast : IForecast
    {
        public double Gehaltsentwicklung(double gehalt)
        {
            return gehalt * 1.03;
        }
    }
}
