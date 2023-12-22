using lab15.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using lab15.Views;

namespace lab15
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AirbnbPage();
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
