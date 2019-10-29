using Newtonsoft.Json;
using Rest.Models;
using Xamarin.Forms;


namespace Rest.ViewModels
{
    class ProfileViewModel : BaseViewModel
    {
        string _response = null;
        public string Response
        {
            get { return _response; }
            set
            {
                SetProperty(ref _response, value);
            }
        }

        private Profile _profile = new Profile();
        public Profile ProfileData
        {
            get { return _profile; }
            set
            {
                SetProperty(ref _profile, value);
            }
        }

       
        public ProfileViewModel()
           {
            LoadProfile();
            this.ProfileData.Email = "Empty email";
            this.ProfileData.Name = "Empty name"; 
            }
        public async void LoadProfile()
        {
            var response = await MyApiService.GetRequest("/profile/");
            this.Response = await response.Content.ReadAsStringAsync();
            this.ProfileData = JsonConvert.DeserializeObject<Profile>(this.Response);            

        }
    }
}
