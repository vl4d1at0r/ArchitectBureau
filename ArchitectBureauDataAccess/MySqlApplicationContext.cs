using Microsoft.EntityFrameworkCore;

namespace ArchitectBureauDataAccess
{
    public sealed class MySqlApplicationContext : ApplicationContext
    {
        private string connectionString = "Server=localhost;UserId=root;Password=root;database=architectbureau;";

        public MySqlApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}