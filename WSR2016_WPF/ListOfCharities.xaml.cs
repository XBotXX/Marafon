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
    /// Логика взаимодействия для ListOfCharities.xaml
    /// </summary>
    public partial class ListOfCharities : Window
    {
        Entities context = new Entities();
        public ListOfCharities()
        {
            InitializeComponent();
            CharityListBox.ItemsSource = context.Charity.ToList();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Information information = new Information();
            information.Show();
            this.Close();
        }
    }
}
