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
using UIControls;

namespace Clementine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Yr1_Click(object sender, RoutedEventArgs e)
        {
            if (Semester1.IsChecked == true)
            {
                y1s1grid.Visibility = Visibility.Visible;
                y1s2grid.Visibility = Visibility.Collapsed;
                y2s1grid.Visibility = Visibility.Collapsed;
                y2s2grid.Visibility = Visibility.Collapsed;
                y3s1grid.Visibility = Visibility.Collapsed;
                y3s2grid.Visibility = Visibility.Collapsed;
                y4s1grid.Visibility = Visibility.Collapsed;
                y4s2grid.Visibility = Visibility.Collapsed;
            }

            else if (Semester2.IsChecked == true)
            {
                y1s1grid.Visibility = Visibility.Collapsed;
                y1s2grid.Visibility = Visibility.Visible;
                y2s1grid.Visibility = Visibility.Collapsed;
                y2s2grid.Visibility = Visibility.Collapsed;
                y3s1grid.Visibility = Visibility.Collapsed;
                y3s2grid.Visibility = Visibility.Collapsed;
                y4s1grid.Visibility = Visibility.Collapsed;
                y4s2grid.Visibility = Visibility.Collapsed;
            }
        }

        private void Yr2_Click(object sender, RoutedEventArgs e)
        {
            if (Semester1.IsChecked == true)
            {
                y1s1grid.Visibility = Visibility.Collapsed;
                y1s2grid.Visibility = Visibility.Collapsed;
                y2s1grid.Visibility = Visibility.Visible;
                y2s2grid.Visibility = Visibility.Collapsed;
                y3s1grid.Visibility = Visibility.Collapsed;
                y3s2grid.Visibility = Visibility.Collapsed;
                y4s1grid.Visibility = Visibility.Collapsed;
                y4s2grid.Visibility = Visibility.Collapsed;
            }

            else if (Semester2.IsChecked == true)
            {
                y1s1grid.Visibility = Visibility.Collapsed;
                y1s2grid.Visibility = Visibility.Collapsed;
                y2s1grid.Visibility = Visibility.Collapsed;
                y2s2grid.Visibility = Visibility.Visible;
                y3s1grid.Visibility = Visibility.Collapsed;
                y3s2grid.Visibility = Visibility.Collapsed;
                y4s1grid.Visibility = Visibility.Collapsed;
                y4s2grid.Visibility = Visibility.Collapsed;
            }
        }

        private void Yr3_Click(object sender, RoutedEventArgs e)
        {
            if (Semester1.IsChecked == true)
            {
                y1s1grid.Visibility = Visibility.Collapsed;
                y1s2grid.Visibility = Visibility.Collapsed;
                y2s1grid.Visibility = Visibility.Collapsed;
                y2s2grid.Visibility = Visibility.Collapsed;
                y3s1grid.Visibility = Visibility.Visible;
                y3s2grid.Visibility = Visibility.Collapsed;
                y4s1grid.Visibility = Visibility.Collapsed;
                y4s2grid.Visibility = Visibility.Collapsed;
            }

            else if (Semester2.IsChecked == true)
            {
                y1s1grid.Visibility = Visibility.Collapsed;
                y1s2grid.Visibility = Visibility.Collapsed;
                y2s1grid.Visibility = Visibility.Collapsed;
                y2s2grid.Visibility = Visibility.Collapsed;
                y3s1grid.Visibility = Visibility.Collapsed;
                y3s2grid.Visibility = Visibility.Visible;
                y4s1grid.Visibility = Visibility.Collapsed;
                y4s2grid.Visibility = Visibility.Collapsed;
            }
        }

        private void Yr4_Click(object sender, RoutedEventArgs e)
        {
            if (Semester1.IsChecked == true)
            {
                y1s1grid.Visibility = Visibility.Collapsed;
                y1s2grid.Visibility = Visibility.Collapsed;
                y2s1grid.Visibility = Visibility.Collapsed;
                y2s2grid.Visibility = Visibility.Collapsed;
                y3s1grid.Visibility = Visibility.Collapsed;
                y3s2grid.Visibility = Visibility.Collapsed;
                y4s1grid.Visibility = Visibility.Visible;
                y4s2grid.Visibility = Visibility.Collapsed;
            }

            else if (Semester2.IsChecked == true)
            {
                y1s1grid.Visibility = Visibility.Collapsed;
                y1s2grid.Visibility = Visibility.Collapsed;
                y2s1grid.Visibility = Visibility.Collapsed;
                y2s2grid.Visibility = Visibility.Collapsed;
                y3s1grid.Visibility = Visibility.Collapsed;
                y3s2grid.Visibility = Visibility.Collapsed;
                y4s1grid.Visibility = Visibility.Collapsed;
                y4s2grid.Visibility = Visibility.Visible;
            }

        }

        private void addtosem1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addtosem2_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
