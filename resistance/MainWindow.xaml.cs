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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace resistance
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Posl_Click(object sender, RoutedEventArgs e)
        {
            double R = 0;
            double R1, R2, R3;
            string S = "";
            if(chR1.IsChecked==true)
            {
                R1 = double.Parse(varR1.Text);
                R += R1;
                S += "R1=" + R1 + " ";
            }
            if (chR2.IsChecked == true)
            {
                R2 = double.Parse(varR2.Text);
                R += R2;
                S += "R2=" + R2 + " ";
            }
            if (chR3.IsChecked == true)
            {
                R3 = double.Parse(varR3.Text);
                R += R3;
                S += "R3=" + R3 + " ";
            }
            Result.Text = S+"R="+R;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            varR1.IsEnabled = false;
            varR2.IsEnabled = false;
            varR3.IsEnabled = false;
        }

        private void chR1_Click(object sender, RoutedEventArgs e)
        {
            if (chR1.IsChecked == true) varR1.IsEnabled = true;
            else varR1.IsEnabled = false;
            varR1.Clear();
        }

        private void chR2_Click(object sender, RoutedEventArgs e)
        {
            if (chR2.IsChecked == true) varR2.IsEnabled = true;
            else varR2.IsEnabled = false;
            varR2.Clear();
        }

        private void chR3_Click(object sender, RoutedEventArgs e)
        {
            if (chR3.IsChecked == true) varR3.IsEnabled = true;
            else varR3.IsEnabled = false;
            varR3.Clear();
        }

        private void Paral_Click_1(object sender, RoutedEventArgs e)
        {
            double R = 0;
            double R1, R2, R3;
            string S = "";
            if (chR1.IsChecked == true)
            {
                R1 = double.Parse(varR1.Text);
                R +=1/R1;
                S += "R1=" + R1 + " ";
            }
            if (chR2.IsChecked == true)
            {
                R2 = double.Parse(varR2.Text);
                R += 1/R2;
                S += "R2=" + R2 + " ";
            }
            if (chR3.IsChecked == true)
            {
                R3 = double.Parse(varR3.Text);
                R += 1/R3;
                S += "R3=" + R3 + " ";
            }
            R = 1 / R;
            Result.Text = S + "R=" + R;
        }
    }
}
