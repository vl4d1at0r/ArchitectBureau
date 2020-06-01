using Microsoft.EntityFrameworkCore;

namespace ArchitectBureauDataAccess
{
    public sealed class MySqlApplicationContext : ApplicationContext
    {
        public MySqlApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;UserId=root;Password=root;database=architectbureau;");
        }
    }
}