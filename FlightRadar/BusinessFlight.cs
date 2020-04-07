using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRadar
{
    public class BusinessFlight<T> : Flight, IBusiness<VIPGuest> 
        
    {
        public List<VIPGuest> BusinessClassGuests { get; private set; }
        public BusinessFlight(string destination, int capacity, double ticketPrice) : base(destination, capacity, ticketPrice)
        {
            BusinessClassGuests = new List<VIPGuest>();
        }
        public void AddBusinessClassGuest(VIPGuest guest)
        {
            AddPassenger(guest);
            BusinessClassGuests.Add(guest);
        }
    }
}
