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
    public partial class EspressoPage : PhoneApplicationPage
    {
        public EspressoPage()
        {
            InitializeComponent();
        }

        private void EspressoNextbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MochaPage.xaml", UriKind.Relative));
        }
    }
}