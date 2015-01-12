using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace KeithsApp
{
    public partial class AmericanoPage : PhoneApplicationPage
    {
        public AmericanoPage()
        {
            InitializeComponent();
        }

        private void AmericanoNextbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EspressoPage.xaml", UriKind.Relative));
        }
    }
}