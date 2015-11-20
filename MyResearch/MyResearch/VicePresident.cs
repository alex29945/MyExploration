using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResearch
{
    [Serializable]
    class VicePresident : Employee
    {
        public int DepartmentsCount { get; set; }
        public VicePresident(string name, int age, string app, int dep) : base(name, age, app)
        {
            DepartmentsCount = dep;
        }

        public override void GetBonus()
        {
            Console.WriteLine("Get 1000$");
        }
    }
}
