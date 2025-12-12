using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_Assignment_6.Models;

namespace C_Sharp_Assignment_6.Data
{
    public interface IPersonDataSource
    {
        IEnumerable<Person> GetPeople();
        IEnumerable<Person> GetPeople(string filter);
        void SaveChanges();
    }
}
