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
    /// Interaction logic for UserHomePageDM.xaml
    /// </summary>
    public partial class UserHomePageDM : Page
    {
        public UserHomePageDM()
        {
            InitializeComponent();
        }


        private void ToSettingsPageDM_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            NavigationService.Navigate(new Uri(@"Views\Pages\UserSettingsDM.xaml", UriKind.Relative));
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


        private void Book04Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Title: Holy Bible \n BN 02300001 \n Availability: available!");
        }

        private void Book05Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Title: The Wager \n BN 10002201 \n Availability: available!");
        }

        private void Book06Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Title: RUBY Programming \n BN 04004021 \n Availability: available!");
        }


        private void Book07Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Title: Nier \n BN 04004021 \n Availability: Taken!");
        }


        private void Book08Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Title: In Science \n BN 00109001 \n Availability: available!");
        }


        private void Book09Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Title: Film Lighting \n BN 10003400 \n Availability: available!");
        }

    }
}
