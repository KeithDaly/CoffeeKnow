﻿using System;
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
    public partial class MochaPage : PhoneApplicationPage
    {
        public MochaPage()
        {
            InitializeComponent();
        }

        private void MochaNextbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CappuccinoPage.xaml", UriKind.Relative));
        }
    }
}