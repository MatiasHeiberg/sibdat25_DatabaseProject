using System;
using System.Linq;
using System.Windows;
using DatabaseWPF.Data;
using DatabaseWPF.Model;
using Microsoft.EntityFrameworkCore;

namespace DatabaseWPF
{
    public partial class MainWindow : Window
    {
        private FleetDbContext _db;

        public MainWindow()
        {
            InitializeComponent();
/*/
            _db = new FleetDbContext();
            LoadEmployees();
/*/
        }
        /*/
        private void LoadEmployees()
        {
            // Hent data fra DB til EF-tracking
            _db.Employees.Load();

            // Bind DataGrid direkte til EF's Local view
            EmployeesGrid.ItemsSource = _db.Employees.Local.ToObservableCollection();
        }

        private void Reload_Click(object sender, RoutedEventArgs e)
        {
            // Smid contexten væk og hent på ny (simpel og robust)
            _db.Dispose();
            _db = new FleetDbContext();
            LoadEmployees();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            // Minimal employee der overholder NOT NULL på FirstName/Surname
            var emp = new Employee
            {
                FirstName = "New",
                Surname = "Employee",
                EmployeeIsActive = true
            };

            _db.Employees.Add(emp);
            _db.SaveChanges(); // giver EmployeeId med det samme
            EmployeesGrid.SelectedItem = emp;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Sørg for at DataGrid sender sidste edit til objektet
                EmployeesGrid.CommitEdit();
                EmployeesGrid.CommitEdit();

                _db.SaveChanges();
                MessageBox.Show("Saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeesGrid.SelectedItem is not Employee emp)
            {
                MessageBox.Show("Vælg en employee først.");
                return;
            }

            try
            {
                _db.Employees.Remove(emp);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            _db.Dispose();
            base.OnClosed(e);
        }
        /*/
    }
}