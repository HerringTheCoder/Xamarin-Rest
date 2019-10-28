using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Rest.Services
{
    interface IApiClient
    {
        HttpClient _client { get; set; }

    }
}
