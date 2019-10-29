using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Rest.Services
{
    public interface IApiService
    {
        HttpClient Client { get;}
        Task<HttpResponseMessage> GetRequest(string affix);
        Task<HttpResponseMessage> PostRequest(string affix, string json);
        string RequestUri { get; }

    }
}
