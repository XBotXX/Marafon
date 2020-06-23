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
    /// Логика взаимодействия для InventarPostuplenie.xaml
    /// </summary>
    public partial class InventarPostuplenie : Window
    {
        Entities context = new Entities();
        public InventarPostuplenie()
        {
            InitializeComponent();

            var result = from product in context.Products
                         select new
                         {
                             Name = product.NameProducts,
                             Post = ""
                         };
            dateGrid.ItemsSource = result.ToList();
        }

        private void ExitOnMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Inventar inventar = new Inventar();
            inventar.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
        }
    }
}
