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
    /// Логика взаимодействия для InteractiveMap.xaml
    /// </summary>
    public partial class InteractiveMap : Window
    {
        Entities context = new Entities();

        List<Chek> cheks = new List<Chek>()
        {
            new Chek{ image= @"icon map\map-icon-drinks.png", str="Drinks" },
            new Chek{ image= @"icon map\map-icon-energy-bars.png", str="Energy Bars" },
            new Chek{ image= @"icon map\map-icon-toilets.png", str="Toilets" },
            new Chek{ image= @"icon map\map-icon-information.png", str="Information" },
            new Chek{ image= @"icon map\map-icon-medical.png", str="Medical" }
        };

        Dictionary<string,string> land = new Dictionary<string,string>() 
        {
            { "1","Avenida Rudge" },
            { "2", "Theatro Municipal" },
            { "3","Parque do Ibirapuera" },
            { "4","Jardim Luzitania" },
            { "5","Iguatemi" },
            { "6", "Rua Lisboa" },
            { "7", "Cemitério da Consolação" },
            { "8", "Cemitério da Consolação" } 
        };

        public InteractiveMap()
        {
            InitializeComponent();
            list.Items.Clear();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            AboutMarathonSkills2016 aboutMarathonSkills2016 = new AboutMarathonSkills2016();
            aboutMarathonSkills2016.Show();
            this.Close();
        }

        private void GotoCheckpoint1(object sender, RoutedEventArgs e)
        {
            ChekPointBorder.Visibility = Visibility.Visible;
            landN.Visibility = Visibility.Visible;
            ServiceProv.Visibility = Visibility.Visible;
            list.Visibility = Visibility.Visible;
            string[] str = ((Button)sender).Name.Split('_');
            ChekName.Content = str[0]+" "+str[1];
            Landmark.Text = land.Where(i=>i.Key==str[1]).Select(i=>i.Value).ToList().First();
            switch (str[1])
            {
                case "1":
                    list.ItemsSource = cheks.Where(i => i.str == "Drinks" || i.str == "Energy Bars").ToList();
                    break;
                case "2":
                    list.ItemsSource = cheks.Where(i => i.str == "Drinks" || i.str == "Energy Bars" || i.str == "Toilets" || i.str == "Toilets" || i.str== "Information" || i.str== "Medical").ToList();
                    break;
                case "3":
                    list.ItemsSource = cheks.Where(i => i.str == "Drinks" || i.str == "Energy Bars" || i.str == "Toilets" || i.str == "Toilets").ToList();
                    break;
                case "4":
                    list.ItemsSource = cheks.Where(i => i.str == "Drinks" || i.str == "Energy Bars" || i.str == "Toilets" || i.str == "Toilets" || i.str == "Medical").ToList();
                    break;
                case "5":
                    list.ItemsSource = cheks.Where(i => i.str == "Drinks" || i.str == "Energy Bars" || i.str == "Toilets" || i.str == "Toilets" || i.str == "Information").ToList();
                    break;
                case "6":
                    list.ItemsSource = cheks.Where(i => i.str == "Drinks" || i.str == "Energy Bars" || i.str == "Toilets" || i.str == "Toilets").ToList();
                    break;
                case "7":
                    list.ItemsSource = cheks.Where(i => i.str == "Drinks" || i.str == "Energy Bars" || i.str == "Toilets" || i.str == "Toilets" || i.str == "Information" || i.str == "Medical").ToList();
                    break;
                case "8":
                    list.ItemsSource = cheks.Where(i => i.str == "Drinks" || i.str == "Energy Bars" || i.str == "Toilets" || i.str == "Toilets" || i.str == "Information" || i.str == "Medical").ToList();
                    break;
            }
        }

        private void CloseList_Click(object sender, RoutedEventArgs e)
        {
            ChekPointBorder.Visibility = Visibility.Hidden;
        }

        private void GotoStart(object sender, RoutedEventArgs e)
        {
            ChekPointBorder.Visibility = Visibility.Visible;
            string str = ((Button)sender).Name;
            ChekName.Content = "Race Start";
            landN.Visibility = Visibility.Hidden;
            ServiceProv.Visibility = Visibility.Hidden;
            list.Visibility = Visibility.Hidden;
            Landmark.Text = context.Event.Where(i => i.MarathonId == 5 && i.EventTypeId == str).Select(i => i.EventName).First();
        }
    }
    public class Chek
    {
        public string image { get; set; }
        public string str { get; set; }
    }
}
