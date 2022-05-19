using SignalR.Models;

namespace SignalR.repos
{
    public class EmployeeRepo : IEmployeeRepo
    {
        CompanyEntity db;
        public EmployeeRepo(CompanyEntity entity)
        {
            db = entity;
        }

        public int addEmployee(Employee emp)
        {
            try
            {
                db.Add(emp);
                return db.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public List<Employee> getAll()
        {
            return db.Employees.ToList();

        }
    }
}
