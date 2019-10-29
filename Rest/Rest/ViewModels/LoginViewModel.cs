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
        public User currentUser = new User();
         //todo: global config variable
        public string Response
        { get; set; }            
        public LoginViewModel()
        {
            currentUser.Email = "maxime.orn@gmail.com";
            currentUser.Password = "123456";
        }

        public async void AttemptLogin()
        {
            
            var json = JsonConvert.SerializeObject(currentUser);                        
            var response = await MyApiService.PostRequest("/auth/login/", json);            
            this.Response = await response.Content.ReadAsStringAsync();
            Application.Current.Properties["token"] = this.Response;
            
        }
    }
}
