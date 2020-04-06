using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRadar
{
    [Serializable]
    public class HoldMoneyException : Exception
    {
        public HoldMoneyException(string reason)
            : base(String.Format("Hold Money Transaction Exception: {0}", reason))
        {

        }

            
    }

}
