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
    /// Логика взаимодействия для RegOnMarathon.xaml
    /// </summary>
    public partial class RegOnMarathon : Window
    {
        public int ZnachRadiobutton = 0;
        public int ZnachCheckBox = 0;

        public string ZnachenieRaceKitOption = "";

        public string PerRaceKitOptionId = "";

        public int PerMarathon = 0;

        Entities context = new Entities();

        Dictionary<int, string> pairs = new Dictionary<int, string>();
        List<int> vs = new List<int>();

        Dictionary<string, decimal> counts = new Dictionary<string, decimal>();

        public RegOnMarathon()
        {
            InitializeComponent();

            PerMarathon = context.Marathon.OrderBy(j => j.MarathonId).OrderByDescending(j => j.MarathonId).Select(i => i.MarathonId).First();

            // var 1
            var g = context.Event.Where(i => i.MarathonId == PerMarathon).Select(j => new { j.EventTypeId, j.Cost }).ToList();
            foreach(var c in g)
            {
                counts.Add(c.EventTypeId, Convert.ToDecimal(c.Cost));
            }
            FM.Content += "($" + DictionaryShow("FM") + ")";
            HM.Content += "($" + DictionaryShow("HM") + ")";
            FR.Content += "($" + DictionaryShow("FR") + ")";

            // var 3
            //FM.Content += "($" + (Int32)counts.Where(i => i.Key == "FM").Select(i => i.Value).First() + ")";
            //HM.Content += "($" + (Int32)counts.Where(i => i.Key == "HM").Select(i => i.Value).First() + ")";
            //FR.Content += "($" + (Int32)counts.Where(i => i.Key == "FR").Select(i => i.Value).First() + ")";

            //var 2
            FM.Content += "($" + (Int32)context.Event.Where(i => i.MarathonId == PerMarathon && i.EventTypeId == "FM").Select(j => j.Cost).First() + ")"; //145
            HM.Content += "($" + (Int32)context.Event.Where(i => i.MarathonId == PerMarathon && i.EventTypeId == "HM").Select(j => j.Cost).First() + ")"; //75
            FR.Content += "($" + (Int32)context.Event.Where(i => i.MarathonId == PerMarathon && i.EventTypeId == "FR").Select(j => j.Cost).First() + ")"; //20

            var a = context.Charity.Select(i =>new { i.CharityName, i.CharityId }).ToList();
            foreach(var b in a)
            {
                pairs.Add(b.CharityId, b.CharityName);
            }
            CharityOrg.ItemsSource = pairs.Select(i=>i.Value).ToList();
        }

        public int DictionaryShow(string str)
        {
            return (Int32)counts.Where(i => i.Key == str).Select(i => i.Value).First();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MenuRunner runner = new MenuRunner();
            runner.Show();
            this.Close();
        }

        private void ExitOnMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void RegistrationOnMarathon(object sender, RoutedEventArgs e)
        {
            context.Registration.Add(new Registration
            {
                RunnerId = UserClass.UserId,
                RegistrationDateTime = DateTime.Now,
                RaceKitOptionId = ZnachenieRaceKitOption,
                RegistrationStatusId = 4,
                Cost = 0,
                CharityId = context.Charity.Where(i => i.CharityName == CharityOrg.Text).Select(i => i.CharityId).First(),
                SponsorshipTarget=Convert.ToDecimal(SummaAll)
            });
            context.SaveChanges();
            RegConfirmation confirmation = new RegConfirmation();
            confirmation.Show();
            this.Close();
        }

        private void ButtonInfSponsor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                vs = pairs.Keys.ToList();
                int a = vs[CharityOrg.SelectedIndex];
                //SponsorInformation sponsorInformation = new SponsorInformation();
                //sponsorInformation.Owner = this;
                //sponsorInformation.ShowDialog();
                InfAboutCharity infAboutCharity = new InfAboutCharity();
                infAboutCharity.Owner = this;
                infAboutCharity.Title.Text = CharityOrg.SelectedItem.ToString();
                infAboutCharity.Opisanie.Text = context.Charity.Where(i => i.CharityId == a).Select(i => i.CharityDescription).ToList()[0].ToString();
                infAboutCharity.ShowDialog();
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выбирите благотворительную организацию из списка");
            }
        }

        public int Slozenie(int a)
        {

            Summa.Content = "$";
            return 5;
        }

        private void A_Checked(object sender, RoutedEventArgs e) => Calculation("A", A);

        private void B_Checked(object sender, RoutedEventArgs e) => Calculation("B", B);

        private void C_Checked(object sender, RoutedEventArgs e) => Calculation("C", C);

        public void Calculation(string z, Control control)
        {
            if(control.GetType() == typeof(RadioButton))
            {
                ZnachRadiobutton = (Int32)context.RaceKitOption.Where(i => i.RaceKitOptionId == z).Select(i => i.Cost).First();
                PerRaceKitOptionId = z;
                SumLabel();
                ZnachenieRaceKitOption = z;
            }
            else
            {

            }
        }

        public void SumLabel() => Summa.Content = "$" + Convert.ToString(ZnachCheckBox + ZnachRadiobutton);

        private void FM_Checked(object sender, RoutedEventArgs e)
        {
            ZnachCheckBox += DictionaryShow("FM");
            SumLabel();
        }

        private void FM_Unchecked(object sender, RoutedEventArgs e)
        {
            ZnachCheckBox -= DictionaryShow("FM");
            SumLabel();
        }

        private void HM_Checked(object sender, RoutedEventArgs e)
        {
            ZnachCheckBox += DictionaryShow("HM");
            SumLabel();
        }

        private void HM_Unchecked(object sender, RoutedEventArgs e)
        {
            ZnachCheckBox -= DictionaryShow("HM");
            SumLabel();
        }

        private void FR_Checked(object sender, RoutedEventArgs e)
        {
            ZnachCheckBox += DictionaryShow("FR");
            SumLabel();
        }

        private void FR_Unchecked(object sender, RoutedEventArgs e)
        {
            ZnachCheckBox += DictionaryShow("FR");
            SumLabel();
        }
    }
}
