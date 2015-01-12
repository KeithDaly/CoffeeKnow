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
    public partial class CappuccinoPage : PhoneApplicationPage
    {
        public CappuccinoPage()
        {
            InitializeComponent();
        }

        private void CappuccinoNextbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/FlatWhitePage.xaml", UriKind.Relative));
        }
    }
}