using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsPinView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PinAuthPage();
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
