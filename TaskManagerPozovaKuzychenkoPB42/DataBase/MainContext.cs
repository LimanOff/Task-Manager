using Microsoft.EntityFrameworkCore;
using TaskManagerPozovaKuzychenkoPB42.DataBase.Data;

namespace TaskManagerPozovaKuzychenkoPB42.DataBase
{
    public class MainContext : DbContext
    {
        private readonly string _connectionHome = "Data Source=localhost;Initial Catalog=TaskManager4211;Trusted_Connection=True;TrustServerCertificate=True";
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
