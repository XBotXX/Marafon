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
    /// Логика взаимодействия для LastResultRunner.xaml
    /// </summary>
    public partial class LastResultRunner : Window
    {

        List<Runn> runns = new List<Runn>();

        List<string> categor = new List<string>()
        {
            "18-...", "18-29", "30-39", "40-55", "56-70", "70-..."
        };

        Entities context = new Entities();

        public int AllRunnerCount = 0;
        public int RegRunnerCount = 0;
        public int SredTimeRunner = 0;

        public LastResultRunner()
        {
            InitializeComponent();

             var a = from mar in context.Marathon
                     join country in context.Country on mar.CountryCode equals country.CountryCode
                     select new
                     {
                        YearAndCountryCode = mar.YearHeld +"-"+ country.CountryName
                     };

            NameMarathon.ItemsSource = a.Select(i=>i.YearAndCountryCode).ToList();

            var b = context.EventType.Select(i => i.EventTypeName).ToList();

            Distance.ItemsSource = b;

            var c = context.Gender.Select(i => i.Gender1).ToList();
            c.Add("Any");

            Gender.ItemsSource = c;

            CategoryCombobox.ItemsSource = categor.ToList();


            var userRun = context.User.Where(i => i.RoleId == "R").ToList();

            int countRunner = userRun.Count();

            var d = from user in userRun
                    join run in context.Runner on user.Email equals run.Email
                    join reg in context.Registration on run.RunnerId equals reg.RunnerId
                    join regevent in context.RegistrationEvent on reg.RegistrationId equals regevent.RegistrationId
                    join eventer in context.Event on regevent.EventId equals eventer.EventId
                    join eventertype in context.EventType on eventer.EventTypeId equals eventertype.EventTypeId
                    join maraf in context.Marathon on eventer.MarathonId equals maraf.MarathonId
                    join countryCode in context.Country on maraf.CountryCode equals countryCode.CountryCode
                    select new
                    {
                        Mesto=0,
                        RaceTime=regevent.RaceTime,
                        FirstName=user.FirstName,
                        CountryCode=run.CountryCode,

                        marafonName=maraf.YearHeld + "-" + countryCode.CountryName,
                        distanceMar=eventertype.EventTypeName,
                        genderMar=run.Gender,
                        BirthMar=run.DateOfBirth

                    };


            var result = d.OrderByDescending(i => i.RaceTime);

            int h = 0;

            foreach(var s in result)
            {
                h++;

                int race = 0;

                if (s.RaceTime == null)
                {
                    race = -1;
                }
                else
                {
                    race = s.RaceTime.Value;
                }

                runns.Add(new Runn { Mesto = h, 
                                     RaceTime = race, 
                                     FirstName = s.FirstName, 
                                     CountryCode = s.CountryCode,
                                     marafonName = s.marafonName,
                                     distanceMar=s.distanceMar,
                                     genderMar = s.genderMar,
                                     BirthMar = s.BirthMar.Value
                });
            }


            dgRunner.ItemsSource = runns.ToList();

            int iteratorRunner = 0;

            int summRunner = 0;

            foreach(var s in d.Select(i => i.RaceTime))
            {
                if (s != null)
                {
                    iteratorRunner++;
                    summRunner += Convert.ToInt32(s);
                }
            }

            summRunner /= iteratorRunner;

            AllRunner.Content = countRunner.ToString();
            FinishRunner.Content = iteratorRunner.ToString();
            SredTime.Content = summRunner.ToString();

        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void SeachButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime now = new DateTime(2014, 7, 20, 0, 0, 0);
            DateTime date_start=new DateTime(2015, 7, 20, 0, 0, 0);
            DateTime date_end = new DateTime(3999, 1, 1, 0, 0, 0);
            switch (CategoryCombobox.Text)
            {
                case "18-...":
                    date_start = now.AddYears(-18);
                    break;
                case "18-29":
                    date_start = now.AddYears(-18);
                    date_end = now.AddYears(-29);
                    break;
                case "30-39":
                    date_start = now.AddYears(-30);
                    date_end = now.AddYears(-39);
                    break;
                case "40-55":
                    date_start = now.AddYears(-40);
                    date_end = now.AddYears(-55);
                    break;
                case "56-70":
                    date_start = now.AddYears(-56);
                    date_end = now.AddYears(-70);
                    break;
                case "70-...":
                    date_start = now.AddYears(-70);
                    break;
            }

            if(Gender.Text == "Any")
            {
                dgRunner.ItemsSource = countData(runns.Where(i => i.marafonName == NameMarathon.Text &&
                                               i.distanceMar == Distance.Text &&
                                               i.BirthMar <= date_start &&
                                               i.BirthMar >= date_end).ToList());
            }
            else
            {
                dgRunner.ItemsSource = countData(runns.Where(i => i.marafonName == NameMarathon.Text &&
                                               i.distanceMar == Distance.Text &&
                                               i.genderMar == Gender.Text &&
                                               i.BirthMar <= date_start &&
                                               i.BirthMar >= date_end).ToList());
            }

            List<Runn> countData(List<Runn> res)
            {
                AllRunnerCount = res.Count();

                RegRunnerCount = 0;

                SredTimeRunner = 0;

                foreach (var s in res.Select(i => i.RaceTime))
                {
                    if (s != -1)
                    {
                        RegRunnerCount++;
                        SredTimeRunner += Convert.ToInt32(s);
                    }
                }

                if(RegRunnerCount != 0)
                {
                    SredTimeRunner /= RegRunnerCount;
                }

                AllRunner.Content = AllRunnerCount.ToString();
                FinishRunner.Content = RegRunnerCount.ToString();
                SredTime.Content = SredTimeRunner.ToString();

                return res;
            }
        }

        
    }

    class Runn
    {
        public int Mesto { get; set; }
        public int RaceTime { get; set; }
        public string FirstName { get; set; }
        public string CountryCode { get; set; }
        public string marafonName { get; set; }
        public string distanceMar { get; set; }
        public string genderMar { get; set; }
        public DateTime BirthMar { get; set; }
    }
}
