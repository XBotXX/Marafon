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
    /// Логика взаимодействия для AddNewUser.xaml
    /// </summary>
    public partial class AddNewUser : Window
    {
        Entities context = new Entities();
        User user = new User();
        public AddNewUser()
        {
            InitializeComponent();
            Role.ItemsSource = context.User.Select(i => i.RoleId).Distinct().ToList();
        }

        private void ExitOnMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            UserManagement userManagement = new UserManagement();
            userManagement.Show();
            this.Close();
        }

        private void RegNewUser(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Password.Password.Equals(ReplayPassword.Password))
                {
                    context.User.Add(new User
                    {
                        Email = Email.Text.Trim(),
                        Password = Password.Password.Trim(),
                        FirstName = Name.Text.Trim(),
                        LastName = SurName.Text.Trim(),
                        RoleId = Role.SelectedItem.ToString()
                    });
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверно введены данные");
            }
            UserManagement userManagement = new UserManagement();
            userManagement.Show();
            this.Close();
            //try
            //{
            //    user.Email = Email.Text.Trim();
            //    user.Password = Password.Text.Trim();
            //    user.FirstName = Name.Text.Trim();
            //    user.LastName = SurName.Text.Trim();

            //    using (Entities db = new Entities())
            //    {
            //        db.User.Add(user);
            //        db.SaveChanges();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }
    }
}
