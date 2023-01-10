using Core_Proje_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Proje_Api.DAL.ApiContext
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            var activeConn = configuration.GetSection("ActiveConn").Value;
            optionsBuilder.UseSqlServer(configuration.GetConnectionString(activeConn));
        }
        public DbSet<Category> Category { get; set; }
    }
}
