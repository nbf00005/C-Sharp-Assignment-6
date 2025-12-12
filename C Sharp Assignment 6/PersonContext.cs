using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using C_Sharp_Assignment_6.Models;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment_6
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PeopleDb;Trusted_Connection=True;");
    }
}
