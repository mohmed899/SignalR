using Microsoft.EntityFrameworkCore;

namespace SignalR.Models
{
    public class CompanyEntity:DbContext
    {
        public CompanyEntity(DbContextOptions<CompanyEntity> options)
           : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }  
    }
}
