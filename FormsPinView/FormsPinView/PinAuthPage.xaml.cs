using Android.App;
using Android.Content;
using Android.Service.Voice;
using Android.Views.InputMethods;
using FormsPinView.ViewModels;
using System;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsPinView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PinAuthPage : ContentPage
    {
        public PinAuthPage()
        {
            InitializeComponent();
            var viewModel = new PinAuthViewModel();
            base.BindingContext = viewModel;
        }

        private void OnTapped(object sender, EventArgs e)
        {
            PinCode.Focus();
        }
    }
}