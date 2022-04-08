using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferProject.PostresqlModels
{
    public class PostgresqlContext : DbContext
    {
        public PostgresqlContext()
        {
        }

        public PostgresqlContext(DbContextOptions<PostgresqlContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<CustomerCompany> CustomerCompany { get; set; }
        public DbSet<CustomerGroup> CustomerGroup { get; set; }
        public DbSet<CustomerStation> CustomerStation { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<DeviceReader> DeviceReader { get; set; }
        public DbSet<Gsm> Gsm { get; set; }
        public DbSet<Logs> Logs { get; set; }
        public DbSet<Package> Package { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=127.0.0.1;Database=PostgresqlDb;Search Path=public;Username=admin;Password=11111111");
        }
    }
}
