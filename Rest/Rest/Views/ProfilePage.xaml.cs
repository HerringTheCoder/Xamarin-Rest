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
using Rest.ViewModels;

namespace Rest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {        
        private ProfileViewModel MyProfileViewModel = new ProfileViewModel();
        public ProfilePage()
        {            
            InitializeComponent();
            BindingContext = MyProfileViewModel;

        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            MyProfileViewModel.LoadProfile();
        }
    }
}


