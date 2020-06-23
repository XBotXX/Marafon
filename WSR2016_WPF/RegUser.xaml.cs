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
    /// Логика взаимодействия для RegUser.xaml
    /// </summary>
    public partial class RegUser : Window
    {
        Entities context = new Entities();
        Entities context1 = new Entities();
        public RegUser()
        {
            InitializeComponent();
            Gender.ItemsSource = context.Gender.Select(i => i.Gender1).ToList();
            Country.ItemsSource = context.Country.Select(i => i.CountryCode).ToList();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void RegistrationRunner_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                context1.User.Add(new User
                {
                    Email = Email.Text,
                    Password = Pass.Text,
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    RoleId = "R"
                });
                context1.SaveChanges();
                context.Runner.Add(new Runner
                {
                    Email = Email.Text,
                    Gender = Gender.Text,
                    DateOfBirth = DateOfBirth.SelectedDate,
                    CountryCode = Country.Text
                });
                context.SaveChanges();
                MenuRunner runner = new MenuRunner();
                runner.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
