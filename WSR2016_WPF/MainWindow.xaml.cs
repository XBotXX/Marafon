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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WSR2016_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        DateTime MarathonDay = new DateTime(2020, 10, 21, 0, 0, 0);
        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 1, 0);
            TimeSpan interval = MarathonDay - DateTime.Now;
            timer.Start();
            MatchTime.Content = (interval.Days).ToString() + " дней " + (interval.Hours).ToString() + " часов и  " + (interval.Minutes).ToString() + " минут до старта марафона!";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan interval = MarathonDay - DateTime.Now;
            MatchTime.Content = (interval.Days).ToString() + " дней " + (interval.Hours).ToString() + " часов и  " + (interval.Minutes).ToString() + " минут до старта марафона!";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SponsorRunner sponsor = new SponsorRunner();
            sponsor.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LastRunner last = new LastRunner();
            last.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Information information = new Information();
            information.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Avtorization avtorization = new Avtorization();
            avtorization.Show();
            this.Close();
        }
    }
}
