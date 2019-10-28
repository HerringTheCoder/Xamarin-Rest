using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using FFImageLoading.Forms;



namespace Rest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        HttpClient _client;
        Models.User currentUser = new Models.User();
        readonly string uri = "http://dfe44795.ngrok.io/auth/login";
        public LoginPage()
        {
            InitializeComponent();
           
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            currentUser.Email = LoginEntry.Text;
            currentUser.Password = PasswordEntry.Text;
            _client = new HttpClient();
           var json = JsonConvert.SerializeObject(currentUser);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var uri = new Uri(string.Format(this.uri, string.Empty));
            waitingGif.IsVisible = true;
            HttpResponseMessage response = await _client.PostAsync(uri,content);
            
            TokenLabel.Text = await response.Content.ReadAsStringAsync();
            Application.Current.Properties["token"] = TokenLabel.Text;
            waitingGif.Source = "tick.png";

        }
    }
}