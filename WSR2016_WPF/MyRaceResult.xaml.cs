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
    /// Логика взаимодействия для MyRaceResult.xaml
    /// </summary>
    public partial class MyRaceResult : Window
    {
        Entities context = new Entities();
        public MyRaceResult()
        {
            InitializeComponent();

            var res = context.RegistrationEvent.Where(i => i.RegistrationId == UserClass.RegId).ToList();

            var result = from user in res
                         join run in context.Event on user.EventId equals run.EventId
                         join reg in context.EventType on run.EventTypeId equals reg.EventTypeId
                         select new
                         {
                             MarafonName = run.EventName,
                             Distance = reg.EventTypeName,
                             TimeRun = user.RaceTime,
                             Mestoall = 705,
                             MestoCategory =121
                         };
            ResultationRunner.ItemsSource = result;
        }

        private void ExitOnMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MenuRunner menuRunner = new MenuRunner();
            menuRunner.Show();
            this.Close();
        }

        private void AllRunner(object sender, RoutedEventArgs e)
        {
            LastResultRunner lastResult = new LastResultRunner();
            lastResult.Show();
            this.Close();
        }
    }
}
