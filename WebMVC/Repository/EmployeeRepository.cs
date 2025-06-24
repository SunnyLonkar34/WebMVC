

using WebMVC.Models;

namespace WebMVC.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        static List<Employee> _employees = new List<Employee>(); 
        static EmployeeRepository() //it will only call once ,only once memory will be allocated
        {
            Employee objEmployee1 = new Employee();
            objEmployee1.Id = 1;
            objEmployee1.Name = "Sunny";
            objEmployee1.Salary = 5000;
            objEmployee1.City = "Nashik";

            _employees.Add(objEmployee1);
            _employees.Add(new Employee() { Id = 2, Name = "Taufique", Salary = 6000, City = "Mumbai" });
            _employees.Add(new Employee() { Id = 3, Name = "Yash", Salary = 7000, City = "Pune" });

        }
        public void AddEmployee(Employee emp)
        {
            _employees.Add(emp);
        }

        public void DeleteEmployee(int id)
        {
            var employee = _employees.First(emp => emp.Id == id);
           
            _employees.Remove(employee);
        }

        public Employee GetEmployeeById(int id)
        {
            //Linq = Language Integrated Query
            var employee = _employees.First(emp => emp.Id == id);
            employee.Company = new CompanyDetail() { Id = 1, CompanyName = "Winjit", CompanyNumber = "123456789" };
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public void UpdateEmployee(Employee emp)
        {
            var employee = _employees.First(value => value.Id == emp.Id);
            employee.Name=emp.Name;
            employee.Salary=emp.Salary;
            employee.City=emp.City;
        }
    }

}