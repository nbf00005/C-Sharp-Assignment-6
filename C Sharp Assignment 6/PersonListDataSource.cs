using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_Assignment_6.Models;

namespace C_Sharp_Assignment_6.Data
{
    public class PersonListDataSource : IPersonDataSource
    {
        private List<Person> _people = new List<Person>();

        public PersonListDataSource()
        {
            _people.Add(new Person { Id = 1, Name = "Alice", Phone = "111-1111" });
            _people.Add(new Person { Id = 2, Name = "Bob", Phone = "222-2222" });
            _people.Add(new Person { Id = 3, Name = "Charlie", Phone = "333-3333" });
        }

        public IEnumerable<Person> GetPeople()
        {
            return _people.ToList();
        }

        public IEnumerable<Person> GetPeople(string filter)
        {
            if (string.IsNullOrWhiteSpace(filter))
                return GetPeople();

            filter = filter.ToLower();

            return _people
                .Where(p => p.Name.ToLower().Contains(filter))
                .ToList();
        }

        public void SaveChanges()
        {
            // no-op (violates SRP for bonus points)
        }
    }
}
