namespace Magazin
{
    public class Shop
    {
        public string Address { get; set; }
        public string Name { get; set; }
        protected List<Employee> employees { get; set; }

        public Shop(Employee firstEmployee)
        {
            employees = new List<Employee>() { firstEmployee };
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(int EmployeeId)
        {
            foreach (Employee employee in employees)
            {
                if (employee.EmployeeID == EmployeeId)
                    employees.Remove(employee);
            }
        }

    }
}
