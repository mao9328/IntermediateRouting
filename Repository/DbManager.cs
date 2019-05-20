using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class DbManager : DbContext
    {
        public DbManager()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                                
        }

        //entities
        public DbSet<ConfigurationServiceProvider> Config { get; set; }
    }
}
