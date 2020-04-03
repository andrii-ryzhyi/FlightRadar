using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRadar
{
    public class Passenger : Person, Iinformable
    {
        public Flight Flight { get; set; }

        public Passenger(string name, string lastName, int age, Flight flight) : base(name, lastName, age)
        {
            Flight = flight;
        }
    }
}
