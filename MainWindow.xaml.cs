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

namespace wpf_Calculator
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

        private void Add(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(numerA.Text);
            int b = Convert.ToInt32(numerB.Text);
            result.Content = a + b;
        }

        private void Subtract(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(numerA.Text);
            int b = Convert.ToInt32(numerB.Text);
            result.Content = a - b;
        }

        private void Multiply(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(numerA.Text);
            int b = Convert.ToInt32(numerB.Text);
            result.Content = a * b;
        }

        private void Divide(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(numerA.Text);
            int b = Convert.ToInt32(numerB.Text);
            result.Content = a / b;
        }
    }
}
