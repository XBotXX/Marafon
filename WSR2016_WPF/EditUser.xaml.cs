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
    /// Логика взаимодействия для EditUser.xaml
    /// </summary>
    public partial class EditUser : Window
    {
        Entities context = new Entities();
        public EditUser()
        {
            InitializeComponent();
            RoleIdUser.ItemsSource = context.User.Select(i => i.RoleId).Distinct().ToList();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            UserManagement userManagement = new UserManagement();
            userManagement.Show();
            this.Close();
        }

        private void ExitOnMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void SaveNewData_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<User> users = context.User.Where(i => i.Email.Equals(EmailText.Text)).AsEnumerable().Select(i => { i.FirstName = FirstNameUser.Text; i.LastName = LastNameUser.Text; i.RoleId = RoleIdUser.SelectedItem.ToString(); i.Password = PasswordUser.Password; return i; });

            foreach (User customer in users)
            {
                // Указать, что запись изменилась
                context.Entry(customer).State = EntityState.Modified;
            }

            context.SaveChanges();
        }
    }
}
