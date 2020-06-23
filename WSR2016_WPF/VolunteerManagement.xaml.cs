using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WSR2016_WPF
{
    /// <summary>
    /// Логика взаимодействия для VolunteerManagement.xaml
    /// </summary>
    public partial class VolunteerManagement : Window
    {
        Entities context = new Entities();
        string b;
        public VolunteerManagement()
        {
            InitializeComponent();
            dgUsers.ItemsSource = context.Volunteer.ToList();
            var a = typeof(Volunteer).GetProperties().Select(t => t.Name).ToList();
            RemoveMethod(a, "VolunteerId", "Gender1", "Country");
            SortVolanteers.ItemsSource = a;
            CountVolunteers.Content = context.Volunteer.Count();
        }

        private void RemoveMethod(List<string> a, params string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                a.Remove(str[i]);
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MenuAdministrator menuAdministrator = new MenuAdministrator();
            menuAdministrator.Show();
            this.Close();
        }

        private void ExitOnMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void GotoImportVolunteers(object sender, RoutedEventArgs e)
        {
            ImportVolunteers importVolunteers = new ImportVolunteers();
            importVolunteers.Show();
            this.Close();
        }

        private void FiltrVolanteers_Click(object sender, RoutedEventArgs e)
        {
            string select = SortVolanteers.SelectedItem.ToString();
            dgUsers.ItemsSource = context.Volunteer.SqlQuery($"select * from Volunteer order by {select}").ToList();
        }

        private void SortVolanteers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = SortVolanteers.SelectedItem.ToString();
            b = a;
        }
    }
}
