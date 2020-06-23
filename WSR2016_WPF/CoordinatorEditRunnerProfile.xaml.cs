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
    /// Логика взаимодействия для CoordinatorEditRunnerProfile.xaml
    /// </summary>
    public partial class CoordinatorEditRunnerProfile : Window
    {
        Entities context = new Entities();
        public CoordinatorEditRunnerProfile()
        {
            InitializeComponent();

            MaleCombo.ItemsSource = context.Gender.Select(i => i.Gender1).ToList();
            Countrty.ItemsSource = context.Country.Select(i => i.CountryCode).ToList();
            RegCombo.ItemsSource = context.RegistrationStatus.Select(i => i.RegistrationStatus1).ToList();

            EmailLbl.Content = ActiveUser.runnerControls.Select(i => i.Email).First();
            NameTxt.Text = ActiveUser.runnerControls.Select(i => i.Name).First();
            SurNameTxt.Text = ActiveUser.runnerControls.Select(i => i.Surname).First();
            MaleCombo.Text = ActiveUser.runnerControls.Select(i => i.GenderCSV).First();
            DateOfBith.SelectedDate = ActiveUser.runnerControls.Select(i => i.DateOfBith).First();
            Countrty.Text = ActiveUser.runnerControls.Select(i => i.CountryCSV).First();
            RegCombo.Text = ActiveUser.runnerControls.Select(i => i.Status).First();
            PasTxt.Text = ActiveUser.runnerControls.Select(i => i.Pas).First();
            PasTxtPovtor.Text = ActiveUser.runnerControls.Select(i => i.Pas).First();

        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            RunnerManage editRunner = new RunnerManage();
            editRunner.Show();
            this.Close();
        }

        private void ExitOnMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
