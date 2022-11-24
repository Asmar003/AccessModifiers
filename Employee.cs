using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Employee
    {
        string _name;
        string _surname;
        float _salary;
        public string Name
        {
            get { return _name; }
            set
            {
                if (Regex.IsMatch("name", ".*?[a-zA-Z].*?"))
                {
                    _name = value.ToUpper();
                }
                //if (value.Length >= 3 && value.Length <= 15)
                //{
                //    _name = value;
                //}
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (Regex.IsMatch("name", ".*?[a-zA-Z].*?"))
                {
                    _name = value.ToUpper();
                }
                //if ( value.Length>=5 && value.Length <= 20)
                //{
                //    _surname = value;
                //}
            }
        }
        public float Salary
        {
            get { return _salary; }
            set
            {
                if(value>=250)
                {
                    _salary = value;
                }
            }
        }
        public Employee(string name, string surname)
        {
            Name = Name;
            Surname = Surname;
            Salary = Salary;

        }
    }
}
