using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Threading.Tasks;


namespace Rest.Services
{
    class ApiService : IApiService
    {
        public HttpClient Client { get; }
       

        public string RequestUri { get; }
        
        public ApiService()
        {
            this.RequestUri = (string)Application.Current.Properties["uri"];
            this.Client = new HttpClient();
        }
        public async Task<HttpResponseMessage> GetRequest(string affix)
        {
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(RequestUri+affix),
                Method = HttpMethod.Get,
                Headers = {
                    {HttpRequestHeader.Authorization.ToString(), "Bearer"+" "+ Application.Current.Properties["token"] },
                    {HttpRequestHeader.Accept.ToString(), "application/json" },
                    {"X-Version", "1" }

                },
            };
            var response = await this.Client.SendAsync(request);
            return response;
        }

        public async Task<HttpResponseMessage> PostRequest(string affix, string json)
        {
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(RequestUri+affix),
                Method = HttpMethod.Post,
                Headers =
                {
                    { HttpRequestHeader.ContentType.ToString(), "application/json" },
                    {HttpRequestHeader.Accept.ToString(), "application/json" },
                    {"X-Version", "1" }
                },
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
        };
            var response = await Client.SendAsync(request);
            return response;

        }
    }
}
