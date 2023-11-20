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

namespace cagliostroBooks.Views.Pages
{
    
    public partial class AdminLogin : Page
    {

        private void ToAdminHomePage_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Testing Testing 1 2 3!");
        }



        public AdminLogin()
        {
            InitializeComponent();
        }
    }
}
