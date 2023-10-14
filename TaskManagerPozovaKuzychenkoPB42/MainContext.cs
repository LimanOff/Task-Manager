using Microsoft.EntityFrameworkCore;
using TaskManager_2.Data;

namespace TaskManagerPozovaKuzychenkoPB42
{
    public class MainContext : DbContext
    {
        private readonly string _connectionHome = "Data Source=localhost;Initial Catalog=TaskManager4211;Trusted_Connection=True;TrustServerCertificate=true";
        private readonly string _connectionAKVT = "Data Source=192.168.221.12;Initial Catalog=TaskManager4211;User ID=user11;Password=11;TrustServerCertificate=true";

        public MainContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionHome);
        }
    }
}
