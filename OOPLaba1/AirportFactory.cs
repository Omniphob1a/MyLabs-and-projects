using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLaba1
{
    public interface IAirport
    {

        /// <summary>
        /// Получить значение _airportName
        /// </summary>
        /// <returns></returns>
        string GetAirportName();

        /// <summary>
        /// Получить значение _flightCount
        /// </summary>
        /// <returns></returns>
        int GetFlightCount();

        /// <summary>
        /// Получить значение _countryCode
        /// </summary>
        /// <returns></returns>
        string GetCountryCode();

        /// <summary>
        /// Получить значение _openingYear
        /// </summary>
        /// <returns></returns>
        int GetOpeningYear();

        /// <summary>
        /// Получить значение _airportArea
        /// </summary>
        /// <returns></returns>
        double GetAirportArea();

        /// <summary>
        /// Установить значение поля _airportName
        /// </summary>
        /// <returns></returns>
        void SetAirportName(string airportName);

        /// <summary>
        /// Установить значение поля _flightCount
        /// </summary>
        /// <returns></returns>
        void SetFlightCount(int flightCount);

        /// <summary>
        /// Установить значение поля _countryCode
        /// </summary>
        /// <returns></returns>
        void SetCountryCode(string countryCode);

        /// <summary>
        /// Установить значение поля _openingYear
        /// </summary>
        /// <returns></returns>
        void SetOpeningYear(int openingYear);

        /// <summary>
        /// Установить значение поля _airportArea
        /// </summary>
        /// <returns></returns>
        void SetAirportArea(double airportArea);

        /// <summary>
        /// Получить тип создаваемого аэропорта
        /// </summary>
        /// <returns>"Военный" или "Гражданский"</returns>
        string GetAirportType();

    }

    public interface IAirportFactory
    {
        string GetAirportType();
        IAirport CreateAirport(string airportName, int flightCount, int ticketsSold,
                            string countryCode, int openingYear, double airportArea,
                            double airportRating);
    }
}
