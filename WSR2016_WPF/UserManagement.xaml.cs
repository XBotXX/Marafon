using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для UserManagement.xaml
    /// </summary>
    public partial class UserManagement : Window
    {
        Entities context = new Entities();
        public UserManagement()
        {
            InitializeComponent();
            //List<Users> UsersList = new List<Users>();
            //UsersList.Add(new Users { Name = "First", Surname = "User1", Email = "first@email.com", Role = "Coordinator", Edit = new Button()});
            dgUsers.ItemsSource = context.User.ToList();
            CountUser.Content = context.User.Count();
            RoleFitr.ItemsSource = context.User.Select(i => i.RoleId).Distinct().ToList();
            var a = typeof(User).GetProperties().Select(t => t.Name).ToList();
            a.Remove("Password");
            SortRunner.ItemsSource = a;

            

            
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MenuAdministrator menuAdministrator = new MenuAdministrator();
            menuAdministrator.Show();
            this.Close();
        }

        private void ExitOnMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void GotoEditUser_Click(object sender, RoutedEventArgs e)
        {
            string a = dgUsers.SelectedIndex.ToString(); // заготовка для исправления колхоза
            var b = (User)dgUsers.SelectedItems[0];// выбираем одну строку поэтому и [0]
            EditUser editUser = new EditUser();
            editUser.EmailText.Text = b.Email.ToString();
            editUser.Show();
            this.Close();
        }

        private void GotoAddNewUser(object sender, RoutedEventArgs e)
        {
            AddNewUser newUser = new AddNewUser();
            newUser.Show();
            this.Close();
        }

        private void ObnovGrid_Click(object sender, RoutedEventArgs e)
        {
            //string select = SortRunner.SelectedItem.ToString();
            //dgUsers.ItemsSource = context.User.SqlQuery($"select * from [User] order by {select}").ToList();
            //dgUsers.ItemsSource = context.User.Where(i => i.LastName.Equals(SearhText.Text) || i.FirstName.Equals(SearhText.Text) || i.RoleId.Equals(SearhText.Text) || i.Email.Equals(SearhText.Text)).ToList();
            //dgUsers.ItemsSource = context.User.Where(i => i.RoleId == RoleFitr.SelectedItem.ToString()).ToList();

            string select = SortRunner.SelectedItem.ToString();
            dgUsers.ItemsSource = context.User.SqlQuery($"select * from [User] order by {select}").ToList().AsQueryable().Intersect(context.User.Where(i => i.LastName.Equals(SearhText.Text) || i.FirstName.Equals(SearhText.Text) || i.RoleId.Equals(SearhText.Text) || i.Email.Equals(SearhText.Text)).ToList()).AsQueryable().Intersect(context.User.Where(i => i.RoleId == RoleFitr.SelectedItem.ToString()).ToList());

            CountUser.Content = dgUsers.Items.Count;

            //foreach (User row in dgUsers.Items)
            //{
            //    MessageBox.Show(row.FirstName);
            //}



            //DataGrid DataGridCamiao = sender as DataGrid;
            //if (dgUsers.SelectedItem != null)
            //{
            //    var item = dgUsers.SelectedItem as User;
            //    if (item != null)
            //        MessageBox.Show(item.FirstName);
            //}



        }
        //public class Users
        //{
        //    public string Name { get; set; }
        //    public string Surname { get; set; }
        //    public string Email { get; set; }
        //    public string Role { get; set; }
        //    public Button Edit { get; set; }
        //}
    }
}
