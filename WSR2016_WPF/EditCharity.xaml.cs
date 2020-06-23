using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для EditCharity.xaml
    /// </summary>
    public partial class EditCharity : Window
    {
        Entities context = new Entities();
        public EditCharity()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            ManageCharities manageCharities = new ManageCharities();
            manageCharities.Show();
            this.Close();
        }

        private void ExitOnMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void SaveCharity_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Charity> charity = context.Charity.Where(i => i.CharityId.Equals(CharityClass.CharityId)).AsEnumerable().Select(i => { i.CharityName = NameOrganization.Text; i.CharityDescription = Opisanie.Text; i.CharityLogo = PathToFoto.Text; return i; });

            foreach (Charity customer in charity)
            {
                // Указать, что запись изменилась
                context.Entry(customer).State = EntityState.Modified;
            }

            context.SaveChanges();
        }
    }
}
