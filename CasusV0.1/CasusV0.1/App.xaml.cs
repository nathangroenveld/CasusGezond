﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CasusV0._1
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public App(string databaseLocation)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());

            DatabaseLocation = databaseLocation;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
