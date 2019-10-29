using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using FFImageLoading.Forms;
using Rest.ViewModels;



namespace Rest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {              
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = loginViewModel;
        }
        private LoginViewModel loginViewModel = new LoginViewModel();

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            waitingGif.IsVisible = true;
            loginViewModel.AttemptLogin();            
            waitingGif.Source = "tick.png";

        }
    }
}