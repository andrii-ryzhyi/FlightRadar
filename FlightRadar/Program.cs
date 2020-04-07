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
            BusinessFlight<VIPGuest> italy = new BusinessFlight<VIPGuest>("Italy", 100, 150.0);
            Passenger p1 = new Passenger("P1", "LastNameP1", 25, 50.45);
            p1.BuyTicket(italy);
            Passenger p2 = new Passenger("P2", "LastNameP2", 30, 300);
            p2.BuyTicket(italy);
            italy.SendAlertToPassengers("Flight is delayed");

            Employee e1 = new Employee("E1", "LastNameE1", 40, Job.CrewMemeber, 15);
            italy.AddCrew(e1);
            italy.SendAlertToCrew("Internal alert");

            VIPGuest vip = new VIPGuest("VIP", "VIP", 30, 300, "VIP");
            vip.BuyTicket(italy);
            italy.AddBusinessClassGuest(vip);

            var onboard = italy.Passengers.Count();
            Console.WriteLine("Total onboard: {0}", onboard);

           

            Console.ReadKey();
        }
    }
}
