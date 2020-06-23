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
    /// Логика взаимодействия для BMRcalculator.xaml
    /// </summary>
    public partial class BMRcalculator : Window
    {
        public BMRcalculator()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Information information = new Information();
            information.Show();
            this.Close();
        }

        private void ButtonInf_Click(object sender, RoutedEventArgs e)
        {
            LavelActive lavelActive = new LavelActive();
            lavelActive.Owner = this;
            lavelActive.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double BMR = 0;

            if(TxtHeight.Text != "" && TxtOld.Text != "" && TxtWeight.Text != "")
            {
                if (ManBorder.Opacity == 1)
                {
                    BMR = 66 + (13.7 * Double.Parse(TxtWeight.Text)) + (5 * Double.Parse(TxtHeight.Text)) - (6.8 * Double.Parse(TxtOld.Text));
                    TableBMR(BMR);
                }
                else if (WomanBorder.Opacity == 1)
                {
                    BMR = 655 + (9.6 * Double.Parse(TxtWeight.Text)) + (1.8 * Double.Parse(TxtHeight.Text)) - (4.7 * Double.Parse(TxtOld.Text));
                    TableBMR(BMR);
                }
                else
                {
                    MessageBox.Show("Вибирете пол");
                    return;
                }
                EveryDayBMR.Content = BMR.ToString();
            }
            else
            {
                MessageBox.Show("Заполните данные");
            }
            
        }

        public void TableBMR(double BMR)
        {
            Lbl1_2.Content = String.Format("{0:f2}", BMR * 1.2);
            Lbl1_375.Content = String.Format("{0:f2}", BMR * 1.375);
            Lbl1_55.Content = String.Format("{0:f2}", BMR * 1.55);
            Lbl1_725.Content = String.Format("{0:f2}", BMR * 1.725);
            Lbl1_9.Content = String.Format("{0:f2}", BMR * 1.9);
        }

        private void ManBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WomanBorder.Opacity = 0.5;
            ManBorder.Opacity = 1;
        }

        private void WomanBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ManBorder.Opacity = 0.5;
            WomanBorder.Opacity = 1;
        }
    }
}
