using CreatingLayouts.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace CreatingLayouts
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

        private void ClickHome_Click(object sender, RoutedEventArgs e)
        {
            Home.Visibility = Visibility.Visible;
            About.Visibility = Visibility.Hidden;
        }

        private void ClickAbout_Click(object sender, RoutedEventArgs e)
        {
            Home.Visibility = Visibility.Hidden;
            About.Visibility = Visibility.Visible;
        }
    }
}
