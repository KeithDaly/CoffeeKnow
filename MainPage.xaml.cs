using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using KeithsApp.Resources;

namespace KeithsApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Americanobtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AmericanoPage.xaml", UriKind.Relative));
        }

        private void Espressobtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EspressoPage.xaml", UriKind.Relative));
        }

        private void Mochabtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MochaPage.xaml", UriKind.Relative));
        }

        private void Cappucccinobtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CappuccinoPage.xaml", UriKind.Relative));
        }

        private void FlatWhitebtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/FlatWhitePage.xaml", UriKind.Relative));
        }

        private void Lattebtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/LattePage.xaml", UriKind.Relative));
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}