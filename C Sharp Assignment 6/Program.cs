using System;
using System.Windows.Forms;
using C_Sharp_Assignment_6.Data;
using C_Sharp_Assignment_6.Forms;
namespace C_Sharp_Assignment_6
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // SWITCH BY COMMENTING ONE LINE
            // For real database:
            IPersonDataSource source = new PersonContextDataSource();

            // For demo list:
            // IPersonDataSource source = new PersonListDataSource();

            Application.Run(new MainForm(source));
        }
    }
}