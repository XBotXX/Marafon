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
    /// Логика взаимодействия для SponsorRunner.xaml
    /// </summary>
    public partial class SponsorRunner : Window
    {
        public int id;
        public string txt;
        Entities context = new Entities();
        public SponsorRunner()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        // проверка данных перед отправкой на корректность кнопка Заплатить
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Int64.TryParse(Number.Text,out long num) && Int32.TryParse(CVC.Text,out int cvc) && Int32.TryParse(Month.Text, out int month) && Int32.TryParse(Year.Text, out int year) && Number.Text.Length==16 && CVC.Text.Length==3 && month <= 12 && month > 0 && year >= DateTime.Now.Year && Int32.Parse(SummaDonation.Text)>0 && RunnerList.SelectedItem != null)
            {
                context.Sponsorship.Add(new Sponsorship
                {
                    SponsorName = SponName.Text,
                    RegistrationId = id,
                    Amount = Convert.ToDecimal(SummaDonation.Text)
                });
                // колхоз
                string rt = "";
                for (int i = 3; i < 16; i += 4)
                {
                    rt += RunnerList.SelectedItem.ToString().Split(' ')[i] + " ";
                }
                //
                context.SaveChanges();
                ThanksSponsor thanks = new ThanksSponsor();
                thanks.SummaDonata.Content = this.LabelDonat.Content;
                thanks.RunnerInf.Text = rt;
                thanks.FondInf.Text = this.InfAboutFond.Text;
                thanks.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Некоректно введённые данные", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Minus(object sender, RoutedEventArgs e)
        {
            if(Int32.TryParse(SummaDonation.Text,out int res) && res > 0)
            {
                SummaDonation.Text = (res - 10).ToString();
            }
        }

        private void Plus(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(SummaDonation.Text, out int res))
            {
                SummaDonation.Text = (res + 10).ToString();
            }
        }

        private void Prirav(object sender, TextChangedEventArgs e)
        {
            LabelDonat.Content = SummaDonation.Text+"$";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var result = from user in context.User
                         join run in context.Runner on user.Email equals run.Email
                         join reg in context.Registration on run.RunnerId equals reg.RunnerId
                         join even in context.RegistrationEvent on reg.RegistrationId equals even.RegistrationId
                         select new
                         {
                             FirstName = user.FirstName + " ",
                             LastName = user.LastName + " ",
                             BibNumber = even.BibNumber + " ",
                             CountryCode = run.CountryCode + " ",
                             RegistrationId = even.RegistrationId
                         };
            //List<string> xz = new List<string>();
            //foreach(var a in result)
            //{
            //    xz.Add(a.FirstName + " " + a.LastName + " " + a.BibNumber + " " + a.CountryCode);
            //}
            RunnerList.ItemsSource = result.ToList();
        }

        private void RunnerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            id = Int32.Parse(RunnerList.SelectedItem.ToString().Split(' ')[11].Trim());
            int znachenie = context.Registration.Where(i => i.RegistrationId == id).Select(i => i.CharityId).ToList()[0];
            InfAboutFond.Text = context.Charity.Where(i => i.CharityId == znachenie).Select(i => i.CharityName).ToList()[0].ToString();
            txt = context.Charity.Where(i => i.CharityId == znachenie).Select(i => i.CharityDescription).ToList()[0].ToString();
            // колхоз
            //InfAboutFond.Text = b[0].ToString();
        }

        private void ButtonInf_Click(object sender, RoutedEventArgs e)
        {
            InfAboutCharity infAboutCharity = new InfAboutCharity();
            infAboutCharity.Owner = this;
            infAboutCharity.Title.Text = InfAboutFond.Text;
            infAboutCharity.Opisanie.Text = txt;
            infAboutCharity.ShowDialog();
        }
    }
}
