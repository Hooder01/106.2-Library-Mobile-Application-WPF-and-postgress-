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


        private void RotateImage()
        {
            RotateTransform rotateTransform = new RotateTransform();

            RenderTransform = rotateTransform;

            DoubleAnimation animation = new DoubleAnimation
            {
                From = 0, To = 360, Duration = TimeSpan.FromSeconds(5), 

                RepeatBehavior = RepeatBehavior.Forever
            };

            rotateTransform.BeginAnimation(RotateTransform.AngleProperty, animation);
        }
        // _Code behind the Rotating settings icon_ \\ (BUG!!!)

    }
}
