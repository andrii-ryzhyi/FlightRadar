using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRadar
{
    public class VIPGuest : Passenger
    {
        public string VIPTitle;

        public VIPGuest(string name, string lastName, int age, double cash, string title) : base(name, lastName, age, cash)
        {
            VIPTitle = title;
        }
    }
}
