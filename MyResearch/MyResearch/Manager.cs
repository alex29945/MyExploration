using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResearch
{
    [Serializable]
    class Manager : Employee
    {
        
        public int StaffCount { get; set; }
        public Manager(string name, int age, string app, int staff) : base(name, age, app)
        {
            StaffCount = staff;
        }

        public override void GetBonus()
        {
            Console.WriteLine("Get 500$");
        }
    }
}