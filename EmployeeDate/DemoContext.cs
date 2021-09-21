using EmployeeModel;
using Microsoft.EntityFrameworkCore;

namespace EmployeeData
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {

        }

        public DbSet<Employees> Employees { get; set; }
    }
}
