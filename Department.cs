using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Department
    {
        string _name;
        readonly int _employeelimit;
        readonly int _salarylimit;
        Employee[] Employees;
        public string Name
        {
            get { return _name; }
            set
            {
                if(value.Length >= 3 && value.Length <= 15)
                {
                    _name = value;
                }
            }
        }
        public Department(string name, int employeelimit, int salarylimit )
        {
            Name = name;
            _employeelimit = employeelimit;
            _salarylimit = salarylimit;
            Employees = new Employee[0];
        }
        internal void AddEmployee(Employee employees)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employees;
        }
    }
}