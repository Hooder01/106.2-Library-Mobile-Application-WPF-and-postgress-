﻿using System;
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
            MessageBox.Show("Testing Testing 1 2 3!");
        }

        private void ToUserHomePage_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Testing Testing 1 2 3!");
        }

        public UserLogin()
        {
            InitializeComponent();

        }
    }
}
