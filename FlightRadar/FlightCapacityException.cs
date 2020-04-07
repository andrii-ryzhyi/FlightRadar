using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRadar
{
    [Serializable]
    public class FlightCapacityException : Exception
    {
        public FlightCapacityException(string reason)
            : base(String.Format("Flight Capacity Exception: {0}", reason))
        {

        }

            
    }

}
