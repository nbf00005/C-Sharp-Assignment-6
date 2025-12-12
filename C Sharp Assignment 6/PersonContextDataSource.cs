using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using C_Sharp_Assignment_6.Models;

namespace C_Sharp_Assignment_6.Data
{
    public class PersonContextDataSource : IPersonDataSource
    {
        private PersonContext _context;

        public PersonContextDataSource()
        {
            _context = new PersonContext();

            // Ensure the database is created before loading data
            _context.Database.EnsureCreated();

            // Now safe to load the People into Local list
            _context.People.Load();
        }

        public IEnumerable<Person> GetPeople()
        {
            return _context.People.Local.ToBindingList();
        }

        public IEnumerable<Person> GetPeople(string filter)
        {
            if (string.IsNullOrWhiteSpace(filter))
                return GetPeople();

            filter = filter.ToLower();

            return _context.People.Local
                .Where(p => p.Name != null && p.Name.ToLower().Contains(filter))
                .ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
