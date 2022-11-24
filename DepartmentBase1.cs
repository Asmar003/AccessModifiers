namespace ClassLibrary1
{
    public class DepartmentBase1
    {
        Employee[] Employees;
        public void AddEmployee(Employee employees)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employees;
        }
    }
}