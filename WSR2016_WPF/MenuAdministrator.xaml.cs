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
    /// Логика взаимодействия для MenuAdministrator.xaml
    /// </summary>
    public partial class MenuAdministrator : Window
    {
        public MenuAdministrator()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void GotoUserManage(object sender, RoutedEventArgs e)
        {
            UserManagement userManagement = new UserManagement();
            userManagement.Show();
            this.Close();
        }

        private void GotoManageCharities(object sender, RoutedEventArgs e)
        {
            ManageCharities manageCharities = new ManageCharities();
            manageCharities.Show();
            this.Close();
        }

        private void GotoVolunterManagement(object sender, RoutedEventArgs e)
        {
            VolunteerManagement volunteerManagement = new VolunteerManagement();
            volunteerManagement.Show();
            this.Close();
        }

        private void GotoInventar(object sender, RoutedEventArgs e)
        {
            Inventar inventar = new Inventar();
            inventar.Show();
            this.Close();
        }
    }
}
