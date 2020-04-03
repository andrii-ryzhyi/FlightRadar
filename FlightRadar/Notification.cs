using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRadar
{
    public class Notification
    {
        public string Message { get; private set; }

        public Notification(string message)
        {
            Message = message;
        }
    }
}
