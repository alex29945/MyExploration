using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResearch
{
    
    class EmployeeCollection : IEnumerable
    {
        private List<Employee> employees = new List<Employee>();

        public Employee this[int index]
        {
            get { return employees[index]; }
        }

        public void Add(Employee emp)
        {
            employees.Add(emp);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var e in employees)
            {
                yield return e;
            }
        }

        public List<Employee> GetList()
        {
            return employees;
        }

    }
}
