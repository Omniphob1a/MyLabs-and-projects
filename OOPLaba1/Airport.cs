using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPLaba1;

namespace OOPLaba1
{
    public class Airport : IAirport
    {
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
        /// Число проданных билетов
        /// </summary>
        private int _ticketsSold;

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
        /// Рейтинг аэропорта от 1 до 5
        /// </summary>
        private double _airportRating;

        /// <summary>
        /// Число созданных объектов класса
        /// </summary>
        public static int _objectCount = 0;

        /// <summary>
        /// Конструктор с количеством параметров, равным количеству полей
        /// </summary>
        /// <param name="airportName">Поле класса Airport, имя аэропорта </param>
        /// <param name="flightCount">Поле класса Airport, число полетов</param>
        /// <param name="ticketsSold">Поле класса Airport, кол-во проданных билетов</param>
        /// <param name="countryCode">Поле класса Airport, код страны</param>
        /// <param name="openingYear">Поле класса Airport, год открытия аэропорта</param>
        /// <param name="airportArea">Поле класса Airport, площадь аэропорта</param>
        /// <param name="airportRating">Поле класса Airport, рейтинг аэропорта</param>
        public Airport(string airportType, string airportName, int flightCount,
                   int ticketsSold, string countryCode, int openingYear,
                   double airportArea, double airportRating)
        {
            this._airportType = airportType;
            this._airportName = airportName;
            this._flightCount = flightCount;
            this._ticketsSold = ticketsSold;
            this._countryCode = countryCode;
            this._openingYear = openingYear;
            this._airportArea = airportArea;
            this._airportRating = airportRating;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Airport()
        {
            _objectCount++;
        }

        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="_airportName">Поле класса Airport, Имя Аэропорта</param>
        public Airport(string _airportName)
        {
            this._airportName = _airportName;
        }

        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="_airportName">Поле класса Airport, Имя Аэропорта</param>
        /// <param name="_flightCount">Поле класса Airport, Число Полетов</param>
        public Airport(string _airportName, int _flightCount)
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

        public int GetTicketsSold()
        {
            return _ticketsSold;
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

        public double GetAirportRating()
        {
            return _airportRating;
        }

        public void SetAirportName(string _airportName)
        {
            this._airportName = _airportName;
        }

        public void SetFlightCount(int flightCount)
        {
            this._flightCount = (flightCount < 0) ? 0 : flightCount;
        }

        public void SetTicketsSold(int ticketsSold)
        {
            this._ticketsSold = (ticketsSold < 0) ? 0 : ticketsSold;
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

        public void SetAirportRating(double airportRating)
        {
            this._airportRating = airportRating;
        }

        /// <summary>
        /// Получить тип аэропорта (по умолчанию - "Неизвестно")
        /// </summary>
        /// <returns>"Гражданский"</returns>
        public virtual string GetAirportType() => "Неизвестно";

        /// <summary>
        /// Переопределение метода ToString() для вывода значения полей
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Airport Type: {_airportType}\n" +
                   $"Airport Name: {_airportName}\n" +
                   $"Flight Count: {_flightCount}\n" +
                   $"Tickets Sold: {_ticketsSold}\n" +
                   $"Country Code: {_countryCode}\n" +
                   $"Opening Year: {_openingYear}\n" +
                   $"Airport Area: {_airportArea}\n" +
                   $"Airport Rating: {_airportRating}\n\n";
        }

    }


    /// <summary>
    /// Пользовательский класс исключения для обработки пользовательских исключений недопустимого приведения типов.
    /// </summary>
    public class CustomInvalidCastException : InvalidCastException
    {
        /// <summary>
        /// Дополнительные пользовательские данные, связанные с исключением.
        /// </summary>
        public string CustomData { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса CustomInvalidCastException с указанным сообщением и пользовательскими данными.
        /// </summary>
        /// <param name="message">Сообщение об ошибке, объясняющее причину исключения.</param>
        /// <param name="customData">Дополнительные пользовательские данные, связанные с исключением.</param>
        public CustomInvalidCastException(string message, string customData) : base(message)
        {
            CustomData = customData;
        }
    }


}