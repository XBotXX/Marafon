using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для ManageCharities.xaml
    /// </summary>
    public partial class ManageCharities : Window
    {
        Entities context = new Entities();
        public ManageCharities()
        {
            InitializeComponent();
            dgUsers.ItemsSource = context.Charity.ToList();
        }

        private void GotoEditCharity_Click(object sender, RoutedEventArgs e)
        {
            var rows = (Charity)dgUsers.SelectedItem;
            CharityClass.CharityId = context.Charity.Where(i => i.CharityName == rows.CharityName).Select(i => i.CharityId).First();

            EditCharity editCharity = new EditCharity();

            editCharity.NameOrganization.Text = rows.CharityName;
            editCharity.Opisanie.Text = rows.CharityDescription;
            editCharity.PathToFoto.Text = rows.CharityLogo;

            editCharity.Show();
            this.Close();
        }

        private void ExitOnMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MenuAdministrator menuAdministrator = new MenuAdministrator();
            menuAdministrator.Show();
            this.Close();
        }

        private void GotoAddCharity(object sender, RoutedEventArgs e)
        {
            AddCharity addCharity = new AddCharity();
            addCharity.Show();
            this.Close();
        }
        public class charities
        {
            public Image Logo { get; set; }
            public string Name { get; set; }
            public string Opisnie { get; set; }
            public Button Edit { get; set; }
        }
    }
}
