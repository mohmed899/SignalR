using SignalR.Models;

namespace SignalR.repos
{
    public interface IEmployeeRepo
    {
       public  int addEmployee(Employee emp);
        public List<Employee> getAll();
    }
}