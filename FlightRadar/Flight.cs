using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRadar
{
    public delegate void EmployeeAlert(Notification notification);
    public class Flight
    {
        private int _id;
        public int Capacity { get; set; }
        public List<Person> Passengers;
        public List<Employee> Crew;
        public string Destination { get; private set; }
        public AlertHandler Alert { get; set; }
        public EmployeeAlert InternalAlert { get; set; }
        public double TicketPrice { get; private set; }

        private static int flightId;

        public Flight(string destination, int capacity, double ticketPrice)
        {

            _id = ++flightId;
            Destination = destination;
            Capacity = capacity;
            TicketPrice = ticketPrice;
            Passengers = new List<Person>();
            Crew = new List<Employee>();
        }

        public void AddPassenger(Passenger passenger)
        {
            if (!passenger.Hold(TicketPrice))
            {
                throw new HoldMoneyException("Not Enogh money");
            }
            if (Passengers.Count < Capacity)
            {
                Passengers.Add(passenger);
                Alert += passenger.Alert;
            }
            else
            {
                throw new FlightCapacityException("No free seats");
            }
            
        }
        public void AddCrew(Employee employee)
        {
            Crew.Add(employee);
            InternalAlert += employee.OnInternalNotification;
        }

        public void SendAlertToPassengers(string notification)
        {
            Alert?.Invoke(new Notification(notification));
        }
        public void SendAlertToCrew(string notification)
        {
            InternalAlert?.Invoke(new Notification(notification));
        }
    }
}
