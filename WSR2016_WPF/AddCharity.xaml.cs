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
    /// Логика взаимодействия для AddCharity.xaml
    /// </summary>
    public partial class AddCharity : Window
    {
        Entities context = new Entities();
        public AddCharity()
        {
            InitializeComponent();
        }

        private void ExitOnMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            ManageCharities manageCharities = new ManageCharities();
            manageCharities.Show();
            this.Close();
        }

        private void SaveCharity_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                context.Charity.Add(new Charity
                {
                    CharityName=NameOrganization.Text.Trim(),
                    CharityDescription=Opisanie.Text,
                    CharityLogo=LogoPath.Text.Trim()
                });
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверно введены данные");
            }
        }
    }
}
