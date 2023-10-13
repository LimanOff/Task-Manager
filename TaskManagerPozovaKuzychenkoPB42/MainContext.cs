using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TaskManagerPozovaKuzychenkoPB42
{
    public class MainContext : DbContext
    {
        private readonly string _connectionStringHome = "Data Source=.\\SQLEXPRESS;Initial Catalog=TaskManager4211;User ID=sa;Password=1;TrustServerCertificate=true";
        private readonly string _connectionStringAKVT = "Data Source=192.168.221.12;Initial Catalog=TaskManager4211;User ID=user11;Password=11;TrustServerCertificate=true";

        public MainContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionStringHome);
        }
    }
}
