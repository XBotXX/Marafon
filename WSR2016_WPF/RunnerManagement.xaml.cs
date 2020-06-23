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
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace WSR2016_WPF
{
    /// <summary>
    /// Логика взаимодействия для RunnerManagement.xaml
    /// </summary>
    public partial class RunnerManagement : System.Windows.Window
    {
        Entities context = new Entities();

        List<RunnerControl> runners = new List<RunnerControl>();
        List<RunnerControl> runnersNow = new List<RunnerControl>();

        public RunnerManagement()
        {
            InitializeComponent();

            RegStatusCombo.ItemsSource = context.RegistrationStatus.Select(i => i.RegistrationStatus1).ToList();
            DistanceCombo.ItemsSource = context.EventType.Select(i => i.EventTypeName).ToList();
            var title = typeof(RunnerControl).GetProperties().Select(t => t.Name).ToList();

            title.RemoveAt(title.Count() - 1);
            title.RemoveAt(title.Count() - 1);
            title.RemoveAt(title.Count() - 1);
            title.RemoveAt(title.Count() - 1);
            title.RemoveAt(title.Count() - 1);
            title.RemoveAt(title.Count() - 1);
            title.RemoveAt(title.Count() - 1);
            title.RemoveAt(title.Count() - 1);
            title.RemoveAt(title.Count() - 1);

            OrderByCombo.ItemsSource = title;

            var userRun = context.User.Where(i => i.RoleId == "R").ToList();

            var d = from user in userRun
                    join run in context.Runner on user.Email equals run.Email
                    join reg in context.Registration on run.RunnerId equals reg.RunnerId
                    join regstatus in context.RegistrationStatus on reg.RegistrationStatusId equals regstatus.RegistrationStatusId
                    join charityMar in context.Charity on reg.CharityId equals charityMar.CharityId

                    join regevent in context.RegistrationEvent on reg.RegistrationId equals regevent.RegistrationId
                    join eventer in context.Event on regevent.EventId equals eventer.EventId
                    join eventertype in context.EventType on eventer.EventTypeId equals eventertype.EventTypeId
                    select new
                    {
                        Pas = user.Password,
                        Name = user.FirstName,
                        Surname = user.LastName,
                        Email = run.Email,
                        Status = regstatus.RegistrationStatus1,

                        EventTypeMar = eventertype.EventTypeName,

                        GenderCSV = run.Gender,
                        CountryCSV = run.CountryCode,
                        DateOfBith = run.DateOfBirth,
                        NuborCSV = reg.RaceKitOptionId,

                        SponsorTarget = reg.SponsorshipTarget,
                        CharityName = charityMar.CharityName
                    };

            var result = d.GroupBy(i => i.Email).Select(group => group.First()).ToList();

            foreach (var s in result)
            {
                runners.Add(new RunnerControl { 
                    Name = s.Name, 
                    Surname = s.Surname, 
                    Email = s.Email, 
                    Status = s.Status, 
                    Edit = new System.Windows.Controls.Button(),
                    EventTypeMar = s.EventTypeMar,
                    GenderCSV = s.GenderCSV,
                    CountryCSV = s.CountryCSV,
                    DateOfBith = s.DateOfBith.Value,
                    NuborCSV = s.NuborCSV,
                    CharityName = s.CharityName,
                    SponsorTarget = s.SponsorTarget,
                    Pas = s.Pas
                });
            }

            CountRunner.Content = runners.ToList().Count();

            dgUsers.ItemsSource = runners;

        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            CoordinatorMenu coordinatorMenu = new CoordinatorMenu();
            coordinatorMenu.Show();
            this.Close();
        }

        private void ExitOnMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            string a = dgUsers.SelectedIndex.ToString(); // заготовка для исправления колхоза
            var b = (RunnerControl)dgUsers.SelectedItems[0];// выбираем одну строку поэтому и [0]
            ActiveUser.runnerControls = runners.Where(i => i.Email == b.Email).ToList();
            RunnerManage runnerManage = new RunnerManage();
            UserClass.UserId = context.Runner.Where(i => i.Email == b.Email).Select(i => i.RunnerId).First();
            UserClass.RegId = context.Registration.Where(i => i.RunnerId == UserClass.UserId).Select(i => i.RegistrationId).First();

            runnerManage.NameLbl.Content = runners.Where(i => i.Email == b.Email).Select(i => i.Name).First();
            runnerManage.SurLbl.Content = runners.Where(i => i.Email == b.Email).Select(i => i.Surname).First();
            runnerManage.MaleLbl.Content = runners.Where(i => i.Email == b.Email).Select(i => i.GenderCSV).First();
            runnerManage.DateOfBithLbl.Content = runners.Where(i => i.Email == b.Email).Select(i => i.DateOfBith).First();
            runnerManage.CountryLbl.Content = runners.Where(i => i.Email == b.Email).Select(i => i.CountryCSV).First();
            runnerManage.CharityLbl.Content = runners.Where(i => i.Email == b.Email).Select(i => i.CharityName).First();
            runnerManage.CountCharityMoneyLbl.Content = runners.Where(i => i.Email == b.Email).Select(i => i.SponsorTarget).First();
            runnerManage.NaborLbl.Content = runners.Where(i => i.Email == b.Email).Select(i => i.NuborCSV).First();
            runnerManage.DistanceLbl.Content = runners.Where(i => i.Email == b.Email).Select(i => i.EventTypeMar).First();

            switch(runners.Where(i => i.Email == b.Email).Select(i => i.Status).First())
            {
                case "Registered":
                    runnerManage.A.Background = Brushes.Green;
                    break;
                case "Payment Confirmed":
                    runnerManage.A.Background = Brushes.Green;
                    runnerManage.B.Background = Brushes.Green;
                    break;
                case "Race Kit Sent":
                    runnerManage.A.Background = Brushes.Green;
                    runnerManage.B.Background = Brushes.Green;
                    runnerManage.C.Background = Brushes.Green;
                    break;
                case "Race Attended":
                    runnerManage.A.Background = Brushes.Green;
                    runnerManage.B.Background = Brushes.Green;
                    runnerManage.C.Background = Brushes.Green;
                    runnerManage.D.Background = Brushes.Green;
                    break;
            }

            runnerManage.EmailLbl.Content = b.Email.ToString();
            runnerManage.Show();
            this.Close();
        }

        private void Upload_Click(object sender, RoutedEventArgs e)
        {
            runnersNow = runners.Where(i => i.Status == RegStatusCombo.Text &&
                                      i.EventTypeMar == DistanceCombo.Text).ToList();

            dgUsers.ItemsSource = from tab in runnersNow orderby OrderByCombo.Text select tab;

            CountRunner.Content = runnersNow.ToList().Count();
        }

        private void CVSWriteFile_Click(object sender, RoutedEventArgs e)
        {
            WriteData();
        }

        public void WriteData()
        {


            Excel excel = new Excel(@"C:\Users\User\Desktop\CSV.xlsx", 1);

            excel.WriteToCell(1, 0, runnersNow);
            excel.Save();
            excel.Close();
        }

        private void EmailList_Click(object sender, RoutedEventArgs e)
        {
            EmailListRunner emailList = new EmailListRunner(runnersNow.ToList());
            emailList.Owner = this;
            emailList.ShowDialog();
        }
    }

    //public class RunnerControl
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //    public string Email { get; set; }
    //    public string Status { get; set; }
    //    public System.Windows.Controls.Button Edit { get; set; }
    //    public string EventTypeMar { get; set; }

    //    public string GenderCSV { get; set; }
    //    public string CountryCSV { get; set; }
    //    public DateTime DateOfBith { get; set; }
    //    public string NuborCSV { get; set; }
    //    public decimal SponsorTarget { get; set; }
    //    public string CharityName { get; set; }
    //}
}
