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
    /// Логика взаимодействия для BMIcalculator.xaml
    /// </summary>
    public partial class BMIcalculator : Window
    {
        public BMIcalculator()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Information information = new Information();
            information.Show();
            this.Close();
        }

        private void CountParametr_Click(object sender, RoutedEventArgs e)
        {
            if(ManBorder.Opacity == 1 || WomenBorder.Opacity == 1)
            {
                if(HeightUser.Text != "" && WieghtUser.Text != "")
                {
                    double HeightUserInM = Double.Parse(HeightUser.Text) / 100;
                    double result = Double.Parse(WieghtUser.Text) / Math.Pow(HeightUserInM, 2);

                    ResultUser.Text = String.Format("{0:f1}", result);

                    // 35

                    // 18.5 - x
                    // 35 - 100

                    // 0 - 25, 25 - 50
                    // 25 - 18.5
                    // x - res

                    double procProgress = 0;


                    if (result <= 18.5)
                    {
                        procProgress = result * 25 / 18.5;
                        ProgressWieght.Foreground = Brushes.Orange;
                        TitleFoto.Text = "Недостаточный";
                        LoadFoto(@"bmiCalc\bmi-underweight-icon.png");
                    }
                    else if (result >= 18.5 && result <= 24.9)
                    {
                        procProgress = result * 50 / 24.9;
                        ProgressWieght.Foreground = Brushes.Green;
                        TitleFoto.Text = "Здоровый";
                        LoadFoto(@"bmiCalc\bmi-healthy-icon.png");
                    }
                    else if (result >= 25 && result <= 29.9)
                    {
                        procProgress = result * 75 / 29.9;
                        ProgressWieght.Foreground = Brushes.Orange;
                        TitleFoto.Text = "Избыточный";
                        LoadFoto(@"bmiCalc\bmi-overweight-icon.png");
                    }
                    else
                    {
                        procProgress = result * 100 / 35;
                        ProgressWieght.Foreground = Brushes.Red;
                        TitleFoto.Text = "Ожирение";
                        LoadFoto(@"bmiCalc\bmi-obese-icon.png");
                    }


                    ProgressWieght.Value = procProgress;
                }
                else
                {
                    MessageBox.Show("Заполните данные");
                }
            }
            else
            {
                MessageBox.Show("Выбирете пол");
            }
            
        }

        public void LoadFoto(string urlTxt)
        {
            BitmapImage src = new BitmapImage();
            src.BeginInit();
            src.UriSource = new Uri(urlTxt, UriKind.RelativeOrAbsolute);
            src.EndInit();
            ImageUser.Source = src;
        }

        private void WomenBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WomenBorder.Opacity = 1;
            ManBorder.Opacity = 0.5;
        }

        private void ManBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ManBorder.Opacity = 1;
            WomenBorder.Opacity = 0.5;
        }
    }
}
