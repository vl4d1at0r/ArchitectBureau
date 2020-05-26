using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ArchitectBuroDataAccess
{
    public class MySQLApplicationContext : ApplicationContext
    {
        public MySQLApplicationContext()
        { 
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;UserId=root;Password=root;database=architectburo;");
        }
    }
}
