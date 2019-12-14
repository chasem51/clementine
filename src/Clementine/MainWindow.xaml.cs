using autocompletetextboxprac;
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
            if (y1s1grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y1s1grid.Children.Add(tb);
                Grid.SetRow(tb, y11);
                y11++;
                tb.Margin = new Thickness(20);
                tb.Inlines.Add(new Run(coursetx.Text) { FontWeight = FontWeights.Bold });
            }
            else if (y1s2grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y1s2grid.Children.Add(tb);
                Grid.SetRow(tb, y12);
                y12++;
                tb.Margin = new Thickness(20);
                tb.Inlines.Add(new Run(coursetx.Text) { FontWeight = FontWeights.Bold });
            }
            else if (y2s1grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y2s1grid.Children.Add(tb);
                Grid.SetRow(tb, y21);
                y21++;
                tb.Margin = new Thickness(20);
                tb.Inlines.Add(new Run(coursetx.Text) { FontWeight = FontWeights.Bold });
            }
            else if (y2s2grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y2s2grid.Children.Add(tb);
                Grid.SetRow(tb, y22);
                y22++;
                tb.Margin = new Thickness(20);
                tb.Inlines.Add(new Run(coursetx.Text) { FontWeight = FontWeights.Bold });
            }
            else if (y3s1grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y3s1grid.Children.Add(tb);
                Grid.SetRow(tb, y31);
                y31++;
                tb.Margin = new Thickness(20);
                tb.Inlines.Add(new Run(coursetx.Text) { FontWeight = FontWeights.Bold });
            }
            else if (y3s2grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y3s2grid.Children.Add(tb);
                Grid.SetRow(tb, y32);
                y32++;
                tb.Margin = new Thickness(20);
                tb.Inlines.Add(new Run(coursetx.Text) { FontWeight = FontWeights.Bold });
            }
            else if (y4s1grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y4s1grid.Children.Add(tb);
                Grid.SetRow(tb, y41);
                y41++;
                tb.Margin = new Thickness(20);
                tb.Inlines.Add(new Run(coursetx.Text) { FontWeight = FontWeights.Bold });
            }
            else if (y4s2grid.Visibility == Visibility.Visible)
            {
                TextBlock tb = new TextBlock();
                y4s2grid.Children.Add(tb);
                Grid.SetRow(tb, y42);
                y42++;
                tb.Margin = new Thickness(20);
                tb.Inlines.Add(new Run(coursetx.Text) {FontWeight = FontWeights.Bold});
            }
        }

        private void majortx_KeyUp(object sender, KeyEventArgs e)
        {
            bool found = false;
            var border = (resultStack.Parent as ScrollViewer).Parent as Border;
            var data = DataBase.ReturnMajor();

            string query = (sender as TextBox).Text;

            resultStack.Children.Clear();

            foreach (var obj in data)
            {
                if (obj.ToLower().StartsWith(query.ToLower()))
                {
                    addItem(obj);
                    found = true;
                }
            }

            if (!found)
            {
                resultStack.Children.Add(new TextBlock() { Text = "No results found." });
            }
        }

        private void addItem(string text)
        {
            TextBlock block = new TextBlock();

            block.Text = text;

            block.Margin = new Thickness(2, 3, 2, 3);
            block.Cursor = Cursors.Hand;

            block.MouseLeftButtonUp += (sender, e) =>
            {
                majortx.Text = (sender as TextBlock).Text;
            };

            block.MouseEnter += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.PeachPuff;
            };

            block.MouseLeave += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.Transparent;
            };

            resultStack.MouseLeave += (sender, e) =>
            {
                resultStack.Visibility = Visibility.Collapsed;
            };

            majortx.MouseEnter += (sender, e) =>
            {
                resultStack.Visibility = Visibility.Visible;
            };

            resultStack.Children.Add(block);

        }

        private void coursetx_KeyUp(object sender, KeyEventArgs e)
        {
            string userinput = majortx.Text;
            bool found = false;
            var border = (resultStack2.Parent as ScrollViewer).Parent as Border;
            var data = DataBase.ReturnMajor_courses(userinput);

            string query = (sender as TextBox).Text;

            resultStack2.Children.Clear();

            foreach (var obj in data)
            {
                if (obj.ToLower().StartsWith(query.ToLower()))
                {
                    addItem2(obj);
                    found = true;
                }
            }

            if (!found)
            {
                resultStack2.Children.Add(new TextBlock() { Text = "No results found." });
            }
        }

        private void addItem2(string text)
        {
            TextBlock block = new TextBlock();

            block.Text = text;

            block.Margin = new Thickness(2, 3, 2, 3);
            block.Cursor = Cursors.Hand;

            block.MouseLeftButtonUp += (sender, e) =>
            {
                coursetx.Text = (sender as TextBlock).Text;
            };

            block.MouseEnter += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.PeachPuff;
            };

            block.MouseLeave += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.Transparent;
            };

            resultStack2.MouseLeave += (sender, e) =>
            {
                resultStack2.Visibility = Visibility.Collapsed;
            };

            coursetx.MouseEnter += (sender, e) =>
            {
                resultStack2.Visibility = Visibility.Visible;
            };

            resultStack2.Children.Add(block);

            string userinput = majortx.Text;
        }

        //Add courses from current major to ListBoxCourses

    }
}
