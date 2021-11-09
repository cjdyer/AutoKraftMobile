using AutoKraftMobile.ViewModels;
using AutoKraftMobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AutoKraftMobile
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }
    }
}
