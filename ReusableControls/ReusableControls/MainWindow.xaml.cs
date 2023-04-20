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

namespace ReusableControls
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

        private void JoinBasicClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("u joined to basic subscription");
        }

        private void JoinProClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("u joined to pro subscription");
            
        }
        private void JoinEnterpriseClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("u joined to enterprise subscription");
        }

    }
}
