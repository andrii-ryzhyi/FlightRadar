using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRadar
{
    public class Program
    {
        static void Main(string[] args)
        {
            Flight italy = new Flight("Italy", 100, 150.0);
            Passenger p1 = new Passenger("P1", "LastNameP1", 25, 400.45);
            p1.BuyTicket(italy);
            Passenger p2 = new Passenger("P2", "LastNameP2", 30, 300);
            p1.BuyTicket(italy);
            italy.SendAlertToPassengers("Flight is delayed");

            Employee e1 = new Employee("E1", "LastNameE1", 40, Job.CrewMemeber, 15);
            italy.AddCrew(e1);
            italy.SendAlertToCrew("Internal alert");

            Console.ReadKey();
        }
    }
}
