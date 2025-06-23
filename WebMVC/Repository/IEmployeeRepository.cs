using WebMVC.Models;
namespace WebMVC.Repository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();

        Employee GetEmployeeById(int id);

        void AddEmployee(Employee emp);

        void UpdateEmployee(Employee emp);

        void DeleteEmployee(int id);
    }
}
