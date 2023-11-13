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

namespace cagliostroBooks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private void FirstButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("clicked!");
        } //Button to send user to home page after logging in

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("clicked!");
        }// button to send user to admin login page

        public MainWindow()
        {
            InitializeComponent();

            
        }
    }
}
