using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRadar
{
    public interface IBusiness<T> where T : VIPGuest
    {
        List<T> BusinessClassGuests { get; }
        void AddBusinessClassGuest(T guest);
    }
}
