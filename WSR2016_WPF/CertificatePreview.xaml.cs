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
    /// Логика взаимодействия для CertificatePreview.xaml
    /// </summary>
    public partial class CertificatePreview : Window
    {
        Entities context = new Entities();
        public CertificatePreview()
        {
            InitializeComponent();

            ComboRaceEvent.ItemsSource = context.EventType.Select(i => i.EventTypeName).ToList();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            RunnerManage runnerManage = new RunnerManage();
            runnerManage.Show();
            this.Close();
        }

        private void ExitOnMainWindows(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
