using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRadar
{
    public delegate void AlertHandler(Notification notification);
    public abstract class Person : Iinformable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Notification> Notifications { get; set; }
        public AlertHandler Alert { get; set; }

        public Person(string name, string lastName, int age)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
            Notifications = new List<Notification>();
            Alert += OnNewNotification;
        }

        public void OnNewNotification(Notification notification)
        {
            Notifications.Add(notification);
            Console.WriteLine("New alert: {0}", notification.Message);
        }
    }
}
