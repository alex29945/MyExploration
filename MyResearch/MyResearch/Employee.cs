using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResearch
{
    [Serializable]
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Appointment { get; set;}

        public abstract void GetBonus();

        public Employee(string name, int age, string app)
        {
            Name = name;
            Age = age;
            Appointment = app;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Age:{1}, Appointment: {2}", Name, Age, Appointment);
        }
    }
}
