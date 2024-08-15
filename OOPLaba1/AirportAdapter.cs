using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLaba1
{
    public class CountrySearchAdapter : IAirportSearch
    {
        private readonly IAirport airport;

        public CountrySearchAdapter(IAirport airport)
        {
            this.airport = airport;
        }

        public List<IAirport> SearchByCountryCode(string countryCode)
        {
            List<IAirport> matchingAirports = new List<IAirport>();
            if (airport.GetCountryCode() == countryCode)
            {
                matchingAirports.Add(airport);
            }
            return matchingAirports;
        }
    }

    public interface IAirportSearch
    {
        List<IAirport> SearchByCountryCode(string countryCode);
    }

}
