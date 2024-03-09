using Microsoft.EntityFrameworkCore;

namespace Demo.Model
{
    public class EmployeeContext: DbContext
    {

        // here we define a table on which we perform a operation
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        { }

        public DbSet<TblEmployee> TblEmployees { get; set; }
        public DbSet<TblDesignation> TblDesignation { get; set; }


    }
}
