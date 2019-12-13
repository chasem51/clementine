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

        int y11 = 0;
        int y12 = 0;
        int y21 = 0;
        int y22 = 0;
        int y31 = 0;
        int y32 = 0;
        int y41 = 0;
        int y42 = 0;
        private void addtosem1_Click(object sender, RoutedEventArgs e)
        {
            if(y1s1grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y1s1grid.Children.Add(tb);
                Grid.SetRow(tb, y11);
                y11++;
                tb.Inlines.Add(coursestx.Text);
            }
            else if (y1s2grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y1s2grid.Children.Add(tb);
                Grid.SetRow(tb, y12);
                y12++;
                tb.Inlines.Add(coursestx.Text);
            }
            else if (y2s1grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y2s1grid.Children.Add(tb);
                Grid.SetRow(tb, y21);
                y21++;
                tb.Inlines.Add(coursestx.Text);
            }
            else if (y2s2grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y2s2grid.Children.Add(tb);
                Grid.SetRow(tb, y22);
                y22++;
                tb.Inlines.Add(coursestx.Text);
            }
            else if (y3s1grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y3s1grid.Children.Add(tb);
                Grid.SetRow(tb, y31);
                y31++;
                tb.Inlines.Add(coursestx.Text);
            }
            else if (y3s2grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y3s2grid.Children.Add(tb);
                Grid.SetRow(tb, y32);
                y32++;
                tb.Inlines.Add(coursestx.Text);
            }
            else if (y4s1grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y4s1grid.Children.Add(tb);
                Grid.SetRow(tb, y41);
                y41++;
                tb.Inlines.Add(coursestx.Text);
            }
            else if (y4s2grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y4s2grid.Children.Add(tb);
                Grid.SetRow(tb, y42);
                y42++;
                tb.Inlines.Add(coursestx.Text);
            }
        }

        private void addtosem2_Click(object sender, RoutedEventArgs e)
        {
            if (y1s1grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y1s1grid.Children.Add(tb);
                Grid.SetRow(tb, y11);
                y11++;
                tb.Inlines.Add(hubtx.Text);
            }
            else if (y1s2grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y1s2grid.Children.Add(tb);
                Grid.SetRow(tb, y12);
                y12++;
                tb.Inlines.Add(hubtx.Text);
            }
            else if (y2s1grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y2s1grid.Children.Add(tb);
                Grid.SetRow(tb, y21);
                y21++;
                tb.Inlines.Add(hubtx.Text);
            }
            else if (y2s2grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y2s2grid.Children.Add(tb);
                Grid.SetRow(tb, y22);
                y22++;
                tb.Inlines.Add(hubtx.Text);
            }
            else if (y3s1grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y3s1grid.Children.Add(tb);
                Grid.SetRow(tb, y31);
                y31++;
                tb.Inlines.Add(hubtx.Text);
            }
            else if (y3s2grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y3s2grid.Children.Add(tb);
                Grid.SetRow(tb, y32);
                y32++;
                tb.Inlines.Add(hubtx.Text);
            }
            else if (y4s1grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y4s1grid.Children.Add(tb);
                Grid.SetRow(tb, y41);
                y41++;
                tb.Inlines.Add(hubtx.Text);
            }
            else if (y4s2grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y4s2grid.Children.Add(tb);
                Grid.SetRow(tb, y42);
                y42++;
                tb.Inlines.Add(hubtx.Text);
            }
        }


        /*private void majortx_TextChanged(object sender, TextChangedEventArgs e)
        {
            while (majortx.Text == GetMajors())
                ListBoxCourses.Items = GetCourses();
                ListBoxHUB.Items = GetHubCourses();
        }
        */

    }
}
