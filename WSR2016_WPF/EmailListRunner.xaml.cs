using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для EmailListRunner.xaml
    /// </summary>
    public partial class EmailListRunner : Window
    {
        public string str = "";
        public EmailListRunner() { }

        public EmailListRunner(List<RunnerControl> res)
        {
            InitializeComponent();

            dgUsersEmail.ItemsSource = res.ToList();

            foreach (var s in res.Select(i => i.Email))
            {
                str += s;
            }
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(str);
        }
    }
}
