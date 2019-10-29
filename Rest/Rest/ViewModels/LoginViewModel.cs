using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Rest.Models;
using Xamarin.Forms;

namespace Rest.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        private User _user = new User();
        public User AttemptingUser
        {
            get { return _user; }
            set
            {
                SetProperty(ref _user, value);
            }
        }
        //todo: global config variable
        private string _response = null;
        public string Response { 
            get { return _response; }
            set
            {
                SetProperty(ref _response, value);
            }
}
public LoginViewModel()
        {
            this.AttemptingUser = new User();
            Title = "Login";
            AttemptingUser.Email = "maxime.orn@gmail.com";
            AttemptingUser.Password = "123456";
        }

        public async void AttemptLogin()
        {
            
            var json = JsonConvert.SerializeObject(AttemptingUser);
            var response = await MyApiService.PostRequest("/auth/login/", json);
            this.Response = await response.Content.ReadAsStringAsync();
            var accessToken = JsonConvert.DeserializeObject<AccessToken>(this.Response).Value;
            Application.Current.Properties["token"] = accessToken;
            this.Response = accessToken;            
        }
    }
}
