namespace ClassLibrary1
{
    public class DepartmentBase
    {
        readonly int _employeelimit;
        readonly int _salarylimit;
        string _name;
        Employee[] Employees;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length >= 3 && value.Length <= 15)
                {
                    _name = value;
                }
            }
        }
        public void AddEmployee(Employee employees)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employees;
        }
    }
}