﻿using FoodDeliveryApp.Constants;
using FoodDeliveryApp.Services;
using FoodDeliveryApp.Views;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FoodDeliveryApp
{
    public partial class AppShellDriver : Xamarin.Forms.Shell
    {
        public AppShellDriver()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(OrderInfoPage), typeof(OrderInfoPage));
            Routing.RegisterRoute(nameof(ProductInOrderPage), typeof(ProductInOrderPage));
            Preferences.Set("LocationServiceRunning", false);
        }


    }
}