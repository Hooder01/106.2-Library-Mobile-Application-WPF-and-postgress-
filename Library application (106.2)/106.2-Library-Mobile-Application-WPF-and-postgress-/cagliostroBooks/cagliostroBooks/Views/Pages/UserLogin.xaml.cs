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
    /// <summary>
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Page
    {

        private void ToAdminLoginPage_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            NavigationService.Navigate(new Uri(@"Views\Pages\AdminLogin.xaml", UriKind.Relative));
        }



        private void ToUserHomePage_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            NavigationService.Navigate(new Uri(@"Views\Pages\UserHomePage.xaml", UriKind.Relative));
        }

        public UserLogin()
        {
            InitializeComponent();

        }
    }
}
