using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRadar
{
    public class Employee : Person, Informable
    {
        public double Salary { get; private set; }
        public int Experience { get; set; }
        public Job job;
        public Employee(string name, string lastName, int age, Job job, int experience) : base(name, lastName, age)
        {
            Experience = experience;
            this.job = job;
        }
    }
}
