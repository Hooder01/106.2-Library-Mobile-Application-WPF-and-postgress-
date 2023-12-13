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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cagliostroBooks.Views.Pages
{
    /// <summary>
    /// Interaction logic for UserSettings.xaml
    /// </summary>
    public partial class UserSettings : Page
    {
        public UserSettings()
        {
            InitializeComponent();
        }

        private void BackToHome_OnClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            NavigationService.Navigate(new Uri(@"Views\Pages\UserHomePage.xaml", UriKind.Relative));
        } 
        // _Sends user back to homepage_


        private void ToDarkMode_Button(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            NavigationService.Navigate(new Uri(@"Views\Pages\UserSettingsDM.xaml", UriKind.Relative));
        }
        // _Sends user to DarkMode version of settings page_


        private void StartGearRotation()
        {
            DoubleAnimation rotationAnimation = new DoubleAnimation();
            rotationAnimation.From = 0;
            rotationAnimation.To = 360;
            rotationAnimation.RepeatBehavior = RepeatBehavior.Forever;
            rotationAnimation.Duration = new Duration(TimeSpan.FromSeconds(10)); 

            RotateTransform rotateTransform = new RotateTransform();
            //gearImage.RenderTransform = rotateTransform;

            //gearImage.RenderTransformOrigin = new Point(0.5, 0.5); 

            rotateTransform.BeginAnimation(RotateTransform.AngleProperty, rotationAnimation);
        }
        // _Code behind the Rotating settings icon_ \\ (BUG!!!)

    }
}
