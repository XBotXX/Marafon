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
    /// Логика взаимодействия для MySponsorship.xaml
    /// </summary>
    public partial class MySponsorship : Window
    {
        Entities context = new Entities();

        List<Sponsorship> sponsorships = new List<Sponsorship>();
        public MySponsorship()
        {
            InitializeComponent();

            sponsorships = context.Sponsorship.Where(i => i.RegistrationId == UserClass.RegId).ToList();

            SponsorList.ItemsSource = sponsorships;

            var a = sponsorships.Select(i => i.RegistrationId).First();
            var result = from user in context.Registration
                         where user.RegistrationId == a
                         join charity in context.Charity on user.CharityId equals charity.CharityId
                         select new
                         {
                             CharityName = charity.CharityName + " ",
                             CharityDescription = charity.CharityDescription + " ",
                             CharityLogo = charity.CharityLogo + " "
                         };

            TitleCharity.Content = result.Select(i => i.CharityName).First();
            DescriptionCharity.Text = result.Select(i => i.CharityDescription).First();

            string count = sponsorships.Sum(i => i.Amount).ToString();
            SummCharity.Content = "$" + count;
        }

        private void ExitOnMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MenuRunner runner = new MenuRunner();
            runner.Show();
            this.Close();
        }

        private void SponsorList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
