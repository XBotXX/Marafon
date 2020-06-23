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
    /// Логика взаимодействия для OverviewSponsor.xaml
    /// </summary>
    public partial class OverviewSponsor : Window
    {
        Entities context = new Entities();

        List<CharitySponsor> charitySponsors = new List<CharitySponsor>();
        public OverviewSponsor()
        {
            InitializeComponent();

            var d = from user in context.Charity
                    join run in context.Registration on user.CharityId equals run.CharityId
                    join reg in context.Sponsorship on run.RegistrationId equals reg.RegistrationId
                    select new
                    {
                        Name = user.CharityName,
                        Summa = reg.Amount
                    };

            var result = d.ToList();//.GroupBy(i => i.Name).Select(group => group.FirstOrDefault()).ToList();

            decimal summaSum = 0;

            foreach (var s in result)
            {
                charitySponsors.Add(new CharitySponsor
                {
                    Name = s.Name,
                    Summa = s.Summa
                });

                summaSum += s.Summa;
            }

            dgCharity.ItemsSource = charitySponsors.ToList();

            CountOrg.Content = context.Charity.ToList().Count();

            SummLabel.Content = "$" + summaSum;
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            CoordinatorMenu coordinatorMenu = new CoordinatorMenu();
            coordinatorMenu.Show();
            this.Close();
        }

        private void ExitOmMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void SortTable_Click(object sender, RoutedEventArgs e)
        {
            switch (SortCombo.Text)
            {
                case "Name":
                    dgCharity.ItemsSource = charitySponsors.OrderBy(i => i.Name).ToList();
                    break;
                case "Summa":
                    dgCharity.ItemsSource = charitySponsors.OrderBy(i => i.Summa).ToList();
                    break;
            }
        }
    }

    class CharitySponsor
    {
        public string Name { get; set; }
        public decimal Summa { get; set; }
    }
}
