using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRadar
{
    public class Flight
    {
        private int _id;
        public int Capacity { get; set; }
        public List<Person> Passengers;
        public string Destination { get; private set; }
        public AlertHandler Alert { get; set; }

        public Flight(int id, string destination, int capacity)
        {
            _id = id;
            Destination = destination;
            Capacity = capacity;
            Passengers = new List<Person>();
        }

        public void AddPassenger(Person passenger)
        {
            Passengers.Add(passenger);
            Alert += passenger.Alert;
        }

        public void SendAlertToPassengers(Notification notification)
        {
            Alert?.Invoke(notification);
        }
    }
}
