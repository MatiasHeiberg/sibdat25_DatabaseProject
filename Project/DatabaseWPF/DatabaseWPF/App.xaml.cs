using System.Configuration;
using System.Data;
using System.Linq.Expressions;
using System.Windows;
using DatabaseWPF.Data;
using Microsoft.EntityFrameworkCore;

namespace DatabaseWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Overrider OnStartup for at sikre at database migreres ved opstart hvis der er ændringer i modellen.
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            try
            {
                using (var db = new FleetDbContext())
                    db.Database.Migrate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    