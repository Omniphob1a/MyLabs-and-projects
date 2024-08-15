using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLaba1
{
    public class CivilAirportFactory : IAirportFactory
    {
        /// <summary>
        /// Получить тип создаваемого аэропорта
        /// </summary>
        /// <returns>"Гражданский"</returns>
        public string GetAirportType() => "Гражданский";
        public IAirport CreateAirport(string airportName, int flightCount,
                                   int ticketsSold, string countryCode,
                                   int openingYear, double airportArea,
                                   double airportRating)
        {
            return new CivilAirport(airportName, flightCount, ticketsSold,
                                    countryCode, openingYear, airportArea,
                                    airportRating);
        }
    }

}
