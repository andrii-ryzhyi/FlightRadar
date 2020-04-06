using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRadar
{
    public static class EmployeeExtensions
    {
        public static void OnInternalNotification(this Employee employee, Notification notification)
        {
            Console.WriteLine("Internal Employee notification: {0}", notification.Message);
        }
    }
}
