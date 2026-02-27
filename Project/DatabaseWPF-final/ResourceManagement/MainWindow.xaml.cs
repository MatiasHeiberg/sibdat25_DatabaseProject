using ResourceManagement.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ResourceManagement
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            using var db = new ResourceManagementDBContext();
            dgItems.ItemsSource = db.Employees.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedEmployee = (ResourceManagement.Model.Employee)dgItems.SelectedItem;
            using var db = new ResourceManagementDBContext();
            db.Employees.Remove(selectedEmployee);
            db.SaveChanges();

            dgItems.ItemsSource = db.Employees.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbSurname.Text))
            {
                MessageBox.Show("FirstName og Surname has to be filled!");
                return;
            }

            using var db = new ResourceManagementDBContext();

            var emp = new ResourceManagement.Model.Employee
            {
                FirstName = tbFirstName.Text,
                Surname = tbSurname.Text,
                PhoneNumber = tbPhoneNumber.Text,
                Role = tbRole.Text,
            };

            db.Employees.Add(emp);
            db.SaveChanges();

            LoadEmployees();
        }
        /// <summary>
        /// Henter det samlede antal medarbejdere fra databasen ved at kalde den stored procedure 'GetEmployeeCount'.
        /// OBS: Denne funktion virker ikke, fordi vi ikke har løkkedes med at gemme den stored procedure på databasen.
        /// Den ligger kun lokalt på vores maskine.
        /// </summary>
        private void btnCount_Click_1(object sender, RoutedEventArgs e)
        {
            using var db = new ResourceManagementDBContext();
            var count = db.Database.SqlQueryRaw<int>("EXEC GetEmployeeCount").ToList()[0];
            MessageBox.Show($"Total employees: {count}");
        }
    }
    }
