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
    /// Логика взаимодействия для CoordinatorMenu.xaml
    /// </summary>
    public partial class CoordinatorMenu : Window
    {
        public CoordinatorMenu()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Sposors_Click(object sender, RoutedEventArgs e)
        {
            OverviewSponsor overviewSponsor = new OverviewSponsor();
            overviewSponsor.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RunnerManagement runnerManagement = new RunnerManagement();
            runnerManagement.Show();
            this.Close();
        }
    }
}
