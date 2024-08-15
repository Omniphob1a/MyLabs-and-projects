using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLaba1
{
    public class MilitaryAirport : Airport, IAirport
    {
        public MilitaryAirport(string airportName, int flightCount, int ticketsSold,
                        string countryCode, int openingYear, double airportArea,
                        double airportRating) :
        base(airportType: "Военный", airportName: airportName,
             flightCount: flightCount, ticketsSold: ticketsSold,
             countryCode: countryCode, openingYear: openingYear,
             airportArea: airportArea, airportRating: airportRating)
        { }
        /// <summary>
        /// Тип аэропорта
        /// </summary>
        private string _airportType;

        /// <summary>
        /// Название аэропорта
        /// </summary>
        private string _airportName;

        /// <summary>
        /// Число полетов
        /// </summary>
        private int _flightCount;

        /// <summary>
        /// Код страны
        /// </summary>
        private string _countryCode;

        /// <summary>
        /// Год открытия аэропорта
        /// </summary>
        private int _openingYear;

        /// <summary>
        /// Площадь аэропорта
        /// </summary>
        private double _airportArea;

        /// <summary>
        /// Число созданных объектов класса
        /// </summary>
        public static int _objectCount = 0;

        /// <summary>
        /// Конструктор с количеством параметров, равным количеству полей
        /// </summary>
        /// <param name="airportName">Поле класса Airport, имя аэропорта </param>
        /// <param name="flightCount">Поле класса Airport, число полетов</param>
        /// <param name="countryCode">Поле класса Airport, код страны</param>
        /// <param name="openingYear">Поле класса Airport, год открытия аэропорта</param>
        /// <param name="airportArea">Поле класса Airport, площадь аэропорта</param>
        public MilitaryAirport(int vehicleCount, string airportType, string airportName, int flightCount,
                   string countryCode, int openingYear,
                   double airportArea)
        {
            this._vehicleCount = vehicleCount;
            this._airportType = airportType;
            this._airportName = airportName;
            this._flightCount = flightCount;            
            this._countryCode = countryCode;
            this._openingYear = openingYear;
            this._airportArea = airportArea;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MilitaryAirport()
        {
            
        }

        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="_airportName">Поле класса Airport, Имя Аэропорта</param>
        public MilitaryAirport(string _airportName)
        {
            this._airportName = _airportName;
        }

        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="_airportName">Поле класса Airport, Имя Аэропорта</param>
        /// <param name="_flightCount">Поле класса Airport, Число Полетов</param>
        public MilitaryAirport(string _airportName, int _flightCount)
        {
            this._airportName = _airportName;
            this._flightCount = _flightCount;
        }

        /// <summary>
        /// Получить значение поля _objectCount 
        /// </summary>
        /// <returns>Число созданных объектов класса Airport</returns>
        public int GetObjectCount()
        {
            return _objectCount;
        }

        public string GetAirportName()
        {
            return _airportName;
        }

        public int GetFlightCount()
        {
            return _flightCount;
        }

        public string GetCountryCode()
        {
            return _countryCode;
        }

        public int GetOpeningYear()
        {
            return _openingYear;
        }

        public double GetAirportArea()
        {
            return _airportArea;
        }

        public void SetAirportName(string _airportName)
        {
            this._airportName = _airportName;
        }

        public void SetFlightCount(int flightCount)
        {
            this._flightCount = (flightCount < 0) ? 0 : flightCount;
        }

        public void SetCountryCode(string _countryCode)
        {
            this._countryCode = _countryCode;
        }

        public void SetOpeningYear(int openingYear)
        {
            this._openingYear = (openingYear < 1910) ? 1910 : (openingYear > 2024) ? 2024 : openingYear;
        }

        public void SetAirportArea(double airportArea)
        {
            this._airportArea = (airportArea < 0) ? 0 : airportArea;
        }

        /// <summary>
        /// Получить тип аэропорта (по умолчанию - "Неизвестно")
        /// </summary>
        /// <returns>"Гражданский"</returns>
        public virtual string GetAirportType() => "Военный";

        /// <summary>
        /// Переопределение метода ToString() для вывода значения полей
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Vehicle Count: {_vehicleCount}\n" +
                   $"Airport Type: {_airportType}\n" +
                   $"Airport Name: {_airportName}\n" +
                   $"Flight Count: {_flightCount}\n" +
                   $"Country Code: {_countryCode}\n" +
                   $"Opening Year: {_openingYear}\n" +
                   $"Airport Area: {_airportArea}\n\n";
        }

        //(Свойства, специфичные для военных аэропортов) 

        /// <summary>
        /// Количество военной техники
        /// </summary>
        private int _vehicleCount;

        /// <summary>
        /// Получить значение поля _vehicleCount
        /// </summary>
        /// <returns></returns>
        public int GetVehicleCount()
        {
            return this._vehicleCount;
        }

        /// <summary>
        /// Установить значение поля _vehicleCount
        /// </summary>
        /// <param name="vehicleCount"></param>
        public void SetVehicleCount(int vehicleCount)
        {
            this._vehicleCount = vehicleCount;
        }
    }
}
