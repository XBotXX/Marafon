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
    /// Логика взаимодействия для HowLongMarathon.xaml
    /// </summary>
    public partial class HowLongMarathon : Window
    {
        //public string NameSpeedObject;
        //public float SpeedSpeedObject, TimeSpeedObject;
        public HowLongMarathon()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Information information = new Information();
            information.Show();
            this.Close();
        }

        private void GotoInteractiveMap(object sender, RoutedEventArgs e)
        {
            InteractiveMap interactiveMap = new InteractiveMap();
            interactiveMap.Show();
            this.Close();
        }

        private void GotoSlug(object sender, RoutedEventArgs e)
        {
            ShowSpeedImage("Slug", 0.01f, @"FotoForMarathon\slug.jpg");
        }

        private void GotoCar(object sender, RoutedEventArgs e)
        {
            ShowSpeedImage("F1 Car", 345f, @"FotoForMarathon\f1-car.jpg");
        }

        private void GotoHorse(object sender, RoutedEventArgs e)
        {
            ShowSpeedImage("Horse", 15f, @"FotoForMarathon\horse.png");
        }

        private void GotoSloth(object sender, RoutedEventArgs e)
        {
            ShowSpeedImage("Horse", 0.12f, @"FotoForMarathon\sloth.jpg");
        }

        private void GotoCapybara(object sender, RoutedEventArgs e)
        {
            ShowSpeedImage("Capybara", 35f, @"FotoForMarathon\capybara.jpg");
        }

        private void GotoJaguar(object sender, RoutedEventArgs e)
        {
            ShowSpeedImage("Jaguar", 80f, @"FotoForMarathon\jaguar.jpg");
        }

        private void GotoWorm(object sender, RoutedEventArgs e)
        {
            ShowSpeedImage("Worm", 0.03f, @"FotoForMarathon\worm.jpg");
        }

        public void ShowSpeedImage(string NameSpeedObject, float SpeedSpeedObject, string URLName)
        {
            float TimeSpeedObject = 42 / (SpeedSpeedObject / 60);
            LabelImage.Text = "An " + NameSpeedObject + " travaels at " + SpeedSpeedObject + " km/h so would complete the marathon in " + String.Format("{0:0.00}", TimeSpeedObject) + " minutes";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(URLName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Foto.Stretch = Stretch.Fill;
            Foto.Source = bitmap;
            NameObjectTitle.Content = NameSpeedObject;
        }

        private void GotoBus(object sender, RoutedEventArgs e)
        {
            ShowLongImage("Bus", 10f, @"FotoForMarathon\bus.jpg");
        }

        public void ShowLongImage(string NameSpeedObject, float SpeedSpeedObject, string URLName)
        {
            float TimeSpeedObject = 42000 / (SpeedSpeedObject);
            LabelImage.Text = "A " + NameSpeedObject + " is " + SpeedSpeedObject + "m in lenght so " + String.Format("{0:0.00}", TimeSpeedObject) + " world fit into the marathon lenght";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(URLName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Foto.Stretch = Stretch.Fill;
            Foto.Source = bitmap;
            NameObjectTitle.Content = NameSpeedObject;
        }

        private void GotoPairofHavaianas(object sender, RoutedEventArgs e)
        {
            ShowLongImage("Pair of Havaianas", 0.245f, @"FotoForMarathon\pair-of-havaianas.jpg");
        }

        private void GotoAirbusA380(object sender, RoutedEventArgs e)
        {
            ShowLongImage("Airbus A380", 73f, @"FotoForMarathon\airbus-a380.jpg");
        }

        private void GotoFootballField(object sender, RoutedEventArgs e)
        {
            ShowLongImage("Football Field", 105f, @"FotoForMarathon\football-field.jpg");
        }

        private void GotoRonaldinho(object sender, RoutedEventArgs e)
        {
            ShowLongImage("Ronaldinho", 1.81f, @"FotoForMarathon\ronaldinho.jpg");
        }
    }
}
