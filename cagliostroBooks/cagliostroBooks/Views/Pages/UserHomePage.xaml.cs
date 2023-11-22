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
    /// Interaction logic for UserHomePage.xaml
    /// </summary>
    public partial class UserHomePage : Page
    {
        public UserHomePage()
        {
            InitializeComponent();
        }

        private void ToSettingsPage_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            NavigationService.Navigate(new Uri(@"Views\Pages\UserSettings.xaml", UriKind.Relative));
        } // _On click will send user to profile settings page_

        private void Book01Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Title: Doctor Who The Stones Of Blood \n BN: 000010001 \n Availability: available!");
        }

        private void Book02Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Title: Alexander Hamilton \n BN: 020050001 \n Availability: available!");
        }


        private void Book03Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Title: Scooby Apocalypse vol01 \n BN: 020030002 \n Availability: Taken!");
        }

        // _On click will give user information of novel via a messeage box (also will have a table in postSQL)_
    }
}
