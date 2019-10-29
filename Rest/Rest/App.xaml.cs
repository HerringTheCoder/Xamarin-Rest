using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rest.Services;
using Rest.Views;

namespace Rest
{
    public partial class App : Application
    {        
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<ApiService>();
            MainPage = new MainPage();
            Current.Properties["uri"] = "http://0cba7345.ngrok.io";
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
