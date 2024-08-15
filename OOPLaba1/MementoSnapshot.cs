using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLaba1
{
    public class Memento
    {
        public string AirportName { get; private set; }
        public int FlightCount { get; private set; }
        public int TicketsSold { get; private set; }
        public string CountryCode { get; private set; }
        public int OpeningYear { get; private set; }
        public double AirportArea { get; private set; }
        public double AirportRating { get; private set; }

        public Memento(string airportName, int flightCount, int ticketsSold, string countryCode,
                       int openingYear, double airportArea, double airportRating)
        {
            AirportName = airportName;
            FlightCount = flightCount;
            TicketsSold = ticketsSold;
            CountryCode = countryCode;
            OpeningYear = openingYear;
            AirportArea = airportArea;
            AirportRating = airportRating;
        }
    }
}
