using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;

namespace Rest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        HttpClient _client;
        readonly string uri = "http://dfe44795.ngrok.io/profile";

        public ProfilePage()
        {
            
            InitializeComponent();
        }

        private async void LoadProfile()
        { 
            _client = new HttpClient();
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(uri),
                Method = HttpMethod.Get,
                Headers = {
                    {HttpRequestHeader.Authorization.ToString(), "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJsdW1lbi1qd3QiLCJzdWIiOjEsImlhdCI6MTU3MjI2NjI2NCwiZXhwIjoxNTcyMjY5ODY0fQ.yCR8hHs4wiDoSqF9e4KHl3EZPpLf6fIWTZKBVgtbQd4" },
                    {HttpRequestHeader.Accept.ToString(), "application/json" },
                    {"X-Version", "1" }
                
                },
            };
            var response = await _client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                userData.Text = content;
            }           

        }
    }
}