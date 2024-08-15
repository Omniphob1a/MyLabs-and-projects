using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLaba1
{
    public class AirportCollection<T> where T : IAirport
    {
        private List<T> _airports;
        public event EventHandler<AirportEventArgs> AirportAdded;
        public event EventHandler<AirportEventArgs> AirportRemoved;

        public AirportCollection()
        {
            _airports = new List<T>();
        }

        /// <summary>
        /// Добавить аэропорт в коллекцию
        /// </summary>
        /// <param name="airport"></param>
        public void AddAirport(T airport)
        {
            if (airport != null)
            {
                _airports.Add(airport);
                AirportAdded?.Invoke(this, new AirportEventArgs(airport, airport.GetAirportType()));
            }
        }
        
        /// <summary>
        /// Удалить аэропорт из коллекции
        /// </summary>
        /// <param name="airport"></param>
        public void RemoveAirport(T airport)
        {
            if (airport != null)
            {
                _airports.Remove(airport);
                AirportRemoved?.Invoke(this, new AirportEventArgs(airport, airport.GetAirportType()));
            }
        }

        public IEnumerable<T> GetAirports()
        {
            return _airports;
        }
    }

    public class AirportEventArgs : EventArgs
    {
        public IAirport Airport { get; }
        public string AirportType { get; }

        public AirportEventArgs(IAirport airport, string airportType)
        {
            Airport = airport;
            AirportType = airportType;
        }
    }

    public class AirportListener
    {
        bool FirstAiportAdded = false;
        public void AirportAddedHandler(object sender, AirportEventArgs e)
        {
            if (!FirstAiportAdded) {
                MessageBox.Show($"Аэропорт добавлен: {e.Airport.GetAirportName()}, тип: {e.AirportType}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FirstAiportAdded = true;
            }

        }

        public void AirportRemovedHandler(object sender, AirportEventArgs e)
        {
            MessageBox.Show($"Аэропорт удален: {e.Airport.GetAirportName()}, тип: {e.AirportType}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
