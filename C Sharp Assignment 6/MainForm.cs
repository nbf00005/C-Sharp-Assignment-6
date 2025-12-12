using System;
using System.Linq;
using System.Windows.Forms;
using C_Sharp_Assignment_6.Data;
using C_Sharp_Assignment_6.Forms;
using C_Sharp_Assignment_6.Models;

namespace C_Sharp_Assignment_6
{
    public partial class MainForm : Form
    {
        private IPersonDataSource _data;

        public MainForm(IPersonDataSource dataSource)
        {
            InitializeComponent();

            _data = dataSource;

            // Set the BindingSource.DataSource to a list of Person
            personBindingSource.DataSource = _data.GetPeople();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplyFilter();
            personBindingSource.DataSource = _data.GetPeople();
        }

        private void ApplyFilter()
        {
            string filterText = txtSearch.Text.Trim().ToUpper();

            var people = _data.GetPeople();

            if (!string.IsNullOrEmpty(filterText))
            {
                people = people.Where(p =>
                    (!string.IsNullOrEmpty(p.Name) && p.Name.ToUpper().Contains(filterText)) ||
                    (!string.IsNullOrEmpty(p.Phone) && p.Phone.ToUpper().Contains(filterText))
                ).ToList();
            }

            personBindingSource.DataSource = people;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _data.SaveChanges();
            ApplyFilter();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var dlg = new AddPerson();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var newP = new Person { Name = dlg.PersonName, Phone = dlg.PersonPhone };

                if (_data is PersonContextDataSource ctx)
                {
                    var contextPrivate = typeof(PersonContextDataSource)
                        .GetField("_context", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                        .GetValue(ctx) as PersonContext;

                    contextPrivate.People.Add(newP);
                }

                if (_data is PersonListDataSource list)
                {
                    var privateField = typeof(PersonListDataSource)
                        .GetField("_people", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                    var listRef = privateField.GetValue(list) as System.Collections.Generic.List<Person>;
                    listRef.Add(newP);
                }

                _data.SaveChanges();
                ApplyFilter();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (personBindingSource.Current is Person p)
            {
                if (_data is PersonContextDataSource ctx)
                {
                    var contextPrivate = typeof(PersonContextDataSource)
                        .GetField("_context", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                        .GetValue(ctx) as PersonContext;

                    var toDelete = contextPrivate.People.FirstOrDefault(x => x.Id == p.Id);
                    if (toDelete != null)
                        contextPrivate.People.Remove(toDelete);
                }

                if (_data is PersonListDataSource list)
                {
                    var privateField = typeof(PersonListDataSource)
                        .GetField("_people", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                    var listRef = privateField.GetValue(list) as System.Collections.Generic.List<Person>;
                    listRef.Remove(p);
                }

                _data.SaveChanges();
                ApplyFilter();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
    }
}
