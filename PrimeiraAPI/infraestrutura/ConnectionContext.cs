using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Model;

namespace PrimeiraAPI.infraestrutura
{
    public class ConnectionContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
            "Server=localhost;" +
            "port=5432;Database=CRUD_SEXTA;" +
            "User Id=postgres;" +
            "Password=123");
    }
}
