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
    /// Interaction logic for UserSettingsDM.xaml
    /// </summary>
    public partial class UserSettingsDM : Page
    {
        public UserSettingsDM()
        {
            InitializeComponent();
        }


        private void ToHomePageDM_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            NavigationService.Navigate(new Uri(@"Views\Pages\UserHomePageDM.xaml", UriKind.Relative));
        }


        private void ToLightMode_Button(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            NavigationService.Navigate(new Uri(@"Views\Pages\UserSettings.xaml", UriKind.Relative));
        }
    }
}
