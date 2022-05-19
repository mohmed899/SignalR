using Microsoft.AspNetCore.SignalR;
using SignalR.Models;
using SignalR.repos;
namespace SignalR.MyHub
{
    public class EmployeeHub:Hub
    {
        IEmployeeRepo db; 
        public EmployeeHub(IEmployeeRepo repo )
        {
            db = repo;
        }
        public void AddEmployee(Employee emp)
        {
            db.addEmployee(emp);
            Clients.All.SendAsync("NewEmp", emp);
        }
    }
}
