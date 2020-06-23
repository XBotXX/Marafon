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
    /// Логика взаимодействия для EditRunnerProfile.xaml
    /// </summary>
    public partial class EditRunnerProfile : Window
    {
        Entities context = new Entities();
        public EditRunnerProfile()
        {
            InitializeComponent();
            UserMail.Content = context.Runner.Where(i => i.RunnerId == UserClass.UserId).Select(i => i.Email).First();
            GenderUser.ItemsSource= context.Gender.Select(i => i.Gender1).ToList();
            CountryUser.ItemsSource= context.Country.Select(i => i.CountryCode).ToList();
            PasUser.Text = context.User.Where(i => i.Email == UserMail.Content.ToString()).Select(i => i.Password).First();
            PasUserRetry.Text = PasUser.Text;
            NameUser.Text = context.User.Where(i => i.Email == UserMail.Content.ToString()).Select(i => i.FirstName).First();
            SurName.Text= context.User.Where(i => i.Email == UserMail.Content.ToString()).Select(i => i.LastName).First();
            DateOfBirthUser.SelectedDate = context.Runner.Where(i => i.Email == UserMail.Content.ToString()).Select(i => i.DateOfBirth).First();
            GenderUser.SelectedItem = context.Runner.Where(i => i.Email == UserMail.Content.ToString()).Select(i => i.Gender).First();
            CountryUser.SelectedItem= context.Runner.Where(i => i.Email == UserMail.Content.ToString()).Select(i => i.CountryCode).First();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MenuRunner runner = new MenuRunner();
            runner.Show();
            this.Close();
        }

        private void ExitOnMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var a = context.User.Where(i => i.Email == UserMail.Content.ToString()).First();
                a.FirstName = NameUser.Text;
                a.LastName = SurName.Text;
                a.Password = PasUser.Text;
                var b = context.Runner.Where(i => i.Email == UserMail.Content.ToString()).First();
                b.CountryCode = CountryUser.Text;
                b.DateOfBirth = DateOfBirthUser.SelectedDate;
                b.Gender = GenderUser.Text;
                context.SaveChanges();

                MenuRunner runner = new MenuRunner();
                runner.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Неверные данные");
            }
        }
    }
}
