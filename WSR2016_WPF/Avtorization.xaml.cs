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
    /// Логика взаимодействия для Avtorization.xaml
    /// </summary>
    public partial class Avtorization : Window
    {
        Entities context = new Entities();
        public Avtorization()
        {
            InitializeComponent();
            Login.Focus();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = context.User.Where(i => i.Email == Login.Text && i.Password == PasswordTxt.Password).ToList();
            if (a.Any())
            {
                if (a.Where(i=>i.RoleId=="C").Any())
                {
                    CoordinatorMenu coordinatorMenu = new CoordinatorMenu();
                    coordinatorMenu.Show();
                    this.Close();
                }
                else if (a.Where(i => i.RoleId == "R").Any())
                {
                    var b = context.Runner.Where(i => i.Email == Login.Text).Select(i => i.RunnerId).First();
                    var c = context.Registration.Where(i => i.RunnerId == b).Select(i => i.RunnerId).First();
                    UserClass.UserId = b;
                    UserClass.RegId = c;

                    MenuRunner menuRunner = new MenuRunner();
                    menuRunner.Show();
                    this.Close();
                }
                else if (a.Where(i => i.RoleId == "A").Any())
                {
                    MenuAdministrator menuAdministrator = new MenuAdministrator();
                    menuAdministrator.Show();
                    this.Close();
                }
            }
        }
    }
}
