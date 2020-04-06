using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRadar
{
    public interface Informable
    {
        List<Notification> Notifications { get; set; }
        string FirstName { get; }
        void OnNewNotification(Notification notification);
    }
}
