using EmployeeLibrary;
using Microsoft.EntityFrameworkCore;

internal class EmployeeDb : DbContext
{
    public EmployeeDb(DbContextOptions options) : base(options) { }

    public DbSet<Employee> Employees {  get; set; }
}