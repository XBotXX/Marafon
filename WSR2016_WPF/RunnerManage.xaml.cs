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
    /// Логика взаимодействия для RunnerManage.xaml
    /// </summary>
    public partial class RunnerManage : Window
    {
        public RunnerManage()
        {
            InitializeComponent();

            NameLbl.Content = ActiveUser.runnerControls.Select(i => i.Name).First();
            SurLbl.Content = ActiveUser.runnerControls.Select(i => i.Surname).First();
            MaleLbl.Content = ActiveUser.runnerControls.Select(i => i.GenderCSV).First();
            DateOfBithLbl.Content = ActiveUser.runnerControls.Select(i => i.DateOfBith).First();
            CountryLbl.Content = ActiveUser.runnerControls.Select(i => i.CountryCSV).First();
            CharityLbl.Content = ActiveUser.runnerControls.Select(i => i.CharityName).First();
            CountCharityMoneyLbl.Content = ActiveUser.runnerControls.Select(i => i.SponsorTarget).First();
            NaborLbl.Content = ActiveUser.runnerControls.Select(i => i.NuborCSV).First();
            DistanceLbl.Content = ActiveUser.runnerControls.Select(i => i.EventTypeMar).First();

            switch (ActiveUser.runnerControls.Select(i => i.Status).First())
            {
                case "Registered":
                    A.Background = Brushes.Green;
                    break;
                case "Payment Confirmed":
                    A.Background = Brushes.Green;
                    B.Background = Brushes.Green;
                    break;
                case "Race Kit Sent":
                    A.Background = Brushes.Green;
                    B.Background = Brushes.Green;
                    C.Background = Brushes.Green;
                    break;
                case "Race Attended":
                    A.Background = Brushes.Green;
                    B.Background = Brushes.Green;
                    C.Background = Brushes.Green;
                    D.Background = Brushes.Green;
                    break;
            }

            EmailLbl.Content = ActiveUser.runnerControls.Select(i => i.Email).First().ToString();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            RunnerManagement runnerManagement = new RunnerManagement();
            runnerManagement.Show();
            this.Close();
        }

        private void ExitOnMainWindows(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void CoordinatorEditRunnerFormShow_Click(object sender, RoutedEventArgs e)
        {
            CoordinatorEditRunnerProfile editRunnerProfile = new CoordinatorEditRunnerProfile();
            editRunnerProfile.Show();
            this.Close();
        }

        private void PrintBage_Click(object sender, RoutedEventArgs e)
        {
            CertificatePreview certificatePreview = new CertificatePreview();
            certificatePreview.Show();
            this.Close();
        }

        private void ShowBage_Click(object sender, RoutedEventArgs e)
        {
            CertificatePreview certificatePreview = new CertificatePreview();
            certificatePreview.Show();
            this.Close();
        }
    }
}
