using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLaba1
{
    public class MilitaryAirportFactory : IAirportFactory
    {
        /// <summary>
        /// Получить тип создаваемого аэропорта
        /// </summary>
        /// <returns>"Военный"</returns>
        public string GetAirportType() => "Военный";
        public IAirport CreateAirport(string airportName, int flightCount,
                                   int ticketsSold, string countryCode,
                                   int openingYear, double airportArea,
                                   double airportRating)
        {
            return new MilitaryAirport(airportName, flightCount, ticketsSold,
                                    countryCode, openingYear, airportArea,
                                    airportRating);
        }
    }
}
